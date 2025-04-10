using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class UpdateItem : Form
    {
        private int _itemID;
        private BackgroundWorker _worker;
        private string _query;
        private Helper _dbHelper;
        private DataTable _tableData;
        private Product _selectedProduct;
        public UpdateItem(int itemID)
        {
            InitializeComponent();
            _itemID = itemID;
            _dbHelper = new Helper();
            _initializeWorkers();
            _worker.RunWorkerAsync();
        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            {
                _worker.DoWork += (s, e) =>
                {

                    _query = $"SELECT SII.ProductID AS 'Item ID', SI.ItemName AS 'Item Name', SII.Color, " +
                    $"SII.UnitPrice, SII.Stocks, SII.Description," +
                    $" S.SupplierName AS 'Supplier Name' FROM SupplierItemDetails SII " +
                    $"INNER JOIN Supplier S ON SII.SupplierID " +
                    $"= S.SupplierID INNER JOIN SupplierItem SI ON SII.ItemID = " +
                    $"SI.ItemID WHERE SII.ItemID = '{_itemID}' " +
                    $"AND SII.Archived=0";
                    _tableData = _dbHelper.GetData(_query);

                };
                _worker.RunWorkerCompleted += (s, e) =>
                {

                    dgvSupplierList.DataSource = _tableData;

                };
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var window = new UpdateGenericItem(_itemID);
            window.StartPosition = FormStartPosition.CenterScreen;
            window.ShowDialog();
            _worker.RunWorkerAsync();
        }

        private void _setItemInfo()
        {
            lblItemName.Text = _selectedProduct.ItemName;
            txtColor.Text = _selectedProduct.Color;
            txtUnitPrice.Text = CurrencyFormat.FormatCurrency(_selectedProduct.Price);
            txtDescription.Text = _selectedProduct.Description;
        }
        private bool _checkInput()
        {
            try
            {
                if (txtColor.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a color");
                    return false;
                }
                if (txtUnitPrice.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a unit price");
                    return false;
                }
                if (txtDescription.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a description");
                    return false;
                }

                //prevent exponential notation on txtUnitPrice
                if (txtUnitPrice.Text.Contains("E") || txtUnitPrice.Text.Contains("e"))
                {
                    MessageBox.Show("Please enter a valid unit price");
                    return false;
                }
                Convert.ToDouble(txtUnitPrice.Text);
                _selectedProduct.Price = Convert.ToDouble(txtUnitPrice.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid unit price");
                return false;
            }

            return true;
        }


        private void dgvSupplierList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var row = dgvSupplierList.Rows[e.RowIndex];
                _selectedProduct = new Product();
                //get selected itemid on table
                _selectedProduct.ProductID = Convert.ToInt32(row.Cells[0].Value);
                _selectedProduct.ItemName = row.Cells[1].Value.ToString();
                _selectedProduct.Color = row.Cells[2].Value.ToString();
                _selectedProduct.Price = Convert.ToDouble(row.Cells[3].Value);
                _selectedProduct.Description = row.Cells[5].Value.ToString();
                _selectedProduct.ItemSupplier = new ViewSupplierInfo().retrieveData<SupplierModel>().
                    Find(x => x.SupplierName == row.Cells[6].Value.ToString());
                _setItemInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_selectedProduct != null)
            {
                if (MessageBox.Show("Are you sure to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvSupplierList.Rows.Count == 1)
                    {
                        if (MessageBox.Show("Are you sure you want to remove this item in your inventory?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            _query = $"UPDATE SupplierItem SET Archived='1' " +
                            $"WHERE ProductID='{_selectedProduct.ProductID}'";
                            _dbHelper.AddUpdDelData(_query);
                            MessageBox.Show("Item Deleted.");
                            Close();
                            return;
                        }
                    }
                    _query = $"UPDATE SupplierItemDetails SET Archived='1' " +
                        $"WHERE ProductID='{_selectedProduct.ProductID}' AND SupplierID='{_selectedProduct.ItemSupplier.SupplierID}'";
                    _dbHelper.AddUpdDelData(_query);
                    MessageBox.Show("Item Updated.");
                    _worker.RunWorkerAsync();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!_checkInput())
                return;
            if(MessageBox.Show("Are you sure you want to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _selectedProduct.Color = txtColor.Text.Trim();
                _selectedProduct.Price = Convert.ToDouble(txtUnitPrice.Text.Trim());
                _selectedProduct.Description = txtDescription.Text.Trim();
                _query = $"UPDATE SupplierItemDetails SET Color='{_selectedProduct.Color}',"+
                        $" UnitPrice='{_selectedProduct.Price}', Description='{_selectedProduct.Description}' WHERE ProductID='{_selectedProduct.ProductID}' " +
                        $"AND SupplierID='{_selectedProduct.ItemSupplier.SupplierID}'";
                    _dbHelper.AddUpdDelData(_query);
                    MessageBox.Show("Item Updated.");
                    _worker.RunWorkerAsync();
            }
        }
    }
}
