using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using DatabaseConnection;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;

namespace Procurement_System.Services.DocumentGenerator
{
    public class QuotationGenerator
    {
        /*
            Algorithm:
                1. Get the quotationID, the supplier and filePath
                2. Save the designated pdf to the filepath string.
         */
        private DatabaseConnection.Database instance = new DatabaseConnection.Database();
        public void GenerateQuote(int quoteID, int supplierID, string filePath)
        {
            var temp = $"SELECT RFQ.QuotationID, RFQ.Remarks, RFQ.ExpirationDate, CONVERT(DATE,RFQ.CreatedDate) AS 'CreatedDate', " +
                $"EMP.FirstName, EMP.LastName, QI.QuotationItemID, QI.ItemName, QI.Color, QI.Quantity, S.SupplierName, S.Address " +
                $"FROM QuotationItems QI INNER JOIN RFQSupplierDetails RFQS ON QI.QuotationID = RFQS.QuotationID " +
                $"INNER JOIN RequestForQuotation RFQ ON QI.QuotationID = RFQ.QuotationID INNER JOIN " +
                $"Employee EMP ON RFQ.EmployeeID = EMP.EmployeeID " +
                $"INNER JOIN Supplier S ON RFQS.SupplierID = S.SupplierID " +
                $"WHERE QI.QuotationID='{quoteID}' AND RFQS.SupplierID = '{supplierID}'";

            instance.Query = temp;
            var result = instance.RetrievedDataSet("QuotationItems");
            result.WriteXml(Application.StartupPath + "\\Quotation.xml");
            result.ReadXml(Application.StartupPath + "\\Quotation.xml");
            var report = new QuotationTemplate();
            report.SetDataSource(result.Tables[0]);
            //Create a folder based on filePath variable
            report.ExportToDisk(ExportFormatType.PortableDocFormat, filePath + "\\Quotation.pdf");

            
        }
    }
}
