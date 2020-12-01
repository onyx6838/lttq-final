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
    public class B_NhanVien
    {
        public static DataTable GetAllNhanVien()
        {
            return D_NhanVien.getData();
        }
        public static void saveNV(NhanVienDTO hs, string method)
        {
            D_NhanVien.saveNV(hs, method);
        }
        public static void DeleteNhanVien(string mahs)
        {
            D_NhanVien.DeleteNV(mahs);
        }
    }
}
