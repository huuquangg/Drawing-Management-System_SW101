using DataAcessTier;
using System.Data;

namespace BusinessLogicTier
{
    public class DanhMucBUS
    {
        DanhMucDAO objDM = new DanhMucDAO();
        public DataTable GetDanhMuc()
        {
            return objDM.GetAllDanhMuc();
        }

        public bool DeleteDanhMuc(string madm)
        {
            if (objDM.CheckDanhMucByID(madm))
                return objDM.DeleteDanhMuc(madm);
            else
                return false;
        }
    }
}