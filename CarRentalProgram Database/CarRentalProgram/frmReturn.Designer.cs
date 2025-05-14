namespace CarRentalProgram
{
    partial class frmReturn
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblVIN = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.tbVIN = new System.Windows.Forms.TextBox();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCracked = new System.Windows.Forms.CheckBox();
            this.cbDentsScratches = new System.Windows.Forms.CheckBox();
            this.cbPaint = new System.Windows.Forms.CheckBox();
            this.cbTire = new System.Windows.Forms.CheckBox();
            this.cbMechanicalIssues = new System.Windows.Forms.CheckBox();
            this.cbInterior = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(278, 379);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(148, 59);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblVIN
            // 
            this.lblVIN.AutoSize = true;
            this.lblVIN.Location = new System.Drawing.Point(141, 47);
            this.lblVIN.Name = "lblVIN";
            this.lblVIN.Size = new System.Drawing.Size(52, 25);
            this.lblVIN.TabIndex = 3;
            this.lblVIN.Text = "VIN:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(124, 101);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(94, 25);
            this.lblMileage.TabIndex = 4;
            this.lblMileage.Text = "Mileage:";
            // 
            // tbVIN
            // 
            this.tbVIN.Location = new System.Drawing.Point(223, 41);
            this.tbVIN.Name = "tbVIN";
            this.tbVIN.Size = new System.Drawing.Size(159, 31);
            this.tbVIN.TabIndex = 6;
            // 
            // tbMileage
            // 
            this.tbMileage.Location = new System.Drawing.Point(223, 95);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.Size = new System.Drawing.Size(159, 31);
            this.tbMileage.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInterior);
            this.groupBox1.Controls.Add(this.cbMechanicalIssues);
            this.groupBox1.Controls.Add(this.cbTire);
            this.groupBox1.Controls.Add(this.cbPaint);
            this.groupBox1.Controls.Add(this.cbDentsScratches);
            this.groupBox1.Controls.Add(this.cbCracked);
            this.groupBox1.Location = new System.Drawing.Point(12, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 215);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Damage Claims";
            // 
            // cbCracked
            // 
            this.cbCracked.AutoSize = true;
            this.cbCracked.Location = new System.Drawing.Point(17, 52);
            this.cbCracked.Name = "cbCracked";
            this.cbCracked.Size = new System.Drawing.Size(224, 29);
            this.cbCracked.TabIndex = 0;
            this.cbCracked.Text = "Cracked Winshield";
            this.cbCracked.UseVisualStyleBackColor = true;
            // 
            // cbDentsScratches
            // 
            this.cbDentsScratches.AutoSize = true;
            this.cbDentsScratches.Location = new System.Drawing.Point(17, 112);
            this.cbDentsScratches.Name = "cbDentsScratches";
            this.cbDentsScratches.Size = new System.Drawing.Size(214, 29);
            this.cbDentsScratches.TabIndex = 1;
            this.cbDentsScratches.Text = "Dents / Scratches";
            this.cbDentsScratches.UseVisualStyleBackColor = true;
            // 
            // cbPaint
            // 
            this.cbPaint.AutoSize = true;
            this.cbPaint.Location = new System.Drawing.Point(283, 52);
            this.cbPaint.Name = "cbPaint";
            this.cbPaint.Size = new System.Drawing.Size(179, 29);
            this.cbPaint.TabIndex = 2;
            this.cbPaint.Text = "Paint Damage";
            this.cbPaint.UseVisualStyleBackColor = true;
            // 
            // cbTire
            // 
            this.cbTire.AutoSize = true;
            this.cbTire.Location = new System.Drawing.Point(283, 112);
            this.cbTire.Name = "cbTire";
            this.cbTire.Size = new System.Drawing.Size(167, 29);
            this.cbTire.TabIndex = 3;
            this.cbTire.Text = "Tire Damage";
            this.cbTire.UseVisualStyleBackColor = true;
            // 
            // cbMechanicalIssues
            // 
            this.cbMechanicalIssues.AutoSize = true;
            this.cbMechanicalIssues.Location = new System.Drawing.Point(17, 167);
            this.cbMechanicalIssues.Name = "cbMechanicalIssues";
            this.cbMechanicalIssues.Size = new System.Drawing.Size(222, 29);
            this.cbMechanicalIssues.TabIndex = 4;
            this.cbMechanicalIssues.Text = "Mechanical Issues";
            this.cbMechanicalIssues.UseVisualStyleBackColor = true;
            // 
            // cbInterior
            // 
            this.cbInterior.AutoSize = true;
            this.cbInterior.Location = new System.Drawing.Point(283, 167);
            this.cbInterior.Name = "cbInterior";
            this.cbInterior.Size = new System.Drawing.Size(196, 29);
            this.cbInterior.TabIndex = 5;
            this.cbInterior.Text = "Interior Damage";
            this.cbInterior.UseVisualStyleBackColor = true;
            this.cbInterior.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(95, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMileage);
            this.Controls.Add(this.tbVIN);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblVIN);
            this.Controls.Add(this.btnClose);
            this.Name = "frmReturn";
            this.Text = "Return Car";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblVIN;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox tbVIN;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbInterior;
        private System.Windows.Forms.CheckBox cbMechanicalIssues;
        private System.Windows.Forms.CheckBox cbTire;
        private System.Windows.Forms.CheckBox cbPaint;
        private System.Windows.Forms.CheckBox cbDentsScratches;
        private System.Windows.Forms.CheckBox cbCracked;
        private System.Windows.Forms.Button button1;
    }
}