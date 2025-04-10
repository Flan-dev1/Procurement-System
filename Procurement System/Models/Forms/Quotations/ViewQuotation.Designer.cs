
namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    partial class ViewQuotation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblPageName = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.lblItemsSearch = new System.Windows.Forms.Label();
            this.txtItemsSearch = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.btnGenerateDoc = new System.Windows.Forms.Button();
            this.dgvrfqItems = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSubRight = new System.Windows.Forms.TableLayoutPanel();
            this.pnlSuppliers = new System.Windows.Forms.Panel();
            this.lblSuppliersSearch = new System.Windows.Forms.Label();
            this.txtSuppliersSearch = new System.Windows.Forms.TextBox();
            this.dgvrfqSuppliers = new System.Windows.Forms.DataGridView();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlQuotes = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblQuotesSearch = new System.Windows.Forms.Label();
            this.txtQuotesSearch = new System.Windows.Forms.TextBox();
            this.dgvrfqQuotes = new System.Windows.Forms.DataGridView();
            this.lblQuotes = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqItems)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlSubRight.SuspendLayout();
            this.pnlSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqSuppliers)).BeginInit();
            this.pnlQuotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPageName
            // 
            this.lblPageName.AutoSize = true;
            this.lblPageName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageName.Location = new System.Drawing.Point(3, 3);
            this.lblPageName.Name = "lblPageName";
            this.lblPageName.Size = new System.Drawing.Size(170, 40);
            this.lblPageName.TabIndex = 0;
            this.lblPageName.Text = "View Quote";
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.lblItemsSearch);
            this.pnlItems.Controls.Add(this.txtItemsSearch);
            this.pnlItems.Controls.Add(this.lblItems);
            this.pnlItems.Controls.Add(this.btnGenerateDoc);
            this.pnlItems.Controls.Add(this.dgvrfqItems);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(3, 330);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(679, 321);
            this.pnlItems.TabIndex = 22;
            // 
            // lblItemsSearch
            // 
            this.lblItemsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemsSearch.AutoSize = true;
            this.lblItemsSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemsSearch.Location = new System.Drawing.Point(455, 6);
            this.lblItemsSearch.Name = "lblItemsSearch";
            this.lblItemsSearch.Size = new System.Drawing.Size(60, 21);
            this.lblItemsSearch.TabIndex = 28;
            this.lblItemsSearch.Text = "Search:";
            // 
            // txtItemsSearch
            // 
            this.txtItemsSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemsSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemsSearch.Location = new System.Drawing.Point(521, 6);
            this.txtItemsSearch.Name = "txtItemsSearch";
            this.txtItemsSearch.Size = new System.Drawing.Size(146, 23);
            this.txtItemsSearch.TabIndex = 27;
            this.txtItemsSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemsSearch_KeyUp);
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(3, 8);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(115, 21);
            this.lblItems.TabIndex = 5;
            this.lblItems.Text = "Items In Quote:";
            // 
            // btnGenerateDoc
            // 
            this.btnGenerateDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGenerateDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateDoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDoc.Location = new System.Drawing.Point(473, 285);
            this.btnGenerateDoc.Name = "btnGenerateDoc";
            this.btnGenerateDoc.Size = new System.Drawing.Size(194, 30);
            this.btnGenerateDoc.TabIndex = 16;
            this.btnGenerateDoc.Text = "Generate Quote Document";
            this.btnGenerateDoc.UseVisualStyleBackColor = false;
            this.btnGenerateDoc.Click += new System.EventHandler(this.btnGenerateDoc_Click);
            // 
            // dgvrfqItems
            // 
            this.dgvrfqItems.AllowUserToAddRows = false;
            this.dgvrfqItems.AllowUserToDeleteRows = false;
            this.dgvrfqItems.AllowUserToResizeRows = false;
            this.dgvrfqItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqItems.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrfqItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrfqItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrfqItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrfqItems.Location = new System.Drawing.Point(7, 34);
            this.dgvrfqItems.Name = "dgvrfqItems";
            this.dgvrfqItems.ReadOnly = true;
            this.dgvrfqItems.RowHeadersVisible = false;
            this.dgvrfqItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqItems.Size = new System.Drawing.Size(660, 248);
            this.dgvrfqItems.TabIndex = 15;
            this.dgvrfqItems.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvrfqItems_DataError);
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 2;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.Controls.Add(this.pnlSubRight, 1, 0);
            this.pnlMain.Controls.Add(this.pnlQuotes, 0, 0);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 1;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(1381, 660);
            this.pnlMain.TabIndex = 15;
            // 
            // pnlSubRight
            // 
            this.pnlSubRight.ColumnCount = 1;
            this.pnlSubRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSubRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlSubRight.Controls.Add(this.pnlItems, 0, 1);
            this.pnlSubRight.Controls.Add(this.pnlSuppliers, 0, 0);
            this.pnlSubRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubRight.Location = new System.Drawing.Point(693, 3);
            this.pnlSubRight.Name = "pnlSubRight";
            this.pnlSubRight.RowCount = 2;
            this.pnlSubRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSubRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlSubRight.Size = new System.Drawing.Size(685, 654);
            this.pnlSubRight.TabIndex = 0;
            // 
            // pnlSuppliers
            // 
            this.pnlSuppliers.Controls.Add(this.lblSuppliersSearch);
            this.pnlSuppliers.Controls.Add(this.txtSuppliersSearch);
            this.pnlSuppliers.Controls.Add(this.dgvrfqSuppliers);
            this.pnlSuppliers.Controls.Add(this.lblSuppliers);
            this.pnlSuppliers.Controls.Add(this.lblCurrentTime);
            this.pnlSuppliers.Controls.Add(this.lblTime);
            this.pnlSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSuppliers.Location = new System.Drawing.Point(3, 3);
            this.pnlSuppliers.Name = "pnlSuppliers";
            this.pnlSuppliers.Size = new System.Drawing.Size(679, 321);
            this.pnlSuppliers.TabIndex = 23;
            // 
            // lblSuppliersSearch
            // 
            this.lblSuppliersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuppliersSearch.AutoSize = true;
            this.lblSuppliersSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuppliersSearch.Location = new System.Drawing.Point(455, 47);
            this.lblSuppliersSearch.Name = "lblSuppliersSearch";
            this.lblSuppliersSearch.Size = new System.Drawing.Size(60, 21);
            this.lblSuppliersSearch.TabIndex = 26;
            this.lblSuppliersSearch.Text = "Search:";
            // 
            // txtSuppliersSearch
            // 
            this.txtSuppliersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSuppliersSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliersSearch.Location = new System.Drawing.Point(521, 49);
            this.txtSuppliersSearch.Name = "txtSuppliersSearch";
            this.txtSuppliersSearch.Size = new System.Drawing.Size(146, 23);
            this.txtSuppliersSearch.TabIndex = 25;
            this.txtSuppliersSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSuppliersSearch_KeyUp);
            // 
            // dgvrfqSuppliers
            // 
            this.dgvrfqSuppliers.AllowUserToAddRows = false;
            this.dgvrfqSuppliers.AllowUserToDeleteRows = false;
            this.dgvrfqSuppliers.AllowUserToResizeRows = false;
            this.dgvrfqSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqSuppliers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqSuppliers.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrfqSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvrfqSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrfqSuppliers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvrfqSuppliers.Location = new System.Drawing.Point(7, 78);
            this.dgvrfqSuppliers.Name = "dgvrfqSuppliers";
            this.dgvrfqSuppliers.ReadOnly = true;
            this.dgvrfqSuppliers.RowHeadersVisible = false;
            this.dgvrfqSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqSuppliers.Size = new System.Drawing.Size(660, 240);
            this.dgvrfqSuppliers.TabIndex = 20;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(3, 49);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(99, 21);
            this.lblSuppliers.TabIndex = 19;
            this.lblSuppliers.Text = "Supplier List:";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(575, 19);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 21);
            this.lblCurrentTime.TabIndex = 18;
            this.lblCurrentTime.Text = "##:## ##";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(522, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "TIME:";
            // 
            // pnlQuotes
            // 
            this.pnlQuotes.Controls.Add(this.lblMessage);
            this.pnlQuotes.Controls.Add(this.lblQuotesSearch);
            this.pnlQuotes.Controls.Add(this.txtQuotesSearch);
            this.pnlQuotes.Controls.Add(this.dgvrfqQuotes);
            this.pnlQuotes.Controls.Add(this.lblQuotes);
            this.pnlQuotes.Controls.Add(this.lblPageName);
            this.pnlQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuotes.Location = new System.Drawing.Point(3, 3);
            this.pnlQuotes.Name = "pnlQuotes";
            this.pnlQuotes.Size = new System.Drawing.Size(684, 654);
            this.pnlQuotes.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(10, 625);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(660, 23);
            this.lblMessage.TabIndex = 25;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQuotesSearch
            // 
            this.lblQuotesSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuotesSearch.AutoSize = true;
            this.lblQuotesSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQuotesSearch.Location = new System.Drawing.Point(458, 52);
            this.lblQuotesSearch.Name = "lblQuotesSearch";
            this.lblQuotesSearch.Size = new System.Drawing.Size(60, 21);
            this.lblQuotesSearch.TabIndex = 24;
            this.lblQuotesSearch.Text = "Search:";
            // 
            // txtQuotesSearch
            // 
            this.txtQuotesSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuotesSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuotesSearch.Location = new System.Drawing.Point(524, 52);
            this.txtQuotesSearch.Name = "txtQuotesSearch";
            this.txtQuotesSearch.Size = new System.Drawing.Size(146, 23);
            this.txtQuotesSearch.TabIndex = 23;
            this.txtQuotesSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuotesSearch_KeyUp);
            // 
            // dgvrfqQuotes
            // 
            this.dgvrfqQuotes.AllowUserToAddRows = false;
            this.dgvrfqQuotes.AllowUserToDeleteRows = false;
            this.dgvrfqQuotes.AllowUserToResizeRows = false;
            this.dgvrfqQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrfqQuotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqQuotes.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrfqQuotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvrfqQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrfqQuotes.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvrfqQuotes.Location = new System.Drawing.Point(10, 81);
            this.dgvrfqQuotes.Name = "dgvrfqQuotes";
            this.dgvrfqQuotes.ReadOnly = true;
            this.dgvrfqQuotes.RowHeadersVisible = false;
            this.dgvrfqQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqQuotes.Size = new System.Drawing.Size(660, 531);
            this.dgvrfqQuotes.TabIndex = 22;
            this.dgvrfqQuotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrfqQuotes_CellClick);
            // 
            // lblQuotes
            // 
            this.lblQuotes.AutoSize = true;
            this.lblQuotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuotes.Location = new System.Drawing.Point(6, 57);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.Size = new System.Drawing.Size(113, 21);
            this.lblQuotes.TabIndex = 21;
            this.lblQuotes.Text = "List of Quotes: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "ViewQuotation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quotations";
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqItems)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlSubRight.ResumeLayout(false);
            this.pnlSuppliers.ResumeLayout(false);
            this.pnlSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqSuppliers)).EndInit();
            this.pnlQuotes.ResumeLayout(false);
            this.pnlQuotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGenerateDoc;
        private System.Windows.Forms.DataGridView dgvrfqItems;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblPageName;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlSubRight;
        private System.Windows.Forms.Panel pnlSuppliers;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView dgvrfqSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Panel pnlQuotes;
        private System.Windows.Forms.DataGridView dgvrfqQuotes;
        private System.Windows.Forms.Label lblQuotes;
        private System.Windows.Forms.Label lblItemsSearch;
        private System.Windows.Forms.TextBox txtItemsSearch;
        private System.Windows.Forms.Label lblSuppliersSearch;
        private System.Windows.Forms.TextBox txtSuppliersSearch;
        private System.Windows.Forms.Label lblQuotesSearch;
        private System.Windows.Forms.TextBox txtQuotesSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMessage;
    }
}