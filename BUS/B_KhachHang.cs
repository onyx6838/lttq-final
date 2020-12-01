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
    public class B_KhachHang
    {
        public static DataTable GetAllKhachHang()
        {
            return D_KhachHang.getData();
        }
        public static void saveKH(KhachHangDTO kh, string method)
        {
            D_KhachHang.saveKH(kh, method);
        }
        public static void DeleteKhachHang(string mahs)
        {
            D_KhachHang.DeleteKH(mahs);
        }
    }
}
