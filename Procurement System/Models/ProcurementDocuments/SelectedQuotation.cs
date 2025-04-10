using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class SelectedQuotation
    {
        public Quotation Quotation { get; set; } = new Quotation();
        public SupplierModel SelectedSupplier { get; set; }
        public List<QuotationItem> Items { get; set; }

        public override string ToString()
        {
            return SelectedSupplier.SupplierName;
        }
    }
}
