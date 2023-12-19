using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace BELMS
{
    public partial class formAddAccount : Form
    {
        const string connectionString = "Server=localhost;Database=finals_db;Uid=root;Pwd='';";
        MySqlConnection connection = new MySqlConnection(connectionString);

        public formAddAccount()
        {
            InitializeComponent();
        }

        private void formAddAccount_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var ID = txtID.Text;
                var fname = txtFname.Text;
                var lname = txtLname.Text;
                var grade = comboGrade.SelectedItem;
                var section = comboSection.SelectedItem;
                var phone = txtPhone.Text;
                var email = txtEmail.Text;
                var password = txtPassword.Text;
                var check = txtCheckPass.Text;

                string status = radioActive.Checked ? "Active" : radioBlocked.Checked ? "Disabled" : null;

                if (string.IsNullOrEmpty(ID) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) ||
                    comboGrade.SelectedItem == null || comboSection.SelectedItem == null ||
                    string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(password) || string.IsNullOrEmpty(check))
                {
                    MessageBox.Show("Please fill up all the fields!");
                    return;
                }

                if (status == null)
                {
                    MessageBox.Show("Please select a status!");
                    return;
                }

                string userType = radioStudent.Checked ? "Student" : radioFaculty.Checked ? "Faculty" : null;

                if (userType == null)
                {
                    MessageBox.Show("Please select a user type!");
                    return;
                }

                if (password == check)
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO users (ID, F_name, L_name, Grade, Section, Phone, Email, Password, Usertype, Status) VALUES ('" +
                    ID + "','" +
                    fname + "','" +
                    lname + "','" +
                    grade + "','" +
                    section + "','" +
                    phone + "','" +
                    email + "','" +
                    password + "','" +
                    userType + "','" +
                    status + "')"
                    , connection);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Account created successfully!");
                }

                else
                {
                    MessageBox.Show("Password confirmation incorrect!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account: " + ex.Message);
            }
        }

        private void CheckPass(object sender, KeyEventArgs e)
        {
            string passw = txtPassword.Text;
            string check = txtCheckPass.Text;

            if (passw == check)
            {
                lblPassCheck.Text = "*Password matched!";
                lblPassCheck.ForeColor = Color.Green;
            }
            else
            {
                lblPassCheck.Text = "*Password mismatch!";
                lblPassCheck.ForeColor = Color.Red;
            }

        }
    }
}
