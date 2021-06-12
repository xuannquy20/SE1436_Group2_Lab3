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
    public partial class AlbumDetailGUI : Form
    {
        public AlbumDetailGUI()
        {
            InitializeComponent();
            textBox5.Hide();
        }

        private void AboutDetail_Load(object sender, EventArgs e)
        {
        }



        public void showDetail(int albumID)
        {
            Album a = AlbumDAO.GetAlbumByID(albumID);
            textBox1.Text = a.Title;
            textBox2.Text = a.Price.ToString();
            textBox3.Text = ArtitsDAO.getName(a.ArtistID);
            textBox4.Text = GenreDAO.getName(a.GenreID);
            textBox5.Text = a.AlbumID.ToString();
            pictureBox1.Image = Image.FromFile(a.AlbumUrl);
            this.ShowDialog();
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ShoppingCartDAO s = ShoppingCartDAO.GetCart();
                s.AddToCart(int.Parse(textBox5.Text));
                CartGUI c = new CartGUI();
                c.bind();
                this.Close();
                c.ShowDialog();
            }
            catch(Exception ex)
            {
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
