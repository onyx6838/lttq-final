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
    public class D_ChatLieu
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllChatLieu",Conn);
        }
        public static void saveCL(ChatLieuDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaChatLieu", hs.MaChatLieu1);
            sqlP[1] = new SqlParameter("@TenChatLieu", hs.TenChatLieu1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertChatLieu", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateChatLieu", sqlP, Conn);
        }
        public static void DeleteCL(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaChatLieu", hs);
            GenericDAL.execNonQuery("sp_DeleteChatLieu", sqlP, Conn);
        }
    }
}
