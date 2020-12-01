using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonViTinhDTO
    {
        private string MaDonVi;
        private string TenDonVi;

        public DonViTinhDTO(string maDonVi, string tenDonVi)
        {
            MaDonVi = maDonVi;
            TenDonVi = tenDonVi;
        }

        public string MaDonVi1 { get => MaDonVi; set => MaDonVi = value; }
        public string TenDonVi1 { get => TenDonVi; set => TenDonVi = value; }
    }
}
