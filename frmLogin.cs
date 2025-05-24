using DealershipData;
using GenericValidation;
using System;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /* This is the parent form of the application
           where a user can login, or register an account.
           The user status is given a default of administrator for grading purposes.
           The stored procedure can be easily altered to make User the default. */

        private bool IsValidData()
        {
            return Validator.IsPresent(txtUserLogin) &&
                Validator.IsPresent(txtPassword);
        }

        private void btnActLogin_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                User pilot = UserDB.GetUser(txtUserLogin.Text, txtPassword.Text);

                if (pilot != null)
                {
                    frmCarDealership openProgram = new frmCarDealership();

                    openProgram.Pilot = pilot;
                    this.Hide();
                    openProgram.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User authentication was not recognized.\n" +
                        "Please try again, or Register an account", "User Not Found");
                }
            }
        }

        private void lblRegistrationLabel_Click(object sender, EventArgs e)
        {
            frmRegistration openForm = new frmRegistration();
            this.Hide();
            openForm.ShowDialog();
            this.Show();
        }

        private void chkShowPasswordLogin_CheckedChanged(object sender, EventArgs e)
        {
            //Utilizes unicode to mask password characters
            if (chkShowPasswordLogin.Checked) 
            { txtPassword.PasswordChar = '\0'; }

            else { txtPassword.PasswordChar = '⬤'; }
        }

        private void btnClearActLogin_Click(object sender, EventArgs e)
        {
            txtUserLogin.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserLogin.Focus();
        }

        private void lblGuestlogin_Click(object sender, EventArgs e)
        {
            frmCarDealership asGuest = new frmCarDealership();
            User guest = new User();
            guest.Role = "User";
            asGuest.Pilot = guest;
            this.Hide();
            asGuest.ShowDialog();
        }
    }
}
