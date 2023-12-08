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
            LogUserLoginPanel.Visible = false;
            LogSignTransition.ShowSync(LogUserLoginPanel);
        }
        private void LogCreateButton_Click(object sender, EventArgs e)
        {
            LogUserLoginPanel.Visible = true;
            LogSignTransition.HideSync(LogUserLoginPanel);
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
    }
}
