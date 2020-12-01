using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class B_NhomHang
    {
        public static DataTable GetAllNhomHang()
        {
            return D_NhomHang.getData();
        }
        public static void saveNH(NhomHangDTO hs, string method)
        {
            D_NhomHang.saveNH(hs, method);
        }
        public static void DeleteNhomHang(string mahs)
        {
            D_NhomHang.DeleteNH(mahs);
        }
    }
}
