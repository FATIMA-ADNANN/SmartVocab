namespace smartVocabProject
{
    partial class LearnWordsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelWordCard = new System.Windows.Forms.Panel();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblMeaningTitle = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.lblSentenceTitle = new System.Windows.Forms.Label();
            this.lblSentence = new System.Windows.Forms.Label();
            this.btnLearned = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panelWordCard.SuspendLayout();
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
            this.pnlHeader.TabIndex = 1;
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
            // panelWordCard
            // 
            this.panelWordCard.BackColor = System.Drawing.Color.White;
            this.panelWordCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWordCard.Controls.Add(this.lblSentence);
            this.panelWordCard.Controls.Add(this.lblSentenceTitle);
            this.panelWordCard.Controls.Add(this.lblMeaning);
            this.panelWordCard.Controls.Add(this.lblMeaningTitle);
            this.panelWordCard.Controls.Add(this.lblWord);
            this.panelWordCard.Location = new System.Drawing.Point(70, 110);
            this.panelWordCard.Name = "panelWordCard";
            this.panelWordCard.Size = new System.Drawing.Size(760, 300);
            this.panelWordCard.TabIndex = 2;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblWord.Location = new System.Drawing.Point(30, 20);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(163, 60);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "WORD";
            // 
            // lblMeaningTitle
            // 
            this.lblMeaningTitle.AutoSize = true;
            this.lblMeaningTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaningTitle.Location = new System.Drawing.Point(30, 90);
            this.lblMeaningTitle.Name = "lblMeaningTitle";
            this.lblMeaningTitle.Size = new System.Drawing.Size(100, 28);
            this.lblMeaningTitle.TabIndex = 1;
            this.lblMeaningTitle.Text = "Meaning:";
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(30, 120);
            this.lblMeaning.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(232, 28);
            this.lblMeaning.TabIndex = 2;
            this.lblMeaning.Text = "Meaning will appear here";
            // 
            // lblSentenceTitle
            // 
            this.lblSentenceTitle.AutoSize = true;
            this.lblSentenceTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentenceTitle.Location = new System.Drawing.Point(30, 180);
            this.lblSentenceTitle.Name = "lblSentenceTitle";
            this.lblSentenceTitle.Size = new System.Drawing.Size(98, 28);
            this.lblSentenceTitle.TabIndex = 3;
            this.lblSentenceTitle.Text = "Sentence";
            // 
            // lblSentence
            // 
            this.lblSentence.AutoSize = true;
            this.lblSentence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentence.Location = new System.Drawing.Point(30, 210);
            this.lblSentence.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblSentence.Name = "lblSentence";
            this.lblSentence.Size = new System.Drawing.Size(235, 28);
            this.lblSentence.TabIndex = 4;
            this.lblSentence.Text = "Sentence will appear here";
            // 
            // btnLearned
            // 
            this.btnLearned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(211)))), ((int)(((byte)(199)))));
            this.btnLearned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLearned.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearned.ForeColor = System.Drawing.Color.White;
            this.btnLearned.Location = new System.Drawing.Point(75, 426);
            this.btnLearned.Name = "btnLearned";
            this.btnLearned.Size = new System.Drawing.Size(196, 45);
            this.btnLearned.TabIndex = 5;
            this.btnLearned.Text = "✔ Mark as Learned";
            this.btnLearned.UseVisualStyleBackColor = false;
            this.btnLearned.Click += new System.EventHandler(this.btnLearned_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(162)))), ((int)(((byte)(97)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(348, 426);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(196, 45);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Word →";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(111)))), ((int)(((byte)(81)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(634, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(196, 45);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back To Dashboard";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(720, 85);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(124, 23);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "Words 1 of 10";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.Location = new System.Drawing.Point(300, 490);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(254, 16);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Click \"Mark as Learned\" to save progress";
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
            this.lblClose.TabIndex = 95;
            this.lblClose.Text = "X";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // LearnWordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLearned);
            this.Controls.Add(this.panelWordCard);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LearnWordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LearnWordsForm";
            this.Load += new System.EventHandler(this.LearnWordsForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelWordCard.ResumeLayout(false);
            this.panelWordCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelWordCard;
        private System.Windows.Forms.Label lblMeaningTitle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblSentence;
        private System.Windows.Forms.Label lblSentenceTitle;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Button btnLearned;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblClose;
    }
}