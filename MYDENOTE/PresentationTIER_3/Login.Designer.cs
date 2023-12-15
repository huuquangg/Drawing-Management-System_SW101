using System;

namespace GUI
{
    partial class Login
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LOGIN_FILLFORMNAME = new System.Windows.Forms.Label();
            this.Password_login_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.CreateAccount_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Login_BTN = new Guna.UI2.WinForms.Guna2GradientButton();
            this.RememberMe_ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Username_signup_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.RememberMe_txt = new System.Windows.Forms.Label();
            this.BrandLogo_Container = new Guna.UI2.WinForms.Guna2Panel();
            this.Deton_brandName = new System.Windows.Forms.Label();
            this.NoteIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.rePassword_signup_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_signup_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUP_btn = new Guna.UI2.WinForms.Guna2Button();
            this.CreateAcc_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Username_login_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AreadyHaveAnAcc_txt = new System.Windows.Forms.Label();
            this.TopNavigation = new Guna.UI2.WinForms.Guna2Panel();
            this.MinimizeBox_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.MaximizeBox_button = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Close_boxbtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.LogSignTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.Container_all = new System.Windows.Forms.TableLayoutPanel();
            this.Container_Form = new System.Windows.Forms.Panel();
            this.FormContainerSIGNUP = new System.Windows.Forms.Panel();
            this.FillingFormLOGIN_container = new System.Windows.Forms.Panel();
            this.OR = new System.Windows.Forms.Label();
            this.SIGNUP_FILLFORMNAME = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.BrandLogo_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteIcon)).BeginInit();
            this.TopNavigation.SuspendLayout();
            this.Container_all.SuspendLayout();
            this.Container_Form.SuspendLayout();
            this.FormContainerSIGNUP.SuspendLayout();
            this.FillingFormLOGIN_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // LOGIN_FILLFORMNAME
            // 
            this.LOGIN_FILLFORMNAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LOGIN_FILLFORMNAME.AutoSize = true;
            this.LOGIN_FILLFORMNAME.BackColor = System.Drawing.Color.Transparent;
            this.LogSignTransition.SetDecoration(this.LOGIN_FILLFORMNAME, Guna.UI2.AnimatorNS.DecorationType.None);
            this.LOGIN_FILLFORMNAME.Font = new System.Drawing.Font("Comic Sans MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_FILLFORMNAME.ForeColor = System.Drawing.Color.Black;
            this.LOGIN_FILLFORMNAME.Location = new System.Drawing.Point(163, 0);
            this.LOGIN_FILLFORMNAME.Name = "LOGIN_FILLFORMNAME";
            this.LOGIN_FILLFORMNAME.Size = new System.Drawing.Size(129, 45);
            this.LOGIN_FILLFORMNAME.TabIndex = 1;
            this.LOGIN_FILLFORMNAME.Text = "LOGIN";
            // 
            // Password_login_txt
            // 
            this.Password_login_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password_login_txt.Animated = true;
            this.Password_login_txt.AutoRoundedCorners = true;
            this.Password_login_txt.BackColor = System.Drawing.Color.Transparent;
            this.Password_login_txt.BorderColor = System.Drawing.Color.Black;
            this.Password_login_txt.BorderRadius = 16;
            this.Password_login_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogSignTransition.SetDecoration(this.Password_login_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Password_login_txt.DefaultText = "";
            this.Password_login_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_login_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_login_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_login_txt.DisabledState.Parent = this.Password_login_txt;
            this.Password_login_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_login_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Password_login_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_login_txt.FocusedState.Parent = this.Password_login_txt;
            this.Password_login_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_login_txt.ForeColor = System.Drawing.Color.Black;
            this.Password_login_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_login_txt.HoverState.Parent = this.Password_login_txt;
            this.Password_login_txt.IconLeft = global::new_project.Properties.Resources.padlock;
            this.Password_login_txt.IconLeftSize = new System.Drawing.Size(13, 13);
            this.Password_login_txt.Location = new System.Drawing.Point(93, 122);
            this.Password_login_txt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Password_login_txt.Name = "Password_login_txt";
            this.Password_login_txt.PasswordChar = '\0';
            this.Password_login_txt.PlaceholderForeColor = System.Drawing.Color.White;
            this.Password_login_txt.PlaceholderText = "Password";
            this.Password_login_txt.SelectedText = "";
            this.Password_login_txt.ShadowDecoration.Parent = this.Password_login_txt;
            this.Password_login_txt.Size = new System.Drawing.Size(260, 35);
            this.Password_login_txt.TabIndex = 3;
            this.Password_login_txt.UseSystemPasswordChar = true;
            // 
            // CreateAccount_btn
            // 
            this.CreateAccount_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateAccount_btn.BackColor = System.Drawing.Color.Transparent;
            this.CreateAccount_btn.CheckedState.Parent = this.CreateAccount_btn;
            this.CreateAccount_btn.CustomImages.Parent = this.CreateAccount_btn;
            this.LogSignTransition.SetDecoration(this.CreateAccount_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CreateAccount_btn.FillColor = System.Drawing.Color.Transparent;
            this.CreateAccount_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.CreateAccount_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.CreateAccount_btn.HoverState.Parent = this.CreateAccount_btn;
            this.CreateAccount_btn.Image = global::new_project.Properties.Resources.icons8_arrow_right_48;
            this.CreateAccount_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CreateAccount_btn.Location = new System.Drawing.Point(103, 252);
            this.CreateAccount_btn.Name = "CreateAccount_btn";
            this.CreateAccount_btn.ShadowDecoration.Parent = this.CreateAccount_btn;
            this.CreateAccount_btn.Size = new System.Drawing.Size(220, 35);
            this.CreateAccount_btn.TabIndex = 8;
            this.CreateAccount_btn.Text = "Create Account         ";
            this.CreateAccount_btn.Click += new System.EventHandler(this.LogCreateButton_Click);
            // 
            // Login_BTN
            // 
            this.Login_BTN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Login_BTN.Animated = true;
            this.Login_BTN.AutoRoundedCorners = true;
            this.Login_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Login_BTN.BorderRadius = 19;
            this.Login_BTN.CheckedState.Parent = this.Login_BTN;
            this.Login_BTN.CustomImages.Parent = this.Login_BTN;
            this.LogSignTransition.SetDecoration(this.Login_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Login_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.Login_BTN.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Login_BTN.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_BTN.ForeColor = System.Drawing.Color.White;
            this.Login_BTN.HoverState.Parent = this.Login_BTN;
            this.Login_BTN.Location = new System.Drawing.Point(122, 189);
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.ShadowDecoration.Parent = this.Login_BTN;
            this.Login_BTN.Size = new System.Drawing.Size(185, 40);
            this.Login_BTN.TabIndex = 4;
            this.Login_BTN.Text = "Login";
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
            // 
            // RememberMe_ToggleSwitch
            // 
            this.RememberMe_ToggleSwitch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RememberMe_ToggleSwitch.Animated = true;
            this.RememberMe_ToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.RememberMe_ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberMe_ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RememberMe_ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberMe_ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RememberMe_ToggleSwitch.CheckedState.Parent = this.RememberMe_ToggleSwitch;
            this.LogSignTransition.SetDecoration(this.RememberMe_ToggleSwitch, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RememberMe_ToggleSwitch.Location = new System.Drawing.Point(132, 163);
            this.RememberMe_ToggleSwitch.Name = "RememberMe_ToggleSwitch";
            this.RememberMe_ToggleSwitch.ShadowDecoration.Parent = this.RememberMe_ToggleSwitch;
            this.RememberMe_ToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.RememberMe_ToggleSwitch.TabIndex = 5;
            this.RememberMe_ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberMe_ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RememberMe_ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.RememberMe_ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.RememberMe_ToggleSwitch.UncheckedState.Parent = this.RememberMe_ToggleSwitch;
            // 
            // Username_signup_txt
            // 
            this.Username_signup_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username_signup_txt.Animated = true;
            this.Username_signup_txt.AutoRoundedCorners = true;
            this.Username_signup_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_signup_txt.BorderColor = System.Drawing.Color.Black;
            this.Username_signup_txt.BorderRadius = 16;
            this.Username_signup_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogSignTransition.SetDecoration(this.Username_signup_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Username_signup_txt.DefaultText = "";
            this.Username_signup_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_signup_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_signup_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_signup_txt.DisabledState.Parent = this.Username_signup_txt;
            this.Username_signup_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_signup_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Username_signup_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_signup_txt.FocusedState.Parent = this.Username_signup_txt;
            this.Username_signup_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_signup_txt.ForeColor = System.Drawing.Color.Black;
            this.Username_signup_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_signup_txt.HoverState.Parent = this.Username_signup_txt;
            this.Username_signup_txt.IconLeft = global::new_project.Properties.Resources.user;
            this.Username_signup_txt.IconLeftSize = new System.Drawing.Size(13, 13);
            this.Username_signup_txt.Location = new System.Drawing.Point(93, 68);
            this.Username_signup_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Username_signup_txt.Name = "Username_signup_txt";
            this.Username_signup_txt.PasswordChar = '\0';
            this.Username_signup_txt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Username_signup_txt.PlaceholderText = "Username";
            this.Username_signup_txt.SelectedText = "";
            this.Username_signup_txt.ShadowDecoration.Parent = this.Username_signup_txt;
            this.Username_signup_txt.Size = new System.Drawing.Size(260, 35);
            this.Username_signup_txt.TabIndex = 2;
            // 
            // RememberMe_txt
            // 
            this.RememberMe_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RememberMe_txt.AutoSize = true;
            this.RememberMe_txt.BackColor = System.Drawing.Color.Transparent;
            this.LogSignTransition.SetDecoration(this.RememberMe_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.RememberMe_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMe_txt.ForeColor = System.Drawing.Color.White;
            this.RememberMe_txt.Location = new System.Drawing.Point(173, 166);
            this.RememberMe_txt.Name = "RememberMe_txt";
            this.RememberMe_txt.Size = new System.Drawing.Size(97, 17);
            this.RememberMe_txt.TabIndex = 6;
            this.RememberMe_txt.Text = "Remember me";
            // 
            // BrandLogo_Container
            // 
            this.BrandLogo_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BrandLogo_Container.BackColor = System.Drawing.Color.Transparent;
            this.BrandLogo_Container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BrandLogo_Container.BorderColor = System.Drawing.Color.Black;
            this.BrandLogo_Container.Controls.Add(this.Deton_brandName);
            this.BrandLogo_Container.Controls.Add(this.NoteIcon);
            this.LogSignTransition.SetDecoration(this.BrandLogo_Container, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BrandLogo_Container.Location = new System.Drawing.Point(173, 11);
            this.BrandLogo_Container.Name = "BrandLogo_Container";
            this.BrandLogo_Container.ShadowDecoration.Parent = this.BrandLogo_Container;
            this.BrandLogo_Container.Size = new System.Drawing.Size(141, 128);
            this.BrandLogo_Container.TabIndex = 0;
            // 
            // Deton_brandName
            // 
            this.Deton_brandName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Deton_brandName.AutoSize = true;
            this.LogSignTransition.SetDecoration(this.Deton_brandName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Deton_brandName.Font = new System.Drawing.Font("Cooper Black", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deton_brandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.Deton_brandName.Location = new System.Drawing.Point(-4, 0);
            this.Deton_brandName.Name = "Deton_brandName";
            this.Deton_brandName.Size = new System.Drawing.Size(150, 40);
            this.Deton_brandName.TabIndex = 1;
            this.Deton_brandName.Text = "DETON";
            // 
            // NoteIcon
            // 
            this.NoteIcon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogSignTransition.SetDecoration(this.NoteIcon, Guna.UI2.AnimatorNS.DecorationType.None);
            this.NoteIcon.Image = global::new_project.Properties.Resources.notes;
            this.NoteIcon.Location = new System.Drawing.Point(32, 45);
            this.NoteIcon.Name = "NoteIcon";
            this.NoteIcon.ShadowDecoration.Parent = this.NoteIcon;
            this.NoteIcon.Size = new System.Drawing.Size(98, 80);
            this.NoteIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NoteIcon.TabIndex = 0;
            this.NoteIcon.TabStop = false;
            // 
            // rePassword_signup_txt
            // 
            this.rePassword_signup_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rePassword_signup_txt.Animated = true;
            this.rePassword_signup_txt.AutoRoundedCorners = true;
            this.rePassword_signup_txt.BackColor = System.Drawing.Color.Transparent;
            this.rePassword_signup_txt.BorderColor = System.Drawing.Color.Black;
            this.rePassword_signup_txt.BorderRadius = 16;
            this.rePassword_signup_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogSignTransition.SetDecoration(this.rePassword_signup_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.rePassword_signup_txt.DefaultText = "";
            this.rePassword_signup_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rePassword_signup_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rePassword_signup_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rePassword_signup_txt.DisabledState.Parent = this.rePassword_signup_txt;
            this.rePassword_signup_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rePassword_signup_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.rePassword_signup_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rePassword_signup_txt.FocusedState.Parent = this.rePassword_signup_txt;
            this.rePassword_signup_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassword_signup_txt.ForeColor = System.Drawing.Color.Black;
            this.rePassword_signup_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rePassword_signup_txt.HoverState.Parent = this.rePassword_signup_txt;
            this.rePassword_signup_txt.IconLeft = global::new_project.Properties.Resources.padlock;
            this.rePassword_signup_txt.IconLeftSize = new System.Drawing.Size(13, 13);
            this.rePassword_signup_txt.Location = new System.Drawing.Point(93, 148);
            this.rePassword_signup_txt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.rePassword_signup_txt.Name = "rePassword_signup_txt";
            this.rePassword_signup_txt.PasswordChar = '\0';
            this.rePassword_signup_txt.PlaceholderForeColor = System.Drawing.Color.White;
            this.rePassword_signup_txt.PlaceholderText = "Confirm password";
            this.rePassword_signup_txt.SelectedText = "";
            this.rePassword_signup_txt.ShadowDecoration.Parent = this.rePassword_signup_txt;
            this.rePassword_signup_txt.Size = new System.Drawing.Size(260, 35);
            this.rePassword_signup_txt.TabIndex = 9;
            this.rePassword_signup_txt.UseSystemPasswordChar = true;
            // 
            // Password_signup_txt
            // 
            this.Password_signup_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Password_signup_txt.Animated = true;
            this.Password_signup_txt.AutoRoundedCorners = true;
            this.Password_signup_txt.BackColor = System.Drawing.Color.Transparent;
            this.Password_signup_txt.BorderColor = System.Drawing.Color.Black;
            this.Password_signup_txt.BorderRadius = 16;
            this.Password_signup_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogSignTransition.SetDecoration(this.Password_signup_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Password_signup_txt.DefaultText = "";
            this.Password_signup_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_signup_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_signup_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_signup_txt.DisabledState.Parent = this.Password_signup_txt;
            this.Password_signup_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_signup_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Password_signup_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_signup_txt.FocusedState.Parent = this.Password_signup_txt;
            this.Password_signup_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_signup_txt.ForeColor = System.Drawing.Color.Black;
            this.Password_signup_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_signup_txt.HoverState.Parent = this.Password_signup_txt;
            this.Password_signup_txt.IconLeft = global::new_project.Properties.Resources.padlock;
            this.Password_signup_txt.IconLeftSize = new System.Drawing.Size(13, 13);
            this.Password_signup_txt.Location = new System.Drawing.Point(93, 108);
            this.Password_signup_txt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Password_signup_txt.Name = "Password_signup_txt";
            this.Password_signup_txt.PasswordChar = '\0';
            this.Password_signup_txt.PlaceholderForeColor = System.Drawing.Color.White;
            this.Password_signup_txt.PlaceholderText = "Password";
            this.Password_signup_txt.SelectedText = "";
            this.Password_signup_txt.ShadowDecoration.Parent = this.Password_signup_txt;
            this.Password_signup_txt.Size = new System.Drawing.Size(260, 35);
            this.Password_signup_txt.TabIndex = 3;
            this.Password_signup_txt.UseSystemPasswordChar = true;
            // 
            // SignUP_btn
            // 
            this.SignUP_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SignUP_btn.BackColor = System.Drawing.Color.Transparent;
            this.SignUP_btn.CheckedState.Parent = this.SignUP_btn;
            this.SignUP_btn.CustomImages.Parent = this.SignUP_btn;
            this.LogSignTransition.SetDecoration(this.SignUP_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SignUP_btn.FillColor = System.Drawing.Color.Transparent;
            this.SignUP_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUP_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.SignUP_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SignUP_btn.HoverState.Parent = this.SignUP_btn;
            this.SignUP_btn.Image = global::new_project.Properties.Resources.icons8_arrow_left_48;
            this.SignUP_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SignUP_btn.Location = new System.Drawing.Point(93, 250);
            this.SignUP_btn.Name = "SignUP_btn";
            this.SignUP_btn.ShadowDecoration.Parent = this.SignUP_btn;
            this.SignUP_btn.Size = new System.Drawing.Size(260, 35);
            this.SignUP_btn.TabIndex = 8;
            this.SignUP_btn.Text = "Log in";
            this.SignUP_btn.Click += new System.EventHandler(this.SignSignButton_Click);
            // 
            // CreateAcc_btn
            // 
            this.CreateAcc_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateAcc_btn.Animated = true;
            this.CreateAcc_btn.AutoRoundedCorners = true;
            this.CreateAcc_btn.BackColor = System.Drawing.Color.Transparent;
            this.CreateAcc_btn.BorderRadius = 16;
            this.CreateAcc_btn.CheckedState.Parent = this.CreateAcc_btn;
            this.CreateAcc_btn.CustomImages.Parent = this.CreateAcc_btn;
            this.LogSignTransition.SetDecoration(this.CreateAcc_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CreateAcc_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(167)))), ((int)(((byte)(255)))));
            this.CreateAcc_btn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.CreateAcc_btn.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAcc_btn.ForeColor = System.Drawing.Color.White;
            this.CreateAcc_btn.HoverState.Parent = this.CreateAcc_btn;
            this.CreateAcc_btn.Location = new System.Drawing.Point(102, 192);
            this.CreateAcc_btn.Name = "CreateAcc_btn";
            this.CreateAcc_btn.ShadowDecoration.Parent = this.CreateAcc_btn;
            this.CreateAcc_btn.Size = new System.Drawing.Size(240, 35);
            this.CreateAcc_btn.TabIndex = 4;
            this.CreateAcc_btn.Text = "Create Account";
            this.CreateAcc_btn.Click += new System.EventHandler(this.CreateAcc_btn_Click);
            // 
            // Username_login_txt
            // 
            this.Username_login_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username_login_txt.Animated = true;
            this.Username_login_txt.AutoRoundedCorners = true;
            this.Username_login_txt.BackColor = System.Drawing.Color.Transparent;
            this.Username_login_txt.BorderColor = System.Drawing.Color.Black;
            this.Username_login_txt.BorderRadius = 16;
            this.Username_login_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LogSignTransition.SetDecoration(this.Username_login_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Username_login_txt.DefaultText = "";
            this.Username_login_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_login_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_login_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_login_txt.DisabledState.Parent = this.Username_login_txt;
            this.Username_login_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_login_txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Username_login_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_login_txt.FocusedState.Parent = this.Username_login_txt;
            this.Username_login_txt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_login_txt.ForeColor = System.Drawing.Color.Black;
            this.Username_login_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_login_txt.HoverState.Parent = this.Username_login_txt;
            this.Username_login_txt.IconLeft = global::new_project.Properties.Resources.user;
            this.Username_login_txt.IconLeftSize = new System.Drawing.Size(13, 13);
            this.Username_login_txt.Location = new System.Drawing.Point(93, 77);
            this.Username_login_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Username_login_txt.Name = "Username_login_txt";
            this.Username_login_txt.PasswordChar = '\0';
            this.Username_login_txt.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Username_login_txt.PlaceholderText = "Username";
            this.Username_login_txt.SelectedText = "";
            this.Username_login_txt.ShadowDecoration.Parent = this.Username_login_txt;
            this.Username_login_txt.Size = new System.Drawing.Size(260, 35);
            this.Username_login_txt.TabIndex = 2;
            // 
            // AreadyHaveAnAcc_txt
            // 
            this.AreadyHaveAnAcc_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AreadyHaveAnAcc_txt.AutoSize = true;
            this.LogSignTransition.SetDecoration(this.AreadyHaveAnAcc_txt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AreadyHaveAnAcc_txt.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreadyHaveAnAcc_txt.Location = new System.Drawing.Point(141, 230);
            this.AreadyHaveAnAcc_txt.Name = "AreadyHaveAnAcc_txt";
            this.AreadyHaveAnAcc_txt.Size = new System.Drawing.Size(164, 17);
            this.AreadyHaveAnAcc_txt.TabIndex = 7;
            this.AreadyHaveAnAcc_txt.Text = " Already have an account ?";
            // 
            // TopNavigation
            // 
            this.TopNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.TopNavigation.Controls.Add(this.MinimizeBox_button);
            this.TopNavigation.Controls.Add(this.MaximizeBox_button);
            this.TopNavigation.Controls.Add(this.Close_boxbtn);
            this.LogSignTransition.SetDecoration(this.TopNavigation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TopNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopNavigation.Location = new System.Drawing.Point(0, 0);
            this.TopNavigation.Name = "TopNavigation";
            this.TopNavigation.ShadowDecoration.Parent = this.TopNavigation;
            this.TopNavigation.Size = new System.Drawing.Size(935, 45);
            this.TopNavigation.TabIndex = 1;
            // 
            // MinimizeBox_button
            // 
            this.MinimizeBox_button.BackColor = System.Drawing.Color.Black;
            this.MinimizeBox_button.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.LogSignTransition.SetDecoration(this.MinimizeBox_button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MinimizeBox_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeBox_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.MinimizeBox_button.HoverState.Parent = this.MinimizeBox_button;
            this.MinimizeBox_button.IconColor = System.Drawing.Color.Black;
            this.MinimizeBox_button.Location = new System.Drawing.Point(737, 0);
            this.MinimizeBox_button.Name = "MinimizeBox_button";
            this.MinimizeBox_button.ShadowDecoration.Parent = this.MinimizeBox_button;
            this.MinimizeBox_button.Size = new System.Drawing.Size(66, 45);
            this.MinimizeBox_button.TabIndex = 2;
            // 
            // MaximizeBox_button
            // 
            this.MaximizeBox_button.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.LogSignTransition.SetDecoration(this.MaximizeBox_button, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MaximizeBox_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeBox_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.MaximizeBox_button.HoverState.Parent = this.MaximizeBox_button;
            this.MaximizeBox_button.IconColor = System.Drawing.Color.Black;
            this.MaximizeBox_button.Location = new System.Drawing.Point(803, 0);
            this.MaximizeBox_button.Name = "MaximizeBox_button";
            this.MaximizeBox_button.ShadowDecoration.Parent = this.MaximizeBox_button;
            this.MaximizeBox_button.Size = new System.Drawing.Size(66, 45);
            this.MaximizeBox_button.TabIndex = 1;
            // 
            // Close_boxbtn
            // 
            this.LogSignTransition.SetDecoration(this.Close_boxbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Close_boxbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_boxbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.Close_boxbtn.HoverState.Parent = this.Close_boxbtn;
            this.Close_boxbtn.IconColor = System.Drawing.Color.Black;
            this.Close_boxbtn.Location = new System.Drawing.Point(869, 0);
            this.Close_boxbtn.Name = "Close_boxbtn";
            this.Close_boxbtn.ShadowDecoration.Parent = this.Close_boxbtn;
            this.Close_boxbtn.Size = new System.Drawing.Size(66, 45);
            this.Close_boxbtn.TabIndex = 3;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.TopNavigation;
            // 
            // LogSignTransition
            // 
            this.LogSignTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.LogSignTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.LogSignTransition.DefaultAnimation = animation1;
            // 
            // Container_all
            // 
            this.Container_all.BackColor = System.Drawing.Color.Transparent;
            this.Container_all.ColumnCount = 3;
            this.Container_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.Container_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.38095F));
            this.Container_all.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.Container_all.Controls.Add(this.Container_Form, 1, 1);
            this.Container_all.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.LogSignTransition.SetDecoration(this.Container_all, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Container_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_all.Location = new System.Drawing.Point(0, 0);
            this.Container_all.Name = "Container_all";
            this.Container_all.RowCount = 3;
            this.Container_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Container_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.Container_all.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.Container_all.Size = new System.Drawing.Size(935, 623);
            this.Container_all.TabIndex = 3;
            // 
            // Container_Form
            // 
            this.Container_Form.BackColor = System.Drawing.Color.Transparent;
            this.Container_Form.Controls.Add(this.FillingFormLOGIN_container);
            this.Container_Form.Controls.Add(this.FormContainerSIGNUP);
            this.Container_Form.Controls.Add(this.BrandLogo_Container);
            this.LogSignTransition.SetDecoration(this.Container_Form, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Container_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container_Form.ForeColor = System.Drawing.Color.Transparent;
            this.Container_Form.Location = new System.Drawing.Point(225, 127);
            this.Container_Form.Name = "Container_Form";
            this.Container_Form.Size = new System.Drawing.Size(483, 430);
            this.Container_Form.TabIndex = 5;
            // 
            // FormContainerSIGNUP
            // 
            this.FormContainerSIGNUP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormContainerSIGNUP.BackColor = System.Drawing.Color.Transparent;
            this.FormContainerSIGNUP.Controls.Add(this.SIGNUP_FILLFORMNAME);
            this.FormContainerSIGNUP.Controls.Add(this.Username_signup_txt);
            this.FormContainerSIGNUP.Controls.Add(this.SignUP_btn);
            this.FormContainerSIGNUP.Controls.Add(this.AreadyHaveAnAcc_txt);
            this.FormContainerSIGNUP.Controls.Add(this.rePassword_signup_txt);
            this.FormContainerSIGNUP.Controls.Add(this.CreateAcc_btn);
            this.FormContainerSIGNUP.Controls.Add(this.Password_signup_txt);
            this.LogSignTransition.SetDecoration(this.FormContainerSIGNUP, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormContainerSIGNUP.ForeColor = System.Drawing.Color.Transparent;
            this.FormContainerSIGNUP.Location = new System.Drawing.Point(29, 142);
            this.FormContainerSIGNUP.Name = "FormContainerSIGNUP";
            this.FormContainerSIGNUP.Size = new System.Drawing.Size(430, 335);
            this.FormContainerSIGNUP.TabIndex = 4;
            // 
            // FillingFormLOGIN_container
            // 
            this.FillingFormLOGIN_container.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FillingFormLOGIN_container.BackColor = System.Drawing.Color.Transparent;
            this.FillingFormLOGIN_container.Controls.Add(this.OR);
            this.FillingFormLOGIN_container.Controls.Add(this.CreateAccount_btn);
            this.FillingFormLOGIN_container.Controls.Add(this.LOGIN_FILLFORMNAME);
            this.FillingFormLOGIN_container.Controls.Add(this.RememberMe_txt);
            this.FillingFormLOGIN_container.Controls.Add(this.RememberMe_ToggleSwitch);
            this.FillingFormLOGIN_container.Controls.Add(this.Username_login_txt);
            this.FillingFormLOGIN_container.Controls.Add(this.Login_BTN);
            this.FillingFormLOGIN_container.Controls.Add(this.Password_login_txt);
            this.LogSignTransition.SetDecoration(this.FillingFormLOGIN_container, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FillingFormLOGIN_container.ForeColor = System.Drawing.Color.Transparent;
            this.FillingFormLOGIN_container.Location = new System.Drawing.Point(29, 142);
            this.FillingFormLOGIN_container.Name = "FillingFormLOGIN_container";
            this.FillingFormLOGIN_container.Size = new System.Drawing.Size(430, 340);
            this.FillingFormLOGIN_container.TabIndex = 2;
            // 
            // OR
            // 
            this.OR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OR.AutoSize = true;
            this.OR.BackColor = System.Drawing.Color.Transparent;
            this.LogSignTransition.SetDecoration(this.OR, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OR.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OR.ForeColor = System.Drawing.Color.White;
            this.OR.Location = new System.Drawing.Point(206, 232);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(23, 17);
            this.OR.TabIndex = 7;
            this.OR.Text = "Or";
            this.OR.Click += new System.EventHandler(this.DontHaveAccount_textLabel_Click);
            // 
            // SIGNUP_FILLFORMNAME
            // 
            this.SIGNUP_FILLFORMNAME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SIGNUP_FILLFORMNAME.AutoSize = true;
            this.SIGNUP_FILLFORMNAME.BackColor = System.Drawing.Color.Transparent;
            this.LogSignTransition.SetDecoration(this.SIGNUP_FILLFORMNAME, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SIGNUP_FILLFORMNAME.Font = new System.Drawing.Font("Comic Sans MS", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIGNUP_FILLFORMNAME.ForeColor = System.Drawing.Color.Black;
            this.SIGNUP_FILLFORMNAME.Location = new System.Drawing.Point(149, 0);
            this.SIGNUP_FILLFORMNAME.Name = "SIGNUP_FILLFORMNAME";
            this.SIGNUP_FILLFORMNAME.Size = new System.Drawing.Size(162, 45);
            this.SIGNUP_FILLFORMNAME.TabIndex = 10;
            this.SIGNUP_FILLFORMNAME.Text = "SIGN UP";
            // 
            // flowLayoutPanel1
            // 
            this.LogSignTransition.SetDecoration(this.flowLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(225, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.guna2ColorTransition1.EndColor = System.Drawing.Color.Yellow;
            this.guna2ColorTransition1.StartColor = System.Drawing.Color.IndianRed;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(217)))));
            this.BackgroundImage = global::new_project.Properties.Resources.f8da0698df90bb808dac336a301d1975;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(935, 623);
            this.Controls.Add(this.TopNavigation);
            this.Controls.Add(this.Container_all);
            this.LogSignTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BrandLogo_Container.ResumeLayout(false);
            this.BrandLogo_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoteIcon)).EndInit();
            this.TopNavigation.ResumeLayout(false);
            this.Container_all.ResumeLayout(false);
            this.Container_Form.ResumeLayout(false);
            this.FormContainerSIGNUP.ResumeLayout(false);
            this.FormContainerSIGNUP.PerformLayout();
            this.FillingFormLOGIN_container.ResumeLayout(false);
            this.FillingFormLOGIN_container.PerformLayout();
            this.ResumeLayout(false);

        }

        private void DontHaveAccount_textLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox Username_login_txt;
        private Guna.UI2.WinForms.Guna2TextBox Password_signup_txt;
        private Guna.UI2.WinForms.Guna2GradientButton CreateAcc_btn;
        private Guna.UI2.WinForms.Guna2ToggleSwitch RememberMe_ToggleSwitch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AreadyHaveAnAcc_txt;
        private Guna.UI2.WinForms.Guna2Button SignUP_btn;
        private Guna.UI2.WinForms.Guna2Panel TopNavigation;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label LOGIN_FILLFORMNAME;
        private Guna.UI2.WinForms.Guna2TextBox Password_login_txt;
        private Guna.UI2.WinForms.Guna2Button CreateAccount_btn;
        private Guna.UI2.WinForms.Guna2GradientButton Login_BTN;
        private Guna.UI2.WinForms.Guna2TextBox Username_signup_txt;
        private System.Windows.Forms.Label RememberMe_txt;
        private Guna.UI2.WinForms.Guna2TextBox rePassword_signup_txt;
        private Guna.UI2.WinForms.Guna2PictureBox NoteIcon;
        private Guna.UI2.WinForms.Guna2Panel BrandLogo_Container;
        private System.Windows.Forms.Label Deton_brandName;
        private Guna.UI2.WinForms.Guna2Transition LogSignTransition;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private System.Windows.Forms.TableLayoutPanel Container_all;
        private System.Windows.Forms.Label OR;
        private System.Windows.Forms.Panel FormContainerSIGNUP;
        private System.Windows.Forms.Panel Container_Form;
        private System.Windows.Forms.Panel FillingFormLOGIN_container;
        private Guna.UI2.WinForms.Guna2ControlBox MinimizeBox_button;
        private Guna.UI2.WinForms.Guna2ControlBox MaximizeBox_button;
        private Guna.UI2.WinForms.Guna2ControlBox Close_boxbtn;
        private System.Windows.Forms.Label SIGNUP_FILLFORMNAME;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

