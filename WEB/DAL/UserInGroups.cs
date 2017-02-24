using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
namespace ESMonitor.DAL
{
    /// <summary>
    /// 数据访问类:UserInGroups
    /// </summary>
    public partial class UserInGroups
    {
        public UserInGroups()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int GroupId, int UserId)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)			};
            parameters[0].Value = GroupId;
            parameters[1].Value = UserId;

            int result = DbHelperSQL.RunProcedure("T_UserInGroups_Exists", parameters, out rowsAffected);
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
        public bool Add(ESMonitor.Model.UserInGroups model)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)};
            parameters[0].Value = model.GroupId;
            parameters[1].Value = model.UserId;

            DbHelperSQL.RunProcedure("T_UserInGroups_ADD", parameters, out rowsAffected);
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
        public bool Delete(int GroupId, int UserId)
        {
            int rowsAffected = 0;
            SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)			};
            parameters[0].Value = GroupId;
            parameters[1].Value = UserId;

            DbHelperSQL.RunProcedure("T_UserInGroups_Delete", parameters, out rowsAffected);
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
        /// 得到一个对象实体
        /// </summary>
        public ESMonitor.Model.UserInGroups GetModel(int GroupId, int UserId)
        {
            SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@UserId", SqlDbType.Int,4)			};
            parameters[0].Value = GroupId;
            parameters[1].Value = UserId;

            ESMonitor.Model.UserInGroups model = new ESMonitor.Model.UserInGroups();
            DataSet ds = DbHelperSQL.RunProcedure("T_UserInGroups_GetModel", parameters, "ds");
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
        public ESMonitor.Model.UserInGroups DataRowToModel(DataRow row)
        {
            ESMonitor.Model.UserInGroups model = new ESMonitor.Model.UserInGroups();
            if (row != null)
            {
                if (row["GroupId"] != null && row["GroupId"].ToString() != "")
                {
                    model.GroupId = int.Parse(row["GroupId"].ToString());
                }
                if (row["UserId"] != null && row["UserId"].ToString() != "")
                {
                    model.UserId = int.Parse(row["UserId"].ToString());
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
            strSql.Append("select GroupId,UserId ");
            strSql.Append(" FROM T_UserInGroups ");
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
            strSql.Append(" GroupId,UserId ");
            strSql.Append(" FROM T_UserInGroups ");
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
            strSql.Append("select count(1) FROM T_UserInGroups ");
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
                strSql.Append("order by T.UserId desc");
            }
            strSql.Append(")AS Row, T.*  from T_UserInGroups T ");
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
            return DbHelperSQL.RunProcedure("T_UserInGroup_GetListByPage", parameters, "ds");
        }

        #endregion  Method
        #region  MethodEx
        /// <summary>
        /// 批量添加用户角色
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddUserInGroups(ArrayList list)
        {
            ArrayList SQLList = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] val = list[i].ToString().Split(',');
                SQLList.Add("insert into T_UserInGroups(GroupId,UserId) values (" + val[0] + "," + val[1] + ")");
            }

            try
            {
                DbHelperSQL.ExecuteSqlTran(SQLList);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 批量删除用户角色
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DeleteUserInGroups(ArrayList list)
        {
            ArrayList SQLList = new ArrayList();

            for (int i = 0; i < list.Count; i++)
            {
                string[] val = list[i].ToString().Split(',');
                SQLList.Add("delete T_UserInGroups where GroupId=" + val[0] + " and UserId=" + val[1]);
            }

            try
            {
                DbHelperSQL.ExecuteSqlTran(SQLList);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 读取用户组列表
        /// </summary>
        /// <param name="groupId"></param>
        /// <returns></returns>
        public DataSet GetUserInGroups(int groupId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Id, Name ");
            strSql.Append("FROM T_UserInGroups INNER JOIN ");
            strSql.Append("T_Users ON T_UserInGroups.UserId = T_Users.UserId ");
            return DbHelperSQL.Query(strSql.ToString() + "where GroupId=" + groupId.ToString());
        }
        #endregion  MethodEx
    }
}

