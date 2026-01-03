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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace smartVocabProject
{
    public partial class LoginForm : Form
    {
        string connectionString =
        @"Data Source=localhost;Initial Catalog=SmartVocab;Integrated Security=True";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"SELECT COUNT(*) 
                                     FROM Users 
                                     WHERE Email = @Email AND Password = @Password";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount == 1)
                    {
                        MessageBox.Show("Login Successful!",
                                        "Welcome",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        // Open Dashboard
                        DashboardForm dashboard = new DashboardForm();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
            this.Hide();
        }
    }
}
