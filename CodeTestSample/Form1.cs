using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTestSample
{
    public partial class AddFiveIntegersForm : Form
    {
        public AddFiveIntegersForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double num1, num2, num3, num4, num5;

            num1 = double.Parse(txtNum1.Text);
            num2 = double.Parse(txtNum2.Text);
            num3 = double.Parse(txtNum3.Text);
            num4 = double.Parse(txtNum4.Text);
            num5 = double.Parse(txtNum5.Text);

            sum = num1 + num2 + num3 + num4 + num5;

            lblResult.Text = "Total is " + sum.ToString();
            

        }
    }
}
