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
using System.Data;
namespace productManagement.PL
{
    public partial class frm_restore : Form
    {
        SqlConnection con = new SqlConnection(@"Server=AYAATEF1;Database=product_db;Integrated Security=true");
        SqlCommand cmd ;
        OpenFileDialog OpenFileDialog1 = new OpenFileDialog();//not sure
        public frm_restore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = OpenFileDialog1.FileName;//it returns the path of the file
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strQuery="restore database product from  disk='"+txtFileName.Text+"'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("restored successfully", "restoration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
