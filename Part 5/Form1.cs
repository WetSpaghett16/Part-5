using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5
{
    public partial class frmIfStatements : Form
    {
         

        public frmIfStatements()
        {
            InitializeComponent();
        }

        private void frmIfStatements_Load(object sender, EventArgs e)
        {
            
        }

        private void txtAGE_TextChanged(object sender, EventArgs e)
        {
            int Age;
            
            lblResult1.Text = "You are a adult";
        }
    }
}
