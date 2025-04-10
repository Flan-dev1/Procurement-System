using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models
{
    public class ItemCategory
    {

        [DisplayName("Category ID")]
        public int CategoryID { get; set; }
        [DisplayName("Category Name")]
        public String CategoryName { get; set; }
        public bool Archived { get; set; }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}
