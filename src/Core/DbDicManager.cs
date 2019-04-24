using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZofX.DbGenerator.Model;
using ZofX.DAL;
using System.Data;
using System.Data.OleDb;

namespace ZofX.DbGenerator.Core
{
    /// <summary>
    /// 数据字典管理类
    /// </summary>
    public class DbDicManager
    {
        /// <summary>
        /// 连接事件参数类
        /// </summary>
        public class ConnEventArgs : EventArgs
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
        /// 连接事件
        /// </summary>
        public event Action<object, ConnEventArgs> OnConn;

        Database db;
        ZofX.DbGenerator.Model.Enums.EnumConnType connType;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="connType"></param>
        /// <param name="connStr"></param>
        public DbDicManager(Enums.EnumConnType connType, string connStr)
        {
            this.connType = connType;
            if (connType.ToString().Contains("MsSql"))
            {
                db = new Database("MsSql", connStr);
            }
            else
            {
                db = new Database(connType.ToString(), connStr);
            }

            if (Enums.EnumConnType.Oracle == connType)
            {
                db.GetList("select 1 from dual");
            }
            else
            {
                db.GetList("select 1");
            }
        }

        /// <summary>
        /// 获取数据表
        /// </summary>        
        /// <param name="strTableNameLike"></param>
        /// <returns></returns>
        public List<Table> GetTables(string strTableNameLike)
        {
            ConnEventArgs args = new ConnEventArgs();
            args.IsFinished = false;
            args.Info = "开始获取表……";
            if (null != OnConn)
            {
                this.OnConn(this, args);
            }

            List<Table> list = null;
            if (this.connType == Enums.EnumConnType.OleDb)
            {
                list = GetTablesOfOleDb(strTableNameLike);
            }
            else
            {
                list = GetTablesOfOther(strTableNameLike);
            }

            args.IsFinished = true;
            args.Info = "表获取完成";
            if (null != OnConn)
            {
                this.OnConn(this, args);
            }

            return list;
        }

        /// <summary>
        /// 获取OleDb数据库的数据字典
        /// </summary>
        /// <param name="strTableNameLike"></param>
        /// <returns></returns>
        private List<Table> GetTablesOfOleDb(string strTableNameLike)
        {
            ConnEventArgs args = new ConnEventArgs();
            
            List<Table> list = new List<Table>();
            OleDbConnection conn = ((OleDbConnection)db.Conn.Conn);
            conn.Open();
            DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "table" });
            args.TotalNum = dt.Rows.Count;
            args.NowIndex = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Table table = new Table();
                table.Name = dr["TABLE_NAME"].ToString();
                table.Type = dr["TABLE_Type"].ToString();
                table.Comment = dr["Description"].ToString();
                table.Columns = new List<Column>();

                DataTable columns = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new Object[] { null, null, table.Name, null });                
                foreach (DataRow column in columns.Rows)
                {
                    Column tableColumn = new Column();
                    tableColumn.Comment = column["Description"].ToString();
                    try
                    {
                        tableColumn.DataType = Config.DataType[Config.ConnType.Value, column["Data_Type"].ToString()].Name;
                    }
                    catch { }
                    //tableColumn.DataTypeMapping = Config.DataType[connType, tableColumn.DataType];
                    tableColumn.DataTypeMapping = Config.DataType[connType, column["Data_Type"].ToString()];
                    tableColumn.DefaultValue = column["Column_Default"].ToString();
                    //tableColumn.IsAutoIncrease = bool.Parse(column[""].ToString());
                    tableColumn.IsNullable = bool.Parse(column["Is_Nullable"].ToString());
                    //tableColumn.IsPrimaryKey = bool.Parse(column[""].ToString());
                    try
                    {
                        tableColumn.MaxLength = short.Parse(column["CHARACTER_MAXIMUM_LENGTH"].ToString());
                    }
                    catch
                    {
                        tableColumn.MaxLength = 0;
                    }
                    tableColumn.Name = column["COLUMN_NAME"].ToString();
                    table.Columns.Add(tableColumn);
                }

                list.Add(table);

                ++args.NowIndex;                                
                if (null != OnConn)
                {
                    this.OnConn(this, args);
                }
            }
            conn.Close();
            return list;
        }

        /// <summary>
        /// 获取其他数据库的数据字典
        /// </summary>
        /// <param name="strTableNameLike"></param>
        /// <returns></returns>
        private List<Table> GetTablesOfOther(string strTableNameLike)
        {
            ConnEventArgs args = new ConnEventArgs();

            DataSet ds = db.GetList(string.Format(Config.Sql[connType].GetTablesSql, " and " + (connType == Enums.EnumConnType.MySql ? "TABLE_NAME" : "Name") + " LIKE '%" + strTableNameLike + "%'", Config.DatabaseName));
            if (null != ds && ds.Tables.Count > 0)
            {
                List<Table> tables = TableListConverter.TableToList<Table>(ds.Tables[0]);
                args.TotalNum = tables.Count;
                args.NowIndex = 0;
                foreach (Table table in tables)
                {
                    DataSet dsColumns = db.GetList(string.Format(Config.Sql[connType].GetColumnsSql, table.Name, Config.DatabaseName));
                    List<Column> columns = TableListConverter.TableToList<Column>(dsColumns.Tables[0]);
                    table.Columns = columns;
                    foreach (Column column in table.Columns)
                    {
                        column.DataTypeMapping = Config.DataType[connType, column.DataType];
                    }

                    ++args.NowIndex;
                    if (null != OnConn)
                    {
                        this.OnConn(this, args);
                    }
                }

                return tables;
            }

            return null;
        }
    }
}