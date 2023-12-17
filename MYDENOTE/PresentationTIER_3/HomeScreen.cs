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
using GUI;
using Microsoft.VisualBasic;
using MyPaint;
namespace new_project
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        BluePrintBUS objBluePrintBUS = new BluePrintBUS();
        UserBUS objUserBUS_HomeScreen = new UserBUS();
        private void btnOpenPaint_Click(object sender, EventArgs e)
        {

        }


        private void btnNewPage_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();

                string setBluePrintName = Interaction.InputBox("New BluePrint Name",
                                                                "", "", 250, 150);
                if (setBluePrintName != "")
                {
                    MessageBox.Show("New BluePrint Name: " + setBluePrintName);
                }

                MyPaint.MyPaint paint = new MyPaint.MyPaint();
                paint.ShowDialog();

                string path = System.IO.Path.GetFullPath(paint.SavedFilePath);
                BluePrint objBluePrint = new BluePrint(0, setBluePrintName, path, DateTime.Now, objUserBUS_HomeScreen.getUserId(Login.currUser));

                objBluePrintBUS.AddBluePrint(objBluePrint);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_PaintWorkspace_Paint(object sender, PaintEventArgs e)
        {
            // Get list of blueprints of current user
            List<BluePrint> listBluePrint = objBluePrintBUS.GetListBluePrint(objUserBUS_HomeScreen.getUserId(Login.currUser));
            
            
        }
    }
}
