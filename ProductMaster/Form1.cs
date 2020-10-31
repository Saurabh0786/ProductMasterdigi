using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProductMaster_Click(object sender, EventArgs e)
        {
            Frm_ProductMaster new_Form = new Frm_ProductMaster();
            new_Form.Show();
        }

        private void btnProductType_Click(object sender, EventArgs e)
        {
            Frm_ProductType new_Form1 = new Frm_ProductType();
            new_Form1.Show();

        }
    }
}
