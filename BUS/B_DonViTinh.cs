using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class B_DonViTinh
    {
        public static DataTable GetAllDVT()
        {
            return D_DonViTinh.getData();
        }
        public static void saveDVT(DonViTinhDTO hs, string method)
        {
            D_DonViTinh.saveDVT(hs, method);
        }
        public static void DeleteDVT(string mahs)
        {
            D_DonViTinh.DeleteDVT(mahs);
        }
    }
}
