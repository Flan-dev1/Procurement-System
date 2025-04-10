using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Services;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.UpdateMasterData
{
    public partial class UpdatePaymentTerms : Form
    {
        public BackgroundWorker _worker;
        private List<PaymentTerms> _paymentTerms;
        string query;
        private PaymentTerms _selectedPaymentTerms;
        public UpdatePaymentTerms()
        {
            InitializeComponent();
            _initializeWorkers();
            _worker.RunWorkerAsync();
        }

        private void _clearTextBoxes()
        {

            txtDiscount.Text = "";
            txtDueDate.Text = "";
            txtValidity.Text = "";

        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {
                _paymentTerms = new ViewPaymentTerms().retrieveData<PaymentTerms>().Where(pt => pt.Archived == 0).ToList();
            };
            _worker.RunWorkerCompleted += (s, e) =>
            {

                cbxPaymentTermName.DataSource = _paymentTerms;
                cbxPaymentTermName.DisplayMember = "PaymentTermName";
                cbxPaymentTermName.ValueMember = "Id";
                cbxPaymentTermName.SelectedIndex = -1;
                _clearTextBoxes();
            };
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvrPaymentTermList_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void _loadInfo()
        {
            if (_selectedPaymentTerms == null) return;
            txtDiscount.Text = _selectedPaymentTerms.Discount.ToString();
            txtValidity.Text = _selectedPaymentTerms.DiscountValidity.ToString();
            txtDueDate.Text = _selectedPaymentTerms.DueDate.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void cbxPaymentTermName_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void cbxPaymentTermName_SelectionChangeCommitted(object sender, EventArgs e)
        {

            _selectedPaymentTerms = _paymentTerms.Find(x => x.PaymentTermName ==
            cbxPaymentTermName.SelectedItem.ToString());
            _loadInfo();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var ptWindow = new CreatePaymentTerms();
            ptWindow.StartPosition = FormStartPosition.CenterScreen;
            ptWindow.ShowDialog();
            _worker.RunWorkerAsync();

        }

        private bool _checkInput()
        {
            try
            {

                if (txtDiscount.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a discount");
                    return false;
                }
                if (txtDueDate.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a due date");
                    return false;
                }
                if (txtValidity.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a validity");
                    return false;
                }
                var discount = Convert.ToDouble(txtDiscount.Text);
                if (discount < 0)
                {
                    MessageBox.Show("Invalid Discount");
                    return false;
                }

                if (txtDiscount.Text.Contains("E") || txtDiscount.Text.Contains("e")
                    || txtValidity.Text.Contains("E")
                    || txtValidity.Text.Contains("e")
                    || txtDueDate.Text.Contains("E") || txtDueDate.Text.Contains("e"))
                {
                    throw new Exception();
                }

                var discountValidity = Convert.ToInt32(txtValidity.Text);
                if (discountValidity < 0)
                {

                    MessageBox.Show("Invalid Discount Validity");
                    return false;

                }

                var dueDate = Convert.ToInt32(txtDueDate.Text);
                if (dueDate < 0)
                {
                    MessageBox.Show("Invalid Due Date");
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

            if (!_checkInput()) return;
            _selectedPaymentTerms.Id = Convert.ToInt32(cbxPaymentTermName.SelectedValue.ToString());
            _selectedPaymentTerms.Discount = Convert.ToDouble(txtDiscount.Text.Trim());
            _selectedPaymentTerms.DiscountValidity = Convert.ToInt32(txtValidity.Text.Trim());
            _selectedPaymentTerms.DueDate = Convert.ToInt32(txtDueDate.Text.Trim());
            query = $"UPDATE PaymentTerms SET Discount='{_selectedPaymentTerms.Discount}'," +
                $"DiscountValidity='{_selectedPaymentTerms.DiscountValidity}', " +
                $"Validity='{_selectedPaymentTerms.DueDate}' WHERE PaymentTermsID='{_selectedPaymentTerms.Id}'";
            new Helper().AddUpdDelData(query);
            MessageBox.Show("Payment term has been updated");
            _worker.RunWorkerAsync();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove this Payment Terms?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var ptID = Convert.ToInt32(cbxPaymentTermName.SelectedValue.ToString());

                query = $"UPDATE PaymentTerms SET Archived='1' WHERE PaymentTermsID='{ptID}'";
                new Helper().AddUpdDelData(query);
                MessageBox.Show("Payment term has been removed");
                _worker.RunWorkerAsync();

            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            //search
        }
    }
}
