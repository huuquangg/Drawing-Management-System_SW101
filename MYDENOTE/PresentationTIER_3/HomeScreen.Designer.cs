using System;
using BUS;
using GUI;

namespace new_project
{
    partial class HomeScreen
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
            this.TopNavigationHomescreen = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimize_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Zoom_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Close_btn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Container_workspace = new System.Windows.Forms.TableLayoutPanel();
            this.Logo_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Icon_img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Brand_ = new System.Windows.Forms.Label();
            this.User_container = new Guna.UI2.WinForms.Guna2Panel();
            this.Username = new System.Windows.Forms.Label();
            this.UserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.LogOut = new Guna.UI2.WinForms.Guna2Button();
            this.Reminder = new Guna.UI2.WinForms.Guna2Button();
            this.Note = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FlowBPItem = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopNavigationHomescreen.SuspendLayout();
            this.Container_workspace.SuspendLayout();
            this.Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_img)).BeginInit();
            this.User_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // TopNavigationHomescreen
            // 
            this.TopNavigationHomescreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.TopNavigationHomescreen.Controls.Add(this.Minimize_btn);
            this.TopNavigationHomescreen.Controls.Add(this.Zoom_btn);
            this.TopNavigationHomescreen.Controls.Add(this.Close_btn);
            this.TopNavigationHomescreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopNavigationHomescreen.Location = new System.Drawing.Point(0, 0);
            this.TopNavigationHomescreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TopNavigationHomescreen.Name = "TopNavigationHomescreen";
            this.TopNavigationHomescreen.ShadowDecoration.Parent = this.TopNavigationHomescreen;
            this.TopNavigationHomescreen.Size = new System.Drawing.Size(935, 46);
            this.TopNavigationHomescreen.TabIndex = 1;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.Minimize_btn.FillColor = System.Drawing.Color.Transparent;
            this.Minimize_btn.HoverState.Parent = this.Minimize_btn;
            this.Minimize_btn.IconColor = System.Drawing.Color.Black;
            this.Minimize_btn.Location = new System.Drawing.Point(724, 0);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.ShadowDecoration.Parent = this.Minimize_btn;
            this.Minimize_btn.Size = new System.Drawing.Size(67, 46);
            this.Minimize_btn.TabIndex = 3;
            // 
            // Zoom_btn
            // 
            this.Zoom_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zoom_btn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.Zoom_btn.FillColor = System.Drawing.Color.Transparent;
            this.Zoom_btn.HoverState.Parent = this.Zoom_btn;
            this.Zoom_btn.IconColor = System.Drawing.Color.Black;
            this.Zoom_btn.Location = new System.Drawing.Point(797, 0);
            this.Zoom_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Zoom_btn.Name = "Zoom_btn";
            this.Zoom_btn.ShadowDecoration.Parent = this.Zoom_btn;
            this.Zoom_btn.Size = new System.Drawing.Size(67, 46);
            this.Zoom_btn.TabIndex = 2;
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.FillColor = System.Drawing.Color.Transparent;
            this.Close_btn.HoverState.Parent = this.Close_btn;
            this.Close_btn.IconColor = System.Drawing.Color.Black;
            this.Close_btn.Location = new System.Drawing.Point(869, 0);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.ShadowDecoration.Parent = this.Close_btn;
            this.Close_btn.Size = new System.Drawing.Size(67, 46);
            this.Close_btn.TabIndex = 1;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Container_workspace
            // 
            this.Container_workspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Container_workspace.BackColor = System.Drawing.Color.LawnGreen;
            this.Container_workspace.ColumnCount = 2;
            this.Container_workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.Container_workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79F));
            this.Container_workspace.Controls.Add(this.Logo_panel, 0, 0);
            this.Container_workspace.Controls.Add(this.User_container, 0, 1);
            this.Container_workspace.Controls.Add(this.SearchBox, 1, 0);
            this.Container_workspace.Controls.Add(this.FlowBPItem, 1, 1);
            this.Container_workspace.Location = new System.Drawing.Point(0, 42);
            this.Container_workspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Container_workspace.Name = "Container_workspace";
            this.Container_workspace.RowCount = 3;
            this.Container_workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.01384F));
            this.Container_workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.98616F));
            this.Container_workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Container_workspace.Size = new System.Drawing.Size(935, 578);
            this.Container_workspace.TabIndex = 0;
            // 
            // Logo_panel
            // 
            this.Logo_panel.BackColor = System.Drawing.Color.Salmon;
            this.Logo_panel.Controls.Add(this.Icon_img);
            this.Logo_panel.Controls.Add(this.Brand_);
            this.Logo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_panel.Location = new System.Drawing.Point(3, 2);
            this.Logo_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo_panel.Name = "Logo_panel";
            this.Logo_panel.ShadowDecoration.Parent = this.Logo_panel;
            this.Logo_panel.Size = new System.Drawing.Size(190, 74);
            this.Logo_panel.TabIndex = 3;
            // 
            // Icon_img
            // 
            this.Icon_img.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Icon_img.Image = global::new_project.Properties.Resources.color_palette;
            this.Icon_img.Location = new System.Drawing.Point(3, 13);
            this.Icon_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Icon_img.Name = "Icon_img";
            this.Icon_img.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Icon_img.ShadowDecoration.Parent = this.Icon_img;
            this.Icon_img.Size = new System.Drawing.Size(45, 46);
            this.Icon_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Icon_img.TabIndex = 0;
            this.Icon_img.TabStop = false;
            // 
            // Brand_
            // 
            this.Brand_.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Brand_.AutoSize = true;
            this.Brand_.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.Brand_.Location = new System.Drawing.Point(48, 18);
            this.Brand_.Name = "Brand_";
            this.Brand_.Size = new System.Drawing.Size(142, 38);
            this.Brand_.TabIndex = 2;
            this.Brand_.Text = "DETON";
            // 
            // User_container
            // 
            this.User_container.BackColor = System.Drawing.Color.LightPink;
            this.User_container.Controls.Add(this.Username);
            this.User_container.Controls.Add(this.UserAvatar);
            this.User_container.Controls.Add(this.LogOut);
            this.User_container.Controls.Add(this.Reminder);
            this.User_container.Controls.Add(this.Note);
            this.User_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_container.Location = new System.Drawing.Point(3, 80);
            this.User_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User_container.Name = "User_container";
            this.User_container.ShadowDecoration.Parent = this.User_container;
            this.User_container.Size = new System.Drawing.Size(190, 475);
            this.User_container.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(49, 84);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(106, 28);
            this.Username.TabIndex = 10;
            this.Username.Text = "Username"; // hardcode while waiting for the above line to work
            //this.Username.Text = objUserBUS_HomeScreen.getUsername(Login.currUser);
            // 
            // UserAvatar
            // 
            this.UserAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserAvatar.Image = global::new_project.Properties.Resources.kitty;
            this.UserAvatar.Location = new System.Drawing.Point(66, 25);
            this.UserAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserAvatar.Name = "UserAvatar";
            this.UserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UserAvatar.ShadowDecoration.Parent = this.UserAvatar;
            this.UserAvatar.Size = new System.Drawing.Size(57, 57);
            this.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserAvatar.TabIndex = 9;
            this.UserAvatar.TabStop = false;
            // 
            // LogOut
            // 
            this.LogOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOut.Animated = true;
            this.LogOut.AutoRoundedCorners = true;
            this.LogOut.BackColor = System.Drawing.Color.Transparent;
            this.LogOut.BorderColor = System.Drawing.Color.Transparent;
            this.LogOut.BorderRadius = 26;
            this.LogOut.BorderThickness = 1;
            this.LogOut.CheckedState.Parent = this.LogOut;
            this.LogOut.CustomImages.Parent = this.LogOut;
            this.LogOut.FillColor = System.Drawing.Color.Transparent;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.Color.Black;
            this.LogOut.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.LogOut.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.LogOut.HoverState.ForeColor = System.Drawing.Color.Black;
            this.LogOut.HoverState.Parent = this.LogOut;
            this.LogOut.Image = global::new_project.Properties.Resources.icons8_arrow_right_30;
            this.LogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogOut.ImageOffset = new System.Drawing.Point(25, 0);
            this.LogOut.ImageSize = new System.Drawing.Size(22, 22);
            this.LogOut.Location = new System.Drawing.Point(-21, 250);
            this.LogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOut.Name = "LogOut";
            this.LogOut.ShadowDecoration.BorderRadius = 26;
            this.LogOut.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.LogOut.ShadowDecoration.Enabled = true;
            this.LogOut.ShadowDecoration.Parent = this.LogOut;
            this.LogOut.Size = new System.Drawing.Size(211, 55);
            this.LogOut.TabIndex = 3;
            this.LogOut.Text = "Log Out";
            this.LogOut.TextOffset = new System.Drawing.Point(20, 0);
            this.LogOut.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // Reminder
            // 
            this.Reminder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reminder.Animated = true;
            this.Reminder.AutoRoundedCorners = true;
            this.Reminder.BackColor = System.Drawing.Color.Transparent;
            this.Reminder.BorderColor = System.Drawing.Color.Transparent;
            this.Reminder.BorderRadius = 26;
            this.Reminder.BorderThickness = 1;
            this.Reminder.CheckedState.Parent = this.Reminder;
            this.Reminder.CustomImages.Parent = this.Reminder;
            this.Reminder.FillColor = System.Drawing.Color.Transparent;
            this.Reminder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reminder.ForeColor = System.Drawing.Color.Black;
            this.Reminder.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Reminder.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Reminder.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Reminder.HoverState.Parent = this.Reminder;
            this.Reminder.Image = global::new_project.Properties.Resources.icons8_bell_24;
            this.Reminder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Reminder.ImageOffset = new System.Drawing.Point(25, 0);
            this.Reminder.ImageSize = new System.Drawing.Size(22, 22);
            this.Reminder.Location = new System.Drawing.Point(-21, 191);
            this.Reminder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reminder.Name = "Reminder";
            this.Reminder.ShadowDecoration.BorderRadius = 26;
            this.Reminder.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.Reminder.ShadowDecoration.Enabled = true;
            this.Reminder.ShadowDecoration.Parent = this.Reminder;
            this.Reminder.Size = new System.Drawing.Size(211, 55);
            this.Reminder.TabIndex = 8;
            this.Reminder.Text = "Reminder";
            this.Reminder.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // Note
            // 
            this.Note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Note.Animated = true;
            this.Note.AutoRoundedCorners = true;
            this.Note.BackColor = System.Drawing.Color.Transparent;
            this.Note.BorderColor = System.Drawing.Color.Transparent;
            this.Note.BorderRadius = 26;
            this.Note.BorderThickness = 1;
            this.Note.CheckedState.Parent = this.Note;
            this.Note.CustomImages.Parent = this.Note;
            this.Note.FillColor = System.Drawing.Color.Transparent;
            this.Note.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.ForeColor = System.Drawing.Color.Black;
            this.Note.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.Note.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Note.HoverState.ForeColor = System.Drawing.Color.Black;
            this.Note.HoverState.Parent = this.Note;
            this.Note.Image = global::new_project.Properties.Resources.icons8_pencil_50;
            this.Note.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Note.ImageOffset = new System.Drawing.Point(25, 0);
            this.Note.ImageSize = new System.Drawing.Size(22, 22);
            this.Note.Location = new System.Drawing.Point(-22, 132);
            this.Note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Note.Name = "Note";
            this.Note.ShadowDecoration.BorderRadius = 26;
            this.Note.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.Note.ShadowDecoration.Enabled = true;
            this.Note.ShadowDecoration.Parent = this.Note;
            this.Note.Size = new System.Drawing.Size(211, 55);
            this.Note.TabIndex = 7;
            this.Note.Text = "Note";
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Animated = true;
            this.SearchBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchBox.BorderColor = System.Drawing.Color.LightCyan;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.DefaultText = "";
            this.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.DisabledState.Parent = this.SearchBox;
            this.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBox.FillColor = System.Drawing.Color.Gainsboro;
            this.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.FocusedState.Parent = this.SearchBox;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBox.HoverState.Parent = this.SearchBox;
            this.SearchBox.IconLeft = global::new_project.Properties.Resources.icons8_search_50;
            this.SearchBox.Location = new System.Drawing.Point(316, 14);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(120, 10, 120, 10);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SearchBox.PlaceholderText = "  Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.Parent = this.SearchBox;
            this.SearchBox.Size = new System.Drawing.Size(499, 50);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // FlowBPItem
            // 
            this.FlowBPItem.AutoSize = true;
            this.FlowBPItem.BackColor = System.Drawing.Color.Silver;
            this.FlowBPItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowBPItem.Location = new System.Drawing.Point(199, 81);
            this.FlowBPItem.Name = "FlowBPItem";
            this.FlowBPItem.Padding = new System.Windows.Forms.Padding(50);
            this.FlowBPItem.Size = new System.Drawing.Size(733, 473);
            this.FlowBPItem.TabIndex = 14;
            this.FlowBPItem.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowBPItem_Paint);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopNavigationHomescreen;
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 622);
            this.Controls.Add(this.TopNavigationHomescreen);
            this.Controls.Add(this.Container_workspace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.TopNavigationHomescreen.ResumeLayout(false);
            this.Container_workspace.ResumeLayout(false);
            this.Container_workspace.PerformLayout();
            this.Logo_panel.ResumeLayout(false);
            this.Logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_img)).EndInit();
            this.User_container.ResumeLayout(false);
            this.User_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopNavigationHomescreen;
        private Guna.UI2.WinForms.Guna2ControlBox Minimize_btn;
        private Guna.UI2.WinForms.Guna2ControlBox Zoom_btn;
        private Guna.UI2.WinForms.Guna2ControlBox Close_btn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TableLayoutPanel Container_workspace;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Icon_img;
        private Guna.UI2.WinForms.Guna2Panel Logo_panel;
        private System.Windows.Forms.Label Brand_;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Panel User_container;
        private Guna.UI2.WinForms.Guna2Button Note;
        private Guna.UI2.WinForms.Guna2Button LogOut;
        private Guna.UI2.WinForms.Guna2Button Reminder;
        //private Guna.UI2.WinForms.Guna2Button row1_left;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox UserAvatar;
        private System.Windows.Forms.Label Username;
        //private Guna.UI2.WinForms.Guna2Button newPaint;
        //private System.Windows.Forms.Label row1_mid_name;
        private System.Windows.Forms.FlowLayoutPanel FlowBPItem;
        //private System.Windows.Forms.Panel BluePrintItemContain;
    }
}