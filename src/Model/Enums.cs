using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZofX.DbGenerator.Model
{
    public class Enums
    {
        /// <summary>
        /// 数据库类型
        /// </summary>
        public enum EnumConnType
        {
            OleDb = 0,
            MsSql2000,
            MsSql2005,
            MsSql2008,
            MySql,
            Oracle
        }

        /// <summary>
        /// 数据库连接状态
        /// </summary>
        public enum EnumConnState
        {
            /// <summary>
            /// 已连接
            /// </summary>
            Open = 1,

            /// <summary>
            /// 已关闭
            /// </summary>
            Closed = 0
        }
    }
}
