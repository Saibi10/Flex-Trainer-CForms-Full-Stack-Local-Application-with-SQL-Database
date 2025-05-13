namespace Flex_Trainer.Divs
{
    partial class SubscribedMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubscribedMember));
            this.kickMemberBtn = new Guna.UI2.WinForms.Guna2Button();
            this.memberNameLbl = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kickMemberBtn
            // 
            this.kickMemberBtn.AutoRoundedCorners = true;
            this.kickMemberBtn.BorderRadius = 19;
            this.kickMemberBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.kickMemberBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.kickMemberBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.kickMemberBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.kickMemberBtn.FillColor = System.Drawing.Color.Red;
            this.kickMemberBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.kickMemberBtn.ForeColor = System.Drawing.Color.White;
            this.kickMemberBtn.Location = new System.Drawing.Point(629, 19);
            this.kickMemberBtn.Margin = new System.Windows.Forms.Padding(2);
            this.kickMemberBtn.Name = "kickMemberBtn";
            this.kickMemberBtn.Size = new System.Drawing.Size(93, 40);
            this.kickMemberBtn.TabIndex = 6;
            this.kickMemberBtn.Text = "Kick";
            this.kickMemberBtn.Click += new System.EventHandler(this.kickMemberBtn_Click);
            // 
            // memberNameLbl
            // 
            this.memberNameLbl.AutoSize = true;
            this.memberNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.memberNameLbl.Location = new System.Drawing.Point(76, 26);
            this.memberNameLbl.Name = "memberNameLbl";
            this.memberNameLbl.Size = new System.Drawing.Size(131, 22);
            this.memberNameLbl.TabIndex = 7;
            this.memberNameLbl.Text = "Member Name";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(21, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(31, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.phoneLbl.Location = new System.Drawing.Point(276, 27);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(120, 22);
            this.phoneLbl.TabIndex = 11;
            this.phoneLbl.Text = "03015202466";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.genderLbl.Location = new System.Drawing.Point(452, 26);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(68, 22);
            this.genderLbl.TabIndex = 12;
            this.genderLbl.Text = "Gender";
            // 
            // SubscribedMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.memberNameLbl);
            this.Controls.Add(this.kickMemberBtn);
            this.Name = "SubscribedMember";
            this.Size = new System.Drawing.Size(741, 80);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button kickMemberBtn;
        private System.Windows.Forms.Label memberNameLbl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label genderLbl;
    }
}
