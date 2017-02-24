using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Files
	/// </summary>
	public class Files
	{
	    #region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSql.GetMaxId("Id", "T_Files"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			var result= DbHelperSql.RunProcedure("T_Files_Exists",parameters,out rowsAffected);
			return result==1;
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public int Add(Model.Files model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@StatCode", SqlDbType.VarChar,20),
					new SqlParameter("@CapTime", SqlDbType.DateTime),
					new SqlParameter("@Type", SqlDbType.TinyInt,1),
					new SqlParameter("@FileName", SqlDbType.VarChar,50),
					new SqlParameter("@Path", SqlDbType.VarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.StatCode;
			parameters[2].Value = model.CapTime;
			parameters[3].Value = model.Type;
			parameters[4].Value = model.FileName;
			parameters[5].Value = model.Path;

			DbHelperSql.RunProcedure("T_Files_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.Files model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@StatCode", SqlDbType.VarChar,20),
					new SqlParameter("@CapTime", SqlDbType.DateTime),
					new SqlParameter("@Type", SqlDbType.TinyInt,1),
					new SqlParameter("@FileName", SqlDbType.VarChar,50),
					new SqlParameter("@Path", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.StatCode;
			parameters[2].Value = model.CapTime;
			parameters[3].Value = model.Type;
			parameters[4].Value = model.FileName;
			parameters[5].Value = model.Path;

			DbHelperSql.RunProcedure("T_Files_Update",parameters,out rowsAffected);
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
		public bool Delete(int id)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			DbHelperSql.RunProcedure("T_Files_Delete",parameters,out rowsAffected);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			var strSql=new StringBuilder();
			strSql.Append("delete from T_Files ");
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
		public Model.Files GetModel(int id)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			var ds= DbHelperSql.RunProcedure("T_Files_GetModel",parameters,"ds");
			return ds.Tables[0].Rows.Count>0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Files DataRowToModel(DataRow row)
		{
			var model=new Model.Files();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["StatCode"]!=null)
				{
					model.StatCode=row["StatCode"].ToString();
				}
				if(row["CapTime"]!=null && row["CapTime"].ToString()!="")
				{
					model.CapTime=DateTime.Parse(row["CapTime"].ToString());
				}
				if(row["Type"]!=null && row["Type"].ToString()!="")
				{
					model.Type=int.Parse(row["Type"].ToString());
				}
				if(row["FileName"]!=null)
				{
					model.FileName=row["FileName"].ToString();
				}
				if(row["Path"]!=null)
				{
					model.Path=row["Path"].ToString();
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
			strSql.Append("select Id,StatCode,CapTime,Type,FileName,Path ");
			strSql.Append(" FROM T_Files ");
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
			strSql.Append(" Id,StatCode,CapTime,Type,FileName,Path ");
			strSql.Append(" FROM T_Files ");
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
			strSql.Append("select count(1) FROM T_Files ");
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
			strSql.Append(")AS Row, T.*  from T_Files T ");
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
			parameters[0].Value = "T_Files";
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

