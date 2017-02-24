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
	public class ModuleType
	{
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string name)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,30)
			};
			parameters[0].Value = name;

			var result= DbHelperSql.RunProcedure("T_ModuleType_Exists",parameters,out rowsAffected);
			return result==1;
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public int Add(Model.ModuleType model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
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

			DbHelperSql.RunProcedure("T_ModuleType_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.ModuleType model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
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

			DbHelperSql.RunProcedure("T_ModuleType_Update",parameters,out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int id)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			var result = DbHelperSql.RunProcedure("T_ModuleType_Delete",parameters,out rowsAffected);
			return result;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			var strSql=new StringBuilder();
			strSql.Append("delete from T_ModuleType ");
			strSql.Append(" where Id in ("+idlist + ")  ");
			var rows=DbHelperSql.ExecuteSql(strSql.ToString());
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
		public Model.ModuleType GetModel(int id)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			var ds= DbHelperSql.RunProcedure("T_ModuleType_GetModel",parameters,"ds");
			return ds.Tables[0].Rows.Count>0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.ModuleType DataRowToModel(DataRow row)
		{
			var model=new Model.ModuleType();
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
			var strSql=new StringBuilder();
			strSql.Append("select Id,Name,Orders,Description,SuperiorId ");
			strSql.Append(" FROM T_ModuleType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where " + strWhere + " order by Orders");
			}
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int top,string strWhere,string filedOrder)
		{
			var strSql=new StringBuilder();
			strSql.Append("select ");
			if(top>0)
			{
				strSql.Append(" top "+top);
			}
			strSql.Append(" Id,Name,Orders,Description,SuperiorId ");
			strSql.Append(" FROM T_ModuleType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			var strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_ModuleType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			var obj = DbHelperSql.GetSingle(strSql.ToString());
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
			var strSql=new StringBuilder();
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
			return DbHelperSql.Query(strSql.ToString());
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

