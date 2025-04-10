using DatabaseConnection;
using System.Data;

namespace Procurement_System.Services
{
    public class Helper
    {
        private Database _instance = new Database();
        public DataTable GetData(string query)
        {
            _instance.Query = query;
            return _instance.Retrieved();
        }

        public void AddUpdDelData(string query)
        {
            _instance.Query = query;
            _instance.Add();
        }

        public bool IsExist(string query)
        {
            _instance.Query = query;
            var res = _instance.Retrieved();
            return res.Rows.Count > 0;
        }
    }
}
