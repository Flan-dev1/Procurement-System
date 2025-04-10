using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IUpdateEmployee
    {
        void AddEmployee(EmployeeModel employee);
        void UpdateEmployee(EmployeeModel employee);
        void DeleteEmployee(EmployeeModel employee);
    }
}
