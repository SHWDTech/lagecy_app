using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ESMonApp.Properties;
using ESMonApp.Vedio;

namespace ESMonApp
{
    public partial class IpChannelConfig : Form
    {
        public ChcNetSdk.NetDvrIpparacfgV40 MStruIpParaCfgV40 = new ChcNetSdk.NetDvrIpparacfgV40();
        private ChcNetSdk.NetDvrIpchaninfo _mStruChanInfo;
        private ChcNetSdk.NetDvrIpchaninfoV40 _mStruChanInfoV40;
        private ChcNetSdk.NetDvrIpcProtoList _mStruProtoList;
        private readonly ChcNetSdk.NetDvrGetStreamUnion _mStruStreamUnion = new ChcNetSdk.NetDvrGetStreamUnion();
        public int IpDevIndex = -1;
        public int ChanIndex = 0;
        public uint DwUnionSize;
        public int MlUserId = -1;

        public ChcNetSdk.NetDvrProtoType MStruProtoType = new ChcNetSdk.NetDvrProtoType();

        public IpChannelConfig()
        {
            InitializeComponent();
            DwUnionSize = (uint)Marshal.SizeOf(_mStruStreamUnion);//联合体大小 
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            /***********************************************************
             * 添加IP通道或者修改IP通道配置
             * **********************************************************/

            if (IpDevIndex < 0)
            { 
                //如果该IP通道空闲，新增IP通道，选择空闲设备ID
                for(var i=0;i<64;i++)
                    if (MStruIpParaCfgV40.struIPDevInfo[i].byEnable==0)
                    {
                        IpDevIndex = i;
                        break;
                    }            
            }

            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].byEnable = 1;//该IP设备是否启用 
            
            //设备（厂家）协议类型,通过NET_DVR_GetIPCProtoList获取
            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].byProType = (byte)_mStruProtoList.struProto[comboBoxFactory.SelectedIndex].dwType;

            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].struIP.sIpV4 = textBoxIPAddr.Text;//前端设备IP地址 
            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].wDVRPort = ushort.Parse(textBoxPort.Text);//前端设备端口
            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].sUserName = textBoxUserName.Text;//前端设备用户名
            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].sPassword = textBoxPsw.Text;//前端设备密码

            switch (MStruIpParaCfgV40.struStreamMode[ChanIndex].byGetStreamType)
            {
                case 0://直接从设备取流，对应联合体中结构NET_DVR_IPCHANINFO
                    _mStruChanInfo.byEnable = 1;
                    _mStruChanInfo.byIPID = Convert.ToByte((IpDevIndex + 1) % 256);
                    _mStruChanInfo.byChannel = byte.Parse(textBoxChannel.Text);
                    var ptrChanInfo = Marshal.AllocHGlobal((int)DwUnionSize);
                    Marshal.StructureToPtr(_mStruChanInfo, ptrChanInfo, false);
                    MStruIpParaCfgV40.struStreamMode[ChanIndex].uGetStream = (ChcNetSdk.NetDvrGetStreamUnion)Marshal.PtrToStructure(ptrChanInfo, typeof(ChcNetSdk.NetDvrGetStreamUnion));
                    Marshal.FreeHGlobal(ptrChanInfo);
                    break;
                case 6: //直接从设备取流(扩展)，对应联合体中结构NET_DVR_IPCHANINFO_V40 
                    _mStruChanInfoV40.byEnable = 1;
                    _mStruChanInfoV40.wIPID = Convert.ToUInt16(IpDevIndex + 1);
                    _mStruChanInfoV40.dwChannel = Convert.ToUInt32(textBoxChannel.Text);
                    _mStruChanInfoV40.byTransProtocol = (byte)comboBoxProtocol.SelectedIndex;
                    _mStruChanInfoV40.byTransMode = (byte)comboBoxStream.SelectedIndex;
                    var ptrChanInfoV40 = Marshal.AllocHGlobal((int)DwUnionSize);
                    Marshal.StructureToPtr(_mStruChanInfoV40, ptrChanInfoV40, false);
                    MStruIpParaCfgV40.struStreamMode[ChanIndex].uGetStream = (ChcNetSdk.NetDvrGetStreamUnion)Marshal.PtrToStructure(ptrChanInfoV40, typeof(ChcNetSdk.NetDvrGetStreamUnion));
                    Marshal.FreeHGlobal(ptrChanInfoV40);
                    break;
            }

            var nSize = Marshal.SizeOf(MStruIpParaCfgV40);
            var ptrIpParaCfgV40 = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(MStruIpParaCfgV40, ptrIpParaCfgV40, false);

            if (!ChcNetSdk.NET_DVR_SetDVRConfig(MlUserId, ChcNetSdk.NetDvrSetIpparacfgV40, 0, ptrIpParaCfgV40, (uint)nSize))
            {
                var iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                var str = "NetDvrSetIpparacfgV40 failed, error code= " + iLastErr;
                MessageBox.Show(str);
                //获取IP资源配置信息失败，输出错误号 Failed to get configuration of IP channels and output the error code
            }
            else 
            {
                MessageBox.Show(Resources.IpChannelConfig_btnSet_Click_IP通道配置成功_);                 
            }
            Marshal.FreeHGlobal(ptrIpParaCfgV40);
        }

        private void IPChannelConfig_Load(object sender, EventArgs e)
        {
            int i;
            
            //获取设备支持IPC协议列表
            if (ChcNetSdk.NET_DVR_GetIPCProtoList(MlUserId, ref _mStruProtoList))
            {
                for (i = 0; i < (int)_mStruProtoList.dwProtoNum; i++)
                {
                    comboBoxFactory.Items.Add(_mStruProtoList.struProto[i].byDescribe);
                }
            }

            comboBoxStreamType.SelectedIndex = 0;
            comboBoxFactory.SelectedIndex = 0;
            comboBoxStream.SelectedIndex = 0;
            comboBoxProtocol.SelectedIndex = 0;

            /***********************************************************
             * 显示当前IP通道配置
             * **********************************************************/
            if (IpDevIndex < 0)
            {
                //该通道未添加有设备，空闲状态
                return;
            }

            comboBoxStreamType.SelectedIndex = MStruIpParaCfgV40.struStreamMode[ChanIndex].byGetStreamType;//取流方式
            textBoxIPAddr.Text = MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].struIP.sIpV4;//前端设备IP地址
            textBoxPort.Text = Convert.ToString(MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].wDVRPort);//前端设备端口
            textBoxUserName.Text = MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].sUserName;//前端设备用户名
            textBoxPsw.Text = MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].sPassword;//前端设备密码
            for (i = 0; i < (int)_mStruProtoList.dwProtoNum; i++)
            {
                //设备（厂家）协议类型,通过NET_DVR_GetIPCProtoList获取
                if (_mStruProtoList.struProto[i].dwType == MStruIpParaCfgV40.struIPDevInfo[IpDevIndex].byProType)
                {
                    comboBoxFactory.SelectedIndex = i;
                }
            }

            switch (MStruIpParaCfgV40.struStreamMode[ChanIndex].byGetStreamType)
            {
                case 0: //直接从设备取流，对应联合体中结构NET_DVR_IPCHANINFO
                    var ptrChanInfo = Marshal.AllocHGlobal((int)DwUnionSize);
                    Marshal.StructureToPtr(MStruIpParaCfgV40.struStreamMode[ChanIndex].uGetStream, ptrChanInfo, false);
                    _mStruChanInfo = (ChcNetSdk.NetDvrIpchaninfo)Marshal.PtrToStructure(ptrChanInfo, typeof(ChcNetSdk.NetDvrIpchaninfo));
                    textBoxChannel.Text = Convert.ToString(_mStruChanInfo.byChannel);
                    Marshal.FreeHGlobal(ptrChanInfo);
                    break;
                case 6://直接从设备取流(扩展)，对应联合体中结构NET_DVR_IPCHANINFO_V40
                    var ptrChanInfoV40 = Marshal.AllocHGlobal((int)DwUnionSize);
                    Marshal.StructureToPtr(MStruIpParaCfgV40.struStreamMode[ChanIndex].uGetStream, ptrChanInfoV40, false);
                    _mStruChanInfoV40 = (ChcNetSdk.NetDvrIpchaninfoV40)Marshal.PtrToStructure(ptrChanInfoV40, typeof(ChcNetSdk.NetDvrIpchaninfoV40));
                    textBoxChannel.Text = Convert.ToString(_mStruChanInfoV40.dwChannel);
                    comboBoxStream.SelectedIndex = _mStruChanInfoV40.byTransMode;
                    comboBoxProtocol.SelectedIndex = _mStruChanInfoV40.byTransProtocol;
                    Marshal.FreeHGlobal(ptrChanInfoV40);
                    break;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Dispose(); 
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (IpDevIndex < 0)
            {
                return; //该通道未添加有设备，空闲状态           
            }

            MStruIpParaCfgV40.struStreamMode[ChanIndex].uGetStream.Init(); //初始化通道参数为0
            MStruIpParaCfgV40.struIPDevInfo[IpDevIndex] = new ChcNetSdk.NetDvrIpdevinfoV31();//初始化设备参数为0
            var nSize = Marshal.SizeOf(MStruIpParaCfgV40);
            var ptrIpParaCfgV40 = Marshal.AllocHGlobal(nSize);
            Marshal.StructureToPtr(MStruIpParaCfgV40, ptrIpParaCfgV40, false);

            if (!ChcNetSdk.NET_DVR_SetDVRConfig(MlUserId, ChcNetSdk.NetDvrSetIpparacfgV40, 0, ptrIpParaCfgV40, (uint)nSize))
            {
                var iLastErr = ChcNetSdk.NET_DVR_GetLastError();
                var str = "NetDvrSetIpparacfgV40 failed, error code= " + iLastErr;
                MessageBox.Show(str);
                //获取IP资源配置信息失败，输出错误号 Failed to get configuration of IP channels and output the error code
            }
            else
            {
                MessageBox.Show(@"IP通道删除成功!");
            }

            Marshal.FreeHGlobal(ptrIpParaCfgV40);
        }
    }
}
