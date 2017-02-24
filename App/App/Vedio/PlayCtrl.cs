using System;
using System.Runtime.InteropServices;

namespace ESMonApp.Vedio
{
	internal class PlayCtrl
	{
		public const string Playm4Api = "extern \"C\"__declspec(dllexport)";

		// public const string PLAYM4_API = "extern \"C\" __declspec(dllimport)";


		//Max channel numbers
		public const int Playm4MaxSupports = 500;
		//Wave coef range;
		public const int MinWaveCoef = -100;
		public const int MaxWaveCoef = 100;

		//Timer type
		public const int Timer1 = 1; //Only 16 timers for every process.Default TIMER;
		public const int Timer2 = 2;//Not limit;But the precision less than TIMER_1; 

		//BUFFER TYPE
		public const int BufVideoSrc = 1;
		public const int BufAudioSrc = 2;
		public const int BufVideoRender = 3;
		public const int BufAudioRender = 4;

		//Error code
		public const int Playm4Noerror = 0;//no error
		public const int Playm4ParaOver = 1;//input parameter is invalid;
		public const int Playm4OrderError = 2;//The order of the function to be called is error.
		public const int Playm4TimerError = 3;//Create multimedia clock failed;
		public const int Playm4DecVideoError = 4;//Decode video data failed.
		public const int Playm4DecAudioError = 5;//Decode audio data failed.
		public const int Playm4AllocMemoryError = 6;//Allocate memory failed.
		public const int Playm4OpenFileError = 7;//Open the file failed.
		public const int Playm4CreateObjError = 8;//Create thread or event failed
		public const int Playm4CreateDdrawError = 9;//Create DirectDraw object failed.
		public const int Playm4CreateOffscreenError = 10;//failed when creating off-screen surface.
		public const int Playm4BufOver = 11;//buffer is overflow
		public const int Playm4CreateSoundError = 12;//failed when creating audio device.	
		public const int Playm4SetVolumeError = 13;//Set volume failed
		public const int Playm4SupportFileOnly = 14;//The function only support play file.
		public const int Playm4SupportStreamOnly = 15;//The function only support play stream.
		public const int Playm4SysNotSupport = 16;//System not support.
		public const int Playm4FileheaderUnknown = 17;//No file header.
		public const int Playm4VersionIncorrect = 18;//The version of decoder and encoder is not adapted.  
		public const int Playm4InitDecoderError = 19;//Initialize decoder failed.
		public const int Playm4CheckFileError = 20;//The file data is unknown.
		public const int Playm4InitTimerError = 21;//Initialize multimedia clock failed.
		public const int Playm4BltError = 22;//Blt failed.
		public const int Playm4UpdateError = 23;//Update failed.
		public const int Playm4OpenFileErrorMulti = 24;//openfile error, streamtype is multi
		public const int Playm4OpenFileErrorVideo = 25;//openfile error, streamtype is video
		public const int Playm4JpegCompressError = 26;//JPEG compress error
		public const int Playm4ExtractNotSupport = 27;//Don't support the version of this file.
		public const int Playm4ExtractDataError = 28;//extract video data failed.
		public const int Playm4SecretKeyError = 29;//Secret Key is error //add 20071218

		//Max display regions.
		public const int MaxDisplayWnd = 4;

		//Display type
		public const int DisplayNormal = 1;
		public const int DisplayQuarter = 2;

		//Display buffers
		public const int MaxDisFrames = 50;
		public const int MinDisFrames = 1;

		//Locate by
		public const int ByFramenum = 1;
		public const int ByFrametime = 2;

		//Source buffer
		public const int SourceBufMax = 1024*100000;
		public const int SourceBufMin	= 1024*50;

		//Stream type
		public const int StreameRealtime = 0;
		public const int StreameFile = 1;

		//frame type
		public const int Audio16 = 101;
		public const int Audio8 = 100;
		public const int Uyvy = 1;
		public const int Yv12 = 3;
		public const int Rgb32 = 7;

		//capability
		public const int SupportDdraw = 1;
		public const int SupportBlt = 2;
		public const int SupportBltfourcc = 4;
		public const int SupportBltshrinkx = 8;
		public const int SupportBltshrinky = 16;
		public const int SupportBltstretchx = 32;
		public const int SupportBltstretchy = 64;
		public const int SupportSse = 128;
		public const int SupportMmx = 256;

		// 以下宏定义用于HIK_MEDIAINFO结构
		public const int FourccHkmi = 0x484B4D49;	// "HKMI" HIK_MEDIAINFO结构标记
		// 系统封装格式
		public const int SystemNull = 0;// 没有系统层，纯音频流或视频流	
		public const int SystemHik = 1;// 海康文件层
		public const int SystemMpeg2Ps = 2;// PS封装
		public const int SystemMpeg2Ts = 3;// TS封装
		public const int SystemRtp = 4;// rtp封装

		// 视频编码类型
		public const int VideoNull = 0;// 没有视频
		public const int VideoH264 = 1;// 标准H.264和海康H.264都可以用这个定义
		public const int VideoMpeg4 = 3;// 标准MPEG4

		// 音频编码类型
		public const int AudioNull = 0;// 没有音频
		public const int AudioAdpcm = 4096;// ADPCM 
		public const int AudioMpeg = 8192;// MPEG 系列音频，解码器能自适应各种MPEG音频

		// G系列音频
		public const int AudioG711U = 28944;
		public const int AudioG711A = 28945;
		public const int AudioG7221 = 29217;
		public const int AudioG7231 = 29233;
		public const int AudioG726 = 29280;
		public const int AudioG729 = 29328;

		//Frame position
		public struct Systemtime
		{
			public ushort WYear;
			public ushort WMonth;
			public ushort WDayOfWeek;
			public ushort WDay;
			public ushort WHour;
			public ushort WMinute;
			public ushort WSecond;
			public ushort WMilliseconds;

			public void Init()
			{
				WYear = 0;
				WMonth = 0;
				WDayOfWeek = 0;
				WDay = 0;
				WHour = 0;
				WMinute = 0;
				WSecond = 0;
				WMilliseconds = 0;
			}
		}
   
		public struct FramePos
		{
			public int NFilePos;
			public int NFrameNum;
			public int NFrameTime;
			public int NErrorFrameNum;
			public IntPtr PErrorTime;
			public int NErrorLostFrameNum;
			public int NErrorFrameSize;

			public void Init()
			{
				NFilePos = 0;
				NFrameNum = 0;
				NFrameTime = 0;
				NErrorFrameNum = 0;
				PErrorTime = new IntPtr();
				NErrorLostFrameNum = 0;
				NErrorFrameSize = 0;
			}
		}

		//Frame Info
		public struct FrameInfo
		{
			public int NWidth;
			public int NHeight;
			public int NStamp;
			public int NType;
			public int NFrameRate;
			public uint DwFrameNum;

			public void Init()
			{
				NWidth = 0;
				NHeight = 0;
				NStamp = 0;
				NType = 0;
				NFrameRate = 0;
				DwFrameNum = 0;
			}
		}

		//Frame
		public struct FrameType
		{
			[MarshalAs(UnmanagedType.LPStr)]
			public string PDataBuf;
			public int NSize;
			public int NFrameNum;
			public bool BIsAudio;
			public int NReserved;

			public void Init()
			{
				PDataBuf = "";
				NSize = 0;
				NFrameNum = 0;
				BIsAudio = false;
				NReserved = 0;
			}
		}

		//Watermark Info	//add by gb 080119
		public struct WatermarkInfo
		{
			[MarshalAs(UnmanagedType.LPStr)]
			public string PDataBuf;
			public int NSize;
			public int NFrameNum;
			public bool BRsaRight;
			public int NReserved;

			public void Init()
			{
				PDataBuf = "";
				NSize = 0;
				NFrameNum = 0;
				BRsaRight = false;
				NReserved = 0;
			}
		}

		// modified by gb 080425
		public struct HikMediainfo
		{
			public uint MediaFourcc;// "HKMI": 0x484B4D49 Hikvision Media Information
			public ushort MediaVersion;// 版本号：指本信息结构版本号，目前为0x0101,即1.01版本，01：主版本号；01：子版本号。
			public ushort DeviceId;// 设备ID，便于跟踪/分析	

			public ushort SystemFormat;// 系统封装层
			public ushort VideoFormat;// 视频编码类型

			public ushort AudioFormat;// 音频编码类型
			public byte AudioChannels;// 通道数  
			public byte AudioBitsPerSample;// 样位率
			public uint AudioSamplesrate;// 采样率 
			public uint AudioBitrate;// 压缩音频码率,单位：bit
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] Reserved;// 保留

			public void Init()
			{
				MediaFourcc = 0;
				MediaVersion = 0;
				DeviceId = 0;
				SystemFormat = 0;
				VideoFormat = 0;
				AudioFormat = 0;
				AudioChannels = 0;
				AudioBitsPerSample = 0;
				AudioSamplesrate = 0;
				AudioBitrate = 0;
				Reserved = new uint[4];
			}
		}

		//自己定义的函数接口
		/*************************************************
	Function:	 ConverUiTimeToDateTime
	Description: 把用uint表示的时间转换成DateTime表示的时间
	Input:		 void
	Output:      void
	Return:		 void
	*************************************************/
		public static DateTime ConverUiTimeToDateTime(uint uiTime)
		{
			var iYear   = (int)((uiTime >> 26) + 2000);
			var iMonth  = (int)((uiTime >> 22) & 15);
			var iDay    = (int)((uiTime >> 17) & 31);
			var iHour   = (int)((uiTime >> 12) & 31);
			var iMinute = (int)((uiTime >> 6)  & 63);
			var iSecond = (int)((uiTime >> 0)  & 63);
			var dateTime = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond);
			return dateTime;
		}

		/*************************************************
	Function:	 GetTimeFromUiTime
	Description:  从uint表示的时间获取时间
	Input:		  void
	Output:       void
	Return:		  void
	*************************************************/
		public static void GetTimeFromUiTime(uint uiTime, ref uint uiHour, ref uint uiMinute, ref uint uiSecond)
		{
			if (uiHour <= 0) throw new ArgumentOutOfRangeException(nameof(uiHour));
			uiHour = ((uiTime >> 12) & 31);
			uiMinute = ((uiTime >> 6) & 63);
			uiSecond = ((uiTime >> 0) & 63);
		}

		//API
		//Initialize DirecDraw.Now invalid.
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_InitDDraw(IntPtr hWnd);
		//Release directDraw; Now invalid.
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_RealeseDDraw();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_OpenFile(int nPort, String sFileName);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_CloseFile(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_Play(int nPort, IntPtr hWnd);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_Stop(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_Pause(int nPort, uint nPause);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_Fast(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_Slow(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_OneByOne(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetPlayPos(int nPort, float fRelativePos);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern float PlayM4_GetPlayPos(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetFileEndMsg(int nPort, IntPtr hWnd, uint nMsg);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetVolume(int nPort, ushort nVolume);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_StopSound();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_PlaySound(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_OpenStream(int nPort, IntPtr pFileHeadBuf, uint nSize, uint nBufPoolSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_InputData(int nPort, IntPtr pBuf, uint nSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_CloseStream(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern int PlayM4_GetCaps();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetFileTime(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetFileTimeEx(int nPort, ref uint pStart, ref uint pStop, ref uint pRev) ;


		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetPlayedTime(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetPlayedFrames(int nPort);

		////////////////ver 2.0 added///////////////////////////////////////
		public delegate void Deccbfun(int nPort, IntPtr pBuf, int nSize, ref FrameInfo pFrameInfo, int nReserved1, int nReserved2);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDecCallBack(int nPort, Deccbfun decCbFun);


		public delegate void Displaycbfun(int nPort, IntPtr pBuf, int nSize, int nWidth, int nHeight, int nStamp, int nType, int nReserved);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDisplayCallBack(int nPort, Displaycbfun displayCbFun);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PLayM4_ConvertToBmpFile(IntPtr pBuf, int nSize, int nWidth, int nHeight, int nType, string sFileName);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetFileTotalFrames(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetCurrentFrameRate(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetPlayedTimeEx(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetPlayedTimeEx(int nPort, uint nTime);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetCurrentFrameNum(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetStreamOpenMode(int nPort, uint nMode);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetFileHeadLength();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetSdkVersion();

		////////////////ver 2.2 added///////////////////////////////////////
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetLastError(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_RefreshPlay(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetOverlayMode(int nPort, int bOverlay, uint colorKey);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetPictureSize(int nPort, ref int pWidth, ref int pHeight);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetPicQuality(int nPort, int bHighQuality);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_PlaySoundShare(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_StopSoundShare(int nPort);

		////////////////ver 2.4 added///////////////////////////////////////
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern int PlayM4_GetStreamOpenMode(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern int PlayM4_GetOverlayMode(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetColorKey(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern ushort PlayM4_GetVolume(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetPictureQuality(int nPort, ref int bHighQuality);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetSourceBufferRemain(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_ResetSourceBuffer(int nPort);

		public delegate void Sourcebufcallbacki(int nPort, uint nBufSize, uint dwUser, IntPtr pResvered);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetSourceBufCallBack(int nPort, uint nThreShold, Sourcebufcallbacki sourceBufCallBack, uint dwUser, IntPtr pReserved);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_ResetSourceBufFlag(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDisplayBuf(int nPort, uint nNum);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetDisplayBuf(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_OneByOneBack(int nPort);

		// PLAYM4_API BOOL __stdcall PlayM4_SetFileRefCallBack(LONG nPort, void (__stdcall *pFileRefDone)(DWORD nPort,DWORD nUser),DWORD nUser);
		public delegate void Pfilerefdone(uint nPort, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetFileRefCallBack(int nPort, Pfilerefdone pFileRefDone, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetKeyFramePos(int nPort, uint nValue, uint nType, ref FramePos pFramePos);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetNextKeyFramePos(int nPort, uint nValue, uint nType, ref FramePos pFramePos);


		//#if (WINVER >= 0x0400)
		//Note: These funtion must be builded under win2000 or above with Microsoft Platform sdk.
		//	    You can download the sdk from "http://www.microsoft.com/msdownload/platformsdk/sdkupdate/";
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_InitDDrawDevice();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern void PlayM4_ReleaseDDrawDevice();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetDDrawDeviceTotalNums();

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDDrawDevice(int nPort, uint nDeviceNum);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern int PlayM4_GetCapsEx(uint nDDrawDeviceNum);

		//#endif
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_ThrowBFrameNum(int nPort, uint nNum);

		////////////////ver 2.5 added///////////////////////////////////////
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDisplayType(int nPort, int nType);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern int PlayM4_GetDisplayType(int nPort);

		////////////////ver 3.0 added///////////////////////////////////////
		public struct TagRect
		{
			public int Left;
			public int Top;
			public int Right;
			public int Bottom;

			public void Init()
			{
				Left = 0;
				Top = 0;
				Right = 0;
				Bottom = 0;
			}
		}

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDecCBStream(int nPort, uint nStream);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDisplayRegion(int nPort, uint nRegionNum, ref TagRect pSrcRect, IntPtr hDestWnd, [MarshalAs(UnmanagedType.Bool)] bool bEnable);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_RefreshPlayEx(int nPort, uint nRegionNum);

		//#if (WINVER >= 0x0400)
		//Note: The funtion must be builded under win2000 or above with Microsoft Platform sdk.
		//	    You can download the sdk from http://www.microsoft.com/msdownload/platformsdk/sdkupdate/;
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDDrawDeviceEx(int nPort, uint nRegionNum, uint nDeviceNum);

		//#endif
		/////////////////v3.2 added/////////////////////////////////////////
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetRefValue(int nPort, ref byte pBuffer, ref uint pSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetRefValue(int nPort, ref byte pBuffer, uint nSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_OpenStreamEx(int nPort, ref byte pFileHeadBuf, uint nSize, uint nBufPoolSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_CloseStreamEx(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_InputVideoData(int nPort, IntPtr pBuf, uint nSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_InputAudioData(int nPort, ref byte pBuf, uint nSize);


		public delegate void Drawfun(int nPort, IntPtr hDc, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_RigisterDrawFun(int nPort, Drawfun drawFun, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_RegisterDrawFun(int nPort, Drawfun drawFun, int nUser);

		//////////////////v3.4/////////////////////////////////////////////////////
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetTimerType(int nPort, uint nTimerType, uint nReserved);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetTimerType(int nPort, ref uint pTimerType, ref uint pReserved);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_ResetBuffer(int nPort, uint nBufType);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetBufferValue(int nPort, uint nBufType);

		//////////////////V3.6/////////////////////////////////////////////////////////
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_AdjustWaveAudio(int nPort, int nCoefficient);

		public delegate void Funveryfy(int nPort, ref FramePos pFilePos, uint bIsVideo, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetVerifyCallBack(int nPort, uint nBeginTime, uint nEndTime, Funveryfy funVerify, uint nUser);

		public delegate void Funaudio(int nPort, string pAudioBuf, int nSize, int nStamp, int nType, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetAudioCallBack(int nPort, Funaudio funAudio, int nUser);


		public delegate void Funencchange(int nPort, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetEncTypeChangeCallBack(int nPort, Funencchange funEncChange, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetColor(int nPort, uint nRegionNum, int nBrightness, int nContrast, int nSaturation, int nHue);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetColor(int nPort, uint nRegionNum, ref int pBrightness, ref int pContrast, ref int pSaturation, ref int pHue);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetEncChangeMsg(int nPort, IntPtr hWnd, uint nMsg);

		public delegate void Fungetorignalframe(int nPort, ref FrameType frameType, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetOriginalFrameCallBack(int nPort, int bIsChange, int bNormalSpeed, int nStartFrameNum, int nStartStamp, int nFileHeader, Fungetorignalframe funGetOrignalFrame, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetFileSpecialAttr(int nPort, ref uint pTimeStamp, ref uint pFileNum, ref uint pReserved);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetSpecialData(int nPort);

		public delegate void Funcheckwatermark(int nPort, ref WatermarkInfo pWatermarkInfo, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetCheckWatermarkCallBack(int nPort, Funcheckwatermark funCheckWatermark, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetImageSharpen(int nPort, uint nLevel);

		public delegate void Funthrowbframe(int nPort, uint nBFrame, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetThrowBFrameCallBack(int nPort, Funthrowbframe funThrowBFrame, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDecodeFrameType(int nPort, uint nFrameType);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetPlayMode(int nPort, int bNormal);

		public delegate void Fungetuserdata(int nPort, ref byte pUserBuf, uint nBufLen, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetGetUserDataCallBack(int nPort, Fungetuserdata funGetUserData, uint nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetOverlayFlipMode(int nPort, int bTrue);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern uint PlayM4_GetAbsFrameNum(int nPort);

		//////////////////V4.7.0.0//////////////////////////////////////////////////////
		////convert yuv to jpeg
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_ConvertToJpegFile(IntPtr pBuf, int nSize, int nWidth, int nHeight, int nType, string sFileName);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetJpegQuality(int nQuality);

		//set deflash
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDeflash(int nPort, int bDefalsh);

		//////////////////V4.8.0.0/////////////////////////////////////////////////////////
		//check discontinuous frame number as error data?
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_CheckDiscontinuousFrameNum(int nPort, int bCheck);

		//get bmp or jpeg
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetBMP(int nPort, ref byte pBitmap, uint nBufSize, ref uint pBmpSize);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetJPEG(int nPort, IntPtr pJpeg, uint nBufSize, ref uint pJpegSize);

		//dec call back mend
		//public delegate void DECCBFUN(int nPort, string pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nUser, int nReserved2);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDecCallBackMend(int nPort, Deccbfun decCbFun, int nUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetSecretKey(int nPort, int lKeyType, string pSecretKey, int lKeyLen);

		// add by gb 2007-12-23
		public delegate void Fileendcallback(int nPort, IntPtr pUser);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetFileEndCallback(int nPort, Fileendcallback fileEndCallback, IntPtr pUser);

		// add by gb 080131 version 4.9.0.1
		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_GetPort(ref int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_FreePort(int nPort);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SyncToAudio(int nPort, int bSyncToAudio);

		//public delegate void Anonymous_b532dad6_7470_4b10_9638_c82a363cd853(int nPort, System.IntPtr pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nReserved1, int nReserved2);

		[DllImport(@"..\bin\PlayCtrl.dll")]
		public static extern bool PlayM4_SetDecCallBackEx(int nPort, Deccbfun decCbFun, IntPtr pDest, int nDestSize);
	}
}

