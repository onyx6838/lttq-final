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
    public class D_HangHoa
    {
        static SqlConnection Conn = dbConnnectionData.HamKetNoi();
        static SystemConstant sys = new SystemConstant();
        public static DataTable getData()
        {
            return GenericDAL.getData("sp_GetAllHangHoa", Conn);
        }
        /* lấy thêm tên của các bảng khóa ngoại để làm tìm kiếm */
        public static DataTable getDataForSearch()
        {
            return GenericDAL.getData("sp_GetAllHangHoa_With_Search", Conn);
        }
        public static void saveHang(HangHoaDTO hs, string method)
        {
            SqlParameter[] sqlP = new SqlParameter[13];
            sqlP[0] = new SqlParameter("@MaHang", hs.MaHang1);
            sqlP[1] = new SqlParameter("@TenHangHoa", hs.TenHangHoa1);
            sqlP[2] = new SqlParameter("@MaNhom", hs.MaNhom1);
            sqlP[3] = new SqlParameter("@SoLuong", hs.SoLuong1);
            //sqlP[4] = new SqlParameter("@DonGiaNhap", hs.DonGiaNhap1);

            if (hs.DonGiaNhap1 == 0)
            {
                sqlP[4] = new SqlParameter("@DonGiaNhap", SqlDbType.Int);
                sqlP[4].Value = DBNull.Value;
            }
            else sqlP[4] = new SqlParameter("@DonGiaNhap", hs.DonGiaNhap1);
            sqlP[5] = new SqlParameter("@MaLoai", hs.MaLoai1);
            sqlP[6] = new SqlParameter("@NhapKhau", hs.NhapKhau1);
            sqlP[7] = new SqlParameter("@MaDonVi", hs.MaDonVi1);
            sqlP[8] = new SqlParameter("@MaChatLieu", hs.MaChatLieu1);
            sqlP[9] = new SqlParameter("@MaCongDung", hs.MaCongDung1);
            sqlP[10] = new SqlParameter("@MaNoiSX", hs.MaNoiSX1);
            //sqlP[11] = new SqlParameter("@Anh", hs.Anh1);


            if (hs.Anh1 == null)
            {
                sqlP[11] = new SqlParameter("@Anh", SqlDbType.Image);
                sqlP[11].Value = DBNull.Value;
            }
            else sqlP[11] = new SqlParameter("@Anh", hs.Anh1);
            sqlP[12] = new SqlParameter("@GhiChu", hs.GhiChu1);
            if (method == sys.INSERT) GenericDAL.execNonQuery("sp_InsertHangHoa", sqlP, Conn);
            else if (method == sys.UPDATE) GenericDAL.execNonQuery("sp_UpdateHangHoa", sqlP, Conn);
        }
        public static void DeleteHang(string hs)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaHang", hs);
            GenericDAL.execNonQuery("sp_DeleteHangHoa", sqlP, Conn);
        }
        public static void UpSLHang(HangHoaDTO hs)
        {
            SqlCommand command = new SqlCommand("sp_UpSLHang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@MaHang", hs.MaHang1);
            command.Parameters.AddWithValue("@SoLuong", hs.SoLuong1);

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
