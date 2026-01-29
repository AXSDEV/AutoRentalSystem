namespace AutoRentalSystem
{
    partial class MaintenancePage
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
            this.panel_titleBar = new Guna.UI2.WinForms.Guna2Panel();
            this.label_licensePlate = new System.Windows.Forms.Label();
            this.panel_titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(282, 570);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panel_titleBar
            // 
            this.panel_titleBar.BorderRadius = 10;
            this.panel_titleBar.Controls.Add(this.label_licensePlate);
            this.panel_titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_titleBar.Location = new System.Drawing.Point(313, 107);
            this.panel_titleBar.Name = "panel_titleBar";
            this.panel_titleBar.Size = new System.Drawing.Size(1591, 45);
            this.panel_titleBar.TabIndex = 1;
            // 
            // label_licensePlate
            // 
            this.label_licensePlate.AutoSize = true;
            this.label_licensePlate.BackColor = System.Drawing.Color.Transparent;
            this.label_licensePlate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label_licensePlate.Location = new System.Drawing.Point(98, 11);
            this.label_licensePlate.Name = "label_licensePlate";
            this.label_licensePlate.Size = new System.Drawing.Size(104, 21);
            this.label_licensePlate.TabIndex = 0;
            this.label_licensePlate.Text = "License Plate";
            // 
            // MaintenancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_titleBar);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "MaintenancePage";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.MaintenancePage_Load);
            this.panel_titleBar.ResumeLayout(false);
            this.panel_titleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panel_titleBar;
        private System.Windows.Forms.Label label_licensePlate;
    }
}
