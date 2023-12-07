namespace PresentationTier
{
    partial class SanPhamForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView = new DataGridView();
            txtMaSP = new TextBox();
            txtXuatXu = new TextBox();
            txtGia = new TextBox();
            txtSoLuong = new TextBox();
            txtTenSp = new TextBox();
            cboDanhMuc = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 444);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnThem_Click;
            // 
            // button2
            // 
            button2.Location = new Point(189, 444);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCapNhat_Click;
            // 
            // button3
            // 
            button3.Location = new Point(669, 444);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Trở về";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnTroVe_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(37, 214);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(743, 208);
            dataGridView.TabIndex = 4;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(134, 61);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(203, 23);
            txtMaSP.TabIndex = 5;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(520, 110);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(203, 23);
            txtXuatXu.TabIndex = 6;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(520, 61);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(203, 23);
            txtGia.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(134, 158);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(203, 23);
            txtSoLuong.TabIndex = 8;
            // 
            // txtTenSp
            // 
            txtTenSp.Location = new Point(134, 110);
            txtTenSp.Name = "txtTenSp";
            txtTenSp.Size = new Size(203, 23);
            txtTenSp.TabIndex = 9;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.Location = new Point(520, 158);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(203, 23);
            cboDanhMuc.TabIndex = 10;
            // 
            // SanPhamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 488);
            Controls.Add(cboDanhMuc);
            Controls.Add(txtTenSp);
            Controls.Add(txtSoLuong);
            Controls.Add(txtGia);
            Controls.Add(txtXuatXu);
            Controls.Add(txtMaSP);
            Controls.Add(dataGridView);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SanPhamForm";
            Text = "Danh Sach San Pham";
            Load += SanPhamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView;
        private TextBox txtMaSP;
        private TextBox txtXuatXu;
        private TextBox txtGia;
        private TextBox txtSoLuong;
        private TextBox txtTenSp;
        private ComboBox cboDanhMuc;
    }
}