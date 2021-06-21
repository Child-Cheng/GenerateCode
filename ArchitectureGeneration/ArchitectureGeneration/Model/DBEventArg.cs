using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureGeneration.Model
{
    public class DBEventArg : EventArgs
    {
        public SqlSugarClient ClientDb { get; set; }

        public DbType Type { get; set; }

        public string Url { get; set; }

        public string DbName { get; set; }

        public string Name { get; set; }
    }
}