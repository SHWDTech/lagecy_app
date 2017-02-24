using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ESMonitor.DAL
{
    public class AlarmType
    {
        public int Add(Model.AlarmType model)
        {
            int rowsAffected;
            IDataParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.Int, 4),
                new SqlParameter("@Name", SqlDbType.NChar, 25),
                new SqlParameter("@DustRange", SqlDbType.Float, 8),
                new SqlParameter("@DbRange", SqlDbType.Float, 8)
            };
            parameters[0].Direction = ParameterDirection.Output;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.DustRange;
            parameters[3].Value = model.DbRange;

            DbHelperSQL.RunProcedure("T_AlarmType_ADD", parameters, out rowsAffected);
            return (int)parameters[0].Value;
        }

        public bool Update(Model.AlarmType model)
        {
            int rowsAffected;
            IDataParameter[] parameters =
            {
                new SqlParameter("@Id", SqlDbType.Int, 4),
                new SqlParameter("@Name", SqlDbType.NChar, 25),
                new SqlParameter("@DustRange", SqlDbType.Float, 8),
                new SqlParameter("@DbRange", SqlDbType.Float, 8)
            };
            parameters[0].Value = model.Id;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.DustRange;
            parameters[3].Value = model.DbRange;

            DbHelperSQL.RunProcedure("T_AlarmType_Update", parameters, out rowsAffected);
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
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            DbHelperSQL.RunProcedure("T_AlarmType_Delete", parameters, out rowsAffected);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public Model.AlarmType GetModel(int id)
        {
            IDataParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.RunProcedure("T_AlarmType_GetModel", parameters, "ds");
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            return null;
        }

        public Model.AlarmType DataRowToModel(DataRow row)
        {
            Model.AlarmType model = new Model.AlarmType();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Name"] != null && row["Name"].ToString() != "")
                {
                    model.Name = row["Name"].ToString();
                }
                if (row["DustRange"] != null && row["DustRange"].ToString() != "")
                {
                    model.DustRange = double.Parse(row["DustRange"].ToString());
                }
                if (row["DbRange"] != null && row["DbRange"].ToString() != "")
                {
                    model.DbRange = double.Parse(row["DbRange"].ToString());
                }
            }
            return model;
        }

        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Id,Name,DustRange,DbRange ");
            strSql.Append(" FROM T_AlarmType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
    }
}
