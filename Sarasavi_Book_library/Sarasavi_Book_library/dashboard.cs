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
    public partial class dashboard : Form
    {
        private string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=""F:\Assignment\1-Sac Project\Sarasavi Book stocked library\Sarasavi_Book_library\Sarasavi_Book_library\SarasaviLibraryDatabase.mdf"";Integrated Security = True";

        public dashboard()
        {
            InitializeComponent();
            DisplayBookRegistrationData();

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
                    dataGridView1.DataSource = dataTable;
                }
            }
        }


    }
}
