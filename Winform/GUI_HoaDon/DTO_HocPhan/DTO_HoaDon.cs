using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        string maHoaDon;
        string tenKH;
        string soDienThoai;
        string tenHang;
        DateTime ngayMua;
        int soLuong;
        int donGia;
        float thanhTien;

        public DTO_HoaDon(string maHoaDon, string tenKH, string soDienThoai, string tenHang, DateTime ngayMua, int soLuong, int donGia, float thanhTien)
        {
            this.maHoaDon = maHoaDon;
            this.tenKH = tenKH;
            this.soDienThoai = soDienThoai;
            this.tenHang = tenHang;
            this.ngayMua = ngayMua;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public DateTime NgayMua { get => ngayMua; set => ngayMua = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
