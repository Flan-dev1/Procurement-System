using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class QuotationList : Form
    {

        private BackgroundWorker _worker;
        private List<Quotation> _quotations;
        private ViewData _viewData;
        private Action<Quotation> _callBack;
        private Quotation _selectedQuote;
        public QuotationList(Action<Quotation> callBack)
        {
            InitializeComponent();
            _callBack = callBack;
            _selectedQuote = null;

            _worker = new BackgroundWorker();
            _worker.DoWork += (e, args) =>
            {
                _viewData = new ViewQuotations();
                _quotations = _viewData.retrieveData<Quotation>();
                _quotations = _quotations.Where(quote => quote.Status != "PO Created").ToList();
                _quotations = _quotations.GroupBy(x => x.QuotationID).Select(x => x.First()).ToList();
            };
            _worker.RunWorkerCompleted += (e, x) =>
            {
                _populateQuotations();
            };
        }

        private void _populateQuotations()
        {
            var bindingList = new BindingList<Quotation>(_quotations);
            dgvrfqQuotes.DataSource = bindingList;
        }


        private void QuotationList_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void btnSelectQuote_Click(object sender, EventArgs e)
        {
            _callBack(_selectedQuote);
            Close();
        }

        private void dgvrfqQuotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _selectedQuote = (Quotation)dgvrfqQuotes.Rows[e.RowIndex].DataBoundItem;
            }
            catch (Exception)
            {

            }


        }

        private void QuotationList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_selectedQuote == null)
            {
                MessageBox.Show("No Quotation is selected.");
            }
        }
    }
}
