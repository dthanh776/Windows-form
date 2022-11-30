using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using DAL;
using System.Data;
namespace BUS
{
    public class BUS_HP
    {
        DAL_HP dal_hp = new DAL_HP();
        public DataTable LayDSHP()
        {
            return dal_hp.LayDSHP();
        }
        public bool ThemHP(HocPhan et)
        {
            return dal_hp.ThemHP(et);
        }
        public bool SuaHP(HocPhan et)
        {
            return dal_hp.SuaHP(et);
        }
        public bool XoaHP(string Ma)
        {
            return dal_hp.XoaHP(Ma);
        }
    }
}
