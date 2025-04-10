using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class PaymentTerms
    {

        public int Id { get; set; }
        public string PaymentTermName { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public int DueDate { get; set; }
        public int DiscountValidity { get; set; }
        public int Archived { get; set; } = 0;

        public override string ToString()
        {
            return PaymentTermName;
        }
    }
}
