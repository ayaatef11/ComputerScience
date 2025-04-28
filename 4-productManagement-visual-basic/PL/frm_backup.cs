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
    public partial class frm_backup : Form
    {
        SqlConnection con=new SqlConnection(@"Server=AYAATEF1;Database=product_db;Integrated Security=true");
        SqlCommand cmd ;
        public frm_backup()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strQuery = "backup database to disk";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
