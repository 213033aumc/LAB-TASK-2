namespace LogInSignupTemplate
{
    partial class SignUpForm
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
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnGoBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(329, 272);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(143, 23);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Sign Up/Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnGoBackToLogin
            // 
            this.btnGoBackToLogin.Location = new System.Drawing.Point(329, 147);
            this.btnGoBackToLogin.Name = "btnGoBackToLogin";
            this.btnGoBackToLogin.Size = new System.Drawing.Size(131, 23);
            this.btnGoBackToLogin.TabIndex = 1;
            this.btnGoBackToLogin.Text = "Go Back to Login";
            this.btnGoBackToLogin.UseVisualStyleBackColor = true;
            this.btnGoBackToLogin.Click += new System.EventHandler(this.btnGoBackToLogin_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoBackToLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnGoBackToLogin;
    }
}