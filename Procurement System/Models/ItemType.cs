using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class ItemType
    {
        [DisplayName("Item Type ID")]
        public int ItemTypeID { get; set; }
        [DisplayName("Item Type")]
        public string TypeName { get; set; }

        [DisplayName("Item Type")]
        public override string ToString()
        {
            return TypeName;
        }
    }
}
