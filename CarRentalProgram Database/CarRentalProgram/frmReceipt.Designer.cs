namespace CarRentalProgram
{
    partial class frmReceipt
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
            this.lblBreakdown = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.lblCarHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBreakdown
            // 
            this.lblBreakdown.AutoSize = true;
            this.lblBreakdown.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakdown.Location = new System.Drawing.Point(310, 654);
            this.lblBreakdown.Name = "lblBreakdown";
            this.lblBreakdown.Size = new System.Drawing.Size(180, 37);
            this.lblBreakdown.TabIndex = 0;
            this.lblBreakdown.Text = "lblBreakdown";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(68, 177);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(208, 37);
            this.lblCustomerInfo.TabIndex = 1;
            this.lblCustomerInfo.Text = "lblCustomerInfo";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe MDL2 Assets", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(40, 32);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(202, 53);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "DateTime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(34, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 10);
            this.panel1.TabIndex = 3;
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F);
            this.lblCarInfo.Location = new System.Drawing.Point(68, 431);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(134, 37);
            this.lblCarInfo.TabIndex = 4;
            this.lblCarInfo.Text = "lblCarInfo";
            // 
            // lblCarHeader
            // 
            this.lblCarHeader.AutoSize = true;
            this.lblCarHeader.Font = new System.Drawing.Font("Segoe MDL2 Assets", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarHeader.Location = new System.Drawing.Point(68, 394);
            this.lblCarHeader.Name = "lblCarHeader";
            this.lblCarHeader.Size = new System.Drawing.Size(189, 37);
            this.lblCarHeader.TabIndex = 5;
            this.lblCarHeader.Text = "lblCarHeader";
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 1011);
            this.Controls.Add(this.lblCarHeader);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblCustomerInfo);
            this.Controls.Add(this.lblBreakdown);
            this.Name = "frmReceipt";
            this.Text = "frmReciept";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBreakdown;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Label lblCarHeader;
    }
}