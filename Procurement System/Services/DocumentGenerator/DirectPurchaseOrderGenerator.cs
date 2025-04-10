using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace Procurement_System.Services.DocumentGenerator
{
    public class DirectPurchaseOrderGenerator
    {

        private DatabaseConnection.Database instance = new DatabaseConnection.Database();
        public void GenerateDirectPO(int poID, int sID, string filePath)
        {
            instance.Query = $"SELECT * FROM DirectPO WHERE DirectPOID={poID} AND DirectPODetailsID='{sID}';";
            var result = instance.RetrievedDataSet("DirectPurchaseOrderItems");
            result.WriteXml(Application.StartupPath + "\\DirectPurchaseOrder.xml");
            result.ReadXml(Application.StartupPath + "\\DirectPurchaseOrder.xml");

            var report = new DirectPurchaseOrder();
            report.SetDataSource(result.Tables[0]);
            //Create a folder based on filePath variable
            report.ExportToDisk(ExportFormatType.PortableDocFormat, filePath + "\\PurchaseOrder.pdf");
        }

    }
}
