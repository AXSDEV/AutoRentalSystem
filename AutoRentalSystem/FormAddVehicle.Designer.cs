namespace AutoRentalSystem
{
    partial class FormAddVehicle
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
            this.panel_AddVehicle_Background = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel_AddVehicle_Background
            // 
            this.panel_AddVehicle_Background.Location = new System.Drawing.Point(0, 0);
            this.panel_AddVehicle_Background.Name = "panel_AddVehicle_Background";
            this.panel_AddVehicle_Background.Size = new System.Drawing.Size(800, 600);
            this.panel_AddVehicle_Background.TabIndex = 0;
            // 
            // FormAddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel_AddVehicle_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddVehicle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddVehicle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_AddVehicle_Background;
    }
}