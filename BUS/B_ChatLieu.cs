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
    public class B_ChatLieu
    {
        public static DataTable GetAllCL()
        {
            return D_ChatLieu.getData();
        }
        public static void saveCL(ChatLieuDTO hs, string method)
        {
            D_ChatLieu.saveCL(hs, method);
        }
        public static void DeleteCL(string mahs)
        {
            D_ChatLieu.DeleteCL(mahs);
        }
    }
}
