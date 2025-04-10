using Procurement_System.Services;
using Procurement_System.Services.ItemAssets;
using System;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class CreatePaymentTerms : Form
    {
        public CreatePaymentTerms()
        {
            InitializeComponent();
        }

        private void CreatePaymentTerms_Load(object sender, EventArgs e)
        {

        }

        private bool _checkInput()
        {
            try
            {

                if (txtPTName.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a payment term name");
                    return false;
                }
                if (txtDiscount.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a discount");
                    return false;
                }
                if (txtDueDate.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a due date");
                    return false;
                }
                if (txtDiscountValidity.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a validity");
                    return false;
                }
                var discount = Convert.ToDouble(txtDiscount.Text);
                if (discount < 0)
                {
                    MessageBox.Show("Invalid Discount");
                    return false;
                }

                if(txtDiscount.Text.Contains("E") || txtDiscount.Text.Contains("e") 
                    || txtDiscountValidity.Text.Contains("E") 
                    || txtDiscountValidity.Text.Contains("e") 
                    || txtDueDate.Text.Contains("E") || txtDueDate.Text.Contains("e"))
                {
                    throw new Exception();
                }

                var discountValidity = Convert.ToInt32(txtDiscountValidity.Text);
                if (discountValidity < 0)
                {

                    MessageBox.Show("Invalid Discount Validity");
                    return false;

                }

                var dueDate = Convert.ToInt32(txtDueDate.Text);
                if(dueDate < 0)
                {
                    MessageBox.Show("Invalid Due date");
                    return false;
                }

                return true;


            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
                return false;
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!_checkInput()) return;
            var isExist = new ViewPaymentTerms().retrieveData<PaymentTerms>().Find(pt =>
                pt.PaymentTermName.ToLower() == txtPTName.Text.ToLower().Trim()
                && pt.Archived == 0
           );

            if(isExist != null)
            {
                MessageBox.Show("Item Already Exist.");
            }else
            {

                var paymentTerm = new PaymentTerms()
                {
                    PaymentTermName = txtPTName.Text.Trim(),
                    Discount = Convert.ToDouble(txtDiscount.Text.Trim()),
                    DiscountValidity = Convert.ToInt32(txtDiscountValidity.Text.Trim()),
                    DueDate = Convert.ToInt32(txtDueDate.Text.Trim())
                };
                var query = $"INSERT INTO PaymentTerms VALUES ('{paymentTerm.PaymentTermName}'," +
                    $"'{paymentTerm.Discount}', '{paymentTerm.DiscountValidity}', '{paymentTerm.DueDate}', '0')";
                new Helper().AddUpdDelData(query);
                MessageBox.Show("Payment Term Created");
                Close();

            }
        }
    }
}
