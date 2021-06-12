
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

        private void screen_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStoreDataSet.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicStoreDataSet.Albums);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embed(screen, new StoreGUI());
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = "select * from Carts";
            new CartGUI().CartTable.DataSource = DAO.GetDataTable(cmd);
            new CartGUI().ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Variable.Username == null)
            {
                new LoginGUI().ShowDialog();
            }
            else
            {
                Variable.Username = null;
                Variable.Role = -1;
                getLogin();
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
        }
    }
}
