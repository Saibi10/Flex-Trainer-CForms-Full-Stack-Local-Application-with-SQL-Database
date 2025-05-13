using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flex_Trainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.main_control_tab = new Guna.UI2.WinForms.Guna2TabControl();
            this.login_tab = new System.Windows.Forms.TabPage();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.error_label_tab1 = new System.Windows.Forms.Label();
            this.password_text_tab1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_text_tab1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.register_tab = new System.Windows.Forms.TabPage();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox7 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lastname_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.firstname_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.error_message_tab2 = new System.Windows.Forms.Label();
            this.contact_info_txt_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.gender_combobox_tab2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.signin_btn_tab1 = new Guna.UI2.WinForms.Guna2Button();
            this.signup_btn_tab2 = new Guna.UI2.WinForms.Guna2Button();
            this.confirm_password_text_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_text_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_text_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_text_tab2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.main_control_tab.SuspendLayout();
            this.login_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.register_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.AutoRoundedCorners = true;
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.login_button.BorderRadius = 21;
            this.login_button.BorderThickness = 1;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.login_button.HoverState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.login_button.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.login_button.HoverState.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(777, 380);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(120, 45);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Login";
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(907, 380);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(120, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Register";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // main_control_tab
            // 
            this.main_control_tab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.main_control_tab.Controls.Add(this.login_tab);
            this.main_control_tab.Controls.Add(this.register_tab);
            this.main_control_tab.ItemSize = new System.Drawing.Size(180, 40);
            this.main_control_tab.Location = new System.Drawing.Point(-180, 0);
            this.main_control_tab.Name = "main_control_tab";
            this.main_control_tab.SelectedIndex = 0;
            this.main_control_tab.Size = new System.Drawing.Size(1817, 664);
            this.main_control_tab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.main_control_tab.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.main_control_tab.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.main_control_tab.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.main_control_tab.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.main_control_tab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.main_control_tab.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.main_control_tab.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.main_control_tab.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.main_control_tab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.main_control_tab.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.main_control_tab.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.main_control_tab.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.main_control_tab.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.main_control_tab.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.main_control_tab.TabButtonSize = new System.Drawing.Size(180, 40);
            this.main_control_tab.TabIndex = 0;
            this.main_control_tab.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            // 
            // login_tab
            // 
            this.login_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.login_tab.Controls.Add(this.guna2HtmlLabel2);
            this.login_tab.Controls.Add(this.guna2PictureBox2);
            this.login_tab.Controls.Add(this.guna2PictureBox1);
            this.login_tab.Controls.Add(this.error_label_tab1);
            this.login_tab.Controls.Add(this.password_text_tab1);
            this.login_tab.Controls.Add(this.username_text_tab1);
            this.login_tab.Controls.Add(this.login_button);
            this.login_tab.Controls.Add(this.guna2Button1);
            this.login_tab.Controls.Add(this.guna2PictureBox3);
            this.login_tab.ForeColor = System.Drawing.SystemColors.Control;
            this.login_tab.Location = new System.Drawing.Point(184, 4);
            this.login_tab.Name = "login_tab";
            this.login_tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.login_tab.Size = new System.Drawing.Size(1629, 656);
            this.login_tab.TabIndex = 0;
            this.login_tab.Text = "login";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(837, 132);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(152, 73);
            this.guna2HtmlLabel2.TabIndex = 11;
            this.guna2HtmlLabel2.Text = "Sign in";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(111, 72);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(433, 427);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 12;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(681, -13);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(8, 682);
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            // 
            // error_label_tab1
            // 
            this.error_label_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.error_label_tab1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label_tab1.ForeColor = System.Drawing.Color.Red;
            this.error_label_tab1.Location = new System.Drawing.Point(782, 347);
            this.error_label_tab1.Name = "error_label_tab1";
            this.error_label_tab1.Size = new System.Drawing.Size(231, 23);
            this.error_label_tab1.TabIndex = 19;
            this.error_label_tab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_text_tab1
            // 
            this.password_text_tab1.AutoRoundedCorners = true;
            this.password_text_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.password_text_tab1.BorderColor = System.Drawing.Color.White;
            this.password_text_tab1.BorderRadius = 21;
            this.password_text_tab1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.password_text_tab1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_text_tab1.DefaultText = "";
            this.password_text_tab1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_text_tab1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_text_tab1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_text_tab1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_text_tab1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_text_tab1.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this.password_text_tab1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_text_tab1.Location = new System.Drawing.Point(774, 298);
            this.password_text_tab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_text_tab1.Name = "password_text_tab1";
            this.password_text_tab1.PasswordChar = '●';
            this.password_text_tab1.PlaceholderText = "Password";
            this.password_text_tab1.SelectedText = "";
            this.password_text_tab1.Size = new System.Drawing.Size(255, 45);
            this.password_text_tab1.TabIndex = 12;
            this.password_text_tab1.UseSystemPasswordChar = true;
            // 
            // username_text_tab1
            // 
            this.username_text_tab1.AutoRoundedCorners = true;
            this.username_text_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.username_text_tab1.BorderColor = System.Drawing.Color.White;
            this.username_text_tab1.BorderRadius = 21;
            this.username_text_tab1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.username_text_tab1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_text_tab1.DefaultText = "";
            this.username_text_tab1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_text_tab1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_text_tab1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_text_tab1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_text_tab1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_text_tab1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.username_text_tab1.ForeColor = System.Drawing.Color.Navy;
            this.username_text_tab1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_text_tab1.Location = new System.Drawing.Point(774, 212);
            this.username_text_tab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_text_tab1.Name = "username_text_tab1";
            this.username_text_tab1.PasswordChar = '\0';
            this.username_text_tab1.PlaceholderText = "Username";
            this.username_text_tab1.SelectedText = "";
            this.username_text_tab1.Size = new System.Drawing.Size(255, 45);
            this.username_text_tab1.TabIndex = 10;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.guna2PictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(690, -15);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(548, 761);
            this.guna2PictureBox3.TabIndex = 23;
            this.guna2PictureBox3.TabStop = false;
            // 
            // register_tab
            // 
            this.register_tab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.register_tab.Controls.Add(this.guna2PictureBox4);
            this.register_tab.Controls.Add(this.guna2PictureBox7);
            this.register_tab.Controls.Add(this.lastname_tab2);
            this.register_tab.Controls.Add(this.firstname_tab2);
            this.register_tab.Controls.Add(this.error_message_tab2);
            this.register_tab.Controls.Add(this.contact_info_txt_tab2);
            this.register_tab.Controls.Add(this.gender_combobox_tab2);
            this.register_tab.Controls.Add(this.signin_btn_tab1);
            this.register_tab.Controls.Add(this.signup_btn_tab2);
            this.register_tab.Controls.Add(this.confirm_password_text_tab2);
            this.register_tab.Controls.Add(this.password_text_tab2);
            this.register_tab.Controls.Add(this.email_text_tab2);
            this.register_tab.Controls.Add(this.username_text_tab2);
            this.register_tab.Controls.Add(this.guna2HtmlLabel1);
            this.register_tab.Controls.Add(this.guna2PictureBox5);
            this.register_tab.Location = new System.Drawing.Point(184, 4);
            this.register_tab.Name = "register_tab";
            this.register_tab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.register_tab.Size = new System.Drawing.Size(1629, 656);
            this.register_tab.TabIndex = 1;
            this.register_tab.Text = "Register";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(110, 72);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(433, 427);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox4.TabIndex = 28;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox7
            // 
            this.guna2PictureBox7.ImageRotate = 0F;
            this.guna2PictureBox7.Location = new System.Drawing.Point(680, -12);
            this.guna2PictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox7.Name = "guna2PictureBox7";
            this.guna2PictureBox7.Size = new System.Drawing.Size(8, 682);
            this.guna2PictureBox7.TabIndex = 27;
            this.guna2PictureBox7.TabStop = false;
            // 
            // lastname_tab2
            // 
            this.lastname_tab2.AllowDrop = true;
            this.lastname_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.lastname_tab2.BorderColor = System.Drawing.Color.White;
            this.lastname_tab2.BorderRadius = 10;
            this.lastname_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lastname_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastname_tab2.DefaultText = "";
            this.lastname_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastname_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastname_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastname_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastname_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastname_tab2.Location = new System.Drawing.Point(885, 116);
            this.lastname_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastname_tab2.Name = "lastname_tab2";
            this.lastname_tab2.PasswordChar = '\0';
            this.lastname_tab2.PlaceholderText = "Last Name";
            this.lastname_tab2.SelectedText = "";
            this.lastname_tab2.Size = new System.Drawing.Size(127, 45);
            this.lastname_tab2.TabIndex = 20;
            // 
            // firstname_tab2
            // 
            this.firstname_tab2.AllowDrop = true;
            this.firstname_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.firstname_tab2.BorderColor = System.Drawing.Color.White;
            this.firstname_tab2.BorderRadius = 10;
            this.firstname_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.firstname_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstname_tab2.DefaultText = "";
            this.firstname_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstname_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstname_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstname_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstname_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstname_tab2.Location = new System.Drawing.Point(756, 116);
            this.firstname_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname_tab2.Name = "firstname_tab2";
            this.firstname_tab2.PasswordChar = '\0';
            this.firstname_tab2.PlaceholderText = "First Name";
            this.firstname_tab2.SelectedText = "";
            this.firstname_tab2.Size = new System.Drawing.Size(120, 45);
            this.firstname_tab2.TabIndex = 19;
            // 
            // error_message_tab2
            // 
            this.error_message_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.error_message_tab2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_message_tab2.ForeColor = System.Drawing.Color.Red;
            this.error_message_tab2.Location = new System.Drawing.Point(765, 517);
            this.error_message_tab2.Name = "error_message_tab2";
            this.error_message_tab2.Size = new System.Drawing.Size(231, 23);
            this.error_message_tab2.TabIndex = 18;
            this.error_message_tab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact_info_txt_tab2
            // 
            this.contact_info_txt_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.contact_info_txt_tab2.BorderColor = System.Drawing.Color.White;
            this.contact_info_txt_tab2.BorderRadius = 10;
            this.contact_info_txt_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.contact_info_txt_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contact_info_txt_tab2.DefaultText = "";
            this.contact_info_txt_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contact_info_txt_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contact_info_txt_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact_info_txt_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contact_info_txt_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact_info_txt_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_info_txt_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contact_info_txt_tab2.Location = new System.Drawing.Point(758, 302);
            this.contact_info_txt_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contact_info_txt_tab2.Name = "contact_info_txt_tab2";
            this.contact_info_txt_tab2.PasswordChar = '\0';
            this.contact_info_txt_tab2.PlaceholderText = "Contact Number";
            this.contact_info_txt_tab2.SelectedText = "";
            this.contact_info_txt_tab2.Size = new System.Drawing.Size(253, 45);
            this.contact_info_txt_tab2.TabIndex = 17;
            // 
            // gender_combobox_tab2
            // 
            this.gender_combobox_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.gender_combobox_tab2.BorderRadius = 10;
            this.gender_combobox_tab2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender_combobox_tab2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_combobox_tab2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender_combobox_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gender_combobox_tab2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gender_combobox_tab2.ForeColor = System.Drawing.Color.Silver;
            this.gender_combobox_tab2.ItemHeight = 30;
            this.gender_combobox_tab2.Items.AddRange(new object[] {
            "Gender",
            "Male",
            "Female"});
            this.gender_combobox_tab2.Location = new System.Drawing.Point(758, 361);
            this.gender_combobox_tab2.Name = "gender_combobox_tab2";
            this.gender_combobox_tab2.Size = new System.Drawing.Size(129, 36);
            this.gender_combobox_tab2.StartIndex = 0;
            this.gender_combobox_tab2.TabIndex = 16;
            // 
            // signin_btn_tab1
            // 
            this.signin_btn_tab1.AutoRoundedCorners = true;
            this.signin_btn_tab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.signin_btn_tab1.BorderRadius = 24;
            this.signin_btn_tab1.BorderThickness = 1;
            this.signin_btn_tab1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signin_btn_tab1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signin_btn_tab1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signin_btn_tab1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signin_btn_tab1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.signin_btn_tab1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.signin_btn_tab1.ForeColor = System.Drawing.Color.White;
            this.signin_btn_tab1.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.signin_btn_tab1.HoverState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.signin_btn_tab1.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.signin_btn_tab1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.signin_btn_tab1.Location = new System.Drawing.Point(893, 543);
            this.signin_btn_tab1.Name = "signin_btn_tab1";
            this.signin_btn_tab1.Size = new System.Drawing.Size(118, 50);
            this.signin_btn_tab1.TabIndex = 14;
            this.signin_btn_tab1.Text = "Sign in";
            this.signin_btn_tab1.Click += new System.EventHandler(this.signin_btn_tab1_Click);
            // 
            // signup_btn_tab2
            // 
            this.signup_btn_tab2.AutoRoundedCorners = true;
            this.signup_btn_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.signup_btn_tab2.BorderRadius = 24;
            this.signup_btn_tab2.BorderThickness = 1;
            this.signup_btn_tab2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn_tab2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signup_btn_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signup_btn_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signup_btn_tab2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.signup_btn_tab2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.signup_btn_tab2.ForeColor = System.Drawing.Color.White;
            this.signup_btn_tab2.HoverState.BorderColor = System.Drawing.SystemColors.Control;
            this.signup_btn_tab2.HoverState.CustomBorderColor = System.Drawing.SystemColors.Control;
            this.signup_btn_tab2.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.signup_btn_tab2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.signup_btn_tab2.Location = new System.Drawing.Point(768, 543);
            this.signup_btn_tab2.Name = "signup_btn_tab2";
            this.signup_btn_tab2.Size = new System.Drawing.Size(118, 50);
            this.signup_btn_tab2.TabIndex = 13;
            this.signup_btn_tab2.Text = "Register";
            this.signup_btn_tab2.Click += new System.EventHandler(this.signup_btn_tab2_Click_1);
            // 
            // confirm_password_text_tab2
            // 
            this.confirm_password_text_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.confirm_password_text_tab2.BorderColor = System.Drawing.Color.White;
            this.confirm_password_text_tab2.BorderRadius = 10;
            this.confirm_password_text_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.confirm_password_text_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirm_password_text_tab2.DefaultText = "";
            this.confirm_password_text_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirm_password_text_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirm_password_text_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirm_password_text_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirm_password_text_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirm_password_text_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_password_text_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirm_password_text_tab2.Location = new System.Drawing.Point(758, 468);
            this.confirm_password_text_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirm_password_text_tab2.Name = "confirm_password_text_tab2";
            this.confirm_password_text_tab2.PasswordChar = '●';
            this.confirm_password_text_tab2.PlaceholderText = "Confim Password";
            this.confirm_password_text_tab2.SelectedText = "";
            this.confirm_password_text_tab2.Size = new System.Drawing.Size(253, 45);
            this.confirm_password_text_tab2.TabIndex = 12;
            this.confirm_password_text_tab2.UseSystemPasswordChar = true;
            // 
            // password_text_tab2
            // 
            this.password_text_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.password_text_tab2.BorderColor = System.Drawing.Color.White;
            this.password_text_tab2.BorderRadius = 10;
            this.password_text_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.password_text_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_text_tab2.DefaultText = "";
            this.password_text_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_text_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_text_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_text_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_text_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_text_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_text_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_text_tab2.Location = new System.Drawing.Point(758, 413);
            this.password_text_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_text_tab2.Name = "password_text_tab2";
            this.password_text_tab2.PasswordChar = '●';
            this.password_text_tab2.PlaceholderText = "Password";
            this.password_text_tab2.SelectedText = "";
            this.password_text_tab2.Size = new System.Drawing.Size(253, 45);
            this.password_text_tab2.TabIndex = 11;
            this.password_text_tab2.UseSystemPasswordChar = true;
            // 
            // email_text_tab2
            // 
            this.email_text_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.email_text_tab2.BorderColor = System.Drawing.Color.White;
            this.email_text_tab2.BorderRadius = 10;
            this.email_text_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.email_text_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_text_tab2.DefaultText = "";
            this.email_text_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_text_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_text_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_text_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_text_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_text_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_text_tab2.Location = new System.Drawing.Point(756, 240);
            this.email_text_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.email_text_tab2.Name = "email_text_tab2";
            this.email_text_tab2.PasswordChar = '\0';
            this.email_text_tab2.PlaceholderText = "Email";
            this.email_text_tab2.SelectedText = "";
            this.email_text_tab2.Size = new System.Drawing.Size(253, 45);
            this.email_text_tab2.TabIndex = 10;
            // 
            // username_text_tab2
            // 
            this.username_text_tab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.username_text_tab2.BorderColor = System.Drawing.Color.White;
            this.username_text_tab2.BorderRadius = 10;
            this.username_text_tab2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.username_text_tab2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_text_tab2.DefaultText = "";
            this.username_text_tab2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_text_tab2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_text_tab2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_text_tab2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_text_tab2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_text_tab2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_text_tab2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_text_tab2.Location = new System.Drawing.Point(756, 178);
            this.username_text_tab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_text_tab2.Name = "username_text_tab2";
            this.username_text_tab2.PasswordChar = '\0';
            this.username_text_tab2.PlaceholderText = "Username";
            this.username_text_tab2.SelectedText = "";
            this.username_text_tab2.Size = new System.Drawing.Size(253, 45);
            this.username_text_tab2.TabIndex = 9;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(805, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(127, 53);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Sign up";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(690, -3);
            this.guna2PictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(526, 655);
            this.guna2PictureBox5.TabIndex = 26;
            this.guna2PictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 655);
            this.Controls.Add(this.main_control_tab);
            this.Name = "Form1";
            this.Text = "Flex Trainer";
            this.main_control_tab.ResumeLayout(false);
            this.login_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.register_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TabControl main_control_tab;
        private TabPage login_tab;
        private TabPage register_tab;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox username_text_tab2;
        private Guna.UI2.WinForms.Guna2TextBox email_text_tab2;
        private Guna.UI2.WinForms.Guna2TextBox password_text_tab2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox username_text_tab1;
        private Guna.UI2.WinForms.Guna2TextBox confirm_password_text_tab2;
        private Guna.UI2.WinForms.Guna2TextBox password_text_tab1;
        private Guna.UI2.WinForms.Guna2Button signup_btn_tab2;
        private Guna.UI2.WinForms.Guna2Button signin_btn_tab1;
        private Guna.UI2.WinForms.Guna2ComboBox gender_combobox_tab2;
        private Guna.UI2.WinForms.Guna2TextBox contact_info_txt_tab2;
        private Label error_message_tab2;
        private Guna.UI2.WinForms.Guna2TextBox lastname_tab2;
        private Guna.UI2.WinForms.Guna2TextBox firstname_tab2;
        private Label error_label_tab1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox7;
    }
}
