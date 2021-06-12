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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void bind()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select DateCreated, AlbumId, Count from Carts where CartId = @CartID");
                cmd.Parameters.AddWithValue("@CartID", Variable.Username);
                CartTable.DataSource = DAO.GetDataTable(cmd);
            }
            catch (Exception ex)
            {
            }

            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true,
            };
            CartTable.Columns.Insert(0, btnDetail);

            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn
            {
                Name = "Remove",
                Text = "Remove from cart",
                UseColumnTextForButtonValue = true,
            };
            CartTable.Columns.Insert(CartTable.ColumnCount, btnRemove);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckOutGUI co = new CheckOutGUI();
            if (Variable.Username == null) {
                new LoginGUI().ShowDialog();
            }
            this.Close();
            new CheckOutGUI().getCheckout(textBox1.Text);
        }

        private void CartGUI_Load(object sender, EventArgs e)
        {

        }

        private void CartGUI_Load_1(object sender, EventArgs e)
        {

        }

        private void CartGUI_Activated(object sender, EventArgs e)
        {
        }
    }
}
