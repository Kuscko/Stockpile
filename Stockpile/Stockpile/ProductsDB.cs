using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Stockpile
{
    /*
     * Author: Patrick Kelly
     * Date Created: 11/30/2018
     * Date Updated: --/--/----
     * File name: Database_Connections.class
     * Purpose:
     *      The purpose of this file is to act as a way for the program to access, insert, or manipulate
     *  Products.
     */
    public class ProductsDB
    {

        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT ProductID, SupplierID, [Type], Name, [Description], Quantity, Price, Picture "
                + "FROM ProductDB "
                + "ORDER BY ProductID ASC ";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader();
                while (customerReader.Read())
                    {
                    
                        Products product = new Products();
                        product.ProductID = customerReader["ProductID"].ToString();
                        product.SupplierID = customerReader["SupplierID"].ToString();
                        product.Type = customerReader["Type"].ToString();
                        product.Name = customerReader["Name"].ToString();
                        product.Description = customerReader["Description"].ToString();
                        product.InStock = (int)customerReader["Quantity"];
                        product.Price = (decimal)customerReader["Price"];
                        product.Picture = customerReader["Picture"].ToString();

                        products.Add(product);
                    }
                
                return products;
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

        public static List<Products> SearchFilter(TextBox textbox)
        {
            List<Products> products = new List<Products>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT ProductID, SupplierID, [Type], Name, [Description], Quantity, Price, Picture "
                + "FROM ProductDB "
                + "WHERE Name LIKE @name "
                + "ORDER BY ProductID ASC";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@name", "%" + textbox.Text + "%");

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader();
                while (customerReader.Read())
                {

                    Products product = new Products();
                    product.ProductID = customerReader["ProductID"].ToString();
                    product.SupplierID = customerReader["SupplierID"].ToString();
                    product.Type = customerReader["Type"].ToString();
                    product.Name = customerReader["Name"].ToString();
                    product.Description = customerReader["Description"].ToString();
                    product.InStock = (int)customerReader["Quantity"];
                    product.Price = (decimal)customerReader["Price"];
                    product.Picture = customerReader["Picture"].ToString();

                    products.Add(product);
                }

                return products;
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

        public static List<Products> FilterByCategory(string type)
        {
            List<Products> products = new List<Products>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT ProductID, SupplierID, [Type], Name, [Description], Quantity, Price, Picture "
                + "FROM ProductDB "
                + "Where Type = @type "
                + "ORDER BY ProductID ASC";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@type", type);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader();
                while (customerReader.Read())
                {

                    Products product = new Products();
                    product.ProductID = customerReader["ProductID"].ToString();
                    product.SupplierID = customerReader["SupplierID"].ToString();
                    product.Type = customerReader["Type"].ToString();
                    product.Name = customerReader["Name"].ToString();
                    product.Description = customerReader["Description"].ToString();
                    product.InStock = (int)customerReader["Quantity"];
                    product.Price = (decimal)customerReader["Price"];
                    product.Picture = customerReader["Picture"].ToString();

                    products.Add(product);
                }

                return products;
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
