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
    public partial class formUserRecords : Form
    {
        const string connectionString = "Server=localhost;Database=finals_db;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(connectionString);
        public formUserRecords()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void formUserRecords_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void Reload()
        {
            dataGridView1.DataSource = null;
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            string query = "SELECT * FROM users";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            panelStatus.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string user_ID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            
            if(radioActive.Checked)
            {
                MySqlCommand sqlCommand = new MySqlCommand("UPDATE `users` SET `status` = 'Active' WHERE user_ID = " + user_ID, connection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            else
            {
                if (user_ID == "1")
                {
                    MessageBox.Show("You can't disable ADMINISTRATOR/LIBRARIAN");
                }
                else
                {
                    MySqlCommand sqlCommand = new MySqlCommand("UPDATE `users` SET `status` = 'Disabled' WHERE user_ID = " + user_ID, connection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
            }
            Reload();
            
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            panelStatus.Enabled = false;
        }
    }
}
