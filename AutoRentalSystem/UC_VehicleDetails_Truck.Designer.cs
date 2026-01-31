namespace AutoRentalSystem
{
    partial class UC_VehicleDetails_Truck
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
            this.label_maxWeight = new System.Windows.Forms.Label();
            this.label_maxWeight_info = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_height_info = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.label_height_info);
            this.guna2Panel1.Controls.Add(this.label_maxWeight_info);
            this.guna2Panel1.Controls.Add(this.label_height);
            this.guna2Panel1.Controls.Add(this.label_maxWeight);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(34)))));
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(700, 77);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label_maxWeight
            // 
            this.label_maxWeight.AutoSize = true;
            this.label_maxWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_maxWeight.Location = new System.Drawing.Point(43, 14);
            this.label_maxWeight.Name = "label_maxWeight";
            this.label_maxWeight.Size = new System.Drawing.Size(127, 25);
            this.label_maxWeight.TabIndex = 0;
            this.label_maxWeight.Text = "Max Weight :";
            // 
            // label_maxWeight_info
            // 
            this.label_maxWeight_info.AutoSize = true;
            this.label_maxWeight_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_maxWeight_info.Location = new System.Drawing.Point(188, 14);
            this.label_maxWeight_info.Name = "label_maxWeight_info";
            this.label_maxWeight_info.Size = new System.Drawing.Size(61, 25);
            this.label_maxWeight_info.TabIndex = 0;
            this.label_maxWeight_info.Text = "label1";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_height.Location = new System.Drawing.Point(445, 14);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(80, 25);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Height :";
            // 
            // label_height_info
            // 
            this.label_height_info.AutoSize = true;
            this.label_height_info.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_height_info.Location = new System.Drawing.Point(545, 14);
            this.label_height_info.Name = "label_height_info";
            this.label_height_info.Size = new System.Drawing.Size(61, 25);
            this.label_height_info.TabIndex = 0;
            this.label_height_info.Text = "label1";
            // 
            // UC_VehicleDetails_Truck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_VehicleDetails_Truck";
            this.Size = new System.Drawing.Size(700, 77);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label_maxWeight;
        private System.Windows.Forms.Label label_maxWeight_info;
        private System.Windows.Forms.Label label_height_info;
        private System.Windows.Forms.Label label_height;
    }
}
