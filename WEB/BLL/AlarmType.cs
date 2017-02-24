using System.Data;

namespace ESMonitor.BLL
{
    public class AlarmType
    {
        private readonly DAL.AlarmType _dal = new DAL.AlarmType();

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.AlarmType model)
        {
            return _dal.Add(model);
        }

        /// <summary>
        /// 修改一条记录
        /// </summary>
        public bool Update(Model.AlarmType model)
        {
            return _dal.Update(model);
        }

        public bool Delete(int id)
        {
            return _dal.Delete(id);
        }

        public Model.AlarmType GetModel(int id)
        {
            return _dal.GetModel(id);
        }

        public DataSet GetList(string strWhere)
        {
            return _dal.GetList(strWhere);
        }
    }
}
