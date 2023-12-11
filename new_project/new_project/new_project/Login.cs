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

namespace GUI
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
    }
}
