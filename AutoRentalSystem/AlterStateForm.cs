using System;
using System.Windows.Forms;
using System.Drawing;


namespace AutoRentalSystem
{
    public partial class AlterStateForm : Form
    {
        public string SelectedState { get; private set; }

        public AlterStateForm()
        {
            InitializeComponent();

            if (comboBox_status.Items.Count == 0)
            {
                comboBox_status.Items.Add("Available");
                comboBox_status.Items.Add("Maintenance");
            }

            comboBox_status.SelectedIndex = 0;

            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
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
