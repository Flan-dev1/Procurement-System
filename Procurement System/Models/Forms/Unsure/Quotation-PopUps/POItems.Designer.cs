namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    partial class POItems
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
            this.dgvPOItemList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPOItemList
            // 
            this.dgvPOItemList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPOItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOItemList.Location = new System.Drawing.Point(12, 127);
            this.dgvPOItemList.Name = "dgvPOItemList";
            this.dgvPOItemList.Size = new System.Drawing.Size(929, 323);
            this.dgvPOItemList.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(818, 456);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // POItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 512);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvPOItemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "POItems";
            this.Text = "Purchase Order items";
            this.Load += new System.EventHandler(this.POItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPOItemList;
        private System.Windows.Forms.Button btnClose;
    }
}