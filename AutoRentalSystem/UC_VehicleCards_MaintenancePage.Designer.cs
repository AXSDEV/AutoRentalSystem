namespace AutoRentalSystem
{
    partial class UC_VehicleCards_MaintenancePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_VehicleCards_MaintenancePage));
            this.panel_actions = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_alterState = new Guna.UI2.WinForms.Guna2Button();
            this.panel_actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_actions
            // 
            this.panel_actions.Controls.Add(this.btn_alterState);
            this.panel_actions.Location = new System.Drawing.Point(0, 0);
            this.panel_actions.Name = "panel_actions";
            this.panel_actions.Size = new System.Drawing.Size(200, 45);
            this.panel_actions.TabIndex = 0;
            // 
            // btn_alterState
            // 
            this.btn_alterState.BorderColor = System.Drawing.Color.White;
            this.btn_alterState.BorderRadius = 5;
            this.btn_alterState.BorderThickness = 1;
            this.btn_alterState.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_alterState.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_alterState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_alterState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_alterState.FillColor = System.Drawing.Color.Transparent;
            this.btn_alterState.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_alterState.ForeColor = System.Drawing.Color.White;
            this.btn_alterState.Image = ((System.Drawing.Image)(resources.GetObject("btn_alterState.Image")));
            this.btn_alterState.ImageOffset = new System.Drawing.Point(0, 12);
            this.btn_alterState.Location = new System.Drawing.Point(91, 10);
            this.btn_alterState.Name = "btn_alterState";
            this.btn_alterState.Size = new System.Drawing.Size(24, 24);
            this.btn_alterState.TabIndex = 0;
            this.btn_alterState.Text = "btn_alterState";
            this.btn_alterState.MouseEnter += new System.EventHandler(this.btn_alterState_MouseEnter);
            this.btn_alterState.MouseLeave += new System.EventHandler(this.btn_alterState_MouseLeave);
            // 
            // UC_VehicleCards_MaintenancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_actions);
            this.Name = "UC_VehicleCards_MaintenancePage";
            this.Size = new System.Drawing.Size(200, 45);
            this.panel_actions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_actions;
        private Guna.UI2.WinForms.Guna2Button btn_alterState;
    }
}
