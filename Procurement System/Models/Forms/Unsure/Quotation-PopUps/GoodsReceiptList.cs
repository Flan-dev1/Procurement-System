using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class GoodsReceiptList : Form
    {

        private BackgroundWorker _worker, _itemWorker;
        private Helper _helperDB;
        private int id, _grpoID;
        DataTable _tableData, _itemTableData;
        public GoodsReceiptList(int id)
        {
            InitializeComponent();
            _helperDB = new Helper();
            _initializeWorker();
            this.id = id;
        }

        private void _initializeWorker()
        {
            _worker = new BackgroundWorker();
            _itemWorker = new BackgroundWorker(); 
            _worker.DoWork += (s, e) =>
            {

                var query = $"SELECT GRPO.GoodsReceiptID, CONCAT(EMP.FirstName,' ',EMP.LastName) AS 'Employee Name', " +
                $"GRPO.EmployeeID, GRPO.TotalPrice, GRPO.ReceivedDate FROM GRPO INNER JOIN QuotationPurchaseOrder QPO ON " +
                $"GRPO.PurchaseOrderID = QPO.PurchaseOrderID INNER JOIN Employee EMP ON GRPO.EmployeeID = EMP.EmployeeID " +
                $"WHERE QPO.PurchaseOrderID='{id}'";
                _tableData = _helperDB.GetData(query);
            
            };

            _worker.RunWorkerCompleted += (s, e) =>
            {
                dgvGRPOList.DataSource = _tableData;
            };

            _itemWorker.DoWork += (s, e) =>
            {

                    var query = $"SELECT GRPOI.ItemName, GRPOI.DeliveredQuantity, GRPOI.Comment FROM GRPOItem GRPOI INNER JOIN " +
                $"GRPO ON GRPOI.GoodReceiptID = GRPO.GoodsReceiptID WHERE GRPOI.GoodReceiptID='{_grpoID}'";
                    _itemTableData = _helperDB.GetData(query);
            };

            _itemWorker.RunWorkerCompleted += (s, e) =>
            {
                _loadItems();
            };
        }
        
        private void _loadItems()
        {
            dgvGRPOItem.DataSource = _itemTableData;
        }

        private void GoodsReceiptList_Load(object sender, EventArgs e)
        {
            _worker.RunWorkerAsync();
        }

        private void dgvGRPOList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvGRPOList.SelectedRows.Count > 0)
            {
                _grpoID = Convert.ToInt32(dgvGRPOList.SelectedRows[0].Cells[0].Value.ToString());
                _itemWorker.RunWorkerAsync();
            }
        }
    }
}
