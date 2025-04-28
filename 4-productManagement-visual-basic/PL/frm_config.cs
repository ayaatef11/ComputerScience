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
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = serverName.Text;
            Properties.Settings.Default.database = dbName.Text;
            Properties.Settings.Default.mode = rbSql.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.id = usName.Text;
            Properties.Settings.Default.password = pwd.Text;
            Properties.Settings.Default.Save(); 

        }
    }
}
