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
    public class D_TheLoai
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllTheLoai", Conn);
        }
        public static void saveTL(TheLoaiDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[3];
            sqlP[0] = new SqlParameter("@MaLoai", hs.MaLoai1);
            sqlP[1] = new SqlParameter("@MaNhom", hs.MaNhom1);
            sqlP[2] = new SqlParameter("@TenLoai", hs.TenLoai1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertTheLoai", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateTheLoai", sqlP, Conn);
        }
        public static void DeleteTL(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaLoai", hs);
            GenericDAL.execNonQuery("sp_DeleteTheLoai", sqlP, Conn);
        }
    }
}