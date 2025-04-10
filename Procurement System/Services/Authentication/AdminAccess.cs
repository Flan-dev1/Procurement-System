using DatabaseConnection;

namespace Procurement_System.Services.Authentication
{
    public class AdminAccess
    {
        private static Database _instance = new Database();

        public static bool CheckAdminPassword(string password)
        {
            _instance.Query = $"SELECT Password FROM AccountCredential AC INNER JOIN EmployeeType ET " +
                $" ON AC.EmpTypeID = ET.EmpTypeID WHERE ET.AccountType='Admin Manager' AND AC.Password='{password}'";
            var res = _instance.Retrieved();
            return res.Rows.Count > 0;
        }

        public static bool CheckSalesStaffPassword(string password)
        {

            _instance.Query = $"SELECT Password FROM AccountCredential AC INNER JOIN EmployeeType ET " +
                $" ON AC.EmpTypeID = ET.EmpTypeID WHERE ET.AccountType='Sales Staff' AND AC.Password='{password}'";
            var res = _instance.Retrieved();
            return res.Rows.Count > 0;

        }
    }
}
