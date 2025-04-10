using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services
{
    public class ViewEmployeesInfo : ViewData
    {

        public override List<T> retrieveData<T>()
        {
            List<T> data = new List<T>();
            database.Query = "SELECT * FROM Employee;";
            var res = database.Retrieved();
            foreach(DataRow row in res.Rows)
            {
                var emp = new EmployeeModel();
                emp.setEmployeeID(Convert.ToInt32(row["EmployeeID"]));
                emp.FirstName = row["FirstName"].ToString();
                emp.MiddleName = row["MiddleName"].ToString();
                emp.LastName = row["LastName"].ToString();
                emp.Gender = row["Gender"].ToString();
                database.Query = $"SELECT * FROM EmployeeType ET INNER JOIN AccountCredential AC ON " +
                    $" AC.EmpTypeID = ET.EmpTypeID INNER JOIN Employee E ON AC.UserID = E.UserID" +
                    $" WHERE E.UserID = '{row["UserID"]}'";
                var res2 = database.Retrieved();
                var employeeType = new EmployeeType();
                employeeType.setID(Convert.ToInt32(res2.Rows[0]["EmpTypeID"]));
                employeeType.setType(res2.Rows[0]["AccountType"].ToString());
                emp.setEmployeeType(employeeType);
                database.Query = $"SELECT * FROM AccountCredential WHERE UserID='{row["UserID"]}'";
                var res3 = database.Retrieved();
                var credential = new EmployeeAccount();
                credential.UserName = res3.Rows[0]["UserName"].ToString();
                credential.Password = res3.Rows[0]["Password"].ToString();
                credential.Enabled = Convert.ToBoolean(res3.Rows[0]["Enabled"]);
                emp.AccountCredential = credential;
                data.Add(emp as T);
            }
            return data;
        }
    }
}
