using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services
{
    public class ViewItemType : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            List<T> list = new List<T>();
            database.Query = $"SELECT * FROM ItemType;";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var itemType = new ItemType();
                itemType.ItemTypeID = Convert.ToInt32(row["ItemTypeID"]);
                itemType.TypeName = row["TypeName"].ToString();
                list.Add(itemType as T);
            }

            return list;
        }
    }
}
