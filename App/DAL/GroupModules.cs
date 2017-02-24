using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:GroupModules
	/// </summary>
	public class GroupModules
	{
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSql.GetMaxId("GroupId", "T_GroupModules"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int groupId,int moduleId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)			};
			parameters[0].Value = groupId;
			parameters[1].Value = moduleId;

			var result= DbHelperSql.RunProcedure("T_GroupModules_Exists",parameters,out rowsAffected);
			return result==1;
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public bool Add(int groupId, int moduleId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)};
			parameters[0].Value = groupId;
			parameters[1].Value = moduleId;

			DbHelperSql.RunProcedure("T_GroupModules_ADD",parameters,out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.GroupModules model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupId;
			parameters[1].Value = model.ModuleId;

			DbHelperSql.RunProcedure("T_GroupModules_Update",parameters,out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int groupId,int moduleId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)			};
			parameters[0].Value = groupId;
			parameters[1].Value = moduleId;

			DbHelperSql.RunProcedure("T_GroupModules_Delete",parameters,out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.GroupModules GetModel(int groupId,int moduleId)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)			};
			parameters[0].Value = groupId;
			parameters[1].Value = moduleId;

			var ds= DbHelperSql.RunProcedure("T_GroupModules_GetModel",parameters,"ds");
			return ds.Tables[0].Rows.Count>0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.GroupModules DataRowToModel(DataRow row)
		{
			var model=new Model.GroupModules();
			if (row != null)
			{
				if(row["GroupId"]!=null && row["GroupId"].ToString()!="")
				{
					model.GroupId=int.Parse(row["GroupId"].ToString());
				}
				if(row["ModuleId"]!=null && row["ModuleId"].ToString()!="")
				{
					model.ModuleId=int.Parse(row["ModuleId"].ToString());
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
			strSql.Append("select GroupId,ModuleId ");
			strSql.Append(" FROM T_GroupModules ");
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
			strSql.Append(" GroupId,ModuleId ");
			strSql.Append(" FROM T_GroupModules ");
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
			strSql.Append("select count(1) FROM T_GroupModules ");
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
				strSql.Append("order by T.ModuleId desc");
			}
			strSql.Append(")AS Row, T.*  from T_GroupModules T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int pageSize,int pageIndex,string strWhere)
		{
			IDataParameter[] parameters = {
				new SqlParameter("@PageSize", SqlDbType.Int),
				new SqlParameter("@PageIndex", SqlDbType.Int),
				new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
			};
			parameters[0].Value = pageSize;
			parameters[1].Value = pageIndex;
			parameters[2].Value = strWhere;
			return DbHelperSql.RunProcedure("T_GroupModules_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx

	    /// <summary>
	    /// 获取模块列表
	    /// </summary>
	    /// <returns></returns>
	    public DataSet GetModules(int groupId)
		{
			var strSql = new StringBuilder();
			strSql.Append("select ModuleId FROM T_GroupModules where GroupId=@GroupId");
			SqlParameter[] parameters = {
				new SqlParameter("@GroupId", SqlDbType.Int,4)
			};
			parameters[0].Value = groupId;

			return DbHelperSql.Query(strSql.ToString(), parameters);
		}
		#endregion  MethodEx
	}
}

