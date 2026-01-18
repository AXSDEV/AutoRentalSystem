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
            this.SuspendLayout();
            // 
            // VehiclesPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "VehiclesPage";
            this.Load += new System.EventHandler(this.VehiclesPage_Load);
            this.ResumeLayout(false);

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
    }
}
