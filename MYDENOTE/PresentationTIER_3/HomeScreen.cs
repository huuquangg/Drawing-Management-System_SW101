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
        public HomeScreen() // constructor of HomeScreen
        {
            InitializeComponent(); // initialize the components of the HomeScreen
        }

        BluePrintBUS objBluePrintBUS = new BluePrintBUS(); // create a new BluePrintBUS object to access the BUS layer
        UserBUS objUserBUS_HomeScreen = new UserBUS(); // create a new UserBUS object to access the BUS layer

        // Create C in CRUD
        private void btnNewPage_Click(object sender, EventArgs e) // Button which allows the user to create a new blueprint
        {

            try // event handler for the add new blueprint button
            {
                string setBluePrintName = Interaction.InputBox("New BluePrint Name", "", "", 250, 150);
                if (setBluePrintName != "")
                {
                    MessageBox.Show(setBluePrintName + " was created"); // show a message box to notify the user that the blueprint was created

                    this.Hide();
                    MyPaint.MyPaint paint = new MyPaint.MyPaint(); // create a new MyPaint object
                    paint.ShowDialog(); // show the MyPaint form

                    // user are drawing a blueprint


                    // when done drawing, save the blueprint
                    string path = Path.GetFullPath(paint.SavedFilePath); // get the path of the blueprint
                    if (path == "") { throw new Exception("Error!"); } // if the path is empty, throw an exception (user did not save the blueprint)

                    // create a new blueprint object and add it to the database
                    BluePrint objBluePrint = new BluePrint(0, setBluePrintName, path, DateTime.Now, objUserBUS_HomeScreen.getUserId(Login.currUser));
                    objBluePrintBUS.AddBluePrint(objBluePrint);

                    isUpdated = false; // set condition to reload flowlayout
                    isAvailable = false; // set condition to reload flowlayout
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

        // Read R
        private bool isAvailable = false;
        private bool isUpdated = false;
        private void FlowBPItem_Paint(object sender, PaintEventArgs e) // load all the blueprints of the current user
        {
            // Get list of blueprints of the current user
            List<BluePrint> listBluePrint = objBluePrintBUS.GetListBluePrint(objUserBUS_HomeScreen.getUserId(Login.currUser));
            int PanelDefaultSize = 120;

            if (!isUpdated) // if the flowlayout is not updated , condition to reload flowlayout
            {
                FlowBPItem.Controls.Clear();
                isUpdated = true;


                // check the HomeScreen is full size or not
                if (this.Width > 1000)
                {
                    //MessageBox.Show("Maximized");
                    PanelDefaultSize = 220;
                }

                foreach (BluePrint bluePrintItem in listBluePrint) // add all the blueprints to the flowlayout
                {
                    //// 
                    //// BluePrintItemContain
                    //// 
                    Panel BluePrintItemContain = new Panel();
                    BluePrintItemContain.Location = new Point(0, 0);
                    BluePrintItemContain.Margin = new Padding(0, 0, 30, 30);
                    BluePrintItemContain.Name = "BluePrintItemContain";
                    BluePrintItemContain.Size = new Size(PanelDefaultSize, PanelDefaultSize);
                    BluePrintItemContain.BackColor = Color.Red;
                    BluePrintItemContain.BorderStyle = BorderStyle.FixedSingle;

                    //// 
                    //// NameBPItem
                    //// 
                    Label NameBPItem = new Label();
                    NameBPItem.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    NameBPItem.Location = new Point(0, 0);
                    NameBPItem.Name = "NameBPItem";
                    NameBPItem.Size = new Size(BluePrintItemContain.Width, BluePrintItemContain.Height / 10);
                    NameBPItem.BackColor = Color.White;
                    NameBPItem.TabIndex = 12;
                    NameBPItem.Text = Convert.ToString(objBluePrintBUS.GetBluePrintName(bluePrintItem));
                    NameBPItem.Dock = DockStyle.Bottom;
                    NameBPItem.TextAlign = ContentAlignment.MiddleCenter;
                    NameBPItem.Cursor = Cursors.Hand;
                    NameBPItem.Click += new EventHandler(btnOpenPaint_Click);

                    // 
                    // picPreviewBP
                    // 
                    Guna2Button picPreviewBP = new Guna2Button();
                    picPreviewBP.BackColor = SystemColors.AppWorkspace;
                    picPreviewBP.BorderThickness = 1;
                    picPreviewBP.CheckedState.Parent = picPreviewBP;
                    picPreviewBP.CustomImages.Parent = picPreviewBP;
                    picPreviewBP.Dock = DockStyle.Top;
                    picPreviewBP.FillColor = Color.White;
                    picPreviewBP.ForeColor = Color.Gray;
                    picPreviewBP.HoverState.Parent = picPreviewBP;
                    picPreviewBP.Location = new Point(0, 0);
                    picPreviewBP.Size = new Size(BluePrintItemContain.Width, BluePrintItemContain.Height - NameBPItem.Height);
                    picPreviewBP.Image = Image.FromFile(objBluePrintBUS.GetBluePrintPath(bluePrintItem));
                    picPreviewBP.ImageSize = new Size(picPreviewBP.Width, picPreviewBP.Height);
                    picPreviewBP.Name = "picPreviewBP";
                    picPreviewBP.ShadowDecoration.Parent = picPreviewBP;
                    picPreviewBP.TabIndex = 2;
                    picPreviewBP.Cursor = Cursors.Hand;
                    picPreviewBP.Click += new EventHandler(btnOpenPaint_Click);

                    //
                    // trashclick
                    //
                    Label trashclick = new Label();
                    trashclick.BackColor = Color.FromArgb(255, 238, 217);
                    trashclick.BorderStyle = BorderStyle.FixedSingle;
                    trashclick.Image = Properties.Resources.remove24px;
                    trashclick.Location = new Point(BluePrintItemContain.Width - 20, 0);
                    trashclick.Name = "trashclick";
                    trashclick.Size = new Size(20, 20);
                    trashclick.Cursor = Cursors.Hand;
                    trashclick.BringToFront();
                    trashclick.BorderStyle = BorderStyle.None;
                    trashclick.Click += new EventHandler(btnDelete_Click);

                    BluePrintItemContain.Controls.Add(trashclick);
                    BluePrintItemContain.Controls.Add(picPreviewBP);
                    BluePrintItemContain.Controls.Add(NameBPItem);
                    FlowBPItem.Controls.Add(BluePrintItemContain);
                }
            }

            // The add new blueprint button
            Guna2Button newPaint = new Guna2Button();
            newPaint.BackColor = SystemColors.AppWorkspace;
            newPaint.BorderThickness = 1;
            newPaint.CheckedState.Parent = newPaint;
            newPaint.CustomImages.Parent = newPaint;
            newPaint.FillColor = Color.White;
            newPaint.ForeColor = Color.Gray;
            newPaint.HoverState.Parent = newPaint;
            newPaint.Image = Properties.Resources.icons8_plus_50;
            newPaint.ImageSize = new Size(25, 25);
            newPaint.Location = new Point(0, 0);
            newPaint.Margin = new Padding(0, 0, 30, 30);
            newPaint.Name = "newPaint";
            newPaint.ShadowDecoration.Parent = newPaint;
            newPaint.Size = new Size(PanelDefaultSize, PanelDefaultSize);
            newPaint.TabIndex = 3;
            newPaint.Cursor = Cursors.Hand;
            newPaint.Click += new EventHandler(btnNewPage_Click);

            if (!isAvailable) // set condition to reload flowlayout
            {
                FlowBPItem.Controls.Add(newPaint);
                isAvailable = true;
            }

        }

        // Update U in CRUD
        private void btnOpenPaint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide(); // hide the HomeScreen
                string path = ""; // initialize the path of the blueprint

                if (sender is Label) // if user click on the blueprint name (asbc)
                {
                    // get the path of the blueprint
                    Label lbl = sender as Label;
                    Panel pnl = lbl.Parent as Panel;
                    Guna2Button btn = pnl.Controls["picPreviewBP"] as Guna2Button;
                    path = objBluePrintBUS.GetBluePrintPATHByName(lbl.Text, objUserBUS_HomeScreen.getUserId(Login.currUser));
                }
                else if (sender is Guna2Button) // if user click on the blueprint image 
                {
                    // get the path of the blueprint
                    Guna2Button btn = sender as Guna2Button;
                    Panel pnl = btn.Parent as Panel;
                    Label lbl = pnl.Controls["NameBPItem"] as Label;
                    path = objBluePrintBUS.GetBluePrintPATHByName(lbl.Text, objUserBUS_HomeScreen.getUserId(Login.currUser));
                }
                else
                {
                    // exception
                    throw new Exception("Error!");
                }

                MyPaint.MyPaint paint = new MyPaint.MyPaint(); // create a new MyPaint object
                paint.LoadMyPaintwithThePATH(path); // load the blueprint to the MyPaint form
                paint.ShowDialog(); // show the MyPaint form

                isUpdated = false; // set condition to reload flowlayout
                isAvailable = false; // set condition to reload flowlayout
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


        // Delete D
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sender is Label) // if user click on trash icon
                {
                    Label lbl = sender as Label;
                    Panel pnl = lbl.Parent as Panel;
                    Label lblName = pnl.Controls["NameBPItem"] as Label;
                    string name = lblName.Text;
                    // dialog confirm
                    if (MessageBox.Show("Are you sure you want to delete " + name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objBluePrintBUS.DeleteBluePrint(name, objUserBUS_HomeScreen.getUserId(Login.currUser));
                        MessageBox.Show(name + " was deleted");
                    }
                }
                else if (sender is Guna2Button) // if user click on blueprint image
                {
                    Guna2Button btn = sender as Guna2Button;
                    Panel pnl = btn.Parent as Panel;
                    Label lblName = pnl.Controls["NameBPItem"] as Label;
                    string name = lblName.Text;

                    // Dialog confirm
                    if (MessageBox.Show("Are you sure you want to delete " + name + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        objBluePrintBUS.DeleteBluePrint(name, objUserBUS_HomeScreen.getUserId(Login.currUser));
                        MessageBox.Show(name + " was deleted");
                        // reload flowlayout
                    }
                }
                else
                {
                    throw new Exception("Error!");
                }
                isUpdated = false; // set condition to reload flowlayout
                isAvailable = false; // set condition to reload flowlayout
                // reload flowlayout or HomeScreen
                if (objBluePrintBUS != null) { this.FlowBPItem_Paint(sender, null); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show(); // show HomeScreen
            }
        }


        // Logout
        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Close(); // close HomeScreen

            // delete all blueprint in flowlayout
            isUpdated = false;
            isAvailable = false;
            Login.currUser = null; // set current user to null (disconnect current user)
            objBluePrintBUS = null; // set objBluePrintBUS to null
            objUserBUS_HomeScreen = null; // set objUserBUS_HomeScreen to null

            // show Login form
            Login login = new Login();
            login.ShowDialog();
        }

        // Close the application
        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Zoom_btn_Click(object sender, EventArgs e)
        {
            isAvailable = false;
            isUpdated = false;
        }

        private void Username_Paint(object sender, PaintEventArgs e)
        {
            this.Username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(49, 69);
            this.Username.Size = new System.Drawing.Size(0, 28);
            this.Username.TabIndex = 10;
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Username.Text = objUserBUS_HomeScreen.getUsername(Login.currUser);
        }
    }
}
