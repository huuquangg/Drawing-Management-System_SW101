using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_project
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();

        }
        //event Sign up account
        private void SignEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignBtn signBtn = new SignBtn();
            signBtn.ShowDialog();
        }
        //event log in account
        private void LogEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
