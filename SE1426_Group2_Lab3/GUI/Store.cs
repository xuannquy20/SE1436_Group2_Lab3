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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStoreDataSet2.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicStoreDataSet2.Albums);
            // TODO: This line of code loads data into the 'musicStoreDataSet1.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.musicStoreDataSet1.Genres);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
