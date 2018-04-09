using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZofX.Library.Strings;
using ZofX.Library.File;
using System.IO;
using System.Collections;

namespace ZofX.DbGenerator.Model
{
    /// <summary>
    /// Sql配置
    /// </summary>
    public class SqlList
    {
        /// <summary>
        /// 存储Sql列表
        /// </summary>
        private static Hashtable htSqlList = Hashtable.Synchronized(new Hashtable());

        /// <summary>
        /// 静态构造
        /// </summary>
        static SqlList()
        {
            string sqlConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SqlList.config");
            AppConfigHelper configHelper = new AppConfigHelper(sqlConfigPath);

            for (Enums.EnumConnType connType = Enums.EnumConnType.OleDb;
                connType <= Enums.EnumConnType.Oracle;
                connType++)
            {
                Sql sqlInfo = new Sql();
                sqlInfo.GetTablesSql = configHelper.GetNodeValue("//Sql[@ConnType='" + connType + "']/GetTablesSql");
                sqlInfo.GetColumnsSql = configHelper.GetNodeValue("//Sql[@ConnType='" + connType + "']/GetColumnsSql");
                htSqlList.Add(connType, sqlInfo);
            }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="connType">连接类型</param>
        /// <returns>Sql</returns>
        public Sql this[Enums.EnumConnType connType]
        {
            get
            {
                return htSqlList[connType] as Sql;
            }
        }

        /// <summary>
        /// Sql信息类
        /// </summary>
        public class Sql
        {
            /// <summary>
            /// 获取表
            /// </summary>
            public string GetTablesSql;

            /// <summary>
            /// 获取列
            /// </summary>
            public string GetColumnsSql;
        }
    }
}
