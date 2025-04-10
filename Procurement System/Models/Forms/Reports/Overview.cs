using Procurement_System.Services;
using System;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Reports
{
    public partial class Overview : Form
    {
        private Helper _dbHelper;
        private string _query;
        public Overview()
        {
            InitializeComponent();
            _dbHelper = new Helper();
            _loadOverviewData();
        }

        private void _loadOverviewData()
        {
            _loadLabels();
            _loadCharts();
        }

        private void _loadCharts()
        {
            _query = $"SELECT * FROM TotalSupplierDiscount";
            chrtSupplierDiscounts.DataSource = _dbHelper.GetData(_query);
            chrtSupplierDiscounts.Series[0].XValueMember = "SupplierName";
            chrtSupplierDiscounts.Series[0].YValueMembers = "Total Discount";
            //change label to percent format
            chrtSupplierDiscounts.Series[0].Label = "#PERCENT{P0}";

            _query = $"SELECT * FROM MonthlySales";
            chrtMontlySales.DataSource = _dbHelper.GetData(_query);
            //Set X axis to month
            chrtMontlySales.Series[0].XValueMember = "Date";
            chrtMontlySales.Series[0].YValueMembers = "Monthly Sales";
            //set label to Monthly Sales with two decimal format
            chrtMontlySales.Series[0].Label = "₱#VAL{0}";

            _query = $"SELECT TOP 5 ItemName, MAX([Sold Quantity]) AS 'Sold Quantity' FROM ReleaseItems GROUP BY ItemName ORDER BY MAX([Sold Quantity])";
            chrtReleaseItems.DataSource = _dbHelper.GetData(_query);
            chrtReleaseItems.Series[0].XValueMember = "ItemName";
            chrtReleaseItems.Series[0].YValueMembers = "Sold Quantity";
            //set label to Sold Quantity
            chrtReleaseItems.Series[0].Label = "#VALY";

        }

        private void _loadLabels()
        {

            _query = $"SELECT COUNT(SupplierID) FROM Supplier";

            var res = _dbHelper.GetData(_query);
            lblSupplierCount.Text = res.Rows[0][0].ToString();

            _query = $"SELECT SUM(Stocks) AS 'Total Count' FROM SupplierItemDetails SII INNER JOIN " +
                $"SupplierItem SI ON SII.ItemID = SI.ItemID";
            var res2 = _dbHelper.GetData(_query);
            lblItemAmount.Text = res2.Rows[0][0].ToString() == "" ? "0" : res2.Rows[0][0].ToString();

            _query = $"SELECT * FROM PendingQuotation;";
            var res3 = _dbHelper.GetData(_query);
            lblPendingQuotAmount.Text = res3.Rows[0][0].ToString();


            _query = $"SELECT * FROM PendingAP;";
            var res6 = _dbHelper.GetData(_query);
            //check first if theres a record
            if (res6.Rows.Count > 0)
            {
                lblPAAmount.Text = res6.Rows[0][0].ToString();
            }
            else
            {
                lblPAAmount.Text = "0";
            }

            _query = $"SELECT * FROM PendingQPO;";
            var res4 = _dbHelper.GetData(_query);
            int count = Convert.ToInt32(res4.Rows[0][0].ToString());
            _query = $"SELECT * FROM PendingDPO;";
            var res5 = _dbHelper.GetData(_query);
            count += Convert.ToInt32(res5.Rows[0][0].ToString());
            lblPendingPOAmount.Text = count.ToString();

            _query = $"SELECT FORMAT(SUM(TotalSaving), 'c', 'en-PH') AS 'Total Net Discount' FROM NetSaving";
            lblDiscountAmount.Text = _dbHelper.GetData(_query).Rows[0][0].ToString() == "" ? "0" 
                : _dbHelper.GetData(_query).Rows[0][0].ToString();
        }

        private void chrtReleaseItems_Click(object sender, System.EventArgs e)
        {

        }
    }
}
