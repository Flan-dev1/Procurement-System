using Procurement_System.Models.Forms.BookKeeperMenus.Quotation_PopUps;
using Procurement_System.Models.ProcurementDocuments;
using Procurement_System.Models.SystemActions;
using Procurement_System.Services.Authentication;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.BookKeeperMenus
{
    public partial class CreateQuotation : Form
    {
        private List<QuotationItem> items;
        private List<SupplierModel> suppliers;
        private IQuotationAction quotationAction;
        private delegate void _callBack(string message, bool success = false);
        private _callBack callBack;
        private readonly EmployeeModel model;

        public CreateQuotation(EmployeeModel userAction)
        {
            model = userAction;
            InitializeComponent();
            _loadOnStartUp();
        }

        private void _loadOnStartUp()
        {

            callBack = new _callBack(_messageCallback);
            lblPostingDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblDue.Text = DateTime.Now.AddDays(7).ToString("MM/dd/yyyy");
            items = new List<QuotationItem>();
            suppliers = new List<SupplierModel>();
            dgvrfqItemList.Columns.Add("ItemName", "Item Name");
            dgvrfqItemList.Columns.Add("Color", "Color");
            dgvrfqItemList.Columns.Add("Quantity", "Quantity");
            dgvrfqItemList.Rows.Clear();

            dgvrfqSupplierList.Columns.Add("SupplierName", "Supplier Name");
            dgvrfqSupplierList.Columns.Add("SupplierAddress", "Address");
            dgvrfqSupplierList.Columns.Add("SupplierEmailAddress", "Email Address");

        }


        private void processInput()
        {
            {
                if (string.IsNullOrEmpty(txtItemName.Text) || string.IsNullOrEmpty(txtQuantity.Text))
                {
                    callBack("Please Fill all the fields.", false);
                }
                else
                {
                    try
                    {
                        int quantity = Convert.ToInt32(txtQuantity.Text);

                        if (quantity <= 0)
                            throw new Exception();
                        var quoteItem = new QuotationItem
                        {
                            ItemName = txtItemName.Text.Trim(),
                            Color = txtColor.Text.Trim().Length == 0 ? "No Color." : txtColor.Text.Trim(),
                            Quantity = quantity
                        };
                        //find if item already exists based on its name and color, if the quantity is not the same, update the quantity
                        var item = items.Find(x => x.ItemName.ToLower() == quoteItem.ItemName.ToLower()
                        && x.Color.ToLower() == quoteItem.Color.ToLower());
                        if (item != null)
                        {
                            item.Quantity += quoteItem.Quantity;
                            // update the quantity in items
                            items[items.IndexOf(item)] = item;
                        }
                        else
                        {
                            items.Add(quoteItem);
                        }
                        callBack("Item Added Successfully.", true);
                        _clearValues();
                        _updateQuoteItem();

                    }
                    catch (Exception)
                    {
                        callBack("Invalid quantity try again.");
                    }

                }
            }
        }

        private void _clearValues()
        {
            txtItemName.Text = "";
            txtColor.Text = "";
            txtQuantity.Text = "";
        }

        private void _updateSuppliers(List<SupplierModel> list = null)
        {
            dgvrfqSupplierList.Rows.Clear();

            if (list == null)
            {
                foreach (var supplier in suppliers)
                {
                    dgvrfqSupplierList.Rows.Add(supplier.SupplierName, supplier.Address, supplier.Email);
                }
            }
            else
            {
                foreach (var supplier in list)
                {
                    dgvrfqSupplierList.Rows.Add(supplier.SupplierName, supplier.Address, supplier.Email);
                }

            }


        }

        private void _updateQuoteItem(List<QuotationItem> list = null)
        {
            //iterate through the items and add them to the datagridview 
            dgvrfqItemList.Rows.Clear();
            if (list == null)
            {
                foreach (var item in items)
                {

                    dgvrfqItemList.Rows.Add(item.ItemName, item.Color, item.Quantity);
                }
            }
            else
            {
                foreach (var item in list)
                {

                    dgvrfqItemList.Rows.Add(item.ItemName, item.Color, item.Quantity);
                }
            }

        }

        private void _messageCallback(string message, bool isValid = false)
        {
            lblMessage.Text = message;
            if (isValid)
            {
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
            }

        }
        //Events
        private void btnAddSuppliers_Click(object sender, EventArgs e)
        {
            var showSupplierForm = new frmSupplierList(AddSupplier);
            showSupplierForm.ShowDialog();

        }

        public void AddSupplier(SupplierModel model)
        {
            if (suppliers.IndexOf(model) == -1)
            {
                suppliers.Add(model);
                dgvrfqSupplierList.Rows.Add(model.SupplierName, model.Address, model.Email);
            }

        }

        private void _resetValues()
        {
            dgvrfqItemList.Rows.Clear();
            dgvrfqSupplierList.Rows.Clear();
            txtRemarks.Text = "";
            _clearValues();

        }


        private void btnGenerateRFQ_Click(object sender, EventArgs e)
        {

            if (items.Count > 0 && suppliers.Count > 0)
            {
                if (MessageBox.Show("Do you want to generate this RFQ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var quote = new Quotation
                    {
                        Employee = model,
                        Items = items,
                        Suppliers = suppliers,
                        CreatedDate = DateTime.Now,
                        Remarks = txtRemarks.Text.Trim(),
                        ExpirationDate = DateTime.Now.AddDays(7),
                        Status = "Not Printed"
                    };
                    if (string.IsNullOrEmpty(quote.Remarks))
                        quote.Remarks = "No Description Provided.";
                    quotationAction = EmployeeFactory.QuotationAction(model);
                    quotationAction.CreateQuotation(quote);
                    MessageBox.Show("RFQ Generated Successfully.");
                    _resetValues();


                }
            }
            else
            {
                if (items.Count == 0)
                    callBack("Please enter any items before generating the RFQ");
                else
                    callBack("Please add suppliers before generating the RFQ");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            processInput();
        }


        private void txtSearchItem_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearchItem.Text.ToLower().Trim();
            //search
            if (input != "")
            {
                var list = items.Where(x => x.ItemName.ToLower().Contains(input)
                || x.Color.ToLower().Contains(input)
                || x.Quantity.ToString().Contains(input)).ToList();
                _updateQuoteItem(list);
            }
            else
            {
                _updateQuoteItem();
            }
        }

        private void txtSearchSupp_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearchSupp.Text.ToLower().Trim();
            //search
            if (input != "")
            {
                var list = suppliers.Where(x => x.SupplierName.ToLower().Contains(input)
                || x.Address.ToLower().Contains(input)
                || x.Email.ToString().Contains(input)).ToList();
                _updateSuppliers(list);
            }
            else
            {
                _updateSuppliers();
            }
        }

        private void dgvrfqItemList_KeyUp(object sender, KeyEventArgs e)
        {
            //check if the key is the delete key
            if (e.KeyCode == Keys.Delete)
            {
                //delete the selected rows and the list rows
                foreach (DataGridViewRow row in dgvrfqItemList.SelectedRows)
                {
                    var item = items.Find(x => x.ItemName.ToLower() == row.Cells[0].Value.ToString().ToLower() &&
                    x.Color.ToLower() == row.Cells[1].Value.ToString().ToLower() && x.Quantity == Convert.ToInt32(row.Cells[2].Value));
                    if (item != null)
                    {
                        items.Remove(item);
                        dgvrfqItemList.Rows.Remove(row);
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void dgvrfqSupplierList_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //delete the selected rows and the list rows
                foreach (DataGridViewRow row in dgvrfqSupplierList.SelectedRows)
                {
                    var supplier = suppliers.Find(x => x.SupplierName.ToLower() == row.Cells[0].Value.ToString().ToLower() &&
                    x.Address.ToLower() == row.Cells[1].Value.ToString().ToLower() && x.Email == row.Cells[2].Value.ToString());
                    if (supplier != null)
                    {
                        suppliers.Remove(supplier);
                        dgvrfqSupplierList.Rows.Remove(row);
                    }
                }
            }


        }
    }
}
