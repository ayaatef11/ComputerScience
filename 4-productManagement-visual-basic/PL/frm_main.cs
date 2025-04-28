using System;
using System.Windows.Forms;

namespace productManagement.PL
{
    public partial class frm_main : Form
    {
        public static frm_main instance;
        public static frm_main GetMainForm
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new frm_main();
                    instance.FormClosed += new FormClosedEventHandler(frm_formClosed);
                }
                return instance;
            }
        }

        private static void frm_formClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        public frm_main()
        {
            InitializeComponent();
            // Rest of your initialization code here
            if (instance == null) instance = this;
            //this.productsToolStripMenuItem.Enabled = false;
            /*    this.clientsToolStripMenuItem.Enabled = false;
                this.usersToolStripMenuItem.Enabled = false;
                this.createAnotherEditionToolStripMenuItem.Enabled = false;
                this.restorePreservedEditonToolStripMenuItem.Enabled = false;*/
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_add_products frm = new frm_add_products();
            frm.ShowDialog();
        }

        private void productsManangementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_products frm = new frm_products();
            frm.ShowDialog();
        }

        private void addANewTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminstrateTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categories frm = new frm_categories();
            frm.ShowDialog();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void createAnotherEditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_backup frm = new frm_backup();
            frm.ShowDialog();
        }

        private void connectToTheServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_config frm = new frm_config();
            frm.ShowDialog();
        }
    }
}
