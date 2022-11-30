using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NhapHoaDon
    {
        private string maHoaDon;
        private DateTime ngayBan;
        private string tenHieuThuoc;
        private string diaChi;

        public DTO_NhapHoaDon(string maHoaDon, DateTime ngayBan, string tenHieuThuoc, string diaChi)
        {
            this.MaHoaDon = maHoaDon;
            this.NgayBan = ngayBan;
            this.TenHieuThuoc = tenHieuThuoc;
            this.DiaChi = diaChi;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime NgayBan { get => ngayBan; set => ngayBan = value; }
        public string TenHieuThuoc { get => tenHieuThuoc; set => tenHieuThuoc = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
