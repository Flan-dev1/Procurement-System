using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class BusinessWallet
    {
        public string BusinessWalletID { get; set; }
        public string WalletName { get; set; }
        public double TotalBalance { get; set; }
    }
}
