using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class CreateItem : Form
    {
        public Action<Product, int> _callBack;
        private List<Product> _items;
        private DataTable _itemTable;
        private Product _selectedProduct;

        public CreateItem(Action<Product, int> callBack)
        {
            InitializeComponent();
            _items = new List<Product>();
            _itemTable = new DataTable();
            _callBack = callBack;
        }

        private void _addExistingItems(Product p)
        {
            //check if item already exists based on its name
            var item = _items.FirstOrDefault(i => i.ItemName == p.ItemName);
            if (item != null)
            {
                //if item exists, increase its quantity
                item.Quantity += p.Quantity;
            }
            else
            {
                //if item does not exist, add it to the list
                _items.Add(p);
            }
            _refreshTable();
        }
        private void _refreshTable()
        {
            _itemTable.Rows.Clear();
            if (_itemTable.Columns.Count == 0)
            {
                _itemTable.Columns.Add("Item ID");
                _itemTable.Columns.Add("Item Name");
                _itemTable.Columns.Add("Category Name");
                _itemTable.Columns.Add("Item Type");
            }
            foreach (var item in _items)
            {
                _itemTable.Rows.Add(item.ItemID, item.ItemName,
                    item.ItemCategory.CategoryName, item.ItemType.TypeName);
            }
            dgvSelectedItems.DataSource = _itemTable;

        }

        private void CreateItem_Load(object sender, EventArgs e)
        {
            var categories = new ViewCategories().retrieveData<ItemCategory>();
            var type = new ViewItemType().retrieveData<ItemType>();

            var categoryBindingList = new BindingList<ItemCategory>(categories);
            var typeBindingList = new BindingList<ItemType>(type);
            //set the comboboxes to the binding lists
            cmbCategory.DataSource = categoryBindingList;
            cmbItemType.DataSource = typeBindingList;
            //set the display member to the name of the item
            cmbCategory.DisplayMember = "CategoryName";
            cmbItemType.DisplayMember = "TypeName";
            //set the value member to the id of the item
            cmbCategory.ValueMember = "CategoryID";
            cmbItemType.ValueMember = "ItemTypeID";

            cmbCategory.SelectedIndex = -1;
            cmbItemType.SelectedIndex = -1;

        }
        private bool _checkInput()
        {
            {
                //check all textboxes for empty values
                var itemName = txtItemName.Text.Trim();
                var itemDescription = txtDescription.Text.Trim();
                var color = txtColor.Text.Trim();
                var itemPrice = txtUnitPrice.Text.Trim();
                var itemQuantity = txtQuantity.Text.Trim();
                if (cmbCategory.SelectedIndex == -1 && _selectedProduct == null)
                {
                    MessageBox.Show("Please select a category");
                    return false;
                }
                if (cmbItemType.SelectedIndex == -1 && _selectedProduct == null)
                {
                    MessageBox.Show("Please select a type");
                    return false;
                }
                if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemPrice) || string.IsNullOrEmpty(color))
                {
                    MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                try
                {
                    if (txtUnitPrice.Text.Contains("E") || txtUnitPrice.Text.Contains("e"))
                    {

                        MessageBox.Show("Invalid Unit Price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var price = Convert.ToDecimal(itemPrice);
                    if (price <= 0)
                    {
                        MessageBox.Show("Price must be greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (itemQuantity != "")
                    {
                        if (txtQuantity.Text.Contains("E") || txtQuantity.Text.Contains("e"))
                        {
                            MessageBox.Show("Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        var quantity = Convert.ToInt32(itemQuantity);
                        if (quantity <= 0)
                        {
                            MessageBox.Show("Quantity must be greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    return true;
                }
                catch (Exception)
                {

                    MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }
            }
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!_checkInput()) return;
            var itemID = 0;
            var itemName = "";
            if (new ViewItemProducts().retrieveData<Product>().Find(x => x.ItemName == txtItemName.Text) != null)
            {
                var res = new ViewItemProducts().retrieveData<Product>().Find(x => x.ItemName == txtItemName.Text);
                itemID = res.ItemID;
                itemName = res.ItemName;
            }
            itemName = txtItemName.Text.Trim();
            var description = txtDescription.Text.Trim();
            var color = txtColor.Text.Trim();
            var unitPrice = txtUnitPrice.Text.Trim();
            var quantity = txtQuantity.Text.Trim();
            var category = new ViewCategories().retrieveData<ItemCategory>().Find(c => c.CategoryID
            == Convert.ToInt32(cmbCategory.SelectedValue));
            var type = new ViewItemType().retrieveData<ItemType>().Find(i => i.ItemTypeID
            == Convert.ToInt32(cmbItemType.SelectedValue));
            if (string.IsNullOrEmpty(quantity))
                quantity = "0";
            if (string.IsNullOrEmpty(description))
                description = "No Description Provided";

            var product = new Product()
            {
                ItemID = itemID,
                ItemName = txtItemName.Text,
                Color = color,
                Description = description,
                Price = Convert.ToDouble(unitPrice),
                Quantity = Convert.ToInt32(quantity),
                ItemCategory = category,
                ItemType = type
            };
            _callBack(product, -1);

            if (_selectedProduct != null)
            {
                dgvSelectedItems.Rows.RemoveAt(dgvSelectedItems.SelectedRows[0].Index);
                _selectedProduct = null;
            }
            _clearInput();
        }

        private void btnAddExistingItem_Click(object sender, EventArgs e)
        {

            var findItem = new ItemList(_addExistingItems);
            findItem.StartPosition = FormStartPosition.CenterScreen;
            findItem.Show();

        }

        private void _loadSelectedItem()
        {

            if (_selectedProduct == null) return;
            txtItemName.Text = _selectedProduct.ItemName;
            txtDescription.Text = _selectedProduct.Description;
            txtColor.Text = _selectedProduct.Color;
            txtUnitPrice.Text = _selectedProduct.Price.ToString();
            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_selectedProduct.ItemCategory.CategoryName);
            cmbItemType.SelectedIndex = cmbItemType.FindStringExact(_selectedProduct.ItemType.TypeName);
            cmbCategory.Enabled = false;
            cmbItemType.Enabled = false;

        }

        private void dgvSelectedItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = dgvSelectedItems.Rows[e.RowIndex];
                var itemID = Convert.ToInt32(row.Cells[0].Value);
                var itemName = row.Cells[1].Value.ToString();
                var category = new ViewCategories().retrieveData<ItemCategory>().Find(c => c.CategoryName
                == row.Cells[2].Value.ToString());
                var type = new ViewItemType().retrieveData<ItemType>().Find(i => i.TypeName
                == row.Cells[3].Value.ToString());
                _selectedProduct = new Product()
                {
                    ItemID = itemID,
                    ItemName = itemName,
                    ItemCategory = category,
                    ItemType = type,

                };
                _loadSelectedItem();

            }

        }

        private void _clearInput()
        {
            txtItemName.Text = "";
            txtDescription.Text = "";
            txtColor.Text = "";
            txtUnitPrice.Text = "";
            txtQuantity.Text = "";
            cmbCategory.SelectedIndex = -1;
            cmbItemType.SelectedIndex = -1;
            cmbCategory.Enabled = true;
            cmbItemType.Enabled = true;
            _selectedProduct = null;
            dgvSelectedItems.ClearSelection();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            _clearInput();

        }
    }
}
