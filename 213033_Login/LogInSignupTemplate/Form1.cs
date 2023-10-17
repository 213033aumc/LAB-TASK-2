using System.Windows.Forms;
using System;

namespace LogInSignupTemplate
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string username;
        string pass;
        string cpass;
        string email;

        public Action<object, EventArgs> LogoutHandler { get; internal set; }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            username = textBox1.Text.ToString();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

            pass = textBox3.Text.ToString();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            cpass = textBox3.Text.ToString();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            email = textBox2.Text.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            string data = "Username: " + username + "\nPassword: " + pass + " " + "\nE-mail: " + email + "";
            MessageBox.Show(data, "Sign Up Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Login login = new Login();
            login.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}