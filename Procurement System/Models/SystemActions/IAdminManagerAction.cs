using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    internal interface IAdminManagerAction : IUpdateProduct, IUpdateEmployee, IUpdateSupplier,
        IPurchaseOrderAction, IQuotationAction, IPayInvoice, ICreateSession, IGoodsReceiptAction, IDirectPOAction, IDGoodsReceiptAction
    {
    }
    
}
