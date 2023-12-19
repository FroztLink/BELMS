using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BELMS
{
    public partial class formSearch : Form
    {
        const string connectionString = "Server=localhost;Database=finals_db;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public static class Globals
        {
            public static string byColumn = "Accession No.";
            public static string cFilter = "%";
            public static string sFilter = "%";
        }
        public formSearch()
        {
            InitializeComponent();
            LoadDataFromDatabase();

            txtSearch.KeyUp += TxtSearch_KeyUp;

            comboBy.SelectedIndexChanged += ComboBy_SelectedIndexChanged;
            comboSection.SelectedIndexChanged += ComboSection_SelectedIndexChanged;
            comboCategory.SelectedIndexChanged += ComboCategory_SelectedIndexChanged;
        }

        private void ComboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridBookSearch.DataSource = null;
            switch (comboCategory.SelectedIndex)
            {
                case 0:
                    Globals.cFilter = "%";
                    break;
                case 1:
                    Globals.cFilter = "000-099";
                    break;
                case 2:
                    Globals.cFilter = "100-199";
                    break;
                case 3:
                    Globals.cFilter = "200-299";
                    break;
                case 4:
                    Globals.cFilter = "300-399";
                    break;
                case 5:
                    Globals.cFilter = "400-499";
                    break;
                case 6:
                    Globals.cFilter = "500-599";
                    break;
                case 7:
                    Globals.cFilter = "600-699";
                    break;
                case 8:
                    Globals.cFilter = "700-799";
                    break;
                case 9:
                    Globals.cFilter = "800-899";
                    break;
                case 10:
                    Globals.cFilter = "900-999";
                    break;
                default:
                    Globals.cFilter = "%";
                    break;
            }
            LoadDataFromDatabase();
        }

        private void ComboBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.byColumn = comboBy.SelectedItem.ToString();
        }

        private void ComboSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridBookSearch.DataSource = null;
            if (comboSection.SelectedItem.ToString() == "SHS")
            {
                Globals.sFilter = "SHS";
                comboCategory.Items.Clear();
                comboCategory.Items.Add("<Any Category>");
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
            else if(comboSection.SelectedItem.ToString() == "CIR")
            {
                Globals.sFilter = "CIR";
                comboCategory.Items.Clear();
                comboCategory.Items.Add("<Any Category>");
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
            else if(comboSection.SelectedItem.ToString() == "<Any Section>")
            {
                Globals.sFilter = "%";
                comboCategory.Items.Clear();
                comboCategory.Items.Add("<Any Category>");
                comboCategory.SelectedIndex = 0;
            }
            LoadDataFromDatabase();
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            gridBookSearch.DataSource = null;
            string entry = txtSearch.Text;
            string sql = "SELECT `Accession No.`, Title, Author, Edition, Copyright, Category, Section FROM `books` WHERE `" + Globals.byColumn + "` LIKE '%" + entry + "%' AND Category LIKE '" + Globals.cFilter + "' AND Section LIKE'" + Globals.sFilter + "'";

            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    gridBookSearch.DataSource = dataTable;
                }
            }
        }

        private void formSearch_Load(object sender, EventArgs e)
        {
            connection.Open();

            comboBy.Items.Insert(0, "Accession No.");
            comboSection.Items.Insert(0, "<Any Section>");
            comboSection.Items.Add("CIR");

            comboBy.SelectedIndex = 0;
            comboSection.SelectedIndex = 0;
        }
        private void LoadDataFromDatabase()
        {
            string entry = txtSearch.Text;
            //string query = "SELECT `Accession No.`, Title, Author, Edition, Copyright, Category, Section FROM `books`";
            string query = "SELECT `Accession No.`, Title, Author, Edition, Copyright, Category, Section FROM `books` WHERE `" + Globals.byColumn + "` LIKE '%" + entry + "%' AND Category LIKE '" + Globals.cFilter + "' AND Section LIKE'" + Globals.sFilter + "'";

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
    }
}
