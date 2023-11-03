using MySqlX.XDevAPI;
using System;
using System.Drawing;
using System.Windows.Forms;
using DoAn.ultilities;
using MySql.Data.MySqlClient;

namespace DoAn.view
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(252, 252, 252);
            registerBox.BackColor = Color.FromArgb(206, 206, 206);
            DbCon = new MySQLConnect();
        }
        private MySQLConnect DbCon;
        private void registBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registForm = new RegisterForm();
            this.Hide();
            registForm.Show();
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Authenticate the user and retrieve the user's role from the database
            int userRole = AuthenticateUserAndGetRole(username, password);

            if (userRole == -1)
            {
                // Authentication failed
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            else if (userRole == 1)
            {
                // Admin user
                adminForm adminForm = new adminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                // Client user
                clientForm clientForm = new clientForm();
                clientForm.Show();
                this.Hide();
            }
        }

        private int AuthenticateUserAndGetRole(string username, string password)
        {
            int userRole = -1;
            using (MySqlConnection connection = DbCon.GetConnection())
            {
                connection.Open();

                // Use parameterized queries to prevent SQL injection
                string query = "SELECT Role FROM Users WHERE Username = @Username AND Password = @Password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        userRole = Convert.ToInt32(reader["Role"]);
                    }
                }
            }

            return userRole;
        }
    }
}
