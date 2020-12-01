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
    public class B_CTHDN
    {
        public static DataTable GetAllCTHDN()
        {
            return D_CTHDN.getData();
        }
        public static void saveCTHDN(CTHDNDTO hs, string method)
        {
            D_CTHDN.saveCTHDN(hs, method);
        }
        public static void DeleteCTHDN(string mahs)
        {
            D_CTHDN.DeleteCTHDN(mahs);
        }
        public static string GetSoLuong(string sql)
        {
            return D_CTHDN.GetSoLuong(sql);
        }
        public static bool DuplicateMaHangHoa(string soHDN, string maHangHoa)
        {
            return D_CTHDN.DuplicateMaHangHoa(soHDN, maHangHoa);
        }
        public static DataTable GetInfoHangHoa(string soHDN)
        {
            return D_CTHDN.GetInfoHangHoa(soHDN);
        }
        public static int exstSHDN(string shdn)
        {
            return D_CTHDN.exstSHDN(shdn);
        }
    }
}
