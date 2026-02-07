using System;
using System.Windows.Forms;
using System.Drawing;

namespace AutoRentalSystem
{
    public partial class AlterStateForm : Form
    {
        public string SelectedState { get; private set; }
        public DateTime? MaintenanceStartDate { get; private set; }
        public DateTime? MaintenanceEndDate { get; private set; }
        private UserControl _currentStateUC;
        private DateTime? _initialMaintenanceStartDate;
        private DateTime? _initialMaintenanceEndDate;
        private bool _applyInitialMaintenanceDates;

        public AlterStateForm()
        {
            InitializeComponent();
            ConfigureStatusOptions();
        }

        public AlterStateForm(string currentState, DateTime? maintenanceStartDate, DateTime? maintenanceEndDate)
            : this()
        {
            ApplyInitialState(currentState, maintenanceStartDate, maintenanceEndDate);
        }

        private void ConfigureStatusOptions()
        {
            if (comboBox_status.Items.Count == 0)
            {
                comboBox_status.Items.Add("Available");
                comboBox_status.Items.Add("Maintenance");
            }


            comboBox_status.SelectedIndexChanged += comboBox_status_SelectedIndexChanged;
            comboBox_status.SelectedIndex = 0; // garante o item selecionado

            LoadStatePanel(comboBox_status.SelectedItem?.ToString());

            this.BackColor = Color.FromArgb(34, 33, 42);
            this.TransparencyKey = Color.FromArgb(34, 33, 42);
        }

        private void ApplyInitialState(string currentState, DateTime? maintenanceStartDate, DateTime? maintenanceEndDate)
        {
            _initialMaintenanceStartDate = maintenanceStartDate;
            _initialMaintenanceEndDate = maintenanceEndDate;
            _applyInitialMaintenanceDates = maintenanceStartDate.HasValue && maintenanceEndDate.HasValue;

            if (!string.IsNullOrWhiteSpace(currentState))
            {
                foreach (var item in comboBox_status.Items)
                {
                    if (string.Equals(item?.ToString(), currentState, StringComparison.OrdinalIgnoreCase))
                    {
                        comboBox_status.SelectedItem = item;
                        break;
                    }
                }
            }

            ApplyInitialMaintenanceDates();
        }

        private void LoadStatePanel(string state)
        {
            if (panel_dateTimePicker == null) return;

            panel_dateTimePicker.Controls.Clear();
            _currentStateUC?.Dispose();
            _currentStateUC = null;

            if (string.IsNullOrWhiteSpace(state))
                return;

            switch (state)
            {
                case "Maintenance":
                    _currentStateUC = new UC_AlterState_DateTimePicker();
                    break;

                default:
                    return;
            }

            _currentStateUC.Dock = DockStyle.Fill;
            panel_dateTimePicker.Controls.Add(_currentStateUC);
            ApplyInitialMaintenanceDates();
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStatePanel(comboBox_status.SelectedItem?.ToString());
        }
        private void ApplyInitialMaintenanceDates()
        {
            if (!_applyInitialMaintenanceDates)
            {
                return;
            }

            if (_currentStateUC is UC_AlterState_DateTimePicker maintenancePicker)
            {
                maintenancePicker.MaintenanceStartDate = _initialMaintenanceStartDate.Value;
                maintenancePicker.MaintenanceEndDate = _initialMaintenanceEndDate.Value;
                _applyInitialMaintenanceDates = false;
            }
        }

        private void btn_alterState_Click(object sender, EventArgs e)
        {
            if (comboBox_status.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a state.",
                    "Alter state",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            SelectedState = comboBox_status.SelectedItem.ToString();
            MaintenanceStartDate = null;
            MaintenanceEndDate = null;

            if (SelectedState == "Maintenance")
            {
                if (_currentStateUC is UC_AlterState_DateTimePicker maintenancePicker)
                {
                    var start = maintenancePicker.MaintenanceStartDate;
                    var end = maintenancePicker.MaintenanceEndDate;

                    if (end < start)
                    {
                        MessageBox.Show(
                            "End date must be after start date.",
                            "Alter state",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    MaintenanceStartDate = start;
                    MaintenanceEndDate = end;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.FillColor = System.Drawing.Color.Red;
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.FillColor = System.Drawing.Color.Transparent;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
