using Constant;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class D_User
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllUser", Conn);
        }
        public static DataTable GetInfoAccount(string userName)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@userName", userName);
            return GenericDAL.getData("sp_GetInfoAccount", sqlP, Conn);
        }
        public static void saveAccount(UserDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[4];
            sqlP[0] = new SqlParameter("@userName", hs.userName);
            sqlP[1] = new SqlParameter("@passWord", hs.passWord);
            sqlP[2] = new SqlParameter("@status", hs.status);
            sqlP[3] = new SqlParameter("@role", hs.role);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertUser", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateUser", sqlP, Conn);
        }
        public static void updateAccount(UserDTO hs, int uid, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[5];
            sqlP[0] = new SqlParameter("@id", uid);
            sqlP[1] = new SqlParameter("@userName", hs.userName);
            sqlP[2] = new SqlParameter("@passWord", hs.passWord);
            sqlP[3] = new SqlParameter("@status", hs.status);
            sqlP[4] = new SqlParameter("@role", hs.role);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertUser", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateUser", sqlP, Conn);
        }
        public static void deleteAccount(int uid)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@uid", uid);
            GenericDAL.execNonQuery("sp_DeleteUser", sqlP, Conn);
        }
        // Authentication
        public static string GetRole(string sql)
        {
            return GenericDAL.execQuery(sql, Conn);
        }
    }
}
