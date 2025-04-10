using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.BookKeeperMenus.Quotation_PopUps
{
    public partial class frmSupplierList : Form
    {
        private ViewData viewAssets;
        private List<SupplierModel> list, _searchSupplier;
        private Action<SupplierModel> _callBack;
        public frmSupplierList(Action<SupplierModel> callback, bool multiSelect = true)
        {
            InitializeComponent();
            viewAssets = new ViewSupplierInfo();
            list = new List<SupplierModel>();
            _callBack = callback;
            dgvSupplierInfo.Columns.Add("SupplierID", "Supplier ID");
            dgvSupplierInfo.Columns.Add("SupplierName", "Supplier Name");
            dgvSupplierInfo.Columns.Add("SupplierAddress", "Address");
            dgvSupplierInfo.Columns.Add("SupplierEmail", "Email");
            dgvSupplierInfo.Columns.Add("SupplierPaymentTerms", "Payment Terms");
            dgvSupplierInfo.MultiSelect = multiSelect;


        }

        private void frmSupplierList_Load(object sender, EventArgs e)
        {

            _loadTable();

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSupplierInfo.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSupplierInfo.SelectedRows)
                {
                    var id = Convert.ToInt32(row.Cells[0].Value);
                    foreach (var supp in list)
                    {
                        if (supp.SupplierID == id)
                        {
                            _callBack(supp);
                        }
                    }
                }
            }
            if (!dgvSupplierInfo.MultiSelect)
                Close();
        }
        private void _loadTable(List<SupplierModel> filtered = null)
        {
            var data = new List<SupplierModel>();
            dgvSupplierInfo.Rows.Clear();
            if (filtered == null)
            {
             this.list = viewAssets.retrieveData<SupplierModel>();
                data = list;
            }else
            {
                data = filtered;
            }
            foreach (var supplier in data)
            {
                dgvSupplierInfo.Rows.Add(supplier.SupplierID, supplier.SupplierName, supplier.Address, supplier.Email,
                    supplier.PaymentTerms.PaymentTermName);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.Trim();
            if(input != string.Empty)
            {
                _searchSupplier = list.FindAll(s => s.SupplierName.ToLower().Contains(input.ToLower()) 
                || s.Address.ToLower().Contains(input.ToLower()) || s.Email.ToLower().Contains(input.ToLower()) || 
                s.PaymentTerms.PaymentTermName.ToLower().Contains(input.ToLower()));
                _loadTable(_searchSupplier);
            }else
            {
                _loadTable();
            }
        }
    }
}
