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
            CartTable.Columns.Insert(0, btnDetail);
            bind();
            Remove_Click();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void bind()
        {
            var id = new ShoppingCartDAO();
            try
            {
                SqlCommand cmd1 = new SqlCommand("select DateCreated, AlbumId, Count from Carts where CartId = @CartID");
                if (Variable.Username != null) {
                    cmd1.Parameters.AddWithValue("@CartID", Variable.Username);
                }
                else
                {
                    cmd1.Parameters.AddWithValue("@CartID", id.GetCartId());
                }
                CartTable.DataSource = DAO.GetDataTable(cmd1);
            }
            catch (Exception ex)
            {
            }

            SqlCommand sql = new SqlCommand("select Sum((a.Price * c.count))  as total" +
                        " from Albums a join Carts c" +
                        " on c.AlbumId = a.AlbumId " +
                        "where c.CartId = @CartID");
            SqlCommand cmd = new SqlCommand("UPDATE Carts SET CartId = @cartid WHERE CartId != @cartid");
            cmd.Parameters.AddWithValue("@cartid", id.GetCartId());
            DAO.UpdateTable(cmd);
            sql.Parameters.AddWithValue("@CartID", id.GetCartId());

            DataTable dt = DAO.GetDataTable(sql);
            if(dt.Rows.Count > 0)
            {
                DataRow dtr = dt.Rows[0];
                string  total = dtr["total"].ToString();
                TotalTextBox.Text = total;
            }
        }

        public void Remove_Click()
        {
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
            new CheckOutGUI().getCheckout(TotalTextBox.Text);
        }
        
        private void CartGUI_Load(object sender, EventArgs e)
        {

        }

        private void CartGUI_Load_1(object sender, EventArgs e)
        {

        }

        private void CartGUI_Activated(object sender, EventArgs e)
        {
            bind();
        }

        private void CartTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShoppingCartDAO s = new ShoppingCartDAO();
            if (e.ColumnIndex == CartTable.Columns["Detail"].Index)
            {
                int albumID = (int)CartTable.Rows[e.RowIndex].Cells["albumID"].Value;
                AlbumDetailGUI ab = new AlbumDetailGUI();
                ab.showDetail(albumID);
            }
            if(e.ColumnIndex == CartTable.Columns["Remove"].Index)
            {
                int albumID = (int)CartTable.Rows[e.RowIndex].Cells["albumID"].Value;
                s.RemoveFromCart(albumID);
                bind();
            }
        }
    }
}
