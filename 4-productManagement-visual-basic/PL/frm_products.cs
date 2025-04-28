using productManagement.BL;
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
namespace productManagement.PL
{
    public partial class frm_products : Form
    {
        public static frm_products instance;
        BL.clsProducts pred = new BL.clsProducts();
        public static frm_products GetMainForm
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frm_products();
                    instance.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return instance;
            }
        }

        private static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        public frm_products()
        {
            InitializeComponent();
            if (instance == null) instance = this;
            this.dataGridView1.DataSource = pred.getAllProducts();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_preview frm = new frm_preview();
            byte[] image = (byte[])pred.getImageProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.picture1.Image = Image.FromStream(ms);
            //frm_preview fem= new frm_preview();
            //fem.picture1.Image=
            frm.ShowDialog();
        }
        //there is a proble it adds the eddited row as a new row 
        private void button3_Click(object sender, EventArgs e)
        {
            frm_add_products frm = new frm_add_products();
            frm.refText.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.textDesc.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtQte.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtPrice.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbCategories.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //frm.refText.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.Text = "Edit a product" + this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.btnOk.Text = "Edit";
            frm.refText.ReadOnly = true;
            frm.state = "update";
            pred.deleteProduct(frm.refText.Text);// in order to not duplicate the id keys
            //this.dataGridView1.CurrentRow=frm.
            byte[] image = (byte[])pred.getImageProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString()).Rows[0][0]; //here there is an exception
            MemoryStream ms = new MemoryStream(image);
            frm.pbox.Image = Image.FromStream(ms);
            frm.ShowDialog();
            // this.dataGridView1.DataSource = pred.getAllProducts();
        }

        private void button2_Click(object sender, EventArgs e)//delete selected item
        {
            if (MessageBox.Show("do you really want to delete this product ", "delete transaction", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                pred.deleteProduct(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("deleted successfully", "deletion transaction", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = pred.getAllProducts();
            }
            else
            {
                MessageBox.Show("deletion canceled", "deletion transaction", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)//add a new product ///i did so
        {
            frm_add_products p = new frm_add_products();
            p.ShowDialog();
        }
        //there is a problem in searching
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = pred.searchProduct(textSearch.Text);
            this.dataGridView1.DataSource = dt;
        }
    }
}
