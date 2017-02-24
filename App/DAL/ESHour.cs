
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:ESHour
	/// </summary>
	public class EsHour
	{
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8)
			};
			parameters[0].Value = id;

			var result= DbHelperSql.RunProcedure("T_ESHour_Exists",parameters,out rowsAffected);
			return result==1;
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public long Add(Model.EsHour model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,8),
					new SqlParameter("@StatId", SqlDbType.Int,4),
					new SqlParameter("@TP", SqlDbType.Float,8),
					new SqlParameter("@DB", SqlDbType.Float,8),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@DataStatus", SqlDbType.Char,1),
					new SqlParameter("@ValidDataNum", SqlDbType.Int,4),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@Country", SqlDbType.VarChar,20),
					new SqlParameter("@Pm25", SqlDbType.Float, 8),
					new SqlParameter("@Pm100", SqlDbType.Float, 8) };
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.StatId;
			parameters[2].Value = model.Tp;
			parameters[3].Value = model.Db;
			parameters[4].Value = model.UpdateTime;
			parameters[5].Value = model.DataStatus;
			parameters[6].Value = model.ValidDataNum;
			parameters[7].Value = model.DevId;
			parameters[8].Value = model.Country;
			parameters[9].Value = model.Pm25;
			parameters[10].Value = model.Pm100;
			DbHelperSql.RunProcedure("T_ESHour_ADD",parameters,out rowsAffected);
			return (long)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.EsHour model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,8),
					new SqlParameter("@StatId", SqlDbType.Int,4),
					new SqlParameter("@TP", SqlDbType.Float,8),
					new SqlParameter("@DB", SqlDbType.Float,8),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@DataStatus", SqlDbType.Char,1),
					new SqlParameter("@ValidDataNum", SqlDbType.Int,4),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@Country", SqlDbType.VarChar,20),
					new SqlParameter("@Pm25", SqlDbType.Float, 8),
					new SqlParameter("@Pm100", SqlDbType.Float, 8) };
			parameters[0].Value = model.Id;
			parameters[1].Value = model.StatId;
			parameters[2].Value = model.Tp;
			parameters[3].Value = model.Db;
			parameters[4].Value = model.UpdateTime;
			parameters[5].Value = model.DataStatus;
			parameters[6].Value = model.ValidDataNum;
			parameters[7].Value = model.DevId;
			parameters[8].Value = model.Country;
			parameters[9].Value = model.Pm25;
			parameters[10].Value = model.Pm100;

			DbHelperSql.RunProcedure("T_ESHour_Update",parameters,out rowsAffected);
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
		public bool Delete(long id)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8)
			};
			parameters[0].Value = id;

			DbHelperSql.RunProcedure("T_ESHour_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from T_ESHour ");
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
		public Model.EsHour GetModel(int id)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8)
			};
			parameters[0].Value = id;

			var ds= DbHelperSql.RunProcedure("T_ESHour_GetModel",parameters,"ds");
			return ds.Tables[0].Rows.Count>0 ? DataRowToModel(ds.Tables[0].Rows[0]) : null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.EsHour DataRowToModel(DataRow row)
		{
			var model=new Model.EsHour();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=long.Parse(row["Id"].ToString());
				}
				if (row["StatId"] != null && row["StatId"].ToString() != "")
				{
					model.StatId=int.Parse(row["StatId"].ToString());
				}
				if(row["TP"]!=null && row["TP"].ToString()!="")
				{
					model.Tp=double.Parse(row["TP"].ToString());
				}
				if(row["DB"]!=null && row["DB"].ToString()!="")
				{
					model.Db=double.Parse(row["DB"].ToString());
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
				}
				if (row["DevId"] != null && row["DevId"].ToString() != "")
				{
					model.DevId = int.Parse(row["DevId"].ToString());
				}
				if (row["Country"] != null)
				{
					model.Country = row["Country"].ToString();
				}
				if(row["DataStatus"]!=null)
				{
					model.DataStatus=row["DataStatus"].ToString();
				}
				if(row["ValidDataNum"]!=null && row["ValidDataNum"].ToString()!="")
				{
					model.ValidDataNum=int.Parse(row["ValidDataNum"].ToString());
				}
				if (row["DevId"] != null && row["DevId"].ToString() != "")
				{
					model.DevId = int.Parse(row["DevId"].ToString());
				}
				if (row["Country"] != null)
				{
					model.Country = row["Country"].ToString();
				}
				if (row["PM25"] != null)
				{
					model.Pm25 = double.Parse(row["PM25"].ToString());
				}
				if (row["PM100"] != null)
				{
					model.Pm100 = double.Parse(row["PM100"].ToString());
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
			strSql.Append("select * ");
			strSql.Append(" FROM T_ESHour ");
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
			strSql.Append(" * ");
			strSql.Append(" FROM T_ESHour ");
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
			strSql.Append("select count(1) FROM T_ESHour ");
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
			strSql.Append(")AS Row, T.*  from T_ESHour T ");
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
			return DbHelperSql.RunProcedure("T_ESHour_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx
		/// <summary>
		/// 查询检测点的CMP小时均值
		/// </summary>
		/// <param name="country"></param>
		/// <param name="strWhere"></param>
		/// <returns></returns>
		public DataSet GetAvgCmpStatList(string country, string strWhere)
		{
			IDataParameter[] parameters = {
				new SqlParameter("@Country", SqlDbType.VarChar,20),
				new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
			};

			parameters[0].Value = country;
			parameters[1].Value = strWhere;

			return DbHelperSql.RunProcedure("T_ESHour_GetAvgCMPStatList", parameters, "ds");
		}

		/// <summary>
		/// 查询检测点的噪音小时均值
		/// </summary>
		/// <param name="country"></param>
		/// <param name="strWhere"></param>
		/// <returns></returns>
		public DataSet GetAvgNoiseStatList(string country, string strWhere)
		{
			IDataParameter[] parameters = {
				new SqlParameter("@Country", SqlDbType.VarChar,20),
				new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
			};

			parameters[0].Value = country;
			parameters[1].Value = strWhere;

			return DbHelperSql.RunProcedure("T_ESHour_GetAvgNoiseStatList", parameters, "ds");
		} 
		#endregion  MethodEx
	}
}

