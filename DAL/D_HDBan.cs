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
    public class D_HDBan
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllHDBan", Conn);
        }
        public static DataTable getYearHDB()
        {
            return GenericDAL.getData("sp_getYearHDB", Conn);
        }
        public static void saveHDB(HDBanDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDB", hs.SoHDB1);
            sqlP[1] = new SqlParameter("@MaNV", hs.MaNV1);
            sqlP[2] = new SqlParameter("@NgayBan", hs.NgayBan1);
            sqlP[3] = new SqlParameter("@MaKhach", hs.MaKhach1);
            sqlP[4] = new SqlParameter("@TongTien", hs.TongTien1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertHDBan", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateHDBan", sqlP, Conn);
        }
        public static void DeleteHDB(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDB", hs);
            GenericDAL.execNonQuery("sp_DeleteHDBan", sqlP, Conn);
        }
        public static bool DuplicateSoHDB(string soHDB)
        {
            SqlCommand command = new SqlCommand("sp_FindOneBySoHDB", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDB", soHDB);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            if (dt.Rows.Count > 0) return false;
            else return true;
        }
        public static void UpdateTongTienHDB(HDBanDTO dtb)
        {
            SqlCommand command = new SqlCommand("sp_UpdateTongTienHDB", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDB", dtb.SoHDB1);
            command.Parameters.AddWithValue("@TongTien", dtb.TongTien1);

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        // EXCEL QUES
        public static DataTable GetBillBan(string soHDB)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDB", soHDB);
            return GenericDAL.getData("sp_XuatHoaDonBan", sqlP, Conn);
        }
        public static DataTable XuatMatHangHDB(string soHDB)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDB", soHDB);
            return GenericDAL.getData("sp_XuatMatHangHDB", sqlP, Conn);
        }
        // REPORT QUES
        public static DataSet SPBanChayNhat(int truoc, int sau)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@Truoc", truoc);
            sqlP[1] = new SqlParameter("@Sau", sau);
            return GenericDAL.execRPQuery("sp_SPBanChayNhat", sqlP, Conn);
        }
        public static DataSet SPBanChayNhatTheoThang(int thang, int year)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@Thang", thang);
            sqlP[1] = new SqlParameter("@Year", year);
            return GenericDAL.execRPQuery("sp_SPBanChayNhatTheoThang", sqlP, Conn);
        }
        public static DataSet HDBTheoNV(string maNV)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNV", maNV);
            return GenericDAL.execRPQuery("sp_rpBillHDB", sqlP, Conn);
        }
        public static DataSet KhachMuaItHangNhat(int truoc, int sau, int year)
        {
            SqlParameter[] sqlP = new SqlParameter[3];
            sqlP[0] = new SqlParameter("@ThangTruoc", truoc);
            sqlP[1] = new SqlParameter("@ThangSau", sau);
            sqlP[2] = new SqlParameter("@Nam", year);
            return GenericDAL.execRPQuery("sp_KhachHang_MuaItHangNhat", sqlP, Conn);
        }
    }
}
