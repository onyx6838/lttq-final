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
    public class B_HangHoa
    {
        public static DataTable GetAllHangHoa()
        {
            return D_HangHoa.getData();
        }
        public static DataTable getDataForSearch()
        {
            return D_HangHoa.getDataForSearch();
        }
        public static void saveHang(HangHoaDTO hs, string method)
        {
            D_HangHoa.saveHang(hs, method);
        }
        public static void DeleteHangHoa(string mahs)
        {
            D_HangHoa.DeleteHang(mahs);
        }
        public static void UpSLHang(HangHoaDTO hs)
        {
            D_HangHoa.UpSLHang(hs);
        }
    }
}
