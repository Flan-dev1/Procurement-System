using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.UpdateMasterData
{
    public partial class UpdateWalletBalance : Form
    {
        private Helper _dbHelper;
        private string _query;
        public UpdateWalletBalance()
        {
            InitializeComponent();
            _loadData();
        }

        private void _loadData()
        {
            txtBalance.Text = "";
            _dbHelper = new Helper();
            _query = "SELECT * FROM BusinessWallet WHERE Archived = 0";
            cbxWallet.DataSource = _dbHelper.GetData(_query);
            cbxWallet.DisplayMember = "WalletName";
            cbxWallet.ValueMember = "BusinessWalletID";
            cbxWallet.SelectedIndex = -1;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxWallet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxWallet.SelectedIndex != -1)
            {
                var value = cbxWallet.SelectedValue;
                _query = "SELECT TotalBalance FROM BusinessWallet WHERE BusinessWalletID = " + value;
                txtBalance.Text = _dbHelper.GetData(_query).Rows[0][0].ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cbxWallet.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a wallet to update");
                return;
            }

            if (txtBalance.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a valid balance");
                return;
            }

            //check if the txt contains a letter
            if (txtBalance.Text.Trim().Any(char.IsLetter))
            {
                MessageBox.Show("Please enter a valid balance");
                return;
            }
            //check if the txt is a negative number or zero
            if (Convert.ToDecimal(txtBalance.Text.Trim()) <= 0)
            {
                MessageBox.Show("Please enter a valid balance");
                return;
            }
            var value = cbxWallet.SelectedValue;
            _query = "UPDATE BusinessWallet SET TotalBalance = " + txtBalance.Text + " WHERE BusinessWalletID = " + value;
            _dbHelper.AddUpdDelData(_query);
            _loadData();
            MessageBox.Show("Wallet balance updated successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this wallet?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var value = cbxWallet.SelectedValue;
                _query = "Update BusinessWallet SET Archived=1 WHERE BusinessWalletID = " + value;
                _dbHelper.AddUpdDelData(_query);
                MessageBox.Show("Wallet deleted successfully");

                _loadData();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newWallet = new CreateNewWallet();
            newWallet.StartPosition = FormStartPosition.CenterScreen;
            newWallet.ShowDialog();
            _loadData();
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
