﻿using System;
using System.Data;
using System.Collections.Generic;

using ESMonitor.Model;
namespace ESMonitor.BLL
{
    /// <summary>
    /// Alarms
    /// </summary>
    public partial class Alarms
    {
        private readonly ESMonitor.DAL.Alarms dal = new ESMonitor.DAL.Alarms();
        public Alarms()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ESMonitor.Model.Alarms model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(ESMonitor.Model.Alarms model)
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
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ESMonitor.Model.Alarms GetModel(int Id)
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ESMonitor.Model.Alarms> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<ESMonitor.Model.Alarms> DataTableToList(DataTable dt)
        {
            List<ESMonitor.Model.Alarms> modelList = new List<ESMonitor.Model.Alarms>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ESMonitor.Model.Alarms model;
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
        /// 污染物超标次数（颗粒物，噪音，总次数）
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetDustOverDataCount(string strWhere)
        {
            return dal.GetDustOverDataCount(strWhere);
        }

        /// <summary>
        /// 日污染次数统计
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetDustOverDataPerDay(string strWhere)
        {
            return dal.GetDustOverDataPerDay(strWhere);
        }
        #endregion  ExtensionMethod
    }
}

