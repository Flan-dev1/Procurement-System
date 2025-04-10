using Procurement_System.Models;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.Data;

namespace Procurement_System.Services
{
    public class ViewSupplierInfo : ViewData
    {

        public override List<T> retrieveData<T>()
        {
            List<T> list = new List<T>();
            database.Query = "SELECT * FROM Supplier;";
            var dt = database.Retrieved();
            foreach (DataRow row in dt.Rows)
            {
                var supplier = new SupplierModel();
                supplier.SupplierID = Convert.ToInt32(row["SupplierID"]);
                supplier.SupplierName = row["SupplierName"].ToString();
                supplier.Address = row["Address"].ToString();
                supplier.Email = row["SupplierEmail"].ToString();
                supplier.PaymentTerms = new ViewPaymentTerms().retrieveData<PaymentTerms>().Find(pt => 
                pt.Id == Convert.ToInt32(row["PaymentTermsID"]));
                supplier.Archived = Convert.ToInt32(row["Archived"]);
                list.Add(supplier as T);
            }
            return list;


        }

        public SupplierModel GetSpecificSupplier(int id)
        {
            database.Query = $"SELECT * FROM Supplier WHERE SupplierID = {id}";
            var dt = database.Retrieved();
            var supplier = new SupplierModel();
            supplier.SupplierID = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
            supplier.SupplierName = dt.Rows[0]["SupplierName"].ToString();
            supplier.Address = dt.Rows[0]["Address"].ToString();
            supplier.Email = dt.Rows[0]["SupplierEmail"].ToString();
            supplier.PaymentTerms = new ViewPaymentTerms().retrieveData<PaymentTerms>().Find(pt => pt.Id == Convert.ToInt32(dt.Rows[0]["PaymentTermsID"]));
            return supplier;

        }

        public int GetLatestSupplierID()
        {

            database.Query = "SELECT MAX(SupplierID) FROM Supplier";
            var dt = database.Retrieved();
            return Convert.ToInt32(dt.Rows[0][0]);

        }
        private PaymentTerms _getSupplierPaymentTerms(int id)
        {
            var paymentTerms = new PaymentTerms();
            database.Query = $"SELECT * FROM PaymentTerms WHERE PaymentTermsID='{id}'";
            var res = database.Retrieved();
            paymentTerms.Id = Convert.ToInt32(res.Rows[0]["PaymentTermsID"].ToString());
            paymentTerms.PaymentTermName = res.Rows[0]["PaymentName"].ToString();
            paymentTerms.Discount = Convert.ToInt32(res.Rows[0]["Discount"].ToString());
            int validity = Convert.ToInt32(res.Rows[0]["Validity"].ToString().Length == 0 ? "0" : res.Rows[0]["Validity"].ToString());
            paymentTerms.DiscountValidity = validity;

            return paymentTerms;

        }

    }
}
