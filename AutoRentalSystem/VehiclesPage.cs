﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
 namespace AutoRentalSystem
{
    public partial class VehiclesPage : UserControl
    {
        private readonly string _vehiclesFilePath = Path.Combine(
        AppDomain.CurrentDomain.BaseDirectory,
        "data",
        "vehicles.csv");
        public VehiclesPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            this.AutoScroll = false;
            
            foreach (Control c in this.Controls)
            {
                Console.WriteLine($"{c.Name} - AutoScroll: {c is ScrollableControl sc && sc.AutoScroll}");
            }
        }

        private void btn_addvehicle_Click(object sender, EventArgs e)
        {
            using (var form = new VehicleAddForm())
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }

        private bool _samplesLoaded;
        private void VehiclesPage_Load(object sender, EventArgs e)
        {
            if (_samplesLoaded)
            {
                return;
            }

           
            LoadVehiclesFromFile();
            _samplesLoaded = true;
        }
 

        private void LoadVehiclesFromFile()
        {
            
            flowpanel_list.Controls.Clear();
            if (!File.Exists(_vehiclesFilePath))
             {
                MessageBox.Show(
                $"Ficheiro CSV não encontrado: {_vehiclesFilePath}",
                "Dados de veículos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
             }
            
            var vehicles = CsvExportService.ImportVehicles(_vehiclesFilePath);
            foreach (var vehicle in vehicles)
            {
                AddVehicleCard(vehicle);
            }
        }
 
        private void AddVehicleCard(Vehicle vehicle)
        {
            if (vehicle == null)
            {
                return;
            }

            flowpanel_list.Controls.Add(new VehicleCards(vehicle));
         }
     }
 }

