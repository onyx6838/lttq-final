using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDBDTO
    {
        private string SoHDB;
        private string MaHang;
        private int SoLuong;
        private int GiamGia;
        private int ThanhTien;
        private string tenHang;
        private int TempDonGia;
        public CTHDBDTO(string soHDB, string maHang, int soLuong, int giamGia, int thanhTien, string tenHang) : this(soHDB, maHang, soLuong, giamGia, thanhTien)
        {
            this.TenHang = tenHang;
        }

        public CTHDBDTO(string soHDB, string maHang, int soLuong, int giamGia, int thanhTien)
        {
            SoHDB1 = soHDB;
            MaHang1 = maHang;
            SoLuong1 = soLuong;
            GiamGia1 = giamGia;
            ThanhTien1 = thanhTien;
        }

        public CTHDBDTO(string soHDB, string maHang, int soLuong, 
            int giamGia, int thanhTien, string tenHang, int tempDonGia) : this(soHDB, maHang, soLuong, giamGia, thanhTien, tenHang)
        {
            TempDonGia = tempDonGia;
        }

        public string SoHDB1 { get => SoHDB; set => SoHDB = value; }
        public string MaHang1 { get => MaHang; set => MaHang = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public int GiamGia1 { get => GiamGia; set => GiamGia = value; }
        public int ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public int TempDonGia1 { get => TempDonGia; set => TempDonGia = value; }
    }
}
