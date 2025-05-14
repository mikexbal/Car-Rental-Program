using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CarRentalProgram
{
    public partial class frmMain : Form
    {
        
        private InventoryManagement inventoryManagement;

        public frmMain()
        {
            InitializeComponent();
            this.inventoryManagement = new InventoryManagement();

            this.FormClosing += new FormClosingEventHandler(frmMain_FormClosing);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd AddForm = new frmAdd();
            AddForm.ShowDialog();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmInventory invetoryForm = new frmInventory();
            invetoryForm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            inventoryManagement.OpenConnection();

        } 
        

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            inventoryManagement.CloseConnection();
        }

    }
}
