using Procurement_System.Models;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services
{
    public class ViewPO : ViewData
    {

        public override List<T> retrieveData<T>()
        {
            List<T> list = new List<T>();
            database.Query = "SELECT * FROM QuotationPurchaseOrder;";
            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {
                QuotationPurchaseOrder po = new QuotationPurchaseOrder();
                po.PurchaseOrderID = Convert.ToInt32(row["PurchaseOrderID"]);
                var empID = Convert.ToInt32(row["EmployeeID"]);
                po.Employee = new ViewEmployeesInfo().retrieveData<EmployeeModel>().Find(emp => emp.getEmployeeID() == empID);
                po.CreatedDate = Convert.ToDateTime(row["CreatedDate"]);
                po.Remarks = row["Remarks"].ToString();
                po.PurchaseOrderStatus = row["PurchaseOrderStatus"].ToString();
                po.SelectedQuotation.Quotation.QuotationID = Convert.ToInt32(row["QuotationID"]);
                po.AP = new ViewAP().retrieveData<AccountPayable>().Find(ap => ap.AccountPayableID == Convert.ToInt32(row["AccountPayableID"]));
                po.SelectedQuotation.SelectedSupplier = new ViewSupplierInfo().GetSpecificSupplier(Convert.ToInt32(row["SupplierID"]));
                po.SelectedQuotation.Items = GetItemsInPO(po.SelectedQuotation.SelectedSupplier.SupplierID, po.PurchaseOrderID);
                list.Add(po as T);
            }
            return list;
        }

        private List<QuotationItem> GetItemsInPO(int suppID, int poID)
        {
            var list = new List<QuotationItem>();
            database.Query = $"SELECT QI.QuotationItemID, QPO.QuotationID, QI.ItemName, QI.Quantity, QI.Color, QPOIS.Price, " +
                $" (QI.Quantity * QPOIS.Price) AS 'TotalPrice' FROM QuotationItems QI INNER JOIN QPOItemSupplier " +
                $"QPOIS ON QI.QuotationItemID = QPOIS.QuotationItemID INNER JOIN QuotationPurchaseOrder " +
                $"QPO ON QI.QuotationID = QPO.QuotationID WHERE QPO.PurchaseOrderID = '{poID}' AND QPOIS.SupplierID ='{suppID}'";

            var dt = database.Retrieved();
            foreach (DataRow item in dt.Rows)
            {
                var qItem = new QuotationItem();
                qItem.QuotationItemID = Convert.ToInt32(item["QuotationItemID"]);
                qItem.QuoteID = Convert.ToInt32(item["QuotationID"]);
                qItem.ItemName = item["ItemName"].ToString();
                qItem.Color = item["Color"].ToString();
                qItem.Quantity = Convert.ToInt32(item["Quantity"]);
                qItem.TotalPrice = Convert.ToInt32(item["TotalPrice"]);
                qItem.UnitPrice = Convert.ToDouble(item["Price"]);
                list.Add(qItem);
            }
            return list;
        }

        public int GetLatestPOID()
        {
            database.Query = $"SELECT MAX(PurchaseOrderID) FROM QuotationPurchaseOrder";
            var dt = database.Retrieved();
            return Convert.ToInt32(dt.Rows[0][0]);
        }

    }
}
