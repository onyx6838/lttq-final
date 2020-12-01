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
    public class B_CongDung
    {
        public static DataTable GetAllCD()
        {
            return D_CongDung.getData();
        }
        public static void saveCD(CongDungDTO hs, string method)
        {
            D_CongDung.saveCD(hs, method);
        }
        public static void DeleteCD(string mahs)
        {
            D_CongDung.DeleteCD(mahs);
        }
    }
}
