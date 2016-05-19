using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTest
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            CreateProfile createProfile = new CreateProfile();
            createProfile.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (HashHelper.verify(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("You are logged in");
            }
            else
            {
                MessageBox.Show("Authentication failed, please try again.");
                txtUsername.Text = null;
                txtPassword.Text = null;
            }
                
        }
    }
}
