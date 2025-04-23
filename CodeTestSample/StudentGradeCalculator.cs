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
    public partial class StudentGradeCalculator : Form
    {
        public StudentGradeCalculator()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int mark = 0;
            mark = int.Parse(txtMark.Text);

            if (mark < 0 || mark > 100) 
            {
                MessageBox.Show("Invalid Input!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (mark > 70) lblResult.Text = "Grade A";
                else if (mark > 60) lblResult.Text = "Grade B";
                else if (mark > 50) lblResult.Text = "Grade C";
                else if (mark > 40) lblResult.Text = "Grade D";
                else if (mark > 30) lblResult.Text = "Grade E";

                else lblResult.Text = "Grade F";

            }
        } 
    }
}
