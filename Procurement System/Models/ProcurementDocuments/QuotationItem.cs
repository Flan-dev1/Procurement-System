using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class QuotationItem
    {
        [DisplayName("Quotation Item ID")]
        public int QuotationItemID { get; set; }
        public int QuoteID { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Unit Price")]
        public double UnitPrice { get; set; }
        [DisplayName("Total Price")]
        public double TotalPrice { get; set; }
        [DisplayName("Supplier Provider")]
        public SupplierModel SupplierProvider { get; set; }
        [DisplayName("Category")]
        public ItemCategory ItemCategory { get; set; } = new ItemCategory();
        [DisplayName("Item Type")]
        public ItemType ItemType { get; set; } = new ItemType();
    }
}
