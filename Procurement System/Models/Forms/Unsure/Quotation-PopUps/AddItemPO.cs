using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class AddItemPO : Form
    {

        private DataTable _itemsTable;
        private Helper _dbHelper;
        private int _itemID;
        private BackgroundWorker _worker;
        private Action<Product> _callBack;
        private string _query;
        public AddItemPO(Action<Product> callBack, int itemID)
        {
            InitializeComponent();
            _callBack = callBack;
            _initializeWorkers();
            _dbHelper = new Helper();
            _itemID = itemID;
        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {

                _query = $"SELECT SII.ProductID AS 'ID', SI.ItemName, " +
                $"SII.UnitPrice, SII.Color, SII.Stocks, S.SupplierName FROM " +
                $"SupplierItemDetails SII INNER JOIN Supplier S ON SII.SupplierID = S.SupplierID INNER " +
                $"JOIN SupplierItem SI ON SII.ItemID = SI.ItemID WHERE SI.ItemID={_itemID} AND SII.Archived = 0 AND S.Archived = 0";
                _itemsTable = _dbHelper.GetData(_query);
            };

            _worker.RunWorkerCompleted += (s, e) =>
            {
                _loadTable();
            };

        }

        private void _loadTable()
        {

            dgvSupplierItemList.DataSource = _itemsTable;
            var checkBox = new DataGridViewCheckBoxColumn();
            checkBox.HeaderText = "Select";
            dgvSupplierItemList.Columns.Add(checkBox);

        }

        private void AddItemPO_Load(object sender, EventArgs e)
        {

            _worker.RunWorkerAsync();

        }

        private void btnSelectItems_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvSupplierItemList.Rows)
            {
                if (Convert.ToBoolean(row.Cells[6].Value))
                {
                    var product = new Product();
                    product.ProductID = Convert.ToInt32(row.Cells[0].Value);
                    product.ItemID = _itemID;
                    product.ItemName = row.Cells[1].Value.ToString();
                    product.Price = Convert.ToDouble(row.Cells[2].Value);
                    product.Color = row.Cells[3].Value.ToString();
                    product.ItemSupplier = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(x => x.SupplierName == row.Cells[5].Value.ToString());
                    _callBack(product);
                    
                }
                
            }
            Close();
        }
    }
}
