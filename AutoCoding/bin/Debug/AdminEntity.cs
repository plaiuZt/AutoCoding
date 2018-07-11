/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 代码工具自动生成
 * Create Date: 2018-07-06 06:38:07
 * Blog: http://www.cnblogs.com/qingyuan/ 
 * Description: Git.Framework
 * 
 * Revision History:
 * Date         Author               Description
 * 2018-07-06 06:38:07         PlaiuZt               	
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Git.Framework.ORM;

namespace Git.Storage.Entity.Base
{
	[TableAttribute(DbName = "JooWMS", Name = "Admin", PrimaryKeyName = "ID", IsInternal = false)]
	public partial class AdminEntity : BaseEntity
	{
		public AdminEntity
		{

		}
		
		[DataMapping(ColumnName = "ID", DbType = DbType.String, Length = 18, CanNull = False, DefaultValue = , PrimaryKey = True, AutoIncrement = true, IsMap = true)]
        public Int32 ID { get; set; }

        public AdminEntity IncludeID(bool flag)
        {
            if (flag && !this.ColumnList.Contains("ID"))
            {
                this.ColumnList.Add("ID");
            }
            return this;
        }
		[DataMapping(ColumnName = "UserName", DbType = DbType.String, Length = 20, CanNull = False, DefaultValue = , PrimaryKey = True, AutoIncrement = true, IsMap = true)]
        public Int32 UserName { get; set; }

        public AdminEntity IncludeUserName(bool flag)
        {
            if (flag && !this.ColumnList.Contains("UserName"))
            {
                this.ColumnList.Add("UserName");
            }
            return this;
        }
		[DataMapping(ColumnName = "PassWord", DbType = DbType.String, Length = 20, CanNull = False, DefaultValue = , PrimaryKey = True, AutoIncrement = true, IsMap = true)]
        public Int32 PassWord { get; set; }

        public AdminEntity IncludePassWord(bool flag)
        {
            if (flag && !this.ColumnList.Contains("PassWord"))
            {
                this.ColumnList.Add("PassWord");
            }
            return this;
        }
		[DataMapping(ColumnName = "UserCode", DbType = DbType.String, Length = 20, CanNull = False, DefaultValue = , PrimaryKey = True, AutoIncrement = true, IsMap = true)]
        public Int32 UserCode { get; set; }

        public AdminEntity IncludeUserCode(bool flag)
        {
            if (flag && !this.ColumnList.Contains("UserCode"))
            {
                this.ColumnList.Add("UserCode");
            }
            return this;
        }
		[DataMapping(ColumnName = "RealName", DbType = DbType.String, Length = 20, CanNull = False, DefaultValue = , PrimaryKey = True, AutoIncrement = true, IsMap = true)]
        public Int32 RealName { get; set; }

        public AdminEntity IncludeRealName(bool flag)
        {
            if (flag && !this.ColumnList.Contains("RealName"))
            {
                this.ColumnList.Add("RealName");
            }
            return this;
        }
		[DataMapping(ColumnName = "Email", DbType = DbType.String, Length = 30, CanNull = False, DefaultValue = , PrimaryKey = True, AutoIncrement = true, IsMap = true)]
        public Int32 Email { get; set; }

        public AdminEntity IncludeEmail(bool flag)
        {
            if (flag && !this.ColumnList.Contains("Email"))
            {
                this.ColumnList.Add("Email");
            }
            return this;
        }
		    }

	public partial class AdminEntity
	{
		/*******************************************************************************
		 * 用户自定义属性
		*********************************************************************************/
		
	}
}