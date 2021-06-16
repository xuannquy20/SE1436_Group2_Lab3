using Lab3_Template.DTL;
using SE1426_Group2_Lab3.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SE1426_Group2_Lab3.DAL
{
    class LoginDAO
    {
        public static void getLogin(string username, string pass)
        {
            try { 
            SqlCommand cmd = new SqlCommand("select UserName, Role from Users where UserName = @username and[Password] = @pass");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            DataTable dt = DAO.GetDataTable(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Variable.Username = row["UserName"].ToString();
                Variable.Role = int.Parse(row["Role"].ToString());
                var id = new ShoppingCartDAO();
                SqlCommand cmd1 = new SqlCommand("UPDATE Carts SET CartId = @acc WHERE CartId = @cartid");
                cmd1.Parameters.AddWithValue("@acc", Variable.Username);
                cmd1.Parameters.AddWithValue("@cartid", id.CartID());
                DAO.UpdateTable(cmd1);
                id.GetCartId();
                }
            }
            catch(Exception e)
            {
            }
        }
    }
}
