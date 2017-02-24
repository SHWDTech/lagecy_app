using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Devs
	/// </summary>
	public partial class Devs
	{
		public Devs()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "T_Devs"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string devCode)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@DevCode", SqlDbType.VarChar,20)
			};
            parameters[0].Value = devCode;

			int result= DbHelperSQL.RunProcedure("T_Devs_Exists",parameters,out rowsAffected);
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
		public int Add(ESMonitor.Model.Devs model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
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
			parameters[7].Value = model.VideoURL;

			DbHelperSQL.RunProcedure("T_Devs_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(ESMonitor.Model.Devs model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
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
			parameters[7].Value = model.VideoURL;

			DbHelperSQL.RunProcedure("T_Devs_Update",parameters,out rowsAffected);
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
		public bool Delete(int Id)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			DbHelperSQL.RunProcedure("T_Devs_Delete",parameters,out rowsAffected);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Devs ");
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
		public ESMonitor.Model.Devs GetModel(int Id)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			ESMonitor.Model.Devs model=new ESMonitor.Model.Devs();
			DataSet ds= DbHelperSQL.RunProcedure("T_Devs_GetModel",parameters,"ds");
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
		public ESMonitor.Model.Devs DataRowToModel(DataRow row)
		{
			ESMonitor.Model.Devs model=new ESMonitor.Model.Devs();
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
					model.VideoURL=row["VideoURL"].ToString();
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
			strSql.Append("select Id,DevCode,StatId,StartTime,PreEndTime,EndTime,DevStatus,VideoURL ");
			strSql.Append(" FROM T_Devs ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			strSql.Append(" Id,DevCode,StatId,StartTime,PreEndTime,EndTime,DevStatus,VideoURL ");
			strSql.Append(" FROM T_Devs ");
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
            strSql.Append("select count(1) FROM T_Devs INNER JOIN T_Stats ON T_Devs.StatId = T_Stats.Id ");
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
			strSql.Append(")AS Row, T.*  from T_Devs T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}
		
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
            SqlParameter[] parameters = {
				new SqlParameter("@PageSize", SqlDbType.Int),
				new SqlParameter("@PageIndex", SqlDbType.Int),
				new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
			};
            parameters[0].Value = PageSize;
            parameters[1].Value = PageIndex;
            parameters[2].Value = strWhere;
            return DbHelperSQL.RunProcedure("T_Devs_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool ExistsAddr(byte[] nodeId)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
			    new SqlParameter("@NodeId", SqlDbType.Binary,4)
			};
            parameters[0].Value = nodeId;

            int result = DbHelperSQL.RunProcedure("T_DevAddr_Exists", parameters, out rowsAffected);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddAddr(int devId, byte[] nodeId)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@NodeId", SqlDbType.Binary,4)};
            parameters[0].Value = devId;
            parameters[1].Value = nodeId;

            DbHelperSQL.RunProcedure("T_DevAddr_ADD", parameters, out rowsAffected);
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
        ///  更新一条数据
        /// </summary>
        public bool UpdateDevAddr(int devId, byte[] nodeId)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@NodeId", SqlDbType.Binary,4)};
            parameters[0].Value = devId;
            parameters[1].Value = nodeId;

            DbHelperSQL.RunProcedure("T_DevAddr_Update", parameters, out rowsAffected);
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
        /// 获得数据列表
        /// </summary>
        public DataSet GetDevAddrList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DevId,NodeId FROM T_DevAddr");

            return DbHelperSQL.Query(strSql.ToString());
        }
        
        //public byte[] GetDevAddr(int devId)
        //{
            
        //}
		#endregion  MethodEx
	}
}

