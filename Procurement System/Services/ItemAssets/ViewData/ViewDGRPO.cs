using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services.ItemAssets
{
    public class ViewDGRPO : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            throw new NotImplementedException();
        }

        public int GetLatestDGRPOID()
        {
            database.Query = "SELECT TOP 1 GoodsReceiptID FROM DGRPO ORDER BY GoodsReceiptID DESC";
            var dgrpoID = Convert.ToInt32(database.Retrieved().Rows[0][0].ToString());
            return dgrpoID;
        }
    }
}
