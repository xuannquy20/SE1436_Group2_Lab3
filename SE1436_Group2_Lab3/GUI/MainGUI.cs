
using Lab3_Template.DTL;
using SE1426_Group2_Lab3.DAL;
using SE1426_Group2_Lab3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1426_Group2_Lab3
{
    public partial class MainGUI : Form
    {

        public MainGUI()
        {
            InitializeComponent();
        }

        private void Embed(Panel p, Form f)
        {
            p.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);//thêm form mới vào panel
            p.Show();
        }

        public void getLogin()
        {
            if(Variable.Username != null) { 
                if (Variable.Role == 1)
                {
                    reportToolStripMenuItem.Visible = true;
                    albumsToolStripMenuItem.Visible = true;
                }
                loginToolStripMenuItem.Text = "Logout (" + Variable.Username + ")";
            }
            else if (Variable.Username == null)
            {
                reportToolStripMenuItem.Visible = false;
                albumsToolStripMenuItem.Visible = false;
                loginToolStripMenuItem.Text = "Login";
            }
        }

        public void gettotalCart()
        {
            var id = new ShoppingCartDAO();
            int total = 0;
            SqlCommand cmd = new SqlCommand("select COUNT(*) as total from Carts where CartId = @cartid");
            cmd.Parameters.AddWithValue("@cartid", id.GetCartId());
            DataTable dt = DAO.GetDataTable(cmd);
            DataRow row = dt.Rows[0];
            total = int.Parse(row["total"].ToString());
            if (total!=0)
            {
                cartToolStripMenuItem.Text = "Cart (" + total + ")";
            }
            else
            {
                cartToolStripMenuItem.Text = "Cart";
            }
        }

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embed(screen, new About());
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embed(screen, new StoreGUI());
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = new ShoppingCartDAO();
            SqlCommand cmd1 = new SqlCommand("select DateCreated, AlbumId, Count from Carts where CartId = @CartID");
            if (Variable.Username != null)
            {
                cmd1.Parameters.AddWithValue("@CartID", Variable.Username);
            }
            else
            {
                cmd1.Parameters.AddWithValue("@CartID", id.GetCartId());
            }
            new CartGUI().CartTable.DataSource = DAO.GetDataTable(cmd1);
            new CartGUI().ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var id = new ShoppingCartDAO();
            if(Variable.Username == null)
            {
                new LoginGUI().ShowDialog();
            }
            else
            {
                Variable.Username = null;
                Variable.Role = -1;
                getLogin();
                gettotalCart();
                id.GetCartId();
                cartToolStripMenuItem.Text = "Cart";
            }
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embed(screen, new ReportGUI());
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embed(screen, new AlbumGUI());
        }

        private void MainGUI_Activated(object sender, EventArgs e)
        {
            getLogin();
            gettotalCart();
        }

        private void MainGUI_VisibleChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Carts");
            DAO.UpdateTable(cmd);
        }
    }
}
