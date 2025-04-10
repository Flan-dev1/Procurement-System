using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class UpdateGenericItem : Form
    {
        private int _itemID;
        private BackgroundWorker _worker;
        private List<ItemCategory> _categories;
        private List<ItemType> _itemTypes;
        private Product _selectedProduct;
        private Helper _dbHelper;
        private string _query;
        public UpdateGenericItem(int itemID)
        {
            InitializeComponent();
            _itemID = itemID;
            _initializeWorkers();
            _dbHelper = new Helper();
        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {

                _categories = new ViewCategories().retrieveData<ItemCategory>();
                _itemTypes = new ViewItemType().retrieveData<ItemType>();
                _selectedProduct = new ViewItemProducts().retrieveData<Product>().Find(x => x.ItemID == _itemID);

            };
            _worker.RunWorkerCompleted += (s, e) =>
            {

                cmbCategory.DataSource = _categories;
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
                cmbItemType.DataSource = _itemTypes;
                cmbItemType.DisplayMember = "TypeName";
                cmbItemType.ValueMember = "ItemTypeID";
                cmbCategory.DataSource = new BindingList<ItemCategory>(_categories);
                cmbItemType.DataSource = new BindingList<ItemType>(_itemTypes);
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_selectedProduct.ItemCategory.CategoryName);
                cmbItemType.SelectedIndex = cmbItemType.FindStringExact(_selectedProduct.ItemType.TypeName);
                txtItemName.Text = _selectedProduct.ItemName;
            };
        }

        private void UpdateGenericItem_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill up all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else
            {
                _query = $"SELECT * FROM SupplierItem WHERE LOWER(ItemName)='{txtItemName.Text.ToLower().Trim()}' " +
                    $"AND NOT ItemID='{_selectedProduct.ItemID}'";
                if (_dbHelper.IsExist(_query))
                {
                    MessageBox.Show("This item name is already exists");
                }else
                {
                    _query = $"UPDATE SupplierItem SET ItemName='{txtItemName.Text.Trim()}', CategoryID='{cmbCategory.SelectedValue}', ItemTypeID='{cmbItemType.SelectedValue}' WHERE ItemID='{_selectedProduct.ItemID}'";
                    _dbHelper.AddUpdDelData(_query);
                    MessageBox.Show("Item updated");
                }
            }
        }
    }
}
