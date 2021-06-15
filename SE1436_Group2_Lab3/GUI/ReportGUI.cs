using SE1426_Group2_Lab3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            string cmd = "select * from Orders";
            OrderGridView1.DataSource = DAO.GetDataTable(cmd);

            string cmd1 = "Select * from OrderDetails where OrderId = (select Top 1OrderId from Orders)";
            OrderDetailGridView2.DataSource = DAO.GetDataTable(cmd1);
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int year = monthCalendar1.SelectionStart.Year;
            int month = monthCalendar1.SelectionStart.Month;
            int day = monthCalendar1.SelectionStart.Day;

            textFrom.Text = string.Format("{0}/{1}/{2}", day, month, year);

            int year1 = monthCalendar1.SelectionEnd.Year;
            int month1 = monthCalendar1.SelectionEnd.Month;
            int day1 = monthCalendar1.SelectionEnd.Day;

            textTo.Text = string.Format("{0}/{1}/{2}", day1, month1, year1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = monthCalendar1.SelectionStart.Year;
            int month = monthCalendar1.SelectionStart.Month;
            int day = monthCalendar1.SelectionStart.Day;

            string dat = string.Format("{0}-{1}-{2}", year, month, day);

            int year1 = monthCalendar1.SelectionEnd.Year;
            int month1 = monthCalendar1.SelectionEnd.Month;
            int day1 = monthCalendar1.SelectionEnd.Day;

            string dat1 = string.Format("{0}-{1}-{2}", year1, month1, day1);
            try
            {

                SqlCommand cmd = new SqlCommand("select * from Orders where OrderDate betWeen @dat and @dat1 AND FirstName LIKE @FirstName AND Country LIKE @Country");
                cmd.Parameters.AddWithValue("@FirstName", "%" + textFname.Text + "%");
                cmd.Parameters.AddWithValue("@Country", "%" + textCountry.Text + "%");
                cmd.Parameters.AddWithValue("@dat", dat);
                cmd.Parameters.AddWithValue("@dat1", dat1);
                OrderGridView1.DataSource = DAO.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // enter
                btFilter.PerformClick();
        }

        private void textCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btFilter.PerformClick();
        }

        private void Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string od = OrderGridView1.Rows[e.RowIndex].Cells["OrderId"].Value.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from OrderDetails where OrderId = (select OrderId from Orders where OrderId = @dateOr) ");
                cmd.Parameters.AddWithValue("@dateOr", od);
                OrderDetailGridView2.DataSource = DAO.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
