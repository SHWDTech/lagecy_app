using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace ESMonApp.Vedio
{
	/// <summary>
	/// CHCNetSDK 的摘要说明。
	/// </summary>
	public class ChcNetSdk
	{
		//SDK类型
		public const int SdkPlaympeg4 = 1;//播放库
		public const int SdkHcnetsdk = 2;//网络库

		public const int NameLen = 32;//用户名长度
		public const int PasswdLen = 16;//密码长度
		public const int GuidLen = 16;      //GUID长度
		public const int DevTypeNameLen = 24;      //设备类型名称长度
		public const int MaxNamelen = 16;//DVR本地登陆名
		public const int MaxRight = 32;//设备支持的权限（1-12表示本地权限，13-32表示远程权限）
		public const int SerialnoLen = 48;//序列号长度
		public const int MacaddrLen = 6;//mac地址长度
		public const int MaxEthernet = 2;//设备可配以太网络
		public const int MaxNetworkCard = 4; //设备可配最大网卡数目
		public const int PathnameLen = 128;//路径长度

		public const int MaxNumberLen = 32;	//号码最大长度
		public const int MaxNameLen = 128; //设备名称最大长度

		public const int MaxTimesegmentV30 = 8;//9000设备最大时间段数
		public const int MaxTimesegment = 4;//8000设备最大时间段数
		public const int MaxIcrNum = 8;   //抓拍机红外滤光片预置点数

		public const int MaxShelternum = 4;//8000设备最大遮挡区域数
		public const int PhonenumberLen = 32;//pppoe拨号号码最大长度

		public const int MaxDisknum = 16;//8000设备最大硬盘数
		public const int MaxDisknumV10 = 8;//1.2版本之前版本

		public const int MaxWindowV30 = 32;//9000设备本地显示最大播放窗口数
		public const int MaxWindow = 16;//8000设备最大硬盘数
		public const int MaxVgaV30 = 4;//9000设备最大可接VGA数
		public const int MaxVga = 1;//8000设备最大可接VGA数

		public const int MaxUsernumV30 = 32;//9000设备最大用户数
		public const int MaxUsernum = 16;//8000设备最大用户数
		public const int MaxExceptionnumV30 = 32;//9000设备最大异常处理数
		public const int MaxExceptionnum = 16;//8000设备最大异常处理数
		public const int MaxLink = 6;//8000设备单通道最大视频流连接数
		public const int MaxItcExceptionout = 32;//抓拍机最大报警输出

		public const int MaxDecpoolnum = 4;//单路解码器每个解码通道最大可循环解码数
		public const int MaxDecnum = 4;//单路解码器的最大解码通道数（实际只有一个，其他三个保留）
		public const int MaxTransparentnum = 2;//单路解码器可配置最大透明通道数
		public const int MaxCycleChan = 16; //单路解码器最大轮循通道数
		public const int MaxCycleChanV30 = 64;//最大轮询通道数（扩展）
		public const int MaxDirnameLength = 80;//最大目录长度

		public const int MaxStringnumV30 = 8;//9000设备最大OSD字符行数数
		public const int MaxStringnum = 4;//8000设备最大OSD字符行数数
		public const int MaxStringnumEx = 8;//8000定制扩展
		public const int MaxAuxoutV30 = 16;//9000设备最大辅助输出数
		public const int MaxAuxout = 4;//8000设备最大辅助输出数
		public const int MaxHdGroup = 16;//9000设备最大硬盘组数
		public const int MaxNfsDisk = 8; //8000设备最大NFS硬盘数

		public const int IwEssidMaxSize = 32;//WIFI的SSID号长度
		public const int IwEncodingTokenMax = 32;//WIFI密锁最大字节数
		public const int WifiWepMaxKeyCount = 4;
		public const int WifiWepMaxKeyLength = 33;
		public const int WifiWpaPskMaxKeyLength = 63;
		public const int WifiWpaPskMinKeyLength = 8;
		public const int WifiMaxApCount = 20;
		public const int MaxSerialNum = 64;//最多支持的透明通道路数
		public const int MaxDdnsNums = 10;//9000设备最大可配ddns数
		public const int MaxEmailAddrLen = 48;//最大email地址长度
		public const int MaxEmailPwdLen = 32;//最大email密码长度

		public const int Maxprogress = 100;//回放时的最大百分率
		public const int MaxSerialnum = 2;//8000设备支持的串口数 1-232， 2-485
		public const int CardnumLen = 20;//卡号长度
		public const int CardnumLenOut = 32; //外部结构体卡号长度
		public const int MaxVideooutV30 = 4;//9000设备的视频输出数
		public const int MaxVideoout = 2;//8000设备的视频输出数

		public const int MaxPresetV30 = 256;// 9000设备支持的云台预置点数
		public const int MaxTrackV30 = 256;// 9000设备支持的云台轨迹数
		public const int MaxCruiseV30 = 256;// 9000设备支持的云台巡航数
		public const int MaxPreset = 128;// 8000设备支持的云台预置点数 
		public const int MaxTrack = 128;// 8000设备支持的云台轨迹数
		public const int MaxCruise = 128;// 8000设备支持的云台巡航数 

		public const int CruiseMaxPresetNums = 32;// 一条巡航最多的巡航点 

		public const int MaxSerialPort = 8;//9000设备支持232串口数
		public const int MaxPreviewMode = 8;// 设备支持最大预览模式数目 1画面,4画面,9画面,16画面.... 
		public const int MaxMatrixout = 16;// 最大模拟矩阵输出个数 
		public const int LogInfoLen = 11840; // 日志附加信息 
		public const int DescLen = 16;// 云台描述字符串长度 
		public const int PtzProtocolNum = 200;// 9000最大支持的云台协议数 

		public const int MaxAudio = 1;//8000语音对讲通道数
		public const int MaxAudioV30 = 2;//9000语音对讲通道数
		public const int MaxChannum = 16;//8000设备最大通道数
		public const int MaxAlarmin = 16;//8000设备最大报警输入数
		public const int MaxAlarmout = 4;//8000设备最大报警输出数
		//9000 IPC接入
		public const int MaxAnalogChannum = 32;//最大32个模拟通道
		public const int MaxAnalogAlarmout = 32; //最大32路模拟报警输出 
		public const int MaxAnalogAlarmin = 32;//最大32路模拟报警输入

		public const int MaxIpDevice = 32;//允许接入的最大IP设备数
		public const int MaxIpDeviceV40 = 64;//允许接入的最大IP设备数
		public const int MaxIpChannel = 32;//允许加入的最多IP通道数
		public const int MaxIpAlarmin = 128;//允许加入的最多报警输入数
		public const int MaxIpAlarmout = 64;//允许加入的最多报警输出数
		public const int MaxIpAlarminV40 = 4096;    //允许加入的最多报警输入数
		public const int MaxIpAlarmoutV40 = 4096;    //允许加入的最多报警输出数

		public const int MaxRecordFileNum = 20;      // 每次删除或者刻录的最大文件数

		//SDK_V31 ATM
		public const int MaxAtmNum = 1;
		public const int MaxActionType = 12;
		public const int AtmFrametypeNum = 4;
		public const int MaxAtmProtocolNum = 1025;
		public const int AtmProtocolSort = 4;
		public const int AtmDescLen = 32;
		// SDK_V31 ATM

		/* 最大支持的通道数 最大模拟加上最大IP支持 */
		public const int MaxChannumV30 = MaxAnalogChannum + MaxIpChannel;//64
		public const int MaxAlarmoutV30 = MaxAnalogAlarmout + MaxIpAlarmout;//96
		public const int MaxAlarminV30 = MaxAnalogAlarmin + MaxIpAlarmin;//160

		public const int MaxChannumV40 = 512;
		public const int MaxAlarmoutV40 = MaxIpAlarmoutV40 + MaxAnalogAlarmout;//4128
		public const int MaxAlarminV40 = MaxIpAlarminV40 + MaxAnalogAlarmout;//4128
		public const int MaxMultiAreaNum = 24;

		public const int MaxHumanPictureNum = 10;   //最大照片数
		public const int MaxHumanBirthdateLen = 10;

		public const int MaxLayernums = 32;

		public const int MaxRoidetectNum = 8;    //支持的ROI区域数
		public const int MaxLanerectNum   =     5;    //最大车牌识别区域数
		public const int MaxFortifyNum   =      10;   //最大布防个数
		public const int MaxIntervalNum  =      4;    //最大时间间隔个数
		public const int MaxChjcNum     =       3;    //最大车辆省份简称字符个数
		public const int MaxVlNum        =      5;    //最大虚拟线圈个数
		public const int MaxDrivechanNum =      16;   //最大车道数
		public const int MaxCoilNum      =      3;    //最大线圈个数
		public const int MaxSignallightNum =    6;   //最大信号灯个数
		public const int Len32				=	32;
		public const int Len31				=	31; 
		public const int MaxCabinetCount  =     8;    //最大支持机柜数量
		public const int MaxIdLen         =     48;
		public const int MaxParknoLen    =      16;
		public const int MaxAlarmreasonLen =    32;
		public const int MaxUpgradeInfoLen=    48; //获取升级文件匹配信息(模糊升级)
		public const int MaxCustomdirLen  =     32; //自定义目录长度

		public const int MaxTransparentChanNum  =    4;   //每个串口允许建立的最大透明通道数
		public const int MaxTransparentAccessNum =   4;   //每个监听端口允许接入的最大主机数

		//ITS
		public const int MaxParkingStatus  =     8;    //车位状态 0代表无车，1代表有车，2代表压线(优先级最高), 3特殊车位 
		public const int MaxParkingNum	   =      4;    //一个通道最大4个车位 (从左到右车位 数组0～3)

		public const int MaxItsSceneNum    =    16;   //最大场景数量
		public const int MaxSceneTimesegNum =   16;   //最大场景时间段数量
		public const int MaxIvmsIpChannel  =    128;  //最大IP通道数
		public const int DeviceIdLen      =      48;   //设备编号长度
		public const int MonitorsiteIdLen  =     48;   //监测点编号长度
		public const int MaxAuxareaNum       =   16;   //辅助区域最大数目
		public const int MaxSlaveChannelNum =   16;   //最大从通道数量

		public const int MaxSchTasksNum = 10;

		public const int MaxServeridLen   =         64; //最大服务器ID的长度
		public const int MaxServerdomainLen =       128; //服务器域名最大长度
		public const int MaxAuthenticateidLen =     64; //认证ID最大长度
		public const int MaxAuthenticatepasswdLen = 32; //认证密码最大长度
		public const int MaxServernameLen =         64; //最大服务器用户名 
		public const int MaxCompressionidLen =      64; //编码ID的最大长度
		public const int MaxSipserverAddressLen =  128; //SIP服务器地址支持域名和IP地址
		//压线报警
		public const int MaxPlAteNoLen =        32;   //车牌号码最大长度 2013-09-27
		public const int UpnpPortNum	=		12;	  //upnp端口映射端口数目

		
		public const int MaxLocalAddrLen	= 96;		//SOCKS最大本地网段个数
		public const int MaxCountryNameLen = 4;		//国家简写名称长度

		//码流连接方式
		public const int Normalconnect = 1;
		public const int Mediaconnect = 2;

		//设备型号(大类)
		public const int Hcdvr = 1;
		public const int Medvr = 2;
		public const int Pcdvr = 3;
		public const int Hc9000 = 4;
		public const int HfI = 5;
		public const int Pcnvr = 6;
		public const int Hc76Nvr = 8;

		//NVR类型
		public const int Ds8000HcNvr = 0;
		public const int Ds9000HcNvr = 1;
		public const int Ds8000MeNvr = 2;

		/*******************全局错误码 begin**********************/
		public const int NetDvrNoerror = 0;//没有错误
		public const int NetDvrPasswordError = 1;//用户名密码错误
		public const int NetDvrNoenoughpri = 2;//权限不足
		public const int NetDvrNoinit = 3;//没有初始化
		public const int NetDvrChannelError = 4;//通道号错误
		public const int NetDvrOverMaxlink = 5;//连接到DVR的客户端个数超过最大
		public const int NetDvrVersionnomatch = 6;//版本不匹配
		public const int NetDvrNetworkFailConnect = 7;//连接服务器失败
		public const int NetDvrNetworkSendError = 8;//向服务器发送失败
		public const int NetDvrNetworkRecvError = 9;//从服务器接收数据失败
		public const int NetDvrNetworkRecvTimeout = 10;//从服务器接收数据超时
		public const int NetDvrNetworkErrordata = 11;//传送的数据有误
		public const int NetDvrOrderError = 12;//调用次序错误
		public const int NetDvrOpernopermit = 13;//无此权限
		public const int NetDvrCommandtimeout = 14;//DVR命令执行超时
		public const int NetDvrErrorserialport = 15;//串口号错误
		public const int NetDvrErroralarmport = 16;//报警端口错误
		public const int NetDvrParameterError = 17;//参数错误
		public const int NetDvrChanException = 18;//服务器通道处于错误状态
		public const int NetDvrNodisk = 19;//没有硬盘
		public const int NetDvrErrordisknum = 20;//硬盘号错误
		public const int NetDvrDiskFull = 21;//服务器硬盘满
		public const int NetDvrDiskError = 22;//服务器硬盘出错
		public const int NetDvrNosupport = 23;//服务器不支持
		public const int NetDvrBusy = 24;//服务器忙
		public const int NetDvrModifyFail = 25;//服务器修改不成功
		public const int NetDvrPasswordFormatError = 26;//密码输入格式不正确
		public const int NetDvrDiskFormating = 27;//硬盘正在格式化，不能启动操作
		public const int NetDvrDvrnoresource = 28;//DVR资源不足
		public const int NetDvrDvropratefailed = 29;//DVR操作失败
		public const int NetDvrOpenhostsoundFail = 30;//打开PC声音失败
		public const int NetDvrDvrvoiceopened = 31;//服务器语音对讲被占用
		public const int NetDvrTimeinputerror = 32;//时间输入不正确
		public const int NetDvrNospecfile = 33;//回放时服务器没有指定的文件
		public const int NetDvrCreatefileError = 34;//创建文件出错
		public const int NetDvrFileopenfail = 35;//打开文件出错
		public const int NetDvrOpernotfinish = 36; //上次的操作还没有完成
		public const int NetDvrGetplaytimefail = 37;//获取当前播放的时间出错
		public const int NetDvrPlayfail = 38;//播放出错
		public const int NetDvrFileformatError = 39;//文件格式不正确
		public const int NetDvrDirError = 40;//路径错误
		public const int NetDvrAllocResourceError = 41;//资源分配错误
		public const int NetDvrAudioModeError = 42;//声卡模式错误
		public const int NetDvrNoenoughBuf = 43;//缓冲区太小
		public const int NetDvrCreatesocketError = 44;//创建SOCKET出错
		public const int NetDvrSetsocketError = 45;//设置SOCKET出错
		public const int NetDvrMaxNum = 46;//个数达到最大
		public const int NetDvrUsernotexist = 47;//用户不存在
		public const int NetDvrWriteflasherror = 48;//写FLASH出错
		public const int NetDvrUpgradefail = 49;//DVR升级失败
		public const int NetDvrCardhaveinit = 50;//解码卡已经初始化过
		public const int NetDvrPlayerfailed = 51;//调用播放库中某个函数失败
		public const int NetDvrMaxUsernum = 52;//设备端用户数达到最大
		public const int NetDvrGetlocalipandmacfail = 53;//获得客户端的IP地址或物理地址失败
		public const int NetDvrNoencodeing = 54;//该通道没有编码
		public const int NetDvrIpmismatch = 55;//IP地址不匹配
		public const int NetDvrMacmismatch = 56;//MAC地址不匹配
		public const int NetDvrUpgradelangmismatch = 57;//升级文件语言不匹配
		public const int NetDvrMaxPlayerport = 58;//播放器路数达到最大
		public const int NetDvrNospacebackup = 59;//备份设备中没有足够空间进行备份
		public const int NetDvrNodevicebackup = 60;//没有找到指定的备份设备
		public const int NetDvrPictureBitsError = 61;//图像素位数不符，限24色
		public const int NetDvrPictureDimensionError = 62;//图片高*宽超限， 限128*256
		public const int NetDvrPictureSizError = 63;//图片大小超限，限100K
		public const int NetDvrLoadplayersdkfailed = 64;//载入当前目录下Player Sdk出错
		public const int NetDvrLoadplayersdkprocError = 65;//找不到Player Sdk中某个函数入口
		public const int NetDvrLoaddssdkfailed = 66;//载入当前目录下DSsdk出错
		public const int NetDvrLoaddssdkprocError = 67;//找不到DsSdk中某个函数入口
		public const int NetDvrDssdkError = 68;//调用硬解码库DsSdk中某个函数失败
		public const int NetDvrVoicemonopolize = 69;//声卡被独占
		public const int NetDvrJoinmulticastfailed = 70;//加入多播组失败
		public const int NetDvrCreatedirError = 71;//建立日志文件目录失败
		public const int NetDvrBindsocketError = 72;//绑定套接字失败
		public const int NetDvrSocketcloseError = 73;//socket连接中断，此错误通常是由于连接中断或目的地不可达
		public const int NetDvrUseridIsusing = 74;//注销时用户ID正在进行某操作
		public const int NetDvrSocketlistenError = 75;//监听失败
		public const int NetDvrProgramException = 76;//程序异常
		public const int NetDvrWritefileFailed = 77;//写文件失败
		public const int NetDvrFormatReadonly = 78;//禁止格式化只读硬盘
		public const int NetDvrWithsameusername = 79;//用户配置结构中存在相同的用户名
		public const int NetDvrDevicetypeError = 80;//导入参数时设备型号不匹配
		public const int NetDvrLanguageError = 81;//导入参数时语言不匹配
		public const int NetDvrParaversionError = 82;//导入参数时软件版本不匹配
		public const int NetDvrIpchanNotalive = 83; //预览时外接IP通道不在线
		public const int NetDvrRtspSdkError = 84;//加载高清IPC通讯库StreamTransClient.dll失败
		public const int NetDvrConvertSdkError = 85;//加载转码库失败
		public const int NetDvrIpcCountOverflow = 86;//超出最大的ip接入通道数

		public const int NetPlaym4Noerror = 500;//no error
		public const int NetPlaym4ParaOver = 501;//input parameter is invalid
		public const int NetPlaym4OrderError = 502;//The order of the function to be called is error
		public const int NetPlaym4TimerError = 503;//Create multimedia clock failed
		public const int NetPlaym4DecVideoError = 504;//Decode video data failed
		public const int NetPlaym4DecAudioError = 505;//Decode audio data failed
		public const int NetPlaym4AllocMemoryError = 506;//Allocate memory failed
		public const int NetPlaym4OpenFileError = 507;//Open the file failed
		public const int NetPlaym4CreateObjError = 508;//Create thread or event failed
		public const int NetPlaym4CreateDdrawError = 509;//Create DirectDraw object failed
		public const int NetPlaym4CreateOffscreenError = 510;//failed when creating off-screen surface
		public const int NetPlaym4BufOver = 511;//buffer is overflow
		public const int NetPlaym4CreateSoundError = 512;//failed when creating audio device
		public const int NetPlaym4SetVolumeError = 513;//Set volume failed
		public const int NetPlaym4SupportFileOnly = 514;//The function only support play file
		public const int NetPlaym4SupportStreamOnly = 515;//The function only support play stream
		public const int NetPlaym4SysNotSupport = 516;//System not support
		public const int NetPlaym4FileheaderUnknown = 517;//No file header
		public const int NetPlaym4VersionIncorrect = 518;//The version of decoder and encoder is not adapted
		public const int NetPalym4InitDecoderError = 519;//Initialize decoder failed
		public const int NetPlaym4CheckFileError = 520;//The file data is unknown
		public const int NetPlaym4InitTimerError = 521;//Initialize multimedia clock failed
		public const int NetPlaym4BltError = 522;//Blt failed
		public const int NetPlaym4UpdateError = 523;//Update failed
		public const int NetPlaym4OpenFileErrorMulti = 524;//openfile error, streamtype is multi
		public const int NetPlaym4OpenFileErrorVideo = 525;//openfile error, streamtype is video
		public const int NetPlaym4JpegCompressError = 526;//JPEG compress error
		public const int NetPlaym4ExtractNotSupport = 527;//Don't support the version of this file
		public const int NetPlaym4ExtractDataError = 528;//extract video data failed
		/*******************全局错误码 end**********************/

		/*************************************************
		NET_DVR_IsSupport()返回值
		1－9位分别表示以下信息（位与是TRUE)表示支持；
		**************************************************/
		public const int NetDvrSupportDdraw = 1;//支持DIRECTDRAW，如果不支持，则播放器不能工作
		public const int NetDvrSupportBlt = 2;//显卡支持BLT操作，如果不支持，则播放器不能工作
		public const int NetDvrSupportBltfourcc = 4;//显卡BLT支持颜色转换，如果不支持，播放器会用软件方法作RGB转换
		public const int NetDvrSupportBltshrinkx = 8;//显卡BLT支持X轴缩小；如果不支持，系统会用软件方法转换
		public const int NetDvrSupportBltshrinky = 16;//显卡BLT支持Y轴缩小；如果不支持，系统会用软件方法转换
		public const int NetDvrSupportBltstretchx = 32;//显卡BLT支持X轴放大；如果不支持，系统会用软件方法转换
		public const int NetDvrSupportBltstretchy = 64;//显卡BLT支持Y轴放大；如果不支持，系统会用软件方法转换
		public const int NetDvrSupportSse = 128;//CPU支持SSE指令，Intel Pentium3以上支持SSE指令
		public const int NetDvrSupportMmx = 256;//CPU支持MMX指令集，Intel Pentium3以上支持SSE指令

		/**********************云台控制命令 begin*************************/
		public const int LightPwron = 2;// 接通灯光电源
		public const int WiperPwron = 3;// 接通雨刷开关 
		public const int FanPwron = 4;// 接通风扇开关
		public const int HeaterPwron = 5;// 接通加热器开关
		public const int AuxPwron1 = 6;// 接通辅助设备开关
		public const int AuxPwron2 = 7;// 接通辅助设备开关 
		public const int SetPreset = 8;// 设置预置点 
		public const int ClePreset = 9;// 清除预置点 

		public const int ZoomIn = 11;// 焦距以速度SS变大(倍率变大)
		public const int ZoomOut = 12;// 焦距以速度SS变小(倍率变小)
		public const int FocusNear = 13;// 焦点以速度SS前调 
		public const int FocusFar = 14;// 焦点以速度SS后调
		public const int IrisOpen = 15;// 光圈以速度SS扩大
		public const int IrisClose = 16;// 光圈以速度SS缩小 

		public const int TiltUp = 21;/* 云台以SS的速度上仰 */
		public const int TiltDown = 22;/* 云台以SS的速度下俯 */
		public const int PanLeft = 23;/* 云台以SS的速度左转 */
		public const int PanRight = 24;/* 云台以SS的速度右转 */
		public const int UpLeft = 25;/* 云台以SS的速度上仰和左转 */
		public const int UpRight = 26;/* 云台以SS的速度上仰和右转 */
		public const int DownLeft = 27;/* 云台以SS的速度下俯和左转 */
		public const int DownRight = 28;/* 云台以SS的速度下俯和右转 */
		public const int PanAuto = 29;/* 云台以SS的速度左右自动扫描 */

		public const int FillPreSeq = 30;/* 将预置点加入巡航序列 */
		public const int SetSeqDwell = 31;/* 设置巡航点停顿时间 */
		public const int SetSeqSpeed = 32;/* 设置巡航速度 */
		public const int ClePreSeq = 33;/* 将预置点从巡航序列中删除 */
		public const int StaMemCruise = 34;/* 开始记录轨迹 */
		public const int StoMemCruise = 35;/* 停止记录轨迹 */
		public const int RunCruise = 36;/* 开始轨迹 */
		public const int RunSeq = 37;/* 开始巡航 */
		public const int StopSeq = 38;/* 停止巡航 */
		public const int GotoPreset = 39;/* 快球转到预置点 */
		/**********************云台控制命令 end*************************/

		/*************************************************
		回放时播放控制命令宏定义 
		NET_DVR_PlayBackControl
		NET_DVR_PlayControlLocDisplay
		NET_DVR_DecPlayBackCtrl的宏定义
		具体支持查看函数说明和代码
		**************************************************/
		public const int NetDvrPlaystart = 1;//开始播放
		public const int NetDvrPlaystop = 2;//停止播放
		public const int NetDvrPlaypause = 3;//暂停播放
		public const int NetDvrPlayrestart = 4;//恢复播放
		public const int NetDvrPlayfast = 5;//快放
		public const int NetDvrPlayslow = 6;//慢放
		public const int NetDvrPlaynormal = 7;//正常速度
		public const int NetDvrPlayframe = 8;//单帧放
		public const int NetDvrPlaystartaudio = 9;//打开声音
		public const int NetDvrPlaystopaudio = 10;//关闭声音
		public const int NetDvrPlayaudiovolume = 11;//调节音量
		public const int NetDvrPlaysetpos = 12;//改变文件回放的进度
		public const int NetDvrPlaygetpos = 13;//获取文件回放的进度
		public const int NetDvrPlaygettime = 14;//获取当前已经播放的时间(按文件回放的时候有效)
		public const int NetDvrPlaygetframe = 15;//获取当前已经播放的帧数(按文件回放的时候有效)
		public const int NetDvrGettotalframes = 16;//获取当前播放文件总的帧数(按文件回放的时候有效)
		public const int NetDvrGettotaltime = 17;//获取当前播放文件总的时间(按文件回放的时候有效)
		public const int NetDvrThrowbframe = 20;//丢B帧
		public const int NetDvrSetspeed = 24;//设置码流速度
		public const int NetDvrKeepalive = 25;//保持与设备的心跳(如果回调阻塞，建议2秒发送一次)
		public const int NetDvrPlaysettime = 26;//按绝对时间定位
		public const int NetDvrPlaygettotallen = 27;//获取按时间回放对应时间段内的所有文件的总长度
		public const int NetDvrPlayForward = 29;//倒放切换为正放
		public const int NetDvrPlayReverse = 30;//正放切换为倒放
		public const int NetDvrSetTransType = 32;//设置转封装类型
		public const int NetDvrPlayConvert = 33;//正放切换为倒放

		//远程按键定义如下：
		/* Key value send to CONFIG program */
		public const int KeyCode1 = 1;
		public const int KeyCode2 = 2;
		public const int KeyCode3 = 3;
		public const int KeyCode4 = 4;
		public const int KeyCode5 = 5;
		public const int KeyCode6 = 6;
		public const int KeyCode7 = 7;
		public const int KeyCode8 = 8;
		public const int KeyCode9 = 9;
		public const int KeyCode0 = 10;
		public const int KeyCodePower = 11;
		public const int KeyCodeMenu = 12;
		public const int KeyCodeEnter = 13;
		public const int KeyCodeCancel = 14;
		public const int KeyCodeUp = 15;
		public const int KeyCodeDown = 16;
		public const int KeyCodeLeft = 17;
		public const int KeyCodeRight = 18;
		public const int KeyCodeEdit = 19;
		public const int KeyCodeAdd = 20;
		public const int KeyCodeMinus = 21;
		public const int KeyCodePlay = 22;
		public const int KeyCodeRec = 23;
		public const int KeyCodePan = 24;
		public const int KeyCodeM = 25;
		public const int KeyCodeA = 26;
		public const int KeyCodeF1 = 27;
		public const int KeyCodeF2 = 28;

		/* for PTZ control */
		public const int KeyPtzUpStart = KeyCodeUp;
		public const int KeyPtzUpStop = 32;

		public const int KeyPtzDownStart = KeyCodeDown;
		public const int KeyPtzDownStop = 33;


		public const int KeyPtzLeftStart = KeyCodeLeft;
		public const int KeyPtzLeftStop = 34;

		public const int KeyPtzRightStart = KeyCodeRight;
		public const int KeyPtzRightStop = 35;

		public const int KeyPtzAp1Start = KeyCodeEdit;/* 光圈+ */
		public const int KeyPtzAp1Stop = 36;

		public const int KeyPtzAp2Start = KeyCodePan;/* 光圈- */
		public const int KeyPtzAp2Stop = 37;

		public const int KeyPtzFocus1Start = KeyCodeA;/* 聚焦+ */
		public const int KeyPtzFocus1Stop = 38;

		public const int KeyPtzFocus2Start = KeyCodeM;/* 聚焦- */
		public const int KeyPtzFocus2Stop = 39;

		public const int KeyPtzB1Start = 40;/* 变倍+ */
		public const int KeyPtzB1Stop = 41;

		public const int KeyPtzB2Start = 42;/* 变倍- */
		public const int KeyPtzB2Stop = 43;

		//9000新增
		public const int KeyCode11 = 44;
		public const int KeyCode12 = 45;
		public const int KeyCode13 = 46;
		public const int KeyCode14 = 47;
		public const int KeyCode15 = 48;
		public const int KeyCode16 = 49;

		/*************************参数配置命令 begin*******************************/
		//用于NET_DVR_SetDVRConfig和NET_DVR_GetDVRConfig,注意其对应的配置结构
		public const int NetDvrGetDevicecfg = 100;//获取设备参数
		public const int NetDvrSetDevicecfg = 101;//设置设备参数
		public const int NetDvrGetNetcfg = 102;//获取网络参数
		public const int NetDvrSetNetcfg = 103;//设置网络参数
		public const int NetDvrGetPiccfg = 104;//获取图象参数
		public const int NetDvrSetPiccfg = 105;//设置图象参数
		public const int NetDvrGetCompresscfg = 106;//获取压缩参数
		public const int NetDvrSetCompresscfg = 107;//设置压缩参数
		public const int NetDvrGetRecordcfg = 108;//获取录像时间参数
		public const int NetDvrSetRecordcfg = 109;//设置录像时间参数
		public const int NetDvrGetDecodercfg = 110;//获取解码器参数
		public const int NetDvrSetDecodercfg = 111;//设置解码器参数
		public const int NetDvrGetRs232Cfg = 112;//获取232串口参数
		public const int NetDvrSetRs232Cfg = 113;//设置232串口参数
		public const int NetDvrGetAlarmincfg = 114;//获取报警输入参数
		public const int NetDvrSetAlarmincfg = 115;//设置报警输入参数
		public const int NetDvrGetAlarmoutcfg = 116;//获取报警输出参数
		public const int NetDvrSetAlarmoutcfg = 117;//设置报警输出参数
		public const int NetDvrGetTimecfg = 118;//获取DVR时间
		public const int NetDvrSetTimecfg = 119;//设置DVR时间
		public const int NetDvrGetPreviewcfg = 120;//获取预览参数
		public const int NetDvrSetPreviewcfg = 121;//设置预览参数
		public const int NetDvrGetVideooutcfg = 122;//获取视频输出参数
		public const int NetDvrSetVideooutcfg = 123;//设置视频输出参数
		public const int NetDvrGetUsercfg = 124;//获取用户参数
		public const int NetDvrSetUsercfg = 125;//设置用户参数
		public const int NetDvrGetExceptioncfg = 126;//获取异常参数
		public const int NetDvrSetExceptioncfg = 127;//设置异常参数
		public const int NetDvrGetZoneanddst = 128;//获取时区和夏时制参数
		public const int NetDvrSetZoneanddst = 129;//设置时区和夏时制参数
		public const int NetDvrGetShowstring = 130;//获取叠加字符参数
		public const int NetDvrSetShowstring = 131;//设置叠加字符参数
		public const int NetDvrGetEventcompcfg = 132;//获取事件触发录像参数
		public const int NetDvrSetEventcompcfg = 133;//设置事件触发录像参数

		public const int NetDvrGetAuxoutcfg = 140;//获取报警触发辅助输出设置(HS设备辅助输出2006-02-28)
		public const int NetDvrSetAuxoutcfg = 141;//设置报警触发辅助输出设置(HS设备辅助输出2006-02-28)
		public const int NetDvrGetPreviewcfgAux = 142;//获取-s系列双输出预览参数(-s系列双输出2006-04-13)
		public const int NetDvrSetPreviewcfgAux = 143;//设置-s系列双输出预览参数(-s系列双输出2006-04-13)

		public const int NetDvrGetPiccfgEx = 200;//获取图象参数(SDK_V14扩展命令)
		public const int NetDvrSetPiccfgEx = 201;//设置图象参数(SDK_V14扩展命令)
		public const int NetDvrGetUsercfgEx = 202;//获取用户参数(SDK_V15扩展命令)
		public const int NetDvrSetUsercfgEx = 203;//设置用户参数(SDK_V15扩展命令)
		public const int NetDvrGetCompresscfgEx = 204;//获取压缩参数(SDK_V15扩展命令2006-05-15)
		public const int NetDvrSetCompresscfgEx = 205;//设置压缩参数(SDK_V15扩展命令2006-05-15)

		public const int NetDvrGetNetappcfg = 222;//获取网络应用参数 NTP/DDNS/EMAIL
		public const int NetDvrSetNetappcfg = 223;//设置网络应用参数 NTP/DDNS/EMAIL
		public const int NetDvrGetNtpcfg = 224;//获取网络应用参数 NTP
		public const int NetDvrSetNtpcfg = 225;//设置网络应用参数 NTP
		public const int NetDvrGetDdnscfg = 226;//获取网络应用参数 DDNS
		public const int NetDvrSetDdnscfg = 227;//设置网络应用参数 DDNS
		//对应NET_DVR_EMAILPARA
		public const int NetDvrGetEmailcfg = 228;//获取网络应用参数 EMAIL
		public const int NetDvrSetEmailcfg = 229;//设置网络应用参数 EMAIL

		public const int NetDvrGetNfscfg = 230;/* NFS disk config */
		public const int NetDvrSetNfscfg = 231;/* NFS disk config */

		public const int NetDvrGetShowstringEx = 238;//获取叠加字符参数扩展(支持8条字符)
		public const int NetDvrSetShowstringEx = 239;//设置叠加字符参数扩展(支持8条字符)
		public const int NetDvrGetNetcfgOther = 244;//获取网络参数
		public const int NetDvrSetNetcfgOther = 245;//设置网络参数

		//对应NET_DVR_EMAILCFG结构
		public const int NetDvrGetEmailparacfg = 250;//Get EMAIL parameters
		public const int NetDvrSetEmailparacfg = 251;//Setup EMAIL parameters

		public const int NetDvrGetDdnscfgEx = 274;//获取扩展DDNS参数
		public const int NetDvrSetDdnscfgEx = 275;//设置扩展DDNS参数

		public const int NetDvrSetPtzpos = 292;//云台设置PTZ位置
		public const int NetDvrGetPtzpos = 293;//云台获取PTZ位置
		public const int NetDvrGetPtzscope = 294;//云台获取PTZ范围

		public const int NetDvrGetApInfoList = 305;//获取无线网络资源参数
		public const int NetDvrSetWifiCfg = 306;//设置IP监控设备无线参数
		public const int NetDvrGetWifiCfg = 307;//获取IP监控设备无线参数
		public const int NetDvrSetWifiWorkmode = 308;//设置IP监控设备网口工作模式参数
		public const int NetDvrGetWifiWorkmode = 309;//获取IP监控设备网口工作模式参数 
		public const int NetDvrGetWifiStatus = 310;	//获取设备当前wifi连接状态
		/***************************DS9000新增命令(_V30) begin *****************************/
		//网络(NET_DVR_NETCFG_V30结构)
		public const int NetDvrGetNetcfgV30 = 1000;//获取网络参数
		public const int NetDvrSetNetcfgV30 = 1001;//设置网络参数

		//图象(NET_DVR_PICCFG_V30结构)
		public const int NetDvrGetPiccfgV30 = 1002;//获取图象参数
		public const int NetDvrSetPiccfgV30 = 1003;//设置图象参数

		//图象(NET_DVR_PICCFG_V40结构)
		public const int NetDvrGetPiccfgV40 = 6179;//获取图象参数V40扩展
		public const int NetDvrSetPiccfgV40 = 6180;//设置图象参数V40扩展

		//录像时间(NET_DVR_RECORD_V30结构)
		public const int NetDvrGetRecordcfgV30 = 1004;//获取录像参数
		public const int NetDvrSetRecordcfgV30 = 1005;//设置录像参数

		//用户(NET_DVR_USER_V30结构)
		public const int NetDvrGetUsercfgV30 = 1006;//获取用户参数
		public const int NetDvrSetUsercfgV30 = 1007;//设置用户参数

		//9000DDNS参数配置(NET_DVR_DDNSPARA_V30结构)
		public const int NetDvrGetDdnscfgV30 = 1010;//获取DDNS(9000扩展)
		public const int NetDvrSetDdnscfgV30 = 1011;//设置DDNS(9000扩展)

		//EMAIL功能(NET_DVR_EMAILCFG_V30结构)
		public const int NetDvrGetEmailcfgV30 = 1012;//获取EMAIL参数 
		public const int NetDvrSetEmailcfgV30 = 1013;//设置EMAIL参数 

		//巡航参数 (NET_DVR_CRUISE_PARA结构)
		public const int NetDvrGetCruise = 1020;
		public const int NetDvrSetCruise = 1021;

		//报警输入结构参数 (NET_DVR_ALARMINCFG_V30结构)
		public const int NetDvrGetAlarmincfgV30 = 1024;
		public const int NetDvrSetAlarmincfgV30 = 1025;

		//报警输出结构参数 (NET_DVR_ALARMOUTCFG_V30结构)
		public const int NetDvrGetAlarmoutcfgV30 = 1026;
		public const int NetDvrSetAlarmoutcfgV30 = 1027;

		//视频输出结构参数 (NET_DVR_VIDEOOUT_V30结构)
		public const int NetDvrGetVideooutcfgV30 = 1028;
		public const int NetDvrSetVideooutcfgV30 = 1029;

		//叠加字符结构参数 (NET_DVR_SHOWSTRING_V30结构)
		public const int NetDvrGetShowstringV30 = 1030;
		public const int NetDvrSetShowstringV30 = 1031;

		//异常结构参数 (NET_DVR_EXCEPTION_V30结构)
		public const int NetDvrGetExceptioncfgV30 = 1034;
		public const int NetDvrSetExceptioncfgV30 = 1035;

		//串口232结构参数 (NET_DVR_RS232CFG_V30结构)
		public const int NetDvrGetRs232CfgV30 = 1036;
		public const int NetDvrSetRs232CfgV30 = 1037;

		//网络硬盘接入结构参数 (NET_DVR_NET_DISKCFG结构)
		public const int NetDvrGetNetDiskcfg = 1038;//网络硬盘接入获取
		public const int NetDvrSetNetDiskcfg = 1039;//网络硬盘接入设置

		//压缩参数 (NET_DVR_COMPRESSIONCFG_V30结构)
		public const int NetDvrGetCompresscfgV30 = 1040;
		public const int NetDvrSetCompresscfgV30 = 1041;

		//获取485解码器参数 (NET_DVR_DECODERCFG_V30结构)
		public const int NetDvrGetDecodercfgV30 = 1042;//获取解码器参数
		public const int NetDvrSetDecodercfgV30 = 1043;//设置解码器参数

		//获取预览参数 (NET_DVR_PREVIEWCFG_V30结构)
		public const int NetDvrGetPreviewcfgV30 = 1044;//获取预览参数
		public const int NetDvrSetPreviewcfgV30 = 1045;//设置预览参数

		//辅助预览参数 (NET_DVR_PREVIEWCFG_AUX_V30结构)
		public const int NetDvrGetPreviewcfgAuxV30 = 1046;//获取辅助预览参数
		public const int NetDvrSetPreviewcfgAuxV30 = 1047;//设置辅助预览参数

		//IP接入配置参数 （NET_DVR_IPPARACFG结构）
		public const int NetDvrGetIpparacfg = 1048; //获取IP接入配置信息 
		public const int NetDvrSetIpparacfg = 1049;//设置IP接入配置信息

		//IP接入配置参数 （NET_DVR_IPPARACFG_V40结构）
		public const int NetDvrGetIpparacfgV40 = 1062; //获取IP接入配置信息 
		public const int NetDvrSetIpparacfgV40 = 1063;//设置IP接入配置信息

		//IP报警输入接入配置参数 （NET_DVR_IPALARMINCFG结构）
		public const int NetDvrGetIpalarmincfg = 1050; //获取IP报警输入接入配置信息 
		public const int NetDvrSetIpalarmincfg = 1051; //设置IP报警输入接入配置信息

		//IP报警输出接入配置参数 （NET_DVR_IPALARMOUTCFG结构）
		public const int NetDvrGetIpalarmoutcfg = 1052;//获取IP报警输出接入配置信息 
		public const int NetDvrSetIpalarmoutcfg = 1053;//设置IP报警输出接入配置信息

		//硬盘管理的参数获取 (NET_DVR_HDCFG结构)
		public const int NetDvrGetHdcfg = 1054;//获取硬盘管理配置参数
		public const int NetDvrSetHdcfg = 1055;//设置硬盘管理配置参数

		//盘组管理的参数获取 (NET_DVR_HDGROUP_CFG结构)
		public const int NetDvrGetHdgroupCfg = 1056;//获取盘组管理配置参数
		public const int NetDvrSetHdgroupCfg = 1057;//设置盘组管理配置参数

		//设备编码类型配置(NET_DVR_COMPRESSION_AUDIO结构)
		public const int NetDvrGetCompresscfgAud = 1058;//获取设备语音对讲编码参数
		public const int NetDvrSetCompresscfgAud = 1059;//设置设备语音对讲编码参数

		//IP接入配置参数 （NET_DVR_IPPARACFG_V31结构）
		public const int NetDvrGetIpparacfgV31 = 1060;//获取IP接入配置信息 
		public const int NetDvrSetIpparacfgV31 = 1061; //设置IP接入配置信息

		//设备参数配置 （NET_DVR_DEVICECFG_V40结构）
		public const int NetDvrGetDevicecfgV40 = 1100;//获取设备参数
		public const int NetDvrSetDevicecfgV40 = 1101;//设置设备参数

		//多网卡配置(NET_DVR_NETCFG_MULTI结构)
		public const int NetDvrGetNetcfgMulti = 1161;
		public const int NetDvrSetNetcfgMulti = 1162;

		//BONDING网卡(NET_DVR_NETWORK_BONDING结构)
		public const int NetDvrGetNetworkBonding = 1254;
		public const int NetDvrSetNetworkBonding = 1255;

		//NAT映射配置参数 （NET_DVR_NAT_CFG结构）
		public const int NetDvrGetNatCfg = 6111;    //获取NAT映射参数
		public const int NetDvrSetNatCfg = 6112;    //设置NAT映射参数  
		/*************************参数配置命令 end*******************************/

		/************************DVR日志 begin***************************/
		/* 报警 */
		//主类型
		public const int MajorAlarm = 1;
		//次类型
		public const int MinorAlarmIn = 1;/* 报警输入 */
		public const int MinorAlarmOut = 2;/* 报警输出 */
		public const int MinorMotdetStart = 3; /* 移动侦测报警开始 */
		public const int MinorMotdetStop = 4; /* 移动侦测报警结束 */
		public const int MinorHideAlarmStart = 5;/* 遮挡报警开始 */
		public const int MinorHideAlarmStop = 6;/* 遮挡报警结束 */
		public const int MinorVcaAlarmStart = 7;/*智能报警开始*/
		public const int MinorVcaAlarmStop = 8;/*智能报警停止*/

		/* 异常 */
		//主类型
		public const int MajorException = 2;
		//次类型
		public const int MinorViLost = 33;/* 视频信号丢失 */
		public const int MinorIllegalAccess = 34;/* 非法访问 */
		public const int MinorHdFull = 35;/* 硬盘满 */
		public const int MinorHdError = 36;/* 硬盘错误 */
		public const int MinorDcdLost = 37;/* MODEM 掉线(保留不使用) */
		public const int MinorIpConflict = 38;/* IP地址冲突 */
		public const int MinorNetBroken = 39;/* 网络断开*/
		public const int MinorRecError = 40;/* 录像出错 */
		public const int MinorIpcNoLink = 41;/* IPC连接异常 */
		public const int MinorViException = 42;/* 视频输入异常(只针对模拟通道) */
		public const int MinorIpcIpConflict = 43;/*ipc ip 地址 冲突*/

		//视频综合平台
		public const int MinorFanabnormal = 49;/* 视频综合平台：风扇状态异常 */
		public const int MinorFanresume = 50;/* 视频综合平台：风扇状态恢复正常 */
		public const int MinorSubsystemAbnormalreboot = 51;/* 视频综合平台：6467异常重启 */
		public const int MinorMatrixStartbuzzer = 52;/* 视频综合平台：dm6467异常，启动蜂鸣器 */

		/* 操作 */
		//主类型
		public const int MajorOperation = 3;
		//次类型
		public const int MinorStartDvr = 65;/* 开机 */
		public const int MinorStopDvr = 66;/* 关机 */
		public const int MinorStopAbnormal = 67;/* 异常关机 */
		public const int MinorRebootDvr = 68;/*本地重启设备*/

		public const int MinorLocalLogin = 80;/* 本地登陆 */
		public const int MinorLocalLogout = 81;/* 本地注销登陆 */
		public const int MinorLocalCfgParm = 82;/* 本地配置参数 */
		public const int MinorLocalPlaybyfile = 83;/* 本地按文件回放或下载 */
		public const int MinorLocalPlaybytime = 84;/* 本地按时间回放或下载*/
		public const int MinorLocalStartRec = 85;/* 本地开始录像 */
		public const int MinorLocalStopRec = 86;/* 本地停止录像 */
		public const int MinorLocalPtzctrl = 87;/* 本地云台控制 */
		public const int MinorLocalPreview = 88;/* 本地预览 (保留不使用)*/
		public const int MinorLocalModifyTime = 89;/* 本地修改时间(保留不使用) */
		public const int MinorLocalUpgrade = 90;/* 本地升级 */
		public const int MinorLocalRecfileOutput = 91;/* 本地备份录象文件 */
		public const int MinorLocalFormatHdd = 92;/* 本地初始化硬盘 */
		public const int MinorLocalCfgfileOutput = 93;/* 导出本地配置文件 */
		public const int MinorLocalCfgfileInput = 94;/* 导入本地配置文件 */
		public const int MinorLocalCopyfile = 95;/* 本地备份文件 */
		public const int MinorLocalLockfile = 96;/* 本地锁定录像文件 */
		public const int MinorLocalUnlockfile = 97;/* 本地解锁录像文件 */
		public const int MinorLocalDvrAlarm = 98;/* 本地手动清除和触发报警*/
		public const int MinorIpcAdd = 99;/* 本地添加IPC */
		public const int MinorIpcDel = 100;/* 本地删除IPC */
		public const int MinorIpcSet = 101;/* 本地设置IPC */
		public const int MinorLocalStartBackup = 102;/* 本地开始备份 */
		public const int MinorLocalStopBackup = 103;/* 本地停止备份*/
		public const int MinorLocalCopyfileStartTime = 104;/* 本地备份开始时间*/
		public const int MinorLocalCopyfileEndTime = 105;/* 本地备份结束时间*/
		public const int MinorLocalAddNas = 106;/*本地添加网络硬盘*/
		public const int MinorLocalDelNas = 107;/* 本地删除nas盘*/
		public const int MinorLocalSetNas = 108;/* 本地设置nas盘*/

		public const int MinorRemoteLogin = 112;/* 远程登录 */
		public const int MinorRemoteLogout = 113;/* 远程注销登陆 */
		public const int MinorRemoteStartRec = 114;/* 远程开始录像 */
		public const int MinorRemoteStopRec = 115;/* 远程停止录像 */
		public const int MinorStartTransChan = 116;/* 开始透明传输 */
		public const int MinorStopTransChan = 117;/* 停止透明传输 */
		public const int MinorRemoteGetParm = 118;/* 远程获取参数 */
		public const int MinorRemoteCfgParm = 119;/* 远程配置参数 */
		public const int MinorRemoteGetStatus = 120;/* 远程获取状态 */
		public const int MinorRemoteArm = 121;/* 远程布防 */
		public const int MinorRemoteDisarm = 122;/* 远程撤防 */
		public const int MinorRemoteReboot = 123;/* 远程重启 */
		public const int MinorStartVt = 124;/* 开始语音对讲 */
		public const int MinorStopVt = 125;/* 停止语音对讲 */
		public const int MinorRemoteUpgrade = 126;/* 远程升级 */
		public const int MinorRemotePlaybyfile = 127;/* 远程按文件回放 */
		public const int MinorRemotePlaybytime = 128;/* 远程按时间回放 */
		public const int MinorRemotePtzctrl = 129;/* 远程云台控制 */
		public const int MinorRemoteFormatHdd = 130;/* 远程格式化硬盘 */
		public const int MinorRemoteStop = 131;/* 远程关机 */
		public const int MinorRemoteLockfile = 132;/* 远程锁定文件 */
		public const int MinorRemoteUnlockfile = 133;/* 远程解锁文件 */
		public const int MinorRemoteCfgfileOutput = 134;/* 远程导出配置文件 */
		public const int MinorRemoteCfgfileIntput = 135;/* 远程导入配置文件 */
		public const int MinorRemoteRecfileOutput = 136;/* 远程导出录象文件 */
		public const int MinorRemoteDvrAlarm = 137;/* 远程手动清除和触发报警*/
		public const int MinorRemoteIpcAdd = 138;/* 远程添加IPC */
		public const int MinorRemoteIpcDel = 139;/* 远程删除IPC */
		public const int MinorRemoteIpcSet = 140;/* 远程设置IPC */
		public const int MinorRebootVcaLib = 141;/*重启智能库*/
		public const int MinorRemoteAddNas = 142;/* 远程添加nas盘*/
		public const int MinorRemoteDelNas = 143;/* 远程删除nas盘*/
		public const int MinorRemoteSetNas = 144;/* 远程设置nas盘*/

		//2009-12-16 增加视频综合平台日志类型
		public const int MinorSubsystemreboot = 160;/*视频综合平台：dm6467 正常重启*/
		public const int MinorMatrixStarttransfervideo = 161;	/*视频综合平台：矩阵切换开始传输图像*/
		public const int MinorMatrixStoptransfervideo = 162;	/*视频综合平台：矩阵切换停止传输图像*/
		public const int MinorRemoteSetAllsubsystem = 163;	/*视频综合平台：设置所有6467子系统信息*/
		public const int MinorRemoteGetAllsubsystem = 164;	/*视频综合平台：获取所有6467子系统信息*/
		public const int MinorRemoteSetPlanarray = 165;	/*视频综合平台：设置计划轮询组*/
		public const int MinorRemoteGetPlanarray = 166;	/*视频综合平台：获取计划轮询组*/
		public const int MinorMatrixStarttransferaudio = 167;	/*视频综合平台：矩阵切换开始传输音频*/
		public const int MinorMatrixStopransferaudio = 168;	/*视频综合平台：矩阵切换停止传输音频*/
		public const int MinorLogonCodespitter = 169;	/*视频综合平台：登陆码分器*/
		public const int MinorLogoffCodespitter = 170;	/*视频综合平台：退出码分器*/

		/*日志附加信息*/
		//主类型
		public const int MajorInformation = 4;/*附加信息*/
		//次类型
		public const int MinorHddInfo = 161;/*硬盘信息*/
		public const int MinorSmartInfo = 162;/*SMART信息*/
		public const int MinorRecStart = 163;/*开始录像*/
		public const int MinorRecStop = 164;/*停止录像*/
		public const int MinorRecOverdue = 165;/*过期录像删除*/
		public const int MinorLinkStart = 166;//连接前端设备
		public const int MinorLinkStop = 167;//断开前端设备　
		public const int MinorNetDiskInfo = 168;//网络硬盘信息

		//当日志的主类型为MAJOR_OPERATION=03，次类型为MINOR_LOCAL_CFG_PARM=0x52或者MINOR_REMOTE_GET_PARM=0x76或者MINOR_REMOTE_CFG_PARM=0x77时，dwParaType:参数类型有效，其含义如下：
		public const int ParaVideoout = 1;
		public const int ParaImage = 2;
		public const int ParaEncode = 4;
		public const int ParaNetwork = 8;
		public const int ParaAlarm = 16;
		public const int ParaException = 32;
		public const int ParaDecoder = 64;/*解码器*/
		public const int ParaRs232 = 128;
		public const int ParaPreview = 256;
		public const int ParaSecurity = 512;
		public const int ParaDatetime = 1024;
		public const int ParaFrametype = 2048;/*帧格式*/
		//vca
		public const int ParaVcaRule = 4096;//行为规则
		/************************DVR日志 End***************************/


		/*******************查找文件和日志函数返回值*************************/
		public const int NetDvrFileSuccess = 1000;//获得文件信息
		public const int NetDvrFileNofind = 1001;//没有文件
		public const int NetDvrIsfinding = 1002;//正在查找文件
		public const int NetDvrNomorefile = 1003;//查找文件时没有更多的文件
		public const int NetDvrFileException = 1004;//查找文件时异常

		/*********************回调函数类型 begin************************/
		public const int CommAlarm = 0x1100;//8000报警信息主动上传，对应NET_DVR_ALARMINFO
		public const int CommAlarmRule = 0x1102;//行为分析报警信息，对应NET_VCA_RULE_ALARM
		public const int CommAlarmPdc = 0x1103;//人流量统计报警上传，对应NET_DVR_PDC_ALRAM_INFO
		public const int CommAlarmAlarmhost = 0x1105;//网络报警主机报警上传，对应NET_DVR_ALARMHOST_ALARMINFO
		public const int CommAlarmFace = 0x1106;//人脸检测识别报警信息，对应NET_DVR_FACEDETECT_ALARM
		public const int CommRuleInfoUpload = 0x1107;  // 事件数据信息上传
		public const int CommAlarmAid = 0x1110;  //交通事件报警信息
		public const int CommAlarmTps = 0x1111;  //交通参数统计报警信息
		public const int CommUploadFacesnapResult = 0x1112;  //人脸识别结果上传
		public const int CommAlarmTfs = 0x1113;  //交通取证报警信息
		public const int CommAlarmTpsV41 = 0x1114;  //交通参数统计报警信息扩展
		public const int CommAlarmAidV41 = 0x1115;  //交通事件报警信息扩展
		public const int CommAlarmVqdEx =  0x1116;	 //视频质量诊断报警
		public const int CommSensorValueUpload = 0x1120;  //模拟量数据实时上传
		public const int CommSensorAlarm  = 0x1121;  //模拟量报警上传
		public const int CommSwitchAlarm   = 0x1122;	 //开关量报警
		public const int CommAlarmhostException   =  0x1123; //报警主机故障报警
		public const int CommAlarmhostOperateeventAlarm  = 0x1124;  //操作事件报警上传
		public const int CommAlarmhostSafetycabinstate = 0x1125;	 //防护舱状态
		public const int CommAlarmhostAlarmoutstatus  = 0x1126;	 //报警输出口/警号状态
		public const int CommAlarmhostCidAlarm 	 = 0x1127;	 //报告报警上传
		public const int CommAlarmhostExternalDeviceAlarm = 0x1128;	 //报警主机外接设备报警上传
		public const int CommAlarmhostDataUpload    = 0x1129;	 //报警数据上传
		public const int CommAlarmAudioexception	 =  0x1150;	 //声音报警信息
		public const int CommAlarmDefocus    =      0x1151;	 //虚焦报警信息
		public const int CommAlarmButtonDownException =  0x1152;	 //按钮按下报警信息
		public const int CommAlarmAlarmgps   =    0x1202; //GPS报警信息上传
		public const int CommTradeinfo      =  0x1500;  //ATMDVR主动上传交易信息
		public const int CommUploadPlateResult  =   0x2800;	 //上传车牌信息
		public const int CommItcStatusDetectResult  = 0x2810;  //实时状态检测结果上传(智能高清IPC)
		public const int CommIpcAuxalarmResult  = 0x2820;  //PIR报警、无线报警、呼救报警上传
		public const int CommUploadPictureinfo    = 0x2900;	 //上传图片信息
		public const int CommSnapMatchAlarm   = 0x2902;  //黑名单比对结果上传
		public const int CommItsPlateResult   =  0x3050;  //终端图片上传
		public const int CommItsTrafficCollect  = 0x3051;  //终端统计数据上传
		public const int CommItsGateVehicle = 0x3052;  //出入口车辆抓拍数据上传
		public const int CommItsGateFace  = 0x3053 ; //出入口人脸抓拍数据上传
		public const int CommItsGateCostitem = 0x3054;  //出入口过车收费明细 2013-11-19
		public const int CommItsGateHandover = 0x3055 ; //出入口交接班数据 2013-11-19
		public const int CommItsParkVehicle  = 0x3056;  //停车场数据上传
		public const int CommItsBlacklistAlarm  = 0x3057;  //黑名单报警上传
		public const int CommAlarmV30	 =  0x4000;	 //9000报警信息主动上传
		public const int CommIpccfg	 =  0x4001;	 //9000设备IPC接入配置改变报警信息主动上传
		public const int CommIpccfgV31 = 0x4002;	 //9000设备IPC接入配置改变报警信息主动上传扩展 9000_1.1
		public const int CommIpccfgV40 =  0x4003; // IVMS 2000 编码服务器 NVR IPC接入配置改变时报警信息上传
		public const int CommAlarmDevice = 0x4004;  //设备报警内容，由于通道值大于256而扩展
		public const int CommAlarmCvr	 =  0x4005;  //CVR 2.0.X外部报警类型
		public const int CommAlarmHotSpare = 0x4006;  //热备异常报警（N+1模式异常报警）
		public const int CommAlarmV40 = 0x4007;	//移动侦测，视频丢失，遮挡，IO信号量等报警信息主动上传，报警数据为可变长

		public const int CommItsRoadException = 0x4500;	 //路口设备异常报警
		public const int CommItsExternalControlAlarm = 0x4520;  //外控报警
		public const int CommScreenAlarm    =  0x5000;  //多屏控制器报警类型
		public const int CommDvcsStateAlarm = 0x5001;  //分布式大屏控制器报警上传
		public const int CommAlarmVqd		 = 0x6000;  //VQD主动报警上传 
		public const int CommPushUpdateRecordInfo  = 0x6001;  //推模式录像信息上传
		public const int CommDiagnosisUpload = 0x5100;  //诊断服务器VQD报警上传

		/*************操作异常类型(消息方式, 回调方式(保留))****************/
		public const int ExceptionExchange = 32768;//用户交互时异常
		public const int ExceptionAudioexchange = 32769;//语音对讲异常
		public const int ExceptionAlarm = 32770;//报警异常
		public const int ExceptionPreview = 32771;//网络预览异常
		public const int ExceptionSerial = 32772;//透明通道异常
		public const int ExceptionReconnect = 32773;//预览时重连
		public const int ExceptionAlarmreconnect = 32774;//报警时重连
		public const int ExceptionSerialreconnect = 32775;//透明通道重连
		public const int ExceptionPlayback = 32784;//回放异常
		public const int ExceptionDiskfmt = 32785;//硬盘格式化

		/********************预览回调函数*********************/
		public const int NetDvrSyshead = 1;//系统头数据
		public const int NetDvrStreamdata = 2;//视频流数据（包括复合流和音视频分开的视频流数据）
		public const int NetDvrAudiostreamdata = 3;//音频流数据
		public const int NetDvrStdVideodata = 4;//标准视频流数据
		public const int NetDvrStdAudiodata = 5;//标准音频流数据

		//回调预览中的状态和消息
		public const int NetDvrRealplayexception = 111;//预览异常
		public const int NetDvrRealplaynetclose = 112;//预览时连接断开
		public const int NetDvrRealplay5Snodata = 113;//预览5s没有收到数据
		public const int NetDvrRealplayreconnect = 114;//预览重连

		/********************回放回调函数*********************/
		public const int NetDvrPlaybackover = 101;//回放数据播放完毕
		public const int NetDvrPlaybackexception = 102;//回放异常
		public const int NetDvrPlaybacknetclose = 103;//回放时候连接断开
		public const int NetDvrPlayback5Snodata = 104;//回放5s没有收到数据

		/*********************回调函数类型 end************************/
		//设备型号(DVR类型)
		/* 设备类型 */
		public const int Dvr = 1;/*对尚未定义的dvr类型返回NETRET_DVR*/
		public const int Atmdvr = 2;/*atm dvr*/
		public const int Dvs = 3;/*Dvs*/
		public const int Dec = 4;/* 6001D */
		public const int EncDec = 5;/* 6001F */
		public const int DvrHc = 6;/*8000HC*/
		public const int DvrHt = 7;/*8000HT*/
		public const int DvrHf = 8;/*8000HF*/
		public const int DvrHs = 9;/* 8000HS DVR(no audio) */
		public const int DvrHts = 10; /* 8016HTS DVR(no audio) */
		public const int DvrHb = 11; /* HB DVR(SATA HD) */
		public const int DvrHcs = 12; /* 8000HCS DVR */
		public const int DvsA = 13; /* 带ATA硬盘的DVS */
		public const int DvrHcS = 14; /* 8000HC-S */
		public const int DvrHtS = 15;/* 8000HT-S */
		public const int DvrHfS = 16;/* 8000HF-S */
		public const int DvrHsS = 17; /* 8000HS-S */
		public const int AtmdvrS = 18;/* ATM-S */
		public const int LowcostDvr = 19;/*7000H系列*/
		public const int DecMat = 20; /*多路解码器*/
		public const int DvrMobile = 21;/* mobile DVR */
		public const int DvrHdS = 22;   /* 8000HD-S */
		public const int DvrHdSl = 23;/* 8000HD-SL */
		public const int DvrHcSl = 24;/* 8000HC-SL */
		public const int DvrHsSt = 25;/* 8000HS_ST */
		public const int DvsHw = 26; /* 6000HW */
		public const int Ds630Xd = 27; /* 多路解码器 */
		public const int Ipcam = 30;/*IP 摄像机*/
		public const int MegaIpcam = 31;/*X52MF系列,752MF,852MF*/
		public const int IpcamX62Mf = 32;/*X62MF系列可接入9000设备,762MF,862MF*/
		public const int Ipdome = 40; /*IP 标清球机*/
		public const int IpdomeMega200 = 41;/*IP 200万高清球机*/
		public const int IpdomeMega130 = 42;/*IP 130万高清球机*/
		public const int Ipmod = 50;/*IP 模块*/
		public const int Ds71XxH = 71;/* DS71XXH_S */
		public const int Ds72XxHs = 72;/* DS72XXH_S */
		public const int Ds73XxHs = 73;/* DS73XXH_S */
		public const int Ds76XxHs = 76;/* Ds76XxHs */
		public const int Ds81XxHsS = 81;/* Ds81XxHsS */
		public const int Ds81XxHlS = 82;/* Ds81XxHlS */
		public const int Ds81XxHcS = 83;/* Ds81XxHcS */
		public const int Ds81XxHdS = 84;/* Ds81XxHdS */
		public const int Ds81XxHeS = 85;/* Ds81XxHeS */
		public const int Ds81XxHfS = 86;/* Ds81XxHfS */
		public const int Ds81XxAhS = 87;/* Ds81XxAhS */
		public const int Ds81XxAhfS = 88;/* Ds81XxAhfS */
		public const int Ds90XxHfS = 90;  /*Ds90XxHfS*/
		public const int Ds91XxHfS = 91;  /*Ds91XxHfS*/
		public const int Ds91XxHdS = 92; /*91XXHD-S(MD)*/
		/**********************设备类型 end***********************/

		/*************************************************
		参数配置结构、参数(其中_V30为9000新增)
		**************************************************/
		//校时结构参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTime
		{
			public uint dwYear;
			public uint dwMonth;
			public uint dwDay;
			public uint dwHour;
			public uint dwMinute;
			public uint dwSecond;
		}

		//时间参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimeV30
		{
			public ushort wYear;
			public byte byMonth;
			public byte byDay;
			public byte byHour;
			public byte byMinute;
			public byte bySecond;
			public byte byRes;
			public ushort wMilliSec;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimeEx
		{
			public ushort wYear;
			public byte byMonth;
			public byte byDay;
			public byte byHour;
			public byte byMinute;
			public byte bySecond;
			public byte byRes;
		}

		//时间段(子结构)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSchedtime
		{
			public byte byStartHour;//开始时间
			public byte byStartMin;//开始时间
			public byte byStopHour;//结束时间
			public byte byStopMin;//结束时间
		}

		/*设备报警和异常处理方式*/
		public const int Noaction = 0x0;/*无响应*/
		public const int Warnonmonitor = 0x1;/*监视器上警告*/
		public const int Warnonaudioout = 0x2;/*声音警告*/
		public const int Uptocenter = 0x4;/*上传中心*/
		public const int Triggeralarmout = 0x8;/*触发报警输出*/
		public const int Triggercatpic = 0x10;/*触发抓图并上传E-mail*/
		public const int SendPicFtp = 0x200;  /*抓图并上传ftp*/        

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStructhead
		{
			public ushort wLength;  //结构长度
			public byte byVersion;	/*高低4位分别代表高低版本，后续根据版本和长度进行扩展，不同的版本的长度进行限制*/
			public byte byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexceptionV41
		{
			public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/ 
			public uint dwMaxRelAlarmOutChanNum; //触发的报警输出通道数（只读）最大支持数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //触发报警通道      
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexceptionV40
		{
			public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/ 
			public uint dwMaxRelAlarmOutChanNum; //触发的报警输出通道数（只读）最大支持数
			public uint dwRelAlarmOutChanNum; //触发的报警输出通道数 实际支持数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //触发报警通道      
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //保留
		}

		//报警和异常处理结构(子结构)(多处使用)(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexceptionV30
		{
			public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelAlarmOut;//报警触发的输出通道,报警触发的输出,为1表示触发该输出
		}

		//报警和异常处理结构(子结构)(多处使用)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexception
		{
			public uint dwHandleType;/*处理方式,处理方式的"或"结果*/
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: Jpeg抓图并上传EMail*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmout, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelAlarmOut;//报警触发的输出通道,报警触发的输出,为1表示触发该输出
		}

		//DVR设备参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevicecfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRName;//DVR名称
			public uint dwDVRID;//DVR ID,用于遥控器 //V1.4(0-99), V1.5(0-255)
			public uint dwRecycleRecord;//是否循环录像,0:不是; 1:是
			//以下不可更改
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//序列号
			public uint dwSoftwareVersion;//软件版本号,高16位是主版本,低16位是次版本
			public uint dwSoftwareBuildDate;//软件生成日期,0xYYYYMMDD
			public uint dwDSPSoftwareVersion;//DSP软件版本,高16位是主版本,低16位是次版本
			public uint dwDSPSoftwareBuildDate;// DSP软件生成日期,0xYYYYMMDD
			public uint dwPanelVersion;// 前面板版本,高16位是主版本,低16位是次版本
			public uint dwHardwareVersion;// 硬件版本,高16位是主版本,低16位是次版本
			public byte byAlarmInPortNum;//DVR报警输入个数
			public byte byAlarmOutPortNum;//DVR报警输出个数
			public byte byRS232Num;//DVR 232串口个数
			public byte byRS485Num;//DVR 485串口个数
			public byte byNetworkPortNum;//网络口个数
			public byte byDiskCtrlNum;//DVR 硬盘控制器个数
			public byte byDiskNum;//DVR 硬盘个数
			public byte byDVRType;//DVR类型, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;//DVR 通道个数
			public byte byStartChan;//起始通道号,例如DVS-1,DVR - 1
			public byte byDecordChans;//DVR 解码路数
			public byte byVGANum;//VGA口的个数
			public byte byUSBNum;//USB口的个数
			public byte byAuxoutNum;//辅口的个数
			public byte byAudioNum;//语音口的个数
			public byte byIPChanNum;//最大数字通道数
		}

		/*IP地址*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpaddr
		{

			/// char[16]
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpV4;

			/// BYTE[128]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[128];
			}
		}

		/*网络数据结构(子结构)(9000扩展)*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEthernetV30
		{
			public NetDvrIpaddr struDVRIP;//DVR IP地址
			public NetDvrIpaddr struDVRIPMask;//DVR IP地址掩码
			public uint dwNetInterface;//网络接口：1-10MBase-T；2-10MBase-T全双工；3-100MBase-TX；4-100M全双工；5-10M/100M/1000M自适应；6-1000M全双工
			public ushort wDVRPort;//端口号
			public ushort wMTU;//增加MTU设置，默认1500。
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;// 物理地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*网络数据结构(子结构)*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrEthernet
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;//DVR IP地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvripMask;//DVR IP地址掩码
			public uint dwNetInterface;//网络接口 1-10MBase-T 2-10MBase-T全双工 3-100MBase-TX 4-100M全双工 5-10M/100M自适应
			public ushort wDVRPort;//端口号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;//服务器的物理地址
		}

		//pppoe结构
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPppoecfg
		{
			public uint dwPPPOE;//0-不启用,1-启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPPPoEUser;//PPPoE用户名
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sPPPoEPassword;// PPPoE密码
			public NetDvrIpaddr struPPPoEIP;//PPPoE IP地址
		}

		//网络配置结构(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNetcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEthernet, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEthernetV30[] struEtherNet;//以太网口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struRes1;/*保留*/
			public NetDvrIpaddr struAlarmHostIpAddr;/* 报警主机IP地址 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public ushort wAlarmHostIpPort;
			public byte byUseDhcp;
			public byte byRes3;
			public NetDvrIpaddr struDnsServer1IpAddr;/* 域名服务器1的IP地址 */
			public NetDvrIpaddr struDnsServer2IpAddr;/* 域名服务器2的IP地址 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byIpResolver;
			public ushort wIpResolverPort;
			public ushort wHttpPortNo;
			public NetDvrIpaddr struMulticastIpAddr;/* 多播组地址 */
			public NetDvrIpaddr struGatewayIpAddr;/* 网关地址 */
			public NetDvrPppoecfg struPPPoE;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//单个网卡配置信息结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEthernetMulti
		{
			public NetDvrIpaddr struDVRIP;
			public NetDvrIpaddr struDVRIPMask;
			public uint dwNetInterface;
			public byte byCardType;  //网卡类型，0-普通网卡，1-内网网卡，2-外网网卡
			public byte byRes1;
			public ushort wMTU;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public byte byUseDhcp;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
			public NetDvrIpaddr struGatewayIpAddr;
			public NetDvrIpaddr struDnsServer1IpAddr;
			public NetDvrIpaddr struDnsServer2IpAddr;
		}

		//多网卡网络配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNetcfgMulti
		{
			public uint dwSize;
			public byte byDefaultRoute;
			public byte byNetworkCardNum;
			public byte byWorkMode;   //0-普通多网卡模式，1-内外网隔离模式
			public byte byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNetworkCard, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEthernetMulti[] struEtherNet;//以太网口
			public NetDvrIpaddr struManageHost1IpAddr;
			public NetDvrIpaddr struManageHost2IpAddr;
			public NetDvrIpaddr struAlarmHostIpAddr;
			public ushort wManageHost1Port;
			public ushort wManageHost2Port;
			public ushort wAlarmHostIpPort;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byIpResolver;
			public ushort wIpResolverPort;
			public ushort wDvrPort;
			public ushort wHttpPortNo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrIpaddr struMulticastIpAddr;/* 多播组地址 */
			public NetDvrPppoecfg struPPPoE;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		//网络配置结构
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrNetcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEthernet, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEthernet[] struEtherNet;/* 以太网口 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sManageHostIP;//远程管理主机地址
			public ushort wManageHostPort;//远程管理主机端口号
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIPServerIP;//IPServer服务器地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sMultiCastIP;//多播组地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sGatewayIP;//网关地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sNFSIP;//NFS主机IP地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PathnameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNFSDirectory;//NFS目录
			public uint dwPPPOE;//0-不启用,1-启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPPPoEUser;//PPPoE用户名
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sPPPoEPassword;// PPPoE密码
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sPPPoEIP;//PPPoE IP地址(只读)
			public ushort wHttpPort;//HTTP端口号
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrSipCfg
		{
			public uint dwSize;
			public byte byEnableAutoLogin;    //使能自动注册，0-不使能，1-使能
			public byte byLoginStatus;  //注册状态，0-未注册，1-已注册，此参数只能获取
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr stuServerIP;  //SIP服务器IP
			public ushort wServerPort;    //SIP服务器端口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName;  //注册用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassWord; //注册密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNumberLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalNo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDispalyName; //设备显示名称
			public ushort wLocalPort;     //本地端口
			public byte byLoginCycle;   //注册周期，1-99分钟
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//IP可视对讲分机配置
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpViewDevcfg
		{
			public uint dwSize;
			public byte byDefaultRing; //默认铃音，范围1-6
			public byte byRingVolume;  //铃音音量，范围0-9
			public byte byInputVolume; //输入音量值，范围0-6
			public byte byOutputVolume; //输出音量值，范围0-9	
			public ushort wRtpPort;  //Rtp端口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwPreviewDelayTime; //预览延时配置，0-30秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		
		//Ip可视对讲音频相关参数配置
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpViewAudioCfg
		{
			public uint dwSize;	
			public byte byAudioEncPri1; //音频编码优先级1，0-OggVorbis，1-G711_U，2-G711_A， 5-MPEG2,6-G726，7-AAC
			public byte byAudioEncPri2; //音频编码优先级2，当sip服务器不支持音频编码1时会使用音频编码2，0-OggVorbis，1-G711_U，2-G711_A， 5-MPEG2,6-G726，7-AAC
			public ushort wAudioPacketLen1; //音频编码1数据包长度
			public ushort wAudioPacketLen2; //音频编码2数据包长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		//IP分机呼叫对讲参数配置结构体
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpViewCallCfg
		{
			public uint dwSize ;
			public byte byEnableAutoResponse; //使能自动应答,0-不使能，1-使能
			public byte byAudoResponseTime; //自动应答时间，0-30秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byEnableAlarmNumber1; //启动报警号码1，0-不启动，1-启动
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNumberLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmNumber1; //呼叫号码1
			public byte byEnableAlarmNumber2; //启动报警号码2，0-不启动，1-启动
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNumberLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmNumber2; //呼叫号码2，呼叫号码1失败会尝试呼叫号码2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes4;
		}
		
		//通道图象结构
		//移动侦测(子结构)(按组方式扩展)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrRecordchan
		{    
			public uint dwMaxRecordChanNum;   //设备支持的最大关联录像通道数-只读
			public uint dwCurRecordChanNum;   //当前实际已配置的关联录像通道数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint dwRelRecordChan;	 /* 实际触发录像通道，按值表示,采用紧凑型排列，从下标0 - MaxChannumV30-1有效，如果中间遇到0xffffffff,则后续无效*/  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //保留
		}             

		//通道图象结构
		//移动侦测(子结构)(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMotionV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96*64, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope;/*侦测区域,0-96位,表示64行,共有96*64个小宏块,为1表示是移动侦测区域,0-表示不是*/
			public byte byMotionSensitive;/*移动侦测灵敏度, 0 - 5,越高越灵敏,oxff关闭*/
			public byte byEnableHandleMotion;/* 是否处理移动侦测 0－否 1－是*/
			public byte byEnableDisplay;/* 启用移动侦测高亮显示：0- 否，1- 是 */
			public byte reservedData;
			public NetDvrHandleexceptionV30 struMotionHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;/*布防时间*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;/* 报警触发的录象通道*/
		}

		//移动侦测(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotion
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope;/*侦测区域,共有22*18个小宏块,为1表示改宏块是移动侦测区域,0-表示不是*/
			public byte byMotionSensitive;/*移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭*/
			public byte byEnableHandleMotion;/* 是否处理移动侦测 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
			public string reservedData;
			public NetDvrHandleexception strMotionHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
		}

		//遮挡报警(子结构)(9000扩展)  区域大小704*576
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHidealarmV30
		{
			public uint dwEnableHideAlarm;/* 是否启动遮挡报警 ,0-否,1-低灵敏度 2-中灵敏度 3-高灵敏度*/
			public ushort wHideAlarmAreaTopLeftX;/* 遮挡区域的x坐标 */
			public ushort wHideAlarmAreaTopLeftY;/* 遮挡区域的y坐标 */
			public ushort wHideAlarmAreaWidth;/* 遮挡区域的宽 */
			public ushort wHideAlarmAreaHeight;/*遮挡区域的高*/
			public NetDvrHandleexceptionV30 strHideAlarmHandleType;	/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
		}

		//遮挡报警(子结构)  区域大小704*576
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHidealarm
		{
			public uint dwEnableHideAlarm;/* 是否启动遮挡报警 ,0-否,1-低灵敏度 2-中灵敏度 3-高灵敏度*/
			public ushort wHideAlarmAreaTopLeftX;/* 遮挡区域的x坐标 */
			public ushort wHideAlarmAreaTopLeftY;/* 遮挡区域的y坐标 */
			public ushort wHideAlarmAreaWidth;/* 遮挡区域的宽 */
			public ushort wHideAlarmAreaHeight;/*遮挡区域的高*/
			public NetDvrHandleexception strHideAlarmHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
		}

		//信号丢失报警(子结构)(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVilostV30
		{
			public byte byEnableHandleVILost;/* 是否处理信号丢失报警 */
			public NetDvrHandleexceptionV30 strVILostHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
		}

		//信号丢失报警(子结构)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVilost
		{
			public byte byEnableHandleVILost;/* 是否处理信号丢失报警 */
			public NetDvrHandleexception strVILostHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
		}

		//遮挡区域(子结构)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShelter
		{
			public ushort wHideAreaTopLeftX;/* 遮挡区域的x坐标 */
			public ushort wHideAreaTopLeftY;/* 遮挡区域的y坐标 */
			public ushort wHideAreaWidth;/* 遮挡区域的宽 */
			public ushort wHideAreaHeight;/*遮挡区域的高*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrColor
		{
			public byte byBrightness;/*亮度,0-255*/
			public byte byContrast;/*对比度,0-255*/
			public byte bySaturation;/*饱和度,0-255*/
			public byte byHue;/*色调,0-255*/
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrRgbColor
		{
			public byte byRed;	 //RGB颜色三分量中的红色
			public byte byGreen; //RGB颜色三分量中的绿色
			public byte byBlue;	//RGB颜色三分量中的蓝色
			public byte byRes;	//保留
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDaytime
		{
			public byte byHour;//0~24
			public byte byMinute;//0~60
			public byte bySecond;//0~60
			public byte byRes;
			public ushort wMilliSecond; //0~1000
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrScheduleDaytime
		{
			public NetDvrDaytime struStartTime; //开始时间
			public NetDvrDaytime struStopTime; //结束时间
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDnmode
		{
			public byte byObjectSize;//占比参数(0~100)
			public byte byMotionSensitive; /*移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionMultiAreaparam
		{
			public byte byAreaNo;//区域编号(IPC- 1~8)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetVcaRect struRect;//单个区域的坐标信息(矩形) size = 16;
			public NetDvrDnmode  struDayNightDisable;//关闭模式
			public NetDvrDnmode  struDayModeParam;//白天模式
			public NetDvrDnmode  struNightModeParam;//夜晚模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionMultiArea
		{
			public byte byDayNightCtrl;//日夜控制 0~关闭,1~自动切换,2~定时切换(默认关闭)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrScheduleDaytime struScheduleTime;//切换时间  16
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxMultiAreaNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMotionMultiAreaparam[] struMotionMultiAreaParam;//最大支持24个区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionSingleArea
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64*96, ArraySubType = UnmanagedType.I1)]
			public byte[]byMotionScope;		/*侦测区域,0-96位,表示64行,共有96*64个小宏块,目前有效的是22*18,为1表示是移动侦测区域,0-表示不是*/
			public byte byMotionSensitive;			/*移动侦测灵敏度, 0 - 5,越高越灵敏,0xff关闭*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}


		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionModeParam
		{
			public NetDvrMotionSingleArea  struMotionSingleArea; //普通模式下的单区域设
			public NetDvrMotionMultiArea struMotionMultiArea; //专家模式下的多区域设置	
		}

		//移动侦测
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionV40
		{	
			public NetDvrMotionModeParam struMotionMode; //(5.1.0新增)
			public byte byEnableHandleMotion;		/* 是否处理移动侦测 0－否 1－是*/ 
			public byte byEnableDisplay;	/*启用移动侦测高亮显示，0-否，1-是*/
			public byte byConfigurationMode; //0~普通,1~专家(5.1.0新增)
			public byte byRes1; //保留字节
			/* 异常处理方式 */
			public uint dwHandleType;        //异常处理,异常处理方式的"或"结果  
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //实际触发的报警输出号，按值表示,采用紧凑型排列，从下标0 - dwRelAlarmOut -1有效，如果中间遇到0xffffffff,则后续无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays*MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime; /*布防时间*/
			/*触发的录像通道*/
			public uint dwMaxRecordChanNum;   //设备支持的最大关联录像通道数-只读
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelRecordChan;	 /* 实际触发录像通道，按值表示,采用紧凑型排列，从下标0 - dwRelRecordChan -1有效，如果中间遇到0xffffffff,则后续无效*/  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留字节
		}

		//遮挡报警
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrHidealarmV40
		{
			public uint dwEnableHideAlarm;  /* 是否启动遮挡报警，0-否，1-低灵敏度，2-中灵敏度，3-高灵敏度*/
			public ushort wHideAlarmAreaTopLeftX;			/* 遮挡区域的x坐标 */
			public ushort wHideAlarmAreaTopLeftY;			/* 遮挡区域的y坐标 */
			public ushort wHideAlarmAreaWidth;				/* 遮挡区域的宽 */
			public ushort wHideAlarmAreaHeight;				/*遮挡区域的高*/ 
			/* 信号丢失触发报警输出 */	
			public uint dwHandleType;        //异常处理,异常处理方式的"或"结果  
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; /*触发报警输出号，按值表示,采用紧凑型排列，从下标0 - dwRelAlarmOut -1有效，如果中间遇到0xffffffff,则后续无效*/  	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays*MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime; /*布防时间*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		} 

		//信号丢失报警
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrVilostV40
		{
			public uint dwEnableVILostAlarm;				/* 是否启动信号丢失报警 ,0-否,1-是*/	 
			/* 信号丢失触发报警输出 */	
			public uint dwHandleType;        //异常处理,异常处理方式的"或"结果     
			/*0x00: 无响应*/    
			/*0x01: 监视器上警告*/    
			/*0x02: 声音警告*/    
			/*0x04: 上传中心*/    
			/*0x08: 触发报警输出*/    
			/*0x10: 触发JPRG抓图并上传Email*/    
			/*0x20: 无线声光报警器联动*/    
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/    
			/*0x200: 抓图并上传FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; /*触发报警输出号，按值表示,采用紧凑型排列，从下标0 - dwRelAlarmOut -1有效，如果中间遇到0xffffffff,则后续无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays*MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime; /*布防时间*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrVicolor
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrColor[]	  struColor;/*图象参数(第一个有效，其他三个保留)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]  struHandleTime;/*处理时间段(保留)*/
		}

		//通道图象结构(V40扩展)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPiccfgV40
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName; 
			public uint dwVideoFormat;	/* 只读 视频制式 1-NTSC 2-PAL  */
			public NetDvrVicolor struViColor;//	图像参数按时间段设置
			//显示通道名
			public uint dwShowChanName; // 预览的图象上是否显示通道名称,0-不显示,1-显示
			public ushort wShowNameTopLeftX;				/* 通道名称显示位置的x坐标 */
			public ushort wShowNameTopLeftY;				/* 通道名称显示位置的y坐标 */
			//隐私遮挡
			public uint dwEnableHide;		/* 是否启动遮挡 ,0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxShelternum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShelter[] struShelter;
			//OSD
			public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示
			public ushort wOSDTopLeftX;				/* OSD的x坐标 */
			public ushort wOSDTopLeftY;				/* OSD的y坐标 */
			public byte byOSDType;					/* OSD类型(主要是年月日格式) */
			/* 0: XXXX-XX-XX 年月日 */
			/* 1: XX-XX-XXXX 月日年 */
			/* 2: XXXX年XX月XX日 */
			/* 3: XX月XX日XXXX年 */
			/* 4: XX-XX-XXXX 日月年*/
			/* 5: XX日XX月XXXX年 */
			/*6: xx/xx/xxxx(月/日/年) */
			/*7: xxxx/xx/xx(年/月/日) */
			/*8: xx/xx/xxxx(日/月/年)*/
			public byte byDispWeek;				/* 是否显示星期 */
			public byte byOSDAttrib;				/* OSD属性:透明，闪烁 */
			/* 0: 不显示OSD */
			/* 1: 透明，闪烁 */
			/* 2: 透明，不闪烁 */
			/* 3: 不透明，闪烁 */
			/* 4: 不透明，不闪烁 */	
			public byte byHourOSDType;				/* OSD小时制:0-24小时制,1-12小时制 */
			public byte byFontSize;      //16*16(中)/8*16(英)，1-32*32(中)/16*32(英)，2-64*64(中)/32*64(英) FOR 91系列HD-SDI高清DVR
			public byte byOSDColorType;	 //0-默认（黑白）；1-自定义
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrVilostV40 struVILost;  //视频信号丢失报警（支持组）
			public NetDvrVilostV40 struAULost;  /*音频信号丢失报警（支持组）*/
			public NetDvrMotionV40 struMotion;  //移动侦测报警（支持组）
			public NetDvrHidealarmV40 struHideAlarm;  //遮挡报警（支持组）
			public NetDvrRgbColor struOsdColor;//OSD颜色
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//通道图象结构(9000扩展)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPiccfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;
			public uint dwVideoFormat;/* 只读 视频制式 1-NTSC 2-PAL*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byReservedData;/*保留*/
			//显示通道名
			public uint dwShowChanName;// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
			public ushort wShowNameTopLeftX;/* 通道名称显示位置的x坐标 */
			public ushort wShowNameTopLeftY;/* 通道名称显示位置的y坐标 */
			//视频信号丢失报警
			public NetDvrVilostV30 struVILost;
			public NetDvrVilostV30 struRes;/*保留*/
			//移动侦测
			public NetDvrMotionV30 struMotion;
			//遮挡报警
			public NetDvrHidealarmV30 struHideAlarm;
			//遮挡  区域大小704*576
			public uint dwEnableHide;/* 是否启动遮挡 ,0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxShelternum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShelter[] struShelter;
			//OSD
			public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
			public ushort wOSDTopLeftX;/* OSD的x坐标 */
			public ushort wOSDTopLeftY;/* OSD的y坐标 */
			public byte byOSDType;/* OSD类型(主要是年月日格式) */
			/* 0: XXXX-XX-XX 年月日 */
			/* 1: XX-XX-XXXX 月日年 */
			/* 2: XXXX年XX月XX日 */
			/* 3: XX月XX日XXXX年 */
			/* 4: XX-XX-XXXX 日月年*/
			/* 5: XX日XX月XXXX年 */
			public byte byDispWeek;/* 是否显示星期 */
			public byte byOSDAttrib;/* OSD属性:透明，闪烁 */
			/* 0: 不显示OSD */
			/* 1: 透明,闪烁 */
			/* 2: 透明,不闪烁 */
			/* 3: 闪烁,不透明 */
			/* 4: 不透明,不闪烁 */
			public byte byHourOSDType;/* OSD小时制:0-24小时制,1-12小时制 */
			public byte byFontSize;//字体大小，16*16(中)/8*16(英)，1-32*32(中)/16*32(英)，2-64*64(中)/32*64(英)  3-48*48(中)/24*48(英) 0xff-自适应(adaptive)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//通道图象结构SDK_V14扩展
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPiccfgEx
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;
			public uint dwVideoFormat;/* 只读 视频制式 1-NTSC 2-PAL*/
			public byte byBrightness;/*亮度,0-255*/
			public byte byContrast;/*对比度,0-255*/
			public byte bySaturation;/*饱和度,0-255 */
			public byte byHue;/*色调,0-255*/
			//显示通道名
			public uint dwShowChanName;// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
			public ushort wShowNameTopLeftX;/* 通道名称显示位置的x坐标 */
			public ushort wShowNameTopLeftY;/* 通道名称显示位置的y坐标 */
			//信号丢失报警
			public NetDvrVilost struVILost;
			//移动侦测
			public NetDvrMotion struMotion;
			//遮挡报警
			public NetDvrHidealarm struHideAlarm;
			//遮挡  区域大小704*576
			public uint dwEnableHide;/* 是否启动遮挡 ,0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxShelternum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShelter[] struShelter;
			//OSD
			public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
			public ushort wOSDTopLeftX;/* OSD的x坐标 */
			public ushort wOSDTopLeftY;/* OSD的y坐标 */
			public byte byOSDType;/* OSD类型(主要是年月日格式) */
			/* 0: XXXX-XX-XX 年月日 */
			/* 1: XX-XX-XXXX 月日年 */
			/* 2: XXXX年XX月XX日 */
			/* 3: XX月XX日XXXX年 */
			/* 4: XX-XX-XXXX 日月年*/
			/* 5: XX日XX月XXXX年 */
			public byte byDispWeek;/* 是否显示星期 */
			public byte byOSDAttrib;/* OSD属性:透明，闪烁 */
			/* 0: 不显示OSD */
			/* 1: 透明,闪烁 */
			/* 2: 透明,不闪烁 */
			/* 3: 闪烁,不透明 */
			/* 4: 不透明,不闪烁 */
			public byte byHourOsdType;/* OSD小时制:0-24小时制,1-12小时制 */
		}

		//通道图象结构(SDK_V13及之前版本)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPiccfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;
			public uint dwVideoFormat;/* 只读 视频制式 1-NTSC 2-PAL*/
			public byte byBrightness;/*亮度,0-255*/
			public byte byContrast;/*对比度,0-255*/
			public byte bySaturation;/*饱和度,0-255 */
			public byte byHue;/*色调,0-255*/
			//显示通道名
			public uint dwShowChanName;// 预览的图象上是否显示通道名称,0-不显示,1-显示 区域大小704*576
			public ushort wShowNameTopLeftX;/* 通道名称显示位置的x坐标 */
			public ushort wShowNameTopLeftY;/* 通道名称显示位置的y坐标 */
			//信号丢失报警
			public NetDvrVilost struVILost;
			//移动侦测
			public NetDvrMotion struMotion;
			//遮挡报警
			public NetDvrHidealarm struHideAlarm;
			//遮挡  区域大小704*576
			public uint dwEnableHide;/* 是否启动遮挡 ,0-否,1-是*/
			public ushort wHideAreaTopLeftX;/* 遮挡区域的x坐标 */
			public ushort wHideAreaTopLeftY;/* 遮挡区域的y坐标 */
			public ushort wHideAreaWidth;/* 遮挡区域的宽 */
			public ushort wHideAreaHeight;/*遮挡区域的高*/
			//OSD
			public uint dwShowOsd;// 预览的图象上是否显示OSD,0-不显示,1-显示 区域大小704*576
			public ushort wOSDTopLeftX;/* OSD的x坐标 */
			public ushort wOSDTopLeftY;/* OSD的y坐标 */
			public byte byOSDType;/* OSD类型(主要是年月日格式) */
			/* 0: XXXX-XX-XX 年月日 */
			/* 1: XX-XX-XXXX 月日年 */
			/* 2: XXXX年XX月XX日 */
			/* 3: XX月XX日XXXX年 */
			/* 4: XX-XX-XXXX 日月年*/
			/* 5: XX日XX月XXXX年 */
			public byte byDispWeek;/* 是否显示星期 */
			public byte byOSDAttrib;/* OSD属性:透明，闪烁 */
			/* 0: 不显示OSD */
			/* 1: 透明,闪烁 */
			/* 2: 透明,不闪烁 */
			/* 3: 闪烁,不透明 */
			/* 4: 不透明,不闪烁 */
			public byte reservedData2;
		}

		//码流压缩参数(子结构)(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionInfoV30
		{
			public byte byStreamType;//码流类型 0-视频流, 1-复合流, 表示事件压缩参数时最高位表示是否启用压缩参数
			public byte byResolution;//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）16-VGA（640*480） 17-UXGA（1600*1200） 18-SVGA （800*600）19-HD720p（1280*720）20-XVGA  21-HD900p
			public byte byBitrateType;//码率类型 0:变码率, 1:定码率
			public byte byPicQuality;//图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
			public uint dwVideoBitrate;//视频码率 0-保留 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
			// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
			//最高位(31位)置成1表示是自定义码流, 0-30位表示码流值。
			public uint dwVideoFrameRate;//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0版本中新加14-15; 15-18; 16-22;
			public ushort wIntervalFrameI;//I帧间隔
			//2006-08-11 增加单P帧的配置接口，可以改善实时流延时问题
			public byte byIntervalBPFrame;//0-BBP帧; 1-BP帧; 2-单P帧
			public byte byres1; //保留
			public byte byVideoEncType;//视频编码类型 0 hik264;1标准h264; 2标准mpeg4;
			public byte byAudioEncType; //音频编码类型 0－OggVorbis
			public byte byVideoEncComplexity; //视频编码复杂度，0-低，1-中，2高,0xfe:自动，和源一致
			public byte byEnableSvc; //0 - 不启用SVC功能；1- 启用SVC功能
			public byte byFormatType; //封装类型，1-裸流，2-RTP封装，3-PS封装，4-TS封装，5-私有，6-FLV，7-ASF，8-3GP,9-RTP+PS（国标：GB28181），0xff-无效
			public byte byAudioBitRate; //音频码率0-默认，1-8Kbps, 2- 16Kbps, 3-32Kbps，4-64Kbps，5-128Kbps，6-192Kbps；(IPC5.1.0默认4-64Kbps)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;//这里保留音频的压缩参数
		}

		//通道压缩参数(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgV30
		{
			public uint dwSize;
			public NetDvrCompressionInfoV30 struNormHighRecordPara;//录像 对应8000的普通
			public NetDvrCompressionInfoV30 struRes;//保留 char reserveData[28];
			public NetDvrCompressionInfoV30 struEventRecordPara;//事件触发压缩参数
			public NetDvrCompressionInfoV30 struNetPara;//网传(子码流)
		}

		//码流压缩参数(子结构)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionInfo
		{
			public byte byStreamType;//码流类型0-视频流,1-复合流,表示压缩参数时最高位表示是否启用压缩参数
			public byte byResolution;//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(车载专用)
			public byte byBitrateType;//码率类型0:变码率，1:定码率
			public byte byPicQuality;//图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
			public uint dwVideoBitrate; //视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
			// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
			//最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K)。
			public uint dwVideoFrameRate;//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
		}

		//通道压缩参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfg
		{
			public uint dwSize;
			public NetDvrCompressionInfo struRecordPara;//录像/事件触发录像
			public NetDvrCompressionInfo struNetPara;//网传/保留
		}

		//码流压缩参数(子结构)(扩展) 增加I帧间隔
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionInfoEx
		{
			public byte byStreamType;//码流类型0-视频流, 1-复合流
			public byte byResolution;//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(车载专用)
			public byte byBitrateType;//码率类型0:变码率，1:定码率
			public byte byPicQuality;//图象质量 0-最好 1-次好 2-较好 3-一般 4-较差 5-差
			public uint dwVideoBitrate;//视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
			// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
			//最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K)。
			public uint dwVideoFrameRate;//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0增加14-15, 15-18, 16-22;
			public ushort wIntervalFrameI;//I帧间隔
			//2006-08-11 增加单P帧的配置接口，可以改善实时流延时问题
			public byte byIntervalBPFrame;//0-BBP帧; 1-BP帧; 2-单P帧
			public byte byRes;
		}

		//通道压缩参数(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgEx
		{
			public uint dwSize;
			public NetDvrCompressionInfoEx struRecordPara;//录像
			public NetDvrCompressionInfoEx struNetPara;//网传
		}

		//时间段录像参数配置(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrRecordsched
		{
			public NetDvrSchedtime struRecordTime;
			public byte byRecordType;//0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警, 5:命令触发, 6: 智能录像
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
			public string reservedData;
		}

		//全天录像参数配置(子结构)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordday
		{
			public ushort wAllDayRecord;/* 是否全天录像 0-否 1-是*/
			public byte byRecordType;/* 录象类型 0:定时录像，1:移动侦测，2:报警录像，3:动测|报警，4:动测&报警 5:命令触发, 6: 智能录像*/
			public byte reservedData;
		}

		//通道录像参数配置(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordV30
		{
			public uint dwSize;
			public uint dwRecord;/*是否录像 0-否 1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordday[] struRecAllDay;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordsched[] struRecordSched;
			public uint dwRecordTime;/* 录象延时长度 0-5秒， 1-20秒， 2-30秒， 3-1分钟， 4-2分钟， 5-5分钟， 6-10分钟*/
			public uint dwPreRecordTime;/* 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录) */
			public uint dwRecorderDuration;/* 录像保存的最长时间 */
			public byte byRedundancyRec;/*是否冗余录像,重要数据双备份：0/1*/
			public byte byAudioRec;/*录像时复合流编码时是否记录音频数据：国外有此法规*/
			public byte byStreamType;  // 0:主码流 1：子码流
			public byte byPassbackRecord;  // 0:不回传录像 1：回传录像
			public ushort wLockDuration;  // 录像锁定时长，单位小时 0表示不锁定，0xffff表示永久锁定，录像段的时长大于锁定的持续时长的录像，将不会锁定
			public byte byRecordBackup;  // 0:录像不存档 1：录像存档
			public byte bySVCLevel;	//SVC抽帧类型：0-不抽，1-抽二分之一 2-抽四分之三
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byReserve;
		}

		//通道录像参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecord
		{
			public uint dwSize;
			public uint dwRecord;/*是否录像 0-否 1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordday[] struRecAllDay;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordsched[] struRecordSched;
			public uint dwRecordTime;/* 录象时间长度 */
			public uint dwPreRecordTime;/* 预录时间 0-不预录 1-5秒 2-10秒 3-15秒 4-20秒 5-25秒 6-30秒 7-0xffffffff(尽可能预录) */
		}

		//云台协议表结构配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzProtocol
		{
			public uint dwType;/*解码器类型值，从1开始连续递增*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe;/*解码器的描述符，和8000中的一致*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PtzProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPtzProtocol[] struPtz;/*最大200中PTZ协议*/
			public uint dwPtzNum;/*有效的ptz协议数目，从0开始(即计算时加1)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		/***************************云台类型(end)******************************/

		//通道解码器(云台)参数配置(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodercfgV30
		{
			public uint dwSize;
			public uint dwBaudRate;//波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
			public byte byDataBit;// 数据有几位 0－5位，1－6位，2－7位，3－8位;
			public byte byStopBit;// 停止位 0－1位，1－2位
			public byte byParity;// 校验 0－无校验，1－奇校验，2－偶校验;
			public byte byFlowcontrol;// 0－无，1－软流控,2-硬流控
			public ushort wDecoderType;//解码器类型, 从0开始，对应ptz协议列表
			public ushort wDecoderAddress;/*解码器地址:0 - 255*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPresetV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetPreset;/* 预置点是否设置,0-没有设置,1-设置*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCruiseV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetCruise;/* 巡航是否设置: 0-没有设置,1-设置 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTrackV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetTrack;/* 轨迹是否设置,0-没有设置,1-设置*/
		}

		//通道解码器(云台)参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodercfg
		{
			public uint dwSize;
			public uint dwBaudRate; //波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
			public byte byDataBit; // 数据有几位 0－5位，1－6位，2－7位，3－8位;
			public byte byStopBit;// 停止位 0－1位，1－2位;
			public byte byParity; // 校验 0－无校验，1－奇校验，2－偶校验;
			public byte byFlowcontrol;// 0－无，1－软流控,2-硬流控
			public ushort wDecoderType;//解码器类型, 0－YouLi，1－LiLin-1016，2－LiLin-820，3－Pelco-p，4－DM DynaColor，5－HD600，6－JC-4116，7－Pelco-d WX，8－Pelco-d PICO
			public ushort wDecoderAddress;/*解码器地址:0 - 255*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPreset, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetPreset;/* 预置点是否设置,0-没有设置,1-设置*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCruise, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetCruise;/* 巡航是否设置: 0-没有设置,1-设置 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTrack, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetTrack;/* 轨迹是否设置,0-没有设置,1-设置*/
		}

		//ppp参数配置(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPppcfgV30
		{
			public NetDvrIpaddr struRemoteIP;//远端IP地址
			public NetDvrIpaddr struLocalIP;//本地IP地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIpMask;//本地IP地址掩码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			public byte byPPPMode;//PPP模式, 0－主动，1－被动
			public byte byRedial;//是否回拨 ：0-否,1-是
			public byte byRedialMode;//回拨模式,0-由拨入者指定,1-预置回拨号码
			public byte byDataEncrypt;//数据加密,0-否,1-是
			public uint dwMTU;//MTU
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PhonenumberLen)]
			public string sTelephoneNumber;//电话号码
		}

		//ppp参数配置(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPppcfg
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteIP;//远端IP地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIp;//本地IP地址
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIpMask;//本地IP地址掩码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			public byte byPPPMode;//PPP模式, 0－主动，1－被动
			public byte byRedial;//是否回拨 ：0-否,1-是
			public byte byRedialMode;//回拨模式,0-由拨入者指定,1-预置回拨号码
			public byte byDataEncrypt;//数据加密,0-否,1-是
			public uint dwMTU;//MTU
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PhonenumberLen)]
			public string sTelephoneNumber;//电话号码
		}

		//RS232串口参数配置(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleRs232
		{
			public uint dwBaudRate;/*波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;*/
			public byte byDataBit;/* 数据有几位 0－5位，1－6位，2－7位，3－8位 */
			public byte byStopBit;/* 停止位 0－1位，1－2位 */
			public byte byParity;/* 校验 0－无校验，1－奇校验，2－偶校验 */
			public byte byFlowcontrol;/* 0－无，1－软流控,2-硬流控 */
			public uint dwWorkMode; /* 工作模式，0－232串口用于PPP拨号，1－232串口用于参数控制，2－透明通道 */
		}

		//RS232串口参数配置(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRs232CfgV30
		{
			public uint dwSize;
			public NetDvrSingleRs232 struRs232;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrPppcfgV30 struPPPConfig;
		}

		//RS232串口参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRs232Cfg
		{
			public uint dwSize;
			public uint dwBaudRate;//波特率(bps)，0－50，1－75，2－110，3－150，4－300，5－600，6－1200，7－2400，8－4800，9－9600，10－19200， 11－38400，12－57600，13－76800，14－115.2k;
			public byte byDataBit;// 数据有几位 0－5位，1－6位，2－7位，3－8位;
			public byte byStopBit;// 停止位 0－1位，1－2位;
			public byte byParity;// 校验 0－无校验，1－奇校验，2－偶校验;
			public byte byFlowcontrol;// 0－无，1－软流控,2-硬流控
			public uint dwWorkMode;// 工作模式，0－窄带传输(232串口用于PPP拨号)，1－控制台(232串口用于参数控制)，2－透明通道
			public NetDvrPppcfg struPPPConfig;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPresetchanInfo
		{
			public uint dwEnablePresetChan;	/*启用预置点的通道*/
			public uint dwPresetPointNo;		/*调用预置点通道对应的预置点序号, 0xfffffff表示不调用预置点。*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruisechanInfo
		{
			public uint dwEnableCruiseChan;	/*启用巡航的通道*/
			public uint dwCruiseNo;		/*巡航通道对应的巡航编号, 0xfffffff表示无效*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtztrackchanInfo
		{
			public uint dwEnablePtzTrackChan;	/*启用云台轨迹的通道*/
			public uint dwPtzTrackNo;		/*云台轨迹通道对应的编号, 0xfffffff表示无效*/
		}

		//报警输入参数配置(256路NVR扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmincfgV40
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;	/* 名称 */
			public byte byAlarmType;	            //报警器类型,0：常开,1：常闭
			public byte byAlarmInHandle;	        /* 是否处理 0-不处理 1-处理*/
			public byte byChannel;                 // 报警输入触发智能识别通道
			public byte byRes1;                    //保留			
			public uint dwHandleType;        //异常处理,异常处理方式的"或"结果   
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //触发的报警输出通道数（只读）最大支持数量
			public uint dwRelAlarmOutChanNum; //触发的报警输出通道数 实际支持数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //触发报警通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			/*触发的录像通道*/
			public uint dwMaxRecordChanNum;   //设备支持的最大关联录像通道数-只读
			public uint dwCurRecordChanNum;    //当前实际已配置的关联录像通道数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelRecordChan;	 /* 实际触发录像通道，按值表示,采用紧凑型排列，从下标0 - dwCurRecordChanNum -1有效，如果中间遇到0xffffffff,则后续无效*/ 
			public uint dwMaxEnablePtzCtrlNun; //最大可启用的云台控制总数(只读)
			public uint dwEnablePresetChanNum;  //当前已启用预置点的数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPresetchanInfo[] struPresetChanInfo; //启用的预置点信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;					/*保留*/
			public uint dwEnableCruiseChanNum;  //当前已启用巡航的通道数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCruisechanInfo[] struCruiseChanInfo; //启用巡航功能通道的信息
			public uint dwEnablePtzTrackChanNum;  //当前已启用巡航的通道数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPtztrackchanInfo[] struPtzTrackInfo; //调用云台轨迹的通道信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//报警输入参数配置(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmincfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;/* 名称 */
			public byte byAlarmType; //报警器类型,0：常开,1：常闭
			public byte byAlarmInHandle; /* 是否处理 0-不处理 1-处理*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrHandleexceptionV30 struAlarmHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePreset;/* 是否调用预置点 0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;/* 调用的云台预置点序号,一个报警输入可以调用多个通道的云台预置点, 0xff表示不调用预置点。*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;/*保留*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnableCruise;/* 是否调用巡航 0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseNo;/* 巡航 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePtzTrack;/* 是否调用轨迹 0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byPTZTrack;/* 调用的云台的轨迹序号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}


		[StructLayout(LayoutKind.Sequential)]
		public struct StructIoAlarm
		{
			public uint	dwAlarmInputNo;		//发生报警的报警输入通道号，一次只有一个
			public uint	dwTrigerAlarmOutNum;	/*触发的报警输出个数，用于后面计算变长数据部分中所有触发的报警输出通道号，四字节表示一个*/
			public uint	dwTrigerRecordChanNum;	/*触发的录像通道个数，用于后面计算变长数据部分中所有触发的录像通道号，四字节表示一个*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct StructAlarmChannel
		{
			public uint	dwAlarmChanNum;	/*发生报警通道数据个数，用于后面计算变长数据部分中所有发生的报警通道号，四字节表示一个*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct StructAlarmHd
		{
			public uint	dwAlarmHardDiskNum;	/*发生报警的硬盘数据长度，用于后面计算变长数据部分中所有发生报警的硬盘号，四节表示一个*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct UnionAlarminfoFixed
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byUnionLen;
			[FieldOffset(0)]
			public StructIoAlarm struIOAlarm;// 报警类型dwAlarmType为0时有效
			[FieldOffset(0)]
			public StructAlarmChannel struAlarmChannel; // dwAlarmType为2，3，6，9，10或13时有效
			[FieldOffset(0)]
			public StructAlarmHd struAlarmHardDisk; // dwAlarmType为1,4,5时有效           
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlramFixedHeader
		{
			public uint dwAlarmType;              /*0-信号量报警,1-硬盘满,2-信号丢失，3－移动侦测，4－硬盘未格式化,5-写硬盘出错,6-遮挡报警，7-制式不匹配, 8-非法访问，9-视频信号异常，10-录像异常，11-智能场景变化，12-阵列异常，13-前端/录像分辨率不匹配*/
			public NetDvrTimeEx struAlarmTime;	//发生报警的时间
			public UnionAlarminfoFixed uStruAlarm;
		}

	   [StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfoV40
	   {
			public NetDvrAlramFixedHeader struAlarmFixedHeader;	//报警固定部分
			public IntPtr pAlarmData;	//报警可变部分内容
	   }

		//报警输入参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmincfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;/* 名称 */
			public byte byAlarmType;//报警器类型,0：常开,1：常闭
			public byte byAlarmInHandle;/* 是否处理 0-不处理 1-处理*/
			public byte byChannel;     // 报警输入触发智能识别通道
			public byte byRes;                     
			public NetDvrHandleexception struAlarmHandleType;/* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePreset;/* 是否调用预置点 0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;/* 调用的云台预置点序号,一个报警输入可以调用多个通道的云台预置点, 0xff表示不调用预置点。*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnableCruise;/* 是否调用巡航 0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseNo;/* 巡航 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePtzTrack;/* 是否调用轨迹 0-否,1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byPTZTrack;/* 调用的云台的轨迹序号 */
		}

		//模拟报警输入参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAnalogAlarmincfg
		{
			public uint dwSize;
			public byte	byEnableAlarmHandle; //处理报警输入
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInName; //模拟报警输入名称
			public ushort wAlarmInUpper; //模拟输入电压上限，实际值乘10，范围0~360
			public ushort wAlarmInLower; //模拟输入电压下限，实际值乘10，范围0~360 
			public NetDvrHandleexceptionV30 struAlarmHandleType;	/* 处理方式 */ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //被触发的录像通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//上传报警信息(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfoV30
		{
			public uint dwAlarmType;/*0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问, 0xa-GPS定位信息(车载定制)*/
			public uint dwAlarmInputNumber;/*报警输入端口*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutputNumber;/*触发的输出端口，为1表示对应输出*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmRelateChannel;/*触发的录像通道，为1表示对应录像, dwAlarmRelateChannel[0]对应第1个通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byChannel;/*dwAlarmType为2或3,6时，表示哪个通道，dwChannel[0]对应第1个通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskNumber;/*dwAlarmType为1,4,5时,表示哪个硬盘, dwDiskNumber[0]对应第1个硬盘*/
			public void Init()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;
				byAlarmRelateChannel = new byte[MaxChannumV30];
				byChannel = new byte[MaxChannumV30];
				byAlarmOutputNumber = new byte[MaxAlarmoutV30];
				byDiskNumber = new byte[MaxDisknumV30];
				for (var i = 0; i < MaxChannumV30; i++)
				{
					byAlarmRelateChannel[i] = Convert.ToByte(0);
					byChannel[i] = Convert.ToByte(0);
				}
				for (var i = 0; i < MaxAlarmoutV30; i++)
				{
					byAlarmOutputNumber[i] = Convert.ToByte(0);
				}
				for (var i = 0; i < MaxDisknumV30; i++)
				{
					byDiskNumber[i] = Convert.ToByte(0);
				}
			}
			public void Reset()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;

				for (var i = 0; i < MaxChannumV30; i++)
				{
					byAlarmRelateChannel[i] = Convert.ToByte(0);
					byChannel[i] = Convert.ToByte(0);
				}
				for (var i = 0; i < MaxAlarmoutV30; i++)
				{
					byAlarmOutputNumber[i] = Convert.ToByte(0);
				}
				for (var i = 0; i < MaxDisknumV30; i++)
				{
					byDiskNumber[i] = Convert.ToByte(0);
				}
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmHotSpare
		{
			public uint dwSize;   //结构体
			public uint dwExceptionCase;   //报警原因   0-网络异常
			public NetDvrIpaddr  struDeviceIP;    //产生异常的设备IP地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfo
		{
			public int dwAlarmType;/*0-信号量报警,1-硬盘满,2-信号丢失,3－移动侦测,4－硬盘未格式化,5-读写硬盘出错,6-遮挡报警,7-制式不匹配, 8-非法访问, 9-串口状态, 0xa-GPS定位信息(车载定制)*/
			public int dwAlarmInputNumber;/*报警输入端口, 当报警类型为9时该变量表示串口状态0表示正常， -1表示错误*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmout, ArraySubType = UnmanagedType.U4)]
			public int[] dwAlarmOutputNumber;/*触发的输出端口，哪一位为1表示对应哪一个输出*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.U4)]
			public int[] dwAlarmRelateChannel;/*触发的录像通道，哪一位为1表示对应哪一路录像, dwAlarmRelateChannel[0]对应第1个通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.U4)]
			public int[] dwChannel;/*dwAlarmType为2或3,6时，表示哪个通道，dwChannel[0]位对应第1个通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknum, ArraySubType = UnmanagedType.U4)]
			public int[] dwDiskNumber;/*dwAlarmType为1,4,5时,表示哪个硬盘, dwDiskNumber[0]位对应第1个硬盘*/
			public void Init()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;
				dwAlarmOutputNumber = new int[MaxAlarmout];
				dwAlarmRelateChannel = new int[MaxChannum];
				dwChannel = new int[MaxChannum];
				dwDiskNumber = new int[MaxDisknum];
				for (var i = 0; i < MaxAlarmout; i++)
				{
					dwAlarmOutputNumber[i] = 0;
				}
				for (var i = 0; i < MaxChannum; i++)
				{
					dwAlarmRelateChannel[i] = 0;
					dwChannel[i] = 0;
				}
				for (var i = 0; i < MaxDisknum; i++)
				{
					dwDiskNumber[i] = 0;
				}
			}
			public void Reset()
			{
				dwAlarmType = 0;
				dwAlarmInputNumber = 0;

				for (var i = 0; i < MaxAlarmout; i++)
				{
					dwAlarmOutputNumber[i] = 0;
				}
				for (var i = 0; i < MaxChannum; i++)
				{
					dwAlarmRelateChannel[i] = 0;
					dwChannel[i] = 0;
				}
				for (var i = 0; i < MaxDisknum; i++)
				{
					dwDiskNumber[i] = 0;
				}
			}
		}


		//////////////////////////////////////////////////////////////////////////////////////
		//IPC接入参数配置
		/* IP设备结构 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpdevinfo
		{
			public uint dwEnable;/* 该IP设备是否启用 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword; /* 密码 */
			public NetDvrIpaddr struIP;/* IP地址 */
			public ushort wDVRPort;/* 端口号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;/* 保留 */

			public void Init()
			{
				sUserName = new byte[NameLen];
				sPassword = new byte[PasswdLen];
				byRes = new byte[34];
			}
		}

		//ipc接入设备信息扩展，支持ip设备的域名添加
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpdevinfoV31
		{
			public byte byEnable;//该IP设备是否有效
			public byte byProType;
			public byte byEnableQuickAdd;
			public byte byRes1;//保留字段，置0
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = NameLen)]
			public string sUserName;//用户名
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sPassword;//密码
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxDomainName)]
			public string byDomain;//设备域名
			public NetDvrIpaddr struIP;//IP地址
			public ushort wDVRPort;// 端口号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//保留字段，置0
		}

		/* IP通道匹配参数 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpchaninfo
		{
			public byte byEnable;/* 该通道是否在线 */
			public byte byIPID;/* IP设备ID 取值1- MaxIpDevice */
			public byte byChannel;/* 通道号 */
			public byte byIPIDHigh; // IP设备ID的高8位
			public byte byTransProtocol;//传输协议类型0-TCP/auto(具体有设备决定)，1-UDP 2-多播 3-仅TCP 4-auto
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留,置0
			public void Init()
			{
				byRes = new byte[31];
			}
		}

		/* IP接入配置结构 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpparacfg
		{
			public uint dwSize;/* 结构大小 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfo[] struIPDevInfo;/* IP设备 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IP通道 */

			public void Init()
			{
				int i;
				struIPDevInfo = new NetDvrIpdevinfo[MaxIpDevice];

				for (i = 0; i < MaxIpDevice; i++)
				{
					struIPDevInfo[i].Init();
				}
				byAnalogChanEnable = new byte[MaxAnalogChannum];
				struIPChanInfo = new NetDvrIpchaninfo[MaxIpChannel];
				for (i = 0; i < MaxIpChannel; i++)
				{
					struIPChanInfo[i].Init();
				}
			}
		}

		/* 扩展IP接入配置结构 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpparacfgV31
		{
			public uint dwSize;/* 结构大小 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo; /* IP设备 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IP通道 */

			public void Init()
			{
				int i;
				struIPDevInfo = new NetDvrIpdevinfoV31[MaxIpDevice];
				byAnalogChanEnable = new byte[MaxAnalogChannum];
				struIPChanInfo = new NetDvrIpchaninfo[MaxIpChannel];
				for (i = 0; i < MaxIpChannel; i++)
				{
					struIPChanInfo[i].Init();
				}
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpserverStream
		{
			public byte  byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[]  byRes;
			public NetDvrIpaddr struIPServer;
			public ushort  wPort;
			public ushort  wDvrNameLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[]  byDVRName;
			public ushort  wDVRSerialLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
			public ushort[]  byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[]  byDVRSerialNumber;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[]  byUserName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[]  byPassWord;
			public byte  byChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[]  byRes2;
			public void Init()
			{
				byRes = new byte[3];
				byDVRName = new byte[NameLen];
				byRes1 = new ushort[2];
				byDVRSerialNumber = new byte[SerialnoLen];
				byUserName = new byte[NameLen];
				byPassWord = new byte[PasswdLen];
				byRes2 = new byte[11];
			}
		}

		/*流媒体服务器基本配置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamMediaServerCfg
		{
			public byte byValid;/*是否启用流媒体服务器取流,0表示无效，非0表示有效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struDevIP;
			public ushort wDevPort;/*流媒体服务器端口*/
			public byte byTransmitType;/*传输协议类型 0-TCP，1-UDP*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		//设备通道信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevChanInfo
		{
			public NetDvrIpaddr struIP;		    //DVR IP地址
			public ushort wDVRPort;			 	//端口号
			public byte byChannel;				//通道号
			public byte byTransProtocol;		//传输协议类型0-TCP，1-UDP
			public byte byTransMode;			//传输码流模式 0－主码流 1－子码流
			public byte byFactoryType;			/*前端设备厂家类型,通过接口获取*/
			public byte byDeviceType; //设备类型(视频综合平台智能板使用)，1-解码器（此时根据视频综合平台能力集中byVcaSupportChanMode字段来决定是使用解码通道还是显示通道），2-编码器
			public byte byDispChan;//显示通道号,智能配置使用
			public byte bySubDispChan;//显示通道子通道号，智能配置时使用
			public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w大屏控制器使用，大屏控制器会根据该参数分配解码资源
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byDomain;	//设备域名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	//监控主机登陆帐号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	//监控主机密码
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPuStreamCfg
		{
			public uint dwSize;
			public NetDvrStreamMediaServerCfg struStreamMediaSvrCfg;
			public NetDvrDevChanInfo struDevChanInfo;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnsStreamCfg
		{
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struStreamServer;
			public ushort wStreamServerPort;
			public byte byStreamServerTransmitType;
			public byte byRes2;
			public NetDvrIpaddr struIPServer;
			public ushort wIPServerPort;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRName;
			public ushort wDVRNameLen;
			public ushort wDVRSerialLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRSerialNumber;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassWord;
			public ushort wDVRPort;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes4;
			public byte byChannel;
			public byte byTransProtocol;
			public byte byTransMode;
			public byte byFactoryType;
			public void Init()
			{
				byRes1 = new byte[3];
				byRes3 = new byte[2];
				sDVRName = new byte[NameLen];
				sDVRSerialNumber = new byte[SerialnoLen];
				sUserName = new byte[NameLen];
				sPassWord = new byte[PasswdLen];
				byRes4 = new byte[2];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPuStreamUrl
		{
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
			public byte[] strURL;
			public byte   byTransPortocol;
			public ushort wIPID;
			public byte byChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public void Init()
			{
				strURL = new byte[240];
				byRes = new byte[7];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHkddnsStream
		{
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byDDNSDomain;
			public ushort wPort;
			public ushort wAliasLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlias;
			public ushort wDVRSerialLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDVRSerialNumber;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassWord;
			public byte byChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public void Init()
			{
				byRes = new byte[3];
				byDDNSDomain = new byte[64];
				byAlias = new byte[NameLen];
				byRes1 = new byte[2];
				byDVRSerialNumber = new byte[SerialnoLen];
				byUserName = new byte[NameLen];
				byPassWord = new byte[PasswdLen];
				byRes2 = new byte[11];
			}
		}

		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpchaninfoV40
		{
			public byte byEnable;				/* 该通道是否在线 */
			public byte byRes1;
			public ushort wIPID;                  //IP设备ID
			public uint dwChannel;				//通道号
			public byte byTransProtocol;		//传输协议类型0-TCP，1-UDP
			public byte byTransMode;			//传输码流模式 0－主码流 1－子码流
			public byte byFactoryType;			/*前端设备厂家类型,通过接口获取*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 241, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrGetStreamUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 492, ArraySubType = UnmanagedType.I1)]
			public byte[] byUnion;
			public void Init()
			{
				byUnion = new byte[492];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamMode
		{
			public byte byGetStreamType;/*取流方式：0- 直接从设备取流；1- 从流媒体取流；2- 通过IPServer获得IP地址后取流；
										  * 3- 通过IPServer找到设备，再通过流媒体取设备的流； 4- 通过流媒体由URL去取流；
										  * 5- 通过hiDDNS域名连接设备然后从设备取流 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[]  byRes;
			public NetDvrGetStreamUnion uGetStream;
			public void Init()
			{
				byGetStreamType = 0;
				byRes = new byte[3];
				//uGetStream.Init();
			}
		}

		/* V40扩展IP接入配置结构 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpparacfgV40
		{
			public uint dwSize;/* 结构大小 */
			public uint dwGroupNum;
			public uint dwAChanNum;
			public uint dwDChanNum;
			public uint dwStartDChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDeviceV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo; /* IP设备 */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrStreamMode[] struStreamMode;/* IP通道 */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; /* 模拟通道是否启用，从低到高表示1-32通道，0表示无效 1有效 */
		}

		//为CVR扩展的报警类型
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfoDev
		{
			public uint dwAlarmType;  //0-编码器(通道)信号量报警；1-私有卷二损坏；2- NVR服务退出；
			//3-编码器状态异常；4-系统时钟异常；5-录像卷剩余容量过低；
			//6-编码器(通道)移动侦测报警；7-编码器(通道)遮挡报警。
			public NetDvrTime   struTime;     //报警时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //保留
			public uint dwNumber;     //数目
			public IntPtr pNO;  //dwNumber个WORD; 每个WORD表示一个通道号，或者磁盘号, 无效时为0
		}

		/* 报警输出参数 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutinfo
		{
			public byte byIPID;/* IP设备ID取值1- MaxIpDevice */
			public byte byAlarmOut;/* 报警输出号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;/* 保留 */

			public void Init()
			{
				byRes = new byte[18];
			}
		}

		/* IP报警输出配置结构 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutcfg
		{
			public uint dwSize; /* 结构大小 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo;/* IP报警输出 */

			public void Init()
			{
				struIPAlarmOutInfo = new NetDvrIpalarmoutinfo[MaxIpAlarmout];
				for (var i = 0; i < MaxIpAlarmout; i++)
				{
					struIPAlarmOutInfo[i].Init();
				}
			}
		}
		/* IP报警输出参数 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutinfoV40
		{
			public uint dwIPID;					/* IP设备ID */
			public uint dwAlarmOut;				/* IP设备ID对应的报警输出号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				/* 保留 */
		}

		/*IP报警输出*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutcfgV40
		{
			public uint dwSize;  //结构体长度
			public uint dwCurIPAlarmOutNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmoutV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfoV40[] struIPAlarmOutInfo;/*IP报警输出*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/* 报警输入参数 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmininfo
		{
			public byte byIPID;/* IP设备ID取值1- MaxIpDevice */
			public byte byAlarmIn;/* 报警输入号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;/* 保留 */
		}

		/* IP报警输入配置结构 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmincfg
		{
			public uint dwSize;/* 结构大小 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo;/* IP报警输入 */
		}
		/* IP报警输入参数 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmininfoV40
		{
			public uint dwIPID;					/* IP设备ID */
			public uint dwAlarmIn;				/* IP设备ID对应的报警输入号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				/* 保留 */
		}
		 /*IP报警输入资源*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmincfgV40
		{
			public uint dwSize;  //结构体长度
			public uint dwCurIPAlarmInNum;  //当前报警输入口数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarminV40, ArraySubType = UnmanagedType.I1)]
			public NetDvrIpalarmininfoV40[] struIPAlarmInInfo;/* IP报警输入*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ipc alarm info
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarminfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfo[] struIPDevInfo; /* IP设备 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* 模拟通道是否启用，0-未启用 1-启用 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IP通道 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo;/* IP报警输入 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo;/* IP报警输出 */
		}

		//ipc配置改变报警信息扩展 9000_1.1
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarminfoV31
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo; /* IP设备 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;/* 模拟通道是否启用，0-未启用 1-启用 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IP通道 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo; /* IP报警输入 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo;/* IP报警输出 */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarminfoV40
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDeviceV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo;           // IP设备
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;           /* 模拟通道是否启用，0-未启用 1-启用 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;	        /* IP通道 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo;    /* IP报警输入 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo; /* IP报警输出 */   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                          // 保留字节
		}

		public enum HdStat
		{
			HdStatOk = 0,/* 正常 */
			HdStatUnformatted = 1,/* 未格式化 */
			HdStatError = 2,/* 错误 */
			HdStatSmartFailed = 3,/* SMART状态 */
			HdStatMismatch = 4,/* 不匹配 */
			HdStatIdle = 5, /* 休眠*/
			NetHdStatOffline = 6,/*网络盘处于未连接状态 */
			HdRiadvdExpand = 7,    /* 虚拟磁盘可扩容 */
			HdStatReparing = 10,   /* 硬盘正在修复(9000 2.0) */
			HdStatFormating = 11,   /* 硬盘正在格式化(9000 2.0) */ 
		}

		//本地硬盘信息配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleHd
		{
			public uint dwHDNo;/*硬盘号, 取值0~MaxDisknumV30-1*/
			public uint dwCapacity;/*硬盘容量(不可设置)*/
			public uint dwFreeSpace;/*硬盘剩余空间(不可设置)*/
			public uint dwHdStatus;/*硬盘状态(不可设置) HD_STAT*/
			public byte byHDAttr;/*0-默认, 1-冗余; 2-只读*/
			public byte byHDType;/*0-本地硬盘,1-ESATA硬盘,2-NAS硬盘*/
			public byte byDiskDriver;   // 值 代表其ASCII字符 
			public byte byRes1;
			public uint dwHdGroup; /*属于哪个盘组 1-MaxHdGroup*/
			public byte byRecycling;   // 是否循环利用 0：不循环利用，1：循环利用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public uint dwStorageType;    //按位表示 0-不支持 非0-支持
							// dwStorageType & 0x1 表示是否是普通录像专用存储盘     
							// dwStorageType & 0x2  表示是否是抽帧录像专用存储盘
							// dwStorageType & 0x4 表示是否是图片录像专用存储盘

			public uint dwPictureCapacity; //硬盘图片容量(不可设置)，单位:MB
			public uint dwFreePictureSpace; //剩余图片空间(不可设置)，单位:MB
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHdcfg
		{
			public uint dwSize;
			public uint dwHDCount;/*硬盘数(不可设置)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleHd[] struHDInfo;//硬盘相关操作都需要重启才能生效；
		}

		//本地盘组信息配置扩展
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleHdgroupV40
		{
			public uint dwHDGroupNo;       /*盘组号(不可设置) 1-MaxHdGroup*/    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelRecordChan;  //触发的录像通道，按值表示，遇到0xffffffff时后续视为无效    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				/* 保留 */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHdgroupCfgV40
		{
			public uint dwSize;                //结构体大小
			public uint dwMaxHDGroupNum; 		  //设备支持的最大盘组数-只读
			public uint dwCurHDGroupNum;       /*当前配置的盘组数*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHdGroup, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleHdgroupV40[] struHDGroupAttr; //硬盘相关操作都需要重启才能生效；
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		//本地盘组信息配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleHdgroup
		{
			public uint dwHDGroupNo;/*盘组号(不可设置) 1-MaxHdGroup*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byHDGroupChans;/*盘组对应的录像通道, 0-表示该通道不录象到该盘组，1-表示录象到该盘组*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHdgroupCfg
		{
			public uint dwSize;
			public uint dwHDGroupCount;/*盘组总数(不可设置)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHdGroup, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleHdgroup[] struHDGroupAttr;//硬盘相关操作都需要重启才能生效
		}

		//配置缩放参数的结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScalecfg
		{
			public uint dwSize;
			public uint dwMajorScale;/* 主显示 0-不缩放，1-缩放*/
			public uint dwMinorScale;/* 辅显示 0-不缩放，1-缩放*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		//DVR报警输出(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmOutName;/* 名称 */
			public uint dwAlarmOutDelay;/* 输出保持时间(-1为无限，手动关闭) */
			//0-5秒,1-10秒,2-30秒,3-1分钟,4-2分钟,5-5分钟,6-10分钟,7-手动
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmOutTime;/* 报警输出激活时间段 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR报警输出
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmOutName;/* 名称 */
			public uint dwAlarmOutDelay;/* 输出保持时间(-1为无限，手动关闭) */
			//0-5秒,1-10秒,2-30秒,3-1分钟,4-2分钟,5-5分钟,6-10分钟,7-手动
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmOutTime;/* 报警输出激活时间段 */
		}

		//DVR本地预览参数(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPreviewcfgV30
		{
			public uint dwSize;
			public byte byPreviewNumber;//预览数目,0-1画面,1-4画面,2-9画面,3-16画面,0xff:最大画面
			public byte byEnableAudio;//是否声音预览,0-不预览,1-预览
			public ushort wSwitchTime;//切换时间,0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPreviewMode * MaxWindowV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySwitchSeq;//切换顺序,如果lSwitchSeq[i]为 0xff表示不用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR本地预览参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPreviewcfg
		{
			public uint dwSize;
			public byte byPreviewNumber;//预览数目,0-1画面,1-4画面,2-9画面,3-16画面,0xff:最大画面
			public byte byEnableAudio;//是否声音预览,0-不预览,1-预览
			public ushort wSwitchTime;//切换时间,0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindow, ArraySubType = UnmanagedType.I1)]
			public byte[] bySwitchSeq;//切换顺序,如果lSwitchSeq[i]为 0xff表示不用
		}

		//DVR视频输出
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVgapara
		{
			public ushort wResolution;/* 分辨率 */
			public ushort wFreq;/* 刷新频率 */
			public uint dwBrightness;/* 亮度 */
		}

		//MATRIX输出参数结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixparaV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wOrder;/* 预览顺序, 0xff表示相应的窗口不预览 */
			public ushort wSwitchTime;// 预览切换时间 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixpara
		{
			public ushort wDisplayLogo;/* 显示视频通道号 */
			public ushort wDisplayOsd;/* 显示时间 */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVoout
		{
			public byte byVideoFormat;/* 输出制式,0-PAL,1-NTSC */
			public byte byMenuAlphaValue;/* 菜单与背景图象对比度 */
			public ushort wScreenSaveTime;/* 屏幕保护时间 0-从不,1-1分钟,2-2分钟,3-5分钟,4-10分钟,5-20分钟,6-30分钟 */
			public ushort wVOffset;/* 视频输出偏移 */
			public ushort wBrightness;/* 视频输出亮度 */
			public byte byStartMode;/* 启动后视频输出模式(0:菜单,1:预览)*/
			public byte byEnableScaler;/* 是否启动缩放 (0-不启动, 1-启动)*/
		}

		//DVR视频输出(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideooutV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVideooutV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVoout[] struVOOut;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVgaV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVgapara[] struVGAPara;/* VGA参数 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxMatrixout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixparaV30[] struMatrixPara;/* MATRIX参数 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR视频输出
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoout
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVideoout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVoout[] struVOOut;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVga, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVgapara[] struVGAPara;	/* VGA参数 */
			public NetDvrMatrixpara struMatrixPara;/* MATRIX参数 */
		}

		//单用户参数(子结构)(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserInfoV40
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;			/* 用户名只能用16字节 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;			/* 密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRight;	/* 本地权限 */
			/*数组0: 本地控制云台*/
			/*数组1: 本地手动录象*/
			/*数组2: 本地回放*/
			/*数组3: 本地设置参数*/
			/*数组4: 本地查看状态、日志*/
			/*数组5: 本地高级操作(升级，格式化，重启，关机)*/
			/*数组6: 本地查看参数 */
			/*数组7: 本地管理模拟和IP camera */
			/*数组8: 本地备份 */
			/*数组9: 本地关机/重启 */    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemoteRight;/* 远程权限 */	
			/*数组0: 远程控制云台*/
			/*数组1: 远程手动录象*/
			/*数组2: 远程回放 */
			/*数组3: 远程设置参数*/
			/*数组4: 远程查看状态、日志*/
			/*数组5: 远程高级操作(升级，格式化，重启，关机)*/
			/*数组6: 远程发起语音对讲*/
			/*数组7: 远程预览*/
			/*数组8: 远程请求报警上传、报警输出*/
			/*数组9: 远程控制，本地输出*/
			/*数组10: 远程控制串口*/
			/*数组11: 远程查看参数 */
			/*数组12: 远程管理模拟和IP camera */
			/*数组13: 远程关机/重启 */	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetPreviewRight;			/* 远程可以预览的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRecordRight;			/* 本地可以录像的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetRecordRight;			/* 远程可以录像的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalPlaybackRight;			/* 本地可以回放的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetPlaybackRight;			/* 远程可以回放的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalPTZRight;				/* 本地可以PTZ的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetPTZRight;				/* 远程可以PTZ的通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalBackupRight;			/* 本地备份权限通道，从前往后顺序排列，遇到0xffffffff后续均为无效*/
			public NetDvrIpaddr	struUserIP;				/* 用户IP地址(为0时表示允许任何地址) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;	/* 物理地址 */
			public byte byPriority;				/* 优先级，0xff-无，0--低，1--中，2--高 */
									/* 无……表示不支持优先级的设置
									低……默认权限:包括本地和远程回放,本地和远程查看日志和状态,本地和远程关机/重启
									中……包括本地和远程控制云台,本地和远程手动录像,本地和远程回放,语音对讲和远程预览、本地备份,本地/远程关机/重启
									高……管理员 */
			public byte byAlarmOnRight;         // 报警输入口布防权限 1-有权限，0-无权限
			public byte byAlarmOffRight;         // 报警输入口撤防权限 1-有权限，0-无权限
			public byte byBypassRight;           // 报警输入口旁路权限 1-有权限，0-无权限 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}

		//单用户参数(子结构)(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserInfoV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRight;/* 本地权限 */
			/*数组0: 本地控制云台*/
			/*数组1: 本地手动录象*/
			/*数组2: 本地回放*/
			/*数组3: 本地设置参数*/
			/*数组4: 本地查看状态、日志*/
			/*数组5: 本地高级操作(升级，格式化，重启，关机)*/
			/*数组6: 本地查看参数 */
			/*数组7: 本地管理模拟和IP camera */
			/*数组8: 本地备份 */
			/*数组9: 本地关机/重启 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemoteRight;/* 远程权限 */
			/*数组0: 远程控制云台*/
			/*数组1: 远程手动录象*/
			/*数组2: 远程回放 */
			/*数组3: 远程设置参数*/
			/*数组4: 远程查看状态、日志*/
			/*数组5: 远程高级操作(升级，格式化，重启，关机)*/
			/*数组6: 远程发起语音对讲*/
			/*数组7: 远程预览*/
			/*数组8: 远程请求报警上传、报警输出*/
			/*数组9: 远程控制，本地输出*/
			/*数组10: 远程控制串口*/
			/*数组11: 远程查看参数 */
			/*数组12: 远程管理模拟和IP camera */
			/*数组13: 远程关机/重启 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPreviewRight;/* 远程可以预览的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalPlaybackRight;/* 本地可以回放的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPlaybackRight;/* 远程可以回放的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRecordRight;/* 本地可以录像的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetRecordRight;/* 远程可以录像的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalPTZRight;/* 本地可以PTZ的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPTZRight;/* 远程可以PTZ的通道 0-有权限，1-无权限*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalBackupRight;/* 本地备份权限通道 0-有权限，1-无权限*/
			public NetDvrIpaddr struUserIP;/* 用户IP地址(为0时表示允许任何地址) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/* 物理地址 */
			public byte byPriority;/* 优先级，0xff-无，0--低，1--中，2--高 */
			/*
			无……表示不支持优先级的设置
			低……默认权限:包括本地和远程回放,本地和远程查看日志和状态,本地和远程关机/重启
			中……包括本地和远程控制云台,本地和远程手动录像,本地和远程回放,语音对讲和远程预览
				  本地备份,本地/远程关机/重启
			高……管理员
			*/
			public byte byAlarmOnRight;         // 报警输入口布防权限
			public byte byAlarmOffRight;        // 报警输入口撤防权限
			public byte byBypassRight;          // 报警输入口旁路权限
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//单用户参数(SDK_V15扩展)(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrUserInfoEx
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRight;/* 权限 */
			/*数组0: 本地控制云台*/
			/*数组1: 本地手动录象*/
			/*数组2: 本地回放*/
			/*数组3: 本地设置参数*/
			/*数组4: 本地查看状态、日志*/
			/*数组5: 本地高级操作(升级，格式化，重启，关机)*/
			public uint dwLocalPlaybackRight;/* 本地可以回放的通道 bit0 -- channel 1*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRemoteRight;/* 权限 */
			/*数组0: 远程控制云台*/
			/*数组1: 远程手动录象*/
			/*数组2: 远程回放 */
			/*数组3: 远程设置参数*/
			/*数组4: 远程查看状态、日志*/
			/*数组5: 远程高级操作(升级，格式化，重启，关机)*/
			/*数组6: 远程发起语音对讲*/
			/*数组7: 远程预览*/
			/*数组8: 远程请求报警上传、报警输出*/
			/*数组9: 远程控制，本地输出*/
			/*数组10: 远程控制串口*/
			public uint dwNetPreviewRight;/* 远程可以预览的通道 bit0 -- channel 1*/
			public uint dwNetPlaybackRight;/* 远程可以回放的通道 bit0 -- channel 1*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sUserIP;/* 用户IP地址(为0时表示允许任何地址) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/* 物理地址 */
		}

		//单用户参数(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrUserInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRight;/* 权限 */
			/*数组0: 本地控制云台*/
			/*数组1: 本地手动录象*/
			/*数组2: 本地回放*/
			/*数组3: 本地设置参数*/
			/*数组4: 本地查看状态、日志*/
			/*数组5: 本地高级操作(升级，格式化，重启，关机)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRemoteRight;/* 权限 */
			/*数组0: 远程控制云台*/
			/*数组1: 远程手动录象*/
			/*数组2: 远程回放 */
			/*数组3: 远程设置参数*/
			/*数组4: 远程查看状态、日志*/
			/*数组5: 远程高级操作(升级，格式化，重启，关机)*/
			/*数组6: 远程发起语音对讲*/
			/*数组7: 远程预览*/
			/*数组8: 远程请求报警上传、报警输出*/
			/*数组9: 远程控制，本地输出*/
			/*数组10: 远程控制串口*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sUserIP;/* 用户IP地址(为0时表示允许任何地址) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/* 物理地址 */
		}

		//DVR用户参数(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserV40
		{
			public uint dwSize;  //结构体大小
			public uint dwMaxUserNum; //设备支持的最大用户数-只读
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfoV40[] struUser;  /* 用户参数 */
		}

		//DVR用户参数(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfoV30[] struUser;
		}

		//DVR用户参数(SDK_V15扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserEx
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfoEx[] struUser;
		}

		//DVR用户参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUser
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfo[] struUser;
		}

		//异常参数配置扩展结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrExceptionV40
		{
			public uint dwSize ;             //结构体大小
			public uint dwMaxGroupNum ;    //设备支持的最大组数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHandleexceptionV41[] struExceptionHandle;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //保留
		} 

		//DVR异常参数(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrExceptionV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHandleexceptionV30[] struExceptionHandleType;
			/*数组0-盘满,1- 硬盘出错,2-网线断,3-局域网内IP 地址冲突, 4-非法访问, 5-输入/输出视频制式不匹配, 6-视频信号异常, 7-录像异常*/
		}

		//DVR异常参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrException
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHandleexception[] struExceptionHandleType;
			/*数组0-盘满,1- 硬盘出错,2-网线断,3-局域网内IP 地址冲突,4-非法访问, 5-输入/输出视频制式不匹配, 6-视频信号异常*/
		}

		//通道状态(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannelstateV30
		{
			public byte byRecordStatic;//通道是否在录像,0-不录像,1-录像
			public byte bySignalStatic;//连接的信号状态,0-正常,1-信号丢失
			public byte byHardwareStatic;//通道硬件状态,0-正常,1-异常,例如DSP死掉
			public byte byRes1;//保留
			public uint dwBitRate;//实际码率
			public uint dwLinkNum;//客户端连接的个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLink, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struClientIP;//客户端的IP地址
			public uint dwIPLinkNum;//如果该通道为IP接入，那么表示IP接入当前的连接数
			public byte byExceedMaxLink;		// 是否超出了单路6路连接数 0 - 未超出, 1-超出
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwChannelNo;    //当前的通道号，0xffffffff表示无效

			public void Init()
			{
				struClientIP = new NetDvrIpaddr[MaxLink];

				for (var i = 0; i < MaxLink; i++)
				{
					struClientIP[i].Init();
				}
				byRes = new byte[12];
			}
		}

		//通道状态
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannelstate
		{
			public byte byRecordStatic;//通道是否在录像,0-不录像,1-录像
			public byte bySignalStatic;//连接的信号状态,0-正常,1-信号丢失
			public byte byHardwareStatic;//通道硬件状态,0-正常,1-异常,例如DSP死掉
			public byte reservedData;//保留
			public uint dwBitRate;//实际码率
			public uint dwLinkNum;//客户端连接的个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLink, ArraySubType = UnmanagedType.U4)]
			public uint[] dwClientIP;//客户端的IP地址
		}

		//硬盘状态
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskstate
		{
			public uint dwVolume;//硬盘的容量
			public uint dwFreeSpace;//硬盘的剩余空间
			public uint dwHardDiskStatic;//硬盘的状态,0-活动,1-休眠,2-不正常
		}

		//设备工作状态扩展结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWorkstateV40
		{ 
			public uint dwSize ;            //结构体大小
			public uint dwDeviceStatic; 	 //设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDiskstate[]  struHardDiskStatic;   //硬盘状态,一次最多只能获取33个硬盘信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChannelstateV30[] struChanStatic;//通道的状态，从前往后顺序排列
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwHasAlarmInStatic; //有报警的报警输入口，按值表示，按下标值顺序排列，值为0xffffffff时当前及后续值无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwHasAlarmOutStatic; //有报警输出的报警输出口，按值表示，按下标值顺序排列，值为0xffffffff时当前及后续值无效
			public uint dwLocalDisplay;			//本地显示状态,0-正常,1-不正常
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAudioV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAudioInChanStatus;		//按位表示语音通道的状态 0-未使用，1-使用中，第0位表示第1个语音通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 				//保留
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGetworkstateCond
		{
			public uint dwSize ;  //结构体长度
			public byte byFindHardByCond; /*0-查找全部磁盘(但一次最多只能查找33个)，此时dwFindHardStatusNum无效*/
			public byte byFindChanByCond ;  /*0-查找全部通道，此时dwFindChanNum无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwFindHardStatus ; /*要查找的硬盘号，按值表示，该值采用顺序排列， 遇到0xffffffff则认为后续无效 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwFindChanNo; /*要查找的通道号，按值表示，该值采用顺序排列， 遇到0xffffffff则认为后续无效 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		//DVR工作状态(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWorkstateV30
		{
			public uint dwDeviceStatic;//设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDiskstate[] struHardDiskStatic;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChannelstateV30[] struChanStatic;//通道的状态
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatic;//报警端口的状态,0-没有报警,1-有报警
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatic;//报警输出端口的状态,0-没有输出,1-有报警输出
			public uint dwLocalDisplay;//本地显示状态,0-正常,1-不正常
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAudioV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAudioChanStatus;//表示语音通道的状态 0-未使用，1-使用中, 0xff无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				struHardDiskStatic = new NetDvrDiskstate[MaxDisknumV30];
				struChanStatic = new NetDvrChannelstateV30[MaxChannumV30];
				for (var i = 0; i < MaxChannumV30; i++)
				{
					struChanStatic[i].Init();
				}
				byAlarmInStatic = new byte[MaxAlarmoutV30];
				byAlarmOutStatic = new byte[MaxAlarmoutV30];
				byAudioChanStatus = new byte[MaxAudioV30];
				byRes = new byte[10];
			}
		}

		//DVR工作状态
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWorkstate
		{
			public uint dwDeviceStatic;//设备的状态,0-正常,1-CPU占用率太高,超过85%,2-硬件错误,例如串口死掉
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDiskstate[] struHardDiskStatic;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChannelstate[] struChanStatic;//通道的状态
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmin, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatic;//报警端口的状态,0-没有报警,1-有报警
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmout, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatic;//报警输出端口的状态,0-没有输出,1-有报警输出
			public uint dwLocalDisplay;//本地显示状态,0-正常,1-不正常

			public void Init()
			{
				struHardDiskStatic = new NetDvrDiskstate[MaxDisknum];
				struChanStatic = new NetDvrChannelstate[MaxChannum];
				byAlarmInStatic = new byte[MaxAlarmin];
				byAlarmOutStatic = new byte[MaxAlarmout];
			}
		}        

		//日志信息(9000扩展)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrLogV30
		{
			public NetDvrTime strLogTime;
			public uint dwMajorType;//主类型 1-报警; 2-异常; 3-操作; 0xff-全部
			public uint dwMinorType;//次类型 0-全部;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;//操作面板的用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;//网络操作的用户名
			public NetDvrIpaddr struRemoteHostAddr;//远程主机地址
			public uint dwParaType;//参数类型
			public uint dwChannel;//通道号
			public uint dwDiskNumber;//硬盘号
			public uint dwAlarmInPort;//报警输入端口
			public uint dwAlarmOutPort;//报警输出端口
			public uint dwInfoLen;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LogInfoLen)]
			public string sInfo;
		}

		//日志信息
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrLog
		{
			public NetDvrTime strLogTime;
			public uint dwMajorType;//主类型 1-报警; 2-异常; 3-操作; 0xff-全部
			public uint dwMinorType;//次类型 0-全部;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;//操作面板的用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;//网络操作的用户名
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteHostAddr;//远程主机地址
			public uint dwParaType;//参数类型
			public uint dwChannel;//通道号
			public uint dwDiskNumber;//硬盘号
			public uint dwAlarmInPort;//报警输入端口
			public uint dwAlarmOutPort;//报警输出端口
		}

		/************************动环报警管理主机日志查找 begin************************************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmhostSearchLogParam
		{
			public ushort wMajorType;		// 主类型
			public ushort wMinorType;		// 次类型 
			public NetDvrTime    struStartTime;	// 开始时间 
			public NetDvrTime    struEndTime;	// 结束时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmhostLogRet
		{
			public NetDvrTime	struLogTime;                //  日志时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;     // 操作用户
			public NetDvrIpaddr	struIPAddr;                 // 操作IP地址
			public ushort wMajorType;                 // 主类型 
			public ushort wMinorType;                 // 次类型
			public ushort wParam;	                    // 操作参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwInfoLen;	                // 描述信息长度
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LogInfoLen)]
			public string sInfo;       // 描述信息
		}
		/*************************动环报警管理主机日志查找 end***********************************************/

		//报警输出状态(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutstatusV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] Output;

			public void Init()
			{
				Output = new byte[MaxAlarmoutV30];
			}
		}

		//报警输出状态
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutstatus
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] Output;
		}        

		//ATM专用
		/****************************ATM(begin)***************************/
		public const int Ncr = 0;
		public const int Diebold = 1;
		public const int WincorNixdorf = 2;
		public const int Siemens = 3;
		public const int Olivetti = 4;
		public const int Fujitsu = 5;
		public const int Hitachi = 6;
		public const int Smi = 7;
		public const int Ibm = 8;
		public const int Bull = 9;
		public const int YiHua = 10;
		public const int LiDe = 11;
		public const int Gdyt = 12;
		public const int MiniBanl = 13;
		public const int GuangLi = 14;
		public const int DongXin = 15;
		public const int ChenTong = 16;
		public const int NanTian = 17;
		public const int XiaoXing = 18;
		public const int Gzyy = 19;
		public const int Qhtlt = 20;
		public const int Drs918 = 21;
		public const int Kalatel = 22;
		public const int Ncr2 = 23;
		public const int Nxs = 24;

		//交易信息
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrTradeinfo
		{
			public ushort m_Year;
			public ushort m_Month;
			public ushort m_Day;
			public ushort m_Hour;
			public ushort m_Minute;
			public ushort m_Second;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] DeviceName;//设备名称
			public uint dwChannelNumer;//通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] CardNumber;//卡号
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
			public string cTradeType;//交易类型
			public uint dwCash;//交易金额
		}

		/*帧格式*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFrametypecode
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] code;/* 代码 */
		}
		
		//ATM参数
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFrameformat
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sATMIP;/* ATM IP地址 */
			public uint dwATMType;/* ATM类型 */
			public uint dwInputMode;/* 输入方式	0-网络侦听 1-网络接收 2-串口直接输入 3-串口ATM命令输入*/
			public uint dwFrameSignBeginPos;/* 报文标志位的起始位置*/
			public uint dwFrameSignLength;/* 报文标志位的长度 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byFrameSignContent;/* 报文标志位的内容 */
			public uint dwCardLengthInfoBeginPos;/* 卡号长度信息的起始位置 */
			public uint dwCardLengthInfoLength;/* 卡号长度信息的长度 */
			public uint dwCardNumberInfoBeginPos;/* 卡号信息的起始位置 */
			public uint dwCardNumberInfoLength;/* 卡号信息的长度 */
			public uint dwBusinessTypeBeginPos;/* 交易类型的起始位置 */
			public uint dwBusinessTypeLength;/* 交易类型的长度 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public NetDvrFrametypecode[] frameTypeCode;/* 类型 */
		}

		//SDK_V31 ATM
		/*过滤设置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFilter
		{
			public byte byEnable;/*0,不启用;1,启用*/
			public byte byMode;/*0,ASCII;1,HEX*/
			public byte byFrameBeginPos;// 报文标志位的起始位置     
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byFilterText;/*过滤字符串*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*起始标识设置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIdentificat
		{
			public byte byStartMode;/*0,ASCII;1,HEX*/
			public byte byEndMode;/*0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrFrametypecode struStartCode;/*起始字符*/
			public NetDvrFrametypecode struEndCode;/*结束字符*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		/*报文信息位置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPackageLocation
		{
			public byte byOffsetMode;/*0,token;1,fix*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwOffsetPos;/*mode为1的时候使用*/
			public NetDvrFrametypecode struTokenCode;/*标志位*/
			public byte byMultiplierValue;/*标志位多少次出现*/
			public byte byEternOffset;/*附加的偏移量*/
			public byte byCodeMode;/*0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*报文信息长度*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPackageLength
		{
			public byte byLengthMode;/*长度类型，0,variable;1,fix;2,get from package(设置卡号长度使用)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwFixLength;/*mode为1的时候使用*/
			public uint dwMaxLength;
			public uint dwMinLength;
			public byte byEndMode;/*终结符0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrFrametypecode struEndCode;/*终结符*/
			public uint dwLengthPos;/*lengthMode为2的时候使用，卡号长度在报文中的位置*/
			public uint dwLengthLen;/*lengthMode为2的时候使用，卡号长度的长度*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		/*OSD 叠加的位置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOsdPosition
		{
			public byte byPositionMode;/*叠加风格，共2种；0，不显示；1，Custom*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwPos_x;/*x坐标，positionmode为Custom时使用*/
			public uint dwPos_y;/*y坐标，positionmode为Custom时使用*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*日期显示格式*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDateFormat
		{
			public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
			public byte byItem2;/*Day,0.dd;*/
			public byte byItem3;/*Year,0.yy;1.yyyy*/
			public byte byDateForm;/*0~5，3个item的排列组合*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chSeprator;/*分隔符*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chDisplaySeprator;/*显示分隔符*/
			public byte byDisplayForm;/*0~5，3个item的排列组合*///lili mode by lili
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		/*时间显示格式*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrtTimeFormat
		{
			public byte byTimeForm;/*1. HH MM SS;0. HH MM*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byHourMode;/*0,12;1,24*/ //lili mode
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chSeprator;/*报文分隔符，暂时没用*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chDisplaySeprator;/*显示分隔符*/
			public byte byDisplayForm;/*0~5，3个item的排列组合*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
			public byte byDisplayHourMode;/*0,12;1,24*/ //lili mode
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes4;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOverlayChannel
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byChannel;/*叠加的通道*/
			public uint dwDelayTime;/*叠加延时时间*/
			public byte byEnableDelayTime;/*是否启用叠加延时，在无退卡命令时启用*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmPackageAction
		{
			public NetDvrPackageLocation struPackageLocation;
			public NetDvrOsdPosition struOsdPosition;
			public NetDvrFrametypecode struActionCode;/*交易类型等对应的码*/
			public NetDvrFrametypecode struPreCode;/*叠加字符前的字符*/
			public byte byActionCodeMode;/*交易类型等对应的码0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmPackageDate
		{
			public NetDvrPackageLocation struPackageLocation;
			public NetDvrDateFormat struDateForm;
			public NetDvrOsdPosition struOsdPosition;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmPackageTime
		{
			public NetDvrPackageLocation location;
			public NetDvrtTimeFormat struTimeForm;
			public NetDvrOsdPosition struOsdPosition;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmPackageOthers
		{
			public NetDvrPackageLocation struPackageLocation;
			public NetDvrPackageLength struPackageLength;
			public NetDvrOsdPosition struOsdPosition;
			public NetDvrFrametypecode struPreCode;/*叠加字符前的字符*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//用户自定义协议
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmUserDefineProtocol
		{
			public NetDvrIdentificat        struIdentification;  //报文标志
			public NetDvrFilter             struFilter; //数据包过滤设置
			public NetDvrAtmPackageOthers struCardNoPara; //叠加卡号设置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxActionType, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAtmPackageAction[] struTradeActionPara; //叠加交易行为设置 0-9 依次对应InCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
			public NetDvrAtmPackageOthers struAmountPara; //叠加交易金额设置
			public NetDvrAtmPackageOthers struSerialNoPara; //叠加交易序号设置
			public NetDvrOverlayChannel    struOverlayChan; //叠加通道设置
			public NetDvrAtmPackageDate   struRes1; //叠加日期，保留
			public NetDvrAtmPackageTime   struRes2; //叠加时间，保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;        //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmFrameformatV30
		{		
			public uint dwSize;                 //结构大小
			public byte byEnable;				/*是否启用0,不启用;1,启用*/
			public byte byInputMode;			/**输入方式:0-网络监听、1网络协议、2-串口监听、3-串口协议*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;              //保留字节 
			public NetDvrIpaddr struAtmIp;				/*ATM 机IP 网络监听时使用 */
			public ushort wAtmPort;				/* 网络协议方式时是使用*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;              // 保留字节
			public uint dwAtmType;				/*ATM协议类型，从NET_DVR_ATM_PROTOCOL结构中获取，如果类型为自定义时使用用户自定义协议*/
			public NetDvrAtmUserDefineProtocol  struAtmUserDefineProtocol; //用户自定义协议，当ATM类型为自定时需要使用该定义
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		//协议信息数据结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmProtoType
		{
			public uint dwAtmType; //ATM协议类型，同时作为索引序号 ATM 配置中的dwAtmType 自定义时为1025
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = AtmDescLen)]
			public string chDesc; //ATM协议简单描述
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrAtmProtoList
		{
			public uint dwAtmProtoNum;/*协议列表的个数*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAtmProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAtmProtoType[] struAtmProtoType;/*协议列表信息*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmProtocol
		{
			public uint dwSize;
			public NetDvrAtmProtoList struNetListenList;     // 网络监听协议描述
			public NetDvrAtmProtoList struSerialListenList; //串口监听协议描述
			public NetDvrAtmProtoList struNetProtoList;     //网络协议描述
			public NetDvrAtmProtoList struSerialProtoList;   //串口协议描述
			public NetDvrAtmProtoType struCustomProto;      //自定义协议            
		}

		/*****************************DS-6001D/F(begin)***************************/
		//DS-6001D Decoder
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderinfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderIP;//解码设备连接的服务器IP
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderUser;//解码设备连接的服务器的用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderPasswd;//解码设备连接的服务器的密码
			public byte bySendMode;//解码设备连接服务器的连接模式
			public byte byEncoderChannel;//解码设备连接的服务器的通道号
			public ushort wEncoderPort;//解码设备连接的服务器的端口号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] reservedData;//保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderstate
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderIP;//解码设备连接的服务器IP
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderUser;//解码设备连接的服务器的用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderPasswd;//解码设备连接的服务器的密码
			public byte byEncoderChannel;//解码设备连接的服务器的通道号
			public byte bySendMode;//解码设备连接的服务器的连接模式
			public ushort wEncoderPort;//解码设备连接的服务器的端口号
			public uint dwConnectState;//解码设备连接服务器的状态
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] reservedData;//保留
		}

		/*解码设备控制码定义*/
		public const int NetDecStartdec = 1;
		public const int NetDecStopdec = 2;
		public const int NetDecStopcycle = 3;
		public const int NetDecContinuecycle = 4;

		/*连接的通道配置*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDecchaninfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/* DVR IP地址 */
			public ushort wDVRPort;/* 端口号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			public byte byChannel;/* 通道号 */
			public byte byLinkMode;/* 连接模式 */
			public byte byLinkType;/* 连接类型 0－主码流 1－子码流 */
		}

		/*每个解码通道的配置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecinfo
		{
			public byte byPoolChans;/*每路解码通道上的循环通道数量, 最多4通道 0表示没有解码*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecpoolnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDecchaninfo[] struchanConInfo;
			public byte byEnablePoll;/*是否轮巡 0-否 1-是*/
			public byte byPoolTime;/*轮巡时间 0-保留 1-10秒 2-15秒 3-20秒 4-30秒 5-45秒 6-1分钟 7-2分钟 8-5分钟 */
		}

		/*整个设备解码配置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeccfg
		{
			public uint dwSize;
			public uint dwDecChanNum;/*解码通道的数量*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDecinfo[] struDecInfo;
		}

		//2005-08-01
		/* 解码设备透明通道设置 */
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPortinfo
		{
			public uint dwEnableTransPort;/* 是否启动透明通道 0－不启用 1－启用*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDecoderIP;/* DVR IP地址 */
			public ushort wDecoderPort;/* 端口号 */
			public ushort wDVRTransPort;/* 配置前端DVR是从485/232输出，1表示232串口,2表示485串口 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string cReserve;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPortcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTransparentnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPortinfo[] struTransPortInfo;/* 数组0表示232 数组1表示485 */
		}

		[StructLayout(LayoutKind.Sequential)]               
		public struct Bytime
		{
			public uint dwChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/*请求视频用户名*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			public NetDvrTime struStartTime;/* 按时间回放的开始时间 */
			public NetDvrTime struStopTime;/* 按时间回放的结束时间 */
		}

		/* 控制网络文件回放 */
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPlayremotefile
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDecoderIP;/* DVR IP地址 */
			public ushort wDecoderPort;/* 端口号 */
			public ushort wLoadMode;/* 回放下载模式 1－按名字 2－按时间 */

			[StructLayout(LayoutKind.Explicit)]
			public struct ModeSize
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]             
				public byte[] byFile;/* 回放的文件名 */
				[FieldOffset(0)]
				public Bytime bytime;
			}
		}



		/*当前设备解码连接状态*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDecchanstatus
		{
			public uint dwWorkType;/*工作方式：1：轮巡、2：动态连接解码、3：文件回放下载 4：按时间回放下载*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/*连接的设备ip*/
			public ushort wDVRPort;/*连接端口号*/
			public byte byChannel;/* 通道号 */
			public byte byLinkMode;/* 连接模式 */
			public uint dwLinkType;/*连接类型 0－主码流 1－子码流*/

			[StructLayout(LayoutKind.Explicit)]
			public struct ObjectInfo
			{
				[StructLayout(LayoutKind.Sequential)]
				public struct UserInfo
				{
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
					public byte[] sUserName;/*请求视频用户名*/
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;/* 密码 */
					[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
					public string cReserve;
				}

				[StructLayout(LayoutKind.Sequential)]
				public struct FileInfo
				{
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
					public byte[] fileName;
				}
				[StructLayout(LayoutKind.Sequential)]
				public struct TimeInfo
				{
					public uint dwChannel;
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
					public byte[] sUserName;/*请求视频用户名*/
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;/* 密码 */
					public NetDvrTime struStartTime;/* 按时间回放的开始时间 */
					public NetDvrTime struStopTime;/* 按时间回放的结束时间 */
				}
			}
		}


		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecstatus
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDecchanstatus[] struTransPortInfo;
		}
		/*****************************DS-6001D/F(end)***************************/

		//单字符参数(子结构)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrShowstringinfo
		{
			public ushort wShowString;// 预览的图象上是否显示字符,0-不显示,1-显示 区域大小704*576,单个字符的大小为32*32
			public ushort wStringSize;/* 该行字符的长度，不能大于44个字符 */
			public ushort wShowStringTopLeftX;/* 字符显示位置的x坐标 */
			public ushort wShowStringTopLeftY;/* 字符名称显示位置的y坐标 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 44)]
			public string sString;/* 要显示的字符内容 */
		}

		//叠加字符(9000扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShowstringV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxStringnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShowstringinfo[] struStringInfo;/* 要显示的字符内容 */
		}

		//叠加字符扩展(8条字符)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShowstringEx
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxStringnumEx, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShowstringinfo[] struStringInfo;/* 要显示的字符内容 */
		}

		//叠加字符
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShowstring
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxStringnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShowstringinfo[] struStringInfo;/* 要显示的字符内容 */
		}

		/****************************DS9000新增结构(begin)******************************/
		/*EMAIL参数结构*/
		//与原结构体有差异
		[StructLayout(LayoutKind.Sequential)]
		public struct StruReceiver
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sName;/* 收件人姓名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAddress;/* 收件人地址 */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEmailcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAccount;/* 账号*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailPwdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/*密码 */

			[StructLayout(LayoutKind.Sequential)]
			public struct StruSender
			{
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
				public byte[] sName;/* 发件人姓名 */
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
				public byte[] sAddress;/* 发件人地址 */
			}

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSmtpServer;/* smtp服务器 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPop3Server;/* pop3服务器 */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
			public StruReceiver[] struStringInfo;/* 最多可以设置3个收件人 */

			public byte byAttachment;/* 是否带附件 */
			public byte bySmtpServerVerify;/* 发送服务器要求身份验证 */
			public byte byMailInterval;/* mail interval */
			public byte byEnableSSL;//ssl是否启用9000_1.1
			public ushort wSmtpPort;//gmail的465，普通的为25  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		/*DVR实现巡航数据结构*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruisePara
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CruiseMaxPresetNums, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;/* 预置点号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CruiseMaxPresetNums, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseSpeed;/* 巡航速度 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CruiseMaxPresetNums, ArraySubType = UnmanagedType.U2)]
			public ushort[] wDwellTime;/* 停留时间 */
			public byte byEnableThisCruise;/* 是否启用 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}
		/****************************DS9000新增结构(end)******************************/     
		//时间点
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimepoint
		{
			public uint dwMonth;//月 0-11表示1-12个月
			public uint dwWeekNo;//第几周 0－第1周 1－第2周 2－第3周 3－第4周 4－最后一周
			public uint dwWeekDate;//星期几 0－星期日 1－星期一 2－星期二 3－星期三 4－星期四 5－星期五 6－星期六
			public uint dwHour;//小时	开始时间0－23 结束时间1－23
			public uint dwMin;//分	0－59
		}

		//夏令时参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrZoneanddst
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留
			public uint dwEnableDST;//是否启用夏时制 0－不启用 1－启用
			public byte byDSTBias;//夏令时偏移值，30min, 60min, 90min, 120min, 以分钟计，传递原始数值
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrTimepoint struBeginPoint;//夏时制开始时间
			public NetDvrTimepoint struEndPoint;//夏时制停止时间
		}

		//图片质量
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegpara
		{
			/*注意：当图像压缩分辨率为VGA时，支持0=CIF, 1=QCIF, 2=D1抓图，
			当分辨率为3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
			仅支持当前分辨率的抓图*/
			public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
			public ushort wPicQuality;/* 图片质量系数 0-最好 1-较好 2-一般 */
		}

		/* aux video out parameter */
		//辅助输出参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAuxoutcfg
		{
			public uint dwSize;
			public uint dwAlarmOutChan;/* 选择报警弹出大报警通道切换时间：1画面的输出通道: 0:主输出/1:辅1/2:辅2/3:辅3/4:辅4 */
			public uint dwAlarmChanSwitchTime;/* :1秒 - 10:10秒 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAuxout, ArraySubType = UnmanagedType.U4)]
			public uint[] dwAuxSwitchTime;/* 辅助输出切换时间: 0-不切换,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAuxout * MaxWindow, ArraySubType = UnmanagedType.I1)]
			public byte[] byAuxOrder;/* 辅助输出预览顺序, 0xff表示相应的窗口不预览 */
		}

		//ntp
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNtppara
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
			public ushort wInterval;/* adjust time interval(hours) */
			public byte byEnableNTP;/* enable NPT client 0-no，1-yes*/
			public byte cTimeDifferenceH;/* 与国际标准时间的 小时偏移-12 ... +13 */
			public byte cTimeDifferenceM;/* 与国际标准时间的 分钟偏移0, 30, 45*/
			public byte res1;
			public ushort wNtpPort; /* ntp server port 9000新增 设备默认为123*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res2;
		}

		//ddns
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnspara
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* DDNS账号用户名/密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName; /* 域名 */
			public byte byEnableDDNS;/*是否应用 0-否，1-是*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnsparaEx
		{
			public byte byHostIndex;/* 0-Hikvision DNS 1－Dyndns 2－PeanutHull(花生壳)*/
			public byte byEnableDDNS;/*是否应用DDNS 0-否，1-是*/
			public ushort wDDNSPort;/* DDNS端口号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* DDNS用户名*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* DDNS密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;/* 设备配备的域名地址 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sServerName;/* DDNS 对应的服务器地址，可以是IP地址或域名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//9000扩展
		[StructLayout(LayoutKind.Sequential)]
		public struct StruDdns
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* DDNS账号用户名*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;/* 设备配备的域名地址 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sServerName;/* DDNS协议对应的服务器地址，可以是IP地址或域名 */
			public ushort wDDNSPort;/* 端口号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnsparaV30
		{
			public byte byEnableDDNS;
			public byte byHostIndex;/* 0-Hikvision DNS(保留) 1－Dyndns 2－PeanutHull(花生壳)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDdnsNums, ArraySubType = UnmanagedType.Struct)]
			public StruDdns[] StruDdnses;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//email
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEmailpara
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* 邮件账号/密码 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sSmtpServer;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sPop3Server;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sMailAddr;/* email */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sEventMailAddr1;/* 上传报警/异常等的email */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sEventMailAddr2;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//网络参数配置
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrNetappcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDNSIp; /* DNS服务器地址 */
			public NetDvrNtppara struNtpClientParam;/* NTP参数 */
			public NetDvrDdnspara struDDNSClientParam;/* DDNS参数 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
			public byte[] res;/* 保留 */
		}

		//nfs结构配置
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrSingleNfs
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sNfsHostIPAddr;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PathnameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNfsDirectory;

			public void Init()
			{
				sNfsDirectory = new byte[PathnameLen];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNfscfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNfsDisk, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleNfs[] struNfsDiskParam;

			public void Init()
			{
				struNfsDiskParam = new NetDvrSingleNfs[MaxNfsDisk];

				for (var i = 0; i < MaxNfsDisk; i++)
				{
					struNfsDiskParam[i].Init();
				}
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIscsiCfg
		{   
			public uint dwSize;                   // 结构大小
			public ushort wVrmPort;                  // VRM 监听端口
			public byte byEnable;                  // 是否启用 ISCSI存储
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                 // 保留字节
			public NetDvrIpaddr struVrmAddr;          // VRM ip地址 16位
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string chNvtIndexCode;        //nvt index Code 
		}

		//巡航点配置(HIK IP快球专用)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruisePoint
		{
			public byte PresetNum;//预置点
			public byte Dwell;//停留时间
			public byte Speed;//速度
			public byte Reserve;//保留

			public void Init()
			{
				PresetNum = 0;
				Dwell = 0;
				Speed = 0;
				Reserve = 0;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruiseRet
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCruisePoint[] struCruisePoint;//最大支持32个巡航点

			public void Init()
			{
				struCruisePoint = new NetDvrCruisePoint[32];
				for (var i = 0; i < 32; i++)
				{
					struCruisePoint[i].Init();
				}
			}
		}

		/************************************多路解码器(begin)***************************************/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrNetcfgOther
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFirstDNSIP;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sSecondDNSIP;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sRes;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecinfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/* DVR IP地址 */
			public ushort wDVRPort;/* 端口号 */
			public byte byChannel;/* 通道号 */
			public byte byTransProtocol;/* 传输协议类型 0-TCP, 1-UDP */
			public byte byTransMode;/* 传输码流模式 0－主码流 1－子码流*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 监控主机登陆帐号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 监控主机密码 */
		}

		//启动/停止动态解码
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDynamicDec
		{
			public uint dwSize;
			public NetDvrMatrixDecinfo struDecChanInfo;/* 动态解码通道信息 */
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecChanStatus
		{
			public uint dwSize;
			public uint dwIsLinked;/* 解码通道状态 0－休眠 1－正在连接 2－已连接 3-正在解码 */
			public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string cRes;/* 保留 */
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecChanInfo
		{
			public uint dwSize;
			public NetDvrMatrixDecinfo struDecChanInfo;/* 解码通道信息 */
			public uint dwDecState;/* 0-动态解码 1－循环解码 2－按时间回放 3－按文件回放 */
			public NetDvrTime StartTime;/* 按时间回放开始时间 */
			public NetDvrTime StopTime;/* 按时间回放停止时间 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;/* 按文件回放文件名 */
		}

		//连接的通道配置 2007-11-05
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecchaninfo
		{
			public uint dwEnable;/* 是否启用 0－否 1－启用*/
			public NetDvrMatrixDecinfo struDecChanInfo;/* 轮循解码通道信息 */
		}

		//2007-11-05 新增每个解码通道的配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixLoopDecinfo
		{
			public uint dwSize;
			public uint dwPoolTime;/*轮巡时间 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChan, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixDecchaninfo[] struchanConInfo;
		}

		//2007-12-22
		[StructLayout(LayoutKind.Sequential)]
		public struct TtyConfig
		{
			public byte baudrate;/* 波特率 */
			public byte databits;/* 数据位 */
			public byte stopbits;/* 停止位 */
			public byte parity;/* 奇偶校验位 */
			public byte flowcontrol;/* 流控 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixTranChanInfo
		{
			public byte byTranChanEnable;/* 当前透明通道是否打开 0：关闭 1：打开 */
			/*
			 *	多路解码器本地有1个485串口，1个232串口都可以作为透明通道,设备号分配如下：
			 *	0 RS485
			 *	1 RS232 Console
			 */
			public byte byLocalSerialDevice;/* Local serial device */
			/*
			 *	远程串口输出还是两个,一个RS232，一个RS485
			 *	1表示232串口
			 *	2表示485串口
			 */
			public byte byRemoteSerialDevice;/* Remote output serial device */
			public byte res1;/* 保留 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteDevIP;/* Remote Device IP */
			public ushort wRemoteDevPort;/* Remote Net Communication Port */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res2;/* 保留 */
			public TtyConfig RemoteSerialDevCfg;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTranChanConfig
		{
			public uint dwSize;
			public byte by232IsDualChan;/* 设置哪路232透明通道是全双工的 取值1到MAX_SERIAL_NUM */
			public byte by485IsDualChan;/* 设置哪路485透明通道是全双工的 取值1到MAX_SERIAL_NUM */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res;/* 保留 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSerialNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixTranChanInfo[] struTranInfo;/*同时支持建立MAX_SERIAL_NUM个透明通道*/
		}

		//2007-12-24 Merry Christmas Eve...
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecRemotePlay
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/* DVR IP地址 */
			public ushort wDVRPort;/* 端口号 */
			public byte byChannel;/* 通道号 */
			public byte byReserve;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* 密码 */
			public uint dwPlayMode;/* 0－按文件 1－按时间*/
			public NetDvrTime StartTime;
			public NetDvrTime StopTime;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecRemotePlayControl
		{
			public uint dwSize;
			public uint dwPlayCmd;/* 播放命令 见文件播放命令*/
			public uint dwCmdParam;/* 播放命令参数 */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecRemotePlayStatus
		{
			public uint dwSize;
			public uint dwCurMediaFileLen;/* 当前播放的媒体文件长度 */
			public uint dwCurMediaFilePosition;/* 当前播放文件的播放位置 */
			public uint dwCurMediaFileDuration;/* 当前播放文件的总时间 */
			public uint dwCurPlayTime;/* 当前已经播放的时间 */
			public uint dwCurMediaFIleFrames;/* 当前播放文件的总帧数 */
			public uint dwCurDataType;/* 当前传输的数据类型，19-文件头，20-流数据， 21-播放结束标志 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//2009-4-11 added by likui 多路解码器new
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixPassivemode
		{
			public ushort wTransProtol;//传输协议，0-TCP, 1-UDP, 2-MCAST
			public ushort wPassivePort;//UDP端口, TCP时默认
			// char	sMcastIP[16];		//TCP,UDP时无效, MCAST时为多播地址
			public NetDvrIpaddr struMcastIP;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}       

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTranChanInfoV30
		{
			public byte byTranChanEnable;/* 当前透明通道是否打开 0：关闭 1：打开 */
			/*
			 *	多路解码器本地有1个485串口，1个232串口都可以作为透明通道,设备号分配如下：
			 *	0 RS485
			 *	1 RS232 Console
			 */
			public byte byLocalSerialDevice;/* Local serial device */
			/*
			 *	远程串口输出还是两个,一个RS232，一个RS485
			 *	1表示232串口
			 *	2表示485串口
			 */
			public byte byRemoteSerialDevice;/* Remote output serial device */
			public byte byRes1;/* 保留 */
			public NetDvrIpaddr struRemoteDevIP;/* Remote Device IP */
			public ushort wRemoteDevPort;/* Remote Net Communication Port */
			public byte byIsEstablished;/* 透明通道建立成功标志，0-没有成功，1-建立成功 */
			public byte byRes2;/* 保留 */
			public TtyConfig RemoteSerialDevCfg;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUsername;/* 32BYTES */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword;/* 16BYTES */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTranChanConfigV30
		{
			public uint dwSize;
			public byte by232IsDualChan;/* 设置哪路232透明通道是全双工的 取值1到MAX_SERIAL_NUM */
			public byte by485IsDualChan;/* 设置哪路485透明通道是全双工的 取值1到MAX_SERIAL_NUM */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] vyRes;/* 保留 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSerialNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixTranChanInfo[] struTranInfo;/*同时支持建立MAX_SERIAL_NUM个透明通道*/
		}        

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixChanInfoV30
		{
			public uint dwEnable;/* 是否启用 0－否 1－启用*/
			public NetDvrStreamMediaServerCfg streamMediaServerCfg;
			public NetDvrDevChanInfo struDevChanInfo;/* 轮循解码通道信息 */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixLoopDecinfoV30
		{
			public uint dwSize;
			public uint dwPoolTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChanV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanInfoV30[] struchanConInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecChanInfoV30
		{
			public uint dwSize;
			public NetDvrStreamMediaServerCfg streamMediaServerCfg;/*流媒体服务器配置*/
			public NetDvrDevChanInfo struDevChanInfo;/* 解码通道信息 */
			public uint dwDecState;/* 0-动态解码 1－循环解码 2－按时间回放 3－按文件回放 */
			public NetDvrTime StartTime;/* 按时间回放开始时间 */
			public NetDvrTime StopTime;/* 按时间回放停止时间 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;/* 按文件回放文件名 */
			public uint dwGetStreamMode;/*取流模式:1-主动，2-被动*/
			public NetDvrMatrixPassivemode struPassiveMode;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int MaxResolutionnum = 64; //支持的最大分辨率数目

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixAbility
		{
			public uint dwSize;
			public byte byDecNums;
			public byte byStartChan;
			public byte byVGANums;
			public byte byBNCNums;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8*12, ArraySubType = UnmanagedType.I1)]
			public byte[] byVGAWindowMode;/*VGA支持的窗口模式*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byBNCWindowMode;/*BNC支持的窗口模式*/
			public byte byDspNums;   
			public byte byHDMINums;//HDMI显示通道个数（从25开始）
			public byte byDVINums;//DVI显示通道个数（从29开始）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxResolutionnum, ArraySubType = UnmanagedType.I1)]
			public byte[] bySupportResolution;//按照上面的枚举定义,一个字节代表一个分辨率是//否支持，1：支持，0：不支持
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
			public byte[] byHDMIWindowMode;//HDMI支持的窗口模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
			public byte[] byDVIWindowMode;//DVI支持的窗口模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//上传logo结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispLogocfg
		{
			public uint dwCorordinateX;//图片显示区域X坐标
			public uint dwCorordinateY;//图片显示区域Y坐标
			public ushort wPicWidth; //图片宽
			public ushort wPicHeight; //图片高
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byFlash;//是否闪烁1-闪烁，0-不闪烁
			public byte byTranslucent;//是否半透明1-半透明，0-不半透明
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//保留
			public uint dwLogoSize;//LOGO大小，包括BMP的文件头
		}

		/*编码类型*/
		public const int NetDvrEncoderUnkown = 0;/*未知编码格式*/
		public const int NetDvrEncoderH264 = 1;/*HIK 264*/
		public const int NetDvrEncoderS264 = 2;/*Standard H264*/
		public const int NetDvrEncoderMpeg4 = 3;/*MPEG4*/
		public const int NetDvrOriginalstream = 4;/*Original Stream*/
		public const int NetDvrPicture = 5;//*Picture*/
		public const int NetDvrEncoderMjpeg = 6;
		public const int NetDvrEconderMpeg2 = 7;
		/* 打包格式 */
		public const int NetDvrStreamTypeUnkown = 0;/*未知打包格式*/
		public const int NetDvrStreamTypeHikprivt = 1; /*海康自定义打包格式*/
		public const int NetDvrStreamTypeTs = 7;/* TS打包 */
		public const int NetDvrStreamTypePs = 8;/* PS打包 */
		public const int NetDvrStreamTypeRtp = 9;/* RTP打包 */

		/*解码通道状态*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixChanStatus
		{
			public byte byDecodeStatus;/*当前状态:0:未启动，1：启动解码*/
			public byte byStreamType;/*码流类型*/
			public byte byPacketType;/*打包方式*/
			public byte byRecvBufUsage;/*接收缓冲使用率*/
			public byte byDecBufUsage;/*解码缓冲使用率*/
			public byte byFpsDecV;/*视频解码帧率*/
			public byte byFpsDecA;/*音频解码帧率*/
			public byte byCpuLoad;/*DSP CPU使用率*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwDecodedV;/*解码的视频帧*/
			public uint dwDecodedA;/*解码的音频帧*/
			public ushort wImgW;/*解码器当前的图像大小,宽*/
			public ushort wImgH; //高
			public byte byVideoFormat;/*视频制式:0-NON,NTSC--1,PAL--2*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public uint dwDecChan; /*获取全部解码通道状态时有效，设置时可填0*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		/*显示通道状态*/
		public const int NetDvrMaxDispregion = 16;         /*每个显示通道最多可以显示的窗口*/
		//VGA分辨率，目前能用的是：VgaThs8200ModeXga60Hz、VgaThs8200ModeSxga60Hz、
		//
		public enum VgaMode
		{
			/*VGA*/
			VgaNotAvaliable,
			VgaThs8200ModeSvga60Hz,    //(800*600)
			VgaThs8200ModeSvga75Hz,    //(800*600)
			VgaThs8200ModeXga60Hz,     //(1024*768)
			VgaThs8200ModeXga75Hz,     //(1024*768)
			VgaThs8200ModeSxga60Hz,    //(1280*1024)
			VgaThs8200Mode720P60Hz,    //(1280*720)
			VgaThs8200Mode1080I60Hz,   //(1920*1080)
			VgaThs8200Mode1080P30Hz,   //(1920*1080)
			VgaThs8200ModeUxga30Hz,    //(1600*1200)
			/*HDMI*/
			HdmiSii9134ModeXga60Hz,	   //(1024*768)
			HdmiSii9134ModeSxga60Hz,   //(1280*1024)
			HdmiSii9134ModeSxga260Hz,  //(1280*960)
			HdmiSii9134Mode720P60Hz,   //(1280*720)	
			HdmiSii9134Mode720P50Hz,   //(1280*720)		
			HdmiSii9134Mode1080I60Hz,  //(1920*1080)
			HdmiSii9134Mode1080I50Hz,  //(1920*1080)	
			HdmiSii9134Mode1080P25Hz,  //(1920*1080)
			HdmiSii9134Mode1080P30Hz,  //(1920*1080)
			HdmiSii9134Mode1080P50Hz,  //(1920*1080)
			HdmiSii9134Mode1080P60Hz,  //(1920*1080)
			HdmiSii9134ModeUxga60Hz,   //(1600*1200)
			/*DVI*/
			DviSii9134ModeXga60Hz,	   //(1024*768)
			DviSii9134ModeSxga60Hz,	   //(1280*1024)
			DviSii9134ModeSxga260Hz,   //(1280*960)
			DviSii9134Mode720P60Hz,	   //(1280*720)	
			DviSii9134Mode720P50Hz,    //(1280*720)		
			DviSii9134Mode1080I60Hz,   //(1920*1080)
			DviSii9134Mode1080I50Hz,   //(1920*1080)
			DviSii9134Mode1080P25Hz,   //(1920*1080)
			DviSii9134Mode1080P30Hz,   //(1920*1080)
			DviSii9134Mode1080P50Hz,   //(1920*1080)
			DviSii9134Mode1080P60Hz,   //(1920*1080)
			DviSii9134ModeUxga60Hz,     //(1600*1200)
			VgaDecsvrModeSxga260Hz,
			HdmiDecsvrMode1080P24Hz,
			DviDecsvrMode1080P24Hz,
			YPbPrDecsvrMode720P60Hz,
			YPbPrDecsvrMode1080I60Hz
		}

		//低帧率定义
		public const int LowDecFps12 = 51;
		public const int LowDecFps14 = 52;
		public const int LowDecFps18 = 53;
		public const int LowDecFps116 = 54;

		/*视频制式标准*/
		public enum VideoStandard
		{
			VsNon = 0,
			VsNtsc = 1,
			VsPal = 2,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionVideoplatform
		{
			/*各个子窗口对应解码通道所对应的解码子系统的槽位号(对于视频综合平台中解码子系统有效)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecoderId;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionNotvideoplatform
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVgaDispChanCfg
		{
			public uint dwSize;
			public byte byAudio;/*音频是否开启,0-否，1-是*/
			public byte byAudioWindowIdx;/*音频开启子窗口*/
			public byte byVgaResolution;/*VGA的分辨率*/
			public byte byVedioFormat;/*视频制式，1:NTSC,2:PAL,0-NON*/
			public uint dwWindowMode;/*画面模式，从能力集里获取，目前支持1,2,4,9,16*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
			public byte byEnlargeStatus;          /*是否处于放大状态，0：不放大，1：放大*/
			public byte byEnlargeSubWindowIndex;//放大的子窗口号
			[StructLayout(LayoutKind.Explicit)]
			public struct StruDiff
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
				 public byte[] byRes;

				[FieldOffset(0)]
				public UnionVideoplatform struVideoPlatform;

				[FieldOffset(0)]
				public UnionNotvideoplatform struNotVideoPlatform;
			}
			public byte byUnionType;/*区分共用体，0-视频综合平台内部解码器显示通道配置，1-其他解码器显示通道配置*/
			public byte byScale; /*显示模式，0---真实显示，1---缩放显示( 针对BNC )*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispChanStatus
		{
			public byte byDispStatus;/*显示状态：0：未显示，1：启动显示*/
			public byte byBVGA; /*VGA/BNC*/
			public byte byVideoFormat;/*视频制式:1:NTSC,2:PAL,0-NON*/
			public byte byWindowMode;/*当前画面模式*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NetDvrMaxDispregion, ArraySubType = UnmanagedType.I1)]
			public byte[] byFpsDisp;/*每个子画面的显示帧率*/
			public byte byScreenMode;			//屏幕模式0-普通 1-大屏
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public const int MaxDecodechannum = 32;//多路解码器最大解码通道数
		public const int MaxDispchannum = 24;//多路解码器最大显示通道数

		/*解码器设备状态*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderWorkStatus
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecodechannum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanStatus[] struDecChanStatus;/*解码通道状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDispchannum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDispChanStatus[] struDispChanStatus;/*显示通道状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogAlarmin, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatus;/*报警输入状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogAlarmout, ArraySubType = UnmanagedType.I1)]
			public byte[] byAalarmOutStatus;/*报警输出状态*/
			public byte byAudioInChanStatus;/*语音对讲状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//2009-12-1 增加被动解码播放控制
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPassivedecodeControl
		{
			public uint dwSize;
			public uint dwPlayCmd;		/* 播放命令 见文件播放命令*/
			public uint dwCmdParam;		/* 播放命令参数 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//Reverse
		}

		public const int PassiveDecPause = 1;	/*被动解码暂停(仅文件流有效)*/
		public const int PassiveDecResume = 2;	/*恢复被动解码(仅文件流有效)*/
		public const int PassiveDecFast = 3;   /*快速被动解码(仅文件流有效)*/
		public const int PassiveDecSlow = 4;   /*慢速被动解码(仅文件流有效)*/
		public const int PassiveDecNormal = 5;   /*正常被动解码(仅文件流有效)*/
		public const int PassiveDecOnebyone =	6;  /*被动解码单帧播放(保留)*/
		public const int PassiveDecAudioOn = 7;   /*音频开启*/
		public const int PassiveDecAudioOff = 8; 	 /*音频关闭*/
		public const int PassiveDecResetbuffer = 9;    /*清空缓冲区*/

		//2009-12-16 增加控制解码器解码通道缩放
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecchanControl
		{        
			public uint dwSize;
			public byte byDecChanScaleStatus;/*解码通道显示缩放控制,1表示缩放显示，0表示真实显示*/
			public byte byDecodeDelay;//解码延时，0-默认，1-实时性好，2-实时性较好，3-实时性中，流畅性中，4-流畅性较好，5-流畅性好，0xff-自动调整   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}
		/************************************多路解码器(end)***************************************/

		/************************************视频综合平台(begin)***************************************/
		public const int MaxSubsystemNum = 80;   //一个矩阵系统中最多子系统数量
		public const int MaxSubsystemNumV40 = 120;   //一个矩阵系统中最多子系统数量
		public const int MaxSeriallen = 36;  //最大序列号长度
		public const int MaxLoopplannum = 16;  //最大计划切换组
		public const int DecodeTimesegment = 4;     //计划解码每天时间段数

		public const int MaxDomainName = 64;  /* 最大域名长度 */
		public const int MaxDisknumV30 = 33; //9000设备最大硬盘数/* 最多33个硬盘(包括16个内置SATA硬盘、1个eSATA硬盘和16个NFS盘) */
		public const int MaxDays = 7;       //每周天数
		public const int MaxDispnumV41 = 32;
		public const int MaxWindowsNum = 12;
		public const int MaxVoutnum = 32;
		public const int MaxSupportRes = 32;
		public const int MaxBigscreennum = 100;

		public const int VideoplatformAbility = 0x210; //视频综合平台能力集
		public const int MatrixdecoderAbilityV41 = 0x260; //解码器能力集

		public const int NetDvrMatrixBigscreencfgGet = 1140;//获取大屏拼接参数        

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSubsysteminfo
		{
			public byte bySubSystemType;//子系统类型，1-解码用子系统，2-编码用子系统，0-NULL（此参数只能获取）
			public byte byChan;//子系统通道数（此参数只能获取）
			public byte byLoginType;//注册类型，1-直连，2-DNS，3-花生壳
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struSubSystemIP;/*IP地址（可修改）*/
			public ushort wSubSystemPort;//子系统端口号（可修改）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrIpaddr struSubSystemIPMask;//子网掩码
			public NetDvrIpaddr struGatewayIpAddr;	/* 网关地址*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* 用户名 （此参数只能获取）*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/*密码（此参数只能获取）*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxDomainName)]
			public string sDomainName;//域名(可修改)
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxDomainName)]
			public string sDnsAddress;/*DNS域名或IP地址*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//序列号（此参数只能获取）
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAllsubsysteminfo
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSubsystemNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSubsysteminfo[] struSubSystemInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLoopplanSubcfg
		{
			public uint dwSize;
			public uint dwPoolTime; /*轮询间隔，单位：秒*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChanV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanInfoV30[] struChanConInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]            
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmmodecfg
		{
			public uint dwSize;
			public byte byAlarmMode;//报警触发类型，1-轮询，2-保持 
			public ushort wLoopTime;//轮询时间, 单位：秒 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCodesplitterinfo
		{
			public uint dwSize;
			public NetDvrIpaddr struIP;/*码分器IP地址*/
			public ushort wPort;//码分器端口号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]             
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)] 
			public byte[] sUserName;/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)] 
			public byte[] sPassword;/*密码 */
			public byte byChan;//码分器485号
			public byte by485Port;//485口地址      
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAssociatecfg
		{
			public byte byAssociateType;//关联类型，1-报警
			public ushort wAlarmDelay;//报警延时，0－5秒；1－10秒；2－30秒；3－1分钟；4－2分钟；5－5分钟；6－10分钟；
			public byte byAlarmNum;//报警号，具体的值由应用赋，相同的报警赋相同的值
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDynamicdecode
		{
			public uint dwSize;
			public NetDvrAssociatecfg struAssociateCfg;//触发动态解码关联结构
			public NetDvrPuStreamCfg struPuStreamCfg;//动态解码结构
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodesched
		{
			public NetDvrSchedtime struSchedTime;
			public byte byDecodeType;/*0-无，1-轮询解码，2-动态解码*/
			public byte byLoopGroup;//轮询组号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
			public NetDvrPuStreamCfg struDynamicDec;//动态解码
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlandecode
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * DecodeTimesegment, ArraySubType = UnmanagedType.I1)] 
			public NetDvrDecodesched[] struDecodeSched;//周一作为开始，和9000一致
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
			public byte[] byres;
		}
		/************************************视频综合平台(end)***************************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoplatformAbility
		{
			public uint dwSize;
			public byte byCodeSubSystemNums;//编码子系统数量
			public byte byDecodeSubSystemNums;//解码子系统数量
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byWindowMode; /*显示通道支持的窗口模式*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSubsystemAbility
		{
			/*子系统类型，1-解码用子系统，2-编码用子系统，3-级联输出子系统，4-级联输入子系统，5-码分器子系统，6-报警主机子系统，7-智能子系统，8-V6解码子系统，9-V6子系统，0-NULL（此参数只能获取）*/
			public byte bySubSystemType;
			public byte byChanNum;//子系统通道数
			public byte byStartChan;//子系统起始通道数
			public byte bySlotNum;//槽位号 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public StruDecoderSystemAbility _struAbility;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct StruDecoderSystemAbility
		{
			public byte byVGANums;//VGA显示通道个数（从1开始）
			public byte byBNCNums;//BNC显示通道个数（从9开始）
			public byte byHDMINums;//HDMI显示通道个数（从25开始）
			public byte byDVINums;//DVI显示通道个数（从29开始）

			public byte byLayerNums;//大屏拼接中，做主屏时所支持图层数
			public byte bySpartan;//畅显功能，0-不支持，1-支持
			public byte byDecType; //解码子系统类型，0-普通型,1-增强型(普通型分屏时前4窗口需使用自身资源，增强型无此限制，增强型最多可被其他子系统借16路D1解码资源
			//增强型被大屏关联为子屏后资源可被借用，普通型则不能被借用)
			public byte byOutputSwitch;//是否支持HDMI/DVI互相切换，0-不支持，1-支持
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byDecoderType; //解码板类型  0-普通解码板 1-万能解码板
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct StruAbility
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			//  [FieldOffset(0)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoplatformAbilityV40
		{
			public uint dwSize;
			public byte byCodeSubSystemNums;
			public byte byDecodeSubSystemNums;//解码子系统数量
			public byte bySupportNat;//是否支持NAT，0-不支持，1-支持
			public byte byInputSubSystemNums;//级联输入子系统数量
			public byte byOutputSubSystemNums;//级联输出子系统数量
			public byte byCodeSpitterSubSystemNums;//码分子系统数量
			public byte byAlarmHostSubSystemNums;//报警子系统数量
			public byte bySupportBigScreenNum;//所支持最多组成大屏的个数
			public byte byVCASubSystemNums;//智能子系统数量
			public byte byV6SubSystemNums;//V6子系统数量
			public byte byV6DecoderSubSystemNums;//V6解码子系统数量
			public byte bySupportBigScreenX;/*大屏拼接的模式：m×n*/
			public byte bySupportBigScreenY;
			public byte bySupportSceneNums;//支持场景模式的个数
			public byte byVcaSupportChanMode;//智能支持的通道使用模式，0-使用解码通道，1-使用显示通道及子通道号
			public byte bySupportScreenNums;//所支持的大屏的屏幕最大个数
			public byte bySupportLayerNums;//所支持的图层数，0xff-无效
			public byte byNotSupportPreview;//是否支持预览,1-不支持，0-支持
			public byte byNotSupportStorage;//是否支持存储,1-不支持，0-支持
			public byte byUploadLogoMode;//上传logo模式，0-上传给解码通道，1-上传给显示通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSubsystemNumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSubsystemAbility[] struSubSystemAbility;
			public byte by485Nums;//485串口个数
			public byte by232Nums;//232串口个数
			public byte bySerieStartChan;//起始通道
			public byte byScreenMode;//大屏模式，0-主屏由客户端分配，1-主屏由设备端分配
			public byte byDevVersion;//设备版本，0-B10/B11/B12，1-B20
			public byte bySupportBaseMapNums;//所支持的底图数，底图号从1开始
			public ushort wBaseLengthX;//每个屏大小的基准值，B20使用
			public ushort wBaseLengthY;
			public byte bySupportPictureTrans;  //是否支持图片回显，0-不支持，1-支持	
			public byte bySupportPreAllocDec;   //是否支持智能解码资源预分配，0-不支持，1-支持
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}       

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSinglescreencfg
		{
			public byte byScreenSeq;//屏幕序号，0xff表示不用此屏,64-T解码器第一个表示主屏
			public byte bySubSystemNum;//解码子系统槽位号,解码器此值没有用
			public byte byDispNum;//解码子系统上对应显示通道号，64-T解码器中该值表示解码器的显示通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBigscreencfg
		{
			public uint dwSize;
			public byte byEnable;//大屏拼接使能，0-不使能，1-使能
			public byte byModeX;/*大屏拼接模式*/
			public byte byModeY;
			public byte byMainDecodeSystem;//综合平台的解码板中该值表示主屏槽位号，64-T解码器中该值表示解码通道号
			public byte byMainDecoderDispChan;//主屏所用显示通道号，1.1netra版本新增，netra解码器有两个显示通道，都能够作为主屏。64-T中该值无效
			public byte byVideoStandard;      //大屏每个子屏制式相同 1:NTSC,2:PAL
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwResolution;         //大屏每个子屏分辨率相同
			//大屏拼接从屏幕信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxBigscreennum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSinglescreencfg[] struFollowSingleScreen;
			//起始坐标必须为基准坐标的整数倍
			public ushort wBigScreenX; //大屏在电视墙中起始X坐标
			public ushort wBigScreenY; //大屏在电视墙中起始Y坐标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public void Init()
			{
				byRes1 = new byte[2];
				struFollowSingleScreen = new NetDvrSinglescreencfg[MaxBigscreennum];
				byRes2 = new byte[12];
			}
		}       

		/************************************视频综合平台(end)***************************************/
		
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrEmailcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sUserName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sPassWord;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sFromName;/* Sender *///字符串中的第一个字符和最后一个字符不能是"@",并且字符串中要有"@"字符
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
			public string sFromAddr;/* Sender address */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sToName1;/* Receiver1 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sToName2;/* Receiver2 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
			public string sToAddr1;/* Receiver address1 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
			public string sToAddr2;/* Receiver address2 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sEmailServer;/* Email server address */
			public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTP…*/
			public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
			public byte byAttachment;/* enable attachment */
			public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgNew
		{
			public uint dwSize;
			public NetDvrCompressionInfoEx struLowCompression;//定时录像
			public NetDvrCompressionInfoEx struEventCompression;//事件触发录像
		}

		//球机位置信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzpos
		{
			public ushort wAction;//获取时该字段无效
			public ushort wPanPos;//水平参数
			public ushort wTiltPos;//垂直参数
			public ushort wZoomPos;//变倍参数
		}

		//球机范围信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzscope
		{
			public ushort wPanPosMin;//水平参数min
			public ushort wPanPosMax;//水平参数max
			public ushort wTiltPosMin;//垂直参数min
			public ushort wTiltPosMax;//垂直参数max
			public ushort wZoomPosMin;//变倍参数min
			public ushort wZoomPosMax;//变倍参数max
		}

		//rtsp配置 ipcamera专用
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRtspcfg
		{
			public uint dwSize;//长度
			public ushort wPort;//rtsp服务器侦听端口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
			public byte[] byReserve;//预留
		}

		/********************************接口参数结构(begin)*********************************/

		//NET_DVR_Login()参数结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeviceinfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//序列号
			public byte byAlarmInPortNum;//DVR报警输入个数
			public byte byAlarmOutPortNum;//DVR报警输出个数
			public byte byDiskNum;//DVR硬盘个数
			public byte byDVRType;//DVR类型, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;//DVR 通道个数
			public byte byStartChan;//起始通道号,例如DVS-1,DVR - 1
		}

		//NET_DVR_Login_V30()参数结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeviceinfoV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;  //序列号
			public byte byAlarmInPortNum;		        //报警输入个数
			public byte byAlarmOutPortNum;		        //报警输出个数
			public byte byDiskNum;				    //硬盘个数
			public byte byDVRType;				    //设备类型, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;				    //模拟通道个数
			public byte byStartChan;			        //起始通道号,例如DVS-1,DVR - 1
			public byte byAudioChanNum;                //语音通道数
			public byte byIPChanNum;					//最大数字通道个数，低位  
			public byte byZeroChanNum;			//零通道编码个数 //2010-01-16
			public byte byMainProto;			//主码流传输协议类型 0-private, 1-rtsp,2-同时支持private和rtsp
			public byte bySubProto;				//子码流传输协议类型0-private, 1-rtsp,2-同时支持private和rtsp
			public byte bySupport;        //能力，位与结果为0表示不支持，1表示支持，
			//bySupport & 0x1, 表示是否支持智能搜索
			//bySupport & 0x2, 表示是否支持备份
			//bySupport & 0x4, 表示是否支持压缩参数能力获取
			//bySupport & 0x8, 表示是否支持多网卡
			//bySupport & 0x10, 表示支持远程SADP
			//bySupport & 0x20, 表示支持Raid卡功能
			//bySupport & 0x40, 表示支持IPSAN 目录查找
			//bySupport & 0x80, 表示支持rtp over rtsp
			public byte bySupport1;        // 能力集扩充，位与结果为0表示不支持，1表示支持
			//bySupport1 & 0x1, 表示是否支持snmp v30
			//bySupport1 & 0x2, 支持区分回放和下载
			//bySupport1 & 0x4, 是否支持布防优先级	
			//bySupport1 & 0x8, 智能设备是否支持布防时间段扩展
			//bySupport1 & 0x10, 表示是否支持多磁盘数（超过33个）
			//bySupport1 & 0x20, 表示是否支持rtsp over http	
			//bySupport1 & 0x80, 表示是否支持车牌新报警信息2012-9-28, 且还表示是否支持NET_DVR_IPPARACFG_V40结构体
			public byte bySupport2; /*能力，位与结果为0表示不支持，非0表示支持							
							bySupport2 & 0x1, 表示解码器是否支持通过URL取流解码
							bySupport2 & 0x2,  表示支持FTPV40
							bySupport2 & 0x4,  表示支持ANR
							bySupport2 & 0x8,  表示支持CCD的通道参数配置
							bySupport2 & 0x10,  表示支持布防报警回传信息（仅支持抓拍机报警 新老报警结构）
							bySupport2 & 0x20,  表示是否支持单独获取设备状态子项
							bySupport2 & 0x40,  表示是否是码流加密设备*/
			public ushort wDevType;              //设备型号
			public byte bySupport3; //能力集扩展，位与结果为0表示不支持，1表示支持
							//bySupport3 & 0x1, 表示是否多码流
							// bySupport3 & 0x4 表示支持按组配置， 具体包含 通道图像参数、报警输入参数、IP报警输入、输出接入参数、
							// 用户参数、设备工作状态、JPEG抓图、定时和时间抓图、硬盘盘组管理 
							//bySupport3 & 0x8为1 表示支持使用TCP预览、UDP预览、多播预览中的"延时预览"字段来请求延时预览（后续都将使用这种方式请求延时预览）。而当bySupport3 & 0x8为0时，将使用 "私有延时预览"协议。
							//bySupport3 & 0x10 表示支持"获取报警主机主要状态（V40）"。
							//bySupport3 & 0x20 表示是否支持通过DDNS域名解析取流

			public byte byMultiStreamProto;//是否支持多码流,按位表示,0-不支持,1-支持,bit1-码流3,bit2-码流4,bit7-主码流，bit-8子码流
			public byte byStartDChan;		//起始数字通道号,0表示无效
			public byte byStartDTalkChan;	//起始数字对讲通道号，区别于模拟对讲通道号，0表示无效
			public byte byHighDChanNum;		//数字通道个数，高位
			public byte bySupport4;
			public byte byLanguageType;// 支持语种能力,按位表示,每一位0-不支持,1-支持  
						//  byLanguageType 等于0 表示 老设备
						//  byLanguageType & 0x1表示支持中文
						//  byLanguageType & 0x2表示支持英文
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;		//保留
		}

		//sdk网络环境枚举变量，用于远程升级
		public enum SdkNetworkEnvironment
		{
			LocalAreaNetwork = 0,
			WideAreaNetwork,
		}

		//显示模式
		public enum DisplayMode
		{
			Normalmode = 0,
			Overlaymode
		}

		//发送模式
		public enum SendMode
		{
			Ptoptcpmode = 0,
			Ptopudpmode,
			Multimode,
			Rtpmode,
			Reservedmode
		}

		//抓图模式
		public enum CaptureMode
		{
			BmpMode = 0,		//BMP模式
			JpegMode = 1		//JPEG模式 
		}

		//实时声音模式
		public enum RealsoundMode
		{
			MonopolizeMode = 1,//独占模式
			ShareMode = 2		//共享模式
		}

		public struct NetDvrClientinfo
		{
			public int LChannel;//通道号
			public int LLinkMode;//最高位(31)为0表示主码流，为1表示子码流，0－30位表示码流连接方式: 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-音视频分开(TCP)
			public IntPtr HPlayWnd;//播放窗口的句柄,为NULL表示不播放图象
			public string SMultiCastIp;//多播组地址
		}

		//SDK状态信息(9000新增)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSdkstate
		{
			public uint dwTotalLoginNum;//当前login用户数
			public uint dwTotalRealPlayNum;//当前realplay路数
			public uint dwTotalPlayBackNum;//当前回放或下载路数
			public uint dwTotalAlarmChanNum;//当前建立报警通道路数
			public uint dwTotalFormatNum;//当前硬盘格式化路数
			public uint dwTotalFileSearchNum;//当前日志或文件搜索路数
			public uint dwTotalLogSearchNum;//当前日志或文件搜索路数
			public uint dwTotalSerialNum;//当前透明通道路数
			public uint dwTotalUpgradeNum;//当前升级路数
			public uint dwTotalVoiceComNum;//当前语音转发路数
			public uint dwTotalBroadCastNum;//当前语音广播路数
			public uint dwTotalListenNum;	    //当前网络监听路数
			public uint dwEmailTestNum;       //当前邮件计数路数
			public uint dwBackupNum;          // 当前文件备份路数
			public uint dwTotalInquestUploadNum; //当前审讯上传路数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		//SDK功能支持信息(9000新增)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSdkabl
		{
			public uint dwMaxLoginNum;//最大login用户数 MAX_LOGIN_USERS
			public uint dwMaxRealPlayNum;//最大realplay路数 WATCH_NUM
			public uint dwMaxPlayBackNum;//最大回放或下载路数 WATCH_NUM
			public uint dwMaxAlarmChanNum;//最大建立报警通道路数 ALARM_NUM
			public uint dwMaxFormatNum;//最大硬盘格式化路数 SERVER_NUM
			public uint dwMaxFileSearchNum;//最大文件搜索路数 SERVER_NUM
			public uint dwMaxLogSearchNum;//最大日志搜索路数 SERVER_NUM
			public uint dwMaxSerialNum;//最大透明通道路数 SERVER_NUM
			public uint dwMaxUpgradeNum;//最大升级路数 SERVER_NUM
			public uint dwMaxVoiceComNum;//最大语音转发路数 SERVER_NUM
			public uint dwMaxBroadCastNum;//最大语音广播路数 MAX_CASTNUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		//报警设备信息
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrAlarmer
		{
			public byte byUserIDValid;/* userid是否有效 0-无效，1-有效 */
			public byte bySerialValid;/* 序列号是否有效 0-无效，1-有效 */
			public byte byVersionValid;/* 版本号是否有效 0-无效，1-有效 */
			public byte byDeviceNameValid;/* 设备名字是否有效 0-无效，1-有效 */
			public byte byMacAddrValid; /* MAC地址是否有效 0-无效，1-有效 */
			public byte byLinkPortValid;/* login端口是否有效 0-无效，1-有效 */
			public byte byDeviceIPValid;/* 设备IP是否有效 0-无效，1-有效 */
			public byte bySocketIPValid;/* socket ip是否有效 0-无效，1-有效 */
			public int lUserId; /* NET_DVR_Login()返回值, 布防时有效 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;/* 序列号 */
			public uint dwDeviceVersion;/* 版本信息 高16位表示主版本，低16位表示次版本*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = NameLen)]
			public string sDeviceName;/* 设备名字 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;/* MAC地址 */
			public ushort wLinkPort; /* link port */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sDeviceIP;/* IP地址 */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sSocketIP;/* 报警主动上传时的socket IP地址 */
			public byte byIpProtocol; /* Ip协议 0-IPV4, 1-IPV6 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//硬解码显示区域参数(子结构)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDisplayPara
		{
			public int bToScreen;
			public int bToVideoOut;
			public int nLeft;
			public int nTop;
			public int nWidth;
			public int nHeight;
			public int nReserved;
		}

		//硬解码预览参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCardinfo
		{
			public int lChannel;//通道号
			public int lLinkMode;//最高位(31)为0表示主码流，为1表示子，0－30位表示码流连接方式:0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-电话线，5－128k宽带，6－256k宽带，7－384k宽带，8－512k宽带；
			[MarshalAs(UnmanagedType.LPStr)]
			public string sMultiCastIP;
			public NetDvrDisplayPara struDisplayPara;
		}

		//录象文件参数
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFindData
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//文件名
			public NetDvrTime struStartTime;//文件的开始时间
			public NetDvrTime struStopTime;//文件的结束时间
			public uint dwFileSize;//文件的大小
		}

		//录象文件参数(9000)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFinddataV30
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//文件名
			public NetDvrTime struStartTime;//文件的开始时间
			public NetDvrTime struStopTime;//文件的结束时间
			public uint dwFileSize;//文件的大小
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
			public byte byLocked;//9000设备支持,1表示此文件已经被锁定,0表示正常的文件
			public byte byFileType;  //文件类型:0－定时录像,1-移动侦测 ，2－报警触发，
			//3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像,7－震动报警，8-环境报警，9-智能报警，10-PIR报警，11-无线报警，12-呼救报警,14-智能交通事件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//录象文件参数(cvr)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFinddataV40
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//文件名
			public NetDvrTime struStartTime;//文件的开始时间
			public NetDvrTime struStopTime;//文件的结束时间
			public uint dwFileSize;//文件的大小
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
			public byte byLocked;//9000设备支持,1表示此文件已经被锁定,0表示正常的文件
			public byte byFileType;  //文件类型:0－定时录像,1-移动侦测 ，2－报警触发，
			//3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像,7－震动报警，8-环境报警，9-智能报警，10-PIR报警，11-无线报警，12-呼救报警,14-智能交通事件
			public byte byQuickSearch; //0:普通查询结果，1：快速（日历）查询结果
			public byte byRes;
			public uint dwFileIndex; //文件索引号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	
		}

		//录象文件参数(带卡号)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFinddataCard
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//文件名
			public NetDvrTime struStartTime;//文件的开始时间
			public NetDvrTime struStopTime;//文件的结束时间
			public uint dwFileSize;//文件的大小
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
		}

		//录象文件查找条件结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFilecond
		{
			public int lChannel;//通道号
			public uint dwFileType;//录象文件类型0xff－全部，0－定时录像,1-移动侦测 ，2－报警触发，
			//3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像
			public uint dwIsLocked;//是否锁定 0-正常文件,1-锁定文件, 0xff表示所有文件
			public uint dwUseCardNo;//是否使用卡号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNumber;//卡号
			public NetDvrTime struStartTime;//开始时间
			public NetDvrTime struStopTime;//结束时间
		}

		//云台区域选择放大缩小(HIK 快球专用)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPointFrame
		{
			public int xTop;//方框起始点的x坐标
			public int yTop;//方框结束点的y坐标
			public int xBottom;//方框结束点的x坐标
			public int yBottom;//方框结束点的y坐标
			public int bCounter;//保留
		}

		//语音对讲参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionAudio
		{
			public byte byAudioEncType;//音频编码类型 0-G722; 1-G711
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;//这里保留音频的压缩参数 
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrApInfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = IwEssidMaxSize)]
			public string sSsid;
			public uint dwMode;/* 0 mange 模式;1 ad-hoc模式，参见NICMODE */
			public uint dwSecurity;  /*0 不加密；1 wep加密；2 wpa-psk;3 wpa-Enterprise，参见WIFISECURITY*/
			public uint dwChannel;/*1-11表示11个通道*/
			public uint dwSignalStrength;/*0-100信号由最弱变为最强*/
			public uint dwSpeed;/*速率,单位是0.01mbps*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrApInfoList
		{
			public uint dwSize;
			public uint dwCount;/*无线AP数量，不超过20*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = WifiMaxApCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrApInfo[] struApInfo;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrWifiethernet
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpAddress;/*IP地址*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpMask;/*掩码*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/*物理地址，只用来显示*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] bRes;
			public uint dwEnableDhcp;/*是否启动dhcp  0不启动 1启动*/
			public uint dwAutoDns;/*如果启动dhcp是否自动获取dns,0不自动获取 1自动获取；对于有线如果启动dhcp目前自动获取dns*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFirstDns; /*第一个dns域名*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sSecondDns;/*第二个dns域名*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sGatewayIpAddr;/* 网关地址*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] bRes2;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionEapTtls
		{
			public byte byEapolVersion; //EAPOL版本，0-版本1，1-版本2
			public byte byAuthType; //内部认证方式，0-PAP，1-MSCHAPV2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnonyIdentity; //匿名身份
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName; //用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword; //密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		} //WPA-enterprise/WPA2-enterpris模式适用

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionEapPeap
		{
			public byte byEapolVersion; //EAPOL版本，0-版本1，1-版本2
			public byte byAuthType; //内部认证方式，0-GTC，1-MD5，2-MSCHAPV2
			public byte byPeapVersion; //PEAP版本，0-版本0，1-版本1
			public byte byPeapLabel; //PEAP标签，0-老标签，1-新标签
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnonyIdentity; //匿名身份
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName; //用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword; //密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		} //WPA-enterprise/WPA2-enterpris模式适用

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionEapTls
		{
			public byte byEapolVersion; //EAPOL版本，0-版本1，1-版本2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byIdentity; //身份
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPrivateKeyPswd; //私钥密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct WifiAuthParam
		{
			[FieldOffset(0)]
			public UnionEapTtls EAP_TTLS;//WPA-enterprise/WPA2-enterpris模式适用
			
			[FieldOffset(0)]
			public UnionEapPeap EAP_PEAP; //WPA-enterprise/WPA2-enterpris模式适用

			[FieldOffset(0)]
			public UnionEapTls EAP_TLS; 
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionWep
		{
			public uint dwAuthentication;/*0 -开放式 1-共享式*/
			public uint dwKeyLength;/* 0 -64位；1- 128位；2-152位*/
			public uint dwKeyType;/*0 16进制;1 ASCI */
			public uint dwActive;/*0 索引：0---3表示用哪一个密钥*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = WifiWepMaxKeyCount * WifiWepMaxKeyLength)]
			public string sKeyInfo;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionWpaPsk
		{
			public uint dwKeyLength;/*8-63个ASCII字符*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = WifiWpaPskMaxKeyLength)]
			public string sKeyInfo;
			public byte byEncryptType;/*WPA/WPA2模式下加密类型,0-AES, 1-TKIP*/
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionWpaWpa2
		{
			public byte byEncryptType;  /*加密类型,0-AES, 1-TKIP*/
			public byte byAuthType; //认证类型，0-EAP_TTLS,1-EAP_PEAP,2-EAP_TLS
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public WifiAuthParam auth_param;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrWifiCfgEx
		{
			public NetDvrWifiethernet struEtherNet;/*wifi网口*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = IwEssidMaxSize)]
			public string sEssid;/*SSID*/
			public uint dwMode;/* 0 mange 模式;1 ad-hoc模式，参见*/
			public uint dwSecurity;/*0 不加密；1 wep加密；2 wpa-psk; */
			[StructLayout(LayoutKind.Explicit)]
			public struct Key
			{
				[FieldOffset(0)]
				public UnionWep wep;

				[FieldOffset(0)]
				public UnionWpaPsk wpa_psk;

				[FieldOffset(0)]
				public UnionWpaWpa2 wpa_wpa2;//WPA-enterprise/WPA2-enterpris模式适用
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWifiCfg
		{
			public uint dwSize;
			public NetDvrWifiCfgEx struWifiCfg;
		}

		//wifi连接状态
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWifiConnectStatus
		{
			public uint dwSize;
			public byte byCurStatus;	//1-已连接，2-未连接，3-正在连接
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;		//保留
			public uint dwErrorCode;	// byCurStatus = 2时有效,1-用户名或密码错误,2-无此路由器,3-未知错误
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWifiWorkmode
		{
			public uint dwSize;
			public uint dwNetworkInterfaceMode;/*0 自动切换模式　1 有线模式*/
		}

		//智能控制信息
		public const int MaxVcaChan = 16;//最大智能通道数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaCtrlinfo
		{
			public byte byVCAEnable;//是否开启智能
			public byte byVCAType;//智能能力类型，VcaChanAbilityType 
			public byte byStreamWithVCA;//码流中是否带智能信息
			public byte byMode;//模式，VCA_CHAN_MODE_TYPE ,atm能力的时候需要配置
			public byte byControlType;   //控制类型，按位表示，0-否，1-是
			// byControlType &1 是否启用抓拍功能
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，设置为0 
		}

		//智能控制信息结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaCtrlcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVcaChan, ArraySubType = UnmanagedType.Struct)]
			public NetVcaCtrlinfo[] struCtrlInfo;//控制信息,数组0对应设备的起始通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//智能设备能力集
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaDevAbility
		{
			public uint dwSize;//结构长度
			public byte byVCAChanNum;//智能通道个数
			public byte byPlateChanNum;//车牌通道个数
			public byte byBBaseChanNum;//行为基本版个数
			public byte byBAdvanceChanNum;//行为高级版个数
			public byte byBFullChanNum;//行为完整版个数
			public byte byATMChanNum;//智能ATM个数
			public byte byPDCChanNum;         //人数统计通道个数
			public byte byITSChanNum;         //交通事件通道个数
			public byte byBPrisonChanNum;     //行为监狱版(监舍)通道个数
			public byte byFSnapChanNum;       //人脸抓拍通道个数
			public byte byFSnapRecogChanNum;  //人脸抓拍和识别通道个数
			public byte byFRetrievalChanNum;  //人脸后检索个数
			public byte bySupport;            //能力，位与结果为0表示不支持，1表示支持
			//bySupport & 0x1，表示是否支持智能跟踪 2012-3-22
			//bySupport & 0x2，表示是否支持128路取流扩展2012-12-27
			public byte byFRecogChanNum;      //人脸识别通道个数
			public byte byBPPerimeterChanNum; //行为监狱版(周界)通道个数
			public byte byTPSChanNum;         //交通诱导通道个数
			public byte byTFSChanNum;         //道路违章取证通道个数
			public byte byFSnapBFullChanNum;  //人脸抓拍和行为分析通道个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//行为分析能力类型
		public enum VcaAbilityType:uint
		{
			TraversePlaneAbility = 0x01,       //穿越警戒面
			EnterAreaAbility = 0x02,       //进入区域
			ExitAreaAbility = 0x04,       //离开区域
			IntrusionAbility = 0x08,       //入侵
			LoiterAbility = 0x10,       //徘徊
			LeftTakeAbility = 0x20,       //物品遗留拿取
			ParkingAbility = 0x40,       //停车
			RunAbility = 0x80,       //快速移动
			HighDensityAbility = 0x100,      //人员聚集
			LfTrackAbility = 0x200,      //球机跟踪
			ViolentMotionAbility = 0x400,      //剧烈运动检测
			ReachHightAbility = 0x800,      //攀高检测
			GetUpAbility = 0x1000,     //起身检测
			LeftAbility = 0x2000,     //物品遗留
			TakeAbility = 0x4000,     //物品拿取
			LeavePosition = 0x8000,     //离岗
			TrailAbility = 0x10000,    //尾随 
			KeyPersonGetUpAbility = 0x20000,    //重点人员起身检测
			FallDownAbility = 0x80000,    //倒地
			AudioAbnormalAbility = 0x100000,   //声强突变
			AdvReachHeightAbility = 0x200000,   //折线攀高
			ToiletTarryAbility = 0x400000,   //如厕超时
			YardTarryAbility = 0x800000,   //放风场滞留
			AdvTraversePlaneAbility = 0x1000000,  //折线警戒面
			HumanEnterAbility = 0x10000000, //人靠近ATM ,只在ATM_PANEL模式下支持
			OverTimeAbility = 0x20000000, //操作超时,只在ATM_PANEL模式下支持
			StickUpAbility = 0x40000000, //贴纸条
			InstallScannerAbility = 0x80000000  //安装读卡器
		}

		//智能通道类型
		public enum VcaChanAbilityType
		{
			VcaBehaviorBase = 1,          //行为分析基本版
			VcaBehaviorAdvance = 2,          //行为分析高级版
			VcaBehaviorFull = 3,          //行为分析完整版
			VcaPlate = 4,          //车牌能力
			VcaAtm = 5,          //ATM能力
			VcaPdc = 6,          //人流量统计
			VcaIts = 7,          //智能 交通事件
			VcaBehaviorPrison = 8,          //行为分析监狱版(监舍) 
			VcaFaceSnap = 9,           //人脸抓拍能力
			VcaFaceSnaprecog = 10,          //人脸抓拍和识别能力
			VcaFaceRetrieval = 11,          //人脸后检索能力
			VcaFaceRecog = 12,          //人脸识别能力
			VcaBehaviorPrisonPerimeter = 13, // 行为分析监狱版 (周界)
			VcaTps = 14,          //交通诱导
			VcaTfs = 15,          //道路违章取证
			VcaBehaviorFacesnap = 16           //人脸抓拍和行为分析能力
		}

		//智能ATM模式类型(ATM能力特有)
		public enum VcaChanModeType
		{
			VcaAtmPanel = 0,//ATM面板
			VcaAtmSurround = 1,//ATM环境
			VcaAtmFace = 2	//ATM人脸
		}
		public enum TfsChanModeType
		{
			TfsCityroad = 0,  //TFS 城市道路
			TfsFreeway = 1   //TFS 高速道路
		}

		//行为分析场景模式
		public enum BehaviorSceneModeType
		{
			BehaviorSceneDefault = 0, //系统默认
			BehaviorSceneWall = 1,    //围墙
			BehaviorSceneIndoor = 2   //室内
		}

		//通道能力输入参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaChanInParam
		{
			public byte byVCAType;//VCA_CHAN_ABILITY_TYPE枚举值
			public byte byMode;//模式，VCA_CHAN_MODE_TYPE ,atm能力的时候需要配置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，设置为0 
		}

		//行为能力集结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBehaviorAbility
		{
			public uint dwSize;//结构长度
			public uint dwAbilityType;//支持的能力类型，按位表示，见VCA_ABILITY_TYPE定义
			public byte byMaxRuleNum;//最大规则数
			public byte byMaxTargetNum;//最大目标数
			public byte bySupport;		// 支持的功能类型   按位表示  
			// bySupport & 0x01 支持标定功能
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留，设置为0
		}

		// 交通能力集结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrItsAbility
		{
			public uint dwSize;             // 结构体大小
			public uint dwAbilityType;      // 支持的能力列表  参照ITS_ABILITY_TYPE
			public byte byMaxRuleNum;	 	//最大规则数
			public byte byMaxTargetNum; 	//最大目标数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    // 保留
		}
		/***********************************end*******************************************/

		/************************************智能参数结构*********************************/
		//智能共用结构
		//坐标值归一化,浮点数值为当前画面的百分比大小, 精度为小数点后三位
		//点坐标结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPoint
		{
			public float fX;// X轴坐标, 0.001~1
			public float fY;//Y轴坐标, 0.001~1
		}

		//区域框结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRect
		{
			public float fX;//边界框左上角点的X轴坐标, 0.001~1
			public float fY;//边界框左上角点的Y轴坐标, 0.001~1
			public float fWidth;//边界框的宽度, 0.001~1
			public float fHeight;//边界框的高度, 0.001~1
		}

		//行为分析事件类型
		public enum VcaEventType : uint
		{
			VcaTraversePlane = 0x1,        //穿越警戒面
			VcaEnterArea = 0x2,        //目标进入区域,支持区域规则
			VcaExitArea = 0x4,        //目标离开区域,支持区域规则
			VcaIntrusion = 0x8,        //周界入侵,支持区域规则
			VcaLoiter = 0x10,       //徘徊,支持区域规则
			VcaLeftTake = 0x20,       //物品遗留拿取,支持区域规则
			VcaParking = 0x40,       //停车,支持区域规则
			VcaRun = 0x80,       //快速移动,支持区域规则
			VcaHighDensity = 0x100,      //区域内人员聚集,支持区域规则
			VcaViolentMotion = 0x200,		 //剧烈运动检测
			VcaReachHight = 0x400,		 //攀高检测
			VcaGetUp = 0x800,	     //起身检测
			VcaLeft = 0x1000,     //物品遗留
			VcaTake = 0x2000,     //物品拿取
			VcaLeavePosition = 0x4000,     //离岗
			VcaTrail = 0x8000,     //尾随
			VcaKeyPersonGetUp = 0x10000,    //重点人员起身检测
			VcaFallDown = 0x80000,    //倒地检测
			VcaAudioAbnormal = 0x100000,   //声强突变检测
			VcaAdvReachHeight = 0x200000,   //折线攀高
			VcaToiletTarry = 0x400000,   //如厕超时
			VcaYardTarry = 0x800000,   //放风场滞留
			VcaAdvTraversePlane = 0x1000000,  //折线警戒面
			VcaHumanEnter = 0x10000000, //人靠近ATM           只在ATM_PANEL模式下支持
			VcaOverTime = 0x20000000, //操作超时            只在ATM_PANEL模式下支持
			VcaStickUp = 0x40000000, //贴纸条,支持区域规则
			VcaInstallScanner = 0x80000000  //安装读卡器,支持区域规则
		}

		//行为分析事件类型扩展
		public enum VcaRuleEventTypeEx : ushort
		{
			EnumVcaEventTraversePlane = 1,   //穿越警戒面
			EnumVcaEventEnterArea = 2,   //目标进入区域,支持区域规则
			EnumVcaEventExitArea = 3,   //目标离开区域,支持区域规则
			EnumVcaEventIntrusion = 4,   //周界入侵,支持区域规则
			EnumVcaEventLoiter = 5,   //徘徊,支持区域规则
			EnumVcaEventLeftTake = 6,   //物品遗留拿取,支持区域规则
			EnumVcaEventParking = 7,   //停车,支持区域规则
			EnumVcaEventRun = 8,   //快速移动,支持区域规则
			EnumVcaEventHighDensity = 9,   //区域内人员聚集,支持区域规则
			EnumVcaEventViolentMotion = 10,  //剧烈运动检测
			EnumVcaEventReachHight = 11,  //攀高检测
			EnumVcaEventGetUp = 12,  //起身检测
			EnumVcaEventLeft = 13,  //物品遗留
			EnumVcaEventTake = 14,  //物品拿取
			EnumVcaEventLeavePosition = 15,  //离岗
			EnumVcaEventTrail = 16,  //尾随
			EnumVcaEventKeyPersonGetUp = 17,  //重点人员起身检测
			EnumVcaEventFallDown = 20,  //倒地检测
			EnumVcaEventAudioAbnormal = 21,  //声强突变检测
			EnumVcaEventAdvReachHeight = 22,  //折线攀高
			EnumVcaEventToiletTarry = 23,  //如厕超时
			EnumVcaEventYardTarry = 24,  //放风场滞留
			EnumVcaEventAdvTraversePlane = 25,  //折线警戒面
			EnumVcaEventHumanEnter = 29,  //人靠近ATM,只在ATM_PANEL模式下支持   
			EnumVcaEventOverTime = 30,  //操作超时,只在ATM_PANEL模式下支持
			EnumVcaEventStickUp = 31,  //贴纸条,支持区域规则
			EnumVcaEventInstallScanner = 32   //安装读卡器,支持区域规则
		}

		//警戒面穿越方向类型
		public enum VcaCrossDirection
		{
			VcaBothDirection,// 双向 
			VcaLeftGoRight,// 由左至右 
			VcaRightGoLeft,// 由右至左 
		}

		//线结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLine
		{
			public NetVcaPoint struStart;//起点 
			public NetVcaPoint struEnd; //终点

			//             public void Init()
			//             {
			//                 struStart = new NetVcaPoint();
			//                 struEnd = new NetVcaPoint();
			//             }
		}

		//该结构会导致xaml界面出不来！！！！！！！！！？？问题暂时还没有找到  
		//暂时屏蔽结构先
		//多边型结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPolygon
		{
			/// DWORD->unsigned int
			public uint dwPointNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = VcaMaxPolygonPointNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPoint[] struPos;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTraversePlane
		{
			public NetVcaLine struPlaneBottom;//警戒面底边
			public VcaCrossDirection dwCrossDirection;//穿越方向: 0-双向，1-从左到右，2-从右到左
			public byte byRes1;//保留
			public byte byPlaneHeight;//警戒面高度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			//             public void Init()
			//             {
			//                 struPlaneBottom = new NET_VCA_LINE();
			//                 struPlaneBottom.Init();
			//                 byRes2 = new byte[38];
			//             }
		}

		//进入/离开区域参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaArea
		{
			public NetVcaPolygon struRegion;//区域范围
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//根据报警延迟时间来标识报警中带图片，报警间隔和IO报警一致，1秒发送一个。
		//入侵参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaIntrusion
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;//报警延迟时间: 1-120秒，建议5秒，判断是有效报警的时间
			public byte bySensitivity;        //灵敏度参数，范围[1-100]
			public byte byRate;               //占比：区域内所有未报警目标尺寸目标占区域面积的比重，归一化为－；
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//徘徊参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLoiter
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;//触发徘徊报警的持续时间：1-120秒，建议10秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//丢包/捡包参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTakeLeft
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;//触发丢包/捡包报警的持续时间：1-120秒，建议10秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//停车参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaParking
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;//触发停车报警持续时间：1-120秒，建议10秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//奔跑参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRun
		{
			public NetVcaPolygon struRegion;//区域范围
			public float fRunDistance;//人奔跑最大距离, 范围: [0.1, 1.00]
			public byte byRes1;             // 保留字节
			public byte byMode;             // 0 像素模式  1 实际模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//人员聚集参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHighDensity
		{
			public NetVcaPolygon struRegion;//区域范围
			public float fDensity;//密度比率, 范围: [0.1, 1.0]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public ushort wDuration;      // 触发人员聚集参数报警阈值 20-360s
		}

		//剧烈运动参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaViolentMotion
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;           //触发剧烈运动报警阈值：1-50秒
			public byte bySensitivity;       //灵敏度参数，范围[1,5]
			public byte byMode;              //0-纯视频模式，1-音视频联合模式，2-纯音频模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;            //保留
		}

		//攀高参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaReachHight
		{
			public NetVcaLine struVcaLine;   //攀高警戒面
			public ushort wDuration; //触发攀高报警阈值：1-120秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           // 保留字节
		}

		//起床参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaGetUp
		{
			public NetVcaPolygon struRegion; //区域范围
			public ushort wDuration;	        //触发起床报警阈值1-100 秒
			public byte byMode;             //起身检测模式,0-大床通铺模式,1-高低铺模式,2-大床通铺坐立起身模式
			public byte bySensitivity;      //灵敏度参数，范围[1,10]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    //保留字节
		}

		//物品遗留
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLeft
		{
			public NetVcaPolygon struRegion; // 区域范围
			public ushort wDuration;       // 触发物品遗留报警阈值 10-100秒
			public byte bySensitivity;   // 灵敏度参数，范围[1,5] 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        // 保留字节
		}

		// 物品拿取
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTake
		{
			public NetVcaPolygon struRegion;     // 区域范围
			public ushort wDuration;      // 触发物品拿取报警阈值10-100秒
			public byte bySensitivity;  // 灵敏度参数，范围[1,5] 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaOverTime
		{
			public NetVcaPolygon struRegion;    // 区域范围
			public ushort wDuration;  // 操作报警时间阈值 4s-60000s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHumanEnter
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;			//保留字节
		}

		//贴纸条参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaStickUp
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;//报警持续时间：10-60秒，建议10秒
			public byte bySensitivity;//灵敏度参数，范围[1,5]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//读卡器参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaScanner
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;//读卡持续时间：10-60秒
			public byte bySensitivity;//灵敏度参数，范围[1,5]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//离岗事件
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLeavePosition
		{
			public NetVcaPolygon struRegion; //区域范围
			public ushort wLeaveDelay;  //无人报警时间，单位：s，取值1-1800
			public ushort wStaticDelay; //睡觉报警时间，单位：s，取值1-1800
			public byte byMode;       //模式，0-离岗事件，1-睡岗事件，2-离岗睡岗事件
			public byte byPersonType; //值岗人数类型，0-单人值岗，1-双人值岗
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //保留
		}

		//尾随参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTrail
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wRes;      /* 保留 */
			public byte bySensitivity;       /* 灵敏度参数，范围[1,5] */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//倒地参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFallDown
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDuration;      /* 触发事件阈值 1-60s*/
			public byte bySensitivity;       /* 灵敏度参数，范围[1,5] */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//声强突变参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAudioAbnormal
		{
			public ushort wDecibel;       //声音强度
			public byte bySensitivity;  //灵敏度参数，范围[1,5] 
			public byte byAudioMode;    //声音检测模式，0-灵敏度检测，1-分贝阈值检测，2-灵敏度与分贝阈值检测 
			public byte byEnable;       //使能，是否开启
			public byte byThreshold;    //声音阈值[0,100]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //保留   
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAudioException
		{
			public uint dwSize;
			public byte byEnableAudioInException;  //使能，是否开启
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetVcaAudioAbnormal struAudioAbnormal;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmSched; //布防时间
			public NetDvrHandleexceptionV40 struHandleException;  //异常处理方式
			public uint dwMaxRelRecordChanNum;  //报警触发的录象通道 数（只读）最大支持数量
			public uint dwRelRecordChanNum;     //报警触发的录象通道 数 实际支持的数量
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] byRelRecordChan;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaToiletTarry
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDelay;        //如厕超时时间[1,3600]，单位：秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaYardTarry
		{
			public NetVcaPolygon struRegion;//区域范围
			public ushort wDelay;        //放风场滞留时间[1,120]，单位：秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAdvReachHeight
		{
			public NetVcaPolygon struRegion; //攀高折线
			public uint dwCrossDirection;   //跨越方向(详见VCA_CROSS_DIRECTION): 0-双向，1-从左到右2-从右到左
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAdvTraversePlane
		{
			public NetVcaPolygon struRegion; //警戒面折线
			public uint dwCrossDirection;   //跨越方向(详见VCA_CROSS_DIRECTION): 0-双向，1-从左到右2-从右到左
			public byte bySensitivity;      //灵敏度参数，范围[1,5] 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    //保留字节
		}

		//警戒事件参数
		[StructLayout(LayoutKind.Explicit)]
		public struct NetVcaEventUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
			public uint[] uLen;//参数

			//[FieldOffset(0)]
			//public NET_VCA_TRAVERSE_PLANE struTraversePlane;//穿越警戒面参数 
			//[FieldOffset(0)]
			//public NET_VCA_AREA struArea;//进入/离开区域参数
			//[FieldOffset(0)]
			//public NET_VCA_INTRUSION struIntrusion;//入侵参数
			//[FieldOffset(0)]
			//public NET_VCA_LOITER struLoiter;//徘徊参数
			//[FieldOffset(0)]
			//public NET_VCA_TAKE_LEFT struTakeTeft;//丢包/捡包参数
			//[FieldOffset(0)]
			//public NET_VCA_PARKING struParking;//停车参数
			//[FieldOffset(0)]
			//public NET_VCA_RUN struRun;//奔跑参数
			//[FieldOffset(0)]
			//public NET_VCA_HIGH_DENSITY struHighDensity;//人员聚集参数  
			//[FieldOffset(0)]
			//public NET_VCA_VIOLENT_MOTION struViolentMotion;	//剧烈运动
			//[FieldOffset(0)]
			//public NET_VCA_REACH_HIGHT struReachHight;      //攀高
			//[FieldOffset(0)]
			//public NET_VCA_GET_UP struGetUp;           //起床
			//[FieldOffset(0)]
			//public NET_VCA_LEFT struLeft;            //物品遗留
			//[FieldOffset(0)]
			//public NetVcaTake struTake;            // 物品拿取
			//[FieldOffset(0)]
			//public NetVcaHumanEnter struHumanEnter;      //人员进入
			//[FieldOffset(0)]
			//public NetVcaOverTime struOvertime;        //操作超时
			//[FieldOffset(0)]
			//public NetVcaStickUp struStickUp;//贴纸条
			//[FieldOffset(0)]
			//public NetVcaScanner struScanner;//读卡器参数
			//[FieldOffset(0)]
			//public NetVcaLeavePosition struLeavePos;        //离岗参数
			//[FieldOffset(0)]
			//public NetVcaTrail struTrail;           //尾随参数
			//[FieldOffset(0)]
			//public NetVcaFallDown struFallDown;        //倒地参数
			//[FieldOffset(0)]
			//public NetVcaAudioAbnormal struAudioAbnormal;   //声强突变
			//[FieldOffset(0)]
			//public NetVcaAdvReachHeight struReachHeight;     //折线攀高参数
			//[FieldOffset(0)]
			//public NetVcaToiletTarry struToiletTarry;     //如厕超时参数
			//[FieldOffset(0)]
			//public NetVcaYardTarry struYardTarry;       //放风场滞留参数
			//[FieldOffset(0)]
			//public NetVcaAdvTraversePlane struAdvTraversePlane;//折线警戒面参数            
		}

		// 尺寸过滤器类型
		public enum SizeFilterMode
		{
			ImagePixMode,//根据像素大小设置
			RealWorldMode,//根据实际大小设置
			DefaultMode 	// 默认模式
		}

		//尺寸过滤器
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSizeFilter
		{
			public byte byActive;//是否激活尺寸过滤器 0-否 非0-是
			public byte byMode;//过滤器模式SIZE_FILTER_MODE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，置0
			public NetVcaRect struMiniRect;//最小目标框,全0表示不设置
			public NetVcaRect struMaxRect;//最大目标框,全0表示不设置
		}

		//警戒规则结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaOneRule
		{
			public byte byActive;//是否激活规则,0-否,非0-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，设置为0字段
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//规则名称
			public VcaEventType dwEventType;//行为分析事件类型
			public NetVcaEventUnion uEventParam;//行为分析事件参数
			public NetVcaSizeFilter struSizeFilter;//尺寸过滤器
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;//处理方式 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
		}

		//行为分析配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRulecfg
		{
			public uint dwSize;//结构长度
			public byte byPicProType;//报警时图片处理方式 0-不处理 非0-上传
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrJpegpara struPictureParam;//图片规格结构
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaOneRule[] struRule;//规则数组
		}

		//尺寸过滤策略
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFilterStrategy
		{
			public byte byStrategy;      //尺寸过滤策略 0 - 不启用 1-高度和宽度过滤,2-面积过滤
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       //保留
		}

		//规则触发参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRuleTriggerParam
		{
			public byte byTriggerMode;   //规则的触发方式，0- 不启用，1- 轨迹点 2- 目标面积 
			public byte byTriggerPoint;  //触发点，触发方式为轨迹点时有效 0- 中,1-上,2-下
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       //保留
			public float fTriggerArea;    //触发目标面积百分比 [0,100]，触发方式为目标面积时有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;       //保留
		}

		//警戒规则结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaOneRuleV41
		{
			public byte byActive; //是否激活规则,0-否,非0-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //保留，设置为0字段
			public ushort wEventTypeEx; //行为事件类型扩展，用于代替字段dwEventType，参考VCA_RULE_EVENT_TYPE_EX
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName; //规则名称
			public VcaEventType dwEventType;	//行为事件类型，保留是为了兼容，后续建议使用wEventTypeEx获取事件类型
			public NetVcaEventUnion uEventParam; //行为分析事件参数
			public NetVcaSizeFilter struSizeFilter;  //尺寸过滤器
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;	//处理方式 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //报警触发的录象通道,为1表示触发该通道
			public ushort wAlarmDelay; //智能报警延时，0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //保留
			public NetVcaFilterStrategy struFilterStrategy; //尺寸过滤策略
			public NetVcaRuleTriggerParam struTriggerParam;   //规则触发参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//行为分析配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRulecfgV41
		{
			public uint dwSize;			//结构长度
			public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
			public byte byUpLastAlarm; //2011-04-06 是否先上传最近一次的报警
			public byte byPicRecordEnable;  /*2012-3-1是否启用图片存储, 0-不启用, 1-启用*/
			public byte byRes1;
			public NetDvrJpegpara struPictureParam; 		//图片规格结构	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaOneRuleV41[] struRule;  //规则数组
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//简化目标结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTargetInfo
		{
			public uint dwID;//目标ID ,人员密度过高报警时为0
			public NetVcaRect struRect; //目标边界框 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		//简化的规则信息, 包含规则的基本信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRuleInfo
		{
			public byte byRuleID;//规则ID,0-7
			public byte byRes;//保留
			public ushort wEventTypeEx;   //行为事件类型扩展，用于代替字段dwEventType，参考VCA_RULE_EVENT_TYPE_EX
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//规则名称
			public VcaEventType dwEventType;//警戒事件类型
			public NetVcaEventUnion uEventParam;//事件参数
		}

		//前端设备地址信息，智能分析仪表示的是前端设备的地址信息，其他设备表示本机的地址
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaDevInfo
		{
			public NetDvrIpaddr struDevIP;//前端设备地址，
			public ushort wPort;//前端设备端口号， 
			public byte byChannel;//前端设备通道，
			public byte byRes;// 保留字节
		}

		//行为分析结果上报结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRuleAlarm
		{
			public uint dwSize;//结构长度
			public uint dwRelativeTime;//相对时标
			public uint dwAbsTime;//绝对时标
			public NetVcaRuleInfo struRuleInfo;//事件规则信息
			public NetVcaTargetInfo struTargetInfo;//报警目标信息
			public NetVcaDevInfo struDevInfo;//前端设备信息
			public uint dwPicDataLen;//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据*/
			public byte byPicType;		//  0-普通图片 1-对比图片
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;//保留，设置为0
			public IntPtr pImage;//指向图片的指针
		}

		//行为分析规则DSP信息叠加结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaDrawMode
		{
			public uint dwSize;
			public byte byDspAddTarget;//编码是否叠加目标
			public byte byDspAddRule;//编码是否叠加规则
			public byte byDspPicAddTarget;//抓图是否叠加目标
			public byte byDspPicAddRule;//抓图是否叠加规则
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//物体类型
		public enum ObjectTypeEnum
		{
			EnumObjectTypeCoat = 1  //上衣
		}

		//物体颜色条件结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrObjectColorCond
		{
			public uint dwChannel;   //通道号
			public uint dwObjType;   //物体类型，参见OBJECT_TYPE_ENUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //保留
		}

		//图片参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPic
		{
			public byte byPicType;        //图片类型，1-jpg
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;        //保留
			public uint dwPicWidth;       //图片宽度
			public uint dwPicHeight;      //图片高度
			public uint dwPicDataLen;     //图片数据实际大小
			public uint dwPicDataBuffLen; //图片数据缓冲区大小
			public IntPtr byPicDataBuff;    //图片数据缓冲区
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;       //保留
		}

		//颜色联合体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrObjectColorUnion
		{
			public NetDvrColor struColor;   //颜色值
			public NetDvrPic struPicture; //图片
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //保留
		}

		//物体颜色参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrObjectColor
		{
			public uint dwSize;       //结构体大小
			public byte byEnable;     //0-不启用，1-启用
			public byte byColorMode;  //取色方式，1-颜色值，2-图片
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //保留
			public NetDvrObjectColorUnion uObjColor; //物体颜色联合体，取值依赖于取色方式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //保留
		}

		//区域类型
		public enum AreaTypeEnum
		{
			EnumOverlapRegion = 1,//共同区域
			EnumBedLocation = 2   //床铺位置
		}

		//辅助区域
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAuxarea
		{
			public uint dwAreaType;   //区域类型，参见AREA_TYPE_ENUM
			public byte byEnable;     //0-不启用，1-启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;     //保留
			public NetVcaPolygon struPolygon; //区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //保留
		}

		//辅助区域列表
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAuxareaList
		{
			public uint dwSize;	// 结构体大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAuxareaNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAuxarea[] struArea; //辅助区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	// 保留
		}

		//通道工作模式
		public enum ChanWorkmodeEnum
		{
			EnumChanWorkmodeIndependent = 1,  //独立模式
			EnumChanWorkmodeMaster = 2,      //主模式
			EnumChanWorkmodeSlave = 3        //从模式
		}

		//通道工作模式参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannelWorkmode
		{
			public uint dwSize;        //结构体大小
			public byte byWorkMode;    //工作模式，参见CHAN_WORKMODE_ENUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //保留
		}

		//设备通道参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannel
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byAddress;	//设备IP或域名
			public ushort wDVRPort;			 	    //端口号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                   //保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	        //主机用户名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;       //主机密码
			public uint dwChannel;                   //通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                  //保留
		}

		//从通道信息联合体
		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrSlaveChannelUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //联合体大小
			[FieldOffset(0)]
			public uint dwLocalChannel;    //本机通道
			[FieldOffset(0)]
			public NetDvrChannel struRemoteChannel; //远程通道
		}

		//从通道参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSlaveChannelParam
		{
			public byte byChanType;   //从通道类型，1-本机通道，2-远程通道 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //保留
			public NetDvrSlaveChannelUnion uSlaveChannel; //从通道联合体，取值依赖于byChanType
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //保留
		}


		//从通道参数配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSlaveChannelCfg
		{
			public uint dwSize;   //结构体大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSlaveChannelNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSlaveChannelParam[] struChanParam;//从通道参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
		}

		//视频质量诊断检测事件
		public enum VqdEventEnum
		{
			EnumVqdEventBlur = 1,  //图像模糊
			EnumVqdEventLuma = 2,  //亮度异常
			EnumVqdEventChroma = 3,  //图像偏色
			EnumVqdEventSnow = 4,  //雪花干扰
			EnumVqdEventStreak = 5,  //条纹干扰
			EnumVqdEventFreeze = 6,  //画面冻结
			EnumVqdEventSignalLoss = 7,  //信号丢失
			EnumVqdEventPtz = 8,  //云台失控
			EnumVqdEventScneneChange = 9,  //场景突变
			EnumVqdEventVideoAbnormal = 10, //视频异常
			EnumVqdEventVideoBlock = 11, //视频遮挡
		}

		//视频质量诊断事件条件结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdEventCond
		{
			public uint dwChannel;   //通道号
			public uint dwEventType; //检测事件类型，参见VQD_EVENT_ENUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //保留
		}

		//视频质量诊断事件参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdEventParam
		{
			public byte byThreshold;    //报警阈值，范围[0,100]
			public byte byTriggerMode;  //1-持续触发，2-单次触发
			public byte byUploadPic;    //0-不上传图片，1-上传图片，无论是否上传图片，事后都可以从设备获取该事件所对应最新的一张报警图片，参见接口NET_DVR_StartDownload
			public byte byRes1;         //保留
			public uint dwTimeInterval; //持续触发报警时间间隔，范围[0,3600] 单位：秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;     //保留
		}

		//视频质量诊断事件规则
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdEventRule
		{
			public uint dwSize;       //结构体大小 
			public byte byEnable;     //0-不启用，1-启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //保留
			public NetDvrVqdEventParam struEventParam; //视频质量诊断事件参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//检测时间
			public NetDvrHandleexceptionV30 struHandleType;  //处理方式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIvmsIpChannel, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //报警触发的录象通道：1表示触发该通道；0表示不触发
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //保留
		}

		//基准场景参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBaselineScene
		{
			public uint dwSize;     //结构体大小
			public byte byEnable;   //0-不启用，1-启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
		}

		//基准场景操作参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrControlBaselineSceneParam
		{
			public uint dwSize;     //结构体大小
			public uint dwChannel;  //通道号
			public byte byCommand;  //操作类型，1-此字段保留，暂不使用，2-更新基准场景
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
		}

		//视频质量诊断报警结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdAlarm
		{
			public uint dwSize;                //结构体大小
			public uint dwRelativeTime;        //相对时标
			public uint dwAbsTime;	          //绝对时标
			public NetVcaDevInfo struDevInfo; //前端设备信息 
			public uint dwEventType;           //事件类型，参考VQD_EVENT_ENUM
			public float fThreshold;            //报警阈值[0.000,1.000]
			public uint dwPicDataLen;          //图片长度，为0表示没有图片
			public IntPtr pImage;               //指向图片的指针 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;            //保留
		}

		//标定点子结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCbPoint
		{
			public NetVcaPoint struPoint;     //标定点，主摄像机（枪机）
			public NetDvrPtzpos struPtzPos;  //球机输入的PTZ坐标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//标定参数配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackCalibrationParam
		{
			public byte byPointNum;			//有效标定点个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCalibPt, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCbPoint[] struCBPoint; //标定点组
		}

		//球机配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackCfg
		{
			public uint dwSize;				//结构长度	
			public byte byEnable;				//标定使能
			public byte byFollowChan;          // 被控制的从通道
			public byte byDomeCalibrate;			//设置智能跟踪球机标定，1设置 0不设置 
			public byte byRes;					// 保留字节
			public NetDvrTrackCalibrationParam struCalParam; //标定点组
		}

		//跟踪模式
		public enum TrackMode
		{
			ManualCtrl = 0,  //手动跟踪
			AlarmTrack    //报警触发跟踪
		}

		//手动控制结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrManualCtrlInfo
		{
			public NetVcaPoint struCtrlPoint;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//跟踪模式结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackMode
		{
			public uint dwSize;		//结构长度
			public byte byTrackMode;   //跟踪模式
			public byte byRuleConfMode;   //规则配置跟踪模式0-本地配置跟踪，1-远程配置跟踪
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //保留，置0
			[StructLayout(LayoutKind.Explicit)]
			public struct UModeParam
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
				public uint[] dwULen;
				[FieldOffset(0)]
				public NetDvrManualCtrlInfo struManualCtrl;//手动跟踪结构
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmJpeg
		{
			public byte byPicProType;	    /*报警时图片处理方式 0-不处理 1-上传*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //保留字节
			public NetDvrJpegpara struPicParam; 				/*图片规格结构*/
		}

		//分析仪行为分析规则结构
		//警戒规则结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsOneRule
		{
			public byte byActive;/* 是否激活规则,0-否, 非0-是 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留，设置为0字段
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//规则名称
			public VcaEventType dwEventType;//行为分析事件类型
			public NetVcaEventUnion uEventParam;//行为分析事件参数
			public NetVcaSizeFilter struSizeFilter;//尺寸过滤器
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;/*保留，设置为0*/
		}

		// 分析仪规则结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsRulecfg
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetIvmsOneRule[] struRule; //规则数组
		}

		// IVMS行为分析配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsBehaviorcfg
		{
			public uint dwSize;
			public byte byPicProType;//报警时图片处理方式 0-不处理 非0-上传
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrJpegpara struPicParam;//图片规格结构
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetIvmsRulecfg[] struRuleCfg;//每个时间段对应规则
		}

		//智能分析仪取流计划子结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsDevsched
		{
			public NetDvrSchedtime struTime;//时间参数
			public NetDvrPuStreamCfg struPUStream;//前端取流参数
		}

		//智能分析仪参数配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsStreamcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetIvmsDevsched[] struDevSched;//按时间段配置前端取流以及规则信息
		}

		//屏蔽区域
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaMaskRegion
		{
			public byte byEnable;//是否激活, 0-否，非0-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，置0
			public NetVcaPolygon struPolygon;//屏蔽多边形
		}

		//屏蔽区域链表结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaMaskRegionList
		{
			public uint dwSize;//结构长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留，置0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxMaskRegionNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaMaskRegion[] struMask;//屏蔽区域数组
		}

		//ATM进入区域参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaEnterRegion
		{
			public uint dwSize;
			public byte byEnable;//是否激活，0-否，非0-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetVcaPolygon struPolygon;//进入区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//IVMS屏蔽区域链表
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsMaskRegionList
		{
			public uint dwSize;//结构长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetVcaMaskRegionList[] struList;
		}

		//IVMS的ATM进入区域参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsEnterRegion
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetVcaEnterRegion[] struEnter;//进入区域
		}

		// ivms 报警图片上传结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsAlarmJpeg
		{
			public byte byPicProType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrJpegpara struPicParam;
		}

		// IVMS 后检索配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsSearchcfg
		{
			public uint dwSize;
			public NetDvrMatrixDecRemotePlay struRemotePlay;// 远程回放
			public NetIvmsAlarmJpeg struAlarmJpeg;// 报警上传图片配置
			public NetIvmsRulecfg struRuleCfg;//IVMS 行为规则配置
		}

		/************************************end******************************************/
		//NAS认证配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIdentificationParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;		/* 用户名 32*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;		/* 密码 16*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	//保留
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrMountParamUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
			public byte[] uLen;   //联合体结构大小
			[FieldOffset(0)]
			public NetDvrIdentificationParam struIdentificationParam;//(SMB/CIFS时生效)
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNasMountParam
		{
			public byte byMountType; //0～保留,1~NFS, 2~ SMB/CIFS
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrMountParamUnion uMountParam;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrMountmethodParamUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
			public byte[] uLen; //联合体结构大小   
			[FieldOffset(0)]
			public NetDvrNasMountParam struNasMountParam;//NAS挂载方式 (byNetDiskType为NFS(NAS)时生效) 
		}

		//网络硬盘结构配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleNetDiskInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留
			public NetDvrIpaddr struNetDiskAddr;//网络硬盘地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PathnameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDirectory;// PATHNAME_LEN = 128
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//保留
		}

		public const int MaxNetDisk = 16;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNetDiskcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNetDisk, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleNetDiskInfo[] struNetDiskParam;
		}

		//事件类型
		//主类型
		public enum MainEventType
		{
			EventMotDet = 0,//移动侦测
			EventAlarmIn = 1,//报警输入
			EventVcaBehavior = 2,//行为分析
			EventInquest = 3,       //审讯事件
			EventVcaDetection = 4, //智能侦测
			EventStreamInfo = 100  //流ID信息
		}

		public const int InquestStartInfo = 0x1001;      /*讯问开始信息*/
		public const int InquestStopInfo = 0x1002;       /*讯问停止信息*/
		public const int InquestTagInfo = 0x1003;       /*重点标记信息*/
		public const int InquestSegmentInfo = 0x1004;      /*审讯片断状态信息*/

		public enum VcaDetectionMinorType:uint
		{
			EventVcaTraversePlane = 1,        //越警侦测
			EventFieldDetection,		     //区域入侵侦测
			EventAudioInputAlarm,      //音频输入异常
			EventSoundIntensityAlarm,   //声强突变侦测
			EventFaceDetection,             //人脸侦测
			EventVirtualFocusAlarm, /*虚焦侦测*/
			EventSceneChangeAlarm, /*场景变更侦测*/
			EventAll = 0xffffffff				//表示全部
		}

		//行为分析主类型对应的此类型， 0xffff表示全部
		public enum BehaviorMinorType
		{
			EventTraversePlane = 0,// 穿越警戒面,
			EventEnterArea,//目标进入区域,支持区域规则
			EventExitArea,//目标离开区域,支持区域规则
			EventIntrusion,// 周界入侵,支持区域规则
			EventLoiter,//徘徊,支持区域规则
			EventLeftTake,//丢包捡包,支持区域规则
			EventParking,//停车,支持区域规则
			EventRun,//奔跑,支持区域规则
			EventHighDensity,//区域内人员密度,支持区域规则
			EventStickUp,//贴纸条,支持区域规则
			EventInstallScanner,//安装读卡器,支持区域规则
			EventOperateOverTime,        // 操作超时
			EventFaceDetect,              // 异常人脸
			EventLeft,                     // 物品遗留
			EventTake,                      // 物品拿取
			EventLeavePosition,         //离岗事件
			EventTrailInfo = 16,            //尾随
			EventFallDownInfo = 19,                 //倒地
			EventObjectPaste = 20,		// 异物粘贴区域
			EventFaceCaptureInfo = 21,                //正常人脸
			EventMultiFacesInfo = 22,                  //多张人脸
			EventAudioAbnormalInfo = 23,             //声强突变
			EventDetect = 24     			   //智能侦测
		}

		// 主类型100，对应的小类型
		public enum StreamInfoMinorType
		{
			EventStreamId = 0,				// 流ID
			EventTiming = 1,					// 定时录像
			EventMotionDetect = 2,			// 移动侦测
			EventAlarm = 3,					// 报警录像
			EventAlarmOrMotionDetect = 4,	// 报警或移动侦测
			EventAlarmAndMotionDetect = 5,	// 报警和移动侦测
			EventCommandTrigger = 6,			// 命令触发
			EventMannual = 7,					// 手动录像
			EventBackupVolume = 8				// 存档卷录像
		}

		//邦诺CVR
		public const int MaxIdCount = 256;
		public const int MaxStreamIdCount = 1024;
		public const int StreamIdLen = 32;
		public const int PlanIdLen = 32;

		// 流信息 - 72字节长
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamInfo
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = StreamIdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byID;      //ID数据
			public uint dwChannel;                //关联设备通道，等于0xffffffff时，表示不关联
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                //保留
			public void Init()
			{
				byID = new byte[StreamIdLen];
				byRes = new byte[32];
			}
		}

		//事件搜索条件 200-04-07 9000_1.1
		public const int SearchEventInfoLen = 300;

		//报警输入
		[StructLayout(LayoutKind.Sequential)]
		public struct EventAlarmBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInNo;//报警输入号，byAlarmInNo[0]若置1则表示查找由报警输入1触发的事件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen - MaxAlarminV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byAlarmInNo = new byte[MaxAlarminV30];
				byRes = new byte[SearchEventInfoLen - MaxChannumV30];
			}
		}

		//报警输入 按值表示
		[StructLayout(LayoutKind.Sequential)]
		public struct EventAlarmByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
			public ushort[] wAlarmInNo;//报警输入号，byAlarmInNo[0]若置1则表示查找由报警输入1触发的事件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				wAlarmInNo = new ushort[128];
				byRes = new byte[44];
			}
		}

		//移动侦测
		[StructLayout(LayoutKind.Sequential)]
		public struct EventMotionBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotDetChanNo;//移动侦测通道，byMotDetChanNo[0]若置1则表示查找由通道1发生移动侦测触发的事件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen - MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byMotDetChanNo = new byte[MaxChannumV30];
				byRes = new byte[SearchEventInfoLen - MaxChannumV30];
			}
		}

		//移动侦测--按值
		[StructLayout(LayoutKind.Sequential)]
		public struct EventMotionByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
			public ushort[] wMotDetChanNo;//报警输入号，byAlarmInNo[0]若置1则表示查找由报警输入1触发的事件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				wMotDetChanNo = new ushort[64];
				byRes = new byte[172];
			}
		}

		//行为分析
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcaBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byChanNo;//触发事件的通道
			public byte byRuleID;//规则ID，0xff表示全部
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留

			public void Init()
			{
				byChanNo = new byte[MaxChannumV30];
				byRes1 = new byte[235];
			}
		}

		//行为分析--按值方式查找 
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcaByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
			public ushort[] wChanNo;	//触发事件的通道			
			public byte byRuleID;      //行为分析类型，规则0xff表示全部，从0开始
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	 /*保留*/
			public void Init()
			{
				wChanNo = new ushort[64];
				byRes = new byte[171];
			}
		}

		//审讯事件搜索条件
		[StructLayout(LayoutKind.Sequential)]
		public struct EventInquestParam
		{			
			public byte byRoomIndex;    //审讯室编号,从1开始
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //保留
			public void Init()
			{
				byRes = new byte[299];
			}
		}

		//智能侦测查找条件
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcadetectBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byChan;//触发智能侦测的通道号，按数组下标表示，byChan[0]若置1则表示查找由通道1发生移动侦测触发的事件 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //保留
			public void Init()
			{
				byChan = new byte[256];
				byRes = new byte[44];
			}
		}
		
		//智能侦测查找条件 ，通道号按值表示
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcadetectByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30-1, ArraySubType = UnmanagedType.U4)]
			public uint[] dwChanNo;// 触发通道号,按值表示，0xffffffff无效，且后续数据也表示无效值
			public byte byAll;//0-表示不是全部，1-表示全部。
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 47, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public void Init()
			{
				dwChanNo = new uint[MaxChannumV30 - 1];
				byRes = new byte[47];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct EventStreamidParam
		{
			public NetDvrStreamInfo struIDInfo; // 流id信息，72字节长
			public uint dwCmdType;  // 外部触发类型，NVR接入云存储使用
			public byte byBackupVolumeNum; //存档卷号，CVR使用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 223, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public void Init()
			{
				struIDInfo.Init();
				byRes = new byte[223];
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct SearchEventUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLen;
			[FieldOffset(0)]
			public EventAlarmBybit struAlarmParam;
			[FieldOffset(0)]
			public EventAlarmByvalue struAlarmParamByValue;
			[FieldOffset(0)]
			public EventMotionBybit struMotionParam;
			[FieldOffset(0)]
			public EventMotionByvalue struMotionParamByValue;
			[FieldOffset(0)]
			public EventVcaBybit struVcaParam;
			[FieldOffset(0)]
			public EventVcaByvalue struVcaParamByValue;
			[FieldOffset(0)]
			public EventInquestParam struInquestParam;
			[FieldOffset(0)]
			public EventVcadetectBybit struVCADetectByBit;
			[FieldOffset(0)]
			public EventVcadetectByvalue struVCADetectByValue;
			[FieldOffset(0)]
			public EventStreamidParam struStreamIDParam;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSearchEventParam
		{
			public ushort wMajorType;//0-移动侦测，1-报警输入, 2-智能事件
			public ushort wMinorType;//搜索次类型- 根据主类型变化，0xffff表示全部
			public NetDvrTime struStartTime;//搜索的开始时间，停止时间: 同时为(0, 0) 表示从最早的时间开始，到最后，最前面的4000个事件
			public NetDvrTime struEndTime;
			public byte byLockType;		// 0xff-全部，0-未锁，1-锁定
			public byte byValue;			//0-按位表示，1-按值表示
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
			public SearchEventUnion uSeniorPara;
		}

		//报警输入结果
		[StructLayout(LayoutKind.Sequential)]
		public struct EventAlarmRet
		{
			public uint dwAlarmInNo;//报警输入号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[SearchEventInfoLen];
			}
		}
		//移动侦测结果
		[StructLayout(LayoutKind.Sequential)]
		public struct EventMotionRet
		{
			public uint dwMotDetNo;//移动侦测通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[SearchEventInfoLen];
			}
		}
		//行为分析结果 
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcaRet
		{
			public uint dwChanNo;//触发事件的通道号
			public byte byRuleID;//规则ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//规则名称
			public NetVcaEventUnion uEvent;//行为事件参数，wMinorType = VCA_EVENT_TYPE决定事件类型

			public void Init()
			{
				byRes1 = new byte[3];
				byRuleName = new byte[NameLen];
			}
		}

		//审讯事件查询结果 
		[StructLayout(LayoutKind.Sequential)]
		public struct EventInquestRet
		{
			public byte byRoomIndex;  //审讯室编号,从1开始
			public byte byDriveIndex; //刻录机编号,从1开始
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //保留            
			public uint dwSegmentNo;     //本片断在本次审讯中的序号,从1开始 
			public ushort wSegmetSize;     //本片断的大小, 单位M 
			public ushort wSegmentState;   //本片断状态 0 刻录正常，1 刻录异常，2 不刻录审讯
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;     //保留

			public void Init()
			{
				byRes1 = new byte[6];
				byRes2 = new byte[288];
			}
		}

		//流id录像查询结果
		[StructLayout(LayoutKind.Sequential)]
		public struct EventStreamidRet
		{
			public uint dwRecordType;	//录像类型 0-定时录像 1-移动侦测 2-报警录像 3-报警|移动侦测 4-报警&移动侦测 5-命令触发 6-手动录像 7-震动报警 8-环境触发 9-智能报警 10-回传录像
			public uint dwRecordLength;	//录像大小
			public byte byLockFlag;    // 锁定标志 0：没锁定 1：锁定
			public byte byDrawFrameType;    // 0：非抽帧录像 1：抽帧录像
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byFileName; 	//文件名
			public uint dwFileIndex;    		// 存档卷上的文件索引
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes1 = new byte[2];
				byFileName = new byte[NameLen];
				byRes = new byte[256];
			}
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct SearchEventRet
		{
			[FieldOffset(0)]
			public EventAlarmRet struAlarmRet;
			[FieldOffset(0)]
			public EventMotionRet struMotionRet;
			[FieldOffset(0)]
			public EventVcaRet struVcaRet;
			[FieldOffset(0)]
			public EventInquestRet struInquestRet;
			[FieldOffset(0)]
			public EventStreamidRet struStreamIDRet;
			public void Init()
			{
				struAlarmRet = new EventAlarmRet();
				struAlarmRet.Init();
				//struMotionRet = new EVENT_MOTION_RET();
				//struMotionRet.Init();
			}
		}
		//查找返回结果
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSearchEventRet
		{
			public ushort wMajorType;//主类型MA
			public ushort wMinorType;//次类型
			public NetDvrTime struStartTime;//事件开始的时间
			public NetDvrTime struEndTime;//事件停止的时间，脉冲事件时和开始时间一样
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byChan;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public SearchEventRet uSeniorRet;

			public void Init()
			{
				byChan = new byte[MaxChannumV30];
				byRes = new byte[36];
				uSeniorRet = new SearchEventRet();
				uSeniorRet.Init();
			}
		}

		//SDK_V35  2009-10-26

		// 标定配置类型
		public enum TagCalibrateType
		{
			PdcCalibrate  = 0x01,  // PDC 标定
			BehaviorOutCalibrate  = 0x02, //行为室外场景标定  
			BehaviorInCalibrate = 0x03,    // 行为室内场景标定 
			ItsCalbirete       = 0x04      //  交通事件标定
		}

		public const int MaxRectNum = 6;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRectList
		{	
			public byte byRectNum;    // 矩形框的个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //保留字节 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRectNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaRect[] struVcaRect; // 最大为6个Rect 
		}

		// PDC 标定参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcCalibration
		{
			public NetDvrRectList struRectList;       // 标定矩形框列表
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // 保留字节 
		}

		// 标定线的属性类别，用来表示当前标定线在实际表示的是高度线还是长度线。
		public enum LineMode
		{
			HeightLine,        //高度样本线
			LengthLine        //长度样本线
		}
		/*在设置标定信息的时候，如果相应位设置了使能，并设置相关参数，若没有设置使能，则标定后可以获取相关的摄像机参数*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraParam
		{
			public byte byEnableHeight;     // 是否使能设置摄像机高度线
			public byte byEnableAngle;      // 是否使能设置摄像机俯仰角度
			public byte byEnableHorizon;    // 是否使能设置摄像机地平线
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // 保留字节 
			public float  fCameraHeight;    // 摄像机高度
			public float  fCameraAngle;     // 摄像机俯仰角度
			public float  fHorizon;         // 场景中的地平线
		}
		
		/*当fValue表示目标高度的时候，struStartPoint和struEndPoint分别表示目标头部点和脚部点。
		 * 当fValue表示线段长度的时候，struStartPoint和struEndPoint分别表示线段起始点和终点，
		 * mode表示当前样本线表示高度线还是长度线。*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLineSegment
		{
			public byte byLineMode;     // 参照 LINE_MODE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // 保留字节 
			public NetVcaPoint   struStartPoint;  
			public NetVcaPoint   struEndPoint;
			public float fValue;
		}

		public const int MaxLineSegNum = 8;

		/*标定样本线目前需要4-8调样本线，以获取摄像机相关参数*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBehaviorOutCalibration
		{
			public uint dwLineSegNum;          // 样本线个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLineSegNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLineSegment[]  struLineSegment;    // 样本线最大个数
			public NetDvrCameraParam  struCameraParam;    // 摄像机参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*该结构体表示IAS智能库标定样本，其中包括一个目标框和一条对应的高度标定线；
		 * 目标框为站立的人体外接矩形框；高度线样本标识从人头顶点到脚点的标定线；用归一化坐标表示；*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInCalSample
		{
			public NetVcaRect struVcaRect;   // 目标框
			public NetDvrLineSegment struLineSegment;    // 高度标定线
		}

		public const int MaxSampleNum = 5;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBehaviorInCalibration 
		{
			public uint dwCalSampleNum;      //  标定样本个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSampleNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInCalSample[]  struCalSample; // 标定样本最大个数
			public NetDvrCameraParam    struCameraParam;    // 摄像机参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int CalibPtNum = 4;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrItsCalibration
		{
			public uint dwPointNum; //标定点数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CalibPtNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPoint[] struPoint; //图像坐标
			public float fWidth;
			public float fHeight;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;        // 保留字节
		}

		// 标定参数联合体
		// 后续的相关标定参数可以放在该结构里面
		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrCalibrationPrarmUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //联合体结构大小
			[FieldOffset(0)]
			public NetDvrPdcCalibration struPDCCalibration;  //PDC 标定参数
			[FieldOffset(0)]
			public NetDvrBehaviorOutCalibration  struBehaviorOutCalibration;  //  行为室外场景标定  主要应用于IVS等
			[FieldOffset(0)]
			public NetDvrBehaviorInCalibration  struBehaviorInCalibration;     // 行为室内场景标定，主要应用IAS等 
			[FieldOffset(0)]
			public NetDvrItsCalibration struITSCalibration;
		}

		// 标定配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCalibrationCfg
		{
			public uint dwSize;               //标定结构大小
			public byte byEnable;           // 是否启用标定
			public byte byCalibrationType;    // 标定类型 根据不同类型在联合体类选择不同的标定 参考CALIBRATE_TYPE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrCalibrationPrarmUnion uCalibrateParam;  // 标定参数联合体
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//流量统计方向结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcEnterDirection
		{
			public NetVcaPoint struStartPoint; //流量统计方向起始点
			public NetVcaPoint struEndPoint;    // 流量统计方向结束点 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcRuleCfg
		{
			public uint dwSize;              //结构大小
			public byte byEnable;             // 是否激活规则;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       // 保留字节 
			public NetVcaPolygon  struPolygon;            // 多边形
			public NetDvrPdcEnterDirection  struEnterDirection;    // 流量进入方向
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcRuleCfgV41
		{
			public uint dwSize;              //结构大小
			public byte byEnable;             // 是否激活规则;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       // 保留字节 
			public NetVcaPolygon struPolygon;            // 多边形
			public NetDvrPdcEnterDirection  struEnterDirection;    // 流量进入方向
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime struAlarmTime;//布防时间
			public NetDvrTimeEx struDayStartTime; //白天开始时间，时分秒有效
			public NetDvrTimeEx struNightStartTime; //夜晚开始时间，时分秒有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // 保留字节
		}

		//试用版信息结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrialVersionCfg
		{
			public uint dwSize;
			public ushort wReserveTime; //试用期剩余时间，0xffff表示无效，单位：天
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSynChannelNameParam
		{
			public uint dwSize;
			public uint dwChannel; //通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrResetCounterCfg
		{
			public uint dwSize;
			public byte byEnable; //是否启用，0-不启用，1-启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrTimeEx[] struTime;//数据清零时间，时分秒有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaCtrlinfoCond
		{
			public uint dwSize;
			public NetDvrStreamInfo  struStreamInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaCtrlinfoCfg
		{
			public uint dwSize;
			public byte byVCAEnable;     //是否开启智能
			public byte byVCAType;       //智能能力类型，VcaChanAbilityType 
			public byte byStreamWithVCA; //码流中是否带智能信息
			public byte byMode;			//模式，ATM 能力时参照VCA_CHAN_MODE_TYPE ,TFS 能力时参照 TFS_CHAN_MODE_TYPE，行为分析完整版时参照BEHAVIOR_SCENE_MODE_TYPE
			public byte byControlType;   //控制类型，按位表示，0-否，1-是
							//byControlType &1 是否启用抓拍功能
							//byControlType &2 是否启用联动前端设备
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 		//保留，设置为0
		}

		/*设置人流量统计参数  复用行为内部关键字参数
		 * HUMAN_GENERATE_RATE
		 * 目标生成速度参数，控制PDC库生成目标的速度。速度越快，目标越容易生成。
		 * 当输入视频光照条件较差，对比度较低时，或者设置的规则区域较小时，应加快目标生成速度， 避免目标的漏检；
		 * 当输入视频中对比度较高时，或者规则区域较大时，应该降低目标生成速度，以减少误检。
		 * 目标生成速度参数共有5级，1级速度最慢，5级最快，默认参数为3。
		 *
		 * DETECT_SENSITIVE
		 * 目标检测灵敏度控制参数，控制PDC库中一个矩形区域被检测为目标的灵敏度。
		 * 灵敏度越高，矩形区域越容易被检测为目标，灵敏度越低则越难检测为目标。
		 * 当输入视频光照条件较差，对比度较低时，应提高检测灵敏度， 避免目标的漏检；
		 * 当输入视频中对比度较高时，应该降低检测灵敏度，以减少误检。
		 * 对应参数共有5级，级别1灵敏度最低，5级最高，默认级别为3。
		 * 
		 * TRAJECTORY_LEN
		 * 轨迹生成长度控制参数，表示生成轨迹时要求目标的最大位移像素。
		 * 对应参数共有5级，级别1，生成长度最长，轨迹生成最慢，5级生成长度最短，轨迹生成最快，默认级别为3。
		 * 
		 * TRAJECT_CNT_LEN
		 * 轨迹计数长度控制参数，表示轨迹计数时要求目标的最大位移像素。
		 * 对应参数共有5级，级别1，计数要求长度最长，轨迹计数最慢，5级计数要求长度最短，轨迹计数最快，默认级别为3。
		 * 
		 * PREPROCESS
		 * 图像预处理控制参数，0 - 不处理；1 - 处理。默认为0；
		 * 
		 * CAMERA_ANGLE
		 * 摄像机角度输入参数， 0 - 倾斜； 1 - 垂直。默认为0；
		 */

		public enum PdcParamKey
		{
			HumanGenerateRate = 50,  // 目标生成速度 从50开始
			DetectSensitive    = 51,  // 检测灵敏度
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcTargetInfo
		{
			public uint dwTargetID;                 // 目标id 
			public NetVcaRect struTargetRect;    // 目标框
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;      // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcTargetInFrame
		{
			public byte byTargetNum;                   //目标个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] yRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTargetNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPdcTargetInfo[]  struTargetInfo;   //目标信息数组
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                  // 保留字节
		}

		//单帧统计结果时使用
		[StructLayout(LayoutKind.Sequential)]
		public struct UnionStatframe
		{
			public uint dwRelativeTime;     // 相对时标
			public uint dwAbsTime;          // 绝对时标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionStattime
		{
			public NetDvrTime tmStart; // 统计起始时间 
			public NetDvrTime tmEnd;  //  统计结束时间 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcAlramInfo
		{
			public uint dwSize;           // PDC人流量报警上传结构体大小
			public byte byMode;            // 0 单帧统计结果 1最小时间段统计结果  
			public byte byChannel;           // 报警上传通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;         // 保留字节   
			public NetVcaDevInfo  	 struDevInfo;		        //前端设备信息
			[StructLayout(LayoutKind.Explicit)]
			public struct UStatModeParam
			{
				[FieldOffset(0)]
				//单帧统计结果时使用
				public UnionStatframe struStatFrame;

				[FieldOffset(0)]
				public UnionStattime struStatTime;
			}
			public uint dwLeaveNum;        // 离开人数
			public uint dwEnterNum;        // 进入人数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;           // 保留字节
		}

		//人流量信息查询
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcQuery
		{
			public NetDvrTime tmStart;
			public NetDvrTime tmEnd;
			public uint dwLeaveNum;
			public uint dwEnterNum; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzPosition
		{
			// 是否启用场景，在设置场景行为规则的时候该字段无效，在设置球机本地配置场景位置信息时作为使能位
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPtzPositionName; //场景位置名称
			public NetDvrPtzpos struPtzPos; //ptz 坐标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionRuleCfg
		{
			public uint dwSize;             // 结构大小 
			public NetDvrPtzPosition    struPtzPosition;    // 场景位置信息
			public NetVcaRulecfg         struVcaRuleCfg;     //行为规则配置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         // 保留字节
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionRuleCfgV41
		{
			public uint dwSize;             // 结构大小 
			public NetDvrPtzPosition  struPtzPosition;    // 场景位置信息
			public NetVcaRulecfgV41   struVcaRuleCfg;     //行为规则配置
			public byte byTrackEnable; //是否启用跟踪
			public byte byRes1;
			public ushort wTrackDuration; //跟踪持续时间，单位s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLimitAngle
		{
			public byte byEnable;	// 是否启用场景限位功能
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrPtzpos  struUp;     // 上限位
			public NetDvrPtzpos  struDown;   // 下限位
			public NetDvrPtzpos  struLeft;   // 左限位
			public NetDvrPtzpos  struRight;  // 右限位
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionIndex
		{
			public byte byIndex;    // 场景索引
			public byte byRes1;
			public ushort wDwell;	// 停留时间 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   // 保留字节
		}

		public const int MaxPositionNum = 10;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionTrackCfg
		{
			public uint dwSize;
			public byte byNum; // 场景个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPositionNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPositionIndex[]   struPositionIndex;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		
		//巡航路径场景信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPatrolSceneInfo
		{
			public ushort wDwell;         // 停留时间 30-300
			public byte byPositionID;   // 场景号1-10，默认0表示该巡航点不添加场景
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//场景巡航跟踪配置信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPatrolTrackcfg
		{
			public uint dwSize;  // 结构大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPatrolSceneInfo[] struPatrolSceneInfo;    // 巡航路径
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                              // 保留字节
		}

		//球机本地规则菜单配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackParamcfg
		{
			public uint dwSize;             // 结构大小
			public ushort wAlarmDelayTime;    // 报警延时时间，目前球机只支持全局入侵 范围1-120秒
			public ushort wTrackHoldTime;     // 报警跟踪持续时间  范围0-300秒
			public byte byTrackMode;        //  参照 IPDOME_TRACK_MODE
			public byte byPreDirection;	// 跟踪方向预判 0-不启用 1-启用
			public byte byTrackSmooth;	    // 跟踪连续  0-不启用 1-启用
			public byte byZoomAdjust;	// 倍率系数调整 参见下表
			public byte byMaxTrackZoom;	//最大跟踪倍率系数,0-表示默认倍率系数,等级6-标定值*1.0(默认),1-5为缩小标定值，值越小，缩小的比例越大,7-15为放大，值越大，放大的比例越大
			public byte byStopTrackWhenFindFace;  //人脸检测到后是否停止跟踪 0-否 1-是
			public byte byStopTrackThreshold;   //跟踪终止评分阈值
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //  保留字节                
		}

		//球机机芯参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDomeMovementParam
		{
			public ushort wMaxZoom;   // 球机最大倍率系数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // 保留字节
		}

		/********************************智能交通事件 begin****************************************/
		public const int MaxRegionNum	= 8;  // 区域列表最大数目
		public const int MaxTpsRule = 8;   // 最大参数规则数目
		public const int MaxAidRule = 8;   // 最大事件规则数目
		public const int MaxLaneNum = 8;   // 最大车道数目

		//交通事件类型
		public enum TrafficAidType
		{
			Congestion            = 0x01,    //拥堵
			Parking               = 0x02,    //停车  
			Inverse               = 0x04,    //逆行
			Pedestrian            = 0x08,    //行人                      
			Debris                = 0x10,    //遗留物 抛洒物碎片 
			Smoke                 = 0x20,    //烟雾  
			Overline              = 0x40,     //压线
			VehicleControlList  = 0x80,  //黑名单数据
			Speed                 = 0x100  //超速
		}
		
		public enum TrafficSceneMode
		{
			Freeway = 0,	//  高速户外场景
			Tunnel,         //  高速隧道场景
			Bridge          //  高速桥梁场景
		}
		
		public enum ItsAbilityType
		{
			ItsCongestionAbility             = 0x01,      //拥堵
			ItsParkingAbility                = 0x02,      //停车  
			ItsInverseAbility                = 0x04,      //逆行
			ItsPedestrianAbility             = 0x08,      //行人                      
			ItsDebrisAbility                 = 0x10,      //遗留物 抛洒物碎片
			ItsSmokeAbility                  = 0x20,      //烟雾-隧道
			ItsOverlineAbility               = 0x40,      //压线
			ItsVehicleControlListAbility   = 0x80,		//黑名单数据
			ItsSpeedAbility				   = 0x100,	    //超速	
			ItsLaneVolumeAbility            = 0x010000,  //车道流量
			ItsLaneVelocityAbility          = 0x020000,  //车道平均速度
			ItsTimeHeadwayAbility           = 0x040000,  //车头时距
			ItsSpaceHeadwayAbility          = 0x080000,  //车头间距
			ItsTimeOccupancyRatioAbility   = 0x100000,  //车道占有率，（时间上)
			ItsSpaceOccupancyRatioAbility  = 0x200000,  //车道占有率，百分比计算（空间上)
			ItsLaneQueueAbility             = 0x400000,  //排队长度
			ItsVehicleTypeAbility           = 0x800000,  //车辆类型
			ItsTrafficStateAbility          = 0x1000000  //交通状态
		}
		
		// 交通统计参数
		public enum ItsTpsType
		{
			LaneVolume           = 0x01,    //车道流量
			LaneVelocity         = 0x02,    //车道速度
			TimeHeadway          = 0x04,    //车头时距
			SpaceHeadway         = 0x08,    //车头间距
			TimeOccupancyRatio  = 0x10,    //车道占有率 (时间上)
			SpaceOccupancyRatio = 0x20,    //车道占有率，百分比计算(空间上)
			Queue                 = 0x40,    //排队长度
			VehicleType          = 0x80,    //车辆类型
			TrafficState         = 0x100    //交通状态
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRegionList
		{
			public uint dwSize;	// 结构体大小
			public byte byNum;      // 区域个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRegionNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPolygon[] struPolygon; // 区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	// 保留字节
		}

		//方向结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDirection
		{
			public NetVcaPoint struStartPoint;   // 方向起始点
			public NetVcaPoint struEndPoint;     // 方向结束点 
		}

		//单个车道
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneLane
		{
			public byte byEnable;  //车道是否启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	   // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLaneName;       // 车道规则名称
			public NetDvrDirection struFlowDirection;// 车道内车流方向
			public NetVcaPolygon struPolygon;		// 车道区域
		}

		//车道配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneCfg
		{
			public uint dwSize;	// 结构体大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLaneNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneLane[] struLane;	// 车道参数 数组下标作为车道ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	 // 保留字节
		}

		//交通事件参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidParam
		{
			public ushort wParkingDuration;       // 违停检测灵敏度  10-120s
			public ushort wPedestrianDuration;    // 行人持续时间    1-120s
			public ushort wDebrisDuration;        // 抛洒物持续时间  10-120s
			public ushort wCongestionLength;      // 拥堵长度阈值    5-200（米）
			public ushort wCongestionDuration;    // 拥堵持续参数    10-120s
			public ushort wInverseDuration;       // 逆行持续时间    1-10s
			public ushort wInverseDistance;       // 逆行距离阈值 单位m 范围[2-100] 默认 10米
			public ushort wInverseAngleTolerance; // 允许角度偏差 90-180度,车流与逆行允许的夹角
			public ushort wIllegalParkingTime;    // 违停时间[4,60]，单位：分钟 ,TFS(交通违章取证) 城市模式下
			public ushort wIllegalParkingPicNum;  // 违停图片数量[1,6], TFS(交通违章取证) 城市模式下
			public byte byMergePic;             // 图片拼接,TFS 城市模式下 0- 不拼接 1- 拼接
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;             // 保留字节
		}

		//单条交通事件规则结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneAidRule
		{   
			public byte byEnable;                   // 是否启用事件规则
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                  // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;       // 规则名称 
			public uint dwEventType;                // 交通事件检测类型 TRAFFIC_AID_TYPE
			public NetVcaSizeFilter struSizeFilter; // 尺寸过滤器
			public NetVcaPolygon     struPolygon;    // 规则区域
			public NetDvrAidParam   struAIDParam;   //  事件参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]   struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;	  //处理方式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;        //报警触发的录象通道,为1表示触发该通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//交通事件规则
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidRulecfg
		{
			public uint dwSize;                    // 结构体大小 
			public byte byPicProType;              //报警时图片处理方式 0-不处理 非0-上传
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                 // 保留字节
			public NetDvrJpegpara struPictureParam; //图片规格结构
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAidRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneAidRule[]  struOneAIDRule;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//单条交通事件规则结构体(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneAidRuleV41
		{   
			public byte byEnable;                 // 是否启用事件规则
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;     // 规则名称 
			public uint dwEventType;              // 交通事件检测类型 TRAFFIC_AID_TYPE
			public NetVcaSizeFilter struSizeFilter;           // 尺寸过滤器
			public NetVcaPolygon struPolygon;              // 规则区域
			public NetDvrAidParam struAIDParam;             // 事件参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;// 布防时间段
			public NetDvrHandleexceptionV30 struHandleType;	          //处理方式 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIvmsIpChannel, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //报警触发的录象通道：1表示触发该通道；0表示不触发
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;               //保留
		}

		//交通事件规则(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidRulecfgV41
		{
			public uint dwSize;                     // 结构体大小 
			public byte byPicProType;               // 报警时图片处理方式 0-不处理 非0-上传
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                  // 保留字节
			public NetDvrJpegpara struPictureParam; 	// 图片规格结构
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAidRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneAidRuleV41[]  struAIDRule;  //规则数组
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                //保留
		}

		//交通统计参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneTpsRule
		{
			public byte byEnable;                   //是否使能车道交通规则参数
			public byte byLaneID;		            //车道ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwCalcType;                 //统计参数类型ITS_TPS_TYPE
			public NetVcaSizeFilter struSizeFilter; //尺寸过滤器 
			public NetVcaPolygon struVitrualLoop;    //虚拟线圈
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;	//处理方式,一般为处理是否上传中心，其他功能不需要
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                         //保留字节
		}

		//交通参数统计规则配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsRulecfg
		{
			public uint dwSize;              // 结构大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneTpsRule[] struOneTpsRule; // 下标对应交通参数ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         // 保留字节
		}

		//交通统计参数结构体(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneTpsRuleV41
		{
			public byte byEnable;                     //是否使能车道交通规则参数
			public byte byLaneID;		              //车道ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                    //保留
			public uint dwCalcType;                   // 统计参数类型ITS_TPS_TYPE
			public NetVcaSizeFilter  struSizeFilter;  //尺寸过滤器 
			public NetVcaPolygon  struVitrualLoop; //虚拟线圈
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]  struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;	   //处理方式 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                   // 保留字节
		}

		//交通参数统计规则配置结构体(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsRulecfgV41
		{
			public uint dwSize;         // 结构大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneTpsRuleV41[] struOneTpsRule; // 下标对应交通参数ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     // 保留
		}

		//交通事件信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidInfo
		{
			public byte byRuleID;   // 规则序号，为规则配置结构下标，0-16
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName; //  规则名称
			public uint dwAIDType;  // 报警事件类型
			public NetDvrDirection   struDirect; // 报警指向区域  
			public byte bySpeedLimit; //限速值，单位km/h[0,255]
			public byte byCurrentSpeed; //当前速度值，单位km/h[0,255]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;  // 保留字节 
		}

		//交通事件报警 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidAlarm
		{
			public uint dwSize;         // 结构长度
			public uint dwRelativeTime;	// 相对时标
			public uint dwAbsTime;		// 绝对时标
			public NetVcaDevInfo struDevInfo;	// 前端设备信息
			public NetDvrAidInfo struAIDInfo;    // 交通事件信息
			public uint dwPicDataLen;   // 返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据
			public IntPtr pImage;        // 指向图片的指针
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // 保留字节  
		}

		//车道队列结构体 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneQueue
		{
			public NetVcaPoint struHead;       //队列头
			public NetVcaPoint struTail;       //队列尾
			public uint dwLength;      //实际队列长度 单位为米 [0-500]
		}

		public enum TrafficDataVaryType
		{
			NoVary,         //无变化 
			VehicleEnter,   //车辆进入虚拟线圈
			VehicleLeave,   //车辆离开虚拟线圈 
			UeueVary        //队列变化             
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;  //车道规则名称 
			public byte byRuleID;              //规则序号，为规则配置结构下标，0-7 
			public byte byVaryType;            //车道交通参数变化类型 参照 TRAFFIC_DATA_VARY_TYPE
			public byte byLaneType;			   //车道上行或下行
			public byte byRes1;
			public uint dwLaneVolume;         //车道流量 ，统计有多少车子通过
			public uint dwLaneVelocity;        //车道速度，公里计算
			public uint dwTimeHeadway;         //车头时距，以秒计算
			public uint dwSpaceHeadway;        //车头间距，以米来计算
			public float fSpaceOccupyRation;    //车道占有率，百分比计算（空间上)
			public NetDvrLaneQueue struLaneQueue;    //车道队列长度
			public NetVcaPoint struRuleLocation; //线圈规则的中心点位置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsInfo
		{
			public uint dwLanNum;   // 交通参数的车道数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLaneParam[]  struLaneParam;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsAlarm
		{
			public uint dwSize;          //结构体大小
			public uint dwRelativeTime;  //相对时标
			public uint dwAbsTime;       //绝对时标
			public NetVcaDevInfo  struDevInfo;     //前端设备信息
			public NetDvrTpsInfo  struTPSInfo;     //交通事件信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;      //保留字节
		}
		
		public enum TrafficDataVaryTypeExEnum
		{    
			EnumTrafficVaryNo             = 0x00,   //无变化
			EnumTrafficVaryVehicleEnter  = 0x01,   //车辆进入虚拟线圈
			EnumTrafficVaryVehicleLeave  = 0x02,   //车辆离开虚拟线圈
			EnumTrafficVaryQueue          = 0x04,   //队列变化
			EnumTrafficVaryStatistic      = 0x08,   //统计数据变化（每分钟变化一次包括平均速度，车道空间/时间占有率，交通状态）        
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneParamV41
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName; // 车道规则名称
			public byte byRuleID;             // 规则序号，为规则配置结构下标，0-7 
			public byte byLaneType;		     // 车道上行或下行
			public byte byTrafficState;       // 车道的交通状态，0-无效，1-畅通，2-拥挤，3-堵塞
			public byte byRes1;               // 保留
			public uint dwVaryType;           // 车道交通参数变化类型参照  TrafficDataVaryTypeExEnum，按位区分
			public uint dwTpsType;            // 数据变化类型标志，表示当前上传的统计参数中，哪些数据有效，参照ITS_TPS_TYPE,按位区分
			public uint dwLaneVolume;	     // 车道流量，统计有多少车子通过
			public uint dwLaneVelocity;       // 车道速度，公里计算
			public uint dwTimeHeadway ;       // 车头时距，以秒计算
			public uint dwSpaceHeadway;       // 车头间距，以米来计算
			public float fSpaceOccupyRation;   // 车道占有率，百分比计算（空间上)
			public float fTimeOccupyRation;    // 时间占有率，百分比计算
			public uint dwLightVehicle;       // 小型车数量
			public uint dwMidVehicle;         // 中型车数量
			public uint dwHeavyVehicle;       // 重型车数量
			public NetDvrLaneQueue struLaneQueue;        // 车道队列长度
			public NetVcaPoint struRuleLocation;     // 规则位置虚拟线圈的中心
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;           // 保留
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsInfoV41
		{
			public uint dwLanNum;          // 交通参数的车道数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLaneParamV41[]  struLaneParam;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //保留
		}

		//人脸规则配置 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacedetectRulecfg
		{
			public uint dwSize;              // 结构体大小
			public byte byEnable;            // 是否启用
			public byte byEventType;			//警戒事件类型， 0-异常人脸; 1-正常人脸;2-异常人脸&正常人脸;
			public byte byUpLastAlarm;       //2011-04-06 是否先上传最近一次的报警
			public byte byUpFacePic; //是否上传人脸子图，0-否，1-是	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;
			public NetVcaPolygon     struVcaPolygon;    // 人脸检测规则区域
			public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
			public byte bySensitivity;   // 规则灵敏度
			public ushort wDuration;      // 触发人脸报警时间阈值
			public NetDvrJpegpara    struPictureParam; 		//图片规格结构
			public NetVcaSizeFilter struSizeFilter;         //尺寸过滤器
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;	  //处理方式 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;			//报警触发的录象通道,为1表示触发该通道
			public byte byPicRecordEnable;  /*2012-3-1是否启用图片存储, 0-不启用, 1-启用*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         //保留字节
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacePipcfg
		{	
			public byte byEnable; //是否开启画中画
			public byte byBackChannel; //背景通道号（面板通道）
			public byte byPosition; //叠加位置，0-左上,1-左下,2-右上,3-右下
			public byte byPIPDiv; //分屏系数(人脸画面:面板画面)，0-1:4,1-1:9,2-1:16
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacedetectRulecfgV41
		{
			public uint dwSize;              // 结构体大小
			public byte byEnable;            // 是否启用
			public byte byEventType;			//警戒事件类型， 0-异常人脸; 1-正常人脸;2-异常人脸&正常人脸;
			public byte byUpLastAlarm;       //2011-04-06 是否先上传最近一次的报警
			public byte byUpFacePic; //是否上传人脸子图，0-否，1-是	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;
			public NetVcaPolygon struVcaPolygon;    // 人脸检测规则区域
			public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
			public byte bySensitivity;   // 规则灵敏度
			public ushort wDuration;      // 触发人脸报警时间阈值
			public NetDvrJpegpara    struPictureParam; 		//图片规格结构
			public NetVcaSizeFilter struSizeFilter;         //尺寸过滤器
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]   struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;	  //处理方式 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;			//报警触发的录象通道,为1表示触发该通道
			public byte byPicRecordEnable;  /*2012-10-22是否启用图片存储, 0-不启用, 1-启用*/
			public byte byRes1;
			public ushort wAlarmDelay; //2012-10-22智能报警延时，0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
			public NetDvrFacePipcfg struFacePIP; //2012-11-7画中画参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //保留字节
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacedetectAlarm
		{
			public uint dwSize;     		// 结构大小
			public uint dwRelativeTime; // 相对时标
			public uint dwAbsTime;			// 绝对时标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;   // 规则名称
			public NetVcaTargetInfo  struTargetInfo;	//报警目标信息
			public NetVcaDevInfo  	 struDevInfo;		//前端设备信息
			public uint dwPicDataLen;						//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据*/
			public byte byAlarmPicType;			// 0-异常人脸报警图片 1- 人脸图片,2-多张人脸 
			public byte byPanelChan;        /*2012-3-1人脸通道关联的面板通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwFacePicDataLen;			//人脸图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // 保留字节
			public IntPtr pFaceImage; //指向人脸图指针
			public IntPtr pImage;   						//指向图片的指针
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventParamUnion
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
			public uint[] uLen;        	// 联合体大小为12字节
			public uint dwHumanIn;  	//有无人接近 0 - 无人 1- 有人  
			public float fCrowdDensity;  // 人员聚集值
		}

		//目前只有有人无人事件和人员聚集事件实时报警上传
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventInfo
		{
			public byte byRuleID;				// Rule ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				// 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;	// 规则名称
			public uint dwEventType;    		// 参照VCA_EVENT_TYPE
			public NetDvrEventParamUnion uEventParam;  // 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventInfoList
		{
			public byte byNum;		// 事件实时信息个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			// 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEventInfo[] struEventInfo;	// 事际实时信息
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRuleInfoAlarm
		{
			public uint dwSize;				// 结构体大小
			public uint dwRelativeTime; 	// 相对时标
			public uint dwAbsTime;			// 绝对时标
			public NetVcaDevInfo  	struDevInfo;		// 前端设备信息
			public NetDvrEventInfoList struEventInfoList;	//事件信息列表
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			// 保留字节
		}

		//单条场景时间段
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneSceneTime
		{
			public byte byActive;                     //0 -无效,1–有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                    //保留
			public uint dwSceneID;                    //场景ID
			public NetDvrSchedtime struEffectiveTime;   //场景起效时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                   //保留
		}

		//场景起效时间段配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneTimeCfg
		{   
			public uint dwSize;                                               //结构大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSceneTimesegNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneSceneTime[] struSceneTime; //场景时间段数组
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                                            //保留
		}

		//单条场景配置信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneSceneCfg
		{    
			public byte byEnable;                 //是否启用该场景,0-不启用 1- 启用
			public byte byDirection;              //监测方向 1-上行，2-下行，3-双向，4-由东向西，5-由南向北，6-由西向东，7-由北向南，8-其它
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                //保留
			public uint dwSceneID;                //场景ID(只读), 0 - 表示该场景无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] bySceneName;    //场景名称
			public NetDvrPtzpos struPtzPos;       //ptz 坐标
			public uint dwTrackTime;              //球机跟踪时间[5,300] 秒，TFS(交通取证)模式下有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;               //保留
		}

		//场景配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneCfg
		{
			public uint dwSize;                                          //结构大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxItsSceneNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneSceneCfg[] struSceneCfg; //场景配置信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                                      //保留
		}

		//多场景操作条件
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneCond
		{
			public uint dwSize;       //结构大小
			public int lChannel;     //通道号
			public uint dwSceneID;    //场景ID, 0-表示该场景无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //保留
		}

		//取证方式
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrForensicsMode
		{
			public uint dwSize;      //结构大小
			public byte byMode;      // 0-手动取证 ,1-自动取证
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //保留
		}

		//报警场景信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneInfo
		{  
			public uint dwSceneID;              //场景ID, 0 - 表示该场景无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] bySceneName;  //场景名称
			public byte byDirection;            //监测方向 1-上行，2-下行，3-双向，4-由东向西，5-由南向北，6-由西向东，7-由北向南，8-其它
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;              //保留
			public NetDvrPtzpos  struPtzPos;             //Ptz 坐标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2 ;            //保留
		}

		//交通事件报警(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidAlarmV41
		{
			public uint dwSize;              //结构长度
			public uint dwRelativeTime;	    //相对时标
			public uint dwAbsTime;			//绝对时标
			public NetVcaDevInfo  struDevInfo;		    //前端设备信息
			public NetDvrAidInfo  struAIDInfo;         //交通事件信息
			public NetDvrSceneInfo struSceneInfo;       //场景信息
			public uint dwPicDataLen;        //图片长度
			public IntPtr pImage; 			//指向图片的指针
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //保留
		}

		//交通统计信息报警(扩展)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsAlarmV41
		{
			public uint dwSize;          // 结构体大小
			public uint dwRelativeTime;  // 相对时标
			public uint dwAbsTime;       // 绝对时标
			public NetVcaDevInfo struDevInfo;     // 前端设备信息
			public NetDvrTpsInfoV41  struTPSInfo;     // 交通参数统计信息 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // 保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaVersion
		{
			public ushort wMajorVersion;		// 主版本号
			public ushort wMinorVersion;		// 次版本号
			public ushort wRevisionNumber;	// 修正号
			public ushort wBuildNumber;		// 编译号
			public ushort wVersionYear;		//	版本日期-年
			public byte byVersionMonth;		//	版本日期-月
			public byte byVersionDay;		//	版本日期-日
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;			// 保留字节
		}
		/*******************************智能交通事件 end*****************************************/

		/******************************车牌识别 begin******************************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateParam
		{	
			public byte byPlateRecoMode;    //车牌识别的模式,默认为1(视频触发模式)
			public byte byBelive;	/*整牌置信度阈值, 只用于视频识别方式, 根据背景复杂程度设置, 误触发率高就设高, 漏车率高就设低, 
									 * 建议在80-90范围内*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //保留字节
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlatecfg
		{	
			public uint dwSize;
			public uint dwEnable;				           /* 是否启用视频车牌识别 0－否 1－是 */
			public byte byPicProType;	//报警时图片处理方式 0-不处理 非0-上传
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  // 保留字节
			public NetDvrJpegpara struPictureParam; 		//图片规格结构
			public NetDvrPlateParam struPlateParam;   // 车牌识别参数配置
			public NetDvrHandleexception struHandleType;	   /* 处理方式 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;        //报警触发的录象通道,为1表示触发该通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // 保留字节
		}

		//车牌识别结果子结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateInfo
		{
			public byte byPlateType; //车牌类型
			public byte byColor; //车牌颜色
			public byte byBright; //车牌亮度
			public byte byLicenseLen;	//车牌字符个数
			public byte byEntireBelieve;//整个车牌的置信度，0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
			public NetVcaRect	struPlateRect;	//车牌位置
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxLicenseLen)]
			public string sLicense;	//车牌号码 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLicenseLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byBelieve; //各个识别字符的置信度，如检测到车牌"浙A12345", 置信度为,20,30,40,50,60,70，则表示"浙"字正确的可能性只有%，"A"字的正确的可能性是%
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlaterecoResule
		{
			public uint dwSize;
			public uint dwRelativeTime;	//相对时标
			public uint dwAbsTime;	//绝对时标
			public NetVcaDevInfo struDevInfo; // 前段设备信息
			public NetDvrPlateInfo struPlateInfo;
			public uint dwPicDataLen;	//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;	//保留，设置为0
			public IntPtr pImage;   //指向图片的指针
		}
		/******************************车牌识别 end******************************************/

		/******************************抓拍机*******************************************/
		//IO输入配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIoIncfg
		{
			public uint dwSize;
			public byte byIoInStatus;//输入的IO口状态，0-下降沿，1-上升沿，2-上升沿和下降沿，3-高电平，4-低电平
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留字节
		}

		//IO输出配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIoOutcfg
		{
			public uint dwSize;
			public byte byDefaultStatus;//IO默认状态：0-低电平，1-高电平 
			public byte byIoOutStatus;//IO起效时状态：0-低电平，1-高电平，2-脉冲
			public ushort wAheadTime;//输出IO提前时间，单位us
			public uint dwTimePluse;//脉冲间隔时间，单位us
			public uint dwTimeDelay;//IO有效持续时间，单位us
			public byte byFreqMulti;		//倍频，数值范围[1,15]
			public byte byDutyRate;		//占空比，[0,40%]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//闪光灯配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFlashOutcfg
		{
			public uint dwSize;
			public byte byMode;//闪光灯闪烁模式，0-不闪，1-闪，2-关联闪，3-轮闪
			public byte byRelatedIoIn;//闪光灯关联的输入IO号（关联闪时此参数有效）
			public byte byRecognizedLane;  /*关联的IO号，按位表示，bit0表示IO1是否关联，0-不关联，1-关联*/
			public byte byDetectBrightness;/*自动检测亮度使能闪光灯0-不检测；1-检测*/
			public byte byBrightnessThreld;/*使能闪光灯亮度阈值，范围[0,100],高于阈值闪*/
			public byte byStartHour;		//开始时间-小时,取值范围0-23
			public byte byStartMinute;		//开始时间-分,取值范围0-59
			public byte byEndHour;		 	//结束时间-小时,取值范围0-23
			public byte byEndMinute;		//结束时间-分,取值范围0-59
			public byte byFlashLightEnable;	//设置闪光灯时间使能:0-关;1-开
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//红绿灯功能（2个IO输入一组）
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLightsnapcfg
		{
			public uint dwSize;
			public byte byLightIoIn;//红绿灯的IO 号
			public byte byTrigIoIn;//触发的IO号
			public byte byRelatedDriveWay;//触发IO关联的车道号
			public byte byTrafficLight; //0-高电平红灯，低电平绿灯；1-高电平绿灯，低电平红灯
			public byte bySnapTimes1; //红灯抓拍次数1，0-不抓拍，非0-连拍次数，最大5次 
			public byte bySnapTimes2; //绿灯抓拍次数2，0-不抓拍，非0-连拍次数，最大5次 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime1;//红灯连拍间隔时间，ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime2;//绿灯连拍间隔时间，ms
			public byte byRecord;//闯红灯周期录像标志，0-不录像，1-录像
			public byte bySessionTimeout;//闯红灯周期录像超时时间（秒）
			public byte byPreRecordTime;//闯红灯录像片段预录时间(秒)
			public byte byVideoDelay;//闯红灯录像片段延时时间（秒）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//保留字节
		}

		//测速功能(2个IO输入一组）
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMeasurespeedcfg
		{
			public uint dwSize;
			public byte byTrigIo1;   //测速第1线圈
			public byte byTrigIo2;   //测速第2线圈
			public byte byRelatedDriveWay;//触发IO关联的车道号
			public byte byTestSpeedTimeOut;//测速模式超时时间，单位s
			public uint dwDistance;//线圈距离,cm
			public byte byCapSpeed;//测速模式起拍速度，单位km/h
			public byte bySpeedLimit;//限速值，单位km/h
			public byte bySnapTimes1; //线圈1抓拍次数，0-不抓拍，非0-连拍次数，最大5次 
			public byte bySnapTimes2; //线圈2抓拍次数，0-不抓拍，非0-连拍次数，最大5次 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime1;//线圈1连拍间隔时间，ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime2;//线圈2连拍间隔时间，ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留字节
		}

		//视频参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoeffect
		{
			public byte byBrightnessLevel; /*0-100*/
			public byte byContrastLevel; /*0-100*/
			public byte bySharpnessLevel; /*0-100*/
			public byte bySaturationLevel; /*0-100*/
			public byte byHueLevel; /*0-100,（保留）*/
			public byte byEnableFunc; //使能，按位表示，bit0-SMART IR(防过曝)，bit1-低照度,bit2-强光抑制使能，0-否，1-是
			public byte byLightInhibitLevel; //强光抑制等级，[1-3]表示等级
			public byte byGrayLevel; //灰度值域，0-[0-255]，1-[16-235]
		}

		//增益配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGain
		{
			public byte byGainLevel; /*增益：0-100*/
			public byte byGainUserSet; /*用户自定义增益；0-100，对于抓拍机，是CCD模式下的抓拍增益*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwMaxGainValue;/*最大增益值，单位dB*/
		}

		//白平衡配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWhitebalance
		{
			public byte byWhiteBalanceMode; /*0-手动白平衡（MWB）,1-自动白平衡1（AWB1）,2-自动白平衡2 (AWB2),3-自动控制改名为锁定白平衡(Locked WB)，
							 4-室外(Indoor)，5-室内(Outdoor)6-日光灯(Fluorescent Lamp)，7-钠灯(Sodium Lamp)，
							 8-自动跟踪(Auto-Track)9-一次白平衡(One Push)，10-室外自动(Auto-Outdoor)，
							 11-钠灯自动 (Auto-Sodiumlight)，12-水银灯(Mercury Lamp)，13-自动白平衡(Auto)，
							 14-白炽灯 (IncandescentLamp)，15-暖光灯(Warm Light Lamp)，16-自然光(Natural Light) */
			public byte byWhiteBalanceModeRGain; /*手动白平衡时有效，手动白平衡 R增益*/
			public byte byWhiteBalanceModeBGain; /*手动白平衡时有效，手动白平衡 B增益*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//曝光控制
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrExposure
		{
			public byte byExposureMode; /*0 手动曝光 1自动曝光*/
			public byte byAutoApertureLevel; /* 自动光圈灵敏度, 0-10 */ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwVideoExposureSet; /* 自定义视频曝光时间（单位us）*//*注:自动曝光时该值为曝光最慢值 新增20-1s(1000000us)*/        
			public uint dwExposureUserSet; /* 自定义曝光时间,在抓拍机上应用时，CCD模式时是抓拍快门速度*/   
			public uint dwRes;    
		}

		//宽动态配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWdr
		{
			public byte byWDREnabled; /*宽动态：0 dsibale  1 enable 2 auto*/
			public byte byWDRLevel1; /*0-F*/
			public byte byWDRLevel2; /*0-F*/
			public byte byWDRContrastLevel; /*0-100*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//日夜转换功能配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDaynight
		{
			public byte byDayNightFilterType; /*日夜切换：0-白天，1-夜晚，2-自动，3-定时，4-报警输入触发*/
			public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(保留)*/
			//定时模式参数
			public byte byBeginTime; /*开始时间（小时），0-23*/
			public byte byEndTime; /*结束时间（小时），0-23*/
			//模式2
			public byte byDayToNightFilterLevel; //0-7
			public byte byNightToDayFilterLevel; //0-7
			public byte byDayNightFilterTime;//(60秒)
			//定时模式参数
			public byte byBeginTimeMin; //开始时间（分），0-59
			public byte byBeginTimeSec; //开始时间（秒），0-59
			public byte byEndTimeMin; //结束时间（分），0-59
			public byte byEndTimeSec; //结束时间（秒），0-59
			//报警输入触发模式参数
			public byte byAlarmTrigState; //报警输入触发状态，0-白天，1-夜晚
		}

		//Gamma校正
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGammacorrect
		{
			public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
			public byte byGammaCorrectionLevel; /*0-100*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//背光补偿配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBacklight
		{
			public byte byBacklightMode; /*背光补偿:0 off 1 UP、2 DOWN、3 LEFT、4 RIGHT、5MIDDLE、6自定义*/
			public byte byBacklightLevel; /*0x0-0xF*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwPositionX1; //（X坐标1）
			public uint dwPositionY1; //（Y坐标1）
			public uint dwPositionX2; //（X坐标2）
			public uint dwPositionY2; //（Y坐标2）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//数字降噪功能
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNoiseremove
		{
			public byte byDigitalNoiseRemoveEnable; /*0-不启用，1-普通模式数字降噪，2-专家模式数字降噪*/
			public byte byDigitalNoiseRemoveLevel; /*普通模式数字降噪级别：0x0-0xF*/
			public byte bySpectralLevel;       /*专家模式下空域强度：0-100*/
			public byte byTemporalLevel;   /*专家模式下时域强度：0-100*/
			public byte byDigitalNoiseRemove2DEnable;         /* 抓拍帧2D降噪，0-不启用，1-启用 */	
			public byte byDigitalNoiseRemove2DLevel;            /* 抓拍帧2D降噪级别，0-100 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//CMOS模式下前端镜头配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCmosmodecfg
		{
			public byte byCaptureMod;   //抓拍模式：0-抓拍模式1；1-抓拍模式2
			public byte byBrightnessGate;//亮度阈值
			public byte byCaptureGain1;   //抓拍增益1,0-100
			public byte byCaptureGain2;   //抓拍增益2,0-100
			public uint dwCaptureShutterSpeed1;//抓拍快门速度1
			public uint dwCaptureShutterSpeed2;//抓拍快门速度2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//前端参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraparamcfg
		{
			public uint dwSize;
			public NetDvrVideoeffect struVideoEffect;/*亮度、对比度、饱和度、锐度、色调配置*/    
			public NetDvrGain struGain;/*自动增益*/
			public NetDvrWhitebalance struWhiteBalance;/*白平衡*/
			public NetDvrExposure struExposure; /*曝光控制*/
			public NetDvrGammacorrect struGammaCorrect;/*Gamma校正*/
			public NetDvrWdr struWdr;/*宽动态*/
			public NetDvrDaynight struDayNight;/*日夜转换*/
			public NetDvrBacklight struBackLight;/*背光补偿*/
			public NetDvrNoiseremove struNoiseRemove;/*数字降噪*/
			public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
			public byte byIrisMode; /*0 自动光圈 1手动光圈*/    
			public byte byMirror ;  /* 镜像：0 off，1- leftright，2- updown，3-center */
			public byte byDigitalZoom;  /*数字缩放:0 dsibale  1 enable*/
			public byte byDeadPixelDetect;   /*坏点检测,0 dsibale  1 enable*/
			public byte byBlackPwl;/*黑电平补偿 ,  0-255*/ 
			public byte byEptzGate;// EPTZ开关变量:0-不启用电子云台，1-启用电子云台
			public byte byLocalOutputGate;//本地输出开关变量0-本地输出关闭1-本地BNC输出打开 2-HDMI输出关闭  
					 //20-HDMI_720P50输出开
					 //21-HDMI_720P60输出开
					 //22-HDMI_1080I60输出开
					 //23-HDMI_1080I50输出开
					 //24-HDMI_1080P24输出开
					 //25-HDMI_1080P25输出开
					 //26-HDMI_1080P30输出开
					 //27-HDMI_1080P50输出开
					 //28-HDMI_1080P60输出开
					 //40-SDI_720P50,
					 //41-SDI_720P60,
					 //42-SDI_1080I50,
					 //43-SDI_1080I60,
					 //44-SDI_1080P24,
					 //45-SDI_1080P25,
					 //46-SDI_1080P30,
					 //47-SDI_1080P50,
					 //48-SDI_1080P60
			public byte byCoderOutputMode;//编码器fpga输出模式0直通3像素搬家
			public byte byLineCoding; //是否开启行编码：0-否，1-是
			public byte byDimmerMode; //调光模式：0-半自动，1-自动
			public byte byPaletteMode; //调色板：0-白热，1-黑热，2-调色板2，…，8-调色板8
			public byte byEnhancedMode; //增强方式（探测物体周边）：0-不增强，1-1，2-2，3-3，4-4
			public byte byDynamicContrastEN;    //动态对比度增强 0-1
			public byte byDynamicContrast;    //动态对比度 0-100
			public byte byJPEGQuality;    //JPEG图像质量 0-100
			public NetDvrCmosmodecfg struCmosModeCfg;//CMOS模式下前端参数配置，镜头模式从能力集获取
			public byte byFilterSwitch; //滤波开关：0-不启用，1-启用
			public byte byFocusSpeed; //镜头调焦速度：0-10
			public byte byAutoCompensationInterval; //定时自动快门补偿：1-120，单位：分钟
			public byte bySceneMode;  //场景模式：0-室外，1-室内，2-默认，3-弱光
		}

		//透雾
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDefogcfg
		{
			public byte byMode; //模式，0-不启用，1-自动模式，2-常开模式
			public byte byLevel; //等级，0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		//电子防抖
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrElectronicstabilization
		{
			public byte byEnable;//使能 0- 不启用，1- 启用
			public byte byLevel; //等级，0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		//走廊模式
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCorridorModeCcd
		{
			public byte byEnableCorridorMode; //是否启用走廊模式 0～不启用， 1～启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//SMART IR(防过曝)配置参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSmartirParam
		{
			public byte byMode;//0～手动，1～自动
			public byte byIRDistance;//红外距离等级(等级，距离正比例)level:1~100 默认:50（手动模式下增加）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//在byIrisMode 为P-Iris1时生效，配置红外光圈大小等级，配置模式
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPirisParam
		{
			public byte byMode;//0-自动，1-手动
			public byte byPIrisAperture;//红外光圈大小等级(等级,光圈大小正比例)level:1~100 默认:50（手动模式下增加）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//前端参数配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraparamcfgEx
		{
			public uint dwSize;
			public NetDvrVideoeffect struVideoEffect;/*亮度、对比度、饱和度、锐度、色调配置*/
			public NetDvrGain struGain;/*自动增益*/
			public NetDvrWhitebalance struWhiteBalance;/*白平衡*/
			public NetDvrExposure struExposure; /*曝光控制*/
			public NetDvrGammacorrect struGammaCorrect;/*Gamma校正*/
			public NetDvrWdr struWdr;/*宽动态*/
			public NetDvrDaynight struDayNight;/*日夜转换*/
			public NetDvrBacklight struBackLight;/*背光补偿*/
			public NetDvrNoiseremove struNoiseRemove;/*数字降噪*/
			public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
			public byte byIrisMode; /*0-自动光圈 1-手动光圈, 2-P-Iris1*/    
			public byte byMirror ;  /* 镜像：0 off，1- leftright，2- updown，3-center */
			public byte byDigitalZoom;  /*数字缩放:0 dsibale  1 enable*/
			public byte byDeadPixelDetect;   /*坏点检测,0 dsibale  1 enable*/
			public byte byBlackPwl;/*黑电平补偿 ,  0-255*/ 
			public byte byEptzGate;// EPTZ开关变量:0-不启用电子云台，1-启用电子云台
			public byte byLocalOutputGate;//本地输出开关变量0-本地输出关闭1-本地BNC输出打开 2-HDMI输出关闭  
			//20-HDMI_720P50输出开
			//21-HDMI_720P60输出开
			//22-HDMI_1080I60输出开
			//23-HDMI_1080I50输出开
			//24-HDMI_1080P24输出开
			//25-HDMI_1080P25输出开
			//26-HDMI_1080P30输出开
			//27-HDMI_1080P50输出开
			//28-HDMI_1080P60输出开
			public byte byCoderOutputMode;//编码器fpga输出模式0直通3像素搬家
			public byte byLineCoding; //是否开启行编码：0-否，1-是
			public byte byDimmerMode; //调光模式：0-半自动，1-自动
			public byte byPaletteMode; //调色板：0-白热，1-黑热，2-调色板2，…，8-调色板8
			public byte byEnhancedMode; //增强方式（探测物体周边）：0-不增强，1-1，2-2，3-3，4-4
			public byte byDynamicContrastEN;    //动态对比度增强 0-1
			public byte byDynamicContrast;    //动态对比度 0-100
			public byte byJPEGQuality;    //JPEG图像质量 0-100
			public NetDvrCmosmodecfg struCmosModeCfg;//CMOS模式下前端参数配置，镜头模式从能力集获取
			public byte byFilterSwitch; //滤波开关：0-不启用，1-启用
			public byte byFocusSpeed; //镜头调焦速度：0-10
			public byte byAutoCompensationInterval; //定时自动快门补偿：1-120，单位：分钟
			public byte bySceneMode;  //场景模式：0-室外，1-室内，2-默认，3-弱光
			public NetDvrDefogcfg struDefogCfg;//透雾参数
			public NetDvrElectronicstabilization struElectronicStabilization;//电子防抖
			public NetDvrCorridorModeCcd struCorridorMode;//走廊模式
			public byte byExposureSegmentEnable; //0~不启用,1~启用  曝光时间和增益呈阶梯状调整，比如曝光往上调整时，先提高曝光时间到中间值，然后提高增益到中间值，再提高曝光到最大值，最后提高增益到最大值
			public byte byBrightCompensate;//亮度增强 [0~100]

			/*0-关闭、1-640*480@25fps、2-640*480@30ps、3-704*576@25fps、4-704*480@30fps、5-1280*720@25fps、6-1280*720@30fps、
			 * 7-1280*720@50fps、8-1280*720@60fps、9-1280*960@15fps、10-1280*960@25fps、11-1280*960@30fps、
			 * 12-1280*1024@25fps、13--1280*1024@30fps、14-1600*900@15fps、15-1600*1200@15fps、16-1920*1080@15fps、
			 * 17-1920*1080@25fps、18-1920*1080@30fps、19-1920*1080@50fps、20-1920*1080@60fps、21-2048*1536@15fps、22-2048*1536@20fps、
			 * 23-2048*1536@24fps、24-2048*1536@25fps、25-2048*1536@30fps、26-2560*2048@25fps、27-2560*2048@30fps、
			 * 28-2560*1920@7.5fps、29-3072*2048@25fps、30-3072*2048@30fps、31-2048*1536@12.5、32-2560*1920@6.25、
			 * 33-1600*1200@25、34-1600*1200@30、35-1600*1200@12.5、36-1600*900@12.5、37-1600@900@15、38-800*600@25、39-800*600@30*/
			public byte byCaptureModeN; //视频输入模式（N制）
			public byte byCaptureModeP; //视频输入模式（P制）
			public NetDvrSmartirParam struSmartIRParam; //红外放过爆配置信息
			public NetDvrPirisParam struPIrisParam;//PIris配置信息对应byIrisMode字段从2-PIris1开始生效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		//车牌颜色
		public enum VcaPlateColor
		{
			VcaBluePlate = 0,//蓝色车牌
			VcaYellowPlate,//黄色车牌
			VcaWhitePlate,//白色车牌
			VcaBlackPlate,//黑色车牌
			VcaGreenPlate //绿色车牌
		}

		//车牌类型
		public enum VcaPlateType
		{
			VcaStandard92Plate = 0,//标准民用车与军车
			VcaStandard02Plate,//02式民用车牌 
			VcaWjpolicePlate,//武警车 
			VcaJingchePlate,//警车
			Standard92BackPlate,//民用车双行尾牌
			VcaShiguanPlate,          //使馆车牌
			VcaNongyongPlate,         //农用车
			VcaMotoPlate              //摩托车
		}

		public enum VlrVehicleClass
		{
			VlrOther       = 0,   //其它
			VlrVolkswagen = 1,    //大众
			VlrBuick        = 2,  //别克
			VlrBmw         = 3,   //宝马
			VlrHonda       = 4,   //本田
			VlrPeugeot     = 5,   //标致
			VlrToyota      = 6,   //丰田
			VlrFord         = 7,  //福特
			VlrNissan       = 8,  //日产
			VlrAudi         = 9,  //奥迪
			VlrMazda       = 10,  //马自达
			VlrChevrolet  = 11,   //雪佛兰
			VlrCitroen     = 12,  //雪铁龙
			VlrHyundai    = 13,   //现代
			VlrChery       = 14   //奇瑞
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVehicleInfo
		{
			public uint dwIndex;
			public byte byVehicleType;
			public byte byColorDepth;
			public byte byColor;
			public byte byRes1;
			public ushort wSpeed;
			public ushort wLength;
			public byte byIllegalType;
			public byte byVehicleLogoRecog; //参考枚举类型 VlrVehicleClass
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byCustomInfo;  //自定义信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes2 = new byte[2];
				byCustomInfo = new byte[16];
				byRes = new byte[16];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateResult
		{
			public uint dwSize;
			public byte byResultType;
			public byte byChanIndex;
			public ushort wAlarmRecordID;	//报警录像ID(用于查询录像，仅当byResultType为2时有效)
			public uint dwRelativeTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAbsTime;
			public uint dwPicLen;
			public uint dwPicPlateLen;
			public uint dwVideoLen;
			public byte byTrafficLight;
			public byte byPicNum;
			public byte byDriveChan;
			public byte byVehicleType; //0- 未知，1- 客车，2- 货车，3- 轿车，4- 面包车，5- 小货车
			public uint dwBinPicLen;
			public uint dwCarPicLen;
			public uint dwFarCarPicLen;
			public IntPtr pBuffer3;
			public IntPtr pBuffer4;
			public IntPtr pBuffer5;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
			public NetDvrPlateInfo struPlateInfo;
			public NetDvrVehicleInfo struVehicleInfo;
			public IntPtr pBuffer1;
			public IntPtr pBuffer2;

			public void Init()
			{
				byAbsTime = new byte[32];
				byRes3 = new byte[8];
			}
		}

		//图像叠加信息配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrImageoverlaycfg
		{
			public uint dwSize;
			public byte byOverlayInfo;//叠加使能开关，0-不叠加，1-叠加
			public byte byOverlayMonitorInfo;//是否叠加监测点信息，0-不叠加，1-叠加
			public byte byOverlayTime;//是否叠加时间，0-不叠加，1-叠加
			public byte byOverlaySpeed;//是否叠加速度，0-不叠加，1-叠加
			public byte byOverlaySpeeding;//是否叠加超速比例，0-不叠加，1-叠加
			public byte byOverlayLimitFlag;//是否叠加限速标志，0-不叠加，1-叠加
			public byte byOverlayPlate;//是否叠加车牌号，0-不叠加，1-叠加
			public byte byOverlayColor;//是否叠加车身颜色，0-不叠加，1-叠加
			public byte byOverlayLength;//是否叠加车长，0-不叠加，1-叠加
			public byte byOverlayType;//是否叠加车型，0-不叠加，1-叠加
			public byte byOverlayColorDepth;//是否叠加车身颜色深浅，0-不叠加，1-叠加
			public byte byOverlayDriveChan;//是否叠加车道，0-不叠加，1-叠加
			public byte byOverlayMilliSec; //叠加毫秒信息 0-不叠加，1-叠加
			public byte byOverlayIllegalInfo; //叠加违章信息 0-不叠加，1-叠加
			public byte byOverlayRedOnTime;  //叠加红灯已亮时间 0-不叠加，1-叠加
			public byte byFarAddPlateJpeg;      //远景图是否叠加车牌截图,0-不叠加,1-叠加
			public byte byNearAddPlateJpeg;      //近景图是否叠加车牌截图,0-不叠加,1-叠加
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitorInfo1;    //监测点信息1
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitorInfo2; //检测点信息2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnapcfg
		{
			public uint dwSize;
			public byte byRelatedDriveWay;
			public byte bySnapTimes;
			public ushort wSnapWaitTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public enum ItcMainmodeAbility
		{
			ItcModeUnknow = 0x0,   //无
			ItcPostMode   = 0x1,  //卡口模式
			ItcEpoliceMode      = 0x2,  //电警模式
			ItcPostepoliceMode  = 0x4  //卡式电警模式
		}

		public enum ItcRecogRegionType
		{
			ItcRegionRect    = 0x0,   //矩形
			ItcRegionPolygon  = 0x1,  //多边形
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnapAbility
		{
			public uint dwSize;
			public byte byIoInNum;//IO输入口数
			public byte byIoOutNum;//IO输出口数
			public byte bySingleSnapNum;//单IO触发组数
			public byte byLightModeArrayNum;//红绿灯模式组数
			public byte byMeasureModeArrayNum;//测速模式组数
			public byte byPlateEnable; //车牌识别能力
			public byte byLensMode;//镜头模式0-CCD,1-CMOS
			public byte byPreTriggerSupport; //是否支持原触发模式，0-支持，1-不支持
			public uint dwAbilityType; //支持的触发模式能力，按位表示，定义见ITC_MAINMODE_ABILITY
			public byte byIoSpeedGroup; //支持的IO测速组数
			public byte byIoLightGroup; //支持的IO红绿灯组数
			public byte byRecogRegionType; //牌识区域支持的类型，详见定义ITC_RECOG_REGION_TYPE
			public byte bySupport; //设备能力，按位表示，0-不支持，1-支持
			// bySupport&0x1，表示是否支持扩展的字符叠加配置
			// bySupport&0x2，表示是否支持扩展的校时配置结构
			// bySupport&0x4, 表示是否支持多网卡(多网隔离)
			// bySupport&0x8, 表示是否支持网卡的bonding功能(网络容错)
			// bySupport&0x10, 表示是否支持语音对讲
			//2013-07-09 能力集返回
			public ushort wSupportMultiRadar;// 设备能力，按位表示，0-不支持，1-支持
			// wSupportMultiRadar&0x1，表示 卡口RS485雷达 支持车道关联雷达处理
			// wSupportMultiRadar&0x2，表示 卡口虚拟线圈 支持车道关联雷达处理
			// wSupportMultiRadar&0x4，表示 混行卡口 支持车道关联雷达处理
			// wSupportMultiRadar&0x8，表示 视频检测 支持车道关联雷达处理
			public byte byICRPresetNum;
			// 表示支持的ICR预置点（滤光片偏移点）数
			public byte byICRTimeSlot;//表示支持的ICR的时间段数（1～8）
			public byte bySupportRS485Num;//表示支持的RS485口的数量
			public byte byExpandRs485SupportSensor;// 设备能力，按位表示，0-不支持，1-支持
			// byExpandRs485SupportSensor &0x1，表示电警车检器支持车检器
			// byExpandRs485SupportSensor &0x2，表示卡式电警车检器支持车检器
			public byte byExpandRs485SupportSignalLampDet;// 设备能力，按位表示，0-不支持，1-支持
			// byExpandRs485SupportSignalLampDet &0x1，表示电警车检器支持外接信号灯检测器
			// byExpandRs485SupportSignalLampDet &0x2，表示卡式电警车检器支持外接信号灯检测器
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrtimecfg
		{
			public NetDvrSchedtime  struTime;
			public byte byAssociateRresetNo;//预置点号1～8 , 0代表无
			public byte bySubSwitchMode;//1~白天，2~晚上 (当预置点等于0 的时候生效)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrTimeswitchParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetItcIcrtimecfg[] struAutoCtrlTime;//自动切换时间段 (自动切换下 时空下生效 现在支持4组，预留4组)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIcrNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byICRPreset; //实际生效根据能力集动态显示 [0~100] 数组下标表示预置点号1～8 （0～7 相对应）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrManualswitchParam
		{	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIcrNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byICRPreset; //实际生效根据能力集动态显示 [0~100]
			public byte  bySubSwitchMode;//1~白天，2~晚上
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrAotoswitchParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIcrNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byICRPreset; //实际生效根据能力集动态显示 [0~100] 数组下标表示预置点号1～8 （0～7 相对应）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 148, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrParamUnion
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 156, ArraySubType = UnmanagedType.I1)]
			public byte[] uLen;
			public NetItcIcrAotoswitchParam struICRAutoSwitch;
			public NetItcIcrManualswitchParam struICRManualSwitch;
			public NetItcIcrTimeswitchParam struICRTimeSwitch;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrcfg
		{
			public uint dwSize;
			public byte bySwitchType;//1~自动切换，2~手动切换 ,3~定时切换 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetItcIcrParamUnion uICRParam;
		}

		//2013-07-09 异常处理
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcHandleexception
		{
			public uint dwHandleType; //异常处理,异常处理方式的"或"结果
			/*0x00: 无响应*/
			/*0x01: 监视器上警告*/
			/*0x02: 声音警告*/
			/*0x04: 上传中心*/
			/*0x08: 触发报警输出（继电器输出）*/
			/*0x10: 触发JPRG抓图并上传Email*/
			/*0x20: 无线声光报警器联动*/
			/*0x40: 联动电子地图(目前只有PCNVR支持)*/
			/*0x200: 抓图并上传FTP*/  
			public byte byEnable; //0～不启用，1～启用
			public byte byRes;
			public ushort wDuration;//持续时间(单位/s)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxItcExceptionout, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutTriggered;//触发输出通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcException
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetItcHandleexception[] struSnapExceptionType; 
			//数组的每个元素都表示一种异常，数组0- 硬盘出错,1-网线断,2-IP 地址冲突, 3-车检器异常, 4-信号灯检测器异常
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrigcoordinate
		{
			public ushort wTopLeftX; /*线圈左上角横坐标（2个字节）*/
			public ushort wTopLeftY; /*线圈左上角纵坐标（2个字节）*/
			public ushort wWdith; /*线圈宽度（2个字节）*/
			public ushort wHeight; /*线圈高度（2个字节）*/
		}

		public enum ProvinceCityIdx
		{
			AnhuiProvince             = 0,              //安徽
			AomenProvince             = 1,              //澳门
			BeijingProvince           = 2,              //北京
			ChongqingProvince         = 3,              //重庆
			FujianProvince            = 4,              //福建
			GansuProvince             = 5,              //甘肃
			GuangdongProvince         = 6,              //广东
			GuangxiProvince           = 7,              //广西
			GuizhouProvince           = 8,              //贵州
			HainanProvince            = 9,              //海南
			HebeiProvince             = 10,             //河北
			HenanProvince             = 11,             //河南
			HeilongjiangProvince      = 12,             //黑龙江
			HubeiProvince             = 13,             //湖北
			HunanProvince             = 14,             //湖南
			JilinProvince             = 15,             //吉林
			JiangsuProvince           = 16,             //江苏
			JiangxiProvince           = 17,             //江西
			LiaoningProvince          = 18,             //辽宁
			NeimengguProvince         = 19,             //内蒙古
			NingxiaProvince           = 20,             //宁夏
			QinghaiProvince           = 21,             //青海
			ShandongProvince          = 22,             //山东
			ShanxiJinProvince        = 23,             //山西
			ShanxiShanProvince       = 24,             //陕西
			ShanghaiProvince          = 25,             //上海
			SichuanProvince           = 26,             //四川
			TaiwanProvince            = 27,             //台湾
			TianjinProvince           = 28,             //天津
			XizangProvince            = 29,             //西藏
			XianggangProvince         = 30,             //香港
			XinjiangProvince          = 31,             //新疆
			YunnanProvince            = 32,             //云南
			ZhejiangProvince          = 33              //浙江
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGeoglocation
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
			public int[] iRes; /*保留*/
			public uint dwCity; /*城市，详见PROVINCE_CITY_IDX */
		}

		//场景模式
		public enum SceneMode
		{
			UnkownSceneMode   = 0,            //未知场景模式
			HighwaySceneMode  = 1,            //高速场景模式
			SuburbanSceneMode = 2,            //郊区场景模式(保留)
			UrbanSceneMode    = 3,            //市区场景模式
			TunnelSceneMode   = 4             //隧道场景模式(保留)
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVtparam
		{
			public uint dwSize;
			public byte byEnable;  /* 是否使能虚拟线圈，0-不使用，1-使用*/
			public byte byIsDisplay; /* 是否显示虚拟线圈，0-不显示，1-显示*/
			public byte byLoopPos; //晚间触发线圈的偏向：0-向上，1-向下
			public byte bySnapGain; /*抓拍增益*/
			public uint dwSnapShutter; /*抓拍快门速度*/
			public NetDvrTrigcoordinate struTrigCoordinate; //保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVlNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrTrigcoordinate[] struRes;
			public byte byTotalLaneNum;/*视频触发的车道数1*/
			public byte byPolarLenType; /*偏振镜类型，0：不加偏振镜；1：加施耐德偏振镜。*/
			public byte	byDayAuxLightMode; /*白天辅助照明模式，0：无辅助照明；1：LED灯照明；2：闪光灯照明*/
			public byte	byLoopToCalRoadBright; /*用以计算路面亮度的车道(虚拟线圈)*/
			public byte	byRoadGrayLowTh; /*路面亮度低阈值初始化值1*/
			public byte	byRoadGrayHighTh; /*路面亮度高阈值初始化值140*/
			public ushort wLoopPosBias; /*晚间触发线圈位移30*/
			public uint dwHfrShtterInitValue; /*连续图像曝光时间的初始值2000*/
			public uint dwSnapShtterInitValue; /*抓拍图像曝光时间的初始值500*/
			public uint dwHfrShtterMaxValue; /*连续图像曝光时间的最大值20000*/
			public uint dwSnapShtterMaxValue; /*抓拍图像曝光时间的最大值1500*/
			public uint dwHfrShtterNightValue; /*晚间连续图像曝光时间的设置值3000*/
			public uint dwSnapShtterNightMinValue; /*晚间抓拍图像曝光时间的最小值3000*/
			public uint dwSnapShtterNightMaxValue; /*晚间抓拍图像曝光时间的最大值5000*/
			public uint dwInitAfe; /*增益的初始值200*/
			public uint dwMaxAfe; /*增益的最大值400*/
			public ushort wResolutionX;/* 设备当前分辨率宽*/
			public ushort wResolutionY;/* 设备当前分辨率高*/
			public uint dwGainNightValue; /*晚间增益，默认值70*/
			public uint dwSceneMode; /*场景模式， 详见SCENE_MODE */
			public uint dwRecordMode; /*录像标志：0-不录像，1-录像*/
			public NetDvrGeoglocation struGeogLocation; /*地址位置*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVlNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrigFlag; /*触发标志，0-车头触发；1-车尾触发；2-车头/车尾都触发*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVlNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrigSensitive;  /*触发灵敏度，1-100*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnapenablecfg
		{
			public uint dwSize;
			public byte byPlateEnable;//是否支持车牌识别，0-不支持，1-支持
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;   //保留
			public byte byFrameFlip;   //图像是否翻转 0-不翻转，1-翻转
			public ushort wFlipAngle;    //图像翻转角度 0,90,180,270
			public ushort wLightPhase;   //相位，取值范围[0, 360]
			public byte byLightSyncPower;  //是否信号灯电源同步，0-不同步；1-同步
			public byte byFrequency;		//信号频率
			public byte byUploadSDEnable;  //是否自动上传SD图片，0-否；1-是
			public byte byPlateMode; //识别模式参数:0-视频触发,1-外部触发
			public byte byUploadInfoFTP; //是否上传抓拍附加信息到FTP，0-否，1-是
			public byte byAutoFormatSD; //是否自动格式化SD卡，0-否，1-是
			public ushort wJpegPicSize; //Jpeg图片大小[64-8196]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		/*ftp上传参数*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFtpcfg
		{
			public uint dwSize;
			public uint dwEnableFTP;			/*是否启动ftp上传功能*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFTPIP;				/*ftp 服务器*/
			public uint dwFTPPort;				/*ftp端口*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	/*用户名*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	/*密码*/
			public uint dwDirLevel;	/*0 = 不使用目录结构，直接保存在根目录,1 = 使用1级目录,2=使用2级目录*/
			public ushort wTopDirMode;	/* 一级目录，0x1 = 使用设备名,0x2 = 使用设备号,0x3 = 使用设备ip地址，0x4=使用监测点,0x5=使用时间(年月),0x=6自定义,0x7=违规类型,0x8=方向,0x9=地点*/
			public ushort wSubDirMode;	/* 二级目录，0x1 = 使用通道名,0x2 = 使用通道号，,0x3=使用时间(年月日),0x4=使用车道号,0x=5自定义,0x6=违规类型,0x7=方向,0x8=地点*/
			public byte byEnableAnony; //启用匿名，0-否，1-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*可用来命名图片的相关元素 */
		public const int PicnameItemDevName = 1;		/*设备名*/
		public const int PicnameItemDevNo = 2;		/*设备号*/
		public const int PicnameItemDevIp = 3;		/*设备IP*/
		public const int PicnameItemChanName = 4;	/*通道名*/
		public const int PicnameItemChanNo = 5;		/*通道号*/
		public const int PicnameItemTime = 6;		/*时间*/
		public const int PicnameItemCardno = 7;		/*卡号*/
		public const int PicnameItemPlateNo = 8;   /*车牌号码*/
		public const int PicnameItemPlateColor = 9;   /*车牌颜色*/
		public const int PicnameItemCarChan = 10;  /*车道号*/
		public const int PicnameItemCarSpeed = 11;  /*车辆速度*/
		public const int PicnameItemCarchan = 12;  /*监测点*/
		public const int PicnameItemPicNumber = 13;  //图片序号
		public const int PicnameItemCarNumber = 14;  //车辆序号

		public const int PicnameItemSpeedLimitValues = 15; //限速值
		public const int PicnameItemIllegalCode = 16; //国标违法代码
		public const int PicnameItemCrossNumber = 17; //路口编号
		public const int PicnameItemDirectionNumber = 18; //方向编号

		public const int PicnameMaxitem = 15;
		//图片命名
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPictureName
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PicnameMaxitem, ArraySubType = UnmanagedType.I1)]
			public byte[] byItemOrder;	/*	桉数组定义文件命名的规则 */
			public byte byDelimiter;		/*分隔符，一般为'_'*/
		}


		//命名规则：2013-09-27
		public const int PicnameItemParkDevIp = 1;	/*设备IP*/
		public const int PicnameItemParkPlateNo = 2;/*车牌号码*/
		public const int PicnameItemParkTime = 3;	/*时间*/
		public const int PicnameItemParkIndex = 4;   /*车位编号*/
		public const int PicnameItemParkStatus = 5;  /*车位状态*/

		//图片命名扩展 2013-09-27
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPictureNameEx
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PicnameMaxitem, ArraySubType = UnmanagedType.I1)]
			public byte[] byItemOrder;	/*	桉数组定义文件命名的规则 */
			public byte byDelimiter;	            	/*分隔符，一般为'_'*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                      /*保留*/
		}

		/* 串口抓图设置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSerialCatchpicPara
		{
			public byte byStrFlag;	/*串口数据开始符*/
			public byte byEndFlag;	/*结束符*/
			public ushort wCardIdx;	/*卡号相对起始位*/
			public uint dwCardLen;	/*卡号长度*/
			public uint dwTriggerPicChans;	/*所触发的通道号，按位，从第1位开始计，即0x2表示第一通道*/
		}

		//DVR抓图参数配置（基线）
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrJpegpara[] struJpegPara;	/*每个通道的图像参数*/
			public ushort wBurstMode;							/*抓图方式,按位设置.0x1=报警输入触发，0x2=移动侦测触发 0x4=232触发，0x8=485触发，0x10=网络触发*/
			public ushort wUploadInterval;					/*图片上传间隔(秒)[0,65535]*/
			public NetDvrPictureName 	struPicNameRule;	/* 图片命名规则 */
			public byte bySaveToHD;		/*是否保存到硬盘*/
			public byte byRes1;
			public ushort wCatchInterval;		/*抓图间隔(毫秒)[0,65535]*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrSerialCatchpicPara struRs232Cfg;
			public NetDvrSerialCatchpicPara struRs485Cfg;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwTriggerPicTimes;	/* 每个通道一次触发拍照次数 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwAlarmInPicChanTriggered; /*报警触发抓拍通道,按位设置，从第1位开始*/
		}

		//抓拍触发请求结构(保留)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrManualsnap
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSprcfg    
		{
			public uint dwSize; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChjcNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byDefaultCHN; /*设备运行省份的汉字简写*/
			public byte byPlateOSD;    /*0:不发送车牌彩色图,1:发送车牌彩色图*/
			public byte bySendJPEG1;   /*0-不传送近景JPEG图,1-传送近景JPEG图*/
			public byte bySendJPEG2;   /*0-不传送远景JPEG图,1-传送远景JPEG图*/
			public ushort wDesignedPlateWidth;   /*车牌设计宽度*/
			public byte byTotalLaneNum;  /*识别的车道数*/
			public byte byRes1;      /*保留*/
			public ushort wRecognizedLane;  /*识别的车道号，按位表示，bit0表示车道1是否识别，0-不识别，1-识别*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLanerectNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaRect[] struLaneRect;  /*车道识别区域*/
			public uint dwRecogMode;  /*识别的类型，
			bit0-背向识别：0-正向车牌识别，1-背向识别(尾牌识别) ； 
			bit1-大车牌识别或小车牌识别：0-小车牌识别，1-大车牌识别 ；
			bit2-车身颜色识别：0-不采用车身颜色识别，在背向识别或小车牌识别时禁止启用，1-车身颜色识别；
			bit3-农用车识别：0-不采用农用车识别，1-农用车识别； 
			bit4-模糊识别：0-不采用模糊识别，1-模糊识别；
			bit5-帧定位或场定位：0-帧定位，1-场定位；
			bit6-帧识别或场识别：0-帧识别，1-场识别； 
			bit7-晚上或白天：0-白天，1-晚上 */
			public byte bySendPRRaw;       	//是否发送原图：0-不发送，1-发送 
			public byte bySendBinImage;  	//是否发送车牌二值图：0-不发送，1-发送 
			public byte byDelayCapture;  //延时抓拍控制,单位：帧
			public byte byUseLED;    //使用LED控制，0-否，1-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlccfg
		{
			public uint dwSize;
			public byte byPlcEnable;	//是否启用车牌亮度补偿（默认启用）：0-关闭，1-启用 
			public byte byPlateExpectedBright;	//车牌的预期亮度（默认值50）, 范围[0, 100]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	//保留 
			public byte byTradeoffFlash;     //是否考虑闪光灯的影响: 0 - 否;  1 - 是(默认); 
			//使用闪光灯补光时, 如果考虑减弱闪光灯的亮度增强效应, 则需要设为1;否则为0
			public byte byCorrectFactor;     //纠正系数, 范围[0, 100], 默认值50 (在tradeoff_flash切换时,恢复默认值）
			public ushort wLoopStatsEn;  //是否该线圈的亮度，按位表示，0-不统计，1-统计
			public byte byPlcBrightOffset;// 车牌亮度补偿灵敏度(虚拟线圈模式起效)，取值范围1~100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevicestatecfg
		{
			public uint dwSize;
			public ushort wPreviewNum; //预览连接个数
			public ushort wFortifyLinkNum; //布防连接个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLink, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struPreviewIP;  //预览的用户IP地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxFortifyNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struFortifyIP; //布防连接的用户IP地址
			public uint dwVideoFrameRate;	//帧率：0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
			public byte byResolution;  	//分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）,16-VGA（640*480）, 17-UXGA（1600*1200）, 18-SVGA （800*600）,19-HD720p（1280*720）,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
			public byte bySnapResolution;  	//抓拍分辨率0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5（保留）,16-VGA（640*480）, 17-UXGA（1600*1200）, 18-SVGA （800*600）,19-HD720p（1280*720）,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
			public byte byStreamType; //传输类型：0-主码流；1-子码流
			public byte byTriggerType; //触发模式：0-视频触发；1-普通触发
			public uint dwSDVolume;  //SD卡容量
			public uint dwSDFreeSpace; //SD卡剩余空间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDrivechanNum * MaxCoilNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byDetectorState;  //车检器状态：0-未使用；1-正常；2-异常
			public byte byDetectorLinkState; //车检器连接状态：0-未连接；1-连接
			public byte bySDStatus;    //SD卡状态 0－活动；1－休眠；2－异常，3-无sd卡
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxFortifyNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byFortifyLevel; //布防等级，0-无，1-一等级（高），2-二等级（中），3-三等级（低）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPostepolicecfg
		{
			public uint dwSize;
			public uint dwDistance;//线圈距离,单位cm，取值范围[0,20000]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSignallightNum, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLightChan;	//信号灯通道号
			public byte byCapSpeed;//标志限速，单位km/h，取值范围[0,255]
			public byte bySpeedLimit;//限速值，单位km/h，取值范围[0,255]
			public byte byTrafficDirection;//车流方向，0-由东向西，1-由西向东，2-由南向北，3-由北向南
			public byte byRes1; //保留
			public ushort wLoopPreDist;        /*触发延迟距离 ，单位：分米*/
			public ushort wTrigDelay;             /*触发硬延时时间 ，单位：毫秒*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留字节
		}
		/***************************** end *********************************************/
		public const int IpcProtocolNum = 50;  //ipc 协议最大个数

		//协议类型
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrProtoType
		{
			public uint dwType;               /*ipc协议值*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = DescLen)]
			public string byDescribe; /*协议描述字段*/
		}

		//协议列表
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpcProtoList
		{    
			public uint dwSize; 
			public uint dwProtoNum;           /*有效的ipc协议数目*/  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = IpcProtocolNum, ArraySubType = UnmanagedType.Struct)]            
			public NetDvrProtoType[] struProto;   /*有效的ipc协议*/    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int MaxAlertlineNum = 8; //最大警戒线条数	
		
		//越界侦测查询条件
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTraversePlaneSearchcond
		{	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlertlineNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaTraversePlane[] struVcaTraversePlane;  //穿越境界面参数
			public uint dwPreTime;   /*智能报警提前时间 单位:秒*/
			public uint dwDelayTime; /*智能报警延迟时间 单位:秒*/ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		} 

		public const int MaxIntrusionregionNum = 8; //最大区域数数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIntrusionSearchcond  
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntrusionregionNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaIntrusion[] struVcaIntrusion; //入侵区域
			public uint dwPreTime;   /*智能报警提前时间 单位:秒*/
			public uint dwDelayTime; /*智能报警延迟时间 单位:秒*/ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}


		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrAreaSmartsearchCondUnion
		{  
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
			public byte[] byLen;  //结构体长度
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope; //侦测区域 0-96位表示64行，共有96*64个小宏块，1-是移动侦测区域，0-非移动侦测区域 
			[FieldOffset(0)]
			public NetDvrTraversePlaneSearchcond struTraversPlaneCond; //越界侦测
			[FieldOffset(0)]
			public NetDvrIntrusionSearchcond struIntrusionCond; //区域入侵
		}

		//智能搜索参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSmartSearchParam
		{
			public byte byChan;					//通道号
			public byte bySearchCondType; //智能查找联合体NET_DVR_AREA_SMARTSEARCH_COND_UNION的索引     
			/*0-移动侦测区域 ，1-越界侦测， 2-区域入侵*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrTime struStartTime;		//录像开始的时间
			public NetDvrTime struEndTime;		//录像停止的时间
			public NetDvrAreaSmartsearchCondUnion uSmartSearchCond;  //智能查找条件
			public byte bySensitivity;   			//移动侦测搜索灵敏度,1	>80%  2 40%~80%  3 1%~40%
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
	
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSmartSearchRet
		{
			public NetDvrTime struStartTime;	//移动侦测报警开始的时间
			public NetDvrTime struEndTime;   //事件停止的时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//IPSAN 文件目录查找
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpsanSerachParam
		{
			public NetDvrIpaddr  struIP;     // IPSAN IP地址
			public ushort wPort;      // IPSAN  端口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpsanSerachRet
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byDirectory;  // 返回的文件目录
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR设备参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevicecfgV40
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRName; //DVR名称
			public uint dwDVRID;				//DVR ID,用于遥控器 //V1.4(0-99), V1.5(0-255)
			public uint dwRecycleRecord;		//是否循环录像,0:不是; 1:是
			//以下不可更改
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber; //序列号
			public uint dwSoftwareVersion;			//软件版本号,高16位是主版本,低16位是次版本
			public uint dwSoftwareBuildDate;			//软件生成日期,0xYYYYMMDD
			public uint dwDSPSoftwareVersion;		    //DSP软件版本,高16位是主版本,低16位是次版本
			public uint dwDSPSoftwareBuildDate;		// DSP软件生成日期,0xYYYYMMDD
			public uint dwPanelVersion;				// 前面板版本,高16位是主版本,低16位是次版本
			public uint dwHardwareVersion;	// 硬件版本,高16位是主版本,低16位是次版本
			public byte byAlarmInPortNum;		//DVR报警输入个数
			public byte byAlarmOutPortNum;		//DVR报警输出个数
			public byte byRS232Num;			//DVR 232串口个数
			public byte byRS485Num;			//DVR 485串口个数 
			public byte byNetworkPortNum;		//网络口个数
			public byte byDiskCtrlNum;			//DVR 硬盘控制器个数
			public byte byDiskNum;				//DVR 硬盘个数
			public byte byDVRType;				//DVR类型, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;				//DVR 通道个数
			public byte byStartChan;			//起始通道号,例如DVS-1,DVR - 1
			public byte byDecordChans;			//DVR 解码路数
			public byte byVGANum;				//VGA口的个数 
			public byte byUSBNum;				//USB口的个数
			public byte byAuxoutNum;			//辅口的个数
			public byte byAudioNum;			//语音口的个数
			public byte byIPChanNum;			//最大数字通道数 低8位，高8位见byHighIPChanNum 
			public byte byZeroChanNum;			//零通道编码个数
			public byte bySupport;        //能力，位与结果为0表示不支持，1表示支持，
			//bySupport & 0x1, 表示是否支持智能搜索
			//bySupport & 0x2, 表示是否支持备份
			//bySupport & 0x4, 表示是否支持压缩参数能力获取
			//bySupport & 0x8, 表示是否支持多网卡
			//bySupport & 0x10, 表示支持远程SADP
			//bySupport & 0x20, 表示支持Raid卡功能
			//bySupport & 0x40, 表示支持IPSAN搜索
			//bySupport & 0x80, 表示支持rtp over rtsp
			public byte byEsataUseage;		//Esata的默认用途，0-默认备份，1-默认录像
			public byte byIPCPlug;			//0-关闭即插即用，1-打开即插即用
			public byte byStorageMode;		//0-盘组模式,1-磁盘配额, 2抽帧模式
			public byte bySupport1;		//能力，位与结果为0表示不支持，1表示支持
			//bySupport1 & 0x1, 表示是否支持snmp v30
			//bySupport1 & 0x2, 支持区分回放和下载
			//bySupport1 & 0x4, 是否支持布防优先级	
			//bySupport1 & 0x8, 智能设备是否支持布防时间段扩展
			//bySupport1 & 0x10, 表示是否支持多磁盘数（超过33个）
			//bySupport1 & 0x20, 表示是否支持rtsp over http	
			public ushort wDevType;//设备型号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DevTypeNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDevTypeName;//设备型号名称 
			public byte bySupport2; //能力集扩展，位与结果为0表示不支持，1表示支持
			//bySupport2 & 0x1, 表示是否支持扩展的OSD字符叠加(终端和抓拍机扩展区分)
			public byte byAnalogAlarmInPortNum; //模拟报警输入个数
			public byte byStartAlarmInNo;    //模拟报警输入起始号
			public byte byStartAlarmOutNo;  //模拟报警输出起始号
			public byte byStartIPAlarmInNo;  //IP报警输入起始号  0-无效
			public byte byStartIPAlarmOutNo; //IP报警输出起始号 0-无效
			public byte byHighIPChanNum;     //数字通道个数，高8位 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			//保留
		}

		public const int MaxZerochanNum = 16;
		//零通道压缩配置参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrZerochancfg
		{
			public uint dwSize;			    //结构长度
			public byte byEnable;			//0-停止零通道编码，1-表示启用零通道编码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			//保留
			public uint dwVideoBitrate; 	/*视频码率 0-保留 1-16K(保留) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
											 * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
											 * 23-2048K
											 * 最高位(31位)置成1表示是自定义码流, 0-30位表示码流值(MIN-32K MAX-8192K) */
			public uint dwVideoFrameRate;	//帧率 0-全部; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
											//V2.0增加14-15, 15-18, 16-22;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;        //保留
		}

		//零通道缩放参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrZeroZoomcfg
		{
			public uint dwSize;			    //结构长度
			public NetVcaPoint struPoint;	//画面中的坐标点
			public byte byState;		 //现在的状态，0-缩小，1-放大  
			public byte byPreviewNumber;       //预览数目,0-1画面,1-4画面,2-9画面,3-16画面 该参数只读
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byPreviewSeq;//画面通道信息 该参数只读
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				//保留 
		}

		public const int DescLen64 = 64;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnmpcfg
		{
			public uint dwSize;			//结构长度
			public byte byEnable;			//0-禁用SNMP，1-表示启用SNMP
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			//保留
			public ushort wVersion;		//snmp 版本  v1 = 1, v2 =2, v3 =3，设备目前不支持 v3
			public ushort wServerPort; //snmp消息接收端口，默认 161
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byReadCommunity; //读共同体，最多31,默认"public"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byWriteCommunity;//写共同体,最多31 字节,默认 "private"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen64, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapHostIP;	//自陷主机ip地址描述，支持IPV4 IPV6和域名描述    
			public ushort wTrapHostPort;   //trap主机端口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapName;	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnmPv3User
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName;			// 用户名				
			public byte bySecLevel;	//安全级别 1-无校验 2-无授权校验 3-授权校验
			public byte byAuthtype;	//认证类型 0-MD5认证 1-SHA认证 2: none
			public byte byPrivtype;	//0: DES; 1: AES; 2: none;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAuthpass;	//认证密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPrivpass;	//加密密码
		}
		
		//snmpv30
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnmpcfgV30
		{
			public uint dwSize;			//结构长度
			public byte byEnableV1;		//0-禁用SNMP V1，1-表示启用SNMP V1
			public byte byEnableV2;		//0-禁用SNMP V2，1-表示启用SNMP V2
			public byte byEnableV3;		//0-禁用SNMP V3，1-表示启用SNMP V3
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public ushort wServerPort;					//snmp消息接收端口，默认 161
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byReadCommunity;		//读共同体，最多31,默认"public"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byWriteCommunity;		//写共同体,最多31 字节,默认 "private"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen64, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapHostIP;		//自陷主机ip地址描述，支持IPV4 IPV6和域名描述    
			public ushort wTrapHostPort;					// trap主机端口
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;       
			public NetDvrSnmPv3User struRWUser;    // 读写用户
			public NetDvrSnmPv3User struROUser;    // 只读用户
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapName;
		}
		
		public const int Processing = 0;    //正在处理
		public const int ProcessSuccess = 100;   //过程完成
		public const int ProcessException = 400;   //过程异常
		public const int ProcessFailed = 500;   //过程失败
		public const int ProcessQuickSetupPdCount = 501; //一键配置至少3块硬盘

		public const int SoftwareVersionLen = 48;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSadpinfo
		{
			public NetDvrIpaddr struIP;     // 设备IP地址
			public ushort wPort;      // 设备端口号
			public ushort wFactoryType;   // 设备厂家类型
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = SoftwareVersionLen)]
			public string chSoftwareVersion;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string chSerialNo; // 序列号
			public ushort wEncCnt;   // 编码通道个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;		// MAC 地址
			public NetDvrIpaddr struSubDVRIPMask;   // DVR IP地址掩码
			public NetDvrIpaddr struGatewayIpAddr;  // 网关
			public NetDvrIpaddr struDnsServer1IpAddr;	/* 域名服务器1的IP地址 */
			public NetDvrIpaddr struDnsServer2IpAddr;	/* 域名服务器2的IP地址 */
			public byte byDns;
			public byte byDhcp;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     // 保留字节
		}

		public const int MaxSadpNum = 256;  //搜索到设备最大数目
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSadpinfoList
		{
			public uint dwSize;   //  结构大小
			public ushort wSadpNum;   // 搜索到设备数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSadpNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSadpinfo[] struSadpInfo; // 搜索
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSadpVerify
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string chPassword;
			public NetDvrIpaddr struOldIP;
			public ushort wOldPort;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		/***************************** end *********************************************/

		/*******************************备份结构 begin********************************/
		//获取备份设备信息接口定义
		public const int DescLen32 = 32;   //描述字长度
		public const int MaxNodeNum = 256;  //节点个数

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDescNode
		{ 
			public int iValue; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe; //描述字段 
			public uint dwFreeSpace; //获取磁盘列表专用,单位为M
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;			  //保留  
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskabilityList
		{ 
			public uint dwSize;            //结构长度
			public uint dwNodeNum;		 //能力结点个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNodeNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDescNode[] struDescNode;  //描述参数  
		}

		//备份进度列表
		public const int BackupSuccess            =    100;  //备份完成
		public const int BackupChangeDevice      =    101;  //备份设备已满，更换设备继续备份

		public const int BackupSearchDevice      =    300;  //正在搜索备份设备
		public const int BackupSearchFile        =    301;  //正在搜索录像文件
		public const int BackupSearchLogFile    =    302;  //正在搜索日志文件

		public const int BackupException		   =    400;  //备份异常
		public const int BackupFail			   =	500;  //备份失败

		public const int BackupTimeSegNoFile   =    501;  //时间段内无录像文件
		public const int BackupNoResource        =    502;  //申请不到资源
		public const int BackupDeviceLowSpace   =    503;  //备份设备容量不足
		public const int BackupDiskFinalized     =    504;  //刻录光盘封盘
		public const int BackupDiskException     =    505;  //刻录光盘异常
		public const int BackupDeviceNotExist   =    506;  //备份设备不存在
		public const int BackupOtherBackupWork  =    507;  //有其他备份操作在进行
		public const int BackupUserNoRight      =    508;  //用户没有操作权限
		public const int BackupOperateFail       =    509;  //操作失败
		public const int BackupNoLogFile        =    510;  //硬盘中无日志

		//备份过程接口定义
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBackupNameParam
		{
			public uint dwFileNum;   //文件个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRecordFileNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrFinddataV30[] struFileList; //文件列表
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskDes;   //备份磁盘描述
			public byte byWithPlayer;      //是否备份播放器
			public byte byContinue;    /*是否继续备份 0不继续 1继续*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBackupTimeParam
		{
			public int lChannel;        //按时间备份的通道
			public NetDvrTime struStartTime;   //备份的起始时间
			public NetDvrTime struStopTime;    //备份的终止时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskDes;     //备份磁盘描述
			public byte byWithPlayer;               //是否备份播放器
			public byte byContinue;                 //是否继续备份 0不继续 1继续
			public byte byDrawFrame;			     //0 不抽帧  1 抽帧
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;					 // 保留字节 
		}
		/********************************* end *******************************************/
		public enum CompressionAbilityType
		{
			CompressionStreamAbility = 0, //码流压缩类型
			MainResolutionAbility = 1,	//主码流压缩分辨率
			SubResolutionAbility  = 2,	//子码流压缩分辨率
			EventResolutionAbility =  3,  //事件压缩参数分辨率
			FrameAbility = 4,				//帧率能力
			BitrateTypeAbility = 5,		//位率类型能力
			BitrateAbility = 6,			//位率上限
			ThirdResolutionAbility = 7,   //三码流压缩分辨率
			StreamTypeAbility = 8,        //码流类型
			PicQualityAbility = 9,         //图像质量
			IntervalBpframeAbility = 10,  //BP帧间隔
			VideoEncAbility = 11,           //视频编码能力
			AudioEncAbility = 12,           //音频编码能力
			VideoEncComplexityAbility = 13, //视频编码复杂度能力
			FormatAbility = 14, //封装格式能力
		}

		//能力列表
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAbilityList
		{ 
			public uint dwAbilityType;	//能力类型 COMPRESSION_ABILITY_TYPE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //保留字节
			public uint dwNodeNum;		//能力结点个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNodeNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDescNode[]  struDescNode;  //描述参数  
		}

		public const int MaxAbilitytypeNum = 12;   //最大能力项

		// 压缩参数能力列表
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgAbility
		{ 
			public uint dwSize;            //结构长度
			public uint dwAbilityNum;		//能力类型个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAbilitytypeNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAbilityList[] struAbilityNode; //描述参数  
		}

		//模式A 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidateModea
		{
			public byte byStartMonth;	// 开始月 从1开始
			public byte byStartDay;		// 开始日 从1开始
			public byte byEndMonth;		// 结束月 
			public byte byEndDay;		// 结束日
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidateModeb
		{
			public byte byStartMonth;	// 从1开始
			public byte byStartWeekNum;	// 第几个星期 从1开始 
			public byte byStartWeekday;	// 星期几
			public byte byEndMonth;		// 从1开始
			public byte byEndWeekNum;	// 第几个星期 从1开始 
			public byte byEndWeekday;	// 星期几
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidateModec
		{
			public ushort wStartYear;		// 年
			public byte byStartMon;		// 月
			public byte byStartDay;		// 日
			public ushort wEndYear;		// 年
			public byte byEndMon;		// 月
			public byte byEndDay;		// 日
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrHolidateUnion
		{	
			//联合体大小 12字节
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
			public uint[] dwSize;
			[FieldOffset(0)]
			public NetDvrHolidateModea	struModeA;	// 模式A
			[FieldOffset(0)]
			public NetDvrHolidateModeb	struModeB;	// 模式B
			[FieldOffset(0)]
			public NetDvrHolidateModec	struModeC;	// 模式C
		}

		public enum HoliDateMode
		{
			HolidateModea = 0,
			HolidateModeb,
			HolidateModec
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayParam
		{
			public byte byEnable;			// 是否启用
			public byte byDateMode;			// 日期模式 0-模式A 1-模式B 2-模式C
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			// 保留字节
			public NetDvrHolidateUnion uHolidate;	// 假日日期
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byName;	// 假日名称
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			// 保留字节
		}

		public const int MaxHolidayNum = 32;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayParamCfg
		{
			public uint dwSize;			// 结构体大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHolidayNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHolidayParam[] struHolidayParam;	// 假日参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留参数
		}

		//假日报警处理方式
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayHandle
		{
			public uint dwSize;				// 结构体大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;	// 布防时间段
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;		// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayRecord
		{
			public uint dwSize;
			public NetDvrRecordday struRecDay;     // 录像参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordsched[] struRecordSched; // 录像时间段
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //  保留字节
		}

		public const int MaxLinkV30 = 128;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneLink
		{
			public NetDvrIpaddr  struIP;     // 客户端IP
			public int lChannel;   // 通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLinkStatus
		{
			public uint dwSize;      // 结构体大小
			public ushort wLinkNum;    // 连接的数目
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLinkV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneLink[] struOneLink;   // 连接的客户端信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // 保留字节
		}

		public const int MaxBondNum = 2;

				//单BONDING网卡配置结构体
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrOneBonding
		{
			public byte byMode;
			public byte byUseDhcp;
			public byte byMasterCard;
			public byte byStatus;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNetworkCard, ArraySubType = UnmanagedType.I1)]
			public byte[] byBond;
			public NetDvrEthernetV30 struEtherNet;
			public NetDvrIpaddr struGatewayIpAddr;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//BONDING网卡配置结构体
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrNetworkBonding
		{  
			public uint dwSize;  
			public byte byEnable;
			public byte byNum;  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxBondNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneBonding[] struOneBond;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}


		//磁盘配额
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskQuota 
		{
			public byte byQuotaType;	 // 磁盘配额类型,1 - 按容量 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       // 保留字节
			public uint dwHCapacity;     // 分配的磁盘容量高32位 单位MB
			public uint dwLCapacity;     // 分配的磁盘容量低32位 单位MB
			public uint dwHUsedSpace;    // 已使用的磁盘大小高32位 单位MB
			public uint dwLUsedSpace;    // 已使用的磁盘大小低32位 单位MB
			public byte byQuotaRatio;    //	分配的磁盘比例,单位:%
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;      // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskQuotaCfg
		{
			public uint dwSize;         // 结构体大小
			public NetDvrDiskQuota struPicQuota;    //  图片配额
			public NetDvrDiskQuota struRecordQuota;    //  录像配额
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimingCapture
		{
			public NetDvrJpegpara struJpegPara;   // 定时抓图图片质量
			public uint dwPicInterval; //定时抓图时间间隔,单位s   1-1s 2-2s 3-3s 4-4s 5-5s 
									   //6-10m 7-30m 8-1h 9-12h 10-24h
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRelCaptureChan
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byChan;    // 按位表示
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          // 保留字节
		}

		public const int MaxPicEventNum = 32;
		public const int MaxAlarminCapture = 16;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRelCaptureChanV40
		{
			public uint dwMaxRelCaptureChanNum;  //最大可触发的关联通道数-只读属性
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwChanNo; //触发的关联抓图通道号，按值表示，采用紧凑型排列,0xffffffff表示后续无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventCaptureV40
		{
			public NetDvrJpegpara struJpegPara;   // 事件抓图图片质量
			public uint dwPicInterval;   // 事件抓图时间间隔  单位为秒 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPicEventNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChanV40[] struRelCaptureChan;   // 数组下标 0 移动侦测触发抓图 1 视频遮挡触发抓图 2 视频丢失触发抓图,数组3表示PIR报警抓图，数组4表示无线报警抓图，数组5表示呼救报警抓图,数组6表示智能抓图
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminCapture, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChanV40[] struAlarmInCapture;    // 报警输入触发抓图，下标0 代表报警输入1 依次类推
			public uint dwMaxGroupNum;  //设备支持的最大报警输入组数，每组16个报警输入
			public byte byCapTimes; //抓图张数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventCapture
		{
			public NetDvrJpegpara  struJpegPara;   // 事件抓图图片质量
			public uint dwPicInterval;  /*事件抓图时间间隔  单位为秒  1-1s 2-2s 3-3s 4-4s 5-5s 
											 * 6-10m 7-30m 8-1h 9-12h 10-24h*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPicEventNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChan[] struRelCaptureChan; /* 数组下标 0 移动侦测触发抓图 1 视频遮挡触发抓图,
																   * 2 视频丢失触发抓图,数组3表示PIR报警抓图，数组4表示无线报警抓图，
																   * 数组5表示呼救报警抓图,数组6表示智能抓图， 数组7表示人脸侦测*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminCapture, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChan[] struAlarmInCapture;  //报警输入触发抓图，下标0 代表报警输入1 依次类推
			public byte byCapTimes; //抓图张数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegCaptureCfgV40
		{
			public uint dwSize;               //结构体长度
			public NetDvrTimingCapture struTimingCapture;    
			public NetDvrEventCaptureV40 struEventCapture;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;     // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegCaptureCfg
		{
			public uint dwSize;         // 结构体大小
			public NetDvrTimingCapture struTimingCapture;    
			public NetDvrEventCapture struEventCapture;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;     // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCaptureDay
		{
			public byte byAllDayCapture;	// 是否全天抓图
			public byte byCaptureType;		// 抓图类型：0-定时抓图，1-移动侦测抓图，2-报警抓图，3-移动侦测或报警抓图，4-移动侦测和报警抓图，6-智能报警抓图
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCaptureSched
		{
			public NetDvrSchedtime struCaptureTime;        // 抓图时间段
			public byte byCaptureType;       // 抓图类型：0-定时抓图，1-移动侦测抓图，2-报警抓图，3-移动侦测或报警抓图，4-移动侦测和报警抓图，6-智能报警抓图
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           // 保留字节
		}

		//通道抓图计划
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSchedCapturecfg
		{
			public uint dwSize;     //结构体
			public byte byEnable;	//是否抓图
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	//保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCaptureDay[] struCaptureDay;//全天抓图计划
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCaptureSched[] struCaptureSched;//时间段抓图布防计划
			public NetDvrCaptureDay	struCaptureHoliday;	//假日抓图计划
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCaptureSched[] struHolidaySched;	//时间段假日抓图布防计划
			public uint dwRecorderDuration;	//抓图保存最长时间 0xffffffff表示该值无效 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;			//保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFlowTestParam
		{
			public uint dwSize;              //结构大小
			public int lCardIndex;         //网卡索引
			public uint dwInterval;         //设备上传流量时间间隔, 单位:100ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFlowInfo
		{
			public uint dwSize;             //结构大小
			public uint dwSendFlowSize;     //发送流量大小,单位kbps
			public uint dwRecvFlowSize;     //接收流量大小,单位kbps
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //保留 
		}

		//录像标签
		public const int LabelNameLen = 40;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordLabel
		{
			public uint dwSize;					// 结构体大小
			public NetDvrTime struTimeLabel;			// 标签的时间 
			public byte byQuickAdd;				// 是否快速添加 快速添加时标签名称无效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;				// 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	// 标签的名称 长度为40字节  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;				// 保留字节
		}

		public const int LabelIdentifyLen = 64;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLabelIdentify
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelIdentifyLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelIdentify;    // 64字节标识
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;               // 保留字节
		}

		public const int MaxDelLabelIdentify = 20;// 删除的最大标签标识个数

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDelLabelParam
		{
			public uint dwSize;       // 结构体大小
			public byte byMode;   // 按位表示,0x01表示按标识删除
			public byte byRes1;
			public ushort wLabelNum;      // 标签数目   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDelLabelIdentify, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLabelIdentify[] struIndentify; // 标签标识
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //保留字节    
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrModLabelParam
		{
			public NetDvrLabelIdentify struIndentify; //要修改的标签标识
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	//修改后的标签名称
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;				
		}

		//标签搜索结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindLabel
		{
			public uint dwSize;          // 结构体大小
			public int lChannel;		// 查找的通道
			public NetDvrTime	struStartTime;	// 开始时间
			public NetDvrTime	struStopTime;	// 结束时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	//  录像标签名称 如果标签名称为空，则搜索起止时间所有标签
			public byte byDrawFrame;		//0:不抽帧，1：抽帧
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
		}

		//标签信息结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindlabelData
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	// 标签名称
			public NetDvrTime struTimeLabel;		// 标签时间
			public NetDvrLabelIdentify struLabelIdentify; // 标签标识
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			// 保留字节
		}

		public const int CardnumLenV30 = 40;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindPictureParam
		{
			public uint dwSize;        //结构体大小 
			public int lChannel;       //通道号
			public byte byFileType;   /* 查找的图片类型:0定时抓图1 移动侦测抓图 2 报警抓图3  报警 | 移动侦测抓图 4 报警 & 移动侦测抓图
									   * 6 手动抓图 ,9-智能图片,10- PIR报警，11- 无线报警，12- 呼救报警,0xa 预览时截图，0xd 人脸侦测, 
									   * 0xe 越界侦测，0xf 入侵区域侦测，0x10 场景变更侦测, 0x11-设备本地回放时截图, 0x12-智能侦测，
									   * 0xff- 全部类型 2013-07-16*/  
			public byte byNeedCard;     //是否需要卡号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;      // 保留字节
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CardnumLenV30, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNum;     // 卡号
			public NetDvrTime  struStartTime;//查找图片的开始时间
			public NetDvrTime  struStopTime;// 查找图片的结束时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;     // 保留字节
		}

		public const int PictureNameLen = 64;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindPicture
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PictureNameLen)]
			public string sFileName;//图片名
			public NetDvrTime struTime;//图片的时间
			public uint dwFileSize;//图片的大小
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CardnumLenV30)]
			public string sCardNum;	//卡号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		//  保留字节
		}

		public const int MaxRecordPictureNum = 50;   //最大备份图片张数  

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBackupPictureParam
		{
			public uint dwSize;         // 结构体大小   
			public uint dwPicNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRecordPictureNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrFindPicture[] struPicture;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskDes;
			public byte byWithPlayer;
			public byte byContinue;    /*是否继续备份 0不继续 1继续*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionLimit
		{	
			public uint dwSize;           //结构体大小
			public uint dwChannel;        //通道号
			public byte byCompressType;   //待获取的压缩参数类型1,主码流2,子码流3,事件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //保留
			public NetDvrCompressioncfgV30  struCurrentCfg; //当前压缩参数配置
		}

		public const int StepReady      = 0;    //准备升级
		public const int StepRecvData  = 1;    //接收升级包数据
		public const int StepUpgrade    = 2;    //升级系统
		public const int StepBackup     = 3;    //备份系统
		public const int StepSearch     = 255;  //搜索升级文件

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoEffect
		{
			public uint dwBrightValue;      //亮度[0,255]
			public uint dwContrastValue;    //对比度[0,255]
			public uint dwSaturationValue;  //饱和度[0,255]
			public uint dwHueValue;         //色调[0,255]
			public uint dwSharpness;		  //锐度[0,255]
			public uint dwDenoising;		  //去噪[0,255]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoInputEffect
		{	
			public uint dwSize;				//结构体大小
			public ushort wEffectMode;        //模式 0-标准 1-室内 2-弱光 3-室外  255-自定义
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;        //保留
			public NetDvrVideoEffect struVideoEffect;	//视频效果参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			//保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoparaV40
		{
			public uint dwChannel;			// 通道号
			public uint dwVideoParamType;  	// 视频参数类型 0-亮度 1-对比度 2-饱和度 3-色度 4-锐度 5-去噪
			public uint dwVideoParamValue;  //对应的视频参数值，范围依据能力集
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDefaultVideoCond
		{
			public uint dwSize;			// 结构体大小
			public uint dwChannel;		// 通道号
			public uint dwVideoMode;	// 模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // 保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEncodeJointParam
		{
			public uint dwSize;			// 结构体大小
			public byte byJointed;		//  0 没有关联 1 已经关联
			public byte byDevType;		// 被关联的设备类型  1 代表智能设备
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;		// 保留字节
			public NetDvrIpaddr	struIP;			// 关联的被取流设备IP地址
			public ushort wPort;			// 关联的被取流设备端口号
			public ushort wChannel;		// 关联的被取流设备通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaChanWorkstatus
		{
			public byte byJointed;				// 0-没有关联  1-已经关联
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr	struIP;					// 关联的取流设备IP地址
			public ushort wPort;					// 关联的取流设备端口号
			public ushort wChannel;				// 关联的取流设备通道号
			public byte byVcaChanStatus;		// 0 - 未启用 1 - 启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;				// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaDevWorkstatus
		{
			public uint dwSize;			// 结构体大小
			public byte byDeviceStatus;	// 设备的状态0 - 正常工作 1- 不正常工作
			public byte byCpuLoad;		// CPU使用率0-100 分别代表使用百分率
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVcaChan, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVcaChanWorkstatus[] struVcaChanStatus;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;		// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionVideoplatformV40
		{
			/*各个子窗口对应解码通道所对应的解码子系统的槽位号(对于视频综合平台中解码子系统有效)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecoderId;
			//显示窗口所解视频分辨率，1-D1,2-720P,3-1080P，设备端需要根据此//分辨率进行解码通道的分配，如1分屏配置成1080P，则设备会把4个解码通
			//道都分配给此解码通道
			public byte byDecResolution;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 143, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionNotvideoplatformV40
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVgaDispChanCfgV40
		{        
			public uint dwSize; 
			public byte byAudio;			/*音频是否开启*/
			public byte byAudioWindowIdx;      /*音频开启子窗口*/
			public byte byVgaResolution;      /*分辨率，从能力集获取*/
			public byte byVedioFormat;         /*1:NTSC,2:PAL，0-NULL*/
			public uint dwWindowMode;		/*画面模式，能力集获取*/       
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
			public byte byEnlargeStatus;          /*是否处于放大状态，0：不放大，1：放大*/
			public byte byEnlargeSubWindowIndex;//放大的子窗口号
			public byte byScale; /*显示模式，0---真实显示，1---缩放显示( 针对BNC )*/
			/*区分共用体，0-视频综合平台内部解码器显示通道配置，1-其他解码器显示通道配置*/
			public byte byUnionType;
	
			[StructLayout(LayoutKind.Explicit)]
			public struct StruDiff
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
				public byte[] byRes;

				[FieldOffset(0)]
				public UnionVideoplatformV40 struVideoPlatform;

				[FieldOffset(0)]
				public UnionNotvideoplatformV40 struNotVideoPlatform;
			}
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrV6Subsystemparam
		{
			public byte bySerialTrans;//是否透传，0-否，1-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int NetDvrV6PsubsystemaramGet = 1501;//获取V6子系统配置
		public const int NetDvrV6PsubsystemaramSet = 1502;//设置V6子系统配置

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCorrectDeadpixelParam
		{
			public uint dwSize;
			public uint dwCommand; //命令：0-进入坏点模式，1-添加坏点，2-保存坏点，3-退出坏点
			public uint dwDeadPixelX; //坏点X坐标
			public uint dwDeadPixelY; //坏点Y坐标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		public const int MaxRedareaNum = 6;   //最大红绿灯区域个数

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRedareacfg
		{
			public uint dwSize;
			public uint dwCorrectEnable; //是否开启校正功能，0-关闭，1-开启
			public uint dwCorrectLevel; //校正级别，1(校正度最低)-10(校正度最高),默认为5
			public uint dwAreaNum; //校正区域个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRedareaNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaRect[] struLaneRect; //校正区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHistoricdatacfg
		{
			public uint dwSize;
			public uint dwTotalNum;  //历史数据个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int InquestMessageLen  = 44;    //审讯重点标记信息长度
		public const int InquestMaxRoomNum = 2;    //最大审讯室个数
		public const int MaxResumeSegment   = 2;     //支持同时恢复的片段数目

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestRoom
		{
			public byte byRoomIndex;     //审讯室编号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestMessage
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = InquestMessageLen)]
			public string sMessage; //重点标记信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                     //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestSensorDevice
		{
			public ushort wDeviceType;	//数据采集设备型号:0-无 1-米乐 2-镭彩 3-优力 4-佳盟 5-永控、6-垅上、7-维纳斯达
			public ushort wDeviceAddr;	//数据采集设备地址	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	    //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestSensorInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = InquestMaxRoomNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInquestSensorDevice[] struSensorDevice;
			public uint  dwSupportPro;      //支持协议类型,按位表示, 新版本走能力集，不再扩展此字段
							   //0x1:米乐 0x2:镭彩 0x4:优力
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestRoomInfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = NameLen)]
			public string szCDName;	//光盘名称，单室双刻光盘名称是一样的
			[StructLayout(LayoutKind.Explicit)]
			public struct UCalcMode
			{
				[FieldOffset(0)]
				public byte byBitRate;	// byCalcType为0时有效，(0-32、1-48、2-64、3-80、4-96、5-128、
								//6-160、7-192、8-224、9-256、10-320、11-384、12-448、
								//13-512、14-640、15-768、16-896前16个值保留)17-1024、18-1280、19-1536、
								//20-1792、21-2048、22-3072、23-4096、24-8192
				[FieldOffset(0)]
				public byte byInquestTime;  // byCalcType为1时有效，0-1小时, 1-2小时,2-3小时,3-4小时, 4-6小时,5-8小时
								//8-16小时, 9-20小时,10-22小时,11-24小时
			}
			public byte byCalcType;			//刻录计算类型0-按码率 1-按时间
			public byte byAutoDelRecord;	// 是否自动删除录像，0-不删除，即结束时保存录像 1-删除
			public byte byAlarmThreshold;		// 声音报警阀值
			public byte byInquestChannelResolution;     //审讯通道分辨率，0:720P  1:1080P
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestSystemInfo
		{
			public uint dwRecordMode;         //刻录模式:1 单室双刻模式 2 单室轮刻模式 3 双室双刻模式（修改需要重启设备）
			public uint  dwWorkMode;           //工作模式:0 标准模式 1 通用模式(保留，目前只有标准模式)
			public uint dwResolutionMode;     //设备分辨率，0:标清 1:D1 2:720P 3:1080P（高清审讯机不用此字段）
			public NetDvrInquestSensorInfo struSensorInfo;  //温湿度传感器配置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = InquestMaxRoomNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInquestRoomInfo[] struInquestRoomInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestResumeSegment
		{
			public NetDvrTime  struStartTime; //事件起始时间
			public NetDvrTime  struStopTime;  //事件终止时间
			public byte byRoomIndex;         //审讯室编号,从1开始
			public byte byDriveIndex;        //刻录机编号,从1开始
			public ushort wSegmetSize;         //本片断的大小, 单位M 
			public uint dwSegmentNo;         //本片断在本次审讯中的序号,从1开始 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestResumeEvent
		{
			public uint  dwResumeNum;       //需恢复的事件个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxResumeSegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInquestResumeSegment[] struResumeSegment;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestDeviceVersion
		{
			public byte byMainVersion;         /*基线主版本.
								   0 : 未知
								   1 : 8000审讯DVR
									   次版本: 1 : 8000HD-S
								   2 : 8100审讯DVR 
									   次版本: 1 : 审讯81SNL
											   2 : 审讯81SH
											   3 : 审讯81SFH
								   3 : 8608高清审讯机NVR 
									   次版本: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
			public byte bySubVersion;          //基线次版本
			public byte byUpgradeVersion;      //升级版本,未升级为0
			public byte byCustomizeVersion;     //定制版本,非定制为0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;             //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskRaidInfo 
		{
			public uint dwSize;   //结构体大小
			public byte byEnable;  //磁盘Raid是否禁用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSynchronousIpc
		{
			public uint dwSize;    //结构体大小
			public byte byEnable;  //是否启用：为前端IPC同步设备参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpcPasswd
		{
			public uint dwSize;    //结构体大小
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sOldPasswd;  //IPC的旧密码，传给DVR让DVR验证
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sNewPasswd;  //IPC的新密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//通过获取DVR的网络状态：单位bps
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDeviceNetUsingInfo 
		{
			public uint dwSize;    //结构体大小
			public uint dwPreview;   //预览
			public uint dwPlayback;  //回放
			public uint dwIPCModule; //IPC接入
			public uint dwNetDiskRW; //网盘读写
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//通过DVR设置前端IPC的IP地址
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpcNetcfg
		{
			public uint dwSize;      //结构体大小
			public NetDvrIpaddr struIP;       //IPC的IP地址
			public ushort wPort;       //IPC的端口
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 126)]
			public string res;  
		}

		//按时间锁定
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimeLock
		{
			public uint dwSize;      //结构体大小
			public NetDvrTime strBeginTime;
			public NetDvrTime strEndTime;
			public uint dwChannel;        //通道号, 0xff表示所有通道
			public uint dwRecordType;     //录像类型:  0xffffffff－全部，0－定时录像，1-移动侦测，2－报警触发，3-报警触发或移动侦测，4-报警触发和移动侦测，5-命令触发，6-手动录像，7-智能录像(同文件查找)
			public uint dwLockDuration;   //锁定持续时间,单位秒,0xffffffff表示永久锁定
			public NetDvrTimeEx strUnlockTimePoint;	//加锁时有效，当dwLockDuration不为永久锁定时，锁定持续的时间到此时间点就自动解锁
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLockReturn
		{
			public uint dwSize;      //结构体大小
			public NetDvrTime strBeginTime; 
			public NetDvrTime strEndTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//67DVS
		//证书下载类型
		public enum NetSdkUploadType 
		{
			UpgradeCertFile = 0, 
			UploadCertFile = 1,
			TrialCertFile = 2,
			ConfigurationFile = 3
		}

		public enum NetSdkDownloadType
		{
			NetSdkDownloadCert = 0,		//下载证书
			NetSdkDownloadIpcCfgFile = 1,//下载IPC配置文件
			NetSdkDownloadBaselineScenePic = 2, //下载基准场景图片
			NetSdkDownloadVqdAlarmPic = 3,       //下载VQD报警图片
			NetSdkDownloadConfigurationFile=4   //下载配置文件
		}

		//下载状态
	   public enum NetSdkDownloadStatus
	   {
			NetSdkDownloadStatusSuccess = 1,	//下载成功
			NetSdkDownloadStatusProcessing,		//正在下载
			NetSdkDownloadStatusFailed,			//下载失败
			NetSdkDownloadStatusUnkownError	//未知错误 
	   }

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBonjourCfg
		{
			public uint dwSize;				// 结构体大小
			public byte byEnableBonjour;		// Bonjour使能 0 ：开启 1：关闭
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;				
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byFriendlyName; 	// 服务名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSocksCfg
		{
			public uint dwSize;				// 结构体大小
			public byte byEnableSocks;  		// 使能 0：关闭 1：开启
			public byte byVersion;  			// SOCKS版本 4：SOCKS4   5：SOCKS5
			public ushort wProxyPort;				// 代理端口，默认1080
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byProxyaddr;  	// 代理IP地址，可以是域名
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName; 	// 用户名 SOCKS才用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword;			// 密码SOCKS5才用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLocalAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalAddr;  //不使用socks代理的网段，格式为"ip/netmask;ip/netmask;…"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrQosCfg
		{
			public uint dwSize;
			public byte byManageDscp;   // 管理数据的DSCP值 [0-63]
			public byte byAlarmDscp;    // 报警数据的DSCP值 [0-63]
			public byte byVideoDscp;    // 视频数据的DSCP值 [0-63]，byFlag为0时，表示音视频
			public byte byAudioDscp;    // 音频数据的DSCP值 [0-63]，byFlag为1时有效
			public byte byFlag;			// 0：音视频合一，1：音视频分开
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHttpsCfg
		{
			public uint dwSize;
			public ushort wHttpsPort;		// HTTPS端口
			public byte byEnable;		// 使能 0：关闭 1：开启
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//证书相关
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCertName
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCountryNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byCountry;  			//国家代号 CN等
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byState;				//洲或省
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocality;			//地区
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byOrganization;		//组织
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byUnit;				//单位
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byCommonName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byEmail;  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCertParam
		{
			public uint dwSize;
			public ushort wCertFunc; //证书种类，0-802.1x,1-HTTPS
			public ushort wCertType; //证书类型，0-CA，1-Certificate,2-私钥文件
			public byte byFileType; //证书文件类型，0-PEM,1-PFX
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		public const int UploadCertificate = 1; //上传证书

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCertInfo
		{
			public uint dwSize;
			public NetDvrCertParam struCertParam;	//证书参数
			public uint dwValidDays;   //有效天数，类型为自签名时有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPasswd;   //私钥密码
			public NetDvrCertName struCertName;    // 证书名称
			public NetDvrCertName struIssuerName;    // 证书发行者名称（自签名证书信息获取时有效）
			public NetDvrTimeEx struBeginTime;   //证书创建时间（自签名证书信息获取时有效）
			public NetDvrTimeEx struEndTime;   //证书截止时间（自签名证书信息获取时有效）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] serialNumber;   //证书标识码（自签名证书信息获取时有效）
			public byte byVersion; 
			public byte byKeyAlgorithm;			//加密类型 0-RSA  1-DSA
			public byte byKeyLen;				//加密长度 0-512  1-1024、 2-2048
			public byte bySignatureAlgorithm; //签名算法类型（自签名证书信息获取时有效）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//channel record status
		//***通道录像状态*****//
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChansRecordStatus
		{
			public byte byValid;       //是否有效
			public byte byRecord;      /*(只读)录像类型, 按位表示:0: 不在录像；1：在录像 2-空闲 
						3-无连接 4-无输入视频 5-未加载 6-存档中
							7-回传中 8-用户名或密码错 9-未验证
							10-存档中和录像中 11-录像回传中和录像中*/
			public ushort wChannelNO;   //通道号
			public uint dwRelatedHD;  //关联磁盘
			public byte byOffLineRecord;  //断网录像功能 0-关闭 1-开启
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpAlarmGroupNum
		{
			public uint dwSize; 
			public uint dwIPAlarmInGroup;      //IP通道报警输入组数
			public uint dwIPAlarmInNum;       //IP通道报警输入个数
			public uint dwIPAlarmOutGroup;     //IP通道报警输出组数
			public uint dwIPAlarmOutNum;      //IP通道报警输出个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  
		}
		
		//****NVR end***//
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChanGroupRecordStatus
		{
			public uint dwSize; //结构体大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChansRecordStatus[] struChanStatus; //一组64个
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRectcfg
		{
			public ushort wXCoordinate; /*矩形左上角起始点X坐标*/
			public ushort wYCoordinate; /*矩形左上角Y坐标*/
			public ushort wWidth;       /*矩形宽度*/
			public ushort wHeight;      /*矩形高度*/
		}

		/*窗口信息*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWincfg
		{
			public uint dwSize;
			public byte byVaild;
			public byte byInputIdx;          /*输入源索引*/
			public byte byLayerIdx;          /*图层，0为最底层*/
			public byte byTransparency; //透明度，0～100 
			public NetDvrRectcfg  struWin;//目的窗口(相对显示墙)
			public ushort wScreenHeight;//大屏高
			public ushort wScreenWidth;//大屏宽
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAllwincfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLayernums, ArraySubType = UnmanagedType.Struct)]
			public NetDvrWincfg[] struWinCfg;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenzoom
		{
			public uint dwSize;
			public uint dwScreenNum;//大屏号
			public NetDvrPointFrame struPointFrame;
			public byte byLayer;//图层号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//2011-04-18
		/*摄像机信息,最多9999个，从1开始 */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixCamerainfo
		{  
			public uint dwGlobalCamId;      /* cam的全局编号*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sCamName; /*cam的名称*/
			public uint dwMatrixId;          /*cam对应矩阵的编号*/
			public uint dwLocCamId;         /*cam对应矩阵的内部编号*/ 
			public byte byValid;    /*是否有效，0-否，1-是*/
			public byte byPtzCtrl; /* 是否可控，0-否，1-是*/
			public byte byUseType; //*使用类型，0-不作为干线使用，1-BNC，2-SP3,3-V6光纤，4-其他光纤*/ 
			public byte byUsedByTrunk;//当前使用状态，0-没有被使用，1-被干线使用 
			public byte byTrunkReq; /*摄像机分辨率,以D1为单位：1 - 1个D1，2- 2个D1，作为干线使用时，指的是干线的带宽*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrTime struInstallTime;//安装时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPurpose;/*用途描述*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;  
		}

		/*监视器信息，最多2048个*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixMonitorinfo 
		{
			public uint dwGloalMonId; /*mon 的统一编号*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sMonName;
			public uint dwMatrixId;  /*mon所在矩阵的编号*/
			public uint dwLocalMonId; /*mon的内部编号*/
			public byte byValid;    /*是否有效，0-否，1-是*/
			public byte byTrunkType; /*使用类型，0-不作为干线使用，1-BNC，2-SP3,3-V6光纤，4-其他光纤*/ 
			public byte byUsedByTrunk;//当前使用状态，0-没有被使用，1-被干线使用 
			public byte byTrunkReq; /*分辨率, 以D1为单位：1- 1个D1，2- 2个D1，作为干线使用时，指的是干线的带宽*/
			public NetDvrTime struInstallTime;//安装时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPurpose;/*用途描述*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixDigitalmatrix
		{
			public NetDvrIpaddr struAddress; /*设备为数字设备时的IP信息*/
			public ushort wPort;
			public byte byNicNum; /*0 - eth0, 1 - eth1, 考虑双网口如何通信加入绑定的网口*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixAnalogmatrix
		{
			public byte bySerPortNum;   /*连接的串口号*/
			public byte byMatrixSerPortType;/* 矩阵接入网关的串口与模拟矩阵的键盘口(键盘协议)连接还是与矩阵通信口（矩阵协议）连接 ，0 --- 矩阵协议通讯口 1 --- 键盘通讯口*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrSingleRs232 struRS232;	//232串口参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;      
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetMatrixUnion
		{
			[FieldOffset(0)]
			public NetMatrixDigitalmatrix struDigitalMatrix;
			[FieldOffset(0)]
			public NetMatrixAnalogmatrix struAnalogMatrix;
		}
		
		/*矩阵配置信息，最多20个*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixMatrixinfo 
		{
			public uint dwSize;
			public uint dwMatrixId;  /*矩阵编号*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDevName;
			public byte byCtrlType; /*指通讯方式是串口通信, 还是网络通信*/
			public byte byProtocolType;/*设置通信控制协议*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;   /*预留*/
			public NetMatrixUnion struMatrixUnion;
			public uint dwMaxPortsIn; /*矩阵输入数*/
			public uint dwMaxPortsOut;/*矩阵输出数*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;   /*登录用户名*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;  /*登录密码*/        
			public NetDvrTime struInstallTime;//安装时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPurpose;/*用途描述*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   /*预留*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixlist
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwMatrixNum;//设备返回的矩阵数量
			public IntPtr pBuffer;//矩阵信息缓冲区
			public uint dwBufLen;//所分配指针长度，输入参数
		}
 
		/*串口配置信息*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixUartparam
		{	
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPortName;
			public ushort wUserId; /*用户编号，当连接设备为键盘时，绑定一个用户，用于权限管理*/
			public byte byPortType;    /*串口类型，三种0-RS232/1-RS485/2-RS422*/
			public byte byFuncType; /*串口连接的设备的类型0-空闲，1-键盘，2-用作透明通道(485串口不可配置成透明通道),3-模拟矩阵*/     
			public byte byProtocolType;  /*串口支持的协议类型, 当连接键盘设备时需要该信息,获取键盘支持协议的编号及描述符*/
			public byte byBaudRate;
			public byte byDataBits;
			public byte byStopBits;   /*停止位*/
			public byte byParity;      /*校验*/
			public byte byFlowCtrl;   /*流控，软件流控，无流控*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     /*预留*/
		}

		//最多256个用户，1～256
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixUserparam 
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
			public byte byRole;/*用户角色:0-管理员,1-操作员；只有一个系统管理员，255个操作员*/
			public byte byLevel;  /*统一级别，用于操作级别管理,1- 255*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//最多255个资源组
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixResoursegroupparam
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byGroupName;
			public byte byGroupType;/*0-摄像机CAM组，1-监视器MON组*/
			public byte byRes1;
			public ushort wMemNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
			public uint[] dwGlobalId; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//最多255个用户组
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixUsergroupparam
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sGroupName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
			public ushort[] wUserMember;  /*包含的用户成员*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
			public ushort[] wResorceGroupMember; /*包含的资源组成员*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byPermission;//权限，数组0-ptz权限、切换权限、查询权限
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixTrunkparam
		{
			public uint dwSize;
			public uint dwTrunkId;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sTrunkName;
			public uint dwSrcMonId;
			public uint dwDstCamId;
			public byte byTrunkType;  /*使用类型  1-BNC，2-SP3光纤高清，3-SP3光纤D1， 4-V6光纤，5-其他光纤*/
			public byte byAbility;     /*表示光纤的带宽，可以传输几路*/
			public byte bySubChan;   /*针对光纤干线而言，表示子通道号*/
			public byte byLevel;		/* 干线级别 1-255*/
			public ushort wReserveUserID;	//预留的用户ID： 1~256 ，0表示释放预留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTrunklist
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwTrunkNum;//设备返回的干线数量
			public IntPtr pBuffer;//干线信息缓冲区
			public uint dwBufLen;//所分配指针长度，输入参数
		}

		public const int MatrixProtocolNum   = 20;    //支持的最大矩阵协议数
		public const int KeyboardProtocolNum = 20;    //支持的最大键盘协议数

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrProtoTypeEx
		{ 
			public ushort wType;               /*ipc协议值*/  
			public ushort wCommunitionType;		/*0：模拟 1：数字 2：兼容模拟、数字*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe; /*协议描述字段*/    
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixmanageAbiility
		{
			public uint dwSize;
			public uint dwMaxCameraNum;//最大Camera数量
			public uint dwMaxMonitorNum;//最大监视器数量
			public ushort wMaxMatrixNum;//最大矩阵数量
			public ushort wMaxSerialNum;//串口数量
			public ushort wMaxUser;//最大用户数
			public ushort wMaxResourceArrayNum;//最大资源组数
			public ushort wMaxUserArrayNum;//最大用户组数
			public ushort wMaxTrunkNum;//最大干线数
			public byte nStartUserNum;//起始用户号
			public byte nStartUserGroupNum;//起始用户组号
			public byte nStartResourceGroupNum;//起始资源组号
			public byte nStartSerialNum;//起始串口号
			public uint  dwMatrixProtoNum;     /*有效的矩阵协议数目，从0开始*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MatrixProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrProtoTypeEx[] struMatrixProto;/*最大协议列表长度*/ 
			public uint dwKeyBoardProtoNum;     /*有效的键盘协议数目，从0开始*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MatrixProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrProtoTypeEx[] struKeyBoardProto;/*最大协议列表长度*/   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//人脸抓拍规则(单条)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSingleFacesnapcfg
		{
			public byte byActive;				//是否激活规则：0-否，1-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //保留
			public NetVcaSizeFilter struSizeFilter;   //尺寸过滤器
			public NetVcaPolygon struVcaPolygon;		//人脸识别区域
		}

		//人脸抓拍规则参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapcfg
		{
			public uint dwSize;
			public byte bySnapTime;					//单个目标人脸的抓拍次数0-10
			public byte bySnapInterval;                 //抓拍间隔，单位：帧
			public byte bySnapThreshold;               //抓拍阈值，0-100
			public byte byGenerateRate; 		//目标生成速度,范围[1, 5]	
			public byte bySensitive;			//目标检测灵敏度，范围[1, 5]
			public byte byReferenceBright; //2012-3-27参考亮度[0,100]
			public byte byMatchType;         //2012-5-3比对报警模式，0-目标消失后报警，1-实时报警
			public byte byMatchThreshold;  //2012-5-3实时比对阈值，0~100
			public NetDvrJpegpara struPictureParam; //图片规格结构
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaSingleFacesnapcfg[] struRule; //人脸抓拍规则
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//人脸抓拍结果报警上传
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapResult
		{
			public uint dwSize;
			public uint dwRelativeTime;
			public uint dwAbsTime;
			public uint dwFacePicID;
			public uint dwFaceScore;
			public NetVcaTargetInfo struTargetInfo;
			public NetVcaRect struRect;
			public NetVcaDevInfo struDevInfo;
			public uint dwFacePicLen;
			public uint dwBackgroundPicLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
			public IntPtr pBuffer1;//指向人脸子图的图片数据
			public IntPtr pBuffer2;//背景图的图片数据（保留，通过查找背景图接口可以获取背景图）
		}

		//虚焦侦测结果
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDefocusAlarm
		{
			public uint dwSize;     /*结构长度*/
			public NetVcaDevInfo struDevInfo;/*设备信息*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAudioexceptionAlarm
		{
			public uint    dwSize;     /*结构长度*/
			public byte byAlarmType;//报警类型，1-音频输入异常，2-音频输入突变
			public byte byRes1;
			public ushort wAudioDecibel;//声音强度（音频输入突变时用到）
			public NetVcaDevInfo struDevInfo;/*设备信息*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetButtonDownExceptionAlarm
		{
			public uint dwSize;     /*结构长度*/
			public NetVcaDevInfo struDevInfo;/*设备信息*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFdImageCfg
		{
			public uint dwWidth;                  //灰度图像数据宽度
			public uint dwHeight;                 //灰度图像高度
			public uint dwImageLen;  //灰度图像数据长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
			public IntPtr pImage;    //灰度图像数据
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFdProcimgCfg
		{
			public uint  dwSize;           //结构大小
			public byte byEnable;         //是否激活规则;
			public byte bySensitivity;      //检测灵敏度，[0,5]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       //保留字节 
			public NetVcaSizeFilter struSizeFilter;  //尺寸过滤器
			public NetVcaPolygon  struPolygon;    //多边形
			public NetVcaFdImageCfg struFDImage;  //图片信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSubProcimg
		{
			public uint dwImageLen;  //图片数据长度
			public uint dwFaceScore;		//人脸评分,0-100
			public NetVcaRect struVcaRect; //人脸子图区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
			public IntPtr pImage;  //图片数据
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFdProcimgResult
		{
			public uint dwSize;   //结构大小
			public uint dwImageId; //大图ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
			public uint dwSubImageNum;  //人脸子图张数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTargetNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaSubProcimg[] struProcImg;  //单张子图信息
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPicmodelResult
		{
			public uint dwImageLen;  //图片数据长度
			public uint dwModelLen;  //模型数据长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
			public IntPtr pImage;  //人脸图片数据指针
			public IntPtr pModel;  //模型数据指针
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRegisterPic
		{
			public uint dwImageID; //大图ID
			public uint dwFaceScore;		//人脸评分,0-100
			public NetVcaRect struVcaRect;  //人脸子图区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
		}

		//籍贯参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAreainfocfg
		{
			public ushort wNationalityID;//国籍
			public ushort wProvinceID;//省
			public ushort wCityID;//市
			public ushort wCountyID;//县
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		//人员信息结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHumanAttribute
		{
			public byte bySex;//性别：0-男，1-女
			public byte byCertificateType;//证件类型：0-身份证，1-警官证
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanBirthdateLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byBirthDate;//出生年月，如：201106
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byName; //姓名
			public NetDvrAreainfocfg struNativePlace;//籍贯参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byCertificateNumber; //证件号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHumanattributeCond
		{
			public byte bySex; //性别：0-不启用，1-男，2-女
			public byte byCertificateType; //证件类型：0-不启用，1-身份证，2-警官证
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanBirthdateLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byStartBirthDate; //起始出生年月，如：201106
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanBirthdateLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byEndBirthDate; //截止出生年月，如201106
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byName; //姓名
			public NetDvrAreainfocfg struNativePlace; //籍贯参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byCertificateNumber;  //证件号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//黑名单信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistInfo
		{
			public uint dwSize;//结构大小
			public uint dwRegisterID;//名单注册ID号（只读）
			public uint dwGroupNo;//分组号
			public byte byType;//黑白名单标志：0-全部，1-白名单，2-黑名单
			public byte byLevel;//黑名单等级，0-全部，1-低，2-中，3-高
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留
			public NetVcaHumanAttribute struAttribute;//人员信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemark;//备注信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistPara
		{
			public uint dwSize;   //结构大小
			public NetVcaBlacklistInfo struBlackListInfo;  //黑名单基本参数
			public uint dwRegisterPicNum;  //黑名单图个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanPictureNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPicmodelResult[] struRegisterPic;  //黑名单图片信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistCond
		{
			public int lChannel; //通道号
			public uint dwGroupNo; //分组号
			public byte byType; //黑白名单标志：0-全部，1-白名单，2-黑名单
			public byte byLevel; //黑名单等级，0-全部，1-低，2-中，3-高
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //保留
			public NetVcaHumanAttribute struAttribute; //人员信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistPic
		{
			public uint dwSize;   //结构大小
			public uint dwFacePicNum;  //人脸图个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanPictureNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPicmodelResult[] struBlackListPic;  //单张照片信息
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFindPicturecond
		{
			public int lChannel;//通道号
			public NetDvrTime struStartTime;//开始时间
			public NetDvrTime struStopTime;//结束时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		public const int MaxFacePicLen = 6144;   //最大人脸图片数据长度
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSubSnappicData
		{
			public uint dwFacePicID; //人脸图ID
			public uint dwFacePicLen;  //人脸图数据长度
			public NetDvrTime struSnapTime;  //抓拍时间
			public uint dwSimilarity; //相似度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxFacePicLen)]
			public string sPicBuf;  //图片数据
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAdvanceFind
		{
			public uint dwFacePicID; //人脸图片ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaNormalFind
		{
			public uint dwImageID; //大图ID
			public uint dwFaceScore;  //人脸评分
			public NetVcaRect struVcaRect; //人脸子图区域
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetVcaFindSnappicUnion
		{
			//联合体大小为44字节
			[FieldOffset(0)]
			public NetVcaNormalFind  struNormalFind; //普通检索
			[FieldOffset(0)]
			public NetVcaAdvanceFind struAdvanceFind; //高级检索
		}

		public enum VcaFindSnappicType
		{
			VcaNormalFind  = 0x00000000,   //普通检索
			VcaAdvanceFind  = 0x00000001  //高级检索
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFindPicturecondAdvance
		{
			public int lChannel;//通道号
			public NetDvrTime struStartTime;//开始时间
			public NetDvrTime struStopTime;//结束时间
			public byte byThreshold;  //阈值，0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
			public VcaFindSnappicType dwFindType;//检索类型，详见VCA_FIND_SNAPPIC_TYPE
			public NetVcaFindSnappicUnion uFindParam; //检索参数
		}

		//人脸抓拍信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapInfoAlarm
		{
			public uint dwRelativeTime;
			public uint dwAbsTime;
			public uint dwSnapFacePicID;
			public uint dwSnapFacePicLen;
			public NetVcaDevInfo struDevInfo;//人脸抓拍上传信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
			public IntPtr pBuffer1;//指向图片的指针
		}
		//黑名单报警信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistInfoAlarm
		{
			public NetVcaBlacklistInfo struBlackListInfo;
			public uint dwBlackListPicLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
			public IntPtr pBuffer1;//指向图片的指针
		}

		//黑名单比对结果报警上传
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapMatchAlarm
		{
			public uint dwSize;
			public float fSimilarity;//相似度，取值范围：[0.001,1]
			public NetVcaFacesnapInfoAlarm struSnapInfo;//人脸抓拍上传信息
			public NetVcaBlacklistInfoAlarm struBlackListInfo;//黑名单报警信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}   
   
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistInfoAlarmLog
		{
			public NetVcaBlacklistInfo struBlackListInfo; //黑名单基本信息
			public uint dwBlackListPicID;       //黑名单人脸子图ID，用于查找图片
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapInfoAlarmLog
		{
			public uint dwRelativeTime;     // 相对时标
			public uint dwAbsTime;			// 绝对时标
			public uint dwSnapFacePicID;       //抓拍人脸图ID
			public NetVcaDevInfo struDevInfo;		//前端设备信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapMatchAlarmLog
		{
			public uint dwSize;     		// 结构大小
			public float fSimilarity; //相似度，[0.001,1]
			public NetVcaFacesnapInfoAlarmLog  struSnapInfoLog; //抓拍信息
			public NetVcaBlacklistInfoAlarmLog struBlackListInfoLog; //黑名单信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacematchPiccond
		{
			public uint dwSize;     		// 结构大小
			public uint dwSnapFaceID; //抓拍人脸子图ID
			public uint dwBlackListID; //匹配的黑名单ID
			public uint dwBlackListFaceID; //比对的黑名单人脸子图ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // 保留字节
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacematchPicture
		{
			public uint dwSize;     		// 结构大小
			public uint dwSnapFaceLen; //抓拍人脸子图长度
			public uint dwBlackListFaceLen; //比对的黑名单人脸子图长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              //保留字节
			public IntPtr pSnapFace;  //抓拍人脸子图的图片数据
			public IntPtr pBlackListFace;  //比对的黑名单人脸子图数据
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistFastregisterPara
		{
			public uint dwSize;   //结构大小
			public NetVcaBlacklistInfo struBlackListInfo;  //黑名单基本参数
			public uint dwImageLen;  //图像数据长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
			public IntPtr pImage;    //图像数据
		}

		//单个分区配置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSinglePath
		{
			public byte byActive;  // 是否可用,0-否,1-是 
			public byte byType;   //0-存储抓拍，1-存储黑名单比对报警，2-存储抓拍和黑名单比对报警，0xff-无效
			public byte bySaveAlarmPic; //是否用于保存断网的报警图片，0-否，1-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1; //保留
			public uint dwDiskDriver;   //盘符号，从0开始
			public uint dwLeftSpace;   //预留容量（单位为G）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //保留
		}

		//存储路径设置
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSavePathCfg
		{ 
			public uint dwSize;   //结构大小
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetVcaSinglePath[] struPathInfo; //单个分区
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevAccessCfg
		{
			public uint   dwSize;
			public NetDvrIpaddr struIP;		//接入设备的IP地址
			public ushort wDevicePort;			 	//端口号
			public byte byEnable;		         //是否启用，0-否，1-是
			public byte byRes1;				//保留
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	//接入设备的登录帐号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	//接入设备的登录密码
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		/********************************智能人脸识别 end****************************/
		//分辨率
		public const int NotAvaliable = 0;
		public const int Svga60Hz = 52505660;
		public const int Svga75Hz = 52505675;
		public const int Xga60Hz = 67207228;
		public const int Xga75Hz = 67207243;
		public const int Sxga60Hz = 84017212;
		public const int Sxga260Hz = 84009020;
		public const int _720P_60HZ = 83978300;
		public const int _720P_50HZ = 83978290;
		public const int _1080I_60HZ = 394402876;
		public const int _1080I_50HZ = 394402866;
		public const int _1080P_60HZ = 125967420;
		public const int _1080P_50HZ = 125967410;
		public const int _1080P_30HZ = 125967390;
		public const int _1080P_25HZ = 125967385;
		public const int _1080P_24HZ = 125967384;
		public const int Uxga60Hz = 105011260;
		public const int Uxga30Hz = 105011230;
		public const int Wsxga60Hz = 110234940;
		public const int Wuxga60Hz = 125982780;
		public const int Wuxga30Hz = 125982750;
		public const int Wxga60Hz = 89227324;
		public const int SxgaPlus60Hz = 91884860;

		//显示通道画面分割模式
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispwindowmode
		{
			public byte byDispChanType;//显示通道类型：0-VGA, 1-BNC, 2-HDMI, 3-DVI
			public byte byDispChanSeq;//显示通道序号,从1开始，如果类型是VGA，则表示第几个VGA
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byDispMode;
		}

		//显示通道信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispinfo
		{
			public byte byChanNums;//通道个数
			public byte byStartChan;//起始通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSupportRes, ArraySubType = UnmanagedType.U1)]
			public uint[] dwSupportResolution;//支持的分辨率
		}

		//大屏拼接信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreeninfo
		{
			public byte bySupportBigScreenNums;//最多大屏拼接数量
			public byte byStartBigScreenNum;//大屏拼接起始号
			public byte byMaxScreenX;//大屏拼接模式
			public byte byMaxScreenY;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixAbilityV41
		{
			public uint dwSize;
			public byte byDspNums;//DSP个数  
			public byte byDecChanNums;//解码通道数
			public byte byStartChan;//起始解码通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public NetDvrDispinfo struVgaInfo;//VGA显示通道信息
			public NetDvrDispinfo struBncInfo;//BNC显示通道信息
			public NetDvrDispinfo struHdmiInfo;//HDMI显示通道信息
			public NetDvrDispinfo struDviInfo;//DVI显示通道信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDispnumV41, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDispwindowmode[] struDispMode;
			public NetDvrScreeninfo struBigScreenInfo;
			public byte bySupportAutoReboot; //是否支持自动重启，0-不支持，1-支持
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public const int MaxWindows = 16;//最大窗口数
		public const int MaxWindowsV41 = 36;
		
		public const int StartdispchanVga = 1;
		public const int StartdispchanBnc = 9;
		public const int StartdispchanHdmi	= 25;
		public const int StartdispchanDvi = 29;

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrVideoPlatform
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[FieldOffset(0)]
			public VideoPlatform struVideoPlatform;
			[FieldOffset(0)]
			public NotVideoPlatform struNotVideoPlatform;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct VideoPlatform
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecoderId;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byDecResolution;
			public NetDvrRectcfg struPosition; //显示通道在电视墙中位置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NotVideoPlatform
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*显示通道配置结构体*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixVoutcfg
		{
			public uint dwSize;
			public byte byAudio;			/*音频是否开启*/
			public byte byAudioWindowIdx;      /*音频开启子窗口*/
			public byte byDispChanType;      /*显示通道类型：0-BNC，1-VGA，2-HDMI，3-DVI，4-YPbPr(解码卡服务器DECODER_SERVER专用)*/
			public byte byVedioFormat;         /*1:NTSC,2:PAL，0-NULL*/
			public uint dwResolution;//分辨率
			public uint dwWindowMode;		/*画面模式，能力集获取*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*各个子窗口关联的解码通道,设备支持解码资源自动分配时此参数不用填充*/
			public byte byEnlargeStatus;          /*是否处于放大状态，0：不放大，1：放大*/
			public byte byEnlargeSubWindowIndex;//放大的子窗口号
			public byte byScale; /*显示模式，0---真实显示，1---缩放显示( 针对BNC )*/
			public byte byUnionType;/*区分共用体,0-视频综合平台内部解码器显示通道配置，1-其他解码器显示通道配置*/
			public NetDvrVideoPlatform struDiff;
			public uint dwDispChanNum; //显示输出号，此参数在全部获取时有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		} 

		/*解码器设备状态*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispChanStatusV41
		{
			public byte byDispStatus;      /*显示状态：0：未显示，1：启动显示*/
			public byte byBVGA;              /*0-BNC，1-VGA， 2-HDMI，3-DVI，0xff-无效*/
			public byte byVideoFormat;     /*视频制式，1:NTSC,2:PAL,0-NON*/
			public byte byWindowMode;       /*画面模式*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;   /*各个子画面关联的解码通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byFpsDisp;        /*每个子画面的显示帧率*/
			public byte byScreenMode;		/*屏幕模式0-普通 1-大屏*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwDispChan; /*获取全部显示通道状态时有效，设置时可填0*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
		}

		/*解码器设备状态*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderWorkStatusV41
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanStatus[] struDecChanStatus;     /*解码通道状态*/
			/*显示通道状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDispnumV41, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDispChanStatusV41[] struDispChanStatus;     
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatus;         /*报警输入状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatus;       /*报警输出状态*/
			public byte byAudioInChanStatus;          /*语音对讲状态*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*******************************文件回放-远程回放设置*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecRemotePlayV41
		{
			public uint dwSize;
			public NetDvrIpaddr	struIP;		/* DVR IP地址 */	
			public ushort wDVRPort;			/* 端口号 */	
			public byte byChannel;			/* 通道号 */
			public byte byReserve;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;		/* 用户名 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;		/* 密码 */
			public uint dwPlayMode;   	/* 0－按文件 1－按时间*/        	
			public NetDvrTime StartTime;
			public NetDvrTime StopTime;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		/*保留*/
		}

		public const int MaxBigscreennumScene = 100;

		//显示通道配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRectcfgScene
		{
			public ushort wXCoordinate; /*矩形左上角起始点X坐标*/
			public ushort wYCoordinate; /*矩形左上角Y坐标*/
			public ushort wWidth;       /*矩形宽度*/
			public ushort wHeight;      /*矩形高度*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScenedispcfg
		{
			public byte byEnable;//是否启用，0-不启用，1-启用
			public byte bySoltNum;//槽位号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byDispChanNum;
			public byte byAudio;				/*音频是否开启,0-否，1-是*/
			public byte byAudioWindowIdx;      /*音频开启子窗口*/
			public byte byVedioFormat;          /*1:NTSC,2:PAL，0-NULL*/
			public byte byWindowMode;			/*画面模式，从能力集获取*/
			public byte byEnlargeStatus;         /*是否处于放大状态，0：不放大，1：放大*/
			public byte byEnlargeSubWindowIndex;//放大的子窗口号    
			public byte byScale; /*显示模式，0-真实显示，1-缩放显示( 针对BNC )*/
			public uint dwResolution;//分辨率
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*各个子窗口关联的解码通道*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecoderId;/*槽位号*/
			//显示窗口所解视频分辨率，1-D1,2-720P,3-1080P，设备端需要根据此//分辨率进行解码通道的分配，如1分屏配置成1080P，则设备会把4个解码通道都分配给此解码通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byDecResolution;
			public byte byRow;//大屏所在的行的序号
			public byte byColumn;//大屏所在的列的序号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrRectcfg struDisp; //电视墙显示位置
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevChanInfoScene
		{
			public NetDvrIpaddr struIP;				/* DVR IP地址 */
			public ushort wDVRPort;			 	/* 端口号 */
			public byte byChannel;		/* 通道号，对于9000等设备的IPC接入，通道号从33开始 */
			public byte byTransProtocol;		/* 传输协议类型0-TCP，1-UDP ，2-MCAST，3-RTP*/
			public byte byTransMode;			/* 传输码流模式 0－主码流 1－子码流*/
			public byte byFactoryType;				/*前端设备厂家类型*/
			public byte byDeviceType;			//设备类型，1-IPC，2- ENCODER
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	/* 监控主机登陆帐号 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	/* 监控主机密码 */
		}

		/*流媒体服务器基本配置*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamMediaServerCfgScene
		{
			public byte byValid;			/*是否启用流媒体服务器取流,0表示无效*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struDevIP;	/*流媒体服务器地址*/
			public ushort wDevPort;			/*流媒体服务器端口*/
			public byte byTransmitType;		/*传输协议类型0-TCP，1-UDP */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPuStreamCfgScene
		{
			public NetDvrStreamMediaServerCfgScene	streamMediaServerCfg;
			public NetDvrDevChanInfoScene				struDevChanInfo;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCycSurChanEleScene
		{
			public byte byEnable;	/* 是否启用 0－否 1－启用*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrStreamMediaServerCfgScene	struStreamMediaSvrCfg;	
			public NetDvrDevChanInfoScene			struDecChanInfo;	/*轮巡解码通道信息*/
		}

		//轮巡解码结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixLoopDecinfoScene
		{
			public ushort wPoolTime;		/*轮询间隔*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChan, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCycSurChanEleScene[] struChanArray;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//单个解码通道配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodechancfgScene
		{
			public byte byDecodeEnable;//解码起停标志，0-停止，1-启用动态解码，2-启用轮巡解码
			public byte bySlotNum;//槽位号
			public byte byDecChan;
			public byte byJointAllDecodeChan;		//是否关联万能解码通道 0-不关联，1-关联
			public byte byJointSlotNum;			//关联的槽位号（万能解码板的槽位号）
			public byte byJointChanNum;		//关联的通道号（万能解码板通道号）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public Strudeccfg struDecCfg;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct Strudeccfg
		{
			//[FieldOffset(0)]
			//[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5480, ArraySubType = UnmanagedType.I1)]
			//public byte[] byRes;
			[FieldOffset(0)]
			public NetDvrPuStreamCfgScene struSceneDynamicDecCfg;
			[FieldOffset(0)]
			public NetDvrMatrixLoopDecinfoScene struSceneCycDecCfg;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBigscreencfgScene
		{
			public byte byAllValid; /*漫游使能标志 */
			public byte byAssociateBaseMap;//关联的底图序号，0代表不关联
			public byte byEnableSpartan;//大屏畅显使能，1-开，0-关
			public byte byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLayernums, ArraySubType = UnmanagedType.Struct)]
			public NetDvrWincfg[] struWinCfg;
			public NetDvrBigscreencfg struBigScreen;

			public void Init()
			{
				struBigScreen = new NetDvrBigscreencfg();
				struWinCfg = new NetDvrWincfg[MaxLayernums];
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixScenecfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSceneName;
			public byte byBigScreenNums;//大屏的个数，最大值通过能力集获取
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public ushort wDecChanNums;//场景中解码通道的个数
			public ushort wDispChanNums;//场景中显示通道的个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public IntPtr pBigScreenBuffer;//大屏配置缓冲区, byBigScreenNums×sizeof(NET_DVR_BIGSCREENCFG_SCENE)
			public IntPtr pDecChanBuffer;//解码通道配置缓冲区, wDecChanNums×sizeof(NET_DVR_DECODECHANCFG_SCENE)
			public IntPtr pDispChanBuffer;//显示通道配置缓冲区, wDispChanNums×sizeof(NET_DVR_SCENEDISPCFG)
			public void Init()
			{
				sSceneName = new byte[NameLen];
				byRes1 = new byte[3];
				byRes1 = new byte[12];
			}
		}
		public const int NetDvrGetAllwincfg = 1503; //窗口参数获取

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBigscreenassociatecfg
		{
			public uint dwSize;
			public byte byEnableBaseMap;//使能底图显示
			public byte byAssociateBaseMap;//关联的底图序号，0代表不关联
			public byte byEnableSpartan;//大屏畅显使能，1-开，0-关
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		/*******************************窗口设置*******************************/
		public const int MaxWinCount = 224; //支持的最大开窗数

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenWincfg{
			public uint dwSize;
			public byte byVaild;
			public byte byInputType;		//见CAM_MDOE
			public ushort wInputIdx;			/*输入源索引*/
			public uint dwLayerIdx;			/*图层，0为最底层*/
			public NetDvrRectcfg struWin;	//目的窗口(相对显示墙)
			public byte byWndIndex;			//窗口号
			public byte byCBD;				//0-无，1-带背景，2-不带背景
			public byte bySubWnd;			//0不是，1是
			public byte byRes1;
			public uint dwDeviceIndex;//设备序号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWinlist
		{
			public uint dwSize;
			public ushort wScreenSeq;	//设备序号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwWinNum;	//设备返回的窗口数量
			public IntPtr pBuffer;	//窗口信息缓冲区，最大为224*sizeof(NET_DVR_WINCFG)
			public uint dwBufLen;	//所分配指针长度
		}

		public const int MaxLayoutCount = 16;		//最大布局数

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLayoutcfg
		{
			public uint dwSize;
			public byte byValid;								//布局是否有效
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLayoutName;			//布局名称			
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWinCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrScreenWincfg[] struWinCfg;	//布局内窗口参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLayoutList
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLayoutCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLayoutcfg[] struLayoutInfo;   //所有布局
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int MaxCamCount = 224;

		public enum NetDvrCamMode
		{
			NetDvrUnknow  = 0,//无效
			NetDvrCamBnc,
			NetDvrCamVga,
			NetDvrCamDvi,
			NetDvrCamHdmi,
			NetDvrCamIp,
			NetDvrCamRgb,
			NetDvrCamDecoder,
			NetDvrCamMatrix,
			NetDvrCamYpbpr,
			NetDvrCamUsb,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputstreamcfg
		{
			public uint dwSize ;
			public byte byValid ;
			public byte byCamMode;						//信号输入源类型，见NET_DVR_CAM_MODE
			public ushort wInputNo;						//信号源序号0-224
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sCamName;			//信号输入源名称
			public NetDvrVideoeffect struVideoEffect;	//视频参数
			public NetDvrPuStreamCfg struPuStream;	//ip输入时使用
			public ushort wBoardNum ;						//信号源所在的板卡号
			public ushort wInputIdxOnBoard;				//信号源在板卡上的位置
			public ushort wResolutionX;					//分辨率
			public ushort wResolutionY;
			public byte byVideoFormat;					//视频制式，0-无，1-NTSC，2-PAL
			public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp 。网络信号源的分辨率，在添加网络信号源时传给设备，设备根据这个分辨率来分配解码资源。
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sGroupName;	//网络信号源分组 组名
			public byte byJointMatrix;			//  关联矩阵 ，0-不关联  1-关联
			public byte byRes;  
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputstreamList
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCamCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInputstreamcfg[] struInputStreamInfo; //所有信号源
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*******************************输出参数配置*******************************/
		/*输出通道管理*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOutputparam
		{
			public uint  dwSize;
			public byte byMonMode;		/*输出连接模式,1-BNC,2-VGA,3-DVI,4-HDMI*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint  dwResolution;	/*分辨率，根据能力集获取所支持的进行设置*/
			public NetDvrVideoeffect  struVideoEffect;	/*输出通道视频参数配置*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOutputcfg
		{
			public uint dwSize;
			public byte byScreenLayX;						//大屏布局-横坐标
			public byte byScreenLayY;						//大屏布局-纵坐标
			public ushort wOutputChanNum;					//输出通道个数，0表示设备支持的最大输出通道个数，最大个数从能力集获取，其他值表示实际输出通道个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrOutputparam struOutputParam;	/*输出通道视频参数配置*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sWallName;					//电视墙名称
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************能力集*******************************/
		public const int ScreenProtocolNum = 20;   //支持的最大大屏控制器协议数
		
		//多屏服务器能力集
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenserverAbility
		{
			public uint dwSize;   			/*结构长度*/
			public byte byIsSupportScreenNum; /*所支持大屏控制器的数目*/
			public byte bySerialNums;			//串口个数
			public byte byMaxInputNums;
			public byte byMaxLayoutNums;
			public byte byMaxWinNums;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byMaxScreenLayX;//大屏布局-最大横坐标大屏数
			public byte byMaxScreenLayY;//大屏布局-最大纵坐标大屏数
			public ushort wMatrixProtoNum; /*有效的大屏协议数目*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = ScreenProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrProtoType[] struScreenProto;/*最大协议列表*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//多屏控制器能力集
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreencontrolAbility
		{
			public uint dwSize;   		/*结构长度*/
			public byte byLayoutNum; 		/* 布局个数*/
			public byte byWinNum; 			/*屏幕窗口个数*/
			public byte byOsdNum;  		/*OSD个数*/
			public byte byLogoNum; 		/*Logo个数*/
			public byte byInputStreamNum;  //输入源个数 ---设备支持最大输入通道个数（包括本地输入源和网络输入源）
			public byte byOutputChanNum;	//输出通道个数---设备支持最大输出通道个数
			public byte byCamGroupNum;		/*分组个数*/
			public byte byPlanNum;    		/*预案个数*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byIsSupportPlayBack;  /*是否支持回放*/	
			public byte byMatrixInputNum;  //支持输入矩阵最大个数
			public byte byMatrixOutputNum; //支持输出矩阵最大个数
			public NetDvrDispinfo struVgaInfo;//VGA输出信息
			public NetDvrDispinfo struBncInfo;//BNC输出信息
			public NetDvrDispinfo struHdmiInfo;//HDMI输出信息
			public NetDvrDispinfo struDviInfo;//DVI输出信息
			public byte byMaxUserNums;//支持用户数
			public byte byPicSpan;		//底图跨度，一张底图最多可覆盖的屏幕数
			public ushort wDVCSDevNum;	//分布式大屏控制器最大设备数
			public ushort wNetSignalNum;	//最大网络输入源个数
			public ushort wBaseCoordinateX;//基准坐标
			public ushort wBaseCoordinateY; 
			public byte byExternalMatrixNum;	//最大外接矩阵个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************输入信号状态*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAnaloginputstatus
		{
			public uint dwLostFrame;		/*视频输入丢帧数*/
			public byte byHaveSignal;		/*是否有视频信号输入*/
			public byte byVideoFormat;		/*视频制式，1：NTSC,2：PAL,0：无*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		} 

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrInputstatusUnion
		{
			[FieldOffset(0)]
			public NetDvrMatrixChanStatus struIpInputStatus;
			[FieldOffset(0)]
			public NetDvrAnaloginputstatus struAnalogInputStatus;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputstatus
		{
			public ushort wInputNo;		/*信号源序号*/
			public byte byInputType;	//见NET_DVR_CAM_MODE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrInputstatusUnion struStatusUnion;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreeninputstatus
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwNums;		//设备返回的输入源状态的数量
			public IntPtr pBuffer;	//缓冲区
			public uint dwBufLen;	//所分配指针长度，输入参数
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenalarmcfg
		{
			public uint dwSize;
			public byte byAlarmType;	//报警类型，1-子板拔出，2-子板插入，3-子系统状态异常，4-子系统恢复恢复 5-输入源异常   6-温度报警 7-FPGA版本不匹配 8-预案开始 9-预案结束 10-解码板断网 11-解码板IP地址冲突，12-风扇异常
			public byte byBoardType;	// 1-输入板 2-输出板 ，3-主板，4-背板，报警类型为1，2，3，6的时候使用 
			public byte bySubException;	//输入异常时具体子异常 1- 分辨率正常改变 2-输入端口类型改变3-分辨率错误4-分辨率改变导致解码资源不足，关闭该输入源对应窗口。5-分辨率改变，导致已开窗的缩放比例不在1/8到8倍范围。6-分辨率恢复正常,7-分辨率改变导致输出板数据量超限,设备关闭窗口 
			public byte byRes1;
			public ushort wStartInputNum; // 异常输入源（异常起点） 
			public ushort wEndInputNum;	// 异常输入源（异常终点） 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	   
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixCfg
		{
			public byte byValid;				//判断是否是模拟矩阵（是否有效）
			public byte byCommandProtocol;	//模拟矩阵的指令（4种）
			public byte byScreenType;			//保留	
			public byte byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byScreenToMatrix;	//模拟矩阵的输出与屏幕的对应关系
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDigitalscreen
		{
			public NetDvrIpaddr  struAddress;/*设备为数字设备时的IP信息*/
			public ushort wPort;		//通道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAnalogscreen
		{
			public byte byDevSerPortNum;   /*连接设备的串口号*/
			public byte byScreenSerPort;  /*连接大屏的串口号*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   
			public NetDvrMatrixCfg struMatrixCfg;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrScreenUnion
		{
			[FieldOffset(0)]
			public NetDvrDigitalscreen struDigitalScreen;
			[FieldOffset(0)]
			public NetDvrAnalogscreen struAnalogScreen;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenScreeninfo
		{
			public uint dwSize;
			public byte byValid;				//是否有效
			public byte nLinkMode;				//连接方式，0-串口，1-网口
			public byte byDeviceType;			//设备型号，能力集获取
			public byte byScreenLayX;			//大屏布局-横坐标
			public byte byScreenLayY;			//大屏布局-纵坐标
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	/*登录用户名*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword; /*登录密码*/   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDevName;	/*设备名称*/
			public NetDvrScreenUnion struScreenUnion;
			public byte byInputNum;			// 输入源个数
			public byte byOutputNum;			// 输出源个数
			public byte byCBDNum;				//CBD个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************底图上传*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBasemapCfg
		{	
			public byte byScreenIndex;         //屏幕的序号
			public byte byMapNum;				/*被分割成了多少块*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
			public ushort wSourWidth;			/* 原图片的宽度 */
			public ushort wSourHeight;			/* 原图片的高度 */
		}            

		/*******************************OSD*******************************/
		public const int MaxOsdcharNum = 256;
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOsdcfg
		{
			public uint dwSize;
			public byte byValid;    /*是否有效 0无效 1有效*/
			public byte byDispMode;  //显示模式，1-透明，2-半透明，3-覆盖三种模式
			public byte byFontColorY; /*字体颜色Y,0-255*/
			public byte byFontColorU; /*字体颜色U,0-255*/
			public byte byFontColorV; /*字体颜色V,0-255*/
			public byte byBackColorY; /*背景颜色Y,0-255*/
			public byte byBackColorU; /*背景颜色U,0-255*/
			public byte byBackColorV; /*背景颜色V,0-255*/
			public ushort wXCoordinate;   /*OSD在屏幕左上角位置x*/
			public ushort wYCoordinate;   /*OSD在屏幕左上角位置y*/
			public ushort wWidth;       /*OSD宽度*/
			public ushort wHeight;      /*OSD高度*/
			public uint dwCharCnt;     /*字符的个数*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxOsdcharNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wOSDChar;       /*OSD字符内容*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*******************************获取串口信息*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSerialControl
		{ 
			public uint dwSize ;
			public byte bySerialNum;        // 串口个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] bySerial;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************屏幕控制*******************************/
		//屏幕输入源控制
		public enum InputInterfaceType
		{
			InterfaceVga = 0,
			InterfaceSvideo, // 2046NL不支持，2046NH支持
			InterfaceYpbpr,
			InterfaceDvi ,
			InterfaceBnc , 
			InterfaceDviLoop,//(环通) 2046NH不支持，2046NL支持
			InterfaceBncLoop, //(环通) 2046NH不支持，2046NL.支持
			InterfaceHdmi,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputInterfaceCtrl
		{
			public byte byInputSourceType;	//见INPUT_INTERFACE_TYPE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		//显示单元颜色控制
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDisplayColorCtrl
		{
			public byte byColorType;		//1-亮度 2-对比度 3-饱和度 4-清晰度
			public char	byScale;			//-1 、0、+1三个值
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//显示单元位置控制
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDisplayPositionCtrl
		{
			public byte byPositionType;	//1-水平位置 2-垂直位置，
			public char byScale;			//-1 、0、+1三个值
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrScreenControlParam
		{
			[FieldOffset(0)]
			public NetDvrInputInterfaceCtrl struInputCtrl;
			[FieldOffset(0)]
			public NetDvrDisplayColorCtrl struDisplayCtrl;
			[FieldOffset(0)]
			public NetDvrDisplayPositionCtrl struPositionCtrl;
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenControl
		{ 	
			public uint dwSize;			 
			public uint dwCommand ;      /* 控制方法 1-开 2-关 3-屏幕输入源选择 4-显示单元颜色控制 5-显示单元位置控制*/
			public byte byProtocol;      //串口协议类型,1:LCD-S1,2:LCD-S2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrScreenControlParam	struControlParam;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	
		}

		/*******************************屏幕控制V41*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenControlV41
		{ 	
			public uint dwSize;
			public byte bySerialNo;		//串口号
			public byte byBeginAddress;	//左上角屏幕号，从1开始
			public byte byEndAddress;	//右下角屏幕号，从1开始
			public byte byProtocol;      	   // 串口协议类型  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 ， 4-LCD-DLP， 5-LCD-S3 , 6-LCD-H1 
			public uint dwCommand ;      /* 控制方法 1-开 2-关 3-屏幕输入源选择 4-显示单元颜色控制 5-显示单元位置控制*/
			public NetDvrScreenControlParam	struControlParam;
			public byte byWallNo;		// 电视墙号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}

		/*******************************预案管理*******************************/
		public const int MaxPlanActionNum = 32; 	//预案动作个数
		public const int DaysAWeek = 7;	//一周7天
		public const int MaxPlanCount = 16;	//预案个数

		public enum NetDvrPlanOperateType
		{
			NetDvrSwitchLayout = 1, 		// 布局切换 默认
			NetDvrScreenPowerOff,  		// 关闭大屏幕显示
			NetDvrScreenPowerOn,   		// 打开大屏幕显示
		}

		/*预案项信息*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlanInfo
		{
			public byte byValid;      	// 该项是否有效
			public byte byType;       	// 见定义NET_DVR_PLAN_OPERATE_TYPE
			public ushort wLayoutNo;  	// 布局号
			public byte byScreenStyle;    //屏幕型号，开关机所用，1是低亮，2是高亮
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwDelayTime;  	// 一个项的运行时间, 单位秒
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCycleTime
		{
			public byte byValid; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrTimeEx struTime;
		}

		/*预案管理*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlanCfg
		{
			public uint dwSize;
			public byte byValid;      	// 该预案是否有效
			public byte byWorkMode;  	// 预案工作模式 1表示手动，2自动，3预案循环
			public byte byWallNo;		//电视墙号，从1开始
			public byte byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPlanName; //预案名称
			public NetDvrTimeEx struTime; // 工作模式为自动时使用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DaysAWeek, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCycleTime[] struTimeCycle; /*循环时间，周期为一个星期，年、月、日三个参数不使用。如：struTimeCycle[0]中的byValid的值是1，表示星期天执行该预案。星期取值区间为[0,6]，其中0代表星期天，1代表星期一，以此类推*/
			public uint dwWorkCount;  	// 预案内容执行次数，0为一直循环播放，其他值表示次数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPlanActionNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPlanInfo[] strPlanEntry;  // 预案执行的内容
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************获取设备状态*******************************/
		/*预案列表*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlanList
		{
			public uint dwSize;
			public uint dwPlanNums;			//设备输入信号源数量
			public IntPtr pBuffer;			//指向dwInputSignalNums个NET_DVR_PLAN_CFG结构大小的缓冲区
			public byte byWallNo;			//墙号，从1开始
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwBufLen;			//所分配缓冲区长度，输入参数（大于等于dwInputSignalNums个NET_DVR_PLAN_CFG结构大小）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************预案控制*******************************/
		//该结构体可作为通用控制结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrControlParam
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDeviceID; //被控设备的设备ID
			public ushort wChan;				 //被控通道
			public byte byIndex;			 //控制索引，根据命令确定具体表示什么索引
			public byte byRes1;
			public uint dwControlParam;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************获取设备状态*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeviceRunStatus
		{
			public uint dwSize;
			public uint dwMemoryTotal;		//内存总量	单位Kbyte
			public uint dwMemoryUsage;		//内存使用量 单位Kbyte
			public byte byCPUUsage;			//CPU使用率 0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//91系列HD-SDI高清DVR 相机信息
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAccessCameraInfo
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCameraInfo;		// 前端相机信息
			public byte  byInterfaceType;		// 前端接入接口类型，1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAudioInputParam
		{
			public byte byAudioInputType;  //音频输入类型，0-mic in，1-line in
			public byte byVolume; //volume,[0-100]
			public byte byEnableNoiseFilter; //是否开启声音过滤-关，-开
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraDehazeCfg
		{
			public uint dwSize;
			public byte byDehazeMode; //0-不启用，1-自动模式，2-开
			public byte byLevel; //等级，0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputSignalList
		{
			public uint dwSize;
			public uint dwInputSignalNums;	//设备输入信号源数量
			public IntPtr pBuffer;			//指向dwInputSignalNums个NET_DVR_INPUTSTREAMCFG结构大小的缓冲区
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwBufLen;			//所分配缓冲区长度，输入参数（大于等于dwInputSignalNums个NET_DVR_INPUTSTREAMCFG结构大小）
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//安全拔盘状态
		public const int PullDiskSuccess = 1;     // 安全拔盘成功
		public const int PullDiskFail = 2;        // 安全拔盘失败
		public const int PullDiskProcessing = 3;  // 正在停止阵列
		public const int PullDiskNoArray = 4;	// 阵列不存在 
		public const int PullDiskNotSupport = 5; // 不支持安全拔盘

		//扫描阵列状态
		public const int ScanRaidSuc = 1; 	// 扫描阵列成功
		public const int ScanRaidFail = 2; 	// 扫描阵列失败
		public const int ScanRaidProcessing = 3;	// 正在扫描阵列
		public const int ScanRaidNotSupport = 4; // 不支持阵列扫描

		//设置前端相机类型状态
		public const int SetCameraTypeSuccess = 1;  // 成功
		public const int SetCameraTypeFail = 2;  // 失败
		public const int SetCameraTypeProcessing	= 3;   // 正在处理

		//9000 2.2
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordTimeSpanInquiry
		{
			public uint dwSize;    //结构体大小
			public byte byType;    //0 正常音视频录像, 1图片通道录像, 2ANR通道录像, 3抽帧通道录像
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordTimeSpan
		{
			public uint dwSize;        //结构体大小
			public NetDvrTime strBeginTime;  //开始时间
			public NetDvrTime strEndTime;    //结束时间
			public byte byType;        //0 正常音视频录像, 1图片通道录像, 2ANR通道录像, 3抽帧通道录像
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDrawframeDiskQuotaCfg
		{
			public uint dwSize;					//结构体大小
			public byte byPicQuota;				//图片百分比	 [0%,  30%]
			public byte byRecordQuota;				//普通录像百分比 [20%, 40%]
			public byte byDrawFrameRecordQuota;	//抽帧录像百分比 [30%, 80%]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;					//保留字节
		}

		//端口映射配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNatPort
		{
			public ushort wEnable;
			public ushort wExtPort;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//端口映射配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNatCfg
		{
			public uint dwSize;
			public ushort wEnableUpnp;
			public ushort wEnableNat;
			public NetDvrIpaddr struIpAddr;//夏时制停止时间
			public NetDvrNatPort struHttpPort;//夏时制停止时间
			public NetDvrNatPort struCmdPort;//夏时制停止时间
			public NetDvrNatPort struRtspPort;//夏时制停止时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byFriendName;
			public byte byNatType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrNatPort struHttpsPort;//夏时制停止时间
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//Upnp端口映射状态结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUpnpPortState
		{
			public uint dwEnabled;//该端口是否被使能映射
			public ushort wInternalPort;//映射前的端口
			public ushort wExternalPort;//映射后的端口
			public uint dwStatus;//端口映射状态：0- 未生效；1- 未生效：映射源端口与目的端口需一致；2- 未生效：映射端口号已被使用；3- 生效
			public NetDvrIpaddr struNatExternalIp;//映射后的外部地址
			public NetDvrIpaddr struNatInternalIp;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		//Upnp端口映射状态结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUpnpNatState
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUpnpPortState[] strUpnpPort;//端口映射状态:：数组0- web server端口，数组1- 管理端口，数组2- rtsp端
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlaycond
		{
			public uint dwChannel;
			public NetDvrTime struStartTime;
			public NetDvrTime struStopTime;
			public byte byDrawFrame;  //0:不抽帧，1：抽帧
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //保留
		}

		//录像回放结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVodPara
		{
			public uint dwSize; //结构体大小
			public NetDvrStreamInfo struIDInfo; //流ID信息
			public NetDvrTime struBeginTime;//回放开始时间
			public NetDvrTime struEndTime;//回放结束时间
			public IntPtr hWnd;//回放窗口
			public byte byDrawFrame;//是否抽帧：0- 不抽帧，1- 抽帧
			public byte byVolumeType;//0-普通录像卷，1-存档卷，适用于CVR设备，普通卷用于通道录像，存档卷用于备份录像
			public byte byVolumeNum;//存档卷号 
			public byte byRes1;//保留
			public uint dwFileIndex;//存档卷上的录像文件索引，搜索存档卷录像时返回的值
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmfindinfo
		{
			public byte byTransactionType;       //交易类型 0-全部，1-查询， 2-取款， 3-存款， 4-修改密码，5-转账， 6-无卡查询 7-无卡存款， 8-吞钞 9-吞卡 10-自定义
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //保留
			public uint dwTransationAmount ;     //交易金额 ;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrSpecialFindinfoUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byLenth ;
			[FieldOffset(0)]
			public NetDvrAtmfindinfo struATMFindInfo;	       //ATM查询
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFilecondV40
		{
			public int lChannel;
			public uint dwFileType;
			public uint dwIsLocked;
			public uint dwUseCardNo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CardnumLenOut, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNumber;
			public NetDvrTime struStartTime;
			public NetDvrTime struStopTime;
			public byte byDrawFrame; //0:不抽帧，1：抽帧
			public byte byFindType; //0:查询普通卷，1：查询存档卷
			public byte byQuickSearch; //0:普通查询，1：快速（日历）查询
			public byte bySpecialFindInfoType ;    //专有查询条件类型 0-无效， 1-带ATM查询条件  
			public uint dwVolumeNum;  //存档卷号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = GuidLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byWorkingDeviceGUID;    //工作机GUID，通过获取N+1得到
			public NetDvrSpecialFindinfoUnion uSpecialFindInfo ;   //专有查询条件
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //保留
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAesKeyInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sAESKey;  /*码流加密密钥*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  /*保留字节*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPoeCfg
		{
			public NetDvrIpaddr struIP;     //IP地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //保留
		}

		public const int MaxProPath = 256; //最大协议路径长度

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCustomProtocal
		{
			public uint dwSize;              //结构体大小
			public uint dwEnabled;           //是否启用该协议0 不启用 1 启用
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = DescLen)]
			public string sProtocalName;   //自定义协议名称, 16位
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;          //保留,用于协议名称扩展
			public uint dwEnableSubStream;   //子码流是否启用0 不启用 1 启用	
			public byte byMainProType;        //主码流协议类型 1 RTSP
			public byte byMainTransType;		//主码流传输类型 0：Auto 1：udp 2：rtp over rtsp
			public ushort wMainPort;           //主码流端口	
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxProPath)]
			public string sMainPath;  //主码流路径	
			public byte bySubProType;         //子码流协议类型 1 RTSP
			public byte bySubTransType;		//子码流传输类型 0：Auto 1：udp 2：rtp over rtsp
			public ushort wSubPort;   //子码流端口
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxProPath)]
			public string sSubPath;   //子码流路径 	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;          //保留
		}
	 
		//预览V40接口
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPreviewinfo
		{
			public int lChannel;//通道号
			public uint dwStreamType;	// 码流类型，0-主码流，1-子码流，2-码流3，3-码流4 等以此类推
			public uint dwLinkMode;// 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-RTP/RTSP,5-RSTP/HTTP 
			public IntPtr hPlayWnd;//播放窗口的句柄,为NULL表示不播放图象
			public bool bBlocked;  //0-非阻塞取流, 1-阻塞取流, 如果阻塞SDK内部connect失败将会有5s的超时才能够返回,不适合于轮询取流操作.
			public bool bPassbackRecord; //0-不启用录像回传,1启用录像回传
			public byte byPreviewMode;//预览模式，0-正常预览，1-延迟预览
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = StreamIdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byStreamID;//流ID，lChannel为0xffffffff时启用此参数
			public byte byProtoType; //应用层取流协议，0-私有协议，1-RTSP协议
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 222, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		///抓拍机
		///
		public const int MaxOverlapItemNum = 50;       //最大字符叠加种数
		public const int NetItsGetOverlapCfg = 5072;//获取字符叠加参数配置（相机或ITS终端）
		public const int NetItsSetOverlapCfg = 5073;//设置字符叠加参数配置（相机或ITS终端）

		//字符叠加配置条件参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapcfgCond
		{
			public uint dwSize;
			public uint dwChannel;//通道号 
			public uint dwConfigMode;//配置模式：0- 终端，1- 前端(直连前端或终端接前端)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		//单条字符叠加信息结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapSingleItemParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留
			public byte byItemType;//类型
			public byte byChangeLineNum;//叠加项后的换行数，取值范围：[0,10]，默认：0 
			public byte bySpaceNum;//叠加项后的空格数，取值范围：[0-255]，默认：0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		//字符串参数配置结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapItemParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxOverlapItemNum, ArraySubType = UnmanagedType.Struct)]
			public NetItsOverlapSingleItemParam[] struSingleItem;//字符串内容信息
			public uint dwLinePercent;
			public uint dwItemsStlye;
			public ushort wStartPosTop;
			public ushort wStartPosLeft;
			public ushort wCharStyle;
			public ushort wCharSize;
			public ushort wCharInterval;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//保留
			public uint dwForeClorRGB;//前景色的RGB值，bit0~bit7: B，bit8~bit15: G，bit16~bit23: R，默认：x00FFFFFF-白
			public uint dwBackClorRGB;//背景色的RGB值，只对图片外叠加有效，bit0~bit7: B，bit8~bit15: G，bit16~bit23: R，默认：x00000000-黑 
			public byte byColorAdapt;//颜色是否自适应：0-否，1-是
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留
		}

		//字符叠加内容信息结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapInfoParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] bySite;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRoadNum;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byInstrumentNum;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDirection;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDirectionDesc;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byLaneDes;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//这里保留音频的压缩参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitoringSite1;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitoringSite2;//这里保留音频的压缩参数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//这里保留音频的压缩参数 
		}

		//字符叠加配置条件参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapCfg
		{
			public uint dwSize;
			public byte byEnable;//是否启用：0- 不启用，1- 启用
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//这里保留音频的压缩参数
			public NetItsOverlapItemParam struOverLapItem;//字符串参数
			public NetItsOverlapInfoParam struOverLapInfo;//字符串内容信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//这里保留音频的压缩参数 
		}

		//报警布防参数结构体
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSetupalarmParam
		{
			public uint dwSize;
			public byte byLevel;//布防优先级：0- 一等级（高），1- 二等级（中），2- 三等级（低，保留）
			public byte byAlarmInfoType;//上传报警信息类型（智能交通摄像机支持）：0- 老报警信息（NetDvrPlateResult），1- 新报警信息(NET_ITS_PLATE_RESULT) 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//这里保留音频的压缩参数 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsGateVehicle
		{
			public uint dwSize;
			public uint dwMatchNo;
			public byte byGroupNum;
			public byte byPicNo;
			public byte bySecondCam;

			public byte byRes;
			public ushort wLaneid;
			public byte byCamLaneId;
			public byte byRes1;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] byAlarmReason;

			public ushort wBackList;
			public ushort wSpeedLimit;
			public uint dwChanIndex;


			public NetDvrPlateInfo struPlateInfo;

			public NetDvrVehicleInfo struVehicleInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
			public byte[] byMonitoringSiteID;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
			public byte[] byDeviceID;


			public byte byDir;
			public byte byDetectType;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
			public byte[] byRes2;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
			public byte[] byCardNo;

			public uint dwPicNum;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
			public NetItsPictureInfo[] struPicInfo;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] bySwipeTime;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 224)]
			public byte[] byRes3;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsPictureInfo
		{
			public uint dwDataLen;
			public byte byType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
			public byte[] byRes1;
			public uint dwRedLightTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
			public byte[] byAbsTime;
			public NetVcaRect struPlateRect;
			public NetVcaRect struPlateRecgRect;
			public IntPtr pBuffer;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
			public byte[] byRes2;
		}
		/********************************接口参数结构(end)*********************************/


		/********************************SDK接口函数声明*********************************/

		/*********************************************************
		Function:	NET_DVR_Init
		Desc:		初始化SDK，调用其他SDK函数的前提。
		Input:	
		Output:	
		Return:	TRUE表示成功，FALSE表示失败。
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Init();

		/*********************************************************
		Function:	NET_DVR_Cleanup
		Desc:		释放SDK资源，在结束之前最后调用
		Input:	
		Output:	
		Return:	TRUE表示成功，FALSE表示失败
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Cleanup();



		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

		/*********************************************************
		Function:	EXCEPYIONCALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Excepyioncallback(uint dwType, int lUserId, int lHandle, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, Excepyioncallback fExceptionCallBack, IntPtr pUser);


		/*********************************************************
		Function:	MESSCALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messcallback(int lCommand, string sDvrip, string pBuf, uint dwBufLen);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack(Messcallback fMessCallBack);

		/*********************************************************
		Function:	MESSCALLBACKEX
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messcallbackex(int iCommand, int iUserId, string pBuf, uint dwBufLen);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack_EX(Messcallbackex fMessCallBackEx);

		/*********************************************************
		Function:	MESSCALLBACKNEW
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messcallbacknew(int lCommand, string sDvrip, string pBuf, uint dwBufLen, ushort dwLinkDvrPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack_NEW(Messcallbacknew fMessCallBackNew);

		/*********************************************************
		Function:	MESSAGECALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messagecallback(int lCommand, IntPtr sDvrip, IntPtr pBuf, uint dwBufLen, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessageCallBack(Messagecallback fMessageCallBack, uint dwUser);


		/*********************************************************
		Function:	MSGCallBack
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void MsgCallBack(int lCommand, ref NetDvrAlarmer pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessageCallBack_V30(MsgCallBack fMessageCallBack, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetLocalIP(byte[] strIp, ref uint pValidNum, ref bool pEnableBind);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetValidIP(uint dwIpIndex, bool bEnableBind);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern uint NET_DVR_GetSDKVersion();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern uint NET_DVR_GetSDKBuildVersion();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_IsSupport();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartListen(string sLocalIp, ushort wLocalPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopListen();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartListen_V30(string sLocalIp, ushort wLocalPort, MsgCallBack dataCallback, IntPtr pUserData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopListen_V30(int lListenHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_Login(string sDvrip, ushort wDvrPort, string sUserName, string sPassword, ref NetDvrDeviceinfo lpDeviceInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Logout(int iUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern uint NET_DVR_GetLastError();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern string NET_DVR_GetErrorMsg(ref int pErrorNo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIp, ushort wServerPort, string sDvrName, ushort wDvrNameLen, string sDvrSerialNumber, ushort wDvrSerialLen, IntPtr pGetIp);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIp, ushort wServerPort, byte[] sDvrName, ushort wDvrNameLen, byte[] sDvrSerialNumber, ushort wDvrSerialLen, byte[] sGetIp, ref uint dwPort);
		//预览相关接口
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay(int iUserId, ref NetDvrClientinfo lpClientInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_SDK_RealPlay(int iUserLogId, ref NetDvrClientinfo lpDvrClientInfo);
		/*********************************************************
		Function:	REALDATACALLBACK
		Desc:		预览回调
		Input:	lRealHandle 当前的预览句柄 
				dwDataType 数据类型
				pBuffer 存放数据的缓冲区指针 
				dwBufSize 缓冲区大小 
				pUser 用户数据 
		Output:	
		Return:	void
		**********************************************************/
		public delegate void Realdatacallback(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr pUser);
		[DllImport(@"..\bin\HCNetSDK.dll")]

		/*********************************************************
		Function:	NET_DVR_RealPlay_V30
		Desc:		实时预览。
		Input:	lUserId [in] NET_DVR_Login()或NET_DVR_Login_V30()的返回值 
				lpClientInfo [in] 预览参数 
				cbRealDataCallBack [in] 码流数据回调函数 
				pUser [in] 用户数据 
				bBlocked [in] 请求码流过程是否阻塞：0－否；1－是 
		Output:	
		Return:	1表示失败，其他值作为NET_DVR_StopRealPlay等函数的句柄参数
		**********************************************************/
		public static extern int NET_DVR_RealPlay_V30(int iUserId, ref NetDvrClientinfo lpClientInfo, Realdatacallback fRealDataCallBackV30, IntPtr pUser, uint bBlocked);

		/*********************************************************
		Function:	NET_DVR_RealPlay_V40
		Desc:		实时预览扩展接口。
		Input:	lUserId [in] NET_DVR_Login()或NET_DVR_Login_V30()的返回值 
				lpPreviewInfo [in] 预览参数 
				fRealDataCallBack_V30 [in] 码流数据回调函数 
				pUser [in] 用户数据 
		Output:	
		Return:	1表示失败，其他值作为NET_DVR_StopRealPlay等函数的句柄参数
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay_V40(int iUserId, ref NetDvrPreviewinfo lpPreviewInfo, Realdatacallback fRealDataCallBackV30, IntPtr pUser);

	   // [DllImport(@"..\bin\HCNetSDK.dll")]
	   // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
		/*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		停止预览。
		Input:	lRealHandle [in] 预览句柄，NET_DVR_RealPlay或者NET_DVR_RealPlay_V30的返回值 
		Output:	
		Return:	
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopRealPlay(int iRealHandle);

		/*********************************************************
		Function:	DRAWFUN
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Drawfun(int lRealHandle, IntPtr hDc, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, Drawfun fDrawFun, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetPlayerBufNumber(int lRealHandle, uint dwBufNum);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ThrowBFrame(int lRealHandle, uint dwNum);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetAudioMode(uint dwMode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_OpenSound(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseSound();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_OpenSoundShare(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseSoundShare(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Volume(int lRealHandle, ushort wVolume);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveRealData(int lRealHandle, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopSaveRealData(int lRealHandle);

		/*********************************************************
		Function:	REALDATACALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Setrealdatacallback(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, Setrealdatacallback fRealDataCallBack, uint dwUser);

		/*********************************************************
		Function:	STDDATACALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Stddatacallback(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, Stddatacallback fStdDataCallBack, uint dwUser);


		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CapturePicture(int lRealHandle, string sPicFileName);

		//动态生成I帧
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MakeKeyFrame(int lUserId, int lChannel);//主码流

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MakeKeyFrameSub(int lUserId, int lChannel);//子码流

		//云台控制相关接口
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZCtrl(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZCtrl_Other(int lUserId, int lChannel);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControl(int lRealHandle, uint dwPtzCommand, uint dwStop);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControl_Other(int lUserId, int lChannel, uint dwPtzCommand, uint dwStop);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_TransPTZ(int lRealHandle, string pPtzCodeBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_TransPTZ_Other(int lUserId, int lChannel, string pPtzCodeBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPtzPresetCmd, uint dwPresetIndex);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZPreset_Other(int lUserId, int lChannel, uint dwPtzPresetCmd, uint dwPresetIndex);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPtzCodeBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPtzCommand, uint dwStop);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPtzPresetCmd, uint dwPresetIndex);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPtzCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZCruise_Other(int lUserId, int lChannel, uint dwPtzCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPtzCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPtzTrackCmd);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZTrack_Other(int lUserId, int lChannel, uint dwPtzTrackCmd);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPtzTrackCmd);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPtzCommand, uint dwStop, uint dwSpeed);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserId, int lChannel, int dwPtzCommand, int dwStop, int dwSpeed);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPtzCommand, uint dwStop, uint dwSpeed);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZCruise(int lUserId, int lChannel, int lCruiseRoute, ref NetDvrCruiseRet lpCruiseRet);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPtzTrackCmd, uint dwTrackIndex);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZMltTrack_Other(int lUserId, int lChannel, uint dwPtzTrackCmd, uint dwTrackIndex);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPtzTrackCmd, uint dwTrackIndex);

		//文件查找与回放
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile(int lUserId, int lChannel, uint dwFileType, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NetDvrFindData lpFindData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindClose(int lFindHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, ref NetDvrFinddataV30 lpFindData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile_V40(int lFindHandle, ref NetDvrFinddataV40 lpFindData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile_V30(int lUserId, ref NetDvrFilecond pFindCond);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile_V40(int lUserId, ref NetDvrFilecondV40 pFindCond);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindClose_V30(int lFindHandle);

		//2007-04-16增加查询结果带卡号的文件查找
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, ref NetDvrFinddataCard lpFindData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFile_Card(int lUserId, int lChannel, uint dwFileType, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_LockFileByName(int lUserId, string sLockFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_UnlockFileByName(int lUserId, string sUnlockFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackByName(int lUserId, string sPlayBackFileName, IntPtr hWnd);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackByTime(int lUserId, int lChannel, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime, IntPtr hWnd);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_PlayBackByTime_V40(int lUserId, ref NetDvrVodPara pVodPara);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint lpOutValue);
		
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint lpOutValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);

		/*********************************************************
		Function:	PLAYDATACALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Playdatacallback(int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, Playdatacallback fPlayDataCallBack, uint dwUser);


		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NetDvrTime lpOsdTime);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetFileByName(int lUserId, string sDvrFileName, string sSavedFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetFileByTime(int lUserId, int lChannel, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime, string sSavedFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetFileByTime_V40(int lUserId, string sSavedFileName, ref NetDvrPlaycond pDownloadCond);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopGetFile(int lFileHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetDownloadPos(int lFileHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);

		//升级
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_Upgrade(int lUserId, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);

		//远程格式化硬盘
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FormatDisk(int lUserId, int lDiskNumber);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);

		//报警
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_SetupAlarmChan(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_SetupAlarmChan_V30(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_SetupAlarmChan_V41(int lUserId, ref NetDvrSetupalarmParam lpSetupParam);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);

		//语音对讲
		/*********************************************************
		Function:	VOICEDATACALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Voicedatacallback(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom(int lUserId, Voicedatacallback fVoiceDataCallBack, uint dwUser);

		/*********************************************************
		Function:	VOICEDATACALLBACKV30
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Voicedatacallbackv30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_V30(int lUserId, uint dwVoiceChan, bool bNeedCbNoEncData, Voicedatacallbackv30 fVoiceDataCallBack, IntPtr pUser);


		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);

		//语音转发
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_MR(int lUserId, Voicedatacallback fVoiceDataCallBack, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserId, uint dwVoiceChan, Voicedatacallbackv30 fVoiceDataCallBack, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);

		//语音广播
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStart();

		/*********************************************************
		Function:	VOICEAUDIOSTART
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Voiceaudiostart(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStart_V30(Voiceaudiostart fVoiceAudioStart, IntPtr pUser);


		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStop();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_AddDVR(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_AddDVR_V30(int lUserId, uint dwVoiceChan);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DelDVR(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);


		//透明通道设置
		/*********************************************************
		Function:	SERIALDATACALLBACK
		Desc:		(回调函数)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Serialdatacallback(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialStart(int lUserId, int lSerialPort, Serialdatacallback fSerialDataCallBack, uint dwUser);

		//485作为透明通道时，需要指明通道号，因为不同通道号485的设置可以不同(比如波特率)
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialStop(int lSerialHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SendTo232Port(int lUserId, string pSendBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SendToSerialPort(int lUserId, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);

		//解码 nBitrate = 16000
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_InitG722Decoder(int nBitrate);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);

		//编码
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_InitG722Encoder();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);

		//远程控制本地显示
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClickKey(int lUserId, int lKeyIndex);

		//远程控制设备端手动录像
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDVRRecord(int lUserId, int lChannel, int lRecordType);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDVRRecord(int lUserId, int lChannel);

		//解码卡
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ReleaseDevice_Card();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ReleaseDDraw_Card();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay_Card(int lUserId, ref NetDvrCardinfo lpCardInfo, int lChannelNum);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, ref NetDvrDisplayPara lpDisplayPara);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RefreshSurface_Card();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClearSurface_Card();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RestoreSurface_Card();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetCardLastError_Card();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);

		//获取解码卡序列号此接口无效，改用GetBoardDetail接口获得(2005-12-08支持)
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);

		//日志
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog(int lUserId, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog(int lLogHandle, ref NetDvrLog lpLogData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindLogClose(int lLogHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog_V30(int lUserId, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime, bool bOnlySmart);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, ref NetDvrLogV30 lpLogData);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);

		//截止2004年8月5日,共113个接口
		//ATM DVR
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFileByCard(int lUserId, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);


		//2005-09-15
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CaptureJPEGPicture(int lUserId, int lChannel, ref NetDvrJpegpara lpJpegPara, string sPicFileName);

		//JPEG抓图到内存
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserId, int lChannel, ref NetDvrJpegpara lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);

		//2006-02-16
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);

		//2006-08-28 704-640 缩放配置
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetScaleCFG(int lUserId, uint dwScale);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetScaleCFG(int lUserId, ref uint lpOutScale);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetScaleCFG_V30(int lUserId, ref NetDvrScalecfg pScalecfg);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetScaleCFG_V30(int lUserId, ref NetDvrScalecfg pScalecfg);

		//2006-08-28 ATM机端口设置
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetATMPortCFG(int lUserId, ushort wAtmPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetATMPortCFG(int lUserId, ref ushort lpOutAtmPort);

		//2006-11-10 支持显卡辅助输出
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_InitDDrawDevice();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ReleaseDDrawDevice();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetDDrawDeviceTotalNums();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NetDvrPointFrame pStruPointFrame);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserId, int lChannel, ref NetDvrPointFrame pStruPointFrame);

		//解码设备DS-6001D/DS-6001F
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDecode(int lUserId, int lChannel, ref NetDvrDecoderinfo lpDecoderinfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDecode(int lUserId, int lChannel);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecoderState(int lUserId, int lChannel, ref NetDvrDecoderstate lpDecoderState);

		//2005-08-01
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDecInfo(int lUserId, int lChannel, ref NetDvrDeccfg lpDecoderinfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecInfo(int lUserId, int lChannel, ref NetDvrDeccfg lpDecoderinfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDecTransPort(int lUserId, ref NetDvrPortcfg lpTransPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecTransPort(int lUserId, ref NetDvrPortcfg lpTransPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecPlayBackCtrl(int lUserId, int lChannel, uint dwControlCode, uint dwInValue, ref uint lpOutValue, ref NetDvrPlayremotefile lpRemoteFileInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDecSpecialCon(int lUserId, int lChannel, ref NetDvrDecchaninfo lpDecChanInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDecSpecialCon(int lUserId, int lChannel, ref NetDvrDecchaninfo lpDecChanInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecCtrlDec(int lUserId, int lChannel, uint dwControlCode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecCtrlScreen(int lUserId, int lChannel, uint dwControl);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDecCurLinkStatus(int lUserId, int lChannel, ref NetDvrDecstatus lpDecStatus);

		//多路解码器
		//2007-11-30 V211支持以下接口 //11
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStartDynamic(int lUserId, uint dwDecChanNum, ref NetDvrMatrixDynamicDec lpDynamicInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStopDynamic(int lUserId, uint dwDecChanNum);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserId, uint dwDecChanNum, ref NetDvrMatrixDecChanInfo lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserId, uint dwDecChanNum, ref NetDvrMatrixLoopDecinfo lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserId, uint dwDecChanNum, ref NetDvrMatrixLoopDecinfo lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserId, uint dwDecChanNum, uint dwEnable);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserId, uint dwDecChanNum, ref uint lpdwEnable);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserId, ref uint lpdwEnable);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserId, uint dwDecChanNum, uint dwEnable);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserId, uint dwDecChanNum, ref uint lpdwEnable);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserId, uint dwDecChanNum, ref NetDvrMatrixDecChanStatus lpInter);

		//2007-12-22 增加支持接口 //18
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetTranInfo(int lUserId, ref NetDvrMatrixTranChanConfig lpTranInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetTranInfo(int lUserId, ref NetDvrMatrixTranChanConfig lpTranInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserId, uint dwDecChanNum, ref NetDvrMatrixDecRemotePlay lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserId, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint lpOutValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserId, uint dwDecChanNum, ref NetDvrMatrixDecRemotePlayStatus lpOuter);

		//2009-4-13 新增
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStartDynamic_V30(int lUserId, uint dwDecChanNum, ref NetDvrPuStreamCfg lpDynamicInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserId, uint dwDecChanNum, ref NetDvrMatrixLoopDecinfoV30 lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserId, uint dwDecChanNum, ref NetDvrMatrixLoopDecinfoV30 lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserId, uint dwDecChanNum, ref NetDvrMatrixDecChanInfoV30 lpInter);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetTranInfo_V30(int lUserId, ref NetDvrMatrixTranChanConfigV30 lpTranInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetTranInfo_V30(int lUserId, ref NetDvrMatrixTranChanConfigV30 lpTranInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDisplayCfg(int lUserId, uint dwDispChanNum, ref NetDvrVgaDispChanCfg lpDisplayCfg);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetDisplayCfg(int lUserId, uint dwDispChanNum, ref NetDvrVgaDispChanCfg lpDisplayCfg);


		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_MatrixStartPassiveDecode(int lUserId, uint dwDecChanNum, ref NetDvrMatrixPassivemode lpPassiveMode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSendData(int lPassiveHandle, IntPtr pSendBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_UploadLogo(int lUserId, uint dwDispChanNum, ref NetDvrDispLogocfg lpDispLogoCfg, IntPtr sLogoBuffer);

		public const int NetDvrShowlogo = 1;/*显示LOGO*/
		public const int NetDvrHidelogo = 2;/*隐藏LOGO*/

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_LogoSwitch(int lUserId, uint dwDecChan, uint dwLogoSwitch);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserId, ref NetDvrDecoderWorkStatus lpDecoderCfg);

		/*显示通道命令码定义*/
		//上海世博 定制
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RigisterPlayBackDrawFun(int lRealHandle, Drawfun fDrawFun, uint dwUser);


		public const int DispCmdEnlargeWindow = 1;	/*显示通道放大某个窗口*/
		public const int DispCmdRenewWindow = 2;	/*显示通道窗口还原*/

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixDiaplayControl(int lUserId, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);

		//end
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);

		//恢复默认值
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RestoreConfig(int lUserId);

		//保存参数
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveConfig(int lUserId);

		//重启
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RebootDVR(int lUserId);

		//关闭DVR
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ShutDownDVR(int lUserId);

		//获取设备支持的IPC协议表
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetIPCProtoList(int lUserId, ref NetDvrIpcProtoList lpProtoList);

		//参数配置 begin
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRConfig(int lUserId, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRConfig(int lUserId, uint dwCommand, int lChannel, IntPtr lpInBuffer, uint dwInBufferSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserId, IntPtr pWorkState);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDVRWorkState(int lUserId, ref NetDvrWorkstate lpWorkState);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVideoEffect(int lUserId, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetVideoEffect(int lUserId, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientGetframeformat(int lUserId, ref NetDvrFrameformat lpFrameFormat);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientSetframeformat(int lUserId, ref NetDvrFrameformat lpFrameFormat);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetAtmProtocol(int lUserId, ref NetDvrAtmProtocol lpAtmProtocol);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetAlarmOut_V30(int lUserId, IntPtr lpAlarmOutState);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetAlarmOut(int lUserId, ref NetDvrAlarmoutstatus lpAlarmOutState);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetAlarmOut(int lUserId, int lAlarmOutPort, int lAlarmOutStatic);

		//获取UPNP端口映射状态
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetUpnpNatState(int lUserId, ref NetDvrUpnpNatState lpState);

		//视频参数调节
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

		//配置文件
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetConfigFile(int lUserId, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetConfigFile(int lUserId, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetConfigFile_V30(int lUserId, string sOutBuffer, uint dwOutSize, ref uint pReturnSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetConfigFile_EX(int lUserId, string sOutBuffer, uint dwOutSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetConfigFile_EX(int lUserId, string sInBuffer, uint dwInSize);

		//启用日志文件写入接口
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSDKState(ref NetDvrSdkstate pSdkState);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSDKAbility(ref NetDvrSdkabl pSdkAbl);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZProtocol(int lUserId, ref NetDvrPtzcfg pPtzcfg);

		//前面板锁定
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_LockPanel(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_UnLockPanel(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetRtspConfig(int lUserId, uint dwCommand, ref NetDvrRtspcfg lpInBuffer, uint dwInBufferSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRtspConfig(int lUserId, uint dwCommand, ref NetDvrRtspcfg lpOutBuffer, uint dwOutBufferSize);

		//视频综合平台
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetSceneCfg(int lUserId, uint dwSceneNum, ref NetDvrMatrixScenecfg lpSceneCfg);
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetSceneCfg(int lUserId, uint dwSceneNum, ref NetDvrMatrixScenecfg lpSceneCfg);

		//SDK_V222
		//智能设备类型
		public const int Ds6001HfB = 60;//行为分析：DS6001-HF/B
		public const int Ds6001HfP = 61;//车牌识别：DS6001-HF/P
		public const int Ds6002HfB = 62;//双机跟踪：DS6002-HF/B
		public const int Ds6101HfB = 63;//行为分析：DS6101-HF/B
		public const int Ids52Xx = 64;//智能分析仪IVMS
		public const int Ds9000Ivs = 65;//9000系列智能DVR
		public const int Ds8004AhlA = 66;//智能ATM, DS8004AHL-S/A
		public const int Ds6101HfP = 67;//车牌识别：DS6101-HF/P

		//能力获取命令
		public const int VcaDevAbility = 256;//设备智能分析的总能力
		public const int VcaChanAbility = 272;//行为分析能力
		public const int MatrixdecoderAbility = 512;//多路解码器显示、解码能力
		//获取/设置大接口参数配置命令
		//车牌识别（NET_VCA_PLATE_CFG）
		public const int NetDvrSetPlatecfg = 150;//设置车牌识别参数
		public const int NetDvrGetPlatecfg = 151;//获取车牌识别参数
		//行为对应（NetVcaRulecfg）
		public const int NetDvrSetRulecfg = 152;//设置行为分析规则
		public const int NetDvrGetRulecfg = 153;//获取行为分析规则

		//双摄像机标定参数（NET_DVR_LF_CFG）
		public const int NetDvrSetLfCfg = 160;//设置双摄像机的配置参数
		public const int NetDvrGetLfCfg = 161;//获取双摄像机的配置参数

		//智能分析仪取流配置结构
		public const int NetDvrSetIvmsStreamcfg = 162;//设置智能分析仪取流参数
		public const int NetDvrGetIvmsStreamcfg = 163;//获取智能分析仪取流参数

		//智能控制参数结构
		public const int NetDvrSetVcaCtrlcfg = 164;//设置智能控制参数
		public const int NetDvrGetVcaCtrlcfg = 165;//获取智能控制参数

		//屏蔽区域NET_VCA_MASK_REGION_LIST
		public const int NetDvrSetVcaMaskRegion = 166;//设置屏蔽区域参数
		public const int NetDvrGetVcaMaskRegion = 167;//获取屏蔽区域参数

		//ATM进入区域 NET_VCA_ENTER_REGION
		public const int NetDvrSetVcaEnterRegion = 168;//设置进入区域参数
		public const int NetDvrGetVcaEnterRegion = 169;//获取进入区域参数

		//标定线配置NET_VCA_LINE_SEGMENT_LIST
		public const int NetDvrSetVcaLineSegment = 170;//设置标定线
		public const int NetDvrGetVcaLineSegment = 171;//获取标定线

		// ivms屏蔽区域NET_IVMS_MASK_REGION_LIST
		public const int NetDvrSetIvmsMaskRegion = 172;//设置IVMS屏蔽区域参数
		public const int NetDvrGetIvmsMaskRegion = 173;//获取IVMS屏蔽区域参数
		// ivms进入检测区域NET_IVMS_ENTER_REGION
		public const int NetDvrSetIvmsEnterRegion = 174;//设置IVMS进入区域参数
		public const int NetDvrGetIvmsEnterRegion = 175;//获取IVMS进入区域参数

		public const int NetDvrSetIvmsBehaviorcfg = 176;//设置智能分析仪行为规则参数
		public const int NetDvrGetIvmsBehaviorcfg = 177;//获取智能分析仪行为规则参数

		// IVMS 回放检索
		public const int NetDvrIvmsSetSearchcfg = 178;//设置IVMS回放检索参数
		public const int NetDvrIvmsGetSearchcfg = 179;//获取IVMS回放检索参数        

		//结构参数宏定义 
		public const int VcaMaxPolygonPointNum = 10;//检测区域最多支持10个点的多边形
		public const int MaxRuleNum = 8;//最多规则条数
		public const int MaxTargetNum = 30;//最多目标个数
		public const int MaxCalibPt = 6;//最大标定点个数
		public const int MinCalibPt = 4;//最小标定点个数
		public const int MaxTimesegment2 = 2;//最大时间段数
		public const int MaxLicenseLen = 16;//车牌号最大长度
		public const int MaxPlateNum = 3;//车牌个数
		public const int MaxMaskRegionNum = 4;//最多四个屏蔽区域
		public const int MaxSegmentNum = 6;//摄像机标定最大样本线数目
		public const int MinSegmentNum = 3;//摄像机标定最小样本线数目        
		/*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE表示成功，FALSE表示失败。
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDeviceAbility(int lUserId, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);

		//参数关键字
		public enum IvsParamKey
		{
			ObjectDetectSensitive = 1,//目标检测灵敏度
			BackgroundUpdateRate = 2,//背景更新速度
			SceneChangeRatio = 3,//场景变化检测最小值
			SuppressLamp = 4,//是否抑制车头灯
			MinObjectSize = 5,//能检测出的最小目标大小
			ObjectGenerateRate = 6,//目标生成速度
			MissingObjectHold = 7,//目标消失后继续跟踪时间
			MaxMissingDistance = 8,//目标消失后继续跟踪距离
			ObjectMergeSpeed = 9,//多个目标交错时，目标的融合速度
			RepeatedMotionSuppress = 10,//重复运动抑制
			IlluminationChange = 11,//光影变化抑制开关
			TrackOutputMode = 12,//轨迹输出模式：0-输出目标的中心，1-输出目标的底部中心
			EnterChangeHold = 13,//检测区域变化阈值
			ResumeDefaultParam = 255,//恢复默认关键字参数
		}

		//设置/获取参数关键字
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetBehaviorParamKey(int lUserId, int lChannel, uint dwParameterKey, int nValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetBehaviorParamKey(int lUserId, int lChannel, uint dwParameterKey, ref int pValue);

		//获取/设置行为分析目标叠加接口
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetVCADrawMode(int lUserId, int lChannel, ref NetVcaDrawMode lpDrawMode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVCADrawMode(int lUserId, int lChannel, ref NetVcaDrawMode lpDrawMode);

		//标定参数配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfCalibrationParam
		{
			public byte byPointNum;//有效标定点个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCalibPt, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCbPoint[] struCBPoint;//标定点组
		}

		//LF双摄像机配置结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfCfg
		{
			public uint dwSize;//结构长度	
			public byte byEnable;//标定使能
			public byte byFollowChan;// 被控制的从通道
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrLfCalibrationParam struCalParam;//标定点组
		}

		//L/F手动控制结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfManualCtrlInfo
		{
			public NetVcaPoint struCtrlPoint;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//L/F目标跟踪结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfTrackTargetInfo
		{
			public uint dwTargetID;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfTrackMode
		{
			public uint dwSize;//结构长度
			public byte byTrackMode;//跟踪模式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，置0
			[StructLayout(LayoutKind.Explicit)]
			public struct UModeParam
			{
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
				[FieldOffset(0)]
				public uint[] dwULen;
				[FieldOffset(0)]
				public NetDvrLfManualCtrlInfo struManualCtrl;//手动跟踪结构
				[FieldOffset(0)]
				public NetDvrLfTrackTargetInfo struTargetTrack;//目标跟踪结构
			}
		}

		//双摄像机跟踪模式设置接口
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetLFTrackMode(int lUserId, int lChannel, ref NetDvrLfTrackMode lpTrackMode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetLFTrackMode(int lUserId, int lChannel, ref NetDvrLfTrackMode lpTrackMode);

		//识别场景
		public enum VcaRecognizeScene
		{
			VcaLowSpeedScene = 0,//低速通过场景（收费站、小区门口、停车场）
			VcaHighSpeedScene = 1,//高速通过场景（卡口、高速公路、移动稽查)
			VcaMobileCameraScene = 2,//移动摄像机应用） 
		}

		//识别结果标志
		public enum VcaRecognizeResult
		{
			VcaRecognizeFailure = 0,//识别失败
			VcaImageRecognizeSuccess,//图像识别成功
			VcaVideoRecognizeSuccessOfBestLicense,//视频识别更优结果
			VcaVideoRecognizeSuccessOfNewLicense,//视频识别到新的车牌
			VcaVideoRecognizeFinishOfCurLicense,//视频识别车牌结束
		}

		

		//视频识别触发类型
		public enum VcaTriggerType
		{
			InterTrigger = 0,// 模块内部触发识别
			ExterTrigger = 1,// 外部物理信号触发：线圈、雷达、手动触发信号；
		}

		public const int MaxChineseCharNum = 64;    // 最大汉字类别数量
		//车牌可动态修改参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlateParam
		{
			public NetVcaRect struSearchRect;//搜索区域(归一化)
			public NetVcaRect struInvalidateRect;//无效区域，在搜索区域内部 (归一化)
			public ushort wMinPlateWidth;//车牌最小宽度
			public ushort wTriggerDuration;//触发持续帧数
			public byte byTriggerType;//触发模式, VCA_TRIGGER_TYPE
			public byte bySensitivity;//灵敏度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，置0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byCharPriority;// 汉字优先级
		}

		/*wMinPlateWidth:该参数默认配置为80像素；该参数的配置对于车牌海康威视车牌识别说明文档 
		识别有影响，如果设置过大，那么如果场景中出现小车牌就会漏识别；如果场景中车牌宽度普遍较大，可以把该参数设置稍大，便于减少对虚假车牌的处理。在标清情况下建议设置为80， 在高清情况下建议设置为120
		wTriggerDuration － 外部触发信号持续帧数量，其含义是从触发信号开始识别的帧数量。该值在低速场景建议设置为50～100；高速场景建议设置为15～25；移动识别时如果也有外部触发，设置为15～25；具体可以根据现场情况进行配置
		*/
		//车牌识别参数子结构
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlateinfo
		{
			public VcaRecognizeScene eRecogniseScene;//识别场景(低速和高速)
			public NetVcaPlateParam struModifyParam;//车牌可动态修改参数
		}

		//车牌识别配置参数
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlatecfg
		{
			public uint dwSize;
			public byte byPicProType;//报警时图片处理方式 0-不处理 1-上传
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，设置为0
			public NetDvrJpegpara struPictureParam;//图片规格结构
			public NetVcaPlateinfo struPlateInfo;//车牌信息
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//布防时间
			public NetDvrHandleexceptionV30 struHandleType;//处理方式
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//报警触发的录象通道,为1表示触发该通道
		}

		//车牌识别结果子结构
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetVcaPlateInfo
		{
			public VcaRecognizeResult eResultFlag;//识别结果标志 
			public VcaPlateType ePlateType;//车牌类型
			public VcaPlateColor ePlateColor;//车牌颜色
			public NetVcaRect struPlateRect;//车牌位置
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;//保留，设置为0 
			public uint dwLicenseLen;//车牌长度
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxLicenseLen)]
			public string sLicense;//车牌号码 
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxLicenseLen)]
			public string sBelieve;//各个识别字符的置信度，如检测到车牌"浙A12345", 置信度为10,20,30,40,50,60,70，则表示"浙"字正确的可能性只有10%，"A"字的正确的可能性是20%
		}

		//车牌检测结果
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlateResult
		{
			public uint dwSize;//结构长度
			public uint dwRelativeTime;//相对时标
			public uint dwAbsTime;//绝对时标
			public byte byPlateNum;//车牌个数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPlateNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPlateInfo[] struPlateInfo;//车牌信息结构
			public uint dwPicDataLen;//返回图片的长度 为0表示没有图片，大于0表示该结构后面紧跟图片数据
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes2;//保留，设置为0 图片的高宽
			public IntPtr pImage;//指向图片的指针
		}

		//重启智能库
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_VCA_RestartLib(int lUserId, int lChannel);

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLineSegment
		{
			public NetVcaPoint struStartPoint;//表示高度线时，表示头部点
			public NetVcaPoint struEndPoint;//表示高度线时，表示脚部点
			public float fValue;//高度值，单位米
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//标定线链表
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLineSegList
		{
			public uint dwSize;//结构长度
			public byte bySegNum;//标定线条数
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//保留，置0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSegmentNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaLineSegment[] struSeg;
		}

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRealHeight(int lUserId, int lChannel, ref NetVcaLine lpLine, ref float lpHeight);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRealLength(int lUserId, int lChannel, ref NetVcaLine lpLine, ref float lpLength);        

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_EncodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

		//2009-7-22 end  

		//邮件服务测试 9000_1.1
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_EmailTest(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFileByEvent(int lUserId, ref NetDvrSearchEventParam lpSearchEventParam);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextEvent(int lSearchHandle, ref NetDvrSearchEventRet lpSearchEventRet);


		//2009-8-18 抓拍机
		public const int PlateInfoLen = 1024;
		public const int PlateNumLen = 16;
		public const int FileNameLen = 256;

		//liscense plate result
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateRet
		{
			public uint dwSize;//结构长度
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PlateNumLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPlateNum;//车牌号
			public byte byVehicleType;// 车类型
			public byte byTrafficLight;//0-绿灯；1-红灯
			public byte byPlateColor;//车牌颜色
			public byte byDriveChan;//触发车道号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byTimeInfo;/*时间信息*///plate_172.6.113.64_20090724155526948_197170484 
			//目前是17位，精确到ms:20090724155526948
			public byte byCarSpeed;/*单位km/h*/
			public byte byCarSpeedH;/*cm/s高8位*/
			public byte byCarSpeedL;/*cm/s低8位*/
			public byte byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PlateInfoLen - 36, ArraySubType = UnmanagedType.I1)]
			public byte[] byInfo;
			public uint dwPicLen;
		}
		/*注：后面紧跟 dwPicLen 长度的 图片 信息*/

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE(int lUserId, int lChannel, string pPicFileName, ref NetDvrPlateRet pPlateRet, string pPicBuf, uint dwPicBufLen);

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCcdCfg
		{
			public uint dwSize;//结构长度
			public byte byBlc;/*背光补偿0-off; 1-on*/
			public byte byBlcMode;/*blc类型0-自定义1-上；2-下；3-左；4-右；5-中；注：此项在blc为 on 时才起效*/
			public byte byAwb;/*自动白平衡0-自动1; 1-自动2; 2-自动控制*/
			public byte byAgc;/*自动增益0-关; 1-低; 2-中; 3-高*/
			public byte byDayNight;/*日夜转换；0 彩色；1黑白；2自动*/
			public byte byMirror;/*镜像0-关;1-左右;2-上下;3-中心*/
			public byte byShutter;/*快门0-自动; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
			public byte byIrCutTime;/*IRCUT切换时间，5, 10, 15, 20, 25*/
			public byte byLensType;/*镜头类型0-电子光圈; 1-自动光圈*/
			public byte byEnVideoTrig;/*视频触发使能：1-支持；0-不支持。视频触发模式下视频快门速度按照byShutter速度，抓拍图片的快门速度按照byCapShutter速度，抓拍完成后会自动调节回视频模式*/
			public byte byCapShutter;/*抓拍时的快门速度，1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
			public byte byEnRecognise;/*1-支持识别；0-不支持识别*/
		}

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetCCDCfg(int lUserId, int lChannel, ref NetDvrCcdCfg lpCcdCfg);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetCCDCfg(int lUserId, int lChannel, ref NetDvrCcdCfg lpCcdCfg);

		[StructLayout(LayoutKind.Sequential)]
		public struct TagCameraparamcfg
		{
			public uint dwSize;
			public uint dwPowerLineFrequencyMode;/*0-50HZ; 1-60HZ*/
			public uint dwWhiteBalanceMode;/*0手动白平衡; 1自动白平衡1（范围小）; 2 自动白平衡2（范围宽，2200K-15000K）;3自动控制3*/
			public uint dwWhiteBalanceModeRGain;/*手动白平衡时有效，手动白平衡 R增益*/
			public uint dwWhiteBalanceModeBGain;/*手动白平衡时有效，手动白平衡 B增益*/
			public uint dwExposureMode;/*0 手动曝光 1自动曝光*/
			public uint dwExposureSet;/* 0-USERSET, 1-自动x2，2-自动4，3-自动81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
			public uint dwExposureUserSet;/* 自动自定义曝光时间*/
			public uint dwExposureTarget;/*手动曝光时间 范围（Manumal有效，微秒）*/
			public uint dwIrisMode;/*0 自动光圈 1手动光圈*/
			public uint dwGainLevel;/*增益：0-100*/
			public uint dwBrightnessLevel;/*0-100*/
			public uint dwContrastLevel;/*0-100*/
			public uint dwSharpnessLevel;/*0-100*/
			public uint dwSaturationLevel;/*0-100*/
			public uint dwHueLevel;/*0-100，（保留）*/
			public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
			public uint dwGammaCorrectionLevel;/*0-100*/
			public uint dwWDREnabled;/*宽动态：0 dsibale  1 enable*/
			public uint dwWDRLevel1;/*0-F*/
			public uint dwWDRLevel2;/*0-F*/
			public uint dwWDRContrastLevel;/*0-100*/
			public uint dwDayNightFilterType;/*日夜切换：0 day,1 night,2 auto */
			public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(保留)*/
			//模式1(保留)
			public uint dwBeginTime;	/*0-100*/
			public uint dwEndTime;/*0-100*/
			//模式2
			public uint dwDayToNightFilterLevel;//0-7
			public uint dwNightToDayFilterLevel;//0-7
			public uint dwDayNightFilterTime;//(60秒)
			public uint dwBacklightMode;/*背光补偿:0 USERSET 1 UP、2 DOWN、3 LEFT、4 RIGHT、5MIDDLE*/
			public uint dwPositionX1;//（X坐标1）
			public uint dwPositionY1;//（Y坐标1）
			public uint dwPositionX2;//（X坐标2）
			public uint dwPositionY2;//（Y坐标2）
			public uint dwBacklightLevel;/*0x0-0xF*/
			public uint dwDigitalNoiseRemoveEnable; /*数字去噪：0 dsibale  1 enable*/
			public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
			public uint dwMirror; /* 镜像：0 Left;1 Right,;2 Up;3Down */
			public uint dwDigitalZoom;/*数字缩放:0 dsibale  1 enable*/
			public uint dwDeadPixelDetect;/*坏点检测,0 dsibale  1 enable*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		public const int NetDvrGetCcdparamcfg = 1067;       //IPC获取CCD参数配置
		public const int NetDvrSetCcdparamcfg = 1068;      //IPC设置CCD参数配置

		//图像增强仪
		//图像增强去燥区域配置
		[StructLayout(LayoutKind.Sequential)]
		public struct TagImageregion
		{
			public uint dwSize;//总的结构长度
			public ushort wImageRegionTopLeftX;/* 图像增强去燥的左上x坐标 */
			public ushort wImageRegionTopLeftY;/* 图像增强去燥的左上y坐标 */
			public ushort wImageRegionWidth;/* 图像增强去燥区域的宽 */
			public ushort wImageRegionHeight;/*图像增强去燥区域的高*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//图像增强、去噪级别及稳定性使能配置
		[StructLayout(LayoutKind.Sequential)]
		public struct TagImagesubparam
		{
			public NetDvrSchedtime struImageStatusTime;//图像状态时间段
			public byte byImageEnhancementLevel;//图像增强的级别，0-7，0表示关闭
			public byte byImageDenoiseLevel;//图像去噪的级别，0-7，0表示关闭
			public byte byImageStableEnable;//图像稳定性使能，0表示关闭，1表示打开
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int NetDvrGetImageregion = 1062;       //图像增强仪图像增强去燥区域获取
		public const int NetDvrSetImageregion = 1063;       //图像增强仪图像增强去燥区域获取
		public const int NetDvrGetImageparam = 1064;       // 图像增强仪图像参数(去噪、增强级别，稳定性使能)获取
		public const int NetDvrSetImageparam = 1065;       // 图像增强仪图像参数(去噪、增强级别，稳定性使能)设置

		[StructLayout(LayoutKind.Sequential)]
		public struct TagImageparam
		{
			public uint dwSize;
			//图像增强时间段参数配置，周日开始	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public TagImagesubparam[] struImageParamSched;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetParamSetMode(int lUserId, ref uint dwParamSetMode);

		/*********************************************************
		Function:	NET_DVR_Login_V30
		Desc:		
		Input:	sDvrip [in] 设备IP地址 
				wServerPort [in] 设备端口号 
				sUserName [in] 登录的用户名 
				sPassword [in] 用户密码 
		Output:	lpDeviceInfo [out] 设备信息 
		Return:	-1表示失败，其他值表示返回的用户ID值
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_Login_V30(string sDvrip, int wDvrPort, string sUserName, string sPassword, ref NetDvrDeviceinfoV30 lpDeviceInfo);

		/*********************************************************
		Function:	NET_DVR_Logout_V30
		Desc:		用户注册设备。
		Input:	lUserId [in] 用户ID号
		Output:	
		Return:	TRUE表示成功，FALSE表示失败
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Logout_V30(int lUserId);











		#region  取流模块相关结构与接口

		[StructLayout(LayoutKind.Sequential)]
		public struct PlayInfo
		{
			public int iUserId;      //注册用户ID
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
			public string strDeviceIP;
			public int iDevicePort;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string strDevAdmin;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string strDevPsd;
			public int iChannel;      //播放通道号(从0开始)
			public int iLinkMode;   //最高位(31)为0表示主码流，为1表示子码流，0－30位表示码流连接方式: 0：TCP方式,1：UDP方式,2：多播方式,3 - RTP方式，4-音视频分开(TCP)
			public bool bUseMedia;     //是否启用流媒体
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
			public string strMediaIP; //流媒体IP地址
			public int iMediaPort;   //流媒体端口号
		}


		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_Init();

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_UnInit();


		[DllImport("GetStream.dll")]
		public static extern int CLIENT_SDK_GetStream(PlayInfo lpPlayInfo); //

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SetRealDataCallBack(int iRealHandle, Setrealdatacallback fRealDataCallBack, uint lUser); //

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_StopStream(int iRealHandle);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_GetVideoEffect(int iRealHandle, ref int iBrightValue, ref int iContrastValue, ref int iSaturationValue, ref int iHueValue);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_SetVideoEffect(int iRealHandle, int iBrightValue, int iContrastValue, int iSaturationValue, int iHueValue);

		[DllImport("GetStream.dll")]
		public static extern bool CLIENT_SDK_MakeKeyFrame(int iRealHandle);

		#endregion


		#region VOD点播放库

		public const int WmNeterror = 0x0400 + 102;          //网络异常消息
		public const int WmStreamend = 0x0400 + 103;		  //文件播放结束

		public const int FileHead = 0;      //文件头
		public const int VideoIFrame = 1;  //视频I帧
		public const int VideoBFrame = 2;  //视频B帧
		public const int VideoPFrame = 3;  //视频P帧
		public const int VideoBpFrame = 4; //视频BP帧
		public const int VideoBbpFrame = 5; //视频B帧B帧P帧
		public const int AudioPacket = 10;   //音频包

		[StructLayout(LayoutKind.Sequential)]
		public struct Blocktime
		{
			public ushort wYear;
			public byte bMonth;
			public byte bDay;
			public byte bHour;
			public byte bMinute;
			public byte bSecond;
		}


		[StructLayout(LayoutKind.Sequential)]
		public struct Vodsearchparam
		{
			public IntPtr sessionHandle;                                    //[in]VOD客户端句柄
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
			public string dvrIP;                                            //	[in]DVR的网络地址
			public uint dvrPort;                                            //	[in]DVR的端口地址
			public uint channelNum;                                         //  [in]DVR的通道号
			public Blocktime startTime;                                     //	[in]查询的开始时间
			public Blocktime stopTime;                                      //	[in]查询的结束时间
			public bool bUseIPServer;                                       //  [in]是否使用IPServer 
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string SerialNumber;                                     //  [in]设备的序列号
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct Sectionlist
		{
			public Blocktime startTime;
			public Blocktime stopTime;
			public byte byRecType;
			public IntPtr pNext;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct Vodopenparam
		{
			public IntPtr sessionHandle;                                    //[in]VOD客户端句柄
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
			public string dvrIP;                                            //	[in]DVR的网络地址
			public uint dvrPort;                                            //	[in]DVR的端口地址
			public uint channelNum;                                         //  [in]DVR的通道号
			public Blocktime startTime;                                     //	[in]查询的开始时间
			public Blocktime stopTime;                                      //	[in]查询的结束时间
			public uint uiUser;
			public bool bUseIPServer;                                       //  [in]是否使用IPServer 
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string SerialNumber;                                     //  [in]设备的序列号

			public VodStreamFrameData streamFrameData;
		}


		[StructLayout(LayoutKind.Sequential)]
		public struct Connparam
		{
			public uint uiUser;
			public ErrorCallback errorCB;
		}


		// 异常回调函数
		public delegate void ErrorCallback(IntPtr hSession, uint dwUser, int lErrorType);
		//帧数据回调函数
		public delegate void VodStreamFrameData(IntPtr hStream, uint dwUser, int lFrameType, IntPtr pBuffer, uint dwSize);

		//模块初始化
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODServerConnect(string strServerIp, uint uiServerPort, ref IntPtr hSession, ref Connparam struConn, IntPtr hWnd);

		//模块销毁
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODServerDisconnect(IntPtr hSession);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStreamSearch(IntPtr pSearchParam, ref IntPtr pSecList);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODDeleteSectionList(IntPtr pSecList);

		// 根据ID、时间段打开流获取流句柄
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODOpenStream(IntPtr pOpenParam, ref IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODCloseStream(IntPtr hStream);

		//根据ID、时间段打开批量下载
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODOpenDownloadStream(ref Vodopenparam struVodParam, ref IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODCloseDownloadStream(IntPtr hStream);

		// 开始流解析，发送数据帧
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStartStreamData(IntPtr phStream);
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODPauseStreamData(IntPtr hStream, bool bPause);
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStopStreamData(IntPtr hStream);

		// 根据时间定位
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODSeekStreamData(IntPtr hStream, IntPtr pStartTime);


		// 根据时间定位
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODSetStreamSpeed(IntPtr hStream, int iSpeed);

		// 根据时间定位
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODGetStreamCurrentTime(IntPtr hStream, ref Blocktime pCurrentTime);

		#endregion


		#region 帧分析库


		[StructLayout(LayoutKind.Sequential)]
		public struct PacketInfo
		{
			public int nPacketType;     // packet type
			// 0:  file head
			// 1:  video I frame
			// 2:  video B frame
			// 3:  video P frame
			// 10: audio frame
			// 11: private frame only for PS


			//      [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)]
			public IntPtr pPacketBuffer;
			public uint dwPacketSize;
			public int nYear;
			public int nMonth;
			public int nDay;
			public int nHour;
			public int nMinute;
			public int nSecond;
			public uint dwTimeStamp;
		}



		/******************************************************************************
		* function：get a empty port number
		* parameters：
		* return： 0 - 499 : empty port number
		*          -1      : server is full  			
		* comment：
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern int AnalyzeDataGetSafeHandle();


		/******************************************************************************
		* function：open standard stream data for analyzing
		* parameters：lHandle - working port number
		*             pHeader - pointer to file header or info header
		* return：TRUE or FALSE
		* comment：
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataOpenStreamEx(int iHandle, byte[] pFileHead);


		/******************************************************************************
		* function：close analyzing
		* parameters：lHandle - working port number
		* return：
		* comment：
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataClose(int iHandle);


		/******************************************************************************
		* function：input stream data
		* parameters：lHandle		- working port number
		*			  pBuffer		- data pointer
		*			  dwBuffersize	- data size
		* return：TRUE or FALSE
		* comment：
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataInputData(int iHandle, IntPtr pBuffer, uint uiSize); //byte []


		/******************************************************************************
		* function：get analyzed packet
		* parameters：lHandle		- working port number
		*			  pPacketInfo	- returned structure
		* return：-1 : error
		*          0 : succeed
		*		   1 : failed
		*		   2 : file end (only in file mode)				
		* comment：
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern int AnalyzeDataGetPacket(int iHandle, ref PacketInfo pPacketInfo);  //要把pPacketInfo转换成PACKET_INFO结构


		/******************************************************************************
		* function：get remain data from input buffer
		* parameters：lHandle		- working port number
		*			  pBuf	        - pointer to the mem which stored remain data
		*             dwSize        - size of remain data  
		* return： TRUE or FALSE				
		* comment：
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataGetTail(int iHandle, ref IntPtr pBuffer, ref uint uiSize);


		[DllImport("AnalyzeData.dll")]
		public static extern uint AnalyzeDataGetLastError(int iHandle);

		#endregion


		#region 录像库

		public const int DatastreamHead = 0;		//数据头
		public const int DatastreamBitblock = 1;		//字节数据
		public const int DatastreamKeyframe = 2;		//关键帧数据
		public const int DatastreamNormalframe = 3;		//非关键帧数据


		public const int MessagevalueDiskfull = 0x01;
		public const int MessagevalueSwitchdisk = 0x02;
		public const int MessagevalueCreatefile = 0x03;
		public const int MessagevalueDeletefile = 0x04;
		public const int MessagevalueSwitchfile = 0x05;




		[StructLayout(LayoutKind.Sequential)]
		public struct Storeinfo
		{
			public int iMaxChannels;
			public int iDiskGroup;
			public int iStreamType;
			public bool bAnalyze;
			public bool bCycWrite;
			public uint uiFileSize;

			public CallbackfunMessage funCallback;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct CreatefileInfo
		{
			public int iHandle;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strCameraid;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strFileName;

			public Blocktime tFileCreateTime;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct ClosefileInfo
		{
			public int iHandle;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strCameraid;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string strFileName;

			public Blocktime tFileSwitchTime;
		}



		public delegate int CallbackfunMessage(int iMessageType, IntPtr pBuf, int iBufLen);


		[DllImport("RecordDLL.dll")]
		public static extern int Initialize(Storeinfo struStoreInfo);

		[DllImport("RecordDLL.dll")]
		public static extern int Release();

		[DllImport("RecordDLL.dll")]
		public static extern int OpenChannelRecord(string strCameraid, IntPtr pHead, uint dwHeadLength);

		[DllImport("RecordDLL.dll")]
		public static extern bool CloseChannelRecord(int iRecordHandle);

		[DllImport("RecordDLL.dll")]
		public static extern int GetData(int iHandle, int iDataType, IntPtr pBuf, uint uiSize);

		#endregion

		//设备区域设置
		public const int Regiontype = 0;//代表区域
		public const int Matrixtype = 11;//矩阵节点
		public const int Devicetype = 2;//代表设备
		public const int Channeltype = 3;//代表通道
		public const int Usertype = 5;//代表用户

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLogMatrix
		{
			public NetDvrTime strLogTime;
			public uint dwMajorType;
			public uint dwMinorType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;
			public NetDvrIpaddr struRemoteHostAddr;
			public uint dwParaType;
			public uint dwChannel;
			public uint dwDiskNumber;
			public uint dwAlarmInPort;
			public uint dwAlarmOutPort;
			public uint dwInfoLen;
			public byte byDevSequence;//槽位号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;//MAC地址
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//序列号
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LogInfoLen - SerialnoLen - MacaddrLen - 1)]
			public string sInfo;
		}

		//视频综合平台软件
		[StructLayout(LayoutKind.Sequential)]
		public struct TagVedioplatlog
		{
			public byte bySearchCondition;//搜索条件，0-按槽位号搜索，1-按序列号搜索 2-按MAC地址进行搜索
			public byte byDevSequence;//槽位号，0-79：对应子系统的槽位号；
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//序列号
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;//MAC地址
		}

		[DllImport(@"..\lib\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NetDvrLogMatrix lpLogData);


		[DllImport(@"..\lib\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog_Matrix(int iUserId, int lSelectMode, uint dwMajorType, uint dwMinorType, ref TagVedioplatlog lpVedioPlatLog, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);
	}
}
