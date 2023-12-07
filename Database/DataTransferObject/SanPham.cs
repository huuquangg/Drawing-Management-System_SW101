using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class SanPham
    {
        public string MaSanPham {  get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string XuatXu {  get; set; }
        public string MaDanhMuc { get; set; }

        public SanPham() { }
        public SanPham(string masp, string tensp, int soluong, int dongia, string xuatxu, string madm)
        {
            MaSanPham = masp;
            TenSanPham = tensp;
            SoLuong = soluong;
            DonGia = dongia;
            XuatXu = xuatxu;
            MaDanhMuc = madm;
        }
    }

}
