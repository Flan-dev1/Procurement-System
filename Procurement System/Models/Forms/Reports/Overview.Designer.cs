
namespace Procurement_System.Models.Forms.Reports
{
    partial class Overview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.chrtReleaseItems = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopLeftGrid = new System.Windows.Forms.Panel();
            this.pnlTotalSuppliers = new System.Windows.Forms.Panel();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.lblSupplierCount = new System.Windows.Forms.Label();
            this.pnlTopMiddleGrid = new System.Windows.Forms.Panel();
            this.pnlTotalItems = new System.Windows.Forms.Panel();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.pnlTopRightGrid = new System.Windows.Forms.Panel();
            this.pnlPendingAccountsPayable = new System.Windows.Forms.Panel();
            this.lblPendingAccountsPayable = new System.Windows.Forms.Label();
            this.lblPAAmount = new System.Windows.Forms.Label();
            this.pnlBotLeftGrid = new System.Windows.Forms.Panel();
            this.pnlNetDiscounts = new System.Windows.Forms.Panel();
            this.lblNetDiscounts = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.pnlBotMiddleGrid = new System.Windows.Forms.Panel();
            this.pnlTotalPendingPO = new System.Windows.Forms.Panel();
            this.lblTotalPendingPO = new System.Windows.Forms.Label();
            this.lblPendingPOAmount = new System.Windows.Forms.Label();
            this.pnlBotRightGrid = new System.Windows.Forms.Panel();
            this.pnlTotalPending = new System.Windows.Forms.Panel();
            this.lblTotalPending = new System.Windows.Forms.Label();
            this.lblPendingQuotAmount = new System.Windows.Forms.Label();
            this.pnlBotLeft = new System.Windows.Forms.Panel();
            this.chrtSupplierDiscounts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlBotRight = new System.Windows.Forms.Panel();
            this.chrtMontlySales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblMain.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtReleaseItems)).BeginInit();
            this.pnlTopRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTopLeftGrid.SuspendLayout();
            this.pnlTotalSuppliers.SuspendLayout();
            this.pnlTopMiddleGrid.SuspendLayout();
            this.pnlTotalItems.SuspendLayout();
            this.pnlTopRightGrid.SuspendLayout();
            this.pnlPendingAccountsPayable.SuspendLayout();
            this.pnlBotLeftGrid.SuspendLayout();
            this.pnlNetDiscounts.SuspendLayout();
            this.pnlBotMiddleGrid.SuspendLayout();
            this.pnlTotalPendingPO.SuspendLayout();
            this.pnlBotRightGrid.SuspendLayout();
            this.pnlTotalPending.SuspendLayout();
            this.pnlBotLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSupplierDiscounts)).BeginInit();
            this.pnlBotRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMontlySales)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblMain.Controls.Add(this.pnlTopLeft, 0, 0);
            this.tblMain.Controls.Add(this.pnlTopRight, 1, 0);
            this.tblMain.Controls.Add(this.pnlBotLeft, 0, 1);
            this.tblMain.Controls.Add(this.pnlBotRight, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tblMain.Size = new System.Drawing.Size(1381, 660);
            this.tblMain.TabIndex = 0;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.chrtReleaseItems);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(546, 423);
            this.pnlTopLeft.TabIndex = 0;
            // 
            // chrtReleaseItems
            // 
            chartArea10.Name = "ChartArea1";
            this.chrtReleaseItems.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chrtReleaseItems.Legends.Add(legend10);
            this.chrtReleaseItems.Location = new System.Drawing.Point(9, 31);
            this.chrtReleaseItems.Name = "chrtReleaseItems";
            this.chrtReleaseItems.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series10.ChartArea = "ChartArea1";
            series10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.Legend = "Legend1";
            series10.Name = "Total Items Sold";
            this.chrtReleaseItems.Series.Add(series10);
            this.chrtReleaseItems.Size = new System.Drawing.Size(514, 350);
            this.chrtReleaseItems.TabIndex = 1;
            this.chrtReleaseItems.Text = "chart1";
            this.chrtReleaseItems.Click += new System.EventHandler(this.chrtReleaseItems_Click);
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.tableLayoutPanel1);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopRight.Location = new System.Drawing.Point(555, 3);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(823, 423);
            this.pnlTopRight.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTopLeftGrid, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTopMiddleGrid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTopRightGrid, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBotLeftGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBotMiddleGrid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBotRightGrid, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(823, 423);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlTopLeftGrid
            // 
            this.pnlTopLeftGrid.Controls.Add(this.pnlTotalSuppliers);
            this.pnlTopLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLeftGrid.Location = new System.Drawing.Point(3, 3);
            this.pnlTopLeftGrid.Name = "pnlTopLeftGrid";
            this.pnlTopLeftGrid.Size = new System.Drawing.Size(268, 205);
            this.pnlTopLeftGrid.TabIndex = 4;
            // 
            // pnlTotalSuppliers
            // 
            this.pnlTotalSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalSuppliers.Controls.Add(this.lblTotalSuppliers);
            this.pnlTotalSuppliers.Controls.Add(this.lblSupplierCount);
            this.pnlTotalSuppliers.Location = new System.Drawing.Point(12, 10);
            this.pnlTotalSuppliers.MinimumSize = new System.Drawing.Size(243, 183);
            this.pnlTotalSuppliers.Name = "pnlTotalSuppliers";
            this.pnlTotalSuppliers.Size = new System.Drawing.Size(243, 183);
            this.pnlTotalSuppliers.TabIndex = 2;
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = true;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuppliers.Location = new System.Drawing.Point(31, 101);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(177, 29);
            this.lblTotalSuppliers.TabIndex = 1;
            this.lblTotalSuppliers.Text = "Total Suppliers";
            this.lblTotalSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSupplierCount
            // 
            this.lblSupplierCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierCount.Location = new System.Drawing.Point(-1, 46);
            this.lblSupplierCount.MinimumSize = new System.Drawing.Size(54, 25);
            this.lblSupplierCount.Name = "lblSupplierCount";
            this.lblSupplierCount.Size = new System.Drawing.Size(243, 55);
            this.lblSupplierCount.TabIndex = 0;
            this.lblSupplierCount.Text = "100";
            this.lblSupplierCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopMiddleGrid
            // 
            this.pnlTopMiddleGrid.Controls.Add(this.pnlTotalItems);
            this.pnlTopMiddleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopMiddleGrid.Location = new System.Drawing.Point(277, 3);
            this.pnlTopMiddleGrid.Name = "pnlTopMiddleGrid";
            this.pnlTopMiddleGrid.Size = new System.Drawing.Size(268, 205);
            this.pnlTopMiddleGrid.TabIndex = 2;
            // 
            // pnlTotalItems
            // 
            this.pnlTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalItems.Controls.Add(this.lblItemAmount);
            this.pnlTotalItems.Controls.Add(this.lblTotalItems);
            this.pnlTotalItems.Location = new System.Drawing.Point(12, 10);
            this.pnlTotalItems.MinimumSize = new System.Drawing.Size(243, 183);
            this.pnlTotalItems.Name = "pnlTotalItems";
            this.pnlTotalItems.Size = new System.Drawing.Size(243, 183);
            this.pnlTotalItems.TabIndex = 3;
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAmount.Location = new System.Drawing.Point(0, 46);
            this.lblItemAmount.MinimumSize = new System.Drawing.Size(54, 25);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(242, 55);
            this.lblItemAmount.TabIndex = 0;
            this.lblItemAmount.Text = "100";
            this.lblItemAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(52, 116);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(132, 29);
            this.lblTotalItems.TabIndex = 1;
            this.lblTotalItems.Text = "Total Items";
            this.lblTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTopRightGrid
            // 
            this.pnlTopRightGrid.Controls.Add(this.pnlPendingAccountsPayable);
            this.pnlTopRightGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopRightGrid.Location = new System.Drawing.Point(551, 3);
            this.pnlTopRightGrid.Name = "pnlTopRightGrid";
            this.pnlTopRightGrid.Size = new System.Drawing.Size(269, 205);
            this.pnlTopRightGrid.TabIndex = 3;
            // 
            // pnlPendingAccountsPayable
            // 
            this.pnlPendingAccountsPayable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPendingAccountsPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPendingAccountsPayable.Controls.Add(this.lblPendingAccountsPayable);
            this.pnlPendingAccountsPayable.Controls.Add(this.lblPAAmount);
            this.pnlPendingAccountsPayable.Location = new System.Drawing.Point(12, 10);
            this.pnlPendingAccountsPayable.MinimumSize = new System.Drawing.Size(243, 183);
            this.pnlPendingAccountsPayable.Name = "pnlPendingAccountsPayable";
            this.pnlPendingAccountsPayable.Size = new System.Drawing.Size(243, 183);
            this.pnlPendingAccountsPayable.TabIndex = 2;
            // 
            // lblPendingAccountsPayable
            // 
            this.lblPendingAccountsPayable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingAccountsPayable.AutoSize = true;
            this.lblPendingAccountsPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingAccountsPayable.Location = new System.Drawing.Point(17, 101);
            this.lblPendingAccountsPayable.Name = "lblPendingAccountsPayable";
            this.lblPendingAccountsPayable.Size = new System.Drawing.Size(206, 58);
            this.lblPendingAccountsPayable.TabIndex = 1;
            this.lblPendingAccountsPayable.Text = "Pending Accounts\r\nPayable";
            this.lblPendingAccountsPayable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPAAmount
            // 
            this.lblPAAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPAAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPAAmount.Location = new System.Drawing.Point(-1, 46);
            this.lblPAAmount.MinimumSize = new System.Drawing.Size(54, 25);
            this.lblPAAmount.Name = "lblPAAmount";
            this.lblPAAmount.Size = new System.Drawing.Size(239, 55);
            this.lblPAAmount.TabIndex = 0;
            this.lblPAAmount.Text = "100";
            this.lblPAAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotLeftGrid
            // 
            this.pnlBotLeftGrid.Controls.Add(this.pnlNetDiscounts);
            this.pnlBotLeftGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotLeftGrid.Location = new System.Drawing.Point(3, 214);
            this.pnlBotLeftGrid.Name = "pnlBotLeftGrid";
            this.pnlBotLeftGrid.Size = new System.Drawing.Size(268, 206);
            this.pnlBotLeftGrid.TabIndex = 5;
            // 
            // pnlNetDiscounts
            // 
            this.pnlNetDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNetDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNetDiscounts.Controls.Add(this.lblNetDiscounts);
            this.pnlNetDiscounts.Controls.Add(this.lblDiscountAmount);
            this.pnlNetDiscounts.Location = new System.Drawing.Point(12, 13);
            this.pnlNetDiscounts.MinimumSize = new System.Drawing.Size(243, 183);
            this.pnlNetDiscounts.Name = "pnlNetDiscounts";
            this.pnlNetDiscounts.Size = new System.Drawing.Size(243, 183);
            this.pnlNetDiscounts.TabIndex = 2;
            // 
            // lblNetDiscounts
            // 
            this.lblNetDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNetDiscounts.AutoSize = true;
            this.lblNetDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetDiscounts.Location = new System.Drawing.Point(41, 94);
            this.lblNetDiscounts.Name = "lblNetDiscounts";
            this.lblNetDiscounts.Size = new System.Drawing.Size(162, 29);
            this.lblNetDiscounts.TabIndex = 1;
            this.lblNetDiscounts.Text = "Net Discounts";
            this.lblNetDiscounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountAmount.Location = new System.Drawing.Point(-1, 39);
            this.lblDiscountAmount.MinimumSize = new System.Drawing.Size(54, 25);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(243, 55);
            this.lblDiscountAmount.TabIndex = 0;
            this.lblDiscountAmount.Text = "100";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotMiddleGrid
            // 
            this.pnlBotMiddleGrid.Controls.Add(this.pnlTotalPendingPO);
            this.pnlBotMiddleGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotMiddleGrid.Location = new System.Drawing.Point(277, 214);
            this.pnlBotMiddleGrid.Name = "pnlBotMiddleGrid";
            this.pnlBotMiddleGrid.Size = new System.Drawing.Size(268, 206);
            this.pnlBotMiddleGrid.TabIndex = 2;
            // 
            // pnlTotalPendingPO
            // 
            this.pnlTotalPendingPO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalPendingPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalPendingPO.Controls.Add(this.lblTotalPendingPO);
            this.pnlTotalPendingPO.Controls.Add(this.lblPendingPOAmount);
            this.pnlTotalPendingPO.Location = new System.Drawing.Point(13, 13);
            this.pnlTotalPendingPO.MinimumSize = new System.Drawing.Size(243, 183);
            this.pnlTotalPendingPO.Name = "pnlTotalPendingPO";
            this.pnlTotalPendingPO.Size = new System.Drawing.Size(243, 183);
            this.pnlTotalPendingPO.TabIndex = 2;
            // 
            // lblTotalPendingPO
            // 
            this.lblTotalPendingPO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPendingPO.AutoSize = true;
            this.lblTotalPendingPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPendingPO.Location = new System.Drawing.Point(21, 94);
            this.lblTotalPendingPO.Name = "lblTotalPendingPO";
            this.lblTotalPendingPO.Size = new System.Drawing.Size(195, 58);
            this.lblTotalPendingPO.TabIndex = 1;
            this.lblTotalPendingPO.Text = "Total Pending\r\nPurchase Orders";
            this.lblTotalPendingPO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingPOAmount
            // 
            this.lblPendingPOAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingPOAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingPOAmount.Location = new System.Drawing.Point(-2, 39);
            this.lblPendingPOAmount.MinimumSize = new System.Drawing.Size(54, 25);
            this.lblPendingPOAmount.Name = "lblPendingPOAmount";
            this.lblPendingPOAmount.Size = new System.Drawing.Size(244, 55);
            this.lblPendingPOAmount.TabIndex = 0;
            this.lblPendingPOAmount.Text = "100";
            this.lblPendingPOAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotRightGrid
            // 
            this.pnlBotRightGrid.Controls.Add(this.pnlTotalPending);
            this.pnlBotRightGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotRightGrid.Location = new System.Drawing.Point(551, 214);
            this.pnlBotRightGrid.Name = "pnlBotRightGrid";
            this.pnlBotRightGrid.Size = new System.Drawing.Size(269, 206);
            this.pnlBotRightGrid.TabIndex = 6;
            // 
            // pnlTotalPending
            // 
            this.pnlTotalPending.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTotalPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalPending.Controls.Add(this.lblTotalPending);
            this.pnlTotalPending.Controls.Add(this.lblPendingQuotAmount);
            this.pnlTotalPending.Location = new System.Drawing.Point(12, 13);
            this.pnlTotalPending.MinimumSize = new System.Drawing.Size(243, 183);
            this.pnlTotalPending.Name = "pnlTotalPending";
            this.pnlTotalPending.Size = new System.Drawing.Size(243, 183);
            this.pnlTotalPending.TabIndex = 2;
            // 
            // lblTotalPending
            // 
            this.lblTotalPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPending.AutoSize = true;
            this.lblTotalPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPending.Location = new System.Drawing.Point(42, 95);
            this.lblTotalPending.Name = "lblTotalPending";
            this.lblTotalPending.Size = new System.Drawing.Size(164, 58);
            this.lblTotalPending.TabIndex = 1;
            this.lblTotalPending.Text = "Total Pending\r\nQuotations";
            this.lblTotalPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPendingQuotAmount
            // 
            this.lblPendingQuotAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPendingQuotAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingQuotAmount.Location = new System.Drawing.Point(-1, 39);
            this.lblPendingQuotAmount.MinimumSize = new System.Drawing.Size(54, 25);
            this.lblPendingQuotAmount.Name = "lblPendingQuotAmount";
            this.lblPendingQuotAmount.Size = new System.Drawing.Size(243, 55);
            this.lblPendingQuotAmount.TabIndex = 0;
            this.lblPendingQuotAmount.Text = "100";
            this.lblPendingQuotAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotLeft
            // 
            this.pnlBotLeft.Controls.Add(this.chrtSupplierDiscounts);
            this.pnlBotLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotLeft.Location = new System.Drawing.Point(3, 432);
            this.pnlBotLeft.Name = "pnlBotLeft";
            this.pnlBotLeft.Size = new System.Drawing.Size(546, 225);
            this.pnlBotLeft.TabIndex = 2;
            // 
            // chrtSupplierDiscounts
            // 
            chartArea11.Name = "ChartArea1";
            this.chrtSupplierDiscounts.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.chrtSupplierDiscounts.Legends.Add(legend11);
            this.chrtSupplierDiscounts.Location = new System.Drawing.Point(9, 19);
            this.chrtSupplierDiscounts.Name = "chrtSupplierDiscounts";
            this.chrtSupplierDiscounts.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series11.ChartArea = "ChartArea1";
            series11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.Legend = "Legend1";
            series11.Name = "Supplier Discounts";
            this.chrtSupplierDiscounts.Series.Add(series11);
            this.chrtSupplierDiscounts.Size = new System.Drawing.Size(514, 197);
            this.chrtSupplierDiscounts.TabIndex = 0;
            this.chrtSupplierDiscounts.Text = "chart1";
            // 
            // pnlBotRight
            // 
            this.pnlBotRight.Controls.Add(this.chrtMontlySales);
            this.pnlBotRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotRight.Location = new System.Drawing.Point(555, 432);
            this.pnlBotRight.Name = "pnlBotRight";
            this.pnlBotRight.Size = new System.Drawing.Size(823, 225);
            this.pnlBotRight.TabIndex = 3;
            // 
            // chrtMontlySales
            // 
            chartArea12.Name = "ChartArea1";
            this.chrtMontlySales.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.chrtMontlySales.Legends.Add(legend12);
            this.chrtMontlySales.Location = new System.Drawing.Point(15, 19);
            this.chrtMontlySales.Name = "chrtMontlySales";
            this.chrtMontlySales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series12.ChartArea = "ChartArea1";
            series12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.Legend = "Legend1";
            series12.Name = "Sales";
            this.chrtMontlySales.Series.Add(series12);
            this.chrtMontlySales.Size = new System.Drawing.Size(799, 197);
            this.chrtMontlySales.TabIndex = 1;
            this.chrtMontlySales.Text = "chart1";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.tblMain);
            this.Name = "Overview";
            this.Text = "Overview";
            this.tblMain.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtReleaseItems)).EndInit();
            this.pnlTopRight.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTopLeftGrid.ResumeLayout(false);
            this.pnlTotalSuppliers.ResumeLayout(false);
            this.pnlTotalSuppliers.PerformLayout();
            this.pnlTopMiddleGrid.ResumeLayout(false);
            this.pnlTotalItems.ResumeLayout(false);
            this.pnlTotalItems.PerformLayout();
            this.pnlTopRightGrid.ResumeLayout(false);
            this.pnlPendingAccountsPayable.ResumeLayout(false);
            this.pnlPendingAccountsPayable.PerformLayout();
            this.pnlBotLeftGrid.ResumeLayout(false);
            this.pnlNetDiscounts.ResumeLayout(false);
            this.pnlNetDiscounts.PerformLayout();
            this.pnlBotMiddleGrid.ResumeLayout(false);
            this.pnlTotalPendingPO.ResumeLayout(false);
            this.pnlTotalPendingPO.PerformLayout();
            this.pnlBotRightGrid.ResumeLayout(false);
            this.pnlTotalPending.ResumeLayout(false);
            this.pnlTotalPending.PerformLayout();
            this.pnlBotLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtSupplierDiscounts)).EndInit();
            this.pnlBotRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtMontlySales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Panel pnlBotLeft;
        private System.Windows.Forms.Panel pnlBotRight;
        private System.Windows.Forms.Panel pnlTotalSuppliers;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label lblSupplierCount;
        private System.Windows.Forms.Panel pnlBotMiddleGrid;
        private System.Windows.Forms.Label lblTotalPendingPO;
        private System.Windows.Forms.Label lblPendingPOAmount;
        private System.Windows.Forms.Panel pnlTopMiddleGrid;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Panel pnlPendingAccountsPayable;
        private System.Windows.Forms.Label lblPendingAccountsPayable;
        private System.Windows.Forms.Label lblPAAmount;
        private System.Windows.Forms.Panel pnlTotalPending;
        private System.Windows.Forms.Label lblTotalPending;
        private System.Windows.Forms.Label lblPendingQuotAmount;
        private System.Windows.Forms.Panel pnlNetDiscounts;
        private System.Windows.Forms.Label lblNetDiscounts;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTotalPendingPO;
        private System.Windows.Forms.Panel pnlTotalItems;
        private System.Windows.Forms.Panel pnlTopRightGrid;
        private System.Windows.Forms.Panel pnlTopLeftGrid;
        private System.Windows.Forms.Panel pnlBotLeftGrid;
        private System.Windows.Forms.Panel pnlBotRightGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSupplierDiscounts;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtMontlySales;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtReleaseItems;
    }
}