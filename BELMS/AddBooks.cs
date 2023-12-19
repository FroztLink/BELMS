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
using static BELMS.formSearch;

namespace BELMS
{
    public partial class formAddBooks : Form
    {
        const string connectionString = "Server=localhost;Database=finals_db;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public formAddBooks()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void Reload()
        {
            gridBookSearch.DataSource = null;
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            string query = "SELECT `Accession No.`, Title, Author, Category, Copyright, Section, Edition FROM `books` ORDER BY `category` ASC, `title`";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    gridBookSearch.DataSource = dataTable;
                }
            }
        }

        private void formAddBooks_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var accno = txtAccNo.Text;
                var title = txtTitle.Text;
                var author = txtAuthor.Text;
                var edition = txtEdition.Text;
                var copyright = txtCopyright.Text;
                var section = comboSection.SelectedItem;

                var categorySelectedItem = comboCategory.SelectedItem?.ToString();
                var category = (categorySelectedItem != null) ? categorySelectedItem.Split('(')[0].Trim() : null;

                MySqlCommand command = new MySqlCommand("INSERT INTO books (`Accession No.`, Title, Author, Edition, Copyright, Category, Section) VALUES ('" +
                accno + "','" +
                title + "','" +
                author + "','" +
                edition + "','" +
                copyright + "','" +
                category + "','" +
                section + "')"
                , connection);
                command.ExecuteNonQuery();
                Reload();

                MessageBox.Show("Book created successfully!");
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating book: " + ex.Message);
            }
        }

        private DataGridViewRow selectedRow;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridBookSearch.SelectedRows.Count > 0)
            {
                selectedRow = gridBookSearch.SelectedRows[0];

                txtAccNo.Text = selectedRow.Cells["Accession No."].Value.ToString();
                txtTitle.Text = selectedRow.Cells["Title"].Value.ToString();
                txtAuthor.Text = selectedRow.Cells["Author"].Value.ToString();
                txtEdition.Text = selectedRow.Cells["Edition"].Value.ToString();
                txtCopyright.Text = selectedRow.Cells["Copyright"].Value.ToString();
                comboSection.SelectedItem = selectedRow.Cells["Section"].Value.ToString();
                comboCategory.SelectedItem = selectedRow.Cells["Category"].Value.ToString();

                txtAccNo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }

            btnAdd.Enabled = false;
            btnClear.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNo.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtEdition.Text = string.Empty;
            txtCopyright.Text = string.Empty;
            comboCategory.SelectedIndex = -1;
            comboSection.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                try
                {
                    var accno = txtAccNo.Text;
                    var title = txtTitle.Text;
                    var author = txtAuthor.Text;
                    var edition = txtEdition.Text;
                    var copyright = txtCopyright.Text;
                    var section = comboSection.SelectedItem;

                    var categorySelectedItem = comboCategory.SelectedItem?.ToString();
                    var category = (categorySelectedItem != null) ? categorySelectedItem.Split('(')[0].Trim() : null;

                    MySqlCommand command = new MySqlCommand(
                        "UPDATE books SET " +
                        "Title = '" + title + "', " +
                        "Author = '" + author + "', " +
                        "Edition = '" + edition + "', " +
                        "Copyright = '" + copyright + "', " +
                        "Category = '" + category + "', " +
                        "Section = '" + section + "' " +
                        "WHERE `Accession No.` = '" + accno + "'", connection);

                    command.ExecuteNonQuery();
                    Reload();

                    MessageBox.Show("Book updated successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating book: " + ex.Message);
                }
                finally
                {
                    btnClear.Enabled = true;
                    selectedRow = null;
                    txtAccNo.Enabled = true;
                    btnClear.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void comboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSection.SelectedItem == null)
            { 
                
            }
            else if (comboSection.SelectedItem.ToString() == "SHS")
            {
                Globals.sFilter = "SHS";
                comboCategory.Items.Clear();
                comboCategory.Items.Add("000-099 (Research)");
                comboCategory.Items.Add("100-199 (Philosophy)");
                comboCategory.Items.Add("200-299 (Theology)");
                comboCategory.Items.Add("300-399 (Education)");
                comboCategory.Items.Add("400-499 (Linguistics)");
                comboCategory.Items.Add("500-599 (Mathematics)");
                comboCategory.Items.Add("600-699 (TLE)");
                comboCategory.Items.Add("700-799 (Arts)");
                comboCategory.Items.Add("800-899 (English)");
                comboCategory.SelectedIndex = 0;
            }
            else if (comboSection.SelectedItem.ToString() == "CIR")
            {
                Globals.sFilter = "CIR";
                comboCategory.Items.Clear();
                comboCategory.Items.Add("000-099 (General Works)");
                comboCategory.Items.Add("100-199 (Philosophy and Psychology)");
                comboCategory.Items.Add("200-299 (Religion)");
                comboCategory.Items.Add("300-399 (Social Science)");
                comboCategory.Items.Add("400-499 (Languages)");
                comboCategory.Items.Add("500-599 (Natural Science and Mathematics)");
                comboCategory.Items.Add("600-699 (Technology)");
                comboCategory.Items.Add("700-799 (Arts and Recreation)");
                comboCategory.Items.Add("800-899 (Literature)");
                comboCategory.Items.Add("900-999 (History and Geograhpy)");
                comboCategory.SelectedIndex = 0;
            }
            else
            {
                comboCategory.Items.Clear();
            }
        }
    }
}
