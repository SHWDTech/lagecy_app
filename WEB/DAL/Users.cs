using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users
	{
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UserId", "T_Users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from T_Users");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
			parameters[0].Value = UserId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Users");
            strSql.Append(" where UserName=@UserName");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = userName;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        public bool CheckLogin(string userName, string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Users");
            strSql.Append(" where UserName=@UserName and Pwd=@Pwd");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
                    new SqlParameter("@Pwd", SqlDbType.NVarChar,32),
			};
            parameters[0].Value = userName;
            parameters[1].Value = pwd;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(ESMonitor.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_Users(");
			strSql.Append("UserName,Pwd,Mobile,Email,Status,RegTime,RoleId,LastTime,NowTime,ReMark)");
			strSql.Append(" values (");
			strSql.Append("@UserName,@Pwd,@Mobile,@Email,@Status,@RegTime,@RoleId,@LastTime,@NowTime,@ReMark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,32),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@Email", SqlDbType.NVarChar,128),
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@RegTime", SqlDbType.DateTime),
					new SqlParameter("@RoleId", SqlDbType.Int,4),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@NowTime", SqlDbType.DateTime),
					new SqlParameter("@ReMark", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Pwd;
			parameters[2].Value = model.Mobile;
			parameters[3].Value = model.Email;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.RegTime;
			parameters[6].Value = model.RoleId;
			parameters[7].Value = model.LastTime;
			parameters[8].Value = model.NowTime;
			parameters[9].Value = model.ReMark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(ESMonitor.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_Users set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Pwd=@Pwd,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("Email=@Email,");
			strSql.Append("Status=@Status,");
			strSql.Append("RegTime=@RegTime,");
			strSql.Append("RoleId=@RoleId,");
			strSql.Append("LastTime=@LastTime,");
			strSql.Append("NowTime=@NowTime,");
			strSql.Append("ReMark=@ReMark");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,32),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,20),
					new SqlParameter("@Email", SqlDbType.NVarChar,128),
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@RegTime", SqlDbType.DateTime),
					new SqlParameter("@RoleId", SqlDbType.Int,4),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@NowTime", SqlDbType.DateTime),
					new SqlParameter("@ReMark", SqlDbType.NVarChar,50),
					new SqlParameter("@UserId", SqlDbType.Int,4)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Pwd;
			parameters[2].Value = model.Mobile;
			parameters[3].Value = model.Email;
			parameters[4].Value = model.Status;
			parameters[5].Value = model.RegTime;
			parameters[6].Value = model.RoleId;
			parameters[7].Value = model.LastTime;
			parameters[8].Value = model.NowTime;
			parameters[9].Value = model.ReMark;
			parameters[10].Value = model.UserId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Users ");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
			parameters[0].Value = UserId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string UserIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_Users ");
			strSql.Append(" where UserId in ("+UserIdlist + ")  ");
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
		public ESMonitor.Model.Users GetModel(int UserId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserId,UserName,Pwd,Mobile,Email,Status,RegTime,RoleId,LastTime,NowTime,ReMark from T_Users ");
			strSql.Append(" where UserId=@UserId");
			SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)
			};
			parameters[0].Value = UserId;

			ESMonitor.Model.Users model=new ESMonitor.Model.Users();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
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
		public ESMonitor.Model.Users DataRowToModel(DataRow row)
		{
			ESMonitor.Model.Users model=new ESMonitor.Model.Users();
			if (row != null)
			{
				if(row["UserId"]!=null && row["UserId"].ToString()!="")
				{
					model.UserId=int.Parse(row["UserId"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["Mobile"]!=null)
				{
					model.Mobile=row["Mobile"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Status"]!=null && row["Status"].ToString()!="")
				{
					model.Status=int.Parse(row["Status"].ToString());
				}
				if(row["RegTime"]!=null && row["RegTime"].ToString()!="")
				{
					model.RegTime=DateTime.Parse(row["RegTime"].ToString());
				}
				if(row["RoleId"]!=null && row["RoleId"].ToString()!="")
				{
					model.RoleId=int.Parse(row["RoleId"].ToString());
				}
				if(row["LastTime"]!=null && row["LastTime"].ToString()!="")
				{
					model.LastTime=DateTime.Parse(row["LastTime"].ToString());
				}
				if(row["NowTime"]!=null && row["NowTime"].ToString()!="")
				{
					model.NowTime=DateTime.Parse(row["NowTime"].ToString());
				}
				if(row["ReMark"]!=null)
				{
					model.ReMark=row["ReMark"].ToString();
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
			strSql.Append("select UserId,UserName,Pwd,Mobile,Email,Status,RegTime,RoleId,LastTime,NowTime,ReMark ");
			strSql.Append(" FROM T_Users ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

	    public DataSet GetList()
	    {
            StringBuilder strSql=new StringBuilder();
			strSql.Append("select UserId,UserName,Pwd,Mobile,Email,Status,RegTime,RoleId,LastTime,NowTime,ReMark ");
			strSql.Append(" FROM T_Users ");
            return DbHelperSQL.Query(strSql.ToString());
	    }

        /// <summary>
        /// 获取用户名、用户名称集合
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<string> GetUsesList(string strWhere)
        {
            List<string> list = new List<string>();
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select UserId,UserName FROM T_Users");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }

            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    list.Add(dr["UserId"].ToString() + "," + dr["UserName"].ToString());
                }
            }

            return list;
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
			strSql.Append(" UserId,UserName,Pwd,Mobile,Email,Status,RegTime,RoleId,LastTime,NowTime,ReMark ");
			strSql.Append(" FROM T_Users ");
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
			strSql.Append("select count(1) FROM T_Users ");
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
				strSql.Append("order by T.UserId desc");
			}
			strSql.Append(")AS Row, T.*  from T_Users T ");
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
            return DbHelperSQL.RunProcedure("T_Users_GetListByPage", parameters, "ds");
		}

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 判断用户原密码是否正确
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="pwd">原密码</param>
        /// <returns></returns>
        public bool VerifyPassword(int userId, string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from T_Users");
            strSql.Append(" where UserId=@UserId and Pwd=@Pwd");
            SqlParameter[] parameters = {
                     new SqlParameter("@UserId", SqlDbType.Int,4),
					 new SqlParameter("@Pwd", SqlDbType.NVarChar,32)};
            parameters[0].Value = userId;
            parameters[1].Value = pwd;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更改用户密码
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="pwd">新密码</param>
        /// <returns></returns>
        public bool ChangePassword(int userId, string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Users set ");
            strSql.Append("Pwd=@Pwd");
            strSql.Append(" where UserId=@UserId");

            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@Pwd", SqlDbType.NVarChar,32)};
            parameters[0].Value = userId;
            parameters[1].Value = pwd;

            if (DbHelperSQL.ExecuteSql(strSql.ToString(), parameters) >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateStatus(int userId, byte status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Users set ");
            strSql.Append("Status=@Status");
            strSql.Append(" where UserId=@UserId");
            SqlParameter[] parameters = {
					new SqlParameter("@Status", SqlDbType.TinyInt,1),
					new SqlParameter("@UserId", SqlDbType.Int,4)};
            parameters[0].Value = status;
            parameters[1].Value = userId;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateLastTime(int userId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update T_Users set ");
            strSql.Append("LastTime=NowTime,");
            strSql.Append("NowTime=@NowTime");
            strSql.Append(" where UserId=@UserId");
            SqlParameter[] parameters = {
                    new SqlParameter("@NowTime", SqlDbType.DateTime),
					new SqlParameter("@UserId", SqlDbType.Int,4)};
            parameters[0].Value = DateTime.Now;
            parameters[1].Value = userId;
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public ESMonitor.Model.Users GetModel(string userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 UserId,UserName,Pwd,Mobile,Email,Status,RegTime,RoleId,LastTime,NowTime,Remark from T_Users ");
            strSql.Append(" where UserName=@UserName");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)
			};
            parameters[0].Value = userName;

            ESMonitor.Model.Users model = new ESMonitor.Model.Users();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
		#endregion  ExtensionMethod

        #region 用户权限管理
        /// <summary>
        ///  增加权限
        /// </summary>
        public int AddAuth(int userId, int authObjId, int authType)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@AuthObjId", SqlDbType.Int,4),
                    new SqlParameter("@AuthType", SqlDbType.TinyInt,1)};
            parameters[0].Value = userId;
            parameters[1].Value = authObjId;
            parameters[2].Value = authType;

            DbHelperSQL.RunProcedure("T_UserAuthority_ADD", parameters, out rowsAffected);
            return rowsAffected;
        }

        /// <summary>
        /// 批量添加权限
        /// </summary>
        /// <param name="logicGroupId"></param>
        /// <param name="ledCtrls">权限类型、权限对象用逗号分隔</param>
        /// <returns></returns>
        public bool AddAuths(List<int> users, List<String> auths)
        {
            List<string> SQLList = new List<string>();

            foreach (int userId in users)
            {
                 foreach (string auth in auths)
                {
                    string[] str = auth.Split(',');
                    SQLList.Add("insert into T_UserAuthority(AuthObjId,AuthType,UserId) values(" + str[0] + "," + str[1] + "," + userId + ")");
                }
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
        ///  删除用户某个访问权限
        /// </summary>
        public int DelAuth(int userId, int authObjId, int authType)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4),
					new SqlParameter("@AuthObjId", SqlDbType.Int,4),
                    new SqlParameter("@AuthType", SqlDbType.TinyInt,1)};
            parameters[0].Value = userId;
            parameters[1].Value = authObjId;
            parameters[2].Value = authType;

            DbHelperSQL.RunProcedure("T_UserAuthority_Delete", parameters, out rowsAffected);
            return rowsAffected;
        }

        //批量删除用户权限
        public bool DelAuths(int userId, List<String> auths)
        {
            List<string> SQLList = new List<string>();
            foreach (string auth in auths)
            {
                string[] str = auth.Split(',');
                SQLList.Add("delete T_UserAuthority where AuthObjId=" + str[0] + " AND AuthType=" + str[1] + " AND UserId=" + userId + ")");
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
        ///  删除用户权限
        /// </summary>
        public int DelAuths(int userId)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)};
            parameters[0].Value = userId;

            DbHelperSQL.RunProcedure("T_UserAuthority_DeleteByUserId", parameters, out rowsAffected);
            return rowsAffected;
        }

        /// <summary>
        /// 获取用户所有的访问权限
        /// </summary>
        /// <returns></returns>
        public Dictionary<int,List<int>> GetAuths(int userId)
        {
            Dictionary<int, List<int>> authDic = new Dictionary<int, List<int>>();
            SqlParameter[] parameters = {
					new SqlParameter("@UserId", SqlDbType.Int,4)};
            parameters[0].Value = userId;

            DataSet ds = DbHelperSQL.RunProcedure("T_UserAuthority_GetAuths", parameters, "ds");
            if (ds != null)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    int authType = Convert.ToInt32(dr["AuthType"]);

                    if (authDic.ContainsKey(authType))
                    {
                        authDic[authType].Add(Convert.ToInt32(dr["AuthObjId"]));
                    }
                    else
                    {
                        List<int> list = new List<int>();
                        list.Add(Convert.ToInt32(dr["AuthObjId"]));
                        authDic.Add(authType, list);
                    }   
                }
            }

            return authDic;
        }
        #endregion
	}
}

