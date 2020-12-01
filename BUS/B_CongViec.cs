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
    public class B_CongViec
    {
        public static DataTable GetAllCV()
        {
            return D_CongViec.getData();
        }
        public static void saveCV(CongViecDTO hs, string method)
        {
            D_CongViec.saveCV(hs, method);
        }
        public static void DeleteCV(string mahs)
        {
            D_CongViec.DeleteCV(mahs);
        }
    }
}
