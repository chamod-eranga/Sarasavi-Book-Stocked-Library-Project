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
    public partial class Loan_ReturnProcess : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf"";Integrated Security = True";

        public Loan_ReturnProcess()
        {
            InitializeComponent();

            DisplayUnavailableBooks();

        }

        private void username_txt_TextChanged(object sender, EventArgs e)
        {
            // Get the entered username
            string username = username_txt.Text;

            // Query to retrieve the corresponding BookID for the entered username
            string query = "SELECT BookID FROM User_Reservation WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameter for username
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();

                    // Execute the query and retrieve the BookID
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        // If BookID is found, fill the bookid_txt TextBox with it
                        bookid_txt.Text = result.ToString();
                        // Disable editing of the bookid_txt TextBox
                        bookid_txt.Enabled = false;
                    }
                    else
                    {
                        // If no corresponding BookID found, enable editing of the bookid_txt TextBox
                        bookid_txt.Enabled = true;
                        bookid_txt.Clear();
                    }
                }
            }
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Get the selected username
            string username = username_txt.Text;

            // Get the selected book ID
            string bookID = bookid_txt.Text;

            // Get the selected return date
            DateTime returnDate = dateTimePicker1.Value;

            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Calculate the delay in days
            int delayDays = (currentDate - returnDate).Days;

            if (delayDays > 0)
            {
                MessageBox.Show("The book has not been returned on time. Please return it as soon as possible.\nDelay: " + delayDays + " days", "Return Overdue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("The book has been returned on time. Please return it by the due date.", "Return On Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // If the book is returned, remove the user's reservation
            RemoveUserReservation(username);

            // If the book is returned late or on time, update NumOfCopies and BorrowingStatus
            UpdateBookAvailability(bookID);

        }

        private void RemoveUserReservation(string username)
        {
            // Query to delete the user's reservation
            string query = "DELETE FROM User_Reservation WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@Username", username);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdateBookAvailability(string bookID)
        {
            // Query to update book availability
            string query = "UPDATE BookRegistration SET NumOfCopies = NumOfCopies + 1, BorrowingStatus = CASE WHEN NumOfCopies = 0 THEN 'Available' ELSE BorrowingStatus END WHERE BookID = @BookID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CheckReturnDates()
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Query to select overdue reservations
            string query = "SELECT Username, BookID, DATEDIFF(day, GETDATE(), ReturnDate) AS DaysToReturn " +
                           "FROM User_Reservation " +
                           "WHERE ReturnDate < GETDATE()";

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

                    // Bind the DataTable to dataGridView1
                    dataGridView1.DataSource = dataTable;
                }
            }
        }


        private void find_btn_Click_1(object sender, EventArgs e)
        {
            CheckReturnDates();
        }

        private void DisplayUnavailableBooks()
        {
            // Query to select data where BorrowingStatus is not available
            string query = "SELECT * FROM BookRegistration WHERE BorrowingStatus != 'Available'";

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

                    // Bind the DataTable to dataGridView2
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

     
    }
}
