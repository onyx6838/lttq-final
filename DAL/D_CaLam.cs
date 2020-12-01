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
    public class D_CaLam
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllCaLam", Conn);
        }
        public static void saveCaLam(CaLamDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaCa", hs.MaCa1);
            sqlP[1] = new SqlParameter("@TenCa", hs.TenCa1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertCaLam", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateCaLam", sqlP, Conn);
        }
        public static void DeleteCaLam(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaCa", hs);
            GenericDAL.execNonQuery("sp_DeleteCaLam", sqlP, Conn);
        }
    }
}
