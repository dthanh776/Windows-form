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
    public class bus_NCC
    {
        dal_tbl_NCC daNCC = new dal_tbl_NCC();
        public DataTable LayDS()
        {
            return daNCC.LayDSNCC();
        }
        public bool ThemNCC(ET_NCC et)
        {
            return daNCC.ThemNCC(et);
    }
        public bool SuaNCC(ET_NCC et)
        {
            return daNCC.SuaNCC(et);
        }
        public bool XoaNCC(String Ma)
        {
            return daNCC.XoaNCC(Ma);
        }
        public DataTable LayTenDS()
        {
            return daNCC.LayTenNCC();
        }
    }
}
