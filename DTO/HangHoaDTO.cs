using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoaDTO
    {
        private string MaHang;
        private string TenHangHoa;
        private string MaNhom;
        private int SoLuong;
        private int DonGiaNhap;
        private int DonGiaBan;
        private string MaLoai;
        private string NhapKhau;
        private string MaDonVi;
        private string MaChatLieu;
        private string MaCongDung;
        private string MaNoiSX;
        private byte[] Anh;
        private string GhiChu;

        public HangHoaDTO(string maHang, string tenHangHoa, string maNhom, int soLuong, int donGiaNhap, string maLoai, string nhapKhau, string maDonVi, string maChatLieu, string maCongDung, string maNoiSX, byte[] anh, string ghiChu)
        {
            MaHang = maHang;
            TenHangHoa = tenHangHoa;
            MaNhom = maNhom;
            SoLuong = soLuong;
            DonGiaNhap = donGiaNhap;
            MaLoai = maLoai;
            NhapKhau = nhapKhau;
            MaDonVi = maDonVi;
            MaChatLieu = maChatLieu;
            MaCongDung = maCongDung;
            MaNoiSX = maNoiSX;
            Anh = anh;
            GhiChu = ghiChu;
        }

        
        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public string TenHangHoa1 { get => TenHangHoa; set => TenHangHoa = value; }
        public string MaNhom1 { get => MaNhom; set => MaNhom = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int DonGiaNhap1 { get => DonGiaNhap; set => DonGiaNhap = value; }
        public int DonGiaBan1 { get => DonGiaBan; set => DonGiaBan = value; }
        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string NhapKhau1 { get => NhapKhau; set => NhapKhau = value; }
        public string MaDonVi1 { get => MaDonVi; set => MaDonVi = value; }
        public string MaChatLieu1 { get => MaChatLieu; set => MaChatLieu = value; }
        public string MaCongDung1 { get => MaCongDung; set => MaCongDung = value; }
        public string MaNoiSX1 { get => MaNoiSX; set => MaNoiSX = value; }
        public byte[] Anh1 { get => Anh; set => Anh = value; }
        public string GhiChu1 { get => GhiChu; set => GhiChu = value; }
    }
}
