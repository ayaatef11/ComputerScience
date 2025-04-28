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
    public partial class FormLogin : Form
    {
        BL.cls_login log = new BL.cls_login();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = log.login(textBox1.Text, textBox2.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("login success !");
                // frm_main frm=new frm_main();
                //frm.createAnotherEditionToolStripMenuItem.Enabled = true;
                frm_main.GetMainForm.createAnotherEditionToolStripMenuItem.Enabled = true;
                // frm_main.getMainForm.rest
                //complete the others
                this.Close();
            }
            else
            {
                MessageBox.Show("login failed !");
            }
        }
    }
}
