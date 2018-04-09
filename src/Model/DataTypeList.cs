using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZofX.Library.File;
using System.Collections;
using System.IO;
using System.Xml;
using ZofX.Library.Strings;

namespace ZofX.DbGenerator.Model
{
    /// <summary>
    /// 数据类型映射配置
    /// </summary>
    public class DataTypeList
    {
        /// <summary>
        /// 存储数据类型转换列表
        /// </summary>
        static Hashtable htDataTypeList = Hashtable.Synchronized(new Hashtable());

        static DataTypeList()
        {
            for (Enums.EnumConnType connType = Enums.EnumConnType.OleDb;
                connType <= Enums.EnumConnType.Oracle;
                connType++)
            {
                string dataTypeConfigPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataTypeList/" + connType.ToString() + ".config");
                AppConfigHelper configHelper = new AppConfigHelper(dataTypeConfigPath);
                XmlNodeList nodeList = configHelper.GetChildNodes("//DataType");

                Hashtable htDataTypes = new Hashtable();
                if (null != nodeList)
                {
                    foreach (XmlNode node in nodeList)
                    {
                        DataType dataType = new DataType();
                        XmlAttribute attr = node.Attributes["Code"];
                        if (null == attr)
                        {
                            continue;
                        }
                        dataType.Code = FilterHelper.GetValue(attr.Value);

                        attr = node.Attributes["CsType"];
                        if (null != attr)
                        {
                            dataType.CsType = FilterHelper.GetValue(attr.Value);
                        }
                        attr = node.Attributes["Name"];
                        if (null != attr)
                        {
                            dataType.Name = FilterHelper.GetValue(attr.Value);
                        }
                        attr = node.Attributes["DbType"];
                        if (null != attr)
                        {
                            dataType.DbType = FilterHelper.GetValue(attr.Value);
                        }
                        htDataTypes.Add(dataType.Code, dataType);
                    }
                }

                htDataTypeList.Add(connType, htDataTypes);
            }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="connType">数据库连接类型</param>
        /// <param name="dataTypeCode">数据库类型码</param>
        /// <returns>数据类型信息类</returns>
        public DataType this[Enums.EnumConnType connType, string dataTypeCode]
        {
            get
            {
                Hashtable ht = htDataTypeList[connType] as Hashtable;
                if (null == ht)
                {
                    return null;
                }

                if (ht.ContainsKey(dataTypeCode))
                {
                    DataType dataType = ht[dataTypeCode] as DataType;
                    if (null != dataType)
                    {
                        return dataType;
                    }
                }

                return null;
            }
        }

        /// <summary>
        /// 数据类型信息
        /// </summary>
        public class DataType{

            /// <summary>
            /// 类型码
            /// </summary>
            public string Code { set; get; }

            /// <summary>
            /// 类型名
            /// </summary>
            public string Name { set; get; }

            /// <summary>
            /// DbType枚举名称
            /// </summary>
            public string DbType { set; get; }

            /// <summary>
            /// C#类型
            /// </summary>
            public string CsType { set; get; }
        }
    }
}
