using System.Data;
using System.Collections.Generic;
using System.Collections;
namespace ESMonitor.BLL
{
    /// <summary>
    /// UserInGroups
    /// </summary>
    public class UserInGroups
    {
        private readonly DAL.UserInGroups _dal = new DAL.UserInGroups();

        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int groupId, int userId)
        {
            return _dal.Exists(groupId, userId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.UserInGroups model)
        {
            return _dal.Add(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int groupId, int userId)
        {

            return _dal.Delete(groupId, userId);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.UserInGroups GetModel(int groupId, int userId)
        {

            return _dal.GetModel(groupId, userId);
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
        public List<Model.UserInGroups> GetModelList(string strWhere)
        {
            var ds = _dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Model.UserInGroups> DataTableToList(DataTable dt)
        {
            var modelList = new List<Model.UserInGroups>();
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
        /// <summary>
        /// 批量添加用户角色
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddUserInGroups(ArrayList list)
        {
            return _dal.AddUserInGroups(list);
        }

        /// <summary>
        /// 批量删除用户角色
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DeleteUserInGroups(ArrayList list)
        {
            return _dal.DeleteUserInGroups(list);
        }

        /// <summary>
        /// 读取用户组列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetUserInGroups(int groupId)
        {
            return _dal.GetUserInGroups(groupId);
        }
        #endregion  ExtensionMethod
    }
}

