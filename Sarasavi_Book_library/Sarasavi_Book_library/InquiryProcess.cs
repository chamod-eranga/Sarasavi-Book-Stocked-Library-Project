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
    public partial class InquiryProcess : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf"";Integrated Security = True";

        public InquiryProcess()
        {
            InitializeComponent();
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
    }
}
