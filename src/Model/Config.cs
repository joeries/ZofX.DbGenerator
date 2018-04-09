using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using ZofX.Library.File;
using System.IO;
using ZofX.Library.Strings;

namespace ZofX.DbGenerator.Model
{
    /// <summary>
    /// 配置类
    /// </summary>
    public class Config
    {
        /// <summary>
        /// 连接类型
        /// </summary>
        public static Enums.EnumConnType? ConnType;

        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnStr;

        /// <summary>
        /// 连接数据库名称
        /// </summary>
        public static string DatabaseName;

        /// <summary>
        /// 连接状态
        /// </summary>
        public static Enums.EnumConnState? ConnState;

        /// <summary>
        /// Sql
        /// </summary>
        public readonly static SqlList Sql;

        /// <summary>
        /// 数据类型转换列表
        /// </summary>
        public readonly static DataTypeList DataType;

        /// <summary>
        /// 数据库结构
        /// </summary>
        public static List<Table> DbSchema;

        static Config()
        {
            Sql = new SqlList();
            DataType = new DataTypeList();
        }
        
    }
}
