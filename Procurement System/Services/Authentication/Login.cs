using Procurement_System.Models;
using Procurement_System.Models.Users;
using System;
namespace Procurement_System.Services.Authentication
{
    public class Login : AuthenticateUser
    {
        public override bool CheckUserName(string username,Action<string> callback)
        {
            instance.Query = "SELECT * FROM AccountCredential " +
                "WHERE UserName = '" + username + "' AND Archived = 0";
            var dt = instance.Retrieved();
            retries = 3;
            CanLogin = true;
            if (dt.Rows.Count == 1)
            {
                var isEnabled = Convert.ToBoolean(dt.Rows[0]["enabled"]);

                if (!isEnabled)
                {
                    callback("Your account is disabled.\nPlease contact your administrator.");
                    CanLogin = false;
                    return false;
                }

                var isLoggedIn = Convert.ToBoolean(dt.Rows[0]["LoggedIn"]);

                if (isLoggedIn)
                {
                    callback("Your account is already logged in.\nPlease contact your administrator.");
                    CanLogin = false;
                    return false;
                }

                //Setting account credential of the user.
                var accountCredential = new EmployeeAccount();
                accountCredential.Id = Convert.ToInt32(dt.Rows[0]["UserID"]);
                accountCredential.UserName = dt.Rows[0]["UserName"].ToString();
                accountCredential.Password = dt.Rows[0]["Password"].ToString();

                instance.Query = "SELECT * FROM Employee WHERE UserID = '" + accountCredential.Id + "'";
                dt = instance.Retrieved();
                user = new EmployeeModel();
                user.FirstName = dt.Rows[0]["FirstName"].ToString();
                user.MiddleName = dt.Rows[0]["MiddleName"].ToString();
                user.LastName = dt.Rows[0]["LastName"].ToString();
                user.Gender = dt.Rows[0]["Gender"].ToString();
                user.setEmployeeID(Convert.ToInt32(dt.Rows[0]["EmployeeID"].ToString()));
                instance.Query = $"SELECT * FROM EmployeeType ET INNER JOIN AccountCredential AC" +
                    $" ON ET.EmpTypeID = AC.EmpTypeID WHERE AC.UserName = '{username}'";
                var empType = new EmployeeType();
                dt = instance.Retrieved();
                empType.setID(Convert.ToInt32(dt.Rows[0]["EmpTypeID"]));
                empType.setType(dt.Rows[0]["AccountType"].ToString());
                user.setEmployeeType(empType);
                user.AccountCredential = accountCredential;

                instance.Query = "UPDATE AccountCredential SET LoggedIn = 1 WHERE UserID = '" + accountCredential.Id + "'";
                instance.Update();
                return true;
            }
            callback.Invoke("Invalid User Name Try again.");
            return false;
        }

        public override bool CheckPassword(string password, Action<string, bool> callback)
        {

            var PASSWORD = user.AccountCredential.Password;
            if (!PASSWORD.Equals(password))
                {
                    retries--;
                    callback.Invoke($"Invalid Password Try again. Remaining {retries}", CanLogin);
                    if (retries == 0) {
                        CanLogin = false;
                        callback("You have exceeded the number of retries", CanLogin);
                    instance.Query = $"UPDATE AccountCredential SET enabled = 0 WHERE UserName = '{user.AccountCredential.UserName}'";
                    instance.Update();
                }
                    return false;
                }

            retries = 3;

            return true;
                
        }

        public override EmployeeModel GetEmployee()
        {
            return user;
        }
    }
}
