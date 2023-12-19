using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELMS
{
    public partial class formRecords : Form
    {
        const string connectionString = "Server=localhost;Database=finals_db;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public formRecords()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void formRecords_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void Reload()
        {
            dataBorrowed.DataSource = null;
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            string query = "SELECT ab.active_id as 'Record ID', b.`Accession No.` AS 'Accession No.', b.title AS 'Title', u.ID AS 'User ID', ab.borrow_date 'Date Borrowed', ab.return_date 'Return Date' FROM active_books ab INNER JOIN books b ON ab.book_id = b.book_id INNER JOIN users u ON ab.user_id = u.user_id";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataBorrowed.DataSource = dataTable;
                }
            }
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string currentDate = now.ToString("yyyy-MM-dd");
            DateTime plus7 = now.AddDays(7);
            string returnDate = plus7.ToString("yyyy-MM-dd");
            string index = dataBorrowed.SelectedRows[0].Cells[0].Value.ToString();
            MySqlCommand sql = new MySqlCommand("DELETE FROM active_books WHERE active_id = " + index, connection);
            sql.ExecuteNonQuery();

            MessageBox.Show("The book has been returned.");
            Reload();
        }
    }
}
