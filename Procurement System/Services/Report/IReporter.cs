using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procurement_System.Services.Report
{
    public interface IReporter
    {
        DataTable GenerateReport();
        DataTable GenerateSpecificReport(string query);
    }
}
