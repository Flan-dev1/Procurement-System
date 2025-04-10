
namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    partial class CreateQuotation
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUpRight = new System.Windows.Forms.Panel();
            this.lblDue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostingDate = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlUpLeft = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCreateQuote = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.pnlDownLeft = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvrfqItemList = new System.Windows.Forms.DataGridView();
            this.btnGenerateRFQ = new System.Windows.Forms.Button();
            this.pnlDownRight = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchSupp = new System.Windows.Forms.TextBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.btnAddSuppliers = new System.Windows.Forms.Button();
            this.dgvrfqSupplierList = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlUpRight.SuspendLayout();
            this.pnlUpLeft.SuspendLayout();
            this.pnlDownLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqItemList)).BeginInit();
            this.pnlDownRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqSupplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tableLayoutPanel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1381, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlUpRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlUpLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDownLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlDownRight, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 660);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // pnlUpRight
            // 
            this.pnlUpRight.Controls.Add(this.lblDue);
            this.pnlUpRight.Controls.Add(this.label1);
            this.pnlUpRight.Controls.Add(this.lblPostingDate);
            this.pnlUpRight.Controls.Add(this.lblRemarks);
            this.pnlUpRight.Controls.Add(this.txtRemarks);
            this.pnlUpRight.Controls.Add(this.lblDate);
            this.pnlUpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpRight.Location = new System.Drawing.Point(693, 3);
            this.pnlUpRight.Name = "pnlUpRight";
            this.pnlUpRight.Size = new System.Drawing.Size(685, 291);
            this.pnlUpRight.TabIndex = 23;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(576, 50);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(84, 21);
            this.lblDue.TabIndex = 21;
            this.lblDue.Text = "Valid Until:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(473, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Valid Until:";
            // 
            // lblPostingDate
            // 
            this.lblPostingDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostingDate.AutoSize = true;
            this.lblPostingDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostingDate.Location = new System.Drawing.Point(576, 19);
            this.lblPostingDate.Name = "lblPostingDate";
            this.lblPostingDate.Size = new System.Drawing.Size(97, 21);
            this.lblPostingDate.TabIndex = 18;
            this.lblPostingDate.Text = "Posting Date";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(3, 62);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(71, 21);
            this.lblRemarks.TabIndex = 7;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(7, 86);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(666, 202);
            this.txtRemarks.TabIndex = 11;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(473, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(97, 21);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Posting Date";
            // 
            // pnlUpLeft
            // 
            this.pnlUpLeft.Controls.Add(this.lblCurrentTime);
            this.pnlUpLeft.Controls.Add(this.lblTime);
            this.pnlUpLeft.Controls.Add(this.lblMessage);
            this.pnlUpLeft.Controls.Add(this.lblCreateQuote);
            this.pnlUpLeft.Controls.Add(this.txtItemName);
            this.pnlUpLeft.Controls.Add(this.btnAddItem);
            this.pnlUpLeft.Controls.Add(this.lblItemName);
            this.pnlUpLeft.Controls.Add(this.lblColor);
            this.pnlUpLeft.Controls.Add(this.lblQuantity);
            this.pnlUpLeft.Controls.Add(this.txtColor);
            this.pnlUpLeft.Controls.Add(this.txtQuantity);
            this.pnlUpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlUpLeft.Name = "pnlUpLeft";
            this.pnlUpLeft.Size = new System.Drawing.Size(684, 291);
            this.pnlUpLeft.TabIndex = 20;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(73, 51);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 21);
            this.lblCurrentTime.TabIndex = 21;
            this.lblCurrentTime.Text = "##:## ##";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(20, 51);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "TIME:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(144, 72);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 19;
            // 
            // lblCreateQuote
            // 
            this.lblCreateQuote.AutoSize = true;
            this.lblCreateQuote.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateQuote.Location = new System.Drawing.Point(0, 0);
            this.lblCreateQuote.Name = "lblCreateQuote";
            this.lblCreateQuote.Size = new System.Drawing.Size(190, 40);
            this.lblCreateQuote.TabIndex = 0;
            this.lblCreateQuote.Text = "Create Quote";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(135, 91);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(344, 25);
            this.txtItemName.TabIndex = 8;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(135, 184);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(94, 31);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(22, 91);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 21);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(22, 121);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 21);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(22, 153);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(70, 21);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(135, 122);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(344, 25);
            this.txtColor.TabIndex = 9;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(135, 153);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(344, 25);
            this.txtQuantity.TabIndex = 10;
            // 
            // pnlDownLeft
            // 
            this.pnlDownLeft.Controls.Add(this.label5);
            this.pnlDownLeft.Controls.Add(this.txtSearchItem);
            this.pnlDownLeft.Controls.Add(this.lblItems);
            this.pnlDownLeft.Controls.Add(this.dgvrfqItemList);
            this.pnlDownLeft.Controls.Add(this.btnGenerateRFQ);
            this.pnlDownLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDownLeft.Location = new System.Drawing.Point(3, 300);
            this.pnlDownLeft.Name = "pnlDownLeft";
            this.pnlDownLeft.Size = new System.Drawing.Size(684, 357);
            this.pnlDownLeft.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(371, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Search:";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(447, 11);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(225, 22);
            this.txtSearchItem.TabIndex = 44;
            this.txtSearchItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyUp);
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(3, 15);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(72, 21);
            this.lblItems.TabIndex = 4;
            this.lblItems.Text = "Item List:";
            // 
            // dgvrfqItemList
            // 
            this.dgvrfqItemList.AllowUserToAddRows = false;
            this.dgvrfqItemList.AllowUserToDeleteRows = false;
            this.dgvrfqItemList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrfqItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqItemList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvrfqItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrfqItemList.Location = new System.Drawing.Point(7, 39);
            this.dgvrfqItemList.Name = "dgvrfqItemList";
            this.dgvrfqItemList.ReadOnly = true;
            this.dgvrfqItemList.RowHeadersVisible = false;
            this.dgvrfqItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqItemList.Size = new System.Drawing.Size(665, 271);
            this.dgvrfqItemList.TabIndex = 13;
            this.dgvrfqItemList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvrfqItemList_KeyUp);
            // 
            // btnGenerateRFQ
            // 
            this.btnGenerateRFQ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateRFQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerateRFQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateRFQ.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateRFQ.Location = new System.Drawing.Point(579, 322);
            this.btnGenerateRFQ.Name = "btnGenerateRFQ";
            this.btnGenerateRFQ.Size = new System.Drawing.Size(95, 30);
            this.btnGenerateRFQ.TabIndex = 14;
            this.btnGenerateRFQ.Text = "Generate RFQ";
            this.btnGenerateRFQ.UseVisualStyleBackColor = false;
            this.btnGenerateRFQ.Click += new System.EventHandler(this.btnGenerateRFQ_Click);
            // 
            // pnlDownRight
            // 
            this.pnlDownRight.Controls.Add(this.label2);
            this.pnlDownRight.Controls.Add(this.txtSearchSupp);
            this.pnlDownRight.Controls.Add(this.lblSuppliers);
            this.pnlDownRight.Controls.Add(this.btnAddSuppliers);
            this.pnlDownRight.Controls.Add(this.dgvrfqSupplierList);
            this.pnlDownRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDownRight.Location = new System.Drawing.Point(693, 300);
            this.pnlDownRight.Name = "pnlDownRight";
            this.pnlDownRight.Size = new System.Drawing.Size(685, 357);
            this.pnlDownRight.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(372, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Search:";
            // 
            // txtSearchSupp
            // 
            this.txtSearchSupp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSupp.Location = new System.Drawing.Point(448, 11);
            this.txtSearchSupp.Name = "txtSearchSupp";
            this.txtSearchSupp.Size = new System.Drawing.Size(225, 22);
            this.txtSearchSupp.TabIndex = 46;
            this.txtSearchSupp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchSupp_KeyUp);
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(3, 15);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(99, 21);
            this.lblSuppliers.TabIndex = 5;
            this.lblSuppliers.Text = "Supplier List:";
            // 
            // btnAddSuppliers
            // 
            this.btnAddSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSuppliers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSuppliers.Location = new System.Drawing.Point(500, 322);
            this.btnAddSuppliers.Name = "btnAddSuppliers";
            this.btnAddSuppliers.Size = new System.Drawing.Size(173, 30);
            this.btnAddSuppliers.TabIndex = 16;
            this.btnAddSuppliers.Text = "Add Suppliers";
            this.btnAddSuppliers.UseVisualStyleBackColor = false;
            this.btnAddSuppliers.Click += new System.EventHandler(this.btnAddSuppliers_Click);
            // 
            // dgvrfqSupplierList
            // 
            this.dgvrfqSupplierList.AllowUserToAddRows = false;
            this.dgvrfqSupplierList.AllowUserToDeleteRows = false;
            this.dgvrfqSupplierList.AllowUserToResizeRows = false;
            this.dgvrfqSupplierList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqSupplierList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrfqSupplierList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqSupplierList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvrfqSupplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrfqSupplierList.Location = new System.Drawing.Point(7, 39);
            this.dgvrfqSupplierList.Name = "dgvrfqSupplierList";
            this.dgvrfqSupplierList.ReadOnly = true;
            this.dgvrfqSupplierList.RowHeadersVisible = false;
            this.dgvrfqSupplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqSupplierList.Size = new System.Drawing.Size(666, 271);
            this.dgvrfqSupplierList.TabIndex = 15;
            this.dgvrfqSupplierList.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvrfqSupplierList_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CreateQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreateQuotation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quotations";
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlUpRight.ResumeLayout(false);
            this.pnlUpRight.PerformLayout();
            this.pnlUpLeft.ResumeLayout(false);
            this.pnlUpLeft.PerformLayout();
            this.pnlDownLeft.ResumeLayout(false);
            this.pnlDownLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqItemList)).EndInit();
            this.pnlDownRight.ResumeLayout(false);
            this.pnlDownRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqSupplierList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnAddSuppliers;
        private System.Windows.Forms.DataGridView dgvrfqSupplierList;
        private System.Windows.Forms.Button btnGenerateRFQ;
        private System.Windows.Forms.DataGridView dgvrfqItemList;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblPostingDate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlUpLeft;
        private System.Windows.Forms.Panel pnlDownLeft;
        private System.Windows.Forms.Panel pnlDownRight;
        private System.Windows.Forms.Panel pnlUpRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchSupp;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCreateQuote;
        private System.Windows.Forms.Timer timer1;
    }
}