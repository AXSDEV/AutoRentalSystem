namespace AutoRentalSystem
{
    partial class UC_VehicleCards_ReservationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VehicleCards_ReservationPage));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_edit_reservation = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete_reservation = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.btn_edit_reservation);
            this.guna2Panel1.Controls.Add(this.btn_delete_reservation);
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 45);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btn_edit_reservation
            // 
            this.btn_edit_reservation.BorderColor = System.Drawing.Color.White;
            this.btn_edit_reservation.BorderRadius = 5;
            this.btn_edit_reservation.BorderThickness = 1;
            this.btn_edit_reservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_reservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_reservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit_reservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit_reservation.FillColor = System.Drawing.Color.Transparent;
            this.btn_edit_reservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_edit_reservation.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit_reservation.Image")));
            this.btn_edit_reservation.ImageOffset = new System.Drawing.Point(0, 12);
            this.btn_edit_reservation.Location = new System.Drawing.Point(76, 10);
            this.btn_edit_reservation.Name = "btn_edit_reservation";
            this.btn_edit_reservation.PressedColor = System.Drawing.Color.Yellow;
            this.btn_edit_reservation.Size = new System.Drawing.Size(24, 24);
            this.btn_edit_reservation.TabIndex = 0;
            this.btn_edit_reservation.Text = "guna2Button1";
            // 
            // btn_delete_reservation
            // 
            this.btn_delete_reservation.BorderColor = System.Drawing.Color.White;
            this.btn_delete_reservation.BorderRadius = 5;
            this.btn_delete_reservation.BorderThickness = 1;
            this.btn_delete_reservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_reservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_reservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_reservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_reservation.FillColor = System.Drawing.Color.Transparent;
            this.btn_delete_reservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete_reservation.ForeColor = System.Drawing.Color.White;
            this.btn_delete_reservation.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_reservation.Image")));
            this.btn_delete_reservation.ImageOffset = new System.Drawing.Point(0, 12);
            this.btn_delete_reservation.Location = new System.Drawing.Point(115, 10);
            this.btn_delete_reservation.Name = "btn_delete_reservation";
            this.btn_delete_reservation.PressedColor = System.Drawing.Color.Red;
            this.btn_delete_reservation.Size = new System.Drawing.Size(24, 24);
            this.btn_delete_reservation.TabIndex = 0;
            this.btn_delete_reservation.Text = "guna2Button1";
            // 
            // UC_VehicleCards_ReservationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_VehicleCards_ReservationPage";
            this.Size = new System.Drawing.Size(200, 45);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_delete_reservation;
        private Guna.UI2.WinForms.Guna2Button btn_edit_reservation;
    }
}
