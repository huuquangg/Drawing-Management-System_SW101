using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPaint;
namespace new_project
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnOpenPaint_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paint paint = new Paint();
            paint.ShowDialog();
        }

        private void btnNewPage_Click(object sender, EventArgs e)
        {
          
        }
    }
}
