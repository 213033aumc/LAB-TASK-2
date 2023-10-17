using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LogInSignupTemplate
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string username;
        string password;

        public Action<object, EventArgs> SignupFormHandler { get; internal set; }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text.ToString();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            password = textBox3.Text.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string data = "Username: " + username + "\nPassword: " + password;
            MessageBox.Show(data, "Sign Up Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Form form = new Form();
            form.Show();

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
