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
    public class B_TheLoai
    {
        public static DataTable GetAllTL()
        {
            return D_TheLoai.getData();
        }
        public static void saveTL(TheLoaiDTO hs, string method)
        {
            D_TheLoai.saveTL(hs, method);
        }
        public static void DeleteTL(string mahs)
        {
            D_TheLoai.DeleteTL(mahs);
        }
    }
}
