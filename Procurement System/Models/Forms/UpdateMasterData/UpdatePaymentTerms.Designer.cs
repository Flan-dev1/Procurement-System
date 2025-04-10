
namespace Procurement_System.Models.Forms.UpdateMasterData
{
    partial class UpdatePaymentTerms
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
            this.pnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();

            this.cbxPaymentTermName = new System.Windows.Forms.ComboBox();

            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateNew = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtValidity = new System.Windows.Forms.TextBox();
            this.lblPaymentTermName = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblValidity = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();


            this.pnlMain.SuspendLayout();
            this.pnlTop.SuspendLayout();
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
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.63636F));
            this.pnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.363636F));
            this.pnlMain.Size = new System.Drawing.Size(1381, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.btnCreateNew);
            this.pnlTop.Controls.Add(this.cbxPaymentTermName);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.txtDueDate);
            this.pnlTop.Controls.Add(this.btnUpdate);
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Controls.Add(this.txtDiscount);
            this.pnlTop.Controls.Add(this.txtValidity);
            this.pnlTop.Controls.Add(this.lblPaymentTermName);
            this.pnlTop.Controls.Add(this.lblDiscount);
            this.pnlTop.Controls.Add(this.lblValidity);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1375, 611);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);

            // cbxPaymentTermName
            // 
            this.cbxPaymentTermName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbxPaymentTermName.FormattingEnabled = true;
            this.cbxPaymentTermName.Location = new System.Drawing.Point(174, 55);
            this.cbxPaymentTermName.Name = "cbxPaymentTermName";
            this.cbxPaymentTermName.Size = new System.Drawing.Size(344, 25);
            this.cbxPaymentTermName.TabIndex = 36;
            // 
            // label2
            // 
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(778, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 21);
            this.label5.TabIndex = 40;
            this.label5.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(778, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(778, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 38;
            this.label3.Text = "Days";
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCreateNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.Location = new System.Drawing.Point(838, 175);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(103, 29);
            this.btnCreateNew.TabIndex = 37;
            this.btnCreateNew.Text = "Create New";
            this.btnCreateNew.UseVisualStyleBackColor = false;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);

            // 
            // cbxPaymentTermName
            // 
            this.cbxPaymentTermName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentTermName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbxPaymentTermName.FormattingEnabled = true;
            this.cbxPaymentTermName.Location = new System.Drawing.Point(639, 178);
            this.cbxPaymentTermName.Name = "cbxPaymentTermName";
            this.cbxPaymentTermName.Size = new System.Drawing.Size(183, 25);
            this.cbxPaymentTermName.TabIndex = 36;
            this.cbxPaymentTermName.SelectionChangeCommitted += new System.EventHandler(this.cbxPaymentTermName_SelectionChangeCommitted);
            this.cbxPaymentTermName.SelectedValueChanged += new System.EventHandler(this.cbxPaymentTermName_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Due Date:";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(639, 302);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(139, 29);
            this.txtDueDate.TabIndex = 32;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(607, 350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 31);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(707, 350);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 31);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(639, 227);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(139, 29);
            this.txtDiscount.TabIndex = 24;
            // 
            // txtValidity
            // 
            this.txtValidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidity.Location = new System.Drawing.Point(639, 262);
            this.txtValidity.Name = "txtValidity";
            this.txtValidity.Size = new System.Drawing.Size(139, 29);
            this.txtValidity.TabIndex = 25;
            // 
            // lblPaymentTermName
            // 
            this.lblPaymentTermName.AutoSize = true;
            this.lblPaymentTermName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTermName.Location = new System.Drawing.Point(476, 178);
            this.lblPaymentTermName.Name = "lblPaymentTermName";
            this.lblPaymentTermName.Size = new System.Drawing.Size(157, 21);
            this.lblPaymentTermName.TabIndex = 20;
            this.lblPaymentTermName.Text = "Payment Term Name:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(476, 227);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(74, 21);
            this.lblDiscount.TabIndex = 21;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidity.Location = new System.Drawing.Point(476, 266);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(126, 21);
            this.lblValidity.TabIndex = 22;
            this.lblValidity.Text = "Discount Validity";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(3, 620);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1375, 37);
            this.pnlBottom.TabIndex = 0;
            // 

            // dgvrPaymentTermList
            // 
            // 
            // lblSearch
            // 
            // 
            // UpdatePaymentTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "UpdatePaymentTerms";
            this.Text = "Update Payment Terms";
            this.pnlMain.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPaymentTermName;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtValidity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.ComboBox cbxPaymentTermName;

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnCreateNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}