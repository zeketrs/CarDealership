using DealershipData;
using GenericValidation;
using System;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        /* This child form has the ability to register a new user. */
        private void lblRegistrationLink_Click(object sender, EventArgs e)
        { this.Close(); }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtUserName) &&
                Validator.IsPresent(txtPassword) &&
                Validator.IsPresent(txtPasswordConfirm);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                //custom validation that tests password confirmation
                if (txtPassword.Text == txtPasswordConfirm.Text)
                {
                    if (UserDB.InsertUser(txtUserName.Text, txtPassword.Text))
                    {
                        MessageBox.Show(
                            "Welcome, your user information has been processed.",
                            "Account Registered");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Password confirmation did not match.",
                        "Please try again");
                }
            }
        }

        private void chkShowPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPasswordLogin.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '⬤';
                txtPasswordConfirm.PasswordChar = '⬤';
            }
        }

        private void btnClearActLogin_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPasswordConfirm.Text = string.Empty;
            txtUserName.Focus();
        }
    }
}
