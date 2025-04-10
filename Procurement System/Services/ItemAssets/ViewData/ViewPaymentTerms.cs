using DatabaseConnection;
using Procurement_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Procurement_System.Services.ItemAssets
{
    public class ViewPaymentTerms : ViewData
    {
        public override List<T> retrieveData<T>()
        {
            var list = new List<T>();
            database.Query = $"SELECT * FROM PaymentTerms";
            var res = database.Retrieved();
            foreach (DataRow row in res.Rows)
            {
                var paymentTerms = new PaymentTerms();
                paymentTerms.Id = Convert.ToInt32(row["PaymentTermsID"].ToString());
                paymentTerms.PaymentTermName = row["PaymentName"].ToString();
                paymentTerms.Discount = Convert.ToInt32(row["Discount"].ToString());
                int validity = Convert.ToInt32(row["DiscountValidity"].ToString());
                paymentTerms.DiscountValidity = validity;
                int dueDate = Convert.ToInt32(row["Validity"].ToString().Length == 0 ? "0" : row["Validity"].ToString());
                paymentTerms.DueDate = dueDate;
                var archived = Convert.ToBoolean(row["Archived"].ToString());
                paymentTerms.Archived = Convert.ToInt32(archived);
                list.Add(paymentTerms as T);
            }

            return list;
        }
    }
}
