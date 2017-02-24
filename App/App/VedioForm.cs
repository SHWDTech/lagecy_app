using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using ESMonApp.Vedio;

namespace ESMonApp
{
    
    public partial class VedioForm : Form
    {
        private readonly bool _mBInitSdk;
        private bool _mBRecord;
        private uint _iLastErr;
        private int _mLUserId = -1;
        private int _mLRealHandle = -1;
        private string _str1;
        private string _str2;
        private int _i;
        public int MlTree { get; private set; }
        private string _str;
        private long _iSelIndex;
        private uint _dwAChanTotalNum;
        private int _mLPort = -1;
        private IntPtr _mPtrRealHandle;
        private readonly int[] _iIpDevId = new int[96];
        private readonly int[] _iChannelNum = new int[96];

        private ChcNetSdk.Realdatacallback _realData;
        public ChcNetSdk.NetDvrDeviceinfoV30 DeviceInfo;
        public ChcNetSdk.NetDvrIpparacfgV40 MStruIpParaCfgV40;
        public ChcNetSdk.NetDvrStreamMode MStruStreamMode;
        public ChcNetSdk.NetDvrIpchaninfo MStruChanInfo;
        public ChcNetSdk.NetDvrIpchaninfoV40 MStruChanInfoV40;
        private PlayCtrl.Deccbfun _mFDisplayFun;
        public delegate void MyDebugInfo(string str);

        public VedioForm()
        {
            InitializeComponent();
            _mBInitSdk = ChcNetSdk.NET_DVR_Init();
            if (_mBInitSdk == false)
            {
                MessageBox.Show(@"NET_DVR_Init error!");
            }
            else
            {
                //保存SDK日志 To save the SDK log
                ChcNetSdk.NET_DVR_SetLogToFile(3,"C:\\SdkLog\\", true);

                comboBoxView.SelectedIndex = 0;

                for (var i = 0; i < 64; i++)
                {
                    _iIpDevId[i] = -1;
                    _iChannelNum[i] = -1;
                }
            }
        }

        public void DebugInfo(string str)
        {
            if (str.Length > 0)
            {
                str += "\n";
                TextBoxInfo.AppendText(str);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_mLUserId < 0)
            {
                var dvripAddress = textBoxIP.Text; //设备IP地址或者域名 Device IP
                var dvrPortNumber = short.Parse(textBoxPort.Text);//设备服务端口号 Device Port
                var dvrUserName = textBoxUserName.Text;//设备登录用户名 User name to login
                var dvrPassword = textBoxPassword.Text;//设备登录密码 Password to login

                //登录设备 Login the device
                _mLUserId = ChcNetSdk.NET_DVR_Login_V30(dvripAddress, dvrPortNumber, dvrUserName, dvrPassword, ref DeviceInfo);
                if (_mLUserId < 0)
                {
                    _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                    _str = "NET_DVR_Login_V30 failed, error code= " + _iLastErr; //登录失败，输出错误号 Failed to login and output the error code
                    DebugInfo(_str);
                }
                else
                {
                    //登录成功
                    DebugInfo("NET_DVR_Login_V30 succ!");
                    btnLogin.Text = @"Logout";

                    _dwAChanTotalNum = DeviceInfo.byChanNum;

                    if (DeviceInfo.byIPChanNum > 0)
                    {
                        InfoIpChannel();
                    }
                    else
                    {
                        for (_i = 0; _i < _dwAChanTotalNum; _i++)
                        {
                            ListAnalogChannel(_i+1, 1);
                            _iChannelNum[_i] = _i + DeviceInfo.byStartChan;
                        }

                        comboBoxView.SelectedItem = 1;
                       // MessageBox.Show("This device has no IP channel!");
                    }
                }

            }
            else
            {
                //注销登录 Logout the device
                if (_mLRealHandle >= 0) 
                {
                    DebugInfo("Please stop live view firstly"); //登出前先停止预览 Stop live view before logout
                    return;
                }

                if (!ChcNetSdk.NET_DVR_Logout(_mLUserId))
                {
                    _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                    _str = "NET_DVR_Logout failed, error code= " + _iLastErr;
                    DebugInfo(_str);
                    return;
                }
                DebugInfo("NET_DVR_Logout succ!");
                listViewIPChannel.Items.Clear();//清空通道列表 Clean up the channel list
                _mLUserId = -1;
                btnLogin.Text = @"Login";
            }
        }

        public void InfoIpChannel()
        {
            var dwSize = (uint)Marshal.SizeOf(MStruIpParaCfgV40);

            var ptrIpParaCfgV40 = Marshal.AllocHGlobal((int)dwSize);
            Marshal.StructureToPtr(MStruIpParaCfgV40, ptrIpParaCfgV40, false);

            uint dwReturn = 0;
            var iGroupNo = 0;
            if (!ChcNetSdk.NET_DVR_GetDVRConfig(_mLUserId, ChcNetSdk.NetDvrGetIpparacfgV40, iGroupNo, ptrIpParaCfgV40, dwSize, ref dwReturn))
            {
                _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                _str = "NetDvrGetIpparacfgV40 failed, error code= " + _iLastErr; 
                //获取IP资源配置信息失败，输出错误号 Failed to get configuration of IP channels and output the error code
                DebugInfo(_str);
            }
            else
            {
                DebugInfo("NetDvrGetIpparacfgV40 succ!");

                MStruIpParaCfgV40 = (ChcNetSdk.NetDvrIpparacfgV40)Marshal.PtrToStructure(ptrIpParaCfgV40, typeof(ChcNetSdk.NetDvrIpparacfgV40));
               
                for (_i = 0; _i < _dwAChanTotalNum; _i++)
                {
                    ListAnalogChannel(_i+1, MStruIpParaCfgV40.byAnalogChanEnable[_i]);
                    _iChannelNum[_i] = _i + DeviceInfo.byStartChan;                     
                }

                for (_i = 0; _i < MStruIpParaCfgV40.dwDChanNum; _i++)
                {
                    _iChannelNum[_i + _dwAChanTotalNum] = _i + (int)MStruIpParaCfgV40.dwStartDChan;
                    var byStreamType = MStruIpParaCfgV40.struStreamMode[_i].byGetStreamType;

                    dwSize = (uint)Marshal.SizeOf(MStruIpParaCfgV40.struStreamMode[_i].uGetStream);
                    switch (byStreamType)
                    {
                        //目前NVR仅支持直接从设备取流 NVR supports only the mode: get stream from device directly
                        case 0:
                            var ptrChanInfo = Marshal.AllocHGlobal((int)dwSize);
                            Marshal.StructureToPtr(MStruIpParaCfgV40.struStreamMode[_i].uGetStream, ptrChanInfo, false);
                            MStruChanInfo = (ChcNetSdk.NetDvrIpchaninfo)Marshal.PtrToStructure(ptrChanInfo, typeof(ChcNetSdk.NetDvrIpchaninfo));

                            //列出IP通道 List the IP channel
                            ListIpChannel(_i + 1, MStruChanInfo.byEnable, MStruChanInfo.byIPID);
                            _iIpDevId[_i] = MStruChanInfo.byIPID + MStruChanInfo.byIPIDHigh * 256 - iGroupNo * 64 - 1;

                            Marshal.FreeHGlobal(ptrChanInfo);
                            break;
                        case 6:                            
                            var ptrChanInfoV40 = Marshal.AllocHGlobal((int)dwSize);
                            Marshal.StructureToPtr(MStruIpParaCfgV40.struStreamMode[_i].uGetStream, ptrChanInfoV40, false);
                            MStruChanInfoV40 = (ChcNetSdk.NetDvrIpchaninfoV40)Marshal.PtrToStructure(ptrChanInfoV40, typeof(ChcNetSdk.NetDvrIpchaninfoV40));
                            
                            //列出IP通道 List the IP channel
                            ListIpChannel(_i + 1, MStruChanInfoV40.byEnable, MStruChanInfoV40.wIPID);
                            _iIpDevId[_i] = MStruChanInfoV40.wIPID - iGroupNo * 64 - 1;

                            Marshal.FreeHGlobal(ptrChanInfoV40);
                            break;
                    }
                }
            }
            Marshal.FreeHGlobal(ptrIpParaCfgV40);
        
        }
        public void ListIpChannel(int iChanNo, byte byOnline, int byIpid)
        {
            _str1 = $"IPCamera {iChanNo}";
            MlTree++;

            if (byIpid == 0)
            {
                _str2 = "X"; //通道空闲，没有添加前端设备 the channel is idle                  
            }
            else
            { 
                _str2 = byOnline==0 ? "offline" : "online";
            }

            listViewIPChannel.Items.Add(new ListViewItem(new[] { _str1, _str2 }));//将通道添加到列表中 add the channel to the list
        }
        public void ListAnalogChannel(int iChanNo, byte byEnable)
        {
            _str1 = $"Camera {iChanNo}";
            MlTree++;

            _str2 = byEnable == 0 ? "Disabled" : "Enabled";

            listViewIPChannel.Items.Add(new ListViewItem(new[] {_str1, _str2 }));//将通道添加到列表中 add the channel to the list
        }

        private void listViewIPChannel_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewIPChannel.SelectedItems.Count > 0) 
            {
                _iSelIndex = listViewIPChannel.SelectedItems[0].Index;  //当前选中的行
            }
        }

        //解码回调函数
        private void DecCallbackFun(int nPort, IntPtr pBuf, int nSize, ref PlayCtrl.FrameInfo pFrameInfo, int nReserved1, int nReserved2)
        {
            // 将pBuf解码后视频输入写入文件中（解码后YUV数据量极大，尤其是高清码流，不建议在回调函数中处理）
            if (pFrameInfo.NType == 3) //#define T_YV12	3
            {
            //    FileStream fs = null;
            //    BinaryWriter bw = null;
            //    try
            //    {
            //        fs = new FileStream("DecodedVideo.yuv", FileMode.Append);
            //        bw = new BinaryWriter(fs);
            //        byte[] byteBuf = new byte[nSize];
            //        Marshal.Copy(pBuf, byteBuf, 0, nSize);
            //        bw.Write(byteBuf);
            //        bw.Flush();
            //    }
            //    catch (System.Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //    finally
            //    {
            //        bw.Close();
            //        fs.Close();
            //    }
            }
        }

        public void RealDataCallBack(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr pUser)
        {
            var alarmInfo = new MyDebugInfo(DebugInfo);
            switch (dwDataType)
            {
                case ChcNetSdk.NetDvrSyshead:     // sys head
                    if (dwBufSize > 0)
                    {
                        //获取播放句柄 Get the port to play
                        if (!PlayCtrl.PlayM4_GetPort(ref _mLPort))
                        {
                            _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                            _str = "PlayM4_GetPort failed, error code= " + _iLastErr;
                            BeginInvoke(alarmInfo, _str);
                            break;
                        }

                        //设置流播放模式 Set the stream mode: real-time stream mode
                        if (!PlayCtrl.PlayM4_SetStreamOpenMode(_mLPort, PlayCtrl.StreameRealtime))
                        {
                            _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                            _str = "Set STREAME_REALTIME mode failed, error code= " + _iLastErr;
                            BeginInvoke(alarmInfo, _str);
                        }

                        //打开码流，送入头数据 Open stream
                        if (!PlayCtrl.PlayM4_OpenStream(_mLPort, pBuffer, dwBufSize, 2*1024*1024))
                        {
                            _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                            _str = "PlayM4_OpenStream failed, error code= " + _iLastErr;
                            BeginInvoke(alarmInfo, _str); 
                            break;
                        }


                        //设置显示缓冲区个数 Set the display buffer number
                        if (!PlayCtrl.PlayM4_SetDisplayBuf(_mLPort, 15))
                        {
                            _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                            _str = "PlayM4_SetDisplayBuf failed, error code= " + _iLastErr;
                            BeginInvoke(alarmInfo, _str);
                        }

                        //设置显示模式 Set the display mode
                        if (!PlayCtrl.PlayM4_SetOverlayMode(_mLPort, 0, 0/* COLORREF(0)*/)) //play off screen 
                        {
                            _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                            _str = "PlayM4_SetOverlayMode failed, error code= " + _iLastErr;
                            BeginInvoke(alarmInfo, _str);
                        }

                        //设置解码回调函数，获取解码后音视频原始数据 Set callback function of decoded data
                        _mFDisplayFun = DecCallbackFun;
                        if (!PlayCtrl.PlayM4_SetDecCallBackEx(_mLPort, _mFDisplayFun,IntPtr.Zero,0))
                        {
                            BeginInvoke(alarmInfo, "PlayM4_SetDisplayCallBack fail");
                        }

                        //开始解码 Start to play                       
                        if (!PlayCtrl.PlayM4_Play(_mLPort, _mPtrRealHandle))
                        {
                            _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                            _str = "PlayM4_Play failed, error code= " + _iLastErr;
                            BeginInvoke(alarmInfo, _str);
                        }
                    }
                    break;
                case ChcNetSdk.NetDvrStreamdata:     // video stream data
                    if (dwBufSize > 0 && _mLPort != -1)
                    {
                        for (var i = 0; i < 999; i++)
                        {
                            //送入码流数据进行解码 Input the stream data to decode
                            if (!PlayCtrl.PlayM4_InputData(_mLPort, pBuffer, dwBufSize))
                            {
                                _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                                _str = "PlayM4_InputData failed, error code= " + _iLastErr;
                                Thread.Sleep(2);
                            }
                            else
                            {                                
                                break;
                            }
                        }                      
                    }
                    break;
                default:
                    if (dwBufSize > 0 && _mLPort != -1)
                    {
                        //送入其他数据 Input the other data
                        for (var i = 0; i < 999; i++)
                        {
                            if (!PlayCtrl.PlayM4_InputData(_mLPort, pBuffer, dwBufSize))
                            {
                                _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                                _str = "PlayM4_InputData failed, error code= " + _iLastErr;
                                Thread.Sleep(2);
                            }
                            else
                            {                                
                                break;
                            }
                        } 
                    }
                    break;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (_mLUserId < 0)
            {
                MessageBox.Show(@"Please login the device firstly!");
                return;
            }

            if (_mBRecord)
            {
                MessageBox.Show(@"Please stop recording firstly!");
                return;           
            }

            if (_mLRealHandle < 0)
            {
                var lpPreviewInfo = new ChcNetSdk.NetDvrPreviewinfo
                {
                    hPlayWnd = RealPlayWnd.Handle,
                    lChannel = _iChannelNum[(int) _iSelIndex],
                    dwStreamType = 0,
                    dwLinkMode = 0,
                    bBlocked = true
                };
                //预览窗口 live view window
                //预览的设备通道 the device channel number
                //码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                //连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                //0- 非阻塞取流，1- 阻塞取流

                var pUser = IntPtr.Zero;//用户数据 user data 

                if (comboBoxView.SelectedIndex == 0)
                {
                    //打开预览 Start live view 
                    _mLRealHandle = ChcNetSdk.NET_DVR_RealPlay_V40(_mLUserId, ref lpPreviewInfo, null/*RealData*/, pUser);
                }
                else
                {
                    lpPreviewInfo.hPlayWnd = IntPtr.Zero;//预览窗口 live view window
                    _mPtrRealHandle = RealPlayWnd.Handle;
                    _realData = RealDataCallBack;//预览实时流回调函数 real-time stream callback function 
                    _mLRealHandle = ChcNetSdk.NET_DVR_RealPlay_V40(_mLUserId, ref lpPreviewInfo, _realData, pUser);                
                }
                
                if (_mLRealHandle < 0)
                {
                    _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                    _str = "NET_DVR_RealPlay_V40 failed, error code= " + _iLastErr; //预览失败，输出错误号 failed to start live view, and output the error code.
                    DebugInfo(_str);
                }
                else
                {
                    //预览成功
                    DebugInfo("NET_DVR_RealPlay_V40 succ!");
                    btnPreview.Text = @"Stop View";
                }
            }
            else
            {
                //停止预览 Stop live view 
                if (!ChcNetSdk.NET_DVR_StopRealPlay(_mLRealHandle))
                {
                    _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                    _str = "NET_DVR_StopRealPlay failed, error code= " + _iLastErr;
                    DebugInfo(_str);
                    return;
                }

                if ((comboBoxView.SelectedIndex == 1) && (_mLPort>=0))
                {
                    if (!PlayCtrl.PlayM4_Stop(_mLPort))
                    {
                        _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                        _str = "PlayM4_Stop failed, error code= " + _iLastErr;
                        DebugInfo(_str);
                    }
                    if (!PlayCtrl.PlayM4_CloseStream(_mLPort))
                    {
                        _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                        _str = "PlayM4_CloseStream failed, error code= " + _iLastErr;
                        DebugInfo(_str);
                    }
                    if (!PlayCtrl.PlayM4_FreePort(_mLPort))
                    {
                        _iLastErr = PlayCtrl.PlayM4_GetLastError(_mLPort);
                        _str = "PlayM4_FreePort failed, error code= " + _iLastErr;
                        DebugInfo(_str);
                    }
                    _mLPort = -1;
                }

                DebugInfo("NET_DVR_StopRealPlay succ!");
                _mLRealHandle = -1;
                btnPreview.Text = @"Live View";
                RealPlayWnd.Invalidate();//刷新窗口 refresh the window
            }
        }

        private void btnBMP_Click(object sender, EventArgs e)
        {
            if (_mLRealHandle < 0)
            {
                DebugInfo("Please start live view firstly!"); //BMP抓图需要先打开预览
                return;
            }

            //图片保存路径和文件名 the path and file name to save
            const string sBmpPicFileName = "test.bmp";

            //BMP抓图 Capture a BMP picture
            if (!ChcNetSdk.NET_DVR_CapturePicture(_mLRealHandle, sBmpPicFileName))
            {
                _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                _str = "NET_DVR_CapturePicture failed, error code= " + _iLastErr;
                DebugInfo(_str);
            }
            else
            {
                _str = "NET_DVR_CapturePicture succ and the saved file is " + sBmpPicFileName;
                DebugInfo(_str);
            }
        }

        private void btnJPEG_Click(object sender, EventArgs e)
        {
            var lChannel = _iChannelNum[(int)_iSelIndex]; //通道号 Channel number

            var lpJpegPara = new ChcNetSdk.NetDvrJpegpara
            {
                wPicQuality = 0,
                wPicSize = 0xff
            };
            //图像质量 Image quality
            //抓图分辨率 Picture size: 0xff-Auto(使用当前码流分辨率) 
            //抓图分辨率需要设备支持，更多取值请参考SDK文档

            //JPEG抓图保存成文件 Capture a JPEG picture
            var sJpegPicFileName = "filetest.jpg";

            if (!ChcNetSdk.NET_DVR_CaptureJPEGPicture(_mLUserId, lChannel, ref lpJpegPara, sJpegPicFileName))
            {
                _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                _str = "NET_DVR_CaptureJPEGPicture failed, error code= " + _iLastErr;
                DebugInfo(_str);
                return;
            }
            _str = "NET_DVR_CaptureJPEGPicture succ and the saved file is " + sJpegPicFileName;
            DebugInfo(_str);

            //JEPG抓图，数据保存在缓冲区中 Capture a JPEG picture and save in the buffer
            uint iBuffSize = 400000; //缓冲区大小需要不小于一张图片数据的大小 The buffer size should not be less than the picture size
            var byJpegPicBuffer = new byte[iBuffSize];
            uint dwSizeReturned = 0;

            if (!ChcNetSdk.NET_DVR_CaptureJPEGPicture_NEW(_mLUserId, lChannel, ref lpJpegPara, byJpegPicBuffer, iBuffSize, ref dwSizeReturned))
            {
                _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                _str = "NET_DVR_CaptureJPEGPicture_NEW failed, error code= " + _iLastErr;
                DebugInfo(_str);
            }
            else
            {
                //将缓冲区里的JPEG图片数据写入文件 save the data into a file
                var str = "buffertest.jpg";
                var fs = new FileStream(str, FileMode.Create);
                var iLen = (int)dwSizeReturned;
                fs.Write(byJpegPicBuffer, 0, iLen);
                fs.Close();

                str = "NET_DVR_CaptureJPEGPicture_NEW succ and save the data in buffer to 'buffertest.jpg'.";
                DebugInfo(str);
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            //录像保存路径和文件名 the path and file name to save
            var sVideoFileName = "test.mp4";

            if (_mBRecord == false)
            {
                //强制I帧 Make one Key frame
                var lChannel = _iChannelNum[(int)_iSelIndex]; //通道号 Channel number
                ChcNetSdk.NET_DVR_MakeKeyFrame(_mLUserId, lChannel);

                //开始录像 Start recording
                if (!ChcNetSdk.NET_DVR_SaveRealData(_mLRealHandle, sVideoFileName))
                {
                    _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                    _str = "NET_DVR_SaveRealData failed, error code= " + _iLastErr;
                    DebugInfo(_str);
                    return;
                }
                DebugInfo("NET_DVR_SaveRealData succ!");
                btnRecord.Text = @"Stop";
                _mBRecord = true;
            }
            else
            {
                //停止录像 Stop recording
                if (!ChcNetSdk.NET_DVR_StopSaveRealData(_mLRealHandle))
                {
                    _iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                    _str = "NET_DVR_StopSaveRealData failed, error code= " + _iLastErr;
                    DebugInfo(_str);
                    return;
                }
                _str = "NET_DVR_StopSaveRealData succ and the saved file is " + sVideoFileName;
                DebugInfo(_str);
                btnRecord.Text = @"Record";
                _mBRecord = false;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //停止预览
            if (_mLRealHandle >= 0)
            {
                ChcNetSdk.NET_DVR_StopRealPlay(_mLRealHandle);
                _mLRealHandle = -1;
            }

            //注销登录
            if (_mLUserId >= 0)
            {
                ChcNetSdk.NET_DVR_Logout(_mLUserId);
                _mLUserId = -1;
            }

            ChcNetSdk.NET_DVR_Cleanup();

            Application.Exit();
        }

        private void listViewIPChannel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var iCurChan = _iChannelNum[(int)_iSelIndex];
                if (iCurChan >= MStruIpParaCfgV40.dwStartDChan)
                {
                    if (DialogResult.OK == MessageBox.Show(@"是否配置该IP通道！", @"配置提示", MessageBoxButtons.OKCancel))
                    {
                        var dlg = new IpChannelConfig
                        {
                            MStruIpParaCfgV40 = MStruIpParaCfgV40,
                            MlUserId = _mLUserId
                        };
                        var iCurChanIndex = iCurChan - (int)MStruIpParaCfgV40.dwStartDChan; //通道索引
                        var iCurIpDevIndex = _iIpDevId[iCurChanIndex]; //设备ID索引
                        dlg.IpDevIndex = iCurIpDevIndex;
                        dlg.ChanIndex = iCurChanIndex;                   
                        dlg.ShowDialog();               
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //刷新通道列表
            listViewIPChannel.Items.Clear();
            for (_i = 0; _i < _dwAChanTotalNum; _i++)
            {
                ListAnalogChannel(_i + 1, 1);
                _iChannelNum[_i] = _i + DeviceInfo.byStartChan;
            }
            InfoIpChannel(); 
        }
    }
}
