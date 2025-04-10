
namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    partial class UpdateQuotation
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
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.dgvrfqItemListInQuote = new System.Windows.Forms.DataGridView();
            this.pnlUpLeft = new System.Windows.Forms.Panel();
            this.lblQuoteID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.btnShowQuotes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblUpdateQuote = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlDownLeft = new System.Windows.Forms.Panel();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.btnUpdateQuote = new System.Windows.Forms.Button();
            this.dgvrfqSupplierListInQuote = new System.Windows.Forms.DataGridView();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlUpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqItemListInQuote)).BeginInit();
            this.pnlUpLeft.SuspendLayout();
            this.pnlDownLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqSupplierListInQuote)).BeginInit();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.02245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.97755F));
            this.tableLayoutPanel1.Controls.Add(this.pnlUpRight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlUpLeft, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlDownLeft, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.05911F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.94089F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 660);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // pnlUpRight
            // 
            this.pnlUpRight.Controls.Add(this.lblCurrentTime);
            this.pnlUpRight.Controls.Add(this.lblItems);
            this.pnlUpRight.Controls.Add(this.lblTime);
            this.pnlUpRight.Controls.Add(this.dgvrfqItemListInQuote);
            this.pnlUpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUpRight.Location = new System.Drawing.Point(680, 3);
            this.pnlUpRight.Name = "pnlUpRight";
            this.pnlUpRight.Size = new System.Drawing.Size(698, 297);
            this.pnlUpRight.TabIndex = 23;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(594, 19);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 21);
            this.lblCurrentTime.TabIndex = 18;
            this.lblCurrentTime.Text = "##:## ##";
            // 
            // lblItems
            // 
            this.lblItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItems.AutoSize = true;
            this.lblItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItems.Location = new System.Drawing.Point(62, 23);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(141, 21);
            this.lblItems.TabIndex = 4;
            this.lblItems.Text = "Items in the Quote:";
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(541, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "TIME:";
            // 
            // dgvrfqItemListInQuote
            // 
            this.dgvrfqItemListInQuote.AllowUserToAddRows = false;
            this.dgvrfqItemListInQuote.AllowUserToDeleteRows = false;
            this.dgvrfqItemListInQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqItemListInQuote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrfqItemListInQuote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqItemListInQuote.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvrfqItemListInQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrfqItemListInQuote.Location = new System.Drawing.Point(66, 47);
            this.dgvrfqItemListInQuote.Name = "dgvrfqItemListInQuote";
            this.dgvrfqItemListInQuote.ReadOnly = true;
            this.dgvrfqItemListInQuote.RowHeadersVisible = false;
            this.dgvrfqItemListInQuote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqItemListInQuote.Size = new System.Drawing.Size(620, 211);
            this.dgvrfqItemListInQuote.TabIndex = 13;
            this.dgvrfqItemListInQuote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrfqItemListInQuote_CellClick);
            this.dgvrfqItemListInQuote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvrfqItemListInQuote_KeyUp);
            // 
            // pnlUpLeft
            // 
            this.pnlUpLeft.Controls.Add(this.lblQuoteID);
            this.pnlUpLeft.Controls.Add(this.label3);
            this.pnlUpLeft.Controls.Add(this.label2);
            this.pnlUpLeft.Controls.Add(this.cbCategory);
            this.pnlUpLeft.Controls.Add(this.cbItemType);
            this.pnlUpLeft.Controls.Add(this.btnShowQuotes);
            this.pnlUpLeft.Controls.Add(this.label1);
            this.pnlUpLeft.Controls.Add(this.lblMessage);
            this.pnlUpLeft.Controls.Add(this.txtPrice);
            this.pnlUpLeft.Controls.Add(this.lblItem);
            this.pnlUpLeft.Controls.Add(this.lblUpdateQuote);
            this.pnlUpLeft.Controls.Add(this.txtItemName);
            this.pnlUpLeft.Controls.Add(this.btnUpdate);
            this.pnlUpLeft.Controls.Add(this.lblItemName);
            this.pnlUpLeft.Controls.Add(this.lblQuantity);
            this.pnlUpLeft.Controls.Add(this.lblPrice);
            this.pnlUpLeft.Controls.Add(this.txtQuantity);
            this.pnlUpLeft.Controls.Add(this.txtColor);
            this.pnlUpLeft.Controls.Add(this.btnClear);
            this.pnlUpLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUpLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlUpLeft.Name = "pnlUpLeft";
            this.pnlUpLeft.Size = new System.Drawing.Size(671, 297);
            this.pnlUpLeft.TabIndex = 20;
            // 
            // lblQuoteID
            // 
            this.lblQuoteID.AutoSize = true;
            this.lblQuoteID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteID.Location = new System.Drawing.Point(137, 60);
            this.lblQuoteID.Name = "lblQuoteID";
            this.lblQuoteID.Size = new System.Drawing.Size(0, 21);
            this.lblQuoteID.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(141, 221);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(165, 29);
            this.cbCategory.TabIndex = 28;
            // 
            // cbItemType
            // 
            this.cbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(363, 221);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(121, 29);
            this.cbItemType.TabIndex = 27;
            // 
            // btnShowQuotes
            // 
            this.btnShowQuotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowQuotes.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowQuotes.Location = new System.Drawing.Point(511, 56);
            this.btnShowQuotes.MaximumSize = new System.Drawing.Size(165, 31);
            this.btnShowQuotes.MinimumSize = new System.Drawing.Size(77, 31);
            this.btnShowQuotes.Name = "btnShowQuotes";
            this.btnShowQuotes.Size = new System.Drawing.Size(145, 31);
            this.btnShowQuotes.TabIndex = 26;
            this.btnShowQuotes.Text = "Select Quote";
            this.btnShowQuotes.UseVisualStyleBackColor = true;
            this.btnShowQuotes.Click += new System.EventHandler(this.btnShowQuotes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quotation ID:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(152, 40);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 23;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(141, 190);
            this.txtPrice.MaximumSize = new System.Drawing.Size(344, 25);
            this.txtPrice.MinimumSize = new System.Drawing.Size(255, 25);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(344, 25);
            this.txtPrice.TabIndex = 22;
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyUp);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(29, 195);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(47, 21);
            this.lblItem.TabIndex = 20;
            this.lblItem.Text = "Price:";
            // 
            // lblUpdateQuote
            // 
            this.lblUpdateQuote.AutoSize = true;
            this.lblUpdateQuote.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateQuote.Location = new System.Drawing.Point(0, 0);
            this.lblUpdateQuote.Name = "lblUpdateQuote";
            this.lblUpdateQuote.Size = new System.Drawing.Size(200, 40);
            this.lblUpdateQuote.TabIndex = 0;
            this.lblUpdateQuote.Text = "Update Quote";
            // 
            // txtItemName
            // 
            this.txtItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(141, 91);
            this.txtItemName.MaximumSize = new System.Drawing.Size(344, 25);
            this.txtItemName.MinimumSize = new System.Drawing.Size(255, 25);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(344, 25);
            this.txtItemName.TabIndex = 8;
            this.txtItemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyUp);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(141, 263);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(165, 31);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(94, 31);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(165, 31);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(26, 91);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(90, 21);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(26, 125);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(26, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(51, 21);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Color:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(141, 122);
            this.txtQuantity.MaximumSize = new System.Drawing.Size(344, 25);
            this.txtQuantity.MinimumSize = new System.Drawing.Size(255, 25);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(344, 25);
            this.txtQuantity.TabIndex = 9;
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyUp);
            // 
            // txtColor
            // 
            this.txtColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(141, 156);
            this.txtColor.MaximumSize = new System.Drawing.Size(344, 25);
            this.txtColor.MinimumSize = new System.Drawing.Size(255, 25);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(344, 25);
            this.txtColor.TabIndex = 10;
            this.txtColor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemName_KeyUp);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(320, 263);
            this.btnClear.MaximumSize = new System.Drawing.Size(165, 31);
            this.btnClear.MinimumSize = new System.Drawing.Size(77, 31);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 31);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear Values";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlDownLeft
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnlDownLeft, 2);
            this.pnlDownLeft.Controls.Add(this.lblSuppliers);
            this.pnlDownLeft.Controls.Add(this.btnUpdateQuote);
            this.pnlDownLeft.Controls.Add(this.dgvrfqSupplierListInQuote);
            this.pnlDownLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDownLeft.Location = new System.Drawing.Point(3, 306);
            this.pnlDownLeft.Name = "pnlDownLeft";
            this.pnlDownLeft.Size = new System.Drawing.Size(1375, 351);
            this.pnlDownLeft.TabIndex = 21;
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.Location = new System.Drawing.Point(3, 10);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(161, 21);
            this.lblSuppliers.TabIndex = 5;
            this.lblSuppliers.Text = "Supplier in the Quote:";
            // 
            // btnUpdateQuote
            // 
            this.btnUpdateQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdateQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateQuote.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateQuote.Location = new System.Drawing.Point(1229, 319);
            this.btnUpdateQuote.Name = "btnUpdateQuote";
            this.btnUpdateQuote.Size = new System.Drawing.Size(139, 30);
            this.btnUpdateQuote.TabIndex = 14;
            this.btnUpdateQuote.Text = "Update Quote";
            this.btnUpdateQuote.UseVisualStyleBackColor = false;
            this.btnUpdateQuote.Click += new System.EventHandler(this.btnUpdateQuote_Click);
            // 
            // dgvrfqSupplierListInQuote
            // 
            this.dgvrfqSupplierListInQuote.AllowUserToAddRows = false;
            this.dgvrfqSupplierListInQuote.AllowUserToDeleteRows = false;
            this.dgvrfqSupplierListInQuote.AllowUserToResizeRows = false;
            this.dgvrfqSupplierListInQuote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrfqSupplierListInQuote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrfqSupplierListInQuote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqSupplierListInQuote.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvrfqSupplierListInQuote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrfqSupplierListInQuote.Location = new System.Drawing.Point(7, 44);
            this.dgvrfqSupplierListInQuote.Name = "dgvrfqSupplierListInQuote";
            this.dgvrfqSupplierListInQuote.ReadOnly = true;
            this.dgvrfqSupplierListInQuote.RowHeadersVisible = false;
            this.dgvrfqSupplierListInQuote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqSupplierListInQuote.Size = new System.Drawing.Size(1361, 271);
            this.dgvrfqSupplierListInQuote.TabIndex = 15;
            this.dgvrfqSupplierListInQuote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrfqSupplierListInQuote_CellClick);
            this.dgvrfqSupplierListInQuote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvrfqSupplierListInQuote_KeyUp);
            // 
            // tmrTime
            // 
            this.tmrTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UpdateQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "UpdateQuotation";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Quotations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateQuotation_FormClosing);
            this.Load += new System.EventHandler(this.UpdateQuotation_Load);
            this.pnlMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlUpRight.ResumeLayout(false);
            this.pnlUpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqItemListInQuote)).EndInit();
            this.pnlUpLeft.ResumeLayout(false);
            this.pnlUpLeft.PerformLayout();
            this.pnlDownLeft.ResumeLayout(false);
            this.pnlDownLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqSupplierListInQuote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridView dgvrfqSupplierListInQuote;
        private System.Windows.Forms.Button btnUpdateQuote;
        private System.Windows.Forms.DataGridView dgvrfqItemListInQuote;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblUpdateQuote;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Panel pnlUpLeft;
        private System.Windows.Forms.Panel pnlDownLeft;
        private System.Windows.Forms.Panel pnlUpRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnShowQuotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbItemType;

        private System.Windows.Forms.Label lblQuoteID;

    }
}