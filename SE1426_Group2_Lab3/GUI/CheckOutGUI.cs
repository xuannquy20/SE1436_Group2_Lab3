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
            if(firstname.TextLength == 0 || lastname.TextLength == 0 || address.TextLength == 0|| city.TextLength == 0 || state.TextLength ==0 || country.TextLength==0|| phone.TextLength==0|| email.TextLength == 0)
            {
                MessageBox.Show("Vui long nhap du thong tin");
            }
            else {
                double totalmoney = 0;
                if(promocode.Text == null)
                {
                    totalmoney = 0;
                }
                else
                {
                    totalmoney = double.Parse(promocode.Text);
                }
                OrderDAO.addOrder(dat, firstname.Text, lastname.Text, address.Text, city.Text, state.Text, country.Text, phone.Text, email.Text, totalmoney, promocode.Text);
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
