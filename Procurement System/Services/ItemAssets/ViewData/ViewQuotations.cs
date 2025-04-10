using Procurement_System.Models;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services
{
    public class ViewQuotations : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            List<T> list = new List<T>();
            database.Query = $"SELECT RFQ.QuotationID, RFQ.CreatedDate, RFQ.ExpirationDate," +
                $" RFQ.EmployeeID, RFQ.Status, RFQ.Remarks, RFQD.QuoteReceived " +
                $"FROM RequestForQuotation RFQ INNER JOIN " +
                $"RFQSupplierDetails RFQD ON RFQ.QuotationID = RFQD.QuotationID;";

            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {
                var quotation = new Quotation();
                quotation.QuotationID = Convert.ToInt32(row["QuotationID"]);
                quotation.Employee = _getEmployee(Convert.ToInt32(row["EmployeeID"]));
                quotation.Status = row["Status"].ToString();
                quotation.Remarks = row["Remarks"].ToString();
                quotation.QuoteReceived = Convert.ToInt32(row["QuoteReceived"]);
                quotation.Items = _getItemList(quotation.QuotationID);
                quotation.Suppliers = _getSupplier(quotation.QuotationID);
                quotation.CreatedDate = Convert.ToDateTime(row["CreatedDate"]);
                quotation.ExpirationDate = Convert.ToDateTime(row["ExpirationDate"]);
                list.Add(quotation as T);
            }
            return list;
        }

        private EmployeeModel _getEmployee(int empID)
        {
            var employee = new EmployeeModel();
            database.Query = $"SELECT * FROM Employee WHERE EmployeeID = {empID}";
            employee.setEmployeeID(empID);
            employee.FirstName = database.Retrieved().Rows[0]["FirstName"].ToString();
            employee.MiddleName = database.Retrieved().Rows[0]["MiddleName"].ToString();
            employee.LastName = database.Retrieved().Rows[0]["LastName"].ToString();
            employee.Gender = database.Retrieved().Rows[0]["Gender"].ToString();
            return employee;
        }

        private List<SupplierModel> _getSupplier(int quoteID)
        {
            var list = new List<SupplierModel>();
            database.Query = $"SELECT * FROM RFQSupplierDetails RFQD INNER JOIN Supplier S ON RFQD.SupplierID = S.SupplierID WHERE RFQD.QuotationID = {quoteID}";
            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {
                var supplier = new SupplierModel();
                supplier.SupplierID = Convert.ToInt32(row["SupplierID"]);
                supplier.SupplierName = row["SupplierName"].ToString();
                supplier.Address = row["Address"].ToString();
                supplier.Email = row["SupplierEmail"].ToString();
                supplier.PaymentTerms = new ViewPaymentTerms().retrieveData<PaymentTerms>().Find(pt => pt.Id == Convert.ToInt32(row["PaymentTermsID"]));
                list.Add(supplier);
            }
            return list;
        }

        private List<QuotationItem> _getItemList(int quoteID)
        {
            var list = new List<QuotationItem>();
            database.Query = $"SELECT *, (QPOIS.Price * QI.Quantity) AS 'TotalPrice' FROM QuotationItems QI INNER JOIN QPOItemSupplier QPOIS ON QI.QuotationItemID = QPOIS.QuotationItemID WHERE QI.QuotationID={quoteID};";
            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {


                var item = new QuotationItem();
                item.QuotationItemID = Convert.ToInt32(row["QuotationItemID"]);
                item.ItemName = row["ItemName"].ToString();
                item.Color = row["Color"].ToString();
                item.Quantity = Convert.ToInt32(row["Quantity"]);
                item.UnitPrice = Convert.ToDouble(row["price"]);
                item.TotalPrice = Convert.ToDouble(row["TotalPrice"]);
                item.SupplierProvider = _getItemSupplier(Convert.ToInt32(row["SupplierID"]));
                list.Add(item);

            }
            return list;
        }
        private SupplierModel _getItemSupplier(int supplierID)
        {
            var supplier = new SupplierModel();
            database.Query = $"SELECT * FROM Supplier WHERE SupplierID = {supplierID}";
            var dt = database.Retrieved();
            supplier.SupplierID = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
            supplier.SupplierName = dt.Rows[0]["SupplierName"].ToString();
            supplier.Address = dt.Rows[0]["Address"].ToString();
            supplier.Email = dt.Rows[0]["SupplierEmail"].ToString();
            return supplier;

        }

        public bool CheckQuoteSupplierPrice(int supplierID, int quotationItemID)
        {
            database.Query = $"SELECT * FROM QPOItemSupplier WHERE QuotationItemID = '{quotationItemID}' AND SupplierID = '{supplierID}'";
            var result = database.Retrieved();
            return result.Rows.Count > 0;
        }

        public List<QuotationItem> GetGenericItems(int id)
        {
            var list = new List<QuotationItem>();
            database.Query = $"SELECT * FROM QuotationItems WHERE QuotationID='{id}'";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var quoteItem = new QuotationItem();
                quoteItem.QuotationItemID = Convert.ToInt32(row["QuotationItemID"]);
                quoteItem.QuoteID = Convert.ToInt32(row["QuotationID"]);
                quoteItem.ItemName = row["ItemName"].ToString();
                quoteItem.Color = row["Color"].ToString();
                quoteItem.Quantity = Convert.ToInt32(row["Quantity"]);
                list.Add(quoteItem);
            }
            return list;
        }
        public List<QuotationItem> GetItemsInQuotation(int id)
        {
            var list = new List<QuotationItem>();
            database.Query = $"SELECT *, (QPOI.Price * QI.Quantity) AS 'TotalPrice' FROM " +
                $"QuotationItems QI LEFT JOIN QPOItemSupplier " +
                $"QPOI ON QI.QuotationItemID = QPOI.QuotationItemID WHERE QI.QuotationID='{id}';";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var quoteItem = new QuotationItem();
                quoteItem.QuotationItemID = Convert.ToInt32(row["QuotationItemID"]);
                quoteItem.QuoteID = Convert.ToInt32(row["QuotationID"]);
                quoteItem.ItemName = row["ItemName"].ToString();
                quoteItem.Color = row["Color"].ToString();
                quoteItem.Quantity = Convert.ToInt32(row["Quantity"]);
                quoteItem.UnitPrice = Convert.ToDouble(row["Price"] == DBNull.Value ? 0 : row["Price"]);
                quoteItem.TotalPrice = Convert.ToDouble(row["TotalPrice"] == DBNull.Value ? 0 : row["TotalPrice"]);
                if (row["SupplierID"] != DBNull.Value)
                    quoteItem.SupplierProvider = _getItemSupplier(Convert.ToInt32(row["SupplierID"]));
                list.Add(quoteItem);
            }
            return list;
        }
    }
}
