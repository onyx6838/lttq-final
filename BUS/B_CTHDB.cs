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
    public class B_CTHDB
    {
        public static DataTable GetAllCTHDB()
        {
            return D_CTHDB.getData();
        }
        public static void saveCTHDB(CTHDBDTO hs, string method)
        {
            D_CTHDB.saveCTHDB(hs, method);
        }
        public static void DeleteCTHDB(string mahs)
        {
            D_CTHDB.DeleteCTHDB(mahs);
        }
        public static bool DuplicateMaHangHoa(string soHDB, string maHangHoa)
        {
            return D_CTHDB.DuplicateMaHangHoa(soHDB, maHangHoa);
        }
        public static DataTable GetInfoHangHoaHDB(string soHDB)
        {
            return D_CTHDB.GetInfoHangHoaHDB(soHDB);
        }
    }
}
