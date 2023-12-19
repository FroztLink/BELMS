using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BELMS
{
    public partial class formHistory : Form
    {
        const string connectionString = "Server=localhost;Database=finals_db;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public formHistory()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void formHistory_Load(object sender, EventArgs e)
        {

        }

        private void LoadDataFromDatabase()
        {
            string query = "SELECT books.`Accession No.` as 'Accession No.', books.title AS 'Title', logs.action AS 'Action', logs.description AS 'Description', logs.timestamp AS 'Timestamp' FROM books RIGHT JOIN logs ON logs.book_id = books.book_id WHERE logs.user_id =" + Program.userID + " ORDER BY logs.timestamp DESC";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataBorrow.DataSource = dataTable;
                }
            }
        }
    }
}
