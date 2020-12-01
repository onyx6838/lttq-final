using Constant;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class D_NoiSX
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllNoiSX",Conn);
        }
        public static void saveNSX(NoiSXDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaNoiSX", hs.MaNoiSX1);
            sqlP[1] = new SqlParameter("@TenNoiSX", hs.TenNoiSX1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertNoiSX", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateNoiSX", sqlP, Conn);
        }
        public static void DeleteNSX(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNoiSX", hs);
            GenericDAL.execNonQuery("sp_DeleteNoiSX", sqlP, Conn);
        }
    }
}