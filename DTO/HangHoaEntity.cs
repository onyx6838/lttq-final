using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaEntity
    {
        private string maHang;
        private string tenHangHoa;
        private string maNhom;
        private int soLuong;
        private int donGiaNhap;
        private int donGiaBan;
        private string maLoai;
        private string nhapKhau;
        private string maDonVi;
        private string maChatLieu;
        private string maCongDung;
        private string maNoiSX;
        private byte[] anh;
        private string ghiChu;

        public string MaHang { get => maHang; set => maHang = value; }
        public string TenHangHoa { get => tenHangHoa; set => tenHangHoa = value; }
        public string MaNhom { get => maNhom; set => maNhom = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public int DonGiaBan { get => donGiaBan; set => donGiaBan = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string NhapKhau { get => nhapKhau; set => nhapKhau = value; }
        public string MaDonVi { get => maDonVi; set => maDonVi = value; }
        public string MaChatLieu { get => maChatLieu; set => maChatLieu = value; }
        public string MaCongDung { get => maCongDung; set => maCongDung = value; }
        public string MaNoiSX { get => maNoiSX; set => maNoiSX = value; }
        public byte[] Anh { get => anh; set => anh = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
    }
}
