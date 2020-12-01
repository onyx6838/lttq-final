using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dbConnnectionData
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection Conn = new SqlConnection("Data Source = ONYX; Initial Catalog  = store_mgmt; UID = sa; PWD = 123qwe123");
            return Conn;
        }
    }
}
