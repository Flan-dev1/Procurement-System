using Procurement_System.Models;
using Procurement_System.Models.Users;
using System;
using System.Windows.Forms;

namespace Procurement_System
{
    public partial class Login : Form
    {
        Services.Authentication.Login session;
        bool userFound;

        public Login()
        {
            InitializeComponent();
            session = new Services.Authentication.Login();
            userFound = false;
        }

        private void callback(string callback, bool canLogin)
        {
            lblError.Text = callback;
            btnEnter.Enabled = canLogin;
        }
        private void _userNameCallBack(string message)
        {
            lblError.Text = message;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!userFound)
            {
                String input = txtUserInput.Text;
                if (input == string.Empty)
                {
                    lblError.Text = "Please enter a username";
                    return;
                }
                if (session.CheckUserName(input, _userNameCallBack))
                {
                    changeUI();
                    userFound = true;
                }
            }
            else
            {
                String input = txtUserInput.Text;
                if (input == string.Empty)
                {
                    lblError.Text = "Please enter password";
                    return;
                }
                if (session.CheckPassword(input, callback))
                {
                    openForm(_checkEmployeeLoginType(session.GetEmployee()));
                }
            }
        }

        private void changeUI()
        {
            lblTitle.Text = "Welcome\n" + session.GetEmployee().FirstName;
            lblError.Text = "";
            lblEntry.Text = "Enter Your Password";
            btnEnter.Text = "Proceed";
            picLogo.Image = Properties.Resources.userBlack;
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            txtUserInput.Text = "";
            txtUserInput.PasswordChar = '*';
            txtUserInput.UseSystemPasswordChar = true;
            btnReturn.Enabled = true;
            btnReturn.Visible = true;
        }

        private void openForm(ICreateSession formSession)
        {
            //Open form of employee type
            Hide();
            formSession.StartSession().ShowDialog();//Showdialog halts the next execution of statements below until the form is closed
            _resetSession(); //This is used to reset the data after the session dialog closes.
            Show();

        }

        private void _resetSession()
        {

            lblTitle.Text = "PROCUREMENT\nSYSTEM";
            lblError.Text = "";
            lblEntry.Text = "Enter Your Username";
            btnEnter.Text = "Log In";
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.Image = Properties.Resources.loginLogo;
            txtUserInput.Text = "";
            txtUserInput.PasswordChar = '\0';
            txtUserInput.UseSystemPasswordChar = false;
            userFound = false;
            btnEnter.Enabled = true;
            btnReturn.Enabled = false;
            btnReturn.Visible = false;

        }

        private ICreateSession _checkEmployeeLoginType(EmployeeModel model)
        {
            ICreateSession session = null;

            switch (model.getEmployeeType().getType())
            {
                case "Admin Manager":
                    session = new AdminManager(model);
                    break;
                case "Sales Staff":
                    session = new SalesStaff(model);
                    break;
                case "Book Keeper":
                    session = new BookKeeper(model);
                    break;
            }
            return session;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            _resetSession();
        }
    }

}
