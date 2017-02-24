﻿
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

// ReSharper disable once CheckNamespace
namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Stats
	/// </summary>
	public class Stats
	{
	    #region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "T_Stats"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(string statCode)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@StatCode", SqlDbType.NVarChar,20)
			};
            parameters[0].Value = statCode;

			int result= DbHelperSQL.RunProcedure("T_Stats_Exists",parameters,out rowsAffected);
			if(result==1)
			{
				return true;
			}
		    return false;
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public int Add(Model.Stats model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@StatCode", SqlDbType.VarChar,20),
					new SqlParameter("@StatName", SqlDbType.VarChar,50),
					new SqlParameter("@ChargeMan", SqlDbType.VarChar,20),
					new SqlParameter("@Telepone", SqlDbType.VarChar,20),
					new SqlParameter("@Longitude", SqlDbType.Decimal,5),
					new SqlParameter("@Latitude", SqlDbType.Decimal,5),
					new SqlParameter("@Department", SqlDbType.VarChar,30),
					new SqlParameter("@Address", SqlDbType.VarChar,50),
					new SqlParameter("@Country", SqlDbType.VarChar,20),
					new SqlParameter("@Street", SqlDbType.VarChar,20),
					new SqlParameter("@Square", SqlDbType.Float,8),
					new SqlParameter("@ProStartTime", SqlDbType.DateTime),
					new SqlParameter("@Stage", SqlDbType.TinyInt,1),
                    new SqlParameter("@AlarmType", SqlDbType.Int,4) };
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.StatCode;
			parameters[2].Value = model.StatName;
			parameters[3].Value = model.ChargeMan;
			parameters[4].Value = model.Telepone;
			parameters[5].Value = model.Longitude;
            parameters[6].Value = model.Latitude;
			parameters[7].Value = model.Department;
			parameters[8].Value = model.Address;
			parameters[9].Value = model.Country;
			parameters[10].Value = model.Street;
			parameters[11].Value = model.Square;
			parameters[12].Value = model.ProStartTime;
			parameters[13].Value = model.Stage;
		    parameters[14].Value = model.AlarmType;

			DbHelperSQL.RunProcedure("T_Stats_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Model.Stats model)
		{
			int rowsAffected;
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@StatCode", SqlDbType.VarChar,20),
					new SqlParameter("@StatName", SqlDbType.VarChar,50),
					new SqlParameter("@ChargeMan", SqlDbType.VarChar,20),
					new SqlParameter("@Telepone", SqlDbType.VarChar,20),
					new SqlParameter("@Longitude", SqlDbType.Decimal,5),
					new SqlParameter("@Department", SqlDbType.VarChar,30),
					new SqlParameter("@Address", SqlDbType.VarChar,50),
					new SqlParameter("@Country", SqlDbType.VarChar,20),
					new SqlParameter("@Street", SqlDbType.VarChar,20),
					new SqlParameter("@Square", SqlDbType.Float,8),
					new SqlParameter("@ProStartTime", SqlDbType.DateTime),
					new SqlParameter("@Stage", SqlDbType.TinyInt,1),
                    new SqlParameter("@Latitude", SqlDbType.Decimal, 5)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.StatCode;
			parameters[2].Value = model.StatName;
			parameters[3].Value = model.ChargeMan;
			parameters[4].Value = model.Telepone;
			parameters[5].Value = model.Longitude;
			parameters[6].Value = model.Department;
			parameters[7].Value = model.Address;
			parameters[8].Value = model.Country;
			parameters[9].Value = model.Street;
			parameters[10].Value = model.Square;
			parameters[11].Value = model.ProStartTime;
			parameters[12].Value = model.Stage;
		    parameters[13].Value = model.Latitude;

			DbHelperSQL.RunProcedure("T_Stats_Update",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
		    return false;
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

			DbHelperSQL.RunProcedure("T_Stats_Delete",parameters,out rowsAffected);
			if (rowsAffected > 0)
			{
				return true;
			}
		    return false;
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Stats ");
			strSql.Append(" where Id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
		    return false;
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Stats GetModel(int id)
		{
			IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			//Model.Stats model=new Model.Stats();
			DataSet ds= DbHelperSQL.RunProcedure("T_Stats_GetModel",parameters,"ds");
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
		    return null;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		// ReSharper disable once FunctionComplexityOverflow
		public Model.Stats DataRowToModel(DataRow row)
		{
			Model.Stats model=new Model.Stats();
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
				if(row["StatName"]!=null)
				{
					model.StatName=row["StatName"].ToString();
				}
				if(row["ChargeMan"]!=null)
				{
					model.ChargeMan=row["ChargeMan"].ToString();
				}
				if(row["Telepone"]!=null)
				{
					model.Telepone=row["Telepone"].ToString();
				}
				if(row["Longitude"]!=null && row["Longitude"].ToString()!="")
				{
					model.Longitude=decimal.Parse(row["Longitude"].ToString());
				}
				if(row["Latitude"]!=null && row["Latitude"].ToString()!="")
				{
					model.Latitude=decimal.Parse(row["Latitude"].ToString());
				}
				if(row["Department"]!=null)
				{
					model.Department=row["Department"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["Country"]!=null)
				{
					model.Country=row["Country"].ToString();
				}
				if(row["Street"]!=null)
				{
					model.Street=row["Street"].ToString();
				}
				if(row["Square"]!=null && row["Square"].ToString()!="")
				{
					model.Square=decimal.Parse(row["Square"].ToString());
				}
				if(row["ProStartTime"]!=null && row["ProStartTime"].ToString()!="")
				{
					model.ProStartTime=DateTime.Parse(row["ProStartTime"].ToString());
				}
				if(row["Stage"]!=null && row["Stage"].ToString()!="")
				{
					model.Stage=int.Parse(row["Stage"].ToString());
				}
			    if (row["AlarmType"] != null && row["AlarmType"].ToString() != "")
			    {
			        model.AlarmType = int.Parse(row["AlarmType"].ToString());
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
            strSql.Append("select Id,StatCode,StatName,ChargeMan,Telepone,Longitude,Latitude,Department,Address,Country,Street,Square,ProStartTime,Stage ");
			strSql.Append(" FROM T_Stats ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(top>0)
			{
				strSql.Append(" top "+top);
			}
            strSql.Append(" Id,StatCode,StatName,ChargeMan,Telepone,Longitude,Latitude,Department,Address,Country,Street,Square,ProStartTime,Stage ");
			strSql.Append(" FROM T_Stats ");
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
			strSql.Append("select count(1) FROM T_Stats ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
		    return Convert.ToInt32(obj);
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
			strSql.Append(")AS Row, T.*  from T_Stats T ");
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
            return DbHelperSQL.RunProcedure("T_Stats_GetListByPage", parameters, "ds");
		}

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

