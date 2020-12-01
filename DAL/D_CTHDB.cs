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
    public class D_CTHDB
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllCTHDB", Conn);
        }
        public static void saveCTHDB(CTHDBDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@SoHDB", hs.SoHDB1);
            sqlP[1] = new SqlParameter("@MaHang", hs.MaHang1);
            sqlP[2] = new SqlParameter("@SoLuong", hs.SoLuong1);
            sqlP[3] = new SqlParameter("@GiamGia", hs.GiamGia1);
            sqlP[4] = new SqlParameter("@ThanhTien", hs.ThanhTien1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertCTHDB", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateCTHDB", sqlP, Conn);
        }
        public static void DeleteCTHDB(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDB", hs);
            GenericDAL.execNonQuery("sp_DeleteCTHDB", sqlP, Conn);
        }
        public static bool DuplicateMaHangHoa(string soHDB, string maHangHoa)
        {
            SqlCommand command = new SqlCommand("sp_FindOneByMaHangHoaHDB", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDB", soHDB);
            command.Parameters.AddWithValue("@MaHang", maHangHoa);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            if (dt.Rows.Count > 0) return false;
            else return true;
        }
        public static DataTable GetInfoHangHoaHDB(string soHDB)
        {
            SqlCommand command = new SqlCommand("sp_GetInfoHangHoaHDB", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDB", soHDB);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
