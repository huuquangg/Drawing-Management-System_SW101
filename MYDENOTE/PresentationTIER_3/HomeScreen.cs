using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BUS;
using DTO;
using GUI;
using Guna.UI2.WinForms;
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
            // Open Paint with selected blueprint path
            try
            {
                this.Hide();
                string path = "";


                if (sender is Label)
                {
                    Label lbl = sender as Label;
                    Panel pnl = lbl.Parent as Panel;
                    Guna2Button btn = pnl.Controls["picPreviewBP"] as Guna2Button;
                    path = objBluePrintBUS.GetBluePrintPATHByName(lbl.Text, objUserBUS_HomeScreen.getUserId(Login.currUser));

                }
                else if (sender is Guna2Button)
                {
                    Guna2Button btn = sender as Guna2Button;
                    Panel pnl = btn.Parent as Panel;
                    Label lbl = pnl.Controls["NameBPItem"] as Label;
                    path = objBluePrintBUS.GetBluePrintPATHByName(lbl.Text, objUserBUS_HomeScreen.getUserId(Login.currUser));
                }
                else
                {
                    throw new Exception("Error!");
                }

                MyPaint.MyPaint paint = new MyPaint.MyPaint();
                paint.OpenMyPaint(path);
                paint.ShowDialog();


                isUpdated = false;
                isAvailable = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show();
            }
        }

        // Create C
        private void btnNewPage_Click(object sender, EventArgs e)
        {

            try
            {
                this.Hide();
                string setBluePrintName = Interaction.InputBox("New BluePrint Name", "", "", 250, 150);
                if (setBluePrintName != "")
                {
                    MessageBox.Show(setBluePrintName + " was created");
                    MyPaint.MyPaint paint = new MyPaint.MyPaint();
                    paint.ShowDialog();
                    string path = System.IO.Path.GetFullPath(paint.SavedFilePath);
                    BluePrint objBluePrint = new BluePrint(0, setBluePrintName, path, DateTime.Now, objUserBUS_HomeScreen.getUserId(Login.currUser));

                    objBluePrintBUS.AddBluePrint(objBluePrint);
                    isUpdated = false;
                    isAvailable = false;
                }
                else
                {
                    MessageBox.Show("Please enter a name for the blueprint!");
                }
            }
            catch (Exception ex)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                if (sender is Label)
                {
                    Label lbl = sender as Label;
                    Panel pnl = lbl.Parent as Panel;
                    Label lblName = pnl.Controls["NameBPItem"] as Label;
                    string name = lblName.Text;

                    if (MessageBox.Show("Are you sure you want to delete " + name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objBluePrintBUS.DeleteBluePrint(name, objUserBUS_HomeScreen.getUserId(Login.currUser));
                        MessageBox.Show(name + " was deleted");
                    }
                }
                else if (sender is Guna2Button)
                {
                    Guna2Button btn = sender as Guna2Button;
                    Panel pnl = btn.Parent as Panel;
                    Label lblName = pnl.Controls["NameBPItem"] as Label;
                    string name = lblName.Text;
                    if (MessageBox.Show("Are you sure you want to delete " + name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objBluePrintBUS.DeleteBluePrint(name, objUserBUS_HomeScreen.getUserId(Login.currUser));
                        MessageBox.Show(name + " was deleted");
                    }
                }
                else
                {
                    throw new Exception("Error!");
                }
                isUpdated = false;
                isAvailable = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show();
            }
        }




        private bool isAvailable = false;
        private bool isUpdated = false;
        private void FlowBPItem_Paint(object sender, PaintEventArgs e)
        {
            List<BluePrint> listBluePrint = objBluePrintBUS.GetListBluePrint(objUserBUS_HomeScreen.getUserId(Login.currUser));
            if (!isUpdated)
            {
                FlowBPItem.Controls.Clear();
                isUpdated = true;
                foreach (BluePrint bluePrintItem in listBluePrint)
                {
                    //// 
                    //// BluePrintItemContain
                    //// 
                    Panel BluePrintItemContain = new Panel();
                    BluePrintItemContain.Location = new Point(0, 0);
                    BluePrintItemContain.Margin = new Padding(0, 0, 30, 30);
                    BluePrintItemContain.Name = "BluePrintItemContain";
                    BluePrintItemContain.Size = new Size(120, 120);
                    BluePrintItemContain.BackColor = Color.Red;
                    BluePrintItemContain.BorderStyle = BorderStyle.FixedSingle;

                    //// 
                    //// NameBPItem
                    //// 
                    Label NameBPItem = new Label();
                    NameBPItem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    NameBPItem.Location = new Point(0, 0);
                    NameBPItem.Name = "NameBPItem";
                    NameBPItem.Size = new Size(BluePrintItemContain.Width, 17);
                    NameBPItem.BackColor = Color.White;
                    NameBPItem.TabIndex = 12;
                    NameBPItem.Text = Convert.ToString(objBluePrintBUS.GetBluePrintName(bluePrintItem));
                    NameBPItem.Dock = DockStyle.Bottom;
                    NameBPItem.TextAlign = ContentAlignment.MiddleCenter;
                    NameBPItem.Cursor = Cursors.Hand;
                    NameBPItem.Click += new EventHandler(btnOpenPaint_Click);

                    Guna2Button picPreviewBP = new Guna2Button();
                    // 
                    // picPreviewBP
                    // 
                    picPreviewBP.BackColor = SystemColors.AppWorkspace;
                    picPreviewBP.BorderThickness = 1;
                    picPreviewBP.CheckedState.Parent = picPreviewBP;
                    picPreviewBP.CustomImages.Parent = picPreviewBP;
                    picPreviewBP.Dock = DockStyle.Top;
                    picPreviewBP.FillColor = Color.White;
                    picPreviewBP.ForeColor = Color.Gray;
                    picPreviewBP.HoverState.Parent = picPreviewBP;
                    // import image from local path to resource file
                    picPreviewBP.Location = new Point(0, 0);
                    picPreviewBP.Size = new Size(BluePrintItemContain.Width, BluePrintItemContain.Height - NameBPItem.Height);
                    picPreviewBP.Image = Image.FromFile(objBluePrintBUS.GetBluePrintPath(bluePrintItem));
                    picPreviewBP.ImageSize = new Size(picPreviewBP.Width, picPreviewBP.Height);
                    picPreviewBP.Name = "picPreviewBP";
                    picPreviewBP.ShadowDecoration.Parent = picPreviewBP;
                    picPreviewBP.TabIndex = 2;
                    picPreviewBP.Cursor = Cursors.Hand;
                    picPreviewBP.Click += new EventHandler(btnOpenPaint_Click);

                    Label trashclick = new Label();
                    trashclick.BackColor = Color.FromArgb(255, 238, 217);
                    trashclick.BorderStyle = BorderStyle.FixedSingle;
                    trashclick.Image = Properties.Resources.icons8_trash_64;
                    trashclick.Location = new Point(BluePrintItemContain.Width - 20, 0);
                    trashclick.Name = "trashclick";
                    trashclick.Size = new Size(20, 20);
                    trashclick.Cursor = Cursors.Hand;
                    trashclick.BringToFront();
                    trashclick.Click += new EventHandler(btnDelete_Click);

                    BluePrintItemContain.Controls.Add(trashclick);
                    BluePrintItemContain.Controls.Add(picPreviewBP);
                    BluePrintItemContain.Controls.Add(NameBPItem);
                    FlowBPItem.Controls.Add(BluePrintItemContain);
                }
            }

            Guna2Button newPaint = new Guna2Button();

            newPaint.BackColor = SystemColors.AppWorkspace;
            newPaint.BorderThickness = 1;
            newPaint.CheckedState.Parent = newPaint;
            newPaint.CustomImages.Parent = newPaint;
            newPaint.FillColor = Color.White;
            newPaint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            newPaint.ForeColor = Color.Gray;
            newPaint.HoverState.Parent = newPaint;
            newPaint.Image = global::new_project.Properties.Resources.icons8_plus_50;
            newPaint.ImageSize = new Size(25, 25);
            newPaint.Location = new Point(0, 0);
            newPaint.Margin = new Padding(0, 0, 30, 30);
            newPaint.Name = "newPaint";
            newPaint.ShadowDecoration.Parent = newPaint;
            newPaint.Size = new Size(120, 120);
            newPaint.TabIndex = 3;
            newPaint.Cursor = Cursors.Hand;
            newPaint.Click += new EventHandler(btnNewPage_Click);

            if (!isAvailable)
            {
                FlowBPItem.Controls.Add(newPaint);
                isAvailable = true;
            }

        }

    }
}
