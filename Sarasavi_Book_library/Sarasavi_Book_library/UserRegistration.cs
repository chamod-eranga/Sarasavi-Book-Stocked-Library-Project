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
    public partial class UserRegistration : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf;Integrated Security=True";

        public UserRegistration()
        {
            InitializeComponent();

            DisplayUserRegistrationData();

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();
            string name = name_txt.Text.Trim();
            string gender = gender_cmb.SelectedItem.ToString();
            string nic = nic_txt.Text.Trim();
            string address = address_txt.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(nic) || string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Insert data into the UserRegistration table
            string query = "INSERT INTO UserRegistration ([Username], [Name], [Sex], [NationalIdentityCard], [Address]) VALUES (@Username, @Name, @Sex, @NationalIdentityCard, @Address)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Sex", gender);
                        command.Parameters.AddWithValue("@NationalIdentityCard", nic);
                        command.Parameters.AddWithValue("@Address", address);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registration successful!");
                            ClearFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ClearFields()
        {
            username_txt.Clear();
            name_txt.Clear();
            gender_cmb.SelectedIndex = -1;
            nic_txt.Clear();
            address_txt.Clear();
        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();

            // Check if the username is not empty
            if (!string.IsNullOrEmpty(username))
            {
                // Retrieve user details and populate other fields
                PopulateUserDetails(username);
            }
            else
            {
                // Clear other fields
                ClearUserDetails();
            }
        }

        private void PopulateUserDetails(string username)
        {
            string query = "SELECT * FROM UserRegistration WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        connection.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Populate other fields with user details
                            name_txt.Text = reader["Name"].ToString();
                            gender_cmb.SelectedItem = reader["Sex"].ToString();
                            nic_txt.Text = reader["NationalIdentityCard"].ToString();
                            address_txt.Text = reader["Address"].ToString();
                        } 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ClearUserDetails()
        {
            // Clear other fields
            name_txt.Clear();
            gender_cmb.SelectedIndex = -1;
            nic_txt.Clear();
            address_txt.Clear();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            // Delete all records related to the original username in the database
            string query = "DELETE FROM UserRegistration WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username_txt.Text);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Delete all successful!");
                            ClearUserDetails();
                        }
                        else
                        {
                            MessageBox.Show("No records were deleted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // Get the updated values from the text boxes and combo boxes
            string username = username_txt.Text.Trim();
            string name = name_txt.Text.Trim();
            string gender = gender_cmb.SelectedItem.ToString();
            string nic = nic_txt.Text.Trim();
            string address = address_txt.Text.Trim();

            // Update the corresponding record in the UserRegistration table
            string query = "UPDATE UserRegistration SET Name = @Name, Sex = @Sex, NationalIdentityCard = @NationalIdentityCard, Address = @Address WHERE Username = @Username";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Sex", gender);
                        command.Parameters.AddWithValue("@NationalIdentityCard", nic);
                        command.Parameters.AddWithValue("@Address", address);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successful update!");
                            ClearUserDetails();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayUserRegistrationData()
        {
            // Query to select all data from UserRegistration table
            string query = "SELECT * FROM UserRegistration";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Create a DataTable to hold the results
                    DataTable dataTable = new DataTable();

                    // Load the data from the query into the DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
        }


    }
}
