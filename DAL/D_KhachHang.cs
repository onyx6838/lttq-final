using Constant;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_KhachHang
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllKhachHang", Conn);
        }
        public static void saveKH(KhachHangDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@MaKhach", hs.MaKhachHang1);
            sqlP[1] = new SqlParameter("@TenKhach", hs.TenKhachHang1);
            sqlP[2] = new SqlParameter("@DiaChi", hs.DiaChi1);
            sqlP[3] = new SqlParameter("@DienThoai", hs.DienThoai1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertKhachHang", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateKhachHang", sqlP, Conn);
        }
        public static void DeleteKH(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaKhach", hs);
            GenericDAL.execNonQuery("sp_DeleteKhachHang", sqlP, Conn);
        }
    }
}
