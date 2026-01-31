namespace AutoRentalSystem
{
    partial class UC_VehicleDetails_Car
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_background = new Guna.UI2.WinForms.Guna2Panel();
            this.label_numberDoors_info = new System.Windows.Forms.Label();
            this.label_numberDoors = new System.Windows.Forms.Label();
            this.panel_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BackColor = System.Drawing.Color.Transparent;
            this.panel_background.Controls.Add(this.label_numberDoors_info);
            this.panel_background.Controls.Add(this.label_numberDoors);
            this.panel_background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.panel_background.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(700, 77);
            this.panel_background.TabIndex = 0;
            // 
            // label_numberDoors_info
            // 
            this.label_numberDoors_info.AutoSize = true;
            this.label_numberDoors_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_numberDoors_info.Location = new System.Drawing.Point(186, 14);
            this.label_numberDoors_info.Name = "label_numberDoors_info";
            this.label_numberDoors_info.Size = new System.Drawing.Size(61, 25);
            this.label_numberDoors_info.TabIndex = 0;
            this.label_numberDoors_info.Text = "label1";
            // 
            // label_numberDoors
            // 
            this.label_numberDoors.AutoSize = true;
            this.label_numberDoors.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_numberDoors.Location = new System.Drawing.Point(46, 14);
            this.label_numberDoors.Name = "label_numberDoors";
            this.label_numberDoors.Size = new System.Drawing.Size(124, 25);
            this.label_numberDoors.TabIndex = 0;
            this.label_numberDoors.Text = "Nº of Doors :";
            // 
            // UC_VehicleDetails_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_background);
            this.Name = "UC_VehicleDetails_Car";
            this.Size = new System.Drawing.Size(700, 77);
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_background;
        private System.Windows.Forms.Label label_numberDoors;
        private System.Windows.Forms.Label label_numberDoors_info;
    }
}
