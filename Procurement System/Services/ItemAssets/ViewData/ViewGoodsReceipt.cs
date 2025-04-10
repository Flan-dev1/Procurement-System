using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services
{
    public class ViewGoodsReceipt : ViewData
    {

        public override List<T> retrieveData<T>()
        {
            List<T> list = new List<T>();
            database.Query = "SELECT * FROM GoodsReceipt";
            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {
;
            }
            return list;

        }
    }
}
