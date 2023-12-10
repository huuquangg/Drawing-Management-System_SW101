using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace new_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
        
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Description_Click(object sender, EventArgs e)
        {

        }

        private void DontHaveAccount_textLabel_Click(object sender, EventArgs e)
        {

        }

        private void MinimizeBox_button_Click(object sender, EventArgs e)
        {

        }

        private void Login_MainButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
