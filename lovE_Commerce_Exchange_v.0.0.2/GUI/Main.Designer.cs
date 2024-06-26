﻿namespace GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.panel_controlbox = new System.Windows.Forms.Panel();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_maximize = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.gradientLabel2 = new GUI.CustomControl.GradientLabel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.iconButton_account_centre = new FontAwesome.Sharp.IconButton();
            this.iconButton_home = new FontAwesome.Sharp.IconButton();
            this.iconButton_shoppingcart = new FontAwesome.Sharp.IconButton();
            this.iconButton_search = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gradientLabel4 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel4_logo = new GUI.CustomControl.GradientLabel();
            this.panel_suggestBar = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.gradientLabel1 = new GUI.CustomControl.GradientLabel();
            this.gradientLabel3 = new GUI.CustomControl.GradientLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_controlbox.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_controlbox
            // 
            this.panel_controlbox.BackColor = System.Drawing.Color.Pink;
            this.panel_controlbox.Controls.Add(this.button_minimize);
            this.panel_controlbox.Controls.Add(this.button_maximize);
            this.panel_controlbox.Controls.Add(this.button_exit);
            this.panel_controlbox.Controls.Add(this.gradientLabel2);
            this.panel_controlbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_controlbox.Location = new System.Drawing.Point(0, 0);
            this.panel_controlbox.Name = "panel_controlbox";
            this.panel_controlbox.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.panel_controlbox.Size = new System.Drawing.Size(1531, 50);
            this.panel_controlbox.TabIndex = 2;
            // 
            // button_minimize
            // 
            this.button_minimize.BackColor = System.Drawing.Color.LightPink;
            this.button_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minimize.ForeColor = System.Drawing.Color.Lime;
            this.button_minimize.Location = new System.Drawing.Point(1402, 0);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(40, 50);
            this.button_minimize.TabIndex = 2;
            this.button_minimize.Text = "O";
            this.button_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_minimize.UseVisualStyleBackColor = false;
            this.button_minimize.Click += new System.EventHandler(this.Button_minimize_Click);
            // 
            // button_maximize
            // 
            this.button_maximize.BackColor = System.Drawing.Color.LightPink;
            this.button_maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_maximize.FlatAppearance.BorderSize = 0;
            this.button_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_maximize.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_maximize.ForeColor = System.Drawing.Color.Yellow;
            this.button_maximize.Location = new System.Drawing.Point(1442, 0);
            this.button_maximize.Name = "button_maximize";
            this.button_maximize.Size = new System.Drawing.Size(40, 50);
            this.button_maximize.TabIndex = 1;
            this.button_maximize.Text = "O";
            this.button_maximize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_maximize.UseVisualStyleBackColor = false;
            this.button_maximize.Click += new System.EventHandler(this.Button_maximize_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.LightPink;
            this.button_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.OrangeRed;
            this.button_exit.Location = new System.Drawing.Point(1482, 0);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(40, 50);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "O";
            this.button_exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BeginColor = System.Drawing.Color.MediumPurple;
            this.gradientLabel2.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabel2.EndColor = System.Drawing.Color.Pink;
            this.gradientLabel2.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(1522, 50);
            this.gradientLabel2.TabIndex = 12;
            this.gradientLabel2.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel2.TextColorEnd = System.Drawing.SystemColors.Control;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_header.Controls.Add(this.textBox_search);
            this.panel_header.Controls.Add(this.rjButton1);
            this.panel_header.Controls.Add(this.iconButton_account_centre);
            this.panel_header.Controls.Add(this.iconButton_home);
            this.panel_header.Controls.Add(this.iconButton_shoppingcart);
            this.panel_header.Controls.Add(this.iconButton_search);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.label);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Controls.Add(this.gradientLabel4);
            this.panel_header.Controls.Add(this.gradientLabel4_logo);
            this.panel_header.Controls.Add(this.panel_suggestBar);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 50);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1531, 94);
            this.panel_header.TabIndex = 3;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_search.Location = new System.Drawing.Point(274, 23);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(624, 21);
            this.textBox_search.TabIndex = 12;
            this.textBox_search.Text = "Search ";
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderRadius = 20;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.Enabled = false;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(256, 12);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(659, 40);
            this.rjButton1.TabIndex = 13;
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton_account_centre
            // 
            this.iconButton_account_centre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_account_centre.FlatAppearance.BorderSize = 0;
            this.iconButton_account_centre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_account_centre.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.iconButton_account_centre.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_account_centre.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton_account_centre.IconColor = System.Drawing.Color.DimGray;
            this.iconButton_account_centre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_account_centre.IconSize = 40;
            this.iconButton_account_centre.Location = new System.Drawing.Point(1198, 11);
            this.iconButton_account_centre.Name = "iconButton_account_centre";
            this.iconButton_account_centre.Size = new System.Drawing.Size(130, 45);
            this.iconButton_account_centre.TabIndex = 11;
            this.iconButton_account_centre.Text = "Account";
            this.iconButton_account_centre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_account_centre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_account_centre.UseVisualStyleBackColor = true;
            this.iconButton_account_centre.Click += new System.EventHandler(this.IconButton_account_centre_Click);
            // 
            // iconButton_home
            // 
            this.iconButton_home.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_home.FlatAppearance.BorderSize = 0;
            this.iconButton_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_home.Font = new System.Drawing.Font("Sans Serif Collection", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton_home.ForeColor = System.Drawing.Color.DimGray;
            this.iconButton_home.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconButton_home.IconColor = System.Drawing.Color.DimGray;
            this.iconButton_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_home.IconSize = 40;
            this.iconButton_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_home.Location = new System.Drawing.Point(1062, 11);
            this.iconButton_home.Name = "iconButton_home";
            this.iconButton_home.Size = new System.Drawing.Size(130, 45);
            this.iconButton_home.TabIndex = 11;
            this.iconButton_home.Text = "Home";
            this.iconButton_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton_home.UseVisualStyleBackColor = true;
            this.iconButton_home.Click += new System.EventHandler(this.IconButton_home_Click);
            // 
            // iconButton_shoppingcart
            // 
            this.iconButton_shoppingcart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_shoppingcart.FlatAppearance.BorderSize = 0;
            this.iconButton_shoppingcart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_shoppingcart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButton_shoppingcart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(127)))), ((int)(((byte)(255)))));
            this.iconButton_shoppingcart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_shoppingcart.Location = new System.Drawing.Point(1334, 9);
            this.iconButton_shoppingcart.Name = "iconButton_shoppingcart";
            this.iconButton_shoppingcart.Size = new System.Drawing.Size(50, 50);
            this.iconButton_shoppingcart.TabIndex = 10;
            this.iconButton_shoppingcart.UseVisualStyleBackColor = true;
            this.iconButton_shoppingcart.Click += new System.EventHandler(this.IconButton_shoppingcart_Click);
            // 
            // iconButton_search
            // 
            this.iconButton_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton_search.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton_search.FlatAppearance.BorderSize = 0;
            this.iconButton_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconButton_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton_search.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.iconButton_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_search.IconSize = 30;
            this.iconButton_search.Location = new System.Drawing.Point(921, 14);
            this.iconButton_search.Name = "iconButton_search";
            this.iconButton_search.Size = new System.Drawing.Size(40, 40);
            this.iconButton_search.TabIndex = 9;
            this.iconButton_search.UseVisualStyleBackColor = true;
            this.iconButton_search.Click += new System.EventHandler(this.IconButton_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Durex condom";
            this.label2.Click += new System.EventHandler(this.Label_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(355, 58);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 16);
            this.label.TabIndex = 8;
            this.label.Text = "Iphone 15 promax";
            this.label.Click += new System.EventHandler(this.Label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lonely Wotf";
            this.label1.Click += new System.EventHandler(this.Label_Click);
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.AutoSize = true;
            this.gradientLabel4.BeginColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientLabel4.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel4.EndColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientLabel4.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel4.Location = new System.Drawing.Point(122, 50);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(112, 22);
            this.gradientLabel4.TabIndex = 14;
            this.gradientLabel4.Text = "e-commerce";
            this.gradientLabel4.TextColorBegin = System.Drawing.Color.Crimson;
            this.gradientLabel4.TextColorEnd = System.Drawing.Color.Fuchsia;
            // 
            // gradientLabel4_logo
            // 
            this.gradientLabel4_logo.AutoSize = true;
            this.gradientLabel4_logo.BeginColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientLabel4_logo.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel4_logo.EndColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientLabel4_logo.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel4_logo.Location = new System.Drawing.Point(73, 9);
            this.gradientLabel4_logo.Name = "gradientLabel4_logo";
            this.gradientLabel4_logo.Size = new System.Drawing.Size(161, 41);
            this.gradientLabel4_logo.TabIndex = 14;
            this.gradientLabel4_logo.Text = "LoveCrush";
            this.gradientLabel4_logo.TextColorBegin = System.Drawing.Color.MediumSlateBlue;
            this.gradientLabel4_logo.TextColorEnd = System.Drawing.Color.DeepPink;
            // 
            // panel_suggestBar
            // 
            this.panel_suggestBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_suggestBar.Location = new System.Drawing.Point(274, 12);
            this.panel_suggestBar.Name = "panel_suggestBar";
            this.panel_suggestBar.Size = new System.Drawing.Size(624, 42);
            this.panel_suggestBar.TabIndex = 15;
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_body.Location = new System.Drawing.Point(121, 149);
            this.panel_body.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1284, 747);
            this.panel_body.TabIndex = 0;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel1.BeginColor = System.Drawing.Color.Thistle;
            this.gradientLabel1.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel1.EndColor = System.Drawing.Color.MediumSlateBlue;
            this.gradientLabel1.Location = new System.Drawing.Point(3, 147);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(917, 753);
            this.gradientLabel1.TabIndex = 4;
            this.gradientLabel1.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel1.TextColorEnd = System.Drawing.SystemColors.Control;
            this.gradientLabel1.Click += new System.EventHandler(this.GradientLabel1_Click);
            // 
            // gradientLabel3
            // 
            this.gradientLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientLabel3.BeginColor = System.Drawing.Color.MediumSlateBlue;
            this.gradientLabel3.Direction = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.gradientLabel3.EndColor = System.Drawing.Color.Thistle;
            this.gradientLabel3.Location = new System.Drawing.Point(918, 147);
            this.gradientLabel3.Name = "gradientLabel3";
            this.gradientLabel3.Size = new System.Drawing.Size(613, 753);
            this.gradientLabel3.TabIndex = 4;
            this.gradientLabel3.TextColorBegin = System.Drawing.SystemColors.Control;
            this.gradientLabel3.TextColorEnd = System.Drawing.SystemColors.Control;
            this.gradientLabel3.Click += new System.EventHandler(this.GradientLabel3_Click);
            // 
            // Main
            // 
            this.AcceptButton = this.iconButton_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1531, 909);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_controlbox);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.gradientLabel1);
            this.Controls.Add(this.gradientLabel3);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel_controlbox.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_controlbox;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_maximize;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Panel panel_header;
        private FontAwesome.Sharp.IconButton iconButton_shoppingcart;
        private FontAwesome.Sharp.IconButton iconButton_search;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton_account_centre;
        private FontAwesome.Sharp.IconButton iconButton_home;
        private System.Windows.Forms.Panel panel_body;
        private CustomControl.GradientLabel gradientLabel1;
        private CustomControl.GradientLabel gradientLabel2;
        private CustomControl.GradientLabel gradientLabel3;
        private System.Windows.Forms.TextBox textBox_search;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControl.GradientLabel gradientLabel4_logo;
        private CustomControl.GradientLabel gradientLabel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_suggestBar;
        private System.Windows.Forms.Timer timer1;
    }
}