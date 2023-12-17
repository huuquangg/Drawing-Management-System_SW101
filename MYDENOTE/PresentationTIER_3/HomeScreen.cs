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
            MyPaint.MyPaint paint = new MyPaint.MyPaint();
            paint.ShowDialog();
        }

        private void btnNewPage_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
