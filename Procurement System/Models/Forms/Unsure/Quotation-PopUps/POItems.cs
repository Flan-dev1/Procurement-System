using Procurement_System.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procurement_System.Models.Forms.Unsure.Quotation_PopUps
{
    public partial class POItems : Form
    {
        private string _query;
        private DataTable _poItemsTable;
        private Helper _dbHelper;
        public POItems()
        {
            InitializeComponent();
            _dbHelper = new Helper();
        }

        private void POItems_Load(object sender, EventArgs e)
        {
            _query = "";
        }
    }
}
