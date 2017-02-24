
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
    /// <summary>
    /// 数据访问类:ESDay
    /// </summary>
    public partial class ESDay
    {
        public ESDay()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(long Id)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8)
			};
            parameters[0].Value = Id;

            int result = DbHelperSQL.RunProcedure("T_ESDay_Exists", parameters, out rowsAffected);
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
        public long Add(ESMonitor.Model.ESDay model)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8),
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
            parameters[2].Value = model.TP;
            parameters[3].Value = model.DB;
            parameters[4].Value = model.UpdateTime;
            parameters[5].Value = model.DataStatus;
            parameters[6].Value = model.ValidDataNum;
            parameters[7].Value = model.DevId;
            parameters[8].Value = model.Country;
            parameters[9].Value = model.Pm25;
            parameters[10].Value = model.Pm100;

            DbHelperSQL.RunProcedure("T_ESDay_ADD", parameters, out rowsAffected);
            return (long)parameters[0].Value;
        }

        /// <summary>
        ///  更新一条数据
        /// </summary>
        public bool Update(ESMonitor.Model.ESDay model)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8),
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
            parameters[2].Value = model.TP;
            parameters[3].Value = model.DB;
            parameters[4].Value = model.UpdateTime;
            parameters[5].Value = model.DataStatus;
            parameters[6].Value = model.ValidDataNum;
            parameters[7].Value = model.DevId;
            parameters[8].Value = model.Country;
            parameters[9].Value = model.Pm25;
            parameters[10].Value = model.Pm100;

            DbHelperSQL.RunProcedure("T_ESDay_Update", parameters, out rowsAffected);
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
        public bool Delete(long Id)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8)
			};
            parameters[0].Value = Id;

            DbHelperSQL.RunProcedure("T_ESDay_Delete", parameters, out rowsAffected);
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
            strSql.Append("delete from T_ESDay ");
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
        public ESMonitor.Model.ESDay GetModel(long Id)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt,8)
			};
            parameters[0].Value = Id;

            ESMonitor.Model.ESDay model = new ESMonitor.Model.ESDay();
            DataSet ds = DbHelperSQL.RunProcedure("T_ESDay_GetModel", parameters, "ds");
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
        public ESMonitor.Model.ESDay DataRowToModel(DataRow row)
        {
            ESMonitor.Model.ESDay model = new ESMonitor.Model.ESDay();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = long.Parse(row["Id"].ToString());
                }
                if (row["StatId"] != null && row["StatId"].ToString() != "")
                {
                    model.StatId = int.Parse(row["StatId"].ToString());
                }
                if (row["TP"] != null && row["TP"].ToString() != "")
                {
                    model.TP = double.Parse(row["TP"].ToString());
                }
                if (row["DB"] != null && row["DB"].ToString() != "")
                {
                    model.DB = double.Parse(row["DB"].ToString());
                }
                if (row["UpdateTime"] != null && row["UpdateTime"].ToString() != "")
                {
                    model.UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
                }
                if (row["DataStatus"] != null)
                {
                    model.DataStatus = row["DataStatus"].ToString();
                }
                if (row["ValidDataNum"] != null && row["ValidDataNum"].ToString() != "")
                {
                    model.ValidDataNum = int.Parse(row["ValidDataNum"].ToString());
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM T_ESDay ");
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
            strSql.Append(" * ");
            strSql.Append(" FROM T_ESDay ");
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
            strSql.Append("select count(1) FROM T_ESDay ");
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
            strSql.Append(")AS Row, T.*  from T_ESDay T ");
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
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            SqlParameter[] parameters = {
				new SqlParameter("@PageSize", SqlDbType.Int),
				new SqlParameter("@PageIndex", SqlDbType.Int),
				new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
			};
            parameters[0].Value = PageSize;
            parameters[1].Value = PageIndex;
            parameters[2].Value = strWhere;
            return DbHelperSQL.RunProcedure("T_ESDay_GetListByPage", parameters, "ds");
        }

        #endregion  Method
        #region  MethodEx
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetStatESPerCountry(string country)
        {
            SqlParameter[] parameters = {
				new SqlParameter("@Country", SqlDbType.VarChar, 20)
			};
            parameters[0].Value = country;

            return DbHelperSQL.RunProcedure("T_ESDay_GetStatESPerCountry", parameters, "ds");
        }

        public DataSet GetAvgNoiseList(string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgNoiseList", parameters, "ds");
        }

        public DataSet GetAvgCMPList(string strWhere)
        {
            SqlParameter[] parameters = { 
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };
            parameters[0].Value = strWhere;


            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgCMPList", parameters, "ds");
        }

        public DataSet GetAvgPM25List(string strWhere)
        {
            SqlParameter[] parameters = { 
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };
            parameters[0].Value = strWhere;


            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgPM25List", parameters, "ds");
        }

        public DataSet GetAvgPM100List(string strWhere)
        {
            SqlParameter[] parameters = { 
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };
            parameters[0].Value = strWhere;


            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgPM100List", parameters, "ds");
        }

        public DataSet GetAvgCMPOrderList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgCMPOrderList", parameters, "ds");
        }

        public DataSet GetAvgPM25OrderList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgPM25OrderList", parameters, "ds");
        }

        public DataSet GetAvgPM100OrderList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgPM100OrderList", parameters, "ds");
        }

        public DataSet GetAvgNoiseOrderList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgNoiseOrderList", parameters, "ds");
        }

        public DataSet GetAvgCMPStatList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgCMPStatList", parameters, "ds");
        }

        public DataSet GetAvgPM25StatList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgPM25StatList", parameters, "ds");
        }

        public DataSet GetAvgPM100StatList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgPM100StatList", parameters, "ds");
        }

        public DataSet GetAvgNoiseStatList(string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            return DbHelperSQL.RunProcedure("T_ESDay_GetAvgNoiseStatList", parameters, "ds");
        }
        #endregion  MethodEx
    }
}

