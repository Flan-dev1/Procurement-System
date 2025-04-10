using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class Product
    {

        [DisplayName("Product ID")]
        public int ProductID { get; set; }
        [DisplayName("Item ID")]
        public int ItemID { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; }
        public ItemCategory ItemCategory { get; set; } = new ItemCategory();
        public ItemType ItemType { get; set; } = new ItemType();
        public SupplierModel ItemSupplier { get; set; }
    }
}
