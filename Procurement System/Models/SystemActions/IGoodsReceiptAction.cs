using Procurement_System.Models.ProcurementDocuments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IGoodsReceiptAction
    {
        void CreateGoodsReceipt(GoodsReceiptPO GRPO);
        void UpdateGoodsReceipt(GoodsReceiptPO GRPO);
        void DeleteGoodsReceipt(GoodsReceiptPO GRPO);
    }
}
