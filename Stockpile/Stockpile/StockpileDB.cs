using System;
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
     *      The purpose of this file is to be a connection to the database StockpileDB.accdb.
     */

    public class StockpileDB
    {
        public static OleDbConnection GetConnection()
        {
            
            // Change the Data Source File Browser
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\StockpileDB.accdb";
            OleDbConnection connection = new OleDbConnection(connectionString);
            return connection;
        }
    }
}
