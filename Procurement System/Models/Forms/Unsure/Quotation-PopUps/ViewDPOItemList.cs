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
    public partial class ViewDPOItemList : Form
    {
        private int _id;
        public ViewDPOItemList(int dpoID)
        {
            InitializeComponent();
            _id = dpoID;
        }

        private void ViewDPOItemList_Load(object sender, EventArgs e)
        {

            var query = $"SELECT * FROM DPOIDetails WHERE DirectPODetailsID='{_id}';";
            var table = new Helper().GetData(query);
            dgvItemList.DataSource = table;

        }
    }
}
