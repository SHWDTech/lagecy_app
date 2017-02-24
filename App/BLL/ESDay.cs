using System.Data;
using System.Collections.Generic;

namespace ESMonitor.BLL
{
	/// <summary>
	/// ESDay
	/// </summary>
	public class EsDay
	{
		private readonly DAL.EsDay _dal=new DAL.EsDay();

		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			return _dal.Exists(id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long  Add(Model.EsDay model)
		{
			return _dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.EsDay model)
		{
			return _dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long id)
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
		public Model.EsDay GetModel(int id)
		{
			
			return _dal.GetModel(id);
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
		public List<Model.EsDay> GetModelList(string strWhere)
		{
			var ds = _dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.EsDay> DataTableToList(DataTable dt)
		{
			var modelList = new List<Model.EsDay>();
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
		public DataSet GetAvgNoiseList(string strWhere)
		{
			return _dal.GetAvgNoiseList(strWhere);
		}

		public DataSet GetAvgCmpList(string strWhere)
		{
			return _dal.GetAvgCmpList(strWhere);
		}

		public DataSet GetAvgCmpOrderList(string country, string strWhere)
		{
			return _dal.GetAvgCmpOrderList(country, strWhere);
		}

		public DataSet GetAvgNoiseOrderList(string country, string strWhere)
		{
			return _dal.GetAvgNoiseOrderList(country, strWhere);
		}

		public DataSet GetAvgCmpStatList(string country, string strWhere)
		{
			return _dal.GetAvgCmpStatList(country, strWhere);
		}

		public DataSet GetAvgNoiseStatList(string country, string strWhere)
		{
			return _dal.GetAvgNoiseStatList(country, strWhere);
		} 
		#endregion  ExtensionMethod
	}
}

