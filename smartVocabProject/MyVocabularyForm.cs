using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smartVocabProject
{
    public partial class MyVocabularyForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=SmartVocab;Integrated Security=True";
        string userEmail;

        public MyVocabularyForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void MyVocabularyForm_Load(object sender, EventArgs e)
        {
            LoadMyVocabulary(); // initial load
        }

        // Automatically refresh whenever form gets focus
        private void MyVocabularyForm_Activated(object sender, EventArgs e)
        {
            LoadMyVocabulary();
        }

        // Method to load learned words
        public void LoadMyVocabulary()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            V.Word,
                            V.Meaning,
                            V.Sentence,
                            V.Level,
                            UW.LearnedOn
                        FROM UsersWords UW
                        INNER JOIN Vocabulary V ON UW.WordId = V.Id
                        WHERE UW.UserEmail = @Email
                        ORDER BY UW.LearnedOn DESC";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", userEmail);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMyVocab.DataSource = dt;
                }

                // DataGridView formatting
                dgvMyVocab.ReadOnly = true;
                dgvMyVocab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvMyVocab.MultiSelect = false;
                dgvMyVocab.AllowUserToAddRows = false;
                dgvMyVocab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vocabulary: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
