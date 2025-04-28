using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Cr
namespace productManagement.PL
{
    
    public partial class frm_products_list : Form
    {
        BL.clsProducts prd = new BL.clsProducts();
        public frm_products_list()
        {
            InitializeComponent();
            //this.dgvProducts.DataSource=prd.getAllProducts();
        }
    }
}
