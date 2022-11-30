using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_NhapHoaDon
    {
        DAL_NhapHoaDon dal_NhapHoaDon = new DAL_NhapHoaDon();
        public DataTable hienThiHoaDon ()
        {
            return dal_NhapHoaDon.hienThiHoaDon("hienThiHoaDon");
        }
        public int ThemHoaDon (DTO_NhapHoaDon hd)
        {
            return dal_NhapHoaDon.LuuHoaDon(hd);
        }
        public int SuaHoaDon(DTO_NhapHoaDon hd)
        {
            return dal_NhapHoaDon.SuaHoaDon(hd);
        }
        public bool XoaHoaDon(string ma)
        {
            return dal_NhapHoaDon.XoaHoaDon(ma);
        }
        public bool CheckTonTai(DTO_NhapHoaDon hd)
        {
            return dal_NhapHoaDon.CheckTonTai(hd);
        }
        public DataTable TimHoaDon(string maHoaDon)
        {
            return dal_NhapHoaDon.TimHoaDon("TimMaHoaDon", maHoaDon);
        }
        public DataTable TimMaThuoc(string maThuoc)
        {
            return dal_NhapHoaDon.TimMaThuoc("TimMaThuoc", maThuoc);
        }
    }
}
