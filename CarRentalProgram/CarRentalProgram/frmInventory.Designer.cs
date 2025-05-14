namespace CarRentalProgram
{
    partial class frmInventory
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
            this.lvCarInventory = new System.Windows.Forms.ListView();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.lblCarMakeModel = new System.Windows.Forms.Label();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radRented = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCarInventory
            // 
            this.lvCarInventory.FullRowSelect = true;
            this.lvCarInventory.GridLines = true;
            this.lvCarInventory.HideSelection = false;
            this.lvCarInventory.Location = new System.Drawing.Point(12, 12);
            this.lvCarInventory.Name = "lvCarInventory";
            this.lvCarInventory.Size = new System.Drawing.Size(798, 382);
            this.lvCarInventory.TabIndex = 0;
            this.lvCarInventory.UseCompatibleStateImageBehavior = false;
            this.lvCarInventory.View = System.Windows.Forms.View.Details;
            this.lvCarInventory.SelectedIndexChanged += new System.EventHandler(this.lvCarInventory_SelectedIndexChanged);
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(827, 23);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(381, 357);
            this.pbCar.TabIndex = 1;
            this.pbCar.TabStop = false;
            // 
            // lblCarMakeModel
            // 
            this.lblCarMakeModel.AutoSize = true;
            this.lblCarMakeModel.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMakeModel.Location = new System.Drawing.Point(821, 406);
            this.lblCarMakeModel.Name = "lblCarMakeModel";
            this.lblCarMakeModel.Size = new System.Drawing.Size(336, 32);
            this.lblCarMakeModel.TabIndex = 2;
            this.lblCarMakeModel.Text = "Year + Make + Model";
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarInfo.Location = new System.Drawing.Point(822, 460);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(102, 29);
            this.lblCarInfo.TabIndex = 3;
            this.lblCarInfo.Text = "CarInfo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radRented);
            this.groupBox1.Controls.Add(this.radAvailable);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Cars";
            // 
            // radRented
            // 
            this.radRented.AutoSize = true;
            this.radRented.Location = new System.Drawing.Point(233, 114);
            this.radRented.Name = "radRented";
            this.radRented.Size = new System.Drawing.Size(112, 29);
            this.radRented.TabIndex = 5;
            this.radRented.TabStop = true;
            this.radRented.Text = "Rented";
            this.radRented.UseVisualStyleBackColor = true;
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Location = new System.Drawing.Point(58, 114);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(131, 29);
            this.radAvailable.TabIndex = 4;
            this.radAvailable.TabStop = true;
            this.radAvailable.Text = "Available";
            this.radAvailable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search Available or Rented:";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(537, 548);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(163, 68);
            this.btnRent.TabIndex = 5;
            this.btnRent.Text = "Rent Car";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 460);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 68);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 637);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.lblCarMakeModel);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.lvCarInventory);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.frmInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCarInventory;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.Label lblCarMakeModel;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radRented;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.Button btnSearch;
    }
}