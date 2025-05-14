using System;
using System.Windows.Forms;

namespace CarRentalProgram
{
    public partial class frmMain : Form
    {
        private CarInventory inventory;

        public frmMain()
        {
            InitializeComponent();
            this.inventory = new CarInventory();

            this.FormClosing += new FormClosingEventHandler(frmMain_FormClosing);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd addCarForm = new frmAdd(inventory);
            addCarForm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmReturn returnCar = new frmReturn(inventory);
            returnCar.ShowDialog(); 
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmInventory InventoryForm = new frmInventory(inventory);
            InventoryForm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            inventory.LoadInventory();
            
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the inventory when the form is closing
            inventory.SaveInventory();
        }

    }
}
