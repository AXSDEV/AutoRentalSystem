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

        public AlterStateForm()
        {
            InitializeComponent();

            if (comboBox_status.Items.Count == 0)
            {
                comboBox_status.Items.Add("Available");
                comboBox_status.Items.Add("Maintenance");
            }

            comboBox_status.SelectedIndexChanged += comboBox_status_SelectedIndexChanged;
            comboBox_status.SelectedIndex = 0; // garante item selecionado

            LoadStatePanel(comboBox_status.SelectedItem?.ToString());

            this.BackColor = Color.FromArgb(34, 33, 42);
            this.TransparencyKey = Color.FromArgb(34, 33, 42);
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
        }

        private void comboBox_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStatePanel(comboBox_status.SelectedItem?.ToString());
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
