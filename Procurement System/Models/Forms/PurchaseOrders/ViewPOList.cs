using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System;

namespace Procurement_System.Models.Forms.PurchaseOrders
{
    public partial class ViewPOList : Form
    {

        private ViewData _viewAssets;
        public static DataTable _itemTable;
        public static DirectPurchaseOrder _selectedPO;
        private EmployeeModel _model;
        private List<QuotationPurchaseOrder> _purchaseOrders;
        private QuotationPurchaseOrder _selectedQPO;
        private SelectedQuotation _QPOProperties;
        public bool IsChild = false, IsFiltered = false;
        private BackgroundWorker _poWorker, _itemWorker;
        private Helper _dbHelper;
        private string _query;
        public ViewPOList(EmployeeModel model)
        {
            InitializeComponent();
            _initializeWorkers();
            _loadStartUp();
            _model = model;
        }

        private void _initializeWorkers()
        {
            _poWorker = new BackgroundWorker();
            _itemWorker = new BackgroundWorker();
            _poWorker.DoWork += (s, e) =>
            {

                _viewAssets = new ViewPO();
                _purchaseOrders = _viewAssets.retrieveData<QuotationPurchaseOrder>();
                if (IsFiltered)
                {
                    _purchaseOrders = _purchaseOrders.Where(x => x.PurchaseOrderStatus == "Pending" ||
                    x.PurchaseOrderStatus == "Partial").ToList();
                }
                _query = $"SELECT * FROM QuotationPurchaseOrder WHERE PurchaseOrderStatus = 'Pending' OR PurchaseOrderStatus = 'Partial'";


            };
            _poWorker.RunWorkerCompleted += (s, e) =>
            {
                _loadPurchaseOrders();
            };
            _itemWorker.DoWork += (s, e) =>
            {
                _selectedQPO = (QuotationPurchaseOrder)dgvrPurchaseOrders.CurrentRow.DataBoundItem;
                _QPOProperties = _selectedQPO.SelectedQuotation;
            };
            _itemWorker.RunWorkerCompleted += (s, e) =>
            {

                _loadInfo();
                _loadItems();
            };


        }

        private void _loadStartUp()
        {
            _poWorker.RunWorkerAsync();
        }

        private void _loadPurchaseOrders(List<QuotationPurchaseOrder> list = null)
        {
            BindingList<QuotationPurchaseOrder> bindingList;
            dgvrPurchaseOrders.AutoGenerateColumns = false;
            if (list == null)
                bindingList = new BindingList<QuotationPurchaseOrder>(_purchaseOrders);
            else
                bindingList = new BindingList<QuotationPurchaseOrder>(list);
            dgvrPurchaseOrders.DataSource = bindingList;
            if (dgvrPurchaseOrders.Columns.Count == 0)
            {
                dgvrPurchaseOrders.Columns.Add("PurchaseOrderID", "Purchase Order ID");
                dgvrPurchaseOrders.Columns.Add("CreatedDate", "Created Date");
                dgvrPurchaseOrders.Columns.Add("POStatus", "Purchase Order Status");
                dgvrPurchaseOrders.Columns.Add("SupplierName", "Supplier Name");
                dgvrPurchaseOrders.Columns[0].DataPropertyName = "PurchaseOrderID";
                dgvrPurchaseOrders.Columns[1].DataPropertyName = "CreatedDate";
                dgvrPurchaseOrders.Columns[2].DataPropertyName = "PurchaseOrderStatus";
                dgvrPurchaseOrders.Columns[3].DataPropertyName = "SelectedQuotation";
                dgvrPurchaseOrders.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvrPurchaseOrders.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgvrPurchaseOrders.ClearSelection();
        }

        private void _loadInfo()
        {
            lblSupplierName.Text = _QPOProperties.SelectedSupplier.SupplierName;
            lblSupplierAddress.Text = _QPOProperties.SelectedSupplier.Address;
            lblPaymentTerms.Text = _QPOProperties.SelectedSupplier.PaymentTerms.PaymentTermName;
            lblPOName.Text = $"{_selectedQPO.Employee.FirstName} {_selectedQPO.Employee.LastName}";
            lblItemCount.Text = _QPOProperties.Items.Count + "";

        }

        private void _loadItems(List<QuotationItem> list = null)
        {
            BindingList<QuotationItem> bindingList;
            if (list == null)
                bindingList = new BindingList<QuotationItem>(_QPOProperties.Items);
            else
                bindingList = new BindingList<QuotationItem>(list);
            dgvrItemList.DataSource = bindingList;
            dgvrItemList.Columns.RemoveAt(0);
            dgvrItemList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvrItemList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvrItemList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvrItemList.Columns.Remove("QuoteID");
            dgvrItemList.Columns.Remove("ItemCategory");
            dgvrItemList.Columns.Remove("ItemType");
            dgvrItemList.Columns.Remove("SupplierProvider");
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            if (input == "")
            {
                _poWorker.RunWorkerAsync();
                return;
            }
            var list = _purchaseOrders.Where(x => x.PurchaseOrderID.ToString().ToLower().Contains(input) ||
            x.Employee.FirstName.ToLower().Contains(input) || x.Employee.LastName.ToLower().Contains(input) ||
            x.Remarks.ToLower().Contains(txtSearch.Text) || x.CreatedDate.ToString().ToLower().Contains(input) ||
            x.SelectedQuotation.SelectedSupplier.SupplierName.ToLower().Contains(input)).ToList();//shallow copy
            _loadPurchaseOrders(list);

        }

        private void txtSearchItem_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearchItem.Text.ToLower().Trim();
            if (input == "")
            {
                _itemWorker.RunWorkerAsync();
                return;
            }
            var list = _QPOProperties.Items.Where(x => x.QuotationItemID.ToString().ToLower().Contains(input) ||
            x.ItemName.ToLower().Contains(input) || x.Color.ToLower().Contains(input) || x.UnitPrice.ToString().ToLower().Contains(input) ||
            x.TotalPrice.ToString().ToLower().Contains(input)).ToList();//shallow copy
            _loadItems(list);
        }

        private void dgvrPurchaseOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get SelectedQuotation
            if (e.RowIndex >= 0)
            {
                if (_purchaseOrders[e.RowIndex].PurchaseOrderStatus != "Received")
                {
                    btnCreateGRPO.Enabled = true;
                    btnCreateGRPO.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    btnCreateGRPO.Enabled = false;
                    btnCreateGRPO.BackColor = SystemColors.Control;
                }
                _itemWorker.RunWorkerAsync();

            }
        }

        private void dgvrItemList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnShowDirectPO_Click(object sender, System.EventArgs e)
        {
            var directPOListWindow = new DirectPOList(btnCreateGRPO);
            directPOListWindow.StartPosition = FormStartPosition.CenterScreen;
            directPOListWindow.ShowDialog();
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

        private void btnCreateGRPO_Click(object sender, System.EventArgs e)
        {
            if (!IsChild)
            {
                CreateGRPO createGRPO;
                if (_itemTable == null)
                {
                    createGRPO = new CreateGRPO(_model);
                    createGRPO.SelectedPO = _selectedQPO;
                }
                else
                {
                    createGRPO = new CreateGRPO(_model, _itemTable);
                    createGRPO.SelectedDPO = _selectedPO;
                }
                createGRPO.StartPosition = FormStartPosition.CenterScreen;
                createGRPO.ShowDialog();
                _loadStartUp();
                btnCreateGRPO.Enabled = false;
                btnCreateGRPO.BackColor = SystemColors.Control;
                return;
            }
            CreateGRPO.SelectedDPOInfo = _selectedPO;
            CreateGRPO._dPOTable = _itemTable;
            Close();

        }

        public QuotationPurchaseOrder GetSelectedPO()
        {
            return _selectedQPO;
        }

    }
}
