using Procurement_System.Models.Forms.BookKeeperMenus;
using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
using Procurement_System.Models.Users;
using Procurement_System.Services;
using Procurement_System.Services.Authentication;
using Procurement_System.Services.DocumentGenerator;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.PurchaseOrders
{
    public partial class CreatePO : Form
    {
        public static SupplierModel SelectedSupplier;
        private QuotationItem _selectedItem;
        public static Quotation SelectedQuotation;
        private Product _selectedProduct;
        public static List<QuotationItem> QuotationItems;
        private List<QuotationItem> _toDeleteItems;
        public static CreatePO IsChild = null;
        private List<ProcurementDocuments.DirectPurchaseOrder> _directPOList;
        private BackgroundWorker _worker, _itemWorker, _directPOWorker;
        private Helper _dbHelper;
        private EmployeeModel _model;
        private DataTable _itemTableData;
        private List<Product> _poProducts;
        private string _query;
        public CreatePO(EmployeeModel model = null)
        {
            InitializeComponent();
            _model = model;
            _poProducts = new List<Product>();
            IsChild = this;
            _toDeleteItems = new List<QuotationItem>();
            _directPOList = new List<ProcurementDocuments.DirectPurchaseOrder>();
            _dbHelper = new Helper();
            _itemTableData = new DataTable();
            _initializeWorkers();
            _loadStartUp();

        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _itemWorker = new BackgroundWorker();
            _directPOWorker = new BackgroundWorker();

            _itemWorker.DoWork += (s, e) =>
            {

                _query = $"SELECT SI.ItemID, SI.ItemName, SUM(SII.Stocks) AS 'Total Stocks' FROM " +
                $"SupplierItem SI INNER JOIN SupplierItemDetails SII ON SI.ItemID = " +
                $"SII.ItemID WHERE SI.Archived = 0 GROUP BY SI.ItemID, SI.ItemName";
                _itemTableData = _dbHelper.GetData(_query);

            };
            _itemWorker.RunWorkerCompleted += (s, e) =>
            {
                _loadItems();
            };

            _directPOWorker.DoWork += (s, e) =>
            {
                string parentPath = (string)e.Argument;
                _processDirectPOItems(parentPath);

            };

            _directPOWorker.RunWorkerCompleted += (s, e) =>
            {

                _message("Purchase Orders Generated Successfully");
                _clearValues();

            };
        }

        private void _clearValues()
        {
            lblQuoteID.Text = "";
            lblItemID.Text = "";
            lblItemName.Text = "";
            txtQuantity.Text = "";
            txtColor.Text = "";
            txtRemarks.Text = "";
            lblActualSuppName.Text = "";
            lblActualAddress.Text = "";
            ActualEmail.Text = "";
            lblActualPaymentName.Text = "";
            lblActualDiscount.Text = "";
            lblActualValidity.Text = "";
            lblUnitPrice.Text = "";
            dgvrItemList.DataSource = null;
            dgvrItemList.Rows.Clear();
            btnGeneratePO.Enabled = false;
            btnGeneratePO.BackColor = SystemColors.Control;
            if (_poProducts != null)
                _poProducts.Clear();
            if (_itemTableData != null)
                _itemTableData.Clear();
            if (QuotationItems != null)
            {
                QuotationItems.Clear();
            }
            else
            {

                QuotationItems = new List<QuotationItem>();

            }
        }

        private void _loadStartUp()
        {

            if (SelectedSupplier == null) return;
            lblActualSuppName.Text = SelectedSupplier.SupplierName;
            lblActualAddress.Text = SelectedSupplier.Address;
            ActualEmail.Text = SelectedSupplier.Email;
            lblActualPaymentName.Text = SelectedSupplier.PaymentTerms.PaymentTermName;

            lblActualDiscount.Text = SelectedSupplier.PaymentTerms.Discount.ToString();
            lblActualValidity.Text = SelectedSupplier.PaymentTerms.DiscountValidity.ToString();
            if (cbDirectPO.Checked)
            {

                return;
            }
            if (SelectedSupplier != null && SelectedQuotation != null && SelectedSupplier != null)
            {
                lblQuoteID.Text = SelectedQuotation.QuotationID.ToString();
                _loadTable();

            }

        }
        private void _loadItems(List<Product> list = null)
        {

            if (_itemTableData.Columns.Count == 0)
            {

                _itemTableData.Columns.Add("Product ID");
                _itemTableData.Columns.Add("Item ID");
                _itemTableData.Columns.Add("Item Name");
                _itemTableData.Columns.Add("Color");
                _itemTableData.Columns.Add("Quantity");
                _itemTableData.Columns.Add("Unit Price");
                _itemTableData.Columns.Add("Supplier Name");

            }

            _itemTableData.Rows.Clear();
            if (_poProducts.Count != 0)
            {

                _poProducts = _poProducts.GroupBy(x => new { x.ProductID, x.ItemID, x.Color, x.ItemSupplier.SupplierID }).Select(x => x.First()).ToList();
            }

            if (list == null)
            {
                foreach (var product in _poProducts)
                {
                    _itemTableData.Rows.Add(product.ProductID, product.ItemID, product.ItemName, product.Color,
                        product.Quantity, product.Price, product.ItemSupplier.SupplierName);
                }
            }
            else
            {
                foreach (var product in list)
                {
                    _itemTableData.Rows.Add(product.ProductID, product.ItemID, product.ItemName, product.Color,
                        product.Quantity, product.Price, product.ItemSupplier.SupplierName);
                }
            }


            dgvrItemList.DataSource = _itemTableData;
            btnGeneratePO.Enabled = _poProducts.Count != 0;

        }
        private void _loadTable(List<QuotationItem> list = null)
        {
            BindingList<QuotationItem> bindingList;
            dgvrItemList.Rows.Clear();
            if (list == null)
                bindingList = new BindingList<QuotationItem>(QuotationItems.ToList());
            else
                bindingList = new BindingList<QuotationItem>(list);
            dgvrItemList.DataSource = bindingList;
            dgvrItemList.ClearSelection();
            dgvrItemList.Columns["ItemCategory"].Visible = false;
            dgvrItemList.Columns["ItemType"].Visible = false;
            btnGeneratePO.Enabled = QuotationItems.Count != 0;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (!cbDirectPO.Checked)
            {
                var compareQuote = new CompareQuotation(_model);
                compareQuote.StartPosition = FormStartPosition.CenterScreen;
                compareQuote.ShowDialog();
            }
            else
            {
                var supplierWindow = new SupplierItemList(_addPOProduct);
                supplierWindow.StartPosition = FormStartPosition.CenterScreen;
                supplierWindow.ShowDialog();
                _loadItems();
            }
            _loadStartUp();

        }

        private void _addPOProduct(Product product)
        {
            _poProducts.Add(product);
        }
        private void _getSupplier(SupplierModel model)
        {
            SelectedSupplier = model;
        }

        private void _message(string message, bool isSuccess = true)
        {
            if (isSuccess)
                lblMessage.ForeColor = System.Drawing.Color.Green;
            else
                lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = message;
        }

        private void dgvrItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!cbDirectPO.Checked)
            {
                try
                {
                    var selectedItem = (QuotationItem)dgvrItemList.Rows[e.RowIndex].DataBoundItem;
                    lblItemID.Text = selectedItem.QuotationItemID.ToString();
                    lblItemName.Text = selectedItem.ItemName;
                    txtColor.Text = selectedItem.Color;
                    lblUnitPrice.Text = CurrencyFormat.FormatCurrency(selectedItem.UnitPrice);
                    _selectedItem = selectedItem;


                }
                catch (Exception)
                {

                }
            }
            else
            {

                var selectedItem = new Product();
                selectedItem.ProductID = Convert.ToInt32(dgvrItemList.Rows[e.RowIndex].Cells[0].Value.ToString());
                selectedItem.ItemID = Convert.ToInt32(dgvrItemList.Rows[e.RowIndex].Cells[1].Value.ToString());
                selectedItem.ItemName = dgvrItemList.Rows[e.RowIndex].Cells[2].Value.ToString();
                selectedItem.Color = dgvrItemList.Rows[e.RowIndex].Cells[3].Value.ToString();
                selectedItem.Quantity = Convert.ToInt32(dgvrItemList.Rows[e.RowIndex].Cells[4].Value.ToString());
                selectedItem.Price = Convert.ToDouble(dgvrItemList.Rows[e.RowIndex].Cells[5].Value.ToString());
                selectedItem.ItemSupplier = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(x => x.SupplierName ==
                dgvrItemList.Rows[e.RowIndex].Cells[6].Value.ToString());
                _selectedProduct = selectedItem;
                _setProductInfo();

            }
            btnDelete.Enabled = true;
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            _message("");
        }

        private void _setProductInfo()
        {
            lblItemID.Text = _selectedProduct.ItemID.ToString();
            lblItemName.Text = _selectedProduct.ItemName;
            txtColor.Text = _selectedProduct.Color;
            lblUnitPrice.Text = CurrencyFormat.FormatCurrency(_selectedProduct.Price);
            txtQuantity.Text = _selectedProduct.Quantity.ToString();
            _setSupplierInfo();
        }

        private void _setSupplierInfo()
        {
            var supplier = _selectedProduct.ItemSupplier;
            lblActualSuppName.Text = supplier.SupplierName;
            lblActualAddress.Text = supplier.Address;
            ActualEmail.Text = supplier.Email;
            lblActualPaymentName.Text = supplier.PaymentTerms.PaymentTermName;
            lblActualDiscount.Text = supplier.PaymentTerms.Discount.ToString();
            lblActualValidity.Text = supplier.PaymentTerms.DiscountValidity.ToString();

        }

        private bool _checkInput()
        {
            try
            {

                if (txtQuantity.Text.Trim() == "")
                {
                    throw new Exception();
                }
                if (txtQuantity.Text.Trim().Contains("e") || txtQuantity.Text.Trim().Contains("E"))
                {
                    throw new Exception();
                }
                if (Convert.ToDouble(txtQuantity.Text) <= 0)
                {

                    _message("Quantity must be greater than 0", false);
                    return false;

                }
                Convert.ToDouble(txtQuantity.Text);
                return true;
            }
            catch (Exception)
            {
                if (txtQuantity.Text == "")
                {
                    _message("");
                    return false;
                }
                _message("Please enter a valid quantity", false);
                return false;
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_checkInput()) return;
            if (!cbDirectPO.Checked)
            {
                var index = QuotationItems.FindIndex(item => item.QuotationItemID == _selectedItem.QuotationItemID);
                if (index != -1)
                {
                    _selectedItem.Quantity = Convert.ToInt32(txtQuantity.Text);
                    _selectedItem.Color = txtColor.Text.Trim();
                    _selectedItem.TotalPrice = _selectedItem.UnitPrice * _selectedItem.Quantity;
                    QuotationItems[index] = _selectedItem;
                    _loadTable();
                }
            }
            else
            {
                var index = _poProducts.FindIndex(item => item.ItemID == _selectedProduct.ItemID &&
                item.ItemSupplier.SupplierID == _selectedProduct.ItemSupplier.SupplierID &&
                item.Color == _selectedProduct.Color && item.ItemName == _selectedProduct.ItemName);
                if (index != -1)
                {
                    _selectedProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
                    _poProducts[index] = _selectedProduct;
                    _loadItems();
                }
            }

        }

        private void btnGeneratePO_Click(object sender, EventArgs e)
        {
            //Create a folder dialog
            if (!cbDirectPO.Checked)
            {


                var folderDialog = new FolderBrowserDialog();
                folderDialog.Description = "Please enter the folder you want to save in";
                folderDialog.ShowNewFolderButton = true;
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    var purchaseOrder = new QuotationPurchaseOrder();
                    purchaseOrder.Remarks = txtRemarks.Text.Trim();
                    purchaseOrder.CreatedDate = DateTime.Now;
                    purchaseOrder.Employee = _model;
                    purchaseOrder.SelectedQuotation.SelectedSupplier = SelectedSupplier;
                    purchaseOrder.SelectedQuotation.Quotation = SelectedQuotation;
                    purchaseOrder.SelectedQuotation.Items = QuotationItems;
                    //Get folder from folderdialog
                    var folder = folderDialog.SelectedPath;
                    _message("Generating Purchase Order...");
                    _worker.DoWork += (s, args) =>
                    {
                        new PurchaseOrderGenerator().GeneratePurchaseOrder(new Services.ViewPO().GetLatestPOID(), SelectedSupplier.SupplierID, folder);
                    };
                    _worker.RunWorkerCompleted += (s, args) =>
                    {
                        //check if theres any error on the background worker
                        if (args.Error != null)
                        {
                            _message($"Error generating purchase order {args.Error.Message}", false);

                            return;
                        }
                        _message("Purchase Order Generated Successfully", true);
                        _clearValues();
                    };

                    _generatePurchaseOrder(_getUserLogin(_model), purchaseOrder);

                }
            }
            else
            {
                if (_poProducts.Any(item => item.Quantity == 0))
                {
                    _message("Invalid PO please check the quantities of all items.", false);
                }
                else
                {
                    var folderDialog = new FolderBrowserDialog();
                    folderDialog.Description = "Please enter the folder you want to save in";
                    folderDialog.ShowNewFolderButton = true;
                    folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        var parentPath = folderDialog.SelectedPath;

                        _message("Generating Purchase Orders Please wait...");
                        _directPOWorker.RunWorkerAsync(parentPath);

                    }
                }
            }

        }

        private void _processDirectPOItems(string parentPath)
        {

            //create a new purchase order
            var purchaseOrder = new ProcurementDocuments.DirectPurchaseOrder();
            purchaseOrder.Remarks = txtRemarks.Text.Trim();
            purchaseOrder.CreatedDate = DateTime.Now;
            purchaseOrder.Employee = _model;
            purchaseOrder.DirectPurchaseOrderDetail = new List<ProcurementDocuments.DirectPurchaseOrder.DirectPurchaseOrderDetails>();
            //find all unique suppliers in the list
            var uniqueSuppliers = _poProducts.Select(item => item.ItemSupplier.SupplierID).Distinct().ToList();
            //loop through each supplier
            foreach (var supplier in uniqueSuppliers)
            {
                //get all items from the supplier
                var items = _poProducts.Where(item => item.ItemSupplier.SupplierID == supplier).ToList();
                var directPODetails = new ProcurementDocuments.DirectPurchaseOrder.DirectPurchaseOrderDetails();
                directPODetails.Supplier = items[0].ItemSupplier;
                directPODetails.Items = items;
                directPODetails.employee = _model;
                purchaseOrder.DirectPurchaseOrderDetail.Add(directPODetails);

            }
            //generate the purchase order
            _generateDirectPO(EmployeeFactory.DirectPOAction(_model), purchaseOrder);
            int id = new ViewDirectPO().GetLatestPOID();
            int poID = new ViewDirectPO().GetLatestPODetailsID(id);

            purchaseOrder.DirectPurchaseOrderDetail.ForEach(dpo =>
            {
                var poPath = $"{parentPath}\\PO{DateTime.Now.ToString("dd-MM-yyyy")}\\{dpo.Supplier.SupplierName}";
                string path = Path.Combine(poPath);
                Directory.CreateDirectory(path);
                //generate the purchase order document
                new DirectPurchaseOrderGenerator().GenerateDirectPO(purchaseOrder.ID, dpo.ID, path);
            });



        }

        private void _generateDirectPO(IDirectPOAction directPOAction, ProcurementDocuments.DirectPurchaseOrder purchaseOrder)
        {
            directPOAction.CreatePO(purchaseOrder);
        }


        private IPurchaseOrderAction _getUserLogin(EmployeeModel model)
        {
            var empType = model.getEmployeeType().getType();
            switch (empType)
            {
                case "Sales Staff":
                    return new SalesStaff(model);
                case "Admin Manager":
                    return new AdminManager(model);
                default:
                    return null;
            }
        }
        private void _generatePurchaseOrder(IPurchaseOrderAction purchaseOrderAction, QuotationPurchaseOrder purchaseOrder)
        {
            try
            {
                if (purchaseOrderAction == null) throw new Exception();
                purchaseOrderAction.DeletePOItems(_toDeleteItems, purchaseOrder.SelectedQuotation.SelectedSupplier.SupplierID);
                purchaseOrderAction.CreatePO(purchaseOrder);
                _worker.RunWorkerAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("You are not authorized to perform this action", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _message("Operation Cancelled.", false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvrItemList.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an item to delete");
                return;
            }
            if (!cbDirectPO.Checked)
            {

                var index = QuotationItems.FindIndex(item => item.QuotationItemID == _selectedItem.QuotationItemID);
                if (index != -1)
                {
                    _toDeleteItems.Add(QuotationItems[index]);
                    QuotationItems.RemoveAt(index);
                    _loadTable();
                    _clearTextBox();
                }
            }
            else
            {

                var index = _poProducts.FindIndex(item => item.ItemID == _selectedProduct.ItemID);
                if (index != -1)
                {
                    _poProducts.RemoveAt(index);
                    _loadItems();
                    _clearTextBox();
                }

            }

        }

        private void _clearTextBox()
        {

            lblItemID.Text = "";
            lblItemName.Text = "";
            txtQuantity.Text = "";
            txtColor.Text = "";
            lblUnitPrice.Text = "";
            lblActualSuppName.Text = "";
            lblActualAddress.Text = "";
            ActualEmail.Text = "";
            lblActualPaymentName.Text = "";
            lblActualDiscount.Text = "";
            lblActualValidity.Text = "";

        }

        private void _resetDefault()
        {
            btnView.Text = "View Quotations";
            lblSelQuote.Visible = true;
            lblQuoteID.Visible = true;
        }

        private void dgvrItemList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void CreateQuotePO_FormClosing(object sender, FormClosingEventArgs e)
        {
            SelectedSupplier = null;
            IsChild = null;
        }

        private void txtSearchItem_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearchItem.Text.ToLower().Trim();
            if (!cbDirectPO.Checked)
            {
                if (QuotationItems != null)
                {
                    if (input == "")
                    {
                        _loadTable();
                        return;
                    }

                    var res = QuotationItems.Where(item => item.ItemName.ToLower().Contains(input.ToLower())
                    || item.QuoteID.ToString().Contains(input) || item.QuoteID.ToString().Contains(input)
                    || item.Color.ToLower().Contains(input) || item.Quantity.ToString().Contains(input)
                    || item.UnitPrice.ToString().Contains(input) || item.TotalPrice.ToString().Contains(input)
                    || item.SupplierProvider.SupplierName.ToLower().Contains(input)).ToList();
                    _loadTable(res);
                }


            }
            else
            {

                if (input != "")
                {
                    var list = _poProducts.Where(item => item.ItemName.ToLower().Contains(input.ToLower())
                        || item.ItemID.ToString().Contains(input) || item.ProductID.ToString().Contains(input)
                        || item.Color.ToLower().Contains(input) || item.Quantity.ToString().Contains(input)
                        || item.Price.ToString().Contains(input) || item.TotalPrice.ToString().Contains(input)
                        || item.ItemSupplier.SupplierName.ToLower().Contains(input)).ToList();
                    _loadItems(list);

                }else
                {
                    _loadItems();
                }

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if (_checkInput())
            {
                btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            }
            else
            {
                btnUpdate.BackColor = SystemColors.Control;
            }

            btnUpdate.Enabled = _checkInput();
        }

        private void cbDirectPO_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDirectPO.Checked)
            {
                btnView.Text = "Select Items";
                lblSelQuote.Visible = false;
                lblQuoteID.Visible = false;
            }
            else
            {
                btnView.Text = "View Quotations";
                lblSelQuote.Visible = true;
                lblQuoteID.Visible = true;
            }
            _clearValues();
        }
    }
}
