using System;
using System.Data;
using System.Collections.Generic;

using ESMonitor.Model;
namespace ESMonitor.BLL
{
	/// <summary>
	/// GroupModules
	/// </summary>
	public partial class GroupModules
	{
		private readonly ESMonitor.DAL.GroupModules dal=new ESMonitor.DAL.GroupModules();
		public GroupModules()
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
		public bool Exists(int GroupId,int ModuleId)
		{
			return dal.Exists(GroupId,ModuleId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public bool Add(int GroupId, int ModuleId)
		{
			return dal.Add(GroupId, ModuleId);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ESMonitor.Model.GroupModules model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int GroupId,int ModuleId)
		{
			
			return dal.Delete(GroupId,ModuleId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ESMonitor.Model.GroupModules GetModel(int GroupId,int ModuleId)
		{
			
			return dal.GetModel(GroupId,ModuleId);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
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
		public List<ESMonitor.Model.GroupModules> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ESMonitor.Model.GroupModules> DataTableToList(DataTable dt)
		{
			List<ESMonitor.Model.GroupModules> modelList = new List<ESMonitor.Model.GroupModules>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ESMonitor.Model.GroupModules model;
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
        /// <summary>
        /// 获取模块列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        public DataSet GetModules(int groupId)
        {
            return dal.GetModules(groupId);
        }
		#endregion  ExtensionMethod
	}
}

