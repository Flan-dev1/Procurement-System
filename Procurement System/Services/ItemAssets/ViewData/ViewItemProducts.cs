using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services
{
    public class ViewItemProducts : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            List<T> list = new List<T>();
            database.Query = "SELECT * FROM SupplierItem INNER JOIN SupplierItemDetails " +
                "ON SupplierItem.ItemID = SupplierItemDetails.ItemID";
            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {
                var item = new Product();
                item.ProductID = Convert.ToInt32(row["ProductID"]);
                item.ItemID = Convert.ToInt32(row["ItemID"]);
                item.ItemName = row["ItemName"].ToString();
                item.Color = row["Color"].ToString();
                item.Price = Convert.ToDouble(row["UnitPrice"]);
                item.Quantity = Convert.ToInt32(row["Stocks"]);
                item.Description = row["Description"].ToString();
                item.ItemCategory = _getItemCategory(Convert.ToInt32(row["CategoryID"].ToString()));
                item.ItemType = _getItemType(Convert.ToInt32(row["ItemTypeID"].ToString()));
                item.ItemSupplier = new ViewSupplierInfo().GetSpecificSupplier(Convert.ToInt32(row["SupplierID"]));
                list.Add(item as T);
            }

            return list;
        }

        public List<Product> GetGenericItemNames()
        {
            var list = new List<Product>();
            database.Query = $"SELECT * FROM SupplierItem";
            var res = database.Retrieved();
            
            foreach(DataRow row in res.Rows)
            {
                var item = new Product();
                item.ItemID = Convert.ToInt32(row["ItemID"]);
                item.ItemName = row["ItemName"].ToString();
                list.Add(item);
            }
            return list;
        }
        public int GetLatestItemID()
        {

            database.Query = "SELECT MAX(ItemID) FROM SupplierItem;";
            var dt = database.Retrieved();
            return Convert.ToInt32(dt.Rows[0][0]);

        }

        private ItemCategory _getItemCategory(int id)
        {
            var category = new ItemCategory();
            database.Query = $"SELECT * FROM Category WHERE CategoryID ='{id}'";
            var res = database.Retrieved();
            category.CategoryID = Convert.ToInt32(res.Rows[0]["CategoryID"].ToString());
            category.CategoryName = res.Rows[0]["CategoryName"].ToString();
            return category;
        }
        private ItemType _getItemType(int id)
        {
            var type = new ItemType();
            database.Query = $"SELECT * FROM ItemType WHERE ItemTypeID ='{id}'";
            var res = database.Retrieved();
            type.ItemTypeID = Convert.ToInt32(res.Rows[0]["ItemTypeID"].ToString());
            type.TypeName = res.Rows[0]["TypeName"].ToString();
            return type;
        }
    }
}
