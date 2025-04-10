using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class WalletList : Form
    {

        private Helper _dbHelper;
        private BackgroundWorker _worker;
        private DataTable _tableData;
        private Action<BusinessWallet> _walletCallBack;
        private BusinessWallet _selectedWallet;
        public WalletList(Action<BusinessWallet> businessWallet)
        {
            InitializeComponent();
            _initializeWorkers();
            _walletCallBack = businessWallet;
        }

        private void _initializeWorkers()
        {
            {
                _worker = new BackgroundWorker();
                _worker.DoWork += (s, e) =>
                {
                    _dbHelper = new Helper();
                    _tableData = _dbHelper.GetData("SELECT BusinessWalletID, WalletName," +
                        "TotalBalance  FROM BusinessWallet WHERE Archived != 0");
                };
                _worker.RunWorkerCompleted += (s, e) =>
                {
                    dgvWalletList.DataSource = _tableData;
                    dgvWalletList.ClearSelection();
                };
            }
        }

        private void WalletList_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void btnSelectWallet_Click(object sender, EventArgs e)
        {
            _walletCallBack(_selectedWallet);
            Close();
        }

        private void dgvWalletList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedWallet = new BusinessWallet()
                {
                    BusinessWalletID = dgvWalletList.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    WalletName = dgvWalletList.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    TotalBalance = double.Parse(dgvWalletList.Rows[e.RowIndex].Cells[2].Value.ToString())
                };
                btnSelectWallet.Enabled = true;
            }
        }
    }
}
