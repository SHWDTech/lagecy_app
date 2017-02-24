using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
    /// <summary>
    /// 数据访问类:Alarms
    /// </summary>
    public partial class Alarms
    {
        public Alarms()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            int result = DbHelperSQL.RunProcedure("T_Alarms_Exists", parameters, out rowsAffected);
            if (result == 1)
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
        public int Add(ESMonitor.Model.Alarms model)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@StatId", SqlDbType.Int,4),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@DustType", SqlDbType.SmallInt,2),
					new SqlParameter("@FaultVal", SqlDbType.Float,8),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@Country", SqlDbType.VarChar,20)};
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = model.StatId;
            parameters[2].Value = model.DevId;
            parameters[3].Value = model.DustType;
            parameters[4].Value = model.FaultVal;
            parameters[5].Value = model.UpdateTime;
            parameters[6].Value = model.Country;

            DbHelperSQL.RunProcedure("T_Alarms_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        /// <summary>
        ///  更新一条数据
        /// </summary>
        public bool Update(ESMonitor.Model.Alarms model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@StatId", SqlDbType.Int,4),
					new SqlParameter("@DevId", SqlDbType.Int,4),
					new SqlParameter("@DustType", SqlDbType.SmallInt,2),
					new SqlParameter("@FaultVal", SqlDbType.Float,8),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@Country", SqlDbType.VarChar,20)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.StatId;
            parameters[2].Value = model.DevId;
            parameters[3].Value = model.DustType;
            parameters[4].Value = model.FaultVal;
            parameters[5].Value = model.UpdateTime;
            parameters[6].Value = model.Country;

            DbHelperSQL.RunProcedure("T_Alarms_Update", parameters, out rowsAffected);
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
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            DbHelperSQL.RunProcedure("T_Alarms_Delete", parameters, out rowsAffected);
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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from T_Alarms ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public ESMonitor.Model.Alarms GetModel(int Id)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = Id;

            ESMonitor.Model.Alarms model = new ESMonitor.Model.Alarms();
            DataSet ds = DbHelperSQL.RunProcedure("T_Alarms_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
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
        public ESMonitor.Model.Alarms DataRowToModel(DataRow row)
        {
            ESMonitor.Model.Alarms model = new ESMonitor.Model.Alarms();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["StatId"] != null && row["StatId"].ToString() != "")
                {
                    model.StatId = int.Parse(row["StatId"].ToString());
                }
                if (row["DevId"] != null && row["DevId"].ToString() != "")
                {
                    model.DevId = int.Parse(row["DevId"].ToString());
                }
                if (row["DustType"] != null && row["DustType"].ToString() != "")
                {
                    model.DustType = int.Parse(row["DustType"].ToString());
                }
                if (row["FaultVal"] != null && row["FaultVal"].ToString() != "")
                {
                    model.FaultVal = decimal.Parse(row["FaultVal"].ToString());
                }
                if (row["UpdateTime"] != null && row["UpdateTime"].ToString() != "")
                {
                    model.UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
                }
                if (row["Country"] != null)
                {
                    model.Country = row["Country"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,StatId,DevId,DustType,FaultVal,UpdateTime,Country ");
            strSql.Append(" FROM T_Alarms ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,StatId,DevId,DustType,FaultVal,UpdateTime,Country ");
            strSql.Append(" FROM T_Alarms ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_Alarms ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from T_Alarms T ");
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
            return DbHelperSQL.RunProcedure("T_Alarms_GetRecordByPage",parameters,"ds");
        }

        #endregion  Method
        #region  MethodEx
        public DataSet GetDustOverDataCount(string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
                    };
            parameters[0].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_Alarms_GetDustOverDataCount", parameters, "ds");
        }
        
        public DataSet GetDustOverDataPerDay(string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
                    };
            parameters[0].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_Alarms_GetDustOverDataPerDay", parameters, "ds");
        }
        
        #endregion  MethodEx
    }
}

