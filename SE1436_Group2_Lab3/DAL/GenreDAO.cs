using Lab3_Template.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SE1426_Group2_Lab3.DAL
{
    public class GenreDAO
    {
        public static string getName(int genreId)
        {
            string name = "";
            SqlCommand cmd = new SqlCommand("select * from Genres where GenreId = @id");
            cmd.Parameters.AddWithValue("@id", genreId);
            DataTable dt = DAO.GetDataTable(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                name = row["Name"].ToString();
            }
            return name;
        }
    }
}
