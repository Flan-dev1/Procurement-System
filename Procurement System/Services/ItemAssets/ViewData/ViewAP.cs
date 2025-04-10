using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services.ItemAssets
{
    public class ViewAP : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            var list = new List<T>();
            database.Query = $"SELECT * FROM AccountsPayable;";
            var res = database.Retrieved();

            foreach (DataRow row in res.Rows)
            {
                var ap = new AccountPayable();
                ap.AccountPayableID = Convert.ToInt32(row["AccountPayableID"]);
                ap.TotalAmount = Convert.ToDouble(row["TotalAmount"]);
                ap.IsPaid = Convert.ToBoolean(row["IsPaid"]);
                ap.Supplier = new ViewSupplierInfo().GetSpecificSupplier(Convert.ToInt32(row["SupplierID"]));
                list.Add(ap as T);
            }
            return list;
        }
    }
}
