using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.ProcurementDocuments
{
    public class JournalEntry
    {
        public int JournalEntryID { get; set; }
        public AccountPayable AccountPayable { get; set; }
        public double AmountPaid { get; set; }
        public BusinessWallet BusinessWallet { get; set; }
    }
}
