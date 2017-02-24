
using System;
using System.Data;
using System.Collections.Generic;

namespace ESMonitor.BLL
{
	/// <summary>
	/// Devs
	/// </summary>
	public class Devs
	{
		private readonly DAL.Devs _dal=new DAL.Devs();

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
		public bool Exists(string devCode)
		{
			return _dal.Exists(devCode);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Devs model)
		{
			return _dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.Devs model)
		{
			return _dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			return _dal.Delete(id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			return _dal.DeleteList(idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Devs GetModel(int id)
		{
			
			return _dal.GetModel(id);
		}

		public Model.Devs GetDevByNodeId(UInt32 nodeId)
		{
			return _dal.GetDevByNodeId(nodeId);
		}

		public Model.Stats GetDevStat(int devId)
		{
			return _dal.GetDevStat(devId);

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
		public List<Model.Devs> GetModelList(string strWhere)
		{
			var ds = _dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Devs> DataTableToList(DataTable dt)
		{
			var modelList = new List<Model.Devs>();
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
		public bool ExistsAddr(byte[] nodeId)
		{
			return _dal.ExistsAddr(nodeId);
		}
		public bool AddAddr(int devId, byte[] nodeId)
		{
			return _dal.AddAddr(devId, nodeId);
		}
		public bool UpdateDevAddr(int devId, byte[] nodeId)
		{
			return _dal.UpdateDevAddr(devId, nodeId);
		}
		public DataSet GetDevAddrList()
		{
			return _dal.GetDevAddrList();
		}
		public DataSet GetDevRelatedStat(string strWhere)
		{
			return _dal.GetDevRelatedStat(strWhere);
		}
		#endregion  ExtensionMethod
	}
}

