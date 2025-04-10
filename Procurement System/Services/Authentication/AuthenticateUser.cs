using DatabaseConnection;
using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services
{
    public abstract class AuthenticateUser
    {
        protected EmployeeModel user = null;
        public bool CanLogin = true;
        public static int retries = 3;
        protected Database instance = new Database();
        public abstract bool CheckUserName(string username, Action<string> callBack);
        public abstract bool CheckPassword(string password, Action<string, bool> callBack);
        public abstract EmployeeModel GetEmployee();
       
    }
}
