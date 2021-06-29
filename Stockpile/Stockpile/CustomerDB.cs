using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Stockpile
{
    /*
     * Author: Patrick Kelly
     * Date Created: 11/14/2018
     * Date Updated: --/--/----
     * File name: Database_Connections.class
     * Purpose:
     *      The purpose of this file is to act as a way for the program to access, insert, or manipulate
     *  Custoemr data.
     */

    public class CustomerDB
    {
        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 11/28/2018 - By: Patrick Kelly
         * Updated: 11/29/2018
         * 
         *        This static Stockpile objective method creates gets the login information that the user enters on
         *  the login form and runs it through the database, if it finds a match then it creates a new instance of
         *  the Stockpile class and returns the information to that class to transfer everything across the 
         *  application. Otherwise it returns null and throws an error message for the user.
         * 
         * Update Notes: 11/29/2018
         *        This method needs to get all the information from the user and send it to the stockpile class.
         *        
         * -------------------------------------------------------------------------------------------------------
         */

        public static Customer GetCustomer(TextBox user, TextBox pass)
        {
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT UserID, [Password], FirstName, LastName, Email "
                + "FROM CustomerDB "
                + "WHERE UserID = @ID "
                + "AND Password = @pass";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);

            // inserts the userID, and password into the select statement to retrieve a row of data.
            selectCommand.Parameters.AddWithValue("@ID", user.Text);
            selectCommand.Parameters.AddWithValue("@pass", pass.Text);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (customerReader.Read())
                {
                    // sets the user's ID and password from the database to lowercasevalues. 
                    string UserName = customerReader["UserID"].ToString();
                    string Password = customerReader["Password"].ToString();
                    UserName = UserName.ToLower();
                    Password = Password.ToLower();

                    // compares the user's entered ID to the ID in the database.
                    if (user.Text.ToLower() == UserName && pass.Text.ToLower() == Password)
                    {
                        // assigns this information to the database.
                        Customer customer = new Customer();
                        customer.UserName = customerReader["UserID"].ToString();
                        customer.Password = customerReader["Password"].ToString();
                        customer.Fname = customerReader["FirstName"].ToString();
                        customer.Lname = customerReader["LastName"].ToString();
                        customer.Email = customerReader["Email"].ToString();
                        return customer;
                    }
                    else
                    {
                        return null;
                    }
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

        public static Customer CreateUser(TextBox user, TextBox fName, TextBox lName, TextBox email, TextBox pass)
        {
            OleDbConnection connection = StockpileDB.GetConnection();
            string insertStatement =
                "INSERT INTO CustomerDB " +
                "(UserID, [Password], FirstName, LastName, Email) " +
                "VALUES (@User, @Pass, @f, @l, @email)";
            OleDbCommand insertCommand = new OleDbCommand(insertStatement, connection);


            insertCommand.Parameters.AddWithValue("@User", user.Text.Trim());
            insertCommand.Parameters.AddWithValue("@Pass", pass.Text.Trim());
            insertCommand.Parameters.AddWithValue("@f", fName.Text.Trim());
            insertCommand.Parameters.AddWithValue("@l", lName.Text.Trim());
            insertCommand.Parameters.AddWithValue("@email", email.Text.Trim());

            try
            {
                connection.Open();

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    Customer customer = new Customer();
                    customer.UserName = user.Text.Trim();
                    customer.Password = pass.Text.Trim();
                    customer.Fname = fName.Text.Trim();
                    customer.Lname = lName.Text.Trim();
                    customer.Email = email.Text.Trim();
                    return customer;
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
         * Created: 12/4/2018 - By: Patrick Kelly
         * 
         *        /
         *        
         * -------------------------------------------------------------------------------------------------------
         */

        public static Customer GetCustomerInformation(string user)
        {
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT UserID, [Password], FirstName, LastName, Email, HomePhone, MobilePhone "
                + "FROM CustomerDB "
                + "WHERE UserID = @ID";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);

            // inserts the userID, and password into the select statement to retrieve a row of data.
            selectCommand.Parameters.AddWithValue("@ID", user);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (customerReader.Read())
                {
                    // assigns this information to the database.
                    Customer customer = new Customer();
                    customer.UserName = customerReader["UserID"].ToString();
                    customer.Password = customerReader["Password"].ToString();
                    customer.Fname = customerReader["FirstName"].ToString();
                    customer.Lname = customerReader["LastName"].ToString();
                    customer.Email = customerReader["Email"].ToString();
                    return customer;
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
         * Created: 12/4/2018 - By: Patrick Kelly
         * Updated: 11/29/2018
         * 
         *        /
         *        
         * -------------------------------------------------------------------------------------------------------
         */

        public static Customer EditCustomer(TextBox user, string uName, string fName, string lName, TextBox email, TextBox home, TextBox mobile)
        {
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string updateStatement
                = "UPDATE CustomerDB "
                + "SET UserID = @ID, FirstName = @fName, LastName = @lName, Email = @eMail, HomePhone = @home, MobilePhone = @phone "
                + "WHERE UserID = @uName";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand updateCommand = new OleDbCommand(updateStatement, connection);



            // inserts the userID, and password into the select statement to retrieve a row of data.
            updateCommand.Parameters.AddWithValue("@ID", user.Text.ToString());
            updateCommand.Parameters.AddWithValue("@fName", fName);
            updateCommand.Parameters.AddWithValue("@lName", lName);
            updateCommand.Parameters.AddWithValue("@eMail", email.Text.ToString());
            updateCommand.Parameters.AddWithValue("@home", home.Text.ToString());
            updateCommand.Parameters.AddWithValue("@phone", mobile.Text.ToString());
            updateCommand.Parameters.AddWithValue("@uName", uName);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                OleDbTransaction transaction = connection.BeginTransaction();
                updateCommand.Transaction = transaction;
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    transaction.Commit();
                    // assigns this information to the database.
                    Customer customer = new Customer();
                    customer.UserName = user.Text.ToString();
                    customer.Fname = fName;
                    customer.Lname = lName;
                    customer.Email = email.Text.ToString();
                    customer.HomePhone = home.Text.ToString();
                    customer.MobilePhone = mobile.Text.ToString();
                    return customer;
                }
                else
                {
                    transaction.Rollback();

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
