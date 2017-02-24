using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ESMonitor.BLL
{
    public class Photos
    {
        private readonly ESMonitor.DAL.Photos dal = new ESMonitor.DAL.Photos();

        public int Add(ESMonitor.Model.Photos model)
        {
            return dal.Add(model);
        }

        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        public DataSet GetList(int PageSize, int PageIndex, string strWhere)
        {
            return dal.GetList(PageSize, PageIndex, strWhere);
        }

        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
    }
}
