namespace AutoRentalSystem
{
    partial class AlterStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterStateForm));
            this.panel_background = new Guna.UI2.WinForms.Guna2Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.comboBox_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_alterState = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.panel_background.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_background
            // 
            this.panel_background.BorderRadius = 30;
            this.panel_background.Controls.Add(this.btn_close);
            this.panel_background.Controls.Add(this.btn_alterState);
            this.panel_background.Controls.Add(this.comboBox_status);
            this.panel_background.Controls.Add(this.label_status);
            this.panel_background.Controls.Add(this.label_title);
            this.panel_background.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_background.Location = new System.Drawing.Point(0, 0);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(500, 270);
            this.panel_background.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(173, 23);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(145, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Alter State";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.Color.Transparent;
            this.label_status.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_status.Location = new System.Drawing.Point(45, 84);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(64, 25);
            this.label_status.TabIndex = 0;
            this.label_status.Text = "Status";
            // 
            // comboBox_status
            // 
            this.comboBox_status.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_status.BorderRadius = 10;
            this.comboBox_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_status.ItemHeight = 30;
            this.comboBox_status.Location = new System.Drawing.Point(50, 112);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(400, 36);
            this.comboBox_status.TabIndex = 1;
            // 
            // btn_alterState
            // 
            this.btn_alterState.BackColor = System.Drawing.Color.Transparent;
            this.btn_alterState.BorderRadius = 10;
            this.btn_alterState.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_alterState.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_alterState.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_alterState.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_alterState.FillColor = System.Drawing.Color.White;
            this.btn_alterState.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterState.ForeColor = System.Drawing.Color.Black;
            this.btn_alterState.Location = new System.Drawing.Point(151, 187);
            this.btn_alterState.Name = "btn_alterState";
            this.btn_alterState.Size = new System.Drawing.Size(180, 45);
            this.btn_alterState.TabIndex = 2;
            this.btn_alterState.Text = "Change";
            this.btn_alterState.Click += new System.EventHandler(this.btn_alterState_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BorderColor = System.Drawing.Color.White;
            this.btn_close.BorderRadius = 10;
            this.btn_close.BorderThickness = 1;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.Color.Transparent;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageOffset = new System.Drawing.Point(1, 0);
            this.btn_close.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_close.Location = new System.Drawing.Point(448, 13);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(35, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // AlterStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.panel_background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlterStateForm";
            this.Text = "AlterStateForm";
            this.panel_background.ResumeLayout(false);
            this.panel_background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel_background;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_status;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_title;
        private Guna.UI2.WinForms.Guna2Button btn_alterState;
        private Guna.UI2.WinForms.Guna2Button btn_close;
    }
}