# Project Introduction
This is an application for generating data dictionary and entity class from database such as Access,SQL Server,MySQL and so on.

![Application UI Snapshot](https://images.gitee.com/uploads/images/2019/0621/163604_2ce91601_27856.png "20190621163543.png")

# Database Config in SqlList.config
* SqlList.config's format follows below:

```
<?xml version="1.0" encoding="utf-8" ?>
<SqlList>
  <Sql ConnType="MySql">
    <GetTablesSql>
      select TABLE_NAME as Name,TABLE_TYPE as Type,TABLE_COMMENT as Comment from information_schema.tables where TABLE_SCHEMA='{1}' {0} and TABLE_TYPE='BASE TABLE' order by Name
    </GetTablesSql>
    <GetColumnsSql>
      SELECT COLUMN_COMMENT as Comment, case when COLUMN_KEY='PRI' then 1 else 0 end as IsPrimaryKey, CHARACTER_MAXIMUM_LENGTH as MaxLength, DATA_TYPE as DataType, case when IS_NULLABLE='YES' then 1 else 0 end as IsNullable, COLUMN_DEFAULT as DefaultValue, COLUMN_NAME as Name,case when EXTRA='auto_increment' then 1 else 0 end as IsAutoIncrease
      FROM information_schema.COLUMNS WHERE TABLE_SCHEMA='{1}' and TABLE_NAME =  '{0}'
    </GetColumnsSql>
  </Sql>
</SqlList>
```
* This config file is used for storing SQL list which can fetches table and column information of every kind of databses.You can set every kind of databses as a "Sql" Node.ConnType stands for database type(OleDb,MsSql2000,MsSql2005,MsSql2008,MySql,Oracle).
* The innertext of "GetTablesSql" node is a SQL which can fetches table list of the specific database.Parameter "{0}" stands for other limited condition and "{1}" stands for database name.Also the aliases of GetTablesSql are Name(Table Name),Type(Table Type),Comment(Table Desc).
* The innertext of "GetColumnsSql" node is a SQL which can fetches colmun list of a table in the specific database.Parameter "{0}" stands for table name and "{1}" stands for database name.Also the aliases of GetColumnsSql are Name(Field name),IsPrimaryKey(Field if Primary Key or not),IsNullable(Field if Nullable or not),IsAutoIncrease(Field if AutoIncrease or not),DataType(Field's Data Type),MaxLength(Field's Max Length),DefaultValue（Field's Default Value）,Comment(Field Comment).

# Data Type Reflection in DataTypeList

* Files in "DataTypeList" directory store reflection between database type and C# object type of each database type.
* These files are named as database type code such as OleDb,MsSql2000,MsSql2005,MsSql2008,MySql,Oracle.
* "Code" is data type in database,"Name" is data type name in database,"CsType" is data type in C#,and "DbType" is data type in ADO.NET.
# Export File Template in Template
* The file named as "DbDicTpl.html" is used for exporting data dictionary based on HTML,Markdown and so on via NVelocity.
* The file named as "ModelTpl.cstpl" is used for exporting entity class based on C# class via NVelocity.
* Fetching table information by "Table" tag;
* Fetching column information by "this.GetColumn(Table,i)" in which i presents column index(starting from 0);
* Fetching C# data type by "this.GetCsType(this.GetColumn(Table,i))".
