using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Models.SystemActions
{
    public interface IUpdateSupplier
    {
        void AddSupplier(SupplierModel supplier);
        void UpdateSupplier(SupplierModel supplier);
        void DeleteSupplier(SupplierModel supplier);
    }
}
