using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhomHangDTO
    {
        private string MaNhom;
        private string TenNhom;

        public NhomHangDTO(string maNhom, string tenNhom)
        {
            MaNhom1 = maNhom;
            TenNhom1 = tenNhom;
        }

        public string MaNhom1 { get => MaNhom; set => MaNhom = value; }
        public string TenNhom1 { get => TenNhom; set => TenNhom = value; }
    }
}
