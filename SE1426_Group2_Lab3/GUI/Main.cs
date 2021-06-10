
using SE1426_Group2_Lab3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SE1426_Group2_Lab3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if(loginToolStripMenuItem.Text == "Login")
            {
                reportToolStripMenuItem.Visible = false;
                albumsToolStripMenuItem.Visible = false;
            }
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
            Embed(screen, new Store());
        }

        private void cartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cart().ShowDialog();
        }
    }
}
