namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    partial class DirectPOList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPOList = new System.Windows.Forms.DataGridView();
            this.dgvPODetailsList = new System.Windows.Forms.DataGridView();
            this.btnShowItems = new System.Windows.Forms.Button();
            this.btnCreateGRPO = new System.Windows.Forms.Button();
            this.txtPOSearch = new System.Windows.Forms.TextBox();
            this.txtItemSearch = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPOList
            // 
            this.dgvPOList.AllowUserToAddRows = false;
            this.dgvPOList.AllowUserToDeleteRows = false;
            this.dgvPOList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPOList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPOList.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPOList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPOList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPOList.Location = new System.Drawing.Point(12, 70);
            this.dgvPOList.MultiSelect = false;
            this.dgvPOList.Name = "dgvPOList";
            this.dgvPOList.ReadOnly = true;
            this.dgvPOList.RowHeadersVisible = false;
            this.dgvPOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPOList.Size = new System.Drawing.Size(519, 354);
            this.dgvPOList.TabIndex = 0;
            this.dgvPOList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPOList_CellClick);
            // 
            // dgvPODetailsList
            // 
            this.dgvPODetailsList.AllowUserToAddRows = false;
            this.dgvPODetailsList.AllowUserToDeleteRows = false;
            this.dgvPODetailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPODetailsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPODetailsList.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPODetailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPODetailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPODetailsList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPODetailsList.Location = new System.Drawing.Point(562, 70);
            this.dgvPODetailsList.MultiSelect = false;
            this.dgvPODetailsList.Name = "dgvPODetailsList";
            this.dgvPODetailsList.ReadOnly = true;
            this.dgvPODetailsList.RowHeadersVisible = false;
            this.dgvPODetailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPODetailsList.Size = new System.Drawing.Size(524, 354);
            this.dgvPODetailsList.TabIndex = 1;
            this.dgvPODetailsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPODetailsList_CellClick);
            // 
            // btnShowItems
            // 
            this.btnShowItems.Enabled = false;
            this.btnShowItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowItems.Location = new System.Drawing.Point(803, 437);
            this.btnShowItems.Name = "btnShowItems";
            this.btnShowItems.Size = new System.Drawing.Size(137, 38);
            this.btnShowItems.TabIndex = 2;
            this.btnShowItems.Text = "Show Items";
            this.btnShowItems.UseVisualStyleBackColor = true;
            this.btnShowItems.Click += new System.EventHandler(this.btnShowItems_Click);
            // 
            // btnCreateGRPO
            // 
            this.btnCreateGRPO.Enabled = false;
            this.btnCreateGRPO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGRPO.Location = new System.Drawing.Point(946, 437);
            this.btnCreateGRPO.Name = "btnCreateGRPO";
            this.btnCreateGRPO.Size = new System.Drawing.Size(140, 38);
            this.btnCreateGRPO.TabIndex = 3;
            this.btnCreateGRPO.Text = "Create GRPO";
            this.btnCreateGRPO.UseVisualStyleBackColor = true;
            this.btnCreateGRPO.Click += new System.EventHandler(this.btnCreateGRPO_Click);
            // 
            // txtPOSearch
            // 
            this.txtPOSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOSearch.Location = new System.Drawing.Point(371, 35);
            this.txtPOSearch.Name = "txtPOSearch";
            this.txtPOSearch.Size = new System.Drawing.Size(160, 29);
            this.txtPOSearch.TabIndex = 4;
            this.txtPOSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // txtItemSearch
            // 
            this.txtItemSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSearch.Location = new System.Drawing.Point(921, 35);
            this.txtItemSearch.Name = "txtItemSearch";
            this.txtItemSearch.Size = new System.Drawing.Size(165, 29);
            this.txtItemSearch.TabIndex = 5;
            this.txtItemSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtItemSearch_KeyUp);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(305, 38);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(60, 21);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(855, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search:";
            // 
            // DirectPOList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtItemSearch);
            this.Controls.Add(this.txtPOSearch);
            this.Controls.Add(this.btnCreateGRPO);
            this.Controls.Add(this.btnShowItems);
            this.Controls.Add(this.dgvPODetailsList);
            this.Controls.Add(this.dgvPOList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DirectPOList";
            this.Text = "Direct Purchase Orders";
            this.Load += new System.EventHandler(this.DirectPOList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPODetailsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPOList;
        private System.Windows.Forms.DataGridView dgvPODetailsList;
        private System.Windows.Forms.Button btnShowItems;
        private System.Windows.Forms.Button btnCreateGRPO;
        private System.Windows.Forms.TextBox txtPOSearch;
        private System.Windows.Forms.TextBox txtItemSearch;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
    }
}