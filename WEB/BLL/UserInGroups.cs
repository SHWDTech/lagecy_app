using System;
using System.Data;
using System.Collections.Generic;
using ESMonitor.Model;
using System.Collections;
namespace ESMonitor.BLL
{
    /// <summary>
    /// UserInGroups
    /// </summary>
    public partial class UserInGroups
    {
        private readonly ESMonitor.DAL.UserInGroups dal = new ESMonitor.DAL.UserInGroups();
        public UserInGroups()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int GroupId, int UserId)
        {
            return dal.Exists(GroupId, UserId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(ESMonitor.Model.UserInGroups model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int GroupId, int UserId)
        {

            return dal.Delete(GroupId, UserId);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ESMonitor.Model.UserInGroups GetModel(int GroupId, int UserId)
        {

            return dal.GetModel(GroupId, UserId);
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
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ESMonitor.Model.UserInGroups> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ESMonitor.Model.UserInGroups> DataTableToList(DataTable dt)
        {
            List<ESMonitor.Model.UserInGroups> modelList = new List<ESMonitor.Model.UserInGroups>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ESMonitor.Model.UserInGroups model;
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
        /// <summary>
        /// 批量添加用户角色
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool AddUserInGroups(ArrayList list)
        {
            return dal.AddUserInGroups(list);
        }

        /// <summary>
        /// 批量删除用户角色
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public bool DeleteUserInGroups(ArrayList list)
        {
            return dal.DeleteUserInGroups(list);
        }

        /// <summary>
        /// 读取用户组列表
        /// </summary>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public DataSet GetUserInGroups(int groupId)
        {
            return dal.GetUserInGroups(groupId);
        }
        #endregion  ExtensionMethod
    }
}

