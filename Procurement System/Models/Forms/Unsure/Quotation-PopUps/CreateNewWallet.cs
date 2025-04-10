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
    public partial class CreateNewWallet : Form
    {
        private string _query;
        private Helper _dbHelper;
        public CreateNewWallet()
        {
            InitializeComponent();
            _dbHelper = new Helper();
            
        }

        private bool _checkInput()
        {

            if (txtWalletName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a wallet name");
                return false;
            }

            if (txtBalance.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a balance");
                return false;
            }

            if (txtBalance.Text.Trim().Any(char.IsLetter))
            {

                MessageBox.Show("Invalid Balance");
                return false;
            }

            if (Convert.ToDecimal(txtBalance.Text.Trim()) < 0)
            {
                MessageBox.Show("Invalid Balance");
                return false;
            }
            _query = $"SELECT * FROM BusinessWallet WHERE WalletName='{txtWalletName.Text.Trim()}'";
            if(_dbHelper.GetData(_query).Rows.Count > 0)
            {
                
                MessageBox.Show("Wallet name already exist try again");
                return false;
            }
            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!_checkInput()) return;
            var name = txtWalletName.Text.Trim();
            var balance = Convert.ToDecimal(txtBalance.Text.Trim());
            _query = $"INSERT INTO BusinessWallet(WalletName, TotalBalance) VALUES('{name}', {balance}, '0')";
            _dbHelper.AddUpdDelData(_query);
            MessageBox.Show("Wallet Added Successfully");
            Close();
        }
    }
}
