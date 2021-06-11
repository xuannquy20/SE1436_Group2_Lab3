﻿using Lab3_Template.DTL;
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
    public partial class AlbumDetailGUI : Form
    {
        public AlbumDetailGUI()
        {
            InitializeComponent();
        }

        private void AboutDetail_Load(object sender, EventArgs e)
        {
        }

        public void showDetail(int albumID)
        {
            Album a = AlbumDAO.GetAlbumByID(albumID);
            this.textBox1.Text = a.Title;
            this.textBox2.Text = a.Price.ToString();
            this.textBox3.Text = a.ArtistID.ToString();
            this.textBox4.Text = a.GenreID.ToString();
            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            new CartGUI().ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
