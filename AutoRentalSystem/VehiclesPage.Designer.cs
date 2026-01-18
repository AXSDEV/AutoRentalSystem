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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.panel_titlebar.SuspendLayout();
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
            this.panel_titlebar.Size = new System.Drawing.Size(1095, 45);
            this.panel_titlebar.TabIndex = 5;
            // 
            // label_actions
            // 
            this.label_actions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_actions.AutoSize = true;
            this.label_actions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_actions.Location = new System.Drawing.Point(947, 11);
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
            this.label_dailyprice.Location = new System.Drawing.Point(760, 11);
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
            this.label_year.Location = new System.Drawing.Point(656, 11);
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
            this.label_model.Location = new System.Drawing.Point(516, 11);
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
            this.label_vtype.Location = new System.Drawing.Point(249, 11);
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
            this.label_maker.Location = new System.Drawing.Point(377, 11);
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
            this.label_licenseplate.Location = new System.Drawing.Point(67, 11);
            this.label_licenseplate.Name = "label_licenseplate";
            this.label_licenseplate.Size = new System.Drawing.Size(104, 21);
            this.label_licenseplate.TabIndex = 0;
            this.label_licenseplate.Text = "License Plate";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(313, 171);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1100, 469);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.BindingContainer = this.flowLayoutPanel1;
            this.guna2VScrollBar2.BorderRadius = 7;
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(1399, 171);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.ScrollbarSize = 14;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(14, 469);
            this.guna2VScrollBar2.TabIndex = 0;
            this.guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // VehiclesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2VScrollBar2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_titlebar);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "VehiclesPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1424, 643);
            this.Load += new System.EventHandler(this.VehiclesPage_Load);
            this.panel_titlebar.ResumeLayout(false);
            this.panel_titlebar.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
        private System.Windows.Forms.Label label_vtype;
    }
}
