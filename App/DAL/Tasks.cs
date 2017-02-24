using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Tasks
	/// </summary>
	public class Tasks
	{
		#region  Method
		/// <summary>
		///  增加一条数据
		/// </summary>
		public long Add(Model.Tasks model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8),
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@SendTime", SqlDbType.DateTime),
					new SqlParameter("@CmdType", SqlDbType.Int,4),
					new SqlParameter("@CmdByte", SqlDbType.Int,4),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@Data", SqlDbType.Binary,512),
					new SqlParameter("@Length", SqlDbType.Int,4)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.Status;
			parameters[2].Value = model.SendTime;
			parameters[3].Value = model.CmdType;
			parameters[4].Value = model.CmdByte;
			parameters[5].Value = model.DevId;
			parameters[6].Value = model.Data;
			parameters[7].Value = model.Length;

			DbHelperSql.RunProcedure("T_Tasks_ADD", parameters, out rowsAffected);
			return (long)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.Tasks model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8),
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@SendTime", SqlDbType.DateTime),
					new SqlParameter("@CmdType", SqlDbType.SmallInt,2),
					new SqlParameter("@CmdByte", SqlDbType.Int,4),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@Data", SqlDbType.Binary,512),
					new SqlParameter("@Length", SqlDbType.Int,4)};
			parameters[0].Value = model.TaskId;
			parameters[1].Value = model.Status;
			parameters[2].Value = model.SendTime;
			parameters[3].Value = model.CmdType;
			parameters[4].Value = model.CmdByte;
			parameters[5].Value = model.DevId;
			parameters[6].Value = model.Data;
			parameters[7].Value = model.Length;

			DbHelperSql.RunProcedure("T_Tasks_Update", parameters, out rowsAffected);
			return rowsAffected > 0;
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long taskId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt)
			};
			parameters[0].Value = taskId;

			DbHelperSql.RunProcedure("T_Tasks_Delete", parameters, out rowsAffected);
			return rowsAffected > 0;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string taskIdlist)
		{
			var strSql = new StringBuilder();
			strSql.Append("delete from T_Tasks ");
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
		public Model.Tasks GetModel(long taskId)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt)
			};
			parameters[0].Value = taskId;

			var ds = DbHelperSql.RunProcedure("T_Tasks_GetModel", parameters, "ds");
			return ds.Tables[0].Rows.Count > 0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Tasks DataRowToModel(DataRow row)
		{
			var model = new Model.Tasks();
			if (row != null)
			{
				if (row["TaskId"] != null && row["TaskId"].ToString() != "")
				{
					model.TaskId = long.Parse(row["TaskId"].ToString());
				}
				if (row["Status"] != null && row["Status"].ToString() != "")
				{
					model.Status = int.Parse(row["Status"].ToString());
				}
				if (row["SendTime"] != null && row["SendTime"].ToString() != "")
				{
					model.SendTime = DateTime.Parse(row["SendTime"].ToString());
				}
				if (row["CmdType"] != null && row["CmdType"].ToString() != "")
				{
					model.CmdType = int.Parse(row["CmdType"].ToString());
				}
				if (row["CmdByte"] != null && row["CmdByte"].ToString() != "")
				{
					model.CmdByte = int.Parse(row["CmdByte"].ToString());
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
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			var strSql = new StringBuilder();
			strSql.Append("select TaskId,Status,SendTime,CmdType,CmdByte,DevId,Data,Length ");
			strSql.Append(" FROM T_Tasks ");
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
			strSql.Append(" TaskId,Status,SendTime,CmdType,CmdByte,DevId,Data,Length ");
			strSql.Append(" FROM T_Tasks ");
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
			strSql.Append("select count(1) FROM T_Tasks ");
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
			strSql.Append(")AS Row, T.*  from T_Tasks T ");
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
			return DbHelperSql.RunProcedure("T_Tasks_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx
		public bool UpdateStatus(long taskId, int status)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@TaskId", SqlDbType.BigInt,8),
					new SqlParameter("@Status", SqlDbType.TinyInt,1)};
			parameters[0].Value = taskId;
			parameters[1].Value = status;

			DbHelperSql.RunProcedure("T_Tasks_UpdateStatus", parameters, out rowsAffected);
			return rowsAffected > 0;
		}




		#endregion  MethodEx
	}
}

