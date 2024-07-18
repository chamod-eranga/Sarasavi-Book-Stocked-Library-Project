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
    public partial class ReservationProcess : Form
    {
        public ReservationProcess()
        {
            InitializeComponent();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            DisplayUserReservations();

        }

        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf"";Integrated Security = True";


        private void ReservationProcess_Load(object sender, EventArgs e)
        {

        }

        private void reservebook_btn_Click(object sender, EventArgs e)
        {
            // Retrieve data from text boxes and date picker
            string username = username_txt.Text.Trim();
            string bookID = bookid_txt.Text.Trim();
            DateTime borrowedDate = DateTime.Now;  // Current date
            DateTime returnDate = dateTimePicker1.Value.AddDays(7);  // Add 7 days to selected date

            // Check if the user has already reserved 5 books
            string countQuery = "SELECT COUNT(*) FROM User_Reservation WHERE Username = @Username";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(countQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    connection.Open();
                    int reservationCount = (int)command.ExecuteScalar();
                    if (reservationCount >= 5)
                    {
                        MessageBox.Show("You have already reserved 5 books. You cannot reserve more books.", "Reservation Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }


            // Check if the book ID exists in the BookRegistration table
            // and if there are available copies
            string query = "SELECT NumOfCopies FROM BookRegistration WHERE BookID = @BookID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookID);

                    connection.Open();

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        // Book exists
                        int numOfCopies = Convert.ToInt32(result);
                        if (numOfCopies > 0)
                        {
                            // Subtract one from the number of copies
                            numOfCopies--;

                            // Update the NumOfCopies and BorrowingStatus in the BookRegistration table
                            string updateQuery = @"UPDATE BookRegistration 
                                           SET NumOfCopies = @NumOfCopies, 
                                               BorrowingStatus = CASE 
                                                                     WHEN @NumOfCopies = 0 THEN 'Not available' 
                                                                     ELSE BorrowingStatus 
                                                                   END 
                                           WHERE BookID = @BookID";
                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("@NumOfCopies", numOfCopies);
                                updateCommand.Parameters.AddWithValue("@BookID", bookID);
                                updateCommand.ExecuteNonQuery();
                            }

                            // Insert a new record into the User_Reservation table
                            string insertQuery = "INSERT INTO User_Reservation (Username, BookID, BorrowedDate, ReturnDate) " +
                                                 "VALUES (@Username, @BookID, @BorrowedDate, @ReturnDate)";
                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@Username", username);
                                insertCommand.Parameters.AddWithValue("@BookID", bookID);
                                insertCommand.Parameters.AddWithValue("@BorrowedDate", borrowedDate);
                                insertCommand.Parameters.AddWithValue("@ReturnDate", returnDate);
                                insertCommand.ExecuteNonQuery();
                            }

                            // Display the return date
                            MessageBox.Show("The book is reserved successfully. Return date: " + returnDate.ToShortDateString(), "Reservation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields
                            username_txt.Clear();
                            bookid_txt.Clear();
                            dateTimePicker1.Value = DateTime.Now;  // Reset date picker to current date
                        }
                        else
                        {
                            MessageBox.Show("The book is not available.", "Reservation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The book does not exist.", "Reservation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void search_books_txt_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = search_books_txt.Text.Trim();

            // Build the SQL query to search for matching titles
            string query = "SELECT * FROM BookRegistration WHERE Title LIKE @Keyword";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add a wildcard (%) to search for titles containing the keyword
                    command.Parameters.AddWithValue("@Keyword", "%" + searchKeyword + "%");

                    connection.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Display the results in dataGridView2
                    dataGridView2.DataSource = dataTable;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.SelectedItem.ToString();

            // Query to fetch data based on selected borrowing status
            string query = "SELECT BookID, Title, BorrowingStatus, NumOfCopies FROM BookRegistration WHERE BorrowingStatus = @BorrowingStatus";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BorrowingStatus", selectedStatus);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Bind data to DataGridView
                    book_availability_dgv.DataSource = dataTable;
                }
            }
        }

        private void DisplayUserReservations()
        {
            // Query to select all data from User_Reservation table
            string query = "SELECT * FROM User_Reservation";

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
                    notify_borrowers_dgv.DataSource = dataTable;
                }
            }
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

        private void find_btn_Click(object sender, EventArgs e)
        {
            CheckReturnDates();

        }
    }
}
