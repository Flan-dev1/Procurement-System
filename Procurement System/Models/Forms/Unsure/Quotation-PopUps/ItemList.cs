using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class ItemList : Form
    {
        private BackgroundWorker _worker;
        private string _query;
        private Helper _dbHelper;
        private DataTable _itemTable;
        private Action<Product> _callBack;
        public ItemList(Action<Product> callBack)
        {
            InitializeComponent();
            _dbHelper = new Helper();
            _itemTable = new DataTable();
            _callBack = callBack;
            _initializeWorkers();

        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {
                _query = $"SELECT SI.ItemID AS 'Item ID', SI.ItemName AS 'Item Name', " +
                $"C.CategoryName AS 'Category Name'," +
                $"IT.TypeName AS 'Item Type' FROM SupplierItem SI INNER JOIN SupplierItemDetails SII ON SI.ItemID = " +
                $"SII.ItemID INNER JOIN Category C ON SI.CategoryID = C.CategoryID INNER JOIN ItemType " +
                $"IT ON SI.ItemTypeID = IT.ItemTypeID WHERE SI.Archived=0 GROUP BY SI.ItemName, C.CategoryName, IT.TypeName, SI.ItemID";
                _itemTable = _dbHelper.GetData(_query);
            };
            _worker.RunWorkerCompleted += (s, e) =>
            {
                dgvItemList.DataSource = _itemTable;
                var checkBox = new DataGridViewCheckBoxColumn();
                checkBox.HeaderText = "Select";
                dgvItemList.Columns.Add(checkBox);
            };
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void ItemList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void _checkSelectedItems()
        {

            foreach (DataGridViewRow row in dgvItemList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    var product = new Product();
                    product.ItemID = Convert.ToInt32(row.Cells[0].Value.ToString());
                    product.ItemName = row.Cells[1].Value.ToString();
                    product.ItemCategory = new ViewCategories().retrieveData<ItemCategory>().Find( i => 
                    i.CategoryName == row.Cells[2].Value.ToString()); 
                    product.ItemType = new ViewItemType().retrieveData<ItemType>().Find( i => 
                    i.TypeName == row.Cells[3].Value.ToString()); 
                    _callBack(product);
                }

            }
            Close();


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            _checkSelectedItems();
        }
    }
}
