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
using MySql.Data.MySqlClient;

namespace BELMS
{

    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=finals_db;Uid=root;Pwd='';");
                connection.Open();

                string username = txtUsername.Text;
                string password = txtPassword.Text;

                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE ID='" + username + "'", connection);
                MySqlCommand command2 = new MySqlCommand("SELECT user_ID FROM users WHERE ID='" + username + "' AND password='" + password + "'", connection);
                var result = command.ExecuteScalar();
                var result2 = command2.ExecuteScalar();



                if (result != null)
                {
                    if (result2 != null)
                    {
                        if (username.ToLower() == "admin")
                        {
                            Program.userID = result2.ToString();
                            MessageBox.Show("Login Successfully! :D");
                            formLibrarianDashboard pupuntaDun = new formLibrarianDashboard();
                            pupuntaDun.Show();
                        }
                        else
                        {
                            Program.userID = result2.ToString();
                            MySqlCommand sql = new MySqlCommand("SELECT status FROM `users` WHERE user_ID = " + Program.userID, connection);
                            string stat = sql.ExecuteScalar().ToString();
                            if(stat == "Active")
                            {
                                MessageBox.Show("Login Successfully! :D");
                                formUserDashboard pupuntaDun = new formUserDashboard();
                                pupuntaDun.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Account Disabled. Please contact Librarian");
                            }
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not Found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
