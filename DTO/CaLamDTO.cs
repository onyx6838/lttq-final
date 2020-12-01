using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CaLamDTO
    {
        private string MaCa;
        private string TenCa;

        public CaLamDTO(string maCa, string tenCa)
        {
            MaCa1 = maCa;
            TenCa1 = tenCa;
        }

        public string MaCa1 { get => MaCa; set => MaCa = value; }
        public string TenCa1 { get => TenCa; set => TenCa = value; }
    }
}
