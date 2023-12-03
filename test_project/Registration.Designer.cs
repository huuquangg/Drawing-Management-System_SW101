namespace test_project
{
    partial class SignBtn
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
            this.SignUp = new System.Windows.Forms.Label();
            this.UserNameSU = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.PassWordSU = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassConfirm = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.BackColor = System.Drawing.SystemColors.Control;
            this.SignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.DarkOrange;
            this.SignUp.Location = new System.Drawing.Point(192, 23);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(141, 33);
            this.SignUp.TabIndex = 0;
            this.SignUp.Text = "SIGN UP";
            // 
            // UserNameSU
            // 
            this.UserNameSU.AutoSize = true;
            this.UserNameSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameSU.Location = new System.Drawing.Point(99, 70);
            this.UserNameSU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNameSU.Name = "UserNameSU";
            this.UserNameSU.Size = new System.Drawing.Size(87, 20);
            this.UserNameSU.TabIndex = 2;
            this.UserNameSU.Text = "User name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 92);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(319, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // PassWordSU
            // 
            this.PassWordSU.AutoSize = true;
            this.PassWordSU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordSU.Location = new System.Drawing.Point(99, 123);
            this.PassWordSU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassWordSU.Name = "PassWordSU";
            this.PassWordSU.Size = new System.Drawing.Size(78, 20);
            this.PassWordSU.TabIndex = 6;
            this.PassWordSU.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(103, 145);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(319, 20);
            this.txtPass.TabIndex = 7;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(99, 176);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(136, 20);
            this.ConfirmPassword.TabIndex = 8;
            this.ConfirmPassword.Text = "Confirm password";
            // 
            // txtPassConfirm
            // 
            this.txtPassConfirm.Location = new System.Drawing.Point(103, 198);
            this.txtPassConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassConfirm.Name = "txtPassConfirm";
            this.txtPassConfirm.Size = new System.Drawing.Size(319, 20);
            this.txtPassConfirm.TabIndex = 9;
            this.txtPassConfirm.UseSystemPasswordChar = true;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.Color.Orange;
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.Location = new System.Drawing.Point(103, 259);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(319, 29);
            this.SignUpBtn.TabIndex = 10;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // SignBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 366);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.txtPassConfirm);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.PassWordSU);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.UserNameSU);
            this.Controls.Add(this.SignUp);
            this.Name = "SignBtn";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.Label UserNameSU;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label PassWordSU;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox txtPassConfirm;
        private System.Windows.Forms.Button SignUpBtn;
    }
}