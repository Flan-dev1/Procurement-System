using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using Procurement_System.Services.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    public partial class UpdateQuotation : Form
    {
        private IQuotationAction _quotationAction;
        private EmployeeModel _model;
        private Quotation _selectedQuotation;
        private QuotationItem _selectedItem;
        private SupplierModel _selectedSupplier;
        private List<Quotation> _quotations;
        private List<SupplierModel> _supplierModels;
        private List<SupplierModel> _toDeleteSupplier;
        private List<QuotationItem> _toDeleteItems;
        private List<QuotationItem> _quotationItems;
        private Dictionary<int, List<QuotationItem>> _supplierItems;
        private DataUpdater _dataUpdater;
        private BackgroundWorker _worker;
        ViewData viewData;


        private void _callBack(string message)
        {
            MessageBox.Show(message);
        }


        public UpdateQuotation(EmployeeModel userAction)
        {
            _model = userAction;
            _quotationAction = EmployeeFactory.QuotationAction(_model);
            InitializeComponent();
            _dataUpdater = new DataUpdater();
            cbCategory.Items.Add("");
            cbItemType.Items.Add("");
            new ViewCategories().retrieveData<ItemCategory>().ForEach(c => cbCategory.Items.Add(c));
            new ViewItemType().retrieveData<ItemType>().ForEach(c => cbItemType.Items.Add(c));

        }

        private void _worker_DoWork(object sender, DoWorkEventArgs e)
        {

            List<Quotation> updatedCopy = new List<Quotation>();
            while (true)
            {
                Thread.Sleep(1000);
                if (_dataUpdater.CheckQuotationData(_quotations))
                {
                    var viewQuotes = new ViewQuotations();
                    updatedCopy = viewQuotes.retrieveData<Quotation>();
                    updatedCopy = updatedCopy.GroupBy(x => x.QuotationID).Select(x => x.First()).ToList();
                    updatedCopy = updatedCopy.Where(quote => quote.Status != "PO Created").ToList();
                    //if (!chkbxReceivedQuote.Checked)
                    //    updatedCopy = updatedCopy.Where(quote => quote.QuoteReceived == 0).ToList();
                    //check local copy against to the new update quotations
                    if (updatedCopy.Count != _quotations.Count)
                    {

                        Action action = () =>
                        {
                            dgvrfqItemListInQuote.Rows.Clear();
                            dgvrfqSupplierListInQuote.Rows.Clear();
                            _populateQuotations();
                        };
                        if (IsHandleCreated)
                            dgvrfqItemListInQuote.Invoke(action);

                    }
                    else
                    {
                        //MessageBox.Show("No Updated");
                    }
                }
                updatedCopy.Clear();
            }
        }

        private void _loadOnStartUp()
        {
            tmrTime.Start();
            _quotations = new List<Quotation>();
            _toDeleteItems = new List<QuotationItem>();
            _toDeleteSupplier = new List<SupplierModel>();
            viewData = new ViewQuotations();
            _populateQuotations();
            _clearValues();
            _worker = new BackgroundWorker();
            _worker.WorkerSupportsCancellation = true;
            _worker.DoWork += _worker_DoWork;
            _worker.RunWorkerAsync();

        }

        private void _showMessage(string message, bool success = false)
        {
            if (success)
            {
                lblMessage.ForeColor = Color.Green;
            }
            else
            {

                lblMessage.ForeColor = Color.Red;

            }
            lblMessage.Text = message;
        }

        private void _populateSuppliers()
        {
            var bindingList = new BindingList<SupplierModel>(_supplierModels);
            dgvrfqSupplierListInQuote.DataSource = bindingList;

            if (dgvrfqSupplierListInQuote.ColumnCount == 6)
                dgvrfqSupplierListInQuote.Columns.RemoveAt(5);
            dgvrfqSupplierListInQuote.ClearSelection();
        }

        private void _populateQuotations()
        {

            _quotations = viewData.retrieveData<Quotation>();
            _quotations = _quotations.Where(quote => quote.Status != "PO Created").ToList();
            _quotations = _quotations.GroupBy(x => x.QuotationID).Select(x => x.First()).ToList();
            var bindingList = new BindingList<Quotation>(_quotations);
        }

        private void _setSupplierItems()
        {
            _supplierItems = new Dictionary<int, List<QuotationItem>>();
            foreach (var supplier in _supplierModels)
            {
                /*
                    Why this loop is implemented this way?
                    Its because only copying the quotationItem list actually
                    still passing the references of that class.
                    So when you add or remove items from the list, it will
                    also affect the original list. So creating a new classes and
                    passing the original attributes of those classes can have
                    a new reference to only itself.
                 */
                var list = new List<QuotationItem>();

                _quotationItems.ForEach(e =>
                {
                    if (e.SupplierProvider != null && e.SupplierProvider.SupplierID == supplier.SupplierID)
                    {

                        list.Add(new QuotationItem
                        {
                            QuotationItemID = e.QuotationItemID,
                            ItemName = e.ItemName,
                            Quantity = e.Quantity,
                            Color = e.Color,
                            UnitPrice = e.UnitPrice,
                            SupplierProvider = supplier
                        });
                    }
                });
                _supplierItems.Add(supplier.SupplierID, list);
            }

            //Checking the suppliers that has no item prices in items.
            var keys = new List<int>(_supplierItems.Keys);
            keys.ForEach(key =>
            {
                var list = new List<QuotationItem>();
                if (_supplierItems[key].Count == 0)
                {
                    _supplierItems[key] = new ViewQuotations().GetGenericItems(_selectedQuotation.QuotationID);
                }
            });
        }

        private void _populateItems(List<QuotationItem> list = null)
        {
            if (dgvrfqItemListInQuote.Columns.Count == 0)
            {

                dgvrfqItemListInQuote.Columns.Add("QuotationItemID", "ItemID");
                dgvrfqItemListInQuote.Columns.Add("ItemName", "ItemName");
                dgvrfqItemListInQuote.Columns.Add("Color", "Color");
                dgvrfqItemListInQuote.Columns.Add("Quantity", "Quantity");
                dgvrfqItemListInQuote.Columns.Add("UnitPrice", "UnitPrice");
                dgvrfqItemListInQuote.Columns[0].DataPropertyName = "QuotationItemID";
                dgvrfqItemListInQuote.Columns[1].DataPropertyName = "ItemName";
                dgvrfqItemListInQuote.Columns[2].DataPropertyName = "Color";
                dgvrfqItemListInQuote.Columns[3].DataPropertyName = "Quantity";
                dgvrfqItemListInQuote.Columns[4].DataPropertyName = "UnitPrice";
                dgvrfqItemListInQuote.Columns[4].DefaultCellStyle.Format = "c2";
                dgvrfqItemListInQuote.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");

            }
            dgvrfqItemListInQuote.Rows.Clear();
            if (list == null)
            {
                _quotationItems.ForEach((e) => dgvrfqItemListInQuote.Rows.Add(e.QuotationItemID, e.ItemName,
                    e.Color, e.Quantity, e.UnitPrice));
                return;
            }
            list.ForEach((e) => dgvrfqItemListInQuote.Rows.Add(e.QuotationItemID, e.ItemName,
                 e.Color, e.Quantity, e.UnitPrice));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _clearValues();
            //check if the quotation is printed
            if (_selectedQuotation != null)
            {
                if (_selectedQuotation.Status == "Printed")
                {
                    _updateItemTextBox(false);
                }
                else
                {
                    _updateItemTextBox(true);
                }
            }
        }
        private void _clearValues()
        {

            txtItemName.Text = "";
            txtColor.Text = "";
            txtQuantity.Text = "";
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = SystemColors.Control;
            txtPrice.Text = "";
            txtPrice.Enabled = false;
            cbCategory.SelectedIndex = 0;
            cbItemType.SelectedIndex = 0;
            btnUpdate.Enabled = false;
            btnUpdate.BackColor = SystemColors.Control;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void UpdateQuotation_Load(object sender, EventArgs e)
        {
            _loadOnStartUp();
            dgvrfqItemListInQuote.AutoGenerateColumns = false;

        }

        private void _updateItemTextBox(bool state)
        {
            txtItemName.Enabled = state;
            txtColor.Enabled = state;
            txtQuantity.Enabled = state;
            dgvrfqItemListInQuote.MultiSelect = state;
            dgvrfqSupplierListInQuote.MultiSelect = state;
            txtPrice.Enabled = !state;
            cbCategory.Enabled = !state;
            cbItemType.Enabled = !state;
        }

        private void dgvrfqItemListInQuote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                var selectedItem = (int)dgvrfqItemListInQuote.Rows[e.RowIndex].Cells[0].Value;

                if (_selectedQuotation.Status == "Printed")
                {
                    if (dgvrfqSupplierListInQuote.SelectedRows.Count != 1 && _selectedSupplier == null)
                    {
                        _showMessage("Please select the supplier you want to update.");
                        return;
                    }
                    var item = _supplierItems[_selectedSupplier.SupplierID].Find(i => i.QuotationItemID == selectedItem);
                    _selectedItem = item;

                }
                else
                {
                    _selectedItem = _quotationItems.Find(item => item.QuotationItemID == selectedItem);
                }
                if (_selectedQuotation.Status == "Printed")
                {
                    if (_selectedItem.ItemCategory.CategoryName != "" || _selectedItem.ItemType.TypeName != "")
                    {
                        cbCategory.SelectedIndex = cbCategory.FindStringExact(_selectedItem.ItemCategory.CategoryName);
                        cbItemType.SelectedIndex = cbItemType.FindStringExact(_selectedItem.ItemType.TypeName);
                    }
                }

                txtItemName.Text = _selectedItem.ItemName;
                txtColor.Text = _selectedItem.Color;
                txtQuantity.Text = _selectedItem.Quantity + "";
                btnUpdate.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(255, 255, 192);

            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }

        private void dgvrfqSupplierListInQuote_KeyUp(object sender, KeyEventArgs e)
        {
            //check if the key pressed is delete key
            if (e.KeyCode == Keys.Delete && _selectedQuotation.Status != "Printed")
            {
                //Show MessageBox confirmation of deletion.
                if (MessageBox.Show("Are you sure you want to this supplier(s)", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    //check if the user has selected a row
                    if (dgvrfqSupplierListInQuote.SelectedRows.Count > 0)
                    {
                        for (var i = 0; i < dgvrfqSupplierListInQuote.SelectedRows.Count; i++)
                        {
                            var selectedRow = dgvrfqSupplierListInQuote.SelectedRows[i];
                            //get the selected supplier
                            var selectedSupplier = (SupplierModel)selectedRow.DataBoundItem;
                            _toDeleteSupplier.Add(selectedSupplier);
                            //remove the selected supplier from the list
                            _supplierModels.Remove(selectedSupplier);
                        }

                        _populateSuppliers();

                    }


                }
            }
            else
            {
                _showMessage("Cannot delete supplier on an already printed quotation.");
            }
        }

        private void dgvrfqItemListInQuote_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Are you sure you want to delete item(s)", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (dgvrfqItemListInQuote.SelectedRows.Count > 0)
                    {
                        for (var i = 0; i < dgvrfqItemListInQuote.SelectedRows.Count; i++)
                        {
                            var selectedRow = dgvrfqItemListInQuote.SelectedRows[i];
                            var selectedItem = (QuotationItem)selectedRow.DataBoundItem;
                            _toDeleteItems.Add(selectedItem);
                            _quotationItems.Remove(selectedItem);
                        }
                        _clearValues();
                        _populateItems();
                    }
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_checkInput())
            {
                if (_selectedQuotation.Status == "Printed")
                    _updateItem(txtItemName.Text.Trim(), txtColor.Text.Trim(),
                        Convert.ToInt32(txtQuantity.Text.Trim()), Convert.ToDouble(txtPrice.Text.Trim()), _selectedSupplier);
                else
                    _updateItem(txtItemName.Text.Trim(), txtColor.Text.Trim(),
                       Convert.ToInt32(txtQuantity.Text.Trim()), 0);
                _selectedItem = null;
                dgvrfqItemListInQuote.ClearSelection();
                _clearValues();
                if (_selectedQuotation.Status == "Printed")
                    _updateItemTextBox(false);
                else
                    _updateItemTextBox(true);
            }

        }

        private bool _checkInput()
        {
            if (txtItemName.Text.Trim() == "")
            {
                _showMessage("Item Name is required");
                return false;
            }
            if (txtColor.Text.Trim() == "")
            {
                _showMessage("Please enter color");
                return false;
            }
            if (txtQuantity.Text.Trim() == "")
            {
                _showMessage("Please enter quantity");
                return false;
            }
            if (txtPrice.Text.Trim() == "" && _selectedQuotation.Status == "Printed")
            {
                _showMessage("Please enter price");
                return false;
            }

            if (cbCategory.Text.Trim() == "" && _selectedQuotation.Status == "Printed")
            {
                _showMessage("Please select category");
                return false;
            }

            if (cbItemType.Text.Trim() == "" && _selectedQuotation.Status == "Printed")
            {
                _showMessage("Please select item type");
                return false;
            }

            try
            {
                Convert.ToInt32(txtQuantity.Text.Trim());
            }
            catch (Exception)
            {
                _showMessage("Quantity must be a number");
                return false;
            }
            return true;
        }

        private void _updateItem(string itemName, string color, int quantity, double unitPrice = 0, SupplierModel provider = null)
        {
            //get the selected row
            //get the selected quotation item
            //update the quotation item 
            _selectedItem.ItemName = itemName;
            _selectedItem.Color = color;
            _selectedItem.Quantity = quantity;
            _selectedItem.UnitPrice = unitPrice;
            _selectedItem.ItemCategory = new ViewCategories().retrieveData<ItemCategory>().Find(c => c.CategoryName == cbCategory.Text.Trim());
            _selectedItem.ItemType = new ViewItemType().retrieveData<ItemType>().Find(t => t.TypeName == cbItemType.Text.Trim());
            if (_selectedQuotation.Status == "Printed")
            {

                _selectedItem.SupplierProvider = provider;
                var index = _supplierItems[provider.SupplierID].FindIndex(item => item.QuotationItemID == _selectedItem.QuotationItemID);
                if (index != -1)
                {
                    _supplierItems[provider.SupplierID][index] = _selectedItem;
                }
                //this foreach is used to apply all category and itemtype to each supplierItem in the dictionary
                foreach (var id in _supplierItems.Keys)
                {
                    foreach (var item in _supplierItems[id])
                    {
                        if (item.ItemName == _selectedItem.ItemName && item.Color == _selectedItem.Color)
                        {
                            item.ItemCategory = _selectedItem.ItemCategory;
                            item.ItemType = _selectedItem.ItemType;
                        }
                    }
                }


                //refresh the datagridview
                _populateItems(_supplierItems[provider.SupplierID]);
            }
            else
            {
                var index = _quotationItems.FindIndex(e => e.QuotationItemID == _selectedItem.QuotationItemID);
                if (index != -1)
                {
                    _quotationItems[index] = _selectedItem;
                }
                _populateItems();
            }

        }

        private void btnUpdateQuote_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to update this Quotation?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_quotationItems.Count == 0)
                {
                    _callBack("Error There should be one or more items in the quote.");
                    _populateQuotations();
                    return;
                }
                else if (_supplierModels.Count == 0)
                {
                    _callBack("Error There should be one or more suppliers in the quote.");
                    _populateQuotations();
                    return;
                }
                _selectedQuotation.Items = _quotationItems;
                _selectedQuotation.Suppliers = _supplierModels;
                _quotationAction.DeleteItemQuotation(_toDeleteItems, _selectedQuotation.QuotationID);
                _quotationAction.DeleteSupplierQuotation(_toDeleteSupplier, _selectedQuotation.QuotationID);
                _quotationAction.UpdateQuotation(_selectedQuotation);

                foreach (KeyValuePair<int, List<QuotationItem>> entry in _supplierItems)
                {
                    _quotationAction.UpdateQuotationPrices(entry.Value, _selectedQuotation.QuotationID);
                }
                _showMessage("Quote has been updated.", true);
                _populateQuotations();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtItemName_KeyUp(object sender, KeyEventArgs e)
        {
            _showMessage("");
        }

        private void dgvrfqSupplierListInQuote_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                if (_selectedQuotation.Status == "Printed")
                {
                    var supplierIndex = dgvrfqSupplierListInQuote.Rows[e.RowIndex];
                    _selectedSupplier = (SupplierModel)supplierIndex.DataBoundItem;

                    var list = _supplierItems[_selectedSupplier.SupplierID];
                    _populateItems(list);
                    dgvrfqItemListInQuote.ClearSelection();
                    if (dgvrfqItemListInQuote.SelectedRows.Count > 0)
                        btnUpdate.Enabled = true;
                    btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
                    _showMessage("");

                    cbCategory.SelectedIndex = 0;
                    cbItemType.SelectedIndex = 0;
                    return;
                }


            }
            catch (Exception)
            {

            }
        }

        private void btnAddUpdItem_Click(object sender, EventArgs e)
        {
            if (_selectedQuotation.Status == "Printed")
            {
                dgvrfqItemListInQuote.Rows.Clear();
            }
        }

        private void UpdateQuotation_FormClosing(object sender, FormClosingEventArgs e)
        {
            _worker.CancelAsync();
        }

        private void chkbxReceivedQuote_CheckedChanged(object sender, EventArgs e)
        {
            _populateQuotations();
        }

        private void _selectQuotation(Quotation _quote)
        {
            _selectedQuotation = _quote;
            _clearValues();
            if (_selectedQuotation == null)
                return;
            if (_selectedQuotation.Status == "Printed")
            {
                dgvrfqItemListInQuote.Rows.Clear();
                _updateItemTextBox(false);
            }
            else
            {
                _updateItemTextBox(true);
                _populateItems(new ViewQuotations().GetGenericItems(_selectedQuotation.QuotationID));
            }
            lblQuoteID.Text = _selectedQuotation.QuotationID.ToString();
            _supplierModels = _quote.Suppliers;
            _quotationItems = new ViewQuotations().GetItemsInQuotation(_quote.QuotationID);
            _populateSuppliers();
            _setSupplierItems();

        }

        private void btnShowQuotes_Click(object sender, EventArgs e)
        {
            new QuotationList(_selectQuotation).ShowDialog();
        }

        private void txtSearchSupp_KeyUp(object sender, KeyEventArgs e)
        {
            //search
        }
    }
}
