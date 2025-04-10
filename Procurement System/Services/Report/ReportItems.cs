using DatabaseConnection;
using System;
using System.Data;

namespace Procurement_System.Services.Report
{
    public class ReportItems : IReporter
    {
        private Database _instance = new Database();
        public DataTable GenerateReport()
        {
            return null;
        }

        public DataTable GenerateSpecificReport(string query)
        {
            throw new NotImplementedException();
        }
    }
}
