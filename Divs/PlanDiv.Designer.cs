namespace Flex_Trainer.Divs
{
    partial class PlanDiv
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

        private void InitializeComponent()
        {
            this.creatorNameLbl = new System.Windows.Forms.Label();
            this.planNameLbl = new System.Windows.Forms.Label();
            this.planDetailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.subscribeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creatorNameLbl
            // 
            this.creatorNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.creatorNameLbl.Location = new System.Drawing.Point(384, 11);
            this.creatorNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creatorNameLbl.Name = "creatorNameLbl";
            this.creatorNameLbl.Size = new System.Drawing.Size(147, 45);
            this.creatorNameLbl.TabIndex = 7;
            this.creatorNameLbl.Text = "Creator Name";
            this.creatorNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // planNameLbl
            // 
            this.planNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.planNameLbl.Location = new System.Drawing.Point(144, 14);
            this.planNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.planNameLbl.Name = "planNameLbl";
            this.planNameLbl.Size = new System.Drawing.Size(147, 40);
            this.planNameLbl.TabIndex = 6;
            this.planNameLbl.Text = "Plan Name";
            this.planNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // planDetailBtn
            // 
            this.planDetailBtn.AutoRoundedCorners = true;
            this.planDetailBtn.BorderRadius = 19;
            this.planDetailBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.planDetailBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.planDetailBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.planDetailBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.planDetailBtn.FillColor = System.Drawing.Color.DarkGray;
            this.planDetailBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.planDetailBtn.ForeColor = System.Drawing.Color.White;
            this.planDetailBtn.Location = new System.Drawing.Point(596, 14);
            this.planDetailBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.planDetailBtn.Name = "planDetailBtn";
            this.planDetailBtn.Size = new System.Drawing.Size(93, 40);
            this.planDetailBtn.TabIndex = 4;
            this.planDetailBtn.Text = "Details";
            this.planDetailBtn.Click += new System.EventHandler(this.planDetailBtn_Click);
            // 
            // subscribeBtn
            // 
            this.subscribeBtn.AutoRoundedCorners = true;
            this.subscribeBtn.BorderRadius = 19;
            this.subscribeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.subscribeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.subscribeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.subscribeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.subscribeBtn.FillColor = System.Drawing.Color.DarkGray;
            this.subscribeBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold);
            this.subscribeBtn.ForeColor = System.Drawing.Color.Black;
            this.subscribeBtn.Location = new System.Drawing.Point(694, 14);
            this.subscribeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subscribeBtn.Name = "subscribeBtn";
            this.subscribeBtn.Size = new System.Drawing.Size(110, 40);
            this.subscribeBtn.TabIndex = 8;
            this.subscribeBtn.Text = "Subscribe";
            this.subscribeBtn.Click += new System.EventHandler(this.subscribeBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.BackColor = System.Drawing.Color.Transparent;
            this.idLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idLbl.Location = new System.Drawing.Point(30, 22);
            this.idLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(28, 21);
            this.idLbl.TabIndex = 5;
            this.idLbl.Text = "15";
            // 
            // PlanDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.subscribeBtn);
            this.Controls.Add(this.creatorNameLbl);
            this.Controls.Add(this.planNameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.planDetailBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlanDiv";
            this.Size = new System.Drawing.Size(819, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creatorNameLbl;
        private System.Windows.Forms.Label planNameLbl;
        private Guna.UI2.WinForms.Guna2Button planDetailBtn;
        private Guna.UI2.WinForms.Guna2Button subscribeBtn;
        private System.Windows.Forms.Label idLbl;
    }
}

