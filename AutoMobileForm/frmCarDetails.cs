using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomobileLibrary.BussinessObject.Models;
using AutomobileLibrary.Repository;

namespace AutoMobileForm
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public Car CarInfo { get; set; }
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car
                {
                    CarId = Int32.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = cboManufacturer.Text,
                    Price = Decimal.Parse(txtPrice.Text),
                    ReleasedYear = Int32.Parse(txtReleasedYear.Text)
                };
                if (InsertOrUpdate == false)
                {
                    CarRepository.AddNew(car);
                }
                else
                {
                    CarRepository.Update(car);
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }

        private void CarDetails_Load(object sender, EventArgs e)
        {
            cboManufacturer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtCarID.Text = CarInfo.CarId.ToString();
                txtCarName.Text = CarInfo.CarName;
                cboManufacturer.Text = CarInfo.Manufacturer.Trim();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleasedYear.Text = CarInfo.ReleasedYear.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
