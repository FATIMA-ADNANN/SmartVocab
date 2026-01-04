using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace smartVocabProject
{
    public partial class PracticeQuizForm : Form
    {
        string connectionString =
            @"Data Source=localhost;Initial Catalog=SmartVocab;Integrated Security=True";

        string userEmail;
        DataTable quizTable;
        int currentIndex = 0;
        int score = 0;

        public PracticeQuizForm(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void PracticeQuizForm_Load(object sender, EventArgs e)
        {
            LoadQuizQuestions();
            DisplayQuestion();
        }

        private void LoadQuizQuestions()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT V.Word, V.Meaning
                FROM UsersWords UW
                INNER JOIN Vocabulary V ON UW.WordId = V.Id
                WHERE UW.UserEmail = @Email
                ORDER BY NEWID()";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", userEmail);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                quizTable = new DataTable();
                da.Fill(quizTable);
            }
        }

        private void DisplayQuestion()
        {
            if (quizTable.Rows.Count == 0)
            {
                MessageBox.Show("No learned words available for quiz.");
                this.Close();
                return;
            }

            if (currentIndex >= quizTable.Rows.Count)
            {
                FinishQuiz();
                return;
            }

            lblQuestion.Text = $"What is the meaning of '{quizTable.Rows[currentIndex]["Word"]}'?";
            lblProgress.Text = $"Question {currentIndex + 1} of {quizTable.Rows.Count}";

            LoadOptions();
        }

        private void LoadOptions()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string correctMeaning = quizTable.Rows[currentIndex]["Meaning"].ToString();

                string query = @"SELECT TOP 4 Meaning FROM Vocabulary ORDER BY NEWID()";
                SqlCommand cmd = new SqlCommand(query, con);

                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                var options = dt.AsEnumerable()
                                .Select(r => r["Meaning"].ToString())
                                .ToList();

                if (!options.Contains(correctMeaning))
                    options[0] = correctMeaning;

                options = options.OrderBy(x => Guid.NewGuid()).ToList();

                rbOption1.Text = options[0];
                rbOption2.Text = options[1];
                rbOption3.Text = options[2];
                rbOption4.Text = options[3];

                rbOption1.Checked = rbOption2.Checked =
                rbOption3.Checked = rbOption4.Checked = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string selectedAnswer = GetSelectedOption();

            if (selectedAnswer == "")
            {
                MessageBox.Show("Please select an option.");
                return;
            }

            string correctAnswer = quizTable.Rows[currentIndex]["Meaning"].ToString();

            if (selectedAnswer == correctAnswer)
                score++;

            lblScore.Text = $"Score: {score}";

            currentIndex++;
            DisplayQuestion();
        }

        private string GetSelectedOption()
        {
            if (rbOption1.Checked) return rbOption1.Text;
            if (rbOption2.Checked) return rbOption2.Text;
            if (rbOption3.Checked) return rbOption3.Text;
            if (rbOption4.Checked) return rbOption4.Text;
            return "";
        }

        private void FinishQuiz()
        {
            double accuracy = ((double)score / quizTable.Rows.Count) * 100;

            MessageBox.Show(
                $"Quiz Completed 🎉\n\n" +
                $"Score: {score}/{quizTable.Rows.Count}\n" +
                $"Accuracy: {accuracy:F2}%",
                "Result");

            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            FinishQuiz();
        }
    }
}
