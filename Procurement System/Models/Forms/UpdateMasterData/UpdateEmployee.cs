using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using Procurement_System.Services.Authentication;
using Procurement_System.Services.ItemAssets;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.UpdateMasterData
{
    public partial class UpdateEmployee : Form
    {

        private BackgroundWorker _worker;
        private EmployeeModel _employee, _selectedEmployee, _model;
        private string _query;
        private Helper _dbHelper;
        private DataTable _tableData;
        private bool _updateMode = false;
        public UpdateEmployee(EmployeeModel employee)
        {
            InitializeComponent();
            _initializeWorkers();
            _model = employee;
            _dbHelper = new Helper();
            _loadComboBox();
            _worker.RunWorkerAsync();
        }

        private void _loadComboBox()
        {

            var list = new ViewEmployeeTypes().retrieveData<EmployeeType>();
            cmbType.DataSource = list;
            cmbType.DisplayMember = "Type";
            cmbType.ValueMember = "ID";
            cmbType.SelectedIndex = -1;
        }

        private bool _checkInput()
        {
            {
                //check all textboxes for empty values
                var firstName = txtFirstName.Text.Trim();
                var middleName = txtMiddleName.Text.Trim();
                var lastName = txtLastname.Text.Trim();
                string gender = "";
                if (rdbMale.Checked)
                {
                    gender = "Male";
                }
                else if (rdbFemale.Checked)
                {
                    gender = "Female";
                }
                var employeeType = cmbType.SelectedValue;
                var username = txtUserName.Text.Trim();
                var password = txtPassword.Text.Trim();

                if (firstName == string.Empty || middleName == string.Empty || lastName == string.Empty || employeeType == null
                    || username == string.Empty || password == string.Empty)
                {
                    MessageBox.Show("Please fill up all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (username.Contains(" "))

                {
                    MessageBox.Show("Username cannot contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (password.Contains(" "))
                {
                    MessageBox.Show("Password cannot contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                else if (gender == string.Empty)
                {
                    MessageBox.Show("Please select gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (!rbnEnabled.Checked && !rbnDisabled.Checked)
                {
                    MessageBox.Show("Please select status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //find if there already existing username in the database
                var isExist = new ViewEmployeesInfo().retrieveData<EmployeeModel>().Find(e => e.AccountCredential.UserName.ToLower() == username.ToLower());
                if (isExist != null && !_updateMode)
                {
                    MessageBox.Show("Username already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;

            }
        }
        private void _initializeWorkers()
        {
            {
                _worker = new BackgroundWorker();
                _worker.DoWork += (s, e) =>
                {
                    _query = $"SELECT E.EmployeeID, CONCAT(E.FirstName,' ', E.MiddleName,' ',E.LastName) AS " +
                    $"'Full Name', E.Gender, AC.UserName, AC.Password, CASE " +
                    $"WHEN AC.Enabled = 0 THEN 'Disabled' WHEN AC.Enabled = 1 " +
                    $"THEN 'Enabled' END AS 'Account Status', CASE " +
                    $"WHEN AC.LoggedIn = 0 THEN 'Not Logged in' " +
                    $"WHEN AC.LoggedIn = 1 THEN 'Logged in' END AS 'Is " +
                    $"Logged in', ET.AccountType FROM Employee E INNER  JOIN " +
                    $"AccountCredential AC ON E.UserID = AC.UserID INNER JOIN EmployeeType ET ON AC.EmpTypeID = ET.EmpTypeID WHERE AC.Archived=0";
                    _tableData = _dbHelper.GetData(_query);
                };

                _worker.RunWorkerCompleted += (s, e) =>
                {
                    _loadData();
                };
            }
        }

        private void _loadData()
        {

            dgvrEmployeeList.DataSource = _tableData;
            dgvrEmployeeList.ClearSelection();
        }

        private void dgvrEmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _employee = new EmployeeModel();
                _employee.setEmployeeID(Convert.ToInt32(dgvrEmployeeList.Rows[e.RowIndex].Cells[0].Value.ToString()));
                _employee.FirstName = dgvrEmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString().Split(' ')[0];
                _employee.MiddleName = dgvrEmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString().Split(' ')[1];
                _employee.LastName = dgvrEmployeeList.Rows[e.RowIndex].Cells[1].Value.ToString().Split(' ')[2];
                _employee.Gender = dgvrEmployeeList.Rows[e.RowIndex].Cells[2].Value.ToString();
                _employee.AccountCredential = new EmployeeAccount();
                _employee.AccountCredential.UserName = dgvrEmployeeList.Rows[e.RowIndex].Cells[3].Value.ToString();
                _employee.AccountCredential.Password = dgvrEmployeeList.Rows[e.RowIndex].Cells[4].Value.ToString();
                _employee.AccountCredential.Enabled = dgvrEmployeeList.Rows[e.RowIndex].Cells[5].Value.ToString() == "Enabled" ? true : false;
                _employee.AccountCredential.isLoggedIn = dgvrEmployeeList.Rows[e.RowIndex].Cells[6].Value.ToString() == "Logged in" ? true : false;
                var empType = new ViewEmployeeTypes().retrieveData<EmployeeType>().Find(emp => emp.Type == dgvrEmployeeList.Rows[e.RowIndex].Cells[7].Value.ToString());
                _employee.setEmployeeType(empType);
                _selectedEmployee = _employee;
                _setInfo();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
                btnDelete.BackColor = Color.FromArgb(255, 128, 128);
                btnAdd.Enabled = false;
                btnAdd.BackColor = SystemColors.Control;
            }
        }

        private void _setInfo()
        {
            txtFirstName.Text = _employee.FirstName;
            txtMiddleName.Text = _employee.MiddleName;
            txtLastname.Text = _employee.LastName;
            txtUserName.Text = _employee.AccountCredential.UserName;
            txtPassword.Text = _employee.AccountCredential.Password;
            if (_employee.AccountCredential.Enabled)
                rbnEnabled.Checked = true;
            else
                rbnDisabled.Checked = true;
            if (_employee.Gender == "Male")
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;
            cmbType.SelectedIndex = cmbType.FindStringExact(_employee.getEmployeeType().Type);
        }

        private void _resetValues()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastname.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            rbnEnabled.Checked = false;
            rbnDisabled.Checked = false;
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            cmbType.SelectedIndex = -1;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.BackColor = SystemColors.Control;
            btnDelete.BackColor = SystemColors.Control;
            btnAdd.Enabled = true;
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            dgvrEmployeeList.ClearSelection();


        }

        private void _addEmployee(IUpdateEmployee action, EmployeeModel account)
        {

            action.AddEmployee(account);

        }

        private void _updateEmployee(IUpdateEmployee action, EmployeeModel account)
        {

            action.UpdateEmployee(account);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _updateMode = true;
            if (!_checkInput()) return;
            if (MessageBox.Show("Are you sure you want to update this account?", "Confirmation", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
            {
                _selectedEmployee.FirstName = txtFirstName.Text;
                _selectedEmployee.MiddleName = txtMiddleName.Text;
                _selectedEmployee.LastName = txtLastname.Text;
                _selectedEmployee.FirstName = txtFirstName.Text.Trim();
                _selectedEmployee.MiddleName = txtMiddleName.Text.Trim();
                _selectedEmployee.LastName = txtLastname.Text.Trim();
                _selectedEmployee.Gender = rdbFemale.Checked ? "Female" : "Male";
                _selectedEmployee.AccountCredential = new EmployeeAccount();
                _selectedEmployee.AccountCredential.UserName = txtUserName.Text.ToLower().Trim();
                _selectedEmployee.AccountCredential.Password = txtPassword.Text.Trim();
                _selectedEmployee.AccountCredential.Enabled = rbnEnabled.Checked ? true : false;
                _selectedEmployee.AccountCredential.isLoggedIn = false;
                _selectedEmployee.setEmployeeType(new ViewEmployeeTypes().retrieveData<EmployeeType>().Find(emp => emp.ID
                == Convert.ToInt32(cmbType.SelectedValue.ToString())));

                _updateEmployee(EmployeeFactory.EmployeeAction(_model), _selectedEmployee);
                MessageBox.Show("Account Updated Successfully");
                _resetValues();
                _worker.RunWorkerAsync();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _deleteEmployee(EmployeeFactory.EmployeeAction(_model), _selectedEmployee);
                MessageBox.Show("Account Deleted Successfully");
                _resetValues();
                _worker.RunWorkerAsync();
            }
        }

        private void _deleteEmployee(IUpdateEmployee action, EmployeeModel account)
        {
            action.DeleteEmployee(account);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            //search
            if(input != string.Empty)
            {
                _query = $"SELECT E.EmployeeID, CONCAT(E.FirstName,' ', E.MiddleName,' ',E.LastName) AS " +
                    $"'Full Name', E.Gender, AC.UserName, AC.Password, CASE " +
                    $"WHEN AC.Enabled = 0 THEN 'Disabled' WHEN AC.Enabled = 1 " +
                    $"THEN 'Enabled' END AS 'Account Status', CASE " +
                    $"WHEN AC.LoggedIn = 0 THEN 'Not Logged in' " +
                    $"WHEN AC.LoggedIn = 1 THEN 'Logged in' END AS 'Is " +
                    $"Logged in', ET.AccountType FROM Employee E INNER  JOIN " +
                    $"AccountCredential AC ON E.UserID = AC.UserID INNER JOIN EmployeeType ET ON AC.EmpTypeID = " +
                    $"ET.EmpTypeID WHERE AC.Archived=0 AND (E.EmployeeID LIKE '%{input}%' OR E.FirstName LIKE '%{input}%'" +
                    $"OR E.MiddleName LIKE '%{input}%' OR E.LastName LIKE '%{input}%' OR E.Gender LIKE '%{input}%' OR " +
                    $"AC.UserName LIKE '%{input}%' OR AC.Password LIKE '%{input}%' OR ET.AccountType LIKE '%{input}%')";
                    _tableData = _dbHelper.GetData(_query);
                    _loadData();
            }else
            {
                _worker.RunWorkerAsync();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void lblCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _resetValues();
            _updateMode = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_checkInput())
            {
                if (MessageBox.Show("Are you sure you want to add this account?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var employee = new EmployeeModel();
                    employee.FirstName = txtFirstName.Text.Trim();
                    employee.MiddleName = txtMiddleName.Text.Trim();
                    employee.LastName = txtLastname.Text.Trim();
                    employee.Gender = rdbFemale.Checked ? "Female" : "Male";
                    employee.AccountCredential = new EmployeeAccount();
                    employee.AccountCredential.UserName = txtUserName.Text.ToLower().Trim();
                    employee.AccountCredential.Password = txtPassword.Text.Trim();
                    employee.AccountCredential.Enabled = rbnEnabled.Checked ? true : false;
                    employee.AccountCredential.isLoggedIn = false;
                    employee.setEmployeeType(new ViewEmployeeTypes().retrieveData<EmployeeType>().Find(emp => emp.ID
                    == Convert.ToInt32(cmbType.SelectedValue.ToString())));
                    _addEmployee(EmployeeFactory.EmployeeAction(_model), employee);
                    MessageBox.Show("Employee Added Successfully");
                    _resetValues();
                    _worker.RunWorkerAsync();

                }

            }
        }
    }
}
