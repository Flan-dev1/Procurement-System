using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class PendingAPList : Form
    {

        private string _query;
        private Helper _dbHelper;
        private BackgroundWorker _worker;
        private DataTable _tableList;
        private Action<SupplierModel> _callBack;
        private SupplierModel _selectedSupplier;
        public PendingAPList(Action<SupplierModel> callBack)
        {
            InitializeComponent();
            _dbHelper = new Helper();
            _callBack = callBack;
            _initializeWorkers();

        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {
                _query = $"SELECT S.SupplierID, S.SupplierName, SUM(AP.TotalAmount) AS 'Total BP Balance' FROM AccountsPayable " +
                    $"AP INNER JOIN Supplier S ON AP.SupplierID = S.SupplierID INNER JOIN PaymentTerms PT ON " +
                    $"S.PaymentTermsID = PT.PaymentTermsID WHERE AP.isPaid = 0 GROUP BY S.SupplierName, S.SupplierID HAVING SUM(AP.TotalAmount) > 0";
                _tableList = _dbHelper.GetData(_query);
            };
            _worker.RunWorkerCompleted += (s, e) =>
            {
                _loadTable();
            };

        }

        private void _loadTable()
        {
            dgvPendingAP.DataSource = _tableList;
            dgvPendingAP.ClearSelection();
        }

        private void PendingAPList_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            _selectedSupplier = new ViewSupplierInfo().retrieveData<SupplierModel>().
                Find(s => s.SupplierID == _selectedSupplier.SupplierID);
            _callBack(_selectedSupplier);
            Close();
        }

        private void dgvPendingAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPendingAP.Rows[e.RowIndex];
                _selectedSupplier = new SupplierModel();
                _selectedSupplier.SupplierID = Convert.ToInt32(row.Cells["SupplierID"].Value);
                _selectedSupplier.SupplierName = row.Cells["SupplierName"].Value.ToString();
                btnSelect.Enabled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            var input = textBox1.Text.Trim();
            if(input == string.Empty)
            {
                _worker.RunWorkerAsync();
            }
            else
            {

                _query = $"SELECT S.SupplierID, S.SupplierName, SUM(AP.TotalAmount) AS 'Total BP Balance' FROM AccountsPayable " +
                    $"AP INNER JOIN Supplier S ON AP.SupplierID = S.SupplierID INNER JOIN PaymentTerms PT ON " +
                    $"S.PaymentTermsID = PT.PaymentTermsID WHERE S.SupplierName LIKE '%{input}%' OR S.SupplierID LIKE '%{input}%' " +
                    $"GROUP BY S.SupplierName, S.SupplierID";
                _tableList = _dbHelper.GetData(_query);
                _loadTable();
            }
                

        }
    }
}
