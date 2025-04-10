using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class QuotationPurchaseOrder
    {
        public int PurchaseOrderID { get; set; }
        public EmployeeModel Employee { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Remarks { get; set; }
        public string PurchaseOrderStatus { get; set; } = "Pending";
        public AccountPayable AP { get; set; } = new AccountPayable();
        public SelectedQuotation SelectedQuotation { get; set; } = new SelectedQuotation();
    }
}
