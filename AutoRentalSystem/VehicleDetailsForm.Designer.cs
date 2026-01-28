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
            this.panel_VehicleDetailsForm_Background = new Guna.UI2.WinForms.Guna2Panel();
            this.label_VehicleDetailsForm_Title = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_VehicleDetailsForm_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_VehicleDetailsForm_Background
            // 
            this.panel_VehicleDetailsForm_Background.BorderRadius = 40;
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.guna2Panel1);
            this.panel_VehicleDetailsForm_Background.Controls.Add(this.label_VehicleDetailsForm_Title);
            this.panel_VehicleDetailsForm_Background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_VehicleDetailsForm_Background.Location = new System.Drawing.Point(0, 0);
            this.panel_VehicleDetailsForm_Background.Name = "panel_VehicleDetailsForm_Background";
            this.panel_VehicleDetailsForm_Background.Size = new System.Drawing.Size(1200, 900);
            this.panel_VehicleDetailsForm_Background.TabIndex = 0;
            // 
            // label_VehicleDetailsForm_Title
            // 
            this.label_VehicleDetailsForm_Title.AutoSize = true;
            this.label_VehicleDetailsForm_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_VehicleDetailsForm_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 24.25F, System.Drawing.FontStyle.Bold);
            this.label_VehicleDetailsForm_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.label_VehicleDetailsForm_Title.Location = new System.Drawing.Point(489, 29);
            this.label_VehicleDetailsForm_Title.Name = "label_VehicleDetailsForm_Title";
            this.label_VehicleDetailsForm_Title.Size = new System.Drawing.Size(240, 45);
            this.label_VehicleDetailsForm_Title.TabIndex = 0;
            this.label_VehicleDetailsForm_Title.Text = "Vehicle Details";
            this.label_VehicleDetailsForm_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(100, 103);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1000, 350);
            this.guna2Panel1.TabIndex = 1;
            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1200, 900);
            this.ControlBox = false;
            this.Controls.Add(this.panel_VehicleDetailsForm_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleDetailsForm";
            this.Text = "VehicleDetailsForm";
            this.panel_VehicleDetailsForm_Background.ResumeLayout(false);
            this.panel_VehicleDetailsForm_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_VehicleDetailsForm_Background;
        private System.Windows.Forms.Label label_VehicleDetailsForm_Title;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}