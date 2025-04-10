
namespace Procurement_System.Models.Forms.PurchaseOrders
{
    partial class CreatePO
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.txtColor = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDirectPO = new System.Windows.Forms.CheckBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.lblQuoteID = new System.Windows.Forms.Label();
            this.lblSelQuote = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblActualValidity = new System.Windows.Forms.Label();
            this.ActualEmail = new System.Windows.Forms.Label();
            this.lblActualDiscount = new System.Windows.Forms.Label();
            this.lblActualAddress = new System.Windows.Forms.Label();
            this.lblValidity = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblActualPaymentName = new System.Windows.Forms.Label();
            this.lblActualSuppName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPaymentName = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lblSelectedSupplier = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGeneratePO = new System.Windows.Forms.Button();
            this.dgvrItemList = new System.Windows.Forms.DataGridView();
            this.lblItemList = new System.Windows.Forms.Label();
            this.cachedQuotationTemplate1 = new Procurement_System.Services.DocumentGenerator.CachedQuotationTemplate();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.ColumnCount = 1;
            this.pnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMain.Controls.Add(this.pnlTop, 0, 0);
            this.pnlMain.Controls.Add(this.pnlBottom, 0, 1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.RowCount = 2;
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlMain.Size = new System.Drawing.Size(1381, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 2;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.pnlTop.Controls.Add(this.pnlTopLeft, 0, 0);
            this.pnlTop.Controls.Add(this.pnlTopRight, 1, 0);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 1;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.Size = new System.Drawing.Size(1375, 324);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.txtColor);
            this.pnlTopLeft.Controls.Add(this.lblUnitPrice);
            this.pnlTopLeft.Controls.Add(this.label4);
            this.pnlTopLeft.Controls.Add(this.cbDirectPO);
            this.pnlTopLeft.Controls.Add(this.lblItemID);
            this.pnlTopLeft.Controls.Add(this.label3);
            this.pnlTopLeft.Controls.Add(this.lblItemName);
            this.pnlTopLeft.Controls.Add(this.label1);
            this.pnlTopLeft.Controls.Add(this.txtQuantity);
            this.pnlTopLeft.Controls.Add(this.btnView);
            this.pnlTopLeft.Controls.Add(this.btnDelete);
            this.pnlTopLeft.Controls.Add(this.btnUpdate);
            this.pnlTopLeft.Controls.Add(this.lblColor);
            this.pnlTopLeft.Controls.Add(this.lblQuantity);
            this.pnlTopLeft.Controls.Add(this.lblEdit);
            this.pnlTopLeft.Controls.Add(this.lblQuoteID);
            this.pnlTopLeft.Controls.Add(this.lblSelQuote);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(544, 318);
            this.pnlTopLeft.TabIndex = 0;
            // 
            // txtColor
            // 
            this.txtColor.AutoSize = true;
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtColor.Location = new System.Drawing.Point(133, 207);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(0, 21);
            this.txtColor.TabIndex = 58;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblUnitPrice.Location = new System.Drawing.Point(133, 240);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 21);
            this.lblUnitPrice.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(21, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Unit Price:";
            // 
            // cbDirectPO
            // 
            this.cbDirectPO.AutoSize = true;
            this.cbDirectPO.Location = new System.Drawing.Point(25, 35);
            this.cbDirectPO.Name = "cbDirectPO";
            this.cbDirectPO.Size = new System.Drawing.Size(165, 17);
            this.cbDirectPO.TabIndex = 55;
            this.cbDirectPO.Text = "Create Direct Purchase Order";
            this.cbDirectPO.UseVisualStyleBackColor = true;
            this.cbDirectPO.CheckedChanged += new System.EventHandler(this.cbDirectPO_CheckedChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemID.Location = new System.Drawing.Point(133, 117);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(0, 21);
            this.lblItemID.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(21, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Item Name:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemName.Location = new System.Drawing.Point(133, 149);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(0, 21);
            this.lblItemName.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(21, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Item ID:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(137, 176);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(307, 23);
            this.txtQuantity.TabIndex = 50;
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(321, 55);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(123, 32);
            this.btnView.TabIndex = 49;
            this.btnView.Text = "View Quotations";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(308, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.TabIndex = 48;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(137, 276);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 32);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblColor.Location = new System.Drawing.Point(21, 206);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(51, 21);
            this.lblColor.TabIndex = 45;
            this.lblColor.Text = "Color:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQuantity.Location = new System.Drawing.Point(21, 176);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(73, 21);
            this.lblQuantity.TabIndex = 46;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEdit.Location = new System.Drawing.Point(21, 86);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(74, 21);
            this.lblEdit.TabIndex = 47;
            this.lblEdit.Text = "Edit Item:";
            // 
            // lblQuoteID
            // 
            this.lblQuoteID.AutoSize = true;
            this.lblQuoteID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblQuoteID.Location = new System.Drawing.Point(205, 55);
            this.lblQuoteID.Name = "lblQuoteID";
            this.lblQuoteID.Size = new System.Drawing.Size(0, 21);
            this.lblQuoteID.TabIndex = 39;
            // 
            // lblSelQuote
            // 
            this.lblSelQuote.AutoSize = true;
            this.lblSelQuote.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSelQuote.Location = new System.Drawing.Point(21, 55);
            this.lblSelQuote.Name = "lblSelQuote";
            this.lblSelQuote.Size = new System.Drawing.Size(102, 21);
            this.lblSelQuote.TabIndex = 40;
            this.lblSelQuote.Text = "Quotation ID:";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.label6);
            this.pnlTopRight.Controls.Add(this.lblCurrentTime);
            this.pnlTopRight.Controls.Add(this.lblTime);
            this.pnlTopRight.Controls.Add(this.label2);
            this.pnlTopRight.Controls.Add(this.txtRemarks);
            this.pnlTopRight.Controls.Add(this.lblActualValidity);
            this.pnlTopRight.Controls.Add(this.ActualEmail);
            this.pnlTopRight.Controls.Add(this.lblActualDiscount);
            this.pnlTopRight.Controls.Add(this.lblActualAddress);
            this.pnlTopRight.Controls.Add(this.lblValidity);
            this.pnlTopRight.Controls.Add(this.lblEmail);
            this.pnlTopRight.Controls.Add(this.lblActualPaymentName);
            this.pnlTopRight.Controls.Add(this.lblActualSuppName);
            this.pnlTopRight.Controls.Add(this.lblDiscount);
            this.pnlTopRight.Controls.Add(this.lblAddress);
            this.pnlTopRight.Controls.Add(this.lblPaymentName);
            this.pnlTopRight.Controls.Add(this.lblSuppName);
            this.pnlTopRight.Controls.Add(this.lblPaymentTerms);
            this.pnlTopRight.Controls.Add(this.lblSelectedSupplier);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopRight.Location = new System.Drawing.Point(553, 3);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(819, 318);
            this.pnlTopRight.TabIndex = 1;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(722, 1);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 21);
            this.lblCurrentTime.TabIndex = 47;
            this.lblCurrentTime.Text = "##:## ##";
            this.lblCurrentTime.Click += new System.EventHandler(this.lblCurrentTime_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(669, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(47, 21);
            this.lblTime.TabIndex = 46;
            this.lblTime.Text = "TIME:";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 45;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(19, 67);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(404, 225);
            this.txtRemarks.TabIndex = 44;
            // 
            // lblActualValidity
            // 
            this.lblActualValidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualValidity.AutoSize = true;
            this.lblActualValidity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualValidity.Location = new System.Drawing.Point(587, 271);
            this.lblActualValidity.Name = "lblActualValidity";
            this.lblActualValidity.Size = new System.Drawing.Size(49, 17);
            this.lblActualValidity.TabIndex = 37;
            this.lblActualValidity.Text = "Validity";
            // 
            // ActualEmail
            // 
            this.ActualEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualEmail.Location = new System.Drawing.Point(587, 136);
            this.ActualEmail.Name = "ActualEmail";
            this.ActualEmail.Size = new System.Drawing.Size(226, 45);
            this.ActualEmail.TabIndex = 37;
            this.ActualEmail.Text = "Supplier Email";
            // 
            // lblActualDiscount
            // 
            this.lblActualDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualDiscount.AutoSize = true;
            this.lblActualDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualDiscount.Location = new System.Drawing.Point(587, 240);
            this.lblActualDiscount.Name = "lblActualDiscount";
            this.lblActualDiscount.Size = new System.Drawing.Size(25, 17);
            this.lblActualDiscount.TabIndex = 38;
            this.lblActualDiscount.Text = "0.0";
            // 
            // lblActualAddress
            // 
            this.lblActualAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualAddress.Location = new System.Drawing.Point(587, 105);
            this.lblActualAddress.Name = "lblActualAddress";
            this.lblActualAddress.Size = new System.Drawing.Size(226, 19);
            this.lblActualAddress.TabIndex = 38;
            this.lblActualAddress.Text = "Supplier Address";
            // 
            // lblValidity
            // 
            this.lblValidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValidity.AutoSize = true;
            this.lblValidity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidity.Location = new System.Drawing.Point(463, 271);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(52, 17);
            this.lblValidity.TabIndex = 39;
            this.lblValidity.Text = "Validity:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(461, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email:";
            // 
            // lblActualPaymentName
            // 
            this.lblActualPaymentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActualPaymentName.AutoSize = true;
            this.lblActualPaymentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualPaymentName.Location = new System.Drawing.Point(587, 210);
            this.lblActualPaymentName.Name = "lblActualPaymentName";
            this.lblActualPaymentName.Size = new System.Drawing.Size(96, 17);
            this.lblActualPaymentName.TabIndex = 40;
            this.lblActualPaymentName.Text = "Payment Name";
            // 
            // lblActualSuppName
            // 
            this.lblActualSuppName.AutoSize = true;
            this.lblActualSuppName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualSuppName.Location = new System.Drawing.Point(587, 75);
            this.lblActualSuppName.Name = "lblActualSuppName";
            this.lblActualSuppName.Size = new System.Drawing.Size(95, 17);
            this.lblActualSuppName.TabIndex = 40;
            this.lblActualSuppName.Text = "Supplier Name";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(463, 240);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(61, 17);
            this.lblDiscount.TabIndex = 41;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(461, 107);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 17);
            this.lblAddress.TabIndex = 41;
            this.lblAddress.Text = "Address:";
            // 
            // lblPaymentName
            // 
            this.lblPaymentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentName.AutoSize = true;
            this.lblPaymentName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentName.Location = new System.Drawing.Point(463, 210);
            this.lblPaymentName.Name = "lblPaymentName";
            this.lblPaymentName.Size = new System.Drawing.Size(99, 17);
            this.lblPaymentName.TabIndex = 42;
            this.lblPaymentName.Text = "Payment Terms:";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppName.Location = new System.Drawing.Point(461, 77);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(98, 17);
            this.lblSuppName.TabIndex = 42;
            this.lblSuppName.Text = "Supplier Name:";
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTerms.Location = new System.Drawing.Point(445, 190);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(99, 17);
            this.lblPaymentTerms.TabIndex = 43;
            this.lblPaymentTerms.Text = "Payment Terms:";
            // 
            // lblSelectedSupplier
            // 
            this.lblSelectedSupplier.AutoSize = true;
            this.lblSelectedSupplier.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedSupplier.Location = new System.Drawing.Point(445, 38);
            this.lblSelectedSupplier.Name = "lblSelectedSupplier";
            this.lblSelectedSupplier.Size = new System.Drawing.Size(112, 17);
            this.lblSelectedSupplier.TabIndex = 43;
            this.lblSelectedSupplier.Text = "Selected Supplier:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.label5);
            this.pnlBottom.Controls.Add(this.txtSearchItem);
            this.pnlBottom.Controls.Add(this.lblMessage);
            this.pnlBottom.Controls.Add(this.btnGeneratePO);
            this.pnlBottom.Controls.Add(this.dgvrItemList);
            this.pnlBottom.Controls.Add(this.lblItemList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBottom.Location = new System.Drawing.Point(3, 333);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1375, 324);
            this.pnlBottom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(1063, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Search:";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItem.Location = new System.Drawing.Point(1141, 10);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(225, 22);
            this.txtSearchItem.TabIndex = 42;
            this.txtSearchItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyUp);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(9, 289);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(422, 29);
            this.lblMessage.TabIndex = 39;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGeneratePO
            // 
            this.btnGeneratePO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeneratePO.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeneratePO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePO.Enabled = false;
            this.btnGeneratePO.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePO.Location = new System.Drawing.Point(1172, 285);
            this.btnGeneratePO.Name = "btnGeneratePO";
            this.btnGeneratePO.Size = new System.Drawing.Size(194, 30);
            this.btnGeneratePO.TabIndex = 38;
            this.btnGeneratePO.Text = "Generate Purchase Order";
            this.btnGeneratePO.UseVisualStyleBackColor = false;
            this.btnGeneratePO.Click += new System.EventHandler(this.btnGeneratePO_Click);
            // 
            // dgvrItemList
            // 
            this.dgvrItemList.AllowUserToAddRows = false;
            this.dgvrItemList.AllowUserToDeleteRows = false;
            this.dgvrItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrItemList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvrItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrItemList.Location = new System.Drawing.Point(15, 38);
            this.dgvrItemList.Name = "dgvrItemList";
            this.dgvrItemList.ReadOnly = true;
            this.dgvrItemList.RowHeadersVisible = false;
            this.dgvrItemList.RowHeadersWidth = 51;
            this.dgvrItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrItemList.Size = new System.Drawing.Size(1351, 241);
            this.dgvrItemList.TabIndex = 36;
            this.dgvrItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrItemList_CellClick);
            this.dgvrItemList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvrItemList_DataError);
            // 
            // lblItemList
            // 
            this.lblItemList.AutoSize = true;
            this.lblItemList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblItemList.Location = new System.Drawing.Point(9, 5);
            this.lblItemList.Name = "lblItemList";
            this.lblItemList.Size = new System.Drawing.Size(72, 21);
            this.lblItemList.TabIndex = 37;
            this.lblItemList.Text = "Item List:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Remarks:";
            // 
            // CreatePO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "CreatePO";
            this.Text = "Create Purchase Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateQuotePO_FormClosing);
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvrItemList;
        private System.Windows.Forms.Label lblItemList;
        private System.Windows.Forms.Button btnGeneratePO;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblQuoteID;
        private System.Windows.Forms.Label lblSelQuote;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblActualValidity;
        private System.Windows.Forms.Label ActualEmail;
        private System.Windows.Forms.Label lblActualDiscount;
        private System.Windows.Forms.Label lblActualAddress;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblActualPaymentName;
        private System.Windows.Forms.Label lblActualSuppName;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPaymentName;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.Label lblPaymentTerms;
        private System.Windows.Forms.Label lblSelectedSupplier;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblMessage;
        private Services.DocumentGenerator.CachedQuotationTemplate cachedQuotationTemplate1;
        private System.Windows.Forms.CheckBox cbDirectPO;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchItem;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
    }
}