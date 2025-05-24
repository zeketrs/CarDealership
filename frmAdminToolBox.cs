using System;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmAdminToolBox : Form
    {
        public frmAdminToolBox()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUserRole alterUserRoles = new frmUserRole();
            this.Hide();
            alterUserRoles.ShowDialog();
            this.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventoryMaintenance expandInventory = new frmInventoryMaintenance();
            this.Hide();
            expandInventory.ShowDialog();
            this.Show();
        }
    }
}
