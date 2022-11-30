using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET_QLSP
{
   public class ET_NCC
    {
        private string msNCC;
        private string tenNCC;
        private string diachiNCC;
        private string soDTNCC;

        public ET_NCC(string msNCC, string tenNCC, string diachiNCC, string soDTNCC)
        {
            this.msNCC = msNCC;
            this.tenNCC = tenNCC;
            this.diachiNCC = diachiNCC;
            this.soDTNCC = soDTNCC;
        }

        public string MsNCC { get => msNCC; set => msNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiachiNCC { get => diachiNCC; set => diachiNCC = value; }
        public string SoDTNCC { get => soDTNCC; set => soDTNCC = value; }
    }
}
