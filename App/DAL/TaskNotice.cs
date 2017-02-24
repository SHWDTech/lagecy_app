using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:TaskNotice
	/// </summary>
	public class TaskNotice
	{
		#region  Method
		/// <summary>
		///  增加一条数据
		/// </summary>
		public bool Add(Model.TaskNotice model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@Data", SqlDbType.Binary,1000),
					new SqlParameter("@Length", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.SmallDateTime)};
			parameters[0].Value = model.TaskId;
			parameters[1].Value = model.DevId;
			parameters[2].Value = model.Data;
			parameters[3].Value = model.Length;
			parameters[4].Value = model.UpdateTime;

			DbHelperSql.RunProcedure("T_TaskNotice_ADD", parameters, out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.TaskNotice model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@Data", SqlDbType.Binary,1000),
					new SqlParameter("@Length", SqlDbType.Int,4),
					new SqlParameter("@UpdateTime", SqlDbType.SmallDateTime)};
			parameters[0].Value = model.TaskId;
			parameters[1].Value = model.DevId;
			parameters[2].Value = model.Data;
			parameters[3].Value = model.Length;
			parameters[4].Value = model.UpdateTime;

			DbHelperSql.RunProcedure("T_TaskNotice_Update", parameters, out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long taskId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8)			};
			parameters[0].Value = taskId;

			DbHelperSql.RunProcedure("T_TaskNotice_Delete", parameters, out rowsAffected);
			return rowsAffected > 0;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string taskIdlist)
		{
			var strSql = new StringBuilder();
			strSql.Append("delete from T_TaskNotice ");
			strSql.Append(" where TaskId in (" + taskIdlist + ")  ");
			var rows = DbHelperSql.ExecuteSql(strSql.ToString());
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
		public Model.TaskNotice GetModel(long taskId)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8)			};
			parameters[0].Value = taskId;

			var ds = DbHelperSql.RunProcedure("T_TaskNotice_GetModel", parameters, "ds");
			return ds.Tables[0].Rows.Count > 0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.TaskNotice DataRowToModel(DataRow row)
		{
			var model = new Model.TaskNotice();
			if (row != null)
			{
				if (row["TaskId"] != null && row["TaskId"].ToString() != "")
				{
					model.TaskId = long.Parse(row["TaskId"].ToString());
				}
				if (row["DevId"] != null && row["DevId"].ToString() != "")
				{
					model.DevId = int.Parse(row["DevId"].ToString());
				}
				if (row["Data"] != null && row["Data"].ToString() != "")
				{
					model.Data = (byte[])row["Data"];
				}
				if (row["Length"] != null && row["Length"].ToString() != "")
				{
					model.Length = int.Parse(row["Length"].ToString());
				}
				if (row["UpdateTime"] != null && row["UpdateTime"].ToString() != "")
				{
					model.UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
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
			strSql.Append("select TaskId,DevId,Data,Length,UpdateTime ");
			strSql.Append(" FROM T_TaskNotice ");
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
			strSql.Append(" TaskId,DevId,Data,Length,UpdateTime ");
			strSql.Append(" FROM T_TaskNotice ");
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
			strSql.Append("select count(1) FROM T_TaskNotice ");
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
				strSql.Append("order by T.TaskId desc");
			}
			strSql.Append(")AS Row, T.*  from T_TaskNotice T ");
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
			return DbHelperSql.RunProcedure("T_TaskNotice_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

