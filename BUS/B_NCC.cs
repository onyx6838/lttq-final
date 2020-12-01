using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_NCC
    {
        public static DataTable GetAllNCC()
        {
            return D_NCC.getData();
        }
        public static void saveNCC(NCCDTO hs, string method)
        {
            D_NCC.saveNCC(hs, method);
        }
        public static void DeleteNCC(string mahs)
        {
            D_NCC.DeleteNCC(mahs);
        }
    }
}
