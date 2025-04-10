using Procurement_System.Services;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms
{
    public partial class ParentForm : Form
    {

        //Fields
        private Button currentButton;
        private EmployeeModel user;
        private Boolean quotationsCollapsed = true;
        private Boolean POCollapsed = true;
        private Boolean updateMasterCollapsed = true;
        private Boolean reportsCollapsed = true;
        private Boolean controlEntered = false;
        private Form activeForm;
        private int enabledControl;
        private Helper _dbHelper;

        //Constructor
        public ParentForm(EmployeeModel user)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            OpenChildForm(new Reports.Overview(), btnView);
            this.user = user;
            _dbHelper = new Helper();
            updateUser();
        }

        //Side Buttons and Main
        private void btnQuotations_Click(object sender, EventArgs e)
        {
            enabledControl = 0;
            foreach (Control comp in pnlQuotations.Controls)
            {
                if (comp.Enabled == true)
                {
                    Console.WriteLine(comp.Name);
                    enabledControl++;
                    Console.WriteLine(enabledControl);
                }
            }
            tmrQuotations.Start();
        }
        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            enabledControl = 0;
            foreach (Control comp in pnlPurchaseOrder.Controls)
            {
                if (comp.Enabled == true)
                {
                    Console.WriteLine(comp.Name);
                    enabledControl++;
                    Console.WriteLine(enabledControl);
                }
            }
            tmrPO.Start();
        }
        private void btnUpdateMasterData_Click(object sender, EventArgs e)
        {
            enabledControl = 0;
            foreach (Control comp in pnlUpdateMasterData.Controls)
            {
                if (comp.Enabled == true)
                {
                    Console.WriteLine(comp.Name);
                    enabledControl++;
                    Console.WriteLine(enabledControl);
                }
            }
            tmrUpdateMasterData.Start();
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            enabledControl = 0;
            foreach (Control comp in pnlReports.Controls)
            {
                if (comp.Enabled == true)
                {
                    Console.WriteLine(comp.Name);
                    enabledControl++;
                    Console.WriteLine(enabledControl);
                }
            }
            tmrReports.Start();
        }

        private void tmrQuotations_Tick(object sender, EventArgs e)
        {
            if (quotationsCollapsed)
            {
                pnlQuotations.Height += 25;
                if (pnlQuotations.Height >= 45 * enabledControl)
                {
                    tmrQuotations.Stop();
                    pnlQuotations.Height = 45 * enabledControl;
                    quotationsCollapsed = false;
                }
            }
            else
            {
                pnlQuotations.Height -= 25;
                if (pnlQuotations.Height <= 45)
                {
                    tmrQuotations.Stop();
                    pnlQuotations.Height = 45;
                    quotationsCollapsed = true;
                }
            }
        }
        private void tmrPO_Tick(object sender, EventArgs e)
        {
            if (POCollapsed)
            {
                pnlPurchaseOrder.Height += 25;
                if (pnlPurchaseOrder.Height >= 45 * enabledControl)
                {
                    tmrPO.Stop();
                    pnlPurchaseOrder.Height = 45 * enabledControl;
                    POCollapsed = false;
                }
            }
            else
            {
                pnlPurchaseOrder.Height -= 25;
                if (pnlPurchaseOrder.Height <= 45)
                {
                    tmrPO.Stop();
                    pnlPurchaseOrder.Height = 45;
                    POCollapsed = true;
                }
            }
        }
        private void tmrUpdateMasterData_Tick(object sender, EventArgs e)
        {
            if (updateMasterCollapsed)
            {
                pnlUpdateMasterData.Height += 25;
                if (pnlUpdateMasterData.Height >= 45 * enabledControl)
                {
                    tmrUpdateMasterData.Stop();
                    pnlUpdateMasterData.Height = 45 * enabledControl;
                    updateMasterCollapsed = false;
                }
            }
            else
            {
                pnlUpdateMasterData.Height -= 25;
                if (pnlUpdateMasterData.Height <= 45)
                {
                    tmrUpdateMasterData.Stop();
                    pnlUpdateMasterData.Height = 45;
                    updateMasterCollapsed = true;
                }
            }
        }
        private void tmrReports_Tick(object sender, EventArgs e)
        {
            if (reportsCollapsed)
            {
                pnlReports.Height += 25;
                if (pnlReports.Height >= 45 * enabledControl)
                {
                    tmrReports.Stop();
                    pnlReports.Height = 45 * enabledControl;
                    reportsCollapsed = false;
                }
            }
            else
            {
                pnlReports.Height -= 25;
                if (pnlReports.Height <= 45)
                {
                    tmrReports.Stop();
                    pnlReports.Height = 45;
                    reportsCollapsed = true;
                }
            }
        }


        //Child Forms
        private void OpenChildForm(Form childForm, object sender)
        {
            if (currentButton == (Button)sender)
            {
                return;
            }

            if (controlEntered)
            {
                if (MessageBox.Show("Any unsaved work will be lost", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                else
                {
                    controlEntered = false;
                }
            }

            if (activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(sender);
            activeForm = childForm;
            lblTitle.Text = childForm.Text;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.SizeGripStyle = SizeGripStyle.Auto;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            Console.WriteLine(currentButton);
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = ColorTranslator.FromHtml("#9899A7");
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pnlSideBar.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ColorTranslator.FromHtml("#4D4E5E");
                }
            }
            foreach (Control previousBtn in pnlQuotations.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ColorTranslator.FromHtml("#4D4E5E");
                }
            }
            foreach (Control previousBtn in pnlPurchaseOrder.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ColorTranslator.FromHtml("#4D4E5E");
                }
            }
            foreach (Control previousBtn in pnlUpdateMasterData.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ColorTranslator.FromHtml("#4D4E5E");
                }
            }
            foreach (Control previousBtn in pnlReports.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = ColorTranslator.FromHtml("#4D4E5E");
                }
            }
        }

        //Quotation Buttons
        private void btnView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookKeeperMenus.ViewQuotation(user), sender);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookKeeperMenus.CreateQuotation(user), sender);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookKeeperMenus.UpdateQuotation(user), sender);
        }

        //Purchase Order Buttons
        private void btnViewPO_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseOrders.ViewPOList(user), sender);
        }
        private void btnCreateQuotePO_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseOrders.CreatePO(user), sender);
        }
        private void btnCreateGRPO_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseOrders.CreateGRPO(user), sender);
        }


        //Update Master Data Buttons
        private void btnUpdateItemData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateMasterData.UpdateItemData(user), sender);
        }
        private void btnUpdateSupplierData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateMasterData.UpdateSupplierData(user), sender);
        }
        private void btnUpdatePaymentTerms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateMasterData.UpdatePaymentTerms(), sender);
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateMasterData.UpdateCategory(), sender);
        }
        private void btnUpdateWalletBalance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateMasterData.UpdateWalletBalance(), sender);
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (user.getEmployeeType().getType() == "Admin Manager")
            {
                OpenChildForm(new UpdateMasterData.UpdateEmployee(user), sender);
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature");
            }
        }

        //Reports
        private void btnOverview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.Overview(), sender); ;
        }
        private void btnNetDiscounts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Reports.NetDiscounts(), sender);
        }

        //User Panel
        private void updateUser()
        {
            lblUser.Text = user.FirstName + " " + user.LastName;
            Text = "Procurement System - " + user.getEmployeeType().getType();

            switch (user.getEmployeeType().getType())
            {
                case "Book Keeper":
                    break;
                case "Sales Staff":
                    break;
                case "Admin Manager":
                    btnUpdateEmployee.Enabled = true;
                    btnUpdateWalletBalance.Enabled = true;
                    btnUpdateCategory.Enabled = true;
                    btnUpdatePaymentTerms.Enabled = true;
                    btnUpdateSupplierData.Enabled = true;
                    break;
            }
        }
        private void Book_Keeper_Resize(object sender, EventArgs e)
        {
            activeForm.Size = pnlMain.Size;
        }
        private void pnlMain_Enter(object sender, EventArgs e)
        {
            controlEntered = true;
        }

        private void btnCompareQuote_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BookKeeperMenus.CompareQuotation(user), sender);
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                var userID = new ViewEmployeesInfo().retrieveData<EmployeeModel>().Where(x => x.getEmployeeID() == user.
                getEmployeeID()).Select(x => x.getEmployeeID()).FirstOrDefault();

                var query = $"UPDATE AccountCredential SET LoggedIn = '0' WHERE UserID=(SELECT UserID FROM Employee WHERE EmployeeID='{userID}')";
                _dbHelper.AddUpdDelData(query);
            }
        }

        private void btnPayAP_Click(object sender, EventArgs e)
        {

            OpenChildForm(new PurchaseOrders.AccountsPayable(user), sender);

        }


    }
}
