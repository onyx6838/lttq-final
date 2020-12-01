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
    public class D_CongViec
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllCongViec", Conn);
        }
        public static void saveCV(CongViecDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCV", hs.MaCV1);
            sqlP[1] = new SqlParameter("@TenCV", hs.TenCV1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertCongViec", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateCongViec", sqlP, Conn);
        }
        public static void DeleteCV(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaCV", hs);
            GenericDAL.execNonQuery("sp_DeleteCongViec", sqlP, Conn);
        }
    }
}
