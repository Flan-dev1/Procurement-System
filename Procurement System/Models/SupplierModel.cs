using Microsoft.SqlServer.Server;
using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class SupplierModel
    {
        [DisplayName("Supplier ID")]
        public int SupplierID { get; set; }
        [DisplayName("Supplier Name")]
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [DisplayName("Payment Terms")]
        public PaymentTerms PaymentTerms { get; set; }
        //public AccountPayable AccountPayable { get; set; }
        public List<Product> Items { get; set; } = new List<Product>();
        public int Archived { get; set; }
        public override string ToString()
        {
            return SupplierName;
        }
    }
}
