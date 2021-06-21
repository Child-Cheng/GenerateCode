using ArchitectureGeneration.Sugar;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureGeneration.Dao
{
    public class ConnectDb : DbContext
    {
        private DbContext context;

        /**
         * 处理复杂操作
         */
        protected SqlSugarClient db;

        internal SqlSugarClient Db
        {
            get { return db; }
            private set { db = value; }
        }

        private DbContext Context
        {
            get { return context; }
            set { context = value; }
        }

        public ConnectDb()
        {
            context = new DbContext();
            db = context._db;
        }

        public ConnectDb(string dbUrl, DbType dbType) : base(dbUrl, dbType)
        {
            context = new DbContext(dbUrl, dbType);
            db = context._db;
        }
    }
}