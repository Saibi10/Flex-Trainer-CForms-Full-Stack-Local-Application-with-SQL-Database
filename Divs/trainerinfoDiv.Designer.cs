namespace Flex_Trainer
{
    partial class trainerinfoDiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainerinfoDiv));
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.edit_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.edit_speclization = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.AutoRoundedCorners = true;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.login_button.BorderRadius = 19;
            this.login_button.BorderThickness = 1;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.Gray;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.login_button.HoverState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.login_button.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.login_button.HoverState.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(783, 6);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(109, 41);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "View";
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(41, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(26, 28);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // edit_name
            // 
            this.edit_name.AutoSize = false;
            this.edit_name.BackColor = System.Drawing.Color.Transparent;
            this.edit_name.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_name.ForeColor = System.Drawing.Color.White;
            this.edit_name.Location = new System.Drawing.Point(78, 14);
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(158, 33);
            this.edit_name.TabIndex = 16;
            this.edit_name.Text = "GYM Name";
            this.edit_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // edit_speclization
            // 
            this.edit_speclization.AutoSize = false;
            this.edit_speclization.BackColor = System.Drawing.Color.Transparent;
            this.edit_speclization.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_speclization.ForeColor = System.Drawing.Color.White;
            this.edit_speclization.Location = new System.Drawing.Point(359, 16);
            this.edit_speclization.Name = "edit_speclization";
            this.edit_speclization.Size = new System.Drawing.Size(319, 33);
            this.edit_speclization.TabIndex = 17;
            this.edit_speclization.Text = "GYM Name";
            this.edit_speclization.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trainerinfoDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.edit_speclization);
            this.Controls.Add(this.edit_name);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.login_button);
            this.Name = "trainerinfoDiv";
            this.Size = new System.Drawing.Size(910, 56);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel edit_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel edit_speclization;
    }
}
