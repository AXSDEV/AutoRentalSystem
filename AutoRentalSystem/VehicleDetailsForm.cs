using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AutoRentalSystem
{
    public partial class VehicleDetailsForm : Form
    {
        private Vehicle _vehicle;

        private readonly UC_VehicleDetails_Car _ucCar;
        private readonly UC_VehicleDetails_Bike _ucBike;
        private readonly UC_VehicleDetails_Bus _ucBus;
        private readonly UC_VehicleDetails_Truck _ucTruck;

        public VehicleDetailsForm(Vehicle vehicle)
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;

            _vehicle = vehicle;
            _ucCar = new UC_VehicleDetails_Car { Dock = DockStyle.Fill, Visible = false };
            _ucBike = new UC_VehicleDetails_Bike { Dock = DockStyle.Fill, Visible = false };
            _ucBus = new UC_VehicleDetails_Bus { Dock = DockStyle.Fill, Visible = false };
            _ucTruck = new UC_VehicleDetails_Truck { Dock = DockStyle.Fill, Visible = false };

            // Adicionar ao painel
            panel_details.Controls.Add(_ucCar);
            panel_details.Controls.Add(_ucBike);
            panel_details.Controls.Add(_ucBus);
            panel_details.Controls.Add(_ucTruck);

            LoadData();
        }

        private void LoadData()
        {
            if (_vehicle == null) return;

            BindCommonFields(_vehicle);

            switch (_vehicle)
            {
                case Car car:
                    label_type_info.Text = "Car";
                    ShowDetailsPanel(_ucCar);
                    _ucCar.LoadData(car);
                    break;

                case Motorcycle bike:
                    label_type_info.Text = "Motorcycle";
                    ShowDetailsPanel(_ucBike);
                    _ucBike.LoadData(bike);
                    break;

                case Bus bus:
                    label_type_info.Text = "Bus";
                    ShowDetailsPanel(_ucBus);
                    _ucBus.LoadData(bus);
                    break;

                case Truck truck:
                    label_type_info.Text = "Truck";
                    ShowDetailsPanel(_ucTruck);
                    _ucTruck.LoadData(truck);
                    break;

                default:
                    break;
            }
        }

        private void BindCommonFields(Vehicle v)
        {
            label_licensePlate_info.Text = v.LicensePlate ?? "-";
            label_maker_info.Text = v.Maker ?? "-";
            label_model_info.Text = v.Model ?? "-";
            label_year_info.Text = v.Year.ToString(CultureInfo.CurrentCulture);

            label_fuel_info.Text = v.FuelType ?? "-";
            label_shiftType_info.Text = v.ShiftType ?? "-";

            label_dailyPrice_info.Text = v.DailyPrice.ToString("C", new CultureInfo("pt-PT"));

        }

        private void ShowDetailsPanel(Control panelToShow)
        {
            foreach (Control c in panel_details.Controls)
                c.Visible = false;

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
            => btn_close.FillColor = Color.Red;

        private void btn_close_MouseLeave(object sender, EventArgs e)
            => btn_close.FillColor = Color.Transparent;

        private void btn_close_Click(object sender, EventArgs e) => Close();
    }
}