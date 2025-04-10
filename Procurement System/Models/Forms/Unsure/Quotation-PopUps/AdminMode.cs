using Procurement_System.Services.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class AdminMode : Form
    {
        private Action<bool> _callBack;
        private string _title;
        public AdminMode(Action<bool> callBack, string title = "Admin")
        {
            InitializeComponent();
            _callBack = callBack;
            _title = title;
        }

        private void _checkAuthorizedUserPassword()
        {
             if (AdminAccess.CheckAdminPassword(txtPassword.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
                _callBack(true);
            }else
            {
                lblMessage.Text = "Incorrect Password";
                _callBack(false);
            }
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (_title == "Admin")
            {
                _checkAuthorizedUserPassword();
            }
            else
            {
                _checkSalesStaffCode();
            }
        }

        private void _checkSalesStaffCode()
        {
            if (AdminAccess.CheckAdminPassword(txtPassword.Text.Trim()) || AdminAccess.CheckSalesStaffPassword(txtPassword.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
                _callBack(true);
            }else
            {
                lblMessage.Text = "Incorrect Password";
                _callBack(false);
            }
        }

        private void AdminMode_Load(object sender, EventArgs e)
        {

        }
    }
}
