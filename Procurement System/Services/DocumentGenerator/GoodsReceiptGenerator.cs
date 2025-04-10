using CrystalDecisions.Shared;
using System.Windows.Forms;

namespace Procurement_System.Services.DocumentGenerator
{
    public class GoodsReceiptGenerator
    {

        private DatabaseConnection.Database instance = new DatabaseConnection.Database();
        public void GenerateGRPO(int GRPOID, string filePath)
        {

            instance.Query = $"SELECT * FROM QGRPOReceipt WHERE GoodsReceiptID='{GRPOID}'";
            var result = instance.RetrievedDataSet("GRPOItem");
            result.WriteXml(Application.StartupPath + "\\GRPO.xml");
            result.ReadXml(Application.StartupPath + "\\GRPO.xml");
            var report = new GoodsReceiptTemplate();
            report.SetDataSource(result.Tables[0]);
            //Create a folder based on filePath variable
            report.ExportToDisk(ExportFormatType.PortableDocFormat, filePath + "\\GoodsReceipt.pdf");


        }
    }
}
