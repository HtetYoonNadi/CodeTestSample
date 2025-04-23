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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddInteger_Click(object sender, EventArgs e)
        {
            AddFiveIntegersForm addFiveInte = new AddFiveIntegersForm();
            addFiveInte.ShowDialog();
        }

        private void btnWeight_Click(object sender, EventArgs e)
        {
            WeightConverter weightConverter = new WeightConverter();
            weightConverter.ShowDialog();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            StudentGradeCalculator gradeCalculator = new StudentGradeCalculator();
            gradeCalculator.ShowDialog();
        }

        private void btnPrize_Click(object sender, EventArgs e)
        {
            Prize prize = new Prize();
            prize.ShowDialog();
        }
    }
}
