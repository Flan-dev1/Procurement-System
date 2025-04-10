using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services
{
    public class ViewCategories : ViewData
    {
        public override List<T> retrieveData<T>()
        {

            List<T> list = new List<T>();
            database.Query = $"SELECT * FROM Category;";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var category = new ItemCategory();
                category.CategoryID = Convert.ToInt32(row["CategoryID"]);
                category.CategoryName = row["CategoryName"].ToString();
                category.Archived = Convert.ToBoolean(row["Archived"] == DBNull.Value ? false : row["Archived"]);
                list.Add(category as T);
            }

            return list;
        }
    }
}
