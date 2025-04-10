using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Reports
{
    public partial class NetDiscounts : Form
    {

        private Helper _dbHelper;
        private DataTable _countChartTable, _netDiscountTable;
        private string _query;
        private BackgroundWorker _worker;
        public NetDiscounts()
        {
            InitializeComponent();
            _dbHelper = new Helper();
            _initializeWorkers();
            _worker.RunWorkerAsync();
        }

        private void _initializeWorkers()
        {
            {
                _worker = new BackgroundWorker();
                _worker.DoWork += (s, e) =>
                {

                    _query = $"SELECT * FROM SupplierPOCount";
                    _countChartTable = _dbHelper.GetData(_query);
                    _query = $"SELECT * FROM TotalSupplierNetDiscount";
                    _netDiscountTable = _dbHelper.GetData(_query);
                };

                _worker.RunWorkerCompleted += (s, e) =>
                {
                    _loadCharts();
                };
            }
        }

        private void _loadCharts()
        {
            chrtTotalNetSavings.DataSource = _netDiscountTable;
            chrtTotalNetSavings.Series[0].XValueMember = "SupplierName";
            chrtTotalNetSavings.Series[0].YValueMembers = "Total Net Saving";
            //set label to Monthly Sales with two decimal format
            chrtTotalNetSavings.Series[0].Label = "₱#VAL{0}";
            chrtTotalNetSavings.DataBind();

            chrtTotalPOCount.DataSource = _countChartTable;
            chrtTotalPOCount.Series[0].XValueMember = "SupplierName";
            chrtTotalPOCount.Series[0].YValueMembers = "Total Count";
            chrtTotalPOCount.Series[0].Label = "#VAL{0}";
            chrtTotalPOCount.DataBind();




        }

        private void NetDiscounts_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
