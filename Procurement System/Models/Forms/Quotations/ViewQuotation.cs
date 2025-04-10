using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
using Procurement_System.Models.Users;
using Procurement_System.Services;
using Procurement_System.Services.Authentication;
using Procurement_System.Services.DocumentGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    public partial class ViewQuotation : Form
    {

        /*
            Process of Loading this class.
            1. Generate the values from ViewData
            2. Set the class quotation attr to retrievedData()
            3. Show the Quotations on the Datagridview
         */

        private ViewData _viewAssets;
        private List<Quotation> _quotations;
        private List<SupplierModel> _suppliers;
        private List<QuotationItem> _items;
        private Quotation _selectedQuote;
        private BackgroundWorker _backgroundWorker;
        private delegate void _callBackDel(string message, bool isSuccess = false, string defaultColor = "Blue");
        private _callBackDel _callBackObj;
        private IQuotationAction _setAction;
        private BackgroundWorker _worker;
        public ViewQuotation(EmployeeModel userAction)
        {
            InitializeComponent();
            _backgroundWorker = new BackgroundWorker();
            _viewAssets = new ViewQuotations();
            _callBackObj += _callBack;
            _worker = new BackgroundWorker();
            _worker.DoWork += (e, x) =>
            {
                _populateQuotations();
            };
            _worker.RunWorkerCompleted += (e, x) =>
            {
                var bindingList = new BindingList<Quotation>(_quotations);
                dgvrfqQuotes.DataSource = bindingList;
                dgvrfqItems.ClearSelection();
                dgvrfqQuotes.Columns.Remove("Employee");
                dgvrfqQuotes.Columns.Remove("Remarks");
            };
            _worker.RunWorkerAsync();
            _setAction = EmployeeFactory.QuotationAction(userAction);
        }

        private IQuotationAction _getUserLogin(EmployeeModel model)
        {
            var empType = model.getEmployeeType().getType();
            switch (empType)
            {
                case "Book Keeper":
                    return new BookKeeper(model);
                case "Sales Staff":
                    return new SalesStaff(model);
                case "AdminManager":
                    return new AdminManager(model);
                default:
                    return null;
            }
        }

        private void _clearAll()
        {
            dgvrfqItems.Rows.Clear();
            dgvrfqSuppliers.Rows.Clear();
            dgvrfqQuotes.Rows.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void _populateQuotations(List<Quotation> list = null)
        {
            _clearAll();
            if (list == null)
                _quotations = _viewAssets.retrieveData<Quotation>();
            else
                _quotations = list;
            _quotations = _quotations.GroupBy(x => x.QuotationID).Select(x => x.First()).ToList();
        }

        private void _populateSuppliers(List<SupplierModel> list = null)
        {
            if (list == null)
                _suppliers = _selectedQuote.Suppliers;
            var bindingList = new BindingList<SupplierModel>(_suppliers);
            dgvrfqSuppliers.DataSource = bindingList;
            dgvrfqSuppliers.Columns.RemoveAt(0);
            dgvrfqSuppliers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvrfqSuppliers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvrfqSuppliers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvrfqSuppliers.Columns.RemoveAt(4);
        }

        private void _populateItems(List<QuotationItem> list = null)
        {
            if (list == null)
                _items = new ViewQuotations().GetGenericItems(_selectedQuote.QuotationID);
            var bindingList = new BindingList<QuotationItem>(_items);
            dgvrfqItems.DataSource = bindingList;
            dgvrfqItems.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvrfqItems.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvrfqItems.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvrfqItems.Columns.Remove("QuoteID");//Removing UnitPrice column
            dgvrfqItems.Columns.Remove("UnitPrice");//Removing UnitPrice column
            dgvrfqItems.Columns.Remove("TotalPrice");//Removing UnitPrice column
            dgvrfqItems.Columns.Remove("ItemCategory");
            dgvrfqItems.Columns.Remove("ItemType");
            dgvrfqItems.Columns.RemoveAt(4);
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

        private void btnGenerateDoc_Click(object sender, EventArgs e)
        {


            if (_selectedQuote == null)
            {
                _callBackObj.Invoke("Please enter the quote you want to generate.");
                return;
            }

            var res = MessageBox.Show("Are you sure you want to generate this quote? It cannot be edited anymore when its released?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;

            var folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "Please enter the folder you want to save in";
            folderDialog.ShowNewFolderButton = true;
            folderDialog.RootFolder = Environment.SpecialFolder.Desktop;

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                var parentPath = folderDialog.SelectedPath;

                _backgroundWorker.DoWork += _backgroundWorker_DoWork;
                _backgroundWorker.RunWorkerAsync(parentPath);
                _callBackObj.Invoke("Generating Document Please Wait...");
                btnGenerateDoc.Enabled = false;
                _backgroundWorker.RunWorkerCompleted += (s, ex) =>
                {
                    _callBackObj("Documents Generated Successfully", true);
                    _populateQuotations();
                    var bindingList = new BindingList<Quotation>(_quotations);
                    dgvrfqQuotes.DataSource = bindingList;
                };

            }


        }

        private void _backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var quotes = new List<Quotation>();
            var parentPath = (string)e.Argument;
            for (var i = 0; i < dgvrfqQuotes.SelectedRows.Count; i++)
            {
                var quoteID = dgvrfqQuotes.SelectedRows[i];
                var quote = (Quotation)quoteID.DataBoundItem;
                quotes.Add(quote);

            }
            var quotationGenerator = new QuotationGenerator();
            foreach (var quote in quotes)
            {
                var quotationFolder = $"{parentPath}\\QuoteID{quote.QuotationID}\\";
                quote.Suppliers.ForEach((s) =>
                {

                    var supplierID = s.SupplierID;
                    string path = Path.Combine(quotationFolder, s.SupplierName);
                    Directory.CreateDirectory(path);
                    quotationGenerator.GenerateQuote(quote.QuotationID, s.SupplierID, path);
                    quote.Status = "Printed";
                    _setAction.UpdateQuotation(quote);
                });
            }
        }



        private void dgvrfqQuotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                _selectedQuote = _quotations[e.RowIndex];
                _suppliers = _selectedQuote.Suppliers;
                _items = new ViewQuotations().GetGenericItems(_selectedQuote.QuotationID);
                if (_selectedQuote.Status == "Printed" || _selectedQuote.Status == "PO Created")
                    btnGenerateDoc.Enabled = false;
                else
                    btnGenerateDoc.Enabled = true;
                _populateSuppliers();
                _populateItems();



            }
            catch (Exception)
            {

            }
        }

        private void txtQuotesSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgvrfqQuotes.ClearSelection();
            if (txtQuotesSearch.Text.Trim() == "")
            {
                _populateQuotations();
            }
            else
            {
                _quotations = _viewAssets.retrieveData<Quotation>();
                var list = _quotations.FindAll(quote =>
                    (quote.Employee.FirstName.ToLower().Contains(txtQuotesSearch.Text.Trim()))
                    || quote.Employee.MiddleName.ToLower().Contains(txtQuotesSearch.Text.ToLower().Trim())
                    || quote.Employee.LastName.ToLower().Contains(txtQuotesSearch.Text.ToLower().Trim())
                    || (quote.Status.ToLower().Contains(txtQuotesSearch.Text.ToLower().Trim()))
                    || (quote.CreatedDate.ToString().ToLower().Contains(txtQuotesSearch.Text.ToLower().Trim()))
                    || (quote.ExpirationDate.ToString().ToLower().Contains(txtQuotesSearch.Text.ToLower().Trim()))
                    || (quote.Remarks.ToLower().Contains(txtQuotesSearch.Text.ToLower().Trim()))
                    || (quote.QuotationID.ToString().Contains(txtQuotesSearch.Text.ToLower().Trim()))
                    ); ;
                _populateQuotations(list);
            }


            var bindingList = new BindingList<Quotation>(_quotations);
            dgvrfqQuotes.DataSource = bindingList;
            dgvrfqItems.ClearSelection();
        }

        private void txtSuppliersSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtSuppliersSearch.Text.Trim() != "")
            {
                _suppliers = _selectedQuote.Suppliers;
                _suppliers = _suppliers.FindAll(
                    supplier =>
                    (supplier.SupplierName.Contains(txtSuppliersSearch.Text))
                    || (supplier.Address.Contains(txtSuppliersSearch.Text))
                    || (supplier.Email.Contains(txtSuppliersSearch.Text))
                    || (supplier.SupplierID.ToString().Contains(txtSuppliersSearch.Text)
                    || (supplier.PaymentTerms.PaymentTermName.ToLower().
                    Contains(txtSuppliersSearch.Text))));
                _populateSuppliers(_suppliers);
            }
            else
            {
                _populateSuppliers();
            }
        }

        private void txtItemsSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtItemsSearch.Text.Trim() != "")
            {
                _items = new ViewQuotations().GetGenericItems(_selectedQuote.QuotationID);
                _items = _items.FindAll(
                    item =>
                    (item.ItemName.Contains(txtItemsSearch.Text))
                    || (item.Color.Contains(txtItemsSearch.Text))
                    || (item.Quantity.ToString().Contains(txtItemsSearch.Text))
                    || (item.QuotationItemID.ToString().Contains(txtItemsSearch.Text))
                    || (item.QuoteID.ToString().Contains(txtItemsSearch.Text))
                    );
                _populateItems(_items);
            }
            else
            {
                _populateItems();
            }
        }

        private void dgvrfqItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
