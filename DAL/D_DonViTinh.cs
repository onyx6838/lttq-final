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
    public class D_DonViTinh
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllDonViTinh", Conn);
        }
        public static void saveDVT(DonViTinhDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[2];
            sqlP[0] = new SqlParameter("@MaDonVi", hs.MaDonVi1);
            sqlP[1] = new SqlParameter("@TenDonVi", hs.TenDonVi1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertDonViTinh", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateDonViTinh", sqlP, Conn);
        }
        public static void DeleteDVT(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaDonVi", hs);
            GenericDAL.execNonQuery("sp_DeleteDonViTinh", sqlP, Conn);
        }
    }
}
