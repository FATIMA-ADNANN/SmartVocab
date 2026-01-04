using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smartVocabProject
{
    public partial class SignUpForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=SmartVocab;Integrated Security=True";

        public SignUpForm()
        {
            InitializeComponent();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string fName = txtFirstName.Text.Trim();
            string lName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;
            string cPass = txtConfirmPassword.Text;

            // Validation
            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please fill in all fields.", "SmartVocab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Invalid Email format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pass != cPass)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Optional: check if email already exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email=@EM", con);
                    checkCmd.Parameters.AddWithValue("@EM", email);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Email already registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "INSERT INTO Users (FirstName, LastName, Email, Password) VALUES (@FN, @LN, @EM, @PW)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FN", fName);
                    cmd.Parameters.AddWithValue("@LN", lName);
                    cmd.Parameters.AddWithValue("@EM", email);
                    cmd.Parameters.AddWithValue("@PW", pass); // plain text password

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Go to Login
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lnklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
