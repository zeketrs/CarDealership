using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DealershipData;
using GenericValidation;

namespace CarDealership
{
    public partial class frmAddModify : Form
    {
        public frmAddModify()
        {
            InitializeComponent();
        }

        public Car Vehicle;
        public NewCar NewVehicle;
        public UsedCar UsedVehicle;
        List<Make> makesOnFile = MakeDB.GetMakes();
        List<Model> modelsOnFile = ModelDB.GetModels();
        public bool addCar;

        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModel.Enabled = true;
            LoadModels(cboMake.SelectedIndex);
        }

        private void LoadModels(int index)
        {
            cboModel.Items.Clear();
            cboModel.Items.Add("Select a Model...");
            foreach (Model name in modelsOnFile)
            {
                if (name.MakeID == index)
                {
                    if (!cboModel.Items.Contains(name.Series))
                        cboModel.Items.Add(name.Series);
                }
            }
            cboModel.SelectedIndex = 0;
        }

        private void LoadMakes()
        {
            
            cboMake.Items.Clear();
            cboMake.Items.Add("Select a Manufacturer...");
            foreach (Make manufacturer in makesOnFile)
            {
                if (!cboMake.Items.Contains(manufacturer.Manufacturer))
                    cboMake.Items.Add(manufacturer.Manufacturer);
            }
        }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            LoadMakes();
            if (addCar)
            {
                this.Text = "Add Listing";
                Vehicle = new Car(Vehicle);
                cboMake.SelectedIndex = 0;
                cboModel.Enabled = false;
                rdoNew.Checked = true;
            }
            else
            { PutControls(); }
        }

        private void PutControls()
        {
            this.Text = "Modify Listing";
            if (Vehicle.Condition == "New")
            {
                NewVehicle = new NewCar(Vehicle);
                cboMake.SelectedItem = NewVehicle.Make;
                cboModel.Text = NewVehicle.Model;
                cboMake.Enabled = false;
                cboModel.Enabled = false;
                rdoUsed.Enabled = false;
                txtColor.Text = NewVehicle.Color;
                txtPrice.Text = NewVehicle.Price.ToString("#.##");
                rdoNew.Checked = true;
                txtAge.Enabled = false;
                txtMilage.Enabled = false;
            }
            else
            {
                UsedVehicle = (UsedCar)Vehicle;
                cboMake.Text = UsedVehicle.Make;
                cboModel.Text = UsedVehicle.Model;
                cboMake.Enabled = false;
                cboModel.Enabled = false;
                rdoNew.Enabled = false;
                txtColor.Text = UsedVehicle.Color;
                txtPrice.Text = UsedVehicle.Price.ToString("#.##");
                rdoUsed.Checked = true;
                txtMilage.Text = UsedVehicle.Milage.ToString();
                txtAge.Text = UsedVehicle.Age.ToString();
            }
        }

        private void SetCarProperties()
        {
            if (rdoNew.Checked)
            {
                NewVehicle = new NewCar(Vehicle.CarID,
                    cboMake.Text, cboModel.Text, txtColor.Text,
                    Convert.ToDecimal(txtPrice.Text));
                Vehicle = NewVehicle;
            }
            else
            {
                UsedVehicle = new UsedCar(
                    Vehicle.CarID, cboMake.Text, cboModel.Text, txtColor.Text,
                    Convert.ToDecimal(txtPrice.Text),
                    Convert.ToInt32(txtAge.Text),
                    Convert.ToInt32(txtMilage.Text));
                Vehicle = UsedVehicle;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SetCarProperties();
                DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            if (rdoNew.Checked)
            {
                return Validator.IsPresent(cboMake) &&
                  Validator.IsPresent(cboModel) &&
                  Validator.IsPresent(txtColor) &&
                  Validator.IsPresent(txtPrice) &&
                  Validator.IsDecimal(txtPrice);
            }
            else
            {
                return Validator.IsPresent(cboMake) &&
                        Validator.IsPresent(cboModel) &&
                        Validator.IsPresent(txtColor) &&
                        Validator.IsPresent(txtPrice) &&
                        Validator.IsDecimal(txtPrice) &&
                        Validator.IsPresent(txtAge) &&
                        Validator.IsInt32(txtAge) &&
                        Validator.IsPresent(txtMilage) &&
                        Validator.IsInt32(txtMilage);
            }                
        }

        private void rdoNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNew.Checked)
            {
                txtAge.Text = "";
                txtMilage.Text = "";
                lblAge.Visible = false;
                lblMilage.Visible = false;
                txtAge.Enabled = false;
                txtMilage.Enabled = false;
            }
        }

        private void rdoUsed_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoUsed.Checked)
            {
                txtAge.Enabled = true;
                txtMilage.Enabled = true;
                if (UsedVehicle != null)
                {
                    lblAge.Visible = true;
                    lblMilage.Visible = true;
                    txtAge.Text = UsedVehicle.Age.ToString();
                    txtMilage.Text = UsedVehicle.Milage.ToString();
                }
                else
                {
                    lblAge.Visible = true;
                    lblMilage.Visible = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
