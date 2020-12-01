using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDNDTO
    {
        private string SoHDN;
        private string MaHang;
        private int SoLuong;
        private int DonGia;
        private int GiamGia;
        private int ThanhTien;
        private string tenHang; 
        public CTHDNDTO(string soHDN, string maHang, int soLuong, int donGia, int giamGia, int thanhTien, string tenHang) : this(soHDN, maHang, soLuong, donGia, giamGia, thanhTien)
        {
            this.TenHang = tenHang;
        }

        public CTHDNDTO(string soHDN, string maHang, int soLuong, int donGia, int giamGia, int thanhTien)
        {
            SoHDN1 = soHDN;
            MaHang1 = maHang;
            SoLuong1 = soLuong;
            DonGia1 = donGia;
            GiamGia1 = giamGia;
            ThanhTien1 = thanhTien;
        }

        public string SoHDN1 { get => SoHDN; set => SoHDN = value; }
        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int DonGia1 { get => DonGia; set => DonGia = value; }
        public int GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public int ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
    }
}
