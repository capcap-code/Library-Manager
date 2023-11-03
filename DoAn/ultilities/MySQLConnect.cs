using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DoAn.ultilities
{
    public class MySQLConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public MySQLConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "ct467_project";
            uid = "tuanhuy";
            password = "";
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            connection = new MySqlConnection(connectionString);
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle connection errors
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle connection closing errors
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }

}
