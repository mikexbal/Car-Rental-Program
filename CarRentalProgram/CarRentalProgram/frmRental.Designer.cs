namespace CarRentalProgram
{
    partial class frmRental
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
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCarHeader = new System.Windows.Forms.Label();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblPolicy = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLicense = new System.Windows.Forms.TextBox();
            this.tbPolicy = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(300, 25);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(391, 256);
            this.pbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCar.TabIndex = 0;
            this.pbCar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDays);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbPolicy);
            this.groupBox1.Controls.Add(this.tbLicense);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblPolicy);
            this.groupBox1.Controls.Add(this.lblLicense);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 245);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(0, 99);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(161, 25);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone Number:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(74, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblCarHeader
            // 
            this.lblCarHeader.AutoSize = true;
            this.lblCarHeader.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblCarHeader.Location = new System.Drawing.Point(295, 301);
            this.lblCarHeader.Name = "lblCarHeader";
            this.lblCarHeader.Size = new System.Drawing.Size(396, 32);
            this.lblCarHeader.TabIndex = 2;
            this.lblCarHeader.Text = "Year + CarMake  + Model";
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCarInfo.Location = new System.Drawing.Point(296, 346);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(102, 29);
            this.lblCarInfo.TabIndex = 3;
            this.lblCarInfo.Text = "CarInfo";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(47, 158);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(477, 54);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(174, 25);
            this.lblLicense.TabIndex = 3;
            this.lblLicense.Text = "License Number:";
            // 
            // lblPolicy
            // 
            this.lblPolicy.AutoSize = true;
            this.lblPolicy.Location = new System.Drawing.Point(494, 109);
            this.lblPolicy.Name = "lblPolicy";
            this.lblPolicy.Size = new System.Drawing.Size(157, 25);
            this.lblPolicy.TabIndex = 4;
            this.lblPolicy.Text = "Policy Number:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(273, 48);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(182, 31);
            this.tbName.TabIndex = 5;
            // 
            // tbLicense
            // 
            this.tbLicense.Location = new System.Drawing.Point(737, 48);
            this.tbLicense.Name = "tbLicense";
            this.tbLicense.Size = new System.Drawing.Size(182, 31);
            this.tbLicense.TabIndex = 6;
            // 
            // tbPolicy
            // 
            this.tbPolicy.Location = new System.Drawing.Point(737, 109);
            this.tbPolicy.Name = "tbPolicy";
            this.tbPolicy.Size = new System.Drawing.Size(182, 31);
            this.tbPolicy.TabIndex = 7;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(273, 158);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(182, 31);
            this.tbEmail.TabIndex = 8;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(273, 99);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(182, 31);
            this.tbPhone.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rental Days:";
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(737, 164);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(182, 31);
            this.tbDays.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 785);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 108);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 1162);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.lblCarHeader);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbCar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRental";
            this.Text = "Rent Car";
            this.Load += new System.EventHandler(this.frmRental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCarHeader;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Label lblPolicy;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbLicense;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPolicy;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}