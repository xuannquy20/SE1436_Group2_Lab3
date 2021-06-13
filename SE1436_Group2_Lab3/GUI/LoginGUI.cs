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
    public partial class LoginGUI : Form
    {

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string user = txtUserName.Text;
                string pass = txtPass.Text;
                LoginDAO.getLogin(user, pass);
                if (Variable.Username == null)
                {
                    MessageBox.Show("Tai khoan hoac mat khau sai");
                }
                else
                {
                    this.Close();
                }
        }
    }
}
