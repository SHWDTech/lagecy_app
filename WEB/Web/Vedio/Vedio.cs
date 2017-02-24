using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ESMonApp
{
    public class Vedio
    {
        private bool m_bRecord = false;
        private uint m_lastErr = 0;
        private Int32 m_lUserID = -1;
        private Int32 m_lRealHandle = -1;
        private Int32 m_lTree = 0;
        private long iSelIndex = 0;
        private Int32 m_lPort = -1;
        private IntPtr m_ptrRealHandle;
        private int[] iChannelNum = new int[64];

        public CHCNetSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;
        //public CHCNetSDK.NET_DVR_IPPARACFG_V40 m_struIpParaCfgV40;
        //public CHCNetSDK.NET_DVR_STREAM_MODE m_struStreamMode;
        //public CHCNetSDK.NET_DVR_IPCHANINFO m_struChanInfo;
        //public CHCNetSDK.NET_DVR_IPCHANINFO_V40 m_struChanInfoV40;

        public Vedio()
        {
            for (int i = 0; i < 64; i++)
            {
                iChannelNum[i] = -1;
            }
        }

        /// <summary>
        /// 获取最后的错误号
        /// </summary>
        /// <returns></returns>
        public uint GetLastErr()
        {
            return m_lastErr;
        }

        /// <summary>
        /// 获取用户ID
        /// </summary>
        /// <returns></returns>
        public Int32 GetUserID()
        {
            return m_lUserID;
        }

        /// <summary>
        /// 获取录像状态
        /// </summary>
        /// <returns></returns>
        public bool GetRecordState()
        {
            return m_bRecord;
        }

        public Int32 GetRealHandle()
        {
            return m_lRealHandle;
        }
        /// <summary>
        /// DDNS方式获取IP地址
        /// </summary>
        /// <param name="DNSAddr"></param>
        /// <param name="DVRIPAddress"></param>
        /// <param name="DVRPortNumber"></param>
        /// <returns></returns>
        public bool GetIPAddr(string DNSAddr, ref string DVRIPAddress, ref Int16 DVRPortNumber)
        {
            byte[] HiDDNSName = System.Text.Encoding.Default.GetBytes(DNSAddr);
            byte[] GetIPAddress = new byte[16];
            uint dwPort = 0;
            bool ret = false;

            if (CHCNetSDK.NET_DVR_GetDVRIPByResolveSvr_EX("www.hik-online.com", (ushort)80, HiDDNSName, (ushort)HiDDNSName.Length, null, 0, GetIPAddress, ref dwPort))
            {
                DVRIPAddress = System.Text.Encoding.UTF8.GetString(GetIPAddress).TrimEnd('\0');
                DVRPortNumber = (Int16)dwPort;
                ret = true;
            }
            else
            {
                m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            }

            return ret;
        }

        /// <summary>
        /// 打开设备
        /// </summary>
        /// <param name="DVRIPAddress"></param>
        /// <param name="DVRPortNumber"></param>
        /// <param name="DVRUserName"></param>
        /// <param name="DVRPassword"></param>
        /// <returns></returns>
        public bool Open(string DVRIPAddress, int DVRPortNumber, string DVRUserName, string DVRPassword)
        {
            bool ret = false;

            //登录设备 Login the device
            m_lUserID = CHCNetSDK.NET_DVR_Login_V30(DVRIPAddress, DVRPortNumber, DVRUserName, DVRPassword, ref DeviceInfo);
            if (m_lUserID >= 0)
            {
                if (DeviceInfo.byIPChanNum > 0)
                {
                    //InfoIPChannel();
                }
                else
                {
                    for (int i = 0; i < DeviceInfo.byChanNum; i++)
                    {
                        iChannelNum[i] = i + (int)DeviceInfo.byStartChan;
                    }
                }

                ret = true;
            }
            else
            {
                m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            }

            return ret;
        }

        /// <summary>
        /// 关闭设备
        /// </summary>
        public void Close()
        {
            //停止预览
            if (m_lRealHandle >= 0)
            {
                CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle);
                m_lRealHandle = -1;
            }

            //注销登录
            if (m_lUserID >= 0)
            {
                CHCNetSDK.NET_DVR_Logout(m_lUserID);
                m_lUserID = -1;
            }

            return;
        }

        /// <summary>
        /// 开启预览
        /// </summary>
        /// <param name="chIndex"></param>
        /// <param name="WndHandle"></param>
        /// <returns></returns>
        public bool StartRealView(IntPtr WndHandle)
        {
            bool ret = false;

            if (m_lRealHandle < 0)
            {
                CHCNetSDK.NET_DVR_PREVIEWINFO lpPreviewInfo = new CHCNetSDK.NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = WndHandle;//预览窗口 live view window
                lpPreviewInfo.lChannel = iChannelNum[(int)iSelIndex];//预览的设备通道 the device channel number
                lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流

                IntPtr pUser = IntPtr.Zero;//用户数据 user data 

                //打开预览 Start live view 
                m_lRealHandle = CHCNetSDK.NET_DVR_RealPlay_V40(m_lUserID, ref lpPreviewInfo, null/*RealData*/, pUser);

                if (m_lRealHandle < 0)
                {
                    m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
                }
                else
                {
                    ret = true;
                }
            }

            return ret;
        }

        /// <summary>
        /// 关闭预览
        /// </summary>
        /// <returns></returns>
        public bool StopRealView()
        {
            bool ret = false;
            //停止预览 Stop live view 
            if (CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle))
            {
                ret = true;
            }
            else
            {
                m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            }

            m_lRealHandle = -1;

            return ret;
        }

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <returns></returns>
        public bool StartRecord(string sVideoFileName)
        {
            bool ret = false;

            //强制I帧 Make one key frame
            int lChannel = iChannelNum[(int)iSelIndex]; //通道号 Channel number
            CHCNetSDK.NET_DVR_MakeKeyFrame(m_lUserID, lChannel);

            //开始录像 Start recording
            if (CHCNetSDK.NET_DVR_SaveRealData(m_lRealHandle, sVideoFileName))
            {
                ret = true;
            }
            else
            {
                m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            }

            return ret;
        }

        /// <summary>
        /// 停止录像
        /// </summary>
        /// <returns></returns>
        public bool StopRecord()
        {
            bool ret = false;

            //停止录像 Stop recording
            if (CHCNetSDK.NET_DVR_StopSaveRealData(m_lRealHandle))
            {
                ret = true;
            }
            else
            {
                m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            }

            return ret;
        }

        /// <summary>
        /// 保存JEPG图片
        /// </summary>
        public bool SaveJEPG(string sJpegPicFileName)
        {
            bool ret = false;
            int lChannel = iChannelNum[(int)iSelIndex]; //通道号 Channel number

            CHCNetSDK.NET_DVR_JPEGPARA lpJpegPara = new CHCNetSDK.NET_DVR_JPEGPARA();
            lpJpegPara.wPicQuality = 0; //图像质量 Image quality
            lpJpegPara.wPicSize = 0xff; //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
            //抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图保存成文件 Capture a JPEG picture
            if (CHCNetSDK.NET_DVR_CaptureJPEGPicture(m_lUserID, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                ret = true;
            }
            else
            {
                m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            }

            ////JEPG抓图，数据保存在缓冲区中 Capture a JPEG picture and save in the buffer
            //uint iBuffSize = 400000; //缓冲区大小需要不小于一张图片数据的大小 The buffer size should not be less than the picture size
            //byte[] byJpegPicBuffer = new byte[iBuffSize];
            //uint dwSizeReturned = 0;

            //if (CHCNetSDK.NET_DVR_CaptureJPEGPicture_NEW(m_lUserID, lChannel, ref lpJpegPara, byJpegPicBuffer, iBuffSize, ref dwSizeReturned))
            //{
            //    //将缓冲区里的JPEG图片数据写入文件 save the data into a file
            //    string str = "buffertest.jpg";
            //    FileStream fs = new FileStream(str, FileMode.Create);
            //    int iLen = (int)dwSizeReturned;
            //    fs.Write(byJpegPicBuffer, 0, iLen);
            //    fs.Close();
            //    ret = true;
            //}
            //else
            //{
            //    m_lastErr = CHCNetSDK.NET_DVR_GetLastError();
            //}

            return ret;
        }

        /// <summary>
        /// 设置摄像头位置
        /// </summary>
        /// <param name="position"></param>
        public bool SetPosition(string position)
        {
            uint PTZCommand = 0;
            int lChannel = iChannelNum[(int)iSelIndex];
 
            if (position == "LEFT")
            {
                PTZCommand = CHCNetSDK.PAN_LEFT;
            }
            else if (position == "RIGHT")
            {
                PTZCommand = CHCNetSDK.PAN_RIGHT;
            }
            else if (position == "UP")
            {
                PTZCommand = CHCNetSDK.TILT_UP;
            }
            else if (position == "DOWN")
            {
                PTZCommand = CHCNetSDK.TILT_DOWN;
            }
            else if (position == "UP_LEFT")
            {
                PTZCommand = CHCNetSDK.UP_LEFT;
            }
            else if (position == "UP_RIGHT")
            {
                PTZCommand = CHCNetSDK.UP_RIGHT;
            }
            else if (position == "DOWN_LEFT")
            {
                PTZCommand = CHCNetSDK.DOWN_LEFT;
            }
            else if (position == "DOWN_RIGHT")
            {
                PTZCommand = CHCNetSDK.DOWN_RIGHT;
            }
            else
            {
                return false;
            }

            CHCNetSDK.NET_DVR_PTZControl_Other(m_lUserID, lChannel, PTZCommand, 0);
            Thread.Sleep(1 * 1000);
            CHCNetSDK.NET_DVR_PTZControl_Other(m_lUserID, lChannel, PTZCommand, 1);

            return true;
        }

    }
}
