namespace AutoMobileForm
{
    partial class frmCarManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCarID = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbReleasedYear = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReleasedYear = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dvgCarList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(43, 45);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(39, 15);
            this.lbCarID.TabIndex = 0;
            this.lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(43, 95);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(60, 15);
            this.lbCarName.TabIndex = 1;
            this.lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(43, 139);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(79, 15);
            this.lbManufacturer.TabIndex = 2;
            this.lbManufacturer.Text = "Manufacturer";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(137, 41);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(237, 23);
            this.txtCarID.TabIndex = 3;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(137, 92);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(237, 23);
            this.txtCarName.TabIndex = 4;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(137, 136);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(237, 23);
            this.txtManufacturer.TabIndex = 5;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(410, 45);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 6;
            this.lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            this.lbReleasedYear.AutoSize = true;
            this.lbReleasedYear.Location = new System.Drawing.Point(410, 95);
            this.lbReleasedYear.Name = "lbReleasedYear";
            this.lbReleasedYear.Size = new System.Drawing.Size(78, 15);
            this.lbReleasedYear.TabIndex = 7;
            this.lbReleasedYear.Text = "Released Year";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(492, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(237, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(492, 91);
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(237, 23);
            this.txtReleasedYear.TabIndex = 9;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(174, 184);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(345, 184);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 184);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dvgCarList
            // 
            this.dvgCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCarList.Location = new System.Drawing.Point(1, 230);
            this.dvgCarList.Name = "dvgCarList";
            this.dvgCarList.ReadOnly = true;
            this.dvgCarList.RowTemplate.Height = 25;
            this.dvgCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCarList.Size = new System.Drawing.Size(801, 201);
            this.dvgCarList.TabIndex = 13;
            this.dvgCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCarList_CellDoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(345, 445);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dvgCarList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbReleasedYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbCarID);
            this.Name = "frmCarManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Management";
            this.Load += new System.EventHandler(this.frmCarManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleasedYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleasedYear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dvgCarList;
        private System.Windows.Forms.Button btnClose;
    }
}
