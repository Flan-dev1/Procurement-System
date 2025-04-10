using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class ReleaseItem : Form
    {
        private Helper _dbHelper;
        private string _query;
        private DataTable _supplierList;
        private BackgroundWorker _worker;
        private Product _selectedProduct;
        private int itemID, empID;
        public ReleaseItem(int itemID, int empID)
        {
            InitializeComponent();
            _dbHelper = new Helper();
            _initializeWorkers();
            this.itemID = itemID;
            this.empID = empID;
        }

        private void _initializeWorkers()
        {
            {
                _worker = new BackgroundWorker();
                _worker.DoWork += (s, e) =>
                {
                    _dbHelper = new Helper();
                    _query = $"SELECT SII.ProductID AS 'Product ID', SI.ItemName AS 'Item Name', SII.Color, " +
                    $"SII.UnitPrice AS 'Unit Price', SII.Stocks, S.SupplierName AS 'Supplier Name' " +
                    $"FROM SupplierItemDetails SII INNER JOIN Supplier S ON " +
                    $"SII.SupplierID = S.SupplierID INNER JOIN SupplierItem SI ON SII.ItemID " +
                    $"= SI.ItemID WHERE SII.ItemID='{itemID}' AND SII.Stocks > 0";
                    _supplierList = _dbHelper.GetData(_query);
                };
                _worker.RunWorkerCompleted += (s, e) =>
                {
                    _loadTable();
                };
            }
        }

        private void _loadTable()
        {
            dgvSupplier.DataSource = _supplierList;
            dgvSupplier.ClearSelection();
        }

        private void ReleaseItem_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];
                _selectedProduct = new Product();
                _selectedProduct.ProductID = Convert.ToInt32(row.Cells[0].Value);
                _query = $"SELECT ItemID FROM SupplierItemDetails WHERE ProductID='{_selectedProduct.ProductID}'";
                _selectedProduct.ItemID = Convert.ToInt32(_dbHelper.GetData(_query).Rows[0][0]);
                _selectedProduct.ItemName = row.Cells[1].Value.ToString();
                _selectedProduct.Color = row.Cells[2].Value.ToString();
                _selectedProduct.Price = Convert.ToDouble(row.Cells[3].Value);
                _selectedProduct.Quantity = Convert.ToInt32(row.Cells[4].Value);
                _selectedProduct.ItemSupplier = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(s => s.SupplierName ==
                row.Cells[5].Value.ToString());
                lblItemID.Text = _selectedProduct.ItemID.ToString();
                lblItemName.Text = _selectedProduct.ItemName;
                lblColor.Text = _selectedProduct.Color;
                lblUnitPrice.Text = _selectedProduct.Price.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-PH"));
                txtQuantity.Text = _selectedProduct.Quantity.ToString();
                txtQuantity.ReadOnly = false;
            }
        }

        private void bnUpdateItem_Click(object sender, EventArgs e)
        {

            int quantity = Convert.ToInt32(txtQuantity.Text.Trim());
            _selectedProduct.Quantity -= quantity;
            _query = $"UPDATE SupplierItemDetails SET Stocks='{_selectedProduct.Quantity}' WHERE ProductID = '{_selectedProduct.ProductID}' AND SupplierID='{_selectedProduct.ItemSupplier.SupplierID}'";
            _dbHelper.AddUpdDelData(_query);
            _query = $"INSERT INTO InventoryReport VALUES ('{_selectedProduct.ItemID}', " +
                $"'{_selectedProduct.ItemSupplier.SupplierID}', '{DateTime.Now}', '{quantity}', '{empID}')";
            _dbHelper.AddUpdDelData(_query);
            _message(message: "Item Updated Successfully");
            _worker.RunWorkerAsync();

        }

        private void _message(string message, bool isSuccess = true)
        {

            if (isSuccess)
            {
                lblInputMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblInputMessage.ForeColor = System.Drawing.Color.Red;
            }
            lblInputMessage.Text = message;

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtSearch.Text.Trim() != string.Empty)
            {
                var input = txtSearch.Text.Trim();
                _query = $"SELECT SII.ItemID AS 'Item ID', SI.ItemName AS 'Item Name', SII.Color, " +
                    $"SII.UnitPrice AS 'Unit Price', SII.Stocks, S.SupplierName AS 'Supplier Name' " +
                    $"FROM SupplierItemDetails SII INNER JOIN Supplier S ON " +
                    $"SII.SupplierID = S.SupplierID INNER JOIN SupplierItem SI ON SII.ItemID " +
                    $"= SI.ItemID WHERE (SII.ItemID='{itemID}' AND SII.Stocks > 0 AND (S.SupplierName " +
                    $"LIKE '%{input}%' OR SII.Color LIKE '%{input}%' OR SII.Stocks LIKE '%{input}%'))";
                _supplierList = _dbHelper.GetData(_query);
                _loadTable();
            }else
            {
                _worker.RunWorkerAsync();
            }
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {

            lblInputMessage.Text = "";
            try
            {
                int quantity = Convert.ToInt32(txtQuantity.Text.Trim());
                if (quantity > _selectedProduct.Quantity)
                {
                    _message(message: "Quantity is greater than the stocks available", false);
                    btnUpdateItem.Enabled = false;
                }
                else if (quantity < 0)
                {
                    _message(message: "Quantity cannot be less than 0", false);
                    btnUpdateItem.Enabled = false;
                }
                else
                {
                    btnUpdateItem.Enabled = true;
                }
            }
            catch (Exception)
            {
                if (txtQuantity.Text == "")
                {
                    lblInputMessage.Text = "";
                    btnUpdateItem.Enabled = false;
                    return;
                }
                _message(message: "Quantity must be a number", false);
                btnUpdateItem.Enabled = false;
            }

        }
    }
}
