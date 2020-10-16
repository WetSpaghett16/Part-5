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
        int Category;

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

            else if (Age <=0)
                lblResult1.Text = "Error";
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        { 



            if (Category == 1)
                lblResult2.Text = "Wind speeds will range between 119-153 km/hr";

            else if (Category == 2)
                lblResult2.Text = "Wind speeds will range between 154-177 km/hr";

            else if (Category == 3)
                lblResult2.Text = "Wind speeds will range between 178-209 km/hr";

            else if (Category == 4)
                lblResult2.Text = "Wind speeds will range between 210-249 km/hr";

            else if (Category == 5)
                lblResult2.Text = "Wind speeds will be greater than 249km/hr";
        }
    }
}
    

