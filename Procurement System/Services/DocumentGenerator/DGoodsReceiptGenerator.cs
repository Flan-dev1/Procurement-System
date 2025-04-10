using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement_System.Services.DocumentGenerator
{
    public class DGoodsReceiptGenerator
    {

        private DatabaseConnection.Database instance = new DatabaseConnection.Database();
        public void GenerateDirectGoodsReceipt(int grpoID, int supplierID, string filePath)
        {

            instance.Query = $"SELECT * FROM DGRPOReceipt WHERE GoodsReceiptID='{grpoID}' AND SupplierID='{supplierID}'";
            var result = instance.RetrievedDataSet("DGRPOReceipt");
            
            result.WriteXml(Application.StartupPath + "\\DGRPOReceipt.xml");
            result.ReadXml(Application.StartupPath + "\\DGRPOReceipt.xml");
            var report = new DirectGoodsReceiptTemplate();
            report.SetDataSource(result.Tables[0]);
            report.ExportToDisk(ExportFormatType.PortableDocFormat, filePath + "\\GoodsReceipt.pdf");
            
        }
    }
}
