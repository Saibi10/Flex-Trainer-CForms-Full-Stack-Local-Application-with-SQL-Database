namespace Flex_Trainer.Divs
{
    partial class feedbackdiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(feedbackdiv));
            this.feedback_detail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.member_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_time = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // feedback_detail
            // 
            this.feedback_detail.AutoSize = false;
            this.feedback_detail.BackColor = System.Drawing.Color.Transparent;
            this.feedback_detail.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedback_detail.ForeColor = System.Drawing.Color.Transparent;
            this.feedback_detail.Location = new System.Drawing.Point(51, 34);
            this.feedback_detail.Name = "feedback_detail";
            this.feedback_detail.Size = new System.Drawing.Size(614, 23);
            this.feedback_detail.TabIndex = 0;
            this.feedback_detail.Text = "guna2HtmlLabel1";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(28, 28);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // member_name
            // 
            this.member_name.AutoSize = false;
            this.member_name.BackColor = System.Drawing.Color.Transparent;
            this.member_name.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_name.ForeColor = System.Drawing.Color.White;
            this.member_name.Location = new System.Drawing.Point(51, 4);
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(158, 33);
            this.member_name.TabIndex = 17;
            this.member_name.Text = "GYM Name";
            this.member_name.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_time
            // 
            this.date_time.AutoSize = false;
            this.date_time.BackColor = System.Drawing.Color.Transparent;
            this.date_time.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.ForeColor = System.Drawing.Color.White;
            this.date_time.Location = new System.Drawing.Point(700, 16);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(158, 33);
            this.date_time.TabIndex = 18;
            this.date_time.Text = "GYM Name";
            this.date_time.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // feedbackdiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.member_name);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.feedback_detail);
            this.Name = "feedbackdiv";
            this.Size = new System.Drawing.Size(865, 64);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel feedback_detail;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel member_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel date_time;
    }
}
