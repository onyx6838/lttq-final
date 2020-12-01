using Constant;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_CTHDN
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllCTHDN", Conn);
        }
        public static void saveCTHDN(CTHDNDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[6];
            sqlP[0] = new SqlParameter("@SoHDN", hs.SoHDN1);
            sqlP[1] = new SqlParameter("@MaHang", hs.MaHang1);
            sqlP[2] = new SqlParameter("@SoLuong", hs.SoLuong1);
            sqlP[3] = new SqlParameter("@DonGia", hs.DonGia1);
            sqlP[4] = new SqlParameter("@GiamGia", hs.GiamGia1);
            sqlP[5] = new SqlParameter("@ThanhTien", hs.ThanhTien1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertCTHDN", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateCTHDN", sqlP, Conn);
        }
        public static void DeleteCTHDN(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@SoHDN", hs);
            GenericDAL.execNonQuery("sp_DeleteCTHDN", sqlP, Conn);
        }
        public static bool DuplicateMaHangHoa(string soHDN, string maHangHoa)
        {
            SqlCommand command = new SqlCommand("sp_FindOneByMaHangHoa", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDN", soHDN);
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
        public static string GetSoLuong(string sql)
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

        public static DataTable GetInfoHangHoa(string soHDN)
        {
            SqlCommand command = new SqlCommand("sp_GetInfoHangHoa", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDN", soHDN);

            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static int exstSHDN(string shdn)
        {
            int ans;
            SqlCommand command = new SqlCommand("checkSHDN", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SoHDN", shdn);
            ans = (int) command.ExecuteScalar();
            return ans;
        }
    }
}
