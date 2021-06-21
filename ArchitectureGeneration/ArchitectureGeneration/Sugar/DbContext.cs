using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;

namespace ArchitectureGeneration.Sugar
{
    /**
     * 数据连接
     * 2020年8月5日16:50:11
     * @作者 Child
     */

    public class DbContext
    {
        // //注意：不能写成静态的
        public SqlSugarClient _db;//用来处理事务多表查询和复杂的操作

        public DbContext()
        {
            _db = new SqlSugarClient(
                    new ConnectionConfig()
                    {
                        ConnectionString = SqlSugarConfig.conStr, //
                        DbType = DbType.MySql,
                        InitKeyType = InitKeyType.Attribute, //从特性读取主键和自增列信息
                        IsAutoCloseConnection = true, //开启自动释放模式和EF原理一样我就不多解释了
                        IsShardSameThread = true, //设为true相同线程是同一个SqlConnection
                    }
                );
        }

        public DbContext(string config, DbType dbType)
        {
            _db = new SqlSugarClient(
                    new ConnectionConfig()
                    {
                        ConnectionString = config,//
                        DbType = dbType,
                        InitKeyType = InitKeyType.Attribute, //从特性读取主键和自增列信息
                        IsAutoCloseConnection = true, //开启自动释放模式和EF原理一样我就不多解释了
                        IsShardSameThread = true, //设为true相同线程是同一个SqlConnection
                    }
                );
        }

        /// <summary>
        /// 功能描述:获取数据库处理对象
        /// 作者:Child
        /// </summary>
        /// <returns>返回值</returns>
        public SimpleClient<T> GetEntityDB<T>() where T : class, new()
        {
            return new SimpleClient<T>(_db);
        }

        /// <summary>
        /// 功能描述:获取数据库处理对象
        /// 作　　者:Child
        /// </summary>
        /// <param name="db">db</param>
        /// <returns>返回值</returns>
        public SimpleClient<T> GetEntityDB<T>(SqlSugarClient db) where T : class, new()
        {
            return new SimpleClient<T>(db);
        }
    }
}