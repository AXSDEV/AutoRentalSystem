namespace AutoRentalSystem
{
    partial class VehicleDetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetailsForm));
            this.panel_VehicleDetailsForm_Background = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_baseDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.label_LicensePlate = new System.Windows.Forms.Label();
            this.label_VehicleDetailsForm_Title = new System.Windows.Forms.Label();
            this.label_maker = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_shiftType = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_fuel = new System.Windows.Forms.Label();
            this.label_dailyPrice = new System.Windows.Forms.Label();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.label_licensePlate_info = new System.Windows.Forms.Label();
            this.label_maker_info = new System.Windows.Forms.Label();
            this.label_year_info = new System.Windows.Forms.Label();
            this.label_shiftType_info = new System.Windows.Forms.Label();
            this.label_type_info = new System.Windows.Forms.Label();
            this.label_model_info = new System.Windows.Forms.Label();
            this.label_fuel_info = new System.Windows.Forms.Label();
            this.label_dailyPrice_info = new System.Windows.Forms.Label();
            this.panel_details = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel_reservations = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_VehicleDetailsForm_Background.SuspendLayout();
            this.panel_baseDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_VehicleDetailsForm_Background
            // 
            this.panel_VehicleDetailsForm_Background.BorderRadius = 40;
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.flowLayoutPanel_reservations);
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.panel_details);
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.btn_close);
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.panel_baseDetails);
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.label_VehicleDetailsForm_Title);
            this.panel_VehicleDetailsForm_Background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_VehicleDetailsForm_Background.Location = new System.Drawing.Point(0, 0);
            this.panel_VehicleDetailsForm_Background.Name = "panel_VehicleDetailsForm_Background";
            this.panel_VehicleDetailsForm_Background.Size = new System.Drawing.Size(1000, 900);
            this.panel_VehicleDetailsForm_Background.TabIndex = 0;
            // 
            // panel_baseDetails
            // 
            this.panel_baseDetails.BackColor = System.Drawing.Color.Transparent;
            this.panel_baseDetails.BorderRadius = 20;
            this.panel_baseDetails.Controls.Add(this.label_dailyPrice_info);
            this.panel_baseDetails.Controls.Add(this.label_fuel_info);
            this.panel_baseDetails.Controls.Add(this.label_model_info);
            this.panel_baseDetails.Controls.Add(this.label_type_info);
            this.panel_baseDetails.Controls.Add(this.label_shiftType_info);
            this.panel_baseDetails.Controls.Add(this.label_year_info);
            this.panel_baseDetails.Controls.Add(this.label_maker_info);
            this.panel_baseDetails.Controls.Add(this.label_licensePlate_info);
            this.panel_baseDetails.Controls.Add(this.label_dailyPrice);
            this.panel_baseDetails.Controls.Add(this.label_fuel);
            this.panel_baseDetails.Controls.Add(this.label_model);
            this.panel_baseDetails.Controls.Add(this.label_type);
            this.panel_baseDetails.Controls.Add(this.label_shiftType);
            this.panel_baseDetails.Controls.Add(this.label_year);
            this.panel_baseDetails.Controls.Add(this.label_maker);
            this.panel_baseDetails.Controls.Add(this.label_LicensePlate);
            this.panel_baseDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.panel_baseDetails.ForeColor = System.Drawing.Color.White;
            this.panel_baseDetails.Location = new System.Drawing.Point(50, 100);
            this.panel_baseDetails.Name = "panel_baseDetails";
            this.panel_baseDetails.Size = new System.Drawing.Size(900, 350);
            this.panel_baseDetails.TabIndex = 1;
            // 
            // label_LicensePlate
            // 
            this.label_LicensePlate.AutoSize = true;
            this.label_LicensePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LicensePlate.Location = new System.Drawing.Point(117, 40);
            this.label_LicensePlate.Name = "label_LicensePlate";
            this.label_LicensePlate.Size = new System.Drawing.Size(132, 25);
            this.label_LicensePlate.TabIndex = 0;
            this.label_LicensePlate.Text = "License Plate :";
            // 
            // label_VehicleDetailsForm_Title
            // 
            this.label_VehicleDetailsForm_Title.AutoSize = true;
            this.label_VehicleDetailsForm_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_VehicleDetailsForm_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 24.25F, System.Drawing.FontStyle.Bold);
            this.label_VehicleDetailsForm_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_VehicleDetailsForm_Title.Location = new System.Drawing.Point(387, 29);
            this.label_VehicleDetailsForm_Title.Name = "label_VehicleDetailsForm_Title";
            this.label_VehicleDetailsForm_Title.Size = new System.Drawing.Size(240, 45);
            this.label_VehicleDetailsForm_Title.TabIndex = 0;
            this.label_VehicleDetailsForm_Title.Text = "Vehicle Details";
            this.label_VehicleDetailsForm_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_maker
            // 
            this.label_maker.AutoSize = true;
            this.label_maker.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maker.Location = new System.Drawing.Point(172, 99);
            this.label_maker.Name = "label_maker";
            this.label_maker.Size = new System.Drawing.Size(77, 25);
            this.label_maker.TabIndex = 0;
            this.label_maker.Text = "Maker :";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year.Location = new System.Drawing.Point(191, 162);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(58, 25);
            this.label_year.TabIndex = 0;
            this.label_year.Text = "Year :";
            // 
            // label_shiftType
            // 
            this.label_shiftType.AutoSize = true;
            this.label_shiftType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shiftType.Location = new System.Drawing.Point(142, 221);
            this.label_shiftType.Name = "label_shiftType";
            this.label_shiftType.Size = new System.Drawing.Size(107, 25);
            this.label_shiftType.TabIndex = 0;
            this.label_shiftType.Text = "Shift Type :";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(582, 40);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(62, 25);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type :";
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_model.Location = new System.Drawing.Point(567, 99);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(77, 25);
            this.label_model.TabIndex = 0;
            this.label_model.Text = "Model :";
            // 
            // label_fuel
            // 
            this.label_fuel.AutoSize = true;
            this.label_fuel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fuel.Location = new System.Drawing.Point(586, 162);
            this.label_fuel.Name = "label_fuel";
            this.label_fuel.Size = new System.Drawing.Size(58, 25);
            this.label_fuel.TabIndex = 0;
            this.label_fuel.Text = "Fuel :";
            // 
            // label_dailyPrice
            // 
            this.label_dailyPrice.AutoSize = true;
            this.label_dailyPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailyPrice.Location = new System.Drawing.Point(531, 221);
            this.label_dailyPrice.Name = "label_dailyPrice";
            this.label_dailyPrice.Size = new System.Drawing.Size(113, 25);
            this.label_dailyPrice.TabIndex = 0;
            this.label_dailyPrice.Text = "Daily Price :";
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderColor = System.Drawing.Color.White;
            this.btn_close.BorderRadius = 10;
            this.btn_close.BorderThickness = 1;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_close.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_close.Location = new System.Drawing.Point(938, 18);
            this.btn_close.Name = "btn_close";
            this.btn_close.PressedColor = System.Drawing.Color.Transparent;
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 2;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // label_licensePlate_info
            // 
            this.label_licensePlate_info.AutoSize = true;
            this.label_licensePlate_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_licensePlate_info.Location = new System.Drawing.Point(267, 40);
            this.label_licensePlate_info.Name = "label_licensePlate_info";
            this.label_licensePlate_info.Size = new System.Drawing.Size(61, 25);
            this.label_licensePlate_info.TabIndex = 1;
            this.label_licensePlate_info.Text = "label1";
            // 
            // label_maker_info
            // 
            this.label_maker_info.AutoSize = true;
            this.label_maker_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maker_info.Location = new System.Drawing.Point(267, 99);
            this.label_maker_info.Name = "label_maker_info";
            this.label_maker_info.Size = new System.Drawing.Size(61, 25);
            this.label_maker_info.TabIndex = 1;
            this.label_maker_info.Text = "label1";
            // 
            // label_year_info
            // 
            this.label_year_info.AutoSize = true;
            this.label_year_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year_info.Location = new System.Drawing.Point(267, 162);
            this.label_year_info.Name = "label_year_info";
            this.label_year_info.Size = new System.Drawing.Size(61, 25);
            this.label_year_info.TabIndex = 1;
            this.label_year_info.Text = "label1";
            // 
            // label_shiftType_info
            // 
            this.label_shiftType_info.AutoSize = true;
            this.label_shiftType_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_shiftType_info.Location = new System.Drawing.Point(267, 221);
            this.label_shiftType_info.Name = "label_shiftType_info";
            this.label_shiftType_info.Size = new System.Drawing.Size(61, 25);
            this.label_shiftType_info.TabIndex = 1;
            this.label_shiftType_info.Text = "label1";
            // 
            // label_type_info
            // 
            this.label_type_info.AutoSize = true;
            this.label_type_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type_info.Location = new System.Drawing.Point(662, 40);
            this.label_type_info.Name = "label_type_info";
            this.label_type_info.Size = new System.Drawing.Size(61, 25);
            this.label_type_info.TabIndex = 1;
            this.label_type_info.Text = "label1";
            // 
            // label_model_info
            // 
            this.label_model_info.AutoSize = true;
            this.label_model_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_model_info.Location = new System.Drawing.Point(662, 99);
            this.label_model_info.Name = "label_model_info";
            this.label_model_info.Size = new System.Drawing.Size(61, 25);
            this.label_model_info.TabIndex = 1;
            this.label_model_info.Text = "label1";
            // 
            // label_fuel_info
            // 
            this.label_fuel_info.AutoSize = true;
            this.label_fuel_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fuel_info.Location = new System.Drawing.Point(662, 162);
            this.label_fuel_info.Name = "label_fuel_info";
            this.label_fuel_info.Size = new System.Drawing.Size(61, 25);
            this.label_fuel_info.TabIndex = 1;
            this.label_fuel_info.Text = "label1";
            // 
            // label_dailyPrice_info
            // 
            this.label_dailyPrice_info.AutoSize = true;
            this.label_dailyPrice_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailyPrice_info.Location = new System.Drawing.Point(662, 221);
            this.label_dailyPrice_info.Name = "label_dailyPrice_info";
            this.label_dailyPrice_info.Size = new System.Drawing.Size(61, 25);
            this.label_dailyPrice_info.TabIndex = 1;
            this.label_dailyPrice_info.Text = "label1";
            // 
            // panel_details
            // 
            this.panel_details.BackColor = System.Drawing.Color.Transparent;
            this.panel_details.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.panel_details.Location = new System.Drawing.Point(50, 358);
            this.panel_details.Name = "panel_details";
            this.panel_details.Size = new System.Drawing.Size(900, 77);
            this.panel_details.TabIndex = 2;
            // 
            // flowLayoutPanel_reservations
            // 
            this.flowLayoutPanel_reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.flowLayoutPanel_reservations.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_reservations.Location = new System.Drawing.Point(50, 536);
            this.flowLayoutPanel_reservations.Name = "flowLayoutPanel_reservations";
            this.flowLayoutPanel_reservations.Size = new System.Drawing.Size(900, 330);
            this.flowLayoutPanel_reservations.TabIndex = 3;
            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 900);
            this.ControlBox = false;
            this.Controls.Add(this.panel_VehicleDetailsForm_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleDetailsForm";
            this.Text = "VehicleDetailsForm";
            this.panel_VehicleDetailsForm_Background.ResumeLayout(false);
            this.panel_VehicleDetailsForm_Background.PerformLayout();
            this.panel_baseDetails.ResumeLayout(false);
            this.panel_baseDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_VehicleDetailsForm_Background;
        private System.Windows.Forms.Label label_VehicleDetailsForm_Title;
        private Guna.UI2.WinForms.Guna2Panel panel_baseDetails;
        private System.Windows.Forms.Label label_LicensePlate;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Label label_dailyPrice;
        private System.Windows.Forms.Label label_fuel;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_shiftType;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_maker;
        private System.Windows.Forms.Label label_dailyPrice_info;
        private System.Windows.Forms.Label label_fuel_info;
        private System.Windows.Forms.Label label_model_info;
        private System.Windows.Forms.Label label_type_info;
        private System.Windows.Forms.Label label_shiftType_info;
        private System.Windows.Forms.Label label_year_info;
        private System.Windows.Forms.Label label_maker_info;
        private System.Windows.Forms.Label label_licensePlate_info;
        private Guna.UI2.WinForms.Guna2Panel panel_details;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_reservations;
    }
}