using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using Procurement_System.Services.Authentication;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class CreateSupplier : Form
    {

        private List<Product> _supplierItems;
        private DataTable _itemTable;
        private readonly EmployeeModel _model;
        private bool _checkInput()
        {
            //check all textboxes for empty values
            var supplierName = txtSupplierName.Text.Trim();
            var supplierAddress = txtAddress.Text.Trim();
            var emailAddress = txtEmail;
            var paymentTerms = cmbPaymentTerms.SelectedValue == null ? "" :
                cmbPaymentTerms.SelectedValue.ToString();

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

        private void _clearInput()
        {

            txtSupplierName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cmbPaymentTerms.SelectedIndex = -1;
            _supplierItems.Clear();
            _itemTable.Rows.Clear();

        }
        public CreateSupplier(EmployeeModel model)
        {
            InitializeComponent();
            _itemTable = new DataTable();
            _supplierItems = new List<Product>();
            _model = model;
        }

        private void CreateSupplier_Load(object sender, EventArgs e)
        {

            var list = new ViewPaymentTerms().retrieveData<PaymentTerms>();
            var bindingList = new BindingList<PaymentTerms>(list);
            cmbPaymentTerms.DataSource = bindingList;
            cmbPaymentTerms.DisplayMember = "PaymentTermName";
            cmbPaymentTerms.ValueMember = "Id";
            cmbPaymentTerms.SelectedIndex = -1;

        }

        private void _addItem(Product p, int index = -1)
        {

            if (index != -1)
            {
                _supplierItems[index] = p;
                _loadTable();
                return;
            }
            bool found = false;
            foreach (var item in _supplierItems)
            {
                if (item.ItemName == p.ItemName && item.Color == p.Color)
                {
                    found = true;
                    item.Quantity += p.Quantity;
                    item.Price = p.Price;
                    item.ItemCategory = p.ItemCategory;
                    item.ItemType = p.ItemType;
                    break;
                }

            }
            if (!found)
                _supplierItems.Add(p);
            _loadTable();
        }

        private void _loadTable()
        {
            //Remove duplicates on the list based on its name

            _supplierItems = _supplierItems.GroupBy(x => new { x.ItemID, x.Color }).Select(x => x.First()).ToList();

            //Clear the table
            _itemTable.Rows.Clear();
            if (_itemTable.Columns.Count == 0)
            {
                _itemTable.Columns.Add("Item Name", typeof(string));
                _itemTable.Columns.Add("Color", typeof(string));
                _itemTable.Columns.Add("Item Description", typeof(string));
                _itemTable.Columns.Add("Item Price", typeof(decimal));
                _itemTable.Columns.Add("Item Quantity", typeof(int));
                _itemTable.Columns.Add("Category", typeof(string));
                _itemTable.Columns.Add("Item Type", typeof(string));
            }
            //set itemTable values from _supplierItem
            foreach (var item in _supplierItems)
            {
                _itemTable.Rows.Add(item.ItemName, item.Color, item.Description,
                    item.Price, item.Quantity, item.ItemCategory.CategoryName,
                    item.ItemType.TypeName);
            }

            dgvSupplierItems.DataSource = _itemTable;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            var createItemWindow = new CreateItem(_addItem);
            createItemWindow.StartPosition = FormStartPosition.CenterScreen;
            createItemWindow.Show();
        }

        private void dgvSupplierItems_MouseDown(object sender, MouseEventArgs e)
        {
            //create a right mouse click event
            if (e.Button == MouseButtons.Right)
            {
                //get the index of the row
                var rowIndex = dgvSupplierItems.HitTest(e.X, e.Y).RowIndex;
                if (rowIndex >= 0)
                {
                    //select the row
                    dgvSupplierItems.ClearSelection();
                    dgvSupplierItems.Rows[rowIndex].Selected = true;
                    //create a context menu
                    var menu = new ContextMenuStrip();
                    menu.Items.Add("Edit").Name = "Edit";
                    menu.Items.Add("Delete").Name = "Delete";
                    //show the context menu
                    menu.Show(dgvSupplierItems, new System.Drawing.Point(e.X, e.Y));
                    //add an event handler for the menu item
                    menu.ItemClicked += (s, ev) =>
                    {
                        if (ev.ClickedItem.Name == "Edit")
                        {
                            var editItem = new EditItem(_supplierItems[rowIndex], _addItem, rowIndex);
                            editItem.StartPosition = FormStartPosition.CenterScreen;
                            editItem.ShowDialog();
                        }
                        else if (ev.ClickedItem.Name == "Delete")
                        {
                            _deleteItems();
                        }
                    };

                }
            }
        }

        private void _createSupplier(IUpdateSupplier action, SupplierModel supplier)
        {
            action.AddSupplier(supplier);
        }

        private void btnCreateSupplier_Click(object sender, EventArgs e)
        {
            if (!_checkInput()) return;
            if (MessageBox.Show("Are you sure you want to create this supplier?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var supplier = new SupplierModel();
                supplier.SupplierName = txtSupplierName.Text.Trim();
                supplier.Address = txtAddress.Text.Trim();
                supplier.Email = txtEmail.Text.Trim();
                supplier.PaymentTerms = new ViewPaymentTerms().retrieveData<PaymentTerms>().Find(pt => pt.Id ==
                Convert.ToInt32(cmbPaymentTerms.SelectedValue));
                if (dgvSupplierItems.Rows.Count > 0)
                {
                    supplier.Items = _supplierItems;
                }
                _createSupplier(EmployeeFactory.UpdateSupplierAction(_model), supplier);
                MessageBox.Show("Supplier Created");
                _clearInput();
            }

        }

        private void _deleteItems()
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvSupplierItems.SelectedRows)
                {
                    _supplierItems.RemoveAt(row.Index);
                }
                _loadTable();
            }
        }

        private void dgvSupplierItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _deleteItems();

            }
        }
    }
}
