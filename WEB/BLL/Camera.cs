using System;
using System.Data;

namespace ESMonitor.BLL
{
    public class Camera
    {
        private readonly DAL.Camera _dal = new DAL.Camera();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Camera model)
        {
            return _dal.Add(model);
        }

        /// <summary>
        /// 修改一条记录
        /// </summary>
        public bool Update(Model.Camera model)
        {
            return _dal.Update(model);
        }

        public bool Delete(int id)
        {
            return _dal.Delete(id);
        }

        public Model.Camera GetModel(int devId)
        {
            return _dal.GetModel(devId);
        }

        public DataSet GetList(string strWhere)
        {
            return _dal.GetList(strWhere);
        }

        public bool Exists(string DnsAddr)
        {
            return _dal.Exists(DnsAddr);
        }
    }
}
