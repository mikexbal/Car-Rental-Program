using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProgram
{
    public partial class frmReturn : Form
    {
        private CarInventory inventory;
            
        public frmReturn(CarInventory Inventory)
        {
            InitializeComponent();
            inventory = Inventory;
        }

        private void cbRented_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //User enters VIN(Primary KEY) to find rented vehicle
            //If car is rented and VIN matches, allow user to update attributes

            List<Car> RentedCars = inventory.RentedCars();

            foreach (Car vehicle in RentedCars)
            {
                if (tbVIN.Text == vehicle.VehicleID)
                {
                    vehicle.IsAvailable = true;

                    if (Convert.ToInt32(tbMileage.Text) < vehicle.Mileage)
                    {
                        MessageBox.Show("Invalid Mileage!" +
                            "\nMileage must be greater or equal to previous!");
                    }
                    else
                    {
                        vehicle.Mileage = Convert.ToInt32(tbMileage.Text);
                        MessageBox.Show("Vehicle sucessfully retured.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid vehicleID Entered!");
                }

                
            }

        }
    }
}
