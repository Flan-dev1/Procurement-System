
namespace Procurement_System.Models.Forms.PurchaseOrders
{
    partial class ViewPOList
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.dgvrItemList = new System.Windows.Forms.DataGridView();
            this.lblItemList = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPOName = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.btnCreateGRPO = new System.Windows.Forms.Button();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.lblPOInfo = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnShowDirectPO = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvrPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.lblPurchaseOrders = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlBottomRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrItemList)).BeginInit();
            this.pnlTopRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrPurchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Controls.Add(this.pnlRight, 1, 0);
            this.pnlMain.Controls.Add(this.pnlLeft, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(1381, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.ColumnCount = 1;
            this.pnlRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlRight.Controls.Add(this.pnlBottomRight, 0, 1);
            this.pnlRight.Controls.Add(this.pnlTopRight, 0, 0);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(693, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.RowCount = 2;
            this.pnlRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlRight.Size = new System.Drawing.Size(685, 654);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Controls.Add(this.label1);
            this.pnlBottomRight.Controls.Add(this.txtSearchItem);
            this.pnlBottomRight.Controls.Add(this.dgvrItemList);
            this.pnlBottomRight.Controls.Add(this.lblItemList);
            this.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomRight.Location = new System.Drawing.Point(3, 231);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Size = new System.Drawing.Size(679, 420);
            this.pnlBottomRight.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(370, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Search:";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(448, 14);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(225, 22);
            this.txtSearchItem.TabIndex = 40;
            this.txtSearchItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyUp);
            // 
            // dgvrItemList
            // 
            this.dgvrItemList.AllowUserToAddRows = false;
            this.dgvrItemList.AllowUserToDeleteRows = false;
            this.dgvrItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvrItemList.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrItemList.Location = new System.Drawing.Point(3, 39);
            this.dgvrItemList.MultiSelect = false;
            this.dgvrItemList.Name = "dgvrItemList";
            this.dgvrItemList.RowHeadersVisible = false;
            this.dgvrItemList.RowHeadersWidth = 51;
            this.dgvrItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrItemList.Size = new System.Drawing.Size(670, 381);
            this.dgvrItemList.TabIndex = 36;
            this.dgvrItemList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvrItemList_DataError);
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemList.Location = new System.Drawing.Point(3, 13);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(72, 21);
            this.lblItemList.TabIndex = 38;
            this.lblItemList.Text = "Item List:";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.lblCurrentTime);
            this.pnlTopRight.Controls.Add(this.lblTime);
            this.pnlTopRight.Controls.Add(this.lblPOName);
            this.pnlTopRight.Controls.Add(this.lblItemCount);
            this.pnlTopRight.Controls.Add(this.lblPaymentTerms);
            this.pnlTopRight.Controls.Add(this.lblSupplierAddress);
            this.pnlTopRight.Controls.Add(this.lblSupplierName);
            this.pnlTopRight.Controls.Add(this.btnCreateGRPO);
            this.pnlTopRight.Controls.Add(this.lblEmployeeName);
            this.pnlTopRight.Controls.Add(this.lblTotalItems);
            this.pnlTopRight.Controls.Add(this.lblUnitPrice);
            this.pnlTopRight.Controls.Add(this.lblAddress);
            this.pnlTopRight.Controls.Add(this.lblSuppName);
            this.pnlTopRight.Controls.Add(this.lblPOInfo);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopRight.Location = new System.Drawing.Point(3, 3);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(679, 222);
            this.pnlTopRight.TabIndex = 1;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(586, 8);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 21);
            this.lblCurrentTime.TabIndex = 53;
            this.lblCurrentTime.Text = "##:## ##";
            this.lblCurrentTime.Click += new System.EventHandler(this.lblCurrentTime_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(533, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 52;
            this.lblTime.Text = "TIME:";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblPOName
            // 
            this.lblPOName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPOName.Location = new System.Drawing.Point(543, 169);
            this.lblPOName.Name = "lblPOName";
            this.lblPOName.Size = new System.Drawing.Size(130, 44);
            this.lblPOName.TabIndex = 51;
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCount.Location = new System.Drawing.Point(543, 140);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(0, 21);
            this.lblItemCount.TabIndex = 50;
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTerms.Location = new System.Drawing.Point(127, 139);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(0, 21);
            this.lblPaymentTerms.TabIndex = 49;
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(126, 108);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(0, 21);
            this.lblSupplierAddress.TabIndex = 48;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(126, 79);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(0, 21);
            this.lblSupplierName.TabIndex = 47;
            // 
            // btnCreateGRPO
            // 
            this.btnCreateGRPO.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateGRPO.Enabled = false;
            this.btnCreateGRPO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGRPO.Location = new System.Drawing.Point(0, 181);
            this.btnCreateGRPO.Name = "btnCreateGRPO";
            this.btnCreateGRPO.Size = new System.Drawing.Size(211, 38);
            this.btnCreateGRPO.TabIndex = 46;
            this.btnCreateGRPO.Text = "Create GRPO on this PO";
            this.btnCreateGRPO.UseVisualStyleBackColor = false;
            this.btnCreateGRPO.Click += new System.EventHandler(this.btnCreateGRPO_Click);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmployeeName.Location = new System.Drawing.Point(410, 169);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(127, 21);
            this.lblEmployeeName.TabIndex = 40;
            this.lblEmployeeName.Text = "Employee Name:";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalItems.Location = new System.Drawing.Point(379, 139);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(158, 21);
            this.lblTotalItems.TabIndex = 42;
            this.lblTotalItems.Text = "Total Items in this PO:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUnitPrice.Location = new System.Drawing.Point(3, 139);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(118, 21);
            this.lblUnitPrice.TabIndex = 41;
            this.lblUnitPrice.Text = "Payment Terms:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAddress.Location = new System.Drawing.Point(3, 108);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(69, 21);
            this.lblAddress.TabIndex = 43;
            this.lblAddress.Text = "Address:";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuppName.Location = new System.Drawing.Point(3, 78);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(117, 21);
            this.lblSuppName.TabIndex = 44;
            this.lblSuppName.Text = "Supplier Name:";
            // 
            // lblPOInfo
            // 
            this.lblPOInfo.AutoSize = true;
            this.lblPOInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPOInfo.Location = new System.Drawing.Point(3, 39);
            this.lblPOInfo.Name = "lblPOInfo";
            this.lblPOInfo.Size = new System.Drawing.Size(149, 21);
            this.lblPOInfo.TabIndex = 45;
            this.lblPOInfo.Text = "Purchase Order Info";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.btnShowDirectPO);
            this.pnlLeft.Controls.Add(this.lblSearch);
            this.pnlLeft.Controls.Add(this.txtSearch);
            this.pnlLeft.Controls.Add(this.dgvrPurchaseOrders);
            this.pnlLeft.Controls.Add(this.lblPurchaseOrders);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(684, 654);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnShowDirectPO
            // 
            this.btnShowDirectPO.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDirectPO.Location = new System.Drawing.Point(577, 20);
            this.btnShowDirectPO.Name = "btnShowDirectPO";
            this.btnShowDirectPO.Size = new System.Drawing.Size(104, 36);
            this.btnShowDirectPO.TabIndex = 47;
            this.btnShowDirectPO.Text = "Show Direct PO";
            this.btnShowDirectPO.UseVisualStyleBackColor = true;
            this.btnShowDirectPO.Click += new System.EventHandler(this.btnShowDirectPO_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.Location = new System.Drawing.Point(378, 62);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 21);
            this.lblSearch.TabIndex = 39;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(456, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 22);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // dgvrPurchaseOrders
            // 
            this.dgvrPurchaseOrders.AllowUserToAddRows = false;
            this.dgvrPurchaseOrders.AllowUserToDeleteRows = false;
            this.dgvrPurchaseOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrPurchaseOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrPurchaseOrders.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrPurchaseOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvrPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrPurchaseOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvrPurchaseOrders.Location = new System.Drawing.Point(7, 90);
            this.dgvrPurchaseOrders.MultiSelect = false;
            this.dgvrPurchaseOrders.Name = "dgvrPurchaseOrders";
            this.dgvrPurchaseOrders.ReadOnly = true;
            this.dgvrPurchaseOrders.RowHeadersVisible = false;
            this.dgvrPurchaseOrders.RowHeadersWidth = 51;
            this.dgvrPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrPurchaseOrders.Size = new System.Drawing.Size(674, 561);
            this.dgvrPurchaseOrders.TabIndex = 36;
            this.dgvrPurchaseOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrPurchaseOrders_CellClick);
            // 
            // lblPurchaseOrders
            // 
            this.lblPurchaseOrders.AutoSize = true;
            this.lblPurchaseOrders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPurchaseOrders.Location = new System.Drawing.Point(6, 61);
            this.lblPurchaseOrders.Name = "lblPurchaseOrders";
            this.lblPurchaseOrders.Size = new System.Drawing.Size(202, 21);
            this.lblPurchaseOrders.TabIndex = 38;
            this.lblPurchaseOrders.Text = "Quotation Purchase Orders:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewPOList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "ViewPOList";
            this.Text = "Purchase Order List";
            this.pnlMain.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlBottomRight.ResumeLayout(false);
            this.pnlBottomRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrItemList)).EndInit();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrPurchaseOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlRight;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvrPurchaseOrders;
        private System.Windows.Forms.Label lblPurchaseOrders;
        private System.Windows.Forms.Panel pnlBottomRight;
        private System.Windows.Forms.DataGridView dgvrItemList;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Button btnCreateGRPO;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.Label lblPOInfo;
        private System.Windows.Forms.Label lblPOName;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label lblPaymentTerms;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Button btnShowDirectPO;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}