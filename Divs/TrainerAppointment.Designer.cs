namespace Flex_Trainer.Divs
{
    partial class TrainerAppointment
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
            this.detailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.memberNameLbl = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detailBtn
            // 
            this.detailBtn.AutoRoundedCorners = true;
            this.detailBtn.BorderRadius = 21;
            this.detailBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.detailBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.detailBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.detailBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.detailBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.detailBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailBtn.ForeColor = System.Drawing.Color.Black;
            this.detailBtn.Location = new System.Drawing.Point(807, 13);
            this.detailBtn.Name = "detailBtn";
            this.detailBtn.Size = new System.Drawing.Size(151, 45);
            this.detailBtn.TabIndex = 5;
            this.detailBtn.Text = "Details";
            this.detailBtn.Click += new System.EventHandler(this.detailBtn_Click);
            // 
            // memberNameLbl
            // 
            this.memberNameLbl.AutoSize = true;
            this.memberNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.memberNameLbl.Location = new System.Drawing.Point(396, 22);
            this.memberNameLbl.Name = "memberNameLbl";
            this.memberNameLbl.Size = new System.Drawing.Size(165, 27);
            this.memberNameLbl.TabIndex = 4;
            this.memberNameLbl.Text = "Member Name";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.dateLabel.Location = new System.Drawing.Point(22, 22);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(66, 27);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date:";
            // 
            // TrainerAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.detailBtn);
            this.Controls.Add(this.memberNameLbl);
            this.Controls.Add(this.dateLabel);
            this.Name = "TrainerAppointment";
            this.Size = new System.Drawing.Size(977, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button detailBtn;
        private System.Windows.Forms.Label memberNameLbl;
        private System.Windows.Forms.Label dateLabel;
    }
}
