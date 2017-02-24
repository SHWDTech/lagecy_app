using System;
using System.Text;

namespace ESMonApp
{
    public class WinLog
    {
        private delegate void OutputLogCallBack(string str);
        private readonly OutputLogCallBack _outputcallback;
        private DevMgrForm _outWinform;
        public WinLog()
        {
            _outputcallback = OutputLog;
        }
        
        public void SetOutputForm(DevMgrForm form)
        {
            _outWinform = form;
        }
        
        public void Log(string str)
        {
            _outWinform?.BeginInvoke(_outputcallback, str);  //UI线程上异步调用委托
        }

        public void LogFormat(string format, object arg0)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("[{0:yyyy-MM-dd HH:mm:ss}]: ", DateTime.Now);
            sb.AppendFormat(format, arg0);
            
            Log(sb.ToString());
        }
        
        public void LogFormat(string format, object arg0, object arg1)
        {
            var sb = new StringBuilder();
            
            sb.AppendFormat("[{0:yyyy-MM-dd HH:mm:ss}]: ", DateTime.Now);
            sb.AppendFormat(format, arg0, arg1);

            Log(sb.ToString());
        }

        public void LogFormat(string format, object arg0, object arg1, object arg2)
        {
            var sb = new StringBuilder();
            
            sb.AppendFormat("[{0:yyyy-MM-dd HH:mm:ss}]: ", DateTime.Now);
            sb.AppendFormat(format, arg0, arg1, arg2);

            Log(sb.ToString());
        }
        
        public void OutputLog(string context)
        {
            _outWinform?.SetListBox(context);
        }
    }
}
