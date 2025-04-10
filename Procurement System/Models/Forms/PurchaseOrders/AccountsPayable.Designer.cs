
namespace Procurement_System.Models.Forms.PurchaseOrders
{
    partial class AccountsPayable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopLeft = new System.Windows.Forms.Panel();
            this.btnAdminMode = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSelectSupplier = new System.Windows.Forms.Button();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.lblEnterPayment = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPODiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblSuppEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblIssuer = new System.Windows.Forms.Label();
            this.lblIssuedBy = new System.Windows.Forms.Label();
            this.lblSuppAddress = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPurchOrderInfo = new System.Windows.Forms.Label();
            this.lblPOID = new System.Windows.Forms.Label();
            this.lblPOInfoID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.lblSuppID = new System.Windows.Forms.Label();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.lblWalletName = new System.Windows.Forms.Label();
            this.txtTotalBalance = new System.Windows.Forms.Label();
            this.txtWalletName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectWallet = new System.Windows.Forms.Button();
            this.lblPaymentTerms = new System.Windows.Forms.Label();
            this.lblPTDiscount = new System.Windows.Forms.Label();
            this.lblPTDiscountNum = new System.Windows.Forms.Label();
            this.lblPTName = new System.Windows.Forms.Label();
            this.lblPTNameString = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblPTDiscountValidity = new System.Windows.Forms.Label();
            this.lblPTDueDate = new System.Windows.Forms.Label();
            this.lblValidityString = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvrPurchaseOrderList = new System.Windows.Forms.DataGridView();
            this.lblPurchaseOrderList = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlTopLeft.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrPurchaseOrderList)).BeginInit();
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
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.pnlMain.Size = new System.Drawing.Size(1461, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 2;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlTop.Controls.Add(this.pnlTopLeft, 0, 0);
            this.pnlTop.Controls.Add(this.pnlTopRight, 1, 0);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 1;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 423F));
            this.pnlTop.Size = new System.Drawing.Size(1455, 423);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlTopLeft
            // 
            this.pnlTopLeft.Controls.Add(this.btnAdminMode);
            this.pnlTopLeft.Controls.Add(this.lblMessage);
            this.pnlTopLeft.Controls.Add(this.btnSelectSupplier);
            this.pnlTopLeft.Controls.Add(this.txtPayment);
            this.pnlTopLeft.Controls.Add(this.lblEnterPayment);
            this.pnlTopLeft.Controls.Add(this.lblEmail);
            this.pnlTopLeft.Controls.Add(this.lblDiscount);
            this.pnlTopLeft.Controls.Add(this.lblPODiscount);
            this.pnlTopLeft.Controls.Add(this.lblPrice);
            this.pnlTopLeft.Controls.Add(this.lblTotalPrice);
            this.pnlTopLeft.Controls.Add(this.lblSuppEmail);
            this.pnlTopLeft.Controls.Add(this.lblAddress);
            this.pnlTopLeft.Controls.Add(this.lblIssuer);
            this.pnlTopLeft.Controls.Add(this.lblIssuedBy);
            this.pnlTopLeft.Controls.Add(this.lblSuppAddress);
            this.pnlTopLeft.Controls.Add(this.btnPay);
            this.pnlTopLeft.Controls.Add(this.lblID);
            this.pnlTopLeft.Controls.Add(this.lblPurchOrderInfo);
            this.pnlTopLeft.Controls.Add(this.lblPOID);
            this.pnlTopLeft.Controls.Add(this.lblPOInfoID);
            this.pnlTopLeft.Controls.Add(this.lblName);
            this.pnlTopLeft.Controls.Add(this.lblDate);
            this.pnlTopLeft.Controls.Add(this.lblCreatedDate);
            this.pnlTopLeft.Controls.Add(this.lblSuppID);
            this.pnlTopLeft.Controls.Add(this.lblSuppName);
            this.pnlTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopLeft.Location = new System.Drawing.Point(3, 3);
            this.pnlTopLeft.Name = "pnlTopLeft";
            this.pnlTopLeft.Size = new System.Drawing.Size(721, 417);
            this.pnlTopLeft.TabIndex = 0;
            this.pnlTopLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTopLeft_Paint);
            // 
            // btnAdminMode
            // 
            this.btnAdminMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminMode.Location = new System.Drawing.Point(558, 20);
            this.btnAdminMode.Name = "btnAdminMode";
            this.btnAdminMode.Size = new System.Drawing.Size(145, 32);
            this.btnAdminMode.TabIndex = 70;
            this.btnAdminMode.Text = "Enter Admin Mode";
            this.btnAdminMode.UseVisualStyleBackColor = true;
            this.btnAdminMode.Click += new System.EventHandler(this.btnAdminMode_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMessage.Location = new System.Drawing.Point(13, 337);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 21);
            this.lblMessage.TabIndex = 69;
            // 
            // btnSelectSupplier
            // 
            this.btnSelectSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSupplier.Location = new System.Drawing.Point(397, 20);
            this.btnSelectSupplier.Name = "btnSelectSupplier";
            this.btnSelectSupplier.Size = new System.Drawing.Size(145, 32);
            this.btnSelectSupplier.TabIndex = 68;
            this.btnSelectSupplier.Text = "Show Pending AP";
            this.btnSelectSupplier.UseVisualStyleBackColor = true;
            this.btnSelectSupplier.Click += new System.EventHandler(this.btnSelectSupplier_Click);
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(15, 361);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(345, 22);
            this.txtPayment.TabIndex = 67;
            this.txtPayment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPayment_KeyUp);
            // 
            // lblEnterPayment
            // 
            this.lblEnterPayment.AutoSize = true;
            this.lblEnterPayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEnterPayment.Location = new System.Drawing.Point(12, 308);
            this.lblEnterPayment.Name = "lblEnterPayment";
            this.lblEnterPayment.Size = new System.Drawing.Size(161, 21);
            this.lblEnterPayment.TabIndex = 64;
            this.lblEnterPayment.Text = "Please Enter Payment:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEmail.Location = new System.Drawing.Point(192, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 21);
            this.lblEmail.TabIndex = 61;
            this.lblEmail.Text = "Supplier Email";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiscount.Location = new System.Drawing.Point(192, 277);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(46, 21);
            this.lblDiscount.TabIndex = 60;
            this.lblDiscount.Text = "####";
            // 
            // lblPODiscount
            // 
            this.lblPODiscount.AutoSize = true;
            this.lblPODiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPODiscount.Location = new System.Drawing.Point(12, 277);
            this.lblPODiscount.Name = "lblPODiscount";
            this.lblPODiscount.Size = new System.Drawing.Size(74, 21);
            this.lblPODiscount.TabIndex = 60;
            this.lblPODiscount.Text = "Discount:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPrice.Location = new System.Drawing.Point(193, 247);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 21);
            this.lblPrice.TabIndex = 60;
            this.lblPrice.Text = "####";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 247);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 21);
            this.lblTotalPrice.TabIndex = 60;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblSuppEmail
            // 
            this.lblSuppEmail.AutoSize = true;
            this.lblSuppEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuppEmail.Location = new System.Drawing.Point(11, 111);
            this.lblSuppEmail.Name = "lblSuppEmail";
            this.lblSuppEmail.Size = new System.Drawing.Size(51, 21);
            this.lblSuppEmail.TabIndex = 60;
            this.lblSuppEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblAddress.Location = new System.Drawing.Point(192, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(128, 21);
            this.lblAddress.TabIndex = 58;
            this.lblAddress.Text = "Supplier Address";
            // 
            // lblIssuer
            // 
            this.lblIssuer.AutoSize = true;
            this.lblIssuer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIssuer.Location = new System.Drawing.Point(193, 217);
            this.lblIssuer.Name = "lblIssuer";
            this.lblIssuer.Size = new System.Drawing.Size(97, 21);
            this.lblIssuer.TabIndex = 57;
            this.lblIssuer.Text = "Issuer Name";
            // 
            // lblIssuedBy
            // 
            this.lblIssuedBy.AutoSize = true;
            this.lblIssuedBy.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblIssuedBy.Location = new System.Drawing.Point(12, 217);
            this.lblIssuedBy.Name = "lblIssuedBy";
            this.lblIssuedBy.Size = new System.Drawing.Size(78, 21);
            this.lblIssuedBy.TabIndex = 57;
            this.lblIssuedBy.Text = "Issued By:";
            // 
            // lblSuppAddress
            // 
            this.lblSuppAddress.AutoSize = true;
            this.lblSuppAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuppAddress.Location = new System.Drawing.Point(11, 81);
            this.lblSuppAddress.Name = "lblSuppAddress";
            this.lblSuppAddress.Size = new System.Drawing.Size(69, 21);
            this.lblSuppAddress.TabIndex = 57;
            this.lblSuppAddress.Text = "Address:";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(15, 386);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(86, 28);
            this.btnPay.TabIndex = 56;
            this.btnPay.Text = "Pay PO";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblID.Location = new System.Drawing.Point(192, 24);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(55, 21);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "#1111";
            // 
            // lblPurchOrderInfo
            // 
            this.lblPurchOrderInfo.AutoSize = true;
            this.lblPurchOrderInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPurchOrderInfo.Location = new System.Drawing.Point(13, 137);
            this.lblPurchOrderInfo.Name = "lblPurchOrderInfo";
            this.lblPurchOrderInfo.Size = new System.Drawing.Size(152, 21);
            this.lblPurchOrderInfo.TabIndex = 46;
            this.lblPurchOrderInfo.Text = "Purchase Order Info:";
            // 
            // lblPOID
            // 
            this.lblPOID.AutoSize = true;
            this.lblPOID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPOID.Location = new System.Drawing.Point(193, 160);
            this.lblPOID.Name = "lblPOID";
            this.lblPOID.Size = new System.Drawing.Size(55, 21);
            this.lblPOID.TabIndex = 46;
            this.lblPOID.Text = "#1111";
            // 
            // lblPOInfoID
            // 
            this.lblPOInfoID.AutoSize = true;
            this.lblPOInfoID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPOInfoID.Location = new System.Drawing.Point(12, 160);
            this.lblPOInfoID.Name = "lblPOInfoID";
            this.lblPOInfoID.Size = new System.Drawing.Size(53, 21);
            this.lblPOInfoID.TabIndex = 46;
            this.lblPOInfoID.Text = "PO ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblName.Location = new System.Drawing.Point(192, 51);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 21);
            this.lblName.TabIndex = 47;
            this.lblName.Text = "Supplier Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDate.Location = new System.Drawing.Point(193, 187);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 21);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "##/##/####";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblCreatedDate.Location = new System.Drawing.Point(13, 187);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(103, 21);
            this.lblCreatedDate.TabIndex = 46;
            this.lblCreatedDate.Text = "Created Date:";
            // 
            // lblSuppID
            // 
            this.lblSuppID.AutoSize = true;
            this.lblSuppID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuppID.Location = new System.Drawing.Point(11, 24);
            this.lblSuppID.Name = "lblSuppID";
            this.lblSuppID.Size = new System.Drawing.Size(90, 21);
            this.lblSuppID.TabIndex = 46;
            this.lblSuppID.Text = "Supplier ID:";
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSuppName.Location = new System.Drawing.Point(12, 51);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(117, 21);
            this.lblSuppName.TabIndex = 46;
            this.lblSuppName.Text = "Supplier Name:";
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.lblTotalBalance);
            this.pnlTopRight.Controls.Add(this.lblWalletName);
            this.pnlTopRight.Controls.Add(this.txtTotalBalance);
            this.pnlTopRight.Controls.Add(this.txtWalletName);
            this.pnlTopRight.Controls.Add(this.label3);
            this.pnlTopRight.Controls.Add(this.label2);
            this.pnlTopRight.Controls.Add(this.label1);
            this.pnlTopRight.Controls.Add(this.btnSelectWallet);
            this.pnlTopRight.Controls.Add(this.lblPaymentTerms);
            this.pnlTopRight.Controls.Add(this.lblPTDiscount);
            this.pnlTopRight.Controls.Add(this.lblPTDiscountNum);
            this.pnlTopRight.Controls.Add(this.lblPTName);
            this.pnlTopRight.Controls.Add(this.lblPTNameString);
            this.pnlTopRight.Controls.Add(this.lblDueDate);
            this.pnlTopRight.Controls.Add(this.lblPTDiscountValidity);
            this.pnlTopRight.Controls.Add(this.lblPTDueDate);
            this.pnlTopRight.Controls.Add(this.lblValidityString);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopRight.Location = new System.Drawing.Point(730, 3);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(722, 417);
            this.pnlTopRight.TabIndex = 1;
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.AutoSize = true;
            this.lblTotalBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblTotalBalance.Location = new System.Drawing.Point(523, 118);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(0, 21);
            this.lblTotalBalance.TabIndex = 77;
            // 
            // lblWalletName
            // 
            this.lblWalletName.AutoSize = true;
            this.lblWalletName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWalletName.Location = new System.Drawing.Point(523, 88);
            this.lblWalletName.Name = "lblWalletName";
            this.lblWalletName.Size = new System.Drawing.Size(0, 21);
            this.lblWalletName.TabIndex = 76;
            // 
            // txtTotalBalance
            // 
            this.txtTotalBalance.AutoSize = true;
            this.txtTotalBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTotalBalance.Location = new System.Drawing.Point(517, 118);
            this.txtTotalBalance.Name = "txtTotalBalance";
            this.txtTotalBalance.Size = new System.Drawing.Size(0, 21);
            this.txtTotalBalance.TabIndex = 75;
            // 
            // txtWalletName
            // 
            this.txtWalletName.AutoSize = true;
            this.txtWalletName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtWalletName.Location = new System.Drawing.Point(517, 88);
            this.txtWalletName.Name = "txtWalletName";
            this.txtWalletName.Size = new System.Drawing.Size(0, 21);
            this.txtWalletName.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(398, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Total Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(398, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 72;
            this.label2.Text = "Wallet Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(398, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Selected Wallet:";
            // 
            // btnSelectWallet
            // 
            this.btnSelectWallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectWallet.Location = new System.Drawing.Point(561, 20);
            this.btnSelectWallet.Name = "btnSelectWallet";
            this.btnSelectWallet.Size = new System.Drawing.Size(145, 32);
            this.btnSelectWallet.TabIndex = 70;
            this.btnSelectWallet.Text = "Choose Wallet";
            this.btnSelectWallet.UseVisualStyleBackColor = true;
            this.btnSelectWallet.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPaymentTerms
            // 
            this.lblPaymentTerms.AutoSize = true;
            this.lblPaymentTerms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPaymentTerms.Location = new System.Drawing.Point(27, 24);
            this.lblPaymentTerms.Name = "lblPaymentTerms";
            this.lblPaymentTerms.Size = new System.Drawing.Size(118, 21);
            this.lblPaymentTerms.TabIndex = 46;
            this.lblPaymentTerms.Text = "Payment Terms:";
            // 
            // lblPTDiscount
            // 
            this.lblPTDiscount.AutoSize = true;
            this.lblPTDiscount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPTDiscount.Location = new System.Drawing.Point(27, 88);
            this.lblPTDiscount.Name = "lblPTDiscount";
            this.lblPTDiscount.Size = new System.Drawing.Size(74, 21);
            this.lblPTDiscount.TabIndex = 46;
            this.lblPTDiscount.Text = "Discount:";
            // 
            // lblPTDiscountNum
            // 
            this.lblPTDiscountNum.AutoSize = true;
            this.lblPTDiscountNum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPTDiscountNum.Location = new System.Drawing.Point(235, 88);
            this.lblPTDiscountNum.Name = "lblPTDiscountNum";
            this.lblPTDiscountNum.Size = new System.Drawing.Size(71, 21);
            this.lblPTDiscountNum.TabIndex = 46;
            this.lblPTDiscountNum.Text = "Discount";
            // 
            // lblPTName
            // 
            this.lblPTName.AutoSize = true;
            this.lblPTName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPTName.Location = new System.Drawing.Point(26, 61);
            this.lblPTName.Name = "lblPTName";
            this.lblPTName.Size = new System.Drawing.Size(164, 21);
            this.lblPTName.TabIndex = 46;
            this.lblPTName.Text = "Payment Terms Name:";
            // 
            // lblPTNameString
            // 
            this.lblPTNameString.AutoSize = true;
            this.lblPTNameString.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPTNameString.Location = new System.Drawing.Point(235, 61);
            this.lblPTNameString.Name = "lblPTNameString";
            this.lblPTNameString.Size = new System.Drawing.Size(116, 21);
            this.lblPTNameString.TabIndex = 46;
            this.lblPTNameString.Text = "Payment Name";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDueDate.Location = new System.Drawing.Point(235, 148);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(94, 21);
            this.lblDueDate.TabIndex = 60;
            this.lblDueDate.Text = "##/##/####";
            // 
            // lblPTDiscountValidity
            // 
            this.lblPTDiscountValidity.AutoSize = true;
            this.lblPTDiscountValidity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPTDiscountValidity.Location = new System.Drawing.Point(26, 118);
            this.lblPTDiscountValidity.Name = "lblPTDiscountValidity";
            this.lblPTDiscountValidity.Size = new System.Drawing.Size(129, 21);
            this.lblPTDiscountValidity.TabIndex = 57;
            this.lblPTDiscountValidity.Text = "Discount Validity:";
            // 
            // lblPTDueDate
            // 
            this.lblPTDueDate.AutoSize = true;
            this.lblPTDueDate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblPTDueDate.Location = new System.Drawing.Point(26, 148);
            this.lblPTDueDate.Name = "lblPTDueDate";
            this.lblPTDueDate.Size = new System.Drawing.Size(77, 21);
            this.lblPTDueDate.TabIndex = 60;
            this.lblPTDueDate.Text = "Due Date:";
            // 
            // lblValidityString
            // 
            this.lblValidityString.AutoSize = true;
            this.lblValidityString.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblValidityString.Location = new System.Drawing.Point(235, 118);
            this.lblValidityString.Name = "lblValidityString";
            this.lblValidityString.Size = new System.Drawing.Size(61, 21);
            this.lblValidityString.TabIndex = 57;
            this.lblValidityString.Text = "Validity";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblSearch);
            this.pnlBottom.Controls.Add(this.txtSearch);
            this.pnlBottom.Controls.Add(this.dgvrPurchaseOrderList);
            this.pnlBottom.Controls.Add(this.lblPurchaseOrderList);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(3, 432);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1455, 225);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.Location = new System.Drawing.Point(1133, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 21);
            this.lblSearch.TabIndex = 41;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1211, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 22);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // dgvrPurchaseOrderList
            // 
            this.dgvrPurchaseOrderList.AllowUserToAddRows = false;
            this.dgvrPurchaseOrderList.AllowUserToDeleteRows = false;
            this.dgvrPurchaseOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvrPurchaseOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrPurchaseOrderList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrPurchaseOrderList.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrPurchaseOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrPurchaseOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrPurchaseOrderList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrPurchaseOrderList.Location = new System.Drawing.Point(19, 37);
            this.dgvrPurchaseOrderList.MultiSelect = false;
            this.dgvrPurchaseOrderList.Name = "dgvrPurchaseOrderList";
            this.dgvrPurchaseOrderList.RowHeadersVisible = false;
            this.dgvrPurchaseOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrPurchaseOrderList.Size = new System.Drawing.Size(1417, 179);
            this.dgvrPurchaseOrderList.TabIndex = 14;
            this.dgvrPurchaseOrderList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrPurchaseOrderList_CellClick);
            // 
            // lblPurchaseOrderList
            // 
            this.lblPurchaseOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPurchaseOrderList.AutoSize = true;
            this.lblPurchaseOrderList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseOrderList.Location = new System.Drawing.Point(14, 13);
            this.lblPurchaseOrderList.Name = "lblPurchaseOrderList";
            this.lblPurchaseOrderList.Size = new System.Drawing.Size(128, 21);
            this.lblPurchaseOrderList.TabIndex = 12;
            this.lblPurchaseOrderList.Text = "Purchase Orders:";
            // 
            // AccountsPayable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "AccountsPayable";
            this.Text = "Accounts Payable";
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTopLeft.ResumeLayout(false);
            this.pnlTopLeft.PerformLayout();
            this.pnlTopRight.ResumeLayout(false);
            this.pnlTopRight.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrPurchaseOrderList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Panel pnlTopLeft;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSuppEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSuppAddress;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label lblEnterPayment;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSuppID;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblIssuedBy;
        private System.Windows.Forms.Label lblPurchOrderInfo;
        private System.Windows.Forms.Label lblPOInfoID;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label lblPODiscount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblIssuer;
        private System.Windows.Forms.Label lblPOID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPaymentTerms;
        private System.Windows.Forms.Label lblPTDiscount;
        private System.Windows.Forms.Label lblPTDiscountNum;
        private System.Windows.Forms.Label lblPTName;
        private System.Windows.Forms.Label lblPTNameString;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblPTDiscountValidity;
        private System.Windows.Forms.Label lblPTDueDate;
        private System.Windows.Forms.Label lblValidityString;
        private System.Windows.Forms.Label lblPurchaseOrderList;
        private System.Windows.Forms.DataGridView dgvrPurchaseOrderList;
        private System.Windows.Forms.Button btnSelectSupplier;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label txtTotalBalance;
        private System.Windows.Forms.Label txtWalletName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectWallet;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.Label lblWalletName;
        private System.Windows.Forms.Button btnAdminMode;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}