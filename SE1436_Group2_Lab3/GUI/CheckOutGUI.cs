using SE1426_Group2_Lab3.DAL;
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
    public partial class CheckOutGUI : Form
    {
        public CheckOutGUI()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            this.date.Value = date;
        }

        public void getCheckout(string total)
        {
            username.Text = Variable.Username;
            this.total.Text = total.ToString();
            this.ShowDialog();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = "yyyy/MM/dd";
            string dat = date.Text;
            if(firstname.TextLength == 0)
            {
                MessageBox.Show("First Name required!");
            }
            else if (lastname.TextLength == 0)
            {
                MessageBox.Show("Last Name required!");
            }
            else if(address.TextLength == 0)
            {
                MessageBox.Show("Address required!");
            }
            else if (city.TextLength == 0)
            {
                MessageBox.Show("City required!");
            }
            else if(state.TextLength == 0)
            {
                MessageBox.Show("State required!");
            }
            else if (country.TextLength == 0)
            {
                MessageBox.Show("Country required!");
            }
            else if(phone.TextLength == 0)
            {
                MessageBox.Show("Phone required!");
            }
            else if (email.TextLength == 0)
            {
                MessageBox.Show("Email required!");
            }
            else {
                double free = 0;
                if (promocode.Text.Equals("FREE"))
                {
                    OrderDAO.addOrder(dat, firstname.Text, lastname.Text, address.Text, city.Text, state.Text, country.Text, phone.Text, email.Text, free, promocode.Text);
                }
                else
                {
                    OrderDAO.addOrder(dat, firstname.Text, lastname.Text, address.Text, city.Text, state.Text, country.Text, phone.Text, email.Text, double.Parse(total.Text), promocode.Text);
                }
                OrderDAO.addOrderDetail();
                CartDAO.Delete(Variable.Username);
                this.Close();
            }
        }

        private void CheckOutGUI_Activated(object sender, EventArgs e)
        {
        }
    }
}
