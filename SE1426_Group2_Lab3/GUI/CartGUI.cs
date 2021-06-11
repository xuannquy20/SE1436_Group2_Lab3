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
    public partial class CartGUI : Form
    {
        public CartGUI()
        {
            InitializeComponent();
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true,
            };
            Cart.Columns.Insert(0, btnDetail);
            
            try
            {
                SqlCommand cmd = new SqlCommand("select DateCreated , AlbumId , Count" +
                            "from Carts where CartId = @CartID");
                cmd.Parameters.AddWithValue("@CartID", Variable.Username);
                Cart.DataSource = DAO.GetDataTable(cmd);
            }catch(Exception ex)
            {

            }
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn
            {
                Name = "Remove",
                Text = "Remove from cart",
                UseColumnTextForButtonValue = true,
            };
            Cart.Columns.Insert(1, btnRemove);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(new MainGUI().loginToolStripMenuItem.Text != "Login") { 
                new CheckOutGUI().ShowDialog();
            }
            else
            {
                new LoginGUI().ShowDialog();
            }
        }
    }
}
