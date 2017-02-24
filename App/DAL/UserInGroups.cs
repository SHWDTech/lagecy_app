using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:UserInGroups
	/// </summary>
	public class UserInGroups
	{
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int groupId, int userId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)			};
			parameters[0].Value = groupId;
			parameters[1].Value = userId;

			var result = DbHelperSql.RunProcedure("T_UserInGroups_Exists", parameters, out rowsAffected);
			return result == 1;
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public bool Add(Model.UserInGroups model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupId;
			parameters[1].Value = model.UserId;

			DbHelperSql.RunProcedure("T_UserInGroups_ADD", parameters, out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int groupId, int userId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)			};
			parameters[0].Value = groupId;
			parameters[1].Value = userId;

			DbHelperSql.RunProcedure("T_UserInGroups_Delete", parameters, out rowsAffected);
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
		/// 得到一个对象实体
		/// </summary>
		public Model.UserInGroups GetModel(int groupId, int userId)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)			};
			parameters[0].Value = groupId;
			parameters[1].Value = userId;

			var ds = DbHelperSql.RunProcedure("T_UserInGroups_GetModel", parameters, "ds");
			return ds.Tables[0].Rows.Count > 0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.UserInGroups DataRowToModel(DataRow row)
		{
			var model = new Model.UserInGroups();
			if (row != null)
			{
				if (row["GroupId"] != null && row["GroupId"].ToString() != "")
				{
					model.GroupId = int.Parse(row["GroupId"].ToString());
				}
				if (row["UserId"] != null && row["UserId"].ToString() != "")
				{
					model.UserId = int.Parse(row["UserId"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			var strSql = new StringBuilder();
			strSql.Append("select GroupId,UserId ");
			strSql.Append(" FROM T_UserInGroups ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int top, string strWhere, string filedOrder)
		{
			var strSql = new StringBuilder();
			strSql.Append("select ");
			if (top > 0)
			{
				strSql.Append(" top " + top);
			}
			strSql.Append(" GroupId,UserId ");
			strSql.Append(" FROM T_UserInGroups ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSql.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			var strSql = new StringBuilder();
			strSql.Append("select count(1) FROM T_UserInGroups ");
			if (strWhere.Trim() != "")
			{
				strSql.Append(" where " + strWhere);
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
			var strSql = new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby);
			}
			else
			{
				strSql.Append("order by T.UserId desc");
			}
			strSql.Append(")AS Row, T.*  from T_UserInGroups T ");
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
			return DbHelperSql.RunProcedure("T_UserInGroup_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx
		/// <summary>
		/// 批量添加用户角色
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
		public bool AddUserInGroups(ArrayList list)
		{
			var sqlList = new ArrayList();

			for (var i = 0; i < list.Count; i++)
			{
				var val = list[i].ToString().Split(',');
				sqlList.Add("insert into T_UserInGroups(GroupId,UserId) values (" + val[0] + "," + val[1] + ")");
			}

			try
			{
				DbHelperSql.ExecuteSqlTran(sqlList);
				return true;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// 批量删除用户角色
		/// </summary>
		/// <param name="list"></param>
		/// <returns></returns>
		public bool DeleteUserInGroups(ArrayList list)
		{
			var sqlList = new ArrayList();

			for (var i = 0; i < list.Count; i++)
			{
				var val = list[i].ToString().Split(',');
				sqlList.Add("delete T_UserInGroups where GroupId=" + val[0] + " and UserId=" + val[1]);
			}

			try
			{
				DbHelperSql.ExecuteSqlTran(sqlList);
				return true;
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// 读取用户组列表
		/// </summary>
		/// <param name="groupId"></param>
		/// <returns></returns>
		public DataSet GetUserInGroups(int groupId)
		{
			var strSql = new StringBuilder();
			strSql.Append("SELECT Id, Name ");
			strSql.Append("FROM T_UserInGroups INNER JOIN ");
			strSql.Append("T_Users ON T_UserInGroups.UserId = T_Users.UserId ");
			return DbHelperSql.Query(strSql + "where GroupId=" + groupId);
		}
		#endregion  MethodEx
	}
}

