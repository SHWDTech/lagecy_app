using System.Data;
using System.Collections.Generic;

namespace ESMonitor.BLL
{
	/// <summary>
	/// GroupModules
	/// </summary>
	public class GroupModules
	{
		private readonly DAL.GroupModules _dal=new DAL.GroupModules();

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
		public bool Exists(int groupId,int moduleId)
		{
			return _dal.Exists(groupId,moduleId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(int groupId, int moduleId)
		{
			return _dal.Add(groupId, moduleId);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.GroupModules model)
		{
			return _dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int groupId,int moduleId)
		{
			
			return _dal.Delete(groupId,moduleId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.GroupModules GetModel(int groupId,int moduleId)
		{
			
			return _dal.GetModel(groupId,moduleId);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return _dal.GetList(strWhere);
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
		public List<Model.GroupModules> GetModelList(string strWhere)
		{
			var ds = _dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.GroupModules> DataTableToList(DataTable dt)
		{
			var modelList = new List<Model.GroupModules>();
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

	    /// <summary>
	    /// 获取模块列表
	    /// </summary>
	    /// <returns></returns>
	    public DataSet GetModules(int groupId)
		{
			return _dal.GetModules(groupId);
		}
		#endregion  ExtensionMethod
	}
}

