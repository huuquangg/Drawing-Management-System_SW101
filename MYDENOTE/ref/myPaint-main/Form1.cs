using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class MyPaint : Form
    {
        Bitmap bitmap;

        Point currentPoint;
        Point previousPoint;

        Action? action;
        bool isPenDown;

        public string SavedFilePath;

        public MyPaint()
        {
            InitializeComponent();
            bitmap = new Bitmap(Draw_area.ClientSize.Width, Draw_area.ClientSize.Height);
            Draw_area.Image = bitmap;
            action = null;
            SavedFilePath = "";
        }

        private void MyPaint_Load(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            g.Dispose();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                AddExtension = true,
                Multiselect = false,
                InitialDirectory = "C://Desktop",
                Title = "Select file to be upload",
                Filter = "JPG (.*jpg *jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);
                Draw_area.Image = bitmap;
            }
            openFileDialog.Dispose();
        }

        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = null;

            bitmap = new Bitmap(Draw_area.ClientSize.Width, Draw_area.ClientSize.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            Brush brush = new SolidBrush(Color.White);
            graphics.FillRectangle(brush, 0, 0, Draw_area.ClientSize.Width, Draw_area.Image.Height);
            graphics.Dispose();
            Draw_area.Image = bitmap;
            Draw_area.Refresh();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JPG (.*jpg *jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png",
                Title = "Save an Image File",
                RestoreDirectory = true
            };


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream file = (FileStream)saveFileDialog.OpenFile();

                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        Draw_area.Image = null;
                        Draw_area.Image = bitmap;
                        Draw_area.Image.Save(file, ImageFormat.Jpeg);
                        break;

                    case 2:
                        Draw_area.Image.Save(file, ImageFormat.Png);
                        break;
                }
                SavedFilePath = saveFileDialog.FileName;
                file.Close();
            }

        }


        private void BtnFreeDraw_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            action = Action.FreeDraw;
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Draw_area.Refresh();
            currentPoint = e.Location;
            isPenDown = true;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPenDown)
            {
                previousPoint = e.Location;

                Graphics graphics = Graphics.FromImage(Draw_area.Image);
                float penWidth = (float)trackBar1.Value;

                switch (action)
                {
                    case Action.FreeDraw: DrawLine(graphics, new Pen(colorDialog1.Color, penWidth)); break;
                    case Action.Eraser: DrawLine(graphics, new Pen(Color.White, penWidth)); break;
                    case Action.Rectangle:
                    case Action.Crop:
                        DrawRectanglePreview(e.Location); break;
                    case Action.Elipse: DrawElipsePreview(e.Location); break;
                }
                graphics.Dispose();
            }
        }
        private void DrawLine(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, currentPoint, previousPoint);
            currentPoint = previousPoint;
            Draw_area.Refresh();
        }

        private void DrawRectanglePreview(Point point)
        {
            Draw_area.Refresh();
            Draw_area.CreateGraphics().DrawRectangle(
                GetPreviewPen(),
                Math.Min(currentPoint.X, previousPoint.X),
                Math.Min(currentPoint.Y, previousPoint.Y),
                Math.Abs(previousPoint.X - currentPoint.X),
                Math.Abs(previousPoint.Y - currentPoint.Y)
            );
        }

        private void DrawElipsePreview(Point point)
        {
            Draw_area.Refresh();
            Draw_area.CreateGraphics().DrawEllipse(
                GetPreviewPen(),
                Math.Min(currentPoint.X, previousPoint.X),
                Math.Min(currentPoint.Y, previousPoint.Y),
                Math.Abs(previousPoint.X - currentPoint.X),
                Math.Abs(previousPoint.Y - currentPoint.Y)
            );
        }

        private Pen GetPreviewPen()
        {
            Pen pen = new Pen(Color.Black, trackBar1.Value);
            pen.DashStyle = DashStyle.DashDotDot;
            return pen;
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Draw_area.Refresh();
            isPenDown = false;

            Graphics graphics = Graphics.FromImage(Draw_area.Image);
            Pen pen = new Pen(colorDialog1.Color, (float)trackBar1.Value);

            switch (action)
            {
                case Action.Rectangle:
                    graphics.DrawRectangle(
                        pen,
                        Math.Min(currentPoint.X, previousPoint.X),
                        Math.Min(currentPoint.Y, previousPoint.Y),
                        Math.Abs(previousPoint.X - currentPoint.X),
                        Math.Abs(previousPoint.Y - currentPoint.Y)
                    );
                    break;

                case Action.Elipse:
                    graphics.DrawEllipse(
                        pen,
                        Math.Min(currentPoint.X, previousPoint.X),
                        Math.Min(currentPoint.Y, previousPoint.Y),
                        Math.Abs(previousPoint.X - currentPoint.X),
                        Math.Abs(previousPoint.Y - currentPoint.Y)
                    );
                    break;

                case Action.Crop: CropImage(); break;
            }

            pen.Dispose();
            graphics.Dispose();
            Draw_area.Refresh();
        }

        private void CropImage()
        {
            Cursor = Cursors.Default;

            if (previousPoint.X == 0 && previousPoint.Y == 0)
            {
                return;
            }

            Rectangle rectangle = new Rectangle(
                Math.Min(currentPoint.X, previousPoint.X),
                Math.Min(currentPoint.Y, previousPoint.Y),
                Math.Abs(previousPoint.X - currentPoint.X),
                Math.Abs(previousPoint.Y - currentPoint.Y)
            );

            Bitmap croppedBitmap = new Bitmap(rectangle.Width, rectangle.Height);
            Graphics graphics = Graphics.FromImage(croppedBitmap);
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.CompositingQuality = CompositingQuality.HighQuality;

            graphics.DrawImage(bitmap, 0, 0, rectangle, GraphicsUnit.Pixel);
            Draw_area.Image = croppedBitmap;
            Draw_area.Width = croppedBitmap.Width;
            Draw_area.Height = croppedBitmap.Height;
            bitmap = croppedBitmap;
            graphics.Dispose();
            action = null;
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            action = Action.Elipse;
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Cross;
            action = Action.Rectangle;
        }

        private void BtnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _ = colorDialog1.Color;
            }
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            action = Action.Eraser;
        }

        private void BtnCrop_Click(object sender, EventArgs e)
        {
            action = Action.Crop;
            previousPoint = new Point();
        }

        private void BtnZoomIn_Click(object sender, EventArgs e)
        {
            if (Draw_area.Image != null)
            {
                Size size = new Size((int)Math.Round(Draw_area.Image.Width * 1.05), (int)Math.Round(Draw_area.Image.Height * 1.05));
                Draw_area.Image = new Bitmap(bitmap, size);
                bitmap = (Bitmap)Draw_area.Image;
            }
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            if (Draw_area.Image != null)
            {
                Size size = new Size((int)Math.Round(Draw_area.Image.Width * 0.9), (int)Math.Round(Draw_area.Image.Height * 0.9));
                Draw_area.Image = new Bitmap(bitmap, size);
                bitmap = (Bitmap)Draw_area.Image;
            }
        }

        private void BtnFlip180V_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
                Draw_area.Image = bitmap;
            }
        }
        private void BtnFlip180H_Click(object sender, EventArgs e)
        {

            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipX);
                Draw_area.Image = bitmap;
            }
        }

        private void BtnRotate90degR_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Draw_area.Image = bitmap;
            }
        }

        private void BtnRotate90degL_Click(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                Draw_area.Image = bitmap;
            }
        }
    }
}
