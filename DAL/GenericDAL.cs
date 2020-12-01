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
    public class GenericDAL
    {
        public static DataTable getData(string sqlQuery, SqlConnection Conn)
        {
            Conn = dbConnnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static DataTable getData(string sqlQuery, SqlParameter[] sqlParameters, SqlConnection Conn)
        {
            Conn = dbConnnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sqlParameters);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void execNonQuery(string sqlQuery, SqlParameter[] sqlParameters, SqlConnection Conn)
        {
            Conn = dbConnnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sqlParameters);
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        #region FOR GROUP SQL FUNC RETURN
        public static string execQuery(string sql, SqlConnection Conn)
        {
            string ma = "";

            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader reader;
            Conn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            Conn.Close();
            return ma;
        }
        #endregion
        #region REPORT QUES
        public static DataSet execRPQuery(string sqlQuery, SqlParameter[] sqlParameters, SqlConnection Conn)
        {
            SqlCommand command = new SqlCommand(sqlQuery, Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(sqlParameters);
            command.Connection = Conn;
            Conn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(command);
            dap.Fill(ds);
            Conn.Close();
            return ds;
        }
        #endregion
    }
}
