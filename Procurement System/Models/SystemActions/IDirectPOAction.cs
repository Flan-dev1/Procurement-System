using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IDirectPOAction
    {

        void CreatePO(DirectPurchaseOrder po);
        void DeletePO(DirectPurchaseOrder selectedPO);
    }
}
