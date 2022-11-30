using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dal_hd = new DAL_HoaDon();
        public DataTable LayHoaDon()
        {
            return dal_hd.LayHoaDon();
        }
        public bool ThemHoaDon (DTO_HoaDon dto)
        {
            return dal_hd.ThemHoaDon(dto);
        }
        public bool XoaHoaDOn(string Ma)
        {
            return dal_hd.XoaHoaDon(Ma);
        }
        public bool SuaHoaDon(DTO_HoaDon dto)
        {
            return dal_hd.SuaHoaDon(dto);
        }
    }
}
