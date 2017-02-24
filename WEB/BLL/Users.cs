using System;
using System.Data;
using System.Collections.Generic;
using ESMonitor.Model;
namespace ESMonitor.BLL
{
	/// <summary>
	/// Users
	/// </summary>
	public partial class Users
	{
        private readonly ESMonitor.DAL.Users dal = new ESMonitor.DAL.Users();
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UserId)
		{
			return dal.Exists(UserId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(ESMonitor.Model.Users model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(ESMonitor.Model.Users model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int UserId)
		{
			
			return dal.Delete(UserId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserIdlist )
		{
			return dal.DeleteList(UserIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public ESMonitor.Model.Users GetModel(int UserId)
		{
			
			return dal.GetModel(UserId);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

	    public DataSet GetList()
	    {
	        return dal.GetList();
	    }

        /// <summary>
        /// 获取用户名、用户名称集合
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public List<string> GetUsesList(string strWhere)
        {
            return dal.GetUsesList(strWhere);
        }
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<ESMonitor.Model.Users> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<ESMonitor.Model.Users> DataTableToList(DataTable dt)
		{
            List<ESMonitor.Model.Users> modelList = new List<ESMonitor.Model.Users>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                ESMonitor.Model.Users model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

		#endregion  BasicMethod
		#region  ExtensionMethod
        public bool Exists(string userName)
        {
            return dal.Exists(userName);
        }

        public bool CheckLogin(string userName, string pwd)
        {
            return dal.CheckLogin(userName, pwd);
        }
    
        /// <summary>
        /// 判断用户原密码是否正确
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="pwd">原密码</param>
        /// <returns></returns>
        public bool VerifyPassword(int userId, string pwd)
        {
            return dal.VerifyPassword(userId, pwd);
        }

        /// <summary>
        /// 更改用户密码
        /// </summary>
        /// <param name="userId">用户ID</param>
        /// <param name="pwd">新密码</param>
        /// <returns></returns>
        public bool ChangePassword(int userId, string pwd)
        {
            return dal.ChangePassword(userId, pwd);
        }

        public bool UpdateStatus(int userId, byte status)
        {
            return dal.UpdateStatus(userId, status);
        }

        public bool UpdateLastTime(int userId)
        {
            return dal.UpdateLastTime(userId);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ESMonitor.Model.Users GetModel(string userName)
        {
            return dal.GetModel(userName);
        }
		#endregion  ExtensionMethod

        #region 用户权限管理
        /// <summary>
        ///  增加权限
        /// </summary>
        public int AddAuth(int userId, int authObjId, int authType)
        {
            return dal.AddAuth(userId, authObjId, authType);
        }

        /// <summary>
        /// 批量添加权限
        /// </summary>
        /// <param name="logicGroupId"></param>
        /// <param name="ledCtrls">权限类型、权限对象用逗号分隔 权限类型：1 菜单权限 2 区域权限 3组权限 4单灯权限 5命令权限</param>
        /// <returns></returns>
        public bool AddAuths(List<int> users, List<String> auths)
        {
            return dal.AddAuths(users, auths);
        }

        /// <summary>
        ///  删除用户某个访问权限
        /// </summary>
        public int DelAuth(int userId, int authObjId, int authType)
        {
            return dal.DelAuth(userId, authObjId, authType);
        }

        /// <summary>
        /// 删除用户部分权限
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="auths"></param>
        /// <returns></returns>
        public bool DelAuths(int userId, List<String> auths)
        {
            return dal.DelAuths(userId, auths);
        }

        /// <summary>
        ///  删除用户全部权限
        /// </summary>
        public int DelAuths(int userId)
        {
            return dal.DelAuths(userId);
        }

        /// <summary>
        /// 获取用户所有的访问权限
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, List<int>> GetAuths(int userId)
        {
            return dal.GetAuths(userId);
        }
        #endregion
	}
}

