using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ET
{
    public class HocPhan
    {
        private string maHP;
        private string tenHP;
        private int soTC;
        private int soTietLT;
        private int soTietTH;

        public HocPhan(string maHP, string tenHP, int soTC, int soTietLT, int soTietTH)
        {
            this.maHP = maHP;
            this.tenHP = tenHP;
            this.soTC = soTC;
            this.soTietLT = soTietLT;
            this.soTietTH = soTietTH;
        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string TenHP { get => tenHP; set => tenHP = value; }
        public int SoTC { get => soTC; set => soTC = value; }
        public int SoTietLT { get => soTietLT; set => soTietLT = value; }
        public int SoTietTH { get => soTietTH; set => soTietTH = value; }
    }
}
