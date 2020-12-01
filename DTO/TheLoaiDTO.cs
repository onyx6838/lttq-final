using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiDTO
    {
        private string MaLoai;
        private string MaNhom;
        private string TenLoai;

        public TheLoaiDTO(string maLoai, string maNhom, string tenLoai)
        {
            MaLoai = maLoai;
            MaNhom = maNhom;
            TenLoai = tenLoai;
        }

        public string MaLoai1 { get => MaLoai; set => MaLoai = value; }
        public string MaNhom1 { get => MaNhom; set => MaNhom = value; }
        public string TenLoai1 { get => TenLoai; set => TenLoai = value; }
    }
}
