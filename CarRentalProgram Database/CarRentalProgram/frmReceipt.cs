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
    public partial class frmReceipt : Form
    {

        private decimal totalCost;
        private decimal subtotal;
        private decimal rentalTax;
        private decimal stateSalesTax;
        private decimal surcharge;
        private Car selectedCar;
        private Customer customer;

        // Updated constructor
        public frmReceipt(decimal totalCost, decimal subtotal, decimal rentalTax, decimal stateSalesTax, decimal surcharge, Car selectedCar, Customer customer)
        {
            InitializeComponent();
            this.totalCost = totalCost;
            this.subtotal = subtotal;
            this.rentalTax = rentalTax;
            this.stateSalesTax = stateSalesTax;
            this.surcharge = surcharge;
            this.selectedCar = selectedCar;
            this.customer = customer;

        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {

            lblDateTime.Text = DateTime.Now.ToString("f");
            lblCarHeader.Text = $"{selectedCar.Year.ToString()} {selectedCar.Manufacturer} {selectedCar.Model}";
            lblCarInfo.Text = 
                $"VIN: {selectedCar.VehicleID}" +
                $"\nClassification: {selectedCar.Classification}" +
                $"\nCurrent Mileage: {selectedCar.Mileage}" +
                $"\nDescription: {selectedCar.Description}" +
                $"\nLocation: {selectedCar.Location}";


            lblCustomerInfo.Text = $"Name: {customer.Name}" +
                $"\nPhone Number: {customer.PhoneNumber}" +
                $"\nEmail: {customer.Email}" +
                $"\nLicense Number: {customer.LicenseNumber}" +
                $"\nPolicy Number; {customer.PolicyNumber}";

            lblBreakdown.Text = $"Subtotal: {subtotal.ToString()}" +
                $"\nRental Tax: {rentalTax.ToString()}" +
                $"\nSales Tax: {stateSalesTax.ToString()}" +
                $"\nSurcharge: {surcharge.ToString()}" +
                $"\nTotal Cost: {totalCost.ToString()}";
           
        }



    }
}
