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
    public class B_HDNhap
    {
        public static DataTable GetAllHDNhap()
        {
            return D_HDNhap.getData();
        }
        public static DataTable GetYearHDN()
        {
            return D_HDNhap.getYearHDN();
        }
        public static DataTable GetDataForSearch()
        {
            return D_HDNhap.getDataForSearch();
        }
        public static void saveHDN(HDNhapDTO hs, string method)
        {
            D_HDNhap.saveHDN(hs, method);
        }
        public static void DeleteHDNhap(string mahs)
        {
            D_HDNhap.DeleteHDN(mahs);
        }
        public static bool DuplicateSoHDN(string soHDN)
        {
            return D_HDNhap.DuplicateSoHDN(soHDN);
        }
        public static void UpdateTongTienHDN(HDNhapDTO hdn)
        {
            D_HDNhap.UpdateTongTienHDN(hdn);
        }
        public static string GetTongTien(string MaHD)
        {
            return D_HDNhap.GetTongTien(MaHD);
        }
        public static DataTable GetBillNhap(string shdn)
        {
            return D_HDNhap.GetBillNhap(shdn);
        }
        public static DataTable XuatMatHangHDN(string shdn)
        {
            return D_HDNhap.XuatMatHangHDN(shdn);
        }
        public static DataSet HDNBillMax(int nam)
        {
            return D_HDNhap.HDNBillMax(nam);
        }
    }
}
