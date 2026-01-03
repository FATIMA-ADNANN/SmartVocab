namespace smartVocabProject
{
    partial class LoginForm
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
            this.lnklblLogin = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.createAccountlbl = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnklblLogin
            // 
            this.lnklblLogin.AutoSize = true;
            this.lnklblLogin.Font = new System.Drawing.Font("Nirmala UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblLogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.lnklblLogin.Location = new System.Drawing.Point(377, 451);
            this.lnklblLogin.Name = "lnklblLogin";
            this.lnklblLogin.Size = new System.Drawing.Size(55, 17);
            this.lnklblLogin.TabIndex = 76;
            this.lnklblLogin.TabStop = true;
            this.lnklblLogin.Text = "Sign up";
            this.lnklblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogin_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.label1.Location = new System.Drawing.Point(192, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Don\'t have an account?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(112, 389);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(413, 39);
            this.btnLogin.TabIndex = 74;
            this.btnLogin.Text = "Login ";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.txtPassword.Location = new System.Drawing.Point(112, 325);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(413, 26);
            this.txtPassword.TabIndex = 71;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.lblPassword.Location = new System.Drawing.Point(108, 299);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(84, 23);
            this.lblPassword.TabIndex = 70;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.txtEmail.Location = new System.Drawing.Point(112, 260);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(413, 26);
            this.txtEmail.TabIndex = 69;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.lblEmail.Location = new System.Drawing.Point(108, 234);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 23);
            this.lblEmail.TabIndex = 68;
            this.lblEmail.Text = "Email";
            // 
            // createAccountlbl
            // 
            this.createAccountlbl.AutoSize = true;
            this.createAccountlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.createAccountlbl.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(206)))), ((int)(((byte)(180)))));
            this.createAccountlbl.Location = new System.Drawing.Point(260, 173);
            this.createAccountlbl.Name = "createAccountlbl";
            this.createAccountlbl.Size = new System.Drawing.Size(90, 38);
            this.createAccountlbl.TabIndex = 63;
            this.createAccountlbl.Text = "Login";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Nirmala UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(105)))));
            this.lblTitle.Location = new System.Drawing.Point(198, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 50);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "SmartVocab";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(632, 603);
            this.Controls.Add(this.lnklblLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.createAccountlbl);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnklblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label createAccountlbl;
        private System.Windows.Forms.Label lblTitle;
    }
}