
using System;
using System.Data;
using System.Collections.Generic;

using ESMonitor.Model;
namespace ESMonitor.BLL
{
	/// <summary>
	/// ESDay
	/// </summary>
	public partial class ESDay
	{
		private readonly ESMonitor.DAL.ESDay dal=new ESMonitor.DAL.ESDay();
		public ESDay()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long  Add(ESMonitor.Model.ESDay model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(ESMonitor.Model.ESDay model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long Id)
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
		public ESMonitor.Model.ESDay GetModel(int Id)
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
		public List<ESMonitor.Model.ESDay> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<ESMonitor.Model.ESDay> DataTableToList(DataTable dt)
		{
			List<ESMonitor.Model.ESDay> modelList = new List<ESMonitor.Model.ESDay>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				ESMonitor.Model.ESDay model;
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
        public DataSet GetAvgNoiseList(string strWhere)
        {
            return dal.GetAvgNoiseList(strWhere);
        }

        public DataSet GetAvgCMPList(string strWhere)
        {
            return dal.GetAvgCMPList(strWhere);
        }

	    public DataSet GetAvgPM25List(string strWhere)
	    {
	        return dal.GetAvgPM25List(strWhere);
	    }

        public DataSet GetAvgPM100List(string strWhere)
        {
            return dal.GetAvgPM25List(strWhere);
        }

        public DataSet GetAvgCMPOrderList(string country, string strWhere)
        {
            return dal.GetAvgCMPOrderList(country, strWhere);
        }

        public DataSet GetAvgPM25OrderList(string country, string strWhere)
        {
            return dal.GetAvgPM25OrderList(country, strWhere);
        }

        public DataSet GetAvgPM100OrderList(string country, string strWhere)
        {
            return dal.GetAvgPM100OrderList(country, strWhere);
        }

        public DataSet GetAvgNoiseOrderList(string country, string strWhere)
        {
            return dal.GetAvgNoiseOrderList(country, strWhere);
        }

        public DataSet GetAvgCMPStatList(string country, string strWhere)
        {
            return dal.GetAvgCMPStatList(country, strWhere);
        }

        public DataSet GetAvgPM25StatList(string country, string strWhere)
        {
            return dal.GetAvgPM25StatList(country, strWhere);
        }

        public DataSet GetAvgPM100StatList(string country, string strWhere)
        {
            return dal.GetAvgPM100StatList(country, strWhere);
        }

        public DataSet GetAvgNoiseStatList(string country, string strWhere)
        {
            return dal.GetAvgNoiseStatList(country, strWhere);
        } 
		#endregion  ExtensionMethod
	}
}

