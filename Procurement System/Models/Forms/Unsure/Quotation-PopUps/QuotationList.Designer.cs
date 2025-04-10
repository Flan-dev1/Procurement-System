namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    partial class QuotationList
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
            this.dgvrfqQuotes = new System.Windows.Forms.DataGridView();
            this.btnSelectQuote = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvrfqQuotes
            // 
            this.dgvrfqQuotes.AllowUserToAddRows = false;
            this.dgvrfqQuotes.AllowUserToDeleteRows = false;
            this.dgvrfqQuotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrfqQuotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvrfqQuotes.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvrfqQuotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvrfqQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvrfqQuotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvrfqQuotes.Location = new System.Drawing.Point(9, 49);
            this.dgvrfqQuotes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvrfqQuotes.Name = "dgvrfqQuotes";
            this.dgvrfqQuotes.RowHeadersVisible = false;
            this.dgvrfqQuotes.RowTemplate.Height = 24;
            this.dgvrfqQuotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvrfqQuotes.Size = new System.Drawing.Size(844, 204);
            this.dgvrfqQuotes.TabIndex = 0;
            this.dgvrfqQuotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrfqQuotes_CellClick);
            // 
            // btnSelectQuote
            // 
            this.btnSelectQuote.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectQuote.Location = new System.Drawing.Point(752, 258);
            this.btnSelectQuote.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectQuote.Name = "btnSelectQuote";
            this.btnSelectQuote.Size = new System.Drawing.Size(102, 34);
            this.btnSelectQuote.TabIndex = 1;
            this.btnSelectQuote.Text = "Select Quote";
            this.btnSelectQuote.UseVisualStyleBackColor = true;
            this.btnSelectQuote.Click += new System.EventHandler(this.btnSelectQuote_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(699, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 25);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search:";
            // 
            // QuotationList
            // 
            this.AcceptButton = this.btnSelectQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 301);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelectQuote);
            this.Controls.Add(this.dgvrfqQuotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuotationList";
            this.Text = "Quotation List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuotationList_FormClosing);
            this.Load += new System.EventHandler(this.QuotationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrfqQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvrfqQuotes;
        private System.Windows.Forms.Button btnSelectQuote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}