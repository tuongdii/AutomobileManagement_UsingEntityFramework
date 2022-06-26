namespace AutoMobileForm
{
    partial class frmCarDetails
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
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbReleasedYear = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtReleasedYear = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(55, 40);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(39, 15);
            this.lbCarID.TabIndex = 0;
            this.lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(55, 85);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(60, 15);
            this.lbCarName.TabIndex = 1;
            this.lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(55, 129);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(79, 15);
            this.lbManufacturer.TabIndex = 2;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(55, 172);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            this.lbReleasedYear.AutoSize = true;
            this.lbReleasedYear.Location = new System.Drawing.Point(55, 214);
            this.lbReleasedYear.Name = "lbReleasedYear";
            this.lbReleasedYear.Size = new System.Drawing.Size(78, 15);
            this.lbReleasedYear.TabIndex = 4;
            this.lbReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(155, 36);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(311, 23);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(155, 81);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(311, 23);
            this.txtCarName.TabIndex = 6;
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(155, 125);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(311, 23);
            this.cboManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(155, 168);
            this.txtPrice.Mask = "000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(311, 23);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "0";
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(155, 210);
            this.txtReleasedYear.Mask = "0000";
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(311, 23);
            this.txtReleasedYear.TabIndex = 9;
            this.txtReleasedYear.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(172, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(282, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 302);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbReleasedYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbCarID);
            this.Name = "frmCarDetails";
            this.Text = "Car Details";
            this.Load += new System.EventHandler(this.CarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleasedYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleasedYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}