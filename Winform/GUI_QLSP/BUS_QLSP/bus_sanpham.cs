using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ET_QLSP;
using DAL_QLSP;
namespace BUS_QLSP
{
   public class bus_sanpham
    {
        dal_tbl_sanpham lb = new dal_tbl_sanpham();
        public DataTable LayDS()
        {
            return lb.LayDSSanPham();
        }
        public bool ThemSanPham(ET_sanpham et)
        {
            return lb.ThemSanPham(et);
        }
        public bool SuaSanPham(ET_sanpham et)
        {
            return lb.SuaSanPham(et);
        }
        public bool XoaSanPham(string Ma)
        {
            return lb.XoaSanPham(Ma);
        }
        public DataTable LayTenSP(string et)
        {
            return lb.LayTenSanPham(et);
        }
    }
}
