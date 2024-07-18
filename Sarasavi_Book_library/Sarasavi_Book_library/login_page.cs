using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarasavi_Book_library
{
    public partial class login_page : Form
    {
        public login_page()

        {
            InitializeComponent();
        }
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf;Integrated Security=True";


        private bool CheckAdminLogin(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM Admin_Login WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }


        private bool User_Login(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM User_Login WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }


        private void login_btn_Click(object sender, EventArgs e)
        {

            string username = username_txt.Text.Trim();
            string password = password_txt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // Check if the entered username and password exist in the User_Login table
            if (User_Login(username, password))
            {
                MessageBox.Show("Login successful!");

                // Create and show the home_page form
                home_page homePage = new home_page();
                homePage.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }

        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();
            string password = password_txt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            // Check if the entered username and password exist in the Admin_Login table
            if (CheckAdminLogin(username, password))
            {
                MessageBox.Show("Login successful!");

                // Create and show the home_page form
                home_page homePage = new home_page();
                homePage.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect.");
            }
        }


    }
}
