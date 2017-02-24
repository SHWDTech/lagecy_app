
using System.Collections.Generic;
using System.Data;

namespace ESMonitor.BLL
{
	/// <summary>
	/// Stats
	/// </summary>
	public class Stats
	{
		private readonly DAL.Stats _dal=new DAL.Stats();

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
		public bool Exists(string statCode)
		{
            return _dal.Exists(statCode);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Stats model)
		{
			return _dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.Stats model)
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
		public Model.Stats GetModel(int id)
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
		public List<Model.Stats> GetModelList(string strWhere)
		{
			DataSet ds = _dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.Stats> DataTableToList(DataTable dt)
		{
			List<Model.Stats> modelList = new List<Model.Stats>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.Stats model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = _dal.DataRowToModel(dt.Rows[n]);
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
		public DataSet GetAllList(string strWhere)
		{
            return GetList(strWhere);
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

		#endregion  ExtensionMethod
	}
}

