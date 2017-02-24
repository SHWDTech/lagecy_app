using System;
using System.Data.Common;

namespace ESMonitor.DAL
{
    public class CommandInfo
    {
        public object ShareObject = null;
        public object OriginalData = null;
        // ReSharper disable once InconsistentNaming
        private event EventHandler _solicitationEvent;
        public event EventHandler SolicitationEvent
        {
            add
            {
                _solicitationEvent += value;
            }
            remove
            {
                _solicitationEvent -= value;
            }
        }
        public void OnSolicitationEvent()
        {
            _solicitationEvent?.Invoke(this,new EventArgs());
        }
        public string CommandText;
        public DbParameter[] Parameters;
        public EffentNextType EffentNextType = EffentNextType.None;
        public CommandInfo()
        {

        }
        public CommandInfo(string sqlText, DbParameter[] para)
        {
            CommandText = sqlText;
            Parameters = para;
        }
        public CommandInfo(string sqlText, DbParameter[] para, EffentNextType type)
        {
            CommandText = sqlText;
            Parameters = para;
            EffentNextType = type;
        }
    }
}
