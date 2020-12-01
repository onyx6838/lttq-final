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
    public class D_NCC
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllNCC", Conn);
        }
        public static void saveNCC(NCCDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@MaNCC", hs.MaNCC1);
            sqlP[1] = new SqlParameter("@TenNCC", hs.TenNCC1);
            sqlP[2] = new SqlParameter("@DiaChi", hs.DiaChi1);
            sqlP[3] = new SqlParameter("@DienThoai", hs.DienThoai1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertNCC", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateNCC", sqlP, Conn);
        }
        public static void DeleteNCC(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNCC", hs);
            GenericDAL.execNonQuery("sp_DeleteNCC", sqlP, Conn);
        }
    }
}
