using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DoAn.ultilities;
using MySql.Data.MySqlClient;

namespace DoAn.view
{
    public partial class adminForm : Form
    {
        int currentPage = 1;
        int itemsPerPage = 4;
        int totalClients = 0;
        int totalPages = 0;
        public adminForm()
        {
            InitializeComponent();
            Load += new EventHandler(adminForm_Load);
            DbCon = new MySQLConnect();
        }
        private MySQLConnect DbCon;

        public int GetTotalClientsCount()
        {
            int totalClients = 0;
            try
            {
                using (MySqlConnection connection = DbCon.GetConnection())
                {
                    if (DbCon.OpenConnection())
                    {
                        string query = "SELECT COUNT(*) FROM Clients"; // Adjust the table name as per your database schema
                        MySqlCommand command = new MySqlCommand(query, connection);

                        totalClients = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle exceptions specific to MySQL
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                DbCon.CloseConnection();
            }

            return totalClients;
        }


        private void adminForm_Load(object sender, EventArgs e)
        {
            // Load total number of clients from the SQL database
            totalClients = GetTotalClientsCount(); // Implement this method

            // Calculate the total number of pages
            totalPages = (int)Math.Ceiling((double)totalClients / itemsPerPage);

            // Load the initial page
            LoadPage(currentPage);
        }
        private List<clientData1> GetClientsForPage(int page, int itemsPerPage)
        {
            List<clientData1> clients = new List<clientData1>();

            MySqlConnection connection = DbCon.GetConnection();

            if (connection != null)
            {
                try
                {
                    // Calculate the starting row for the current page
                    int startRow = (page - 1) * itemsPerPage;

                    // Build and execute your MySQL query to retrieve client data for the current page
                    string query = $"SELECT * FROM Clients ORDER BY ClientID LIMIT {startRow}, {itemsPerPage}";

                    using (MySqlCommand command = new MySqlCommand(query, connection)) // Define MySqlCommand
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Create clientData1 objects and populate them with data from the reader
                            clientData1 client = new clientData1
                            {
                                Name = reader["Name"].ToString(),
                                // Set other properties as needed
                            };
                            clients.Add(client);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle exceptions specific to MySQL
                    MessageBox.Show("Error retrieving client data: " + ex.Message);
                }
                finally
                {
                    DbCon.CloseConnection();
                }
            }

            return clients;
        }


        private void LoadPage(int page)
        {
            // Query the SQL database for client data for the current page
            List<clientData1> clients = GetClientsForPage(page, itemsPerPage); // Implement this method

            // Clear the FlowLayoutPanel
            clientLayout.Controls.Clear();

            // Add clientData controls to the FlowLayoutPanel
            foreach (var client in clients)
            {
                clientData1 clientControl = new clientData1();
                // Set properties of the clientData control using data from the database
                clientControl.CustomerName = client.Name;
                // Set other properties as needed
                clientLayout.Controls.Add(clientControl);
            }

            // Update the page count label
            pageCountLabel.Text = $"{currentPage} of {totalPages}";
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadPage(currentPage);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage(currentPage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                clientData1 customerPanel = new clientData1();
                customerPanel.CustomerName = "Customer " + i;
                customerPanel.CustomerPhone = "Phone " + i;
                customerPanel.RentedBooksCount = "So sach dang muon " + i;
                clientLayout.Controls.Add(customerPanel);
            }
        }
    }
}
