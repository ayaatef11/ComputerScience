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
    public partial class frm_add_products : Form
    {
        public string state = "add";
        BL.clsProducts pred = new BL.clsProducts();
        public frm_add_products()
        {
            InitializeComponent();
            cmbCategories.DataSource = pred.getAllCategories();
            cmbCategories.DisplayMember = "description_cat";
            cmbCategories.ValueMember = "id_cat";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//exit key 
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)//to selct a picture 
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "imagephotos |*.png;*.jpg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)// the ok putton
        {
            if (state == "add")
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                pred.addProducts(textDesc.Text, refText.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage, Convert.ToInt32(cmbCategories.SelectedValue));
                MessageBox.Show("added", " successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
frm_products.GetMainForm.dataGridView1.DataSource=pred.getAllProducts();
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pbox.Image.Save(ms, pbox.Image.RawFormat);
                byte[] byteImage = ms.ToArray();
                pred.update_products(textDesc.Text, refText.Text, Convert.ToInt32(txtQte.Text), txtPrice.Text, byteImage, Convert.ToInt32(cmbCategories.SelectedValue));
                MessageBox.Show("updated", " successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtQte_TextChanged(object sender, EventArgs e)
        {

        }

        private void refText_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable dt = new DataTable();
                dt = pred.verifyProductId(refText.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("warnning", "this id is found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    refText.Focus();
                    refText.SelectionStart = 0;
                    refText.SelectionLength = refText.TextLength;
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
