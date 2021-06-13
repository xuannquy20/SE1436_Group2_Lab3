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
    public class ShoppingCartDAO
    {
        string ShoppingCartId { get; set; }
        static string cartID { get; set; }
        public static string UserName { get; set; }

        public static ShoppingCartDAO GetCart()
        {
            var cart = new ShoppingCartDAO();
            cart.ShoppingCartId = cart.GetCartId();
            return cart;
        }

        public List<Cart> GetCartItems()
        {
            List<Cart> cartItems = CartDAO.GetCarts()
                    .Where(c => c.CartID == GetCartId()).ToList<Cart>();
            return cartItems;
        }

        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            List<Cart> cartItems = GetCartItems();
            int count = 0;
            if (cartItems != null)
                foreach (Cart cartItem in cartItems)
                    count += cartItem.Count;
            return count;
        }
        public double GetTotal()
        {
            // Multiply album price by count of that album to get
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total
            double total = 0;
            List<Cart> cartItems = GetCartItems();
            if (cartItems != null)
                foreach (Cart cart in cartItems)
                    total += cart.Count * AlbumDAO.GetAlbumByID(cart.AlbumID).Price;
            return total;
        }
        /*public int CreateOrder(Order order)
        {
            // Save the order
            //OrderDAO.Insert(order);
            //int orderID = OrderDAO.GetMaxID();
            var cartItems = GetCartItems();
            // Iterate over the items in the cart, adding the 
            // order details for each
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    AlbumID = item.AlbumID,
                    //OrderID = orderID,
                    UnitPrice = AlbumDAO.GetAlbumByID(item.AlbumID).Price,
                    Quantity = item.Count
                };
                //OrderDetailDAO.Insert(orderDetail);
            }

            // Empty the shopping cart
            CartDAO.Delete(ShoppingCartId);
            // Return the OrderId as the confirmation number
            //return orderID;
        }*/

        public void AddToCart(int id)
        {
            // Get the matching cart and album instances
            Cart cartItem = null;
            SqlCommand cmd = new SqlCommand("select * from carts where cartId = @cartid and albumid = @albumid");
            cmd.Parameters.AddWithValue("@cartid", GetCartId());
            cmd.Parameters.AddWithValue("@albumid", id);
            DataTable dt = DAO.GetDataTable(cmd);
            if (dt.Rows.Count == 0)
            {
                cartItem = new Cart
                {
                    AlbumID = id,
                    CartID = GetCartId(),
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                CartDAO.Insert(cartItem);
            }
            else
            {
                DataRow row = dt.Rows[0];
                cartItem = new Cart
                {
                    AlbumID = int.Parse(row["AlbumId"].ToString()),
                    CartID = row["CartId"].ToString(),
                    Count = int.Parse(row["Count"].ToString()),
                    DateCreated = DateTime.Now
                };
                cartItem.Count++;
                CartDAO.Update(cartItem);
            }
        }

        public void RemoveFromCart(int id)
        {
            // Get the cart
            // Get the matching cart and album instances
            var cartItem = GetCartItems().Where(c => c.AlbumID == id).First();
            int itemCount = 0;
            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                    CartDAO.Update(cartItem);
                }
                else
                {
                    CartDAO.Delete(ShoppingCartId, id);
                }
            }
        }

        public void EmptyCart() => CartDAO.Delete(ShoppingCartId);

        public string GetCartId()
        {
            if (Variable.Username != null) { 
                cartID = Variable.Username;
            }
            else if(Variable.Username == null)
            {
                if(cartID == null)
                {
                    Guid tempCartId = Guid.NewGuid();
                    cartID = tempCartId.ToString();
                }
                else
                {
                    return cartID;
                }
            }
            return cartID;
        }

        // When a user has logged in, migrate their shopping cart 
        // to be associated with their username
        public void MigrateCart()
        {
            CartDAO.MigrateCart(ShoppingCartId, UserName);
            cartID = UserName;
        }

        public void ResetCartID()
        {
            cartID = null;
        }
    }


}
