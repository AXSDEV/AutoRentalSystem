namespace AutoRentalSystem
{
    partial class UC_VehicleDetails_Bus
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label_maxPassenger = new System.Windows.Forms.Label();
            this.label_maxPassenger_info = new System.Windows.Forms.Label();
            this.label_axelNumber = new System.Windows.Forms.Label();
            this.label_axelNumber_info = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.label_axelNumber_info);
            this.guna2Panel1.Controls.Add(this.label_axelNumber);
            this.guna2Panel1.Controls.Add(this.label_maxPassenger_info);
            this.guna2Panel1.Controls.Add(this.label_maxPassenger);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(700, 77);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label_maxPassenger
            // 
            this.label_maxPassenger.AutoSize = true;
            this.label_maxPassenger.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_maxPassenger.Location = new System.Drawing.Point(20, 14);
            this.label_maxPassenger.Name = "label_maxPassenger";
            this.label_maxPassenger.Size = new System.Drawing.Size(150, 25);
            this.label_maxPassenger.TabIndex = 0;
            this.label_maxPassenger.Text = "Max Passenger :";
            // 
            // label_maxPassenger_info
            // 
            this.label_maxPassenger_info.AutoSize = true;
            this.label_maxPassenger_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_maxPassenger_info.Location = new System.Drawing.Point(188, 14);
            this.label_maxPassenger_info.Name = "label_maxPassenger_info";
            this.label_maxPassenger_info.Size = new System.Drawing.Size(61, 25);
            this.label_maxPassenger_info.TabIndex = 0;
            this.label_maxPassenger_info.Text = "label1";
            // 
            // label_axelNumber
            // 
            this.label_axelNumber.AutoSize = true;
            this.label_axelNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_axelNumber.Location = new System.Drawing.Point(390, 14);
            this.label_axelNumber.Name = "label_axelNumber";
            this.label_axelNumber.Size = new System.Drawing.Size(136, 25);
            this.label_axelNumber.TabIndex = 0;
            this.label_axelNumber.Text = "Axel Number :";
            // 
            // label_axelNumber_info
            // 
            this.label_axelNumber_info.AutoSize = true;
            this.label_axelNumber_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_axelNumber_info.Location = new System.Drawing.Point(545, 14);
            this.label_axelNumber_info.Name = "label_axelNumber_info";
            this.label_axelNumber_info.Size = new System.Drawing.Size(61, 25);
            this.label_axelNumber_info.TabIndex = 0;
            this.label_axelNumber_info.Text = "label1";
            // 
            // UC_VehicleDetails_Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_VehicleDetails_Bus";
            this.Size = new System.Drawing.Size(700, 77);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_maxPassenger;
        private System.Windows.Forms.Label label_maxPassenger_info;
        private System.Windows.Forms.Label label_axelNumber_info;
        private System.Windows.Forms.Label label_axelNumber;
    }
}
