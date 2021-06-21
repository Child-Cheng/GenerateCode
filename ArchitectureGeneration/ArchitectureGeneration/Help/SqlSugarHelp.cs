using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureGeneration.Help
{
    public class SqlSugarHelp
    {
        /// <summary>
        /// 获取所有数据库名称
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<string> GetDataBaseList(SqlSugarClient db)
        {
            return db.DbMaintenance.GetDataBaseList(db);
        }

        /// <summary>
        /// 获取所有视图
        /// </summary>
        /// <returns></returns>
        public static List<DbTableInfo> GetViewInfoList(SqlSugarClient db)
        {
            return db.DbMaintenance.GetViewInfoList();
        }

        /// <summary>
        /// 获取所有表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<DbTableInfo> GetTableInfoList(SqlSugarClient db)
        {
            return db.DbMaintenance.GetTableInfoList();
        }

        /// <summary>
        /// 获取列根据表名
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<DbColumnInfo> GetColumnInfosByTableName(string tableName, SqlSugarClient db)
        {
            return db.DbMaintenance.GetColumnInfosByTableName(tableName);
        }

        /// <summary>
        /// 获取自增列
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<string> GetIsIdentities(string tableName, SqlSugarClient db)
        {
            return db.DbMaintenance.GetIsIdentities(tableName);
        }

        /// <summary>
        /// 获取主键
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="db"></param>
        /// <returns></returns>
        public static List<string> GetPrimaries(string tableName, SqlSugarClient db)
        {
            return db.DbMaintenance.GetPrimaries(tableName);
        }
    }
}