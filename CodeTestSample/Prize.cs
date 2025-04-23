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
    public partial class Prize : Form
    {
        public Prize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int result = 0;
            result = int.Parse(txtNum.Text);

            if (result < 0 || result > 6 )
            {
                MessageBox.Show("Invalid Input!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                if (result == 1 || result == 2 || result == 3)
                {
                    lblResult.Text = "No prize.";
                }

                else if (result == 4) lblResult.Text = "A pencil";

                else if (result == 5) lblResult.Text = "A pair of shoelaces";

                else if (result == 6) lblResult.Text = "An activity tracker watch";
            }


        }
    }
}
