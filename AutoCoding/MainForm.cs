using AutoCoding.Model;
using AutoCoding.Temp;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCoding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableModel tableEntity = new TableModel();
            tableEntity.DbName = "JooWMS";
            tableEntity.TableName = "Admin";
            tableEntity.TableKey = "ID";
            tableEntity.ModuleName = "Base";
            tableEntity.Columns = new List<Column>() {
                new Column() { ColumnName = "ID",ColumnType = "DbType.String",CharLength = "18",IsNullable=false,IsPrimaryKey=true,DefaultValue="" },
                new Column() { ColumnName = "UserName",ColumnType = "DbType.String",CharLength = "20",IsNullable=false,IsPrimaryKey=true,DefaultValue="" },
                new Column() { ColumnName = "PassWord",ColumnType = "DbType.String",CharLength = "20",IsNullable=false,IsPrimaryKey=true,DefaultValue="" },
                new Column() { ColumnName = "UserCode",ColumnType = "DbType.String",CharLength = "20",IsNullable=false,IsPrimaryKey=true,DefaultValue="" },
                new Column() { ColumnName = "RealName",ColumnType = "DbType.String",CharLength = "20",IsNullable=false,IsPrimaryKey=true,DefaultValue="" },
                new Column() { ColumnName = "Email",ColumnType = "DbType.String",CharLength = "30",IsNullable=false,IsPrimaryKey=true,DefaultValue="" },
            };
            EntityTemplate temp = new EntityTemplate();
            temp.Session = new TextTemplatingSession();
            temp.Session["entity"] = tableEntity;
            temp.Initialize(); // Must call this to transfer values.  
            string text = temp.TransformText();

            System.IO.File.WriteAllText(tableEntity.TableName+"Entity.cs", text, Encoding.UTF8);
        }
    }
}
