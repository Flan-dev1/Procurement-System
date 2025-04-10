using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
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
    public partial class CreateGRPO : Form
    {
        private EmployeeModel _model;
        private string _path;
        private GoodsReceiptPO _grpo;
        private QuotationPurchaseOrder _selectedPO;
        private QuotationItem _selectedItem;
        private List<GoodsReceiptPO.GoodsReceiptItem> _grpoItems;
        private List<GoodsReceiptPO.GoodsReceiptItem> _grpoItemslocal = new List<GoodsReceiptPO.GoodsReceiptItem>();
        private List<DGoodsReceipt.GoodsReceiptItem> _dgrpoItems;
        private List<DGoodsReceipt.GoodsReceiptItem> _dgrpoItemslocal = new List<DGoodsReceipt.GoodsReceiptItem>();
        private DGoodsReceipt.GoodsReceiptItem _selectedDGROItem;
        private DGoodsReceipt _dgrpo;
        private GoodsReceiptPO.GoodsReceiptItem _selectedGRPOItem;
        private Product _selectedProduct;
        private BackgroundWorker _worker, _documentWorker, _direcPOWorker;
        private Helper _dbHelper;
        private string _query;
        private ProcurementDocuments.DirectPurchaseOrder _selectedDPO;
        public static ProcurementDocuments.DirectPurchaseOrder SelectedDPOInfo;
        public static DataTable _dPOTable;
        private bool _isExist, _dpoMode = false;
        public CreateGRPO(EmployeeModel model)
        {
            InitializeComponent();
            _clearValues();
            _model = model;
            _grpoItems = new List<GoodsReceiptPO.GoodsReceiptItem>();
            _initializeWorkers();
        }

        public CreateGRPO(EmployeeModel model, DataTable directPOTable)
        {
            InitializeComponent();
            _model = model;
            _loadDPOMode(directPOTable);
        }

        private void _loadDPOMode(DataTable directPOTable = null)
        {
            _dgrpoItems = new List<DGoodsReceipt.GoodsReceiptItem>();
            _dPOTable = directPOTable;
            _dpoMode = true;
        }

        private void _loadDPOFromOpenWindow(DataTable data)
        {
            _clearTextBoxes();
            _clearSupplierInfo();
            _dpoMode = true;
            _loadDPOMode(data);
            _selectedDPO = SelectedDPOInfo;
            _loadDPOInfo();
            _loadTableData();
            btnGenerateGoodsReceipt.Enabled = true;
            btnGenerateGoodsReceipt.BackColor = Color.FromArgb(128, 255, 128);
        }

        private void _loadDPOInfo()
        {
            lblID.Text = _selectedDPO.ID.ToString();
            lblSupplierName.Text = _selectedDPO.DirectPurchaseOrderDetail[0].Supplier.SupplierName;
            lblPaymentTerms.Text = _selectedDPO.DirectPurchaseOrderDetail[0].Supplier.PaymentTerms.PaymentTermName;
            label6.Visible = false;
            lblQuoteID.Visible = false;
            _dbHelper = new Helper();
            _initalizeDocumentWorker();
        }

        private void _loadTableData(List<DGoodsReceipt.GoodsReceiptItem> list = null)
        {
            dgvrItemList.AutoGenerateColumns = false;
            if (dgvrItemList.Columns.Count == 0)
            {
                dgvrItemList.Columns.Add("ItemID", "Item ID");
                dgvrItemList.Columns.Add("ItemName", "Item Name");
                dgvrItemList.Columns.Add("Color", "Color");
                dgvrItemList.Columns.Add("Quantity", "Ordered Quantity");
                dgvrItemList.Columns.Add("UnitPrice", "Unit Price");
                dgvrItemList.Columns.Add("Total Price", "Total Price");
                dgvrItemList.Columns.Add("DeliveredQuantity", "Delivered Quantity");
                dgvrItemList.Columns.Add("ReceivedQuantity", "Received Quantity");
            }

            if (_dgrpoItems.Count == 0)
            {
                _selectedDPO.DirectPurchaseOrderDetail[0].Items.ForEach(item =>
                {

                    var data = new DGoodsReceipt.GoodsReceiptItem();
                    data.Product = item;
                    _query = $"SELECT * FROM DGRPOInfo WHERE " +
                    $"DirectPODetailsID='{_selectedDPO.DirectPurchaseOrderDetail[0].ID}'";
                    var res = _dbHelper.GetData(_query);
                    //iterate the result and check if the item is already in the GRPO
                    if (res.Rows.Count > 0)
                    {
                        foreach (DataRow row in res.Rows)
                        {
                            if (row["ItemName"].ToString() == item.ItemName.ToString())
                            {
                                data.ReceivedQuantity = int.Parse(row["Received Quantity"].ToString());
                            }
                        }
                    }
                    _dgrpoItems.Add(data);

                });

            }
            dgvrItemList.Rows.Clear();
            if (list == null)
            {
                foreach (var item in _dgrpoItems)
                {
                    dgvrItemList.Rows.Add(item.Product.ItemID, item.Product.ItemName,
                        item.Product.Color, item.Product.Quantity,
                        CurrencyFormat.FormatCurrency(item.Product.Price),
                        CurrencyFormat.FormatCurrency(item.Product.TotalPrice),
                        item.DeliveredQuantity, item.ReceivedQuantity);
                }
            }
            else
            {

                foreach (var item in list)
                {
                    dgvrItemList.Rows.Add(item.Product.ItemID, item.Product.ItemName,
                        item.Product.Color, item.Product.Quantity,
                        CurrencyFormat.FormatCurrency(item.Product.Price),
                        CurrencyFormat.FormatCurrency(item.Product.TotalPrice),
                        item.DeliveredQuantity, item.ReceivedQuantity);
                }

            }


        }

        private void _initalizeDocumentWorker()
        {
            _documentWorker = new BackgroundWorker();
            _documentWorker.DoWork += (s, e) =>
            {

                _prepareData();
                if (!_dpoMode)
                {
                    _updatePurchaseOrder(EmployeeFactory.PurchaseOrderAction(_model));
                    _generateGRPO(EmployeeFactory.GoodsReceiptAction(_model));
                    var newGRPO = new ViewGRPO().GetLatestGRPOID();
                    new GoodsReceiptGenerator().GenerateGRPO(newGRPO, _path);
                }
                else
                {

                    _generateDGRPO(EmployeeFactory.UpdateDGoodsReceipt(_model));
                    var newDGRPO = new ViewDGRPO().GetLatestDGRPOID();
                    new DGoodsReceiptGenerator().GenerateDirectGoodsReceipt(newDGRPO, _selectedDPO.DirectPurchaseOrderDetail[0]
                        .Supplier.SupplierID, _path);
                }



            };

            _documentWorker.RunWorkerCompleted += (s, e) =>
            {
                _callBack("GRPO Generated", true, "Green");

                _clearValues();
            };
        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _documentWorker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {

                /*
                 * Algorithm:
                 * 1st check if the GRPO is created in the selected PO
                 * If yes then iterate the fetched GRPOs
                 * then fetch the GRPO item with its corresponding GRPOID then check its foreign key
                 * if foreign key is the same of the current grpo
                 * then iterate the items, if the item of the item list is the same as the item of the grpo item
                 *
                 */
                var grpo = new ViewGRPO().retrieveData<GoodsReceiptPO>().FindAll(gpo => gpo.QuotationPurchaseOrder.PurchaseOrderID == _selectedPO.PurchaseOrderID);
                foreach (var item in _selectedPO.SelectedQuotation.Items)
                {
                    var grpoItem = new GoodsReceiptPO.GoodsReceiptItem();
                    grpoItem.QuotationItem = item;
                    if (grpo.Count > 0)
                    {
                        _isExist = true;
                        grpo.ForEach(g =>
                        {
                            var items = new GRPOItem().retrieveData<GoodsReceiptPO.GoodsReceiptItem>().FindAll(i => i.GoodsReceiptID == g.GoodsReceiptID);
                            items.ForEach(i =>
                            {

                                if (i.QuotationItem.ItemName == item.ItemName)
                                {
                                    grpoItem.DeliveredQuantity += i.DeliveredQuantity;
                                }
                            });

                        });
                    }
                    _grpoItems.Add(grpoItem);
                }
            };

            _worker.RunWorkerCompleted += (s, e) =>
                {
                    _clearTextBoxes();
                    _clearSupplierInfo();
                    _loadItems();
                    _loadPOInfo();
                    btnGenerateGoodsReceipt.Enabled = true;
                    btnGenerateGoodsReceipt.BackColor = Color.FromArgb(128, 255, 128);
                };
            _initalizeDocumentWorker();


        }

        private void _callBack(string message, bool isSuccess = false, string defaultColor = "Gray")
        {
            lblMessage.ForeColor = Color.FromName(defaultColor);
            if (isSuccess)
            {
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
            }
            lblMessage.Text = message;
        }



        private void _loadItems(List<GoodsReceiptPO.GoodsReceiptItem> list = null)
        {
            if (dgvrItemList.Columns.Count == 0)
            {
                dgvrItemList.Columns.Add("QuoteID", "Quotation ID");
                dgvrItemList.Columns.Add("QuotationItemID", "ItemID");
                dgvrItemList.Columns.Add("ItemName", "ItemName");
                dgvrItemList.Columns.Add("Color", "Color");
                dgvrItemList.Columns.Add("Quantity", "OrderedQuantity");
                dgvrItemList.Columns.Add("UnitPrice", "UnitPrice");
                dgvrItemList.Columns.Add("ReceivedQuantity", "Delivered Quantity");
                dgvrItemList.Columns.Add("Comments", "Comments");

            }
            dgvrItemList.Rows.Clear();
            if (list == null)
            {
                _grpoItems.ForEach(e =>
                {
                    dgvrItemList.Rows.Add(e.QuotationItem.QuoteID, e.QuotationItem.QuotationItemID,
                        e.QuotationItem.ItemName, e.QuotationItem.Color, e.QuotationItem.Quantity,
                        e.QuotationItem.Quantity, e.DeliveredQuantity, e.Comments);
                });
            }
            else
            {
                list.ForEach(e =>
                {
                    dgvrItemList.Rows.Add(e.QuotationItem.QuoteID, e.QuotationItem.QuotationItemID,
                    e.QuotationItem.ItemName, e.QuotationItem.Color, e.QuotationItem.Quantity,
                    e.QuotationItem.Quantity, e.DeliveredQuantity, e.Comments);
                });
            }
            dgvrItemList.ClearSelection();
        }

        private void _loadPOInfo()
        {
            lblID.Text = _selectedPO.PurchaseOrderID.ToString();
            lblQuoteID.Text = _selectedPO.SelectedQuotation.Quotation.QuotationID.ToString();
            lblSupplierName.Text = _selectedPO.SelectedQuotation.SelectedSupplier.SupplierName;
            lblPaymentTerms.Text = _selectedPO.SelectedQuotation.SelectedSupplier.PaymentTerms.PaymentTermName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public ProcurementDocuments.DirectPurchaseOrder SelectedDPO
        {
            set { _selectedDPO = value; }
        }

        public QuotationPurchaseOrder SelectedPO
        {
            set
            {
                _selectedPO = value;
            }
        }

        private void _clearTextBoxes()
        {
            lblID.Text = "";
            lblQuoteID.Text = "";
            lblName.Text = "";
            lblColor.Text = "";
            lblPrice.Text = "";
            lblOrderedQty.Text = "";
            txtDeliveredQty.Text = "";
            txtComments.Text = "";
        }
        private void _clearSupplierInfo()
        {
            lblSupplierName.Text = "";
            lblPaymentTerms.Text = "";
        }
            
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dialog = new ViewPOList(_model);
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.IsChild = true;
            dialog.IsFiltered = true;
            _selectedPO = null;
            if (!_dpoMode)
                _grpoItems.Clear();
            dgvrItemList.Rows.Clear();
            dialog.ShowDialog();
            _selectedPO = dialog.GetSelectedPO();
            if (_selectedPO == null && SelectedDPOInfo == null)
                MessageBox.Show("No PO Selected");
            else
                if (_selectedPO != null)
                _worker.RunWorkerAsync();
            else
                _loadDPOFromOpenWindow(CreateGRPO._dPOTable);

        }

        private void dgvrItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!_dpoMode)
                {
                    btnUpdate.Enabled = true;
                    btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
                    _selectedGRPOItem = _grpoItems.Find(i => i.QuotationItem.QuotationItemID == Convert.ToInt32(dgvrItemList.Rows[e.RowIndex].Cells[1].Value));
                    var qItem = _selectedGRPOItem.QuotationItem;
                    lblName.Text = qItem.ItemName;
                    lblColor.Text = qItem.Color;
                    lblPrice.Text = CurrencyFormat.FormatCurrency(qItem.UnitPrice);
                    lblOrderedQty.Text = qItem.Quantity.ToString();
                    _selectedItem = qItem;
                }
                else
                {

                    btnUpdate.Enabled = true;
                    btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
                    var itemData = _dgrpoItems[e.RowIndex].Product;
                    _selectedProduct = itemData;
                    lblName.Text = itemData.ItemName;
                    lblColor.Text = itemData.Color;
                    lblPrice.Text = CurrencyFormat.FormatCurrency(itemData.Price);
                    lblOrderedQty.Text = itemData.Quantity.ToString();
                    _selectedDGROItem = _dgrpoItems[e.RowIndex];

                }

            }
        }

        private bool _checkInput()
        {
            try
            {

                if (txtDeliveredQty.Text == "")
                {
                    MessageBox.Show("Please enter the received quantity");
                    return false;
                }
                if (Convert.ToInt32(txtDeliveredQty.Text.Trim()) <= 0)
                {

                    MessageBox.Show("Please enter a valid quantity");
                    return false;

                }
                if (txtComments.Text == "")
                {
                    MessageBox.Show("Please enter the comments");
                    return false;
                }
                if (!_dpoMode && Convert.ToInt32(txtDeliveredQty.Text) + _selectedGRPOItem.DeliveredQuantity
                    > _selectedItem.Quantity)
                {
                    MessageBox.Show("Received quantity cannot be greater than ordered quantity");
                    return false;
                }
                else if (_dpoMode && Convert.ToInt32(txtDeliveredQty.Text.Trim()) + _selectedDGROItem.ReceivedQuantity
                    > _selectedProduct.Quantity && _dpoMode)
                {

                    MessageBox.Show("Received quantity cannot be greater than ordered quantity");
                    return false;

                }
                return true;

            }
            catch (Exception)
            {

                MessageBox.Show("Invalid Input");
                return false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_checkInput())
            {
                if (!_dpoMode)
                {
                    _selectedGRPOItem.DeliveredQuantity = Convert.ToInt32(txtDeliveredQty.Text.Trim());
                    _selectedGRPOItem.Comments = txtComments.Text.Trim();
                    var index = _grpoItems.FindIndex(i => i.QuotationItem.QuotationItemID == _selectedGRPOItem.QuotationItem.QuotationItemID);
                    if (index != -1)
                        _grpoItems[index] = _selectedGRPOItem;
                    dgvrItemList.Rows.Clear();
                    _loadItems();
                    btnUpdate.Enabled = false;
                    btnUpdate.BackColor = SystemColors.Control;
                    _clearTextBoxes();
                }
                else
                {

                    _selectedDGROItem.DeliveredQuantity = Convert.ToInt32(txtDeliveredQty.Text.Trim());
                    _selectedDGROItem.Comments = txtComments.Text.Trim();
                    var index = _dgrpoItems.FindIndex(i => i.Product.ItemID == _selectedDGROItem.Product.ItemID);
                    if (index != -1)
                    {
                        _dgrpoItems[index] = _selectedDGROItem;
                        dgvrItemList.Rows.Clear();
                        _loadTableData();
                        btnUpdate.Enabled = false;
                        btnUpdate.BackColor = SystemColors.Control;
                        _clearTextBoxes();
                    }

                }

            }
        }
        private void _prepareData()
        {

            if (!_dpoMode)
            {
                _grpo = new GoodsReceiptPO();
                _grpo.QuotationPurchaseOrder = _selectedPO;
                _grpo.ReceivedItems = _grpoItems;
                _grpo.CreatedDate = DateTime.Now;
                _grpo.Employee = _model;
                _grpo.ReceivedDate = DateTime.Now;
                _grpo.IsPartial = false;
                _grpo.QuotationPurchaseOrder.PurchaseOrderStatus = "Received";
                for (var i = 0; i < _grpoItems.Count; i++)
                {
                    if (_isExist)
                    {

                        var query = $"SELECT GPI.ItemName, SUM(DeliveredQuantity) AS 'Received Quantity', GPI.OrderedQuantity FROM GRPOItem " +
                            $"GPI INNER JOIN GRPO G ON GPI.GoodReceiptID = G.GoodsReceiptID INNER JOIN QuotationPurchaseOrder QPO ON " +
                            $"G.PurchaseOrderID = QPO.PurchaseOrderID WHERE QPO.PurchaseOrderID='{_selectedPO.PurchaseOrderID}'AND " +
                            $"GPI.ItemName='{_grpoItems[i].QuotationItem.ItemName}' GROUP BY GPI.ItemName, GPI.OrderedQuantity";
                        var data = new Helper();
                        var result = data.GetData(query);
                        var currentReceived = Convert.ToInt32(result.Rows[0]["Received Quantity"]) + _grpoItems[i].DeliveredQuantity;
                        var orderedQuantity = Convert.ToInt32(result.Rows[0]["OrderedQuantity"]);
                        if (currentReceived < orderedQuantity)
                        {
                            _grpo.IsPartial = true;
                            _grpo.QuotationPurchaseOrder.PurchaseOrderStatus = "Partial";
                        }
                    }
                    else
                    {
                        if (_selectedPO.SelectedQuotation.Items[i].Quantity > _grpoItems[i].DeliveredQuantity)
                        {
                            _grpo.IsPartial = true;
                            _grpo.QuotationPurchaseOrder.PurchaseOrderStatus = "Partial";
                        }
                    }
                }
                _grpo.TotalPrice = _grpoItems.Sum(item => item.QuotationItem.UnitPrice * item.DeliveredQuantity);


            }
            else
            {
                var result = "";
                var dgrpo = new DGoodsReceipt();
                foreach (var item in _dgrpoItems)
                {
                    if (item.DeliveredQuantity + item.ReceivedQuantity == item.Product.Quantity)
                    {
                        dgrpo.IsPartial = false;
                        result = "Received";
                    }
                    else
                    {
                        dgrpo.IsPartial = true;
                        result = "Partial";
                        break;
                    }

                }
                dgrpo.DirectPOID = _selectedDPO.DirectPurchaseOrderDetail[0].ID;
                _query = $"UPDATE DirectPurchaseOrderDetails SET PurchaseOrderStatus='{result}' WHERE DirectPODetailsID='{dgrpo.DirectPOID}'";
                _dbHelper.AddUpdDelData(_query);
                dgrpo.Employee = _model;
                dgrpo.TotalPrice = _dgrpoItems.Sum(item => item.Product.Price * item.DeliveredQuantity);
                dgrpo.ReceivedItems = _dgrpoItems;
                _dgrpo = dgrpo;
            }
        }


        private void _clearValues()
        {
            lblID.Text = "";
            lblQuoteID.Text = "";
            lblName.Text = "";
            lblColor.Text = "";
            lblPrice.Text = "";
            lblOrderedQty.Text = "";
            txtDeliveredQty.Text = "";
            txtComments.Text = "";
            lblSupplierName.Text = "";
            lblPaymentTerms.Text = "";
            dgvrItemList.Rows.Clear();
            btnGenerateGoodsReceipt.Enabled = false;
            btnGenerateGoodsReceipt.BackColor = SystemColors.Control;
        }
        private void _updatePurchaseOrder(IPurchaseOrderAction action)
        {
            action.UpdatePO(_grpo.QuotationPurchaseOrder);
        }
        private void _generateGRPO(IGoodsReceiptAction action)
        {
            action.CreateGoodsReceipt(_grpo);
        }

        private void _generateDGRPO(IDGoodsReceiptAction action)
        {
            action.CreateGoodsReceipt(_dgrpo, _selectedDPO.DirectPurchaseOrderDetail[0].AP);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.Trim();

            if (input == string.Empty)
            {
                if (_dpoMode)
                {
                    _loadTableData();
                    _dgrpoItemslocal.Clear();
                }
                else
                {
                    _loadItems();
                    _grpoItemslocal.Clear();

                }
                return;
            }
            if (!_dpoMode)
            {
                _grpoItemslocal = _grpoItems.Where(item => item.QuotationItem.ItemName.ToLower().Contains(input.ToLower())
                || item.QuotationItem.Color.ToLower().Contains(input.ToLower())
                || item.QuotationItem.QuoteID.ToString().Contains(input.ToLower())
                || item.QuotationItem.QuotationItemID.ToString().Contains(input.ToLower())).ToList();
                _loadItems(_grpoItemslocal);
            }
            else
            {
                _dgrpoItemslocal = _dgrpoItems.Where(item => item.Product.ItemName.ToLower().Contains(input.ToLower())
                || item.Product.ItemID.ToString().Contains(input.ToLower())
                || item.Product.Color.ToString().Contains(input.ToLower())).ToList();
                _loadTableData(_dgrpoItemslocal);
            }

        }

        private void btnGenerateGoodsReceipt_Click(object sender, EventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please enter the folder you want to save in";
            folderDialog.ShowNewFolderButton = true;
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                var quotationFolder = folderDialog.SelectedPath;
                if (!_dpoMode)
                    _path = Path.Combine(quotationFolder, _selectedPO.SelectedQuotation.SelectedSupplier.SupplierName);
                else
                {
                    _path = Path.Combine(quotationFolder, _selectedDPO.DirectPurchaseOrderDetail[0].Supplier.SupplierName);
                }
                Directory.CreateDirectory(_path);
                _callBack("Generating GRPO Please Wait", true, "Yellow");
                _documentWorker.RunWorkerAsync();

            }
        }

        private void dgvrItemList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void CreateGRPO_Load(object sender, EventArgs e)
        {
            if (_selectedPO != null)
                _worker.RunWorkerAsync();
            else
            {

                if (_dpoMode)
                {

                    _loadDPOInfo();
                    _loadTableData();
                }
            }
        }
    }
}
