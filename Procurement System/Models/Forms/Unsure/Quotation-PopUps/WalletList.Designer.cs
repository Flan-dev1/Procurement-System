namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    partial class WalletList
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
            this.dgvWalletList = new System.Windows.Forms.DataGridView();
            this.btnSelectWallet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalletList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWalletList
            // 
            this.dgvWalletList.AllowUserToAddRows = false;
            this.dgvWalletList.AllowUserToDeleteRows = false;
            this.dgvWalletList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWalletList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWalletList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWalletList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWalletList.Location = new System.Drawing.Point(12, 32);
            this.dgvWalletList.MultiSelect = false;
            this.dgvWalletList.Name = "dgvWalletList";
            this.dgvWalletList.RowHeadersVisible = false;
            this.dgvWalletList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWalletList.Size = new System.Drawing.Size(453, 150);
            this.dgvWalletList.TabIndex = 0;
            this.dgvWalletList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWalletList_CellClick);
            // 
            // btnSelectWallet
            // 
            this.btnSelectWallet.Enabled = false;
            this.btnSelectWallet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectWallet.Location = new System.Drawing.Point(366, 188);
            this.btnSelectWallet.Name = "btnSelectWallet";
            this.btnSelectWallet.Size = new System.Drawing.Size(99, 37);
            this.btnSelectWallet.TabIndex = 1;
            this.btnSelectWallet.Text = "Select";
            this.btnSelectWallet.UseVisualStyleBackColor = true;
            this.btnSelectWallet.Click += new System.EventHandler(this.btnSelectWallet_Click);
            // 
            // WalletList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 237);
            this.Controls.Add(this.btnSelectWallet);
            this.Controls.Add(this.dgvWalletList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WalletList";
            this.Text = "Wallet List";
            this.Load += new System.EventHandler(this.WalletList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWalletList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWalletList;
        private System.Windows.Forms.Button btnSelectWallet;
    }
}