using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace CarRentalProgram
{
    public partial class frmInventory : Form
    {
        private InventoryManagement inventory;
        public frmInventory()
        {
            InitializeComponent();
            inventory = new InventoryManagement();

        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            //Load DB or Establish connection
            //

            DataTable inventoryData = inventory.GetInventory();
            dgwInventory.DataSource = inventoryData;


        }

        private void btnRent_Click(object sender, EventArgs e)
        {


            //Grabs car from tag property
            Car selectedCar;


            //If the car is available allow the user to rent it
            //if (selectedCar.IsAvailable)
            //{
            //    frmRental RentalForm = new frmRental(selectedCar);
            //    RentalForm.ShowDialog();
            //} else

            ////If not display error
            //{
            //    MessageBox.Show("Please select an available vehicle!");

            //}

        }
    



   
       
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void pbCar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
