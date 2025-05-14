using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalProgram
{
    public partial class frmRental : Form
    {
        //Private field to access selected car from inventory form
        private Car selectedCar;
        
        public frmRental(Car car)
        {
            InitializeComponent();
            selectedCar = car;
        }


        //Loads data from previous form and shows the user the car they selected
        private void frmRental_Load(object sender, EventArgs e)
        {
            lblCarHeader.Text = $"{selectedCar.Year} {selectedCar.Manufacturer} {selectedCar.Model}";
            lblCarInfo.Text = $"Classification: {selectedCar.Classification}" +
                        $"\nMileage: {selectedCar.Mileage}" +
                        $"\nDescription: {selectedCar.Description}" +
                        $"\nLocation: {selectedCar.Location}" +
                        $"\nCost per day: {selectedCar.RentalCost}" +
                        $"\nAvailability: {selectedCar.Availability}";

           try
           {
              pbCar.Load(selectedCar.Image);
           } catch
           {
              pbCar.Image = null;
           }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //convert to int and if the days > 0
            if (int.TryParse(tbDays.Text, out int days) && days > 0)
            {
                //Create customer object
                Customer customer = new Customer(tbName.Text, tbPhone.Text, tbEmail.Text, tbLicense.Text, tbPolicy.Text);

                //Create rental object
                CarRental carRental = new CarRental(selectedCar, customer, DateTime.Now, days);

                //Sets car IsAvailable value to Rented
                //selectedCar.IsAvailable == "Rented";

                //Calculate the total cost
                var breakdown = carRental.CalculateTotal();

                //Passes the breakdown of the total cost into the reciept
                frmReceipt receiptForm = new frmReceipt(breakdown.totalCost, breakdown.subtotal, breakdown.rentalTax, breakdown.stateSalesTax, breakdown.surcharge, selectedCar, customer);
                receiptForm.Show();
            }
            else
            {
                //If number of days invalid alert user

                MessageBox.Show("Please enter a valid number of days.");
            }
        }

    }
}
