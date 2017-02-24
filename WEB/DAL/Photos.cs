using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ESMonitor.DAL
{
    public class Photos
    {
        public int Add(Model.Photos model)
        {
            int rowsAffected;
            IDataParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.Int, 8),
                new SqlParameter("@DevId", SqlDbType.Int, 4),
                new SqlParameter("@AddTime", SqlDbType.DateTime),
                new SqlParameter("@FileName", SqlDbType.VarChar, 100)
            };
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = model.DevId;
            parameters[2].Value = model.AddTime;
            parameters[3].Value = model.FileName;

            DbHelperSQL.RunProcedure("T_Photos_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        public bool Delete(int id)
        {
            int rowsAffected;
            IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,8)
			};
            parameters[0].Value = id;

            DbHelperSQL.RunProcedure("T_Photos_Delete", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public Model.Photos GetModel(int id)
        {
            IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,8)
			};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.RunProcedure("T_Photos_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public Model.Photos DataRowToModel(DataRow row)
        {
            Model.Photos model = new Model.Photos();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.ID = int.Parse(row["Id"].ToString());
                }
                if (row["DevId"] != null && row["DevId"].ToString() != "")
                {
                    model.DevId = int.Parse(row["DevId"].ToString());
                }
                if (row["DnsAddr"] != null && row["DnsAddr"].ToString() != "")
                {
                    model.AddTime = DateTime.Parse(row["DnsAddr"].ToString());
                }
                if (row["UserName"] != null && row["UserName"].ToString() != "")
                {
                    model.FileName = row["UserName"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT T1.ID,T1.AddTime,T1.FileName FROM [T_Photos] T1 INNER JOIN [T_Devs] T2 ON T1.DevId = T2.Id");
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
            strSql.Append(" Id,DevId,AddTime,FileName");
            strSql.Append(" FROM T_Photos ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
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
            strSql.Append(")AS Row, T.*  from T_Photos T ");
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
            return DbHelperSQL.RunProcedure("T_Photos_GetListByPage", parameters, "ds");
        }

        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM T_Photos INNER JOIN T_Devs ON T_Photos.DevId = T_Devs.Id");
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
    }
}
