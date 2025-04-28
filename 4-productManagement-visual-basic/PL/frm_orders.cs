using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace productManagement.PL
{
    public partial class frm_orders : Form
    {
        BL.cls_orders cls = new BL.cls_orders();
        DataTable dt = new DataTable();
        void createDataTable()
        {
            dt.Columns.Add("product id");
            dt.Columns.Add("product label");
            dt.Columns.Add("qte in stock");
            dt.Columns.Add("price");
            dt.Columns.Add("image_product");
            dt.Columns.Add("discount");
            dt.Columns.Add("money");
            dt.Columns.Add("total money");
            dgvProducts.DataSource = dt;
            /*DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "select product";
            btn.Text = "search";
            btn.UseColumnTextForButtonValue = true;//to show the text
            dgvProducts.Columns.Insert(0, btn);*/
        }
        void recognizeDGV()
        {
            this.dgvProducts.RowHeadersWidth = 94;
            /*  this.dgvProducts.Columns[0].Width = 144;
              this.dgvProducts.Columns[1].Width = 218;
              this.dgvProducts.Columns[2].Width = 169;
              this.dgvProducts.Columns[3].Width = 155;
              this.dgvProducts.Columns[4].Width = 150;
              this.dgvProducts.Columns[5].Width = 160;//null reference error in all the code
              this.dgvProducts.Columns[6].Width = 125;*/
        }
        public frm_orders()
        {
            InitializeComponent();
            createDataTable();
            recognizeDGV();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.billId.Text = cls.get_last_order().Rows[0][0].ToString();
            btnNew.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_customer_list frm = new frm_customer_list();
            frm.ShowDialog();
            this.pId.Text = frm.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            this.fName.Text = frm.dgvCustomers.CurrentRow.Cells[1].Value.ToString();
            this.lanme.Text = frm.dgvCustomers.CurrentRow.Cells[2].Value.ToString();
            this.phno.Text = frm.dgvCustomers.CurrentRow.Cells[3].Value.ToString();
            this.email.Text = frm.dgvCustomers.CurrentRow.Cells[4].Value.ToString();


            // this.txtProfileId.Text = frm.dgvCustomers.CurrentRow.Cells[0].Value.ToString();
            //if (frm.dgvCustomers.CurrentRow.Cells[5].Value is DBNull) MessageBox.Show("picture not found");//5 gives exception outof range
            //else
            //{
            // byte[] custPicture = (byte[])frm.dgvCustomers.CurrentRow.Cells[5].Value; out of range error
            // MemoryStream ms = new MemoryStream(custPicture);
            //pictureBox1.Image = Image.FromStream(ms);
            //}
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_products_list frm = new frm_products_list();
            frm.ShowDialog();
         //  txtPid.Text=frm.
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //txt
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            txtAmount.ReadOnly = true;
        }

        private void txtTamount_TextChanged(object sender, EventArgs e)
        {
            txtTamount.ReadOnly = true;
        }
    }
}
