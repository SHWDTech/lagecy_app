using System;
using System.Data;
using System.Collections.Generic;

namespace ESMonitor.BLL
{
	/// <summary>
	/// Users
	/// </summary>
	public class Users
	{
		private readonly DAL.Users _dal = new DAL.Users();

		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return _dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			return _dal.Exists(userId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.Users model)
		{
			return _dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.Users model)
		{
			return _dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int userId)
		{
			
			return _dal.Delete(userId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string userIdlist )
		{
			return _dal.DeleteList(userIdlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Users GetModel(int userId)
		{
			
			return _dal.GetModel(userId);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return _dal.GetList(strWhere);
		}

		/// <summary>
		/// 获取用户名、用户名称集合
		/// </summary>
		/// <param name="strWhere"></param>
		/// <returns></returns>
		public List<string> GetUsesList(string strWhere)
		{
			return _dal.GetUsesList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int top,string strWhere,string filedOrder)
		{
			return _dal.GetList(top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Users> GetModelList(string strWhere)
		{
			var ds = _dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Users> DataTableToList(DataTable dt)
		{
			var modelList = new List<Model.Users>();
			var rowsCount = dt.Rows.Count;
		    if (rowsCount <= 0) return modelList;
		    for (var n = 0; n < rowsCount; n++)
		    {
		        var model = _dal.DataRowToModel(dt.Rows[n]);
		        if (model != null)
		        {
		            modelList.Add(model);
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
			return _dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return _dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int pageSize, int pageIndex, string strWhere)
		{
			return _dal.GetList(pageSize, pageIndex, strWhere);
		}

		#endregion  BasicMethod
		#region  ExtensionMethod
		public bool Exists(string userName)
		{
			return _dal.Exists(userName);
		}

		public bool CheckLogin(string userName, string pwd)
		{
			return _dal.CheckLogin(userName, pwd);
		}
	
		/// <summary>
		/// 判断用户原密码是否正确
		/// </summary>
		/// <param name="userId">用户ID</param>
		/// <param name="pwd">原密码</param>
		/// <returns></returns>
		public bool VerifyPassword(int userId, string pwd)
		{
			return _dal.VerifyPassword(userId, pwd);
		}

		/// <summary>
		/// 更改用户密码
		/// </summary>
		/// <param name="userId">用户ID</param>
		/// <param name="pwd">新密码</param>
		/// <returns></returns>
		public bool ChangePassword(int userId, string pwd)
		{
			return _dal.ChangePassword(userId, pwd);
		}

		public bool UpdateStatus(int userId, byte status)
		{
			return _dal.UpdateStatus(userId, status);
		}

		public bool UpdateLastTime(int userId)
		{
			return _dal.UpdateLastTime(userId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Users GetModel(string userName)
		{
			return _dal.GetModel(userName);
		}
		#endregion  ExtensionMethod

		#region 用户权限管理
		/// <summary>
		///  增加权限
		/// </summary>
		public int AddAuth(int userId, int authObjId, int authType)
		{
			return _dal.AddAuth(userId, authObjId, authType);
		}

	    /// <summary>
	    /// 批量添加权限
	    /// </summary>
	    /// <returns></returns>
	    public bool AddAuths(List<int> users, List<String> auths)
		{
			return _dal.AddAuths(users, auths);
		}

		/// <summary>
		///  删除用户某个访问权限
		/// </summary>
		public int DelAuth(int userId, int authObjId, int authType)
		{
			return _dal.DelAuth(userId, authObjId, authType);
		}

		/// <summary>
		/// 删除用户部分权限
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="auths"></param>
		/// <returns></returns>
		public bool DelAuths(int userId, List<String> auths)
		{
			return _dal.DelAuths(userId, auths);
		}

		/// <summary>
		///  删除用户全部权限
		/// </summary>
		public int DelAuths(int userId)
		{
			return _dal.DelAuths(userId);
		}

		/// <summary>
		/// 获取用户所有的访问权限
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, List<int>> GetAuths(int userId)
		{
			return _dal.GetAuths(userId);
		}
		#endregion
	}
}

