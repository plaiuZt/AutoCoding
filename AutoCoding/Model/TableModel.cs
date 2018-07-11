using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCoding.Model
{
    public class TableModel
    {
        public string DbName { get; set; }
        public string ModuleName { get; set; }
        public string TableName { get; set; }
        public string TableKey { get; set; }
        public List<Column> Columns { get; set; }
    }

    public class Column
    {
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public string CharLength { get; set; }
        public bool IsNullable { get; set; }
        public string DefaultValue { get; set; }
        public bool IsPrimaryKey { get; set; }

    }
}
