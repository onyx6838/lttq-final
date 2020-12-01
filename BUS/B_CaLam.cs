using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class B_CaLam
    {
        public static DataTable GetAllCaLam()
        {
            return D_CaLam.getData();
        }
        public static void saveCaLam(CaLamDTO hs, string method)
        {
            D_CaLam.saveCaLam(hs, method);
        }
        public static void DeleteCaLam(string mahs)
        {
            D_CaLam.DeleteCaLam(mahs);
        }
    }
}
