using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IPayInvoice
    {
        void PayAP(AccountPayable ap, BusinessWallet wallet);
        void UpdateAP(AccountPayable ap);
        void PayFullAP(List<AccountPayable> poList, BusinessWallet wallet);
    }
}
