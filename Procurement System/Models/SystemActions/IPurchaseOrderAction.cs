using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IPurchaseOrderAction
    {
        /*
            What can we have on the RFQPO?
            1. The PO can be created. But theres a constraint...
            Should we allow the deletion of procurement? Because PO commonly in procurement
            should not be deleted because it can affect other documents in the system
            But there a situation:
            how about a certain situation where the PO is issued
            But the Supplier says it cannot fullfiled their request and shall make the PO void?
         */
        void CreatePO(QuotationPurchaseOrder purchaseOrder);
        void UpdatePO(QuotationPurchaseOrder purchaseOrder);
        void DeletePO(QuotationPurchaseOrder selectedPO);
        void DeletePOItems(List<QuotationItem> list, int supplierID);
    }
}
