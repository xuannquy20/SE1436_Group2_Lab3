using SE1426_Group2_Lab3.GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SE1426_Group2_Lab3.DAL
{
    public class OrderDAO
    {
        public static void addOrder(string date, string promocode, string firstname, string lastname, string address,string city, string state, string country, string phone, string email, string total)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO [MusicStore].[dbo].[Orders] VALUES (@date, @promocode, @username, @firstname, @lastname, @address, @city, @state, @country, @phone, @email, @total)");
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@promocode", promocode);
            cmd.Parameters.AddWithValue("@username", Variable.Username);
            cmd.Parameters.AddWithValue("@firstname", firstname);
            cmd.Parameters.AddWithValue("@lastname", lastname);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@city", city);
            cmd.Parameters.AddWithValue("@state", state);
            cmd.Parameters.AddWithValue("@country", country);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@total", total);
            DAO.UpdateTable(cmd);
        }
    }
}
