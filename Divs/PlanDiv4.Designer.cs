namespace Flex_Trainer.Divs
{
    partial class PlanDiv4
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
            this.creatorNameLbl = new System.Windows.Forms.Label();
            this.planNameLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.planDetailBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // creatorNameLbl
            // 
            this.creatorNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatorNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.creatorNameLbl.Location = new System.Drawing.Point(389, 15);
            this.creatorNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.creatorNameLbl.Name = "creatorNameLbl";
            this.creatorNameLbl.Size = new System.Drawing.Size(147, 45);
            this.creatorNameLbl.TabIndex = 12;
            this.creatorNameLbl.Text = "Creator Name";
            this.creatorNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // planNameLbl
            // 
            this.planNameLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.planNameLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.planNameLbl.Location = new System.Drawing.Point(149, 18);
            this.planNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.planNameLbl.Name = "planNameLbl";
            this.planNameLbl.Size = new System.Drawing.Size(147, 40);
            this.planNameLbl.TabIndex = 11;
            this.planNameLbl.Text = "Plan Name";
            this.planNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.BackColor = System.Drawing.Color.Transparent;
            this.idLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.idLbl.Location = new System.Drawing.Point(35, 26);
            this.idLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(28, 21);
            this.idLbl.TabIndex = 10;
            this.idLbl.Text = "15";
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
            this.planDetailBtn.Location = new System.Drawing.Point(698, 20);
            this.planDetailBtn.Margin = new System.Windows.Forms.Padding(2);
            this.planDetailBtn.Name = "planDetailBtn";
            this.planDetailBtn.Size = new System.Drawing.Size(93, 40);
            this.planDetailBtn.TabIndex = 9;
            this.planDetailBtn.Text = "Details";
            this.planDetailBtn.Click += new System.EventHandler(this.planDetailBtn_Click);
            // 
            // PlanDiv4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.Controls.Add(this.creatorNameLbl);
            this.Controls.Add(this.planNameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.planDetailBtn);
            this.Name = "PlanDiv4";
            this.Size = new System.Drawing.Size(844, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label creatorNameLbl;
        private System.Windows.Forms.Label planNameLbl;
        private System.Windows.Forms.Label idLbl;
        private Guna.UI2.WinForms.Guna2Button planDetailBtn;
    }
}
