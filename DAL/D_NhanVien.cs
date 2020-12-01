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
    public class D_NhanVien
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllNhanVien", Conn);
        }
        public static void saveNV(NhanVienDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[9];
            sqlP[0] = new SqlParameter("@MaNV", hs.MaNV1);
            sqlP[1] = new SqlParameter("@TenNV", hs.TenNV1);
            sqlP[2] = new SqlParameter("@GioiTinh", hs.GioiTinh1);
            sqlP[3] = new SqlParameter("@NgaySinh", hs.NgaySinh1);
            sqlP[4] = new SqlParameter("@DienThoai", hs.DienThoai1);
            sqlP[5] = new SqlParameter("@DiaChi", hs.DiaChi1);
            sqlP[6] = new SqlParameter("@MaNhom", hs.MaNhom1);
            sqlP[7] = new SqlParameter("@MaCa", hs.MaCa1);
            sqlP[8] = new SqlParameter("@MaCV", hs.MaCV1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertNhanVien", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateNhanVien", sqlP, Conn);
        }
        public static void DeleteNV(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaNV", hs);
            GenericDAL.execNonQuery("sp_DeleteNhanVien", sqlP, Conn);
        }
    }
}
