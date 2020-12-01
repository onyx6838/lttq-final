using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_User
    {
        public static DataTable getAllAccount()
        {
            return D_User.getData();
        }
        public static DataTable getInfoAccount(string userName)
        {
            return D_User.GetInfoAccount(userName);
        }
        public static void saveAccount(UserDTO hs, string method)
        {
            D_User.saveAccount(hs, method);
        }
        public static void updateAccount(UserDTO hs, int uid, string method)
        {
            D_User.updateAccount(hs, uid, method);
        }
        public static void deleteAccount(int uid)
        {
            D_User.deleteAccount(uid);
        }
        public static string getRole(string sql)
        {
            return D_User.GetRole(sql);
        }
    }
}
