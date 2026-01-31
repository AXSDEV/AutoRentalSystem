namespace AutoRentalSystem
{
    partial class ReserveVehicleForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_licensePlate = new System.Windows.Forms.Label();
            this.textbox_licensePlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_startDate = new System.Windows.Forms.Label();
            this.label_endDate = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker_endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_reserveVehicle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.btn_reserveVehicle);
            this.guna2Panel1.Controls.Add(this.dateTimePicker_endDate);
            this.guna2Panel1.Controls.Add(this.dateTimePicker_startDate);
            this.guna2Panel1.Controls.Add(this.textbox_licensePlate);
            this.guna2Panel1.Controls.Add(this.label_endDate);
            this.guna2Panel1.Controls.Add(this.label_startDate);
            this.guna2Panel1.Controls.Add(this.label_licensePlate);
            this.guna2Panel1.Controls.Add(this.label_title);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(600, 450);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_title.Location = new System.Drawing.Point(194, 27);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(205, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Reserve Vehicle";
            // 
            // label_licensePlate
            // 
            this.label_licensePlate.AutoSize = true;
            this.label_licensePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_licensePlate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_licensePlate.Location = new System.Drawing.Point(44, 99);
            this.label_licensePlate.Name = "label_licensePlate";
            this.label_licensePlate.Size = new System.Drawing.Size(122, 25);
            this.label_licensePlate.TabIndex = 1;
            this.label_licensePlate.Text = "License Plate";
            // 
            // textbox_licensePlate
            // 
            this.textbox_licensePlate.BorderRadius = 10;
            this.textbox_licensePlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_licensePlate.DefaultText = "";
            this.textbox_licensePlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_licensePlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_licensePlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_licensePlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_licensePlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_licensePlate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_licensePlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_licensePlate.Location = new System.Drawing.Point(49, 127);
            this.textbox_licensePlate.Name = "textbox_licensePlate";
            this.textbox_licensePlate.PlaceholderText = "";
            this.textbox_licensePlate.SelectedText = "";
            this.textbox_licensePlate.Size = new System.Drawing.Size(500, 36);
            this.textbox_licensePlate.TabIndex = 2;
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_startDate.Location = new System.Drawing.Point(45, 191);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(99, 25);
            this.label_startDate.TabIndex = 1;
            this.label_startDate.Text = "Start Date";
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_endDate.Location = new System.Drawing.Point(344, 191);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(90, 25);
            this.label_endDate.TabIndex = 1;
            this.label_endDate.Text = "End Date";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.BorderRadius = 10;
            this.dateTimePicker_startDate.Checked = true;
            this.dateTimePicker_startDate.FillColor = System.Drawing.Color.White;
            this.dateTimePicker_startDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_startDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(49, 219);
            this.dateTimePicker_startDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_startDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(200, 36);
            this.dateTimePicker_startDate.TabIndex = 3;
            this.dateTimePicker_startDate.Value = new System.DateTime(2026, 1, 31, 20, 45, 34, 729);
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.BorderRadius = 10;
            this.dateTimePicker_endDate.Checked = true;
            this.dateTimePicker_endDate.FillColor = System.Drawing.Color.White;
            this.dateTimePicker_endDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker_endDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(349, 219);
            this.dateTimePicker_endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(200, 36);
            this.dateTimePicker_endDate.TabIndex = 3;
            this.dateTimePicker_endDate.Value = new System.DateTime(2026, 1, 31, 20, 45, 34, 729);
            // 
            // btn_reserveVehicle
            // 
            this.btn_reserveVehicle.BorderRadius = 10;
            this.btn_reserveVehicle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reserveVehicle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reserveVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reserveVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reserveVehicle.FillColor = System.Drawing.Color.White;
            this.btn_reserveVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserveVehicle.ForeColor = System.Drawing.Color.Black;
            this.btn_reserveVehicle.Location = new System.Drawing.Point(49, 311);
            this.btn_reserveVehicle.Name = "btn_reserveVehicle";
            this.btn_reserveVehicle.Size = new System.Drawing.Size(500, 45);
            this.btn_reserveVehicle.TabIndex = 4;
            this.btn_reserveVehicle.Text = "Reserve Vehicle";
            // 
            // ReserveVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReserveVehicleForm";
            this.Text = "ReserveVehicleForm";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_title;
        private Guna.UI2.WinForms.Guna2TextBox textbox_licensePlate;
        private System.Windows.Forms.Label label_licensePlate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Label label_startDate;
        private Guna.UI2.WinForms.Guna2Button btn_reserveVehicle;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_endDate;
    }
}