using Lab3_Template.DTL;
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
        public static User getLogin(string username, string pass)
        {
            try { 
            User u = null;
            SqlCommand cmd = new SqlCommand("select * from Users where UserName = @username and[Password] = @pass");
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            DataTable dt = DAO.GetDataTable(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                u = new User
                {
                    Id = int.Parse(row["Id"].ToString()),
                    UserName = row["UserName"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = int.Parse(row["Role"].ToString()),
                    FirstName = row["FirstName"].ToString(),
                    LastName = row["LastName"].ToString(),
                    Address = row["Address"].ToString(),
                    City = row["City"].ToString(),
                    State = row["State"].ToString(),
                    Country = row["Country"].ToString(),
                    Phone = row["Phone"].ToString(),
                    Email = row["Email"].ToString()
                };
                return u;
                }
            }
            catch(Exception e)
            {

            }
            return null;
        }
    }
}
