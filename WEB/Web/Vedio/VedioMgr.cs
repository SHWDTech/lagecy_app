using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ESMonApp
{
    public class VedioMgr
    {
        private bool m_bInitSDK = false;

        public VedioMgr()
        {
            m_bInitSDK = CHCNetSDK.NET_DVR_Init();
            if (m_bInitSDK == true)
            {
                //保存SDK日志 To save the SDK log
                CHCNetSDK.NET_DVR_SetLogToFile(3, "C:\\SdkLog\\", true);
            }
        }

        public void Dispose()
        {
            if (m_bInitSDK == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }
        }
    }
}
