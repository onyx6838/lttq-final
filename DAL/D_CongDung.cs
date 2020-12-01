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
    public class D_CongDung
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllCongDung", Conn);
        }
        public static void saveCD(CongDungDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCongDung", hs.MaCongDung1);
            sqlP[1] = new SqlParameter("@TenCongDung", hs.TenCongDung1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertCongDung", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateCongDung", sqlP, Conn);
        }
        public static void DeleteCD(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaCongDung", hs);
            GenericDAL.execNonQuery("sp_DeleteCongDung", sqlP, Conn);
        }
    }
}
