using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace ESMonitor.DAL
{
	/// <summary>
	/// 数据访问类:GroupModules
	/// </summary>
	public partial class GroupModules
	{
		public GroupModules()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("GroupId", "T_GroupModules"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int GroupId,int ModuleId)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)			};
			parameters[0].Value = GroupId;
			parameters[1].Value = ModuleId;

			int result= DbHelperSQL.RunProcedure("T_GroupModules_Exists",parameters,out rowsAffected);
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
        public bool Add(int GroupId, int ModuleId)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)};
			parameters[0].Value = GroupId;
			parameters[1].Value = ModuleId;

			DbHelperSQL.RunProcedure("T_GroupModules_ADD",parameters,out rowsAffected);
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
		public bool Update(ESMonitor.Model.GroupModules model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)};
			parameters[0].Value = model.GroupId;
			parameters[1].Value = model.ModuleId;

			DbHelperSQL.RunProcedure("T_GroupModules_Update",parameters,out rowsAffected);
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
		public bool Delete(int GroupId,int ModuleId)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)			};
			parameters[0].Value = GroupId;
			parameters[1].Value = ModuleId;

			DbHelperSQL.RunProcedure("T_GroupModules_Delete",parameters,out rowsAffected);
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
		public ESMonitor.Model.GroupModules GetModel(int GroupId,int ModuleId)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@GroupId", SqlDbType.Int,4),
					new SqlParameter("@ModuleId", SqlDbType.Int,4)			};
			parameters[0].Value = GroupId;
			parameters[1].Value = ModuleId;

			ESMonitor.Model.GroupModules model=new ESMonitor.Model.GroupModules();
			DataSet ds= DbHelperSQL.RunProcedure("T_GroupModules_GetModel",parameters,"ds");
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
		public ESMonitor.Model.GroupModules DataRowToModel(DataRow row)
		{
			ESMonitor.Model.GroupModules model=new ESMonitor.Model.GroupModules();
			if (row != null)
			{
				if(row["GroupId"]!=null && row["GroupId"].ToString()!="")
				{
					model.GroupId=int.Parse(row["GroupId"].ToString());
				}
				if(row["ModuleId"]!=null && row["ModuleId"].ToString()!="")
				{
					model.ModuleId=int.Parse(row["ModuleId"].ToString());
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
			strSql.Append("select GroupId,ModuleId ");
			strSql.Append(" FROM T_GroupModules ");
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
			strSql.Append(" GroupId,ModuleId ");
			strSql.Append(" FROM T_GroupModules ");
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
			strSql.Append("select count(1) FROM T_GroupModules ");
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
				strSql.Append("order by T.ModuleId desc");
			}
			strSql.Append(")AS Row, T.*  from T_GroupModules T ");
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
            return DbHelperSQL.RunProcedure("T_GroupModules_GetListByPage", parameters, "ds");
		}

		#endregion  Method
        #region  MethodEx
        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetModules(int groupId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ModuleId FROM T_GroupModules where GroupId=@GroupId");
            SqlParameter[] parameters = {
				new SqlParameter("@GroupId", SqlDbType.Int,4)
			};
            parameters[0].Value = groupId;

            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        #endregion  MethodEx
    }
}

