
namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    partial class CompareQuotation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.txtSearchPrinted = new System.Windows.Forms.TextBox();
            this.lblSearchPrinted = new System.Windows.Forms.Label();
            this.lblPrinted = new System.Windows.Forms.Label();
            this.dgvPrinted = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvComparison = new System.Windows.Forms.DataGridView();
            this.lblComparison = new System.Windows.Forms.Label();
            this.pnlBottomLeft = new System.Windows.Forms.Panel();
            this.txtSearchItems = new System.Windows.Forms.TextBox();
            this.lblSearchItems = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.btnCreatePO = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lvlLowestCostSupplierName = new System.Windows.Forms.Label();
            this.lblNumSuppliers = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.lblLowestCostSupplier = new System.Windows.Forms.Label();
            this.lblSuppliersInQuote = new System.Windows.Forms.Label();
            this.lblItemsInQuote = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSysAnalysis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinted)).BeginInit();
            this.pnlTopRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparison)).BeginInit();
            this.pnlBottomLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlBottomRight.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTopLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTopRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlBottomLeft, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBottomRight, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 679);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.txtSearchPrinted);
            this.pnlTopLeft.Controls.Add(this.lblSearchPrinted);
            this.pnlTopLeft.Controls.Add(this.lblPrinted);
            this.pnlTopLeft.Controls.Add(this.dgvPrinted);
            this.pnlTopLeft.Controls.Add(this.lblName);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLeft.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pnlTopLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(615, 333);
            this.pnlTopLeft.TabIndex = 1;
            // 
            // txtSearchPrinted
            // 
            this.txtSearchPrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPrinted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSearchPrinted.Location = new System.Drawing.Point(449, 63);
            this.txtSearchPrinted.Name = "txtSearchPrinted";
            this.txtSearchPrinted.Size = new System.Drawing.Size(151, 20);
            this.txtSearchPrinted.TabIndex = 4;
            this.txtSearchPrinted.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchPrinted_KeyUp);
            // 
            // lblSearchPrinted
            // 
            this.lblSearchPrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchPrinted.AutoSize = true;
            this.lblSearchPrinted.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearchPrinted.Location = new System.Drawing.Point(383, 60);
            this.lblSearchPrinted.Name = "lblSearchPrinted";
            this.lblSearchPrinted.Size = new System.Drawing.Size(60, 21);
            this.lblSearchPrinted.TabIndex = 3;
            this.lblSearchPrinted.Text = "Search:";
            // 
            // lblPrinted
            // 
            this.lblPrinted.AutoSize = true;
            this.lblPrinted.Location = new System.Drawing.Point(16, 60);
            this.lblPrinted.Name = "lblPrinted";
            this.lblPrinted.Size = new System.Drawing.Size(144, 21);
            this.lblPrinted.TabIndex = 2;
            this.lblPrinted.Text = "Printed Quotations:";
            // 
            // dgvPrinted
            // 
            this.dgvPrinted.AllowUserToAddRows = false;
            this.dgvPrinted.AllowUserToDeleteRows = false;
            this.dgvPrinted.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrinted.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrinted.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrinted.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPrinted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrinted.Location = new System.Drawing.Point(20, 92);
            this.dgvPrinted.MultiSelect = false;
            this.dgvPrinted.Name = "dgvPrinted";
            this.dgvPrinted.ReadOnly = true;
            this.dgvPrinted.RowHeadersVisible = false;
            this.dgvPrinted.RowHeadersWidth = 51;
            this.dgvPrinted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrinted.Size = new System.Drawing.Size(580, 221);
            this.dgvPrinted.TabIndex = 1;
            this.dgvPrinted.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrinted_CellClick);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(238, 40);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Compare Quotes";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.lblCurrentTime);
            this.pnlTopRight.Controls.Add(this.lblTime);
            this.pnlTopRight.Controls.Add(this.dgvComparison);
            this.pnlTopRight.Controls.Add(this.lblComparison);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopRight.Location = new System.Drawing.Point(624, 3);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(754, 333);
            this.pnlTopRight.TabIndex = 2;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(649, 13);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 21);
            this.lblCurrentTime.TabIndex = 20;
            this.lblCurrentTime.Text = "##:## ##";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(596, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 19;
            this.lblTime.Text = "TIME:";
            // 
            // dgvComparison
            // 
            this.dgvComparison.AllowUserToAddRows = false;
            this.dgvComparison.AllowUserToDeleteRows = false;
            this.dgvComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComparison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComparison.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComparison.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComparison.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComparison.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComparison.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComparison.Location = new System.Drawing.Point(14, 92);
            this.dgvComparison.MultiSelect = false;
            this.dgvComparison.Name = "dgvComparison";
            this.dgvComparison.ReadOnly = true;
            this.dgvComparison.RowHeadersVisible = false;
            this.dgvComparison.RowHeadersWidth = 51;
            this.dgvComparison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComparison.Size = new System.Drawing.Size(722, 221);
            this.dgvComparison.TabIndex = 1;
            this.dgvComparison.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComparison_CellClick);
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblComparison.Location = new System.Drawing.Point(10, 60);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(98, 21);
            this.lblComparison.TabIndex = 0;
            this.lblComparison.Text = "Comparison:";
            // 
            // pnlBottomLeft
            // 
            this.pnlBottomLeft.Controls.Add(this.txtSearchItems);
            this.pnlBottomLeft.Controls.Add(this.lblSearchItems);
            this.pnlBottomLeft.Controls.Add(this.lblItems);
            this.pnlBottomLeft.Controls.Add(this.dgvItems);
            this.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomLeft.Location = new System.Drawing.Point(3, 342);
            this.pnlBottomLeft.Name = "pnlBottomLeft";
            this.pnlBottomLeft.Size = new System.Drawing.Size(615, 334);
            this.pnlBottomLeft.TabIndex = 3;
            // 
            // txtSearchItems
            // 
            this.txtSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItems.Location = new System.Drawing.Point(448, 45);
            this.txtSearchItems.Name = "txtSearchItems";
            this.txtSearchItems.Size = new System.Drawing.Size(151, 20);
            this.txtSearchItems.TabIndex = 8;
            this.txtSearchItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchItems_KeyUp);
            // 
            // lblSearchItems
            // 
            this.lblSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchItems.AutoSize = true;
            this.lblSearchItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearchItems.Location = new System.Drawing.Point(382, 42);
            this.lblSearchItems.Name = "lblSearchItems";
            this.lblSearchItems.Size = new System.Drawing.Size(60, 21);
            this.lblSearchItems.TabIndex = 7;
            this.lblSearchItems.Text = "Search:";
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItems.Location = new System.Drawing.Point(16, 42);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(141, 21);
            this.lblItems.TabIndex = 6;
            this.lblItems.Text = "Items In the Quote:";
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvItems.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.Location = new System.Drawing.Point(19, 74);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(580, 222);
            this.dgvItems.TabIndex = 5;
            this.dgvItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvItems_DataError);
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Controls.Add(this.btnCreatePO);
            this.pnlBottomRight.Controls.Add(this.pnlSummary);
            this.pnlBottomRight.Controls.Add(this.lblSysAnalysis);
            this.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomRight.Location = new System.Drawing.Point(624, 342);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Size = new System.Drawing.Size(754, 334);
            this.pnlBottomRight.TabIndex = 4;
            // 
            // btnCreatePO
            // 
            this.btnCreatePO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreatePO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreatePO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePO.Location = new System.Drawing.Point(573, 286);
            this.btnCreatePO.Name = "btnCreatePO";
            this.btnCreatePO.Size = new System.Drawing.Size(163, 39);
            this.btnCreatePO.TabIndex = 4;
            this.btnCreatePO.Text = "Create PO";
            this.btnCreatePO.UseVisualStyleBackColor = false;
            this.btnCreatePO.Click += new System.EventHandler(this.btnCreatePO_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lvlLowestCostSupplierName);
            this.pnlSummary.Controls.Add(this.lblNumSuppliers);
            this.pnlSummary.Controls.Add(this.lblNumItems);
            this.pnlSummary.Controls.Add(this.lblLowestCostSupplier);
            this.pnlSummary.Controls.Add(this.lblSuppliersInQuote);
            this.pnlSummary.Controls.Add(this.lblItemsInQuote);
            this.pnlSummary.Controls.Add(this.lblSummary);
            this.pnlSummary.Location = new System.Drawing.Point(18, 45);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(718, 222);
            this.pnlSummary.TabIndex = 3;
            // 
            // lvlLowestCostSupplierName
            // 
            this.lvlLowestCostSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlLowestCostSupplierName.AutoSize = true;
            this.lvlLowestCostSupplierName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlLowestCostSupplierName.Location = new System.Drawing.Point(198, 92);
            this.lvlLowestCostSupplierName.Name = "lvlLowestCostSupplierName";
            this.lvlLowestCostSupplierName.Size = new System.Drawing.Size(95, 17);
            this.lvlLowestCostSupplierName.TabIndex = 6;
            this.lvlLowestCostSupplierName.Text = "Supplier Name";
            // 
            // lblNumSuppliers
            // 
            this.lblNumSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumSuppliers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSuppliers.Location = new System.Drawing.Point(227, 70);
            this.lblNumSuppliers.Name = "lblNumSuppliers";
            this.lblNumSuppliers.Size = new System.Drawing.Size(82, 17);
            this.lblNumSuppliers.TabIndex = 5;
            this.lblNumSuppliers.Text = "#";
            // 
            // lblNumItems
            // 
            this.lblNumItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumItems.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItems.Location = new System.Drawing.Point(227, 49);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(85, 21);
            this.lblNumItems.TabIndex = 4;
            this.lblNumItems.Text = "#";
            // 
            // lblLowestCostSupplier
            // 
            this.lblLowestCostSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLowestCostSupplier.AutoSize = true;
            this.lblLowestCostSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestCostSupplier.Location = new System.Drawing.Point(49, 92);
            this.lblLowestCostSupplier.Name = "lblLowestCostSupplier";
            this.lblLowestCostSupplier.Size = new System.Drawing.Size(128, 17);
            this.lblLowestCostSupplier.TabIndex = 3;
            this.lblLowestCostSupplier.Text = "Supplier lowest cost:";
            // 
            // lblSuppliersInQuote
            // 
            this.lblSuppliersInQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuppliersInQuote.AutoSize = true;
            this.lblSuppliersInQuote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliersInQuote.Location = new System.Drawing.Point(49, 70);
            this.lblSuppliersInQuote.Name = "lblSuppliersInQuote";
            this.lblSuppliersInQuote.Size = new System.Drawing.Size(163, 17);
            this.lblSuppliersInQuote.TabIndex = 2;
            this.lblSuppliersInQuote.Text = "Suppliers in the Quotation:";
            // 
            // lblItemsInQuote
            // 
            this.lblItemsInQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemsInQuote.AutoSize = true;
            this.lblItemsInQuote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsInQuote.Location = new System.Drawing.Point(49, 49);
            this.lblItemsInQuote.Name = "lblItemsInQuote";
            this.lblItemsInQuote.Size = new System.Drawing.Size(172, 17);
            this.lblItemsInQuote.TabIndex = 1;
            this.lblItemsInQuote.Text = "Total Items in the Quotation:";
            // 
            // lblSummary
            // 
            this.lblSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(24, 15);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(65, 17);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Summary:";
            // 
            // lblSysAnalysis
            // 
            this.lblSysAnalysis.AutoSize = true;
            this.lblSysAnalysis.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSysAnalysis.Location = new System.Drawing.Point(14, 11);
            this.lblSysAnalysis.Name = "lblSysAnalysis";
            this.lblSysAnalysis.Size = new System.Drawing.Size(79, 21);
            this.lblSysAnalysis.TabIndex = 2;
            this.lblSysAnalysis.Text = "Overview:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CompareQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 679);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CompareQuotation";
            this.Text = "Quotations";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrinted)).EndInit();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparison)).EndInit();
            this.pnlBottomLeft.ResumeLayout(false);
            this.pnlBottomLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlBottomRight.ResumeLayout(false);
            this.pnlBottomRight.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.TextBox txtSearchPrinted;
        private System.Windows.Forms.Label lblSearchPrinted;
        private System.Windows.Forms.Label lblPrinted;
        private System.Windows.Forms.DataGridView dgvPrinted;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.DataGridView dgvComparison;
        private System.Windows.Forms.Label lblComparison;
        private System.Windows.Forms.Panel pnlBottomLeft;
        private System.Windows.Forms.TextBox txtSearchItems;
        private System.Windows.Forms.Label lblSearchItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel pnlBottomRight;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSysAnalysis;
        private System.Windows.Forms.Label lvlLowestCostSupplierName;
        private System.Windows.Forms.Label lblNumSuppliers;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.Label lblLowestCostSupplier;
        private System.Windows.Forms.Label lblSuppliersInQuote;
        private System.Windows.Forms.Label lblItemsInQuote;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnCreatePO;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}