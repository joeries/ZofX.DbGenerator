using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;

namespace ZofX.DbGenerator.Core
{
    /// <summary>
    /// DataTable转换成List
    /// </summary>
    public class TableListConverter
    {
        /// <summary>
        /// 将DataTable转换成List
        /// </summary>
        /// <typeparam name="T">目标类</typeparam>
        /// <param name="dt">DataTable</param>
        /// <returns></returns>
        public static List<T> TableToList<T>(DataTable dt)
        {
            List<T> list = new List<T>();
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            foreach (DataRow dr in dt.Rows)
            {
                T t =Activator.CreateInstance<T>();
                foreach (PropertyInfo property in properties)
                {
                    try
                    {
                        if (property.PropertyType.Equals(typeof(bool?)))
                        {
                            property.SetValue(t, dr[property.Name].ToString() == "1", null);
                        }
                        else
                        {
                            property.SetValue(t, dr[property.Name], null);
                        }
                    }
                    catch { }
                }
                list.Add(t);
            }

            return list;
        }
    }
}