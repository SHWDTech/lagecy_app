using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Devs
	/// </summary>
	public class Devs
	{
	    #region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSql.GetMaxId("Id", "T_Devs"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string devCode)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@DevCode", SqlDbType.VarChar,20)
			};
			parameters[0].Value = devCode;

			var result= DbHelperSql.RunProcedure("T_Devs_Exists",parameters,out rowsAffected);
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
		public int Add(Model.Devs model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@DevCode", SqlDbType.VarChar,20),
					new SqlParameter("@StatId", SqlDbType.VarChar,20),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@PreEndTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@DevStatus", SqlDbType.TinyInt,1),
					new SqlParameter("@VideoURL", SqlDbType.VarChar,50)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.DevCode;
			parameters[2].Value = model.StatId;
			parameters[3].Value = model.StartTime;
			parameters[4].Value = model.PreEndTime;
			parameters[5].Value = model.EndTime;
			parameters[6].Value = model.DevStatus;
			parameters[7].Value = model.VideoUrl;

			DbHelperSql.RunProcedure("T_Devs_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.Devs model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@DevCode", SqlDbType.VarChar,20),
					new SqlParameter("@StatId", SqlDbType.VarChar,20),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@PreEndTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@DevStatus", SqlDbType.TinyInt,1),
					new SqlParameter("@VideoURL", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.DevCode;
			parameters[2].Value = model.StatId;
			parameters[3].Value = model.StartTime;
			parameters[4].Value = model.PreEndTime;
			parameters[5].Value = model.EndTime;
			parameters[6].Value = model.DevStatus;
			parameters[7].Value = model.VideoUrl;

			DbHelperSql.RunProcedure("T_Devs_Update",parameters,out rowsAffected);
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

			DbHelperSql.RunProcedure("T_Devs_Delete",parameters,out rowsAffected);
			return rowsAffected > 0;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			var strSql=new StringBuilder();
			strSql.Append("delete from T_Devs ");
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
		public Model.Devs GetModel(int id)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			var ds= DbHelperSql.RunProcedure("T_Devs_GetModel",parameters,"ds");
			return ds.Tables[0].Rows.Count>0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}

		public Model.Devs GetDevByNodeId(UInt32 nodeId)
		{
			var strSql = new StringBuilder();
			strSql.Append($"SELECT * FROM T_Devs WHERE T_Devs.Id = (SELECT TOP 1 DevId FROM T_DevAddr WHERE T_DevAddr.NodeId = {nodeId})");


			return DataRowToModel(DbHelperSql.Query(strSql.ToString()).Tables[0].Rows[0]);
		}

		public Model.Stats GetDevStat(int devId)
		{
			var strSql = new StringBuilder();
			strSql.Append($"SELECT * FROM T_Stats WHERE Id = (SELECT TOP 1 StatId FROM T_Devs WHERE T_Devs.Id = {devId})");


			return new Stats().DataRowToModel(DbHelperSql.Query(strSql.ToString()).Tables[0].Rows[0]);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Devs DataRowToModel(DataRow row)
		{
			var model=new Model.Devs();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DevCode"]!=null)
				{
					model.DevCode=row["DevCode"].ToString();
				}
				if (row["StatId"] != null && row["StatId"].ToString() != "")
				{
					model.StatId=int.Parse(row["StatId"].ToString());
				}
				if(row["StartTime"]!=null && row["StartTime"].ToString()!="")
				{
					model.StartTime=DateTime.Parse(row["StartTime"].ToString());
				}
				if(row["PreEndTime"]!=null && row["PreEndTime"].ToString()!="")
				{
					model.PreEndTime=DateTime.Parse(row["PreEndTime"].ToString());
				}
				if(row["EndTime"]!=null && row["EndTime"].ToString()!="")
				{
					model.EndTime=DateTime.Parse(row["EndTime"].ToString());
				}
				if(row["DevStatus"]!=null && row["DevStatus"].ToString()!="")
				{
					model.DevStatus=int.Parse(row["DevStatus"].ToString());
				}
				if(row["VideoURL"]!=null)
				{
					model.VideoUrl=row["VideoURL"].ToString();
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
			strSql.Append("select Id,DevCode,StatId,StartTime,PreEndTime,EndTime,DevStatus,VideoURL ");
			strSql.Append(" FROM T_Devs ");
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
			strSql.Append(" Id,DevCode,StatId,StartTime,PreEndTime,EndTime,DevStatus,VideoURL ");
			strSql.Append(" FROM T_Devs ");
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
			strSql.Append("select count(1) FROM T_Devs ");
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
			strSql.Append(")AS Row, T.*  from T_Devs T ");
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
			return DbHelperSql.RunProcedure("T_Devs_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool ExistsAddr(byte[] nodeId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
				new SqlParameter("@NodeId", SqlDbType.Binary,4)
			};
			parameters[0].Value = nodeId;

			var result = DbHelperSql.RunProcedure("T_DevAddr_Exists", parameters, out rowsAffected);
			return result == 1;
		}
		public bool AddAddr(int devId, byte[] nodeId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@NodeId", SqlDbType.Binary,4)};
			parameters[0].Value = devId;
			parameters[1].Value = nodeId;

			DbHelperSql.RunProcedure("T_DevAddr_ADD", parameters, out rowsAffected);
			return rowsAffected > 0;
		}
		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool UpdateDevAddr(int devId, byte[] nodeId)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@NodeId", SqlDbType.Binary,4)};
			parameters[0].Value = devId;
			parameters[1].Value = nodeId;

			DbHelperSql.RunProcedure("T_DevAddr_Update", parameters, out rowsAffected);
			return rowsAffected > 0;
		}
		 
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetDevAddrList()
		{
			var strSql = new StringBuilder();
			strSql.Append("select DevId,NodeId FROM T_DevAddr");

			return DbHelperSql.Query(strSql.ToString());
		}

		public DataSet GetDevRelatedStat(string strWhere)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@StrWhere", SqlDbType.VarChar,1000)};
			parameters[0].Value = strWhere;

			return DbHelperSql.RunProcedure("T_Devs_GetRelatedStat", parameters, "ds");
		}

		#endregion  MethodEx
	}
}

