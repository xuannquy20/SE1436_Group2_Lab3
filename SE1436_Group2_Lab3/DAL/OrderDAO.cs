using SE1426_Group2_Lab3.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SE1426_Group2_Lab3.DAL
{
    public class OrderDAO
    {
        public static void addOrder(string date, string firstname, string lastname, string address,string city, string state, string country, string phone, string email, double total, string promocode)
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


        public static void addOrderDetail()
        {
            SqlCommand cmd = new SqlCommand("insert into OrderDetails (OrderId, AlbumId,Quantity,UnitPrice) (select Max(o.orderiD) as OrderId, c.AlbumId,c.[Count], a.Price as UnitPrice from Carts c"
            +" join Albums a"
            +" on c.AlbumId = a.AlbumId"
            +" join Orders o"
            +" on o.UserName = c.CartId"
            +" where c.CartId = (select UserName from Orders where OrderId = (select MAX(OrderId) from Orders))"
            +" group by c.AlbumId, c.[Count], a.Price)");
            DAO.UpdateTable(cmd);
        }
    }
}
