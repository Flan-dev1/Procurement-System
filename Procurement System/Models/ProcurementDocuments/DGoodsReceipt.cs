using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class DGoodsReceipt
    {

        public int GoodsReceiptID { get; set; }
        public int DirectPOID { get; set; }
        public bool IsPartial { get; set; }
        public EmployeeModel Employee { get; set; }
        public DateTime ReceivedDate { get; set; } = DateTime.Now;
        public double TotalPrice { get; set; }
        public List<GoodsReceiptItem> ReceivedItems { get; set; }

        public class GoodsReceiptItem
        {
            public int GoodsReceiptItemID { get; set; }
            public Product Product { get; set; }
            public int DeliveredQuantity { get; set; }
            public int ReceivedQuantity { get; set; } = 0;
            public int OrderedQuantity { get; set; }
            public string Comments { get; set; }
            
        }
    }
}
