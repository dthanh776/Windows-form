using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSP
{
    public class ET_sanpham
    {
        private string maSP;
        private string tenSP;
        private string msNCC;
        private string dacTa;
        private float giaDC;

        public ET_sanpham(string maSP, string tenSP, string msNCC, string dacTa, float giaDC)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.msNCC = msNCC;
            this.dacTa = dacTa;
            this.giaDC = giaDC;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MsNCC { get => msNCC; set => msNCC = value; }
        public string DacTa { get => dacTa; set => dacTa = value; }
        public float GiaDC { get => giaDC; set => giaDC = value; }
    }
}
