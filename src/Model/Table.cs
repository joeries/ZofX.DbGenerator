using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZofX.DbGenerator.Model
{
    /// <summary>
    /// 数据库表
    /// </summary>
    public class Table
    {
        /// <summary>
        /// 表名
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 类型
        /// </summary>
        public string Type { set; get; }

        /// <summary>
        /// 表备注
        /// </summary>
        public string Comment { set; get; }

        /// <summary>
        /// 字段列表
        /// </summary>
        public List<Column> Columns
        {
            get;
            set;
        }
    }
}
