
using System;
using System.Data;
using System.Collections.Generic;

using ESMonitor.Model;
namespace ESMonitor.BLL
{
	/// <summary>
	/// Devs
	/// </summary>
	public partial class Devs
	{
		private readonly ESMonitor.DAL.Devs dal=new ESMonitor.DAL.Devs();
		public Devs()
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
		public bool Exists(string devCode)
		{
            return dal.Exists(devCode);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(ESMonitor.Model.Devs model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ESMonitor.Model.Devs model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ESMonitor.Model.Devs GetModel(int Id)
		{
			
			return dal.GetModel(Id);
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
		public List<ESMonitor.Model.Devs> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ESMonitor.Model.Devs> DataTableToList(DataTable dt)
		{
			List<ESMonitor.Model.Devs> modelList = new List<ESMonitor.Model.Devs>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ESMonitor.Model.Devs model;
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
		public bool ExistsAddr(byte[] nodeId)
		{
		    return dal.ExistsAddr(nodeId);
		}
        public bool AddAddr(int devId, byte[] nodeId)
        {
            return dal.AddAddr(devId, nodeId);
        }
        public bool UpdateDevAddr(int devId, byte[] nodeId)
        {
            return dal.UpdateDevAddr(devId, nodeId);
        }
        public DataSet GetDevAddrList()
        {
            return dal.GetDevAddrList();
        }
		#endregion  ExtensionMethod
	}
}

