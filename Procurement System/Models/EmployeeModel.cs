using DatabaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class EmployeeModel : PersonModel
    {

        protected Database instance = new Database();
        private EmployeeType EmployeeType;
        public EmployeeAccount AccountCredential;
        private int EmployeeID;
        
        public void setEmployeeType(EmployeeType type)
        {
            
            EmployeeType = type;
            
        }

        public void setEmployeeID(int id)
        {

            EmployeeID = id;
        }

        public EmployeeType getEmployeeType()
        {
            return EmployeeType;
        }

        public int getEmployeeID()
        {
            return EmployeeID;
        }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }
    }
}
