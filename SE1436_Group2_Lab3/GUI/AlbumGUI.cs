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
    public partial class AlbumGUI : Form
    {
        public AlbumGUI()
        {
            InitializeComponent();
            albumsData.DataSource = AlbumDAO.GetDataTable();
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            albumsData.Columns.Insert(albumsData.ColumnCount, btnDetail);

            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            albumsData.Columns.Insert(albumsData.ColumnCount, btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            albumsData.Columns.Insert(albumsData.ColumnCount, btnDelete);
        }

        private void AlbumGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AlbumAddGUI().ShowDialog();
        }

        private void albumsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == albumsData.Columns["Detail"].Index)
            {
                string title = albumsData.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                AlbumDetailGUI ab = new AlbumDetailGUI();
                ab.showDetailbytt(title);
            }
        }
    }
}
