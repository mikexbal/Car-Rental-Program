namespace CarRentalProgram
{
    partial class frmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblRental = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.gbAvalible = new System.Windows.Forms.GroupBox();
            this.cbAvailable = new System.Windows.Forms.ComboBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.Button();
            this.gbClassification = new System.Windows.Forms.GroupBox();
            this.cbClassification = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblVIN = new System.Windows.Forms.Label();
            this.txtVIN = new System.Windows.Forms.TextBox();
            this.gbAvalible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.gbClassification.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(461, 323);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 91);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Car";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(43, 104);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(145, 25);
            this.lblManufacturer.TabIndex = 8;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(80, 221);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(70, 25);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year: ";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(74, 165);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(83, 25);
            this.lblModel.TabIndex = 10;
            this.lblModel.Text = "Model: ";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(65, 275);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(100, 25);
            this.lblMileage.TabIndex = 11;
            this.lblMileage.Text = "Mileage: ";
            // 
            // lblRental
            // 
            this.lblRental.AutoSize = true;
            this.lblRental.Location = new System.Drawing.Point(10, 332);
            this.lblRental.Name = "lblRental";
            this.lblRental.Size = new System.Drawing.Size(211, 25);
            this.lblRental.TabIndex = 12;
            this.lblRental.Text = "Rental Cost per Day:";
            this.lblRental.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(52, 389);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(65, 446);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(100, 25);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location:";
            // 
            // gbAvalible
            // 
            this.gbAvalible.Controls.Add(this.cbAvailable);
            this.gbAvalible.Location = new System.Drawing.Point(448, 38);
            this.gbAvalible.Name = "gbAvalible";
            this.gbAvalible.Size = new System.Drawing.Size(218, 123);
            this.gbAvalible.TabIndex = 15;
            this.gbAvalible.TabStop = false;
            this.gbAvalible.Text = "Availability ";
            // 
            // cbAvailable
            // 
            this.cbAvailable.FormattingEnabled = true;
            this.cbAvailable.Items.AddRange(new object[] {
            "Available",
            "Rented"});
            this.cbAvailable.Location = new System.Drawing.Point(14, 57);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(191, 33);
            this.cbAvailable.TabIndex = 0;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(234, 104);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(167, 31);
            this.txtManufacturer.TabIndex = 17;
            this.txtManufacturer.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(234, 221);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(167, 31);
            this.txtYear.TabIndex = 18;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(234, 165);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(167, 31);
            this.txtModel.TabIndex = 19;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(234, 275);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(167, 31);
            this.txtMileage.TabIndex = 20;
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(234, 332);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(167, 31);
            this.txtRentalCost.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(234, 389);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(167, 31);
            this.txtDescription.TabIndex = 22;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(234, 450);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(167, 31);
            this.txtLocation.TabIndex = 23;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(234, 508);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(167, 31);
            this.txtImage.TabIndex = 24;
            this.txtImage.TextChanged += new System.EventHandler(this.txtImage_TextChanged);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(44, 508);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(144, 25);
            this.lblImage.TabIndex = 25;
            this.lblImage.Text = "Image (URL): ";
            // 
            // pbCar
            // 
            this.pbCar.BackColor = System.Drawing.Color.DimGray;
            this.pbCar.Location = new System.Drawing.Point(46, 570);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(351, 283);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 26;
            this.pbCar.TabStop = false;
            this.pbCar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(461, 450);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(192, 91);
            this.btnInventory.TabIndex = 27;
            this.btnInventory.Text = "Show Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // gbClassification
            // 
            this.gbClassification.Controls.Add(this.cbClassification);
            this.gbClassification.Location = new System.Drawing.Point(448, 177);
            this.gbClassification.Name = "gbClassification";
            this.gbClassification.Size = new System.Drawing.Size(218, 123);
            this.gbClassification.TabIndex = 28;
            this.gbClassification.TabStop = false;
            this.gbClassification.Text = "Car Classification";
            // 
            // cbClassification
            // 
            this.cbClassification.FormattingEnabled = true;
            this.cbClassification.Items.AddRange(new object[] {
            "Sedan",
            "SUV",
            "Sport",
            "Coupe",
            "Pickup",
            "Luxury"});
            this.cbClassification.Location = new System.Drawing.Point(14, 56);
            this.cbClassification.Name = "cbClassification";
            this.cbClassification.Size = new System.Drawing.Size(191, 33);
            this.cbClassification.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(461, 580);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(191, 93);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 721);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 95);
            this.button2.TabIndex = 30;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(80, 56);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(52, 25);
            this.lblVIN.TabIndex = 31;
            this.lblVIN.Text = "VIN:";
            // 
            // txtVIN
            // 
            this.txtVIN.Location = new System.Drawing.Point(234, 56);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(167, 31);
            this.txtVIN.TabIndex = 32;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(710, 865);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.lblVIN);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbClassification);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.gbAvalible);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRental);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdd";
            this.Text = "Add Car";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.gbAvalible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.gbClassification.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblRental;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.GroupBox gbAvalible;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.ComboBox cbAvailable;
        private System.Windows.Forms.GroupBox gbClassification;
        private System.Windows.Forms.ComboBox cbClassification;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.TextBox txtVIN;
    }
}