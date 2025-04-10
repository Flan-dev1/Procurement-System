using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;

namespace Procurement_System.Models.Forms.UpdateMasterData
{
    public partial class UpdateItemData : Form
    {
        private BackgroundWorker _worker;
        private EmployeeModel _model;
        private Helper _dbHelper;
        private DataTable _itemTable;
        string _query = "";
        int _itemID;
        public UpdateItemData(EmployeeModel model)
        {
            InitializeComponent();
            _model = model;
            _dbHelper = new Helper();
            _initializeWorkers();
            _worker.RunWorkerAsync();
            _loadComboBoxValues();
            _setupRestrictions(_checkUserLogin());

        }

        private bool _checkUserLogin()
        {
            switch (_model.getEmployeeType().getType())
            {
                case "Admin Manager":
                    return true;
                default:
                    return false;
            }
        }

        private void _setupRestrictions(bool hasAthority)
        {
            bool enabled = hasAthority;
            txtItemName.Enabled = enabled;
            btnUpdateItemInfo.Visible = enabled;
            btnEnterAdmin.Visible = !enabled;


        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {
                _query = $"SELECT SI.ItemID AS 'Item ID', SI.ItemName AS 'Item Name', " +
                $"SUM(SII.Stocks) AS 'Total Stocks', C.CategoryName AS 'Category Name'," +
                $"IT.TypeName AS 'Item Type' FROM SupplierItem SI INNER JOIN SupplierItemDetails SII ON " +
                $"SI.ItemID = " +
                $"SII.ItemID INNER JOIN Category C ON SI.CategoryID = C.CategoryID INNER JOIN ItemType " +
                $"IT ON SI.ItemTypeID = IT.ItemTypeID WHERE SI.Archived=0 AND SII.Archived=0 " +
                $"GROUP BY SI.ItemName, C.CategoryName, IT.TypeName, SI.ItemID";
                _itemTable = _dbHelper.GetData(_query);
            };
            _worker.RunWorkerCompleted += (s, e) =>
            {

                _loadItems();

            };

        }

        private void _loadComboBoxValues()
        {
            var categories = new ViewCategories().retrieveData<ItemCategory>().ToList();
            cbxCategory.Items.Add("");
            categories.ForEach(c => cbxCategory.Items.Add(c.CategoryName));
            var itemType = new ViewItemType().retrieveData<ItemType>().ToList();
            itemType.ForEach(i => cbxItemType.Items.Add(i.TypeName));

            _query = $"SELECT * FROM ItemType";
            var res = _dbHelper.GetData(_query);
            cbxSort.Items.Add("");
            foreach (DataRow row in res.Rows)
            {
                cbxSort.Items.Add(row["TypeName"].ToString());
            }
            cbxSort.SelectedIndex = 0;

        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var updateItemWindow = new UpdateItem(_itemID);
            updateItemWindow.StartPosition = FormStartPosition.CenterScreen;
            updateItemWindow.ShowDialog();
            _worker.RunWorkerAsync();
            txtItemName.Text = "";
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            var releaseItemWindow = new ReleaseItem(_itemID, _model.getEmployeeID());
            releaseItemWindow.StartPosition = FormStartPosition.CenterScreen;
            releaseItemWindow.ShowDialog();
            _worker.RunWorkerAsync();
        }

        private void btnEnterAdmin_Click(object sender, System.EventArgs e)
        {
            var adminMode = new AdminMode(_setupRestrictions);
            adminMode.StartPosition = FormStartPosition.CenterScreen;
            adminMode.ShowDialog();

        }

        private void _loadItems()
        {
            dgvrItemList.DataSource = _itemTable;
            btnUpdate.Enabled = false;
            btnUpdateItemInfo.Enabled = false;
            btnUpdate.BackColor = SystemColors.Control;
            btnUpdateItemInfo.BackColor = SystemColors.Control;
        }

        private void dgvrItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvrItemList.Rows[e.RowIndex];
                _itemID = int.Parse(row.Cells[0].Value.ToString());
                txtItemName.Text = row.Cells[1].Value.ToString();
                cbxCategory.SelectedIndex = cbxCategory.FindStringExact(row.Cells[3].Value.ToString());
                cbxItemType.SelectedIndex = cbxItemType.FindStringExact(row.Cells[4].Value.ToString());
                btnUpdate.Enabled = true;
                btnUpdateItemInfo.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
                btnUpdateItemInfo.BackColor = Color.FromArgb(255, 255, 192);
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            if (input != string.Empty)
            {
                _query = $"SELECT SI.ItemID AS 'Item ID', SI.ItemName AS 'Item Name', SUM(SII.Stocks) AS 'Total Stocks', " +
                    $"C.CategoryName AS 'Category Name',IT.TypeName " +
                    $"AS 'Item Type' FROM SupplierItem SI INNER JOIN SupplierItemDetails SII ON SI.ItemID = " +
                    $"SII.ItemID INNER JOIN Category C ON " +
                    $"SI.CategoryID = C.CategoryID INNER JOIN ItemType IT ON SI.ItemTypeID = " +
                    $"IT.ItemTypeID WHERE SI.Archived=0 AND SII.Archived=0 AND ( " +
                    $"SI.ItemID LIKE '%{input}%' OR SI.ItemName LIKE '%{input}%' " +
                    $"OR SII.Stocks LIKE '%{input}%' OR C.CategoryName LIKE '%{input}%' OR IT.TypeName " +
                    $"LIKE '%{input}%' ) GROUP BY SI.ItemName, C.CategoryName, IT.TypeName, SI.ItemID ";
                _itemTable = _dbHelper.GetData(_query);
                _loadItems();

            }
            else
            {
                _worker.RunWorkerAsync();
            }
        }

        private void cbxSort_SelectionChangeCommitted(object sender, System.EventArgs e)
        {

            if(cbxSort.SelectedIndex != 0)
            {
            var value = cbxSort.Text.Trim();
                _query = $"SELECT * FROM ItemType WHERE TypeName = '{value}'";
                int id = Convert.ToInt32(_dbHelper.GetData(_query).Rows[0][0]);
            _query = $"SELECT SI.ItemID AS 'Item ID', SI.ItemName AS 'Item Name', SUM(SII.Stocks) AS 'Total Stocks', " +
                                $"C.CategoryName AS 'Category Name',IT.TypeName " +
                                $"AS 'Item Type' FROM SupplierItem SI INNER JOIN SupplierItemDetails SII ON SI.ItemID = " +
                                $"SII.ItemID INNER JOIN Category C ON " +
                                $"SI.CategoryID = C.CategoryID INNER JOIN ItemType IT ON SI.ItemTypeID = " +
                                $"IT.ItemTypeID WHERE SI.Archived=0 AND SII.Archived=0 AND SI.ItemTypeID='{id}'" +
                                $" GROUP BY SI.ItemName, C.CategoryName, IT.TypeName, SI.ItemID ";
            _itemTable = _dbHelper.GetData(_query);    
            _loadItems();
            }else
            {
                _worker.RunWorkerAsync();
                
            }
            
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblCurrentTime_Click(object sender, System.EventArgs e)
        {

        }

        private void lblTime_Click(object sender, System.EventArgs e)
        {

        }
    }


}
