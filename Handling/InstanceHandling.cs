using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Handling
{
    public class InstanceHandling
    {
        public static string AutoCreateKey(DataTable dtForCreate, string primaryCode, string keyCreate)
        {
            string[] exstCode = dtForCreate.AsEnumerable().Select(r => r.Field<string>(primaryCode)).ToArray();
            int index = exstCode.Length;
            if (exstCode.Length == 0)
            {
                string codeWithEmptyArr = keyCreate + "1";
                return codeWithEmptyArr;
            }
            else
            {
                List<int> numEachString = new List<int>();
                for (int i = 0; i < exstCode.Length; i++)
                {
                    string z = String.Join("", exstCode[i].Where(char.IsDigit));
                    numEachString.Add(int.Parse(z));
                }
                //string newCodex = exstCode[index - 1];
                //string val = String.Join("", newCodex.Where(char.IsDigit));
                //int valInt = int.Parse(val) + 1;
                //string fnlCode = keyCreate + valInt.ToString();
                int maxNum = numEachString.Max();
                string fnlCode = keyCreate + (maxNum + 1).ToString();
                return fnlCode;
            }
        }
        public static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        public static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        if (dr[column.ColumnName] == DBNull.Value) pro.SetValue(obj, null, null);
                        else pro.SetValue(obj, dr[column.ColumnName], null);
                    }
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
