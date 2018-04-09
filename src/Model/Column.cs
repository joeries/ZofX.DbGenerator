using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZofX.DbGenerator.Model
{
    /// <summary>
    /// 列
    /// </summary>
    public class Column
    {
        /// <summary>
        /// 列名
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// 显示名称
        /// </summary>
        //public string DisplayName { set; get; }

        /// <summary>
        /// 数据类型
        /// </summary>
        public string DataType { set; get; }

        /// <summary>
        /// 字符数据类型最大长度，0为固定或不限
        /// </summary>
        public Int16? MaxLength { set; get; }

        /// <summary>
        /// 默认值
        /// </summary>
        public object DefaultValue { set; get; }

        /// <summary>
        /// 是否主键
        /// </summary>
        public bool? IsPrimaryKey { set; get; }

        /// <summary>
        /// 是否标识
        /// </summary>
        public bool? IsAutoIncrease { set; get; }

        /// <summary>
        /// 是否可空
        /// </summary>
        public bool? IsNullable { set; get; }

        /// <summary>
        /// 是否外键
        /// </summary>
        //public bool? IsForeignKey { set; get; }

        /// <summary>
        /// 列备注
        /// </summary>
        public string Comment { set; get; }

        /// <summary>
        /// 数据类型映射
        /// </summary>
        public DataTypeList.DataType DataTypeMapping { get; set; }
    }
}
