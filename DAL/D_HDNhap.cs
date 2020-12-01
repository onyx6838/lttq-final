using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constant;
using DTO;
namespace DAL
{
    public class D_HDNhap
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllHDNhap", Conn);
        }
        public static DataTable getYearHDN()
        {
            return GenericDAL.getData("sp_getYearHDN", Conn);
        }
        public static DataTable getDataForSearch()
        {
            return GenericDAL.getData("sp_GetAllHDNhap_WithSearch", Conn);
        }
        public static void saveHDN(HDNhapDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDN", hs.SoHDN1);
            sqlP[1] = new SqlParameter("@MaNV", hs.MaNV1);
            sqlP[2] = new SqlParameter("@NgayNhap", hs.NgayNhap1);
            sqlP[3] = new SqlParameter("@MaNCC", hs.MaNCC1);
            sqlP[4] = new SqlParameter("@TongTien", hs.TongTien1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertHDNhap", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateHDNhap", sqlP, Conn);
        }
        public static void DeleteHDN(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDN", hs);
            GenericDAL.execNonQuery("sp_DeleteHDNhap", sqlP, Conn);
        }
        #region EXCEL HDN
        public static DataTable GetBillNhap(string soHDN)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDN", soHDN);
            return GenericDAL.getData("sp_XuatHoaDonNhap", sqlP, Conn);
        }
        public static DataTable XuatMatHangHDN(string soHDN)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDN", soHDN);
            return GenericDAL.getData("sp_XuatMatHangHDN", sqlP, Conn);
        }
        #endregion
        public static bool DuplicateSoHDN(string soHDN)
        {
            SqlCommand command = new SqlCommand("sp_FindOneBySoHDN", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDN", soHDN);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            if (dt.Rows.Count > 0) return false;
            else return true;
        }

        public static void UpdateTongTienHDN(HDNhapDTO dth)
        {
            SqlCommand command = new SqlCommand("sp_UpdateTongTienHDN", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDN", dth.SoHDN1);
            command.Parameters.AddWithValue("@TongTien", dth.TongTien1);

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static string GetTongTien(string sql)
        {
            string ma = "";

            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader reader;
            Conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            Conn.Close();
            return ma;
        }
        public static DataSet HDNBillMax(int nam)
        {
            SqlCommand command = new SqlCommand("sp_MaxBill", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Year", nam);
            command.Connection = Conn;
            Conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            Conn.Close();
            return ds;
        }
    }
}