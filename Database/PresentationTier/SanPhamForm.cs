using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicTier;


namespace PresentationTier
{
    public partial class SanPhamForm : Form
    {
        DanhMucBUS objDM = new DanhMucBUS();
        SanPhamBUS objSP = new SanPhamBUS();

        DataTable tbSP;
        public SanPhamForm()
        {
            InitializeComponent();
        }

        private void SanPhamForm_Load(object sender, EventArgs e)
        {
            string strMaDM = MainForm.strMaDanhMuc_Chon;
            tbSP = objSP.GetSanPhamByMADM(strMaDM);
            dataGridView.DataSource = tbSP;

            cboDanhMuc.DataSource = objDM.GetDanhMuc();
            cboDanhMuc.DisplayMember = "TenDM";
            cboDanhMuc.ValueMember = "MaDM";
        }

        private void dataGridView_SelectionChanged(object sender, DataGridViewCellEventArgs e)
        {
            string strMasp = "";
            if ((strMasp = dataGridView.CurrentRow.Cells[0].Value.ToString()) != "")
            {
                SanPham sp = objSP.GetSanPhamByMASP(strMasp);
                txtMaSP.Text = sp.MaSanPham;
                txtTenSp.Text = sp.TenSanPham;
                txtSoLuong.Text = sp.SoLuong.ToString();
                txtGia.Text = sp.SoLuong.ToString();
                txtXuatXu.Text = sp.XuatXu;
                cboDanhMuc.SelectedValue = sp.MaDanhMuc;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = Convert.ToInt32(txtSoLuong.Text);
                int dg = Convert.ToInt32(txtGia.Text);

                SanPham sp = new SanPham(txtMaSP.Text, txtTenSp.Text, sl, dg, txtXuatXu.Text, cboDanhMuc.SelectedValue.ToString());
                if (objSP.AddSanPham(sp))
                {
                    MessageBox.Show("Thêm một sản phẩm thành công");
                    dataGridView.DataSource = objSP.GetSanPhamByMASP(MainForm.strMaDanhMuc_Chon);
                    ResetTextFields();
                }
                else
                    MessageBox.Show("Có lỗi trong quá trình thêm sản phẩm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm sản phẩm");
            }
        }



        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int sl = Convert.ToInt32(txtSoLuong.Text);
                int dg = Convert.ToInt32(txtGia.Text);

                SanPham sp = new SanPham(txtMaSP.Text, txtTenSp.Text, sl, dg, txtXuatXu.Text, cboDanhMuc.SelectedValue.ToString());
                if (objSP.UpdateSanPham(sp))
                {
                    MessageBox.Show("Đã lưu sản phẩm thành công");
                    dataGridView.DataSource = objSP.GetSanPhamByMADM(MainForm.strMaDanhMuc_Chon);
                    ResetTextFields();
                }
                else
                    MessageBox.Show("Có lỗi trong quá trình lưu sản phẩm");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình lưu sản phẩm");
            }
        }

        private void ResetTextFields()
        {
            txtMaSP.Text = "";
            txtTenSp.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
            txtXuatXu.Text = "";
            cboDanhMuc.SelectedIndex = -1;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
