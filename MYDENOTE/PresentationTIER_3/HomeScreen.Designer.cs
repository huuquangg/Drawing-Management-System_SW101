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
            this.CRUD_PaintWorkspace = new Guna.UI2.WinForms.Guna2Panel();
            this.row1_mid = new Guna.UI2.WinForms.Guna2Button();
            this.row1_mid_name = new System.Windows.Forms.Label();
            this.row1_left_name = new System.Windows.Forms.Label();
            this.newPaint = new Guna.UI2.WinForms.Guna2Button();
            this.row1_left = new Guna.UI2.WinForms.Guna2Button();
            this.User = new Guna.UI2.WinForms.Guna2Panel();
            this.Username = new System.Windows.Forms.Label();
            this.UserAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.TrashCan = new Guna.UI2.WinForms.Guna2Button();
            this.Reminder = new Guna.UI2.WinForms.Guna2Button();
            this.Note = new Guna.UI2.WinForms.Guna2Button();
            this.SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopNavigationHomescreen.SuspendLayout();
            this.Container_workspace.SuspendLayout();
            this.Logo_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_img)).BeginInit();
            this.CRUD_PaintWorkspace.SuspendLayout();
            this.User.SuspendLayout();
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
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // Container_workspace
            // 
            this.Container_workspace.ColumnCount = 2;
            this.Container_workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.Container_workspace.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79F));
            this.Container_workspace.Controls.Add(this.Logo_panel, 0, 0);
            this.Container_workspace.Controls.Add(this.CRUD_PaintWorkspace, 1, 1);
            this.Container_workspace.Controls.Add(this.User, 0, 1);
            this.Container_workspace.Controls.Add(this.SearchBox, 1, 0);
            this.Container_workspace.Location = new System.Drawing.Point(0, 42);
            this.Container_workspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Container_workspace.Name = "Container_workspace";
            this.Container_workspace.RowCount = 2;
            this.Container_workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.01384F));
            this.Container_workspace.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.98616F));
            this.Container_workspace.Size = new System.Drawing.Size(935, 578);
            this.Container_workspace.TabIndex = 0;
            // 
            // Logo_panel
            // 
            this.Logo_panel.Controls.Add(this.Icon_img);
            this.Logo_panel.Controls.Add(this.Brand_);
            this.Logo_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_panel.Location = new System.Drawing.Point(3, 2);
            this.Logo_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo_panel.Name = "Logo_panel";
            this.Logo_panel.ShadowDecoration.Parent = this.Logo_panel;
            this.Logo_panel.Size = new System.Drawing.Size(190, 76);
            this.Logo_panel.TabIndex = 3;
            // 
            // Icon_img
            // 
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
            this.Brand_.AutoSize = true;
            this.Brand_.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brand_.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.Brand_.Location = new System.Drawing.Point(47, 21);
            this.Brand_.Name = "Brand_";
            this.Brand_.Size = new System.Drawing.Size(142, 38);
            this.Brand_.TabIndex = 2;
            this.Brand_.Text = "DETON";
            // 
            // CRUD_PaintWorkspace
            // 
            this.CRUD_PaintWorkspace.Controls.Add(this.row1_mid);
            this.CRUD_PaintWorkspace.Controls.Add(this.row1_mid_name);
            this.CRUD_PaintWorkspace.Controls.Add(this.row1_left_name);
            this.CRUD_PaintWorkspace.Controls.Add(this.newPaint);
            this.CRUD_PaintWorkspace.Controls.Add(this.row1_left);
            this.CRUD_PaintWorkspace.Location = new System.Drawing.Point(199, 82);
            this.CRUD_PaintWorkspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CRUD_PaintWorkspace.Name = "CRUD_PaintWorkspace";
            this.CRUD_PaintWorkspace.ShadowDecoration.Parent = this.CRUD_PaintWorkspace;
            this.CRUD_PaintWorkspace.Size = new System.Drawing.Size(733, 493);
            this.CRUD_PaintWorkspace.TabIndex = 5;
            this.CRUD_PaintWorkspace.Paint += new System.Windows.Forms.PaintEventHandler(this.CRUD_PaintWorkspace_Paint);
            // 
            // row1_mid
            // 
            this.row1_mid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.row1_mid.BorderThickness = 1;
            this.row1_mid.CheckedState.Parent = this.row1_mid;
            this.row1_mid.CustomImages.Parent = this.row1_mid;
            this.row1_mid.FillColor = System.Drawing.Color.White;
            this.row1_mid.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1_mid.ForeColor = System.Drawing.Color.Gray;
            this.row1_mid.HoverState.Parent = this.row1_mid;
            this.row1_mid.Image = global::new_project.Properties.Resources.icons8_document_64;
            this.row1_mid.Location = new System.Drawing.Point(253, 25);
            this.row1_mid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.row1_mid.Name = "row1_mid";
            this.row1_mid.ShadowDecoration.Parent = this.row1_mid;
            this.row1_mid.Size = new System.Drawing.Size(180, 180);
            this.row1_mid.TabIndex = 13;
            this.row1_mid.Text = "Untitled";
            // 
            // row1_mid_name
            // 
            this.row1_mid_name.AutoSize = true;
            this.row1_mid_name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1_mid_name.Location = new System.Drawing.Point(309, 207);
            this.row1_mid_name.Name = "row1_mid_name";
            this.row1_mid_name.Size = new System.Drawing.Size(71, 17);
            this.row1_mid_name.TabIndex = 12;
            this.row1_mid_name.Text = "UserName";
            // 
            // row1_left_name
            // 
            this.row1_left_name.AutoSize = true;
            this.row1_left_name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1_left_name.Location = new System.Drawing.Point(73, 207);
            this.row1_left_name.Name = "row1_left_name";
            this.row1_left_name.Size = new System.Drawing.Size(71, 17);
            this.row1_left_name.TabIndex = 11;
            this.row1_left_name.Text = "UserName";
            // 
            // newPaint
            // 
            this.newPaint.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.newPaint.BorderThickness = 1;
            this.newPaint.CheckedState.Parent = this.newPaint;
            this.newPaint.CustomImages.Parent = this.newPaint;
            this.newPaint.FillColor = System.Drawing.Color.White;
            this.newPaint.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPaint.ForeColor = System.Drawing.Color.Gray;
            this.newPaint.HoverState.Parent = this.newPaint;
            this.newPaint.Image = global::new_project.Properties.Resources.icons8_plus_50;
            this.newPaint.ImageSize = new System.Drawing.Size(50, 50);
            this.newPaint.Location = new System.Drawing.Point(485, 25);
            this.newPaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newPaint.Name = "newPaint";
            this.newPaint.ShadowDecoration.Parent = this.newPaint;
            this.newPaint.Size = new System.Drawing.Size(180, 180);
            this.newPaint.TabIndex = 3;
            this.newPaint.Click += new System.EventHandler(this.btnNewPage_Click);
            // 
            // row1_left
            // 
            this.row1_left.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.row1_left.BorderThickness = 1;
            this.row1_left.CheckedState.Parent = this.row1_left;
            this.row1_left.CustomImages.Parent = this.row1_left;
            this.row1_left.FillColor = System.Drawing.Color.White;
            this.row1_left.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.row1_left.ForeColor = System.Drawing.Color.Gray;
            this.row1_left.HoverState.Parent = this.row1_left;
            this.row1_left.Image = global::new_project.Properties.Resources.icons8_document_64;
            this.row1_left.Location = new System.Drawing.Point(19, 25);
            this.row1_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.row1_left.Name = "row1_left";
            this.row1_left.ShadowDecoration.Parent = this.row1_left;
            this.row1_left.Size = new System.Drawing.Size(180, 180);
            this.row1_left.TabIndex = 2;
            this.row1_left.Text = "Untitled";
            this.row1_left.Click += new System.EventHandler(this.btnOpenPaint_Click);
            // 
            // User
            // 
            this.User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User.Controls.Add(this.Username);
            this.User.Controls.Add(this.UserAvatar);
            this.User.Controls.Add(this.TrashCan);
            this.User.Controls.Add(this.Reminder);
            this.User.Controls.Add(this.Note);
            this.User.Location = new System.Drawing.Point(3, 82);
            this.User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.User.Name = "User";
            this.User.ShadowDecoration.Parent = this.User;
            this.User.Size = new System.Drawing.Size(189, 493);
            this.User.TabIndex = 7;
            // 
            // Username
            // 
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(62, 70);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(0, 17);
            this.Username.TabIndex = 10;
            //this.Username.Text = "UserName";
            UserBUS userBUS = new UserBUS();
            this.Username.Text = Convert.ToString(userBUS.getUserId(Login.currUser));
            // 
            // UserAvatar
            // 
            this.UserAvatar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserAvatar.Image = global::new_project.Properties.Resources.kitty;
            this.UserAvatar.Location = new System.Drawing.Point(71, 18);
            this.UserAvatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserAvatar.Name = "UserAvatar";
            this.UserAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.UserAvatar.ShadowDecoration.Parent = this.UserAvatar;
            this.UserAvatar.Size = new System.Drawing.Size(51, 50);
            this.UserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserAvatar.TabIndex = 9;
            this.UserAvatar.TabStop = false;
            // 
            // TrashCan
            // 
            this.TrashCan.Animated = true;
            this.TrashCan.AutoRoundedCorners = true;
            this.TrashCan.BackColor = System.Drawing.Color.Transparent;
            this.TrashCan.BorderColor = System.Drawing.Color.Transparent;
            this.TrashCan.BorderRadius = 26;
            this.TrashCan.BorderThickness = 1;
            this.TrashCan.CheckedState.Parent = this.TrashCan;
            this.TrashCan.CustomImages.Parent = this.TrashCan;
            this.TrashCan.FillColor = System.Drawing.Color.Transparent;
            this.TrashCan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrashCan.ForeColor = System.Drawing.Color.Black;
            this.TrashCan.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TrashCan.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.TrashCan.HoverState.ForeColor = System.Drawing.Color.Black;
            this.TrashCan.HoverState.Parent = this.TrashCan;
            this.TrashCan.Image = global::new_project.Properties.Resources.icons8_trash_64;
            this.TrashCan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TrashCan.ImageOffset = new System.Drawing.Point(25, 0);
            this.TrashCan.ImageSize = new System.Drawing.Size(22, 22);
            this.TrashCan.Location = new System.Drawing.Point(-21, 230);
            this.TrashCan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrashCan.Name = "TrashCan";
            this.TrashCan.ShadowDecoration.BorderRadius = 26;
            this.TrashCan.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.TrashCan.ShadowDecoration.Enabled = true;
            this.TrashCan.ShadowDecoration.Parent = this.TrashCan;
            this.TrashCan.Size = new System.Drawing.Size(211, 55);
            this.TrashCan.TabIndex = 3;
            this.TrashCan.Text = "Trash can";
            this.TrashCan.TextOffset = new System.Drawing.Point(20, 0);
            this.TrashCan.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // Reminder
            // 
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
            this.Reminder.Location = new System.Drawing.Point(-21, 171);
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
            this.Note.Location = new System.Drawing.Point(-21, 112);
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
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.SearchBox.Location = new System.Drawing.Point(341, 20);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 20, 4, 6);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.PasswordChar = '\0';
            this.SearchBox.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SearchBox.PlaceholderText = "  Search";
            this.SearchBox.SelectedText = "";
            this.SearchBox.ShadowDecoration.Parent = this.SearchBox;
            this.SearchBox.Size = new System.Drawing.Size(448, 41);
            this.SearchBox.TabIndex = 6;
            this.SearchBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
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
            this.Logo_panel.ResumeLayout(false);
            this.Logo_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icon_img)).EndInit();
            this.CRUD_PaintWorkspace.ResumeLayout(false);
            this.CRUD_PaintWorkspace.PerformLayout();
            this.User.ResumeLayout(false);
            this.User.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2Panel CRUD_PaintWorkspace;
        private Guna.UI2.WinForms.Guna2TextBox SearchBox;
        private Guna.UI2.WinForms.Guna2Panel User;
        private Guna.UI2.WinForms.Guna2Button Note;
        private Guna.UI2.WinForms.Guna2Button TrashCan;
        private Guna.UI2.WinForms.Guna2Button Reminder;
        private Guna.UI2.WinForms.Guna2Button row1_left;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox UserAvatar;
        private System.Windows.Forms.Label Username;
        private Guna.UI2.WinForms.Guna2Button newPaint;
        private Guna.UI2.WinForms.Guna2Button row1_mid;
        private System.Windows.Forms.Label row1_mid_name;
        private System.Windows.Forms.Label row1_left_name;
    }
}