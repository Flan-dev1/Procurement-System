using Procurement_System.Models.SystemActions;
using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.UpdateMasterData
{
    public partial class UpdateCategory : Form
    {

        private BackgroundWorker _worker;
        private List<ItemCategory> _categories, _searchCategories;
        private ItemCategory _selectedCategory;
        public UpdateCategory()
        {
            InitializeComponent();
            _initializeWorkers();
            _worker.RunWorkerAsync();
            timer1.Start();
        }

        private void _initializeWorkers()
        {
            _worker = new BackgroundWorker();
            _worker.DoWork += (s, e) =>
            {
                _categories = new ViewCategories().retrieveData<ItemCategory>();
                _categories = _categories.FindAll(x => x.Archived == false);
            };

            _worker.RunWorkerCompleted += (s, e) =>
            {
                _loadTable();
            };
        }

        private void _loadTable(List<ItemCategory> list = null)
        {
            BindingList<ItemCategory> bindingList;
            if (list == null)
                bindingList = new BindingList<ItemCategory>(_categories);
            else
                bindingList = new BindingList<ItemCategory>(list);
            dgvrCategoryList.DataSource = bindingList;
            dgvrCategoryList.Columns.Remove("Archived");
                
        }

        private void dgvrCategoryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Get databount item
                _selectedCategory = (ItemCategory)dgvrCategoryList.CurrentRow.DataBoundItem;
                lblCategoryID.Text = _selectedCategory.CategoryID.ToString();
                txtCategoryName.Text = _selectedCategory.CategoryName;
            }

        }

        private void _message(bool isSuccess = true)
        {
            if (isSuccess)
            {
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
            }

            lblMessage.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                lblMessage.Text = "Name cannot be empty";
                _message(false);
            }
            else
            {
                if (new ViewCategories().retrieveData<ItemCategory>().Find(c => c.CategoryName.ToLower() == txtCategoryName.Text.ToLower()) != null &&
                    ((Button)sender).Text != "Delete")
                {
                    lblMessage.Text = "Category Already exist";
                    _message(false);
                    return;
                }
                switch (((Button)sender).Text)
                {
                    case "Add":
                        var newCategory = new ItemCategory();
                        newCategory.CategoryName = txtCategoryName.Text.Trim();
                        new CategoryUpdater().AddCategory(newCategory);
                        lblMessage.Text = "Category Added";
                        break;
                    case "Update":
                        if (_selectedCategory != null)
                        {
                            _selectedCategory.CategoryName = txtCategoryName.Text.Trim();
                            new CategoryUpdater().UpdateCategory(_selectedCategory);
                            lblMessage.Text = "Category Updated";
                        }
                        else
                        {
                            lblMessage.Text = "Please select a category to update";
                            _message(false);
                            return;
                        }
                        break;
                    case "Delete":
                        if (_selectedCategory != null)
                        {
                            _selectedCategory.Archived = true;
                            new CategoryUpdater().UpdateCategory(_selectedCategory);
                            lblMessage.Text = "Category Updated";
                        }
                        else
                        {
                            lblMessage.Text = "Please select a category to delete";
                            _message(false);
                            return;
                        }
                        break;
                        
                }

                _worker.RunWorkerAsync();

            }
        }

        private void txtCategoryName_KeyUp(object sender, KeyEventArgs e)
        { lblMessage.Visible = false;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            var input = txtSearch.Text.ToLower().Trim();
            //search
            if(input != string.Empty)
            {

                _searchCategories = _categories.FindAll(c => c.CategoryName.ToLower().Contains(input) || 
                c.CategoryID.ToString().Contains(input)).ToList();
                _loadTable(_searchCategories);
            }else
            {
                _worker.RunWorkerAsync();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void dgvrCategoryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

    }
}
