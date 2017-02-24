using System.Data;
using System.Collections.Generic;

namespace ESMonitor.BLL
{
    /// <summary>
    /// Tasks
    /// </summary>
    public class Tasks
    {
        private readonly DAL.Tasks _dal = new DAL.Tasks();

        #region  BasicMethod
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Add(Model.Tasks model)
        {
            return _dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.Tasks model)
        {
            return _dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long taskId)
        {

            return _dal.Delete(taskId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string taskIdlist)
        {
            return _dal.DeleteList(taskIdlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Tasks GetModel(long taskId)
        {

            return _dal.GetModel(taskId);
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
        public DataSet GetList(int top, string strWhere, string filedOrder)
        {
            return _dal.GetList(top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Tasks> GetModelList(string strWhere)
        {
            var ds = _dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.Tasks> DataTableToList(DataTable dt)
        {
            var modelList = new List<Model.Tasks>();
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
            return _dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
        public bool UpdateStatus(long taskId, int status)
        {
            return _dal.UpdateStatus(taskId, status);
        }

        #endregion  ExtensionMethod
    }
}

