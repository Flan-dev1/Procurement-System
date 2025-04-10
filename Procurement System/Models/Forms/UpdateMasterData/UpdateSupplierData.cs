using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using Procurement_System.Services.Authentication;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Procurement_System.Models.Forms.UpdateMasterData
{
    public partial class UpdateSupplierData : Form
    {

        private List<SupplierModel> _suppliers, _searchSupplierValues;
        private BackgroundWorker _worker;
        private SupplierModel _selectedSupplier;
        private List<PaymentTerms> _paymentTerms;
        private ViewData _viewAssets;
        private readonly EmployeeModel _model;
        public UpdateSupplierData(EmployeeModel _model)
        {
            InitializeComponent();
            _viewAssets = new ViewSupplierInfo();
            _loadStartUp();
            this._model = _model;
        }

        private bool _checkInput()
        {
            {
                //check all textboxes for empty values
                var supplierName = txtSuppName.Text.Trim();
                var supplierAddress = txtAddress.Text.Trim();
                var emailAddress = txtEmail;
                var paymentTerms = cbxPT.SelectedValue == null ? "" :
                    cbxPT.SelectedValue.ToString();

                var isExist = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(s => s.SupplierName.ToLower() == supplierName);
                if (isExist != null)
                {
                    MessageBox.Show("Supplier is already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                var emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (supplierName == string.Empty || supplierAddress == string.Empty || emailAddress.Text.Trim() == string.Empty || paymentTerms == string.Empty)
                {
                    MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!emailRegex.IsMatch(emailAddress.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    return true;
                }

            }
        }

        private void _loadStartUp()
        {
            _initializeWorker();

            _paymentTerms = new ViewPaymentTerms().retrieveData<PaymentTerms>().Where(pt => pt.Archived == 0).ToList();
            cbxPT.DataSource = _paymentTerms;
            cbxPT.DisplayMember = "PaymentTermName";
            cbxPT.ValueMember = "Id";
            cbxPT.SelectedIndex = -1;
            _worker.RunWorkerAsync();
        }

        private void _resetValues()
        {
            txtSuppName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbxPT.SelectedIndex = -1;
            _selectedSupplier = null;

        }

        private void _initializeWorker()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {
                _suppliers = _viewAssets.retrieveData<SupplierModel>().FindAll(supp => supp.Archived == 0).ToList();
            };

            _worker.RunWorkerCompleted += (s, e) =>
            {
                _populateSupplier();
            };
        }

        private void _populateSupplier(List<SupplierModel> list = null)
        {
            BindingList<SupplierModel> bindingList;
            if(list == null)
            bindingList = new BindingList<SupplierModel>(_suppliers);
            else
            bindingList = new BindingList<SupplierModel>(list);
            dgvrSupplierList.DataSource = bindingList;
            dgvrSupplierList.Columns.Remove("Archived");
            dgvrSupplierList.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var createSupplier = new CreateSupplier(_model);
            createSupplier.StartPosition = FormStartPosition.CenterScreen;
            createSupplier.ShowDialog();
            _worker.RunWorkerAsync();
        }

        private void dgvrSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                _selectedSupplier = (SupplierModel)dgvrSupplierList.Rows[e.RowIndex].DataBoundItem;
                txtSuppName.Text = _selectedSupplier.SupplierName;
                txtAddress.Text = _selectedSupplier.Address;
                txtEmail.Text = _selectedSupplier.Email;
                cbxPT.SelectedIndex = cbxPT.FindStringExact(_selectedSupplier.PaymentTerms.PaymentTermName);
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
                btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            }
        }

        private void _deleteSupplier(IUpdateSupplier action)
        {


            action.DeleteSupplier(_selectedSupplier);
            _selectedSupplier = null;

        }

        private void _updateSupplier(IUpdateSupplier action)
        {

            action.UpdateSupplier(_selectedSupplier);
            _selectedSupplier = null;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedSupplier != null)
            {
                if (MessageBox.Show("Are you sure you want to remove this supplier?",
                    "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _deleteSupplier(EmployeeFactory.UpdateSupplierAction(_model));
                    MessageBox.Show("Supplier has been removed");
                    _resetValues();
                    _worker.RunWorkerAsync();
                }
            }
        }

        private void _setItemValues()
        {

            _selectedSupplier.SupplierName = txtSuppName.Text.Trim();
            _selectedSupplier.Address = txtAddress.Text.Trim();
            _selectedSupplier.Email = txtEmail.Text.Trim();
            _selectedSupplier.PaymentTerms = (PaymentTerms)cbxPT.SelectedItem;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedSupplier != null && _checkInput())
            {
                if (MessageBox.Show("Are you sure you want to update this supplier?",
                    "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _setItemValues();
                    _updateSupplier(EmployeeFactory.UpdateSupplierAction(_model));
                    MessageBox.Show("Supplier has been updated");
                    _resetValues();
                    _worker.RunWorkerAsync();
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            //search
            if(input != string.Empty)
            {
                _searchSupplierValues = _suppliers.FindAll(s => s.SupplierName.ToLower().Contains(input) || s.Address.ToLower().Contains(input) 
                || s.Email.ToLower().Contains(input) 
                || s.PaymentTerms.PaymentTermName.ToLower().Contains(input));
                _populateSupplier(_searchSupplierValues);
            }else
            {
                _worker.RunWorkerAsync();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
