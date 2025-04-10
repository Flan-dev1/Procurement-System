using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class Quotation
    {
        [DisplayName("Quotation ID")]
        public int QuotationID { get; set; }
        public EmployeeModel Employee { get; set; }
        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Due Date")]
        public DateTime ExpirationDate { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public int QuoteReceived { get; set; }
        public List<QuotationItem> Items { get; set; } = new List<QuotationItem>();
        public List<SupplierModel> Suppliers { get; set; } = new List<SupplierModel>();
    }
}
