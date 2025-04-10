using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class AccountPayable
    {
        public int AccountPayableID { get; set; }
        public bool IsPaid { get; set; }
        public double TotalAmount { get; set; }
        public SupplierModel Supplier { get; set; }
        public double PaidAmount { get; set; }
    }
}
