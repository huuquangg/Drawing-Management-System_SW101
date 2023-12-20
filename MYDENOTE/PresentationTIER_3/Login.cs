using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Guna.UI2.WinForms;
using BCrypt;
using new_project;

namespace GUI
{
    public partial class Login : Form
    {
        public static User currUser;
        UserBUS objUserBUS = new UserBUS();

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            Container_Form.BackColor = Color.FromArgb(30, 0, 0, 0);
        }
        private void SignSignButton_Click(object sender, EventArgs e)
        {
            FillingFormLOGIN_container.Visible = false;
            LogSignTransition.ShowSync(FillingFormLOGIN_container);
        }
        private void LogCreateButton_Click(object sender, EventArgs e)
        {
            FillingFormLOGIN_container.Visible = true;
            LogSignTransition.HideSync(FillingFormLOGIN_container);
        }

        private void Login_BTN_Click(object sender, EventArgs e)
        {
            if (Username_login_txt.Text == "" || Password_login_txt.Text == "")
            {
                MessageBox.Show("Please fill in all the fields!");
            }
            else
            {
                User objUSER = new User(Username_login_txt.Text, Password_login_txt.Text);
                if (objUserBUS.checkLogin(objUSER))
                {
                    MessageBox.Show("Login successful!");
                    currUser = objUSER;
                    this.Hide();
                    new HomeScreen().Show();
                }
                else
                {
                    MessageBox.Show("Login failed!");
                }
            }

        }

        private void CreateAcc_btn_Click(object sender, EventArgs e)
        {
            if (Username_signup_txt.Text == "" || Password_signup_txt.Text == "")
            {
                if (Username_signup_txt.Text == "")
                {
                    Username_signup_txt.BorderColor = Color.Red;
                }
                if (Password_signup_txt.Text == "")
                {
                    Password_signup_txt.BorderColor = Color.Red;
                }
                if (Password_signup_txt.Text != rePassword_signup_txt.Text)
                {
                    MessageBox.Show("Passwords do not match!");
                    rePassword_signup_txt.BorderColor = Color.Red;
                }

                MessageBox.Show("Please fill in all the fields!");
            }
            else
            {
                try
                {
                    // Generate a salt for bcrypt encryption
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    // Hash the password with bcrypt
                    string hashPassword = BCrypt.Net.BCrypt.HashPassword(Password_signup_txt.Text, salt);

                    User objUSERadded = new User(Username_signup_txt.Text, hashPassword);
                    objUserBUS.AddUser(objUSERadded);
                    MessageBox.Show("Account created successfully!");
                    FillingFormLOGIN_container.Visible = false;
                    LogSignTransition.ShowSync(FillingFormLOGIN_container);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }


        private void Container_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_boxbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
}
