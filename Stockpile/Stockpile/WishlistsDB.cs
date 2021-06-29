using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Stockpile
{
    public class WishlistsDB
    {
                /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/29/2018 - By: Patrick Kelly
         * Updated: null
         * 
         *      This static Stockpile objective method creates a new customer based on the information that the
         * user enters. This information is processed and put to the Stockpile Object. Afterward it returns the 
         * object stockpile on success, null otherwise. 
         *
         * -------------------------------------------------------------------------------------------------------
         */

        public static List<Wishlists> CreateWishlistItem(string user, string listName)
        {
            List<Wishlists> wishlists = new List<Wishlists>();
            OleDbConnection connection = StockpileDB.GetConnection();
            string insertStatement =
                "INSERT INTO UserWishlists " +
                "(ListName, UserID) " +
                "VALUES (@lName, @ID)";
            OleDbCommand insertCommand = new OleDbCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@lName", user);
            insertCommand.Parameters.AddWithValue("@ID", listName);

            try
            {
                connection.Open();

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    Wishlists wishlist = new Wishlists();
                    wishlist.UserID = user;
                    wishlist.ListName = listName;
                    wishlists.Add(wishlist);
                    return wishlists;
                }
                else
                {
                    return null;
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        /*
  * -------------------------------------------------------------------------------------------------------
  * 
  * Created: 11/29/2018 - By: Patrick Kelly
  * Updated: null
  * 
  *      This static Stockpile objective method creates a new customer based on the information that the
  * user enters. This information is processed and put to the Stockpile Object. Afterward it returns the 
  * object stockpile on success, null otherwise. 
  *
  * -------------------------------------------------------------------------------------------------------
  */

        public static List<Wishlists> CreateWishlistItem(string listName, string prodName, string desc, string quantity, string price)
        {
            List<Wishlists> wishlists = new List<Wishlists>();
            OleDbConnection connection = StockpileDB.GetConnection();
            string insertStatement =
                "INSERT INTO WishlistDB " +
                "(ListName, ProductName, ProductDescription, Quantity, Price) " +
                "VALUES (@lName, @pName, @pDesc, @pQuantity, @pPrice)";
            OleDbCommand insertCommand = new OleDbCommand(insertStatement, connection);
            
            insertCommand.Parameters.AddWithValue("@lName", listName);
            insertCommand.Parameters.AddWithValue("@pName", prodName);
            insertCommand.Parameters.AddWithValue("@pDesc", desc);
            insertCommand.Parameters.AddWithValue("@pQuantity", quantity);
            insertCommand.Parameters.AddWithValue("@pPrice", price);
        
            try
            {
                connection.Open();

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    WishlistItems items = new WishlistItems();
                    items.ListName = listName;
                    items.ProductName = prodName;
                    items.ProductDescription = desc;
                    items.Quantity = Convert.ToInt32(quantity);
                    items.Price = Convert.ToDecimal(price);
                    return wishlists;
                }
                else
                {
                    return null;
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
