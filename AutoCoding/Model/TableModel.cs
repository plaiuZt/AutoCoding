using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCoding.Model
{
    public class TableModel
    {
        public TableModel()
        {
            this.Columns = new List<Column>();
        }
        public string DbName { get; set; }

        public string Schema { get; set; }

        public string ModuleName { get; set; }

        public string TableName { get; set; }

        public string TableFullName
        {
            get { return DbName+"."+(Schema==null?"dbo":Schema)+"."+TableName; }
        }

        public string TableKey { get; set; }

        public List<Column> Columns { get; set; }
    }

    public class Column
    {
        public string ColumnName { get; set; }
        public string ColumnType { get; set; }
        public string DbType { get {
                return SqlServerDbTypeMap.MapDbType(ColumnType);
            } }
        public string FieldType { get {
                return SqlServerDbTypeMap.MapCsharpType(ColumnType);
            } }
        public string CharLength { get; set; }
        public bool IsNullable { get; set; }
        public Object DefaultValue { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsIdentity { get; set; }
        public string ColumnID { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
        public string Remark { get; set; }

    }
}
