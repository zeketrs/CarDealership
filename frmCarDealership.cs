using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DealershipData;

namespace CarDealership
{
    public partial class frmCarDealership : Form
    {
        public frmCarDealership()
        {
            InitializeComponent();
        }

        public User Pilot;
        private List<Car> Inventory;

        // Double clicking the listview displays contextual details for new and used listings.
        private void lvInventory_DoubleClick(object sender, EventArgs e)
        {
            Car selectedCar = (Car)lvInventory.FocusedItem.Tag;
            MessageBox.Show(selectedCar.GetDisplayText(), "Listing Details");
        }

        // Opens a form with tools to alter user permissions and manager actions
        private void btnAdminTools_Click(object sender, EventArgs e)
        {
            frmAdminToolBox openToolBox = new frmAdminToolBox();
            this.Hide();
            openToolBox.ShowDialog();
            this.Show();
        }

        // Populates the Inventory list.
        // Populates the listview.
        // Loads the filter combo boxes.
        // Enables the filter controls.
        // Then determines which controls should be enabled, given the user permissions.
        private void frmCarDealership_Load(object sender, EventArgs e)
        {
            lvInventory.Items.Clear();
            try
            {
                Inventory = InventoryDB.GetInventory();
                if (Inventory.Count > 0)
                {
                    ApplyListViewFilter(Inventory);
                    LoadComboBoxes();
                    ClearFilters();
                }
                else
                {
                    MessageBox.Show(
                        "There are no listings in inventory.", "Inventory Unavailable");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message, ex.GetType().ToString());
            }
            finally 
            {
                if (Pilot.Role != "Admin")
                { btnAdminTools.Visible = false; }

                if(Pilot.Role == "User")
                {
                    btnAdd.Visible = false;
                    btnModify.Visible = false;
                    btnRemove.Visible = false;
                    btnSave.Visible = false;
                }
            }
        }

        // Runs two for each loops over the Inventory.
        // Uses the .Contains() method to add distinct filter options.
        private void LoadComboBoxes()
        {
            cboModel.Items.Clear();
            cboModel.Items.Add("All");

            foreach (Car car in Inventory)
            {
                if (!cboModel.Items.Contains(car.Model))
                    cboModel.Items.Add(car.Model);
            }

            cboMake.Items.Clear();
            cboMake.Items.Add("All");

            foreach (Car car in Inventory)
            {
                if (!cboMake.Items.Contains(car.Make))
                    cboMake.Items.Add(car.Make);
            }
        }

        // Opens the add/modify form.
        // Alters its properties.
        // Assigns the Inventory list to the tag of the form.
        // If a listing was added the listview is refreshed.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModify addListing = new frmAddModify();
            addListing.addCar = true;
            addListing.Vehicle = Inventory.Last();
            addListing.Tag = Inventory;
            DialogResult result = addListing.ShowDialog();
            if (result == DialogResult.OK)
            {
                Inventory.Add(addListing.Vehicle);
                ClearFilters();
            }
        }

        // Fetches the index of a selected item from the listview.
        private int GetSelectedIndex()
        {
            if (lvInventory.SelectedItems.Count > 0)
            {
                int i = lvInventory.FocusedItem.Index;
                return i;
            }
            else
            { return -1; }
        }

        // Opens the add modify form.
        // Sets form properties to modify
        // Checks the selected index of the listview for validation.
        // Instantiates a car from the tag of a listview item.
        // Checks the condition property of a car.
        // Passes the Car object to the modify form.
        // If a Car object was approved for alteration,
        // the selected vehicle properties are set to the modified properties.
        // Finally, the listing is updated.
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModify modifyListing = new frmAddModify();
            modifyListing.addCar = false;
            int i = GetSelectedIndex();
            if (i != -1)
            {
                Car selected = (Car)lvInventory.FocusedItem.Tag;

                if (selected.Condition == "New")
                {
                    NewCar newVehicle = (NewCar)selected;
                    modifyListing.Vehicle = newVehicle;
                    DialogResult result = modifyListing.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        newVehicle = modifyListing.NewVehicle;
                        UpdateListing(newVehicle);
                    }
                }
                else
                {
                    UsedCar usedVehicle = (UsedCar)selected;
                    modifyListing.Vehicle = usedVehicle;
                    DialogResult result = modifyListing.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        usedVehicle = modifyListing.UsedVehicle;
                        UpdateListing(usedVehicle);
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a Car's ID from the list",
                    "Selected Index Error");
            }
        }

        // Utilizing the .Finding() method, an index is set against the matching carID.
        // And the Inventory is altered to match the updated properties at the correct original index.
        private void UpdateListing(Car altered)
        {
            int carID = altered.CarID;
            int i = Inventory.FindIndex(vehicle => vehicle.CarID == carID);
            Inventory[i] = altered;
            ClearFilters();
        }

        // Uses the listview item tag property to fetch a selected car object.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int i = GetSelectedIndex();
            if (i != -1)
            {
                DialogResult result = MessageBox.Show(
                "You are about to remove an existing listing from the database.",
                "Delete Listing", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Car selected = (Car)lvInventory.FocusedItem.Tag;
                    RemoveListing(selected);
                }
            }
        }

        // Utilizing the .Finding() method, an index is set against the matching carID.
        // And the Inventory Car object is removed at the correct original index.
        private void RemoveListing(Car removed)
        {
            int carID = removed.CarID;
            int i = Inventory.FindIndex(x => x.CarID == carID);
            Inventory.RemoveAt(i);
            ClearFilters();
        }

        // Populates the listview with a filtered list of Cars.
        // Sets the tag of a specific listview item to a Car object
        private void ApplyListViewFilter(IEnumerable<Car> filteredCars)
        {
            if (filteredCars != null)
            {
                lvInventory.Items.Clear();
                int index = 0;
                foreach (Car details in filteredCars)
                {
                    lvInventory.Items.Add(details.CarID.ToString());
                    lvInventory.Items[index].SubItems.Add(details.Make);
                    lvInventory.Items[index].SubItems.Add(details.Model);
                    lvInventory.Items[index].SubItems.Add(details.Color);
                    lvInventory.Items[index].SubItems.Add(details.Condition);
                    lvInventory.Items[index].SubItems.Add(details.Price.ToString("c"));
                    lvInventory.Items[index].Tag = details;
                    index++;
                }
            }
        }

        // A series of methods which utilize Linq to supply a filtered list.
        private void FilterMake()
        {
            string filterByMake = cboMake.Text;
            IEnumerable<Car> filteredCars = null;

            if (filterByMake != "All")
            {
                filteredCars = from Car cars in Inventory
                               where cars.Make == filterByMake
                               orderby cars.CarID
                               select cars;
                LoadModelsComboBoxes(filteredCars);
            }
            else filteredCars = Inventory;
            ApplyListViewFilter(filteredCars);
        }
        private void LoadModelsComboBoxes(IEnumerable<Car> filteredCars)
        {
            cboModel.Items.Clear();

            foreach (Car car in filteredCars)
            {
                if (!cboModel.Items.Contains(car.Model))
                    cboModel.Items.Add(car.Model);
            }
        }

        private void FilterModel()
        {
            string filterByModel = cboModel.Text;
            IEnumerable<Car> filteredCars = null;

            if (filterByModel != "All")
            {
                filteredCars = from Car cars in Inventory
                               where cars.Model == filterByModel
                               orderby cars.CarID
                               select cars;
            }
            else filteredCars = Inventory;
            ApplyListViewFilter(filteredCars);
        }

        private void FilterCondition()
        {

            IEnumerable<Car> filteredCars = null;
            if (rdoNew.Checked == true)
            {
                filteredCars = from Car cars in Inventory
                               where cars.Condition == "New"
                               orderby cars.CarID
                               select cars;
            }
            else if (rdoUsed.Checked == true)
            {
                filteredCars = from Car cars in Inventory
                               where cars.Condition == "Used"
                               orderby cars.CarID
                               select cars;
            }
            else filteredCars = Inventory;

            ApplyListViewFilter(filteredCars);
        }

        // Clears data from the database before saving the data stored in the session before closing the form.
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InventoryDB.DumpDataBase() && InventoryDB.SaveSession(Inventory))
            {
                MessageBox.Show(
                    "The database has been update", 
                    "Have a nice day :)");
                this.Close();
            }
            else
            {
                MessageBox.Show("There was an error communicating with the client.\n" +
                    "This session was not saved.\n" +
                    "Please contact a specialist for troubleshooting.",
                    "Systems Error");
                this.Close();
            }
        }

        // Series of event handlers that control the user interface.
        private void cboMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inventory != null)
            {
                rdoNew.Enabled = false;
                rdoUsed.Enabled = false;
                FilterMake();
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Inventory != null)
            {
                cboMake.Enabled = false;
                rdoNew.Enabled = false;
                rdoUsed.Enabled = false;
                FilterModel();
            }
        }

        private void rdoNew_CheckedChanged(object sender, EventArgs e)
        {
            cboMake.Enabled = false;
            cboModel.Enabled = false;
            FilterCondition();
        }

        private void rdoUsed_CheckedChanged(object sender, EventArgs e)
        {
            cboMake.Enabled = false;
            cboModel.Enabled = false;
            FilterCondition();
        }

        private void btnClear_Click(object sender, EventArgs e)
        { ClearFilters(); }

        // Enables filter controls and refreshes the listview.
        private void ClearFilters()
        {
            LoadComboBoxes();
            cboMake.SelectedIndex = 0;
            cboModel.SelectedIndex = 0;
            rdoNew.Checked = false;
            rdoUsed.Checked = false;

            rdoNew.Enabled = true;
            rdoUsed.Enabled = true;
            cboMake.Enabled = true;
            cboModel.Enabled = true;

            ApplyListViewFilter(Inventory);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            frmLogin logout = new frmLogin();
            this.Hide();
            logout.ShowDialog();
        }
    }
}