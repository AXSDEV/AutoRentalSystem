namespace AutoRentalSystem
{
    partial class VehicleAddForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleAddForm));
            this.panel_AddVehicle_Background = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_AddVehicleForm_Close = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AddVehicleForm_Car = new Guna.UI2.WinForms.Guna2Button();
            this.label_AddVehicleForm_LicencePlate = new System.Windows.Forms.Label();
            this.label_VehicleAddForm_Title = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel_AddVehicle_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_AddVehicle_Background
            // 
            this.panel_AddVehicle_Background.BackColor = System.Drawing.Color.Transparent;
            this.panel_AddVehicle_Background.BorderRadius = 40;
            this.panel_AddVehicle_Background.Controls.Add(this.btn_AddVehicleForm_Close);
            this.panel_AddVehicle_Background.Controls.Add(this.btn_AddVehicleForm_Car);
            this.panel_AddVehicle_Background.Controls.Add(this.label_AddVehicleForm_LicencePlate);
            this.panel_AddVehicle_Background.Controls.Add(this.label_VehicleAddForm_Title);
            this.panel_AddVehicle_Background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_AddVehicle_Background.Location = new System.Drawing.Point(0, 0);
            this.panel_AddVehicle_Background.Name = "panel_AddVehicle_Background";
            this.panel_AddVehicle_Background.Size = new System.Drawing.Size(800, 600);
            this.panel_AddVehicle_Background.TabIndex = 2;
            // 
            // btn_AddVehicleForm_Close
            // 
            this.btn_AddVehicleForm_Close.BorderColor = System.Drawing.Color.White;
            this.btn_AddVehicleForm_Close.BorderRadius = 10;
            this.btn_AddVehicleForm_Close.BorderThickness = 1;
            this.btn_AddVehicleForm_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddVehicleForm_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddVehicleForm_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddVehicleForm_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddVehicleForm_Close.FillColor = System.Drawing.Color.Transparent;
            this.btn_AddVehicleForm_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddVehicleForm_Close.ForeColor = System.Drawing.Color.White;
            this.btn_AddVehicleForm_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddVehicleForm_Close.Image")));
            this.btn_AddVehicleForm_Close.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_AddVehicleForm_Close.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_AddVehicleForm_Close.Location = new System.Drawing.Point(735, 22);
            this.btn_AddVehicleForm_Close.Name = "btn_AddVehicleForm_Close";
            this.btn_AddVehicleForm_Close.Size = new System.Drawing.Size(40, 40);
            this.btn_AddVehicleForm_Close.TabIndex = 0;
            this.btn_AddVehicleForm_Close.Click += new System.EventHandler(this.btn_AddVehicleForm_Close_Click);
            this.btn_AddVehicleForm_Close.MouseEnter += new System.EventHandler(this.btn_AddVehicleForm_Close_MouseEnter);
            this.btn_AddVehicleForm_Close.MouseLeave += new System.EventHandler(this.btn_AddVehicleForm_Close_MouseLeave);
            // 
            // btn_AddVehicleForm_Car
            // 
            this.btn_AddVehicleForm_Car.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddVehicleForm_Car.BorderRadius = 20;
            this.btn_AddVehicleForm_Car.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btn_AddVehicleForm_Car.CustomBorderColor = System.Drawing.Color.White;
            this.btn_AddVehicleForm_Car.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddVehicleForm_Car.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddVehicleForm_Car.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddVehicleForm_Car.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddVehicleForm_Car.FillColor = System.Drawing.Color.White;
            this.btn_AddVehicleForm_Car.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddVehicleForm_Car.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.btn_AddVehicleForm_Car.Location = new System.Drawing.Point(68, 100);
            this.btn_AddVehicleForm_Car.Name = "btn_AddVehicleForm_Car";
            this.btn_AddVehicleForm_Car.Size = new System.Drawing.Size(123, 45);
            this.btn_AddVehicleForm_Car.TabIndex = 2;
            this.btn_AddVehicleForm_Car.Text = "Car";
            // 
            // label_AddVehicleForm_LicencePlate
            // 
            this.label_AddVehicleForm_LicencePlate.AutoSize = true;
            this.label_AddVehicleForm_LicencePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label_AddVehicleForm_LicencePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_AddVehicleForm_LicencePlate.Location = new System.Drawing.Point(21, 179);
            this.label_AddVehicleForm_LicencePlate.Name = "label_AddVehicleForm_LicencePlate";
            this.label_AddVehicleForm_LicencePlate.Size = new System.Drawing.Size(123, 25);
            this.label_AddVehicleForm_LicencePlate.TabIndex = 1;
            this.label_AddVehicleForm_LicencePlate.Text = "Licence Plate";
            this.label_AddVehicleForm_LicencePlate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_VehicleAddForm_Title
            // 
            this.label_VehicleAddForm_Title.AutoSize = true;
            this.label_VehicleAddForm_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_VehicleAddForm_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_VehicleAddForm_Title.Location = new System.Drawing.Point(309, 25);
            this.label_VehicleAddForm_Title.Name = "label_VehicleAddForm_Title";
            this.label_VehicleAddForm_Title.Size = new System.Drawing.Size(160, 37);
            this.label_VehicleAddForm_Title.TabIndex = 0;
            this.label_VehicleAddForm_Title.Text = "Add Vehicle";
            this.label_VehicleAddForm_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // VehicleAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel_AddVehicle_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleAddForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VehicleAddForm";
            this.panel_AddVehicle_Background.ResumeLayout(false);
            this.panel_AddVehicle_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel_AddVehicle_Background;
        private System.Windows.Forms.Label label_VehicleAddForm_Title;
        private System.Windows.Forms.Label label_AddVehicleForm_LicencePlate;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_AddVehicleForm_Car;
        private Guna.UI2.WinForms.Guna2Button btn_AddVehicleForm_Close;
    }
}