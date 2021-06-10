using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1426_Group2_Lab3.GUI
{
    public partial class ReportGUI : Form
    {
        public ReportGUI()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = monthCalendar1.SelectionStart.Year;
            int month = monthCalendar1.SelectionStart.Month;
            int day = monthCalendar1.SelectionStart.Day;

            textBox1.Text = string.Format("{0}/{1}/{2}", day, month, year) ;

            int year1 = monthCalendar1.SelectionEnd.Year;
            int month1 = monthCalendar1.SelectionEnd.Month;
            int day1 = monthCalendar1.SelectionEnd.Day;

            textBox2.Text = string.Format("{0}/{1}/{2}", day1, month1, year1);

        }
    }
}
