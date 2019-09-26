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
        
        public void RecPerimeter(double height, double width)
        {
            Double.TryParse(txtWidth.Text, out width);
            Double.TryParse(txtHeight.Text, out height);
            double perim = (2 * width) + (2 * height);
        }

        public double RecArea(double height, double width)
        {
            Double.TryParse(txtWidth.Text, out width);
            Double.TryParse(txtHeight.Text, out height);

            double area = width * height;
            return area;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtWidth.Text, out double width);
            Double.TryParse(txtHeight.Text, out double height);
            double temparea = width * height;


            if(temparea = RecArea() { }
            




           /* if (Double.TryParse(txtWidth.Text, out double width) && Double.TryParse(txtWidth.Text, out double height))
            {
                double area = width * height;
                double perim = (2 * width) + (2 * height);

                lblArea.Text = area.ToString("0.000");
                lblPerim.Text = perim.ToString("0.000");

                txtHeight.Clear();
                txtWidth.Clear();

            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHeight.Clear();
                txtWidth.Clear();
                txtWidth.Focus();
            }*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
