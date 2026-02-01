using System;

namespace AutoRentalSystem
{
    partial class VehiclesPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiclesPage));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.panel_titlebar = new Guna.UI2.WinForms.Guna2Panel();
            this.label_actions = new System.Windows.Forms.Label();
            this.label_dailyprice = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_vtype = new System.Windows.Forms.Label();
            this.label_maker = new System.Windows.Forms.Label();
            this.label_licenseplate = new System.Windows.Forms.Label();
            this.flowpanel_list = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panel_VehiclesPage_Description = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBox_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_vehicleType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel_titlebar.SuspendLayout();
            this.panel_VehiclesPage_Description.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(282, 570);
            this.guna2Panel1.TabIndex = 0;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.BackColor = System.Drawing.Color.Black;
            this.title_label.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.Control;
            this.title_label.Location = new System.Drawing.Point(313, 65);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(62, 23);
            this.title_label.TabIndex = 4;
            this.title_label.Text = "label2";
            // 
            // panel_titlebar
            // 
            this.panel_titlebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_titlebar.BackColor = System.Drawing.Color.Transparent;
            this.panel_titlebar.BorderRadius = 10;
            this.panel_titlebar.Controls.Add(this.label_actions);
            this.panel_titlebar.Controls.Add(this.label_dailyprice);
            this.panel_titlebar.Controls.Add(this.label_year);
            this.panel_titlebar.Controls.Add(this.label_model);
            this.panel_titlebar.Controls.Add(this.label_vtype);
            this.panel_titlebar.Controls.Add(this.label_maker);
            this.panel_titlebar.Controls.Add(this.label_licenseplate);
            this.panel_titlebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_titlebar.Location = new System.Drawing.Point(313, 107);
            this.panel_titlebar.Name = "panel_titlebar";
            this.panel_titlebar.Size = new System.Drawing.Size(1591, 45);
            this.panel_titlebar.TabIndex = 5;
            // 
            // label_actions
            // 
            this.label_actions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_actions.AutoSize = true;
            this.label_actions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_actions.Location = new System.Drawing.Point(1379, 11);
            this.label_actions.Name = "label_actions";
            this.label_actions.Size = new System.Drawing.Size(65, 21);
            this.label_actions.TabIndex = 0;
            this.label_actions.Text = "Actions";
            // 
            // label_dailyprice
            // 
            this.label_dailyprice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_dailyprice.AutoSize = true;
            this.label_dailyprice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dailyprice.Location = new System.Drawing.Point(1119, 11);
            this.label_dailyprice.Name = "label_dailyprice";
            this.label_dailyprice.Size = new System.Drawing.Size(85, 21);
            this.label_dailyprice.TabIndex = 0;
            this.label_dailyprice.Text = "Daily Price";
            // 
            // label_year
            // 
            this.label_year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_year.Location = new System.Drawing.Point(957, 11);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(41, 21);
            this.label_year.TabIndex = 0;
            this.label_year.Text = "Year";
            // 
            // label_model
            // 
            this.label_model.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_model.Location = new System.Drawing.Point(742, 11);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(58, 21);
            this.label_model.TabIndex = 0;
            this.label_model.Text = "Model";
            // 
            // label_vtype
            // 
            this.label_vtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_vtype.AutoSize = true;
            this.label_vtype.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_vtype.Location = new System.Drawing.Point(329, 11);
            this.label_vtype.Name = "label_vtype";
            this.label_vtype.Size = new System.Drawing.Size(45, 21);
            this.label_vtype.TabIndex = 0;
            this.label_vtype.Text = "Type";
            // 
            // label_maker
            // 
            this.label_maker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_maker.AutoSize = true;
            this.label_maker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maker.Location = new System.Drawing.Point(509, 11);
            this.label_maker.Name = "label_maker";
            this.label_maker.Size = new System.Drawing.Size(56, 21);
            this.label_maker.TabIndex = 0;
            this.label_maker.Text = "Maker";
            // 
            // label_licenseplate
            // 
            this.label_licenseplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_licenseplate.AutoSize = true;
            this.label_licenseplate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_licenseplate.Location = new System.Drawing.Point(98, 11);
            this.label_licenseplate.Name = "label_licenseplate";
            this.label_licenseplate.Size = new System.Drawing.Size(104, 21);
            this.label_licenseplate.TabIndex = 0;
            this.label_licenseplate.Text = "License Plate";
            // 
            // flowpanel_list
            // 
            this.flowpanel_list.AutoScroll = true;
            this.flowpanel_list.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpanel_list.Location = new System.Drawing.Point(313, 171);
            this.flowpanel_list.Name = "flowpanel_list";
            this.flowpanel_list.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowpanel_list.Size = new System.Drawing.Size(1596, 838);
            this.flowpanel_list.TabIndex = 7;
            this.flowpanel_list.WrapContents = false;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.BindingContainer = this.flowpanel_list;
            this.guna2VScrollBar2.BorderRadius = 7;
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(1891, 171);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.ScrollbarSize = 18;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(18, 838);
            this.guna2VScrollBar2.TabIndex = 0;
            this.guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // panel_VehiclesPage_Description
            // 
            this.panel_VehiclesPage_Description.Controls.Add(this.label5);
            this.panel_VehiclesPage_Description.Controls.Add(this.label4);
            this.panel_VehiclesPage_Description.Controls.Add(this.label2);
            this.panel_VehiclesPage_Description.Controls.Add(this.label1);
            this.panel_VehiclesPage_Description.Location = new System.Drawing.Point(324, 1020);
            this.panel_VehiclesPage_Description.Name = "panel_VehiclesPage_Description";
            this.panel_VehiclesPage_Description.Size = new System.Drawing.Size(633, 42);
            this.panel_VehiclesPage_Description.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(479, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Maintenance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(330, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rented";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(164, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Reserved";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_search
            // 
            this.textBox_search.BorderRadius = 10;
            this.textBox_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_search.DefaultText = "";
            this.textBox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_search.Location = new System.Drawing.Point(1704, 65);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.PlaceholderText = "Search Licence Plate...";
            this.textBox_search.SelectedText = "";
            this.textBox_search.Size = new System.Drawing.Size(200, 36);
            this.textBox_search.TabIndex = 9;
            // 
            // comboBox_status
            // 
            this.comboBox_status.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_status.BorderRadius = 10;
            this.comboBox_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_status.ItemHeight = 30;
            this.comboBox_status.Items.AddRange(new object[] {
            "All",
            "Available",
            "Reserved",
            "Rented",
            "Maintenance"});
            this.comboBox_status.Location = new System.Drawing.Point(1525, 65);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(155, 36);
            this.comboBox_status.StartIndex = 0;
            this.comboBox_status.TabIndex = 10;
            this.comboBox_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_vehicleType
            // 
            this.comboBox_vehicleType.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_vehicleType.BorderRadius = 10;
            this.comboBox_vehicleType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_vehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_vehicleType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_vehicleType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_vehicleType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_vehicleType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_vehicleType.ItemHeight = 30;
            this.comboBox_vehicleType.Items.AddRange(new object[] {
            "All",
            "Car",
            "Motorcycle",
            "Bus",
            "Truck"});
            this.comboBox_vehicleType.Location = new System.Drawing.Point(1344, 65);
            this.comboBox_vehicleType.Name = "comboBox_vehicleType";
            this.comboBox_vehicleType.Size = new System.Drawing.Size(155, 36);
            this.comboBox_vehicleType.StartIndex = 0;
            this.comboBox_vehicleType.TabIndex = 10;
            this.comboBox_vehicleType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1242, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filter by :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1388, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1564, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Status";
            // 
            // VehiclesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_vehicleType);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.guna2VScrollBar2);
            this.Controls.Add(this.panel_VehiclesPage_Description);
            this.Controls.Add(this.flowpanel_list);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "VehiclesPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.VehiclesPage_Load);
            this.panel_titlebar.ResumeLayout(false);
            this.panel_titlebar.PerformLayout();
            this.panel_VehiclesPage_Description.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel label_mainbar_vehicle;
        private System.Windows.Forms.FlowLayoutPanel flow_panel;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_type;
        private Guna.UI2.WinForms.Guna2Button btn_add_vehicle;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label title_label;
        private Guna.UI2.WinForms.Guna2Panel panel_titlebar;
        private System.Windows.Forms.Label label_dailyprice;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_maker;
        private System.Windows.Forms.Label label_licenseplate;
        private System.Windows.Forms.Label label_actions;
        private System.Windows.Forms.FlowLayoutPanel flowpanel_list;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private System.Windows.Forms.Label label_vtype;
        private Guna.UI2.WinForms.Guna2Panel panel_VehiclesPage_Description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_search;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_status;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_vehicleType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
