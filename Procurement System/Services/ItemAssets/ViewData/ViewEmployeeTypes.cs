using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services.ItemAssets
{
    class ViewEmployeeTypes : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            var list = new List<T>();
            database.Query = $"SELECT * FROM EmployeeType;";
            var res = database.Retrieved();

            foreach (DataRow row in res.Rows)
            {

                var employeeType = new EmployeeType();
                employeeType.setID(Convert.ToInt32(row["EmpTypeID"]));
                employeeType.setType(row["AccountType"].ToString());
                list.Add((T)Convert.ChangeType(employeeType, typeof(T)));
            }
            return list;

        }
    }
}
