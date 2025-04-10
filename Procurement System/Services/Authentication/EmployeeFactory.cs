using Procurement_System.Models;
using Procurement_System.Models.SystemActions;
using Procurement_System.Models.Users;

namespace Procurement_System.Services.Authentication
{
    public class EmployeeFactory
    {

        public static IQuotationAction QuotationAction(EmployeeModel account)
        {
            var empType = account.getEmployeeType().getType();

            switch (empType)
            {
                case "Book Keeper":
                    return new BookKeeper(account);
                case "Sales Staff":
                    return new SalesStaff(account);
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }
        }

        public static IGoodsReceiptAction GoodsReceiptAction(EmployeeModel account)
        {

            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                case "Sales Staff":
                    return new SalesStaff(account);
                case "Admin Manager":
                    return new AdminManager(account);
                case "Book Keeper":
                    return new BookKeeper(account);
                default:
                    return null;
            }

        }

        public static IPurchaseOrderAction PurchaseOrderAction(EmployeeModel account)
        {

            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                case "Book Keeper":
                    return new BookKeeper(account);
                case "Sales Staff":
                    return new SalesStaff(account);
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }

        }

        public static IPayInvoice PayInvoiceAction(EmployeeModel account)
        {

            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }

        }

        public static IDirectPOAction DirectPOAction(EmployeeModel account)
        {

            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                case "Book Keeper":
                    return new BookKeeper(account);
                case "Sales Staff":
                    return new SalesStaff(account);
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }

        }
        public static IUpdateSupplier UpdateSupplierAction(EmployeeModel account)
        {

            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                //case "Book Keeper":
                //    return new BookKeeper(account);
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }

        }

        public static IDGoodsReceiptAction UpdateDGoodsReceipt(EmployeeModel account)
        {
            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                case "Book Keeper":
                    return new BookKeeper(account);
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }


        }

        public static IUpdateProduct UpdateProductAction(EmployeeModel account)
        {

            var empType = account.getEmployeeType().getType();
            switch (empType)
            {
                //case "Book Keeper":
                //    return new BookKeeper(account);
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }

        }
        public static IUpdateEmployee EmployeeAction(EmployeeModel account)
        {
            var empType = account.getEmployeeType().getType();

            switch (empType)
            {
                case "Admin Manager":
                    return new AdminManager(account);
                default:
                    return null;
            }
        }
    }
}
