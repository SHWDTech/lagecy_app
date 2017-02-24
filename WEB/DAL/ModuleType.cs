/**  版本信息模板在安装目录下，可自行修改。
* ModuleType.cs
*
* 功 能： N/A
* 类 名： ModuleType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/3 23:34:22   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:ModuleType
	/// </summary>
	public partial class ModuleType
	{
		public ModuleType()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,30)
			};
            parameters[0].Value = name;

			int result= DbHelperSQL.RunProcedure("T_ModuleType_Exists",parameters,out rowsAffected);
			if(result==1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public int Add(ESMonitor.Model.ModuleType model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,30),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@SuperiorId", SqlDbType.Int,4)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Orders;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.SuperiorId;

			DbHelperSQL.RunProcedure("T_ModuleType_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(ESMonitor.Model.ModuleType model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,30),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@SuperiorId", SqlDbType.Int,4)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Orders;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.SuperiorId;

			DbHelperSQL.RunProcedure("T_ModuleType_Update",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int Id)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			int result = DbHelperSQL.RunProcedure("T_ModuleType_Delete",parameters,out rowsAffected);
            return result;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_ModuleType ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ESMonitor.Model.ModuleType GetModel(int Id)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			ESMonitor.Model.ModuleType model=new ESMonitor.Model.ModuleType();
			DataSet ds= DbHelperSQL.RunProcedure("T_ModuleType_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ESMonitor.Model.ModuleType DataRowToModel(DataRow row)
		{
			ESMonitor.Model.ModuleType model=new ESMonitor.Model.ModuleType();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Orders"]!=null && row["Orders"].ToString()!="")
				{
					model.Orders=int.Parse(row["Orders"].ToString());
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["SuperiorId"]!=null && row["SuperiorId"].ToString()!="")
				{
					model.SuperiorId=int.Parse(row["SuperiorId"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Name,Orders,Description,SuperiorId ");
			strSql.Append(" FROM T_ModuleType ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where " + strWhere + " order by Orders");
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Name,Orders,Description,SuperiorId ");
			strSql.Append(" FROM T_ModuleType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_ModuleType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from T_ModuleType T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_ModuleType";
			parameters[1].Value = "Id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

