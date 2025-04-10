using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class SupplierItemList : Form
    {

        private BackgroundWorker _worker;
        private DataTable _itemTableData;
        private Helper _dbHelper;
        private string _query;
        private Action<Product> _callBack;
        public SupplierItemList(Action<Product> _callbackFunc)
        {
            InitializeComponent();
            _initializeWorkers();
            _dbHelper = new Helper();
            _callBack = _callbackFunc;
            _worker.RunWorkerAsync();
        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {

                _query = $"SELECT SI.ItemID, SI.ItemName, SUM(SII.Stocks) AS 'Total Stocks' FROM " +
                $"SupplierItem SI INNER JOIN SupplierItemDetails SII ON SI.ItemID = " +
                $"SII.ItemID WHERE SI.Archived = 0 GROUP BY SI.ItemID, SI.ItemName";
                _itemTableData = _dbHelper.GetData(_query);

            };

            _worker.RunWorkerCompleted += (s, e) =>
            {
                _loadItems();

            };
        }

        private void _loadItems(DataTable list = null)
        {

            dgvItemSupplier.DataSource = null;
            dgvItemSupplier.Columns.Clear();
            dgvItemSupplier.Rows.Clear();
            if (list == null)
                dgvItemSupplier.DataSource = _itemTableData;
            else
                dgvItemSupplier.DataSource = list;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Select Supplier";
            dgvItemSupplier.Columns.Add(btn);
            foreach (DataGridViewRow row in dgvItemSupplier.Rows)
            {
                DataGridViewCell cell = row.Cells[3];//Column Index
                cell.Value = "Select Supplier";
            }
        }

        private void SupplierItemList_Load(object sender, EventArgs e)
        {

        }

        private void dgvItemSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender; 

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //get the value of the first cell
                int itemID = Convert.ToInt32(dgvItemSupplier.Rows[e.RowIndex].Cells[0].Value);
                var additemPOWindow = new AddItemPO(_callBack, itemID);
                additemPOWindow.StartPosition = FormStartPosition.CenterScreen;
                additemPOWindow.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.Trim();

            if(input != string.Empty)
            {
                _query = $"SELECT SI.ItemID, SI.ItemName, SUM(SII.Stocks) AS 'Total Stocks' FROM " +
                $"SupplierItem SI INNER JOIN SupplierItemDetails SII ON SI.ItemID = " +
                $"SII.ItemID WHERE SI.Archived = 0 AND (SI.ItemID LIKE '%{input}%' OR " +
                $"SI.ItemName LIKE '%{input}%' OR SII.Stocks LIKE '%{input}%') GROUP BY SI.ItemID, SI.ItemName"    ;
                var res = _dbHelper.GetData(_query);
                _loadItems(res);
            }else
            {
                _itemTableData.Rows.Clear();
                _worker.RunWorkerAsync();
            }
        }
    }
}
