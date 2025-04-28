using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace productManagement.PL
{
    public partial class frm_categories : Form
    {
        //we will  use the databinding way as we have few columns and this is much easier in transactions
        SqlConnection sqlcon = new SqlConnection(@"Server=AYAATEF1;Database=product_db;Integrated Security=true");
        SqlDataAdapter da;
        //this table can't be null so you must initialize it to  a  new table
        DataTable dt = new DataTable();
        BindingManagerBase bmb;
        CurrencyManager cm;
        //this sclass is for transactions like add,delete,edit
        SqlCommandBuilder cmdb;
        public frm_categories()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select id_cat,description_cat from categories", sqlcon);
            //to put them in the data table 
            da.Fill(dt);
            dgList.DataSource = dt;
            dgList.DataSource = dt;
            txtId.DataBindings.Add("text", dt, "id_cat");
            txtdesc.DataBindings.Add("text", dt, "description_cat");//property-source -data member
            bmb = this.BindingContext[dt];
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void button13_Click(object sender, EventArgs e)//exit button
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)//btnFirst
        {
            bmb.Position = 0;
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnLast_Click(object sender, EventArgs e)//the last button
        {
            bmb.Position = bmb.Count;
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void btnNext_Click(object sender, EventArgs e)//prev
        {
            bmb.Position -= 1;
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void btnprev_Click(object sender, EventArgs e)//next
        {
            bmb.Position += 1;
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void iblPos_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bmb.AddNew();
            btnNew.Enabled = false;
            btnAdd.Enabled = true;
            int id = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0]) + 1;
            txtId.Text = id.ToString();
            txtdesc.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("added successfully", "add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAdd.Enabled = false;
            btnNew.Enabled = true;
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void button7_Click(object sender, EventArgs e)//deleteButton
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("deleted successfully", "delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bmb.RemoveAt(bmb.Position);
            bmb.EndCurrentEdit();
            cmdb = new SqlCommandBuilder(da);
            da.Update(dt);
            MessageBox.Show("Edited successfully", "edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            iblPos.Text = Convert.ToString((bmb.Position + 1)) + "/" + Convert.ToString(bmb.Count);
        }
    }
}
