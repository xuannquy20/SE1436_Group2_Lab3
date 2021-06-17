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
            bind();
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

        public void bind()
        {
            albumsData.DataSource = AlbumDAO.GetDataTable();
            albumsData.Columns["AlbumId"].Visible = false;
            albumsData.Columns["GenreId"].Visible = false;
            albumsData.Columns["ArtistId"].Visible = false;
            
        }

        private void AlbumGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumAddGUI aa = new AlbumAddGUI();
            aa.IsSave = true;
            aa.ShowDialog();
            bind();
        }

        private void albumsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == albumsData.Columns["Detail"].Index)
            {
                int id = int.Parse(albumsData.Rows[e.RowIndex].Cells["AlbumId"].Value.ToString());
                AlbumDetailGUI ab = new AlbumDetailGUI();
                ab.showDetail(id);
            }
            else if(e.ColumnIndex == albumsData.Columns["Edit"].Index)
            {
                int id = int.Parse(albumsData.Rows[e.RowIndex].Cells["AlbumId"].Value.ToString());
                AlbumAddGUI aa = new AlbumAddGUI();
                aa.IsSave = false;
                aa.showDetail(id);
                bind();
            }
            else if (e.ColumnIndex == albumsData.Columns["Delete"].Index)
            {
                int id = int.Parse(albumsData.Rows[e.RowIndex].Cells["AlbumId"].Value.ToString());
                DialogResult dr = MessageBox.Show("Do you want to detele this album?", "Confirm", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    AlbumDAO.Delete(id);
                }
                bind();
            }
            
        }
    }
}
