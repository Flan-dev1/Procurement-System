using System;
using System.Collections.Generic;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class DirectPurchaseOrder
    {
        public int ID { get; set; }
        public EmployeeModel Employee { get; set; }
        public string Remarks { get; set; } = "No Remarks";
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public List<DirectPurchaseOrderDetails> DirectPurchaseOrderDetail { get; set; } = new List<DirectPurchaseOrderDetails>();
        public class DirectPurchaseOrderDetails
        {
            public int DirectPOID { get; set; }
            public int ID { get; set; }
            public string PurchaseOrderStatus { get; set; } = "Pending";
            public AccountPayable AP { get; set; } = new AccountPayable();
            public SupplierModel Supplier { get; set; } = new SupplierModel();
            public List<Product> Items { get; set; } = new List<Product>();
            public bool Archived { get; set; } = false;
            public EmployeeModel employee { get; set; } = new EmployeeModel();

        }
    }
}
