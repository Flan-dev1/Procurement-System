namespace Procurement_System
{
    partial class Login
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
            this.pnlInputLine = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEntry = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInputLine
            // 
            this.pnlInputLine.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlInputLine.Location = new System.Drawing.Point(33, 356);
            this.pnlInputLine.Name = "pnlInputLine";
            this.pnlInputLine.Size = new System.Drawing.Size(222, 3);
            this.pnlInputLine.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 74);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "PROCUREMENT\r\nSYSTEM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntry
            // 
            this.lblEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntry.Location = new System.Drawing.Point(0, 0);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(222, 30);
            this.lblEntry.TabIndex = 3;
            this.lblEntry.Text = "Enter Your Username";
            this.lblEntry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.Color.White;
            this.txtUserInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserInput.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInput.Location = new System.Drawing.Point(46, 330);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(196, 20);
            this.txtUserInput.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Silver;
            this.btnEnter.Location = new System.Drawing.Point(33, 407);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(222, 33);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Log In";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 6;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(33, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 74);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblEntry);
            this.panel2.Location = new System.Drawing.Point(33, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 30);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picLogo);
            this.panel3.Location = new System.Drawing.Point(33, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 171);
            this.panel3.TabIndex = 9;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::Procurement_System.Properties.Resources.loginLogo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(222, 171);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = global::Procurement_System.Properties.Resources._return;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReturn.Enabled = false;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(127, 446);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(32, 31);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblError);
            this.panel4.Location = new System.Drawing.Point(33, 365);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 36);
            this.panel4.TabIndex = 8;
            // 
            // Login
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 482);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.pnlInputLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurement System";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlInputLine;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel4;
    }
}

