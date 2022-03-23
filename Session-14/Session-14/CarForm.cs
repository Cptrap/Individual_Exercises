using DevExpress.XtraEditors;
using Session_014.EF.Repositories;
using Session_14.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Session_14

{
    public partial class CarForm : DevExpress.XtraEditors.XtraForm
    {

        private readonly IEntityRepo<Car> _carRepo;

        private List<Car> _cars = new List<Car>();
        public CarForm()
        {
            InitializeComponent();      
        }
        public CarForm(IEntityRepo<Car> carRepo)
        {
            InitializeComponent();
            _carRepo = carRepo;
        }
        private void CarForm_Load(object sender, EventArgs e)
        {
            cmbBrands.Properties.Items.AddRange(typeof(Brands).GetEnumValues());
            RefreshCars();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var carBrand = (Brands)Enum.Parse(typeof(Brands), cmbBrands.SelectedItem.ToString());
            var carModel = txtModel.Text;
            var carRegNumber = txtRegNumber.Text;
            var car = new Car(carBrand, carModel, carRegNumber);
            _carRepo.Create(car);
            RefreshCars();

        }      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedIndexes = grvCars.GetSelectedRows();
            var selectedCustomer = grvCars.GetRow(selectedIndexes[0]) as Car;
            if (selectedCustomer is not null)
            {
                _carRepo.Delete(selectedCustomer.ID);
                RefreshCars();
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RefreshCars()
        {
            _cars = _carRepo.GetAll();
            grdCars.DataSource = null;
            grdCars.DataSource = _cars;
            grdCars.Refresh();
            grdCars.Update();
        }
    }
}