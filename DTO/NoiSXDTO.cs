using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NoiSXDTO
    {
        private string MaNoiSX;
        private string TenNoiSX;

        public NoiSXDTO(string maNoiSX, string tenNoiSX)
        {
            MaNoiSX1 = maNoiSX;
            TenNoiSX1 = tenNoiSX;
        }

        public string MaNoiSX1 { get => MaNoiSX; set => MaNoiSX = value; }
        public string TenNoiSX1 { get => TenNoiSX; set => TenNoiSX = value; }
    }
}
