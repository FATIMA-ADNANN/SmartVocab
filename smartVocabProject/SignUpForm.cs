using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace smartVocabProject
{
    public partial class SignUpForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=SmartVocab;Integrated Security=True";

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Read inputs
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // 1️⃣ Empty field check
            if (firstName == "" || lastName == ""  ||
                email == "" || password == "" || confirmPassword == "")
            {
                MessageBox.Show("Please fill in all fields.",
                                "Missing Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 2️⃣ Email validation
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.",
                                "Invalid Email",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // 3️⃣ Password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.",
                                "Weak Password",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // 4️⃣ Password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.",
                                "Password Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // 5️⃣ Insert into Database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string query = @"INSERT INTO Users
                                     (FirstName, LastName, Email, Password)
                                     VALUES
                                     (@FirstName, @LastName, @Email, @Password)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!",
                                    "Success",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    ClearFields();
                }
                catch (SqlException ex)
                {
                    // UNIQUE constraint violation
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("Username or Email already exists.",
                                        "Duplicate Entry",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message,
                                        "Database Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConfirmPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
