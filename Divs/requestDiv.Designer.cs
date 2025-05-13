namespace Flex_Trainer
{
    partial class requestDiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestDiv));
            this.edit_owner_name = new System.Windows.Forms.Label();
            this.gym_name_lable = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.decline_button = new Guna.UI2.WinForms.Guna2Button();
            this.accept_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.edit_gym_name = new System.Windows.Forms.Label();
            this.edit_address = new System.Windows.Forms.Label();
            this.edit_phone_number = new System.Windows.Forms.Label();
            this.edit_price = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_owner_name
            // 
            this.edit_owner_name.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_owner_name.ForeColor = System.Drawing.Color.Transparent;
            this.edit_owner_name.Location = new System.Drawing.Point(67, 13);
            this.edit_owner_name.Name = "edit_owner_name";
            this.edit_owner_name.Size = new System.Drawing.Size(193, 29);
            this.edit_owner_name.TabIndex = 1;
            this.edit_owner_name.Text = "Name";
            this.edit_owner_name.Click += new System.EventHandler(this.owner_name_Click);
            // 
            // gym_name_lable
            // 
            this.gym_name_lable.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gym_name_lable.ForeColor = System.Drawing.Color.Transparent;
            this.gym_name_lable.Location = new System.Drawing.Point(14, 49);
            this.gym_name_lable.Name = "gym_name_lable";
            this.gym_name_lable.Size = new System.Drawing.Size(130, 23);
            this.gym_name_lable.TabIndex = 2;
            this.gym_name_lable.Text = "Gym Name :";
            this.gym_name_lable.Click += new System.EventHandler(this.label1_Click);
            // 
            // address_label
            // 
            this.address_label.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_label.ForeColor = System.Drawing.Color.Transparent;
            this.address_label.Location = new System.Drawing.Point(14, 81);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(110, 23);
            this.address_label.TabIndex = 3;
            this.address_label.Text = "Address     :";
            // 
            // phone_label
            // 
            this.phone_label.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_label.ForeColor = System.Drawing.Color.Transparent;
            this.phone_label.Location = new System.Drawing.Point(397, 48);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(100, 23);
            this.phone_label.TabIndex = 4;
            this.phone_label.Text = "Phone   :";
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.Transparent;
            this.price_label.Location = new System.Drawing.Point(397, 80);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(100, 23);
            this.price_label.TabIndex = 5;
            this.price_label.Text = "Price     :";
            // 
            // decline_button
            // 
            this.decline_button.BorderRadius = 10;
            this.decline_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.decline_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.decline_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.decline_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.decline_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.decline_button.FillColor = System.Drawing.Color.LightCoral;
            this.decline_button.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decline_button.ForeColor = System.Drawing.Color.Black;
            this.decline_button.Location = new System.Drawing.Point(200, 115);
            this.decline_button.Name = "decline_button";
            this.decline_button.Size = new System.Drawing.Size(105, 31);
            this.decline_button.TabIndex = 6;
            this.decline_button.Text = "Decline";
            this.decline_button.Click += new System.EventHandler(this.decline_button_Click);
            // 
            // accept_button
            // 
            this.accept_button.BorderRadius = 10;
            this.accept_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.accept_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accept_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accept_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accept_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accept_button.FillColor = System.Drawing.Color.LightGreen;
            this.accept_button.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.accept_button.Location = new System.Drawing.Point(342, 115);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(105, 31);
            this.accept_button.TabIndex = 7;
            this.accept_button.Text = "Accept";
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(16, 10);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(38, 36);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 8;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // edit_gym_name
            // 
            this.edit_gym_name.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_gym_name.ForeColor = System.Drawing.Color.Transparent;
            this.edit_gym_name.Location = new System.Drawing.Point(120, 49);
            this.edit_gym_name.Name = "edit_gym_name";
            this.edit_gym_name.Size = new System.Drawing.Size(206, 23);
            this.edit_gym_name.TabIndex = 9;
            this.edit_gym_name.Text = "name";
            // 
            // edit_address
            // 
            this.edit_address.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_address.ForeColor = System.Drawing.Color.Transparent;
            this.edit_address.Location = new System.Drawing.Point(121, 81);
            this.edit_address.Name = "edit_address";
            this.edit_address.Size = new System.Drawing.Size(205, 23);
            this.edit_address.TabIndex = 10;
            this.edit_address.Text = "name";
            // 
            // edit_phone_number
            // 
            this.edit_phone_number.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_phone_number.ForeColor = System.Drawing.Color.Transparent;
            this.edit_phone_number.Location = new System.Drawing.Point(492, 48);
            this.edit_phone_number.Name = "edit_phone_number";
            this.edit_phone_number.Size = new System.Drawing.Size(148, 23);
            this.edit_phone_number.TabIndex = 11;
            this.edit_phone_number.Text = "name";
            // 
            // edit_price
            // 
            this.edit_price.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_price.ForeColor = System.Drawing.Color.Transparent;
            this.edit_price.Location = new System.Drawing.Point(492, 80);
            this.edit_price.Name = "edit_price";
            this.edit_price.Size = new System.Drawing.Size(148, 23);
            this.edit_price.TabIndex = 12;
            this.edit_price.Text = "name";
            // 
            // requestDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.edit_price);
            this.Controls.Add(this.edit_phone_number);
            this.Controls.Add(this.edit_address);
            this.Controls.Add(this.edit_gym_name);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.decline_button);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.gym_name_lable);
            this.Controls.Add(this.edit_owner_name);
            this.Name = "requestDiv";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(694, 155);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label edit_owner_name;
        private System.Windows.Forms.Label gym_name_lable;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label price_label;
        private Guna.UI2.WinForms.Guna2Button decline_button;
        private Guna.UI2.WinForms.Guna2Button accept_button;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label edit_gym_name;
        private System.Windows.Forms.Label edit_address;
        private System.Windows.Forms.Label edit_phone_number;
        private System.Windows.Forms.Label edit_price;
    }
}
