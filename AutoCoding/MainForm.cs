using AutoCoding.Model;
using AutoCoding.Temp;
using Microsoft.VisualStudio.TextTemplating;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            this.tbConnStr.Text = @"Server=WIN-TONY\SQLEXPRESS;database=JooWMS;user id=sa;Password=123456";
            tabMain.MouseDoubleClick += TabMain_MouseDoubleClick;
        }

<<<<<<< HEAD
        /// <summary>
        /// 双击关闭事件处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X, y = e.Y;
                //计算关闭区域   
                Rectangle myTabRect = this.tabMain.GetTabRect(this.tabMain.SelectedIndex);
                myTabRect.Offset(2, 2);
                //如果鼠标在区域内就关闭选项卡   
                bool isClose = x > myTabRect.X && x < myTabRect.Right && y > myTabRect.Y && y < myTabRect.Bottom;
                if (isClose == true)
                {
                    //this.tabMain.SelectedTab.Dispose();
                    lvTable.Items[this.tabMain.SelectedTab.Name].Checked = false;
                }
            }
        }

=======
>>>>>>> d91443cdd1257c8f133790f05d4365e0ae37ea40
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
                        lvi.Name = dr[0].ToString();
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
            if (!e.Item.Checked)
            {
                //如果存在tabpage,则取消
                if(tabMain.TabPages.ContainsKey(e.Item.Text))
                {
                    this.tabMain.TabPages[e.Item.Text].Dispose();
                }
                return;
            };
            TabPage tp = new TabPage(e.Item.Text);
            tp.Name = e.Item.Text;
            DataGridView dgv = new DataGridView();
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
                                prop.value Remark,
                                scm.text defaultvalue
                                from JooWMS.sys.columns colm
                                inner join JooWMS.sys.types systype on colm.system_type_id=systype.system_type_id and colm.user_type_id=systype.user_type_id
                                left join JooWMS.sys.extended_properties prop on colm.object_id=prop.major_id and colm.column_id=prop.minor_id
                                LEFT JOIN indexCTE ON colm.column_id=indexCTE.column_id AND colm.object_id=indexCTE.object_id
                                LEFT JOIN JooWMS.sys.syscolumns sc on sc.colid = colm.column_id and sc.id = colm.object_id 
                                LEFT JOIN JooWMS.sys.syscomments scm on scm.id = sc.cdefault                                      
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

        private void btnGen_Click(object sender, EventArgs e)
        {
            FileInfo csprojFile = new FileInfo(this.tbProj.Text);
            DirectoryInfo dir = new DirectoryInfo(Path.GetDirectoryName(csprojFile.FullName));
            foreach (TabPage tp in tabMain.TabPages)
            {
                string dbName = cbDb.Text;
                string tableName = tp.Name;
                TableModel model = new TableModel();
                model.DbName = cbDb.Text.Trim();
                model.TableName = tp.Text.Trim();
                model.ModuleName = tbModule.Text.Trim();
                DataTable dt = GetTable(model.TableFullName);
                foreach (DataRow dr in dt.Rows)
                {
                    Column col = new Column();
                    col.ColumnName = dr["ColumnName"].ToString();
                    col.ColumnType = dr["ColumnType"].ToString();
                    col.CharLength = dr["CharLength"].ToString();
                    col.IsNullable = (bool)dr["IsNullable"];
                    col.IsPrimaryKey = (bool)dr["IsPrimaryKey"];
<<<<<<< HEAD
                    col.DefaultValue = dr["DefaultValue"]== DBNull.Value?"null": dr["DefaultValue"];
=======
                    col.DefaultValue = dr["DefaultValue"].ToString();
>>>>>>> d91443cdd1257c8f133790f05d4365e0ae37ea40
                    col.IsIdentity = (bool)dr["IsIdentity"];
                    col.ColumnID = dr["ColumnID"].ToString();
                    col.Precision = (int)dr["Precision"];
                    col.Scale = (int)dr["Scale"];
                    col.Remark = dr["Remark"].ToString();

                    if(col.IsPrimaryKey)
                    {
                        model.TableKey += col.ColumnName+",";
                    }
                    model.Columns.Add(col);
                }

                model.TableKey = model.TableKey.TrimEnd(',');

                EntityTemplate temp = new EntityTemplate();
                temp.Session = new TextTemplatingSession();
                temp.Session["entity"] = model;
                temp.Initialize(); // Must call this to transfer values.  
                string text = temp.TransformText();

                if(!string.IsNullOrEmpty(model.ModuleName))
                {
                    //创建目录
                    if(dir.GetDirectories().Where(a=>a.Name == model.ModuleName).Count() == 0)
                    {
                        DirectoryInfo subDir = dir.CreateSubdirectory(model.ModuleName);
                        File.WriteAllText(subDir.FullName+"/"+model.TableName + "Entity.cs", text, Encoding.UTF8);
                    }
                    else
                    {
                        File.WriteAllText(dir.FullName + "/" +model.ModuleName+"/"+ model.TableName + "Entity.cs", text, Encoding.UTF8);
                    }
                }
                else
                {
                    File.WriteAllText(dir.FullName + "/" + model.TableName + "Entity.cs", text, Encoding.UTF8);
                }
            }
            
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
<<<<<<< HEAD
            ofd.Filter = "文本文件(*.csproj)|*.csproj|所有文件(*.*)|*.*";
=======
            ofd.Filter = "文本文件(*.csproj) | *.csproj | 所有文件(*.*) | *.*";
>>>>>>> d91443cdd1257c8f133790f05d4365e0ae37ea40
            ofd.Multiselect = false;
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                this.tbProj.Text = ofd.FileName;
            }
        }

        private DataTable GetTable(string tableName)
        {
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
                                prop.value Remark,
<<<<<<< HEAD
                                scm.text defaultvalue
                                from JooWMS.sys.columns colm
                                inner join JooWMS.sys.types systype on colm.system_type_id=systype.system_type_id and colm.user_type_id=systype.user_type_id
                                left join JooWMS.sys.extended_properties prop on colm.object_id=prop.major_id and colm.column_id=prop.minor_id
                                LEFT JOIN indexCTE ON colm.column_id=indexCTE.column_id AND colm.object_id=indexCTE.object_id
                                LEFT JOIN JooWMS.sys.syscolumns sc on sc.colid = colm.column_id and sc.id = colm.object_id 
                                LEFT JOIN JooWMS.sys.syscomments scm on scm.id = sc.cdefault                                      
=======
                                '' defaultvalue
                                from JooWMS.sys.columns colm
                                inner join JooWMS.sys.types systype on colm.system_type_id=systype.system_type_id and colm.user_type_id=systype.user_type_id
                                left join JooWMS.sys.extended_properties prop on colm.object_id=prop.major_id and colm.column_id=prop.minor_id
                                LEFT JOIN indexCTE ON colm.column_id=indexCTE.column_id AND colm.object_id=indexCTE.object_id                                        
>>>>>>> d91443cdd1257c8f133790f05d4365e0ae37ea40
                                where colm.object_id=OBJECT_ID('{0}')
                                order by colm.column_id";
            sqlText = string.Format(sqlText, tableName);
            #endregion
            DataSet ds = new DataSet();
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
                    da.Fill(ds);
                }
                return ds.Tables[0];
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
