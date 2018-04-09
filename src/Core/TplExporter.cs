using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZofX.DbGenerator.Model;
using ZofX.NvelocityHelper;
using System.IO;

namespace ZofX.DbGenerator.Core
{
    /// <summary>
    /// 模板导出类
    /// </summary>
    public class TplExporter
    {
        /// <summary>
        /// 导出事件参数类
        /// </summary>
        public class ExportEventArgs : EventArgs
        {
            /// <summary>
            /// 是否完成
            /// </summary>
            public bool IsFinished;

            /// <summary>
            /// 总数
            /// </summary>
            public int TotalNum;

            /// <summary>
            /// 当前数
            /// </summary>
            public int NowIndex;

            /// <summary>
            /// 提示信息
            /// </summary>
            public string Info;
        }

        /// <summary>
        /// 导出事件
        /// </summary>
        public event Action<object, ExportEventArgs> OnExport;

        NVelocityHelper nVelocity;
        Encoding encoding = Encoding.UTF8;

        public TplExporter()
        {

        }

        /// <summary>
        /// 导出Model类
        /// </summary>
        /// <param name="strDbName">数据库名称</param>
        /// <param name="table">数据库表</param>
        /// <param name="savePath">文件夹存储路径</param>
        public void ExportModel(string strDbName, List<Table> tables, string saveDirectoryPath)
        {
            nVelocity = new NVelocityHelper(AppDomain.CurrentDomain.BaseDirectory + "Template");
            nVelocity.TemplateFileName = "ModelTpl.cstpl";
            nVelocity.Put("ConnType", Config.ConnType.ToString());
            nVelocity.Put("DatabaseName", Config.DatabaseName);
            nVelocity.Put("this", this);

            ExportEventArgs args = new ExportEventArgs();
            args.IsFinished = false;
            args.Info = "开始生成Model类……";
            if (null != OnExport)
            {
                this.OnExport(this, args);
            }

            if (!Directory.Exists(saveDirectoryPath + Config.DatabaseName))
            {
                Directory.CreateDirectory(saveDirectoryPath + Config.DatabaseName);
            }

            args.TotalNum = tables.Count;
            foreach (Table table in tables)
            {
                nVelocity.Remove("Table");
                nVelocity.Put("Table", table);
                nVelocity.Remove("Columns");
                nVelocity.Put("Columns", table.Columns);
                int i = 0;
                nVelocity.Put("i", i);
                File.WriteAllText(Path.Combine(saveDirectoryPath, Config.DatabaseName + "/" + table.Name + ".cs"), nVelocity.Content, encoding);

                ++args.NowIndex;
                if (null != OnExport)
                {
                    this.OnExport(this, args);
                }
            }

            args.IsFinished = true;
            args.Info = "Model类生成完成";
            if (null != OnExport)
            {
                this.OnExport(this, args);
            }

            nVelocity.Dispose();
        }

        /// <summary>
        /// 导出数据字典
        /// </summary>
        /// <param name="strDbName">数据库名称</param>
        /// <param name="table">数据库表</param>
        /// <param name="savePath">文件存储路径</param>
        public void ExportDbDic(string strDbName, List<Table> tables, string saveFilePath)
        {
            nVelocity = new NVelocityHelper(AppDomain.CurrentDomain.BaseDirectory + "Template");
            nVelocity.TemplateFileName = "DbDicTpl.html";
            nVelocity.Put("ConnType", Config.ConnType.ToString());
            nVelocity.Put("DatabaseName", Config.DatabaseName);
            nVelocity.Put("this", this);

            int i = 1;
            nVelocity.Put("i", i);

            int j = 0;
            nVelocity.Put("j", j);

            ExportEventArgs args = new ExportEventArgs();
            args.IsFinished = false;
            args.Info = "开始生成数据字典……";
            if (null != OnExport)
            {
                this.OnExport(this, args);
            }

            args.TotalNum = tables.Count;
            args.NowIndex = 1;

            nVelocity.Remove("Tables");
            nVelocity.Put("Tables", tables);
            File.WriteAllText(saveFilePath, nVelocity.Content, encoding);

            args.IsFinished = true;
            args.NowIndex = args.TotalNum;
            args.Info = "数据字典生成完成";
            if (null != OnExport)
            {
                this.OnExport(this, args);
            }

            nVelocity.Dispose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Table GetTable(int index)
        {
            return Config.DbSchema[index - 1];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public List<Column> GetColumns(int index)
        {
            return Config.DbSchema[index - 1].Columns;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Column GetColumn(Table table, int index)
        {
            return table.Columns[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Column GetColumn(List<Column> columns, int index)
        {
            return columns[index];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetCsType(Column column)
        {
            return column.DataTypeMapping.CsType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetDbType(Column column)
        {
            return column.DataTypeMapping.DbType;
        }
    }
}