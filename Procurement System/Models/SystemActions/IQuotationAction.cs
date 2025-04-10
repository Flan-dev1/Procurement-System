using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IQuotationAction
    {
        void CreateQuotation(Quotation quote);
        void UpdateQuotation(Quotation quote);
        void DeleteQuotation(Quotation quote);
        void UpdateQuotationPrices(List<QuotationItem> list, int quoteID);
        void DeleteItemQuotation(List<QuotationItem> list, int quoteID);
        void DeleteSupplierQuotation(List<SupplierModel> list, int quoteID);
        void AddItemFromQuotation(QuotationItem item);
    }
}
