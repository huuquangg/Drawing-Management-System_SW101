using DataAcessTier;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier
{
    public class SanPhamBUS
    {
        SanPhamDAO objSP = new SanPhamDAO();
        DanhMucDAO objDM = new DanhMucDAO();

        public SanPham GetSanPhamByMASP(string strmasp)
        {
            return objSP.GetSanPhamByMASP(strmasp);
        }

        public DataTable GetSanPhamByMADM(string strmasp)
        {
            return objSP.GetSanPhamByMADM(strmasp);
        }

        public string GetTenDanhMuc (string strmadm)
        {
            return objSP.GetTenDanhMuc(strmadm);
        }

        public bool AddSanPham(SanPham sp)
        {
            if (!objSP.CheckSanPhamByID(sp.MaSanPham) && objDM.CheckDanhMucByID(sp.MaDanhMuc))
                return objSP.AddSanPham(sp);
            else
                return false;
        }

        public bool UpdateSanPham (SanPham sp)
        {
            if (objSP.CheckSanPhamByID(sp.MaSanPham) && objDM.CheckDanhMucByID(sp.MaDanhMuc))
                return objSP.UpdateSanPham(sp);
            else
                return false;
        }
    }
}
