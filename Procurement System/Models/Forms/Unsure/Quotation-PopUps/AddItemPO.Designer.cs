namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    partial class AddItemPO
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSupplierItemList = new System.Windows.Forms.DataGridView();
            this.btnSelectItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the items you want to order:";
            // 
            // dgvSupplierItemList
            // 
            this.dgvSupplierItemList.AllowUserToAddRows = false;
            this.dgvSupplierItemList.AllowUserToDeleteRows = false;
            this.dgvSupplierItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSupplierItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSupplierItemList.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierItemList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplierItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierItemList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplierItemList.Location = new System.Drawing.Point(12, 110);
            this.dgvSupplierItemList.MultiSelect = false;
            this.dgvSupplierItemList.Name = "dgvSupplierItemList";
            this.dgvSupplierItemList.Size = new System.Drawing.Size(758, 284);
            this.dgvSupplierItemList.TabIndex = 1;
            // 
            // btnSelectItems
            // 
            this.btnSelectItems.Location = new System.Drawing.Point(647, 400);
            this.btnSelectItems.Name = "btnSelectItems";
            this.btnSelectItems.Size = new System.Drawing.Size(123, 34);
            this.btnSelectItems.TabIndex = 2;
            this.btnSelectItems.Text = "Select Items";
            this.btnSelectItems.UseVisualStyleBackColor = true;
            this.btnSelectItems.Click += new System.EventHandler(this.btnSelectItems_Click);
            // 
            // AddItemPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 456);
            this.Controls.Add(this.btnSelectItems);
            this.Controls.Add(this.dgvSupplierItemList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddItemPO";
            this.Text = "Add Item into Purchase Order";
            this.Load += new System.EventHandler(this.AddItemPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSupplierItemList;
        private System.Windows.Forms.Button btnSelectItems;
    }
}