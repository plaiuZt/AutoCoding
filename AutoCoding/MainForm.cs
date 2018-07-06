using AutoCoding.Model;
using AutoCoding.Temp;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCoding
{
    public partial class MainForm : Form
    {
        private SqlConnection Conn = null;
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

        private void btnConn_Click(object sender, EventArgs e)
        {
            string strConn = tbConnStr.Text.Trim();
            if(!string.IsNullOrEmpty(strConn))
            {
                Conn = new SqlConnection(strConn);
                try
                {
                    Conn.Open();
                    if(Conn.State == ConnectionState.Open)
                    {
                        tbConnStr.Enabled = false;
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = Conn;
                        cmd.CommandText = @"select name from master..sysdatabases
                                             where name not in ('master','tempdb','model','msdb')";

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            cbDb.Items.Add(dr[0]);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("请输入数据库连接字符串！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cbDb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strDbName = cbDb.SelectedText;
            try
            {
                if(Conn == null)
                {
                    string strConn = tbConnStr.Text.Trim();
                    Conn = new SqlConnection(strConn);
                }
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                if (Conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Conn;
                    cmd.CommandText = @"select name from "+ strDbName + "..sysObjects where xtype = 'U' order by name";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ListViewItem lvi = new ListViewItem(dr[0].ToString());
                        lvi.SubItems.Add(dr[0].ToString());
                        lvTable.Items.Add(lvi);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void lvTable_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (!e.Item.Checked) return;
            TabPage tp = new TabPage(e.Item.Text);
            DataGridView dgv = new DataGridView();
            //dgv.Columns.Add("ColumnID", "ID");
            //dgv.Columns.Add("IsPrimaryKey", "主键");
            //dgv.Columns.Add("ColumnName", "字段名");
            //dgv.Columns.Add("ColumnType", "字段类型");
            //dgv.Columns.Add("IsIdentity", "自增");
            //dgv.Columns.Add("IsNullable", "可空");
            //dgv.Columns.Add("ByteLength", "字节");
            //dgv.Columns.Add("CharLength", "字符长度");
            //dgv.Columns.Add("Precision", "经度");
            //dgv.Columns.Add("Scale", "刻度");
            //dgv.Columns.Add("Remark", "字段说明");
            dgv.Dock = DockStyle.Fill;
            tp.Controls.Add(dgv);
            #region SqlText
            string sqlText = @"WITH indexCTE AS
                                (
                                    SELECT 
                                    ic.column_id,
                                    ic.index_column_id,
                                    ic.object_id    
                                    FROM JooWMS.sys.indexes idx
                                    INNER JOIN JooWMS.sys.index_columns ic ON idx.index_id = ic.index_id AND idx.object_id = ic.object_id
                                    WHERE  idx.object_id =OBJECT_ID('{0}') AND idx.is_primary_key=1
                                )
                                select
                                colm.column_id ColumnID,
                                CAST(CASE WHEN indexCTE.column_id IS NULL THEN 0 ELSE 1 END AS BIT) IsPrimaryKey,
                                colm.name ColumnName,
                                systype.name ColumnType,
                                colm.is_identity IsIdentity,
                                colm.is_nullable IsNullable,
                                cast(colm.max_length as int) ByteLength,
                                (
                                    case 
                                        when systype.name='nvarchar' and colm.max_length>0 then colm.max_length/2 
                                        when systype.name='nchar' and colm.max_length>0 then colm.max_length/2
                                        when systype.name='ntext' and colm.max_length>0 then colm.max_length/2 
                                        else colm.max_length
                                    end
                                ) CharLength,
                                cast(colm.precision as int) Precision,
                                cast(colm.scale as int) Scale,
                                prop.value Remark
                                from JooWMS.sys.columns colm
                                inner join JooWMS.sys.types systype on colm.system_type_id=systype.system_type_id and colm.user_type_id=systype.user_type_id
                                left join JooWMS.sys.extended_properties prop on colm.object_id=prop.major_id and colm.column_id=prop.minor_id
                                LEFT JOIN indexCTE ON colm.column_id=indexCTE.column_id AND colm.object_id=indexCTE.object_id                                        
                                where colm.object_id=OBJECT_ID('{0}')
                                order by colm.column_id";
            sqlText = string.Format(sqlText, cbDb.Text + ".dbo." + e.Item.Text);
            #endregion

            try
            {
                if (Conn == null)
                {
                    string strConn = tbConnStr.Text.Trim();
                    Conn = new SqlConnection(strConn);
                }
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }
                if (Conn.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = Conn;
                    cmd.CommandText = sqlText;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    dgv.DataSource = ds.Tables[0];
                }

            }
            catch (Exception)
            {
                throw;
            }
            tabMain.TabPages.Add(tp);
        }
    }
}
