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
    public partial class StoreGUI : Form
    {
        public StoreGUI()
        {
            InitializeComponent();
            string name = "Select Name from Genres";
            NameGenres.DataSource = DAO.GetDataTable(name);
            
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };

            Albums.Columns.Insert(0, btnDetail);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Albums where GenreId = (select GenreId from Genres where Name = @NameGen) ");
                cmd.Parameters.AddWithValue("@NameGen", "Rock");
                Albums.DataSource = DAO.GetDataTable(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicStoreDataSet2.Albums' table. You can move, or remove it, as needed.
            this.albumsTableAdapter.Fill(this.musicStoreDataSet2.Albums);
            // TODO: This line of code loads data into the 'musicStoreDataSet1.Genres' table. You can move, or remove it, as needed.
            this.genresTableAdapter.Fill(this.musicStoreDataSet1.Genres);

        }

        private void NameGenres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string genName = NameGenres.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Albums where GenreId = (select GenreId from Genres where Name = @NameGen) ");
                cmd.Parameters.AddWithValue("@NameGen", genName);
                Albums.DataSource = DAO.GetDataTable(cmd);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void Albums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Albums.Columns["Detail"].Index)
            {
                int albumID = (int)Albums.Rows[e.RowIndex].Cells["albumID"].Value;
                AlbumDetailGUI ab = new AlbumDetailGUI();
                ab.showDetail(albumID);
            }
        }
    }
}
