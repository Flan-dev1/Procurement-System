using Procurement_System.Models;
using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services.ItemAssets
{
    public class ViewDirectPO : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            var list = new List<T>();
            database.Query = $"SELECT * FROM DirectPurchaseOrder;";
            var res = database.Retrieved();
            //Iterate the list of rows
            foreach (DataRow row in res.Rows)
            {
                var dpo = new DirectPurchaseOrder();
                dpo.ID = Convert.ToInt32(row["DirectPOID"].ToString());
                dpo.Employee = new ViewEmployeesInfo().retrieveData<EmployeeModel>().Find(emp => emp.getEmployeeID() ==
                Convert.ToInt32(row["EmployeeID"]));
                dpo.CreatedDate = Convert.ToDateTime(row["CreatedDate"].ToString());
                dpo.Remarks = row["Remarks"].ToString();
                dpo.DirectPurchaseOrderDetail = ItemList().FindAll(dpod => dpod.DirectPOID == dpo.ID);
                //Add the item to the list
                list.Add(dpo as T);
            }
            return list;
        }

        public List<DirectPurchaseOrder.DirectPurchaseOrderDetails> ItemList()
        {
            
                var list = new List<DirectPurchaseOrder.DirectPurchaseOrderDetails>();
                database.Query = $"SELECT * FROM DirectPurchaseOrderDetails;";
                var res = database.Retrieved();
                //Iterate the list of rows
                foreach (DataRow row in res.Rows)
                {
                    var dpo = new DirectPurchaseOrder.DirectPurchaseOrderDetails();
                    dpo.ID = Convert.ToInt32(row["DirectPODetailsID"].ToString());
                    dpo.DirectPOID = Convert.ToInt32(row["DirectPOID"].ToString());
                    dpo.PurchaseOrderStatus = row["PurchaseOrderStatus"].ToString();
                    dpo.Supplier = new ViewSupplierInfo().retrieveData<SupplierModel>().Find(sup => sup.SupplierID ==
                    Convert.ToInt32(row["SupplierID"]));
                    dpo.AP = new ViewAP().retrieveData<AccountPayable>().Find(ap => ap.AccountPayableID ==
                    Convert.ToInt32(row["AccountPayableID"]));
                    //Add the item to the list
                    list.Add(dpo);
                }
                return list;
            
        }
        public int GetLatestPOID()
        {
            database.Query = $"SELECT MAX(DirectPoID) FROM DirectPurchaseOrder;";
            return Convert.ToInt32(database.Retrieved().Rows[0][0].ToString());
        }

        public int GetLatestPODetailsID(int id)
        {

            database.Query = $"SELECT MAX(DirectPoDetailsID) FROM DirectPurchaseOrderDetails WHERE DirectPoID = {id};";
            return Convert.ToInt32(database.Retrieved().Rows[0][0].ToString());

        }
    }
}
