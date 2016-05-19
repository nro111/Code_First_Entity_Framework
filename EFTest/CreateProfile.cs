using EFTest.Context;
using EFTest.Entities;
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
    public partial class CreateProfile : Form
    {
        public CreateProfile()
        {
            InitializeComponent();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
           
            if (txtPassword.Text.Equals(txtConfirm.Text))
            {
                using (var context = new MyContext())
                {

                    var userInfo = new UserInfo
                    {
                        FirstName = HashHelper.encode(txtUsername.Text),
                        LastName = HashHelper.encode(txtPassword.Text),
                        Email = HashHelper.encode(txtEmail.Text),
                        BirthDate = HashHelper.encode(txtBirthdate.Text)
                    };

                    var userCredential = new UserCredential
                    {
                        Username = HashHelper.encode(txtUsername.Text),
                        Password = HashHelper.encode(txtPassword.Text)
                    };

                    context.UserCredentials.Add(userCredential);
                    context.UserInformation.Add(userInfo);

                    var user = new User
                    {
                        UserInfoID = userInfo.UserInfoID,
                        UserCredentialID = userCredential.UserCredentialID
                    };

                    context.Users.Add(user);

                    context.SaveChanges();
                    MessageBox.Show("Hello " + txtFirstName.Text + " " + txtLastName.Text + ", your account has been created.");
                }
            }
            else
            {
                txtPassword.Text = null;
                txtConfirm.Text = null;
                MessageBox.Show("Your passwords do not match.");
            }                
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
