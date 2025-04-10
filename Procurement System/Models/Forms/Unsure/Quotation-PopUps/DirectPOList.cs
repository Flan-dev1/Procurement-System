using Procurement_System.Models.Forms.PurchaseOrders;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class DirectPOList : Form
    {
        private BackgroundWorker _poWorker, _poListWorker;
        private string _query;
        private DataTable _poListTable, _itemTable;
        private DataTable _poItemsTable;
        private Helper _dbHelper;
        private int _id, _poDetailsID, _lastPosition;
        private SupplierModel _selectedSupplier;
        private Button _grpoButton;
        public DirectPOList(Button invoker)
        {
            InitializeComponent();
            _dbHelper = new Helper();
            _initializeWorkers();
            _grpoButton = invoker;
        }

        private void _initializeWorkers()
        {

            _poWorker = new BackgroundWorker();
            _poListWorker = new BackgroundWorker();
            _poWorker.DoWork += (s, e) =>
            {
                _query = $"SELECT DirectPOID AS 'Direct POID', Remarks, CreatedDate AS " +
                $"'Created Date' FROM DirectPurchaseOrder;";
                _poListTable = _dbHelper.GetData(_query);
            };
            _poWorker.RunWorkerCompleted += (s, e) =>
            {
                _loadPurchaseOrders();
            };
            _poListWorker.DoWork += (s, e) =>
            {
                _query = $"SELECT * FROM DirectPODetails WHERE ID='{_id}';";
                _poItemsTable = _dbHelper.GetData(_query);
            };
            _poListWorker.RunWorkerCompleted += (s, e) =>
            {
                _loadList();
            };

        }

        private void _loadPurchaseOrders(DataTable list = null)
        {
            dgvPOList.DataSource = null;
            dgvPOList.Rows.Clear();
            if (list == null)
                dgvPOList.DataSource = _poListTable;
            else
                dgvPOList.DataSource = list;

        }

        private void dgvPOList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _id = Convert.ToInt32(dgvPOList.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (_poListWorker.IsBusy == false)
                {
                    _poListWorker.RunWorkerAsync();
                }
            }
        }

        private void dgvPODetailsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _poDetailsID = Convert.ToInt32(dgvPODetailsList.Rows[e.RowIndex].Cells[1].Value.ToString());
                _selectedSupplier = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(s => s.SupplierName ==
                dgvPODetailsList.Rows[e.RowIndex].Cells[2].Value.ToString());
                _lastPosition = e.RowIndex;
                var poStatus = dgvPODetailsList.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (poStatus == "Pending" || poStatus == "Partial")
                {
                    btnCreateGRPO.Enabled = true;
                }
                else
                {
                    btnCreateGRPO.Enabled = false;
                }
                btnShowItems.Enabled = true;


            }

        }

        private void txtItemSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtItemSearch.Text.Trim();
            if (input != string.Empty)
            {
                _query = $"SELECT * FROM DirectPODetails WHERE ID='{_id}' AND ([DirectPO ID] LIKE " +
                    $"'%{input}%' OR [Supplier Name] LIKE '%{input}%' OR [PO Status] LIKE '%{input}%' OR " +
                    $"[Total Items] LIKE '%{input}%');";
                var res = _dbHelper.GetData(_query);
                _loadList(res);
            }
            else
            {
                _poListWorker.RunWorkerAsync();
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            var input = txtPOSearch.Text.Trim();
            if (input != string.Empty)
            {
                _query = $"SELECT DirectPOID AS 'Direct POID', Remarks, CreatedDate AS " +
                $"'Created Date' FROM DirectPurchaseOrder WHERE (DirectPOID LIKE '%{input}%' OR Remarks LIKE " +
                $"'%{input}%' OR CreatedDate LIKE '%{input}%')";
                var res = _dbHelper.GetData(_query);
                _loadPurchaseOrders(res);
            }
            else
            {
                _poListWorker.RunWorkerAsync();
            }

        }

        private void btnShowItems_Click(object sender, EventArgs e)
        {
            var window = new ViewDPOItemList(_poDetailsID);
            window.StartPosition = FormStartPosition.CenterScreen;
            window.ShowDialog();
        }

        private void btnCreateGRPO_Click(object sender, EventArgs e)
        {

            _query = $"SELECT * FROM DPOSupplierItem WHERE DirectPODetailsID = '{_poDetailsID}' " +
                $"AND SupplierID='{_selectedSupplier.SupplierID}'";
            _itemTable = _dbHelper.GetData(_query);
            ViewPOList._itemTable = _itemTable;
            var directPO = new DirectPurchaseOrder();
            directPO.ID = _poDetailsID;
            var directPODetails = new List<DirectPurchaseOrder.DirectPurchaseOrderDetails>();
            var directPODetail = new DirectPurchaseOrder.DirectPurchaseOrderDetails();
            directPODetail.ID = _poDetailsID;
            directPODetail.Supplier = _selectedSupplier;
            _query = $"SELECT AccountPayableID FROM DirectPurchaseOrderDetails WHERE DirectPODetailsID='{_poDetailsID}';";
            var res = Convert.ToInt32(_dbHelper.GetData(_query).Rows[0][0].ToString());
            var ap = new AccountPayable();
            _query = $"SELECT * FROM AccountsPayable WHERE AccountPayableID='{res}';";
            var apTable = _dbHelper.GetData(_query);
            ap.AccountPayableID = Convert.ToInt32(apTable.Rows[0][0].ToString());
            ap.TotalAmount = Convert.ToDouble(apTable.Rows[0][1].ToString());
            ap.IsPaid = Convert.ToBoolean(apTable.Rows[0][2].ToString());
            ap.Supplier = new SupplierModel();
            ap.Supplier.SupplierID = Convert.ToInt32(apTable.Rows[0][3].ToString());
            ap.Supplier = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(s => s.SupplierID == ap.Supplier.SupplierID);
            directPODetail.AP = ap;
            directPODetail.PurchaseOrderStatus = dgvPODetailsList.Rows[_lastPosition].Cells[2].Value.ToString();

            foreach (DataRow row in _itemTable.Rows)
            {

                var item = new Product();
                item.ProductID = Convert.ToInt32(row["ItemID"].ToString());
                item.ItemID = Convert.ToInt32(row["ItemID"].ToString());
                item.ItemName = row["Item Name"].ToString();
                item.Color = row["Color"].ToString();
                item.Quantity = Convert.ToInt32(row["Quantity"].ToString());
                item.Price = Convert.ToDouble(row["UnitPrice"].ToString());
                item.TotalPrice = Convert.ToDouble(row["TotalPrice"].ToString());
                item.ItemSupplier = _selectedSupplier;
                directPODetail.Items.Add(item);

            }

            directPODetails.Add(directPODetail);
            directPO.DirectPurchaseOrderDetail = directPODetails;
            ViewPOList._selectedPO = directPO;
            _grpoButton.Enabled = true;
            _grpoButton.PerformClick();
            Close();

        }

        private void _loadList(DataTable list =null)
        {
            if (list == null)
                dgvPODetailsList.DataSource = _poItemsTable;
            else
                dgvPODetailsList.DataSource = list;
            dgvPODetailsList.ClearSelection();
            btnCreateGRPO.Enabled = false;
            btnShowItems.Enabled = false;
        }

        private void DirectPOList_Load(object sender, EventArgs e)
        {
            _poWorker.RunWorkerAsync();
        }
    }
}
