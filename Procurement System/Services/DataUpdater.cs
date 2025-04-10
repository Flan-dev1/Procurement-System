using Procurement_System.Models.ProcurementDocuments;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Procurement_System.Services
{
    public class DataUpdater
    {

        private ViewData _viewAssets;
        public bool CheckQuotationData(List<Quotation> compare)
        {
            _viewAssets = new ViewQuotations();
            var updatedData = _viewAssets.retrieveData<Quotation>();


            if (updatedData.Count != compare.Count)
            {
                return true;
            }
                


            if (updatedData.Except(compare).Any())
            {
                return true;
            }
            return false;
        }
    }
}
