using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ESMonitor.BLL
{
    public partial class HistoryQuery
    {
        private readonly ESMonitor.DAL.HistoryQuery dal = new ESMonitor.DAL.HistoryQuery();
        public HistoryQuery()
		{}
        public DataSet GetSearchResualt(int selectControl,int devId,DateTime statetime,DateTime endtime) //获取增加条件的收索结果
        {
            return dal.GetSearchResualt(selectControl, devId, statetime, endtime);
        }

        public DataSet GetSearchResualt1(int selectControl, int devId, DateTime statetime, DateTime endtime) //获取增加条件的收索结果
        {
            return dal.GetSearchResualt1(selectControl, devId, statetime, endtime);
        }
        public DataSet GetList(int selectControl, DateTime statetime, DateTime endtime,int indexKind) //获取增加条件的收索结果
        {
            return dal.GetList(selectControl,  statetime, endtime,indexKind);
        }

        public DataSet GetAvgNoiseList(int statisType, string strWhere)
        {
            return dal.GetAvgNoiseList(statisType, strWhere);
        }

        public DataSet GetAvgCMPList(int statisType, string strWhere)
        {
            return dal.GetAvgCMPList(statisType, strWhere);
        }

        public DataSet GetAvgCMPOrderList(int statisType, string country, string strWhere)
        {
            return dal.GetAvgCMPOrderList(statisType, country, strWhere);
        }

        public DataSet GetAvgNoiseOrderList(int statisType, string country, string strWhere)
        {
            return dal.GetAvgNoiseOrderList(statisType, country, strWhere);
        }

        public DataSet GetAvgCMPStatList(int statisType, string country, string strWhere)
        {
            return dal.GetAvgCMPStatList(statisType, country, strWhere);
        }

        public DataSet GetAvgNoiseStatList(int statisType, string country, string strWhere)
        {
            return dal.GetAvgNoiseStatList(statisType, country, strWhere);
        } 
    }
    
    
    
}
