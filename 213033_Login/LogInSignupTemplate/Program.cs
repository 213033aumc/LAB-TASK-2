using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInSignupTemplate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        [STAThread]
        static void Main()
        {
          

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 mainForm = new Form1();
            SignUpForm signUpForm;
            Login loginForm;

            mainForm.LogoutHandler += RestartApp;

            loginForm = new Login();
            loginForm.SignupFormHandler += ShowSignup;


            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                mainForm.ShowDialog();
            }

            void ShowSignup(object sender, EventArgs e)
            {
                signUpForm = new SignUpForm();
                signUpForm.GoBackHandler += ShowLogin;
                loginForm.Visible = false;
                if (signUpForm.ShowDialog() == DialogResult.OK)
                {
                    mainForm.ShowDialog();
                }
            }

            void ShowLogin(object sender, EventArgs e)
            {
                loginForm.Visible = true;
                signUpForm.Visible = false;
            }

            void RestartApp(object sender, EventArgs e) => Application.Restart();
        }

        

        
    }
}
