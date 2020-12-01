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
    public class D_NhomHang
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllNhomHang", Conn);
        }
        public static void saveNH(NhomHangDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaNhom", hs.MaNhom1);
            sqlP[1] = new SqlParameter("@TenNhom", hs.TenNhom1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertNhomHang", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateNhomHang", sqlP, Conn);
        }
        public static void DeleteNH(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNhom", hs);
            GenericDAL.execNonQuery("sp_DeleteNhomHang", sqlP, Conn);
        }
    }
}