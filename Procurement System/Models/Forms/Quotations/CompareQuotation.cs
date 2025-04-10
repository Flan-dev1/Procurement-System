using Procurement_System.Models.Forms.PurchaseOrders;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    public partial class CompareQuotation : Form
    {
        private EmployeeModel _model;
        private Dictionary<int, List<QuotationItem>> _supplierItems;
        private List<Quotation> _quotations;
        private List<SupplierModel> _supplierModels;
        private Quotation _selectedQuote;
        private SupplierModel _selectedSupplier;
        private ViewData _viewData;

        public CompareQuotation(EmployeeModel userAction)
        {
            _model = userAction;
            InitializeComponent();
            _viewData = new ViewQuotations();
            _populateQuotations();
            dgvPrinted.AutoGenerateColumns = false;
        }

        private void _populateQuotations(List<Quotation> list = null)
        {
            if (list == null)
                _quotations = _viewData.retrieveData<Quotation>();
            _quotations = _quotations.Where(x => x.Status == "Printed" && x.QuoteReceived == 1).ToList();
            //remove duplications on quotation by its QuotationID
            _quotations = _quotations.GroupBy(x => x.QuotationID).Select(x => x.First()).ToList();
            var bindingList = new BindingList<Quotation>(_quotations);
            dgvPrinted.DataSource = bindingList;
            dgvPrinted.ClearSelection();
            try
            {
                dgvPrinted.Columns.Remove("Employee");
                dgvPrinted.Columns.Remove("Status");
                dgvPrinted.Columns.Remove("Remarks");
            }catch(Exception ignored)
            {
                
            }


            dgvComparison.Rows.Clear();
            dgvItems.Rows.Clear();
        }

        private void _setSupplierValues()
        {
            _supplierModels = _selectedQuote.Suppliers;
            var itemList = new ViewQuotations().GetItemsInQuotation(_selectedQuote.QuotationID);
            itemList = itemList.Where(x => x.SupplierProvider != null).ToList();
            _supplierItems = new Dictionary<int, List<QuotationItem>>();
            foreach (var supplier in _supplierModels)
            {

                var items = new List<QuotationItem>();
                foreach (var item in itemList)
                {
                    if (item.SupplierProvider.SupplierID == supplier.SupplierID)
                    {
                        items.Add(item);
                    }
                }
                _supplierItems.Add(supplier.SupplierID, items);

            }
        }

        private void _generateSupplierQuoteData()
        {
            dgvComparison.Rows.Clear();
            if (dgvComparison.Columns.Count == 0)
            {
                dgvComparison.Columns.Add("SupplierID", "Supplier ID");
                dgvComparison.Columns.Add("SupplierName", "Supplier Name");
                dgvComparison.Columns.Add("TotalQuotePrice", "Total Quote Price");

            }
            foreach (var key in _supplierItems.Keys)
            {

                var supplier = _supplierModels.Where(x => x.SupplierID == key).FirstOrDefault();
                var items = _supplierItems[key];
                var total = items.Sum(x => x.TotalPrice);
                var row = new string[] { supplier.SupplierID + "", supplier.SupplierName, CurrencyFormat.FormatCurrency(total.ToString()) };
                dgvComparison.Rows.Add(row);

            }

        }

        private void _generateSummary()
        {
            lblNumItems.Text = new ViewQuotations().GetGenericItems(_selectedQuote.QuotationID).Count + "";
            lblNumSuppliers.Text = _supplierModels.Count + "";
            double minimum = double.MaxValue, currentVal = 0;
            string lowestPriceSupplierName = "";
            foreach (KeyValuePair<int, List<QuotationItem>> list in _supplierItems)
            {
                currentVal = _supplierItems[list.Key].Sum(x => x.UnitPrice);
                if (currentVal < minimum)
                {
                    minimum = currentVal;
                    lowestPriceSupplierName = _supplierModels.Find(x => x.SupplierID == list.Key).SupplierName;
                }

            }
            lvlLowestCostSupplierName.Text = lowestPriceSupplierName;
        }

        private void _populateItemQuotations(List<QuotationItem> list = null)
        {
            if (list == null)
                list = new ViewQuotations().GetGenericItems(_selectedQuote.QuotationID);

            var bindingList = new BindingList<QuotationItem>(list);
            dgvItems.DataSource = bindingList;
            dgvItems.Columns[5].DefaultCellStyle.Format = "c2";
            dgvItems.Columns[5].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
            dgvItems.Columns[6].DefaultCellStyle.Format = "c2";
            dgvItems.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-PH");
            dgvItems.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvItems.Columns["TotalPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvItems.Columns.Remove("QuoteID");
            dgvItems.Columns.Remove("ItemCategory");
            dgvItems.Columns.Remove("ItemType");
            dgvItems.Columns.Remove("SupplierProvider");
            dgvItems.Columns.Remove("QuotationItemID");
        }

        private void dgvPrinted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedQuote = _quotations[e.RowIndex];
                _setSupplierValues();
                _generateSupplierQuoteData();
                _generateSummary();
                dgvComparison.ClearSelection();
                btnCreatePO.Enabled = true;

            }
            catch (Exception)
            {
            }
        }

        private void dgvComparison_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string supplierID = dgvComparison.Rows[e.RowIndex].Cells["SupplierID"].Value + "";
                supplierID = supplierID.Trim();
                _selectedSupplier = _supplierModels.Find(supp => supp.SupplierID == Convert.ToInt32(supplierID));
                _populateItemQuotations(_supplierItems[_selectedSupplier.SupplierID]);
            }
            catch (Exception)
            {

            }

        }

        private void txtSearchPrinted_KeyUp(object sender, KeyEventArgs e)
        {
            var textInput = txtSearchPrinted.Text.ToLower().Trim();

            if (textInput == "")
            {
                _populateQuotations();
                return;
            }
            _quotations = _viewData.retrieveData<Quotation>();
            _quotations = _quotations.FindAll(quote =>
                    (quote.Employee.FirstName.ToLower().Contains(textInput))
                    || (quote.Status.ToLower().Contains(textInput))
                    || (quote.Remarks.ToLower().Contains(textInput))
                    || (quote.QuotationID.ToString().ToLower().Contains(textInput)));
            _populateQuotations(_quotations);

        }

        private void txtSearchItems_KeyUp(object sender, KeyEventArgs e)
        {
            var textInput = txtSearchItems.Text.Trim().ToLower();
            if (textInput != "")
            {
                var items = _supplierItems[_selectedSupplier.SupplierID].ToList();
                items = items.FindAll(
                    item =>
                    (item.ItemName.ToLower().Contains(textInput))
                    || (item.Quantity.ToString().ToLower().ToLower().Contains(textInput))
                    || (item.QuotationItemID.ToString().ToLower().Contains(textInput))
                    || (item.QuoteID.ToString().ToLower().Contains(textInput))
                    || (item.Color.ToLower().Contains(textInput))
                    || (item.Quantity.ToString().ToLower().Contains(textInput))
                    || (item.UnitPrice.ToString().ToLower().Contains(textInput))
                    );
                _populateItemQuotations(items);
            }
            else
            {
                _populateItemQuotations();
            }
        }

        private void btnCreatePO_Click(object sender, EventArgs e)
        {
            if (_selectedSupplier == null || _selectedQuote == null)
            {
                MessageBox.Show("Please select a quotation and a supplier to create a purchase order.");
                return;
            }
            CreatePO.SelectedSupplier = _selectedSupplier;
            CreatePO.SelectedQuotation = _selectedQuote;
            CreatePO.QuotationItems = _supplierItems[_selectedSupplier.SupplierID].ToList();
            if (CreatePO.IsChild == null)
            {
                var POWindow = new CreatePO(_model);
                POWindow.StartPosition = FormStartPosition.CenterScreen;
                POWindow.ShowDialog();
                _populateQuotations();
                btnCreatePO.Enabled = false;
                _selectedSupplier = null;
                return;
            }
            Close();

        }

        private void dgvItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
