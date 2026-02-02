namespace AutoRentalSystem
{
    partial class UC_AlterState_DateTimePicker
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
            this.panel_backgound = new Guna.UI2.WinForms.Guna2Panel();
            this.label_endDate = new System.Windows.Forms.Label();
            this.label_startDate = new System.Windows.Forms.Label();
            this.dateTimePicker_endDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePicker_startDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panel_backgound.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_backgound
            // 
            this.panel_backgound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_backgound.Controls.Add(this.label_endDate);
            this.panel_backgound.Controls.Add(this.label_startDate);
            this.panel_backgound.Controls.Add(this.dateTimePicker_endDate);
            this.panel_backgound.Controls.Add(this.dateTimePicker_startDate);
            this.panel_backgound.Location = new System.Drawing.Point(0, 0);
            this.panel_backgound.Name = "panel_backgound";
            this.panel_backgound.Size = new System.Drawing.Size(490, 57);
            this.panel_backgound.TabIndex = 0;
            // 
            // label_endDate
            // 
            this.label_endDate.AutoSize = true;
            this.label_endDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_endDate.ForeColor = System.Drawing.Color.Black;
            this.label_endDate.Location = new System.Drawing.Point(283, 0);
            this.label_endDate.Name = "label_endDate";
            this.label_endDate.Size = new System.Drawing.Size(90, 25);
            this.label_endDate.TabIndex = 1;
            this.label_endDate.Text = "End Date";
            // 
            // label_startDate
            // 
            this.label_startDate.AutoSize = true;
            this.label_startDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_startDate.ForeColor = System.Drawing.Color.Black;
            this.label_startDate.Location = new System.Drawing.Point(45, 0);
            this.label_startDate.Name = "label_startDate";
            this.label_startDate.Size = new System.Drawing.Size(99, 25);
            this.label_startDate.TabIndex = 1;
            this.label_startDate.Text = "Start Date";
            // 
            // dateTimePicker_endDate
            // 
            this.dateTimePicker_endDate.BorderRadius = 10;
            this.dateTimePicker_endDate.Checked = true;
            this.dateTimePicker_endDate.FillColor = System.Drawing.Color.White;
            this.dateTimePicker_endDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endDate.Location = new System.Drawing.Point(288, 26);
            this.dateTimePicker_endDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_endDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_endDate.Name = "dateTimePicker_endDate";
            this.dateTimePicker_endDate.Size = new System.Drawing.Size(160, 31);
            this.dateTimePicker_endDate.TabIndex = 0;
            this.dateTimePicker_endDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePicker_endDate.Value = new System.DateTime(2026, 2, 1, 23, 33, 55, 91);
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.BorderRadius = 10;
            this.dateTimePicker_startDate.Checked = true;
            this.dateTimePicker_startDate.FillColor = System.Drawing.Color.White;
            this.dateTimePicker_startDate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(50, 26);
            this.dateTimePicker_startDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_startDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(160, 31);
            this.dateTimePicker_startDate.TabIndex = 0;
            this.dateTimePicker_startDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePicker_startDate.Value = new System.DateTime(2026, 2, 1, 23, 33, 55, 91);
            // 
            // UC_AlterState_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel_backgound);
            this.Name = "UC_AlterState_DateTimePicker";
            this.Size = new System.Drawing.Size(500, 57);
            this.panel_backgound.ResumeLayout(false);
            this.panel_backgound.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_backgound;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_startDate;
        private System.Windows.Forms.Label label_endDate;
        private System.Windows.Forms.Label label_startDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker_endDate;
    }
}
