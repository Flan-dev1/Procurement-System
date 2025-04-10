using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class EditItem : Form
    {
        private Action<Product, int> _addItem;
        private Product _product;
        private int index;
        public EditItem(Product editItem, Action<Product, int> callBack, int index)
        {
            InitializeComponent();
            _addItem = callBack;
            txtItemName.Text = editItem.ItemName;
            txtItemDescription.Text = editItem.Description;
            txtItemColor.Text = editItem.Color;
            txtItemPrice.Text = editItem.Price.ToString();
            _product = editItem;

            bool hasID = _product.ItemID != 0;
            cmbCategory.Enabled = !hasID;
            cmbItemType.Enabled = !hasID;
            this.index = index;
        }

        private bool _checkInput()
        {

            //check all textboxes for empty values
            var itemName = txtItemName.Text.Trim();
            var itemDescription = txtItemDescription.Text.Trim();
            var color = txtItemColor.Text.Trim();
            var itemPrice = txtItemPrice.Text.Trim();
            var itemQuantity = txtItemQuantity.Text.Trim();
            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(itemPrice) || string.IsNullOrEmpty(color))
            {
                MessageBox.Show("Please fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                if (txtItemPrice.Text.Contains("E") || txtItemPrice.Text.Contains("e"))
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
                    if (txtItemQuantity.Text.Contains("E") || txtItemQuantity.Text.Contains("e"))
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

        private void EditItem_Load(object sender, EventArgs e)
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

            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_product.ItemCategory.CategoryName);
            cmbItemType.SelectedIndex = cmbItemType.FindStringExact(_product.ItemType.TypeName);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
            var description = txtItemDescription.Text.Trim();
            var color = txtItemColor.Text.Trim();
            var unitPrice = txtItemPrice.Text.Trim();
            var quantity = txtItemQuantity.Text.Trim();
            var category = new ViewCategories().retrieveData<ItemCategory>().Find(x => x.CategoryName == 
            cmbCategory.Text);
            var type = new ViewItemType().retrieveData<ItemType>().Find(x => x.TypeName == 
            cmbItemType.Text);
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
            _product = product;

            _addItem(_product, index);
            Close();
        }
    }
}
