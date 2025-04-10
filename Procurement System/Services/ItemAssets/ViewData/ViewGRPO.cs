using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services.ItemAssets
{
    public class ViewGRPO : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            var list = new List<T>();
            database.Query = $"SELECT * FROM GRPO;";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var grpo = new GoodsReceiptPO();
                grpo.GoodsReceiptID = Convert.ToInt32(row["GoodsReceiptID"]);
                grpo.QuotationPurchaseOrder = new ViewPO().retrieveData<QuotationPurchaseOrder>().
                    Find(qpo => qpo.PurchaseOrderID == Convert.ToInt32(row["PurchaseOrderID"]));
                grpo.IsPartial = Convert.ToBoolean(row["IsPartial"]);
                grpo.TotalPrice = Convert.ToDouble(row["TotalPrice"]);
                list.Add(grpo as T);
            }
            return list;
        }

        public int GetLatestGRPOID()
        {
            database.Query = $"SELECT MAX(GoodsReceiptID) FROM GRPO;";
            var dt = database.Retrieved();
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public bool IsExist(int id)
        {
            database.Query = $"SELECT * FROM GRPO WHERE PurchaseOrderID='{id}'";
            return database.Retrieved().Rows.Count > 0;
        }
    }
}
