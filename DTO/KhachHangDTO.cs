using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string MaKhachHang;
        private string TenKhachHang;
        private string DiaChi;
        private string DienThoai;

        public KhachHangDTO(string maKhachHang, string tenKhachHang, string diaChi, string dienThoai)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public string MaKhachHang1 { get => MaKhachHang; set => MaKhachHang = value; }
        public string TenKhachHang1 { get => TenKhachHang; set => TenKhachHang = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
    }
}
