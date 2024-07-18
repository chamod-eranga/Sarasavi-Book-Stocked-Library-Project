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
using System.Windows.Markup;

namespace Sarasavi_Book_library
{
    public partial class BookRegistration : Form
    {
        // Connection string to connect to the database
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf"";Integrated Security = True";

        public BookRegistration()
        {
            InitializeComponent();
            DisplayBookRegistrationData();

        }

        private void BookRegistration_Load(object sender, EventArgs e)
        {

        }

        private void DisplayBookRegistrationData()
        {
            // Query to select all data from BookRegistration table
            string query = "SELECT * FROM BookRegistration";

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
                    dataGridView3.DataSource = dataTable;
                }
            }
        }



        private void add_btn_Click(object sender, EventArgs e)
        {
            // Retrieve data from textboxes and comboboxes
            string bookID = bookID_txt.Text;
            string classification = classification_cmb.SelectedItem.ToString();
            string title = title_txt.Text;
            string publisher = publisher_txt.Text;
            string borrowingStatus = borrowable_status_cmb.SelectedItem.ToString();
            int numOfCopies = Convert.ToInt32(bookcopies_txt.Text);

            // SQL query to insert data into the BookRegistration table
            string query = "INSERT INTO BookRegistration (BookID, Classification, Title, Publisher, BorrowingStatus, NumOfCopies) " +
                           "VALUES (@BookID, @Classification, @Title, @Publisher, @BorrowingStatus, @NumOfCopies)";

            try
            {
                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create SQL command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@BookID", bookID);
                        command.Parameters.AddWithValue("@Classification", classification);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Publisher", publisher);
                        command.Parameters.AddWithValue("@BorrowingStatus", borrowingStatus);
                        command.Parameters.AddWithValue("@NumOfCopies", numOfCopies);

                        // Open the connection
                        connection.Open();

                        // Execute the command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected (i.e., if the insertion was successful)
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Book registration successful!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to register the book.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void bookID_txt_TextChanged(object sender, EventArgs e)
        {
            // Clear existing data in other textboxes and comboboxes
            ClearBookDetails();

            // Retrieve the entered BookID
            string bookID = bookID_txt.Text.Trim();

            // Check if the BookID is not empty
            if (!string.IsNullOrEmpty(bookID))
            {
                // Query to select book details based on the entered BookID
                string query = "SELECT * FROM BookRegistration WHERE BookID = @BookID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameter for BookID
                            command.Parameters.AddWithValue("@BookID", bookID);

                            // Open the connection
                            connection.Open();

                            // Execute the command
                            SqlDataReader reader = command.ExecuteReader();

                            // Check if a record with the entered BookID exists
                            if (reader.Read())
                            {
                                // Populate other textboxes and comboboxes with book details
                                classification_cmb.SelectedItem = reader["Classification"].ToString();
                                title_txt.Text = reader["Title"].ToString();
                                publisher_txt.Text = reader["Publisher"].ToString();
                                borrowable_status_cmb.SelectedItem = reader["BorrowingStatus"].ToString();
                                bookcopies_txt.Text = reader["NumOfCopies"].ToString();
                            }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void ClearBookDetails()
        {
            // Clear textboxes and comboboxes
            classification_cmb.SelectedIndex = -1;
            title_txt.Clear();
            publisher_txt.Clear();
            borrowable_status_cmb.SelectedIndex = -1;
            bookcopies_txt.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            // Update book details in the database
            string bookID = bookID_txt.Text.Trim();
            string classification = classification_cmb.SelectedItem.ToString();
            string title = title_txt.Text;
            string publisher = publisher_txt.Text;
            string borrowingStatus = borrowable_status_cmb.SelectedItem.ToString();
            int numOfCopies = Convert.ToInt32(bookcopies_txt.Text);

            string query = "UPDATE BookRegistration SET Classification = @Classification, Title = @Title, Publisher = @Publisher, BorrowingStatus = @BorrowingStatus, NumOfCopies = @NumOfCopies WHERE BookID = @OriginalBookID";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Classification", classification);
                        command.Parameters.AddWithValue("@Title", title);
                        command.Parameters.AddWithValue("@Publisher", publisher);
                        command.Parameters.AddWithValue("@BorrowingStatus", borrowingStatus);
                        command.Parameters.AddWithValue("@NumOfCopies", numOfCopies);
                        command.Parameters.AddWithValue("@OriginalBookID",bookID);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                            ClearBookDetails();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string bookID = bookID_txt.Text.Trim();

            // Check if the BookID is not empty
            if (!string.IsNullOrEmpty(bookID))
            {
                // Delete all records related to the BookID in the database
                string query = "DELETE FROM BookRegistration WHERE BookID = @BookID";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookID);

                            connection.Open();

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Delete all successful!");
                                ClearBookDetails();
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
            else
            {
                MessageBox.Show("Please enter a BookID.");
            }
        }
    }
}
