
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Modules
	/// </summary>
	public class Modules
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

			var result = DbHelperSql.RunProcedure("T_Modules_Exists",parameters,out rowsAffected);
			if(result == 1)
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
		public int Add(Model.Modules model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,30),
					new SqlParameter("@Tag", SqlDbType.NVarChar,50),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@URL", SqlDbType.NVarChar,500),
					new SqlParameter("@Disabled", SqlDbType.Bit,1),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@IsMenu", SqlDbType.Bit,1)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.TypeId;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Tag;
			parameters[4].Value = model.Description;
			parameters[5].Value = model.Url;
			parameters[6].Value = model.Disabled;
			parameters[7].Value = model.Orders;
			parameters[8].Value = model.IsMenu;

			DbHelperSql.RunProcedure("T_Modules_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.Modules model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,30),
					new SqlParameter("@Tag", SqlDbType.NVarChar,50),
					new SqlParameter("@Description", SqlDbType.NVarChar,50),
					new SqlParameter("@URL", SqlDbType.NVarChar,500),
					new SqlParameter("@Disabled", SqlDbType.Bit,1),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@IsMenu", SqlDbType.Bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.TypeId;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Tag;
			parameters[4].Value = model.Description;
			parameters[5].Value = model.Url;
			parameters[6].Value = model.Disabled;
			parameters[7].Value = model.Orders;
			parameters[8].Value = model.IsMenu;

			DbHelperSql.RunProcedure("T_Modules_Update",parameters,out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			DbHelperSql.RunProcedure("T_Modules_Delete",parameters,out rowsAffected);
			return rowsAffected > 0;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			var strSql=new StringBuilder();
			strSql.Append("delete from T_Modules ");
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
		public Model.Modules GetModel(int id)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			var ds= DbHelperSql.RunProcedure("T_Modules_GetModel",parameters,"ds");
			return ds.Tables[0].Rows.Count>0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Modules DataRowToModel(DataRow row)
		{
			var model=new Model.Modules();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["TypeId"]!=null && row["TypeId"].ToString()!="")
				{
					model.TypeId=int.Parse(row["TypeId"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Tag"]!=null)
				{
					model.Tag=row["Tag"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["URL"]!=null)
				{
					model.Url=row["URL"].ToString();
				}
				if(row["Disabled"]!=null && row["Disabled"].ToString()!="")
				{
					if((row["Disabled"].ToString()=="1")||(row["Disabled"].ToString().ToLower()=="true"))
					{
						model.Disabled=true;
					}
					else
					{
						model.Disabled=false;
					}
				}
				if(row["Orders"]!=null && row["Orders"].ToString()!="")
				{
					model.Orders=int.Parse(row["Orders"].ToString());
				}
				if(row["IsMenu"]!=null && row["IsMenu"].ToString()!="")
				{
					if((row["IsMenu"].ToString()=="1")||(row["IsMenu"].ToString().ToLower()=="true"))
					{
						model.IsMenu=true;
					}
					else
					{
						model.IsMenu=false;
					}
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
			strSql.Append("select Id,TypeId,Name,Tag,Description,URL,Disabled,Orders,IsMenu ");
			strSql.Append(" FROM T_Modules ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			strSql.Append(" Id,TypeId,Name,Tag,Description,URL,Disabled,Orders,IsMenu ");
			strSql.Append(" FROM T_Modules ");
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
			strSql.Append("select count(1) FROM T_Modules ");
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
			strSql.Append(")AS Row, T.*  from T_Modules T ");
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
			parameters[0].Value = "T_Modules";
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

