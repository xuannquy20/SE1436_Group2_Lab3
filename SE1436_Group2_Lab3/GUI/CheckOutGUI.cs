using Lab3_Template.DTL;
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
    public partial class CheckOutGUI : Form
    {
        public CheckOutGUI()
        {
            InitializeComponent();
        }

        public void getCheckout()
        {
            username.Text = Variable.Username;
            try
            {
                DateTime date = DateTime.Now;
                this.date.Value = date;
                var id = new ShoppingCartDAO();
                SqlCommand sql = new SqlCommand("select Sum((a.Price * c.count))  as total" +
                            " from Albums a join Carts c" +
                            " on c.AlbumId = a.AlbumId " +
                            "where c.CartId = @CartID");
                sql.Parameters.AddWithValue("@CartID", id.GetCartId());
                DataTable dt = DAO.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow dtr = dt.Rows[0];
                    string total = dtr["total"].ToString();
                    this.total.Text = total;
                }
                User u = null;
                SqlCommand cmd = new SqlCommand("select * from Users where UserName = @username");
                cmd.Parameters.AddWithValue("@username", Variable.Username);
                DataTable dt1 = DAO.GetDataTable(cmd);
                if (dt1.Rows.Count > 0)
                {
                    DataRow dr = dt1.Rows[0];
                    username.Text = dr["username"].ToString();
                    firstname.Text = dr["Firstname"].ToString();
                    lastname.Text = dr["Lastname"].ToString();
                    address.Text = dr["address"].ToString();
                    city.Text = dr["city"].ToString();
                    state.Text = dr["state"].ToString();
                    country.Text = dr["country"].ToString();
                    phone.Text = dr["phone"].ToString();
                    email.Text = dr["email"].ToString();
                }
                promocode.Text = "FREE";
            }
            catch (Exception e) { 
            }
            finally { 
                this.ShowDialog();
            }
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
            else 
            {
                OrderDAO.addOrder(dat, firstname.Text, lastname.Text, address.Text, city.Text, state.Text, country.Text, phone.Text, email.Text, double.Parse(total.Text), promocode.Text);
                OrderDAO.addOrderDetail();
                CartDAO.Delete(Variable.Username);
                string sql = "select MAX(orderid) as id from Orders";
                DataTable dt = DAO.GetDataTable(sql);
                DataRow dr = dt.Rows[0];
                MessageBox.Show("Order successfully\nOrderID: " + dr["id"].ToString());
                this.Close();
            }
        }

    }
}
