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
    public partial class frm_customers_ : Form
    {
        BL.cls_customers c = new BL.cls_customers();
        public frm_customers_()
        {
            InitializeComponent();
            this.dg1.DataSource = c.getAllCustomers();
            dg1.Columns[0].Visible = false;//we don't want to show the column of the id as its created for the developer so as not be distributed and the user does't need it 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            txtPhoto.Image.Save(ms, txtPhoto.Image.RawFormat);
            byte[] picture = ms.ToArray();
            c.addCustomers(txtFname.Text, txtLname.Text, txtPhNo.Text, txtEmail.Text, picture);
            MessageBox.Show("added successfully", "added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.dg1.DataSource = c.getAllCustomers();
        }

        private void txtPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "photos files|*.png;*.jpg,*.bmp,*gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtFname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLname.Focus();
            }
        }

        private void txtLname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLname.Focus();
            }
        }

        private void txtPhNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLname.Focus();
            }
        }
    }
}
