using System;
using System.Windows.Forms;
using DealershipData;

namespace CarDealership
{
    public partial class frmUserRole : Form
    {
        public frmUserRole()
        {
            InitializeComponent();
        }

        private void frmAdminTools_Load(object sender, EventArgs e)
        {            
            usersTableAdapter.Fill(carDealershipDataSet.Users);

            foreach(var item in carDealershipDataSet.Users)
            {
                if (!cboRole.Items.Contains(item.Role))
                { cboRole.Items.Add(item.Role); }
            }
            cboRole.SelectedIndex = 0;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
                if (UserDB.UpdateUser(cboUserName.Text, cboRole.Text))
                {
                    MessageBox.Show("Selected user role has been altered successfully.", "User Updated");
                    this.Close();
                }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
