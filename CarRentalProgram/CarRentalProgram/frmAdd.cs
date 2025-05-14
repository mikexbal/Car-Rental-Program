using System;
using System.Collections;
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
    public partial class frmAdd : Form
    {

        private CarInventory inventory;

        internal frmAdd(CarInventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtImage_TextChanged(object sender, EventArgs e)
        {
            //Loads image of the car

            try
            {
                pbCar.Load(txtImage.Text);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message);

            }
            
            
        }
        
        private void btnInventory_Click(object sender, EventArgs e)
        {
            //Opens inventory form and passes in the inventory
            frmInventory inventoryForm = new frmInventory(inventory);
            inventoryForm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            //creates varibles to store car data
            string vin = txtVIN.Text;
            string manufacturer = txtManufacturer.Text;
            string model = txtModel.Text;
            int year = Convert.ToInt32(txtYear.Text);
            int mileage = Convert.ToInt32(txtMileage.Text);
            decimal rentalCost = Convert.ToDecimal(txtRentalCost.Text);
            string description = txtDescription.Text;
            string location = txtLocation.Text;
            bool isAvailable = cbAvailable.SelectedItem.ToString() == "Available";
            string classification = cbClassification.SelectedItem.ToString();
            string image = txtImage.Text;

            //Creates car object from 
            Car car = new Car(vin,
                manufacturer, 
                model,
                year, 
                mileage, 
                rentalCost, 
                description, 
                location, 
                isAvailable, 
                classification, 
                image);

            inventory.AddCar(car);
            MessageBox.Show("Car successfully added!");
    
        }

        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear button to reset fields
            txtVIN.Text = string.Empty;
            txtManufacturer.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtMileage.Text= string.Empty; 
            txtRentalCost.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtLocation.Text = string.Empty;
            pbCar.Image = null;
            txtImage.Text = string.Empty;
            cbAvailable.SelectedIndex = -1;
            cbClassification.SelectedIndex = -1;

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
