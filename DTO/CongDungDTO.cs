using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongDungDTO
    {
        private string MaCongDung;
        private string TenCongDung;

        public CongDungDTO(string maCongDung, string tenCongDung)
        {
            MaCongDung1 = maCongDung;
            TenCongDung1 = tenCongDung;
        }

        public string MaCongDung1 { get => MaCongDung; set => MaCongDung = value; }
        public string TenCongDung1 { get => TenCongDung; set => TenCongDung = value; }
    }
}
