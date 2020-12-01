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
    public class B_NoiSX
    {
        public static DataTable GetAllNSX()
        {
            return D_NoiSX.getData();
        }
        public static void saveNSX(NoiSXDTO hs, string method)
        {
            D_NoiSX.saveNSX(hs, method);
        }
        public static void DeleteNSX(string mahs)
        {
            D_NoiSX.DeleteNSX(mahs);
        }
    }
}
