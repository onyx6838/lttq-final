using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDBanDTO
    {
        private string SoHDB;
        private string MaNV;
        private DateTime NgayBan;
        private string MaKhach;
        private int TongTien;

        public HDBanDTO(string soHDB, int tongTien)
        {
            SoHDB = soHDB;
            TongTien = tongTien;
        }

        public HDBanDTO(string soHDB, string maNV, DateTime ngayBan, string maKhach, int tongTien)
        {
            SoHDB1 = soHDB;
            MaNV1 = maNV;
            NgayBan1 = ngayBan;
            MaKhach1 = maKhach;
            TongTien1 = tongTien;
        }

        public string SoHDB1 { get => SoHDB; set => SoHDB = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public DateTime NgayBan1 { get => NgayBan; set => NgayBan = value; }
        public string MaKhach1 { get => MaKhach; set => MaKhach = value; }
        public int TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
