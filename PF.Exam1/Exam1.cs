using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF.Exam1
{
    public partial class Exam1 : Form
    {
        public Exam1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double width = 0;
            double height = 0;
            
            Double.TryParse(txtWidth.Text, out width);
            Double.TryParse(txtWidth.Text, out height);
            
            double area = width * height;
            double perim = (2 * width) + (2 * height);
            lblArea.Text = area.ToString("0.000");
            lblPerim.Text = perim.ToString("0.000");

            txtHeight.Clear();
            txtWidth.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
