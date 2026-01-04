using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartVocabProject
{
    public partial class DashboardForm : Form
    {
            private string loggedInUser;

            // Receive username from LoginForm
            public DashboardForm(string firstname)
            {
                InitializeComponent();
                loggedInUser = firstname;
            }

            private void DashboardForm_Load(object sender, EventArgs e)
            {
                lblWelcome.Text = "Welcome, " + loggedInUser;
            }

            private void btnStart_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Learn New Words – coming soon!");
            }

            private void btnPracticeQuiz_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Practice Quiz – coming soon!");
            }

            private void btnMyVocab_Click(object sender, EventArgs e)
            {
                MessageBox.Show("My Vocabulary – coming soon!");
            }

            private void btnLogout_Click(object sender, EventArgs e)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            
            string level = "";

            if (rdoBeginner.Checked) level = "Beginner";
            else if (rdoIntermediate.Checked) level = "Intermediate";
            else if (rdoAdvance.Checked) level = "Advanced";
            else
            {
                MessageBox.Show("Please select a level");
                return;
            }

            LearnWordsForm learn = new LearnWordsForm(loggedInUser, level);
            learn.ShowDialog();
        }

        private void btnMyVocab_Click_1(object sender, EventArgs e)
        {
            MyVocabularyForm vocabForm = new MyVocabularyForm(loggedInUser);
            vocabForm.Show();
        }

        private void btnPracticeQuiz_Click_1(object sender, EventArgs e)
        {
            PracticeQuizForm quizForm = new PracticeQuizForm(loggedInUser);
            quizForm.Show();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Logging Off!");
            this.Close();
        }
    }
    }