using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CarRentalProgram
{
    public partial class frmInventory : Form
    {
        private CarInventory inventory;
        private List<Car> filteredCars;
        private ListView listview;


        public frmInventory(CarInventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory; // Store the inventory reference
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            CreateListView(lvCarInventory);
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lvCarInventory.SelectedItems[0];
           
            //Grabs car from tag property
            Car selectedCar = (Car)selectedItem.Tag;


            //If the car is available allow the user to rent it
            if (selectedCar.IsAvailable)
            {
                frmRental RentalForm = new frmRental(selectedCar);
                RentalForm.ShowDialog();
            } else

            //If not display error
            {
                MessageBox.Show("Please select an available vehicle!");

            }
      
        }

        public void CreateListView(System.Windows.Forms.ListView listview, List<Car> carList = null)
        {
            listview.Items.Clear();
            listview.Columns.Clear();


            //Creates columns for listview
            listview.Columns.Add("Manufacturer");
            listview.Columns.Add("Model");
            listview.Columns.Add("Year");
            listview.Columns.Add("Mileage");
            listview.Columns.Add("Cost per Day");
            listview.Columns.Add("Availability");

            // If carList is empty, use the full inventory, else use the provided list
            List<Car> carsToDisplay = carList ?? inventory.Inventory;

            foreach (Car car in carsToDisplay)
            {
                ListViewItem item = new ListViewItem(car.Manufacturer);
                item.SubItems.Add(car.Model);
                item.SubItems.Add(car.Year.ToString());
                item.SubItems.Add(car.Mileage.ToString());
                item.SubItems.Add($"${car.RentalCost.ToString()}");
                item.SubItems.Add(car.IsAvailable ? "Available" : "Rented");
                item.Tag = car;

                listview.Items.Add(item);
            }
        }


        private void lvCarInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCarInventory.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = lvCarInventory.SelectedItems[0];

                // Retrieve the Car object from the Tag property
                Car selectedCar = (Car)selectedItem.Tag;

                if (selectedCar != null)
                {
                    lblCarMakeModel.Text = $"{selectedCar.Year} {selectedCar.Manufacturer} {selectedCar.Model}";

                    //Year, Mileage, Description, Location, Availabiliy, Classification

                    lblCarInfo.Text = $"Classification: {selectedCar.Classification}" +
                        $"\nMileage: {selectedCar.Mileage}" +
                        $"\nLocation: {selectedCar.Location}" +
                        $"\nCost per day: {selectedCar.RentalCost}" +
                        $"\nAvailability: {(selectedCar.IsAvailable ? "Available" : "Rented")}";

                   


                    // Load the car image if available

                    try
                    {
                        
                        pbCar.Load(selectedCar.Image);
                    } catch
                    {
                        pbCar.Image = null;
                    }
                    
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clear any previously selected items
            lvCarInventory.SelectedItems.Clear();

            if (radAvailable.Checked)
            {
                //Populate the ListView with available cars
                CreateListView(lvCarInventory, inventory.AvailableCars());
            }
            else if (radRented.Checked)
            {
                //Populate the ListView with rented cars
                CreateListView(lvCarInventory, inventory.RentedCars());
            }
            else
            {
                //If no filter is selected, show the entire inventory
                CreateListView(lvCarInventory);
            }
        }

    }
}
