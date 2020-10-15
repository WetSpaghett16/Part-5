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
        int Age;

        public frmIfStatements()
        {
            InitializeComponent();
        }

        private void frmIfStatements_Load(object sender, EventArgs e)
        {

        }

        private void txtAGE_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Age >= 18)
                lblResult1.Text = "You are an adult";

            else if (Age <= 5)
                lblResult1.Text = "You are a toddler";

            else if (Age <= 10)
                lblResult1.Text = "You are a child";

            else if (Age >= 12)
                lblResult1.Text = "You are a preteen";

           
        }
    }
}
    

