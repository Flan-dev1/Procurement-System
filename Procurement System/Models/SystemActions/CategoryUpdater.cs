using DatabaseConnection;
using System;

namespace Procurement_System.Models.SystemActions
{
    public class CategoryUpdater
    {
        private Database instance = new Database();
        public void AddCategory(ItemCategory category)
        {
            instance.Query = $"INSERT INTO Category VALUES ('{category.CategoryName}', '0')";
            instance.Add();
        }

        public void UpdateCategory(ItemCategory category)
        {
            instance.Query = $"UPDATE Category SET CategoryName='{category.CategoryName}', " +
                $"Archived='{Convert.ToInt32(category.Archived)}' WHERE CategoryID='{category.CategoryID}'";
            instance.Update();
        }

    }
}
