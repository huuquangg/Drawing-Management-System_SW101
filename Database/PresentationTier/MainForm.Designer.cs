namespace PresentationTier
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lstDanhMuc = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(35, 353);
            button1.Name = "button1";
            button1.Size = new Size(167, 43);
            button1.TabIndex = 0;
            button1.Text = "Xem Danh Sách Sản Phẩm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnXem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(269, 353);
            button2.Name = "button2";
            button2.Size = new Size(186, 43);
            button2.TabIndex = 1;
            button2.Text = "Xóa Danh Sách Sản Phẩm";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnXoa_Click;
            // 
            // button3
            // 
            button3.Location = new Point(541, 353);
            button3.Name = "button3";
            button3.Size = new Size(186, 43);
            button3.TabIndex = 2;
            button3.Text = "Thoát Chương Trình";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnThoat_Click;
            // 
            // lstDanhMuc
            // 
            lstDanhMuc.FormattingEnabled = true;
            lstDanhMuc.ItemHeight = 15;
            lstDanhMuc.Location = new Point(32, 21);
            lstDanhMuc.Name = "lstDanhMuc";
            lstDanhMuc.Size = new Size(703, 274);
            lstDanhMuc.TabIndex = 3;
            lstDanhMuc.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDanhMuc);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox lstDanhMuc;
    }
}