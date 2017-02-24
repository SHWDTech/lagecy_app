using System;
using System.Data;
using System.Collections.Generic;
using ESMonitor.Model;
namespace ESMonitor.BLL
{
    /// <summary>
    /// Tasks
    /// </summary>
    public partial class Tasks
    {
        private readonly ESMonitor.DAL.Tasks dal = new ESMonitor.DAL.Tasks();
        public Tasks()
        { }
        #region  BasicMethod
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Add(ESMonitor.Model.Tasks model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ESMonitor.Model.Tasks model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long TaskId)
        {

            return dal.Delete(TaskId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string TaskIdlist)
        {
            return dal.DeleteList(TaskIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ESMonitor.Model.Tasks GetModel(long TaskId)
        {

            return dal.GetModel(TaskId);
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

        public DataSet GetLast(string strWhere, int Devid)
        {
            return dal.GetLast(strWhere, Devid);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ESMonitor.Model.Tasks> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ESMonitor.Model.Tasks> DataTableToList(DataTable dt)
        {
            List<ESMonitor.Model.Tasks> modelList = new List<ESMonitor.Model.Tasks>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ESMonitor.Model.Tasks model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
        public bool UpdateStatus(long taskId, int status)
        {
            return dal.UpdateStatus(taskId, status);
        }
        #endregion  ExtensionMethod
    }
}

