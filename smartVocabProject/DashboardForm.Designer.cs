namespace smartVocabProject
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblQuizzesCompleted = new System.Windows.Forms.Label();
            this.lblWordsLearned = new System.Windows.Forms.Label();
            this.lblProgressTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.rdoAdvance = new System.Windows.Forms.RadioButton();
            this.rdoIntermediate = new System.Windows.Forms.RadioButton();
            this.rdoBeginner = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPracticeQuiz = new System.Windows.Forms.Button();
            this.btnMyVocab = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.lblClose.Location = new System.Drawing.Point(860, 10);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 32);
            this.lblClose.TabIndex = 94;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SmartVocab";
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.White;
            this.pnlProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlProgress.Controls.Add(this.lblAccuracy);
            this.pnlProgress.Controls.Add(this.lblQuizzesCompleted);
            this.pnlProgress.Controls.Add(this.lblWordsLearned);
            this.pnlProgress.Controls.Add(this.lblProgressTitle);
            this.pnlProgress.Location = new System.Drawing.Point(466, 165);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(372, 260);
            this.pnlProgress.TabIndex = 3;
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccuracy.Location = new System.Drawing.Point(20, 150);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(156, 25);
            this.lblAccuracy.TabIndex = 3;
            this.lblAccuracy.Text = " 🎯 Accuracy : 0%";
            // 
            // lblQuizzesCompleted
            // 
            this.lblQuizzesCompleted.AutoSize = true;
            this.lblQuizzesCompleted.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizzesCompleted.Location = new System.Drawing.Point(20, 110);
            this.lblQuizzesCompleted.Name = "lblQuizzesCompleted";
            this.lblQuizzesCompleted.Size = new System.Drawing.Size(220, 25);
            this.lblQuizzesCompleted.TabIndex = 2;
            this.lblQuizzesCompleted.Text = "📝 Quizzes Completed : 0";
            // 
            // lblWordsLearned
            // 
            this.lblWordsLearned.AutoSize = true;
            this.lblWordsLearned.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsLearned.Location = new System.Drawing.Point(20, 70);
            this.lblWordsLearned.Name = "lblWordsLearned";
            this.lblWordsLearned.Size = new System.Drawing.Size(181, 25);
            this.lblWordsLearned.TabIndex = 1;
            this.lblWordsLearned.Text = "📘 Words Learned : 0";
            // 
            // lblProgressTitle
            // 
            this.lblProgressTitle.AutoSize = true;
            this.lblProgressTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProgressTitle.Name = "lblProgressTitle";
            this.lblProgressTitle.Size = new System.Drawing.Size(106, 31);
            this.lblProgressTitle.TabIndex = 0;
            this.lblProgressTitle.Text = "Progress";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(593, 446);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // rdoAdvance
            // 
            this.rdoAdvance.AutoSize = true;
            this.rdoAdvance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdvance.Location = new System.Drawing.Point(26, 143);
            this.rdoAdvance.Name = "rdoAdvance";
            this.rdoAdvance.Size = new System.Drawing.Size(96, 27);
            this.rdoAdvance.TabIndex = 7;
            this.rdoAdvance.Text = "Advance";
            this.rdoAdvance.UseVisualStyleBackColor = true;
            // 
            // rdoIntermediate
            // 
            this.rdoIntermediate.AutoSize = true;
            this.rdoIntermediate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoIntermediate.Location = new System.Drawing.Point(26, 103);
            this.rdoIntermediate.Name = "rdoIntermediate";
            this.rdoIntermediate.Size = new System.Drawing.Size(129, 27);
            this.rdoIntermediate.TabIndex = 6;
            this.rdoIntermediate.Text = "Intermediate";
            this.rdoIntermediate.UseVisualStyleBackColor = true;
            // 
            // rdoBeginner
            // 
            this.rdoBeginner.AutoSize = true;
            this.rdoBeginner.Checked = true;
            this.rdoBeginner.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBeginner.Location = new System.Drawing.Point(26, 63);
            this.rdoBeginner.Name = "rdoBeginner";
            this.rdoBeginner.Size = new System.Drawing.Size(99, 27);
            this.rdoBeginner.TabIndex = 5;
            this.rdoBeginner.TabStop = true;
            this.rdoBeginner.Text = "Beginner";
            this.rdoBeginner.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lblLevel);
            this.panel1.Controls.Add(this.rdoAdvance);
            this.panel1.Controls.Add(this.rdoBeginner);
            this.panel1.Controls.Add(this.rdoIntermediate);
            this.panel1.Location = new System.Drawing.Point(52, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 260);
            this.panel1.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(20, 200);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(180, 40);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start Learning";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(20, 20);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(208, 31);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Choose Your Level";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(23, 107);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(198, 31);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome,User👋";
            // 
            // btnPracticeQuiz
            // 
            this.btnPracticeQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.btnPracticeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPracticeQuiz.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPracticeQuiz.Location = new System.Drawing.Point(131, 446);
            this.btnPracticeQuiz.Name = "btnPracticeQuiz";
            this.btnPracticeQuiz.Size = new System.Drawing.Size(180, 40);
            this.btnPracticeQuiz.TabIndex = 6;
            this.btnPracticeQuiz.Text = "Practice Quiz";
            this.btnPracticeQuiz.UseVisualStyleBackColor = false;
            this.btnPracticeQuiz.Click += new System.EventHandler(this.btnPracticeQuiz_Click_1);
            // 
            // btnMyVocab
            // 
            this.btnMyVocab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.btnMyVocab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyVocab.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyVocab.Location = new System.Drawing.Point(359, 446);
            this.btnMyVocab.Name = "btnMyVocab";
            this.btnMyVocab.Size = new System.Drawing.Size(180, 40);
            this.btnMyVocab.TabIndex = 7;
            this.btnMyVocab.Text = "My Vocabulary";
            this.btnMyVocab.UseVisualStyleBackColor = false;
            this.btnMyVocab.Click += new System.EventHandler(this.btnMyVocab_Click_1);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnMyVocab);
            this.Controls.Add(this.btnPracticeQuiz);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartVocab-DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblQuizzesCompleted;
        private System.Windows.Forms.Label lblWordsLearned;
        private System.Windows.Forms.Label lblProgressTitle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RadioButton rdoAdvance;
        private System.Windows.Forms.RadioButton rdoIntermediate;
        private System.Windows.Forms.RadioButton rdoBeginner;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPracticeQuiz;
        private System.Windows.Forms.Button btnMyVocab;
        private System.Windows.Forms.Label lblClose;
    }
}