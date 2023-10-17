using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInSignupTemplate
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnGoBackToLogin_Click(object sender, EventArgs e)
        {
            OnGoBack(EventArgs.Empty);
        }

        protected virtual void OnGoBack(EventArgs e)
        {
            EventHandler handler = GoBackHandler;
            handler?.Invoke(this, e);
        }

        public event EventHandler GoBackHandler;
    }
}
