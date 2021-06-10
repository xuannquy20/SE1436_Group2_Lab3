using Lab3_Template.DTL;
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
    public partial class CartGUI : Form
    {
        public CartGUI()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if(new Main().loginToolStripMenuItem.Text != "Login") { 
                new CheckOutGUI().ShowDialog();
            }
            else
            {
                new LoginGUI().ShowDialog();
            }
        }
    }
}
