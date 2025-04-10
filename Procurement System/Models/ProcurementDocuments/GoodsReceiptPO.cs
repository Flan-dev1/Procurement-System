using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class GoodsReceiptPO
    {
        public int GoodsReceiptID { get; set; }
        public SelectedQuotation SelectedQuotation { get; set; }
        public QuotationPurchaseOrder QuotationPurchaseOrder { get; set; }
        public bool IsPartial { get; set; }
        public DateTime CreatedDate { get; set; }
        public double TotalPrice { get; set; }
        public List<GoodsReceiptItem> ReceivedItems { get; set; }
        public EmployeeModel Employee { get; set; }
        public DateTime ReceivedDate { get; set; }

        public class GoodsReceiptItem
        {
            public QuotationItem QuotationItem { get; set; } = new QuotationItem();
            public int GoodsReceiptItemID { get; set; }
            public int DeliveredQuantity { get; set; }
            public string Comments { get; set; }
            public int GoodsReceiptID { get; set; }

        }
    }
}
