namespace MyPaint
{
    partial class MyPaint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaint));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuOption = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawTool = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFlip180V = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRotate90degL = new System.Windows.Forms.Button();
            this.btnRotate90degR = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.btnFreeDraw = new System.Windows.Forms.Button();
            this.btnFlip180H = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Draw_workspace = new System.Windows.Forms.Panel();
            this.Draw_area = new System.Windows.Forms.PictureBox();
            this.MenuOption.SuspendLayout();
            this.DrawTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.Draw_workspace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Draw_area)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Upload";
            // 
            // MenuOption
            // 
            this.MenuOption.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.helpToolStripMenuItem});
            this.MenuOption.Location = new System.Drawing.Point(0, 0);
            this.MenuOption.Name = "MenuOption";
            this.MenuOption.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuOption.Size = new System.Drawing.Size(1179, 30);
            this.MenuOption.TabIndex = 3;
            this.MenuOption.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(46, 26);
            this.File.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.newProjectToolStripMenuItem.Text = "New Project";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.NewProjectToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.helpToolStripMenuItem.Text = "Instructions and Credits";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // DrawTool
            // 
            this.DrawTool.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DrawTool.Controls.Add(this.label9);
            this.DrawTool.Controls.Add(this.label8);
            this.DrawTool.Controls.Add(this.label7);
            this.DrawTool.Controls.Add(this.label6);
            this.DrawTool.Controls.Add(this.label5);
            this.DrawTool.Controls.Add(this.label4);
            this.DrawTool.Controls.Add(this.label3);
            this.DrawTool.Controls.Add(this.label2);
            this.DrawTool.Controls.Add(this.label1);
            this.DrawTool.Controls.Add(this.btnFlip180V);
            this.DrawTool.Controls.Add(this.btnZoomOut);
            this.DrawTool.Controls.Add(this.btnZoomIn);
            this.DrawTool.Controls.Add(this.btnCrop);
            this.DrawTool.Controls.Add(this.trackBar1);
            this.DrawTool.Controls.Add(this.btnErase);
            this.DrawTool.Controls.Add(this.btnRectangle);
            this.DrawTool.Controls.Add(this.btnEllipse);
            this.DrawTool.Controls.Add(this.btnRotate90degL);
            this.DrawTool.Controls.Add(this.btnRotate90degR);
            this.DrawTool.Controls.Add(this.btnChooseColor);
            this.DrawTool.Controls.Add(this.btnFreeDraw);
            this.DrawTool.Controls.Add(this.btnFlip180H);
            this.DrawTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.DrawTool.Location = new System.Drawing.Point(0, 30);
            this.DrawTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawTool.Name = "DrawTool";
            this.DrawTool.Size = new System.Drawing.Size(186, 672);
            this.DrawTool.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Color Picker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Pen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Shapes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Eraser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Zoom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Crop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Thickness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rotate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Flip";
            // 
            // btnFlip180V
            // 
            this.btnFlip180V.Image = global::MyPaint.Properties.Resources.icons8_flip_vertical_30;
            this.btnFlip180V.Location = new System.Drawing.Point(101, 446);
            this.btnFlip180V.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlip180V.Name = "btnFlip180V";
            this.btnFlip180V.Size = new System.Drawing.Size(53, 48);
            this.btnFlip180V.TabIndex = 11;
            this.btnFlip180V.UseVisualStyleBackColor = true;
            this.btnFlip180V.Click += new System.EventHandler(this.BtnFlip180V_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Image = global::MyPaint.Properties.Resources.icons8_zoom_out_30;
            this.btnZoomOut.Location = new System.Drawing.Point(101, 533);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(53, 48);
            this.btnZoomOut.TabIndex = 10;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.BtnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Image = global::MyPaint.Properties.Resources.icons8_zoom_in_30;
            this.btnZoomIn.Location = new System.Drawing.Point(16, 533);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(53, 48);
            this.btnZoomIn.TabIndex = 9;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.BtnZoomIn_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Image = global::MyPaint.Properties.Resources.icons8_crop_30;
            this.btnCrop.Location = new System.Drawing.Point(56, 602);
            this.btnCrop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(53, 48);
            this.btnCrop.TabIndex = 6;
            this.btnCrop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.BtnCrop_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(42, 278);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(82, 56);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Tag = "";
            // 
            // btnErase
            // 
            this.btnErase.Image = global::MyPaint.Properties.Resources.icons8_eraser_32;
            this.btnErase.Location = new System.Drawing.Point(56, 186);
            this.btnErase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(53, 48);
            this.btnErase.TabIndex = 7;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.BtnErase_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRectangle.Image = global::MyPaint.Properties.Resources.icons8_rectangle_30;
            this.btnRectangle.Location = new System.Drawing.Point(101, 108);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(53, 48);
            this.btnRectangle.TabIndex = 6;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.SystemColors.Menu;
            this.btnEllipse.Image = global::MyPaint.Properties.Resources.icons8_ellipse_30;
            this.btnEllipse.Location = new System.Drawing.Point(16, 108);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(53, 48);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // btnRotate90degL
            // 
            this.btnRotate90degL.Image = global::MyPaint.Properties.Resources.icons8_rotate_left_24;
            this.btnRotate90degL.Location = new System.Drawing.Point(101, 354);
            this.btnRotate90degL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRotate90degL.Name = "btnRotate90degL";
            this.btnRotate90degL.Size = new System.Drawing.Size(53, 48);
            this.btnRotate90degL.TabIndex = 4;
            this.btnRotate90degL.UseVisualStyleBackColor = true;
            this.btnRotate90degL.Click += new System.EventHandler(this.BtnRotate90degL_Click);
            // 
            // btnRotate90degR
            // 
            this.btnRotate90degR.Image = global::MyPaint.Properties.Resources.icons8_rotate_right_24;
            this.btnRotate90degR.Location = new System.Drawing.Point(16, 354);
            this.btnRotate90degR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRotate90degR.Name = "btnRotate90degR";
            this.btnRotate90degR.Size = new System.Drawing.Size(53, 48);
            this.btnRotate90degR.TabIndex = 3;
            this.btnRotate90degR.UseVisualStyleBackColor = true;
            this.btnRotate90degR.Click += new System.EventHandler(this.BtnRotate90degR_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.SystemColors.Menu;
            this.btnChooseColor.Image = global::MyPaint.Properties.Resources.icons8_color_wheel_48;
            this.btnChooseColor.Location = new System.Drawing.Point(101, 29);
            this.btnChooseColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(53, 48);
            this.btnChooseColor.TabIndex = 2;
            this.btnChooseColor.UseVisualStyleBackColor = false;
            this.btnChooseColor.Click += new System.EventHandler(this.BtnChooseColor_Click);
            // 
            // btnFreeDraw
            // 
            this.btnFreeDraw.BackColor = System.Drawing.SystemColors.Menu;
            this.btnFreeDraw.Image = global::MyPaint.Properties.Resources.icons8_pen_32;
            this.btnFreeDraw.Location = new System.Drawing.Point(16, 29);
            this.btnFreeDraw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFreeDraw.Name = "btnFreeDraw";
            this.btnFreeDraw.Size = new System.Drawing.Size(53, 48);
            this.btnFreeDraw.TabIndex = 1;
            this.btnFreeDraw.UseVisualStyleBackColor = false;
            this.btnFreeDraw.Click += new System.EventHandler(this.BtnFreeDraw_Click);
            // 
            // btnFlip180H
            // 
            this.btnFlip180H.Image = global::MyPaint.Properties.Resources.icons8_flip_horizontal_30;
            this.btnFlip180H.Location = new System.Drawing.Point(16, 446);
            this.btnFlip180H.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlip180H.Name = "btnFlip180H";
            this.btnFlip180H.Size = new System.Drawing.Size(53, 48);
            this.btnFlip180H.TabIndex = 0;
            this.btnFlip180H.UseVisualStyleBackColor = true;
            this.btnFlip180H.Click += new System.EventHandler(this.BtnFlip180H_Click);
            // 
            // Draw_workspace
            // 
            this.Draw_workspace.AutoScroll = true;
            this.Draw_workspace.Controls.Add(this.Draw_area);
            this.Draw_workspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draw_workspace.Location = new System.Drawing.Point(0, 0);
            this.Draw_workspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Draw_workspace.Name = "Draw_workspace";
            this.Draw_workspace.Size = new System.Drawing.Size(1179, 702);
            this.Draw_workspace.TabIndex = 6;
            // 
            // Draw_area
            // 
            this.Draw_area.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Draw_area.BackColor = System.Drawing.Color.White;
            this.Draw_area.Location = new System.Drawing.Point(191, 26);
            this.Draw_area.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Draw_area.Name = "Draw_area";
            this.Draw_area.Size = new System.Drawing.Size(1099, 842);
            this.Draw_area.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Draw_area.TabIndex = 0;
            this.Draw_area.TabStop = false;
            this.Draw_area.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.Draw_area.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.Draw_area.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 702);
            this.Controls.Add(this.DrawTool);
            this.Controls.Add(this.MenuOption);
            this.Controls.Add(this.Draw_workspace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuOption;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1194, 742);
            this.Name = "MyPaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPaint";
            this.Load += new System.EventHandler(this.MyPaint_Load);
            this.MenuOption.ResumeLayout(false);
            this.MenuOption.PerformLayout();
            this.DrawTool.ResumeLayout(false);
            this.DrawTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.Draw_workspace.ResumeLayout(false);
            this.Draw_workspace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Draw_area)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip MenuOption;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.Panel DrawTool;
        private System.Windows.Forms.Button btnFlip180H;
        private System.Windows.Forms.Button btnFreeDraw;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRotate90degL;
        private System.Windows.Forms.Button btnRotate90degR;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnFlip180V;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Draw_workspace;
        private System.Windows.Forms.PictureBox Draw_area;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

