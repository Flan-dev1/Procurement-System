using Procurement_System.Models.Forms.Unsure.Quotation_PopUps;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.PurchaseOrders
{
    public partial class AccountsPayable : Form
    {
        private EmployeeModel _model;
        private BackgroundWorker _worker;
        private SupplierModel _supplierModel;
        private DataTable _poTableData, _poDetails;
        private QuotationPurchaseOrder _po;
        private int _poID;
        private DirectPurchaseOrder.DirectPurchaseOrderDetails _directPODetails;
        private DirectPurchaseOrder _directPOInfo;
        private EmployeeModel _directEmp;
        private AccountPayable AP;
        private int _totalItems;
        private double _totalPrice, _payAmount, _oldPrice;
        private Helper _dbHelper;
        private string _query = "";
        private BusinessWallet _selectedWallet;
        private bool _isDirectPO = false;
        private int _quoteID;

        public AccountsPayable(EmployeeModel model)
        {
            InitializeComponent();
            _model = model;
            _initializeWorkers();
            _resetAll();
            if (_model.getEmployeeType().getType() == "Admin Manager")
            {
                _setupRestrictions(true);
                btnAdminMode.Visible = false;
            }
            else
            {
                _setupRestrictions();
                btnAdminMode.Visible = true;
            }

        }

        private void _setupRestrictions(bool hasAuthority = false)
        {

            btnSelectSupplier.Enabled = hasAuthority;
            btnSelectWallet.Enabled = hasAuthority;
            _model.setEmployeeType(new EmployeeType() { Type = "Admin Manager" });

        }
        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (e, s) =>
            {
                _dbHelper = new Helper();
                _query = $"SELECT * FROM QPOAPDetails WHERE isPaid=0 AND " +
                $"SupplierID='{_supplierModel.SupplierID}' ";
                _poTableData = _dbHelper.GetData(_query);
                _query = $"SELECT * FROM DPOAPDetails WHERE isPaid=0 AND [Remaining AP Balance] > 0 AND SupplierID='{_supplierModel.SupplierID}'";
                _poTableData.Merge(_dbHelper.GetData(_query));

            };
            _worker.RunWorkerCompleted += (e, s) =>
            {
                _loadTable();
                _loadInfo();
            };

        }

        private void _loadInfo()
        {
            lblName.Text = _supplierModel.SupplierName;
            lblAddress.Text = _supplierModel.Address;
            lblEmail.Text = _supplierModel.Email;
            lblPTNameString.Text = _supplierModel.PaymentTerms.PaymentTermName;
            lblPTDiscountNum.Text = $"{_supplierModel.PaymentTerms.Discount}%";
            lblValidityString.Text = DateTime.Now.AddDays(_supplierModel.PaymentTerms.DiscountValidity).ToString("MM/dd/yyyy");
            lblDueDate.Text = DateTime.Now.AddDays(_supplierModel.PaymentTerms.DueDate).ToString("MM/dd/yyyy");
            //_enableControls();
            txtPayment.Enabled = true;

        }

        private void _loadPOInfo()
        {

            var createdDate = DateTime.Parse(_poDetails.Rows[0]["CreatedDate"].ToString());
            lblDate.Text = createdDate.ToString("MM/dd/yyyy");
            lblIssuer.Text = _poDetails.Rows[0]["Employee Name"].ToString();
            lblPrice.Text = _totalPrice.ToString();

        }

        private void _loadTable()
        {
            dgvrPurchaseOrderList.AutoGenerateColumns = false;

            if (dgvrPurchaseOrderList.Columns.Count == 0)
            {
                dgvrPurchaseOrderList.Columns.Add("ID", "ID");
                dgvrPurchaseOrderList.Columns.Add("CreatedDate", "Created Date");
                dgvrPurchaseOrderList.Columns.Add("DueDate", "Due Date");
                dgvrPurchaseOrderList.Columns.Add("RemainingAPBalance", "Remaining AP Balance");
                dgvrPurchaseOrderList.Columns.Add("TotalPaid", "Total Paid");
                dgvrPurchaseOrderList.Columns.Add("SupplierName", "Supplier Name");
            }
            dgvrPurchaseOrderList.Rows.Clear();

            foreach (DataRow row in _poTableData.Rows)
            {

                //Convert Due Date row to DateTime

                dgvrPurchaseOrderList.Rows.Add(row["ID"], DateTime.Parse(row["CreatedDate"].ToString()).
                    ToString("MM/dd/yyyy"), DateTime.Parse(row["Due Date"].ToString()).
                    ToString("MM/dd/yyyy"),
                    row["Remaining AP Balance"], row["Total Paid"], row["SupplierName"]);

            }
            dgvrPurchaseOrderList.ClearSelection();

        }

        private void _selectSupplier(SupplierModel supplier)
        {
            _supplierModel = supplier;
        }

        private void _selectWallet(BusinessWallet wallet)
        {
            _selectedWallet = wallet;
            lblWalletName.Text = _selectedWallet.WalletName;
            lblTotalBalance.Text = CurrencyFormat.FormatCurrency(_selectedWallet.TotalBalance);

        }

        private void btnSelectSupplier_Click(object sender, System.EventArgs e)
        {
            var apWindow = new PendingAPList(_selectSupplier);
            apWindow.StartPosition = FormStartPosition.CenterScreen;
            apWindow.ShowDialog();
            if (_supplierModel != null)
                _worker.RunWorkerAsync();
        }

        private void btnViewGoodsReceipt_Click(object sender, System.EventArgs e)
        {

            _query = $"SELECT * FROM QuotationPurchaseOrder WHERE PurchaseOrderID={_quoteID}";
            var res = _dbHelper.GetData(_query).Rows[0][0].ToString();
            new GoodsReceiptList(Convert.ToInt32(res)).ShowDialog();
        }

        private void dgvrPurchaseOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvrPurchaseOrderList.SelectedRows.Count > 0)
            {
                _quoteID = Convert.ToInt32(dgvrPurchaseOrderList.SelectedRows[0].Cells[0].Value.ToString());
                _totalPrice = Convert.ToDouble(dgvrPurchaseOrderList.SelectedRows[0].Cells[3].Value.ToString());

                _query = $"SELECT * FROM QuotationPurchaseOrder WHERE PurchaseOrderID={_quoteID}";

                if (_dbHelper.GetData(_query).Rows.Count == 0)
                {
                    _query = $"SELECT * FROM APDPODetails WHERE DirectPODetailsID='{_quoteID}'";
                    _poDetails = _dbHelper.GetData(_query);

                }
                else
                {
                    _query = $"SELECT * FROM QPDPODetails WHERE PurchaseOrderID='{_quoteID}'";
                    _poDetails = _dbHelper.GetData(_query);
                }

                _loadPOInfo();
                _loadInfo();

            }
        }

        private void _resetAll()
        {
            txtPayment.Text = "";
            lblName.Text = "";
            lblAddress.Text = "";
            lblEmail.Text = "";
            lblPTNameString.Text = "";
            lblPTDiscountNum.Text = "";
            lblValidityString.Text = "";
            lblDueDate.Text = "";
            lblID.Text = "";
            lblPOID.Text = "";
            lblDate.Text = "";
            lblIssuer.Text = "";
            lblPrice.Text = "";
            lblDiscount.Text = "";
            //btnViewGoodsReceipt.Enabled = false;
            btnPay.Enabled = false;
            //btnPayAll.Enabled = false;
            txtPayment.Enabled = false;
            _supplierModel = null;
            _selectedWallet = null;
            _po = null;
            _poTableData = null;
            dgvrPurchaseOrderList.DataSource = null;
            dgvrPurchaseOrderList.Rows.Clear();
            lblTotalBalance.Text = "";
            lblWalletName.Text = "";

        }

        private void _enableControls()
        {
            btnPay.Enabled = true;
            //btnPayAll.Enabled = true;
            txtPayment.Enabled = true;
            //btnViewGoodsReceipt.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var walletListWindow = new WalletList(_selectWallet);
            walletListWindow.StartPosition = FormStartPosition.CenterScreen;
            walletListWindow.ShowDialog();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (_selectedWallet == null)
            {

                MessageBox.Show("Please select a wallet to pay from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (txtPayment.Text == "")
            {
                MessageBox.Show("Please enter a payment amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure you want to pay this Purchase Order?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                var hasDiscount = _hasDiscount();
                var wallet = _selectedWallet;
                wallet.TotalBalance -= _totalPrice;

                _query = $"SELECT * FROM GetAPInfo WHERE DirectPODetailsID='{_quoteID}'";
                var res = _dbHelper.GetData(_query);
                double ap = 0, total;
                if (res.Rows.Count != 0)
                {
                    ap = Convert.ToDouble(res.Rows[0][1].ToString());
                    total = Convert.ToDouble(res.Rows[0][2].ToString());
                }
                else
                {
                    _query = $"SELECT AP.AccountPayableID, AP.TotalAmount " +
                        $"FROM QuotationPurchaseOrder QPO INNER JOIN AccountsPayable AP ON " +
                        $"QPO.AccountPayableID = AP.AccountPayableID WHERE QPO.PurchaseOrderID = '{_quoteID}'";
                    res = _dbHelper.GetData(_query);
                    ap = Convert.ToDouble(res.Rows[0][0].ToString());
                    total = Convert.ToDouble(res.Rows[0][1].ToString());
                }

                _query = $"INSERT INTO JournalEntry VALUES ('{ap}', '{wallet.BusinessWalletID}'," +
                    $"'{DateTime.Now}', '{_totalPrice}')";
                _dbHelper.AddUpdDelData(_query);
                _query = $"UPDATE BusinessWallet SET TotalBalance='{wallet.TotalBalance}' WHERE BusinessWalletID='{wallet.BusinessWalletID}'";
                _dbHelper.AddUpdDelData(_query);

                //Update total amount of ap
                _query = $"UPDATE AccountsPayable SET TotalAmount='0', isPaid=1 WHERE AccountPayableID='{ap}'";
                _dbHelper.AddUpdDelData(_query);
                if (hasDiscount)
                {
                    //calculate the net discount based on the oldprice and the discount payment terms
                    //var netDiscount = _totalPrice - (_totalPrice * _/100);

                    var totalSaving = _oldPrice - (_oldPrice * ((double)_supplierModel.PaymentTerms.Discount / 100));
                    totalSaving = _oldPrice - totalSaving;
                    MessageBox.Show($"Payment Successful! You save {CurrencyFormat.FormatCurrency(totalSaving)}", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _query = $"INSERT INTO NetSaving VALUES ('{ap}', '{totalSaving}')";
                    _dbHelper.AddUpdDelData(_query);
                }

                    MessageBox.Show($"Payment has been saved!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                _resetAll();

            }
        }

        private void _generateJournalEntry(IPayInvoice payInvoice)
        {
            payInvoice.PayAP(AP, _selectedWallet);
            _resetAll();
        }

        private void btnAdminMode_Click(object sender, EventArgs e)
        {
            var adminMode = new AdminMode(_setupRestrictions);
            adminMode.StartPosition = FormStartPosition.CenterScreen;
            adminMode.ShowDialog();
        }

        private void btnPayAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to pay all Purchase Orders?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_selectedWallet == null)
                {
                    MessageBox.Show("Please select a wallet to pay from.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_selectedWallet.TotalBalance < _totalPrice)
                {
                    MessageBox.Show("Insufficient funds in wallet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _query = $"SELECT SUM(TotalAmount) AS 'Total BP' FROM AccountsPayable WHERE SupplierID='{_supplierModel.SupplierID}' AND IsPaid=0";
                var total = _dbHelper.GetData(_query);
                var totalBP = Convert.ToDouble(total.Rows[0][0].ToString());
                _selectedWallet.TotalBalance -= totalBP;
                _query = $"UPDATE BusinessWallet SET TotalBalance={_selectedWallet.TotalBalance} WHERE BusinessWalletID={_selectedWallet.BusinessWalletID}";
                _dbHelper.AddUpdDelData(_query);
                _query = $"SELECT * FROM AccountsPayable WHERE SupplierID='{_supplierModel.SupplierID}' AND IsPaid=0";
                var res = _dbHelper.GetData(_query);
                foreach (DataRow row in res.Rows)
                {
                    _query = $"INSERT INTO JournalEntry VALUES ('{row["AccountPayableID"]}', '{_selectedWallet.BusinessWalletID}', '{DateTime.Now.ToString("yyyy-MM-dd")}', '{row["TotalAmount"]}')";
                    _dbHelper.AddUpdDelData(_query);
                    _query = $"UPDATE AccountsPayable SET TotalAmount=0, IsPaid=1 WHERE AccountPayableID={row[0].ToString()} AND SupplierID='{_supplierModel.SupplierID}'";
                    _dbHelper.AddUpdDelData(_query);
                }

                MessageBox.Show("Payment Successful!");
                _resetAll();


            }
        }


        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            //search
        }

        private bool _hasDiscount()
        {
            //check if the discount validity is still valid 
            var postingDate = DateTime.Now;
            var discountTimeFrame = DateTime.Now.AddDays(_supplierModel.PaymentTerms.DiscountValidity);
            if (postingDate < discountTimeFrame)
            {
                //apply total discount
                _query = $"UPDATE SII SET SII.Discount='{_supplierModel.PaymentTerms.Discount}' " +
                    $"FROM SupplierItemDetails " +
                    $"SII INNER JOIN DirectPurchaseOrderItem DPOI ON SII.ItemID = " +
                    $"DPOI.ItemID INNER JOIN DirectPurchaseOrderDetails DPOD ON " +
                    $"DPOD.DirectPODetailsID = DPOI.DirectPODetailsID AND " +
                    $"DPOD.SupplierID = SII.SupplierID WHERE DPOD.DirectPODetailsID='{_quoteID}'";
                _dbHelper.AddUpdDelData(_query);
                _oldPrice = _totalPrice;
                _totalPrice = _totalPrice - (_totalPrice * _supplierModel.PaymentTerms.Discount / 100);
                return true;

            }
            return false;
        }

        private void pnlTopLeft_Paint(object sender, PaintEventArgs e)
        {


        }

        private void txtPayment_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                lblMessage.Text = "";
                if(txtPayment.Text.Trim() == "")
                {
                    btnPay.Enabled = false;
                    return;
                }
                //prevent exponential notation on txtPayment
                if (txtPayment.Text.Contains("E") || txtPayment.Text.Contains("e"))
                {
                    throw new Exception();
                }
                _payAmount = Convert.ToDouble(txtPayment.Text);
                if (_payAmount >= _totalPrice)
                {
                    btnPay.Enabled = true;
                }
                else
                {
                    btnPay.Enabled = false;
                }

            }
            catch (Exception)
            {
                if (txtPayment.Text == "") return;
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Invalid Input.";
                btnPay.Enabled = false;
            }
        }
    }
}
