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
    public partial class AlbumAddGUI : Form
    {
        bool isSave = true;

        public bool IsSave { get => isSave; set => isSave = value; }

        public AlbumAddGUI()
        {
            InitializeComponent();
            textBox4.Hide();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            string cmd1 = "select GenreId,name  from Genres";
            DataTable dt = DAO.GetDataTable(cmd1);
            BindingSource source = new BindingSource();
            source.DataSource = dt;
            comboBox1.DataSource = source;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "GenreId";

            string cmd = "select ArtistId,name  from Artists";
            DataTable dt1 = DAO.GetDataTable(cmd);
            BindingSource source2 = new BindingSource();
            source2.DataSource = dt1;
            comboBox2.DataSource = source2;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "ArtistId";
        }

        public void showDetail(int albumID)
        {
            try
            {
                Album a = AlbumDAO.GetAlbumByID(albumID);
                textBox1.Text = a.Title;
                textBox2.Text = a.Price.ToString();

                string cmd1 = "select GenreId,name  from Genres";
                DataTable dt = DAO.GetDataTable(cmd1);
                BindingSource source = new BindingSource();
                source.DataSource = dt;
                comboBox1.DataSource = source;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "GenreId";

                string cmd = "select ArtistId,name  from Artists";
                DataTable dt1 = DAO.GetDataTable(cmd);
                BindingSource source2 = new BindingSource();
                source2.DataSource = dt1;
                comboBox2.DataSource = source2;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "ArtistId";

                textBox3.Text = a.AlbumUrl;
                textBox4.Text = a.AlbumID.ToString();

                pictureBox1.Image = Image.FromFile(a.AlbumUrl);
            }
            catch (Exception e)
            {

            }
            finally
            {
                this.ShowDialog();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                Album a = new Album
                {
                    ArtistID = int.Parse(comboBox2.SelectedValue.ToString()),
                    GenreID = int.Parse(comboBox1.SelectedValue.ToString()),
                    Title = textBox1.Text.ToString(),
                    Price = double.Parse(textBox2.Text.ToString()),
                    AlbumUrl = textBox3.Text.Replace('\\', '/').ToString(),
            };
                    if (IsSave)
                    {
                        
                        AlbumDAO.Insert(a);
                    }
                    else if (!isSave)
                    {
                    a.AlbumID = int.Parse(textBox4.Text);
                    AlbumDAO.Update(a);
                    }
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Title cannot be empty and Price must be double number");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            textBox3.Text = of.FileName;
            try
            {
                pictureBox1.Image = Image.FromFile(textBox3.Text);
            }
            catch(Exception ex)
            {

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
