using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace smartVocabProject
{
    public partial class LearnWordsForm : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=SmartVocab;Integrated Security=True";
        string userEmail;
        string selectedLevel;

        DataTable wordsTable;
        int currentIndex = 0;

        public event EventHandler WordLearned; // Event to notify MyVocabularyForm

        public LearnWordsForm(string email, string level)
        {
            InitializeComponent();
            userEmail = email;
            selectedLevel = level;
        }

        private void LearnWordsForm_Load(object sender, EventArgs e)
        {
            LoadWords();
            DisplayWord();
        }

        private void LoadWords()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT * FROM Vocabulary
                    WHERE Level = @Level
                    AND Id NOT IN
                    (
                        SELECT WordId FROM UsersWords WHERE UserEmail = @Email
                    )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Level", selectedLevel);
                cmd.Parameters.AddWithValue("@Email", userEmail);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                wordsTable = new DataTable();
                da.Fill(wordsTable);
            }
        }

        private void DisplayWord()
        {
            if (wordsTable.Rows.Count == 0 || currentIndex >= wordsTable.Rows.Count)
            {
                MessageBox.Show("You have completed this level 🎯");
                this.Close();
                return;
            }

            DataRow row = wordsTable.Rows[currentIndex];

            lblWord.Text = row["Word"].ToString();
            lblMeaning.Text = row["Meaning"].ToString();
            lblSentence.Text = row["Sentence"].ToString();
            lblProgress.Text = $"Word {currentIndex + 1} of {wordsTable.Rows.Count}";
            lblStatus.Text = ""; // Reset status
        }

        private void btnLearned_Click(object sender, EventArgs e)
        {
            int wordId = Convert.ToInt32(wordsTable.Rows[currentIndex]["Id"]);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"
                    IF NOT EXISTS (SELECT 1 FROM UsersWords WHERE UserEmail = @Email AND WordId = @WordId)
                    BEGIN
                        INSERT INTO UsersWords (UserEmail, WordId)
                        VALUES (@Email, @WordId)
                    END";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.Parameters.AddWithValue("@WordId", wordId);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    lblStatus.Text = "Word marked as learned ✔";
                    WordLearned?.Invoke(this, EventArgs.Empty); // Notify MyVocabularyForm
                }
                else
                {
                    lblStatus.Text = "Word already learned";
                }
            }

            // Remove word from table and show next
            wordsTable.Rows.RemoveAt(currentIndex);
            DisplayWord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentIndex++;
            DisplayWord();
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
