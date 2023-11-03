using DoAn.view;
using MySqlX.XDevAPI;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DoAn.ultilities;
using MySql.Data.MySqlClient;

namespace DoAn
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            InitializeComponentRegister();
            this.BackColor = Color.FromArgb(252, 252, 252);
            DbCon = new MySQLConnect();
        }
        private MySQLConnect DbCon;

        public void RegisterUser()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (username.Contains(" "))
            {
                MessageBox.Show("Username cannot contain spaces.");
                return;
            }

            // Validate the password
            if (password.Length <= 6 || !IsPasswordValid(password))
            {
                MessageBox.Show("Password must have more than 6 characters, contain at least one letter (uppercase or lowercase), and at least one number.");
                return;
            }

            // Validate the phone number
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, "^0[0-9]{9,10}$"))
            {
                MessageBox.Show("Phone number must start with 0 and have 10 or 11 digits.");
                return;
            }

            // Check for the uniqueness of the username in the database
            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already taken. Please choose a different username.");
                return;
            }

            MySqlConnection connection = DbCon.GetConnection();
            connection.Open();
            string query = "INSERT INTO Users (Username, Password, PhoneNumber) VALUES (@Username, @Password, @PhoneNumber)";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration successful");
                    }
                    else
                    {
                        MessageBox.Show("Registration failed");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private bool IsPasswordValid(string password)
        {
            // Password must have more than 6 characters, contain at least one letter (uppercase or lowercase), and at least one number
            return password.Length > 6 &&
                   System.Text.RegularExpressions.Regex.IsMatch(password, "[a-zA-Z]") &&
                   System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]");
        }
        // kiem tra trung lap username
        private bool IsUsernameTaken(string username)
        {
            // Use the same MySQL connection from DbCon
            MySqlConnection connection = DbCon.GetConnection();
            connection.Open();

            string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

            try
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
            finally
            {
                connection.Close();
            }
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            this.RegisterUser();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
