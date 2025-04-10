using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services.ItemAssets
{
    public class GRPOItem : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            var list = new List<T>();
            database.Query = $"SELECT * FROM GRPOItem;";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var grpoItem = new GoodsReceiptPO.GoodsReceiptItem();
                grpoItem.GoodsReceiptItemID = Convert.ToInt32(row["GRPOItemID"]);
                grpoItem.QuotationItem.ItemName = row["ItemName"].ToString();
                grpoItem.QuotationItem.Quantity = Convert.ToInt32(row["OrderedQuantity"]);
                grpoItem.DeliveredQuantity = Convert.ToInt32(row["DeliveredQuantity"]);
                grpoItem.Comments = row["Comment"].ToString();
                grpoItem.GoodsReceiptID = Convert.ToInt32(row["GoodReceiptID"]);
                list.Add(grpoItem as T);
            }
            return list;
        }

        public int GetLatestGRPOItemID()
        {
            database.Query = $"SELECT MAX(GoodsReceiptItemID) FROM GRPOItem;";
            var dt = database.Retrieved();
            return Convert.ToInt32(dt.Rows[0][0]);
        }

        public bool IsExist(int id)
        {
            database.Query = $"SELECT * FROM GRPOItem WHERE GoodsReceiptItemID='{id}'";
            return database.Retrieved().Rows.Count > 0;
        }
    }
}
