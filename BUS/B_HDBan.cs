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
    public class B_HDBan
    {
        public static DataTable GetAllHDBan()
        {
            return D_HDBan.getData();
        }
        public static DataTable GetYearHDB()
        {
            return D_HDBan.getYearHDB();
        }
        public static void saveHDB(HDBanDTO hs, string method)
        {
            D_HDBan.saveHDB(hs, method);
        }
        public static void DeleteHDBan(string mahs)
        {
            D_HDBan.DeleteHDB(mahs);
        }
        public static bool DuplicateSoHDB(string soHDB)
        {
            return D_HDBan.DuplicateSoHDB(soHDB);
        }
        public static void UpdateTongTienHDB(HDBanDTO dtb)
        {
            D_HDBan.UpdateTongTienHDB(dtb);
        }
        #region EXCEL
        public static DataTable GetBillBan(string HDB)
        {
            return D_HDBan.GetBillBan(HDB);
        }
        public static DataTable XuatMatHangHDB(string HDB)
        {
            return D_HDBan.XuatMatHangHDB(HDB);
        }
        #endregion

        #region RP QUES
        public static DataSet SPBanChayNhat(int truoc, int sau)
        {
            return D_HDBan.SPBanChayNhat(truoc, sau);
        }
        public static DataSet SPBanChayNhatTheoThang(int thang, int year)
        {
            return D_HDBan.SPBanChayNhatTheoThang(thang, year);
        }
        public static DataSet HDBTheoNV(string maNV)
        {
            return D_HDBan.HDBTheoNV(maNV);
        }
        public static DataSet KhachMuaItHangNhat(int truoc, int sau, int year)
        {
            return D_HDBan.KhachMuaItHangNhat(truoc, sau, year);
        }
        #endregion
    }
}
