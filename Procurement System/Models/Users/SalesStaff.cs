using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using Procurement_System.Services.ItemAssets;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Procurement_System.Models.Users
{
    public class SalesStaff : EmployeeModel, ICreateSession,
        IDirectPOAction, IQuotationAction, IPurchaseOrderAction, IGoodsReceiptAction, IDGoodsReceiptAction
    {

        public SalesStaff(EmployeeModel info)
        {

            FirstName = info.FirstName;
            MiddleName = info.MiddleName;
            LastName = info.LastName;
            Gender = info.Gender;
            setEmployeeID(info.getEmployeeID());
            setEmployeeType(info.getEmployeeType());

        }

        public void CreatePO(QuotationPurchaseOrder selectedQuote)
        {

            instance.Query = $"INSERT INTO AccountsPayable VALUES ('0', '0', '{selectedQuote.SelectedQuotation.SelectedSupplier.SupplierID}');";
            instance.Add();
            instance.Query = $"SELECT TOP 1 AccountPayableID FROM AccountsPayable ORDER BY AccountPayableID DESC;";
            var id = instance.Retrieved().Rows[0][0].ToString();
            instance.Query = $"INSERT INTO QuotationPurchaseOrder VALUES " +
                $"('{selectedQuote.Employee.getEmployeeID()}', '{selectedQuote.CreatedDate}', " +
                $"'{selectedQuote.Remarks}','{selectedQuote.PurchaseOrderStatus}', " +
                $"'{selectedQuote.SelectedQuotation.SelectedSupplier.SupplierID}', " +
                $"'{selectedQuote.SelectedQuotation.Quotation.QuotationID}', '{id}');";
            instance.Add();
            instance.Query = $"UPDATE RequestForQuotation SET Status='PO Created' WHERE QuotationID='{selectedQuote.SelectedQuotation.Quotation.QuotationID}'";
            instance.Update();


            foreach (var item in selectedQuote.SelectedQuotation.Items)
            {

                instance.Query = $"UPDATE QuotationItems SET ItemName = '{item.ItemName}' WHERE QuotationItemID = {item.QuotationItemID} AND ItemName = '{item.ItemName}'";
                instance.Update();

                instance.Query = $"UPDATE QuotationItems SET Quantity = {item.Quantity} WHERE QuotationItemID = {item.QuotationItemID} AND ItemName = '{item.ItemName}'";
                instance.Update();

                instance.Query = $"UPDATE QuotationItems SET Color = '{item.Color}' WHERE QuotationItemID = {item.QuotationItemID} AND ItemName = '{item.ItemName}'";
                instance.Update();

            }



        }

        public void CreateQuotation(Quotation quote)
        {
            instance.Query = $"INSERT INTO RequestForQuotation VALUES ('{quote.Employee.getEmployeeID()}'," +
                                        $" '{quote.Status}', '{quote.CreatedDate}', '{quote.Remarks}', '{quote.ExpirationDate}')";
            instance.Add();
            instance.Query = $"SELECT TOP 1 QuotationID FROM RequestForQuotation ORDER BY QuotationID DESC";
            int quoteID = Convert.ToInt32(instance.Retrieved().Rows[0][0]);
            foreach (var supplier in quote.Suppliers)
            {
                instance.Query = $"INSERT INTO RFQSupplierDetails VALUES ({quoteID}, {supplier.SupplierID}, {0})";
                instance.Add();
            }

            foreach (var item in quote.Items)
            {
                instance.Query = $"INSERT INTO QuotationItems VALUES ('{item.ItemName}', '{item.Color}', '{item.Quantity}', '{quoteID}')";
                instance.Add();
            }
        }

        public void DeleteItemQuotation(List<QuotationItem> list, int quoteID)
        {
            foreach (var item in list)
            {
                instance.Query = $"DELETE FROM QuotationItems WHERE QuotationItemID = '{item.QuotationItemID}' AND QuotationID = '{quoteID}'";
                instance.Delete();
            }
        }

        public void DeletePO(QuotationPurchaseOrder selectedPO)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuotation(Quotation quote)
        {
            instance.Query = $"DELETE FROM RequestForQuotation WHERE QuotationID = '{quote.QuotationID}'";
            instance.Delete();
        }

        public void DeleteSupplierQuotation(List<SupplierModel> list, int quoteID)
        {
            foreach (var supp in list)
            {
                instance.Query = $"DELETE FROM RFQSupplierDetails WHERE SupplierID = {supp.SupplierID} AND QuotationID='{quoteID}'";
                instance.Delete();
            }
        }

        public Form StartSession()
        {
            //Return your created form for the admin window here.
            return new Forms.ParentForm(this);
            throw new NotImplementedException("Window is not created. Please Create the window for SalesStaff");
        }

        public void UpdateQuotation(Quotation quote)
        {
            instance.Query = $"UPDATE RequestForQuotation SET Status = '{quote.Status}' WHERE QuotationID = {quote.QuotationID}";
            instance.Update();

            instance.Query = $"UPDATE RequestForQuotation SET Remarks = '{quote.Remarks}' WHERE QuotationID = {quote.QuotationID}";
            instance.Update();

            foreach (var item in quote.Items)
            {

                instance.Query = $"UPDATE QuotationItems SET ItemName = '{item.ItemName}' WHERE QuotationID = {quote.QuotationID} AND QuotationItemID ='{item.QuotationItemID}'";
                instance.Update();

                instance.Query = $"UPDATE QuotationItems SET Quantity = {item.Quantity} WHERE QuotationID = {quote.QuotationID} AND QuotationItemID = '{item.QuotationItemID}'";
                instance.Update();

                instance.Query = $"UPDATE QuotationItems SET Color = '{item.Color}' WHERE QuotationID = {quote.QuotationID} AND QuotationItemID = '{item.QuotationItemID}'";
                instance.Update();

            }

        }

        public void UpdateQuotationPrices(List<QuotationItem> list, int quoteID)
        {

            list.ForEach((e) =>
                        {
                            if (e.UnitPrice > 0)
                            {
                                if (!new ViewQuotations().CheckQuoteSupplierPrice(e.SupplierProvider.SupplierID, e.QuotationItemID))
                                {
                                    instance.Query = $"INSERT INTO QPOItemSupplier VALUES ('{e.QuotationItemID}', " +
                                    $"'{e.SupplierProvider.SupplierID}', '{e.UnitPrice}')";
                                    instance.Add();
                                    instance.Query = $"UPDATE RFQSupplierDetails SET QuoteReceived='1' WHERE QuotationID = '{quoteID}' AND SupplierID = {e.SupplierProvider.SupplierID}";
                                    instance.Update();
                                }
                                //check if item is exists
                                int itemID = new ViewItemProducts().GetGenericItemNames().Find(x => x.ItemName.ToLower() == e.ItemName.ToLower()) == null ? 0 :
                                new ViewItemProducts().GetGenericItemNames().Find(x => x.ItemName.ToLower() == e.ItemName.ToLower()).ItemID;
                                if (itemID == 0)
                                {
                                    AddItemFromQuotation(e);
                                    itemID = new ViewItemProducts().GetLatestItemID();
                                }
                                else
                                {
                                    //if not then find the id of the itename
                                    itemID = new ViewItemProducts().GetGenericItemNames().Find(i => i.ItemName.ToLower() == e.ItemName.ToLower()).ItemID;
                                }

                                //check if supplier has already has the item record in the SupplierItemDetails
                                var supp = new ViewItemProducts().retrieveData<Product>().Find(p => p.ItemSupplier.SupplierID == e.SupplierProvider.SupplierID && p.ItemName.ToLower() == e.ItemName.ToLower());

                                if (supp == null)
                                {

                                    instance.Query = $"INSERT INTO SupplierItemDetails VALUES ('{itemID}', '{e.SupplierProvider.SupplierID}', '{e.Color}'," +
                                    $"'{e.UnitPrice}', '0', 'No Description Provided', '0', '0', '{e.QuotationItemID}');";
                                    instance.Add();
                                }


                            }

                        });
        }

        public void DeletePOItems(List<QuotationItem> list, int supplierID)
        {
            foreach (var item in list)
            {
                instance.Query = $"DELETE QI FROM QuotationItems QI INNER JOIN QPOItemSupplier QPOIS ON QI.QuotationItemID = QPOIS.QuotationItemID " +
                    $"WHERE QPOIS.SupplierID='{supplierID}' AND QI.QuotationItemID='{item.QuotationItemID}'";
                instance.Delete();

            }
        }

        public void CreateGoodsReceipt(GoodsReceiptPO GRPO)
        {
            instance.Query = $"INSERT INTO GRPO VALUES ('{GRPO.QuotationPurchaseOrder.PurchaseOrderID}', " +
                            $"'{Convert.ToInt16(GRPO.IsPartial)}', '{GRPO.TotalPrice}', '{GRPO.Employee.getEmployeeID()}'," +
                            $"'{GRPO.ReceivedDate}');";
            instance.Add();

            instance.Query = $"SELECT TOP 1 GoodsReceiptID FROM GRPO ORDER BY GoodsReceiptID DESC;";
            var grpoID = instance.Retrieved().Rows[0][0].ToString();

            foreach (var list in GRPO.ReceivedItems)
            {
                instance.Query = $"INSERT INTO GRPOItem VALUES ('{list.QuotationItem.ItemName}', '{list.QuotationItem.Color}', '{list.QuotationItem.Quantity}', " +
                 $"'{list.DeliveredQuantity}', '{list.Comments}', '{grpoID}');";
                instance.Add();

                // Update query of the quantity of the item in the database
                instance.Query = $"UPDATE SII SET SII.Stocks+={list.DeliveredQuantity} " +
                        $"FROM SupplierItemDetails SII INNER JOIN SupplierItem SI ON SII.ItemID = SI.ItemID " +
                        $"WHERE SI.ItemName='{list.QuotationItem.ItemName}' AND SII.Color='{list.QuotationItem.Color}' AND SII.SupplierID = '{GRPO.QuotationPurchaseOrder.SelectedQuotation.SelectedSupplier.SupplierID}';";
                instance.Update();

            }
            instance.Query = $"UPDATE AccountsPayable SET TotalAmount+={GRPO.TotalPrice} WHERE AccountPayableID='{GRPO.QuotationPurchaseOrder.AP.AccountPayableID}'";
            instance.Update();
        }

        public void UpdateGoodsReceipt(GoodsReceiptPO GRPO)
        {
            instance.Query = $"UPDATE GRPO SET IsPartial='{Convert.ToInt16(GRPO.IsPartial)}', TotalPrice+={GRPO.TotalPrice}, '{GRPO.Employee.getEmployeeID()}', " +
                            $"ReceivedDate='{GRPO.ReceivedDate}' WHERE PurchaseOrderID='{GRPO.QuotationPurchaseOrder.PurchaseOrderID}'";
            instance.Add();

            foreach (var list in GRPO.ReceivedItems)
            {
                instance.Query = $"INSERT INTO GRPOItem VALUES ('{list.QuotationItem.ItemName}', '{list.QuotationItem.Quantity}', " +
                    $"'{list.DeliveredQuantity}', '{list.Comments}', '{GRPO.GoodsReceiptID}');";
                instance.Add();
            }
            instance.Query = $"UPDATE AccountsPayable SET TotalAmount+={GRPO.TotalPrice} WHERE AccountPayableID='{GRPO.QuotationPurchaseOrder.AP.AccountPayableID}'";
            instance.Update();


        }

        public void DeleteGoodsReceipt(GoodsReceiptPO GRPO)
        {
            throw new NotImplementedException();
        }

        public void UpdatePO(QuotationPurchaseOrder purchaseOrder)
        {
            instance.Query = $"UPDATE QuotationPurchaseOrder SET PurchaseOrderStatus='{purchaseOrder.PurchaseOrderStatus}' ," +
                            $"Remarks='{purchaseOrder.Remarks}' WHERE PurchaseOrderID='{purchaseOrder.PurchaseOrderID}'";
            instance.Update();
        }

        public void AddItemFromQuotation(QuotationItem item)
        {
            instance.Query = $"INSERT INTO SupplierItem VALUES ('{item.ItemName}', '{item.ItemCategory.CategoryID}', '{item.ItemType.ItemTypeID}', '0')";
            instance.Add();
        }

        public void CreatePO(DirectPurchaseOrder po)
        {
            //fetch the id of the last inserted record
            instance.Query = $"INSERT INTO DirectPurchaseOrder VALUES ('{po.Employee.getEmployeeID()}', " +
                $"'{po.CreatedDate}', '{po.Remarks}');";
            instance.Add();
            var poID = new ViewDirectPO().GetLatestPOID();
            po.ID = poID;

            po.DirectPurchaseOrderDetail.ForEach(dpo =>
            {

                instance.Query = $"INSERT INTO AccountsPayable VALUES ('0', '0', '{dpo.Supplier.SupplierID}');";
                instance.Add();

                instance.Query = $"SELECT TOP 1 AccountPayableID FROM AccountsPayable ORDER BY AccountPayableID DESC;";
                var id = instance.Retrieved().Rows[0][0].ToString();
                instance.Query = $"INSERT INTO DirectPurchaseOrderDetails VALUES ('{po.ID}', '{dpo.Supplier.SupplierID}', " +
                $"'{dpo.PurchaseOrderStatus}','{id}');";
                instance.Add();
                var poDiD = new ViewDirectPO().GetLatestPODetailsID(po.ID);
                dpo.ID = poDiD;
                dpo.Items.ForEach(item =>
                {
                    instance.Query = $"INSERT INTO DirectPurchaseOrderItem VALUES ('{item.ProductID}', '{item.Quantity}', " +
            $"'{dpo.ID}');";
                    instance.Add();

                });

            });


        }

        public void DeletePO(DirectPurchaseOrder selectedPO)
        {
            throw new NotImplementedException();
        }

        public void CreateGoodsReceipt(DGoodsReceipt GRPO, AccountPayable AP)
        {
            instance.Query = $"INSERT INTO DGRPO VALUES ('{GRPO.DirectPOID}', '{GRPO.IsPartial}', '{GRPO.TotalPrice}', '{GRPO.Employee.getEmployeeID()}', '{GRPO.ReceivedDate}');";
            instance.Add();
            //fetch the latest DGRPO
            var dgrpoID = new ViewDGRPO().GetLatestDGRPOID();
            GRPO.ReceivedItems.ForEach(dgItem =>
            {

                dgItem.GoodsReceiptItemID = dgrpoID;
                instance.Query = $"INSERT INTO DirectGRPOItem VALUES (" +
                $"'{dgItem.Product.ItemName}', '{dgItem.Product.Color}', '{dgItem.Product.Quantity}', " +
                $"'{dgItem.DeliveredQuantity}', '{dgItem.Comments}', '{dgrpoID}')";
                instance.Add();
                instance.Query = $"UPDATE SII SET SII.Stocks+='{dgItem.DeliveredQuantity}' FROM " +
                $"SupplierItemDetails SII WHERE SII.ProductID='{dgItem.Product.ItemID}' AND " +
                $"SII.SupplierID='{dgItem.Product.ItemSupplier.SupplierID}'";
                instance.Update();
            });

            instance.Query = $"UPDATE AccountsPayable SET TotalAmount+={GRPO.TotalPrice} WHERE AccountPayableID='{AP.AccountPayableID}'";
            instance.Update();
        }
    }

}

