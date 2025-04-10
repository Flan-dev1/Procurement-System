using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace Procurement_System.Services.DocumentGenerator
{
    public class PurchaseOrderGenerator
    {
        private DatabaseConnection.Database instance = new DatabaseConnection.Database();
        public void GeneratePurchaseOrder(int poID, int supplierID, string filePath)
        {
            var temp = $"SELECT QPO.SupplierID, QI.QuotationItemID, QI.Color, QPO.CreatedDate, QPO.PurchaseOrderID, CONCAT(EMP.FirstName,' ',EMP.LastName) AS 'Employee Name'," +
                $"S.SupplierName, S.Address, PT.PaymentName, QI.ItemName, (QPOIS.Price * QI.Quantity) AS 'Total'," +
                $"QI.Quantity, QPOIS.Price AS 'Unit Price', QPO.Remarks FROM QuotationItems QI " +
                $"INNER JOIN QPOItemSupplier QPOIS ON QI.QuotationItemID = QPOIS.QuotationItemID " +
                $"INNER JOIN Supplier S ON QPOIS.SupplierID = S.SupplierID " +
                $"INNER JOIN PaymentTerms PT ON S.PaymentTermsID = PT.PaymentTermsID " +
                $"INNER JOIN QuotationPurchaseOrder QPO ON QI.QuotationID = QPO.QuotationID " +
                $"INNER JOIN RequestForQuotation RFQ ON QI.QuotationID = RFQ.QuotationID INNER JOIN Employee EMP " +
                $"ON QPO.EmployeeID = EMP.EmployeeID WHERE QPO.PurchaseOrderID = '{poID}' AND " +
                $"QPOIS.SupplierID='{supplierID}'";

            instance.Query = temp;
            var result = instance.RetrievedDataSet("QuotationItems");
            result.WriteXml(Application.StartupPath + "\\RFQPurchaseOrder.xml");
            result.ReadXml(Application.StartupPath + "\\RFQPurchaseOrder.xml");
            var report = new RFQPurchaseOrderTemplate();
            report.SetDataSource(result.Tables[0]);
            //Create a folder based on filePath variable
            report.ExportToDisk(ExportFormatType.PortableDocFormat, filePath + "\\PurchaseOrder.pdf");


        }
    }
}
