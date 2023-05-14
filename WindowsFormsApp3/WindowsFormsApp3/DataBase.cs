using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class DB
    {
        MySqlConnection connection; // Database connection object

        // Constructor
        public DB()
        {
            // Initialize the MySqlConnection object with the connection string
            connection = new MySqlConnection("########");
        }

        // Open the database connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        // Close the database connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        // Get the MySqlConnection object
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
