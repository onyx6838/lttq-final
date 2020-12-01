using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NCCDTO
    {
        private string MaNCC;
        private string TenNCC;
        private string DiaChi;
        private string DienThoai;

        public NCCDTO(string maNCC, string tenNCC, string diaChi, string dienThoai)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }

        public string MaNCC1 { get => MaNCC; set => MaNCC = value; }
        public string TenNCC1 { get => TenNCC; set => TenNCC = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string DienThoai1 { get => DienThoai; set => DienThoai = value; }
    }
}
