using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace productManagement.PL
{
    public partial class frm_customer_list : Form
    {
        BL.cls_customers cls = new BL.cls_customers();
        public frm_customer_list()
        {
            InitializeComponent();
            this.dgvCustomers.DataSource = cls.getAllCustomers();
            this.dgvCustomers.Columns[0].Visible = false;
            //this.dgvCustomers.Columns[5].Visible = false;
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dgvCustomers.DataSource = cls.getAllCustomers();
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
