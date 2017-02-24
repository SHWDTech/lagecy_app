using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ESMonitor.DAL
{
    public class Camera
    {
        public int Add(Model.Camera model)
        {
            int rowsAffected;
            IDataParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.Int, 8),
                new SqlParameter("@DevId", SqlDbType.Int, 4),
                new SqlParameter("@DnsAddr", SqlDbType.VarChar, 50),
                new SqlParameter("@UserName", SqlDbType.VarChar, 50),
                new SqlParameter("@PassWord", SqlDbType.VarChar, 50)
            };
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = model.DevId;
            parameters[2].Value = model.DnsAddr;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.PassWord;

            DbHelperSQL.RunProcedure("T_Camera_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        public bool Update(Model.Camera model)
        {
            int rowsAffected;
            IDataParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.Int, 8),
                new SqlParameter("@DevId", SqlDbType.Int, 4),
                new SqlParameter("@DnsAddr", SqlDbType.VarChar, 50),
                new SqlParameter("@UserName", SqlDbType.VarChar, 50),
                new SqlParameter("@PassWord", SqlDbType.VarChar, 50)
            };
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DevId;
            parameters[2].Value = model.DnsAddr;
            parameters[3].Value = model.UserName;
            parameters[4].Value = model.PassWord;

            DbHelperSQL.RunProcedure("T_Camera_Update", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            int rowsAffected;
            IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,8)
			};
            parameters[0].Value = id;

            DbHelperSQL.RunProcedure("T_Camera_Delete", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public Model.Camera GetModel(int devId)
        {
            IDataParameter[] parameters = {
					new SqlParameter("@DevId", SqlDbType.Int,8)
			};
            parameters[0].Value = devId;

            DataSet ds = DbHelperSQL.RunProcedure("T_Camera_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public Model.Camera DataRowToModel(DataRow row)
        {
            Model.Camera model = new Model.Camera();
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
                    model.DnsAddr = row["DnsAddr"].ToString();
                }
                if (row["UserName"] != null && row["UserName"].ToString() != "")
                {
                    model.UserName = row["UserName"].ToString();
                }
                if (row["PassWord"] != null && row["PassWord"].ToString() != "")
                {
                    model.PassWord = row["PassWord"].ToString();
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Id,DevId,DnsAddr,UserName,PassWord ");
            strSql.Append(" FROM T_Camera");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string DnsAddr)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@DnsAddr", SqlDbType.VarChar,50)
			};
            parameters[0].Value = DnsAddr;

            int result = DbHelperSQL.RunProcedure("T_Camera_Exists", parameters, out rowsAffected);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
