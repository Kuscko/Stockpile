using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stockpile
{
    public class BillingAndShippingInfoDB
    {
        // Get States
        public static List<States> GetStates()
        {
            List<States> states = new List<States>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses thse parameter @ID
            string selectStatement
                = "SELECT * "
                + "FROM States "
                + "ORDER BY StateID ASC";
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

                    States state = new States();
                    state.StateID = customerReader["StateID"].ToString();
                    state.StateName = customerReader["StateName"].ToString();
                    state.StateTax = customerReader["StateTax"].ToString();
                    states.Add(state);
                }

                return states;
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

        // Get Billing Information
        public static List<BillingInfo> GetBillingInfo(string user)
        {
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT * "
                + "FROM BillingInfoDB "
                + "WHERE UserID = @ID";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@ID", user);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader();
                while (customerReader.Read())
                {
                    /*
                     BillingID, UserID, 
                     CardNumber, CardType, 
                     ExpirationDate, SecurityCode, 
                     BillingAddressLine1, BillingAddressLine2, 
                     City, StateID, Zip-Code
                     */

                    BillingInfo info = new BillingInfo();
                    info.CardNumber = customerReader["CardNumber"].ToString();
                    info.CardType = customerReader["CardType"].ToString();
                    info.ExpirationDate = customerReader["ExpirationDate"].ToString();
                    info.SecurityCode = customerReader["SecurityCode"].ToString();
                    info.BillingAddr1 = customerReader["BillingAddressLine1"].ToString();
                    info.BillingAddr2 = customerReader["BillingAddressLine2"].ToString();
                    info.City = customerReader["City"].ToString();
                    info.State = customerReader["StateID"].ToString();
                    info.ZipCode = customerReader["ZipCode"].ToString();

                    billingInfo.Add(info);
                }

                return billingInfo;
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

        // Main forms billing info assignment
        public static List<BillingInfo> mainGetBillingInfo(string user, string tax)
        {
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT * "
                + "FROM BillingInfoDB "
                + "WHERE UserID = @ID";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@ID", user);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader();
                while (customerReader.Read())
                {
                    /*
                     BillingID, UserID, 
                     CardNumber, CardType, 
                     ExpirationDate, SecurityCode, 
                     BillingAddressLine1, BillingAddressLine2, 
                     City, StateID, Zip-Code
                     */

                    BillingInfo info = new BillingInfo();
                    info.CardNumber = customerReader["CardNumber"].ToString();
                    info.CardType = customerReader["CardType"].ToString();
                    info.ExpirationDate = customerReader["ExpirationDate"].ToString();
                    info.SecurityCode = customerReader["SecurityCode"].ToString();
                    info.BillingAddr1 = customerReader["BillingAddressLine1"].ToString();
                    info.BillingAddr2 = customerReader["BillingAddressLine2"].ToString();
                    info.City = customerReader["City"].ToString();
                    info.State = customerReader["StateID"].ToString();
                    info.ZipCode = customerReader["ZipCode"].ToString();
                    info.StateTax = tax;

                    billingInfo.Add(info);
                }

                return billingInfo;
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

        // Update Billing Information
        /*
         * -------------------------------------------------------------------------------------------------------
         * 
         * Created: 12/4/2018 - By: Patrick Kelly
         * Updated: 11/29/2018
         * 
         *        Updates an Existing Billing information based on the user's Cardnumber(Which cannot be changed and is unique)
         *        
         * -------------------------------------------------------------------------------------------------------
         */

        public static List<BillingInfo> UpdateBillingInfo(TextBox type, string tax, string user, string state, string cardNum, string expiration, TextBox security, TextBox billingAddr1, TextBox billingAddrO, TextBox city, MaskedTextBox zipcode)
        {
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string updateStatement
                = "UPDATE BillingInfoDB "
                + "SET BillingAddressLine1 = @bAddr1, BillingAddressLine2 = @bAddr2, City = @city, StateID = @sID, ZipCode = @zip "
                + "WHERE CardNumber = @cNum";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand updateCommand = new OleDbCommand(updateStatement, connection);

            // inserts the userID, and password into the select statement to retrieve a row of data.
            
            updateCommand.Parameters.AddWithValue("@bAddr1", billingAddr1.Text.Trim());
            updateCommand.Parameters.AddWithValue("@bAddr2", billingAddrO.Text.Trim());
            updateCommand.Parameters.AddWithValue("@city", city.Text.Trim());
            updateCommand.Parameters.AddWithValue("@sID", state);
            updateCommand.Parameters.AddWithValue("@zip", zipcode.Text.Trim());
            updateCommand.Parameters.AddWithValue("@cNum", cardNum);

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
                    BillingInfo billing = new BillingInfo();
                    billing.CardNumber = cardNum;
                    billing.CardType = type.Text.Trim();
                    billing.ExpirationDate = expiration;
                    billing.SecurityCode = security.Text.Trim();
                    billing.BillingAddr1 = billingAddr1.Text.Trim();
                    billing.BillingAddr2 = billingAddrO.Text.Trim();
                    billing.City = city.Text.Trim();
                    billing.State = state;
                    billing.ZipCode = zipcode.Text.Trim();
                    billing.StateTax = tax;

                    billingInfo.Add(billing);

                    return billingInfo;
                }
                else
                {
                    //transaction.Rollback();

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

        // Create New Billing Info
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

        public static List<BillingInfo> CreatBillingInfo(string type, string tax, string user, string state, string cardNum, string expiration, TextBox security, TextBox billingAddr1, TextBox billingAddrO, TextBox city, MaskedTextBox zipcode)
        {
            List<BillingInfo> billingInfo = new List<BillingInfo>();
            OleDbConnection connection = StockpileDB.GetConnection();
            string insertStatement =
                "INSERT INTO BillingInfoDB " +
                "(UserID, CardNumber, CardType, ExpirationDate, SecurityCode, BillingAddressLine1, BillingAddressLine2, City, StateID, ZipCode) " +
                "VALUES (@User, @cNum, @cType, @expir, @code, @bAddr1, @bAddr2, @city, @sID, @zip)";
            OleDbCommand insertCommand = new OleDbCommand(insertStatement, connection);


            insertCommand.Parameters.AddWithValue("@User", user);
            insertCommand.Parameters.AddWithValue("@cNum", cardNum);
            insertCommand.Parameters.AddWithValue("@cType", type);
            insertCommand.Parameters.AddWithValue("@expir", expiration);
            insertCommand.Parameters.AddWithValue("@code", security.Text.Trim());
            insertCommand.Parameters.AddWithValue("@bAddr1", billingAddr1.Text.Trim());
            insertCommand.Parameters.AddWithValue("@bAddr2", billingAddrO.Text.Trim());
            insertCommand.Parameters.AddWithValue("@city", city.Text.Trim());
            insertCommand.Parameters.AddWithValue("@sID", state);
            insertCommand.Parameters.AddWithValue("@zip", zipcode.Text.Trim());


            try
            {
                connection.Open();

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    BillingInfo billing = new BillingInfo();
                    billing.CardNumber = cardNum;
                    billing.CardType = type;
                    billing.ExpirationDate = expiration;
                    billing.SecurityCode = security.Text.Trim();
                    billing.BillingAddr1 = billingAddr1.Text.Trim();
                    billing.BillingAddr2 = billingAddrO.Text.Trim();
                    billing.City = city.Text.Trim();
                    billing.State = state;
                    billing.ZipCode = zipcode.Text.Trim();
                    billing.StateTax = tax;

                    billingInfo.Add(billing);
                    return billingInfo;
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

        // Get Shipping Information
        public static List<ShippingInfo> GetShippingInformation(string user)
        {
            List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string selectStatement
                = "SELECT * "
                + "FROM ShippingInfoDB "
                + "WHERE UserID = @ID";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand selectCommand = new OleDbCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ID", user.Trim());

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataReader Object that executes a reader and retrieves a single row.
                OleDbDataReader customerReader = selectCommand.ExecuteReader();
                while (customerReader.Read())
                {

                    ShippingInfo info = new ShippingInfo();
                    info.ShippingAddr1 = customerReader["AddressLine1"].ToString();
                    info.ShippingAddr2 = customerReader["AddressLine2"].ToString();
                    info.City = customerReader["City"].ToString();
                    info.State = customerReader["StateID"].ToString();
                    info.ZipCode = customerReader["ZipCode"].ToString();

                    shippingInfo.Add(info);
                }

                return shippingInfo;
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

        // Update Shipping Information shippingId, selectedState, tboShippingAdr, tboShippingAddrO, tboCityShipping, tboShippingZipcode
        public static List<ShippingInfo> UpdateShippingInfo(string state, string addr, TextBox shippingAddr1, TextBox shippingAddrO, TextBox city, MaskedTextBox zipcode)
        {
            List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
            // creates a connection to the database.
            OleDbConnection connection = StockpileDB.GetConnection();
            // SQL Select Statement that uses the parameter @ID
            string updateStatement
                = "UPDATE ShippingInfoDB "
                + "SET AddressLine1 = @bAddr1, AddressLine2 = @bAddr2, [City] = @city, [StateID] = @sID, [ZipCode] = @zip "
                + "WHERE AddressLine1 = @sAddr1";
            // selects data from the database using the 'connection' string and with the 'selectStatement'
            OleDbCommand updateCommand = new OleDbCommand(updateStatement, connection);

            // inserts the userID, and password into the select statement to retrieve a row of data.

            updateCommand.Parameters.AddWithValue("@bAddr1", shippingAddr1.Text.Trim());
            updateCommand.Parameters.AddWithValue("@bAddr2", shippingAddrO.Text.Trim());
            updateCommand.Parameters.AddWithValue("@city", city.Text.Trim());
            updateCommand.Parameters.AddWithValue("@sID", state);
            updateCommand.Parameters.AddWithValue("@zip", zipcode.Text.Trim());
            updateCommand.Parameters.AddWithValue("@sAddr1", addr);

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
                    ShippingInfo shipping = new ShippingInfo();
                    shipping.ShippingAddr1 = shippingAddr1.Text.Trim();
                    shipping.ShippingAddr2 = shippingAddrO.Text.Trim();
                    shipping.City = city.Text.Trim();
                    shipping.State = state;
                    shipping.ZipCode = zipcode.Text.Trim();

                    shippingInfo.Add(shipping);

                    return shippingInfo;
                }
                else
                {
                    //transaction.Rollback();

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

        // Create Shipping Information
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
        public static List<ShippingInfo> CreateShippingInfo(string user, string state, TextBox shippingAddr1, TextBox shippingAddrO, TextBox city, MaskedTextBox zipcode)
        {
            List<ShippingInfo> shippingInfo = new List<ShippingInfo>();
            OleDbConnection connection = StockpileDB.GetConnection();
            string insertStatement =
                "INSERT INTO ShippingInfoDB " +
                "(UserID, AddressLine1, AddressLine2, City, StateID, ZipCode) " +
                "VALUES (@User, @bAddr1, @bAddr2, @city, @sID, @zip)";
            OleDbCommand insertCommand = new OleDbCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@user", user);
            insertCommand.Parameters.AddWithValue("@bAddr1", shippingAddr1.Text.Trim());
            insertCommand.Parameters.AddWithValue("@bAddr2", shippingAddrO.Text.Trim());
            insertCommand.Parameters.AddWithValue("@city", city.Text.Trim());
            insertCommand.Parameters.AddWithValue("@sID", state);
            insertCommand.Parameters.AddWithValue("@zip", zipcode.Text.Trim());


            try
            {
                connection.Open();

                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    ShippingInfo shipping = new ShippingInfo();
                    shipping.ShippingAddr1 = shippingAddr1.Text.Trim();
                    shipping.ShippingAddr2 = shippingAddrO.Text.Trim();
                    shipping.City = city.Text.Trim();
                    shipping.State = state;
                    shipping.ZipCode = zipcode.Text.Trim();

                    shippingInfo.Add(shipping);
                    return shippingInfo;
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
