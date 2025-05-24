using DealershipData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarDealership
{
    public partial class frmInventoryMaintenance : Form
    {
        public frmInventoryMaintenance()
        {
            InitializeComponent();
        }

        private void frmInventoryMaintenance_Load(object sender, EventArgs e)
        { LoadMakes(); }

        private void LoadMakes()
        {
            List<Make> makesOnFile = MakeDB.GetMakes();

            cboMake.Items.Clear();
            cboMake.Items.Add("Select a Manufacturer...");

            foreach (Make manufacturer in makesOnFile)
            {
                if (!cboMake.Items.Contains(manufacturer.Manufacturer))
                    cboMake.Items.Add(manufacturer.Manufacturer);
            }
            cboMake.SelectedIndex = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Make manufacturer = new Make(txtNewMake.Text);
            Model newModel = new Model(cboMake.Text, txtModel.Text);

            if (!cboMake.Items.Contains(manufacturer.Manufacturer))
            {
                if (txtNewMake.Text != "" && txtModel.Text != "")
                {
                    MessageBox.Show(
                        "Please insert a new make, or select a prior make from the dropdown\n" +
                        "before inserting a new model.", "Input Error");
                }
                else if (txtNewMake.Text != "" &&
                    txtModel.Text == "")
                {
                    if (MakeDB.InsertMake(manufacturer))
                    {
                        MessageBox.Show(
                            "A new manufacturer was added.",
                            "Insert Successful");
                    }
                }
                else if (txtModel.Text != "" &&
                    txtNewMake.Text == "")
                {
                    if (ModelDB.InsertModel(newModel))
                    {
                        MessageBox.Show(
                            "A new model was added.",
                            "Insert Successful");
                    }
                }
                LoadMakes();
            }
            else
            {
                MessageBox.Show(
                    "This manufacturer already exists in the database.",
                    "Continuity Error");
            }
        }

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMake.SelectedIndex != 0)
            {
                txtNewMake.Enabled = false;
                txtNewMake.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
