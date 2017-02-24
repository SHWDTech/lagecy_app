using System;
using System.Runtime.InteropServices;
// ReSharper disable InconsistentNaming

namespace ESMonApp.Vedio
{
	/// <summary>
	/// CHCNetSDK ��ժҪ˵����
	/// </summary>
	public class ChcNetSdk
	{
		//SDK����
		public const int SdkPlaympeg4 = 1;//���ſ�
		public const int SdkHcnetsdk = 2;//�����

		public const int NameLen = 32;//�û�������
		public const int PasswdLen = 16;//���볤��
		public const int GuidLen = 16;      //GUID����
		public const int DevTypeNameLen = 24;      //�豸�������Ƴ���
		public const int MaxNamelen = 16;//DVR���ص�½��
		public const int MaxRight = 32;//�豸֧�ֵ�Ȩ�ޣ�1-12��ʾ����Ȩ�ޣ�13-32��ʾԶ��Ȩ�ޣ�
		public const int SerialnoLen = 48;//���кų���
		public const int MacaddrLen = 6;//mac��ַ����
		public const int MaxEthernet = 2;//�豸������̫����
		public const int MaxNetworkCard = 4; //�豸�������������Ŀ
		public const int PathnameLen = 128;//·������

		public const int MaxNumberLen = 32;	//������󳤶�
		public const int MaxNameLen = 128; //�豸������󳤶�

		public const int MaxTimesegmentV30 = 8;//9000�豸���ʱ�����
		public const int MaxTimesegment = 4;//8000�豸���ʱ�����
		public const int MaxIcrNum = 8;   //ץ�Ļ������˹�ƬԤ�õ���

		public const int MaxShelternum = 4;//8000�豸����ڵ�������
		public const int PhonenumberLen = 32;//pppoe���ź�����󳤶�

		public const int MaxDisknum = 16;//8000�豸���Ӳ����
		public const int MaxDisknumV10 = 8;//1.2�汾֮ǰ�汾

		public const int MaxWindowV30 = 32;//9000�豸������ʾ��󲥷Ŵ�����
		public const int MaxWindow = 16;//8000�豸���Ӳ����
		public const int MaxVgaV30 = 4;//9000�豸���ɽ�VGA��
		public const int MaxVga = 1;//8000�豸���ɽ�VGA��

		public const int MaxUsernumV30 = 32;//9000�豸����û���
		public const int MaxUsernum = 16;//8000�豸����û���
		public const int MaxExceptionnumV30 = 32;//9000�豸����쳣������
		public const int MaxExceptionnum = 16;//8000�豸����쳣������
		public const int MaxLink = 6;//8000�豸��ͨ�������Ƶ��������
		public const int MaxItcExceptionout = 32;//ץ�Ļ���󱨾����

		public const int MaxDecpoolnum = 4;//��·������ÿ������ͨ������ѭ��������
		public const int MaxDecnum = 4;//��·��������������ͨ������ʵ��ֻ��һ������������������
		public const int MaxTransparentnum = 2;//��·���������������͸��ͨ����
		public const int MaxCycleChan = 16; //��·�����������ѭͨ����
		public const int MaxCycleChanV30 = 64;//�����ѯͨ��������չ��
		public const int MaxDirnameLength = 80;//���Ŀ¼����

		public const int MaxStringnumV30 = 8;//9000�豸���OSD�ַ�������
		public const int MaxStringnum = 4;//8000�豸���OSD�ַ�������
		public const int MaxStringnumEx = 8;//8000������չ
		public const int MaxAuxoutV30 = 16;//9000�豸����������
		public const int MaxAuxout = 4;//8000�豸����������
		public const int MaxHdGroup = 16;//9000�豸���Ӳ������
		public const int MaxNfsDisk = 8; //8000�豸���NFSӲ����

		public const int IwEssidMaxSize = 32;//WIFI��SSID�ų���
		public const int IwEncodingTokenMax = 32;//WIFI��������ֽ���
		public const int WifiWepMaxKeyCount = 4;
		public const int WifiWepMaxKeyLength = 33;
		public const int WifiWpaPskMaxKeyLength = 63;
		public const int WifiWpaPskMinKeyLength = 8;
		public const int WifiMaxApCount = 20;
		public const int MaxSerialNum = 64;//���֧�ֵ�͸��ͨ��·��
		public const int MaxDdnsNums = 10;//9000�豸������ddns��
		public const int MaxEmailAddrLen = 48;//���email��ַ����
		public const int MaxEmailPwdLen = 32;//���email���볤��

		public const int Maxprogress = 100;//�ط�ʱ�����ٷ���
		public const int MaxSerialnum = 2;//8000�豸֧�ֵĴ����� 1-232�� 2-485
		public const int CardnumLen = 20;//���ų���
		public const int CardnumLenOut = 32; //�ⲿ�ṹ�忨�ų���
		public const int MaxVideooutV30 = 4;//9000�豸����Ƶ�����
		public const int MaxVideoout = 2;//8000�豸����Ƶ�����

		public const int MaxPresetV30 = 256;// 9000�豸֧�ֵ���̨Ԥ�õ���
		public const int MaxTrackV30 = 256;// 9000�豸֧�ֵ���̨�켣��
		public const int MaxCruiseV30 = 256;// 9000�豸֧�ֵ���̨Ѳ����
		public const int MaxPreset = 128;// 8000�豸֧�ֵ���̨Ԥ�õ��� 
		public const int MaxTrack = 128;// 8000�豸֧�ֵ���̨�켣��
		public const int MaxCruise = 128;// 8000�豸֧�ֵ���̨Ѳ���� 

		public const int CruiseMaxPresetNums = 32;// һ��Ѳ������Ѳ���� 

		public const int MaxSerialPort = 8;//9000�豸֧��232������
		public const int MaxPreviewMode = 8;// �豸֧�����Ԥ��ģʽ��Ŀ 1����,4����,9����,16����.... 
		public const int MaxMatrixout = 16;// ���ģ������������ 
		public const int LogInfoLen = 11840; // ��־������Ϣ 
		public const int DescLen = 16;// ��̨�����ַ������� 
		public const int PtzProtocolNum = 200;// 9000���֧�ֵ���̨Э���� 

		public const int MaxAudio = 1;//8000�����Խ�ͨ����
		public const int MaxAudioV30 = 2;//9000�����Խ�ͨ����
		public const int MaxChannum = 16;//8000�豸���ͨ����
		public const int MaxAlarmin = 16;//8000�豸��󱨾�������
		public const int MaxAlarmout = 4;//8000�豸��󱨾������
		//9000 IPC����
		public const int MaxAnalogChannum = 32;//���32��ģ��ͨ��
		public const int MaxAnalogAlarmout = 32; //���32·ģ�ⱨ����� 
		public const int MaxAnalogAlarmin = 32;//���32·ģ�ⱨ������

		public const int MaxIpDevice = 32;//�����������IP�豸��
		public const int MaxIpDeviceV40 = 64;//�����������IP�豸��
		public const int MaxIpChannel = 32;//�����������IPͨ����
		public const int MaxIpAlarmin = 128;//����������౨��������
		public const int MaxIpAlarmout = 64;//����������౨�������
		public const int MaxIpAlarminV40 = 4096;    //����������౨��������
		public const int MaxIpAlarmoutV40 = 4096;    //����������౨�������

		public const int MaxRecordFileNum = 20;      // ÿ��ɾ�����߿�¼������ļ���

		//SDK_V31 ATM
		public const int MaxAtmNum = 1;
		public const int MaxActionType = 12;
		public const int AtmFrametypeNum = 4;
		public const int MaxAtmProtocolNum = 1025;
		public const int AtmProtocolSort = 4;
		public const int AtmDescLen = 32;
		// SDK_V31 ATM

		/* ���֧�ֵ�ͨ���� ���ģ��������IP֧�� */
		public const int MaxChannumV30 = MaxAnalogChannum + MaxIpChannel;//64
		public const int MaxAlarmoutV30 = MaxAnalogAlarmout + MaxIpAlarmout;//96
		public const int MaxAlarminV30 = MaxAnalogAlarmin + MaxIpAlarmin;//160

		public const int MaxChannumV40 = 512;
		public const int MaxAlarmoutV40 = MaxIpAlarmoutV40 + MaxAnalogAlarmout;//4128
		public const int MaxAlarminV40 = MaxIpAlarminV40 + MaxAnalogAlarmout;//4128
		public const int MaxMultiAreaNum = 24;

		public const int MaxHumanPictureNum = 10;   //�����Ƭ��
		public const int MaxHumanBirthdateLen = 10;

		public const int MaxLayernums = 32;

		public const int MaxRoidetectNum = 8;    //֧�ֵ�ROI������
		public const int MaxLanerectNum   =     5;    //�����ʶ��������
		public const int MaxFortifyNum   =      10;   //��󲼷�����
		public const int MaxIntervalNum  =      4;    //���ʱ��������
		public const int MaxChjcNum     =       3;    //�����ʡ�ݼ���ַ�����
		public const int MaxVlNum        =      5;    //���������Ȧ����
		public const int MaxDrivechanNum =      16;   //��󳵵���
		public const int MaxCoilNum      =      3;    //�����Ȧ����
		public const int MaxSignallightNum =    6;   //����źŵƸ���
		public const int Len32				=	32;
		public const int Len31				=	31; 
		public const int MaxCabinetCount  =     8;    //���֧�ֻ�������
		public const int MaxIdLen         =     48;
		public const int MaxParknoLen    =      16;
		public const int MaxAlarmreasonLen =    32;
		public const int MaxUpgradeInfoLen=    48; //��ȡ�����ļ�ƥ����Ϣ(ģ������)
		public const int MaxCustomdirLen  =     32; //�Զ���Ŀ¼����

		public const int MaxTransparentChanNum  =    4;   //ÿ�����������������͸��ͨ����
		public const int MaxTransparentAccessNum =   4;   //ÿ�������˿������������������

		//ITS
		public const int MaxParkingStatus  =     8;    //��λ״̬ 0�����޳���1�����г���2����ѹ��(���ȼ����), 3���⳵λ 
		public const int MaxParkingNum	   =      4;    //һ��ͨ�����4����λ (�����ҳ�λ ����0��3)

		public const int MaxItsSceneNum    =    16;   //��󳡾�����
		public const int MaxSceneTimesegNum =   16;   //��󳡾�ʱ�������
		public const int MaxIvmsIpChannel  =    128;  //���IPͨ����
		public const int DeviceIdLen      =      48;   //�豸��ų���
		public const int MonitorsiteIdLen  =     48;   //�����ų���
		public const int MaxAuxareaNum       =   16;   //�������������Ŀ
		public const int MaxSlaveChannelNum =   16;   //����ͨ������

		public const int MaxSchTasksNum = 10;

		public const int MaxServeridLen   =         64; //��������ID�ĳ���
		public const int MaxServerdomainLen =       128; //������������󳤶�
		public const int MaxAuthenticateidLen =     64; //��֤ID��󳤶�
		public const int MaxAuthenticatepasswdLen = 32; //��֤������󳤶�
		public const int MaxServernameLen =         64; //���������û��� 
		public const int MaxCompressionidLen =      64; //����ID����󳤶�
		public const int MaxSipserverAddressLen =  128; //SIP��������ַ֧��������IP��ַ
		//ѹ�߱���
		public const int MaxPlAteNoLen =        32;   //���ƺ�����󳤶� 2013-09-27
		public const int UpnpPortNum	=		12;	  //upnp�˿�ӳ��˿���Ŀ

		
		public const int MaxLocalAddrLen	= 96;		//SOCKS��󱾵����θ���
		public const int MaxCountryNameLen = 4;		//���Ҽ�д���Ƴ���

		//�������ӷ�ʽ
		public const int Normalconnect = 1;
		public const int Mediaconnect = 2;

		//�豸�ͺ�(����)
		public const int Hcdvr = 1;
		public const int Medvr = 2;
		public const int Pcdvr = 3;
		public const int Hc9000 = 4;
		public const int HfI = 5;
		public const int Pcnvr = 6;
		public const int Hc76Nvr = 8;

		//NVR����
		public const int Ds8000HcNvr = 0;
		public const int Ds9000HcNvr = 1;
		public const int Ds8000MeNvr = 2;

		/*******************ȫ�ִ����� begin**********************/
		public const int NetDvrNoerror = 0;//û�д���
		public const int NetDvrPasswordError = 1;//�û����������
		public const int NetDvrNoenoughpri = 2;//Ȩ�޲���
		public const int NetDvrNoinit = 3;//û�г�ʼ��
		public const int NetDvrChannelError = 4;//ͨ���Ŵ���
		public const int NetDvrOverMaxlink = 5;//���ӵ�DVR�Ŀͻ��˸����������
		public const int NetDvrVersionnomatch = 6;//�汾��ƥ��
		public const int NetDvrNetworkFailConnect = 7;//���ӷ�����ʧ��
		public const int NetDvrNetworkSendError = 8;//�����������ʧ��
		public const int NetDvrNetworkRecvError = 9;//�ӷ�������������ʧ��
		public const int NetDvrNetworkRecvTimeout = 10;//�ӷ������������ݳ�ʱ
		public const int NetDvrNetworkErrordata = 11;//���͵���������
		public const int NetDvrOrderError = 12;//���ô������
		public const int NetDvrOpernopermit = 13;//�޴�Ȩ��
		public const int NetDvrCommandtimeout = 14;//DVR����ִ�г�ʱ
		public const int NetDvrErrorserialport = 15;//���ںŴ���
		public const int NetDvrErroralarmport = 16;//�����˿ڴ���
		public const int NetDvrParameterError = 17;//��������
		public const int NetDvrChanException = 18;//������ͨ�����ڴ���״̬
		public const int NetDvrNodisk = 19;//û��Ӳ��
		public const int NetDvrErrordisknum = 20;//Ӳ�̺Ŵ���
		public const int NetDvrDiskFull = 21;//������Ӳ����
		public const int NetDvrDiskError = 22;//������Ӳ�̳���
		public const int NetDvrNosupport = 23;//��������֧��
		public const int NetDvrBusy = 24;//������æ
		public const int NetDvrModifyFail = 25;//�������޸Ĳ��ɹ�
		public const int NetDvrPasswordFormatError = 26;//���������ʽ����ȷ
		public const int NetDvrDiskFormating = 27;//Ӳ�����ڸ�ʽ����������������
		public const int NetDvrDvrnoresource = 28;//DVR��Դ����
		public const int NetDvrDvropratefailed = 29;//DVR����ʧ��
		public const int NetDvrOpenhostsoundFail = 30;//��PC����ʧ��
		public const int NetDvrDvrvoiceopened = 31;//�����������Խ���ռ��
		public const int NetDvrTimeinputerror = 32;//ʱ�����벻��ȷ
		public const int NetDvrNospecfile = 33;//�ط�ʱ������û��ָ�����ļ�
		public const int NetDvrCreatefileError = 34;//�����ļ�����
		public const int NetDvrFileopenfail = 35;//���ļ�����
		public const int NetDvrOpernotfinish = 36; //�ϴεĲ�����û�����
		public const int NetDvrGetplaytimefail = 37;//��ȡ��ǰ���ŵ�ʱ�����
		public const int NetDvrPlayfail = 38;//���ų���
		public const int NetDvrFileformatError = 39;//�ļ���ʽ����ȷ
		public const int NetDvrDirError = 40;//·������
		public const int NetDvrAllocResourceError = 41;//��Դ�������
		public const int NetDvrAudioModeError = 42;//����ģʽ����
		public const int NetDvrNoenoughBuf = 43;//������̫С
		public const int NetDvrCreatesocketError = 44;//����SOCKET����
		public const int NetDvrSetsocketError = 45;//����SOCKET����
		public const int NetDvrMaxNum = 46;//�����ﵽ���
		public const int NetDvrUsernotexist = 47;//�û�������
		public const int NetDvrWriteflasherror = 48;//дFLASH����
		public const int NetDvrUpgradefail = 49;//DVR����ʧ��
		public const int NetDvrCardhaveinit = 50;//���뿨�Ѿ���ʼ����
		public const int NetDvrPlayerfailed = 51;//���ò��ſ���ĳ������ʧ��
		public const int NetDvrMaxUsernum = 52;//�豸���û����ﵽ���
		public const int NetDvrGetlocalipandmacfail = 53;//��ÿͻ��˵�IP��ַ�������ַʧ��
		public const int NetDvrNoencodeing = 54;//��ͨ��û�б���
		public const int NetDvrIpmismatch = 55;//IP��ַ��ƥ��
		public const int NetDvrMacmismatch = 56;//MAC��ַ��ƥ��
		public const int NetDvrUpgradelangmismatch = 57;//�����ļ����Բ�ƥ��
		public const int NetDvrMaxPlayerport = 58;//������·���ﵽ���
		public const int NetDvrNospacebackup = 59;//�����豸��û���㹻�ռ���б���
		public const int NetDvrNodevicebackup = 60;//û���ҵ�ָ���ı����豸
		public const int NetDvrPictureBitsError = 61;//ͼ����λ����������24ɫ
		public const int NetDvrPictureDimensionError = 62;//ͼƬ��*���ޣ� ��128*256
		public const int NetDvrPictureSizError = 63;//ͼƬ��С���ޣ���100K
		public const int NetDvrLoadplayersdkfailed = 64;//���뵱ǰĿ¼��Player Sdk����
		public const int NetDvrLoadplayersdkprocError = 65;//�Ҳ���Player Sdk��ĳ���������
		public const int NetDvrLoaddssdkfailed = 66;//���뵱ǰĿ¼��DSsdk����
		public const int NetDvrLoaddssdkprocError = 67;//�Ҳ���DsSdk��ĳ���������
		public const int NetDvrDssdkError = 68;//����Ӳ�����DsSdk��ĳ������ʧ��
		public const int NetDvrVoicemonopolize = 69;//��������ռ
		public const int NetDvrJoinmulticastfailed = 70;//����ಥ��ʧ��
		public const int NetDvrCreatedirError = 71;//������־�ļ�Ŀ¼ʧ��
		public const int NetDvrBindsocketError = 72;//���׽���ʧ��
		public const int NetDvrSocketcloseError = 73;//socket�����жϣ��˴���ͨ�������������жϻ�Ŀ�ĵز��ɴ�
		public const int NetDvrUseridIsusing = 74;//ע��ʱ�û�ID���ڽ���ĳ����
		public const int NetDvrSocketlistenError = 75;//����ʧ��
		public const int NetDvrProgramException = 76;//�����쳣
		public const int NetDvrWritefileFailed = 77;//д�ļ�ʧ��
		public const int NetDvrFormatReadonly = 78;//��ֹ��ʽ��ֻ��Ӳ��
		public const int NetDvrWithsameusername = 79;//�û����ýṹ�д�����ͬ���û���
		public const int NetDvrDevicetypeError = 80;//�������ʱ�豸�ͺŲ�ƥ��
		public const int NetDvrLanguageError = 81;//�������ʱ���Բ�ƥ��
		public const int NetDvrParaversionError = 82;//�������ʱ����汾��ƥ��
		public const int NetDvrIpchanNotalive = 83; //Ԥ��ʱ���IPͨ��������
		public const int NetDvrRtspSdkError = 84;//���ظ���IPCͨѶ��StreamTransClient.dllʧ��
		public const int NetDvrConvertSdkError = 85;//����ת���ʧ��
		public const int NetDvrIpcCountOverflow = 86;//��������ip����ͨ����

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
		/*******************ȫ�ִ����� end**********************/

		/*************************************************
		NET_DVR_IsSupport()����ֵ
		1��9λ�ֱ��ʾ������Ϣ��λ����TRUE)��ʾ֧�֣�
		**************************************************/
		public const int NetDvrSupportDdraw = 1;//֧��DIRECTDRAW�������֧�֣��򲥷������ܹ���
		public const int NetDvrSupportBlt = 2;//�Կ�֧��BLT�����������֧�֣��򲥷������ܹ���
		public const int NetDvrSupportBltfourcc = 4;//�Կ�BLT֧����ɫת���������֧�֣��������������������RGBת��
		public const int NetDvrSupportBltshrinkx = 8;//�Կ�BLT֧��X����С�������֧�֣�ϵͳ�����������ת��
		public const int NetDvrSupportBltshrinky = 16;//�Կ�BLT֧��Y����С�������֧�֣�ϵͳ�����������ת��
		public const int NetDvrSupportBltstretchx = 32;//�Կ�BLT֧��X��Ŵ������֧�֣�ϵͳ�����������ת��
		public const int NetDvrSupportBltstretchy = 64;//�Կ�BLT֧��Y��Ŵ������֧�֣�ϵͳ�����������ת��
		public const int NetDvrSupportSse = 128;//CPU֧��SSEָ�Intel Pentium3����֧��SSEָ��
		public const int NetDvrSupportMmx = 256;//CPU֧��MMXָ���Intel Pentium3����֧��SSEָ��

		/**********************��̨�������� begin*************************/
		public const int LightPwron = 2;// ��ͨ�ƹ��Դ
		public const int WiperPwron = 3;// ��ͨ��ˢ���� 
		public const int FanPwron = 4;// ��ͨ���ȿ���
		public const int HeaterPwron = 5;// ��ͨ����������
		public const int AuxPwron1 = 6;// ��ͨ�����豸����
		public const int AuxPwron2 = 7;// ��ͨ�����豸���� 
		public const int SetPreset = 8;// ����Ԥ�õ� 
		public const int ClePreset = 9;// ���Ԥ�õ� 

		public const int ZoomIn = 11;// �������ٶ�SS���(���ʱ��)
		public const int ZoomOut = 12;// �������ٶ�SS��С(���ʱ�С)
		public const int FocusNear = 13;// �������ٶ�SSǰ�� 
		public const int FocusFar = 14;// �������ٶ�SS���
		public const int IrisOpen = 15;// ��Ȧ���ٶ�SS����
		public const int IrisClose = 16;// ��Ȧ���ٶ�SS��С 

		public const int TiltUp = 21;/* ��̨��SS���ٶ����� */
		public const int TiltDown = 22;/* ��̨��SS���ٶ��¸� */
		public const int PanLeft = 23;/* ��̨��SS���ٶ���ת */
		public const int PanRight = 24;/* ��̨��SS���ٶ���ת */
		public const int UpLeft = 25;/* ��̨��SS���ٶ���������ת */
		public const int UpRight = 26;/* ��̨��SS���ٶ���������ת */
		public const int DownLeft = 27;/* ��̨��SS���ٶ��¸�����ת */
		public const int DownRight = 28;/* ��̨��SS���ٶ��¸�����ת */
		public const int PanAuto = 29;/* ��̨��SS���ٶ������Զ�ɨ�� */

		public const int FillPreSeq = 30;/* ��Ԥ�õ����Ѳ������ */
		public const int SetSeqDwell = 31;/* ����Ѳ����ͣ��ʱ�� */
		public const int SetSeqSpeed = 32;/* ����Ѳ���ٶ� */
		public const int ClePreSeq = 33;/* ��Ԥ�õ��Ѳ��������ɾ�� */
		public const int StaMemCruise = 34;/* ��ʼ��¼�켣 */
		public const int StoMemCruise = 35;/* ֹͣ��¼�켣 */
		public const int RunCruise = 36;/* ��ʼ�켣 */
		public const int RunSeq = 37;/* ��ʼѲ�� */
		public const int StopSeq = 38;/* ֹͣѲ�� */
		public const int GotoPreset = 39;/* ����ת��Ԥ�õ� */
		/**********************��̨�������� end*************************/

		/*************************************************
		�ط�ʱ���ſ�������궨�� 
		NET_DVR_PlayBackControl
		NET_DVR_PlayControlLocDisplay
		NET_DVR_DecPlayBackCtrl�ĺ궨��
		����֧�ֲ鿴����˵���ʹ���
		**************************************************/
		public const int NetDvrPlaystart = 1;//��ʼ����
		public const int NetDvrPlaystop = 2;//ֹͣ����
		public const int NetDvrPlaypause = 3;//��ͣ����
		public const int NetDvrPlayrestart = 4;//�ָ�����
		public const int NetDvrPlayfast = 5;//���
		public const int NetDvrPlayslow = 6;//����
		public const int NetDvrPlaynormal = 7;//�����ٶ�
		public const int NetDvrPlayframe = 8;//��֡��
		public const int NetDvrPlaystartaudio = 9;//������
		public const int NetDvrPlaystopaudio = 10;//�ر�����
		public const int NetDvrPlayaudiovolume = 11;//��������
		public const int NetDvrPlaysetpos = 12;//�ı��ļ��طŵĽ���
		public const int NetDvrPlaygetpos = 13;//��ȡ�ļ��طŵĽ���
		public const int NetDvrPlaygettime = 14;//��ȡ��ǰ�Ѿ����ŵ�ʱ��(���ļ��طŵ�ʱ����Ч)
		public const int NetDvrPlaygetframe = 15;//��ȡ��ǰ�Ѿ����ŵ�֡��(���ļ��طŵ�ʱ����Ч)
		public const int NetDvrGettotalframes = 16;//��ȡ��ǰ�����ļ��ܵ�֡��(���ļ��طŵ�ʱ����Ч)
		public const int NetDvrGettotaltime = 17;//��ȡ��ǰ�����ļ��ܵ�ʱ��(���ļ��طŵ�ʱ����Ч)
		public const int NetDvrThrowbframe = 20;//��B֡
		public const int NetDvrSetspeed = 24;//���������ٶ�
		public const int NetDvrKeepalive = 25;//�������豸������(����ص�����������2�뷢��һ��)
		public const int NetDvrPlaysettime = 26;//������ʱ�䶨λ
		public const int NetDvrPlaygettotallen = 27;//��ȡ��ʱ��طŶ�Ӧʱ����ڵ������ļ����ܳ���
		public const int NetDvrPlayForward = 29;//�����л�Ϊ����
		public const int NetDvrPlayReverse = 30;//�����л�Ϊ����
		public const int NetDvrSetTransType = 32;//����ת��װ����
		public const int NetDvrPlayConvert = 33;//�����л�Ϊ����

		//Զ�̰����������£�
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

		public const int KeyPtzAp1Start = KeyCodeEdit;/* ��Ȧ+ */
		public const int KeyPtzAp1Stop = 36;

		public const int KeyPtzAp2Start = KeyCodePan;/* ��Ȧ- */
		public const int KeyPtzAp2Stop = 37;

		public const int KeyPtzFocus1Start = KeyCodeA;/* �۽�+ */
		public const int KeyPtzFocus1Stop = 38;

		public const int KeyPtzFocus2Start = KeyCodeM;/* �۽�- */
		public const int KeyPtzFocus2Stop = 39;

		public const int KeyPtzB1Start = 40;/* �䱶+ */
		public const int KeyPtzB1Stop = 41;

		public const int KeyPtzB2Start = 42;/* �䱶- */
		public const int KeyPtzB2Stop = 43;

		//9000����
		public const int KeyCode11 = 44;
		public const int KeyCode12 = 45;
		public const int KeyCode13 = 46;
		public const int KeyCode14 = 47;
		public const int KeyCode15 = 48;
		public const int KeyCode16 = 49;

		/*************************������������ begin*******************************/
		//����NET_DVR_SetDVRConfig��NET_DVR_GetDVRConfig,ע�����Ӧ�����ýṹ
		public const int NetDvrGetDevicecfg = 100;//��ȡ�豸����
		public const int NetDvrSetDevicecfg = 101;//�����豸����
		public const int NetDvrGetNetcfg = 102;//��ȡ�������
		public const int NetDvrSetNetcfg = 103;//�����������
		public const int NetDvrGetPiccfg = 104;//��ȡͼ�����
		public const int NetDvrSetPiccfg = 105;//����ͼ�����
		public const int NetDvrGetCompresscfg = 106;//��ȡѹ������
		public const int NetDvrSetCompresscfg = 107;//����ѹ������
		public const int NetDvrGetRecordcfg = 108;//��ȡ¼��ʱ�����
		public const int NetDvrSetRecordcfg = 109;//����¼��ʱ�����
		public const int NetDvrGetDecodercfg = 110;//��ȡ����������
		public const int NetDvrSetDecodercfg = 111;//���ý���������
		public const int NetDvrGetRs232Cfg = 112;//��ȡ232���ڲ���
		public const int NetDvrSetRs232Cfg = 113;//����232���ڲ���
		public const int NetDvrGetAlarmincfg = 114;//��ȡ�����������
		public const int NetDvrSetAlarmincfg = 115;//���ñ����������
		public const int NetDvrGetAlarmoutcfg = 116;//��ȡ�����������
		public const int NetDvrSetAlarmoutcfg = 117;//���ñ����������
		public const int NetDvrGetTimecfg = 118;//��ȡDVRʱ��
		public const int NetDvrSetTimecfg = 119;//����DVRʱ��
		public const int NetDvrGetPreviewcfg = 120;//��ȡԤ������
		public const int NetDvrSetPreviewcfg = 121;//����Ԥ������
		public const int NetDvrGetVideooutcfg = 122;//��ȡ��Ƶ�������
		public const int NetDvrSetVideooutcfg = 123;//������Ƶ�������
		public const int NetDvrGetUsercfg = 124;//��ȡ�û�����
		public const int NetDvrSetUsercfg = 125;//�����û�����
		public const int NetDvrGetExceptioncfg = 126;//��ȡ�쳣����
		public const int NetDvrSetExceptioncfg = 127;//�����쳣����
		public const int NetDvrGetZoneanddst = 128;//��ȡʱ������ʱ�Ʋ���
		public const int NetDvrSetZoneanddst = 129;//����ʱ������ʱ�Ʋ���
		public const int NetDvrGetShowstring = 130;//��ȡ�����ַ�����
		public const int NetDvrSetShowstring = 131;//���õ����ַ�����
		public const int NetDvrGetEventcompcfg = 132;//��ȡ�¼�����¼�����
		public const int NetDvrSetEventcompcfg = 133;//�����¼�����¼�����

		public const int NetDvrGetAuxoutcfg = 140;//��ȡ�������������������(HS�豸�������2006-02-28)
		public const int NetDvrSetAuxoutcfg = 141;//���ñ������������������(HS�豸�������2006-02-28)
		public const int NetDvrGetPreviewcfgAux = 142;//��ȡ-sϵ��˫���Ԥ������(-sϵ��˫���2006-04-13)
		public const int NetDvrSetPreviewcfgAux = 143;//����-sϵ��˫���Ԥ������(-sϵ��˫���2006-04-13)

		public const int NetDvrGetPiccfgEx = 200;//��ȡͼ�����(SDK_V14��չ����)
		public const int NetDvrSetPiccfgEx = 201;//����ͼ�����(SDK_V14��չ����)
		public const int NetDvrGetUsercfgEx = 202;//��ȡ�û�����(SDK_V15��չ����)
		public const int NetDvrSetUsercfgEx = 203;//�����û�����(SDK_V15��չ����)
		public const int NetDvrGetCompresscfgEx = 204;//��ȡѹ������(SDK_V15��չ����2006-05-15)
		public const int NetDvrSetCompresscfgEx = 205;//����ѹ������(SDK_V15��չ����2006-05-15)

		public const int NetDvrGetNetappcfg = 222;//��ȡ����Ӧ�ò��� NTP/DDNS/EMAIL
		public const int NetDvrSetNetappcfg = 223;//��������Ӧ�ò��� NTP/DDNS/EMAIL
		public const int NetDvrGetNtpcfg = 224;//��ȡ����Ӧ�ò��� NTP
		public const int NetDvrSetNtpcfg = 225;//��������Ӧ�ò��� NTP
		public const int NetDvrGetDdnscfg = 226;//��ȡ����Ӧ�ò��� DDNS
		public const int NetDvrSetDdnscfg = 227;//��������Ӧ�ò��� DDNS
		//��ӦNET_DVR_EMAILPARA
		public const int NetDvrGetEmailcfg = 228;//��ȡ����Ӧ�ò��� EMAIL
		public const int NetDvrSetEmailcfg = 229;//��������Ӧ�ò��� EMAIL

		public const int NetDvrGetNfscfg = 230;/* NFS disk config */
		public const int NetDvrSetNfscfg = 231;/* NFS disk config */

		public const int NetDvrGetShowstringEx = 238;//��ȡ�����ַ�������չ(֧��8���ַ�)
		public const int NetDvrSetShowstringEx = 239;//���õ����ַ�������չ(֧��8���ַ�)
		public const int NetDvrGetNetcfgOther = 244;//��ȡ�������
		public const int NetDvrSetNetcfgOther = 245;//�����������

		//��ӦNET_DVR_EMAILCFG�ṹ
		public const int NetDvrGetEmailparacfg = 250;//Get EMAIL parameters
		public const int NetDvrSetEmailparacfg = 251;//Setup EMAIL parameters

		public const int NetDvrGetDdnscfgEx = 274;//��ȡ��չDDNS����
		public const int NetDvrSetDdnscfgEx = 275;//������չDDNS����

		public const int NetDvrSetPtzpos = 292;//��̨����PTZλ��
		public const int NetDvrGetPtzpos = 293;//��̨��ȡPTZλ��
		public const int NetDvrGetPtzscope = 294;//��̨��ȡPTZ��Χ

		public const int NetDvrGetApInfoList = 305;//��ȡ����������Դ����
		public const int NetDvrSetWifiCfg = 306;//����IP����豸���߲���
		public const int NetDvrGetWifiCfg = 307;//��ȡIP����豸���߲���
		public const int NetDvrSetWifiWorkmode = 308;//����IP����豸���ڹ���ģʽ����
		public const int NetDvrGetWifiWorkmode = 309;//��ȡIP����豸���ڹ���ģʽ���� 
		public const int NetDvrGetWifiStatus = 310;	//��ȡ�豸��ǰwifi����״̬
		/***************************DS9000��������(_V30) begin *****************************/
		//����(NET_DVR_NETCFG_V30�ṹ)
		public const int NetDvrGetNetcfgV30 = 1000;//��ȡ�������
		public const int NetDvrSetNetcfgV30 = 1001;//�����������

		//ͼ��(NET_DVR_PICCFG_V30�ṹ)
		public const int NetDvrGetPiccfgV30 = 1002;//��ȡͼ�����
		public const int NetDvrSetPiccfgV30 = 1003;//����ͼ�����

		//ͼ��(NET_DVR_PICCFG_V40�ṹ)
		public const int NetDvrGetPiccfgV40 = 6179;//��ȡͼ�����V40��չ
		public const int NetDvrSetPiccfgV40 = 6180;//����ͼ�����V40��չ

		//¼��ʱ��(NET_DVR_RECORD_V30�ṹ)
		public const int NetDvrGetRecordcfgV30 = 1004;//��ȡ¼�����
		public const int NetDvrSetRecordcfgV30 = 1005;//����¼�����

		//�û�(NET_DVR_USER_V30�ṹ)
		public const int NetDvrGetUsercfgV30 = 1006;//��ȡ�û�����
		public const int NetDvrSetUsercfgV30 = 1007;//�����û�����

		//9000DDNS��������(NET_DVR_DDNSPARA_V30�ṹ)
		public const int NetDvrGetDdnscfgV30 = 1010;//��ȡDDNS(9000��չ)
		public const int NetDvrSetDdnscfgV30 = 1011;//����DDNS(9000��չ)

		//EMAIL����(NET_DVR_EMAILCFG_V30�ṹ)
		public const int NetDvrGetEmailcfgV30 = 1012;//��ȡEMAIL���� 
		public const int NetDvrSetEmailcfgV30 = 1013;//����EMAIL���� 

		//Ѳ������ (NET_DVR_CRUISE_PARA�ṹ)
		public const int NetDvrGetCruise = 1020;
		public const int NetDvrSetCruise = 1021;

		//��������ṹ���� (NET_DVR_ALARMINCFG_V30�ṹ)
		public const int NetDvrGetAlarmincfgV30 = 1024;
		public const int NetDvrSetAlarmincfgV30 = 1025;

		//��������ṹ���� (NET_DVR_ALARMOUTCFG_V30�ṹ)
		public const int NetDvrGetAlarmoutcfgV30 = 1026;
		public const int NetDvrSetAlarmoutcfgV30 = 1027;

		//��Ƶ����ṹ���� (NET_DVR_VIDEOOUT_V30�ṹ)
		public const int NetDvrGetVideooutcfgV30 = 1028;
		public const int NetDvrSetVideooutcfgV30 = 1029;

		//�����ַ��ṹ���� (NET_DVR_SHOWSTRING_V30�ṹ)
		public const int NetDvrGetShowstringV30 = 1030;
		public const int NetDvrSetShowstringV30 = 1031;

		//�쳣�ṹ���� (NET_DVR_EXCEPTION_V30�ṹ)
		public const int NetDvrGetExceptioncfgV30 = 1034;
		public const int NetDvrSetExceptioncfgV30 = 1035;

		//����232�ṹ���� (NET_DVR_RS232CFG_V30�ṹ)
		public const int NetDvrGetRs232CfgV30 = 1036;
		public const int NetDvrSetRs232CfgV30 = 1037;

		//����Ӳ�̽���ṹ���� (NET_DVR_NET_DISKCFG�ṹ)
		public const int NetDvrGetNetDiskcfg = 1038;//����Ӳ�̽����ȡ
		public const int NetDvrSetNetDiskcfg = 1039;//����Ӳ�̽�������

		//ѹ������ (NET_DVR_COMPRESSIONCFG_V30�ṹ)
		public const int NetDvrGetCompresscfgV30 = 1040;
		public const int NetDvrSetCompresscfgV30 = 1041;

		//��ȡ485���������� (NET_DVR_DECODERCFG_V30�ṹ)
		public const int NetDvrGetDecodercfgV30 = 1042;//��ȡ����������
		public const int NetDvrSetDecodercfgV30 = 1043;//���ý���������

		//��ȡԤ������ (NET_DVR_PREVIEWCFG_V30�ṹ)
		public const int NetDvrGetPreviewcfgV30 = 1044;//��ȡԤ������
		public const int NetDvrSetPreviewcfgV30 = 1045;//����Ԥ������

		//����Ԥ������ (NET_DVR_PREVIEWCFG_AUX_V30�ṹ)
		public const int NetDvrGetPreviewcfgAuxV30 = 1046;//��ȡ����Ԥ������
		public const int NetDvrSetPreviewcfgAuxV30 = 1047;//���ø���Ԥ������

		//IP�������ò��� ��NET_DVR_IPPARACFG�ṹ��
		public const int NetDvrGetIpparacfg = 1048; //��ȡIP����������Ϣ 
		public const int NetDvrSetIpparacfg = 1049;//����IP����������Ϣ

		//IP�������ò��� ��NET_DVR_IPPARACFG_V40�ṹ��
		public const int NetDvrGetIpparacfgV40 = 1062; //��ȡIP����������Ϣ 
		public const int NetDvrSetIpparacfgV40 = 1063;//����IP����������Ϣ

		//IP��������������ò��� ��NET_DVR_IPALARMINCFG�ṹ��
		public const int NetDvrGetIpalarmincfg = 1050; //��ȡIP�����������������Ϣ 
		public const int NetDvrSetIpalarmincfg = 1051; //����IP�����������������Ϣ

		//IP��������������ò��� ��NET_DVR_IPALARMOUTCFG�ṹ��
		public const int NetDvrGetIpalarmoutcfg = 1052;//��ȡIP�����������������Ϣ 
		public const int NetDvrSetIpalarmoutcfg = 1053;//����IP�����������������Ϣ

		//Ӳ�̹���Ĳ�����ȡ (NET_DVR_HDCFG�ṹ)
		public const int NetDvrGetHdcfg = 1054;//��ȡӲ�̹������ò���
		public const int NetDvrSetHdcfg = 1055;//����Ӳ�̹������ò���

		//�������Ĳ�����ȡ (NET_DVR_HDGROUP_CFG�ṹ)
		public const int NetDvrGetHdgroupCfg = 1056;//��ȡ����������ò���
		public const int NetDvrSetHdgroupCfg = 1057;//��������������ò���

		//�豸������������(NET_DVR_COMPRESSION_AUDIO�ṹ)
		public const int NetDvrGetCompresscfgAud = 1058;//��ȡ�豸�����Խ��������
		public const int NetDvrSetCompresscfgAud = 1059;//�����豸�����Խ��������

		//IP�������ò��� ��NET_DVR_IPPARACFG_V31�ṹ��
		public const int NetDvrGetIpparacfgV31 = 1060;//��ȡIP����������Ϣ 
		public const int NetDvrSetIpparacfgV31 = 1061; //����IP����������Ϣ

		//�豸�������� ��NET_DVR_DEVICECFG_V40�ṹ��
		public const int NetDvrGetDevicecfgV40 = 1100;//��ȡ�豸����
		public const int NetDvrSetDevicecfgV40 = 1101;//�����豸����

		//����������(NET_DVR_NETCFG_MULTI�ṹ)
		public const int NetDvrGetNetcfgMulti = 1161;
		public const int NetDvrSetNetcfgMulti = 1162;

		//BONDING����(NET_DVR_NETWORK_BONDING�ṹ)
		public const int NetDvrGetNetworkBonding = 1254;
		public const int NetDvrSetNetworkBonding = 1255;

		//NATӳ�����ò��� ��NET_DVR_NAT_CFG�ṹ��
		public const int NetDvrGetNatCfg = 6111;    //��ȡNATӳ�����
		public const int NetDvrSetNatCfg = 6112;    //����NATӳ�����  
		/*************************������������ end*******************************/

		/************************DVR��־ begin***************************/
		/* ���� */
		//������
		public const int MajorAlarm = 1;
		//������
		public const int MinorAlarmIn = 1;/* �������� */
		public const int MinorAlarmOut = 2;/* ������� */
		public const int MinorMotdetStart = 3; /* �ƶ���ⱨ����ʼ */
		public const int MinorMotdetStop = 4; /* �ƶ���ⱨ������ */
		public const int MinorHideAlarmStart = 5;/* �ڵ�������ʼ */
		public const int MinorHideAlarmStop = 6;/* �ڵ��������� */
		public const int MinorVcaAlarmStart = 7;/*���ܱ�����ʼ*/
		public const int MinorVcaAlarmStop = 8;/*���ܱ���ֹͣ*/

		/* �쳣 */
		//������
		public const int MajorException = 2;
		//������
		public const int MinorViLost = 33;/* ��Ƶ�źŶ�ʧ */
		public const int MinorIllegalAccess = 34;/* �Ƿ����� */
		public const int MinorHdFull = 35;/* Ӳ���� */
		public const int MinorHdError = 36;/* Ӳ�̴��� */
		public const int MinorDcdLost = 37;/* MODEM ����(������ʹ��) */
		public const int MinorIpConflict = 38;/* IP��ַ��ͻ */
		public const int MinorNetBroken = 39;/* ����Ͽ�*/
		public const int MinorRecError = 40;/* ¼����� */
		public const int MinorIpcNoLink = 41;/* IPC�����쳣 */
		public const int MinorViException = 42;/* ��Ƶ�����쳣(ֻ���ģ��ͨ��) */
		public const int MinorIpcIpConflict = 43;/*ipc ip ��ַ ��ͻ*/

		//��Ƶ�ۺ�ƽ̨
		public const int MinorFanabnormal = 49;/* ��Ƶ�ۺ�ƽ̨������״̬�쳣 */
		public const int MinorFanresume = 50;/* ��Ƶ�ۺ�ƽ̨������״̬�ָ����� */
		public const int MinorSubsystemAbnormalreboot = 51;/* ��Ƶ�ۺ�ƽ̨��6467�쳣���� */
		public const int MinorMatrixStartbuzzer = 52;/* ��Ƶ�ۺ�ƽ̨��dm6467�쳣������������ */

		/* ���� */
		//������
		public const int MajorOperation = 3;
		//������
		public const int MinorStartDvr = 65;/* ���� */
		public const int MinorStopDvr = 66;/* �ػ� */
		public const int MinorStopAbnormal = 67;/* �쳣�ػ� */
		public const int MinorRebootDvr = 68;/*���������豸*/

		public const int MinorLocalLogin = 80;/* ���ص�½ */
		public const int MinorLocalLogout = 81;/* ����ע����½ */
		public const int MinorLocalCfgParm = 82;/* �������ò��� */
		public const int MinorLocalPlaybyfile = 83;/* ���ذ��ļ��طŻ����� */
		public const int MinorLocalPlaybytime = 84;/* ���ذ�ʱ��طŻ�����*/
		public const int MinorLocalStartRec = 85;/* ���ؿ�ʼ¼�� */
		public const int MinorLocalStopRec = 86;/* ����ֹͣ¼�� */
		public const int MinorLocalPtzctrl = 87;/* ������̨���� */
		public const int MinorLocalPreview = 88;/* ����Ԥ�� (������ʹ��)*/
		public const int MinorLocalModifyTime = 89;/* �����޸�ʱ��(������ʹ��) */
		public const int MinorLocalUpgrade = 90;/* �������� */
		public const int MinorLocalRecfileOutput = 91;/* ���ر���¼���ļ� */
		public const int MinorLocalFormatHdd = 92;/* ���س�ʼ��Ӳ�� */
		public const int MinorLocalCfgfileOutput = 93;/* �������������ļ� */
		public const int MinorLocalCfgfileInput = 94;/* ���뱾�������ļ� */
		public const int MinorLocalCopyfile = 95;/* ���ر����ļ� */
		public const int MinorLocalLockfile = 96;/* ��������¼���ļ� */
		public const int MinorLocalUnlockfile = 97;/* ���ؽ���¼���ļ� */
		public const int MinorLocalDvrAlarm = 98;/* �����ֶ�����ʹ�������*/
		public const int MinorIpcAdd = 99;/* �������IPC */
		public const int MinorIpcDel = 100;/* ����ɾ��IPC */
		public const int MinorIpcSet = 101;/* ��������IPC */
		public const int MinorLocalStartBackup = 102;/* ���ؿ�ʼ���� */
		public const int MinorLocalStopBackup = 103;/* ����ֹͣ����*/
		public const int MinorLocalCopyfileStartTime = 104;/* ���ر��ݿ�ʼʱ��*/
		public const int MinorLocalCopyfileEndTime = 105;/* ���ر��ݽ���ʱ��*/
		public const int MinorLocalAddNas = 106;/*�����������Ӳ��*/
		public const int MinorLocalDelNas = 107;/* ����ɾ��nas��*/
		public const int MinorLocalSetNas = 108;/* ��������nas��*/

		public const int MinorRemoteLogin = 112;/* Զ�̵�¼ */
		public const int MinorRemoteLogout = 113;/* Զ��ע����½ */
		public const int MinorRemoteStartRec = 114;/* Զ�̿�ʼ¼�� */
		public const int MinorRemoteStopRec = 115;/* Զ��ֹͣ¼�� */
		public const int MinorStartTransChan = 116;/* ��ʼ͸������ */
		public const int MinorStopTransChan = 117;/* ֹͣ͸������ */
		public const int MinorRemoteGetParm = 118;/* Զ�̻�ȡ���� */
		public const int MinorRemoteCfgParm = 119;/* Զ�����ò��� */
		public const int MinorRemoteGetStatus = 120;/* Զ�̻�ȡ״̬ */
		public const int MinorRemoteArm = 121;/* Զ�̲��� */
		public const int MinorRemoteDisarm = 122;/* Զ�̳��� */
		public const int MinorRemoteReboot = 123;/* Զ������ */
		public const int MinorStartVt = 124;/* ��ʼ�����Խ� */
		public const int MinorStopVt = 125;/* ֹͣ�����Խ� */
		public const int MinorRemoteUpgrade = 126;/* Զ������ */
		public const int MinorRemotePlaybyfile = 127;/* Զ�̰��ļ��ط� */
		public const int MinorRemotePlaybytime = 128;/* Զ�̰�ʱ��ط� */
		public const int MinorRemotePtzctrl = 129;/* Զ����̨���� */
		public const int MinorRemoteFormatHdd = 130;/* Զ�̸�ʽ��Ӳ�� */
		public const int MinorRemoteStop = 131;/* Զ�̹ػ� */
		public const int MinorRemoteLockfile = 132;/* Զ�������ļ� */
		public const int MinorRemoteUnlockfile = 133;/* Զ�̽����ļ� */
		public const int MinorRemoteCfgfileOutput = 134;/* Զ�̵��������ļ� */
		public const int MinorRemoteCfgfileIntput = 135;/* Զ�̵��������ļ� */
		public const int MinorRemoteRecfileOutput = 136;/* Զ�̵���¼���ļ� */
		public const int MinorRemoteDvrAlarm = 137;/* Զ���ֶ�����ʹ�������*/
		public const int MinorRemoteIpcAdd = 138;/* Զ�����IPC */
		public const int MinorRemoteIpcDel = 139;/* Զ��ɾ��IPC */
		public const int MinorRemoteIpcSet = 140;/* Զ������IPC */
		public const int MinorRebootVcaLib = 141;/*�������ܿ�*/
		public const int MinorRemoteAddNas = 142;/* Զ�����nas��*/
		public const int MinorRemoteDelNas = 143;/* Զ��ɾ��nas��*/
		public const int MinorRemoteSetNas = 144;/* Զ������nas��*/

		//2009-12-16 ������Ƶ�ۺ�ƽ̨��־����
		public const int MinorSubsystemreboot = 160;/*��Ƶ�ۺ�ƽ̨��dm6467 ��������*/
		public const int MinorMatrixStarttransfervideo = 161;	/*��Ƶ�ۺ�ƽ̨�������л���ʼ����ͼ��*/
		public const int MinorMatrixStoptransfervideo = 162;	/*��Ƶ�ۺ�ƽ̨�������л�ֹͣ����ͼ��*/
		public const int MinorRemoteSetAllsubsystem = 163;	/*��Ƶ�ۺ�ƽ̨����������6467��ϵͳ��Ϣ*/
		public const int MinorRemoteGetAllsubsystem = 164;	/*��Ƶ�ۺ�ƽ̨����ȡ����6467��ϵͳ��Ϣ*/
		public const int MinorRemoteSetPlanarray = 165;	/*��Ƶ�ۺ�ƽ̨�����üƻ���ѯ��*/
		public const int MinorRemoteGetPlanarray = 166;	/*��Ƶ�ۺ�ƽ̨����ȡ�ƻ���ѯ��*/
		public const int MinorMatrixStarttransferaudio = 167;	/*��Ƶ�ۺ�ƽ̨�������л���ʼ������Ƶ*/
		public const int MinorMatrixStopransferaudio = 168;	/*��Ƶ�ۺ�ƽ̨�������л�ֹͣ������Ƶ*/
		public const int MinorLogonCodespitter = 169;	/*��Ƶ�ۺ�ƽ̨����½�����*/
		public const int MinorLogoffCodespitter = 170;	/*��Ƶ�ۺ�ƽ̨���˳������*/

		/*��־������Ϣ*/
		//������
		public const int MajorInformation = 4;/*������Ϣ*/
		//������
		public const int MinorHddInfo = 161;/*Ӳ����Ϣ*/
		public const int MinorSmartInfo = 162;/*SMART��Ϣ*/
		public const int MinorRecStart = 163;/*��ʼ¼��*/
		public const int MinorRecStop = 164;/*ֹͣ¼��*/
		public const int MinorRecOverdue = 165;/*����¼��ɾ��*/
		public const int MinorLinkStart = 166;//����ǰ���豸
		public const int MinorLinkStop = 167;//�Ͽ�ǰ���豸��
		public const int MinorNetDiskInfo = 168;//����Ӳ����Ϣ

		//����־��������ΪMAJOR_OPERATION=03��������ΪMINOR_LOCAL_CFG_PARM=0x52����MINOR_REMOTE_GET_PARM=0x76����MINOR_REMOTE_CFG_PARM=0x77ʱ��dwParaType:����������Ч���京�����£�
		public const int ParaVideoout = 1;
		public const int ParaImage = 2;
		public const int ParaEncode = 4;
		public const int ParaNetwork = 8;
		public const int ParaAlarm = 16;
		public const int ParaException = 32;
		public const int ParaDecoder = 64;/*������*/
		public const int ParaRs232 = 128;
		public const int ParaPreview = 256;
		public const int ParaSecurity = 512;
		public const int ParaDatetime = 1024;
		public const int ParaFrametype = 2048;/*֡��ʽ*/
		//vca
		public const int ParaVcaRule = 4096;//��Ϊ����
		/************************DVR��־ End***************************/


		/*******************�����ļ�����־��������ֵ*************************/
		public const int NetDvrFileSuccess = 1000;//����ļ���Ϣ
		public const int NetDvrFileNofind = 1001;//û���ļ�
		public const int NetDvrIsfinding = 1002;//���ڲ����ļ�
		public const int NetDvrNomorefile = 1003;//�����ļ�ʱû�и�����ļ�
		public const int NetDvrFileException = 1004;//�����ļ�ʱ�쳣

		/*********************�ص��������� begin************************/
		public const int CommAlarm = 0x1100;//8000������Ϣ�����ϴ�����ӦNET_DVR_ALARMINFO
		public const int CommAlarmRule = 0x1102;//��Ϊ����������Ϣ����ӦNET_VCA_RULE_ALARM
		public const int CommAlarmPdc = 0x1103;//������ͳ�Ʊ����ϴ�����ӦNET_DVR_PDC_ALRAM_INFO
		public const int CommAlarmAlarmhost = 0x1105;//���籨�����������ϴ�����ӦNET_DVR_ALARMHOST_ALARMINFO
		public const int CommAlarmFace = 0x1106;//�������ʶ�𱨾���Ϣ����ӦNET_DVR_FACEDETECT_ALARM
		public const int CommRuleInfoUpload = 0x1107;  // �¼�������Ϣ�ϴ�
		public const int CommAlarmAid = 0x1110;  //��ͨ�¼�������Ϣ
		public const int CommAlarmTps = 0x1111;  //��ͨ����ͳ�Ʊ�����Ϣ
		public const int CommUploadFacesnapResult = 0x1112;  //����ʶ�����ϴ�
		public const int CommAlarmTfs = 0x1113;  //��ͨȡ֤������Ϣ
		public const int CommAlarmTpsV41 = 0x1114;  //��ͨ����ͳ�Ʊ�����Ϣ��չ
		public const int CommAlarmAidV41 = 0x1115;  //��ͨ�¼�������Ϣ��չ
		public const int CommAlarmVqdEx =  0x1116;	 //��Ƶ������ϱ���
		public const int CommSensorValueUpload = 0x1120;  //ģ��������ʵʱ�ϴ�
		public const int CommSensorAlarm  = 0x1121;  //ģ���������ϴ�
		public const int CommSwitchAlarm   = 0x1122;	 //����������
		public const int CommAlarmhostException   =  0x1123; //�����������ϱ���
		public const int CommAlarmhostOperateeventAlarm  = 0x1124;  //�����¼������ϴ�
		public const int CommAlarmhostSafetycabinstate = 0x1125;	 //������״̬
		public const int CommAlarmhostAlarmoutstatus  = 0x1126;	 //���������/����״̬
		public const int CommAlarmhostCidAlarm 	 = 0x1127;	 //���汨���ϴ�
		public const int CommAlarmhostExternalDeviceAlarm = 0x1128;	 //������������豸�����ϴ�
		public const int CommAlarmhostDataUpload    = 0x1129;	 //���������ϴ�
		public const int CommAlarmAudioexception	 =  0x1150;	 //����������Ϣ
		public const int CommAlarmDefocus    =      0x1151;	 //�齹������Ϣ
		public const int CommAlarmButtonDownException =  0x1152;	 //��ť���±�����Ϣ
		public const int CommAlarmAlarmgps   =    0x1202; //GPS������Ϣ�ϴ�
		public const int CommTradeinfo      =  0x1500;  //ATMDVR�����ϴ�������Ϣ
		public const int CommUploadPlateResult  =   0x2800;	 //�ϴ�������Ϣ
		public const int CommItcStatusDetectResult  = 0x2810;  //ʵʱ״̬������ϴ�(���ܸ���IPC)
		public const int CommIpcAuxalarmResult  = 0x2820;  //PIR���������߱��������ȱ����ϴ�
		public const int CommUploadPictureinfo    = 0x2900;	 //�ϴ�ͼƬ��Ϣ
		public const int CommSnapMatchAlarm   = 0x2902;  //�������ȶԽ���ϴ�
		public const int CommItsPlateResult   =  0x3050;  //�ն�ͼƬ�ϴ�
		public const int CommItsTrafficCollect  = 0x3051;  //�ն�ͳ�������ϴ�
		public const int CommItsGateVehicle = 0x3052;  //����ڳ���ץ�������ϴ�
		public const int CommItsGateFace  = 0x3053 ; //���������ץ�������ϴ�
		public const int CommItsGateCostitem = 0x3054;  //����ڹ����շ���ϸ 2013-11-19
		public const int CommItsGateHandover = 0x3055 ; //����ڽ��Ӱ����� 2013-11-19
		public const int CommItsParkVehicle  = 0x3056;  //ͣ���������ϴ�
		public const int CommItsBlacklistAlarm  = 0x3057;  //�����������ϴ�
		public const int CommAlarmV30	 =  0x4000;	 //9000������Ϣ�����ϴ�
		public const int CommIpccfg	 =  0x4001;	 //9000�豸IPC�������øı䱨����Ϣ�����ϴ�
		public const int CommIpccfgV31 = 0x4002;	 //9000�豸IPC�������øı䱨����Ϣ�����ϴ���չ 9000_1.1
		public const int CommIpccfgV40 =  0x4003; // IVMS 2000 ��������� NVR IPC�������øı�ʱ������Ϣ�ϴ�
		public const int CommAlarmDevice = 0x4004;  //�豸�������ݣ�����ͨ��ֵ����256����չ
		public const int CommAlarmCvr	 =  0x4005;  //CVR 2.0.X�ⲿ��������
		public const int CommAlarmHotSpare = 0x4006;  //�ȱ��쳣������N+1ģʽ�쳣������
		public const int CommAlarmV40 = 0x4007;	//�ƶ���⣬��Ƶ��ʧ���ڵ���IO�ź����ȱ�����Ϣ�����ϴ�����������Ϊ�ɱ䳤

		public const int CommItsRoadException = 0x4500;	 //·���豸�쳣����
		public const int CommItsExternalControlAlarm = 0x4520;  //��ر���
		public const int CommScreenAlarm    =  0x5000;  //������������������
		public const int CommDvcsStateAlarm = 0x5001;  //�ֲ�ʽ���������������ϴ�
		public const int CommAlarmVqd		 = 0x6000;  //VQD���������ϴ� 
		public const int CommPushUpdateRecordInfo  = 0x6001;  //��ģʽ¼����Ϣ�ϴ�
		public const int CommDiagnosisUpload = 0x5100;  //��Ϸ�����VQD�����ϴ�

		/*************�����쳣����(��Ϣ��ʽ, �ص���ʽ(����))****************/
		public const int ExceptionExchange = 32768;//�û�����ʱ�쳣
		public const int ExceptionAudioexchange = 32769;//�����Խ��쳣
		public const int ExceptionAlarm = 32770;//�����쳣
		public const int ExceptionPreview = 32771;//����Ԥ���쳣
		public const int ExceptionSerial = 32772;//͸��ͨ���쳣
		public const int ExceptionReconnect = 32773;//Ԥ��ʱ����
		public const int ExceptionAlarmreconnect = 32774;//����ʱ����
		public const int ExceptionSerialreconnect = 32775;//͸��ͨ������
		public const int ExceptionPlayback = 32784;//�ط��쳣
		public const int ExceptionDiskfmt = 32785;//Ӳ�̸�ʽ��

		/********************Ԥ���ص�����*********************/
		public const int NetDvrSyshead = 1;//ϵͳͷ����
		public const int NetDvrStreamdata = 2;//��Ƶ�����ݣ�����������������Ƶ�ֿ�����Ƶ�����ݣ�
		public const int NetDvrAudiostreamdata = 3;//��Ƶ������
		public const int NetDvrStdVideodata = 4;//��׼��Ƶ������
		public const int NetDvrStdAudiodata = 5;//��׼��Ƶ������

		//�ص�Ԥ���е�״̬����Ϣ
		public const int NetDvrRealplayexception = 111;//Ԥ���쳣
		public const int NetDvrRealplaynetclose = 112;//Ԥ��ʱ���ӶϿ�
		public const int NetDvrRealplay5Snodata = 113;//Ԥ��5sû���յ�����
		public const int NetDvrRealplayreconnect = 114;//Ԥ������

		/********************�طŻص�����*********************/
		public const int NetDvrPlaybackover = 101;//�ط����ݲ������
		public const int NetDvrPlaybackexception = 102;//�ط��쳣
		public const int NetDvrPlaybacknetclose = 103;//�ط�ʱ�����ӶϿ�
		public const int NetDvrPlayback5Snodata = 104;//�ط�5sû���յ�����

		/*********************�ص��������� end************************/
		//�豸�ͺ�(DVR����)
		/* �豸���� */
		public const int Dvr = 1;/*����δ�����dvr���ͷ���NETRET_DVR*/
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
		public const int DvsA = 13; /* ��ATAӲ�̵�DVS */
		public const int DvrHcS = 14; /* 8000HC-S */
		public const int DvrHtS = 15;/* 8000HT-S */
		public const int DvrHfS = 16;/* 8000HF-S */
		public const int DvrHsS = 17; /* 8000HS-S */
		public const int AtmdvrS = 18;/* ATM-S */
		public const int LowcostDvr = 19;/*7000Hϵ��*/
		public const int DecMat = 20; /*��·������*/
		public const int DvrMobile = 21;/* mobile DVR */
		public const int DvrHdS = 22;   /* 8000HD-S */
		public const int DvrHdSl = 23;/* 8000HD-SL */
		public const int DvrHcSl = 24;/* 8000HC-SL */
		public const int DvrHsSt = 25;/* 8000HS_ST */
		public const int DvsHw = 26; /* 6000HW */
		public const int Ds630Xd = 27; /* ��·������ */
		public const int Ipcam = 30;/*IP �����*/
		public const int MegaIpcam = 31;/*X52MFϵ��,752MF,852MF*/
		public const int IpcamX62Mf = 32;/*X62MFϵ�пɽ���9000�豸,762MF,862MF*/
		public const int Ipdome = 40; /*IP �������*/
		public const int IpdomeMega200 = 41;/*IP 200��������*/
		public const int IpdomeMega130 = 42;/*IP 130��������*/
		public const int Ipmod = 50;/*IP ģ��*/
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
		/**********************�豸���� end***********************/

		/*************************************************
		�������ýṹ������(����_V30Ϊ9000����)
		**************************************************/
		//Уʱ�ṹ����
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

		//ʱ�����
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

		//ʱ���(�ӽṹ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSchedtime
		{
			public byte byStartHour;//��ʼʱ��
			public byte byStartMin;//��ʼʱ��
			public byte byStopHour;//����ʱ��
			public byte byStopMin;//����ʱ��
		}

		/*�豸�������쳣����ʽ*/
		public const int Noaction = 0x0;/*����Ӧ*/
		public const int Warnonmonitor = 0x1;/*�������Ͼ���*/
		public const int Warnonaudioout = 0x2;/*��������*/
		public const int Uptocenter = 0x4;/*�ϴ�����*/
		public const int Triggeralarmout = 0x8;/*�����������*/
		public const int Triggercatpic = 0x10;/*����ץͼ���ϴ�E-mail*/
		public const int SendPicFtp = 0x200;  /*ץͼ���ϴ�ftp*/        

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStructhead
		{
			public ushort wLength;  //�ṹ����
			public byte byVersion;	/*�ߵ�4λ�ֱ����ߵͰ汾���������ݰ汾�ͳ��Ƚ�����չ����ͬ�İ汾�ĳ��Ƚ�������*/
			public byte byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexceptionV41
		{
			public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/ 
			public uint dwMaxRelAlarmOutChanNum; //�����ı������ͨ������ֻ�������֧����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //��������ͨ��      
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexceptionV40
		{
			public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/ 
			public uint dwMaxRelAlarmOutChanNum; //�����ı������ͨ������ֻ�������֧����
			public uint dwRelAlarmOutChanNum; //�����ı������ͨ���� ʵ��֧����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //��������ͨ��      
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //����
		}

		//�������쳣����ṹ(�ӽṹ)(�ദʹ��)(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexceptionV30
		{
			public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelAlarmOut;//�������������ͨ��,�������������,Ϊ1��ʾ���������
		}

		//�������쳣����ṹ(�ӽṹ)(�ദʹ��)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHandleexception
		{
			public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: Jpegץͼ���ϴ�EMail*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmout, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelAlarmOut;//�������������ͨ��,�������������,Ϊ1��ʾ���������
		}

		//DVR�豸����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevicecfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRName;//DVR����
			public uint dwDVRID;//DVR ID,����ң���� //V1.4(0-99), V1.5(0-255)
			public uint dwRecycleRecord;//�Ƿ�ѭ��¼��,0:����; 1:��
			//���²��ɸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//���к�
			public uint dwSoftwareVersion;//����汾��,��16λ�����汾,��16λ�Ǵΰ汾
			public uint dwSoftwareBuildDate;//�����������,0xYYYYMMDD
			public uint dwDSPSoftwareVersion;//DSP����汾,��16λ�����汾,��16λ�Ǵΰ汾
			public uint dwDSPSoftwareBuildDate;// DSP�����������,0xYYYYMMDD
			public uint dwPanelVersion;// ǰ���汾,��16λ�����汾,��16λ�Ǵΰ汾
			public uint dwHardwareVersion;// Ӳ���汾,��16λ�����汾,��16λ�Ǵΰ汾
			public byte byAlarmInPortNum;//DVR�����������
			public byte byAlarmOutPortNum;//DVR�����������
			public byte byRS232Num;//DVR 232���ڸ���
			public byte byRS485Num;//DVR 485���ڸ���
			public byte byNetworkPortNum;//����ڸ���
			public byte byDiskCtrlNum;//DVR Ӳ�̿���������
			public byte byDiskNum;//DVR Ӳ�̸���
			public byte byDVRType;//DVR����, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;//DVR ͨ������
			public byte byStartChan;//��ʼͨ����,����DVS-1,DVR - 1
			public byte byDecordChans;//DVR ����·��
			public byte byVGANum;//VGA�ڵĸ���
			public byte byUSBNum;//USB�ڵĸ���
			public byte byAuxoutNum;//���ڵĸ���
			public byte byAudioNum;//�����ڵĸ���
			public byte byIPChanNum;//�������ͨ����
		}

		/*IP��ַ*/
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

		/*�������ݽṹ(�ӽṹ)(9000��չ)*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEthernetV30
		{
			public NetDvrIpaddr struDVRIP;//DVR IP��ַ
			public NetDvrIpaddr struDVRIPMask;//DVR IP��ַ����
			public uint dwNetInterface;//����ӿڣ�1-10MBase-T��2-10MBase-Tȫ˫����3-100MBase-TX��4-100Mȫ˫����5-10M/100M/1000M����Ӧ��6-1000Mȫ˫��
			public ushort wDVRPort;//�˿ں�
			public ushort wMTU;//����MTU���ã�Ĭ��1500��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;// �����ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*�������ݽṹ(�ӽṹ)*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrEthernet
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;//DVR IP��ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvripMask;//DVR IP��ַ����
			public uint dwNetInterface;//����ӿ� 1-10MBase-T 2-10MBase-Tȫ˫�� 3-100MBase-TX 4-100Mȫ˫�� 5-10M/100M����Ӧ
			public ushort wDVRPort;//�˿ں�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;//�������������ַ
		}

		//pppoe�ṹ
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPppoecfg
		{
			public uint dwPPPOE;//0-������,1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPPPoEUser;//PPPoE�û���
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sPPPoEPassword;// PPPoE����
			public NetDvrIpaddr struPPPoEIP;//PPPoE IP��ַ
		}

		//�������ýṹ(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNetcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEthernet, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEthernetV30[] struEtherNet;//��̫����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struRes1;/*����*/
			public NetDvrIpaddr struAlarmHostIpAddr;/* ��������IP��ַ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public ushort wAlarmHostIpPort;
			public byte byUseDhcp;
			public byte byRes3;
			public NetDvrIpaddr struDnsServer1IpAddr;/* ����������1��IP��ַ */
			public NetDvrIpaddr struDnsServer2IpAddr;/* ����������2��IP��ַ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byIpResolver;
			public ushort wIpResolverPort;
			public ushort wHttpPortNo;
			public NetDvrIpaddr struMulticastIpAddr;/* �ಥ���ַ */
			public NetDvrIpaddr struGatewayIpAddr;/* ���ص�ַ */
			public NetDvrPppoecfg struPPPoE;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��������������Ϣ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEthernetMulti
		{
			public NetDvrIpaddr struDVRIP;
			public NetDvrIpaddr struDVRIPMask;
			public uint dwNetInterface;
			public byte byCardType;  //�������ͣ�0-��ͨ������1-����������2-��������
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

		//�������������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNetcfgMulti
		{
			public uint dwSize;
			public byte byDefaultRoute;
			public byte byNetworkCardNum;
			public byte byWorkMode;   //0-��ͨ������ģʽ��1-����������ģʽ
			public byte byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNetworkCard, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEthernetMulti[] struEtherNet;//��̫����
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
			public NetDvrIpaddr struMulticastIpAddr;/* �ಥ���ַ */
			public NetDvrPppoecfg struPPPoE;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		//�������ýṹ
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrNetcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEthernet, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEthernet[] struEtherNet;/* ��̫���� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sManageHostIP;//Զ�̹���������ַ
			public ushort wManageHostPort;//Զ�̹��������˿ں�
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIPServerIP;//IPServer��������ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sMultiCastIP;//�ಥ���ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sGatewayIP;//���ص�ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sNFSIP;//NFS����IP��ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PathnameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNFSDirectory;//NFSĿ¼
			public uint dwPPPOE;//0-������,1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPPPoEUser;//PPPoE�û���
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sPPPoEPassword;// PPPoE����
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sPPPoEIP;//PPPoE IP��ַ(ֻ��)
			public ushort wHttpPort;//HTTP�˿ں�
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrSipCfg
		{
			public uint dwSize;
			public byte byEnableAutoLogin;    //ʹ���Զ�ע�ᣬ0-��ʹ�ܣ�1-ʹ��
			public byte byLoginStatus;  //ע��״̬��0-δע�ᣬ1-��ע�ᣬ�˲���ֻ�ܻ�ȡ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr stuServerIP;  //SIP������IP
			public ushort wServerPort;    //SIP�������˿�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName;  //ע���û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassWord; //ע������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNumberLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalNo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDispalyName; //�豸��ʾ����
			public ushort wLocalPort;     //���ض˿�
			public byte byLoginCycle;   //ע�����ڣ�1-99����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//IP���ӶԽ��ֻ�����
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpViewDevcfg
		{
			public uint dwSize;
			public byte byDefaultRing; //Ĭ����������Χ1-6
			public byte byRingVolume;  //������������Χ0-9
			public byte byInputVolume; //��������ֵ����Χ0-6
			public byte byOutputVolume; //�������ֵ����Χ0-9	
			public ushort wRtpPort;  //Rtp�˿�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwPreviewDelayTime; //Ԥ����ʱ���ã�0-30��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		
		//Ip���ӶԽ���Ƶ��ز�������
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpViewAudioCfg
		{
			public uint dwSize;	
			public byte byAudioEncPri1; //��Ƶ�������ȼ�1��0-OggVorbis��1-G711_U��2-G711_A�� 5-MPEG2,6-G726��7-AAC
			public byte byAudioEncPri2; //��Ƶ�������ȼ�2����sip��������֧����Ƶ����1ʱ��ʹ����Ƶ����2��0-OggVorbis��1-G711_U��2-G711_A�� 5-MPEG2,6-G726��7-AAC
			public ushort wAudioPacketLen1; //��Ƶ����1���ݰ�����
			public ushort wAudioPacketLen2; //��Ƶ����2���ݰ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		//IP�ֻ����жԽ��������ýṹ��
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrIpViewCallCfg
		{
			public uint dwSize ;
			public byte byEnableAutoResponse; //ʹ���Զ�Ӧ��,0-��ʹ�ܣ�1-ʹ��
			public byte byAudoResponseTime; //�Զ�Ӧ��ʱ�䣬0-30��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byEnableAlarmNumber1; //������������1��0-��������1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNumberLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmNumber1; //���к���1
			public byte byEnableAlarmNumber2; //������������2��0-��������1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNumberLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmNumber2; //���к���2�����к���1ʧ�᳢ܻ�Ժ��к���2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes4;
		}
		
		//ͨ��ͼ��ṹ
		//�ƶ����(�ӽṹ)(���鷽ʽ��չ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrRecordchan
		{    
			public uint dwMaxRecordChanNum;   //�豸֧�ֵ�������¼��ͨ����-ֻ��
			public uint dwCurRecordChanNum;   //��ǰʵ�������õĹ���¼��ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint dwRelRecordChan;	 /* ʵ�ʴ���¼��ͨ������ֵ��ʾ,���ý��������У����±�0 - MaxChannumV30-1��Ч������м�����0xffffffff,�������Ч*/  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //����
		}             

		//ͨ��ͼ��ṹ
		//�ƶ����(�ӽṹ)(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMotionV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 96*64, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope;/*�������,0-96λ,��ʾ64��,����96*64��С���,Ϊ1��ʾ���ƶ��������,0-��ʾ����*/
			public byte byMotionSensitive;/*�ƶ����������, 0 - 5,Խ��Խ����,oxff�ر�*/
			public byte byEnableHandleMotion;/* �Ƿ����ƶ���� 0���� 1����*/
			public byte byEnableDisplay;/* �����ƶ���������ʾ��0- ��1- �� */
			public byte reservedData;
			public NetDvrHandleexceptionV30 struMotionHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;/*����ʱ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;/* ����������¼��ͨ��*/
		}

		//�ƶ����(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotion
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope;/*�������,����22*18��С���,Ϊ1��ʾ�ĺ�����ƶ��������,0-��ʾ����*/
			public byte byMotionSensitive;/*�ƶ����������, 0 - 5,Խ��Խ����,0xff�ر�*/
			public byte byEnableHandleMotion;/* �Ƿ����ƶ���� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
			public string reservedData;
			public NetDvrHandleexception strMotionHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
		}

		//�ڵ�����(�ӽṹ)(9000��չ)  �����С704*576
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHidealarmV30
		{
			public uint dwEnableHideAlarm;/* �Ƿ������ڵ����� ,0-��,1-�������� 2-�������� 3-��������*/
			public ushort wHideAlarmAreaTopLeftX;/* �ڵ������x���� */
			public ushort wHideAlarmAreaTopLeftY;/* �ڵ������y���� */
			public ushort wHideAlarmAreaWidth;/* �ڵ�����Ŀ� */
			public ushort wHideAlarmAreaHeight;/*�ڵ�����ĸ�*/
			public NetDvrHandleexceptionV30 strHideAlarmHandleType;	/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
		}

		//�ڵ�����(�ӽṹ)  �����С704*576
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHidealarm
		{
			public uint dwEnableHideAlarm;/* �Ƿ������ڵ����� ,0-��,1-�������� 2-�������� 3-��������*/
			public ushort wHideAlarmAreaTopLeftX;/* �ڵ������x���� */
			public ushort wHideAlarmAreaTopLeftY;/* �ڵ������y���� */
			public ushort wHideAlarmAreaWidth;/* �ڵ�����Ŀ� */
			public ushort wHideAlarmAreaHeight;/*�ڵ�����ĸ�*/
			public NetDvrHandleexception strHideAlarmHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
		}

		//�źŶ�ʧ����(�ӽṹ)(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVilostV30
		{
			public byte byEnableHandleVILost;/* �Ƿ����źŶ�ʧ���� */
			public NetDvrHandleexceptionV30 strVILostHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
		}

		//�źŶ�ʧ����(�ӽṹ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVilost
		{
			public byte byEnableHandleVILost;/* �Ƿ����źŶ�ʧ���� */
			public NetDvrHandleexception strVILostHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
		}

		//�ڵ�����(�ӽṹ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShelter
		{
			public ushort wHideAreaTopLeftX;/* �ڵ������x���� */
			public ushort wHideAreaTopLeftY;/* �ڵ������y���� */
			public ushort wHideAreaWidth;/* �ڵ�����Ŀ� */
			public ushort wHideAreaHeight;/*�ڵ�����ĸ�*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrColor
		{
			public byte byBrightness;/*����,0-255*/
			public byte byContrast;/*�Աȶ�,0-255*/
			public byte bySaturation;/*���Ͷ�,0-255*/
			public byte byHue;/*ɫ��,0-255*/
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrRgbColor
		{
			public byte byRed;	 //RGB��ɫ�������еĺ�ɫ
			public byte byGreen; //RGB��ɫ�������е���ɫ
			public byte byBlue;	//RGB��ɫ�������е���ɫ
			public byte byRes;	//����
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
			public NetDvrDaytime struStartTime; //��ʼʱ��
			public NetDvrDaytime struStopTime; //����ʱ��
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDnmode
		{
			public byte byObjectSize;//ռ�Ȳ���(0~100)
			public byte byMotionSensitive; /*�ƶ����������, 0 - 5,Խ��Խ����,0xff�ر�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionMultiAreaparam
		{
			public byte byAreaNo;//������(IPC- 1~8)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetVcaRect struRect;//���������������Ϣ(����) size = 16;
			public NetDvrDnmode  struDayNightDisable;//�ر�ģʽ
			public NetDvrDnmode  struDayModeParam;//����ģʽ
			public NetDvrDnmode  struNightModeParam;//ҹ��ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionMultiArea
		{
			public byte byDayNightCtrl;//��ҹ���� 0~�ر�,1~�Զ��л�,2~��ʱ�л�(Ĭ�Ϲر�)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrScheduleDaytime struScheduleTime;//�л�ʱ��  16
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxMultiAreaNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMotionMultiAreaparam[] struMotionMultiAreaParam;//���֧��24������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionSingleArea
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64*96, ArraySubType = UnmanagedType.I1)]
			public byte[]byMotionScope;		/*�������,0-96λ,��ʾ64��,����96*64��С���,Ŀǰ��Ч����22*18,Ϊ1��ʾ���ƶ��������,0-��ʾ����*/
			public byte byMotionSensitive;			/*�ƶ����������, 0 - 5,Խ��Խ����,0xff�ر�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}


		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionModeParam
		{
			public NetDvrMotionSingleArea  struMotionSingleArea; //��ͨģʽ�µĵ�������
			public NetDvrMotionMultiArea struMotionMultiArea; //ר��ģʽ�µĶ���������	
		}

		//�ƶ����
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMotionV40
		{	
			public NetDvrMotionModeParam struMotionMode; //(5.1.0����)
			public byte byEnableHandleMotion;		/* �Ƿ����ƶ���� 0���� 1����*/ 
			public byte byEnableDisplay;	/*�����ƶ���������ʾ��0-��1-��*/
			public byte byConfigurationMode; //0~��ͨ,1~ר��(5.1.0����)
			public byte byRes1; //�����ֽ�
			/* �쳣����ʽ */
			public uint dwHandleType;        //�쳣����,�쳣����ʽ��"��"���  
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //�����ı������ͨ������ֻ�������֧������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //ʵ�ʴ����ı�������ţ���ֵ��ʾ,���ý��������У����±�0 - dwRelAlarmOut -1��Ч������м�����0xffffffff,�������Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays*MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime; /*����ʱ��*/
			/*������¼��ͨ��*/
			public uint dwMaxRecordChanNum;   //�豸֧�ֵ�������¼��ͨ����-ֻ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelRecordChan;	 /* ʵ�ʴ���¼��ͨ������ֵ��ʾ,���ý��������У����±�0 - dwRelRecordChan -1��Ч������м�����0xffffffff,�������Ч*/  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //�����ֽ�
		}

		//�ڵ�����
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrHidealarmV40
		{
			public uint dwEnableHideAlarm;  /* �Ƿ������ڵ�������0-��1-�������ȣ�2-�������ȣ�3-��������*/
			public ushort wHideAlarmAreaTopLeftX;			/* �ڵ������x���� */
			public ushort wHideAlarmAreaTopLeftY;			/* �ڵ������y���� */
			public ushort wHideAlarmAreaWidth;				/* �ڵ�����Ŀ� */
			public ushort wHideAlarmAreaHeight;				/*�ڵ�����ĸ�*/ 
			/* �źŶ�ʧ����������� */	
			public uint dwHandleType;        //�쳣����,�쳣����ʽ��"��"���  
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //�����ı������ͨ������ֻ�������֧������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; /*������������ţ���ֵ��ʾ,���ý��������У����±�0 - dwRelAlarmOut -1��Ч������м�����0xffffffff,�������Ч*/  	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays*MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime; /*����ʱ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		} 

		//�źŶ�ʧ����
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrVilostV40
		{
			public uint dwEnableVILostAlarm;				/* �Ƿ������źŶ�ʧ���� ,0-��,1-��*/	 
			/* �źŶ�ʧ����������� */	
			public uint dwHandleType;        //�쳣����,�쳣����ʽ��"��"���     
			/*0x00: ����Ӧ*/    
			/*0x01: �������Ͼ���*/    
			/*0x02: ��������*/    
			/*0x04: �ϴ�����*/    
			/*0x08: �����������*/    
			/*0x10: ����JPRGץͼ���ϴ�Email*/    
			/*0x20: �������ⱨ��������*/    
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/    
			/*0x200: ץͼ���ϴ�FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //�����ı������ͨ������ֻ�������֧������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; /*������������ţ���ֵ��ʾ,���ý��������У����±�0 - dwRelAlarmOut -1��Ч������м�����0xffffffff,�������Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays*MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime; /*����ʱ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrVicolor
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrColor[]	  struColor;/*ͼ�����(��һ����Ч��������������)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]  struHandleTime;/*����ʱ���(����)*/
		}

		//ͨ��ͼ��ṹ(V40��չ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPiccfgV40
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName; 
			public uint dwVideoFormat;	/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL  */
			public NetDvrVicolor struViColor;//	ͼ�������ʱ�������
			//��ʾͨ����
			public uint dwShowChanName; // Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ
			public ushort wShowNameTopLeftX;				/* ͨ��������ʾλ�õ�x���� */
			public ushort wShowNameTopLeftY;				/* ͨ��������ʾλ�õ�y���� */
			//��˽�ڵ�
			public uint dwEnableHide;		/* �Ƿ������ڵ� ,0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxShelternum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShelter[] struShelter;
			//OSD
			public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ
			public ushort wOSDTopLeftX;				/* OSD��x���� */
			public ushort wOSDTopLeftY;				/* OSD��y���� */
			public byte byOSDType;					/* OSD����(��Ҫ�������ո�ʽ) */
			/* 0: XXXX-XX-XX ������ */
			/* 1: XX-XX-XXXX ������ */
			/* 2: XXXX��XX��XX�� */
			/* 3: XX��XX��XXXX�� */
			/* 4: XX-XX-XXXX ������*/
			/* 5: XX��XX��XXXX�� */
			/*6: xx/xx/xxxx(��/��/��) */
			/*7: xxxx/xx/xx(��/��/��) */
			/*8: xx/xx/xxxx(��/��/��)*/
			public byte byDispWeek;				/* �Ƿ���ʾ���� */
			public byte byOSDAttrib;				/* OSD����:͸������˸ */
			/* 0: ����ʾOSD */
			/* 1: ͸������˸ */
			/* 2: ͸��������˸ */
			/* 3: ��͸������˸ */
			/* 4: ��͸��������˸ */	
			public byte byHourOSDType;				/* OSDСʱ��:0-24Сʱ��,1-12Сʱ�� */
			public byte byFontSize;      //16*16(��)/8*16(Ӣ)��1-32*32(��)/16*32(Ӣ)��2-64*64(��)/32*64(Ӣ) FOR 91ϵ��HD-SDI����DVR
			public byte byOSDColorType;	 //0-Ĭ�ϣ��ڰף���1-�Զ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrVilostV40 struVILost;  //��Ƶ�źŶ�ʧ������֧���飩
			public NetDvrVilostV40 struAULost;  /*��Ƶ�źŶ�ʧ������֧���飩*/
			public NetDvrMotionV40 struMotion;  //�ƶ���ⱨ����֧���飩
			public NetDvrHidealarmV40 struHideAlarm;  //�ڵ�������֧���飩
			public NetDvrRgbColor struOsdColor;//OSD��ɫ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ͨ��ͼ��ṹ(9000��չ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPiccfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;
			public uint dwVideoFormat;/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byReservedData;/*����*/
			//��ʾͨ����
			public uint dwShowChanName;// Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ �����С704*576
			public ushort wShowNameTopLeftX;/* ͨ��������ʾλ�õ�x���� */
			public ushort wShowNameTopLeftY;/* ͨ��������ʾλ�õ�y���� */
			//��Ƶ�źŶ�ʧ����
			public NetDvrVilostV30 struVILost;
			public NetDvrVilostV30 struRes;/*����*/
			//�ƶ����
			public NetDvrMotionV30 struMotion;
			//�ڵ�����
			public NetDvrHidealarmV30 struHideAlarm;
			//�ڵ�  �����С704*576
			public uint dwEnableHide;/* �Ƿ������ڵ� ,0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxShelternum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShelter[] struShelter;
			//OSD
			public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ �����С704*576
			public ushort wOSDTopLeftX;/* OSD��x���� */
			public ushort wOSDTopLeftY;/* OSD��y���� */
			public byte byOSDType;/* OSD����(��Ҫ�������ո�ʽ) */
			/* 0: XXXX-XX-XX ������ */
			/* 1: XX-XX-XXXX ������ */
			/* 2: XXXX��XX��XX�� */
			/* 3: XX��XX��XXXX�� */
			/* 4: XX-XX-XXXX ������*/
			/* 5: XX��XX��XXXX�� */
			public byte byDispWeek;/* �Ƿ���ʾ���� */
			public byte byOSDAttrib;/* OSD����:͸������˸ */
			/* 0: ����ʾOSD */
			/* 1: ͸��,��˸ */
			/* 2: ͸��,����˸ */
			/* 3: ��˸,��͸�� */
			/* 4: ��͸��,����˸ */
			public byte byHourOSDType;/* OSDСʱ��:0-24Сʱ��,1-12Сʱ�� */
			public byte byFontSize;//�����С��16*16(��)/8*16(Ӣ)��1-32*32(��)/16*32(Ӣ)��2-64*64(��)/32*64(Ӣ)  3-48*48(��)/24*48(Ӣ) 0xff-����Ӧ(adaptive)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ͨ��ͼ��ṹSDK_V14��չ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPiccfgEx
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;
			public uint dwVideoFormat;/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL*/
			public byte byBrightness;/*����,0-255*/
			public byte byContrast;/*�Աȶ�,0-255*/
			public byte bySaturation;/*���Ͷ�,0-255 */
			public byte byHue;/*ɫ��,0-255*/
			//��ʾͨ����
			public uint dwShowChanName;// Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ �����С704*576
			public ushort wShowNameTopLeftX;/* ͨ��������ʾλ�õ�x���� */
			public ushort wShowNameTopLeftY;/* ͨ��������ʾλ�õ�y���� */
			//�źŶ�ʧ����
			public NetDvrVilost struVILost;
			//�ƶ����
			public NetDvrMotion struMotion;
			//�ڵ�����
			public NetDvrHidealarm struHideAlarm;
			//�ڵ�  �����С704*576
			public uint dwEnableHide;/* �Ƿ������ڵ� ,0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxShelternum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShelter[] struShelter;
			//OSD
			public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ �����С704*576
			public ushort wOSDTopLeftX;/* OSD��x���� */
			public ushort wOSDTopLeftY;/* OSD��y���� */
			public byte byOSDType;/* OSD����(��Ҫ�������ո�ʽ) */
			/* 0: XXXX-XX-XX ������ */
			/* 1: XX-XX-XXXX ������ */
			/* 2: XXXX��XX��XX�� */
			/* 3: XX��XX��XXXX�� */
			/* 4: XX-XX-XXXX ������*/
			/* 5: XX��XX��XXXX�� */
			public byte byDispWeek;/* �Ƿ���ʾ���� */
			public byte byOSDAttrib;/* OSD����:͸������˸ */
			/* 0: ����ʾOSD */
			/* 1: ͸��,��˸ */
			/* 2: ͸��,����˸ */
			/* 3: ��˸,��͸�� */
			/* 4: ��͸��,����˸ */
			public byte byHourOsdType;/* OSDСʱ��:0-24Сʱ��,1-12Сʱ�� */
		}

		//ͨ��ͼ��ṹ(SDK_V13��֮ǰ�汾)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPiccfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sChanName;
			public uint dwVideoFormat;/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL*/
			public byte byBrightness;/*����,0-255*/
			public byte byContrast;/*�Աȶ�,0-255*/
			public byte bySaturation;/*���Ͷ�,0-255 */
			public byte byHue;/*ɫ��,0-255*/
			//��ʾͨ����
			public uint dwShowChanName;// Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ �����С704*576
			public ushort wShowNameTopLeftX;/* ͨ��������ʾλ�õ�x���� */
			public ushort wShowNameTopLeftY;/* ͨ��������ʾλ�õ�y���� */
			//�źŶ�ʧ����
			public NetDvrVilost struVILost;
			//�ƶ����
			public NetDvrMotion struMotion;
			//�ڵ�����
			public NetDvrHidealarm struHideAlarm;
			//�ڵ�  �����С704*576
			public uint dwEnableHide;/* �Ƿ������ڵ� ,0-��,1-��*/
			public ushort wHideAreaTopLeftX;/* �ڵ������x���� */
			public ushort wHideAreaTopLeftY;/* �ڵ������y���� */
			public ushort wHideAreaWidth;/* �ڵ�����Ŀ� */
			public ushort wHideAreaHeight;/*�ڵ�����ĸ�*/
			//OSD
			public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ �����С704*576
			public ushort wOSDTopLeftX;/* OSD��x���� */
			public ushort wOSDTopLeftY;/* OSD��y���� */
			public byte byOSDType;/* OSD����(��Ҫ�������ո�ʽ) */
			/* 0: XXXX-XX-XX ������ */
			/* 1: XX-XX-XXXX ������ */
			/* 2: XXXX��XX��XX�� */
			/* 3: XX��XX��XXXX�� */
			/* 4: XX-XX-XXXX ������*/
			/* 5: XX��XX��XXXX�� */
			public byte byDispWeek;/* �Ƿ���ʾ���� */
			public byte byOSDAttrib;/* OSD����:͸������˸ */
			/* 0: ����ʾOSD */
			/* 1: ͸��,��˸ */
			/* 2: ͸��,����˸ */
			/* 3: ��˸,��͸�� */
			/* 4: ��͸��,����˸ */
			public byte reservedData2;
		}

		//����ѹ������(�ӽṹ)(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionInfoV30
		{
			public byte byStreamType;//�������� 0-��Ƶ��, 1-������, ��ʾ�¼�ѹ������ʱ���λ��ʾ�Ƿ�����ѹ������
			public byte byResolution;//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5��������16-VGA��640*480�� 17-UXGA��1600*1200�� 18-SVGA ��800*600��19-HD720p��1280*720��20-XVGA  21-HD900p
			public byte byBitrateType;//�������� 0:������, 1:������
			public byte byPicQuality;//ͼ������ 0-��� 1-�κ� 2-�Ϻ� 3-һ�� 4-�ϲ� 5-��
			public uint dwVideoBitrate;//��Ƶ���� 0-���� 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
			// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
			//���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ��
			public uint dwVideoFrameRate;//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0�汾���¼�14-15; 15-18; 16-22;
			public ushort wIntervalFrameI;//I֡���
			//2006-08-11 ���ӵ�P֡�����ýӿڣ����Ը���ʵʱ����ʱ����
			public byte byIntervalBPFrame;//0-BBP֡; 1-BP֡; 2-��P֡
			public byte byres1; //����
			public byte byVideoEncType;//��Ƶ�������� 0 hik264;1��׼h264; 2��׼mpeg4;
			public byte byAudioEncType; //��Ƶ�������� 0��OggVorbis
			public byte byVideoEncComplexity; //��Ƶ���븴�Ӷȣ�0-�ͣ�1-�У�2��,0xfe:�Զ�����Դһ��
			public byte byEnableSvc; //0 - ������SVC���ܣ�1- ����SVC����
			public byte byFormatType; //��װ���ͣ�1-������2-RTP��װ��3-PS��װ��4-TS��װ��5-˽�У�6-FLV��7-ASF��8-3GP,9-RTP+PS�����꣺GB28181����0xff-��Ч
			public byte byAudioBitRate; //��Ƶ����0-Ĭ�ϣ�1-8Kbps, 2- 16Kbps, 3-32Kbps��4-64Kbps��5-128Kbps��6-192Kbps��(IPC5.1.0Ĭ��4-64Kbps)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;//���ﱣ����Ƶ��ѹ������
		}

		//ͨ��ѹ������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgV30
		{
			public uint dwSize;
			public NetDvrCompressionInfoV30 struNormHighRecordPara;//¼�� ��Ӧ8000����ͨ
			public NetDvrCompressionInfoV30 struRes;//���� char reserveData[28];
			public NetDvrCompressionInfoV30 struEventRecordPara;//�¼�����ѹ������
			public NetDvrCompressionInfoV30 struNetPara;//����(������)
		}

		//����ѹ������(�ӽṹ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionInfo
		{
			public byte byStreamType;//��������0-��Ƶ��,1-������,��ʾѹ������ʱ���λ��ʾ�Ƿ�����ѹ������
			public byte byResolution;//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(����ר��)
			public byte byBitrateType;//��������0:�����ʣ�1:������
			public byte byPicQuality;//ͼ������ 0-��� 1-�κ� 2-�Ϻ� 3-һ�� 4-�ϲ� 5-��
			public uint dwVideoBitrate; //��Ƶ���� 0-���� 1-16K(����) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
			// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
			//���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ(MIN-32K MAX-8192K)��
			public uint dwVideoFrameRate;//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
		}

		//ͨ��ѹ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfg
		{
			public uint dwSize;
			public NetDvrCompressionInfo struRecordPara;//¼��/�¼�����¼��
			public NetDvrCompressionInfo struNetPara;//����/����
		}

		//����ѹ������(�ӽṹ)(��չ) ����I֡���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionInfoEx
		{
			public byte byStreamType;//��������0-��Ƶ��, 1-������
			public byte byResolution;//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(����ר��)
			public byte byBitrateType;//��������0:�����ʣ�1:������
			public byte byPicQuality;//ͼ������ 0-��� 1-�κ� 2-�Ϻ� 3-һ�� 4-�ϲ� 5-��
			public uint dwVideoBitrate;//��Ƶ���� 0-���� 1-16K(����) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
			// 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
			//���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ(MIN-32K MAX-8192K)��
			public uint dwVideoFrameRate;//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0����14-15, 15-18, 16-22;
			public ushort wIntervalFrameI;//I֡���
			//2006-08-11 ���ӵ�P֡�����ýӿڣ����Ը���ʵʱ����ʱ����
			public byte byIntervalBPFrame;//0-BBP֡; 1-BP֡; 2-��P֡
			public byte byRes;
		}

		//ͨ��ѹ������(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgEx
		{
			public uint dwSize;
			public NetDvrCompressionInfoEx struRecordPara;//¼��
			public NetDvrCompressionInfoEx struNetPara;//����
		}

		//ʱ���¼���������(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrRecordsched
		{
			public NetDvrSchedtime struRecordTime;
			public byte byRecordType;//0:��ʱ¼��1:�ƶ���⣬2:����¼��3:����|������4:����&����, 5:�����, 6: ����¼��
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
			public string reservedData;
		}

		//ȫ��¼���������(�ӽṹ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordday
		{
			public ushort wAllDayRecord;/* �Ƿ�ȫ��¼�� 0-�� 1-��*/
			public byte byRecordType;/* ¼������ 0:��ʱ¼��1:�ƶ���⣬2:����¼��3:����|������4:����&���� 5:�����, 6: ����¼��*/
			public byte reservedData;
		}

		//ͨ��¼���������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordV30
		{
			public uint dwSize;
			public uint dwRecord;/*�Ƿ�¼�� 0-�� 1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordday[] struRecAllDay;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordsched[] struRecordSched;
			public uint dwRecordTime;/* ¼����ʱ���� 0-5�룬 1-20�룬 2-30�룬 3-1���ӣ� 4-2���ӣ� 5-5���ӣ� 6-10����*/
			public uint dwPreRecordTime;/* Ԥ¼ʱ�� 0-��Ԥ¼ 1-5�� 2-10�� 3-15�� 4-20�� 5-25�� 6-30�� 7-0xffffffff(������Ԥ¼) */
			public uint dwRecorderDuration;/* ¼�񱣴���ʱ�� */
			public byte byRedundancyRec;/*�Ƿ�����¼��,��Ҫ����˫���ݣ�0/1*/
			public byte byAudioRec;/*¼��ʱ����������ʱ�Ƿ��¼��Ƶ���ݣ������д˷���*/
			public byte byStreamType;  // 0:������ 1��������
			public byte byPassbackRecord;  // 0:���ش�¼�� 1���ش�¼��
			public ushort wLockDuration;  // ¼������ʱ������λСʱ 0��ʾ��������0xffff��ʾ����������¼��ε�ʱ�����������ĳ���ʱ����¼�񣬽���������
			public byte byRecordBackup;  // 0:¼�񲻴浵 1��¼��浵
			public byte bySVCLevel;	//SVC��֡���ͣ�0-���飬1-�����֮һ 2-���ķ�֮��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byReserve;
		}

		//ͨ��¼���������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecord
		{
			public uint dwSize;
			public uint dwRecord;/*�Ƿ�¼�� 0-�� 1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordday[] struRecAllDay;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordsched[] struRecordSched;
			public uint dwRecordTime;/* ¼��ʱ�䳤�� */
			public uint dwPreRecordTime;/* Ԥ¼ʱ�� 0-��Ԥ¼ 1-5�� 2-10�� 3-15�� 4-20�� 5-25�� 6-30�� 7-0xffffffff(������Ԥ¼) */
		}

		//��̨Э���ṹ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzProtocol
		{
			public uint dwType;/*����������ֵ����1��ʼ��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe;/*������������������8000�е�һ��*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PtzProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPtzProtocol[] struPtz;/*���200��PTZЭ��*/
			public uint dwPtzNum;/*��Ч��ptzЭ����Ŀ����0��ʼ(������ʱ��1)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		/***************************��̨����(end)******************************/

		//ͨ��������(��̨)��������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodercfgV30
		{
			public uint dwSize;
			public uint dwBaudRate;//������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;
			public byte byDataBit;// �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ;
			public byte byStopBit;// ֹͣλ 0��1λ��1��2λ
			public byte byParity;// У�� 0����У�飬1����У�飬2��żУ��;
			public byte byFlowcontrol;// 0���ޣ�1��������,2-Ӳ����
			public ushort wDecoderType;//����������, ��0��ʼ����ӦptzЭ���б�
			public ushort wDecoderAddress;/*��������ַ:0 - 255*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPresetV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetPreset;/* Ԥ�õ��Ƿ�����,0-û������,1-����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCruiseV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetCruise;/* Ѳ���Ƿ�����: 0-û������,1-���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTrackV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetTrack;/* �켣�Ƿ�����,0-û������,1-����*/
		}

		//ͨ��������(��̨)��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodercfg
		{
			public uint dwSize;
			public uint dwBaudRate; //������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;
			public byte byDataBit; // �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ;
			public byte byStopBit;// ֹͣλ 0��1λ��1��2λ;
			public byte byParity; // У�� 0����У�飬1����У�飬2��żУ��;
			public byte byFlowcontrol;// 0���ޣ�1��������,2-Ӳ����
			public ushort wDecoderType;//����������, 0��YouLi��1��LiLin-1016��2��LiLin-820��3��Pelco-p��4��DM DynaColor��5��HD600��6��JC-4116��7��Pelco-d WX��8��Pelco-d PICO
			public ushort wDecoderAddress;/*��������ַ:0 - 255*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPreset, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetPreset;/* Ԥ�õ��Ƿ�����,0-û������,1-����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCruise, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetCruise;/* Ѳ���Ƿ�����: 0-û������,1-���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTrack, ArraySubType = UnmanagedType.I1)]
			public byte[] bySetTrack;/* �켣�Ƿ�����,0-û������,1-����*/
		}

		//ppp��������(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPppcfgV30
		{
			public NetDvrIpaddr struRemoteIP;//Զ��IP��ַ
			public NetDvrIpaddr struLocalIP;//����IP��ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIpMask;//����IP��ַ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			public byte byPPPMode;//PPPģʽ, 0��������1������
			public byte byRedial;//�Ƿ�ز� ��0-��,1-��
			public byte byRedialMode;//�ز�ģʽ,0-�ɲ�����ָ��,1-Ԥ�ûز�����
			public byte byDataEncrypt;//���ݼ���,0-��,1-��
			public uint dwMTU;//MTU
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PhonenumberLen)]
			public string sTelephoneNumber;//�绰����
		}

		//ppp��������(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPppcfg
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteIP;//Զ��IP��ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIp;//����IP��ַ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sLocalIpMask;//����IP��ַ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			public byte byPPPMode;//PPPģʽ, 0��������1������
			public byte byRedial;//�Ƿ�ز� ��0-��,1-��
			public byte byRedialMode;//�ز�ģʽ,0-�ɲ�����ָ��,1-Ԥ�ûز�����
			public byte byDataEncrypt;//���ݼ���,0-��,1-��
			public uint dwMTU;//MTU
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PhonenumberLen)]
			public string sTelephoneNumber;//�绰����
		}

		//RS232���ڲ�������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleRs232
		{
			public uint dwBaudRate;/*������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;*/
			public byte byDataBit;/* �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ */
			public byte byStopBit;/* ֹͣλ 0��1λ��1��2λ */
			public byte byParity;/* У�� 0����У�飬1����У�飬2��żУ�� */
			public byte byFlowcontrol;/* 0���ޣ�1��������,2-Ӳ���� */
			public uint dwWorkMode; /* ����ģʽ��0��232��������PPP���ţ�1��232�������ڲ������ƣ�2��͸��ͨ�� */
		}

		//RS232���ڲ�������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRs232CfgV30
		{
			public uint dwSize;
			public NetDvrSingleRs232 struRs232;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrPppcfgV30 struPPPConfig;
		}

		//RS232���ڲ�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRs232Cfg
		{
			public uint dwSize;
			public uint dwBaudRate;//������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;
			public byte byDataBit;// �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ;
			public byte byStopBit;// ֹͣλ 0��1λ��1��2λ;
			public byte byParity;// У�� 0����У�飬1����У�飬2��żУ��;
			public byte byFlowcontrol;// 0���ޣ�1��������,2-Ӳ����
			public uint dwWorkMode;// ����ģʽ��0��խ������(232��������PPP����)��1������̨(232�������ڲ�������)��2��͸��ͨ��
			public NetDvrPppcfg struPPPConfig;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPresetchanInfo
		{
			public uint dwEnablePresetChan;	/*����Ԥ�õ��ͨ��*/
			public uint dwPresetPointNo;		/*����Ԥ�õ�ͨ����Ӧ��Ԥ�õ����, 0xfffffff��ʾ������Ԥ�õ㡣*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruisechanInfo
		{
			public uint dwEnableCruiseChan;	/*����Ѳ����ͨ��*/
			public uint dwCruiseNo;		/*Ѳ��ͨ����Ӧ��Ѳ�����, 0xfffffff��ʾ��Ч*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtztrackchanInfo
		{
			public uint dwEnablePtzTrackChan;	/*������̨�켣��ͨ��*/
			public uint dwPtzTrackNo;		/*��̨�켣ͨ����Ӧ�ı��, 0xfffffff��ʾ��Ч*/
		}

		//���������������(256·NVR��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmincfgV40
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;	/* ���� */
			public byte byAlarmType;	            //����������,0������,1������
			public byte byAlarmInHandle;	        /* �Ƿ��� 0-������ 1-����*/
			public byte byChannel;                 // �������봥������ʶ��ͨ��
			public byte byRes1;                    //����			
			public uint dwHandleType;        //�쳣����,�쳣����ʽ��"��"���   
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: �����������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/ 
			public uint dwMaxRelAlarmOutChanNum ; //�����ı������ͨ������ֻ�������֧������
			public uint dwRelAlarmOutChanNum; //�����ı������ͨ���� ʵ��֧����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelAlarmOut; //��������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			/*������¼��ͨ��*/
			public uint dwMaxRecordChanNum;   //�豸֧�ֵ�������¼��ͨ����-ֻ��
			public uint dwCurRecordChanNum;    //��ǰʵ�������õĹ���¼��ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelRecordChan;	 /* ʵ�ʴ���¼��ͨ������ֵ��ʾ,���ý��������У����±�0 - dwCurRecordChanNum -1��Ч������м�����0xffffffff,�������Ч*/ 
			public uint dwMaxEnablePtzCtrlNun; //�������õ���̨��������(ֻ��)
			public uint dwEnablePresetChanNum;  //��ǰ������Ԥ�õ����Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPresetchanInfo[] struPresetChanInfo; //���õ�Ԥ�õ���Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;					/*����*/
			public uint dwEnableCruiseChanNum;  //��ǰ������Ѳ����ͨ����Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCruisechanInfo[] struCruiseChanInfo; //����Ѳ������ͨ������Ϣ
			public uint dwEnablePtzTrackChanNum;  //��ǰ������Ѳ����ͨ����Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPtztrackchanInfo[] struPtzTrackInfo; //������̨�켣��ͨ����Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���������������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmincfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;/* ���� */
			public byte byAlarmType; //����������,0������,1������
			public byte byAlarmInHandle; /* �Ƿ��� 0-������ 1-����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrHandleexceptionV30 struAlarmHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePreset;/* �Ƿ����Ԥ�õ� 0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;/* ���õ���̨Ԥ�õ����,һ������������Ե��ö��ͨ������̨Ԥ�õ�, 0xff��ʾ������Ԥ�õ㡣*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;/*����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnableCruise;/* �Ƿ����Ѳ�� 0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseNo;/* Ѳ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePtzTrack;/* �Ƿ���ù켣 0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byPTZTrack;/* ���õ���̨�Ĺ켣��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}


		[StructLayout(LayoutKind.Sequential)]
		public struct StructIoAlarm
		{
			public uint	dwAlarmInputNo;		//���������ı�������ͨ���ţ�һ��ֻ��һ��
			public uint	dwTrigerAlarmOutNum;	/*�����ı���������������ں������䳤���ݲ��������д����ı������ͨ���ţ����ֽڱ�ʾһ��*/
			public uint	dwTrigerRecordChanNum;	/*������¼��ͨ�����������ں������䳤���ݲ��������д�����¼��ͨ���ţ����ֽڱ�ʾһ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct StructAlarmChannel
		{
			public uint	dwAlarmChanNum;	/*��������ͨ�����ݸ��������ں������䳤���ݲ��������з����ı���ͨ���ţ����ֽڱ�ʾһ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct StructAlarmHd
		{
			public uint	dwAlarmHardDiskNum;	/*����������Ӳ�����ݳ��ȣ����ں������䳤���ݲ��������з���������Ӳ�̺ţ��Ľڱ�ʾһ��*/
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
			public StructIoAlarm struIOAlarm;// ��������dwAlarmTypeΪ0ʱ��Ч
			[FieldOffset(0)]
			public StructAlarmChannel struAlarmChannel; // dwAlarmTypeΪ2��3��6��9��10��13ʱ��Ч
			[FieldOffset(0)]
			public StructAlarmHd struAlarmHardDisk; // dwAlarmTypeΪ1,4,5ʱ��Ч           
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlramFixedHeader
		{
			public uint dwAlarmType;              /*0-�ź�������,1-Ӳ����,2-�źŶ�ʧ��3���ƶ���⣬4��Ӳ��δ��ʽ��,5-дӲ�̳���,6-�ڵ�������7-��ʽ��ƥ��, 8-�Ƿ����ʣ�9-��Ƶ�ź��쳣��10-¼���쳣��11-���ܳ����仯��12-�����쳣��13-ǰ��/¼��ֱ��ʲ�ƥ��*/
			public NetDvrTimeEx struAlarmTime;	//����������ʱ��
			public UnionAlarminfoFixed uStruAlarm;
		}

	   [StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfoV40
	   {
			public NetDvrAlramFixedHeader struAlarmFixedHeader;	//�����̶�����
			public IntPtr pAlarmData;	//�����ɱ䲿������
	   }

		//���������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmincfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmInName;/* ���� */
			public byte byAlarmType;//����������,0������,1������
			public byte byAlarmInHandle;/* �Ƿ��� 0-������ 1-����*/
			public byte byChannel;     // �������봥������ʶ��ͨ��
			public byte byRes;                     
			public NetDvrHandleexception struAlarmHandleType;/* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePreset;/* �Ƿ����Ԥ�õ� 0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;/* ���õ���̨Ԥ�õ����,һ������������Ե��ö��ͨ������̨Ԥ�õ�, 0xff��ʾ������Ԥ�õ㡣*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnableCruise;/* �Ƿ����Ѳ�� 0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseNo;/* Ѳ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byEnablePtzTrack;/* �Ƿ���ù켣 0-��,1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byPTZTrack;/* ���õ���̨�Ĺ켣��� */
		}

		//ģ�ⱨ�������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAnalogAlarmincfg
		{
			public uint dwSize;
			public byte	byEnableAlarmHandle; //����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInName; //ģ�ⱨ����������
			public ushort wAlarmInUpper; //ģ�������ѹ���ޣ�ʵ��ֵ��10����Χ0~360
			public ushort wAlarmInLower; //ģ�������ѹ���ޣ�ʵ��ֵ��10����Χ0~360 
			public NetDvrHandleexceptionV30 struAlarmHandleType;	/* ����ʽ */ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //��������¼��ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//�ϴ�������Ϣ(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfoV30
		{
			public uint dwAlarmType;/*0-�ź�������,1-Ӳ����,2-�źŶ�ʧ,3���ƶ����,4��Ӳ��δ��ʽ��,5-��дӲ�̳���,6-�ڵ�����,7-��ʽ��ƥ��, 8-�Ƿ�����, 0xa-GPS��λ��Ϣ(���ض���)*/
			public uint dwAlarmInputNumber;/*��������˿�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutputNumber;/*����������˿ڣ�Ϊ1��ʾ��Ӧ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmRelateChannel;/*������¼��ͨ����Ϊ1��ʾ��Ӧ¼��, dwAlarmRelateChannel[0]��Ӧ��1��ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byChannel;/*dwAlarmTypeΪ2��3,6ʱ����ʾ�ĸ�ͨ����dwChannel[0]��Ӧ��1��ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskNumber;/*dwAlarmTypeΪ1,4,5ʱ,��ʾ�ĸ�Ӳ��, dwDiskNumber[0]��Ӧ��1��Ӳ��*/
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
			public uint dwSize;   //�ṹ��
			public uint dwExceptionCase;   //����ԭ��   0-�����쳣
			public NetDvrIpaddr  struDeviceIP;    //�����쳣���豸IP��ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfo
		{
			public int dwAlarmType;/*0-�ź�������,1-Ӳ����,2-�źŶ�ʧ,3���ƶ����,4��Ӳ��δ��ʽ��,5-��дӲ�̳���,6-�ڵ�����,7-��ʽ��ƥ��, 8-�Ƿ�����, 9-����״̬, 0xa-GPS��λ��Ϣ(���ض���)*/
			public int dwAlarmInputNumber;/*��������˿�, ����������Ϊ9ʱ�ñ�����ʾ����״̬0��ʾ������ -1��ʾ����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmout, ArraySubType = UnmanagedType.U4)]
			public int[] dwAlarmOutputNumber;/*����������˿ڣ���һλΪ1��ʾ��Ӧ��һ�����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.U4)]
			public int[] dwAlarmRelateChannel;/*������¼��ͨ������һλΪ1��ʾ��Ӧ��һ·¼��, dwAlarmRelateChannel[0]��Ӧ��1��ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.U4)]
			public int[] dwChannel;/*dwAlarmTypeΪ2��3,6ʱ����ʾ�ĸ�ͨ����dwChannel[0]λ��Ӧ��1��ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknum, ArraySubType = UnmanagedType.U4)]
			public int[] dwDiskNumber;/*dwAlarmTypeΪ1,4,5ʱ,��ʾ�ĸ�Ӳ��, dwDiskNumber[0]λ��Ӧ��1��Ӳ��*/
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
		//IPC�����������
		/* IP�豸�ṹ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpdevinfo
		{
			public uint dwEnable;/* ��IP�豸�Ƿ����� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword; /* ���� */
			public NetDvrIpaddr struIP;/* IP��ַ */
			public ushort wDVRPort;/* �˿ں� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;/* ���� */

			public void Init()
			{
				sUserName = new byte[NameLen];
				sPassword = new byte[PasswdLen];
				byRes = new byte[34];
			}
		}

		//ipc�����豸��Ϣ��չ��֧��ip�豸���������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpdevinfoV31
		{
			public byte byEnable;//��IP�豸�Ƿ���Ч
			public byte byProType;
			public byte byEnableQuickAdd;
			public byte byRes1;//�����ֶΣ���0
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = NameLen)]
			public string sUserName;//�û���
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sPassword;//����
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxDomainName)]
			public string byDomain;//�豸����
			public NetDvrIpaddr struIP;//IP��ַ
			public ushort wDVRPort;// �˿ں�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//�����ֶΣ���0
		}

		/* IPͨ��ƥ����� */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpchaninfo
		{
			public byte byEnable;/* ��ͨ���Ƿ����� */
			public byte byIPID;/* IP�豸ID ȡֵ1- MaxIpDevice */
			public byte byChannel;/* ͨ���� */
			public byte byIPIDHigh; // IP�豸ID�ĸ�8λ
			public byte byTransProtocol;//����Э������0-TCP/auto(�������豸����)��1-UDP 2-�ಥ 3-��TCP 4-auto
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����,��0
			public void Init()
			{
				byRes = new byte[31];
			}
		}

		/* IP�������ýṹ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpparacfg
		{
			public uint dwSize;/* �ṹ��С */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfo[] struIPDevInfo;/* IP�豸 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IPͨ�� */

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

		/* ��չIP�������ýṹ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpparacfgV31
		{
			public uint dwSize;/* �ṹ��С */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo; /* IP�豸 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IPͨ�� */

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

		/*��ý���������������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamMediaServerCfg
		{
			public byte byValid;/*�Ƿ�������ý�������ȡ��,0��ʾ��Ч����0��ʾ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struDevIP;
			public ushort wDevPort;/*��ý��������˿�*/
			public byte byTransmitType;/*����Э������ 0-TCP��1-UDP*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		//�豸ͨ����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevChanInfo
		{
			public NetDvrIpaddr struIP;		    //DVR IP��ַ
			public ushort wDVRPort;			 	//�˿ں�
			public byte byChannel;				//ͨ����
			public byte byTransProtocol;		//����Э������0-TCP��1-UDP
			public byte byTransMode;			//��������ģʽ 0�������� 1��������
			public byte byFactoryType;			/*ǰ���豸��������,ͨ���ӿڻ�ȡ*/
			public byte byDeviceType; //�豸����(��Ƶ�ۺ�ƽ̨���ܰ�ʹ��)��1-����������ʱ������Ƶ�ۺ�ƽ̨��������byVcaSupportChanMode�ֶ���������ʹ�ý���ͨ��������ʾͨ������2-������
			public byte byDispChan;//��ʾͨ����,��������ʹ��
			public byte bySubDispChan;//��ʾͨ����ͨ���ţ���������ʱʹ��
			public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w����������ʹ�ã���������������ݸò������������Դ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byDomain;	//�豸����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	//���������½�ʺ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	//�����������
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
			public byte byEnable;				/* ��ͨ���Ƿ����� */
			public byte byRes1;
			public ushort wIPID;                  //IP�豸ID
			public uint dwChannel;				//ͨ����
			public byte byTransProtocol;		//����Э������0-TCP��1-UDP
			public byte byTransMode;			//��������ģʽ 0�������� 1��������
			public byte byFactoryType;			/*ǰ���豸��������,ͨ���ӿڻ�ȡ*/
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
			public byte byGetStreamType;/*ȡ����ʽ��0- ֱ�Ӵ��豸ȡ����1- ����ý��ȡ����2- ͨ��IPServer���IP��ַ��ȡ����
										  * 3- ͨ��IPServer�ҵ��豸����ͨ����ý��ȡ�豸������ 4- ͨ����ý����URLȥȡ����
										  * 5- ͨ��hiDDNS���������豸Ȼ����豸ȡ�� */
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

		/* V40��չIP�������ýṹ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpparacfgV40
		{
			public uint dwSize;/* �ṹ��С */
			public uint dwGroupNum;
			public uint dwAChanNum;
			public uint dwDChanNum;
			public uint dwStartDChan;

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDeviceV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo; /* IP�豸 */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrStreamMode[] struStreamMode;/* IPͨ�� */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */
		}

		//ΪCVR��չ�ı�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarminfoDev
		{
			public uint dwAlarmType;  //0-������(ͨ��)�ź���������1-˽�о���𻵣�2- NVR�����˳���
			//3-������״̬�쳣��4-ϵͳʱ���쳣��5-¼���ʣ���������ͣ�
			//6-������(ͨ��)�ƶ���ⱨ����7-������(ͨ��)�ڵ�������
			public NetDvrTime   struTime;     //����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //����
			public uint dwNumber;     //��Ŀ
			public IntPtr pNO;  //dwNumber��WORD; ÿ��WORD��ʾһ��ͨ���ţ����ߴ��̺�, ��ЧʱΪ0
		}

		/* ����������� */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutinfo
		{
			public byte byIPID;/* IP�豸IDȡֵ1- MaxIpDevice */
			public byte byAlarmOut;/* ��������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;/* ���� */

			public void Init()
			{
				byRes = new byte[18];
			}
		}

		/* IP����������ýṹ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutcfg
		{
			public uint dwSize; /* �ṹ��С */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo;/* IP������� */

			public void Init()
			{
				struIPAlarmOutInfo = new NetDvrIpalarmoutinfo[MaxIpAlarmout];
				for (var i = 0; i < MaxIpAlarmout; i++)
				{
					struIPAlarmOutInfo[i].Init();
				}
			}
		}
		/* IP����������� */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutinfoV40
		{
			public uint dwIPID;					/* IP�豸ID */
			public uint dwAlarmOut;				/* IP�豸ID��Ӧ�ı�������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				/* ���� */
		}

		/*IP�������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmoutcfgV40
		{
			public uint dwSize;  //�ṹ�峤��
			public uint dwCurIPAlarmOutNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmoutV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfoV40[] struIPAlarmOutInfo;/*IP�������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/* ����������� */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmininfo
		{
			public byte byIPID;/* IP�豸IDȡֵ1- MaxIpDevice */
			public byte byAlarmIn;/* ��������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;/* ���� */
		}

		/* IP�����������ýṹ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmincfg
		{
			public uint dwSize;/* �ṹ��С */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo;/* IP�������� */
		}
		/* IP����������� */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmininfoV40
		{
			public uint dwIPID;					/* IP�豸ID */
			public uint dwAlarmIn;				/* IP�豸ID��Ӧ�ı�������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				/* ���� */
		}
		 /*IP����������Դ*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarmincfgV40
		{
			public uint dwSize;  //�ṹ�峤��
			public uint dwCurIPAlarmInNum;  //��ǰ�����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarminV40, ArraySubType = UnmanagedType.I1)]
			public NetDvrIpalarmininfoV40[] struIPAlarmInInfo;/* IP��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ipc alarm info
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarminfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfo[] struIPDevInfo; /* IP�豸 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã�0-δ���� 1-���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IPͨ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo;/* IP�������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo;/* IP������� */
		}

		//ipc���øı䱨����Ϣ��չ 9000_1.1
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarminfoV31
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDevice, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo; /* IP�豸 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;/* ģ��ͨ���Ƿ����ã�0-δ���� 1-���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpChannel, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;/* IPͨ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo; /* IP�������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo;/* IP������� */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpalarminfoV40
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpDeviceV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpdevinfoV31[] struIPDevInfo;           // IP�豸
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnalogChanEnable;           /* ģ��ͨ���Ƿ����ã�0-δ���� 1-���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpchaninfo[] struIPChanInfo;	        /* IPͨ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmin, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmininfo[] struIPAlarmInInfo;    /* IP�������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIpAlarmout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpalarmoutinfo[] struIPAlarmOutInfo; /* IP������� */   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                          // �����ֽ�
		}

		public enum HdStat
		{
			HdStatOk = 0,/* ���� */
			HdStatUnformatted = 1,/* δ��ʽ�� */
			HdStatError = 2,/* ���� */
			HdStatSmartFailed = 3,/* SMART״̬ */
			HdStatMismatch = 4,/* ��ƥ�� */
			HdStatIdle = 5, /* ����*/
			NetHdStatOffline = 6,/*�����̴���δ����״̬ */
			HdRiadvdExpand = 7,    /* ������̿����� */
			HdStatReparing = 10,   /* Ӳ�������޸�(9000 2.0) */
			HdStatFormating = 11,   /* Ӳ�����ڸ�ʽ��(9000 2.0) */ 
		}

		//����Ӳ����Ϣ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleHd
		{
			public uint dwHDNo;/*Ӳ�̺�, ȡֵ0~MaxDisknumV30-1*/
			public uint dwCapacity;/*Ӳ������(��������)*/
			public uint dwFreeSpace;/*Ӳ��ʣ��ռ�(��������)*/
			public uint dwHdStatus;/*Ӳ��״̬(��������) HD_STAT*/
			public byte byHDAttr;/*0-Ĭ��, 1-����; 2-ֻ��*/
			public byte byHDType;/*0-����Ӳ��,1-ESATAӲ��,2-NASӲ��*/
			public byte byDiskDriver;   // ֵ ������ASCII�ַ� 
			public byte byRes1;
			public uint dwHdGroup; /*�����ĸ����� 1-MaxHdGroup*/
			public byte byRecycling;   // �Ƿ�ѭ������ 0����ѭ�����ã�1��ѭ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public uint dwStorageType;    //��λ��ʾ 0-��֧�� ��0-֧��
							// dwStorageType & 0x1 ��ʾ�Ƿ�����ͨ¼��ר�ô洢��     
							// dwStorageType & 0x2  ��ʾ�Ƿ��ǳ�֡¼��ר�ô洢��
							// dwStorageType & 0x4 ��ʾ�Ƿ���ͼƬ¼��ר�ô洢��

			public uint dwPictureCapacity; //Ӳ��ͼƬ����(��������)����λ:MB
			public uint dwFreePictureSpace; //ʣ��ͼƬ�ռ�(��������)����λ:MB
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHdcfg
		{
			public uint dwSize;
			public uint dwHDCount;/*Ӳ����(��������)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleHd[] struHDInfo;//Ӳ����ز�������Ҫ����������Ч��
		}

		//����������Ϣ������չ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleHdgroupV40
		{
			public uint dwHDGroupNo;       /*�����(��������) 1-MaxHdGroup*/    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRelRecordChan;  //������¼��ͨ������ֵ��ʾ������0xffffffffʱ������Ϊ��Ч    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				/* ���� */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHdgroupCfgV40
		{
			public uint dwSize;                //�ṹ���С
			public uint dwMaxHDGroupNum; 		  //�豸֧�ֵ����������-ֻ��
			public uint dwCurHDGroupNum;       /*��ǰ���õ�������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHdGroup, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleHdgroupV40[] struHDGroupAttr; //Ӳ����ز�������Ҫ����������Ч��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		//����������Ϣ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleHdgroup
		{
			public uint dwHDGroupNo;/*�����(��������) 1-MaxHdGroup*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byHDGroupChans;/*�����Ӧ��¼��ͨ��, 0-��ʾ��ͨ����¼�󵽸����飬1-��ʾ¼�󵽸�����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHdgroupCfg
		{
			public uint dwSize;
			public uint dwHDGroupCount;/*��������(��������)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHdGroup, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleHdgroup[] struHDGroupAttr;//Ӳ����ز�������Ҫ����������Ч
		}

		//�������Ų����Ľṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScalecfg
		{
			public uint dwSize;
			public uint dwMajorScale;/* ����ʾ 0-�����ţ�1-����*/
			public uint dwMinorScale;/* ����ʾ 0-�����ţ�1-����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		//DVR�������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmOutName;/* ���� */
			public uint dwAlarmOutDelay;/* �������ʱ��(-1Ϊ���ޣ��ֶ��ر�) */
			//0-5��,1-10��,2-30��,3-1����,4-2����,5-5����,6-10����,7-�ֶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmOutTime;/* �����������ʱ��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAlarmOutName;/* ���� */
			public uint dwAlarmOutDelay;/* �������ʱ��(-1Ϊ���ޣ��ֶ��ر�) */
			//0-5��,1-10��,2-30��,3-1����,4-2����,5-5����,6-10����,7-�ֶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmOutTime;/* �����������ʱ��� */
		}

		//DVR����Ԥ������(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPreviewcfgV30
		{
			public uint dwSize;
			public byte byPreviewNumber;//Ԥ����Ŀ,0-1����,1-4����,2-9����,3-16����,0xff:�����
			public byte byEnableAudio;//�Ƿ�����Ԥ��,0-��Ԥ��,1-Ԥ��
			public ushort wSwitchTime;//�л�ʱ��,0-���л�,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPreviewMode * MaxWindowV30, ArraySubType = UnmanagedType.I1)]
			public byte[] bySwitchSeq;//�л�˳��,���lSwitchSeq[i]Ϊ 0xff��ʾ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR����Ԥ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPreviewcfg
		{
			public uint dwSize;
			public byte byPreviewNumber;//Ԥ����Ŀ,0-1����,1-4����,2-9����,3-16����,0xff:�����
			public byte byEnableAudio;//�Ƿ�����Ԥ��,0-��Ԥ��,1-Ԥ��
			public ushort wSwitchTime;//�л�ʱ��,0-���л�,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindow, ArraySubType = UnmanagedType.I1)]
			public byte[] bySwitchSeq;//�л�˳��,���lSwitchSeq[i]Ϊ 0xff��ʾ����
		}

		//DVR��Ƶ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVgapara
		{
			public ushort wResolution;/* �ֱ��� */
			public ushort wFreq;/* ˢ��Ƶ�� */
			public uint dwBrightness;/* ���� */
		}

		//MATRIX��������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixparaV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogChannum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wOrder;/* Ԥ��˳��, 0xff��ʾ��Ӧ�Ĵ��ڲ�Ԥ�� */
			public ushort wSwitchTime;// Ԥ���л�ʱ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixpara
		{
			public ushort wDisplayLogo;/* ��ʾ��Ƶͨ���� */
			public ushort wDisplayOsd;/* ��ʾʱ�� */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVoout
		{
			public byte byVideoFormat;/* �����ʽ,0-PAL,1-NTSC */
			public byte byMenuAlphaValue;/* �˵��뱳��ͼ��Աȶ� */
			public ushort wScreenSaveTime;/* ��Ļ����ʱ�� 0-�Ӳ�,1-1����,2-2����,3-5����,4-10����,5-20����,6-30���� */
			public ushort wVOffset;/* ��Ƶ���ƫ�� */
			public ushort wBrightness;/* ��Ƶ������� */
			public byte byStartMode;/* ��������Ƶ���ģʽ(0:�˵�,1:Ԥ��)*/
			public byte byEnableScaler;/* �Ƿ��������� (0-������, 1-����)*/
		}

		//DVR��Ƶ���(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideooutV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVideooutV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVoout[] struVOOut;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVgaV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVgapara[] struVGAPara;/* VGA���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxMatrixout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixparaV30[] struMatrixPara;/* MATRIX���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR��Ƶ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoout
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVideoout, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVoout[] struVOOut;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVga, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVgapara[] struVGAPara;	/* VGA���� */
			public NetDvrMatrixpara struMatrixPara;/* MATRIX���� */
		}

		//���û�����(�ӽṹ)(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserInfoV40
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;			/* �û���ֻ����16�ֽ� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;			/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRight;	/* ����Ȩ�� */
			/*����0: ���ؿ�����̨*/
			/*����1: �����ֶ�¼��*/
			/*����2: ���ػط�*/
			/*����3: �������ò���*/
			/*����4: ���ز鿴״̬����־*/
			/*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
			/*����6: ���ز鿴���� */
			/*����7: ���ع���ģ���IP camera */
			/*����8: ���ر��� */
			/*����9: ���عػ�/���� */    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemoteRight;/* Զ��Ȩ�� */	
			/*����0: Զ�̿�����̨*/
			/*����1: Զ���ֶ�¼��*/
			/*����2: Զ�̻ط� */
			/*����3: Զ�����ò���*/
			/*����4: Զ�̲鿴״̬����־*/
			/*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
			/*����6: Զ�̷��������Խ�*/
			/*����7: Զ��Ԥ��*/
			/*����8: Զ�����󱨾��ϴ����������*/
			/*����9: Զ�̿��ƣ��������*/
			/*����10: Զ�̿��ƴ���*/
			/*����11: Զ�̲鿴���� */
			/*����12: Զ�̹���ģ���IP camera */
			/*����13: Զ�̹ػ�/���� */	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetPreviewRight;			/* Զ�̿���Ԥ����ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRecordRight;			/* ���ؿ���¼���ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetRecordRight;			/* Զ�̿���¼���ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalPlaybackRight;			/* ���ؿ��Իطŵ�ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetPlaybackRight;			/* Զ�̿��Իطŵ�ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalPTZRight;				/* ���ؿ���PTZ��ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwNetPTZRight;				/* Զ�̿���PTZ��ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalBackupRight;			/* ���ر���Ȩ��ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
			public NetDvrIpaddr	struUserIP;				/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;	/* �����ַ */
			public byte byPriority;				/* ���ȼ���0xff-�ޣ�0--�ͣ�1--�У�2--�� */
									/* �ޡ�����ʾ��֧�����ȼ�������
									�͡���Ĭ��Ȩ��:�������غ�Զ�̻ط�,���غ�Զ�̲鿴��־��״̬,���غ�Զ�̹ػ�/����
									�С����������غ�Զ�̿�����̨,���غ�Զ���ֶ�¼��,���غ�Զ�̻ط�,�����Խ���Զ��Ԥ�������ر���,����/Զ�̹ػ�/����
									�ߡ�������Ա */
			public byte byAlarmOnRight;         // ��������ڲ���Ȩ�� 1-��Ȩ�ޣ�0-��Ȩ��
			public byte byAlarmOffRight;         // ��������ڳ���Ȩ�� 1-��Ȩ�ޣ�0-��Ȩ��
			public byte byBypassRight;           // �����������·Ȩ�� 1-��Ȩ�ޣ�0-��Ȩ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}

		//���û�����(�ӽṹ)(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserInfoV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRight;/* ����Ȩ�� */
			/*����0: ���ؿ�����̨*/
			/*����1: �����ֶ�¼��*/
			/*����2: ���ػط�*/
			/*����3: �������ò���*/
			/*����4: ���ز鿴״̬����־*/
			/*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
			/*����6: ���ز鿴���� */
			/*����7: ���ع���ģ���IP camera */
			/*����8: ���ر��� */
			/*����9: ���عػ�/���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemoteRight;/* Զ��Ȩ�� */
			/*����0: Զ�̿�����̨*/
			/*����1: Զ���ֶ�¼��*/
			/*����2: Զ�̻ط� */
			/*����3: Զ�����ò���*/
			/*����4: Զ�̲鿴״̬����־*/
			/*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
			/*����6: Զ�̷��������Խ�*/
			/*����7: Զ��Ԥ��*/
			/*����8: Զ�����󱨾��ϴ����������*/
			/*����9: Զ�̿��ƣ��������*/
			/*����10: Զ�̿��ƴ���*/
			/*����11: Զ�̲鿴���� */
			/*����12: Զ�̹���ģ���IP camera */
			/*����13: Զ�̹ػ�/���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPreviewRight;/* Զ�̿���Ԥ����ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalPlaybackRight;/* ���ؿ��Իطŵ�ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPlaybackRight;/* Զ�̿��Իطŵ�ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalRecordRight;/* ���ؿ���¼���ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetRecordRight;/* Զ�̿���¼���ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalPTZRight;/* ���ؿ���PTZ��ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byNetPTZRight;/* Զ�̿���PTZ��ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalBackupRight;/* ���ر���Ȩ��ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
			public NetDvrIpaddr struUserIP;/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/* �����ַ */
			public byte byPriority;/* ���ȼ���0xff-�ޣ�0--�ͣ�1--�У�2--�� */
			/*
			�ޡ�����ʾ��֧�����ȼ�������
			�͡���Ĭ��Ȩ��:�������غ�Զ�̻ط�,���غ�Զ�̲鿴��־��״̬,���غ�Զ�̹ػ�/����
			�С����������غ�Զ�̿�����̨,���غ�Զ���ֶ�¼��,���غ�Զ�̻ط�,�����Խ���Զ��Ԥ��
				  ���ر���,����/Զ�̹ػ�/����
			�ߡ�������Ա
			*/
			public byte byAlarmOnRight;         // ��������ڲ���Ȩ��
			public byte byAlarmOffRight;        // ��������ڳ���Ȩ��
			public byte byBypassRight;          // �����������·Ȩ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���û�����(SDK_V15��չ)(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrUserInfoEx
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRight;/* Ȩ�� */
			/*����0: ���ؿ�����̨*/
			/*����1: �����ֶ�¼��*/
			/*����2: ���ػط�*/
			/*����3: �������ò���*/
			/*����4: ���ز鿴״̬����־*/
			/*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
			public uint dwLocalPlaybackRight;/* ���ؿ��Իطŵ�ͨ�� bit0 -- channel 1*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRemoteRight;/* Ȩ�� */
			/*����0: Զ�̿�����̨*/
			/*����1: Զ���ֶ�¼��*/
			/*����2: Զ�̻ط� */
			/*����3: Զ�����ò���*/
			/*����4: Զ�̲鿴״̬����־*/
			/*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
			/*����6: Զ�̷��������Խ�*/
			/*����7: Զ��Ԥ��*/
			/*����8: Զ�����󱨾��ϴ����������*/
			/*����9: Զ�̿��ƣ��������*/
			/*����10: Զ�̿��ƴ���*/
			public uint dwNetPreviewRight;/* Զ�̿���Ԥ����ͨ�� bit0 -- channel 1*/
			public uint dwNetPlaybackRight;/* Զ�̿��Իطŵ�ͨ�� bit0 -- channel 1*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sUserIP;/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/* �����ַ */
		}

		//���û�����(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrUserInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLocalRight;/* Ȩ�� */
			/*����0: ���ؿ�����̨*/
			/*����1: �����ֶ�¼��*/
			/*����2: ���ػط�*/
			/*����3: �������ò���*/
			/*����4: ���ز鿴״̬����־*/
			/*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRight, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRemoteRight;/* Ȩ�� */
			/*����0: Զ�̿�����̨*/
			/*����1: Զ���ֶ�¼��*/
			/*����2: Զ�̻ط� */
			/*����3: Զ�����ò���*/
			/*����4: Զ�̲鿴״̬����־*/
			/*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
			/*����6: Զ�̷��������Խ�*/
			/*����7: Զ��Ԥ��*/
			/*����8: Զ�����󱨾��ϴ����������*/
			/*����9: Զ�̿��ƣ��������*/
			/*����10: Զ�̿��ƴ���*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sUserIP;/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/* �����ַ */
		}

		//DVR�û�����(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserV40
		{
			public uint dwSize;  //�ṹ���С
			public uint dwMaxUserNum; //�豸֧�ֵ�����û���-ֻ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfoV40[] struUser;  /* �û����� */
		}

		//DVR�û�����(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfoV30[] struUser;
		}

		//DVR�û�����(SDK_V15��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUserEx
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfoEx[] struUser;
		}

		//DVR�û�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUser
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxUsernum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUserInfo[] struUser;
		}

		//�쳣����������չ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrExceptionV40
		{
			public uint dwSize ;             //�ṹ���С
			public uint dwMaxGroupNum ;    //�豸֧�ֵ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHandleexceptionV41[] struExceptionHandle;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //����
		} 

		//DVR�쳣����(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrExceptionV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHandleexceptionV30[] struExceptionHandleType;
			/*����0-����,1- Ӳ�̳���,2-���߶�,3-��������IP ��ַ��ͻ, 4-�Ƿ�����, 5-����/�����Ƶ��ʽ��ƥ��, 6-��Ƶ�ź��쳣, 7-¼���쳣*/
		}

		//DVR�쳣����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrException
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHandleexception[] struExceptionHandleType;
			/*����0-����,1- Ӳ�̳���,2-���߶�,3-��������IP ��ַ��ͻ,4-�Ƿ�����, 5-����/�����Ƶ��ʽ��ƥ��, 6-��Ƶ�ź��쳣*/
		}

		//ͨ��״̬(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannelstateV30
		{
			public byte byRecordStatic;//ͨ���Ƿ���¼��,0-��¼��,1-¼��
			public byte bySignalStatic;//���ӵ��ź�״̬,0-����,1-�źŶ�ʧ
			public byte byHardwareStatic;//ͨ��Ӳ��״̬,0-����,1-�쳣,����DSP����
			public byte byRes1;//����
			public uint dwBitRate;//ʵ������
			public uint dwLinkNum;//�ͻ������ӵĸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLink, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struClientIP;//�ͻ��˵�IP��ַ
			public uint dwIPLinkNum;//�����ͨ��ΪIP���룬��ô��ʾIP���뵱ǰ��������
			public byte byExceedMaxLink;		// �Ƿ񳬳��˵�·6·������ 0 - δ����, 1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwChannelNo;    //��ǰ��ͨ���ţ�0xffffffff��ʾ��Ч

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

		//ͨ��״̬
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannelstate
		{
			public byte byRecordStatic;//ͨ���Ƿ���¼��,0-��¼��,1-¼��
			public byte bySignalStatic;//���ӵ��ź�״̬,0-����,1-�źŶ�ʧ
			public byte byHardwareStatic;//ͨ��Ӳ��״̬,0-����,1-�쳣,����DSP����
			public byte reservedData;//����
			public uint dwBitRate;//ʵ������
			public uint dwLinkNum;//�ͻ������ӵĸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLink, ArraySubType = UnmanagedType.U4)]
			public uint[] dwClientIP;//�ͻ��˵�IP��ַ
		}

		//Ӳ��״̬
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskstate
		{
			public uint dwVolume;//Ӳ�̵�����
			public uint dwFreeSpace;//Ӳ�̵�ʣ��ռ�
			public uint dwHardDiskStatic;//Ӳ�̵�״̬,0-�,1-����,2-������
		}

		//�豸����״̬��չ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWorkstateV40
		{ 
			public uint dwSize ;            //�ṹ���С
			public uint dwDeviceStatic; 	 //�豸��״̬,0-����,1-CPUռ����̫��,����85%,2-Ӳ������,���紮������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDiskstate[]  struHardDiskStatic;   //Ӳ��״̬,һ�����ֻ�ܻ�ȡ33��Ӳ����Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChannelstateV30[] struChanStatic;//ͨ����״̬����ǰ����˳������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwHasAlarmInStatic; //�б����ı�������ڣ���ֵ��ʾ�����±�ֵ˳�����У�ֵΪ0xffffffffʱ��ǰ������ֵ��Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwHasAlarmOutStatic; //�б�������ı�������ڣ���ֵ��ʾ�����±�ֵ˳�����У�ֵΪ0xffffffffʱ��ǰ������ֵ��Ч
			public uint dwLocalDisplay;			//������ʾ״̬,0-����,1-������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAudioV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAudioInChanStatus;		//��λ��ʾ����ͨ����״̬ 0-δʹ�ã�1-ʹ���У���0λ��ʾ��1������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 				//����
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGetworkstateCond
		{
			public uint dwSize ;  //�ṹ�峤��
			public byte byFindHardByCond; /*0-����ȫ������(��һ�����ֻ�ܲ���33��)����ʱdwFindHardStatusNum��Ч*/
			public byte byFindChanByCond ;  /*0-����ȫ��ͨ������ʱdwFindChanNum��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwFindHardStatus ; /*Ҫ���ҵ�Ӳ�̺ţ���ֵ��ʾ����ֵ����˳�����У� ����0xffffffff����Ϊ������Ч */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwFindChanNo; /*Ҫ���ҵ�ͨ���ţ���ֵ��ʾ����ֵ����˳�����У� ����0xffffffff����Ϊ������Ч */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		//DVR����״̬(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWorkstateV30
		{
			public uint dwDeviceStatic;//�豸��״̬,0-����,1-CPUռ����̫��,����85%,2-Ӳ������,���紮������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDiskstate[] struHardDiskStatic;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChannelstateV30[] struChanStatic;//ͨ����״̬
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatic;//�����˿ڵ�״̬,0-û�б���,1-�б���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmoutV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatic;//��������˿ڵ�״̬,0-û�����,1-�б������
			public uint dwLocalDisplay;//������ʾ״̬,0-����,1-������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAudioV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAudioChanStatus;//��ʾ����ͨ����״̬ 0-δʹ�ã�1-ʹ����, 0xff��Ч
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

		//DVR����״̬
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWorkstate
		{
			public uint dwDeviceStatic;//�豸��״̬,0-����,1-CPUռ����̫��,����85%,2-Ӳ������,���紮������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDiskstate[] struHardDiskStatic;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChannelstate[] struChanStatic;//ͨ����״̬
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmin, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatic;//�����˿ڵ�״̬,0-û�б���,1-�б���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarmout, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatic;//��������˿ڵ�״̬,0-û�����,1-�б������
			public uint dwLocalDisplay;//������ʾ״̬,0-����,1-������

			public void Init()
			{
				struHardDiskStatic = new NetDvrDiskstate[MaxDisknum];
				struChanStatic = new NetDvrChannelstate[MaxChannum];
				byAlarmInStatic = new byte[MaxAlarmin];
				byAlarmOutStatic = new byte[MaxAlarmout];
			}
		}        

		//��־��Ϣ(9000��չ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrLogV30
		{
			public NetDvrTime strLogTime;
			public uint dwMajorType;//������ 1-����; 2-�쳣; 3-����; 0xff-ȫ��
			public uint dwMinorType;//������ 0-ȫ��;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;//���������û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;//����������û���
			public NetDvrIpaddr struRemoteHostAddr;//Զ��������ַ
			public uint dwParaType;//��������
			public uint dwChannel;//ͨ����
			public uint dwDiskNumber;//Ӳ�̺�
			public uint dwAlarmInPort;//��������˿�
			public uint dwAlarmOutPort;//��������˿�
			public uint dwInfoLen;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LogInfoLen)]
			public string sInfo;
		}

		//��־��Ϣ
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrLog
		{
			public NetDvrTime strLogTime;
			public uint dwMajorType;//������ 1-����; 2-�쳣; 3-����; 0xff-ȫ��
			public uint dwMinorType;//������ 0-ȫ��;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPanelUser;//���������û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNamelen, ArraySubType = UnmanagedType.I1)]
			public byte[] sNetUser;//����������û���
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteHostAddr;//Զ��������ַ
			public uint dwParaType;//��������
			public uint dwChannel;//ͨ����
			public uint dwDiskNumber;//Ӳ�̺�
			public uint dwAlarmInPort;//��������˿�
			public uint dwAlarmOutPort;//��������˿�
		}

		/************************������������������־���� begin************************************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmhostSearchLogParam
		{
			public ushort wMajorType;		// ������
			public ushort wMinorType;		// ������ 
			public NetDvrTime    struStartTime;	// ��ʼʱ�� 
			public NetDvrTime    struEndTime;	// ����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmhostLogRet
		{
			public NetDvrTime	struLogTime;                //  ��־ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;     // �����û�
			public NetDvrIpaddr	struIPAddr;                 // ����IP��ַ
			public ushort wMajorType;                 // ������ 
			public ushort wMinorType;                 // ������
			public ushort wParam;	                    // ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwInfoLen;	                // ������Ϣ����
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LogInfoLen)]
			public string sInfo;       // ������Ϣ
		}
		/*************************������������������־���� end***********************************************/

		//�������״̬(9000��չ)
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

		//�������״̬
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmoutstatus
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] Output;
		}        

		//ATMר��
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

		//������Ϣ
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
			public byte[] DeviceName;//�豸����
			public uint dwChannelNumer;//ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] CardNumber;//����
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
			public string cTradeType;//��������
			public uint dwCash;//���׽��
		}

		/*֡��ʽ*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFrametypecode
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] code;/* ���� */
		}
		
		//ATM����
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFrameformat
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sATMIP;/* ATM IP��ַ */
			public uint dwATMType;/* ATM���� */
			public uint dwInputMode;/* ���뷽ʽ	0-�������� 1-������� 2-����ֱ������ 3-����ATM��������*/
			public uint dwFrameSignBeginPos;/* ���ı�־λ����ʼλ��*/
			public uint dwFrameSignLength;/* ���ı�־λ�ĳ��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byFrameSignContent;/* ���ı�־λ������ */
			public uint dwCardLengthInfoBeginPos;/* ���ų�����Ϣ����ʼλ�� */
			public uint dwCardLengthInfoLength;/* ���ų�����Ϣ�ĳ��� */
			public uint dwCardNumberInfoBeginPos;/* ������Ϣ����ʼλ�� */
			public uint dwCardNumberInfoLength;/* ������Ϣ�ĳ��� */
			public uint dwBusinessTypeBeginPos;/* �������͵���ʼλ�� */
			public uint dwBusinessTypeLength;/* �������͵ĳ��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public NetDvrFrametypecode[] frameTypeCode;/* ���� */
		}

		//SDK_V31 ATM
		/*��������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFilter
		{
			public byte byEnable;/*0,������;1,����*/
			public byte byMode;/*0,ASCII;1,HEX*/
			public byte byFrameBeginPos;// ���ı�־λ����ʼλ��     
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byFilterText;/*�����ַ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*��ʼ��ʶ����*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIdentificat
		{
			public byte byStartMode;/*0,ASCII;1,HEX*/
			public byte byEndMode;/*0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrFrametypecode struStartCode;/*��ʼ�ַ�*/
			public NetDvrFrametypecode struEndCode;/*�����ַ�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		/*������Ϣλ��*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPackageLocation
		{
			public byte byOffsetMode;/*0,token;1,fix*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwOffsetPos;/*modeΪ1��ʱ��ʹ��*/
			public NetDvrFrametypecode struTokenCode;/*��־λ*/
			public byte byMultiplierValue;/*��־λ���ٴγ���*/
			public byte byEternOffset;/*���ӵ�ƫ����*/
			public byte byCodeMode;/*0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*������Ϣ����*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPackageLength
		{
			public byte byLengthMode;/*�������ͣ�0,variable;1,fix;2,get from package(���ÿ��ų���ʹ��)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwFixLength;/*modeΪ1��ʱ��ʹ��*/
			public uint dwMaxLength;
			public uint dwMinLength;
			public byte byEndMode;/*�ս��0,ASCII;1,HEX*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrFrametypecode struEndCode;/*�ս��*/
			public uint dwLengthPos;/*lengthModeΪ2��ʱ��ʹ�ã����ų����ڱ����е�λ��*/
			public uint dwLengthLen;/*lengthModeΪ2��ʱ��ʹ�ã����ų��ȵĳ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		/*OSD ���ӵ�λ��*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOsdPosition
		{
			public byte byPositionMode;/*���ӷ�񣬹�2�֣�0������ʾ��1��Custom*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwPos_x;/*x���꣬positionmodeΪCustomʱʹ��*/
			public uint dwPos_y;/*y���꣬positionmodeΪCustomʱʹ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*������ʾ��ʽ*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDateFormat
		{
			public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
			public byte byItem2;/*Day,0.dd;*/
			public byte byItem3;/*Year,0.yy;1.yyyy*/
			public byte byDateForm;/*0~5��3��item���������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chSeprator;/*�ָ���*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chDisplaySeprator;/*��ʾ�ָ���*/
			public byte byDisplayForm;/*0~5��3��item���������*///lili mode by lili
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		/*ʱ����ʾ��ʽ*/
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
			public string chSeprator;/*���ķָ�������ʱû��*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string chDisplaySeprator;/*��ʾ�ָ���*/
			public byte byDisplayForm;/*0~5��3��item���������*/
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
			public byte[] byChannel;/*���ӵ�ͨ��*/
			public uint dwDelayTime;/*������ʱʱ��*/
			public byte byEnableDelayTime;/*�Ƿ����õ�����ʱ�������˿�����ʱ����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmPackageAction
		{
			public NetDvrPackageLocation struPackageLocation;
			public NetDvrOsdPosition struOsdPosition;
			public NetDvrFrametypecode struActionCode;/*�������͵ȶ�Ӧ����*/
			public NetDvrFrametypecode struPreCode;/*�����ַ�ǰ���ַ�*/
			public byte byActionCodeMode;/*�������͵ȶ�Ӧ����0,ASCII;1,HEX*/
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
			public NetDvrFrametypecode struPreCode;/*�����ַ�ǰ���ַ�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//�û��Զ���Э��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmUserDefineProtocol
		{
			public NetDvrIdentificat        struIdentification;  //���ı�־
			public NetDvrFilter             struFilter; //���ݰ���������
			public NetDvrAtmPackageOthers struCardNoPara; //���ӿ�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxActionType, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAtmPackageAction[] struTradeActionPara; //���ӽ�����Ϊ���� 0-9 ���ζ�ӦInCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
			public NetDvrAtmPackageOthers struAmountPara; //���ӽ��׽������
			public NetDvrAtmPackageOthers struSerialNoPara; //���ӽ����������
			public NetDvrOverlayChannel    struOverlayChan; //����ͨ������
			public NetDvrAtmPackageDate   struRes1; //�������ڣ�����
			public NetDvrAtmPackageTime   struRes2; //����ʱ�䣬����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;        //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmFrameformatV30
		{		
			public uint dwSize;                 //�ṹ��С
			public byte byEnable;				/*�Ƿ�����0,������;1,����*/
			public byte byInputMode;			/**���뷽ʽ:0-���������1����Э�顢2-���ڼ�����3-����Э��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;              //�����ֽ� 
			public NetDvrIpaddr struAtmIp;				/*ATM ��IP �������ʱʹ�� */
			public ushort wAtmPort;				/* ����Э�鷽ʽʱ��ʹ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;              // �����ֽ�
			public uint dwAtmType;				/*ATMЭ�����ͣ���NET_DVR_ATM_PROTOCOL�ṹ�л�ȡ���������Ϊ�Զ���ʱʹ���û��Զ���Э��*/
			public NetDvrAtmUserDefineProtocol  struAtmUserDefineProtocol; //�û��Զ���Э�飬��ATM����Ϊ�Զ�ʱ��Ҫʹ�øö���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		//Э����Ϣ���ݽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmProtoType
		{
			public uint dwAtmType; //ATMЭ�����ͣ�ͬʱ��Ϊ������� ATM �����е�dwAtmType �Զ���ʱΪ1025
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = AtmDescLen)]
			public string chDesc; //ATMЭ�������
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrAtmProtoList
		{
			public uint dwAtmProtoNum;/*Э���б�ĸ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAtmProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAtmProtoType[] struAtmProtoType;/*Э���б���Ϣ*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmProtocol
		{
			public uint dwSize;
			public NetDvrAtmProtoList struNetListenList;     // �������Э������
			public NetDvrAtmProtoList struSerialListenList; //���ڼ���Э������
			public NetDvrAtmProtoList struNetProtoList;     //����Э������
			public NetDvrAtmProtoList struSerialProtoList;   //����Э������
			public NetDvrAtmProtoType struCustomProto;      //�Զ���Э��            
		}

		/*****************************DS-6001D/F(begin)***************************/
		//DS-6001D Decoder
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderinfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderIP;//�����豸���ӵķ�����IP
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderUser;//�����豸���ӵķ��������û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderPasswd;//�����豸���ӵķ�����������
			public byte bySendMode;//�����豸���ӷ�����������ģʽ
			public byte byEncoderChannel;//�����豸���ӵķ�������ͨ����
			public ushort wEncoderPort;//�����豸���ӵķ������Ķ˿ں�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] reservedData;//����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderstate
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderIP;//�����豸���ӵķ�����IP
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderUser;//�����豸���ӵķ��������û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byEncoderPasswd;//�����豸���ӵķ�����������
			public byte byEncoderChannel;//�����豸���ӵķ�������ͨ����
			public byte bySendMode;//�����豸���ӵķ�����������ģʽ
			public ushort wEncoderPort;//�����豸���ӵķ������Ķ˿ں�
			public uint dwConnectState;//�����豸���ӷ�������״̬
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] reservedData;//����
		}

		/*�����豸�����붨��*/
		public const int NetDecStartdec = 1;
		public const int NetDecStopdec = 2;
		public const int NetDecStopcycle = 3;
		public const int NetDecContinuecycle = 4;

		/*���ӵ�ͨ������*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDecchaninfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/* DVR IP��ַ */
			public ushort wDVRPort;/* �˿ں� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			public byte byChannel;/* ͨ���� */
			public byte byLinkMode;/* ����ģʽ */
			public byte byLinkType;/* �������� 0�������� 1�������� */
		}

		/*ÿ������ͨ��������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecinfo
		{
			public byte byPoolChans;/*ÿ·����ͨ���ϵ�ѭ��ͨ������, ���4ͨ�� 0��ʾû�н���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecpoolnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDecchaninfo[] struchanConInfo;
			public byte byEnablePoll;/*�Ƿ���Ѳ 0-�� 1-��*/
			public byte byPoolTime;/*��Ѳʱ�� 0-���� 1-10�� 2-15�� 3-20�� 4-30�� 5-45�� 6-1���� 7-2���� 8-5���� */
		}

		/*�����豸��������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeccfg
		{
			public uint dwSize;
			public uint dwDecChanNum;/*����ͨ��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDecinfo[] struDecInfo;
		}

		//2005-08-01
		/* �����豸͸��ͨ������ */
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPortinfo
		{
			public uint dwEnableTransPort;/* �Ƿ�����͸��ͨ�� 0�������� 1������*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDecoderIP;/* DVR IP��ַ */
			public ushort wDecoderPort;/* �˿ں� */
			public ushort wDVRTransPort;/* ����ǰ��DVR�Ǵ�485/232�����1��ʾ232����,2��ʾ485���� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
			public string cReserve;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPortcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTransparentnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPortinfo[] struTransPortInfo;/* ����0��ʾ232 ����1��ʾ485 */
		}

		[StructLayout(LayoutKind.Sequential)]               
		public struct Bytime
		{
			public uint dwChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/*������Ƶ�û���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			public NetDvrTime struStartTime;/* ��ʱ��طŵĿ�ʼʱ�� */
			public NetDvrTime struStopTime;/* ��ʱ��طŵĽ���ʱ�� */
		}

		/* ���������ļ��ط� */
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrPlayremotefile
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDecoderIP;/* DVR IP��ַ */
			public ushort wDecoderPort;/* �˿ں� */
			public ushort wLoadMode;/* �ط�����ģʽ 1�������� 2����ʱ�� */

			[StructLayout(LayoutKind.Explicit)]
			public struct ModeSize
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]             
				public byte[] byFile;/* �طŵ��ļ��� */
				[FieldOffset(0)]
				public Bytime bytime;
			}
		}



		/*��ǰ�豸��������״̬*/
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrDecchanstatus
		{
			public uint dwWorkType;/*������ʽ��1����Ѳ��2����̬���ӽ��롢3���ļ��ط����� 4����ʱ��ط�����*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/*���ӵ��豸ip*/
			public ushort wDVRPort;/*���Ӷ˿ں�*/
			public byte byChannel;/* ͨ���� */
			public byte byLinkMode;/* ����ģʽ */
			public uint dwLinkType;/*�������� 0�������� 1��������*/

			[StructLayout(LayoutKind.Explicit)]
			public struct ObjectInfo
			{
				[StructLayout(LayoutKind.Sequential)]
				public struct UserInfo
				{
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
					public byte[] sUserName;/*������Ƶ�û���*/
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;/* ���� */
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
					public byte[] sUserName;/*������Ƶ�û���*/
					[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
					public byte[] sPassword;/* ���� */
					public NetDvrTime struStartTime;/* ��ʱ��طŵĿ�ʼʱ�� */
					public NetDvrTime struStopTime;/* ��ʱ��طŵĽ���ʱ�� */
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

		//���ַ�����(�ӽṹ)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrShowstringinfo
		{
			public ushort wShowString;// Ԥ����ͼ�����Ƿ���ʾ�ַ�,0-����ʾ,1-��ʾ �����С704*576,�����ַ��Ĵ�СΪ32*32
			public ushort wStringSize;/* �����ַ��ĳ��ȣ����ܴ���44���ַ� */
			public ushort wShowStringTopLeftX;/* �ַ���ʾλ�õ�x���� */
			public ushort wShowStringTopLeftY;/* �ַ�������ʾλ�õ�y���� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 44)]
			public string sString;/* Ҫ��ʾ���ַ����� */
		}

		//�����ַ�(9000��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShowstringV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxStringnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShowstringinfo[] struStringInfo;/* Ҫ��ʾ���ַ����� */
		}

		//�����ַ���չ(8���ַ�)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShowstringEx
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxStringnumEx, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShowstringinfo[] struStringInfo;/* Ҫ��ʾ���ַ����� */
		}

		//�����ַ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrShowstring
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxStringnum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrShowstringinfo[] struStringInfo;/* Ҫ��ʾ���ַ����� */
		}

		/****************************DS9000�����ṹ(begin)******************************/
		/*EMAIL�����ṹ*/
		//��ԭ�ṹ���в���
		[StructLayout(LayoutKind.Sequential)]
		public struct StruReceiver
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sName;/* �ռ������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAddress;/* �ռ��˵�ַ */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEmailcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sAccount;/* �˺�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailPwdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/*���� */

			[StructLayout(LayoutKind.Sequential)]
			public struct StruSender
			{
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
				public byte[] sName;/* ���������� */
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
				public byte[] sAddress;/* �����˵�ַ */
			}

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSmtpServer;/* smtp������ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxEmailAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPop3Server;/* pop3������ */

			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
			public StruReceiver[] struStringInfo;/* ����������3���ռ��� */

			public byte byAttachment;/* �Ƿ������ */
			public byte bySmtpServerVerify;/* ���ͷ�����Ҫ�������֤ */
			public byte byMailInterval;/* mail interval */
			public byte byEnableSSL;//ssl�Ƿ�����9000_1.1
			public ushort wSmtpPort;//gmail��465����ͨ��Ϊ25  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		/*DVRʵ��Ѳ�����ݽṹ*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruisePara
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CruiseMaxPresetNums, ArraySubType = UnmanagedType.I1)]
			public byte[] byPresetNo;/* Ԥ�õ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CruiseMaxPresetNums, ArraySubType = UnmanagedType.I1)]
			public byte[] byCruiseSpeed;/* Ѳ���ٶ� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CruiseMaxPresetNums, ArraySubType = UnmanagedType.U2)]
			public ushort[] wDwellTime;/* ͣ��ʱ�� */
			public byte byEnableThisCruise;/* �Ƿ����� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}
		/****************************DS9000�����ṹ(end)******************************/     
		//ʱ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimepoint
		{
			public uint dwMonth;//�� 0-11��ʾ1-12����
			public uint dwWeekNo;//�ڼ��� 0����1�� 1����2�� 2����3�� 3����4�� 4�����һ��
			public uint dwWeekDate;//���ڼ� 0�������� 1������һ 2�����ڶ� 3�������� 4�������� 5�������� 6��������
			public uint dwHour;//Сʱ	��ʼʱ��0��23 ����ʱ��1��23
			public uint dwMin;//��	0��59
		}

		//����ʱ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrZoneanddst
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����
			public uint dwEnableDST;//�Ƿ�������ʱ�� 0�������� 1������
			public byte byDSTBias;//����ʱƫ��ֵ��30min, 60min, 90min, 120min, �Է��Ӽƣ�����ԭʼ��ֵ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrTimepoint struBeginPoint;//��ʱ�ƿ�ʼʱ��
			public NetDvrTimepoint struEndPoint;//��ʱ��ֹͣʱ��
		}

		//ͼƬ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegpara
		{
			/*ע�⣺��ͼ��ѹ���ֱ���ΪVGAʱ��֧��0=CIF, 1=QCIF, 2=D1ץͼ��
			���ֱ���Ϊ3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
			��֧�ֵ�ǰ�ֱ��ʵ�ץͼ*/
			public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
			public ushort wPicQuality;/* ͼƬ����ϵ�� 0-��� 1-�Ϻ� 2-һ�� */
		}

		/* aux video out parameter */
		//���������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAuxoutcfg
		{
			public uint dwSize;
			public uint dwAlarmOutChan;/* ѡ�񱨾������󱨾�ͨ���л�ʱ�䣺1��������ͨ��: 0:�����/1:��1/2:��2/3:��3/4:��4 */
			public uint dwAlarmChanSwitchTime;/* :1�� - 10:10�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAuxout, ArraySubType = UnmanagedType.U4)]
			public uint[] dwAuxSwitchTime;/* ��������л�ʱ��: 0-���л�,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAuxout * MaxWindow, ArraySubType = UnmanagedType.I1)]
			public byte[] byAuxOrder;/* �������Ԥ��˳��, 0xff��ʾ��Ӧ�Ĵ��ڲ�Ԥ�� */
		}

		//ntp
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNtppara
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
			public ushort wInterval;/* adjust time interval(hours) */
			public byte byEnableNTP;/* enable NPT client 0-no��1-yes*/
			public byte cTimeDifferenceH;/* ����ʱ�׼ʱ��� Сʱƫ��-12 ... +13 */
			public byte cTimeDifferenceM;/* ����ʱ�׼ʱ��� ����ƫ��0, 30, 45*/
			public byte res1;
			public ushort wNtpPort; /* ntp server port 9000���� �豸Ĭ��Ϊ123*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res2;
		}

		//ddns
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnspara
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* DDNS�˺��û���/���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName; /* ���� */
			public byte byEnableDDNS;/*�Ƿ�Ӧ�� 0-��1-��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnsparaEx
		{
			public byte byHostIndex;/* 0-Hikvision DNS 1��Dyndns 2��PeanutHull(������)*/
			public byte byEnableDDNS;/*�Ƿ�Ӧ��DDNS 0-��1-��*/
			public ushort wDDNSPort;/* DDNS�˿ں� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* DDNS�û���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* DDNS���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;/* �豸�䱸��������ַ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sServerName;/* DDNS ��Ӧ�ķ�������ַ��������IP��ַ������ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//9000��չ
		[StructLayout(LayoutKind.Sequential)]
		public struct StruDdns
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUsername;/* DDNS�˺��û���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sDomainName;/* �豸�䱸��������ַ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] sServerName;/* DDNSЭ���Ӧ�ķ�������ַ��������IP��ַ������ */
			public ushort wDDNSPort;/* �˿ں� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDdnsparaV30
		{
			public byte byEnableDDNS;
			public byte byHostIndex;/* 0-Hikvision DNS(����) 1��Dyndns 2��PeanutHull(������)*/
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
			public byte[] sUsername;/* �ʼ��˺�/���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sSmtpServer;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sPop3Server;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sMailAddr;/* email */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sEventMailAddr1;/* �ϴ�����/�쳣�ȵ�email */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] sEventMailAddr2;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//�����������
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrNetappcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDNSIp; /* DNS��������ַ */
			public NetDvrNtppara struNtpClientParam;/* NTP���� */
			public NetDvrDdnspara struDDNSClientParam;/* DDNS���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
			public byte[] res;/* ���� */
		}

		//nfs�ṹ����
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
			public uint dwSize;                   // �ṹ��С
			public ushort wVrmPort;                  // VRM �����˿�
			public byte byEnable;                  // �Ƿ����� ISCSI�洢
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                 // �����ֽ�
			public NetDvrIpaddr struVrmAddr;          // VRM ip��ַ 16λ
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string chNvtIndexCode;        //nvt index Code 
		}

		//Ѳ��������(HIK IP����ר��)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCruisePoint
		{
			public byte PresetNum;//Ԥ�õ�
			public byte Dwell;//ͣ��ʱ��
			public byte Speed;//�ٶ�
			public byte Reserve;//����

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
			public NetDvrCruisePoint[] struCruisePoint;//���֧��32��Ѳ����

			public void Init()
			{
				struCruisePoint = new NetDvrCruisePoint[32];
				for (var i = 0; i < 32; i++)
				{
					struCruisePoint[i].Init();
				}
			}
		}

		/************************************��·������(begin)***************************************/
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
			public string sDvrip;/* DVR IP��ַ */
			public ushort wDVRPort;/* �˿ں� */
			public byte byChannel;/* ͨ���� */
			public byte byTransProtocol;/* ����Э������ 0-TCP, 1-UDP */
			public byte byTransMode;/* ��������ģʽ 0�������� 1��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* ���������½�ʺ� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ����������� */
		}

		//����/ֹͣ��̬����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDynamicDec
		{
			public uint dwSize;
			public NetDvrMatrixDecinfo struDecChanInfo;/* ��̬����ͨ����Ϣ */
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecChanStatus
		{
			public uint dwSize;
			public uint dwIsLinked;/* ����ͨ��״̬ 0������ 1���������� 2�������� 3-���ڽ��� */
			public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
			public string cRes;/* ���� */
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecChanInfo
		{
			public uint dwSize;
			public NetDvrMatrixDecinfo struDecChanInfo;/* ����ͨ����Ϣ */
			public uint dwDecState;/* 0-��̬���� 1��ѭ������ 2����ʱ��ط� 3�����ļ��ط� */
			public NetDvrTime StartTime;/* ��ʱ��طſ�ʼʱ�� */
			public NetDvrTime StopTime;/* ��ʱ��ط�ֹͣʱ�� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;/* ���ļ��ط��ļ��� */
		}

		//���ӵ�ͨ������ 2007-11-05
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecchaninfo
		{
			public uint dwEnable;/* �Ƿ����� 0���� 1������*/
			public NetDvrMatrixDecinfo struDecChanInfo;/* ��ѭ����ͨ����Ϣ */
		}

		//2007-11-05 ����ÿ������ͨ��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixLoopDecinfo
		{
			public uint dwSize;
			public uint dwPoolTime;/*��Ѳʱ�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChan, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixDecchaninfo[] struchanConInfo;
		}

		//2007-12-22
		[StructLayout(LayoutKind.Sequential)]
		public struct TtyConfig
		{
			public byte baudrate;/* ������ */
			public byte databits;/* ����λ */
			public byte stopbits;/* ֹͣλ */
			public byte parity;/* ��żУ��λ */
			public byte flowcontrol;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixTranChanInfo
		{
			public byte byTranChanEnable;/* ��ǰ͸��ͨ���Ƿ�� 0���ر� 1���� */
			/*
			 *	��·������������1��485���ڣ�1��232���ڶ�������Ϊ͸��ͨ��,�豸�ŷ������£�
			 *	0 RS485
			 *	1 RS232 Console
			 */
			public byte byLocalSerialDevice;/* Local serial device */
			/*
			 *	Զ�̴��������������,һ��RS232��һ��RS485
			 *	1��ʾ232����
			 *	2��ʾ485����
			 */
			public byte byRemoteSerialDevice;/* Remote output serial device */
			public byte res1;/* ���� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sRemoteDevIP;/* Remote Device IP */
			public ushort wRemoteDevPort;/* Remote Net Communication Port */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res2;/* ���� */
			public TtyConfig RemoteSerialDevCfg;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTranChanConfig
		{
			public uint dwSize;
			public byte by232IsDualChan;/* ������·232͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
			public byte by485IsDualChan;/* ������·485͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSerialNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixTranChanInfo[] struTranInfo;/*ͬʱ֧�ֽ���MAX_SERIAL_NUM��͸��ͨ��*/
		}

		//2007-12-24 Merry Christmas Eve...
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrMatrixDecRemotePlay
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sDvrip;/* DVR IP��ַ */
			public ushort wDVRPort;/* �˿ں� */
			public byte byChannel;/* ͨ���� */
			public byte byReserve;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/* ���� */
			public uint dwPlayMode;/* 0�����ļ� 1����ʱ��*/
			public NetDvrTime StartTime;
			public NetDvrTime StopTime;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecRemotePlayControl
		{
			public uint dwSize;
			public uint dwPlayCmd;/* �������� ���ļ���������*/
			public uint dwCmdParam;/* ����������� */
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecRemotePlayStatus
		{
			public uint dwSize;
			public uint dwCurMediaFileLen;/* ��ǰ���ŵ�ý���ļ����� */
			public uint dwCurMediaFilePosition;/* ��ǰ�����ļ��Ĳ���λ�� */
			public uint dwCurMediaFileDuration;/* ��ǰ�����ļ�����ʱ�� */
			public uint dwCurPlayTime;/* ��ǰ�Ѿ����ŵ�ʱ�� */
			public uint dwCurMediaFIleFrames;/* ��ǰ�����ļ�����֡�� */
			public uint dwCurDataType;/* ��ǰ������������ͣ�19-�ļ�ͷ��20-�����ݣ� 21-���Ž�����־ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//2009-4-11 added by likui ��·������new
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixPassivemode
		{
			public ushort wTransProtol;//����Э�飬0-TCP, 1-UDP, 2-MCAST
			public ushort wPassivePort;//UDP�˿�, TCPʱĬ��
			// char	sMcastIP[16];		//TCP,UDPʱ��Ч, MCASTʱΪ�ಥ��ַ
			public NetDvrIpaddr struMcastIP;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}       

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTranChanInfoV30
		{
			public byte byTranChanEnable;/* ��ǰ͸��ͨ���Ƿ�� 0���ر� 1���� */
			/*
			 *	��·������������1��485���ڣ�1��232���ڶ�������Ϊ͸��ͨ��,�豸�ŷ������£�
			 *	0 RS485
			 *	1 RS232 Console
			 */
			public byte byLocalSerialDevice;/* Local serial device */
			/*
			 *	Զ�̴��������������,һ��RS232��һ��RS485
			 *	1��ʾ232����
			 *	2��ʾ485����
			 */
			public byte byRemoteSerialDevice;/* Remote output serial device */
			public byte byRes1;/* ���� */
			public NetDvrIpaddr struRemoteDevIP;/* Remote Device IP */
			public ushort wRemoteDevPort;/* Remote Net Communication Port */
			public byte byIsEstablished;/* ͸��ͨ�������ɹ���־��0-û�гɹ���1-�����ɹ� */
			public byte byRes2;/* ���� */
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
			public byte by232IsDualChan;/* ������·232͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
			public byte by485IsDualChan;/* ������·485͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] vyRes;/* ���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSerialNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixTranChanInfo[] struTranInfo;/*ͬʱ֧�ֽ���MAX_SERIAL_NUM��͸��ͨ��*/
		}        

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixChanInfoV30
		{
			public uint dwEnable;/* �Ƿ����� 0���� 1������*/
			public NetDvrStreamMediaServerCfg streamMediaServerCfg;
			public NetDvrDevChanInfo struDevChanInfo;/* ��ѭ����ͨ����Ϣ */
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
			public NetDvrStreamMediaServerCfg streamMediaServerCfg;/*��ý�����������*/
			public NetDvrDevChanInfo struDevChanInfo;/* ����ͨ����Ϣ */
			public uint dwDecState;/* 0-��̬���� 1��ѭ������ 2����ʱ��ط� 3�����ļ��ط� */
			public NetDvrTime StartTime;/* ��ʱ��طſ�ʼʱ�� */
			public NetDvrTime StopTime;/* ��ʱ��ط�ֹͣʱ�� */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;/* ���ļ��ط��ļ��� */
			public uint dwGetStreamMode;/*ȡ��ģʽ:1-������2-����*/
			public NetDvrMatrixPassivemode struPassiveMode;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int MaxResolutionnum = 64; //֧�ֵ����ֱ�����Ŀ

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixAbility
		{
			public uint dwSize;
			public byte byDecNums;
			public byte byStartChan;
			public byte byVGANums;
			public byte byBNCNums;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8*12, ArraySubType = UnmanagedType.I1)]
			public byte[] byVGAWindowMode;/*VGA֧�ֵĴ���ģʽ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byBNCWindowMode;/*BNC֧�ֵĴ���ģʽ*/
			public byte byDspNums;   
			public byte byHDMINums;//HDMI��ʾͨ����������25��ʼ��
			public byte byDVINums;//DVI��ʾͨ����������29��ʼ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxResolutionnum, ArraySubType = UnmanagedType.I1)]
			public byte[] bySupportResolution;//���������ö�ٶ���,һ���ֽڴ���һ���ֱ�����//��֧�֣�1��֧�֣�0����֧��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
			public byte[] byHDMIWindowMode;//HDMI֧�ֵĴ���ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
			public byte[] byDVIWindowMode;//DVI֧�ֵĴ���ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//�ϴ�logo�ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispLogocfg
		{
			public uint dwCorordinateX;//ͼƬ��ʾ����X����
			public uint dwCorordinateY;//ͼƬ��ʾ����Y����
			public ushort wPicWidth; //ͼƬ��
			public ushort wPicHeight; //ͼƬ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byFlash;//�Ƿ���˸1-��˸��0-����˸
			public byte byTranslucent;//�Ƿ��͸��1-��͸����0-����͸��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//����
			public uint dwLogoSize;//LOGO��С������BMP���ļ�ͷ
		}

		/*��������*/
		public const int NetDvrEncoderUnkown = 0;/*δ֪�����ʽ*/
		public const int NetDvrEncoderH264 = 1;/*HIK 264*/
		public const int NetDvrEncoderS264 = 2;/*Standard H264*/
		public const int NetDvrEncoderMpeg4 = 3;/*MPEG4*/
		public const int NetDvrOriginalstream = 4;/*Original Stream*/
		public const int NetDvrPicture = 5;//*Picture*/
		public const int NetDvrEncoderMjpeg = 6;
		public const int NetDvrEconderMpeg2 = 7;
		/* �����ʽ */
		public const int NetDvrStreamTypeUnkown = 0;/*δ֪�����ʽ*/
		public const int NetDvrStreamTypeHikprivt = 1; /*�����Զ�������ʽ*/
		public const int NetDvrStreamTypeTs = 7;/* TS��� */
		public const int NetDvrStreamTypePs = 8;/* PS��� */
		public const int NetDvrStreamTypeRtp = 9;/* RTP��� */

		/*����ͨ��״̬*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixChanStatus
		{
			public byte byDecodeStatus;/*��ǰ״̬:0:δ������1����������*/
			public byte byStreamType;/*��������*/
			public byte byPacketType;/*�����ʽ*/
			public byte byRecvBufUsage;/*���ջ���ʹ����*/
			public byte byDecBufUsage;/*���뻺��ʹ����*/
			public byte byFpsDecV;/*��Ƶ����֡��*/
			public byte byFpsDecA;/*��Ƶ����֡��*/
			public byte byCpuLoad;/*DSP CPUʹ����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwDecodedV;/*�������Ƶ֡*/
			public uint dwDecodedA;/*�������Ƶ֡*/
			public ushort wImgW;/*��������ǰ��ͼ���С,��*/
			public ushort wImgH; //��
			public byte byVideoFormat;/*��Ƶ��ʽ:0-NON,NTSC--1,PAL--2*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public uint dwDecChan; /*��ȡȫ������ͨ��״̬ʱ��Ч������ʱ����0*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;
		}

		/*��ʾͨ��״̬*/
		public const int NetDvrMaxDispregion = 16;         /*ÿ����ʾͨ����������ʾ�Ĵ���*/
		//VGA�ֱ��ʣ�Ŀǰ���õ��ǣ�VgaThs8200ModeXga60Hz��VgaThs8200ModeSxga60Hz��
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

		//��֡�ʶ���
		public const int LowDecFps12 = 51;
		public const int LowDecFps14 = 52;
		public const int LowDecFps18 = 53;
		public const int LowDecFps116 = 54;

		/*��Ƶ��ʽ��׼*/
		public enum VideoStandard
		{
			VsNon = 0,
			VsNtsc = 1,
			VsPal = 2,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionVideoplatform
		{
			/*�����Ӵ��ڶ�Ӧ����ͨ������Ӧ�Ľ�����ϵͳ�Ĳ�λ��(������Ƶ�ۺ�ƽ̨�н�����ϵͳ��Ч)*/
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
			public byte byAudio;/*��Ƶ�Ƿ���,0-��1-��*/
			public byte byAudioWindowIdx;/*��Ƶ�����Ӵ���*/
			public byte byVgaResolution;/*VGA�ķֱ���*/
			public byte byVedioFormat;/*��Ƶ��ʽ��1:NTSC,2:PAL,0-NON*/
			public uint dwWindowMode;/*����ģʽ�������������ȡ��Ŀǰ֧��1,2,4,9,16*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
			public byte byEnlargeStatus;          /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
			public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�
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
			public byte byUnionType;/*���ֹ����壬0-��Ƶ�ۺ�ƽ̨�ڲ���������ʾͨ�����ã�1-������������ʾͨ������*/
			public byte byScale; /*��ʾģʽ��0---��ʵ��ʾ��1---������ʾ( ���BNC )*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispChanStatus
		{
			public byte byDispStatus;/*��ʾ״̬��0��δ��ʾ��1��������ʾ*/
			public byte byBVGA; /*VGA/BNC*/
			public byte byVideoFormat;/*��Ƶ��ʽ:1:NTSC,2:PAL,0-NON*/
			public byte byWindowMode;/*��ǰ����ģʽ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NetDvrMaxDispregion, ArraySubType = UnmanagedType.I1)]
			public byte[] byFpsDisp;/*ÿ���ӻ������ʾ֡��*/
			public byte byScreenMode;			//��Ļģʽ0-��ͨ 1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public const int MaxDecodechannum = 32;//��·������������ͨ����
		public const int MaxDispchannum = 24;//��·�����������ʾͨ����

		/*�������豸״̬*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderWorkStatus
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDecodechannum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanStatus[] struDecChanStatus;/*����ͨ��״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDispchannum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDispChanStatus[] struDispChanStatus;/*��ʾͨ��״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogAlarmin, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatus;/*��������״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAnalogAlarmout, ArraySubType = UnmanagedType.I1)]
			public byte[] byAalarmOutStatus;/*�������״̬*/
			public byte byAudioInChanStatus;/*�����Խ�״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//2009-12-1 ���ӱ������벥�ſ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPassivedecodeControl
		{
			public uint dwSize;
			public uint dwPlayCmd;		/* �������� ���ļ���������*/
			public uint dwCmdParam;		/* ����������� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//Reverse
		}

		public const int PassiveDecPause = 1;	/*����������ͣ(���ļ�����Ч)*/
		public const int PassiveDecResume = 2;	/*�ָ���������(���ļ�����Ч)*/
		public const int PassiveDecFast = 3;   /*���ٱ�������(���ļ�����Ч)*/
		public const int PassiveDecSlow = 4;   /*���ٱ�������(���ļ�����Ч)*/
		public const int PassiveDecNormal = 5;   /*������������(���ļ�����Ч)*/
		public const int PassiveDecOnebyone =	6;  /*�������뵥֡����(����)*/
		public const int PassiveDecAudioOn = 7;   /*��Ƶ����*/
		public const int PassiveDecAudioOff = 8; 	 /*��Ƶ�ر�*/
		public const int PassiveDecResetbuffer = 9;    /*��ջ�����*/

		//2009-12-16 ���ӿ��ƽ���������ͨ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecchanControl
		{        
			public uint dwSize;
			public byte byDecChanScaleStatus;/*����ͨ����ʾ���ſ���,1��ʾ������ʾ��0��ʾ��ʵ��ʾ*/
			public byte byDecodeDelay;//������ʱ��0-Ĭ�ϣ�1-ʵʱ�Ժã�2-ʵʱ�ԽϺã�3-ʵʱ���У��������У�4-�����ԽϺã�5-�����Ժã�0xff-�Զ�����   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}
		/************************************��·������(end)***************************************/

		/************************************��Ƶ�ۺ�ƽ̨(begin)***************************************/
		public const int MaxSubsystemNum = 80;   //һ������ϵͳ�������ϵͳ����
		public const int MaxSubsystemNumV40 = 120;   //һ������ϵͳ�������ϵͳ����
		public const int MaxSeriallen = 36;  //������кų���
		public const int MaxLoopplannum = 16;  //���ƻ��л���
		public const int DecodeTimesegment = 4;     //�ƻ�����ÿ��ʱ�����

		public const int MaxDomainName = 64;  /* ����������� */
		public const int MaxDisknumV30 = 33; //9000�豸���Ӳ����/* ���33��Ӳ��(����16������SATAӲ�̡�1��eSATAӲ�̺�16��NFS��) */
		public const int MaxDays = 7;       //ÿ������
		public const int MaxDispnumV41 = 32;
		public const int MaxWindowsNum = 12;
		public const int MaxVoutnum = 32;
		public const int MaxSupportRes = 32;
		public const int MaxBigscreennum = 100;

		public const int VideoplatformAbility = 0x210; //��Ƶ�ۺ�ƽ̨������
		public const int MatrixdecoderAbilityV41 = 0x260; //������������

		public const int NetDvrMatrixBigscreencfgGet = 1140;//��ȡ����ƴ�Ӳ���        

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSubsysteminfo
		{
			public byte bySubSystemType;//��ϵͳ���ͣ�1-��������ϵͳ��2-��������ϵͳ��0-NULL���˲���ֻ�ܻ�ȡ��
			public byte byChan;//��ϵͳͨ�������˲���ֻ�ܻ�ȡ��
			public byte byLoginType;//ע�����ͣ�1-ֱ����2-DNS��3-������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struSubSystemIP;/*IP��ַ�����޸ģ�*/
			public ushort wSubSystemPort;//��ϵͳ�˿ںţ����޸ģ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrIpaddr struSubSystemIPMask;//��������
			public NetDvrIpaddr struGatewayIpAddr;	/* ���ص�ַ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;/* �û��� ���˲���ֻ�ܻ�ȡ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;/*���루�˲���ֻ�ܻ�ȡ��*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxDomainName)]
			public string sDomainName;//����(���޸�)
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxDomainName)]
			public string sDnsAddress;/*DNS������IP��ַ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//���кţ��˲���ֻ�ܻ�ȡ��
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
			public uint dwPoolTime; /*��ѯ�������λ����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChanV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanInfoV30[] struChanConInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]            
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmmodecfg
		{
			public uint dwSize;
			public byte byAlarmMode;//�����������ͣ�1-��ѯ��2-���� 
			public ushort wLoopTime;//��ѯʱ��, ��λ���� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCodesplitterinfo
		{
			public uint dwSize;
			public NetDvrIpaddr struIP;/*�����IP��ַ*/
			public ushort wPort;//������˿ں�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]             
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)] 
			public byte[] sUserName;/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)] 
			public byte[] sPassword;/*���� */
			public byte byChan;//�����485��
			public byte by485Port;//485�ڵ�ַ      
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAssociatecfg
		{
			public byte byAssociateType;//�������ͣ�1-����
			public ushort wAlarmDelay;//������ʱ��0��5�룻1��10�룻2��30�룻3��1���ӣ�4��2���ӣ�5��5���ӣ�6��10���ӣ�
			public byte byAlarmNum;//�����ţ������ֵ��Ӧ�ø�����ͬ�ı�������ͬ��ֵ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDynamicdecode
		{
			public uint dwSize;
			public NetDvrAssociatecfg struAssociateCfg;//������̬��������ṹ
			public NetDvrPuStreamCfg struPuStreamCfg;//��̬����ṹ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodesched
		{
			public NetDvrSchedtime struSchedTime;
			public byte byDecodeType;/*0-�ޣ�1-��ѯ���룬2-��̬����*/
			public byte byLoopGroup;//��ѯ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] 
			public byte[] byRes;
			public NetDvrPuStreamCfg struDynamicDec;//��̬����
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlandecode
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * DecodeTimesegment, ArraySubType = UnmanagedType.I1)] 
			public NetDvrDecodesched[] struDecodeSched;//��һ��Ϊ��ʼ����9000һ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
			public byte[] byres;
		}
		/************************************��Ƶ�ۺ�ƽ̨(end)***************************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoplatformAbility
		{
			public uint dwSize;
			public byte byCodeSubSystemNums;//������ϵͳ����
			public byte byDecodeSubSystemNums;//������ϵͳ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byWindowMode; /*��ʾͨ��֧�ֵĴ���ģʽ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSubsystemAbility
		{
			/*��ϵͳ���ͣ�1-��������ϵͳ��2-��������ϵͳ��3-���������ϵͳ��4-����������ϵͳ��5-�������ϵͳ��6-����������ϵͳ��7-������ϵͳ��8-V6������ϵͳ��9-V6��ϵͳ��0-NULL���˲���ֻ�ܻ�ȡ��*/
			public byte bySubSystemType;
			public byte byChanNum;//��ϵͳͨ����
			public byte byStartChan;//��ϵͳ��ʼͨ����
			public byte bySlotNum;//��λ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public StruDecoderSystemAbility _struAbility;
		}
		[StructLayout(LayoutKind.Sequential)]
		public struct StruDecoderSystemAbility
		{
			public byte byVGANums;//VGA��ʾͨ����������1��ʼ��
			public byte byBNCNums;//BNC��ʾͨ����������9��ʼ��
			public byte byHDMINums;//HDMI��ʾͨ����������25��ʼ��
			public byte byDVINums;//DVI��ʾͨ����������29��ʼ��

			public byte byLayerNums;//����ƴ���У�������ʱ��֧��ͼ����
			public byte bySpartan;//���Թ��ܣ�0-��֧�֣�1-֧��
			public byte byDecType; //������ϵͳ���ͣ�0-��ͨ��,1-��ǿ��(��ͨ�ͷ���ʱǰ4������ʹ��������Դ����ǿ���޴����ƣ���ǿ�����ɱ�������ϵͳ��16·D1������Դ
			//��ǿ�ͱ���������Ϊ��������Դ�ɱ����ã���ͨ�����ܱ�����)
			public byte byOutputSwitch;//�Ƿ�֧��HDMI/DVI�����л���0-��֧�֣�1-֧��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byDecoderType; //���������  0-��ͨ����� 1-���ܽ����
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
			public byte byDecodeSubSystemNums;//������ϵͳ����
			public byte bySupportNat;//�Ƿ�֧��NAT��0-��֧�֣�1-֧��
			public byte byInputSubSystemNums;//����������ϵͳ����
			public byte byOutputSubSystemNums;//���������ϵͳ����
			public byte byCodeSpitterSubSystemNums;//�����ϵͳ����
			public byte byAlarmHostSubSystemNums;//������ϵͳ����
			public byte bySupportBigScreenNum;//��֧�������ɴ����ĸ���
			public byte byVCASubSystemNums;//������ϵͳ����
			public byte byV6SubSystemNums;//V6��ϵͳ����
			public byte byV6DecoderSubSystemNums;//V6������ϵͳ����
			public byte bySupportBigScreenX;/*����ƴ�ӵ�ģʽ��m��n*/
			public byte bySupportBigScreenY;
			public byte bySupportSceneNums;//֧�ֳ���ģʽ�ĸ���
			public byte byVcaSupportChanMode;//����֧�ֵ�ͨ��ʹ��ģʽ��0-ʹ�ý���ͨ����1-ʹ����ʾͨ������ͨ����
			public byte bySupportScreenNums;//��֧�ֵĴ�������Ļ������
			public byte bySupportLayerNums;//��֧�ֵ�ͼ������0xff-��Ч
			public byte byNotSupportPreview;//�Ƿ�֧��Ԥ��,1-��֧�֣�0-֧��
			public byte byNotSupportStorage;//�Ƿ�֧�ִ洢,1-��֧�֣�0-֧��
			public byte byUploadLogoMode;//�ϴ�logoģʽ��0-�ϴ�������ͨ����1-�ϴ�����ʾͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSubsystemNumV40, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSubsystemAbility[] struSubSystemAbility;
			public byte by485Nums;//485���ڸ���
			public byte by232Nums;//232���ڸ���
			public byte bySerieStartChan;//��ʼͨ��
			public byte byScreenMode;//����ģʽ��0-�����ɿͻ��˷��䣬1-�������豸�˷���
			public byte byDevVersion;//�豸�汾��0-B10/B11/B12��1-B20
			public byte bySupportBaseMapNums;//��֧�ֵĵ�ͼ������ͼ�Ŵ�1��ʼ
			public ushort wBaseLengthX;//ÿ������С�Ļ�׼ֵ��B20ʹ��
			public ushort wBaseLengthY;
			public byte bySupportPictureTrans;  //�Ƿ�֧��ͼƬ���ԣ�0-��֧�֣�1-֧��	
			public byte bySupportPreAllocDec;   //�Ƿ�֧�����ܽ�����ԴԤ���䣬0-��֧�֣�1-֧��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}       

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSinglescreencfg
		{
			public byte byScreenSeq;//��Ļ��ţ�0xff��ʾ���ô���,64-T��������һ����ʾ����
			public byte bySubSystemNum;//������ϵͳ��λ��,��������ֵû����
			public byte byDispNum;//������ϵͳ�϶�Ӧ��ʾͨ���ţ�64-T�������и�ֵ��ʾ����������ʾͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBigscreencfg
		{
			public uint dwSize;
			public byte byEnable;//����ƴ��ʹ�ܣ�0-��ʹ�ܣ�1-ʹ��
			public byte byModeX;/*����ƴ��ģʽ*/
			public byte byModeY;
			public byte byMainDecodeSystem;//�ۺ�ƽ̨�Ľ�����и�ֵ��ʾ������λ�ţ�64-T�������и�ֵ��ʾ����ͨ����
			public byte byMainDecoderDispChan;//����������ʾͨ���ţ�1.1netra�汾������netra��������������ʾͨ�������ܹ���Ϊ������64-T�и�ֵ��Ч
			public byte byVideoStandard;      //����ÿ��������ʽ��ͬ 1:NTSC,2:PAL
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwResolution;         //����ÿ�������ֱ�����ͬ
			//����ƴ�Ӵ���Ļ��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxBigscreennum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSinglescreencfg[] struFollowSingleScreen;
			//��ʼ�������Ϊ��׼�����������
			public ushort wBigScreenX; //�����ڵ���ǽ����ʼX����
			public ushort wBigScreenY; //�����ڵ���ǽ����ʼY����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			public void Init()
			{
				byRes1 = new byte[2];
				struFollowSingleScreen = new NetDvrSinglescreencfg[MaxBigscreennum];
				byRes2 = new byte[12];
			}
		}       

		/************************************��Ƶ�ۺ�ƽ̨(end)***************************************/
		
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrEmailcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sUserName;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sPassWord;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sFromName;/* Sender *///�ַ����еĵ�һ���ַ������һ���ַ�������"@",�����ַ�����Ҫ��"@"�ַ�
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
			public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTP��*/
			public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
			public byte byAttachment;/* enable attachment */
			public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgNew
		{
			public uint dwSize;
			public NetDvrCompressionInfoEx struLowCompression;//��ʱ¼��
			public NetDvrCompressionInfoEx struEventCompression;//�¼�����¼��
		}

		//���λ����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzpos
		{
			public ushort wAction;//��ȡʱ���ֶ���Ч
			public ushort wPanPos;//ˮƽ����
			public ushort wTiltPos;//��ֱ����
			public ushort wZoomPos;//�䱶����
		}

		//�����Χ��Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPtzscope
		{
			public ushort wPanPosMin;//ˮƽ����min
			public ushort wPanPosMax;//ˮƽ����max
			public ushort wTiltPosMin;//��ֱ����min
			public ushort wTiltPosMax;//��ֱ����max
			public ushort wZoomPosMin;//�䱶����min
			public ushort wZoomPosMax;//�䱶����max
		}

		//rtsp���� ipcameraר��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRtspcfg
		{
			public uint dwSize;//����
			public ushort wPort;//rtsp�����������˿�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
			public byte[] byReserve;//Ԥ��
		}

		/********************************�ӿڲ����ṹ(begin)*********************************/

		//NET_DVR_Login()�����ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeviceinfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//���к�
			public byte byAlarmInPortNum;//DVR�����������
			public byte byAlarmOutPortNum;//DVR�����������
			public byte byDiskNum;//DVRӲ�̸���
			public byte byDVRType;//DVR����, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;//DVR ͨ������
			public byte byStartChan;//��ʼͨ����,����DVS-1,DVR - 1
		}

		//NET_DVR_Login_V30()�����ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeviceinfoV30
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;  //���к�
			public byte byAlarmInPortNum;		        //�����������
			public byte byAlarmOutPortNum;		        //�����������
			public byte byDiskNum;				    //Ӳ�̸���
			public byte byDVRType;				    //�豸����, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;				    //ģ��ͨ������
			public byte byStartChan;			        //��ʼͨ����,����DVS-1,DVR - 1
			public byte byAudioChanNum;                //����ͨ����
			public byte byIPChanNum;					//�������ͨ����������λ  
			public byte byZeroChanNum;			//��ͨ��������� //2010-01-16
			public byte byMainProto;			//����������Э������ 0-private, 1-rtsp,2-ͬʱ֧��private��rtsp
			public byte bySubProto;				//����������Э������0-private, 1-rtsp,2-ͬʱ֧��private��rtsp
			public byte bySupport;        //������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧�֣�
			//bySupport & 0x1, ��ʾ�Ƿ�֧����������
			//bySupport & 0x2, ��ʾ�Ƿ�֧�ֱ���
			//bySupport & 0x4, ��ʾ�Ƿ�֧��ѹ������������ȡ
			//bySupport & 0x8, ��ʾ�Ƿ�֧�ֶ�����
			//bySupport & 0x10, ��ʾ֧��Զ��SADP
			//bySupport & 0x20, ��ʾ֧��Raid������
			//bySupport & 0x40, ��ʾ֧��IPSAN Ŀ¼����
			//bySupport & 0x80, ��ʾ֧��rtp over rtsp
			public byte bySupport1;        // ���������䣬λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
			//bySupport1 & 0x1, ��ʾ�Ƿ�֧��snmp v30
			//bySupport1 & 0x2, ֧�����ֻطź�����
			//bySupport1 & 0x4, �Ƿ�֧�ֲ������ȼ�	
			//bySupport1 & 0x8, �����豸�Ƿ�֧�ֲ���ʱ�����չ
			//bySupport1 & 0x10, ��ʾ�Ƿ�֧�ֶ������������33����
			//bySupport1 & 0x20, ��ʾ�Ƿ�֧��rtsp over http	
			//bySupport1 & 0x80, ��ʾ�Ƿ�֧�ֳ����±�����Ϣ2012-9-28, �һ���ʾ�Ƿ�֧��NET_DVR_IPPARACFG_V40�ṹ��
			public byte bySupport2; /*������λ����Ϊ0��ʾ��֧�֣���0��ʾ֧��							
							bySupport2 & 0x1, ��ʾ�������Ƿ�֧��ͨ��URLȡ������
							bySupport2 & 0x2,  ��ʾ֧��FTPV40
							bySupport2 & 0x4,  ��ʾ֧��ANR
							bySupport2 & 0x8,  ��ʾ֧��CCD��ͨ����������
							bySupport2 & 0x10,  ��ʾ֧�ֲ��������ش���Ϣ����֧��ץ�Ļ����� ���ϱ����ṹ��
							bySupport2 & 0x20,  ��ʾ�Ƿ�֧�ֵ�����ȡ�豸״̬����
							bySupport2 & 0x40,  ��ʾ�Ƿ������������豸*/
			public ushort wDevType;              //�豸�ͺ�
			public byte bySupport3; //��������չ��λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
							//bySupport3 & 0x1, ��ʾ�Ƿ������
							// bySupport3 & 0x4 ��ʾ֧�ְ������ã� ������� ͨ��ͼ��������������������IP�������롢������������
							// �û��������豸����״̬��JPEGץͼ����ʱ��ʱ��ץͼ��Ӳ��������� 
							//bySupport3 & 0x8Ϊ1 ��ʾ֧��ʹ��TCPԤ����UDPԤ�����ಥԤ���е�"��ʱԤ��"�ֶ���������ʱԤ������������ʹ�����ַ�ʽ������ʱԤ����������bySupport3 & 0x8Ϊ0ʱ����ʹ�� "˽����ʱԤ��"Э�顣
							//bySupport3 & 0x10 ��ʾ֧��"��ȡ����������Ҫ״̬��V40��"��
							//bySupport3 & 0x20 ��ʾ�Ƿ�֧��ͨ��DDNS��������ȡ��

			public byte byMultiStreamProto;//�Ƿ�֧�ֶ�����,��λ��ʾ,0-��֧��,1-֧��,bit1-����3,bit2-����4,bit7-��������bit-8������
			public byte byStartDChan;		//��ʼ����ͨ����,0��ʾ��Ч
			public byte byStartDTalkChan;	//��ʼ���ֶԽ�ͨ���ţ�������ģ��Խ�ͨ���ţ�0��ʾ��Ч
			public byte byHighDChanNum;		//����ͨ����������λ
			public byte bySupport4;
			public byte byLanguageType;// ֧����������,��λ��ʾ,ÿһλ0-��֧��,1-֧��  
						//  byLanguageType ����0 ��ʾ ���豸
						//  byLanguageType & 0x1��ʾ֧������
						//  byLanguageType & 0x2��ʾ֧��Ӣ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;		//����
		}

		//sdk���绷��ö�ٱ���������Զ������
		public enum SdkNetworkEnvironment
		{
			LocalAreaNetwork = 0,
			WideAreaNetwork,
		}

		//��ʾģʽ
		public enum DisplayMode
		{
			Normalmode = 0,
			Overlaymode
		}

		//����ģʽ
		public enum SendMode
		{
			Ptoptcpmode = 0,
			Ptopudpmode,
			Multimode,
			Rtpmode,
			Reservedmode
		}

		//ץͼģʽ
		public enum CaptureMode
		{
			BmpMode = 0,		//BMPģʽ
			JpegMode = 1		//JPEGģʽ 
		}

		//ʵʱ����ģʽ
		public enum RealsoundMode
		{
			MonopolizeMode = 1,//��ռģʽ
			ShareMode = 2		//����ģʽ
		}

		public struct NetDvrClientinfo
		{
			public int LChannel;//ͨ����
			public int LLinkMode;//���λ(31)Ϊ0��ʾ��������Ϊ1��ʾ��������0��30λ��ʾ�������ӷ�ʽ: 0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-����Ƶ�ֿ�(TCP)
			public IntPtr HPlayWnd;//���Ŵ��ڵľ��,ΪNULL��ʾ������ͼ��
			public string SMultiCastIp;//�ಥ���ַ
		}

		//SDK״̬��Ϣ(9000����)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSdkstate
		{
			public uint dwTotalLoginNum;//��ǰlogin�û���
			public uint dwTotalRealPlayNum;//��ǰrealplay·��
			public uint dwTotalPlayBackNum;//��ǰ�طŻ�����·��
			public uint dwTotalAlarmChanNum;//��ǰ��������ͨ��·��
			public uint dwTotalFormatNum;//��ǰӲ�̸�ʽ��·��
			public uint dwTotalFileSearchNum;//��ǰ��־���ļ�����·��
			public uint dwTotalLogSearchNum;//��ǰ��־���ļ�����·��
			public uint dwTotalSerialNum;//��ǰ͸��ͨ��·��
			public uint dwTotalUpgradeNum;//��ǰ����·��
			public uint dwTotalVoiceComNum;//��ǰ����ת��·��
			public uint dwTotalBroadCastNum;//��ǰ�����㲥·��
			public uint dwTotalListenNum;	    //��ǰ�������·��
			public uint dwEmailTestNum;       //��ǰ�ʼ�����·��
			public uint dwBackupNum;          // ��ǰ�ļ�����·��
			public uint dwTotalInquestUploadNum; //��ǰ��Ѷ�ϴ�·��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		//SDK����֧����Ϣ(9000����)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSdkabl
		{
			public uint dwMaxLoginNum;//���login�û��� MAX_LOGIN_USERS
			public uint dwMaxRealPlayNum;//���realplay·�� WATCH_NUM
			public uint dwMaxPlayBackNum;//���طŻ�����·�� WATCH_NUM
			public uint dwMaxAlarmChanNum;//���������ͨ��·�� ALARM_NUM
			public uint dwMaxFormatNum;//���Ӳ�̸�ʽ��·�� SERVER_NUM
			public uint dwMaxFileSearchNum;//����ļ�����·�� SERVER_NUM
			public uint dwMaxLogSearchNum;//�����־����·�� SERVER_NUM
			public uint dwMaxSerialNum;//���͸��ͨ��·�� SERVER_NUM
			public uint dwMaxUpgradeNum;//�������·�� SERVER_NUM
			public uint dwMaxVoiceComNum;//�������ת��·�� SERVER_NUM
			public uint dwMaxBroadCastNum;//��������㲥·�� MAX_CASTNUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		//�����豸��Ϣ
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrAlarmer
		{
			public byte byUserIDValid;/* userid�Ƿ���Ч 0-��Ч��1-��Ч */
			public byte bySerialValid;/* ���к��Ƿ���Ч 0-��Ч��1-��Ч */
			public byte byVersionValid;/* �汾���Ƿ���Ч 0-��Ч��1-��Ч */
			public byte byDeviceNameValid;/* �豸�����Ƿ���Ч 0-��Ч��1-��Ч */
			public byte byMacAddrValid; /* MAC��ַ�Ƿ���Ч 0-��Ч��1-��Ч */
			public byte byLinkPortValid;/* login�˿��Ƿ���Ч 0-��Ч��1-��Ч */
			public byte byDeviceIPValid;/* �豸IP�Ƿ���Ч 0-��Ч��1-��Ч */
			public byte bySocketIPValid;/* socket ip�Ƿ���Ч 0-��Ч��1-��Ч */
			public int lUserId; /* NET_DVR_Login()����ֵ, ����ʱ��Ч */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;/* ���к� */
			public uint dwDeviceVersion;/* �汾��Ϣ ��16λ��ʾ���汾����16λ��ʾ�ΰ汾*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = NameLen)]
			public string sDeviceName;/* �豸���� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;/* MAC��ַ */
			public ushort wLinkPort; /* link port */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sDeviceIP;/* IP��ַ */
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sSocketIP;/* ���������ϴ�ʱ��socket IP��ַ */
			public byte byIpProtocol; /* IpЭ�� 0-IPV4, 1-IPV6 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//Ӳ������ʾ�������(�ӽṹ)
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

		//Ӳ����Ԥ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCardinfo
		{
			public int lChannel;//ͨ����
			public int lLinkMode;//���λ(31)Ϊ0��ʾ��������Ϊ1��ʾ�ӣ�0��30λ��ʾ�������ӷ�ʽ:0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-�绰�ߣ�5��128k�����6��256k�����7��384k�����8��512k�����
			[MarshalAs(UnmanagedType.LPStr)]
			public string sMultiCastIP;
			public NetDvrDisplayPara struDisplayPara;
		}

		//¼���ļ�����
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFindData
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//�ļ���
			public NetDvrTime struStartTime;//�ļ��Ŀ�ʼʱ��
			public NetDvrTime struStopTime;//�ļ��Ľ���ʱ��
			public uint dwFileSize;//�ļ��Ĵ�С
		}

		//¼���ļ�����(9000)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFinddataV30
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//�ļ���
			public NetDvrTime struStartTime;//�ļ��Ŀ�ʼʱ��
			public NetDvrTime struStopTime;//�ļ��Ľ���ʱ��
			public uint dwFileSize;//�ļ��Ĵ�С
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
			public byte byLocked;//9000�豸֧��,1��ʾ���ļ��Ѿ�������,0��ʾ�������ļ�
			public byte byFileType;  //�ļ�����:0����ʱ¼��,1-�ƶ���� ��2������������
			//3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼��,7���𶯱�����8-����������9-���ܱ�����10-PIR������11-���߱�����12-���ȱ���,14-���ܽ�ͨ�¼�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//¼���ļ�����(cvr)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFinddataV40
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//�ļ���
			public NetDvrTime struStartTime;//�ļ��Ŀ�ʼʱ��
			public NetDvrTime struStopTime;//�ļ��Ľ���ʱ��
			public uint dwFileSize;//�ļ��Ĵ�С
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
			public byte byLocked;//9000�豸֧��,1��ʾ���ļ��Ѿ�������,0��ʾ�������ļ�
			public byte byFileType;  //�ļ�����:0����ʱ¼��,1-�ƶ���� ��2������������
			//3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼��,7���𶯱�����8-����������9-���ܱ�����10-PIR������11-���߱�����12-���ȱ���,14-���ܽ�ͨ�¼�
			public byte byQuickSearch; //0:��ͨ��ѯ�����1�����٣���������ѯ���
			public byte byRes;
			public uint dwFileIndex; //�ļ�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	
		}

		//¼���ļ�����(������)
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrFinddataCard
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
			public string sFileName;//�ļ���
			public NetDvrTime struStartTime;//�ļ��Ŀ�ʼʱ��
			public NetDvrTime struStopTime;//�ļ��Ľ���ʱ��
			public uint dwFileSize;//�ļ��Ĵ�С
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCardNum;
		}

		//¼���ļ����������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFilecond
		{
			public int lChannel;//ͨ����
			public uint dwFileType;//¼���ļ�����0xff��ȫ����0����ʱ¼��,1-�ƶ���� ��2������������
			//3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼��
			public uint dwIsLocked;//�Ƿ����� 0-�����ļ�,1-�����ļ�, 0xff��ʾ�����ļ�
			public uint dwUseCardNo;//�Ƿ�ʹ�ÿ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNumber;//����
			public NetDvrTime struStartTime;//��ʼʱ��
			public NetDvrTime struStopTime;//����ʱ��
		}

		//��̨����ѡ��Ŵ���С(HIK ����ר��)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPointFrame
		{
			public int xTop;//������ʼ���x����
			public int yTop;//����������y����
			public int xBottom;//����������x����
			public int yBottom;//����������y����
			public int bCounter;//����
		}

		//�����Խ�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionAudio
		{
			public byte byAudioEncType;//��Ƶ�������� 0-G722; 1-G711
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;//���ﱣ����Ƶ��ѹ������ 
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrApInfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = IwEssidMaxSize)]
			public string sSsid;
			public uint dwMode;/* 0 mange ģʽ;1 ad-hocģʽ���μ�NICMODE */
			public uint dwSecurity;  /*0 �����ܣ�1 wep���ܣ�2 wpa-psk;3 wpa-Enterprise���μ�WIFISECURITY*/
			public uint dwChannel;/*1-11��ʾ11��ͨ��*/
			public uint dwSignalStrength;/*0-100�ź���������Ϊ��ǿ*/
			public uint dwSpeed;/*����,��λ��0.01mbps*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrApInfoList
		{
			public uint dwSize;
			public uint dwCount;/*����AP������������20*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = WifiMaxApCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrApInfo[] struApInfo;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrWifiethernet
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpAddress;/*IP��ַ*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sIpMask;/*����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;/*�����ַ��ֻ������ʾ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] bRes;
			public uint dwEnableDhcp;/*�Ƿ�����dhcp  0������ 1����*/
			public uint dwAutoDns;/*�������dhcp�Ƿ��Զ���ȡdns,0���Զ���ȡ 1�Զ���ȡ�����������������dhcpĿǰ�Զ���ȡdns*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFirstDns; /*��һ��dns����*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sSecondDns;/*�ڶ���dns����*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sGatewayIpAddr;/* ���ص�ַ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] bRes2;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionEapTtls
		{
			public byte byEapolVersion; //EAPOL�汾��0-�汾1��1-�汾2
			public byte byAuthType; //�ڲ���֤��ʽ��0-PAP��1-MSCHAPV2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnonyIdentity; //�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName; //�û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword; //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		} //WPA-enterprise/WPA2-enterprisģʽ����

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionEapPeap
		{
			public byte byEapolVersion; //EAPOL�汾��0-�汾1��1-�汾2
			public byte byAuthType; //�ڲ���֤��ʽ��0-GTC��1-MD5��2-MSCHAPV2
			public byte byPeapVersion; //PEAP�汾��0-�汾0��1-�汾1
			public byte byPeapLabel; //PEAP��ǩ��0-�ϱ�ǩ��1-�±�ǩ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAnonyIdentity; //�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName; //�û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword; //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		} //WPA-enterprise/WPA2-enterprisģʽ����

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionEapTls
		{
			public byte byEapolVersion; //EAPOL�汾��0-�汾1��1-�汾2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byIdentity; //���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPrivateKeyPswd; //˽Կ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct WifiAuthParam
		{
			[FieldOffset(0)]
			public UnionEapTtls EAP_TTLS;//WPA-enterprise/WPA2-enterprisģʽ����
			
			[FieldOffset(0)]
			public UnionEapPeap EAP_PEAP; //WPA-enterprise/WPA2-enterprisģʽ����

			[FieldOffset(0)]
			public UnionEapTls EAP_TLS; 
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionWep
		{
			public uint dwAuthentication;/*0 -����ʽ 1-����ʽ*/
			public uint dwKeyLength;/* 0 -64λ��1- 128λ��2-152λ*/
			public uint dwKeyType;/*0 16����;1 ASCI */
			public uint dwActive;/*0 ������0---3��ʾ����һ����Կ*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = WifiWepMaxKeyCount * WifiWepMaxKeyLength)]
			public string sKeyInfo;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionWpaPsk
		{
			public uint dwKeyLength;/*8-63��ASCII�ַ�*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = WifiWpaPskMaxKeyLength)]
			public string sKeyInfo;
			public byte byEncryptType;/*WPA/WPA2ģʽ�¼�������,0-AES, 1-TKIP*/
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct UnionWpaWpa2
		{
			public byte byEncryptType;  /*��������,0-AES, 1-TKIP*/
			public byte byAuthType; //��֤���ͣ�0-EAP_TTLS,1-EAP_PEAP,2-EAP_TLS
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public WifiAuthParam auth_param;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetDvrWifiCfgEx
		{
			public NetDvrWifiethernet struEtherNet;/*wifi����*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = IwEssidMaxSize)]
			public string sEssid;/*SSID*/
			public uint dwMode;/* 0 mange ģʽ;1 ad-hocģʽ���μ�*/
			public uint dwSecurity;/*0 �����ܣ�1 wep���ܣ�2 wpa-psk; */
			[StructLayout(LayoutKind.Explicit)]
			public struct Key
			{
				[FieldOffset(0)]
				public UnionWep wep;

				[FieldOffset(0)]
				public UnionWpaPsk wpa_psk;

				[FieldOffset(0)]
				public UnionWpaWpa2 wpa_wpa2;//WPA-enterprise/WPA2-enterprisģʽ����
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWifiCfg
		{
			public uint dwSize;
			public NetDvrWifiCfgEx struWifiCfg;
		}

		//wifi����״̬
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWifiConnectStatus
		{
			public uint dwSize;
			public byte byCurStatus;	//1-�����ӣ�2-δ���ӣ�3-��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;		//����
			public uint dwErrorCode;	// byCurStatus = 2ʱ��Ч,1-�û������������,2-�޴�·����,3-δ֪����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWifiWorkmode
		{
			public uint dwSize;
			public uint dwNetworkInterfaceMode;/*0 �Զ��л�ģʽ��1 ����ģʽ*/
		}

		//���ܿ�����Ϣ
		public const int MaxVcaChan = 16;//�������ͨ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaCtrlinfo
		{
			public byte byVCAEnable;//�Ƿ�������
			public byte byVCAType;//�����������ͣ�VcaChanAbilityType 
			public byte byStreamWithVCA;//�������Ƿ��������Ϣ
			public byte byMode;//ģʽ��VCA_CHAN_MODE_TYPE ,atm������ʱ����Ҫ����
			public byte byControlType;   //�������ͣ���λ��ʾ��0-��1-��
			// byControlType &1 �Ƿ�����ץ�Ĺ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����������Ϊ0 
		}

		//���ܿ�����Ϣ�ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaCtrlcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVcaChan, ArraySubType = UnmanagedType.Struct)]
			public NetVcaCtrlinfo[] struCtrlInfo;//������Ϣ,����0��Ӧ�豸����ʼͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//�����豸������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaDevAbility
		{
			public uint dwSize;//�ṹ����
			public byte byVCAChanNum;//����ͨ������
			public byte byPlateChanNum;//����ͨ������
			public byte byBBaseChanNum;//��Ϊ���������
			public byte byBAdvanceChanNum;//��Ϊ�߼������
			public byte byBFullChanNum;//��Ϊ���������
			public byte byATMChanNum;//����ATM����
			public byte byPDCChanNum;         //����ͳ��ͨ������
			public byte byITSChanNum;         //��ͨ�¼�ͨ������
			public byte byBPrisonChanNum;     //��Ϊ������(����)ͨ������
			public byte byFSnapChanNum;       //����ץ��ͨ������
			public byte byFSnapRecogChanNum;  //����ץ�ĺ�ʶ��ͨ������
			public byte byFRetrievalChanNum;  //�������������
			public byte bySupport;            //������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
			//bySupport & 0x1����ʾ�Ƿ�֧�����ܸ��� 2012-3-22
			//bySupport & 0x2����ʾ�Ƿ�֧��128·ȡ����չ2012-12-27
			public byte byFRecogChanNum;      //����ʶ��ͨ������
			public byte byBPPerimeterChanNum; //��Ϊ������(�ܽ�)ͨ������
			public byte byTPSChanNum;         //��ͨ�յ�ͨ������
			public byte byTFSChanNum;         //��·Υ��ȡ֤ͨ������
			public byte byFSnapBFullChanNum;  //����ץ�ĺ���Ϊ����ͨ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��Ϊ������������
		public enum VcaAbilityType:uint
		{
			TraversePlaneAbility = 0x01,       //��Խ������
			EnterAreaAbility = 0x02,       //��������
			ExitAreaAbility = 0x04,       //�뿪����
			IntrusionAbility = 0x08,       //����
			LoiterAbility = 0x10,       //�ǻ�
			LeftTakeAbility = 0x20,       //��Ʒ������ȡ
			ParkingAbility = 0x40,       //ͣ��
			RunAbility = 0x80,       //�����ƶ�
			HighDensityAbility = 0x100,      //��Ա�ۼ�
			LfTrackAbility = 0x200,      //�������
			ViolentMotionAbility = 0x400,      //�����˶����
			ReachHightAbility = 0x800,      //�ʸ߼��
			GetUpAbility = 0x1000,     //������
			LeftAbility = 0x2000,     //��Ʒ����
			TakeAbility = 0x4000,     //��Ʒ��ȡ
			LeavePosition = 0x8000,     //���
			TrailAbility = 0x10000,    //β�� 
			KeyPersonGetUpAbility = 0x20000,    //�ص���Ա������
			FallDownAbility = 0x80000,    //����
			AudioAbnormalAbility = 0x100000,   //��ǿͻ��
			AdvReachHeightAbility = 0x200000,   //�����ʸ�
			ToiletTarryAbility = 0x400000,   //��޳�ʱ
			YardTarryAbility = 0x800000,   //�ŷ糡����
			AdvTraversePlaneAbility = 0x1000000,  //���߾�����
			HumanEnterAbility = 0x10000000, //�˿���ATM ,ֻ��ATM_PANELģʽ��֧��
			OverTimeAbility = 0x20000000, //������ʱ,ֻ��ATM_PANELģʽ��֧��
			StickUpAbility = 0x40000000, //��ֽ��
			InstallScannerAbility = 0x80000000  //��װ������
		}

		//����ͨ������
		public enum VcaChanAbilityType
		{
			VcaBehaviorBase = 1,          //��Ϊ����������
			VcaBehaviorAdvance = 2,          //��Ϊ�����߼���
			VcaBehaviorFull = 3,          //��Ϊ����������
			VcaPlate = 4,          //��������
			VcaAtm = 5,          //ATM����
			VcaPdc = 6,          //������ͳ��
			VcaIts = 7,          //���� ��ͨ�¼�
			VcaBehaviorPrison = 8,          //��Ϊ����������(����) 
			VcaFaceSnap = 9,           //����ץ������
			VcaFaceSnaprecog = 10,          //����ץ�ĺ�ʶ������
			VcaFaceRetrieval = 11,          //�������������
			VcaFaceRecog = 12,          //����ʶ������
			VcaBehaviorPrisonPerimeter = 13, // ��Ϊ���������� (�ܽ�)
			VcaTps = 14,          //��ͨ�յ�
			VcaTfs = 15,          //��·Υ��ȡ֤
			VcaBehaviorFacesnap = 16           //����ץ�ĺ���Ϊ��������
		}

		//����ATMģʽ����(ATM��������)
		public enum VcaChanModeType
		{
			VcaAtmPanel = 0,//ATM���
			VcaAtmSurround = 1,//ATM����
			VcaAtmFace = 2	//ATM����
		}
		public enum TfsChanModeType
		{
			TfsCityroad = 0,  //TFS ���е�·
			TfsFreeway = 1   //TFS ���ٵ�·
		}

		//��Ϊ��������ģʽ
		public enum BehaviorSceneModeType
		{
			BehaviorSceneDefault = 0, //ϵͳĬ��
			BehaviorSceneWall = 1,    //Χǽ
			BehaviorSceneIndoor = 2   //����
		}

		//ͨ�������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaChanInParam
		{
			public byte byVCAType;//VCA_CHAN_ABILITY_TYPEö��ֵ
			public byte byMode;//ģʽ��VCA_CHAN_MODE_TYPE ,atm������ʱ����Ҫ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����������Ϊ0 
		}

		//��Ϊ�������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBehaviorAbility
		{
			public uint dwSize;//�ṹ����
			public uint dwAbilityType;//֧�ֵ��������ͣ���λ��ʾ����VCA_ABILITY_TYPE����
			public byte byMaxRuleNum;//��������
			public byte byMaxTargetNum;//���Ŀ����
			public byte bySupport;		// ֧�ֵĹ�������   ��λ��ʾ  
			// bySupport & 0x01 ֧�ֱ궨����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����������Ϊ0
		}

		// ��ͨ�������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrItsAbility
		{
			public uint dwSize;             // �ṹ���С
			public uint dwAbilityType;      // ֧�ֵ������б�  ����ITS_ABILITY_TYPE
			public byte byMaxRuleNum;	 	//��������
			public byte byMaxTargetNum; 	//���Ŀ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    // ����
		}
		/***********************************end*******************************************/

		/************************************���ܲ����ṹ*********************************/
		//���ܹ��ýṹ
		//����ֵ��һ��,������ֵΪ��ǰ����İٷֱȴ�С, ����ΪС�������λ
		//������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPoint
		{
			public float fX;// X������, 0.001~1
			public float fY;//Y������, 0.001~1
		}

		//�����ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRect
		{
			public float fX;//�߽�����Ͻǵ��X������, 0.001~1
			public float fY;//�߽�����Ͻǵ��Y������, 0.001~1
			public float fWidth;//�߽��Ŀ��, 0.001~1
			public float fHeight;//�߽��ĸ߶�, 0.001~1
		}

		//��Ϊ�����¼�����
		public enum VcaEventType : uint
		{
			VcaTraversePlane = 0x1,        //��Խ������
			VcaEnterArea = 0x2,        //Ŀ���������,֧���������
			VcaExitArea = 0x4,        //Ŀ���뿪����,֧���������
			VcaIntrusion = 0x8,        //�ܽ�����,֧���������
			VcaLoiter = 0x10,       //�ǻ�,֧���������
			VcaLeftTake = 0x20,       //��Ʒ������ȡ,֧���������
			VcaParking = 0x40,       //ͣ��,֧���������
			VcaRun = 0x80,       //�����ƶ�,֧���������
			VcaHighDensity = 0x100,      //��������Ա�ۼ�,֧���������
			VcaViolentMotion = 0x200,		 //�����˶����
			VcaReachHight = 0x400,		 //�ʸ߼��
			VcaGetUp = 0x800,	     //������
			VcaLeft = 0x1000,     //��Ʒ����
			VcaTake = 0x2000,     //��Ʒ��ȡ
			VcaLeavePosition = 0x4000,     //���
			VcaTrail = 0x8000,     //β��
			VcaKeyPersonGetUp = 0x10000,    //�ص���Ա������
			VcaFallDown = 0x80000,    //���ؼ��
			VcaAudioAbnormal = 0x100000,   //��ǿͻ����
			VcaAdvReachHeight = 0x200000,   //�����ʸ�
			VcaToiletTarry = 0x400000,   //��޳�ʱ
			VcaYardTarry = 0x800000,   //�ŷ糡����
			VcaAdvTraversePlane = 0x1000000,  //���߾�����
			VcaHumanEnter = 0x10000000, //�˿���ATM           ֻ��ATM_PANELģʽ��֧��
			VcaOverTime = 0x20000000, //������ʱ            ֻ��ATM_PANELģʽ��֧��
			VcaStickUp = 0x40000000, //��ֽ��,֧���������
			VcaInstallScanner = 0x80000000  //��װ������,֧���������
		}

		//��Ϊ�����¼�������չ
		public enum VcaRuleEventTypeEx : ushort
		{
			EnumVcaEventTraversePlane = 1,   //��Խ������
			EnumVcaEventEnterArea = 2,   //Ŀ���������,֧���������
			EnumVcaEventExitArea = 3,   //Ŀ���뿪����,֧���������
			EnumVcaEventIntrusion = 4,   //�ܽ�����,֧���������
			EnumVcaEventLoiter = 5,   //�ǻ�,֧���������
			EnumVcaEventLeftTake = 6,   //��Ʒ������ȡ,֧���������
			EnumVcaEventParking = 7,   //ͣ��,֧���������
			EnumVcaEventRun = 8,   //�����ƶ�,֧���������
			EnumVcaEventHighDensity = 9,   //��������Ա�ۼ�,֧���������
			EnumVcaEventViolentMotion = 10,  //�����˶����
			EnumVcaEventReachHight = 11,  //�ʸ߼��
			EnumVcaEventGetUp = 12,  //������
			EnumVcaEventLeft = 13,  //��Ʒ����
			EnumVcaEventTake = 14,  //��Ʒ��ȡ
			EnumVcaEventLeavePosition = 15,  //���
			EnumVcaEventTrail = 16,  //β��
			EnumVcaEventKeyPersonGetUp = 17,  //�ص���Ա������
			EnumVcaEventFallDown = 20,  //���ؼ��
			EnumVcaEventAudioAbnormal = 21,  //��ǿͻ����
			EnumVcaEventAdvReachHeight = 22,  //�����ʸ�
			EnumVcaEventToiletTarry = 23,  //��޳�ʱ
			EnumVcaEventYardTarry = 24,  //�ŷ糡����
			EnumVcaEventAdvTraversePlane = 25,  //���߾�����
			EnumVcaEventHumanEnter = 29,  //�˿���ATM,ֻ��ATM_PANELģʽ��֧��   
			EnumVcaEventOverTime = 30,  //������ʱ,ֻ��ATM_PANELģʽ��֧��
			EnumVcaEventStickUp = 31,  //��ֽ��,֧���������
			EnumVcaEventInstallScanner = 32   //��װ������,֧���������
		}

		//�����洩Խ��������
		public enum VcaCrossDirection
		{
			VcaBothDirection,// ˫�� 
			VcaLeftGoRight,// �������� 
			VcaRightGoLeft,// �������� 
		}

		//�߽ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLine
		{
			public NetVcaPoint struStart;//��� 
			public NetVcaPoint struEnd; //�յ�

			//             public void Init()
			//             {
			//                 struStart = new NetVcaPoint();
			//                 struEnd = new NetVcaPoint();
			//             }
		}

		//�ýṹ�ᵼ��xaml�������������������������������������ʱ��û���ҵ�  
		//��ʱ���νṹ��
		//����ͽṹ��
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
			public NetVcaLine struPlaneBottom;//������ױ�
			public VcaCrossDirection dwCrossDirection;//��Խ����: 0-˫��1-�����ң�2-���ҵ���
			public byte byRes1;//����
			public byte byPlaneHeight;//������߶�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;

			//             public void Init()
			//             {
			//                 struPlaneBottom = new NET_VCA_LINE();
			//                 struPlaneBottom.Init();
			//                 byRes2 = new byte[38];
			//             }
		}

		//����/�뿪�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaArea
		{
			public NetVcaPolygon struRegion;//����Χ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���ݱ����ӳ�ʱ������ʶ�����д�ͼƬ�����������IO����һ�£�1�뷢��һ����
		//���ֲ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaIntrusion
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;//�����ӳ�ʱ��: 1-120�룬����5�룬�ж�����Ч������ʱ��
			public byte bySensitivity;        //�����Ȳ�������Χ[1-100]
			public byte byRate;               //ռ�ȣ�����������δ����Ŀ��ߴ�Ŀ��ռ��������ı��أ���һ��Ϊ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//�ǻ�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLoiter
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;//�����ǻ������ĳ���ʱ�䣺1-120�룬����10��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//����/�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTakeLeft
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;//��������/��������ĳ���ʱ�䣺1-120�룬����10��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ͣ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaParking
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;//����ͣ����������ʱ�䣺1-120�룬����10��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���ܲ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRun
		{
			public NetVcaPolygon struRegion;//����Χ
			public float fRunDistance;//�˱���������, ��Χ: [0.1, 1.00]
			public byte byRes1;             // �����ֽ�
			public byte byMode;             // 0 ����ģʽ  1 ʵ��ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��Ա�ۼ�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHighDensity
		{
			public NetVcaPolygon struRegion;//����Χ
			public float fDensity;//�ܶȱ���, ��Χ: [0.1, 1.0]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public ushort wDuration;      // ������Ա�ۼ�����������ֵ 20-360s
		}

		//�����˶�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaViolentMotion
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;           //���������˶�������ֵ��1-50��
			public byte bySensitivity;       //�����Ȳ�������Χ[1,5]
			public byte byMode;              //0-����Ƶģʽ��1-����Ƶ����ģʽ��2-����Ƶģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;            //����
		}

		//�ʸ߲���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaReachHight
		{
			public NetVcaLine struVcaLine;   //�ʸ߾�����
			public ushort wDuration; //�����ʸ߱�����ֵ��1-120��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           // �����ֽ�
		}

		//�𴲲���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaGetUp
		{
			public NetVcaPolygon struRegion; //����Χ
			public ushort wDuration;	        //�����𴲱�����ֵ1-100 ��
			public byte byMode;             //������ģʽ,0-��ͨ��ģʽ,1-�ߵ���ģʽ,2-��ͨ����������ģʽ
			public byte bySensitivity;      //�����Ȳ�������Χ[1,10]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    //�����ֽ�
		}

		//��Ʒ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLeft
		{
			public NetVcaPolygon struRegion; // ����Χ
			public ushort wDuration;       // ������Ʒ����������ֵ 10-100��
			public byte bySensitivity;   // �����Ȳ�������Χ[1,5] 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        // �����ֽ�
		}

		// ��Ʒ��ȡ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTake
		{
			public NetVcaPolygon struRegion;     // ����Χ
			public ushort wDuration;      // ������Ʒ��ȡ������ֵ10-100��
			public byte bySensitivity;  // �����Ȳ�������Χ[1,5] 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaOverTime
		{
			public NetVcaPolygon struRegion;    // ����Χ
			public ushort wDuration;  // ��������ʱ����ֵ 4s-60000s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHumanEnter
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;			//�����ֽ�
		}

		//��ֽ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaStickUp
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;//��������ʱ�䣺10-60�룬����10��
			public byte bySensitivity;//�����Ȳ�������Χ[1,5]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//����������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaScanner
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;//��������ʱ�䣺10-60��
			public byte bySensitivity;//�����Ȳ�������Χ[1,5]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//����¼�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLeavePosition
		{
			public NetVcaPolygon struRegion; //����Χ
			public ushort wLeaveDelay;  //���˱���ʱ�䣬��λ��s��ȡֵ1-1800
			public ushort wStaticDelay; //˯������ʱ�䣬��λ��s��ȡֵ1-1800
			public byte byMode;       //ģʽ��0-����¼���1-˯���¼���2-���˯���¼�
			public byte byPersonType; //ֵ���������ͣ�0-����ֵ�ڣ�1-˫��ֵ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //����
		}

		//β�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTrail
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wRes;      /* ���� */
			public byte bySensitivity;       /* �����Ȳ�������Χ[1,5] */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���ز���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFallDown
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDuration;      /* �����¼���ֵ 1-60s*/
			public byte bySensitivity;       /* �����Ȳ�������Χ[1,5] */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��ǿͻ�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAudioAbnormal
		{
			public ushort wDecibel;       //����ǿ��
			public byte bySensitivity;  //�����Ȳ�������Χ[1,5] 
			public byte byAudioMode;    //�������ģʽ��0-�����ȼ�⣬1-�ֱ���ֵ��⣬2-��������ֱ���ֵ��� 
			public byte byEnable;       //ʹ�ܣ��Ƿ���
			public byte byThreshold;    //������ֵ[0,100]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //����   
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAudioException
		{
			public uint dwSize;
			public byte byEnableAudioInException;  //ʹ�ܣ��Ƿ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetVcaAudioAbnormal struAudioAbnormal;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmSched; //����ʱ��
			public NetDvrHandleexceptionV40 struHandleException;  //�쳣����ʽ
			public uint dwMaxRelRecordChanNum;  //����������¼��ͨ�� ����ֻ�������֧������
			public uint dwRelRecordChanNum;     //����������¼��ͨ�� �� ʵ��֧�ֵ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] byRelRecordChan;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaToiletTarry
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDelay;        //��޳�ʱʱ��[1,3600]����λ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaYardTarry
		{
			public NetVcaPolygon struRegion;//����Χ
			public ushort wDelay;        //�ŷ糡����ʱ��[1,120]����λ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAdvReachHeight
		{
			public NetVcaPolygon struRegion; //�ʸ�����
			public uint dwCrossDirection;   //��Խ����(���VCA_CROSS_DIRECTION): 0-˫��1-������2-���ҵ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAdvTraversePlane
		{
			public NetVcaPolygon struRegion; //����������
			public uint dwCrossDirection;   //��Խ����(���VCA_CROSS_DIRECTION): 0-˫��1-������2-���ҵ���
			public byte bySensitivity;      //�����Ȳ�������Χ[1,5] 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		    //�����ֽ�
		}

		//�����¼�����
		[StructLayout(LayoutKind.Explicit)]
		public struct NetVcaEventUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
			public uint[] uLen;//����

			//[FieldOffset(0)]
			//public NET_VCA_TRAVERSE_PLANE struTraversePlane;//��Խ��������� 
			//[FieldOffset(0)]
			//public NET_VCA_AREA struArea;//����/�뿪�������
			//[FieldOffset(0)]
			//public NET_VCA_INTRUSION struIntrusion;//���ֲ���
			//[FieldOffset(0)]
			//public NET_VCA_LOITER struLoiter;//�ǻ�����
			//[FieldOffset(0)]
			//public NET_VCA_TAKE_LEFT struTakeTeft;//����/�������
			//[FieldOffset(0)]
			//public NET_VCA_PARKING struParking;//ͣ������
			//[FieldOffset(0)]
			//public NET_VCA_RUN struRun;//���ܲ���
			//[FieldOffset(0)]
			//public NET_VCA_HIGH_DENSITY struHighDensity;//��Ա�ۼ�����  
			//[FieldOffset(0)]
			//public NET_VCA_VIOLENT_MOTION struViolentMotion;	//�����˶�
			//[FieldOffset(0)]
			//public NET_VCA_REACH_HIGHT struReachHight;      //�ʸ�
			//[FieldOffset(0)]
			//public NET_VCA_GET_UP struGetUp;           //��
			//[FieldOffset(0)]
			//public NET_VCA_LEFT struLeft;            //��Ʒ����
			//[FieldOffset(0)]
			//public NetVcaTake struTake;            // ��Ʒ��ȡ
			//[FieldOffset(0)]
			//public NetVcaHumanEnter struHumanEnter;      //��Ա����
			//[FieldOffset(0)]
			//public NetVcaOverTime struOvertime;        //������ʱ
			//[FieldOffset(0)]
			//public NetVcaStickUp struStickUp;//��ֽ��
			//[FieldOffset(0)]
			//public NetVcaScanner struScanner;//����������
			//[FieldOffset(0)]
			//public NetVcaLeavePosition struLeavePos;        //��ڲ���
			//[FieldOffset(0)]
			//public NetVcaTrail struTrail;           //β�����
			//[FieldOffset(0)]
			//public NetVcaFallDown struFallDown;        //���ز���
			//[FieldOffset(0)]
			//public NetVcaAudioAbnormal struAudioAbnormal;   //��ǿͻ��
			//[FieldOffset(0)]
			//public NetVcaAdvReachHeight struReachHeight;     //�����ʸ߲���
			//[FieldOffset(0)]
			//public NetVcaToiletTarry struToiletTarry;     //��޳�ʱ����
			//[FieldOffset(0)]
			//public NetVcaYardTarry struYardTarry;       //�ŷ糡��������
			//[FieldOffset(0)]
			//public NetVcaAdvTraversePlane struAdvTraversePlane;//���߾��������            
		}

		// �ߴ����������
		public enum SizeFilterMode
		{
			ImagePixMode,//�������ش�С����
			RealWorldMode,//����ʵ�ʴ�С����
			DefaultMode 	// Ĭ��ģʽ
		}

		//�ߴ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSizeFilter
		{
			public byte byActive;//�Ƿ񼤻�ߴ������ 0-�� ��0-��
			public byte byMode;//������ģʽSIZE_FILTER_MODE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//��������0
			public NetVcaRect struMiniRect;//��СĿ���,ȫ0��ʾ������
			public NetVcaRect struMaxRect;//���Ŀ���,ȫ0��ʾ������
		}

		//�������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaOneRule
		{
			public byte byActive;//�Ƿ񼤻����,0-��,��0-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����������Ϊ0�ֶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//��������
			public VcaEventType dwEventType;//��Ϊ�����¼�����
			public NetVcaEventUnion uEventParam;//��Ϊ�����¼�����
			public NetVcaSizeFilter struSizeFilter;//�ߴ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;//����ʽ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
		}

		//��Ϊ�������ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRulecfg
		{
			public uint dwSize;//�ṹ����
			public byte byPicProType;//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrJpegpara struPictureParam;//ͼƬ���ṹ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaOneRule[] struRule;//��������
		}

		//�ߴ���˲���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFilterStrategy
		{
			public byte byStrategy;      //�ߴ���˲��� 0 - ������ 1-�߶ȺͿ�ȹ���,2-�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       //����
		}

		//���򴥷�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRuleTriggerParam
		{
			public byte byTriggerMode;   //����Ĵ�����ʽ��0- �����ã�1- �켣�� 2- Ŀ����� 
			public byte byTriggerPoint;  //�����㣬������ʽΪ�켣��ʱ��Ч 0- ��,1-��,2-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       //����
			public float fTriggerArea;    //����Ŀ������ٷֱ� [0,100]��������ʽΪĿ�����ʱ��Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;       //����
		}

		//�������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaOneRuleV41
		{
			public byte byActive; //�Ƿ񼤻����,0-��,��0-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //����������Ϊ0�ֶ�
			public ushort wEventTypeEx; //��Ϊ�¼�������չ�����ڴ����ֶ�dwEventType���ο�VCA_RULE_EVENT_TYPE_EX
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName; //��������
			public VcaEventType dwEventType;	//��Ϊ�¼����ͣ�������Ϊ�˼��ݣ���������ʹ��wEventTypeEx��ȡ�¼�����
			public NetVcaEventUnion uEventParam; //��Ϊ�����¼�����
			public NetVcaSizeFilter struSizeFilter;  //�ߴ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;	//����ʽ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			public ushort wAlarmDelay; //���ܱ�����ʱ��0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //����
			public NetVcaFilterStrategy struFilterStrategy; //�ߴ���˲���
			public NetVcaRuleTriggerParam struTriggerParam;   //���򴥷�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��Ϊ�������ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRulecfgV41
		{
			public uint dwSize;			//�ṹ����
			public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			public byte byUpLastAlarm; //2011-04-06 �Ƿ����ϴ����һ�εı���
			public byte byPicRecordEnable;  /*2012-3-1�Ƿ�����ͼƬ�洢, 0-������, 1-����*/
			public byte byRes1;
			public NetDvrJpegpara struPictureParam; 		//ͼƬ���ṹ	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaOneRuleV41[] struRule;  //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��Ŀ��ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaTargetInfo
		{
			public uint dwID;//Ŀ��ID ,��Ա�ܶȹ��߱���ʱΪ0
			public NetVcaRect struRect; //Ŀ��߽�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		//�򻯵Ĺ�����Ϣ, ��������Ļ�����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRuleInfo
		{
			public byte byRuleID;//����ID,0-7
			public byte byRes;//����
			public ushort wEventTypeEx;   //��Ϊ�¼�������չ�����ڴ����ֶ�dwEventType���ο�VCA_RULE_EVENT_TYPE_EX
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//��������
			public VcaEventType dwEventType;//�����¼�����
			public NetVcaEventUnion uEventParam;//�¼�����
		}

		//ǰ���豸��ַ��Ϣ�����ܷ����Ǳ�ʾ����ǰ���豸�ĵ�ַ��Ϣ�������豸��ʾ�����ĵ�ַ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaDevInfo
		{
			public NetDvrIpaddr struDevIP;//ǰ���豸��ַ��
			public ushort wPort;//ǰ���豸�˿ںţ� 
			public byte byChannel;//ǰ���豸ͨ����
			public byte byRes;// �����ֽ�
		}

		//��Ϊ��������ϱ��ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRuleAlarm
		{
			public uint dwSize;//�ṹ����
			public uint dwRelativeTime;//���ʱ��
			public uint dwAbsTime;//����ʱ��
			public NetVcaRuleInfo struRuleInfo;//�¼�������Ϣ
			public NetVcaTargetInfo struTargetInfo;//����Ŀ����Ϣ
			public NetVcaDevInfo struDevInfo;//ǰ���豸��Ϣ
			public uint dwPicDataLen;//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����*/
			public byte byPicType;		//  0-��ͨͼƬ 1-�Ա�ͼƬ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;//����������Ϊ0
			public IntPtr pImage;//ָ��ͼƬ��ָ��
		}

		//��Ϊ��������DSP��Ϣ���ӽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaDrawMode
		{
			public uint dwSize;
			public byte byDspAddTarget;//�����Ƿ����Ŀ��
			public byte byDspAddRule;//�����Ƿ���ӹ���
			public byte byDspPicAddTarget;//ץͼ�Ƿ����Ŀ��
			public byte byDspPicAddRule;//ץͼ�Ƿ���ӹ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��������
		public enum ObjectTypeEnum
		{
			EnumObjectTypeCoat = 1  //����
		}

		//������ɫ�����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrObjectColorCond
		{
			public uint dwChannel;   //ͨ����
			public uint dwObjType;   //�������ͣ��μ�OBJECT_TYPE_ENUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //����
		}

		//ͼƬ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPic
		{
			public byte byPicType;        //ͼƬ���ͣ�1-jpg
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;        //����
			public uint dwPicWidth;       //ͼƬ���
			public uint dwPicHeight;      //ͼƬ�߶�
			public uint dwPicDataLen;     //ͼƬ����ʵ�ʴ�С
			public uint dwPicDataBuffLen; //ͼƬ���ݻ�������С
			public IntPtr byPicDataBuff;    //ͼƬ���ݻ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;       //����
		}

		//��ɫ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrObjectColorUnion
		{
			public NetDvrColor struColor;   //��ɫֵ
			public NetDvrPic struPicture; //ͼƬ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //����
		}

		//������ɫ�����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrObjectColor
		{
			public uint dwSize;       //�ṹ���С
			public byte byEnable;     //0-�����ã�1-����
			public byte byColorMode;  //ȡɫ��ʽ��1-��ɫֵ��2-ͼƬ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //����
			public NetDvrObjectColorUnion uObjColor; //������ɫ�����壬ȡֵ������ȡɫ��ʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //����
		}

		//��������
		public enum AreaTypeEnum
		{
			EnumOverlapRegion = 1,//��ͬ����
			EnumBedLocation = 2   //����λ��
		}

		//��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAuxarea
		{
			public uint dwAreaType;   //�������ͣ��μ�AREA_TYPE_ENUM
			public byte byEnable;     //0-�����ã�1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;     //����
			public NetVcaPolygon struPolygon; //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //����
		}

		//���������б�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAuxareaList
		{
			public uint dwSize;	// �ṹ���С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAuxareaNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAuxarea[] struArea; //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	// ����
		}

		//ͨ������ģʽ
		public enum ChanWorkmodeEnum
		{
			EnumChanWorkmodeIndependent = 1,  //����ģʽ
			EnumChanWorkmodeMaster = 2,      //��ģʽ
			EnumChanWorkmodeSlave = 3        //��ģʽ
		}

		//ͨ������ģʽ�����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannelWorkmode
		{
			public uint dwSize;        //�ṹ���С
			public byte byWorkMode;    //����ģʽ���μ�CHAN_WORKMODE_ENUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //����
		}

		//�豸ͨ�������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChannel
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byAddress;	//�豸IP������
			public ushort wDVRPort;			 	    //�˿ں�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                   //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	        //�����û���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;       //��������
			public uint dwChannel;                   //ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                  //����
		}

		//��ͨ����Ϣ������
		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrSlaveChannelUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //�������С
			[FieldOffset(0)]
			public uint dwLocalChannel;    //����ͨ��
			[FieldOffset(0)]
			public NetDvrChannel struRemoteChannel; //Զ��ͨ��
		}

		//��ͨ�������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSlaveChannelParam
		{
			public byte byChanType;   //��ͨ�����ͣ�1-����ͨ����2-Զ��ͨ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //����
			public NetDvrSlaveChannelUnion uSlaveChannel; //��ͨ�������壬ȡֵ������byChanType
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //����
		}


		//��ͨ���������ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSlaveChannelCfg
		{
			public uint dwSize;   //�ṹ���С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSlaveChannelNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSlaveChannelParam[] struChanParam;//��ͨ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
		}

		//��Ƶ������ϼ���¼�
		public enum VqdEventEnum
		{
			EnumVqdEventBlur = 1,  //ͼ��ģ��
			EnumVqdEventLuma = 2,  //�����쳣
			EnumVqdEventChroma = 3,  //ͼ��ƫɫ
			EnumVqdEventSnow = 4,  //ѩ������
			EnumVqdEventStreak = 5,  //���Ƹ���
			EnumVqdEventFreeze = 6,  //���涳��
			EnumVqdEventSignalLoss = 7,  //�źŶ�ʧ
			EnumVqdEventPtz = 8,  //��̨ʧ��
			EnumVqdEventScneneChange = 9,  //����ͻ��
			EnumVqdEventVideoAbnormal = 10, //��Ƶ�쳣
			EnumVqdEventVideoBlock = 11, //��Ƶ�ڵ�
		}

		//��Ƶ��������¼������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdEventCond
		{
			public uint dwChannel;   //ͨ����
			public uint dwEventType; //����¼����ͣ��μ�VQD_EVENT_ENUM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //����
		}

		//��Ƶ��������¼�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdEventParam
		{
			public byte byThreshold;    //������ֵ����Χ[0,100]
			public byte byTriggerMode;  //1-����������2-���δ���
			public byte byUploadPic;    //0-���ϴ�ͼƬ��1-�ϴ�ͼƬ�������Ƿ��ϴ�ͼƬ���º󶼿��Դ��豸��ȡ���¼�����Ӧ���µ�һ�ű���ͼƬ���μ��ӿ�NET_DVR_StartDownload
			public byte byRes1;         //����
			public uint dwTimeInterval; //������������ʱ��������Χ[0,3600] ��λ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;     //����
		}

		//��Ƶ��������¼�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdEventRule
		{
			public uint dwSize;       //�ṹ���С 
			public byte byEnable;     //0-�����ã�1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //����
			public NetDvrVqdEventParam struEventParam; //��Ƶ��������¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//���ʱ��
			public NetDvrHandleexceptionV30 struHandleType;  //����ʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIvmsIpChannel, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //����������¼��ͨ����1��ʾ������ͨ����0��ʾ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //����
		}

		//��׼��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBaselineScene
		{
			public uint dwSize;     //�ṹ���С
			public byte byEnable;   //0-�����ã�1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
		}

		//��׼�������������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrControlBaselineSceneParam
		{
			public uint dwSize;     //�ṹ���С
			public uint dwChannel;  //ͨ����
			public byte byCommand;  //�������ͣ�1-���ֶα������ݲ�ʹ�ã�2-���»�׼����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
		}

		//��Ƶ������ϱ����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVqdAlarm
		{
			public uint dwSize;                //�ṹ���С
			public uint dwRelativeTime;        //���ʱ��
			public uint dwAbsTime;	          //����ʱ��
			public NetVcaDevInfo struDevInfo; //ǰ���豸��Ϣ 
			public uint dwEventType;           //�¼����ͣ��ο�VQD_EVENT_ENUM
			public float fThreshold;            //������ֵ[0.000,1.000]
			public uint dwPicDataLen;          //ͼƬ���ȣ�Ϊ0��ʾû��ͼƬ
			public IntPtr pImage;               //ָ��ͼƬ��ָ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;            //����
		}

		//�궨���ӽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCbPoint
		{
			public NetVcaPoint struPoint;     //�궨�㣬���������ǹ����
			public NetDvrPtzpos struPtzPos;  //��������PTZ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//�궨�������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackCalibrationParam
		{
			public byte byPointNum;			//��Ч�궨�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCalibPt, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCbPoint[] struCBPoint; //�궨����
		}

		//������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackCfg
		{
			public uint dwSize;				//�ṹ����	
			public byte byEnable;				//�궨ʹ��
			public byte byFollowChan;          // �����ƵĴ�ͨ��
			public byte byDomeCalibrate;			//�������ܸ�������궨��1���� 0������ 
			public byte byRes;					// �����ֽ�
			public NetDvrTrackCalibrationParam struCalParam; //�궨����
		}

		//����ģʽ
		public enum TrackMode
		{
			ManualCtrl = 0,  //�ֶ�����
			AlarmTrack    //������������
		}

		//�ֶ����ƽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrManualCtrlInfo
		{
			public NetVcaPoint struCtrlPoint;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//����ģʽ�ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackMode
		{
			public uint dwSize;		//�ṹ����
			public byte byTrackMode;   //����ģʽ
			public byte byRuleConfMode;   //�������ø���ģʽ0-�������ø��٣�1-Զ�����ø���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //��������0
			[StructLayout(LayoutKind.Explicit)]
			public struct UModeParam
			{
				[FieldOffset(0)]
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
				public uint[] dwULen;
				[FieldOffset(0)]
				public NetDvrManualCtrlInfo struManualCtrl;//�ֶ����ٽṹ
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAlarmJpeg
		{
			public byte byPicProType;	    /*����ʱͼƬ����ʽ 0-������ 1-�ϴ�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //�����ֽ�
			public NetDvrJpegpara struPicParam; 				/*ͼƬ���ṹ*/
		}

		//��������Ϊ��������ṹ
		//�������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsOneRule
		{
			public byte byActive;/* �Ƿ񼤻����,0-��, ��0-�� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����������Ϊ0�ֶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//��������
			public VcaEventType dwEventType;//��Ϊ�����¼�����
			public NetVcaEventUnion uEventParam;//��Ϊ�����¼�����
			public NetVcaSizeFilter struSizeFilter;//�ߴ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;/*����������Ϊ0*/
		}

		// �����ǹ���ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsRulecfg
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetIvmsOneRule[] struRule; //��������
		}

		// IVMS��Ϊ�������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsBehaviorcfg
		{
			public uint dwSize;
			public byte byPicProType;//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrJpegpara struPicParam;//ͼƬ���ṹ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetIvmsRulecfg[] struRuleCfg;//ÿ��ʱ��ζ�Ӧ����
		}

		//���ܷ�����ȡ���ƻ��ӽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsDevsched
		{
			public NetDvrSchedtime struTime;//ʱ�����
			public NetDvrPuStreamCfg struPUStream;//ǰ��ȡ������
		}

		//���ܷ����ǲ������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsStreamcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetIvmsDevsched[] struDevSched;//��ʱ�������ǰ��ȡ���Լ�������Ϣ
		}

		//��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaMaskRegion
		{
			public byte byEnable;//�Ƿ񼤻�, 0-�񣬷�0-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//��������0
			public NetVcaPolygon struPolygon;//���ζ����
		}

		//������������ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaMaskRegionList
		{
			public uint dwSize;//�ṹ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //��������0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxMaskRegionNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaMaskRegion[] struMask;//������������
		}

		//ATM�����������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaEnterRegion
		{
			public uint dwSize;
			public byte byEnable;//�Ƿ񼤻0-�񣬷�0-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetVcaPolygon struPolygon;//��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//IVMS������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsMaskRegionList
		{
			public uint dwSize;//�ṹ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetVcaMaskRegionList[] struList;
		}

		//IVMS��ATM�����������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsEnterRegion
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetVcaEnterRegion[] struEnter;//��������
		}

		// ivms ����ͼƬ�ϴ��ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsAlarmJpeg
		{
			public byte byPicProType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrJpegpara struPicParam;
		}

		// IVMS ���������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetIvmsSearchcfg
		{
			public uint dwSize;
			public NetDvrMatrixDecRemotePlay struRemotePlay;// Զ�̻ط�
			public NetIvmsAlarmJpeg struAlarmJpeg;// �����ϴ�ͼƬ����
			public NetIvmsRulecfg struRuleCfg;//IVMS ��Ϊ��������
		}

		/************************************end******************************************/
		//NAS��֤����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIdentificationParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;		/* �û��� 32*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;		/* ���� 16*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	//����
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrMountParamUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
			public byte[] uLen;   //������ṹ��С
			[FieldOffset(0)]
			public NetDvrIdentificationParam struIdentificationParam;//(SMB/CIFSʱ��Ч)
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNasMountParam
		{
			public byte byMountType; //0������,1~NFS, 2~ SMB/CIFS
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrMountParamUnion uMountParam;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrMountmethodParamUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
			public byte[] uLen; //������ṹ��С   
			[FieldOffset(0)]
			public NetDvrNasMountParam struNasMountParam;//NAS���ط�ʽ (byNetDiskTypeΪNFS(NAS)ʱ��Ч) 
		}

		//����Ӳ�̽ṹ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSingleNetDiskInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����
			public NetDvrIpaddr struNetDiskAddr;//����Ӳ�̵�ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PathnameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDirectory;// PATHNAME_LEN = 128
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//����
		}

		public const int MaxNetDisk = 16;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNetDiskcfg
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNetDisk, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSingleNetDiskInfo[] struNetDiskParam;
		}

		//�¼�����
		//������
		public enum MainEventType
		{
			EventMotDet = 0,//�ƶ����
			EventAlarmIn = 1,//��������
			EventVcaBehavior = 2,//��Ϊ����
			EventInquest = 3,       //��Ѷ�¼�
			EventVcaDetection = 4, //�������
			EventStreamInfo = 100  //��ID��Ϣ
		}

		public const int InquestStartInfo = 0x1001;      /*Ѷ�ʿ�ʼ��Ϣ*/
		public const int InquestStopInfo = 0x1002;       /*Ѷ��ֹͣ��Ϣ*/
		public const int InquestTagInfo = 0x1003;       /*�ص�����Ϣ*/
		public const int InquestSegmentInfo = 0x1004;      /*��ѶƬ��״̬��Ϣ*/

		public enum VcaDetectionMinorType:uint
		{
			EventVcaTraversePlane = 1,        //Խ�����
			EventFieldDetection,		     //�����������
			EventAudioInputAlarm,      //��Ƶ�����쳣
			EventSoundIntensityAlarm,   //��ǿͻ�����
			EventFaceDetection,             //�������
			EventVirtualFocusAlarm, /*�齹���*/
			EventSceneChangeAlarm, /*����������*/
			EventAll = 0xffffffff				//��ʾȫ��
		}

		//��Ϊ���������Ͷ�Ӧ�Ĵ����ͣ� 0xffff��ʾȫ��
		public enum BehaviorMinorType
		{
			EventTraversePlane = 0,// ��Խ������,
			EventEnterArea,//Ŀ���������,֧���������
			EventExitArea,//Ŀ���뿪����,֧���������
			EventIntrusion,// �ܽ�����,֧���������
			EventLoiter,//�ǻ�,֧���������
			EventLeftTake,//�������,֧���������
			EventParking,//ͣ��,֧���������
			EventRun,//����,֧���������
			EventHighDensity,//��������Ա�ܶ�,֧���������
			EventStickUp,//��ֽ��,֧���������
			EventInstallScanner,//��װ������,֧���������
			EventOperateOverTime,        // ������ʱ
			EventFaceDetect,              // �쳣����
			EventLeft,                     // ��Ʒ����
			EventTake,                      // ��Ʒ��ȡ
			EventLeavePosition,         //����¼�
			EventTrailInfo = 16,            //β��
			EventFallDownInfo = 19,                 //����
			EventObjectPaste = 20,		// ����ճ������
			EventFaceCaptureInfo = 21,                //��������
			EventMultiFacesInfo = 22,                  //��������
			EventAudioAbnormalInfo = 23,             //��ǿͻ��
			EventDetect = 24     			   //�������
		}

		// ������100����Ӧ��С����
		public enum StreamInfoMinorType
		{
			EventStreamId = 0,				// ��ID
			EventTiming = 1,					// ��ʱ¼��
			EventMotionDetect = 2,			// �ƶ����
			EventAlarm = 3,					// ����¼��
			EventAlarmOrMotionDetect = 4,	// �������ƶ����
			EventAlarmAndMotionDetect = 5,	// �������ƶ����
			EventCommandTrigger = 6,			// �����
			EventMannual = 7,					// �ֶ�¼��
			EventBackupVolume = 8				// �浵��¼��
		}

		//��ŵCVR
		public const int MaxIdCount = 256;
		public const int MaxStreamIdCount = 1024;
		public const int StreamIdLen = 32;
		public const int PlanIdLen = 32;

		// ����Ϣ - 72�ֽڳ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamInfo
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = StreamIdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byID;      //ID����
			public uint dwChannel;                //�����豸ͨ��������0xffffffffʱ����ʾ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                //����
			public void Init()
			{
				byID = new byte[StreamIdLen];
				byRes = new byte[32];
			}
		}

		//�¼��������� 200-04-07 9000_1.1
		public const int SearchEventInfoLen = 300;

		//��������
		[StructLayout(LayoutKind.Sequential)]
		public struct EventAlarmBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInNo;//��������ţ�byAlarmInNo[0]����1���ʾ�����ɱ�������1�������¼�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen - MaxAlarminV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byAlarmInNo = new byte[MaxAlarminV30];
				byRes = new byte[SearchEventInfoLen - MaxChannumV30];
			}
		}

		//�������� ��ֵ��ʾ
		[StructLayout(LayoutKind.Sequential)]
		public struct EventAlarmByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
			public ushort[] wAlarmInNo;//��������ţ�byAlarmInNo[0]����1���ʾ�����ɱ�������1�������¼�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				wAlarmInNo = new ushort[128];
				byRes = new byte[44];
			}
		}

		//�ƶ����
		[StructLayout(LayoutKind.Sequential)]
		public struct EventMotionBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotDetChanNo;//�ƶ����ͨ����byMotDetChanNo[0]����1���ʾ������ͨ��1�����ƶ���ⴥ�����¼�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen - MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byMotDetChanNo = new byte[MaxChannumV30];
				byRes = new byte[SearchEventInfoLen - MaxChannumV30];
			}
		}

		//�ƶ����--��ֵ
		[StructLayout(LayoutKind.Sequential)]
		public struct EventMotionByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
			public ushort[] wMotDetChanNo;//��������ţ�byAlarmInNo[0]����1���ʾ�����ɱ�������1�������¼�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				wMotDetChanNo = new ushort[64];
				byRes = new byte[172];
			}
		}

		//��Ϊ����
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcaBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byChanNo;//�����¼���ͨ��
			public byte byRuleID;//����ID��0xff��ʾȫ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����

			public void Init()
			{
				byChanNo = new byte[MaxChannumV30];
				byRes1 = new byte[235];
			}
		}

		//��Ϊ����--��ֵ��ʽ���� 
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcaByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
			public ushort[] wChanNo;	//�����¼���ͨ��			
			public byte byRuleID;      //��Ϊ�������ͣ�����0xff��ʾȫ������0��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	 /*����*/
			public void Init()
			{
				wChanNo = new ushort[64];
				byRes = new byte[171];
			}
		}

		//��Ѷ�¼���������
		[StructLayout(LayoutKind.Sequential)]
		public struct EventInquestParam
		{			
			public byte byRoomIndex;    //��Ѷ�ұ��,��1��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //����
			public void Init()
			{
				byRes = new byte[299];
			}
		}

		//��������������
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcadetectBybit
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
			public byte[] byChan;//������������ͨ���ţ��������±��ʾ��byChan[0]����1���ʾ������ͨ��1�����ƶ���ⴥ�����¼� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //����
			public void Init()
			{
				byChan = new byte[256];
				byRes = new byte[44];
			}
		}
		
		//�������������� ��ͨ���Ű�ֵ��ʾ
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcadetectByvalue
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30-1, ArraySubType = UnmanagedType.U4)]
			public uint[] dwChanNo;// ����ͨ����,��ֵ��ʾ��0xffffffff��Ч���Һ�������Ҳ��ʾ��Чֵ
			public byte byAll;//0-��ʾ����ȫ����1-��ʾȫ����
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
			public NetDvrStreamInfo struIDInfo; // ��id��Ϣ��72�ֽڳ�
			public uint dwCmdType;  // �ⲿ�������ͣ�NVR�����ƴ洢ʹ��
			public byte byBackupVolumeNum; //�浵��ţ�CVRʹ��
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
			public ushort wMajorType;//0-�ƶ���⣬1-��������, 2-�����¼�
			public ushort wMinorType;//����������- ���������ͱ仯��0xffff��ʾȫ��
			public NetDvrTime struStartTime;//�����Ŀ�ʼʱ�䣬ֹͣʱ��: ͬʱΪ(0, 0) ��ʾ�������ʱ�俪ʼ���������ǰ���4000���¼�
			public NetDvrTime struEndTime;
			public byte byLockType;		// 0xff-ȫ����0-δ����1-����
			public byte byValue;			//0-��λ��ʾ��1-��ֵ��ʾ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
			public SearchEventUnion uSeniorPara;
		}

		//����������
		[StructLayout(LayoutKind.Sequential)]
		public struct EventAlarmRet
		{
			public uint dwAlarmInNo;//���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[SearchEventInfoLen];
			}
		}
		//�ƶ������
		[StructLayout(LayoutKind.Sequential)]
		public struct EventMotionRet
		{
			public uint dwMotDetNo;//�ƶ����ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SearchEventInfoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;

			public void Init()
			{
				byRes = new byte[SearchEventInfoLen];
			}
		}
		//��Ϊ������� 
		[StructLayout(LayoutKind.Sequential)]
		public struct EventVcaRet
		{
			public uint dwChanNo;//�����¼���ͨ����
			public byte byRuleID;//����ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;//��������
			public NetVcaEventUnion uEvent;//��Ϊ�¼�������wMinorType = VCA_EVENT_TYPE�����¼�����

			public void Init()
			{
				byRes1 = new byte[3];
				byRuleName = new byte[NameLen];
			}
		}

		//��Ѷ�¼���ѯ��� 
		[StructLayout(LayoutKind.Sequential)]
		public struct EventInquestRet
		{
			public byte byRoomIndex;  //��Ѷ�ұ��,��1��ʼ
			public byte byDriveIndex; //��¼�����,��1��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //����            
			public uint dwSegmentNo;     //��Ƭ���ڱ�����Ѷ�е����,��1��ʼ 
			public ushort wSegmetSize;     //��Ƭ�ϵĴ�С, ��λM 
			public ushort wSegmentState;   //��Ƭ��״̬ 0 ��¼������1 ��¼�쳣��2 ����¼��Ѷ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;     //����

			public void Init()
			{
				byRes1 = new byte[6];
				byRes2 = new byte[288];
			}
		}

		//��id¼���ѯ���
		[StructLayout(LayoutKind.Sequential)]
		public struct EventStreamidRet
		{
			public uint dwRecordType;	//¼������ 0-��ʱ¼�� 1-�ƶ���� 2-����¼�� 3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼�� 7-�𶯱��� 8-�������� 9-���ܱ��� 10-�ش�¼��
			public uint dwRecordLength;	//¼���С
			public byte byLockFlag;    // ������־ 0��û���� 1������
			public byte byDrawFrameType;    // 0���ǳ�֡¼�� 1����֡¼��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byFileName; 	//�ļ���
			public uint dwFileIndex;    		// �浵���ϵ��ļ�����
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
		//���ҷ��ؽ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSearchEventRet
		{
			public ushort wMajorType;//������MA
			public ushort wMinorType;//������
			public NetDvrTime struStartTime;//�¼���ʼ��ʱ��
			public NetDvrTime struEndTime;//�¼�ֹͣ��ʱ�䣬�����¼�ʱ�Ϳ�ʼʱ��һ��
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

		// �궨��������
		public enum TagCalibrateType
		{
			PdcCalibrate  = 0x01,  // PDC �궨
			BehaviorOutCalibrate  = 0x02, //��Ϊ���ⳡ���궨  
			BehaviorInCalibrate = 0x03,    // ��Ϊ���ڳ����궨 
			ItsCalbirete       = 0x04      //  ��ͨ�¼��궨
		}

		public const int MaxRectNum = 6;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRectList
		{	
			public byte byRectNum;    // ���ο�ĸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //�����ֽ� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRectNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaRect[] struVcaRect; // ���Ϊ6��Rect 
		}

		// PDC �궨����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcCalibration
		{
			public NetDvrRectList struRectList;       // �궨���ο��б�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // �����ֽ� 
		}

		// �궨�ߵ��������������ʾ��ǰ�궨����ʵ�ʱ�ʾ���Ǹ߶��߻��ǳ����ߡ�
		public enum LineMode
		{
			HeightLine,        //�߶�������
			LengthLine        //����������
		}
		/*�����ñ궨��Ϣ��ʱ�������Ӧλ������ʹ�ܣ���������ز�������û������ʹ�ܣ���궨����Ի�ȡ��ص����������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraParam
		{
			public byte byEnableHeight;     // �Ƿ�ʹ������������߶���
			public byte byEnableAngle;      // �Ƿ�ʹ����������������Ƕ�
			public byte byEnableHorizon;    // �Ƿ�ʹ�������������ƽ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // �����ֽ� 
			public float  fCameraHeight;    // ������߶�
			public float  fCameraAngle;     // ����������Ƕ�
			public float  fHorizon;         // �����еĵ�ƽ��
		}
		
		/*��fValue��ʾĿ��߶ȵ�ʱ��struStartPoint��struEndPoint�ֱ��ʾĿ��ͷ����ͽŲ��㡣
		 * ��fValue��ʾ�߶γ��ȵ�ʱ��struStartPoint��struEndPoint�ֱ��ʾ�߶���ʼ����յ㣬
		 * mode��ʾ��ǰ�����߱�ʾ�߶��߻��ǳ����ߡ�*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLineSegment
		{
			public byte byLineMode;     // ���� LINE_MODE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // �����ֽ� 
			public NetVcaPoint   struStartPoint;  
			public NetVcaPoint   struEndPoint;
			public float fValue;
		}

		public const int MaxLineSegNum = 8;

		/*�궨������Ŀǰ��Ҫ4-8�������ߣ��Ի�ȡ�������ز���*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBehaviorOutCalibration
		{
			public uint dwLineSegNum;          // �����߸���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLineSegNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLineSegment[]  struLineSegment;    // ������������
			public NetDvrCameraParam  struCameraParam;    // ���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*�ýṹ���ʾIAS���ܿ�궨���������а���һ��Ŀ����һ����Ӧ�ĸ߶ȱ궨�ߣ�
		 * Ŀ���Ϊվ����������Ӿ��ο򣻸߶���������ʶ����ͷ���㵽�ŵ�ı궨�ߣ��ù�һ�������ʾ��*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInCalSample
		{
			public NetVcaRect struVcaRect;   // Ŀ���
			public NetDvrLineSegment struLineSegment;    // �߶ȱ궨��
		}

		public const int MaxSampleNum = 5;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBehaviorInCalibration 
		{
			public uint dwCalSampleNum;      //  �궨��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSampleNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInCalSample[]  struCalSample; // �궨����������
			public NetDvrCameraParam    struCameraParam;    // ���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int CalibPtNum = 4;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrItsCalibration
		{
			public uint dwPointNum; //�궨����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CalibPtNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPoint[] struPoint; //ͼ������
			public float fWidth;
			public float fHeight;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;        // �����ֽ�
		}

		// �궨����������
		// ��������ر궨�������Է��ڸýṹ����
		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrCalibrationPrarmUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //������ṹ��С
			[FieldOffset(0)]
			public NetDvrPdcCalibration struPDCCalibration;  //PDC �궨����
			[FieldOffset(0)]
			public NetDvrBehaviorOutCalibration  struBehaviorOutCalibration;  //  ��Ϊ���ⳡ���궨  ��ҪӦ����IVS��
			[FieldOffset(0)]
			public NetDvrBehaviorInCalibration  struBehaviorInCalibration;     // ��Ϊ���ڳ����궨����ҪӦ��IAS�� 
			[FieldOffset(0)]
			public NetDvrItsCalibration struITSCalibration;
		}

		// �궨���ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCalibrationCfg
		{
			public uint dwSize;               //�궨�ṹ��С
			public byte byEnable;           // �Ƿ����ñ궨
			public byte byCalibrationType;    // �궨���� ���ݲ�ͬ��������������ѡ��ͬ�ı궨 �ο�CALIBRATE_TYPE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrCalibrationPrarmUnion uCalibrateParam;  // �궨����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//����ͳ�Ʒ���ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcEnterDirection
		{
			public NetVcaPoint struStartPoint; //����ͳ�Ʒ�����ʼ��
			public NetVcaPoint struEndPoint;    // ����ͳ�Ʒ�������� 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcRuleCfg
		{
			public uint dwSize;              //�ṹ��С
			public byte byEnable;             // �Ƿ񼤻����;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       // �����ֽ� 
			public NetVcaPolygon  struPolygon;            // �����
			public NetDvrPdcEnterDirection  struEnterDirection;    // �������뷽��
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcRuleCfgV41
		{
			public uint dwSize;              //�ṹ��С
			public byte byEnable;             // �Ƿ񼤻����;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       // �����ֽ� 
			public NetVcaPolygon struPolygon;            // �����
			public NetDvrPdcEnterDirection  struEnterDirection;    // �������뷽��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime struAlarmTime;//����ʱ��
			public NetDvrTimeEx struDayStartTime; //���쿪ʼʱ�䣬ʱ������Ч
			public NetDvrTimeEx struNightStartTime; //ҹ��ʼʱ�䣬ʱ������Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       // �����ֽ�
		}

		//���ð���Ϣ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrialVersionCfg
		{
			public uint dwSize;
			public ushort wReserveTime; //������ʣ��ʱ�䣬0xffff��ʾ��Ч����λ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSynChannelNameParam
		{
			public uint dwSize;
			public uint dwChannel; //ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrResetCounterCfg
		{
			public uint dwSize;
			public byte byEnable; //�Ƿ����ã�0-�����ã�1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrTimeEx[] struTime;//��������ʱ�䣬ʱ������Ч
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
			public byte byVCAEnable;     //�Ƿ�������
			public byte byVCAType;       //�����������ͣ�VcaChanAbilityType 
			public byte byStreamWithVCA; //�������Ƿ��������Ϣ
			public byte byMode;			//ģʽ��ATM ����ʱ����VCA_CHAN_MODE_TYPE ,TFS ����ʱ���� TFS_CHAN_MODE_TYPE����Ϊ����������ʱ����BEHAVIOR_SCENE_MODE_TYPE
			public byte byControlType;   //�������ͣ���λ��ʾ��0-��1-��
							//byControlType &1 �Ƿ�����ץ�Ĺ���
							//byControlType &2 �Ƿ���������ǰ���豸
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 		//����������Ϊ0
		}

		/*����������ͳ�Ʋ���  ������Ϊ�ڲ��ؼ��ֲ���
		 * HUMAN_GENERATE_RATE
		 * Ŀ�������ٶȲ���������PDC������Ŀ����ٶȡ��ٶ�Խ�죬Ŀ��Խ�������ɡ�
		 * ��������Ƶ���������ϲ�ԱȶȽϵ�ʱ���������õĹ��������Сʱ��Ӧ�ӿ�Ŀ�������ٶȣ� ����Ŀ���©�죻
		 * ��������Ƶ�жԱȶȽϸ�ʱ�����߹�������ϴ�ʱ��Ӧ�ý���Ŀ�������ٶȣ��Լ�����졣
		 * Ŀ�������ٶȲ�������5����1���ٶ�������5����죬Ĭ�ϲ���Ϊ3��
		 *
		 * DETECT_SENSITIVE
		 * Ŀ���������ȿ��Ʋ���������PDC����һ���������򱻼��ΪĿ��������ȡ�
		 * ������Խ�ߣ���������Խ���ױ����ΪĿ�꣬������Խ����Խ�Ѽ��ΪĿ�ꡣ
		 * ��������Ƶ���������ϲ�ԱȶȽϵ�ʱ��Ӧ��߼�������ȣ� ����Ŀ���©�죻
		 * ��������Ƶ�жԱȶȽϸ�ʱ��Ӧ�ý��ͼ�������ȣ��Լ�����졣
		 * ��Ӧ��������5��������1��������ͣ�5����ߣ�Ĭ�ϼ���Ϊ3��
		 * 
		 * TRAJECTORY_LEN
		 * �켣���ɳ��ȿ��Ʋ�������ʾ���ɹ켣ʱҪ��Ŀ������λ�����ء�
		 * ��Ӧ��������5��������1�����ɳ�������켣����������5�����ɳ�����̣��켣������죬Ĭ�ϼ���Ϊ3��
		 * 
		 * TRAJECT_CNT_LEN
		 * �켣�������ȿ��Ʋ�������ʾ�켣����ʱҪ��Ŀ������λ�����ء�
		 * ��Ӧ��������5��������1������Ҫ�󳤶�����켣����������5������Ҫ�󳤶���̣��켣������죬Ĭ�ϼ���Ϊ3��
		 * 
		 * PREPROCESS
		 * ͼ��Ԥ������Ʋ�����0 - ������1 - ����Ĭ��Ϊ0��
		 * 
		 * CAMERA_ANGLE
		 * ������Ƕ���������� 0 - ��б�� 1 - ��ֱ��Ĭ��Ϊ0��
		 */

		public enum PdcParamKey
		{
			HumanGenerateRate = 50,  // Ŀ�������ٶ� ��50��ʼ
			DetectSensitive    = 51,  // ���������
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcTargetInfo
		{
			public uint dwTargetID;                 // Ŀ��id 
			public NetVcaRect struTargetRect;    // Ŀ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;      // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcTargetInFrame
		{
			public byte byTargetNum;                   //Ŀ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] yRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTargetNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPdcTargetInfo[]  struTargetInfo;   //Ŀ����Ϣ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                  // �����ֽ�
		}

		//��֡ͳ�ƽ��ʱʹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct UnionStatframe
		{
			public uint dwRelativeTime;     // ���ʱ��
			public uint dwAbsTime;          // ����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionStattime
		{
			public NetDvrTime tmStart; // ͳ����ʼʱ�� 
			public NetDvrTime tmEnd;  //  ͳ�ƽ���ʱ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPdcAlramInfo
		{
			public uint dwSize;           // PDC�����������ϴ��ṹ���С
			public byte byMode;            // 0 ��֡ͳ�ƽ�� 1��Сʱ���ͳ�ƽ��  
			public byte byChannel;           // �����ϴ�ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;         // �����ֽ�   
			public NetVcaDevInfo  	 struDevInfo;		        //ǰ���豸��Ϣ
			[StructLayout(LayoutKind.Explicit)]
			public struct UStatModeParam
			{
				[FieldOffset(0)]
				//��֡ͳ�ƽ��ʱʹ��
				public UnionStatframe struStatFrame;

				[FieldOffset(0)]
				public UnionStattime struStatTime;
			}
			public uint dwLeaveNum;        // �뿪����
			public uint dwEnterNum;        // ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;           // �����ֽ�
		}

		//��������Ϣ��ѯ
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
			// �Ƿ����ó����������ó�����Ϊ�����ʱ����ֶ���Ч������������������ó���λ����Ϣʱ��Ϊʹ��λ
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPtzPositionName; //����λ������
			public NetDvrPtzpos struPtzPos; //ptz ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionRuleCfg
		{
			public uint dwSize;             // �ṹ��С 
			public NetDvrPtzPosition    struPtzPosition;    // ����λ����Ϣ
			public NetVcaRulecfg         struVcaRuleCfg;     //��Ϊ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         // �����ֽ�
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionRuleCfgV41
		{
			public uint dwSize;             // �ṹ��С 
			public NetDvrPtzPosition  struPtzPosition;    // ����λ����Ϣ
			public NetVcaRulecfgV41   struVcaRuleCfg;     //��Ϊ��������
			public byte byTrackEnable; //�Ƿ����ø���
			public byte byRes1;
			public ushort wTrackDuration; //���ٳ���ʱ�䣬��λs
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLimitAngle
		{
			public byte byEnable;	// �Ƿ����ó�����λ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrPtzpos  struUp;     // ����λ
			public NetDvrPtzpos  struDown;   // ����λ
			public NetDvrPtzpos  struLeft;   // ����λ
			public NetDvrPtzpos  struRight;  // ����λ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionIndex
		{
			public byte byIndex;    // ��������
			public byte byRes1;
			public ushort wDwell;	// ͣ��ʱ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   // �����ֽ�
		}

		public const int MaxPositionNum = 10;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPositionTrackCfg
		{
			public uint dwSize;
			public byte byNum; // ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPositionNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPositionIndex[]   struPositionIndex;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		
		//Ѳ��·��������Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPatrolSceneInfo
		{
			public ushort wDwell;         // ͣ��ʱ�� 30-300
			public byte byPositionID;   // ������1-10��Ĭ��0��ʾ��Ѳ���㲻��ӳ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//����Ѳ������������Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPatrolTrackcfg
		{
			public uint dwSize;  // �ṹ��С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPatrolSceneInfo[] struPatrolSceneInfo;    // Ѳ��·��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                              // �����ֽ�
		}

		//������ع���˵����ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrackParamcfg
		{
			public uint dwSize;             // �ṹ��С
			public ushort wAlarmDelayTime;    // ������ʱʱ�䣬Ŀǰ���ֻ֧��ȫ������ ��Χ1-120��
			public ushort wTrackHoldTime;     // �������ٳ���ʱ��  ��Χ0-300��
			public byte byTrackMode;        //  ���� IPDOME_TRACK_MODE
			public byte byPreDirection;	// ���ٷ���Ԥ�� 0-������ 1-����
			public byte byTrackSmooth;	    // ��������  0-������ 1-����
			public byte byZoomAdjust;	// ����ϵ������ �μ��±�
			public byte byMaxTrackZoom;	//�����ٱ���ϵ��,0-��ʾĬ�ϱ���ϵ��,�ȼ�6-�궨ֵ*1.0(Ĭ��),1-5Ϊ��С�궨ֵ��ֵԽС����С�ı���Խ��,7-15Ϊ�Ŵ�ֵԽ�󣬷Ŵ�ı���Խ��
			public byte byStopTrackWhenFindFace;  //������⵽���Ƿ�ֹͣ���� 0-�� 1-��
			public byte byStopTrackThreshold;   //������ֹ������ֵ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //  �����ֽ�                
		}

		//�����о����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDomeMovementParam
		{
			public ushort wMaxZoom;   // ��������ϵ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // �����ֽ�
		}

		/********************************���ܽ�ͨ�¼� begin****************************************/
		public const int MaxRegionNum	= 8;  // �����б������Ŀ
		public const int MaxTpsRule = 8;   // ������������Ŀ
		public const int MaxAidRule = 8;   // ����¼�������Ŀ
		public const int MaxLaneNum = 8;   // ��󳵵���Ŀ

		//��ͨ�¼�����
		public enum TrafficAidType
		{
			Congestion            = 0x01,    //ӵ��
			Parking               = 0x02,    //ͣ��  
			Inverse               = 0x04,    //����
			Pedestrian            = 0x08,    //����                      
			Debris                = 0x10,    //������ ��������Ƭ 
			Smoke                 = 0x20,    //����  
			Overline              = 0x40,     //ѹ��
			VehicleControlList  = 0x80,  //����������
			Speed                 = 0x100  //����
		}
		
		public enum TrafficSceneMode
		{
			Freeway = 0,	//  ���ٻ��ⳡ��
			Tunnel,         //  �����������
			Bridge          //  ������������
		}
		
		public enum ItsAbilityType
		{
			ItsCongestionAbility             = 0x01,      //ӵ��
			ItsParkingAbility                = 0x02,      //ͣ��  
			ItsInverseAbility                = 0x04,      //����
			ItsPedestrianAbility             = 0x08,      //����                      
			ItsDebrisAbility                 = 0x10,      //������ ��������Ƭ
			ItsSmokeAbility                  = 0x20,      //����-���
			ItsOverlineAbility               = 0x40,      //ѹ��
			ItsVehicleControlListAbility   = 0x80,		//����������
			ItsSpeedAbility				   = 0x100,	    //����	
			ItsLaneVolumeAbility            = 0x010000,  //��������
			ItsLaneVelocityAbility          = 0x020000,  //����ƽ���ٶ�
			ItsTimeHeadwayAbility           = 0x040000,  //��ͷʱ��
			ItsSpaceHeadwayAbility          = 0x080000,  //��ͷ���
			ItsTimeOccupancyRatioAbility   = 0x100000,  //����ռ���ʣ���ʱ����)
			ItsSpaceOccupancyRatioAbility  = 0x200000,  //����ռ���ʣ��ٷֱȼ��㣨�ռ���)
			ItsLaneQueueAbility             = 0x400000,  //�Ŷӳ���
			ItsVehicleTypeAbility           = 0x800000,  //��������
			ItsTrafficStateAbility          = 0x1000000  //��ͨ״̬
		}
		
		// ��ͨͳ�Ʋ���
		public enum ItsTpsType
		{
			LaneVolume           = 0x01,    //��������
			LaneVelocity         = 0x02,    //�����ٶ�
			TimeHeadway          = 0x04,    //��ͷʱ��
			SpaceHeadway         = 0x08,    //��ͷ���
			TimeOccupancyRatio  = 0x10,    //����ռ���� (ʱ����)
			SpaceOccupancyRatio = 0x20,    //����ռ���ʣ��ٷֱȼ���(�ռ���)
			Queue                 = 0x40,    //�Ŷӳ���
			VehicleType          = 0x80,    //��������
			TrafficState         = 0x100    //��ͨ״̬
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRegionList
		{
			public uint dwSize;	// �ṹ���С
			public byte byNum;      // �������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRegionNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPolygon[] struPolygon; // ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	// �����ֽ�
		}

		//����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDirection
		{
			public NetVcaPoint struStartPoint;   // ������ʼ��
			public NetVcaPoint struEndPoint;     // ��������� 
		}

		//��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneLane
		{
			public byte byEnable;  //�����Ƿ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	   // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLaneName;       // ������������
			public NetDvrDirection struFlowDirection;// �����ڳ�������
			public NetVcaPolygon struPolygon;		// ��������
		}

		//��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneCfg
		{
			public uint dwSize;	// �ṹ���С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLaneNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneLane[] struLane;	// �������� �����±���Ϊ����ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	 // �����ֽ�
		}

		//��ͨ�¼�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidParam
		{
			public ushort wParkingDuration;       // Υͣ���������  10-120s
			public ushort wPedestrianDuration;    // ���˳���ʱ��    1-120s
			public ushort wDebrisDuration;        // ���������ʱ��  10-120s
			public ushort wCongestionLength;      // ӵ�³�����ֵ    5-200���ף�
			public ushort wCongestionDuration;    // ӵ�³�������    10-120s
			public ushort wInverseDuration;       // ���г���ʱ��    1-10s
			public ushort wInverseDistance;       // ���о�����ֵ ��λm ��Χ[2-100] Ĭ�� 10��
			public ushort wInverseAngleTolerance; // ����Ƕ�ƫ�� 90-180��,��������������ļн�
			public ushort wIllegalParkingTime;    // Υͣʱ��[4,60]����λ������ ,TFS(��ͨΥ��ȡ֤) ����ģʽ��
			public ushort wIllegalParkingPicNum;  // ΥͣͼƬ����[1,6], TFS(��ͨΥ��ȡ֤) ����ģʽ��
			public byte byMergePic;             // ͼƬƴ��,TFS ����ģʽ�� 0- ��ƴ�� 1- ƴ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;             // �����ֽ�
		}

		//������ͨ�¼�����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneAidRule
		{   
			public byte byEnable;                   // �Ƿ������¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                  // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;       // �������� 
			public uint dwEventType;                // ��ͨ�¼�������� TRAFFIC_AID_TYPE
			public NetVcaSizeFilter struSizeFilter; // �ߴ������
			public NetVcaPolygon     struPolygon;    // ��������
			public NetDvrAidParam   struAIDParam;   //  �¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]   struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;	  //����ʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;        //����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//��ͨ�¼�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidRulecfg
		{
			public uint dwSize;                    // �ṹ���С 
			public byte byPicProType;              //����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                 // �����ֽ�
			public NetDvrJpegpara struPictureParam; //ͼƬ���ṹ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAidRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneAidRule[]  struOneAIDRule;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//������ͨ�¼�����ṹ��(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneAidRuleV41
		{   
			public byte byEnable;                 // �Ƿ������¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;     // �������� 
			public uint dwEventType;              // ��ͨ�¼�������� TRAFFIC_AID_TYPE
			public NetVcaSizeFilter struSizeFilter;           // �ߴ������
			public NetVcaPolygon struPolygon;              // ��������
			public NetDvrAidParam struAIDParam;             // �¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;// ����ʱ���
			public NetDvrHandleexceptionV30 struHandleType;	          //����ʽ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIvmsIpChannel, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan; //����������¼��ͨ����1��ʾ������ͨ����0��ʾ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;               //����
		}

		//��ͨ�¼�����(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidRulecfgV41
		{
			public uint dwSize;                     // �ṹ���С 
			public byte byPicProType;               // ����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                  // �����ֽ�
			public NetDvrJpegpara struPictureParam; 	// ͼƬ���ṹ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAidRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneAidRuleV41[]  struAIDRule;  //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                //����
		}

		//��ͨͳ�Ʋ����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneTpsRule
		{
			public byte byEnable;                   //�Ƿ�ʹ�ܳ�����ͨ�������
			public byte byLaneID;		            //����ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwCalcType;                 //ͳ�Ʋ�������ITS_TPS_TYPE
			public NetVcaSizeFilter struSizeFilter; //�ߴ������ 
			public NetVcaPolygon struVitrualLoop;    //������Ȧ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;	//����ʽ,һ��Ϊ�����Ƿ��ϴ����ģ��������ܲ���Ҫ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                         //�����ֽ�
		}

		//��ͨ����ͳ�ƹ������ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsRulecfg
		{
			public uint dwSize;              // �ṹ��С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneTpsRule[] struOneTpsRule; // �±��Ӧ��ͨ����ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         // �����ֽ�
		}

		//��ͨͳ�Ʋ����ṹ��(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneTpsRuleV41
		{
			public byte byEnable;                     //�Ƿ�ʹ�ܳ�����ͨ�������
			public byte byLaneID;		              //����ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                    //����
			public uint dwCalcType;                   // ͳ�Ʋ�������ITS_TPS_TYPE
			public NetVcaSizeFilter  struSizeFilter;  //�ߴ������ 
			public NetVcaPolygon  struVitrualLoop; //������Ȧ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]  struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;	   //����ʽ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                   // �����ֽ�
		}

		//��ͨ����ͳ�ƹ������ýṹ��(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsRulecfgV41
		{
			public uint dwSize;         // �ṹ��С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneTpsRuleV41[] struOneTpsRule; // �±��Ӧ��ͨ����ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     // ����
		}

		//��ͨ�¼���Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidInfo
		{
			public byte byRuleID;   // ������ţ�Ϊ�������ýṹ�±꣬0-16
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName; //  ��������
			public uint dwAIDType;  // �����¼�����
			public NetDvrDirection   struDirect; // ����ָ������  
			public byte bySpeedLimit; //����ֵ����λkm/h[0,255]
			public byte byCurrentSpeed; //��ǰ�ٶ�ֵ����λkm/h[0,255]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;  // �����ֽ� 
		}

		//��ͨ�¼����� 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidAlarm
		{
			public uint dwSize;         // �ṹ����
			public uint dwRelativeTime;	// ���ʱ��
			public uint dwAbsTime;		// ����ʱ��
			public NetVcaDevInfo struDevInfo;	// ǰ���豸��Ϣ
			public NetDvrAidInfo struAIDInfo;    // ��ͨ�¼���Ϣ
			public uint dwPicDataLen;   // ����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����
			public IntPtr pImage;        // ָ��ͼƬ��ָ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // �����ֽ�  
		}

		//�������нṹ�� 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneQueue
		{
			public NetVcaPoint struHead;       //����ͷ
			public NetVcaPoint struTail;       //����β
			public uint dwLength;      //ʵ�ʶ��г��� ��λΪ�� [0-500]
		}

		public enum TrafficDataVaryType
		{
			NoVary,         //�ޱ仯 
			VehicleEnter,   //��������������Ȧ
			VehicleLeave,   //�����뿪������Ȧ 
			UeueVary        //���б仯             
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;  //������������ 
			public byte byRuleID;              //������ţ�Ϊ�������ýṹ�±꣬0-7 
			public byte byVaryType;            //������ͨ�����仯���� ���� TRAFFIC_DATA_VARY_TYPE
			public byte byLaneType;			   //�������л�����
			public byte byRes1;
			public uint dwLaneVolume;         //�������� ��ͳ���ж��ٳ���ͨ��
			public uint dwLaneVelocity;        //�����ٶȣ��������
			public uint dwTimeHeadway;         //��ͷʱ�࣬�������
			public uint dwSpaceHeadway;        //��ͷ��࣬����������
			public float fSpaceOccupyRation;    //����ռ���ʣ��ٷֱȼ��㣨�ռ���)
			public NetDvrLaneQueue struLaneQueue;    //�������г���
			public NetVcaPoint struRuleLocation; //��Ȧ��������ĵ�λ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsInfo
		{
			public uint dwLanNum;   // ��ͨ�����ĳ�����Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLaneParam[]  struLaneParam;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsAlarm
		{
			public uint dwSize;          //�ṹ���С
			public uint dwRelativeTime;  //���ʱ��
			public uint dwAbsTime;       //����ʱ��
			public NetVcaDevInfo  struDevInfo;     //ǰ���豸��Ϣ
			public NetDvrTpsInfo  struTPSInfo;     //��ͨ�¼���Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;      //�����ֽ�
		}
		
		public enum TrafficDataVaryTypeExEnum
		{    
			EnumTrafficVaryNo             = 0x00,   //�ޱ仯
			EnumTrafficVaryVehicleEnter  = 0x01,   //��������������Ȧ
			EnumTrafficVaryVehicleLeave  = 0x02,   //�����뿪������Ȧ
			EnumTrafficVaryQueue          = 0x04,   //���б仯
			EnumTrafficVaryStatistic      = 0x08,   //ͳ�����ݱ仯��ÿ���ӱ仯һ�ΰ���ƽ���ٶȣ������ռ�/ʱ��ռ���ʣ���ͨ״̬��        
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLaneParamV41
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName; // ������������
			public byte byRuleID;             // ������ţ�Ϊ�������ýṹ�±꣬0-7 
			public byte byLaneType;		     // �������л�����
			public byte byTrafficState;       // �����Ľ�ͨ״̬��0-��Ч��1-��ͨ��2-ӵ����3-����
			public byte byRes1;               // ����
			public uint dwVaryType;           // ������ͨ�����仯���Ͳ���  TrafficDataVaryTypeExEnum����λ����
			public uint dwTpsType;            // ���ݱ仯���ͱ�־����ʾ��ǰ�ϴ���ͳ�Ʋ����У���Щ������Ч������ITS_TPS_TYPE,��λ����
			public uint dwLaneVolume;	     // ����������ͳ���ж��ٳ���ͨ��
			public uint dwLaneVelocity;       // �����ٶȣ��������
			public uint dwTimeHeadway ;       // ��ͷʱ�࣬�������
			public uint dwSpaceHeadway;       // ��ͷ��࣬����������
			public float fSpaceOccupyRation;   // ����ռ���ʣ��ٷֱȼ��㣨�ռ���)
			public float fTimeOccupyRation;    // ʱ��ռ���ʣ��ٷֱȼ���
			public uint dwLightVehicle;       // С�ͳ�����
			public uint dwMidVehicle;         // ���ͳ�����
			public uint dwHeavyVehicle;       // ���ͳ�����
			public NetDvrLaneQueue struLaneQueue;        // �������г���
			public NetVcaPoint struRuleLocation;     // ����λ��������Ȧ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;           // ����
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsInfoV41
		{
			public uint dwLanNum;          // ��ͨ�����ĳ�����Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTpsRule, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLaneParamV41[]  struLaneParam;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //����
		}

		//������������ 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacedetectRulecfg
		{
			public uint dwSize;              // �ṹ���С
			public byte byEnable;            // �Ƿ�����
			public byte byEventType;			//�����¼����ͣ� 0-�쳣����; 1-��������;2-�쳣����&��������;
			public byte byUpLastAlarm;       //2011-04-06 �Ƿ����ϴ����һ�εı���
			public byte byUpFacePic; //�Ƿ��ϴ�������ͼ��0-��1-��	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;
			public NetVcaPolygon     struVcaPolygon;    // ��������������
			public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			public byte bySensitivity;   // ����������
			public ushort wDuration;      // ������������ʱ����ֵ
			public NetDvrJpegpara    struPictureParam; 		//ͼƬ���ṹ
			public NetVcaSizeFilter struSizeFilter;         //�ߴ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;	  //����ʽ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;			//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			public byte byPicRecordEnable;  /*2012-3-1�Ƿ�����ͼƬ�洢, 0-������, 1-����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;         //�����ֽ�
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacePipcfg
		{	
			public byte byEnable; //�Ƿ������л�
			public byte byBackChannel; //����ͨ���ţ����ͨ����
			public byte byPosition; //����λ�ã�0-����,1-����,2-����,3-����
			public byte byPIPDiv; //����ϵ��(��������:��廭��)��0-1:4,1-1:9,2-1:16
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacedetectRulecfgV41
		{
			public uint dwSize;              // �ṹ���С
			public byte byEnable;            // �Ƿ�����
			public byte byEventType;			//�����¼����ͣ� 0-�쳣����; 1-��������;2-�쳣����&��������;
			public byte byUpLastAlarm;       //2011-04-06 �Ƿ����ϴ����һ�εı���
			public byte byUpFacePic; //�Ƿ��ϴ�������ͼ��0-��1-��	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;
			public NetVcaPolygon struVcaPolygon;    // ��������������
			public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			public byte bySensitivity;   // ����������
			public ushort wDuration;      // ������������ʱ����ֵ
			public NetDvrJpegpara    struPictureParam; 		//ͼƬ���ṹ
			public NetVcaSizeFilter struSizeFilter;         //�ߴ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[]   struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;	  //����ʽ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;			//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			public byte byPicRecordEnable;  /*2012-10-22�Ƿ�����ͼƬ�洢, 0-������, 1-����*/
			public byte byRes1;
			public ushort wAlarmDelay; //2012-10-22���ܱ�����ʱ��0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
			public NetDvrFacePipcfg struFacePIP; //2012-11-7���л�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //�����ֽ�
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFacedetectAlarm
		{
			public uint dwSize;     		// �ṹ��С
			public uint dwRelativeTime; // ���ʱ��
			public uint dwAbsTime;			// ����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;   // ��������
			public NetVcaTargetInfo  struTargetInfo;	//����Ŀ����Ϣ
			public NetVcaDevInfo  	 struDevInfo;		//ǰ���豸��Ϣ
			public uint dwPicDataLen;						//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����*/
			public byte byAlarmPicType;			// 0-�쳣��������ͼƬ 1- ����ͼƬ,2-�������� 
			public byte byPanelChan;        /*2012-3-1����ͨ�����������ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwFacePicDataLen;			//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // �����ֽ�
			public IntPtr pFaceImage; //ָ������ͼָ��
			public IntPtr pImage;   						//ָ��ͼƬ��ָ��
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventParamUnion
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
			public uint[] uLen;        	// �������СΪ12�ֽ�
			public uint dwHumanIn;  	//�����˽ӽ� 0 - ���� 1- ����  
			public float fCrowdDensity;  // ��Ա�ۼ�ֵ
		}

		//Ŀǰֻ�����������¼�����Ա�ۼ��¼�ʵʱ�����ϴ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventInfo
		{
			public byte byRuleID;				// Rule ID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				// �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRuleName;	// ��������
			public uint dwEventType;    		// ����VCA_EVENT_TYPE
			public NetDvrEventParamUnion uEventParam;  // 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventInfoList
		{
			public byte byNum;		// �¼�ʵʱ��Ϣ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			// �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrEventInfo[] struEventInfo;	// �¼�ʵʱ��Ϣ
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRuleInfoAlarm
		{
			public uint dwSize;				// �ṹ���С
			public uint dwRelativeTime; 	// ���ʱ��
			public uint dwAbsTime;			// ����ʱ��
			public NetVcaDevInfo  	struDevInfo;		// ǰ���豸��Ϣ
			public NetDvrEventInfoList struEventInfoList;	//�¼���Ϣ�б�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			// �����ֽ�
		}

		//��������ʱ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneSceneTime
		{
			public byte byActive;                     //0 -��Ч,1�C��Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                    //����
			public uint dwSceneID;                    //����ID
			public NetDvrSchedtime struEffectiveTime;   //������Чʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                   //����
		}

		//������Чʱ�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneTimeCfg
		{   
			public uint dwSize;                                               //�ṹ��С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSceneTimesegNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneSceneTime[] struSceneTime; //����ʱ�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                                            //����
		}

		//��������������Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneSceneCfg
		{    
			public byte byEnable;                 //�Ƿ����øó���,0-������ 1- ����
			public byte byDirection;              //��ⷽ�� 1-���У�2-���У�3-˫��4-�ɶ�������5-�����򱱣�6-�����򶫣�7-�ɱ����ϣ�8-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;                //����
			public uint dwSceneID;                //����ID(ֻ��), 0 - ��ʾ�ó�����Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] bySceneName;    //��������
			public NetDvrPtzpos struPtzPos;       //ptz ����
			public uint dwTrackTime;              //�������ʱ��[5,300] �룬TFS(��ͨȡ֤)ģʽ����Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;               //����
		}

		//�������ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneCfg
		{
			public uint dwSize;                                          //�ṹ��С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxItsSceneNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneSceneCfg[] struSceneCfg; //����������Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                                      //����
		}

		//�ೡ����������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneCond
		{
			public uint dwSize;       //�ṹ��С
			public int lChannel;     //ͨ����
			public uint dwSceneID;    //����ID, 0-��ʾ�ó�����Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //����
		}

		//ȡ֤��ʽ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrForensicsMode
		{
			public uint dwSize;      //�ṹ��С
			public byte byMode;      // 0-�ֶ�ȡ֤ ,1-�Զ�ȡ֤
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   //����
		}

		//����������Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSceneInfo
		{  
			public uint dwSceneID;              //����ID, 0 - ��ʾ�ó�����Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] bySceneName;  //��������
			public byte byDirection;            //��ⷽ�� 1-���У�2-���У�3-˫��4-�ɶ�������5-�����򱱣�6-�����򶫣�7-�ɱ����ϣ�8-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;              //����
			public NetDvrPtzpos  struPtzPos;             //Ptz ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2 ;            //����
		}

		//��ͨ�¼�����(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAidAlarmV41
		{
			public uint dwSize;              //�ṹ����
			public uint dwRelativeTime;	    //���ʱ��
			public uint dwAbsTime;			//����ʱ��
			public NetVcaDevInfo  struDevInfo;		    //ǰ���豸��Ϣ
			public NetDvrAidInfo  struAIDInfo;         //��ͨ�¼���Ϣ
			public NetDvrSceneInfo struSceneInfo;       //������Ϣ
			public uint dwPicDataLen;        //ͼƬ����
			public IntPtr pImage; 			//ָ��ͼƬ��ָ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //����
		}

		//��ͨͳ����Ϣ����(��չ)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTpsAlarmV41
		{
			public uint dwSize;          // �ṹ���С
			public uint dwRelativeTime;  // ���ʱ��
			public uint dwAbsTime;       // ����ʱ��
			public NetVcaDevInfo struDevInfo;     // ǰ���豸��Ϣ
			public NetDvrTpsInfoV41  struTPSInfo;     // ��ͨ����ͳ����Ϣ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // ����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaVersion
		{
			public ushort wMajorVersion;		// ���汾��
			public ushort wMinorVersion;		// �ΰ汾��
			public ushort wRevisionNumber;	// ������
			public ushort wBuildNumber;		// �����
			public ushort wVersionYear;		//	�汾����-��
			public byte byVersionMonth;		//	�汾����-��
			public byte byVersionDay;		//	�汾����-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;			// �����ֽ�
		}
		/*******************************���ܽ�ͨ�¼� end*****************************************/

		/******************************����ʶ�� begin******************************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateParam
		{	
			public byte byPlateRecoMode;    //����ʶ���ģʽ,Ĭ��Ϊ1(��Ƶ����ģʽ)
			public byte byBelive;	/*�������Ŷ���ֵ, ֻ������Ƶʶ��ʽ, ���ݱ������ӳ̶�����, �󴥷��ʸ߾����, ©���ʸ߾����, 
									 * ������80-90��Χ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //�����ֽ�
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlatecfg
		{	
			public uint dwSize;
			public uint dwEnable;				           /* �Ƿ�������Ƶ����ʶ�� 0���� 1���� */
			public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  // �����ֽ�
			public NetDvrJpegpara struPictureParam; 		//ͼƬ���ṹ
			public NetDvrPlateParam struPlateParam;   // ����ʶ���������
			public NetDvrHandleexception struHandleType;	   /* ����ʽ */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannum, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;        //����������¼��ͨ��,Ϊ1��ʾ������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // �����ֽ�
		}

		//����ʶ�����ӽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateInfo
		{
			public byte byPlateType; //��������
			public byte byColor; //������ɫ
			public byte byBright; //��������
			public byte byLicenseLen;	//�����ַ�����
			public byte byEntireBelieve;//�������Ƶ����Ŷȣ�0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
			public NetVcaRect	struPlateRect;	//����λ��
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxLicenseLen)]
			public string sLicense;	//���ƺ��� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLicenseLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byBelieve; //����ʶ���ַ������Ŷȣ����⵽����"��A12345", ���Ŷ�Ϊ,20,30,40,50,60,70�����ʾ"��"����ȷ�Ŀ�����ֻ��%��"A"�ֵ���ȷ�Ŀ�������%
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlaterecoResule
		{
			public uint dwSize;
			public uint dwRelativeTime;	//���ʱ��
			public uint dwAbsTime;	//����ʱ��
			public NetVcaDevInfo struDevInfo; // ǰ���豸��Ϣ
			public NetDvrPlateInfo struPlateInfo;
			public uint dwPicDataLen;	//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;	//����������Ϊ0
			public IntPtr pImage;   //ָ��ͼƬ��ָ��
		}
		/******************************����ʶ�� end******************************************/

		/******************************ץ�Ļ�*******************************************/
		//IO��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIoIncfg
		{
			public uint dwSize;
			public byte byIoInStatus;//�����IO��״̬��0-�½��أ�1-�����أ�2-�����غ��½��أ�3-�ߵ�ƽ��4-�͵�ƽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//�����ֽ�
		}

		//IO�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIoOutcfg
		{
			public uint dwSize;
			public byte byDefaultStatus;//IOĬ��״̬��0-�͵�ƽ��1-�ߵ�ƽ 
			public byte byIoOutStatus;//IO��Чʱ״̬��0-�͵�ƽ��1-�ߵ�ƽ��2-����
			public ushort wAheadTime;//���IO��ǰʱ�䣬��λus
			public uint dwTimePluse;//������ʱ�䣬��λus
			public uint dwTimeDelay;//IO��Ч����ʱ�䣬��λus
			public byte byFreqMulti;		//��Ƶ����ֵ��Χ[1,15]
			public byte byDutyRate;		//ռ�ձȣ�[0,40%]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFlashOutcfg
		{
			public uint dwSize;
			public byte byMode;//�������˸ģʽ��0-������1-����2-��������3-����
			public byte byRelatedIoIn;//����ƹ���������IO�ţ�������ʱ�˲�����Ч��
			public byte byRecognizedLane;  /*������IO�ţ���λ��ʾ��bit0��ʾIO1�Ƿ������0-��������1-����*/
			public byte byDetectBrightness;/*�Զ��������ʹ�������0-����⣻1-���*/
			public byte byBrightnessThreld;/*ʹ�������������ֵ����Χ[0,100],������ֵ��*/
			public byte byStartHour;		//��ʼʱ��-Сʱ,ȡֵ��Χ0-23
			public byte byStartMinute;		//��ʼʱ��-��,ȡֵ��Χ0-59
			public byte byEndHour;		 	//����ʱ��-Сʱ,ȡֵ��Χ0-23
			public byte byEndMinute;		//����ʱ��-��,ȡֵ��Χ0-59
			public byte byFlashLightEnable;	//���������ʱ��ʹ��:0-��;1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���̵ƹ��ܣ�2��IO����һ�飩
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLightsnapcfg
		{
			public uint dwSize;
			public byte byLightIoIn;//���̵Ƶ�IO ��
			public byte byTrigIoIn;//������IO��
			public byte byRelatedDriveWay;//����IO�����ĳ�����
			public byte byTrafficLight; //0-�ߵ�ƽ��ƣ��͵�ƽ�̵ƣ�1-�ߵ�ƽ�̵ƣ��͵�ƽ���
			public byte bySnapTimes1; //���ץ�Ĵ���1��0-��ץ�ģ���0-���Ĵ��������5�� 
			public byte bySnapTimes2; //�̵�ץ�Ĵ���2��0-��ץ�ģ���0-���Ĵ��������5�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime1;//������ļ��ʱ�䣬ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime2;//�̵����ļ��ʱ�䣬ms
			public byte byRecord;//���������¼���־��0-��¼��1-¼��
			public byte bySessionTimeout;//���������¼��ʱʱ�䣨�룩
			public byte byPreRecordTime;//�����¼��Ƭ��Ԥ¼ʱ��(��)
			public byte byVideoDelay;//�����¼��Ƭ����ʱʱ�䣨�룩
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//�����ֽ�
		}

		//���ٹ���(2��IO����һ�飩
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMeasurespeedcfg
		{
			public uint dwSize;
			public byte byTrigIo1;   //���ٵ�1��Ȧ
			public byte byTrigIo2;   //���ٵ�2��Ȧ
			public byte byRelatedDriveWay;//����IO�����ĳ�����
			public byte byTestSpeedTimeOut;//����ģʽ��ʱʱ�䣬��λs
			public uint dwDistance;//��Ȧ����,cm
			public byte byCapSpeed;//����ģʽ�����ٶȣ���λkm/h
			public byte bySpeedLimit;//����ֵ����λkm/h
			public byte bySnapTimes1; //��Ȧ1ץ�Ĵ�����0-��ץ�ģ���0-���Ĵ��������5�� 
			public byte bySnapTimes2; //��Ȧ2ץ�Ĵ�����0-��ץ�ģ���0-���Ĵ��������5�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime1;//��Ȧ1���ļ��ʱ�䣬ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntervalNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wIntervalTime2;//��Ȧ2���ļ��ʱ�䣬ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//�����ֽ�
		}

		//��Ƶ��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoeffect
		{
			public byte byBrightnessLevel; /*0-100*/
			public byte byContrastLevel; /*0-100*/
			public byte bySharpnessLevel; /*0-100*/
			public byte bySaturationLevel; /*0-100*/
			public byte byHueLevel; /*0-100,��������*/
			public byte byEnableFunc; //ʹ�ܣ���λ��ʾ��bit0-SMART IR(������)��bit1-���ն�,bit2-ǿ������ʹ�ܣ�0-��1-��
			public byte byLightInhibitLevel; //ǿ�����Ƶȼ���[1-3]��ʾ�ȼ�
			public byte byGrayLevel; //�Ҷ�ֵ��0-[0-255]��1-[16-235]
		}

		//��������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGain
		{
			public byte byGainLevel; /*���棺0-100*/
			public byte byGainUserSet; /*�û��Զ������棻0-100������ץ�Ļ�����CCDģʽ�µ�ץ������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwMaxGainValue;/*�������ֵ����λdB*/
		}

		//��ƽ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWhitebalance
		{
			public byte byWhiteBalanceMode; /*0-�ֶ���ƽ�⣨MWB��,1-�Զ���ƽ��1��AWB1��,2-�Զ���ƽ��2 (AWB2),3-�Զ����Ƹ���Ϊ������ƽ��(Locked WB)��
							 4-����(Indoor)��5-����(Outdoor)6-�չ��(Fluorescent Lamp)��7-�Ƶ�(Sodium Lamp)��
							 8-�Զ�����(Auto-Track)9-һ�ΰ�ƽ��(One Push)��10-�����Զ�(Auto-Outdoor)��
							 11-�Ƶ��Զ� (Auto-Sodiumlight)��12-ˮ����(Mercury Lamp)��13-�Զ���ƽ��(Auto)��
							 14-�׳�� (IncandescentLamp)��15-ů���(Warm Light Lamp)��16-��Ȼ��(Natural Light) */
			public byte byWhiteBalanceModeRGain; /*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� R����*/
			public byte byWhiteBalanceModeBGain; /*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� B����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//�ع����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrExposure
		{
			public byte byExposureMode; /*0 �ֶ��ع� 1�Զ��ع�*/
			public byte byAutoApertureLevel; /* �Զ���Ȧ������, 0-10 */ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwVideoExposureSet; /* �Զ�����Ƶ�ع�ʱ�䣨��λus��*//*ע:�Զ��ع�ʱ��ֵΪ�ع�����ֵ ����20-1s(1000000us)*/        
			public uint dwExposureUserSet; /* �Զ����ع�ʱ��,��ץ�Ļ���Ӧ��ʱ��CCDģʽʱ��ץ�Ŀ����ٶ�*/   
			public uint dwRes;    
		}

		//��̬����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWdr
		{
			public byte byWDREnabled; /*��̬��0 dsibale  1 enable 2 auto*/
			public byte byWDRLevel1; /*0-F*/
			public byte byWDRLevel2; /*0-F*/
			public byte byWDRContrastLevel; /*0-100*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��ҹת����������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDaynight
		{
			public byte byDayNightFilterType; /*��ҹ�л���0-���죬1-ҹ��2-�Զ���3-��ʱ��4-�������봥��*/
			public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(����)*/
			//��ʱģʽ����
			public byte byBeginTime; /*��ʼʱ�䣨Сʱ����0-23*/
			public byte byEndTime; /*����ʱ�䣨Сʱ����0-23*/
			//ģʽ2
			public byte byDayToNightFilterLevel; //0-7
			public byte byNightToDayFilterLevel; //0-7
			public byte byDayNightFilterTime;//(60��)
			//��ʱģʽ����
			public byte byBeginTimeMin; //��ʼʱ�䣨�֣���0-59
			public byte byBeginTimeSec; //��ʼʱ�䣨�룩��0-59
			public byte byEndTimeMin; //����ʱ�䣨�֣���0-59
			public byte byEndTimeSec; //����ʱ�䣨�룩��0-59
			//�������봥��ģʽ����
			public byte byAlarmTrigState; //�������봥��״̬��0-���죬1-ҹ��
		}

		//GammaУ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGammacorrect
		{
			public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
			public byte byGammaCorrectionLevel; /*0-100*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���ⲹ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBacklight
		{
			public byte byBacklightMode; /*���ⲹ��:0 off 1 UP��2 DOWN��3 LEFT��4 RIGHT��5MIDDLE��6�Զ���*/
			public byte byBacklightLevel; /*0x0-0xF*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwPositionX1; //��X����1��
			public uint dwPositionY1; //��Y����1��
			public uint dwPositionX2; //��X����2��
			public uint dwPositionY2; //��Y����2��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//���ֽ��빦��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNoiseremove
		{
			public byte byDigitalNoiseRemoveEnable; /*0-�����ã�1-��ͨģʽ���ֽ��룬2-ר��ģʽ���ֽ���*/
			public byte byDigitalNoiseRemoveLevel; /*��ͨģʽ���ֽ��뼶��0x0-0xF*/
			public byte bySpectralLevel;       /*ר��ģʽ�¿���ǿ�ȣ�0-100*/
			public byte byTemporalLevel;   /*ר��ģʽ��ʱ��ǿ�ȣ�0-100*/
			public byte byDigitalNoiseRemove2DEnable;         /* ץ��֡2D���룬0-�����ã�1-���� */	
			public byte byDigitalNoiseRemove2DLevel;            /* ץ��֡2D���뼶��0-100 */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//CMOSģʽ��ǰ�˾�ͷ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCmosmodecfg
		{
			public byte byCaptureMod;   //ץ��ģʽ��0-ץ��ģʽ1��1-ץ��ģʽ2
			public byte byBrightnessGate;//������ֵ
			public byte byCaptureGain1;   //ץ������1,0-100
			public byte byCaptureGain2;   //ץ������2,0-100
			public uint dwCaptureShutterSpeed1;//ץ�Ŀ����ٶ�1
			public uint dwCaptureShutterSpeed2;//ץ�Ŀ����ٶ�2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ǰ�˲�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraparamcfg
		{
			public uint dwSize;
			public NetDvrVideoeffect struVideoEffect;/*���ȡ��Աȶȡ����Ͷȡ���ȡ�ɫ������*/    
			public NetDvrGain struGain;/*�Զ�����*/
			public NetDvrWhitebalance struWhiteBalance;/*��ƽ��*/
			public NetDvrExposure struExposure; /*�ع����*/
			public NetDvrGammacorrect struGammaCorrect;/*GammaУ��*/
			public NetDvrWdr struWdr;/*��̬*/
			public NetDvrDaynight struDayNight;/*��ҹת��*/
			public NetDvrBacklight struBackLight;/*���ⲹ��*/
			public NetDvrNoiseremove struNoiseRemove;/*���ֽ���*/
			public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
			public byte byIrisMode; /*0 �Զ���Ȧ 1�ֶ���Ȧ*/    
			public byte byMirror ;  /* ����0 off��1- leftright��2- updown��3-center */
			public byte byDigitalZoom;  /*��������:0 dsibale  1 enable*/
			public byte byDeadPixelDetect;   /*������,0 dsibale  1 enable*/
			public byte byBlackPwl;/*�ڵ�ƽ���� ,  0-255*/ 
			public byte byEptzGate;// EPTZ���ر���:0-�����õ�����̨��1-���õ�����̨
			public byte byLocalOutputGate;//����������ر���0-��������ر�1-����BNC����� 2-HDMI����ر�  
					 //20-HDMI_720P50�����
					 //21-HDMI_720P60�����
					 //22-HDMI_1080I60�����
					 //23-HDMI_1080I50�����
					 //24-HDMI_1080P24�����
					 //25-HDMI_1080P25�����
					 //26-HDMI_1080P30�����
					 //27-HDMI_1080P50�����
					 //28-HDMI_1080P60�����
					 //40-SDI_720P50,
					 //41-SDI_720P60,
					 //42-SDI_1080I50,
					 //43-SDI_1080I60,
					 //44-SDI_1080P24,
					 //45-SDI_1080P25,
					 //46-SDI_1080P30,
					 //47-SDI_1080P50,
					 //48-SDI_1080P60
			public byte byCoderOutputMode;//������fpga���ģʽ0ֱͨ3���ذ��
			public byte byLineCoding; //�Ƿ����б��룺0-��1-��
			public byte byDimmerMode; //����ģʽ��0-���Զ���1-�Զ�
			public byte byPaletteMode; //��ɫ�壺0-���ȣ�1-���ȣ�2-��ɫ��2������8-��ɫ��8
			public byte byEnhancedMode; //��ǿ��ʽ��̽�������ܱߣ���0-����ǿ��1-1��2-2��3-3��4-4
			public byte byDynamicContrastEN;    //��̬�Աȶ���ǿ 0-1
			public byte byDynamicContrast;    //��̬�Աȶ� 0-100
			public byte byJPEGQuality;    //JPEGͼ������ 0-100
			public NetDvrCmosmodecfg struCmosModeCfg;//CMOSģʽ��ǰ�˲������ã���ͷģʽ����������ȡ
			public byte byFilterSwitch; //�˲����أ�0-�����ã�1-����
			public byte byFocusSpeed; //��ͷ�����ٶȣ�0-10
			public byte byAutoCompensationInterval; //��ʱ�Զ����Ų�����1-120����λ������
			public byte bySceneMode;  //����ģʽ��0-���⣬1-���ڣ�2-Ĭ�ϣ�3-����
		}

		//͸��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDefogcfg
		{
			public byte byMode; //ģʽ��0-�����ã�1-�Զ�ģʽ��2-����ģʽ
			public byte byLevel; //�ȼ���0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		//���ӷ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrElectronicstabilization
		{
			public byte byEnable;//ʹ�� 0- �����ã�1- ����
			public byte byLevel; //�ȼ���0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		//����ģʽ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCorridorModeCcd
		{
			public byte byEnableCorridorMode; //�Ƿ���������ģʽ 0�������ã� 1������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//SMART IR(������)���ò���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSmartirParam
		{
			public byte byMode;//0���ֶ���1���Զ�
			public byte byIRDistance;//�������ȼ�(�ȼ�������������)level:1~100 Ĭ��:50���ֶ�ģʽ�����ӣ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��byIrisMode ΪP-Iris1ʱ��Ч�����ú����Ȧ��С�ȼ�������ģʽ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPirisParam
		{
			public byte byMode;//0-�Զ���1-�ֶ�
			public byte byPIrisAperture;//�����Ȧ��С�ȼ�(�ȼ�,��Ȧ��С������)level:1~100 Ĭ��:50���ֶ�ģʽ�����ӣ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ǰ�˲�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraparamcfgEx
		{
			public uint dwSize;
			public NetDvrVideoeffect struVideoEffect;/*���ȡ��Աȶȡ����Ͷȡ���ȡ�ɫ������*/
			public NetDvrGain struGain;/*�Զ�����*/
			public NetDvrWhitebalance struWhiteBalance;/*��ƽ��*/
			public NetDvrExposure struExposure; /*�ع����*/
			public NetDvrGammacorrect struGammaCorrect;/*GammaУ��*/
			public NetDvrWdr struWdr;/*��̬*/
			public NetDvrDaynight struDayNight;/*��ҹת��*/
			public NetDvrBacklight struBackLight;/*���ⲹ��*/
			public NetDvrNoiseremove struNoiseRemove;/*���ֽ���*/
			public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
			public byte byIrisMode; /*0-�Զ���Ȧ 1-�ֶ���Ȧ, 2-P-Iris1*/    
			public byte byMirror ;  /* ����0 off��1- leftright��2- updown��3-center */
			public byte byDigitalZoom;  /*��������:0 dsibale  1 enable*/
			public byte byDeadPixelDetect;   /*������,0 dsibale  1 enable*/
			public byte byBlackPwl;/*�ڵ�ƽ���� ,  0-255*/ 
			public byte byEptzGate;// EPTZ���ر���:0-�����õ�����̨��1-���õ�����̨
			public byte byLocalOutputGate;//����������ر���0-��������ر�1-����BNC����� 2-HDMI����ر�  
			//20-HDMI_720P50�����
			//21-HDMI_720P60�����
			//22-HDMI_1080I60�����
			//23-HDMI_1080I50�����
			//24-HDMI_1080P24�����
			//25-HDMI_1080P25�����
			//26-HDMI_1080P30�����
			//27-HDMI_1080P50�����
			//28-HDMI_1080P60�����
			public byte byCoderOutputMode;//������fpga���ģʽ0ֱͨ3���ذ��
			public byte byLineCoding; //�Ƿ����б��룺0-��1-��
			public byte byDimmerMode; //����ģʽ��0-���Զ���1-�Զ�
			public byte byPaletteMode; //��ɫ�壺0-���ȣ�1-���ȣ�2-��ɫ��2������8-��ɫ��8
			public byte byEnhancedMode; //��ǿ��ʽ��̽�������ܱߣ���0-����ǿ��1-1��2-2��3-3��4-4
			public byte byDynamicContrastEN;    //��̬�Աȶ���ǿ 0-1
			public byte byDynamicContrast;    //��̬�Աȶ� 0-100
			public byte byJPEGQuality;    //JPEGͼ������ 0-100
			public NetDvrCmosmodecfg struCmosModeCfg;//CMOSģʽ��ǰ�˲������ã���ͷģʽ����������ȡ
			public byte byFilterSwitch; //�˲����أ�0-�����ã�1-����
			public byte byFocusSpeed; //��ͷ�����ٶȣ�0-10
			public byte byAutoCompensationInterval; //��ʱ�Զ����Ų�����1-120����λ������
			public byte bySceneMode;  //����ģʽ��0-���⣬1-���ڣ�2-Ĭ�ϣ�3-����
			public NetDvrDefogcfg struDefogCfg;//͸�����
			public NetDvrElectronicstabilization struElectronicStabilization;//���ӷ���
			public NetDvrCorridorModeCcd struCorridorMode;//����ģʽ
			public byte byExposureSegmentEnable; //0~������,1~����  �ع�ʱ�������ʽ���״�����������ع����ϵ���ʱ��������ع�ʱ�䵽�м�ֵ��Ȼ��������浽�м�ֵ��������ع⵽���ֵ�����������浽���ֵ
			public byte byBrightCompensate;//������ǿ [0~100]

			/*0-�رա�1-640*480@25fps��2-640*480@30ps��3-704*576@25fps��4-704*480@30fps��5-1280*720@25fps��6-1280*720@30fps��
			 * 7-1280*720@50fps��8-1280*720@60fps��9-1280*960@15fps��10-1280*960@25fps��11-1280*960@30fps��
			 * 12-1280*1024@25fps��13--1280*1024@30fps��14-1600*900@15fps��15-1600*1200@15fps��16-1920*1080@15fps��
			 * 17-1920*1080@25fps��18-1920*1080@30fps��19-1920*1080@50fps��20-1920*1080@60fps��21-2048*1536@15fps��22-2048*1536@20fps��
			 * 23-2048*1536@24fps��24-2048*1536@25fps��25-2048*1536@30fps��26-2560*2048@25fps��27-2560*2048@30fps��
			 * 28-2560*1920@7.5fps��29-3072*2048@25fps��30-3072*2048@30fps��31-2048*1536@12.5��32-2560*1920@6.25��
			 * 33-1600*1200@25��34-1600*1200@30��35-1600*1200@12.5��36-1600*900@12.5��37-1600@900@15��38-800*600@25��39-800*600@30*/
			public byte byCaptureModeN; //��Ƶ����ģʽ��N�ƣ�
			public byte byCaptureModeP; //��Ƶ����ģʽ��P�ƣ�
			public NetDvrSmartirParam struSmartIRParam; //����Ź���������Ϣ
			public NetDvrPirisParam struPIrisParam;//PIris������Ϣ��ӦbyIrisMode�ֶδ�2-PIris1��ʼ��Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		//������ɫ
		public enum VcaPlateColor
		{
			VcaBluePlate = 0,//��ɫ����
			VcaYellowPlate,//��ɫ����
			VcaWhitePlate,//��ɫ����
			VcaBlackPlate,//��ɫ����
			VcaGreenPlate //��ɫ����
		}

		//��������
		public enum VcaPlateType
		{
			VcaStandard92Plate = 0,//��׼���ó������
			VcaStandard02Plate,//02ʽ���ó��� 
			VcaWjpolicePlate,//�侯�� 
			VcaJingchePlate,//����
			Standard92BackPlate,//���ó�˫��β��
			VcaShiguanPlate,          //ʹ�ݳ���
			VcaNongyongPlate,         //ũ�ó�
			VcaMotoPlate              //Ħ�г�
		}

		public enum VlrVehicleClass
		{
			VlrOther       = 0,   //����
			VlrVolkswagen = 1,    //����
			VlrBuick        = 2,  //���
			VlrBmw         = 3,   //����
			VlrHonda       = 4,   //����
			VlrPeugeot     = 5,   //����
			VlrToyota      = 6,   //����
			VlrFord         = 7,  //����
			VlrNissan       = 8,  //�ղ�
			VlrAudi         = 9,  //�µ�
			VlrMazda       = 10,  //���Դ�
			VlrChevrolet  = 11,   //ѩ����
			VlrCitroen     = 12,  //ѩ����
			VlrHyundai    = 13,   //�ִ�
			VlrChery       = 14   //����
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
			public byte byVehicleLogoRecog; //�ο�ö������ VlrVehicleClass
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byCustomInfo;  //�Զ�����Ϣ
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
			public ushort wAlarmRecordID;	//����¼��ID(���ڲ�ѯ¼�񣬽���byResultTypeΪ2ʱ��Ч)
			public uint dwRelativeTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAbsTime;
			public uint dwPicLen;
			public uint dwPicPlateLen;
			public uint dwVideoLen;
			public byte byTrafficLight;
			public byte byPicNum;
			public byte byDriveChan;
			public byte byVehicleType; //0- δ֪��1- �ͳ���2- ������3- �γ���4- �������5- С����
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

		//ͼ�������Ϣ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrImageoverlaycfg
		{
			public uint dwSize;
			public byte byOverlayInfo;//����ʹ�ܿ��أ�0-�����ӣ�1-����
			public byte byOverlayMonitorInfo;//�Ƿ���Ӽ�����Ϣ��0-�����ӣ�1-����
			public byte byOverlayTime;//�Ƿ����ʱ�䣬0-�����ӣ�1-����
			public byte byOverlaySpeed;//�Ƿ�����ٶȣ�0-�����ӣ�1-����
			public byte byOverlaySpeeding;//�Ƿ���ӳ��ٱ�����0-�����ӣ�1-����
			public byte byOverlayLimitFlag;//�Ƿ�������ٱ�־��0-�����ӣ�1-����
			public byte byOverlayPlate;//�Ƿ���ӳ��ƺţ�0-�����ӣ�1-����
			public byte byOverlayColor;//�Ƿ���ӳ�����ɫ��0-�����ӣ�1-����
			public byte byOverlayLength;//�Ƿ���ӳ�����0-�����ӣ�1-����
			public byte byOverlayType;//�Ƿ���ӳ��ͣ�0-�����ӣ�1-����
			public byte byOverlayColorDepth;//�Ƿ���ӳ�����ɫ��ǳ��0-�����ӣ�1-����
			public byte byOverlayDriveChan;//�Ƿ���ӳ�����0-�����ӣ�1-����
			public byte byOverlayMilliSec; //���Ӻ�����Ϣ 0-�����ӣ�1-����
			public byte byOverlayIllegalInfo; //����Υ����Ϣ 0-�����ӣ�1-����
			public byte byOverlayRedOnTime;  //���Ӻ������ʱ�� 0-�����ӣ�1-����
			public byte byFarAddPlateJpeg;      //Զ��ͼ�Ƿ���ӳ��ƽ�ͼ,0-������,1-����
			public byte byNearAddPlateJpeg;      //����ͼ�Ƿ���ӳ��ƽ�ͼ,0-������,1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;    //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitorInfo1;    //������Ϣ1
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitorInfo2; //������Ϣ2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //����
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
			ItcModeUnknow = 0x0,   //��
			ItcPostMode   = 0x1,  //����ģʽ
			ItcEpoliceMode      = 0x2,  //�羯ģʽ
			ItcPostepoliceMode  = 0x4  //��ʽ�羯ģʽ
		}

		public enum ItcRecogRegionType
		{
			ItcRegionRect    = 0x0,   //����
			ItcRegionPolygon  = 0x1,  //�����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnapAbility
		{
			public uint dwSize;
			public byte byIoInNum;//IO�������
			public byte byIoOutNum;//IO�������
			public byte bySingleSnapNum;//��IO��������
			public byte byLightModeArrayNum;//���̵�ģʽ����
			public byte byMeasureModeArrayNum;//����ģʽ����
			public byte byPlateEnable; //����ʶ������
			public byte byLensMode;//��ͷģʽ0-CCD,1-CMOS
			public byte byPreTriggerSupport; //�Ƿ�֧��ԭ����ģʽ��0-֧�֣�1-��֧��
			public uint dwAbilityType; //֧�ֵĴ���ģʽ��������λ��ʾ�������ITC_MAINMODE_ABILITY
			public byte byIoSpeedGroup; //֧�ֵ�IO��������
			public byte byIoLightGroup; //֧�ֵ�IO���̵�����
			public byte byRecogRegionType; //��ʶ����֧�ֵ����ͣ��������ITC_RECOG_REGION_TYPE
			public byte bySupport; //�豸��������λ��ʾ��0-��֧�֣�1-֧��
			// bySupport&0x1����ʾ�Ƿ�֧����չ���ַ���������
			// bySupport&0x2����ʾ�Ƿ�֧����չ��Уʱ���ýṹ
			// bySupport&0x4, ��ʾ�Ƿ�֧�ֶ�����(��������)
			// bySupport&0x8, ��ʾ�Ƿ�֧��������bonding����(�����ݴ�)
			// bySupport&0x10, ��ʾ�Ƿ�֧�������Խ�
			//2013-07-09 ����������
			public ushort wSupportMultiRadar;// �豸��������λ��ʾ��0-��֧�֣�1-֧��
			// wSupportMultiRadar&0x1����ʾ ����RS485�״� ֧�ֳ��������״ﴦ��
			// wSupportMultiRadar&0x2����ʾ ����������Ȧ ֧�ֳ��������״ﴦ��
			// wSupportMultiRadar&0x4����ʾ ���п��� ֧�ֳ��������״ﴦ��
			// wSupportMultiRadar&0x8����ʾ ��Ƶ��� ֧�ֳ��������״ﴦ��
			public byte byICRPresetNum;
			// ��ʾ֧�ֵ�ICRԤ�õ㣨�˹�Ƭƫ�Ƶ㣩��
			public byte byICRTimeSlot;//��ʾ֧�ֵ�ICR��ʱ�������1��8��
			public byte bySupportRS485Num;//��ʾ֧�ֵ�RS485�ڵ�����
			public byte byExpandRs485SupportSensor;// �豸��������λ��ʾ��0-��֧�֣�1-֧��
			// byExpandRs485SupportSensor &0x1����ʾ�羯������֧�ֳ�����
			// byExpandRs485SupportSensor &0x2����ʾ��ʽ�羯������֧�ֳ�����
			public byte byExpandRs485SupportSignalLampDet;// �豸��������λ��ʾ��0-��֧�֣�1-֧��
			// byExpandRs485SupportSignalLampDet &0x1����ʾ�羯������֧������źŵƼ����
			// byExpandRs485SupportSignalLampDet &0x2����ʾ��ʽ�羯������֧������źŵƼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrtimecfg
		{
			public NetDvrSchedtime  struTime;
			public byte byAssociateRresetNo;//Ԥ�õ��1��8 , 0������
			public byte bySubSwitchMode;//1~���죬2~���� (��Ԥ�õ����0 ��ʱ����Ч)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrTimeswitchParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetItcIcrtimecfg[] struAutoCtrlTime;//�Զ��л�ʱ��� (�Զ��л��� ʱ������Ч ����֧��4�飬Ԥ��4��)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIcrNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byICRPreset; //ʵ����Ч������������̬��ʾ [0~100] �����±��ʾԤ�õ��1��8 ��0��7 ���Ӧ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrManualswitchParam
		{	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIcrNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byICRPreset; //ʵ����Ч������������̬��ʾ [0~100]
			public byte  bySubSwitchMode;//1~���죬2~����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcIcrAotoswitchParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIcrNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byICRPreset; //ʵ����Ч������������̬��ʾ [0~100] �����±��ʾԤ�õ��1��8 ��0��7 ���Ӧ��
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
			public byte bySwitchType;//1~�Զ��л���2~�ֶ��л� ,3~��ʱ�л� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetItcIcrParamUnion uICRParam;
		}

		//2013-07-09 �쳣����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcHandleexception
		{
			public uint dwHandleType; //�쳣����,�쳣����ʽ��"��"���
			/*0x00: ����Ӧ*/
			/*0x01: �������Ͼ���*/
			/*0x02: ��������*/
			/*0x04: �ϴ�����*/
			/*0x08: ��������������̵��������*/
			/*0x10: ����JPRGץͼ���ϴ�Email*/
			/*0x20: �������ⱨ��������*/
			/*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
			/*0x200: ץͼ���ϴ�FTP*/  
			public byte byEnable; //0�������ã�1������
			public byte byRes;
			public ushort wDuration;//����ʱ��(��λ/s)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxItcExceptionout, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutTriggered;//�������ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetItcException
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxExceptionnumV30, ArraySubType = UnmanagedType.Struct)]
			public NetItcHandleexception[] struSnapExceptionType; 
			//�����ÿ��Ԫ�ض���ʾһ���쳣������0- Ӳ�̳���,1-���߶�,2-IP ��ַ��ͻ, 3-�������쳣, 4-�źŵƼ�����쳣
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTrigcoordinate
		{
			public ushort wTopLeftX; /*��Ȧ���ϽǺ����꣨2���ֽڣ�*/
			public ushort wTopLeftY; /*��Ȧ���Ͻ������꣨2���ֽڣ�*/
			public ushort wWdith; /*��Ȧ��ȣ�2���ֽڣ�*/
			public ushort wHeight; /*��Ȧ�߶ȣ�2���ֽڣ�*/
		}

		public enum ProvinceCityIdx
		{
			AnhuiProvince             = 0,              //����
			AomenProvince             = 1,              //����
			BeijingProvince           = 2,              //����
			ChongqingProvince         = 3,              //����
			FujianProvince            = 4,              //����
			GansuProvince             = 5,              //����
			GuangdongProvince         = 6,              //�㶫
			GuangxiProvince           = 7,              //����
			GuizhouProvince           = 8,              //����
			HainanProvince            = 9,              //����
			HebeiProvince             = 10,             //�ӱ�
			HenanProvince             = 11,             //����
			HeilongjiangProvince      = 12,             //������
			HubeiProvince             = 13,             //����
			HunanProvince             = 14,             //����
			JilinProvince             = 15,             //����
			JiangsuProvince           = 16,             //����
			JiangxiProvince           = 17,             //����
			LiaoningProvince          = 18,             //����
			NeimengguProvince         = 19,             //���ɹ�
			NingxiaProvince           = 20,             //����
			QinghaiProvince           = 21,             //�ຣ
			ShandongProvince          = 22,             //ɽ��
			ShanxiJinProvince        = 23,             //ɽ��
			ShanxiShanProvince       = 24,             //����
			ShanghaiProvince          = 25,             //�Ϻ�
			SichuanProvince           = 26,             //�Ĵ�
			TaiwanProvince            = 27,             //̨��
			TianjinProvince           = 28,             //���
			XizangProvince            = 29,             //����
			XianggangProvince         = 30,             //���
			XinjiangProvince          = 31,             //�½�
			YunnanProvince            = 32,             //����
			ZhejiangProvince          = 33              //�㽭
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrGeoglocation
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
			public int[] iRes; /*����*/
			public uint dwCity; /*���У����PROVINCE_CITY_IDX */
		}

		//����ģʽ
		public enum SceneMode
		{
			UnkownSceneMode   = 0,            //δ֪����ģʽ
			HighwaySceneMode  = 1,            //���ٳ���ģʽ
			SuburbanSceneMode = 2,            //��������ģʽ(����)
			UrbanSceneMode    = 3,            //��������ģʽ
			TunnelSceneMode   = 4             //�������ģʽ(����)
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVtparam
		{
			public uint dwSize;
			public byte byEnable;  /* �Ƿ�ʹ��������Ȧ��0-��ʹ�ã�1-ʹ��*/
			public byte byIsDisplay; /* �Ƿ���ʾ������Ȧ��0-����ʾ��1-��ʾ*/
			public byte byLoopPos; //��䴥����Ȧ��ƫ��0-���ϣ�1-����
			public byte bySnapGain; /*ץ������*/
			public uint dwSnapShutter; /*ץ�Ŀ����ٶ�*/
			public NetDvrTrigcoordinate struTrigCoordinate; //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVlNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrTrigcoordinate[] struRes;
			public byte byTotalLaneNum;/*��Ƶ�����ĳ�����1*/
			public byte byPolarLenType; /*ƫ�����ͣ�0������ƫ�񾵣�1����ʩ�͵�ƫ�񾵡�*/
			public byte	byDayAuxLightMode; /*���츨������ģʽ��0���޸���������1��LED��������2�����������*/
			public byte	byLoopToCalRoadBright; /*���Լ���·�����ȵĳ���(������Ȧ)*/
			public byte	byRoadGrayLowTh; /*·�����ȵ���ֵ��ʼ��ֵ1*/
			public byte	byRoadGrayHighTh; /*·�����ȸ���ֵ��ʼ��ֵ140*/
			public ushort wLoopPosBias; /*��䴥����Ȧλ��30*/
			public uint dwHfrShtterInitValue; /*����ͼ���ع�ʱ��ĳ�ʼֵ2000*/
			public uint dwSnapShtterInitValue; /*ץ��ͼ���ع�ʱ��ĳ�ʼֵ500*/
			public uint dwHfrShtterMaxValue; /*����ͼ���ع�ʱ������ֵ20000*/
			public uint dwSnapShtterMaxValue; /*ץ��ͼ���ع�ʱ������ֵ1500*/
			public uint dwHfrShtterNightValue; /*�������ͼ���ع�ʱ�������ֵ3000*/
			public uint dwSnapShtterNightMinValue; /*���ץ��ͼ���ع�ʱ�����Сֵ3000*/
			public uint dwSnapShtterNightMaxValue; /*���ץ��ͼ���ع�ʱ������ֵ5000*/
			public uint dwInitAfe; /*����ĳ�ʼֵ200*/
			public uint dwMaxAfe; /*��������ֵ400*/
			public ushort wResolutionX;/* �豸��ǰ�ֱ��ʿ�*/
			public ushort wResolutionY;/* �豸��ǰ�ֱ��ʸ�*/
			public uint dwGainNightValue; /*������棬Ĭ��ֵ70*/
			public uint dwSceneMode; /*����ģʽ�� ���SCENE_MODE */
			public uint dwRecordMode; /*¼���־��0-��¼��1-¼��*/
			public NetDvrGeoglocation struGeogLocation; /*��ַλ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVlNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrigFlag; /*������־��0-��ͷ������1-��β������2-��ͷ/��β������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVlNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrigSensitive;  /*���������ȣ�1-100*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnapenablecfg
		{
			public uint dwSize;
			public byte byPlateEnable;//�Ƿ�֧�ֳ���ʶ��0-��֧�֣�1-֧��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;   //����
			public byte byFrameFlip;   //ͼ���Ƿ�ת 0-����ת��1-��ת
			public ushort wFlipAngle;    //ͼ��ת�Ƕ� 0,90,180,270
			public ushort wLightPhase;   //��λ��ȡֵ��Χ[0, 360]
			public byte byLightSyncPower;  //�Ƿ��źŵƵ�Դͬ����0-��ͬ����1-ͬ��
			public byte byFrequency;		//�ź�Ƶ��
			public byte byUploadSDEnable;  //�Ƿ��Զ��ϴ�SDͼƬ��0-��1-��
			public byte byPlateMode; //ʶ��ģʽ����:0-��Ƶ����,1-�ⲿ����
			public byte byUploadInfoFTP; //�Ƿ��ϴ�ץ�ĸ�����Ϣ��FTP��0-��1-��
			public byte byAutoFormatSD; //�Ƿ��Զ���ʽ��SD����0-��1-��
			public ushort wJpegPicSize; //JpegͼƬ��С[64-8196]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		/*ftp�ϴ�����*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFtpcfg
		{
			public uint dwSize;
			public uint dwEnableFTP;			/*�Ƿ�����ftp�ϴ�����*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string sFTPIP;				/*ftp ������*/
			public uint dwFTPPort;				/*ftp�˿�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	/*�û���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	/*����*/
			public uint dwDirLevel;	/*0 = ��ʹ��Ŀ¼�ṹ��ֱ�ӱ����ڸ�Ŀ¼,1 = ʹ��1��Ŀ¼,2=ʹ��2��Ŀ¼*/
			public ushort wTopDirMode;	/* һ��Ŀ¼��0x1 = ʹ���豸��,0x2 = ʹ���豸��,0x3 = ʹ���豸ip��ַ��0x4=ʹ�ü���,0x5=ʹ��ʱ��(����),0x=6�Զ���,0x7=Υ������,0x8=����,0x9=�ص�*/
			public ushort wSubDirMode;	/* ����Ŀ¼��0x1 = ʹ��ͨ����,0x2 = ʹ��ͨ���ţ�,0x3=ʹ��ʱ��(������),0x4=ʹ�ó�����,0x=5�Զ���,0x6=Υ������,0x7=����,0x8=�ص�*/
			public byte byEnableAnony; //����������0-��1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*����������ͼƬ�����Ԫ�� */
		public const int PicnameItemDevName = 1;		/*�豸��*/
		public const int PicnameItemDevNo = 2;		/*�豸��*/
		public const int PicnameItemDevIp = 3;		/*�豸IP*/
		public const int PicnameItemChanName = 4;	/*ͨ����*/
		public const int PicnameItemChanNo = 5;		/*ͨ����*/
		public const int PicnameItemTime = 6;		/*ʱ��*/
		public const int PicnameItemCardno = 7;		/*����*/
		public const int PicnameItemPlateNo = 8;   /*���ƺ���*/
		public const int PicnameItemPlateColor = 9;   /*������ɫ*/
		public const int PicnameItemCarChan = 10;  /*������*/
		public const int PicnameItemCarSpeed = 11;  /*�����ٶ�*/
		public const int PicnameItemCarchan = 12;  /*����*/
		public const int PicnameItemPicNumber = 13;  //ͼƬ���
		public const int PicnameItemCarNumber = 14;  //�������

		public const int PicnameItemSpeedLimitValues = 15; //����ֵ
		public const int PicnameItemIllegalCode = 16; //����Υ������
		public const int PicnameItemCrossNumber = 17; //·�ڱ��
		public const int PicnameItemDirectionNumber = 18; //������

		public const int PicnameMaxitem = 15;
		//ͼƬ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPictureName
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PicnameMaxitem, ArraySubType = UnmanagedType.I1)]
			public byte[] byItemOrder;	/*	�����鶨���ļ������Ĺ��� */
			public byte byDelimiter;		/*�ָ�����һ��Ϊ'_'*/
		}


		//��������2013-09-27
		public const int PicnameItemParkDevIp = 1;	/*�豸IP*/
		public const int PicnameItemParkPlateNo = 2;/*���ƺ���*/
		public const int PicnameItemParkTime = 3;	/*ʱ��*/
		public const int PicnameItemParkIndex = 4;   /*��λ���*/
		public const int PicnameItemParkStatus = 5;  /*��λ״̬*/

		//ͼƬ������չ 2013-09-27
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPictureNameEx
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PicnameMaxitem, ArraySubType = UnmanagedType.I1)]
			public byte[] byItemOrder;	/*	�����鶨���ļ������Ĺ��� */
			public byte byDelimiter;	            	/*�ָ�����һ��Ϊ'_'*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                      /*����*/
		}

		/* ����ץͼ����*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSerialCatchpicPara
		{
			public byte byStrFlag;	/*�������ݿ�ʼ��*/
			public byte byEndFlag;	/*������*/
			public ushort wCardIdx;	/*���������ʼλ*/
			public uint dwCardLen;	/*���ų���*/
			public uint dwTriggerPicChans;	/*��������ͨ���ţ���λ���ӵ�1λ��ʼ�ƣ���0x2��ʾ��һͨ��*/
		}

		//DVRץͼ�������ã����ߣ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegcfgV30
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrJpegpara[] struJpegPara;	/*ÿ��ͨ����ͼ�����*/
			public ushort wBurstMode;							/*ץͼ��ʽ,��λ����.0x1=�������봥����0x2=�ƶ���ⴥ�� 0x4=232������0x8=485������0x10=���紥��*/
			public ushort wUploadInterval;					/*ͼƬ�ϴ����(��)[0,65535]*/
			public NetDvrPictureName 	struPicNameRule;	/* ͼƬ�������� */
			public byte bySaveToHD;		/*�Ƿ񱣴浽Ӳ��*/
			public byte byRes1;
			public ushort wCatchInterval;		/*ץͼ���(����)[0,65535]*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrSerialCatchpicPara struRs232Cfg;
			public NetDvrSerialCatchpicPara struRs485Cfg;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwTriggerPicTimes;	/* ÿ��ͨ��һ�δ������մ��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminV30, ArraySubType = UnmanagedType.U4)]
			public uint[] dwAlarmInPicChanTriggered; /*��������ץ��ͨ��,��λ���ã��ӵ�1λ��ʼ*/
		}

		//ץ�Ĵ�������ṹ(����)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrManualsnap
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSprcfg    
		{
			public uint dwSize; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChjcNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byDefaultCHN; /*�豸����ʡ�ݵĺ��ּ�д*/
			public byte byPlateOSD;    /*0:�����ͳ��Ʋ�ɫͼ,1:���ͳ��Ʋ�ɫͼ*/
			public byte bySendJPEG1;   /*0-�����ͽ���JPEGͼ,1-���ͽ���JPEGͼ*/
			public byte bySendJPEG2;   /*0-������Զ��JPEGͼ,1-����Զ��JPEGͼ*/
			public ushort wDesignedPlateWidth;   /*������ƿ��*/
			public byte byTotalLaneNum;  /*ʶ��ĳ�����*/
			public byte byRes1;      /*����*/
			public ushort wRecognizedLane;  /*ʶ��ĳ����ţ���λ��ʾ��bit0��ʾ����1�Ƿ�ʶ��0-��ʶ��1-ʶ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLanerectNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaRect[] struLaneRect;  /*����ʶ������*/
			public uint dwRecogMode;  /*ʶ������ͣ�
			bit0-����ʶ��0-������ʶ��1-����ʶ��(β��ʶ��) �� 
			bit1-����ʶ���С����ʶ��0-С����ʶ��1-����ʶ�� ��
			bit2-������ɫʶ��0-�����ó�����ɫʶ���ڱ���ʶ���С����ʶ��ʱ��ֹ���ã�1-������ɫʶ��
			bit3-ũ�ó�ʶ��0-������ũ�ó�ʶ��1-ũ�ó�ʶ�� 
			bit4-ģ��ʶ��0-������ģ��ʶ��1-ģ��ʶ��
			bit5-֡��λ�򳡶�λ��0-֡��λ��1-����λ��
			bit6-֡ʶ���ʶ��0-֡ʶ��1-��ʶ�� 
			bit7-���ϻ���죺0-���죬1-���� */
			public byte bySendPRRaw;       	//�Ƿ���ԭͼ��0-�����ͣ�1-���� 
			public byte bySendBinImage;  	//�Ƿ��ͳ��ƶ�ֵͼ��0-�����ͣ�1-���� 
			public byte byDelayCapture;  //��ʱץ�Ŀ���,��λ��֡
			public byte byUseLED;    //ʹ��LED���ƣ�0-��1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlccfg
		{
			public uint dwSize;
			public byte byPlcEnable;	//�Ƿ����ó������Ȳ�����Ĭ�����ã���0-�رգ�1-���� 
			public byte byPlateExpectedBright;	//���Ƶ�Ԥ�����ȣ�Ĭ��ֵ50��, ��Χ[0, 100]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	//���� 
			public byte byTradeoffFlash;     //�Ƿ�������Ƶ�Ӱ��: 0 - ��;  1 - ��(Ĭ��); 
			//ʹ������Ʋ���ʱ, ������Ǽ�������Ƶ�������ǿЧӦ, ����Ҫ��Ϊ1;����Ϊ0
			public byte byCorrectFactor;     //����ϵ��, ��Χ[0, 100], Ĭ��ֵ50 (��tradeoff_flash�л�ʱ,�ָ�Ĭ��ֵ��
			public ushort wLoopStatsEn;  //�Ƿ����Ȧ�����ȣ���λ��ʾ��0-��ͳ�ƣ�1-ͳ��
			public byte byPlcBrightOffset;// �������Ȳ���������(������Ȧģʽ��Ч)��ȡֵ��Χ1~100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevicestatecfg
		{
			public uint dwSize;
			public ushort wPreviewNum; //Ԥ�����Ӹ���
			public ushort wFortifyLinkNum; //�������Ӹ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLink, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struPreviewIP;  //Ԥ�����û�IP��ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxFortifyNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrIpaddr[] struFortifyIP; //�������ӵ��û�IP��ַ
			public uint dwVideoFrameRate;	//֡�ʣ�0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
			public byte byResolution;  	//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5��������,16-VGA��640*480��, 17-UXGA��1600*1200��, 18-SVGA ��800*600��,19-HD720p��1280*720��,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
			public byte bySnapResolution;  	//ץ�ķֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5��������,16-VGA��640*480��, 17-UXGA��1600*1200��, 18-SVGA ��800*600��,19-HD720p��1280*720��,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
			public byte byStreamType; //�������ͣ�0-��������1-������
			public byte byTriggerType; //����ģʽ��0-��Ƶ������1-��ͨ����
			public uint dwSDVolume;  //SD������
			public uint dwSDFreeSpace; //SD��ʣ��ռ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDrivechanNum * MaxCoilNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byDetectorState;  //������״̬��0-δʹ�ã�1-������2-�쳣
			public byte byDetectorLinkState; //����������״̬��0-δ���ӣ�1-����
			public byte bySDStatus;    //SD��״̬ 0�����1�����ߣ�2���쳣��3-��sd��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxFortifyNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byFortifyLevel; //�����ȼ���0-�ޣ�1-һ�ȼ����ߣ���2-���ȼ����У���3-���ȼ����ͣ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPostepolicecfg
		{
			public uint dwSize;
			public uint dwDistance;//��Ȧ����,��λcm��ȡֵ��Χ[0,20000]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSignallightNum, ArraySubType = UnmanagedType.U4)]
			public uint[] dwLightChan;	//�źŵ�ͨ����
			public byte byCapSpeed;//��־���٣���λkm/h��ȡֵ��Χ[0,255]
			public byte bySpeedLimit;//����ֵ����λkm/h��ȡֵ��Χ[0,255]
			public byte byTrafficDirection;//��������0-�ɶ�������1-�����򶫣�2-�����򱱣�3-�ɱ�����
			public byte byRes1; //����
			public ushort wLoopPreDist;        /*�����ӳپ��� ����λ������*/
			public ushort wTrigDelay;             /*����Ӳ��ʱʱ�� ����λ������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//�����ֽ�
		}
		/***************************** end *********************************************/
		public const int IpcProtocolNum = 50;  //ipc Э��������

		//Э������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrProtoType
		{
			public uint dwType;               /*ipcЭ��ֵ*/
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = DescLen)]
			public string byDescribe; /*Э�������ֶ�*/
		}

		//Э���б�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpcProtoList
		{    
			public uint dwSize; 
			public uint dwProtoNum;           /*��Ч��ipcЭ����Ŀ*/  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = IpcProtocolNum, ArraySubType = UnmanagedType.Struct)]            
			public NetDvrProtoType[] struProto;   /*��Ч��ipcЭ��*/    
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int MaxAlertlineNum = 8; //��󾯽�������	
		
		//Խ������ѯ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTraversePlaneSearchcond
		{	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlertlineNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaTraversePlane[] struVcaTraversePlane;  //��Խ���������
			public uint dwPreTime;   /*���ܱ�����ǰʱ�� ��λ:��*/
			public uint dwDelayTime; /*���ܱ����ӳ�ʱ�� ��λ:��*/ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		} 

		public const int MaxIntrusionregionNum = 8; //�����������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIntrusionSearchcond  
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxIntrusionregionNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaIntrusion[] struVcaIntrusion; //��������
			public uint dwPreTime;   /*���ܱ�����ǰʱ�� ��λ:��*/
			public uint dwDelayTime; /*���ܱ����ӳ�ʱ�� ��λ:��*/ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}


		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrAreaSmartsearchCondUnion
		{  
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
			public byte[] byLen;  //�ṹ�峤��
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
			public byte[] byMotionScope; //������� 0-96λ��ʾ64�У�����96*64��С��飬1-���ƶ��������0-���ƶ�������� 
			[FieldOffset(0)]
			public NetDvrTraversePlaneSearchcond struTraversPlaneCond; //Խ�����
			[FieldOffset(0)]
			public NetDvrIntrusionSearchcond struIntrusionCond; //��������
		}

		//������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSmartSearchParam
		{
			public byte byChan;					//ͨ����
			public byte bySearchCondType; //���ܲ���������NET_DVR_AREA_SMARTSEARCH_COND_UNION������     
			/*0-�ƶ�������� ��1-Խ����⣬ 2-��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrTime struStartTime;		//¼��ʼ��ʱ��
			public NetDvrTime struEndTime;		//¼��ֹͣ��ʱ��
			public NetDvrAreaSmartsearchCondUnion uSmartSearchCond;  //���ܲ�������
			public byte bySensitivity;   			//�ƶ��������������,1	>80%  2 40%~80%  3 1%~40%
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
	
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSmartSearchRet
		{
			public NetDvrTime struStartTime;	//�ƶ���ⱨ����ʼ��ʱ��
			public NetDvrTime struEndTime;   //�¼�ֹͣ��ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//IPSAN �ļ�Ŀ¼����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpsanSerachParam
		{
			public NetDvrIpaddr  struIP;     // IPSAN IP��ַ
			public ushort wPort;      // IPSAN  �˿�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpsanSerachRet
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byDirectory;  // ���ص��ļ�Ŀ¼
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//DVR�豸����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevicecfgV40
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDVRName; //DVR����
			public uint dwDVRID;				//DVR ID,����ң���� //V1.4(0-99), V1.5(0-255)
			public uint dwRecycleRecord;		//�Ƿ�ѭ��¼��,0:����; 1:��
			//���²��ɸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber; //���к�
			public uint dwSoftwareVersion;			//����汾��,��16λ�����汾,��16λ�Ǵΰ汾
			public uint dwSoftwareBuildDate;			//�����������,0xYYYYMMDD
			public uint dwDSPSoftwareVersion;		    //DSP����汾,��16λ�����汾,��16λ�Ǵΰ汾
			public uint dwDSPSoftwareBuildDate;		// DSP�����������,0xYYYYMMDD
			public uint dwPanelVersion;				// ǰ���汾,��16λ�����汾,��16λ�Ǵΰ汾
			public uint dwHardwareVersion;	// Ӳ���汾,��16λ�����汾,��16λ�Ǵΰ汾
			public byte byAlarmInPortNum;		//DVR�����������
			public byte byAlarmOutPortNum;		//DVR�����������
			public byte byRS232Num;			//DVR 232���ڸ���
			public byte byRS485Num;			//DVR 485���ڸ��� 
			public byte byNetworkPortNum;		//����ڸ���
			public byte byDiskCtrlNum;			//DVR Ӳ�̿���������
			public byte byDiskNum;				//DVR Ӳ�̸���
			public byte byDVRType;				//DVR����, 1:DVR 2:ATM DVR 3:Dvs ......
			public byte byChanNum;				//DVR ͨ������
			public byte byStartChan;			//��ʼͨ����,����DVS-1,DVR - 1
			public byte byDecordChans;			//DVR ����·��
			public byte byVGANum;				//VGA�ڵĸ��� 
			public byte byUSBNum;				//USB�ڵĸ���
			public byte byAuxoutNum;			//���ڵĸ���
			public byte byAudioNum;			//�����ڵĸ���
			public byte byIPChanNum;			//�������ͨ���� ��8λ����8λ��byHighIPChanNum 
			public byte byZeroChanNum;			//��ͨ���������
			public byte bySupport;        //������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧�֣�
			//bySupport & 0x1, ��ʾ�Ƿ�֧����������
			//bySupport & 0x2, ��ʾ�Ƿ�֧�ֱ���
			//bySupport & 0x4, ��ʾ�Ƿ�֧��ѹ������������ȡ
			//bySupport & 0x8, ��ʾ�Ƿ�֧�ֶ�����
			//bySupport & 0x10, ��ʾ֧��Զ��SADP
			//bySupport & 0x20, ��ʾ֧��Raid������
			//bySupport & 0x40, ��ʾ֧��IPSAN����
			//bySupport & 0x80, ��ʾ֧��rtp over rtsp
			public byte byEsataUseage;		//Esata��Ĭ����;��0-Ĭ�ϱ��ݣ�1-Ĭ��¼��
			public byte byIPCPlug;			//0-�رռ��弴�ã�1-�򿪼��弴��
			public byte byStorageMode;		//0-����ģʽ,1-�������, 2��֡ģʽ
			public byte bySupport1;		//������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
			//bySupport1 & 0x1, ��ʾ�Ƿ�֧��snmp v30
			//bySupport1 & 0x2, ֧�����ֻطź�����
			//bySupport1 & 0x4, �Ƿ�֧�ֲ������ȼ�	
			//bySupport1 & 0x8, �����豸�Ƿ�֧�ֲ���ʱ�����չ
			//bySupport1 & 0x10, ��ʾ�Ƿ�֧�ֶ������������33����
			//bySupport1 & 0x20, ��ʾ�Ƿ�֧��rtsp over http	
			public ushort wDevType;//�豸�ͺ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DevTypeNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDevTypeName;//�豸�ͺ����� 
			public byte bySupport2; //��������չ��λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
			//bySupport2 & 0x1, ��ʾ�Ƿ�֧����չ��OSD�ַ�����(�ն˺�ץ�Ļ���չ����)
			public byte byAnalogAlarmInPortNum; //ģ�ⱨ���������
			public byte byStartAlarmInNo;    //ģ�ⱨ��������ʼ��
			public byte byStartAlarmOutNo;  //ģ�ⱨ�������ʼ��
			public byte byStartIPAlarmInNo;  //IP����������ʼ��  0-��Ч
			public byte byStartIPAlarmOutNo; //IP���������ʼ�� 0-��Ч
			public byte byHighIPChanNum;     //����ͨ����������8λ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			//����
		}

		public const int MaxZerochanNum = 16;
		//��ͨ��ѹ�����ò���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrZerochancfg
		{
			public uint dwSize;			    //�ṹ����
			public byte byEnable;			//0-ֹͣ��ͨ�����룬1-��ʾ������ͨ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			//����
			public uint dwVideoBitrate; 	/*��Ƶ���� 0-���� 1-16K(����) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
											 * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
											 * 23-2048K
											 * ���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ(MIN-32K MAX-8192K) */
			public uint dwVideoFrameRate;	//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
											//V2.0����14-15, 15-18, 16-22;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;        //����
		}

		//��ͨ�����Ų���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrZeroZoomcfg
		{
			public uint dwSize;			    //�ṹ����
			public NetVcaPoint struPoint;	//�����е������
			public byte byState;		 //���ڵ�״̬��0-��С��1-�Ŵ�  
			public byte byPreviewNumber;       //Ԥ����Ŀ,0-1����,1-4����,2-9����,3-16���� �ò���ֻ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byPreviewSeq;//����ͨ����Ϣ �ò���ֻ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;				//���� 
		}

		public const int DescLen64 = 64;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnmpcfg
		{
			public uint dwSize;			//�ṹ����
			public byte byEnable;			//0-����SNMP��1-��ʾ����SNMP
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			//����
			public ushort wVersion;		//snmp �汾  v1 = 1, v2 =2, v3 =3���豸Ŀǰ��֧�� v3
			public ushort wServerPort; //snmp��Ϣ���ն˿ڣ�Ĭ�� 161
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byReadCommunity; //����ͬ�壬���31,Ĭ��"public"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byWriteCommunity;//д��ͬ��,���31 �ֽ�,Ĭ�� "private"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen64, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapHostIP;	//��������ip��ַ������֧��IPV4 IPV6����������    
			public ushort wTrapHostPort;   //trap�����˿�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapName;	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnmPv3User
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName;			// �û���				
			public byte bySecLevel;	//��ȫ���� 1-��У�� 2-����ȨУ�� 3-��ȨУ��
			public byte byAuthtype;	//��֤���� 0-MD5��֤ 1-SHA��֤ 2: none
			public byte byPrivtype;	//0: DES; 1: AES; 2: none;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byAuthpass;	//��֤����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPrivpass;	//��������
		}
		
		//snmpv30
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSnmpcfgV30
		{
			public uint dwSize;			//�ṹ����
			public byte byEnableV1;		//0-����SNMP V1��1-��ʾ����SNMP V1
			public byte byEnableV2;		//0-����SNMP V2��1-��ʾ����SNMP V2
			public byte byEnableV3;		//0-����SNMP V3��1-��ʾ����SNMP V3
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public ushort wServerPort;					//snmp��Ϣ���ն˿ڣ�Ĭ�� 161
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byReadCommunity;		//����ͬ�壬���31,Ĭ��"public"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byWriteCommunity;		//д��ͬ��,���31 �ֽ�,Ĭ�� "private"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen64, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapHostIP;		//��������ip��ַ������֧��IPV4 IPV6����������    
			public ushort wTrapHostPort;					// trap�����˿�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;       
			public NetDvrSnmPv3User struRWUser;    // ��д�û�
			public NetDvrSnmPv3User struROUser;    // ֻ���û�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byTrapName;
		}
		
		public const int Processing = 0;    //���ڴ���
		public const int ProcessSuccess = 100;   //�������
		public const int ProcessException = 400;   //�����쳣
		public const int ProcessFailed = 500;   //����ʧ��
		public const int ProcessQuickSetupPdCount = 501; //һ����������3��Ӳ��

		public const int SoftwareVersionLen = 48;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSadpinfo
		{
			public NetDvrIpaddr struIP;     // �豸IP��ַ
			public ushort wPort;      // �豸�˿ں�
			public ushort wFactoryType;   // �豸��������
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = SoftwareVersionLen)]
			public string chSoftwareVersion;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string chSerialNo; // ���к�
			public ushort wEncCnt;   // ����ͨ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMACAddr;		// MAC ��ַ
			public NetDvrIpaddr struSubDVRIPMask;   // DVR IP��ַ����
			public NetDvrIpaddr struGatewayIpAddr;  // ����
			public NetDvrIpaddr struDnsServer1IpAddr;	/* ����������1��IP��ַ */
			public NetDvrIpaddr struDnsServer2IpAddr;	/* ����������2��IP��ַ */
			public byte byDns;
			public byte byDhcp;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     // �����ֽ�
		}

		public const int MaxSadpNum = 256;  //�������豸�����Ŀ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSadpinfoList
		{
			public uint dwSize;   //  �ṹ��С
			public ushort wSadpNum;   // �������豸��Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSadpNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSadpinfo[] struSadpInfo; // ����
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

		/*******************************���ݽṹ begin********************************/
		//��ȡ�����豸��Ϣ�ӿڶ���
		public const int DescLen32 = 32;   //�����ֳ���
		public const int MaxNodeNum = 256;  //�ڵ����

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDescNode
		{ 
			public int iValue; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe; //�����ֶ� 
			public uint dwFreeSpace; //��ȡ�����б�ר��,��λΪM
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;			  //����  
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskabilityList
		{ 
			public uint dwSize;            //�ṹ����
			public uint dwNodeNum;		 //����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNodeNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDescNode[] struDescNode;  //��������  
		}

		//���ݽ����б�
		public const int BackupSuccess            =    100;  //�������
		public const int BackupChangeDevice      =    101;  //�����豸�����������豸��������

		public const int BackupSearchDevice      =    300;  //�������������豸
		public const int BackupSearchFile        =    301;  //��������¼���ļ�
		public const int BackupSearchLogFile    =    302;  //����������־�ļ�

		public const int BackupException		   =    400;  //�����쳣
		public const int BackupFail			   =	500;  //����ʧ��

		public const int BackupTimeSegNoFile   =    501;  //ʱ�������¼���ļ�
		public const int BackupNoResource        =    502;  //���벻����Դ
		public const int BackupDeviceLowSpace   =    503;  //�����豸��������
		public const int BackupDiskFinalized     =    504;  //��¼���̷���
		public const int BackupDiskException     =    505;  //��¼�����쳣
		public const int BackupDeviceNotExist   =    506;  //�����豸������
		public const int BackupOtherBackupWork  =    507;  //���������ݲ����ڽ���
		public const int BackupUserNoRight      =    508;  //�û�û�в���Ȩ��
		public const int BackupOperateFail       =    509;  //����ʧ��
		public const int BackupNoLogFile        =    510;  //Ӳ��������־

		//���ݹ��̽ӿڶ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBackupNameParam
		{
			public uint dwFileNum;   //�ļ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRecordFileNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrFinddataV30[] struFileList; //�ļ��б�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskDes;   //���ݴ�������
			public byte byWithPlayer;      //�Ƿ񱸷ݲ�����
			public byte byContinue;    /*�Ƿ�������� 0������ 1����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;         //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBackupTimeParam
		{
			public int lChannel;        //��ʱ�䱸�ݵ�ͨ��
			public NetDvrTime struStartTime;   //���ݵ���ʼʱ��
			public NetDvrTime struStopTime;    //���ݵ���ֹʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskDes;     //���ݴ�������
			public byte byWithPlayer;               //�Ƿ񱸷ݲ�����
			public byte byContinue;                 //�Ƿ�������� 0������ 1����
			public byte byDrawFrame;			     //0 ����֡  1 ��֡
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;					 // �����ֽ� 
		}
		/********************************* end *******************************************/
		public enum CompressionAbilityType
		{
			CompressionStreamAbility = 0, //����ѹ������
			MainResolutionAbility = 1,	//������ѹ���ֱ���
			SubResolutionAbility  = 2,	//������ѹ���ֱ���
			EventResolutionAbility =  3,  //�¼�ѹ�������ֱ���
			FrameAbility = 4,				//֡������
			BitrateTypeAbility = 5,		//λ����������
			BitrateAbility = 6,			//λ������
			ThirdResolutionAbility = 7,   //������ѹ���ֱ���
			StreamTypeAbility = 8,        //��������
			PicQualityAbility = 9,         //ͼ������
			IntervalBpframeAbility = 10,  //BP֡���
			VideoEncAbility = 11,           //��Ƶ��������
			AudioEncAbility = 12,           //��Ƶ��������
			VideoEncComplexityAbility = 13, //��Ƶ���븴�Ӷ�����
			FormatAbility = 14, //��װ��ʽ����
		}

		//�����б�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAbilityList
		{ 
			public uint dwAbilityType;	//�������� COMPRESSION_ABILITY_TYPE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //�����ֽ�
			public uint dwNodeNum;		//����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxNodeNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDescNode[]  struDescNode;  //��������  
		}

		public const int MaxAbilitytypeNum = 12;   //���������

		// ѹ�����������б�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressioncfgAbility
		{ 
			public uint dwSize;            //�ṹ����
			public uint dwAbilityNum;		//�������͸���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAbilitytypeNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrAbilityList[] struAbilityNode; //��������  
		}

		//ģʽA 
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidateModea
		{
			public byte byStartMonth;	// ��ʼ�� ��1��ʼ
			public byte byStartDay;		// ��ʼ�� ��1��ʼ
			public byte byEndMonth;		// ������ 
			public byte byEndDay;		// ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidateModeb
		{
			public byte byStartMonth;	// ��1��ʼ
			public byte byStartWeekNum;	// �ڼ������� ��1��ʼ 
			public byte byStartWeekday;	// ���ڼ�
			public byte byEndMonth;		// ��1��ʼ
			public byte byEndWeekNum;	// �ڼ������� ��1��ʼ 
			public byte byEndWeekday;	// ���ڼ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ� 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidateModec
		{
			public ushort wStartYear;		// ��
			public byte byStartMon;		// ��
			public byte byStartDay;		// ��
			public ushort wEndYear;		// ��
			public byte byEndMon;		// ��
			public byte byEndDay;		// ��
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrHolidateUnion
		{	
			//�������С 12�ֽ�
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
			public uint[] dwSize;
			[FieldOffset(0)]
			public NetDvrHolidateModea	struModeA;	// ģʽA
			[FieldOffset(0)]
			public NetDvrHolidateModeb	struModeB;	// ģʽB
			[FieldOffset(0)]
			public NetDvrHolidateModec	struModeC;	// ģʽC
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
			public byte byEnable;			// �Ƿ�����
			public byte byDateMode;			// ����ģʽ 0-ģʽA 1-ģʽB 2-ģʽC
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			// �����ֽ�
			public NetDvrHolidateUnion uHolidate;	// ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byName;	// ��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			// �����ֽ�
		}

		public const int MaxHolidayNum = 32;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayParamCfg
		{
			public uint dwSize;			// �ṹ���С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHolidayNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrHolidayParam[] struHolidayParam;	// ���ղ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// ��������
		}

		//���ձ�������ʽ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayHandle
		{
			public uint dwSize;				// �ṹ���С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;	// ����ʱ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;		// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHolidayRecord
		{
			public uint dwSize;
			public NetDvrRecordday struRecDay;     // ¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRecordsched[] struRecordSched; // ¼��ʱ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //  �����ֽ�
		}

		public const int MaxLinkV30 = 128;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOneLink
		{
			public NetDvrIpaddr  struIP;     // �ͻ���IP
			public int lChannel;   // ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLinkStatus
		{
			public uint dwSize;      // �ṹ���С
			public ushort wLinkNum;    // ���ӵ���Ŀ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLinkV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrOneLink[] struOneLink;   // ���ӵĿͻ�����Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  // �����ֽ�
		}

		public const int MaxBondNum = 2;

				//��BONDING�������ýṹ��
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

		//BONDING�������ýṹ��
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


		//�������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskQuota 
		{
			public byte byQuotaType;	 // �����������,1 - ������ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       // �����ֽ�
			public uint dwHCapacity;     // ����Ĵ���������32λ ��λMB
			public uint dwLCapacity;     // ����Ĵ���������32λ ��λMB
			public uint dwHUsedSpace;    // ��ʹ�õĴ��̴�С��32λ ��λMB
			public uint dwLUsedSpace;    // ��ʹ�õĴ��̴�С��32λ ��λMB
			public byte byQuotaRatio;    //	����Ĵ��̱���,��λ:%
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;      // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskQuotaCfg
		{
			public uint dwSize;         // �ṹ���С
			public NetDvrDiskQuota struPicQuota;    //  ͼƬ���
			public NetDvrDiskQuota struRecordQuota;    //  ¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //�����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimingCapture
		{
			public NetDvrJpegpara struJpegPara;   // ��ʱץͼͼƬ����
			public uint dwPicInterval; //��ʱץͼʱ����,��λs   1-1s 2-2s 3-3s 4-4s 5-5s 
									   //6-10m 7-30m 8-1h 9-12h 10-24h
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRelCaptureChan
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byChan;    // ��λ��ʾ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          // �����ֽ�
		}

		public const int MaxPicEventNum = 32;
		public const int MaxAlarminCapture = 16;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRelCaptureChanV40
		{
			public uint dwMaxRelCaptureChanNum;  //���ɴ����Ĺ���ͨ����-ֻ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwChanNo; //�����Ĺ���ץͼͨ���ţ���ֵ��ʾ�����ý���������,0xffffffff��ʾ������Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventCaptureV40
		{
			public NetDvrJpegpara struJpegPara;   // �¼�ץͼͼƬ����
			public uint dwPicInterval;   // �¼�ץͼʱ����  ��λΪ�� 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPicEventNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChanV40[] struRelCaptureChan;   // �����±� 0 �ƶ���ⴥ��ץͼ 1 ��Ƶ�ڵ�����ץͼ 2 ��Ƶ��ʧ����ץͼ,����3��ʾPIR����ץͼ������4��ʾ���߱���ץͼ������5��ʾ���ȱ���ץͼ,����6��ʾ����ץͼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminCapture, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChanV40[] struAlarmInCapture;    // �������봥��ץͼ���±�0 ����������1 ��������
			public uint dwMaxGroupNum;  //�豸֧�ֵ���󱨾�����������ÿ��16����������
			public byte byCapTimes; //ץͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEventCapture
		{
			public NetDvrJpegpara  struJpegPara;   // �¼�ץͼͼƬ����
			public uint dwPicInterval;  /*�¼�ץͼʱ����  ��λΪ��  1-1s 2-2s 3-3s 4-4s 5-5s 
											 * 6-10m 7-30m 8-1h 9-12h 10-24h*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPicEventNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChan[] struRelCaptureChan; /* �����±� 0 �ƶ���ⴥ��ץͼ 1 ��Ƶ�ڵ�����ץͼ,
																   * 2 ��Ƶ��ʧ����ץͼ,����3��ʾPIR����ץͼ������4��ʾ���߱���ץͼ��
																   * ����5��ʾ���ȱ���ץͼ,����6��ʾ����ץͼ�� ����7��ʾ�������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxAlarminCapture, ArraySubType = UnmanagedType.Struct)]
			public NetDvrRelCaptureChan[] struAlarmInCapture;  //�������봥��ץͼ���±�0 ����������1 ��������
			public byte byCapTimes; //ץͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegCaptureCfgV40
		{
			public uint dwSize;               //�ṹ�峤��
			public NetDvrTimingCapture struTimingCapture;    
			public NetDvrEventCaptureV40 struEventCapture;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;     // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrJpegCaptureCfg
		{
			public uint dwSize;         // �ṹ���С
			public NetDvrTimingCapture struTimingCapture;    
			public NetDvrEventCapture struEventCapture;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes3;     // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCaptureDay
		{
			public byte byAllDayCapture;	// �Ƿ�ȫ��ץͼ
			public byte byCaptureType;		// ץͼ���ͣ�0-��ʱץͼ��1-�ƶ����ץͼ��2-����ץͼ��3-�ƶ����򱨾�ץͼ��4-�ƶ����ͱ���ץͼ��6-���ܱ���ץͼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCaptureSched
		{
			public NetDvrSchedtime struCaptureTime;        // ץͼʱ���
			public byte byCaptureType;       // ץͼ���ͣ�0-��ʱץͼ��1-�ƶ����ץͼ��2-����ץͼ��3-�ƶ����򱨾�ץͼ��4-�ƶ����ͱ���ץͼ��6-���ܱ���ץͼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           // �����ֽ�
		}

		//ͨ��ץͼ�ƻ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSchedCapturecfg
		{
			public uint dwSize;     //�ṹ��
			public byte byEnable;	//�Ƿ�ץͼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;	//�����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCaptureDay[] struCaptureDay;//ȫ��ץͼ�ƻ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCaptureSched[] struCaptureSched;//ʱ���ץͼ�����ƻ�
			public NetDvrCaptureDay	struCaptureHoliday;	//����ץͼ�ƻ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTimesegmentV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCaptureSched[] struHolidaySched;	//ʱ��μ���ץͼ�����ƻ�
			public uint dwRecorderDuration;	//ץͼ�����ʱ�� 0xffffffff��ʾ��ֵ��Ч 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;			//�����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFlowTestParam
		{
			public uint dwSize;              //�ṹ��С
			public int lCardIndex;         //��������
			public uint dwInterval;         //�豸�ϴ�����ʱ����, ��λ:100ms
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //�����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFlowInfo
		{
			public uint dwSize;             //�ṹ��С
			public uint dwSendFlowSize;     //����������С,��λkbps
			public uint dwRecvFlowSize;     //����������С,��λkbps
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;          //���� 
		}

		//¼���ǩ
		public const int LabelNameLen = 40;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordLabel
		{
			public uint dwSize;					// �ṹ���С
			public NetDvrTime struTimeLabel;			// ��ǩ��ʱ�� 
			public byte byQuickAdd;				// �Ƿ������� �������ʱ��ǩ������Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;				// �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	// ��ǩ������ ����Ϊ40�ֽ�  
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;				// �����ֽ�
		}

		public const int LabelIdentifyLen = 64;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLabelIdentify
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelIdentifyLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelIdentify;    // 64�ֽڱ�ʶ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;               // �����ֽ�
		}

		public const int MaxDelLabelIdentify = 20;// ɾ��������ǩ��ʶ����

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDelLabelParam
		{
			public uint dwSize;       // �ṹ���С
			public byte byMode;   // ��λ��ʾ,0x01��ʾ����ʶɾ��
			public byte byRes1;
			public ushort wLabelNum;      // ��ǩ��Ŀ   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDelLabelIdentify, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLabelIdentify[] struIndentify; // ��ǩ��ʶ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   //�����ֽ�    
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrModLabelParam
		{
			public NetDvrLabelIdentify struIndentify; //Ҫ�޸ĵı�ǩ��ʶ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	//�޸ĺ�ı�ǩ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;				
		}

		//��ǩ�����ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindLabel
		{
			public uint dwSize;          // �ṹ���С
			public int lChannel;		// ���ҵ�ͨ��
			public NetDvrTime	struStartTime;	// ��ʼʱ��
			public NetDvrTime	struStopTime;	// ����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	//  ¼���ǩ���� �����ǩ����Ϊ�գ���������ֹʱ�����б�ǩ
			public byte byDrawFrame;		//0:����֡��1����֡
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
		}

		//��ǩ��Ϣ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindlabelData
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = LabelNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sLabelName;	// ��ǩ����
			public NetDvrTime struTimeLabel;		// ��ǩʱ��
			public NetDvrLabelIdentify struLabelIdentify; // ��ǩ��ʶ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;			// �����ֽ�
		}

		public const int CardnumLenV30 = 40;
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindPictureParam
		{
			public uint dwSize;        //�ṹ���С 
			public int lChannel;       //ͨ����
			public byte byFileType;   /* ���ҵ�ͼƬ����:0��ʱץͼ1 �ƶ����ץͼ 2 ����ץͼ3  ���� | �ƶ����ץͼ 4 ���� & �ƶ����ץͼ
									   * 6 �ֶ�ץͼ ,9-����ͼƬ,10- PIR������11- ���߱�����12- ���ȱ���,0xa Ԥ��ʱ��ͼ��0xd �������, 
									   * 0xe Խ����⣬0xf ����������⣬0x10 ����������, 0x11-�豸���ػط�ʱ��ͼ, 0x12-������⣬
									   * 0xff- ȫ������ 2013-07-16*/  
			public byte byNeedCard;     //�Ƿ���Ҫ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;      // �����ֽ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = CardnumLenV30, ArraySubType = UnmanagedType.I1)]
			public byte[] sCardNum;     // ����
			public NetDvrTime  struStartTime;//����ͼƬ�Ŀ�ʼʱ��
			public NetDvrTime  struStopTime;// ����ͼƬ�Ľ���ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;     // �����ֽ�
		}

		public const int PictureNameLen = 64;

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrFindPicture
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PictureNameLen)]
			public string sFileName;//ͼƬ��
			public NetDvrTime struTime;//ͼƬ��ʱ��
			public uint dwFileSize;//ͼƬ�Ĵ�С
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = CardnumLenV30)]
			public string sCardNum;	//����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		//  �����ֽ�
		}

		public const int MaxRecordPictureNum = 50;   //��󱸷�ͼƬ����  

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBackupPictureParam
		{
			public uint dwSize;         // �ṹ���С   
			public uint dwPicNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRecordPictureNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrFindPicture[] struPicture;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen32, ArraySubType = UnmanagedType.I1)]
			public byte[] byDiskDes;
			public byte byWithPlayer;
			public byte byContinue;    /*�Ƿ�������� 0������ 1����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCompressionLimit
		{	
			public uint dwSize;           //�ṹ���С
			public uint dwChannel;        //ͨ����
			public byte byCompressType;   //����ȡ��ѹ����������1,������2,������3,�¼�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //����
			public NetDvrCompressioncfgV30  struCurrentCfg; //��ǰѹ����������
		}

		public const int StepReady      = 0;    //׼������
		public const int StepRecvData  = 1;    //��������������
		public const int StepUpgrade    = 2;    //����ϵͳ
		public const int StepBackup     = 3;    //����ϵͳ
		public const int StepSearch     = 255;  //���������ļ�

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoEffect
		{
			public uint dwBrightValue;      //����[0,255]
			public uint dwContrastValue;    //�Աȶ�[0,255]
			public uint dwSaturationValue;  //���Ͷ�[0,255]
			public uint dwHueValue;         //ɫ��[0,255]
			public uint dwSharpness;		  //���[0,255]
			public uint dwDenoising;		  //ȥ��[0,255]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoInputEffect
		{	
			public uint dwSize;				//�ṹ���С
			public ushort wEffectMode;        //ģʽ 0-��׼ 1-���� 2-���� 3-����  255-�Զ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;        //����
			public NetDvrVideoEffect struVideoEffect;	//��ƵЧ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			//����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVideoparaV40
		{
			public uint dwChannel;			// ͨ����
			public uint dwVideoParamType;  	// ��Ƶ�������� 0-���� 1-�Աȶ� 2-���Ͷ� 3-ɫ�� 4-��� 5-ȥ��
			public uint dwVideoParamValue;  //��Ӧ����Ƶ����ֵ����Χ����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDefaultVideoCond
		{
			public uint dwSize;			// �ṹ���С
			public uint dwChannel;		// ͨ����
			public uint dwVideoMode;	// ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      // ����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrEncodeJointParam
		{
			public uint dwSize;			// �ṹ���С
			public byte byJointed;		//  0 û�й��� 1 �Ѿ�����
			public byte byDevType;		// ���������豸����  1 ���������豸
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;		// �����ֽ�
			public NetDvrIpaddr	struIP;			// �����ı�ȡ���豸IP��ַ
			public ushort wPort;			// �����ı�ȡ���豸�˿ں�
			public ushort wChannel;		// �����ı�ȡ���豸ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;			// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaChanWorkstatus
		{
			public byte byJointed;				// 0-û�й���  1-�Ѿ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr	struIP;					// ������ȡ���豸IP��ַ
			public ushort wPort;					// ������ȡ���豸�˿ں�
			public ushort wChannel;				// ������ȡ���豸ͨ����
			public byte byVcaChanStatus;		// 0 - δ���� 1 - ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;				// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVcaDevWorkstatus
		{
			public uint dwSize;			// �ṹ���С
			public byte byDeviceStatus;	// �豸��״̬0 - �������� 1- ����������
			public byte byCpuLoad;		// CPUʹ����0-100 �ֱ����ʹ�ðٷ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxVcaChan, ArraySubType = UnmanagedType.Struct)]
			public NetDvrVcaChanWorkstatus[] struVcaChanStatus;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;		// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct UnionVideoplatformV40
		{
			/*�����Ӵ��ڶ�Ӧ����ͨ������Ӧ�Ľ�����ϵͳ�Ĳ�λ��(������Ƶ�ۺ�ƽ̨�н�����ϵͳ��Ч)*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecoderId;
			//��ʾ����������Ƶ�ֱ��ʣ�1-D1,2-720P,3-1080P���豸����Ҫ���ݴ�//�ֱ��ʽ��н���ͨ���ķ��䣬��1�������ó�1080P�����豸���4������ͨ
			//����������˽���ͨ��
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
			public byte byAudio;			/*��Ƶ�Ƿ���*/
			public byte byAudioWindowIdx;      /*��Ƶ�����Ӵ���*/
			public byte byVgaResolution;      /*�ֱ��ʣ�����������ȡ*/
			public byte byVedioFormat;         /*1:NTSC,2:PAL��0-NULL*/
			public uint dwWindowMode;		/*����ģʽ����������ȡ*/       
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindows, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
			public byte byEnlargeStatus;          /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
			public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�
			public byte byScale; /*��ʾģʽ��0---��ʵ��ʾ��1---������ʾ( ���BNC )*/
			/*���ֹ����壬0-��Ƶ�ۺ�ƽ̨�ڲ���������ʾͨ�����ã�1-������������ʾͨ������*/
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
			public byte bySerialTrans;//�Ƿ�͸����0-��1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int NetDvrV6PsubsystemaramGet = 1501;//��ȡV6��ϵͳ����
		public const int NetDvrV6PsubsystemaramSet = 1502;//����V6��ϵͳ����

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCorrectDeadpixelParam
		{
			public uint dwSize;
			public uint dwCommand; //���0-���뻵��ģʽ��1-��ӻ��㣬2-���滵�㣬3-�˳�����
			public uint dwDeadPixelX; //����X����
			public uint dwDeadPixelY; //����Y����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		public const int MaxRedareaNum = 6;   //�����̵��������

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRedareacfg
		{
			public uint dwSize;
			public uint dwCorrectEnable; //�Ƿ���У�����ܣ�0-�رգ�1-����
			public uint dwCorrectLevel; //У������1(У�������)-10(У�������),Ĭ��Ϊ5
			public uint dwAreaNum; //У���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRedareaNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaRect[] struLaneRect; //У������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHistoricdatacfg
		{
			public uint dwSize;
			public uint dwTotalNum;  //��ʷ���ݸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int InquestMessageLen  = 44;    //��Ѷ�ص�����Ϣ����
		public const int InquestMaxRoomNum = 2;    //�����Ѷ�Ҹ���
		public const int MaxResumeSegment   = 2;     //֧��ͬʱ�ָ���Ƭ����Ŀ

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestRoom
		{
			public byte byRoomIndex;     //��Ѷ�ұ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;       //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestMessage
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = InquestMessageLen)]
			public string sMessage; //�ص�����Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;                     //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestSensorDevice
		{
			public ushort wDeviceType;	//���ݲɼ��豸�ͺ�:0-�� 1-���� 2-�ز� 3-���� 4-���� 5-���ء�6-���ϡ�7-ά��˹��
			public ushort wDeviceAddr;	//���ݲɼ��豸��ַ	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	    //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestSensorInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = InquestMaxRoomNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInquestSensorDevice[] struSensorDevice;
			public uint  dwSupportPro;      //֧��Э������,��λ��ʾ, �°汾����������������չ���ֶ�
							   //0x1:���� 0x2:�ز� 0x4:����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestRoomInfo
		{
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = NameLen)]
			public string szCDName;	//�������ƣ�����˫�̹���������һ����
			[StructLayout(LayoutKind.Explicit)]
			public struct UCalcMode
			{
				[FieldOffset(0)]
				public byte byBitRate;	// byCalcTypeΪ0ʱ��Ч��(0-32��1-48��2-64��3-80��4-96��5-128��
								//6-160��7-192��8-224��9-256��10-320��11-384��12-448��
								//13-512��14-640��15-768��16-896ǰ16��ֵ����)17-1024��18-1280��19-1536��
								//20-1792��21-2048��22-3072��23-4096��24-8192
				[FieldOffset(0)]
				public byte byInquestTime;  // byCalcTypeΪ1ʱ��Ч��0-1Сʱ, 1-2Сʱ,2-3Сʱ,3-4Сʱ, 4-6Сʱ,5-8Сʱ
								//8-16Сʱ, 9-20Сʱ,10-22Сʱ,11-24Сʱ
			}
			public byte byCalcType;			//��¼��������0-������ 1-��ʱ��
			public byte byAutoDelRecord;	// �Ƿ��Զ�ɾ��¼��0-��ɾ����������ʱ����¼�� 1-ɾ��
			public byte byAlarmThreshold;		// ����������ֵ
			public byte byInquestChannelResolution;     //��Ѷͨ���ֱ��ʣ�0:720P  1:1080P
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestSystemInfo
		{
			public uint dwRecordMode;         //��¼ģʽ:1 ����˫��ģʽ 2 �����ֿ�ģʽ 3 ˫��˫��ģʽ���޸���Ҫ�����豸��
			public uint  dwWorkMode;           //����ģʽ:0 ��׼ģʽ 1 ͨ��ģʽ(������Ŀǰֻ�б�׼ģʽ)
			public uint dwResolutionMode;     //�豸�ֱ��ʣ�0:���� 1:D1 2:720P 3:1080P��������Ѷ�����ô��ֶΣ�
			public NetDvrInquestSensorInfo struSensorInfo;  //��ʪ�ȴ���������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = InquestMaxRoomNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInquestRoomInfo[] struInquestRoomInfo;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestResumeSegment
		{
			public NetDvrTime  struStartTime; //�¼���ʼʱ��
			public NetDvrTime  struStopTime;  //�¼���ֹʱ��
			public byte byRoomIndex;         //��Ѷ�ұ��,��1��ʼ
			public byte byDriveIndex;        //��¼�����,��1��ʼ
			public ushort wSegmetSize;         //��Ƭ�ϵĴ�С, ��λM 
			public uint dwSegmentNo;         //��Ƭ���ڱ�����Ѷ�е����,��1��ʼ 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;           //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestResumeEvent
		{
			public uint  dwResumeNum;       //��ָ����¼�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxResumeSegment, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInquestResumeSegment[] struResumeSegment;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;        //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInquestDeviceVersion
		{
			public byte byMainVersion;         /*�������汾.
								   0 : δ֪
								   1 : 8000��ѶDVR
									   �ΰ汾: 1 : 8000HD-S
								   2 : 8100��ѶDVR 
									   �ΰ汾: 1 : ��Ѷ81SNL
											   2 : ��Ѷ81SH
											   3 : ��Ѷ81SFH
								   3 : 8608������Ѷ��NVR 
									   �ΰ汾: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
			public byte bySubVersion;          //���ߴΰ汾
			public byte byUpgradeVersion;      //�����汾,δ����Ϊ0
			public byte byCustomizeVersion;     //���ư汾,�Ƕ���Ϊ0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;             //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDiskRaidInfo 
		{
			public uint dwSize;   //�ṹ���С
			public byte byEnable;  //����Raid�Ƿ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //�����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSynchronousIpc
		{
			public uint dwSize;    //�ṹ���С
			public byte byEnable;  //�Ƿ����ã�Ϊǰ��IPCͬ���豸����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpcPasswd
		{
			public uint dwSize;    //�ṹ���С
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sOldPasswd;  //IPC�ľ����룬����DVR��DVR��֤
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = PasswdLen)]
			public string sNewPasswd;  //IPC��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ͨ����ȡDVR������״̬����λbps
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDeviceNetUsingInfo 
		{
			public uint dwSize;    //�ṹ���С
			public uint dwPreview;   //Ԥ��
			public uint dwPlayback;  //�ط�
			public uint dwIPCModule; //IPC����
			public uint dwNetDiskRW; //���̶�д
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
		}

		//ͨ��DVR����ǰ��IPC��IP��ַ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpcNetcfg
		{
			public uint dwSize;      //�ṹ���С
			public NetDvrIpaddr struIP;       //IPC��IP��ַ
			public ushort wPort;       //IPC�Ķ˿�
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 126)]
			public string res;  
		}

		//��ʱ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrTimeLock
		{
			public uint dwSize;      //�ṹ���С
			public NetDvrTime strBeginTime;
			public NetDvrTime strEndTime;
			public uint dwChannel;        //ͨ����, 0xff��ʾ����ͨ��
			public uint dwRecordType;     //¼������:  0xffffffff��ȫ����0����ʱ¼��1-�ƶ���⣬2������������3-�����������ƶ���⣬4-�����������ƶ���⣬5-�������6-�ֶ�¼��7-����¼��(ͬ�ļ�����)
			public uint dwLockDuration;   //��������ʱ��,��λ��,0xffffffff��ʾ��������
			public NetDvrTimeEx strUnlockTimePoint;	//����ʱ��Ч����dwLockDuration��Ϊ��������ʱ������������ʱ�䵽��ʱ�����Զ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLockReturn
		{
			public uint dwSize;      //�ṹ���С
			public NetDvrTime strBeginTime; 
			public NetDvrTime strEndTime;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//67DVS
		//֤����������
		public enum NetSdkUploadType 
		{
			UpgradeCertFile = 0, 
			UploadCertFile = 1,
			TrialCertFile = 2,
			ConfigurationFile = 3
		}

		public enum NetSdkDownloadType
		{
			NetSdkDownloadCert = 0,		//����֤��
			NetSdkDownloadIpcCfgFile = 1,//����IPC�����ļ�
			NetSdkDownloadBaselineScenePic = 2, //���ػ�׼����ͼƬ
			NetSdkDownloadVqdAlarmPic = 3,       //����VQD����ͼƬ
			NetSdkDownloadConfigurationFile=4   //���������ļ�
		}

		//����״̬
	   public enum NetSdkDownloadStatus
	   {
			NetSdkDownloadStatusSuccess = 1,	//���سɹ�
			NetSdkDownloadStatusProcessing,		//��������
			NetSdkDownloadStatusFailed,			//����ʧ��
			NetSdkDownloadStatusUnkownError	//δ֪���� 
	   }

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBonjourCfg
		{
			public uint dwSize;				// �ṹ���С
			public byte byEnableBonjour;		// Bonjourʹ�� 0 ������ 1���ر�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;				
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byFriendlyName; 	// ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSocksCfg
		{
			public uint dwSize;				// �ṹ���С
			public byte byEnableSocks;  		// ʹ�� 0���ر� 1������
			public byte byVersion;  			// SOCKS�汾 4��SOCKS4   5��SOCKS5
			public ushort wProxyPort;				// ����˿ڣ�Ĭ��1080
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byProxyaddr;  	// ����IP��ַ������������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byUserName; 	// �û��� SOCKS����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPassword;			// ����SOCKS5����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLocalAddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocalAddr;  //��ʹ��socks��������Σ���ʽΪ"ip/netmask;ip/netmask;��"
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrQosCfg
		{
			public uint dwSize;
			public byte byManageDscp;   // �������ݵ�DSCPֵ [0-63]
			public byte byAlarmDscp;    // �������ݵ�DSCPֵ [0-63]
			public byte byVideoDscp;    // ��Ƶ���ݵ�DSCPֵ [0-63]��byFlagΪ0ʱ����ʾ����Ƶ
			public byte byAudioDscp;    // ��Ƶ���ݵ�DSCPֵ [0-63]��byFlagΪ1ʱ��Ч
			public byte byFlag;			// 0������Ƶ��һ��1������Ƶ�ֿ�
			public byte byEnable;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrHttpsCfg
		{
			public uint dwSize;
			public ushort wHttpsPort;		// HTTPS�˿�
			public byte byEnable;		// ʹ�� 0���ر� 1������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//֤�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCertName
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCountryNameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byCountry;  			//���Ҵ��� CN��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byState;				//�޻�ʡ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byLocality;			//����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byOrganization;		//��֯
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDomainName, ArraySubType = UnmanagedType.I1)]
			public byte[] byUnit;				//��λ
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
			public ushort wCertFunc; //֤�����࣬0-802.1x,1-HTTPS
			public ushort wCertType; //֤�����ͣ�0-CA��1-Certificate,2-˽Կ�ļ�
			public byte byFileType; //֤���ļ����ͣ�0-PEM,1-PFX
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		public const int UploadCertificate = 1; //�ϴ�֤��

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCertInfo
		{
			public uint dwSize;
			public NetDvrCertParam struCertParam;	//֤�����
			public uint dwValidDays;   //��Ч����������Ϊ��ǩ��ʱ��Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPasswd;   //˽Կ����
			public NetDvrCertName struCertName;    // ֤������
			public NetDvrCertName struIssuerName;    // ֤�鷢�������ƣ���ǩ��֤����Ϣ��ȡʱ��Ч��
			public NetDvrTimeEx struBeginTime;   //֤�鴴��ʱ�䣨��ǩ��֤����Ϣ��ȡʱ��Ч��
			public NetDvrTimeEx struEndTime;   //֤���ֹʱ�䣨��ǩ��֤����Ϣ��ȡʱ��Ч��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] serialNumber;   //֤���ʶ�루��ǩ��֤����Ϣ��ȡʱ��Ч��
			public byte byVersion; 
			public byte byKeyAlgorithm;			//�������� 0-RSA  1-DSA
			public byte byKeyLen;				//���ܳ��� 0-512  1-1024�� 2-2048
			public byte bySignatureAlgorithm; //ǩ���㷨���ͣ���ǩ��֤����Ϣ��ȡʱ��Ч��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//channel record status
		//***ͨ��¼��״̬*****//
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChansRecordStatus
		{
			public byte byValid;       //�Ƿ���Ч
			public byte byRecord;      /*(ֻ��)¼������, ��λ��ʾ:0: ����¼��1����¼�� 2-���� 
						3-������ 4-��������Ƶ 5-δ���� 6-�浵��
							7-�ش��� 8-�û���������� 9-δ��֤
							10-�浵�к�¼���� 11-¼��ش��к�¼����*/
			public ushort wChannelNO;   //ͨ����
			public uint dwRelatedHD;  //��������
			public byte byOffLineRecord;  //����¼���� 0-�ر� 1-����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;      //�����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrIpAlarmGroupNum
		{
			public uint dwSize; 
			public uint dwIPAlarmInGroup;      //IPͨ��������������
			public uint dwIPAlarmInNum;       //IPͨ�������������
			public uint dwIPAlarmOutGroup;     //IPͨ�������������
			public uint dwIPAlarmOutNum;      //IPͨ�������������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  
		}
		
		//****NVR end***//
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrChanGroupRecordStatus
		{
			public uint dwSize; //�ṹ���С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.Struct)]
			public NetDvrChansRecordStatus[] struChanStatus; //һ��64��
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRectcfg
		{
			public ushort wXCoordinate; /*�������Ͻ���ʼ��X����*/
			public ushort wYCoordinate; /*�������Ͻ�Y����*/
			public ushort wWidth;       /*���ο��*/
			public ushort wHeight;      /*���θ߶�*/
		}

		/*������Ϣ*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWincfg
		{
			public uint dwSize;
			public byte byVaild;
			public byte byInputIdx;          /*����Դ����*/
			public byte byLayerIdx;          /*ͼ�㣬0Ϊ��ײ�*/
			public byte byTransparency; //͸���ȣ�0��100 
			public NetDvrRectcfg  struWin;//Ŀ�Ĵ���(�����ʾǽ)
			public ushort wScreenHeight;//������
			public ushort wScreenWidth;//������
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
			public uint dwScreenNum;//������
			public NetDvrPointFrame struPointFrame;
			public byte byLayer;//ͼ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//2011-04-18
		/*�������Ϣ,���9999������1��ʼ */
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixCamerainfo
		{  
			public uint dwGlobalCamId;      /* cam��ȫ�ֱ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sCamName; /*cam������*/
			public uint dwMatrixId;          /*cam��Ӧ����ı��*/
			public uint dwLocCamId;         /*cam��Ӧ������ڲ����*/ 
			public byte byValid;    /*�Ƿ���Ч��0-��1-��*/
			public byte byPtzCtrl; /* �Ƿ�ɿأ�0-��1-��*/
			public byte byUseType; //*ʹ�����ͣ�0-����Ϊ����ʹ�ã�1-BNC��2-SP3,3-V6���ˣ�4-��������*/ 
			public byte byUsedByTrunk;//��ǰʹ��״̬��0-û�б�ʹ�ã�1-������ʹ�� 
			public byte byTrunkReq; /*������ֱ���,��D1Ϊ��λ��1 - 1��D1��2- 2��D1����Ϊ����ʹ��ʱ��ָ���Ǹ��ߵĴ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrTime struInstallTime;//��װʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPurpose;/*��;����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;  
		}

		/*��������Ϣ�����2048��*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixMonitorinfo 
		{
			public uint dwGloalMonId; /*mon ��ͳһ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sMonName;
			public uint dwMatrixId;  /*mon���ھ���ı��*/
			public uint dwLocalMonId; /*mon���ڲ����*/
			public byte byValid;    /*�Ƿ���Ч��0-��1-��*/
			public byte byTrunkType; /*ʹ�����ͣ�0-����Ϊ����ʹ�ã�1-BNC��2-SP3,3-V6���ˣ�4-��������*/ 
			public byte byUsedByTrunk;//��ǰʹ��״̬��0-û�б�ʹ�ã�1-������ʹ�� 
			public byte byTrunkReq; /*�ֱ���, ��D1Ϊ��λ��1- 1��D1��2- 2��D1����Ϊ����ʹ��ʱ��ָ���Ǹ��ߵĴ���*/
			public NetDvrTime struInstallTime;//��װʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPurpose;/*��;����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixDigitalmatrix
		{
			public NetDvrIpaddr struAddress; /*�豸Ϊ�����豸ʱ��IP��Ϣ*/
			public ushort wPort;
			public byte byNicNum; /*0 - eth0, 1 - eth1, ����˫�������ͨ�ż���󶨵�����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;   
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixAnalogmatrix
		{
			public byte bySerPortNum;   /*���ӵĴ��ں�*/
			public byte byMatrixSerPortType;/* ����������صĴ�����ģ�����ļ��̿�(����Э��)���ӻ��������ͨ�ſڣ�����Э�飩���� ��0 --- ����Э��ͨѶ�� 1 --- ����ͨѶ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrSingleRs232 struRS232;	//232���ڲ���
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
		
		/*����������Ϣ�����20��*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixMatrixinfo 
		{
			public uint dwSize;
			public uint dwMatrixId;  /*������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDevName;
			public byte byCtrlType; /*ָͨѶ��ʽ�Ǵ���ͨ��, ��������ͨ��*/
			public byte byProtocolType;/*����ͨ�ſ���Э��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;   /*Ԥ��*/
			public NetMatrixUnion struMatrixUnion;
			public uint dwMaxPortsIn; /*����������*/
			public uint dwMaxPortsOut;/*���������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;   /*��¼�û���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;  /*��¼����*/        
			public NetDvrTime struInstallTime;//��װʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPurpose;/*��;����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;   /*Ԥ��*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixlist
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwMatrixNum;//�豸���صľ�������
			public IntPtr pBuffer;//������Ϣ������
			public uint dwBufLen;//������ָ�볤�ȣ��������
		}
 
		/*����������Ϣ*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixUartparam
		{	
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPortName;
			public ushort wUserId; /*�û���ţ��������豸Ϊ����ʱ����һ���û�������Ȩ�޹���*/
			public byte byPortType;    /*�������ͣ�����0-RS232/1-RS485/2-RS422*/
			public byte byFuncType; /*�������ӵ��豸������0-���У�1-���̣�2-����͸��ͨ��(485���ڲ������ó�͸��ͨ��),3-ģ�����*/     
			public byte byProtocolType;  /*����֧�ֵ�Э������, �����Ӽ����豸ʱ��Ҫ����Ϣ,��ȡ����֧��Э��ı�ż�������*/
			public byte byBaudRate;
			public byte byDataBits;
			public byte byStopBits;   /*ֹͣλ*/
			public byte byParity;      /*У��*/
			public byte byFlowCtrl;   /*���أ�������أ�������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     /*Ԥ��*/
		}

		//���256���û���1��256
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixUserparam 
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;
			public byte byRole;/*�û���ɫ:0-����Ա,1-����Ա��ֻ��һ��ϵͳ����Ա��255������Ա*/
			public byte byLevel;  /*ͳһ�������ڲ����������,1- 255*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//���255����Դ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixResoursegroupparam
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byGroupName;
			public byte byGroupType;/*0-�����CAM�飬1-������MON��*/
			public byte byRes1;
			public ushort wMemNum;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
			public uint[] dwGlobalId; 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//���255���û���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetMatrixUsergroupparam
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sGroupName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
			public ushort[] wUserMember;  /*�������û���Ա*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
			public ushort[] wResorceGroupMember; /*��������Դ���Ա*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byPermission;//Ȩ�ޣ�����0-ptzȨ�ޡ��л�Ȩ�ޡ���ѯȨ��
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
			public byte byTrunkType;  /*ʹ������  1-BNC��2-SP3���˸��壬3-SP3����D1�� 4-V6���ˣ�5-��������*/
			public byte byAbility;     /*��ʾ���˵Ĵ������Դ��伸·*/
			public byte bySubChan;   /*��Թ��˸��߶��ԣ���ʾ��ͨ����*/
			public byte byLevel;		/* ���߼��� 1-255*/
			public ushort wReserveUserID;	//Ԥ�����û�ID�� 1~256 ��0��ʾ�ͷ�Ԥ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixTrunklist
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwTrunkNum;//�豸���صĸ�������
			public IntPtr pBuffer;//������Ϣ������
			public uint dwBufLen;//������ָ�볤�ȣ��������
		}

		public const int MatrixProtocolNum   = 20;    //֧�ֵ�������Э����
		public const int KeyboardProtocolNum = 20;    //֧�ֵ�������Э����

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrProtoTypeEx
		{ 
			public ushort wType;               /*ipcЭ��ֵ*/  
			public ushort wCommunitionType;		/*0��ģ�� 1������ 2������ģ�⡢����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DescLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byDescribe; /*Э�������ֶ�*/    
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixmanageAbiility
		{
			public uint dwSize;
			public uint dwMaxCameraNum;//���Camera����
			public uint dwMaxMonitorNum;//������������
			public ushort wMaxMatrixNum;//����������
			public ushort wMaxSerialNum;//��������
			public ushort wMaxUser;//����û���
			public ushort wMaxResourceArrayNum;//�����Դ����
			public ushort wMaxUserArrayNum;//����û�����
			public ushort wMaxTrunkNum;//��������
			public byte nStartUserNum;//��ʼ�û���
			public byte nStartUserGroupNum;//��ʼ�û����
			public byte nStartResourceGroupNum;//��ʼ��Դ���
			public byte nStartSerialNum;//��ʼ���ں�
			public uint  dwMatrixProtoNum;     /*��Ч�ľ���Э����Ŀ����0��ʼ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MatrixProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrProtoTypeEx[] struMatrixProto;/*���Э���б���*/ 
			public uint dwKeyBoardProtoNum;     /*��Ч�ļ���Э����Ŀ����0��ʼ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MatrixProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrProtoTypeEx[] struKeyBoardProto;/*���Э���б���*/   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//����ץ�Ĺ���(����)
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSingleFacesnapcfg
		{
			public byte byActive;				//�Ƿ񼤻����0-��1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //����
			public NetVcaSizeFilter struSizeFilter;   //�ߴ������
			public NetVcaPolygon struVcaPolygon;		//����ʶ������
		}

		//����ץ�Ĺ������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapcfg
		{
			public uint dwSize;
			public byte bySnapTime;					//����Ŀ��������ץ�Ĵ���0-10
			public byte bySnapInterval;                 //ץ�ļ������λ��֡
			public byte bySnapThreshold;               //ץ����ֵ��0-100
			public byte byGenerateRate; 		//Ŀ�������ٶ�,��Χ[1, 5]	
			public byte bySensitive;			//Ŀ���������ȣ���Χ[1, 5]
			public byte byReferenceBright; //2012-3-27�ο�����[0,100]
			public byte byMatchType;         //2012-5-3�ȶԱ���ģʽ��0-Ŀ����ʧ�󱨾���1-ʵʱ����
			public byte byMatchThreshold;  //2012-5-3ʵʱ�ȶ���ֵ��0~100
			public NetDvrJpegpara struPictureParam; //ͼƬ���ṹ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxRuleNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaSingleFacesnapcfg[] struRule; //����ץ�Ĺ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//����ץ�Ľ�������ϴ�
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
			public byte[] byRes;//����
			public IntPtr pBuffer1;//ָ��������ͼ��ͼƬ����
			public IntPtr pBuffer2;//����ͼ��ͼƬ���ݣ�������ͨ�����ұ���ͼ�ӿڿ��Ի�ȡ����ͼ��
		}

		//�齹�����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDefocusAlarm
		{
			public uint dwSize;     /*�ṹ����*/
			public NetVcaDevInfo struDevInfo;/*�豸��Ϣ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAudioexceptionAlarm
		{
			public uint    dwSize;     /*�ṹ����*/
			public byte byAlarmType;//�������ͣ�1-��Ƶ�����쳣��2-��Ƶ����ͻ��
			public byte byRes1;
			public ushort wAudioDecibel;//����ǿ�ȣ���Ƶ����ͻ��ʱ�õ���
			public NetVcaDevInfo struDevInfo;/*�豸��Ϣ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetButtonDownExceptionAlarm
		{
			public uint dwSize;     /*�ṹ����*/
			public NetVcaDevInfo struDevInfo;/*�豸��Ϣ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		// �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFdImageCfg
		{
			public uint dwWidth;                  //�Ҷ�ͼ�����ݿ��
			public uint dwHeight;                 //�Ҷ�ͼ��߶�
			public uint dwImageLen;  //�Ҷ�ͼ�����ݳ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
			public IntPtr pImage;    //�Ҷ�ͼ������
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFdProcimgCfg
		{
			public uint  dwSize;           //�ṹ��С
			public byte byEnable;         //�Ƿ񼤻����;
			public byte bySensitivity;      //��������ȣ�[0,5]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;       //�����ֽ� 
			public NetVcaSizeFilter struSizeFilter;  //�ߴ������
			public NetVcaPolygon  struPolygon;    //�����
			public NetVcaFdImageCfg struFDImage;  //ͼƬ��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSubProcimg
		{
			public uint dwImageLen;  //ͼƬ���ݳ���
			public uint dwFaceScore;		//��������,0-100
			public NetVcaRect struVcaRect; //������ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
			public IntPtr pImage;  //ͼƬ����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFdProcimgResult
		{
			public uint dwSize;   //�ṹ��С
			public uint dwImageId; //��ͼID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
			public uint dwSubImageNum;  //������ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxTargetNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaSubProcimg[] struProcImg;  //������ͼ��Ϣ
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPicmodelResult
		{
			public uint dwImageLen;  //ͼƬ���ݳ���
			public uint dwModelLen;  //ģ�����ݳ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
			public IntPtr pImage;  //����ͼƬ����ָ��
			public IntPtr pModel;  //ģ������ָ��
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaRegisterPic
		{
			public uint dwImageID; //��ͼID
			public uint dwFaceScore;		//��������,0-100
			public NetVcaRect struVcaRect;  //������ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
		}

		//��������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAreainfocfg
		{
			public ushort wNationalityID;//����
			public ushort wProvinceID;//ʡ
			public ushort wCityID;//��
			public ushort wCountyID;//��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		//��Ա��Ϣ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHumanAttribute
		{
			public byte bySex;//�Ա�0-�У�1-Ů
			public byte byCertificateType;//֤�����ͣ�0-���֤��1-����֤
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanBirthdateLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byBirthDate;//�������£��磺201106
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byName; //����
			public NetDvrAreainfocfg struNativePlace;//�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byCertificateNumber; //֤����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaHumanattributeCond
		{
			public byte bySex; //�Ա�0-�����ã�1-�У�2-Ů
			public byte byCertificateType; //֤�����ͣ�0-�����ã�1-���֤��2-����֤
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanBirthdateLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byStartBirthDate; //��ʼ�������£��磺201106
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanBirthdateLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byEndBirthDate; //��ֹ�������£���201106
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byName; //����
			public NetDvrAreainfocfg struNativePlace; //�������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byCertificateNumber;  //֤����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��������Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistInfo
		{
			public uint dwSize;//�ṹ��С
			public uint dwRegisterID;//����ע��ID�ţ�ֻ����
			public uint dwGroupNo;//�����
			public byte byType;//�ڰ�������־��0-ȫ����1-��������2-������
			public byte byLevel;//�������ȼ���0-ȫ����1-�ͣ�2-�У�3-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����
			public NetVcaHumanAttribute struAttribute;//��Ա��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byRemark;//��ע��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;//����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistPara
		{
			public uint dwSize;   //�ṹ��С
			public NetVcaBlacklistInfo struBlackListInfo;  //��������������
			public uint dwRegisterPicNum;  //������ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanPictureNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPicmodelResult[] struRegisterPic;  //������ͼƬ��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistCond
		{
			public int lChannel; //ͨ����
			public uint dwGroupNo; //�����
			public byte byType; //�ڰ�������־��0-ȫ����1-��������2-������
			public byte byLevel; //�������ȼ���0-ȫ����1-�ͣ�2-�У�3-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;  //����
			public NetVcaHumanAttribute struAttribute; //��Ա��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistPic
		{
			public uint dwSize;   //�ṹ��С
			public uint dwFacePicNum;  //����ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxHumanPictureNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPicmodelResult[] struBlackListPic;  //������Ƭ��Ϣ
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFindPicturecond
		{
			public int lChannel;//ͨ����
			public NetDvrTime struStartTime;//��ʼʱ��
			public NetDvrTime struStopTime;//����ʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		public const int MaxFacePicLen = 6144;   //�������ͼƬ���ݳ���
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSubSnappicData
		{
			public uint dwFacePicID; //����ͼID
			public uint dwFacePicLen;  //����ͼ���ݳ���
			public NetDvrTime struSnapTime;  //ץ��ʱ��
			public uint dwSimilarity; //���ƶ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxFacePicLen)]
			public string sPicBuf;  //ͼƬ����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaAdvanceFind
		{
			public uint dwFacePicID; //����ͼƬID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaNormalFind
		{
			public uint dwImageID; //��ͼID
			public uint dwFaceScore;  //��������
			public NetVcaRect struVcaRect; //������ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetVcaFindSnappicUnion
		{
			//�������СΪ44�ֽ�
			[FieldOffset(0)]
			public NetVcaNormalFind  struNormalFind; //��ͨ����
			[FieldOffset(0)]
			public NetVcaAdvanceFind struAdvanceFind; //�߼�����
		}

		public enum VcaFindSnappicType
		{
			VcaNormalFind  = 0x00000000,   //��ͨ����
			VcaAdvanceFind  = 0x00000001  //�߼�����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFindPicturecondAdvance
		{
			public int lChannel;//ͨ����
			public NetDvrTime struStartTime;//��ʼʱ��
			public NetDvrTime struStopTime;//����ʱ��
			public byte byThreshold;  //��ֵ��0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
			public VcaFindSnappicType dwFindType;//�������ͣ����VCA_FIND_SNAPPIC_TYPE
			public NetVcaFindSnappicUnion uFindParam; //��������
		}

		//����ץ����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapInfoAlarm
		{
			public uint dwRelativeTime;
			public uint dwAbsTime;
			public uint dwSnapFacePicID;
			public uint dwSnapFacePicLen;
			public NetVcaDevInfo struDevInfo;//����ץ���ϴ���Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
			public IntPtr pBuffer1;//ָ��ͼƬ��ָ��
		}
		//������������Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistInfoAlarm
		{
			public NetVcaBlacklistInfo struBlackListInfo;
			public uint dwBlackListPicLen;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
			public IntPtr pBuffer1;//ָ��ͼƬ��ָ��
		}

		//�������ȶԽ�������ϴ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapMatchAlarm
		{
			public uint dwSize;
			public float fSimilarity;//���ƶȣ�ȡֵ��Χ��[0.001,1]
			public NetVcaFacesnapInfoAlarm struSnapInfo;//����ץ���ϴ���Ϣ
			public NetVcaBlacklistInfoAlarm struBlackListInfo;//������������Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}   
   
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistInfoAlarmLog
		{
			public NetVcaBlacklistInfo struBlackListInfo; //������������Ϣ
			public uint dwBlackListPicID;       //������������ͼID�����ڲ���ͼƬ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapInfoAlarmLog
		{
			public uint dwRelativeTime;     // ���ʱ��
			public uint dwAbsTime;			// ����ʱ��
			public uint dwSnapFacePicID;       //ץ������ͼID
			public NetVcaDevInfo struDevInfo;		//ǰ���豸��Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacesnapMatchAlarmLog
		{
			public uint dwSize;     		// �ṹ��С
			public float fSimilarity; //���ƶȣ�[0.001,1]
			public NetVcaFacesnapInfoAlarmLog  struSnapInfoLog; //ץ����Ϣ
			public NetVcaBlacklistInfoAlarmLog struBlackListInfoLog; //��������Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacematchPiccond
		{
			public uint dwSize;     		// �ṹ��С
			public uint dwSnapFaceID; //ץ��������ͼID
			public uint dwBlackListID; //ƥ��ĺ�����ID
			public uint dwBlackListFaceID; //�ȶԵĺ�����������ͼID
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              // �����ֽ�
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaFacematchPicture
		{
			public uint dwSize;     		// �ṹ��С
			public uint dwSnapFaceLen; //ץ��������ͼ����
			public uint dwBlackListFaceLen; //�ȶԵĺ�����������ͼ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;              //�����ֽ�
			public IntPtr pSnapFace;  //ץ��������ͼ��ͼƬ����
			public IntPtr pBlackListFace;  //�ȶԵĺ�����������ͼ����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaBlacklistFastregisterPara
		{
			public uint dwSize;   //�ṹ��С
			public NetVcaBlacklistInfo struBlackListInfo;  //��������������
			public uint dwImageLen;  //ͼ�����ݳ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
			public IntPtr pImage;    //ͼ������
		}

		//������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSinglePath
		{
			public byte byActive;  // �Ƿ����,0-��,1-�� 
			public byte byType;   //0-�洢ץ�ģ�1-�洢�������ȶԱ�����2-�洢ץ�ĺͺ������ȶԱ�����0xff-��Ч
			public byte bySaveAlarmPic; //�Ƿ����ڱ�������ı���ͼƬ��0-��1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1; //����
			public uint dwDiskDriver;   //�̷��ţ���0��ʼ
			public uint dwLeftSpace;   //Ԥ����������λΪG��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2; //����
		}

		//�洢·������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaSavePathCfg
		{ 
			public uint dwSize;   //�ṹ��С
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDisknumV30, ArraySubType = UnmanagedType.Struct)]
			public NetVcaSinglePath[] struPathInfo; //��������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevAccessCfg
		{
			public uint   dwSize;
			public NetDvrIpaddr struIP;		//�����豸��IP��ַ
			public ushort wDevicePort;			 	//�˿ں�
			public byte byEnable;		         //�Ƿ����ã�0-��1-��
			public byte byRes1;				//����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	//�����豸�ĵ�¼�ʺ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	//�����豸�ĵ�¼����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		/********************************��������ʶ�� end****************************/
		//�ֱ���
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

		//��ʾͨ������ָ�ģʽ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispwindowmode
		{
			public byte byDispChanType;//��ʾͨ�����ͣ�0-VGA, 1-BNC, 2-HDMI, 3-DVI
			public byte byDispChanSeq;//��ʾͨ�����,��1��ʼ�����������VGA�����ʾ�ڼ���VGA
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsNum, ArraySubType = UnmanagedType.I1)]
			public byte[] byDispMode;
		}

		//��ʾͨ����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispinfo
		{
			public byte byChanNums;//ͨ������
			public byte byStartChan;//��ʼͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxSupportRes, ArraySubType = UnmanagedType.U1)]
			public uint[] dwSupportResolution;//֧�ֵķֱ���
		}

		//����ƴ����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreeninfo
		{
			public byte bySupportBigScreenNums;//������ƴ������
			public byte byStartBigScreenNum;//����ƴ����ʼ��
			public byte byMaxScreenX;//����ƴ��ģʽ
			public byte byMaxScreenY;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixAbilityV41
		{
			public uint dwSize;
			public byte byDspNums;//DSP����  
			public byte byDecChanNums;//����ͨ����
			public byte byStartChan;//��ʼ����ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;

			public NetDvrDispinfo struVgaInfo;//VGA��ʾͨ����Ϣ
			public NetDvrDispinfo struBncInfo;//BNC��ʾͨ����Ϣ
			public NetDvrDispinfo struHdmiInfo;//HDMI��ʾͨ����Ϣ
			public NetDvrDispinfo struDviInfo;//DVI��ʾͨ����Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDispnumV41, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDispwindowmode[] struDispMode;
			public NetDvrScreeninfo struBigScreenInfo;
			public byte bySupportAutoReboot; //�Ƿ�֧���Զ�������0-��֧�֣�1-֧��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		public const int MaxWindows = 16;//��󴰿���
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
			public NetDvrRectcfg struPosition; //��ʾͨ���ڵ���ǽ��λ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NotVideoPlatform
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*��ʾͨ�����ýṹ��*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixVoutcfg
		{
			public uint dwSize;
			public byte byAudio;			/*��Ƶ�Ƿ���*/
			public byte byAudioWindowIdx;      /*��Ƶ�����Ӵ���*/
			public byte byDispChanType;      /*��ʾͨ�����ͣ�0-BNC��1-VGA��2-HDMI��3-DVI��4-YPbPr(���뿨������DECODER_SERVERר��)*/
			public byte byVedioFormat;         /*1:NTSC,2:PAL��0-NULL*/
			public uint dwResolution;//�ֱ���
			public uint dwWindowMode;		/*����ģʽ����������ȡ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��,�豸֧�ֽ�����Դ�Զ�����ʱ�˲����������*/
			public byte byEnlargeStatus;          /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
			public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�
			public byte byScale; /*��ʾģʽ��0---��ʵ��ʾ��1---������ʾ( ���BNC )*/
			public byte byUnionType;/*���ֹ�����,0-��Ƶ�ۺ�ƽ̨�ڲ���������ʾͨ�����ã�1-������������ʾͨ������*/
			public NetDvrVideoPlatform struDiff;
			public uint dwDispChanNum; //��ʾ����ţ��˲�����ȫ����ȡʱ��Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		} 

		/*�������豸״̬*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDispChanStatusV41
		{
			public byte byDispStatus;      /*��ʾ״̬��0��δ��ʾ��1��������ʾ*/
			public byte byBVGA;              /*0-BNC��1-VGA�� 2-HDMI��3-DVI��0xff-��Ч*/
			public byte byVideoFormat;     /*��Ƶ��ʽ��1:NTSC,2:PAL,0-NON*/
			public byte byWindowMode;       /*����ģʽ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;   /*�����ӻ�������Ľ���ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byFpsDisp;        /*ÿ���ӻ������ʾ֡��*/
			public byte byScreenMode;		/*��Ļģʽ0-��ͨ 1-����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwDispChan; /*��ȡȫ����ʾͨ��״̬ʱ��Ч������ʱ����0*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
		}

		/*�������豸״̬*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecoderWorkStatusV41
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
			public NetDvrMatrixChanStatus[] struDecChanStatus;     /*����ͨ��״̬*/
			/*��ʾͨ��״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDispnumV41, ArraySubType = UnmanagedType.Struct)]
			public NetDvrDispChanStatusV41[] struDispChanStatus;     
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmInStatus;         /*��������״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byAlarmOutStatus;       /*�������״̬*/
			public byte byAudioInChanStatus;          /*�����Խ�״̬*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*******************************�ļ��ط�-Զ�̻ط�����*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixDecRemotePlayV41
		{
			public uint dwSize;
			public NetDvrIpaddr	struIP;		/* DVR IP��ַ */	
			public ushort wDVRPort;			/* �˿ں� */	
			public byte byChannel;			/* ͨ���� */
			public byte byReserve;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;		/* �û��� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;		/* ���� */
			public uint dwPlayMode;   	/* 0�����ļ� 1����ʱ��*/        	
			public NetDvrTime StartTime;
			public NetDvrTime StopTime;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string sFileName;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;		/*����*/
		}

		public const int MaxBigscreennumScene = 100;

		//��ʾͨ�����ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRectcfgScene
		{
			public ushort wXCoordinate; /*�������Ͻ���ʼ��X����*/
			public ushort wYCoordinate; /*�������Ͻ�Y����*/
			public ushort wWidth;       /*���ο��*/
			public ushort wHeight;      /*���θ߶�*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScenedispcfg
		{
			public byte byEnable;//�Ƿ����ã�0-�����ã�1-����
			public byte bySoltNum;//��λ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byDispChanNum;
			public byte byAudio;				/*��Ƶ�Ƿ���,0-��1-��*/
			public byte byAudioWindowIdx;      /*��Ƶ�����Ӵ���*/
			public byte byVedioFormat;          /*1:NTSC,2:PAL��0-NULL*/
			public byte byWindowMode;			/*����ģʽ������������ȡ*/
			public byte byEnlargeStatus;         /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
			public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�    
			public byte byScale; /*��ʾģʽ��0-��ʵ��ʾ��1-������ʾ( ���BNC )*/
			public uint dwResolution;//�ֱ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byJoinDecoderId;/*��λ��*/
			//��ʾ����������Ƶ�ֱ��ʣ�1-D1,2-720P,3-1080P���豸����Ҫ���ݴ�//�ֱ��ʽ��н���ͨ���ķ��䣬��1�������ó�1080P�����豸���4������ͨ����������˽���ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWindowsV41, ArraySubType = UnmanagedType.I1)]
			public byte[] byDecResolution;
			public byte byRow;//�������ڵ��е����
			public byte byColumn;//�������ڵ��е����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public NetDvrRectcfg struDisp; //����ǽ��ʾλ��
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDevChanInfoScene
		{
			public NetDvrIpaddr struIP;				/* DVR IP��ַ */
			public ushort wDVRPort;			 	/* �˿ں� */
			public byte byChannel;		/* ͨ���ţ�����9000���豸��IPC���룬ͨ���Ŵ�33��ʼ */
			public byte byTransProtocol;		/* ����Э������0-TCP��1-UDP ��2-MCAST��3-RTP*/
			public byte byTransMode;			/* ��������ģʽ 0�������� 1��������*/
			public byte byFactoryType;				/*ǰ���豸��������*/
			public byte byDeviceType;			//�豸���ͣ�1-IPC��2- ENCODER
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	/* ���������½�ʺ� */
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword;	/* ����������� */
		}

		/*��ý���������������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrStreamMediaServerCfgScene
		{
			public byte byValid;			/*�Ƿ�������ý�������ȡ��,0��ʾ��Ч*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrIpaddr struDevIP;	/*��ý���������ַ*/
			public ushort wDevPort;			/*��ý��������˿�*/
			public byte byTransmitType;		/*����Э������0-TCP��1-UDP */
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
			public byte byEnable;	/* �Ƿ����� 0���� 1������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrStreamMediaServerCfgScene	struStreamMediaSvrCfg;	
			public NetDvrDevChanInfoScene			struDecChanInfo;	/*��Ѳ����ͨ����Ϣ*/
		}

		//��Ѳ����ṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixLoopDecinfoScene
		{
			public ushort wPoolTime;		/*��ѯ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCycleChan, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCycSurChanEleScene[] struChanArray;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//��������ͨ�����ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDecodechancfgScene
		{
			public byte byDecodeEnable;//������ͣ��־��0-ֹͣ��1-���ö�̬���룬2-������Ѳ����
			public byte bySlotNum;//��λ��
			public byte byDecChan;
			public byte byJointAllDecodeChan;		//�Ƿ�������ܽ���ͨ�� 0-��������1-����
			public byte byJointSlotNum;			//�����Ĳ�λ�ţ����ܽ����Ĳ�λ�ţ�
			public byte byJointChanNum;		//������ͨ���ţ����ܽ����ͨ���ţ�
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
			public byte byAllValid; /*����ʹ�ܱ�־ */
			public byte byAssociateBaseMap;//�����ĵ�ͼ��ţ�0��������
			public byte byEnableSpartan;//��������ʹ�ܣ�1-����0-��
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
			public byte byBigScreenNums;//�����ĸ��������ֵͨ����������ȡ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public ushort wDecChanNums;//�����н���ͨ���ĸ���
			public ushort wDispChanNums;//��������ʾͨ���ĸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
			public IntPtr pBigScreenBuffer;//�������û�����, byBigScreenNums��sizeof(NET_DVR_BIGSCREENCFG_SCENE)
			public IntPtr pDecChanBuffer;//����ͨ�����û�����, wDecChanNums��sizeof(NET_DVR_DECODECHANCFG_SCENE)
			public IntPtr pDispChanBuffer;//��ʾͨ�����û�����, wDispChanNums��sizeof(NET_DVR_SCENEDISPCFG)
			public void Init()
			{
				sSceneName = new byte[NameLen];
				byRes1 = new byte[3];
				byRes1 = new byte[12];
			}
		}
		public const int NetDvrGetAllwincfg = 1503; //���ڲ�����ȡ

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBigscreenassociatecfg
		{
			public uint dwSize;
			public byte byEnableBaseMap;//ʹ�ܵ�ͼ��ʾ
			public byte byAssociateBaseMap;//�����ĵ�ͼ��ţ�0��������
			public byte byEnableSpartan;//��������ʹ�ܣ�1-����0-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		/*******************************��������*******************************/
		public const int MaxWinCount = 224; //֧�ֵ���󿪴���

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenWincfg{
			public uint dwSize;
			public byte byVaild;
			public byte byInputType;		//��CAM_MDOE
			public ushort wInputIdx;			/*����Դ����*/
			public uint dwLayerIdx;			/*ͼ�㣬0Ϊ��ײ�*/
			public NetDvrRectcfg struWin;	//Ŀ�Ĵ���(�����ʾǽ)
			public byte byWndIndex;			//���ں�
			public byte byCBD;				//0-�ޣ�1-��������2-��������
			public byte bySubWnd;			//0���ǣ�1��
			public byte byRes1;
			public uint dwDeviceIndex;//�豸���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrWinlist
		{
			public uint dwSize;
			public ushort wScreenSeq;	//�豸���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public uint dwWinNum;	//�豸���صĴ�������
			public IntPtr pBuffer;	//������Ϣ�����������Ϊ224*sizeof(NET_DVR_WINCFG)
			public uint dwBufLen;	//������ָ�볤��
		}

		public const int MaxLayoutCount = 16;		//��󲼾���

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLayoutcfg
		{
			public uint dwSize;
			public byte byValid;								//�����Ƿ���Ч
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byLayoutName;			//��������			
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxWinCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrScreenWincfg[] struWinCfg;	//�����ڴ��ڲ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLayoutList
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxLayoutCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrLayoutcfg[] struLayoutInfo;   //���в���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int MaxCamCount = 224;

		public enum NetDvrCamMode
		{
			NetDvrUnknow  = 0,//��Ч
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
			public byte byCamMode;						//�ź�����Դ���ͣ���NET_DVR_CAM_MODE
			public ushort wInputNo;						//�ź�Դ���0-224
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sCamName;			//�ź�����Դ����
			public NetDvrVideoeffect struVideoEffect;	//��Ƶ����
			public NetDvrPuStreamCfg struPuStream;	//ip����ʱʹ��
			public ushort wBoardNum ;						//�ź�Դ���ڵİ忨��
			public ushort wInputIdxOnBoard;				//�ź�Դ�ڰ忨�ϵ�λ��
			public ushort wResolutionX;					//�ֱ���
			public ushort wResolutionY;
			public byte byVideoFormat;					//��Ƶ��ʽ��0-�ޣ�1-NTSC��2-PAL
			public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp �������ź�Դ�ķֱ��ʣ�����������ź�Դʱ�����豸���豸��������ֱ��������������Դ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sGroupName;	//�����ź�Դ���� ����
			public byte byJointMatrix;			//  �������� ��0-������  1-����
			public byte byRes;  
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputstreamList
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCamCount, ArraySubType = UnmanagedType.Struct)]
			public NetDvrInputstreamcfg[] struInputStreamInfo; //�����ź�Դ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*******************************�����������*******************************/
		/*���ͨ������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOutputparam
		{
			public uint  dwSize;
			public byte byMonMode;		/*�������ģʽ,1-BNC,2-VGA,3-DVI,4-HDMI*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint  dwResolution;	/*�ֱ��ʣ�������������ȡ��֧�ֵĽ�������*/
			public NetDvrVideoeffect  struVideoEffect;	/*���ͨ����Ƶ��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOutputcfg
		{
			public uint dwSize;
			public byte byScreenLayX;						//��������-������
			public byte byScreenLayY;						//��������-������
			public ushort wOutputChanNum;					//���ͨ��������0��ʾ�豸֧�ֵ�������ͨ������������������������ȡ������ֵ��ʾʵ�����ͨ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrOutputparam struOutputParam;	/*���ͨ����Ƶ��������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sWallName;					//����ǽ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************������*******************************/
		public const int ScreenProtocolNum = 20;   //֧�ֵ�������������Э����
		
		//����������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenserverAbility
		{
			public uint dwSize;   			/*�ṹ����*/
			public byte byIsSupportScreenNum; /*��֧�ִ�������������Ŀ*/
			public byte bySerialNums;			//���ڸ���
			public byte byMaxInputNums;
			public byte byMaxLayoutNums;
			public byte byMaxWinNums;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byMaxScreenLayX;//��������-�������������
			public byte byMaxScreenLayY;//��������-��������������
			public ushort wMatrixProtoNum; /*��Ч�Ĵ���Э����Ŀ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = ScreenProtocolNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrProtoType[] struScreenProto;/*���Э���б�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//����������������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreencontrolAbility
		{
			public uint dwSize;   		/*�ṹ����*/
			public byte byLayoutNum; 		/* ���ָ���*/
			public byte byWinNum; 			/*��Ļ���ڸ���*/
			public byte byOsdNum;  		/*OSD����*/
			public byte byLogoNum; 		/*Logo����*/
			public byte byInputStreamNum;  //����Դ���� ---�豸֧���������ͨ��������������������Դ����������Դ��
			public byte byOutputChanNum;	//���ͨ������---�豸֧��������ͨ������
			public byte byCamGroupNum;		/*�������*/
			public byte byPlanNum;    		/*Ԥ������*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public byte byIsSupportPlayBack;  /*�Ƿ�֧�ֻط�*/	
			public byte byMatrixInputNum;  //֧���������������
			public byte byMatrixOutputNum; //֧���������������
			public NetDvrDispinfo struVgaInfo;//VGA�����Ϣ
			public NetDvrDispinfo struBncInfo;//BNC�����Ϣ
			public NetDvrDispinfo struHdmiInfo;//HDMI�����Ϣ
			public NetDvrDispinfo struDviInfo;//DVI�����Ϣ
			public byte byMaxUserNums;//֧���û���
			public byte byPicSpan;		//��ͼ��ȣ�һ�ŵ�ͼ���ɸ��ǵ���Ļ��
			public ushort wDVCSDevNum;	//�ֲ�ʽ��������������豸��
			public ushort wNetSignalNum;	//�����������Դ����
			public ushort wBaseCoordinateX;//��׼����
			public ushort wBaseCoordinateY; 
			public byte byExternalMatrixNum;	//�����Ӿ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************�����ź�״̬*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAnaloginputstatus
		{
			public uint dwLostFrame;		/*��Ƶ���붪֡��*/
			public byte byHaveSignal;		/*�Ƿ�����Ƶ�ź�����*/
			public byte byVideoFormat;		/*��Ƶ��ʽ��1��NTSC,2��PAL,0����*/
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
			public ushort wInputNo;		/*�ź�Դ���*/
			public byte byInputType;	//��NET_DVR_CAM_MODE
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
			public uint dwNums;		//�豸���ص�����Դ״̬������
			public IntPtr pBuffer;	//������
			public uint dwBufLen;	//������ָ�볤�ȣ��������
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenalarmcfg
		{
			public uint dwSize;
			public byte byAlarmType;	//�������ͣ�1-�Ӱ�γ���2-�Ӱ���룬3-��ϵͳ״̬�쳣��4-��ϵͳ�ָ��ָ� 5-����Դ�쳣   6-�¶ȱ��� 7-FPGA�汾��ƥ�� 8-Ԥ����ʼ 9-Ԥ������ 10-�������� 11-�����IP��ַ��ͻ��12-�����쳣
			public byte byBoardType;	// 1-����� 2-����� ��3-���壬4-���壬��������Ϊ1��2��3��6��ʱ��ʹ�� 
			public byte bySubException;	//�����쳣ʱ�������쳣 1- �ֱ��������ı� 2-����˿����͸ı�3-�ֱ��ʴ���4-�ֱ��ʸı䵼�½�����Դ���㣬�رո�����Դ��Ӧ���ڡ�5-�ֱ��ʸı䣬�����ѿ��������ű�������1/8��8����Χ��6-�ֱ��ʻָ�����,7-�ֱ��ʸı䵼�����������������,�豸�رմ��� 
			public byte byRes1;
			public ushort wStartInputNum; // �쳣����Դ���쳣��㣩 
			public ushort wEndInputNum;	// �쳣����Դ���쳣�յ㣩 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	   
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrMatrixCfg
		{
			public byte byValid;				//�ж��Ƿ���ģ������Ƿ���Ч��
			public byte byCommandProtocol;	//ģ������ָ�4�֣�
			public byte byScreenType;			//����	
			public byte byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byScreenToMatrix;	//ģ�������������Ļ�Ķ�Ӧ��ϵ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDigitalscreen
		{
			public NetDvrIpaddr  struAddress;/*�豸Ϊ�����豸ʱ��IP��Ϣ*/
			public ushort wPort;		//ͨ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAnalogscreen
		{
			public byte byDevSerPortNum;   /*�����豸�Ĵ��ں�*/
			public byte byScreenSerPort;  /*���Ӵ����Ĵ��ں�*/
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
			public byte byValid;				//�Ƿ���Ч
			public byte nLinkMode;				//���ӷ�ʽ��0-���ڣ�1-����
			public byte byDeviceType;			//�豸�ͺţ���������ȡ
			public byte byScreenLayX;			//��������-������
			public byte byScreenLayY;			//��������-������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sUserName;	/*��¼�û���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PasswdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sPassword; /*��¼����*/   
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDevName;	/*�豸����*/
			public NetDvrScreenUnion struScreenUnion;
			public byte byInputNum;			// ����Դ����
			public byte byOutputNum;			// ���Դ����
			public byte byCBDNum;				//CBD����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************��ͼ�ϴ�*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrBasemapCfg
		{	
			public byte byScreenIndex;         //��Ļ�����
			public byte byMapNum;				/*���ָ���˶��ٿ�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] res;
			public ushort wSourWidth;			/* ԭͼƬ�Ŀ�� */
			public ushort wSourHeight;			/* ԭͼƬ�ĸ߶� */
		}            

		/*******************************OSD*******************************/
		public const int MaxOsdcharNum = 256;
		
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrOsdcfg
		{
			public uint dwSize;
			public byte byValid;    /*�Ƿ���Ч 0��Ч 1��Ч*/
			public byte byDispMode;  //��ʾģʽ��1-͸����2-��͸����3-��������ģʽ
			public byte byFontColorY; /*������ɫY,0-255*/
			public byte byFontColorU; /*������ɫU,0-255*/
			public byte byFontColorV; /*������ɫV,0-255*/
			public byte byBackColorY; /*������ɫY,0-255*/
			public byte byBackColorU; /*������ɫU,0-255*/
			public byte byBackColorV; /*������ɫV,0-255*/
			public ushort wXCoordinate;   /*OSD����Ļ���Ͻ�λ��x*/
			public ushort wYCoordinate;   /*OSD����Ļ���Ͻ�λ��y*/
			public ushort wWidth;       /*OSD���*/
			public ushort wHeight;      /*OSD�߶�*/
			public uint dwCharCnt;     /*�ַ��ĸ���*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxOsdcharNum, ArraySubType = UnmanagedType.U2)]
			public ushort[] wOSDChar;       /*OSD�ַ�����*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		/*******************************��ȡ������Ϣ*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSerialControl
		{ 
			public uint dwSize ;
			public byte bySerialNum;        // ���ڸ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] bySerial;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************��Ļ����*******************************/
		//��Ļ����Դ����
		public enum InputInterfaceType
		{
			InterfaceVga = 0,
			InterfaceSvideo, // 2046NL��֧�֣�2046NH֧��
			InterfaceYpbpr,
			InterfaceDvi ,
			InterfaceBnc , 
			InterfaceDviLoop,//(��ͨ) 2046NH��֧�֣�2046NL֧��
			InterfaceBncLoop, //(��ͨ) 2046NH��֧�֣�2046NL.֧��
			InterfaceHdmi,
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputInterfaceCtrl
		{
			public byte byInputSourceType;	//��INPUT_INTERFACE_TYPE
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}
		
		//��ʾ��Ԫ��ɫ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDisplayColorCtrl
		{
			public byte byColorType;		//1-���� 2-�Աȶ� 3-���Ͷ� 4-������
			public char	byScale;			//-1 ��0��+1����ֵ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//��ʾ��Ԫλ�ÿ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDisplayPositionCtrl
		{
			public byte byPositionType;	//1-ˮƽλ�� 2-��ֱλ�ã�
			public char byScale;			//-1 ��0��+1����ֵ
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
			public uint dwCommand ;      /* ���Ʒ��� 1-�� 2-�� 3-��Ļ����Դѡ�� 4-��ʾ��Ԫ��ɫ���� 5-��ʾ��Ԫλ�ÿ���*/
			public byte byProtocol;      //����Э������,1:LCD-S1,2:LCD-S2
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrScreenControlParam	struControlParam;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;	
		}

		/*******************************��Ļ����V41*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrScreenControlV41
		{ 	
			public uint dwSize;
			public byte bySerialNo;		//���ں�
			public byte byBeginAddress;	//���Ͻ���Ļ�ţ���1��ʼ
			public byte byEndAddress;	//���½���Ļ�ţ���1��ʼ
			public byte byProtocol;      	   // ����Э������  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 �� 4-LCD-DLP�� 5-LCD-S3 , 6-LCD-H1 
			public uint dwCommand ;      /* ���Ʒ��� 1-�� 2-�� 3-��Ļ����Դѡ�� 4-��ʾ��Ԫ��ɫ���� 5-��ʾ��Ԫλ�ÿ���*/
			public NetDvrScreenControlParam	struControlParam;
			public byte byWallNo;		// ����ǽ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;	
		}

		/*******************************Ԥ������*******************************/
		public const int MaxPlanActionNum = 32; 	//Ԥ����������
		public const int DaysAWeek = 7;	//һ��7��
		public const int MaxPlanCount = 16;	//Ԥ������

		public enum NetDvrPlanOperateType
		{
			NetDvrSwitchLayout = 1, 		// �����л� Ĭ��
			NetDvrScreenPowerOff,  		// �رմ���Ļ��ʾ
			NetDvrScreenPowerOn,   		// �򿪴���Ļ��ʾ
		}

		/*Ԥ������Ϣ*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlanInfo
		{
			public byte byValid;      	// �����Ƿ���Ч
			public byte byType;       	// ������NET_DVR_PLAN_OPERATE_TYPE
			public ushort wLayoutNo;  	// ���ֺ�
			public byte byScreenStyle;    //��Ļ�ͺţ����ػ����ã�1�ǵ�����2�Ǹ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwDelayTime;  	// һ���������ʱ��, ��λ��
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

		/*Ԥ������*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlanCfg
		{
			public uint dwSize;
			public byte byValid;      	// ��Ԥ���Ƿ���Ч
			public byte byWorkMode;  	// Ԥ������ģʽ 1��ʾ�ֶ���2�Զ���3Ԥ��ѭ��
			public byte byWallNo;		//����ǽ�ţ���1��ʼ
			public byte byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPlanName; //Ԥ������
			public NetDvrTimeEx struTime; // ����ģʽΪ�Զ�ʱʹ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = DaysAWeek, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCycleTime[] struTimeCycle; /*ѭ��ʱ�䣬����Ϊһ�����ڣ��ꡢ�¡�������������ʹ�á��磺struTimeCycle[0]�е�byValid��ֵ��1����ʾ������ִ�и�Ԥ��������ȡֵ����Ϊ[0,6]������0���������죬1��������һ���Դ�����*/
			public uint dwWorkCount;  	// Ԥ������ִ�д�����0Ϊһֱѭ�����ţ�����ֵ��ʾ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPlanActionNum, ArraySubType = UnmanagedType.Struct)]
			public NetDvrPlanInfo[] strPlanEntry;  // Ԥ��ִ�е�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************��ȡ�豸״̬*******************************/
		/*Ԥ���б�*/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlanList
		{
			public uint dwSize;
			public uint dwPlanNums;			//�豸�����ź�Դ����
			public IntPtr pBuffer;			//ָ��dwInputSignalNums��NET_DVR_PLAN_CFG�ṹ��С�Ļ�����
			public byte byWallNo;			//ǽ�ţ���1��ʼ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwBufLen;			//�����仺�������ȣ�������������ڵ���dwInputSignalNums��NET_DVR_PLAN_CFG�ṹ��С��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************Ԥ������*******************************/
		//�ýṹ�����Ϊͨ�ÿ��ƽṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrControlParam
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = NameLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sDeviceID; //�����豸���豸ID
			public ushort wChan;				 //����ͨ��
			public byte byIndex;			 //������������������ȷ�������ʾʲô����
			public byte byRes1;
			public uint dwControlParam;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		/*******************************��ȡ�豸״̬*******************************/
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDeviceRunStatus
		{
			public uint dwSize;
			public uint dwMemoryTotal;		//�ڴ�����	��λKbyte
			public uint dwMemoryUsage;		//�ڴ�ʹ���� ��λKbyte
			public byte byCPUUsage;			//CPUʹ���� 0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//91ϵ��HD-SDI����DVR �����Ϣ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAccessCameraInfo
		{
			public uint dwSize;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string sCameraInfo;		// ǰ�������Ϣ
			public byte  byInterfaceType;		// ǰ�˽���ӿ����ͣ�1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwChannel;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAudioInputParam
		{
			public byte byAudioInputType;  //��Ƶ�������ͣ�0-mic in��1-line in
			public byte byVolume; //volume,[0-100]
			public byte byEnableNoiseFilter; //�Ƿ�����������-�أ�-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
			public byte[] byres;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCameraDehazeCfg
		{
			public uint dwSize;
			public byte byDehazeMode; //0-�����ã�1-�Զ�ģʽ��2-��
			public byte byLevel; //�ȼ���0-100
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; 
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrInputSignalList
		{
			public uint dwSize;
			public uint dwInputSignalNums;	//�豸�����ź�Դ����
			public IntPtr pBuffer;			//ָ��dwInputSignalNums��NET_DVR_INPUTSTREAMCFG�ṹ��С�Ļ�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public uint dwBufLen;			//�����仺�������ȣ�������������ڵ���dwInputSignalNums��NET_DVR_INPUTSTREAMCFG�ṹ��С��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;
		}

		//��ȫ����״̬
		public const int PullDiskSuccess = 1;     // ��ȫ���̳ɹ�
		public const int PullDiskFail = 2;        // ��ȫ����ʧ��
		public const int PullDiskProcessing = 3;  // ����ֹͣ����
		public const int PullDiskNoArray = 4;	// ���в����� 
		public const int PullDiskNotSupport = 5; // ��֧�ְ�ȫ����

		//ɨ������״̬
		public const int ScanRaidSuc = 1; 	// ɨ�����гɹ�
		public const int ScanRaidFail = 2; 	// ɨ������ʧ��
		public const int ScanRaidProcessing = 3;	// ����ɨ������
		public const int ScanRaidNotSupport = 4; // ��֧������ɨ��

		//����ǰ���������״̬
		public const int SetCameraTypeSuccess = 1;  // �ɹ�
		public const int SetCameraTypeFail = 2;  // ʧ��
		public const int SetCameraTypeProcessing	= 3;   // ���ڴ���

		//9000 2.2
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordTimeSpanInquiry
		{
			public uint dwSize;    //�ṹ���С
			public byte byType;    //0 ��������Ƶ¼��, 1ͼƬͨ��¼��, 2ANRͨ��¼��, 3��֡ͨ��¼��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrRecordTimeSpan
		{
			public uint dwSize;        //�ṹ���С
			public NetDvrTime strBeginTime;  //��ʼʱ��
			public NetDvrTime strEndTime;    //����ʱ��
			public byte byType;        //0 ��������Ƶ¼��, 1ͼƬͨ��¼��, 2ANRͨ��¼��, 3��֡ͨ��¼��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;     //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrDrawframeDiskQuotaCfg
		{
			public uint dwSize;					//�ṹ���С
			public byte byPicQuota;				//ͼƬ�ٷֱ�	 [0%,  30%]
			public byte byRecordQuota;				//��ͨ¼��ٷֱ� [20%, 40%]
			public byte byDrawFrameRecordQuota;	//��֡¼��ٷֱ� [30%, 80%]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;					//�����ֽ�
		}

		//�˿�ӳ�����ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNatPort
		{
			public ushort wEnable;
			public ushort wExtPort;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//�˿�ӳ�����ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrNatCfg
		{
			public uint dwSize;
			public ushort wEnableUpnp;
			public ushort wEnableNat;
			public NetDvrIpaddr struIpAddr;//��ʱ��ֹͣʱ��
			public NetDvrNatPort struHttpPort;//��ʱ��ֹͣʱ��
			public NetDvrNatPort struCmdPort;//��ʱ��ֹͣʱ��
			public NetDvrNatPort struRtspPort;//��ʱ��ֹͣʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byFriendName;
			public byte byNatType;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			public NetDvrNatPort struHttpsPort;//��ʱ��ֹͣʱ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//Upnp�˿�ӳ��״̬�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUpnpPortState
		{
			public uint dwEnabled;//�ö˿��Ƿ�ʹ��ӳ��
			public ushort wInternalPort;//ӳ��ǰ�Ķ˿�
			public ushort wExternalPort;//ӳ���Ķ˿�
			public uint dwStatus;//�˿�ӳ��״̬��0- δ��Ч��1- δ��Ч��ӳ��Դ�˿���Ŀ�Ķ˿���һ�£�2- δ��Ч��ӳ��˿ں��ѱ�ʹ�ã�3- ��Ч
			public NetDvrIpaddr struNatExternalIp;//ӳ�����ⲿ��ַ
			public NetDvrIpaddr struNatInternalIp;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		//Upnp�˿�ӳ��״̬�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrUpnpNatState
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
			public NetDvrUpnpPortState[] strUpnpPort;//�˿�ӳ��״̬:������0- web server�˿ڣ�����1- ����˿ڣ�����2- rtsp��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlaycond
		{
			public uint dwChannel;
			public NetDvrTime struStartTime;
			public NetDvrTime struStopTime;
			public byte byDrawFrame;  //0:����֡��1����֡
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //����
		}

		//¼��طŽṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrVodPara
		{
			public uint dwSize; //�ṹ���С
			public NetDvrStreamInfo struIDInfo; //��ID��Ϣ
			public NetDvrTime struBeginTime;//�طſ�ʼʱ��
			public NetDvrTime struEndTime;//�طŽ���ʱ��
			public IntPtr hWnd;//�طŴ���
			public byte byDrawFrame;//�Ƿ��֡��0- ����֡��1- ��֡
			public byte byVolumeType;//0-��ͨ¼���1-�浵��������CVR�豸����ͨ������ͨ��¼�񣬴浵�����ڱ���¼��
			public byte byVolumeNum;//�浵��� 
			public byte byRes1;//����
			public uint dwFileIndex;//�浵���ϵ�¼���ļ������������浵��¼��ʱ���ص�ֵ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAtmfindinfo
		{
			public byte byTransactionType;       //�������� 0-ȫ����1-��ѯ�� 2-ȡ� 3-�� 4-�޸����룬5-ת�ˣ� 6-�޿���ѯ 7-�޿��� 8-�̳� 9-�̿� 10-�Զ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;    //����
			public uint dwTransationAmount ;     //���׽�� ;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct NetDvrSpecialFindinfoUnion
		{
			[FieldOffset(0)]
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byLenth ;
			[FieldOffset(0)]
			public NetDvrAtmfindinfo struATMFindInfo;	       //ATM��ѯ
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
			public byte byDrawFrame; //0:����֡��1����֡
			public byte byFindType; //0:��ѯ��ͨ��1����ѯ�浵��
			public byte byQuickSearch; //0:��ͨ��ѯ��1�����٣���������ѯ
			public byte bySpecialFindInfoType ;    //ר�в�ѯ�������� 0-��Ч�� 1-��ATM��ѯ����  
			public uint dwVolumeNum;  //�浵���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = GuidLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byWorkingDeviceGUID;    //������GUID��ͨ����ȡN+1�õ�
			public NetDvrSpecialFindinfoUnion uSpecialFindInfo ;   //ר�в�ѯ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;    //����
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrAesKeyInfo
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] sAESKey;  /*����������Կ*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;  /*�����ֽ�*/
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPoeCfg
		{
			public NetDvrIpaddr struIP;     //IP��ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes; //����
		}

		public const int MaxProPath = 256; //���Э��·������

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCustomProtocal
		{
			public uint dwSize;              //�ṹ���С
			public uint dwEnabled;           //�Ƿ����ø�Э��0 ������ 1 ����
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = DescLen)]
			public string sProtocalName;   //�Զ���Э������, 16λ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;          //����,����Э��������չ
			public uint dwEnableSubStream;   //�������Ƿ�����0 ������ 1 ����	
			public byte byMainProType;        //������Э������ 1 RTSP
			public byte byMainTransType;		//�������������� 0��Auto 1��udp 2��rtp over rtsp
			public ushort wMainPort;           //�������˿�	
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxProPath)]
			public string sMainPath;  //������·��	
			public byte bySubProType;         //������Э������ 1 RTSP
			public byte bySubTransType;		//�������������� 0��Auto 1��udp 2��rtp over rtsp
			public ushort wSubPort;   //�������˿�
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxProPath)]
			public string sSubPath;   //������·�� 	
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes2;          //����
		}
	 
		//Ԥ��V40�ӿ�
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPreviewinfo
		{
			public int lChannel;//ͨ����
			public uint dwStreamType;	// �������ͣ�0-��������1-��������2-����3��3-����4 ���Դ�����
			public uint dwLinkMode;// 0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-RTP/RTSP,5-RSTP/HTTP 
			public IntPtr hPlayWnd;//���Ŵ��ڵľ��,ΪNULL��ʾ������ͼ��
			public bool bBlocked;  //0-������ȡ��, 1-����ȡ��, �������SDK�ڲ�connectʧ�ܽ�����5s�ĳ�ʱ���ܹ�����,���ʺ�����ѯȡ������.
			public bool bPassbackRecord; //0-������¼��ش�,1����¼��ش�
			public byte byPreviewMode;//Ԥ��ģʽ��0-����Ԥ����1-�ӳ�Ԥ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = StreamIdLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byStreamID;//��ID��lChannelΪ0xffffffffʱ���ô˲���
			public byte byProtoType; //Ӧ�ò�ȡ��Э�飬0-˽��Э�飬1-RTSPЭ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 222, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		///ץ�Ļ�
		///
		public const int MaxOverlapItemNum = 50;       //����ַ���������
		public const int NetItsGetOverlapCfg = 5072;//��ȡ�ַ����Ӳ������ã������ITS�նˣ�
		public const int NetItsSetOverlapCfg = 5073;//�����ַ����Ӳ������ã������ITS�նˣ�

		//�ַ������������������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapcfgCond
		{
			public uint dwSize;
			public uint dwChannel;//ͨ���� 
			public uint dwConfigMode;//����ģʽ��0- �նˣ�1- ǰ��(ֱ��ǰ�˻��ն˽�ǰ��)
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		//�����ַ�������Ϣ�ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapSingleItemParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����
			public byte byItemType;//����
			public byte byChangeLineNum;//�������Ļ�������ȡֵ��Χ��[0,10]��Ĭ�ϣ�0 
			public byte bySpaceNum;//�������Ŀո�����ȡֵ��Χ��[0-255]��Ĭ�ϣ�0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		//�ַ����������ýṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapItemParam
		{
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxOverlapItemNum, ArraySubType = UnmanagedType.Struct)]
			public NetItsOverlapSingleItemParam[] struSingleItem;//�ַ���������Ϣ
			public uint dwLinePercent;
			public uint dwItemsStlye;
			public ushort wStartPosTop;
			public ushort wStartPosLeft;
			public ushort wCharStyle;
			public ushort wCharSize;
			public ushort wCharInterval;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//����
			public uint dwForeClorRGB;//ǰ��ɫ��RGBֵ��bit0~bit7: B��bit8~bit15: G��bit16~bit23: R��Ĭ�ϣ�x00FFFFFF-��
			public uint dwBackClorRGB;//����ɫ��RGBֵ��ֻ��ͼƬ�������Ч��bit0~bit7: B��bit8~bit15: G��bit16~bit23: R��Ĭ�ϣ�x00000000-�� 
			public byte byColorAdapt;//��ɫ�Ƿ�����Ӧ��0-��1-��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����
		}

		//�ַ�����������Ϣ�ṹ��
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
			public byte[] byRes1;//���ﱣ����Ƶ��ѹ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitoringSite1;//
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byMonitoringSite2;//���ﱣ����Ƶ��ѹ������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//���ﱣ����Ƶ��ѹ������ 
		}

		//�ַ������������������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetItsOverlapCfg
		{
			public uint dwSize;
			public byte byEnable;//�Ƿ����ã�0- �����ã�1- ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;//���ﱣ����Ƶ��ѹ������
			public NetItsOverlapItemParam struOverLapItem;//�ַ�������
			public NetItsOverlapInfoParam struOverLapInfo;//�ַ���������Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//���ﱣ����Ƶ��ѹ������ 
		}

		//�������������ṹ��
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrSetupalarmParam
		{
			public uint dwSize;
			public byte byLevel;//�������ȼ���0- һ�ȼ����ߣ���1- ���ȼ����У���2- ���ȼ����ͣ�������
			public byte byAlarmInfoType;//�ϴ�������Ϣ���ͣ����ܽ�ͨ�����֧�֣���0- �ϱ�����Ϣ��NetDvrPlateResult����1- �±�����Ϣ(NET_ITS_PLATE_RESULT) 
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//���ﱣ����Ƶ��ѹ������ 
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
		/********************************�ӿڲ����ṹ(end)*********************************/


		/********************************SDK�ӿں�������*********************************/

		/*********************************************************
		Function:	NET_DVR_Init
		Desc:		��ʼ��SDK����������SDK������ǰ�ᡣ
		Input:	
		Output:	
		Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ�ܡ�
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Init();

		/*********************************************************
		Function:	NET_DVR_Cleanup
		Desc:		�ͷ�SDK��Դ���ڽ���֮ǰ������
		Input:	
		Output:	
		Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ��
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Cleanup();



		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

		/*********************************************************
		Function:	EXCEPYIONCALLBACK
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Excepyioncallback(uint dwType, int lUserId, int lHandle, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, Excepyioncallback fExceptionCallBack, IntPtr pUser);


		/*********************************************************
		Function:	MESSCALLBACK
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messcallback(int lCommand, string sDvrip, string pBuf, uint dwBufLen);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack(Messcallback fMessCallBack);

		/*********************************************************
		Function:	MESSCALLBACKEX
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messcallbackex(int iCommand, int iUserId, string pBuf, uint dwBufLen);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack_EX(Messcallbackex fMessCallBackEx);

		/*********************************************************
		Function:	MESSCALLBACKNEW
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messcallbacknew(int lCommand, string sDvrip, string pBuf, uint dwBufLen, ushort dwLinkDvrPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessCallBack_NEW(Messcallbacknew fMessCallBackNew);

		/*********************************************************
		Function:	MESSAGECALLBACK
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate int Messagecallback(int lCommand, IntPtr sDvrip, IntPtr pBuf, uint dwBufLen, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetDVRMessageCallBack(Messagecallback fMessageCallBack, uint dwUser);


		/*********************************************************
		Function:	MSGCallBack
		Desc:		(�ص�����)
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
		//Ԥ����ؽӿ�
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay(int iUserId, ref NetDvrClientinfo lpClientInfo);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_SDK_RealPlay(int iUserLogId, ref NetDvrClientinfo lpDvrClientInfo);
		/*********************************************************
		Function:	REALDATACALLBACK
		Desc:		Ԥ���ص�
		Input:	lRealHandle ��ǰ��Ԥ����� 
				dwDataType ��������
				pBuffer ������ݵĻ�����ָ�� 
				dwBufSize ��������С 
				pUser �û����� 
		Output:	
		Return:	void
		**********************************************************/
		public delegate void Realdatacallback(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, IntPtr pUser);
		[DllImport(@"..\bin\HCNetSDK.dll")]

		/*********************************************************
		Function:	NET_DVR_RealPlay_V30
		Desc:		ʵʱԤ����
		Input:	lUserId [in] NET_DVR_Login()��NET_DVR_Login_V30()�ķ���ֵ 
				lpClientInfo [in] Ԥ������ 
				cbRealDataCallBack [in] �������ݻص����� 
				pUser [in] �û����� 
				bBlocked [in] �������������Ƿ�������0����1���� 
		Output:	
		Return:	1��ʾʧ�ܣ�����ֵ��ΪNET_DVR_StopRealPlay�Ⱥ����ľ������
		**********************************************************/
		public static extern int NET_DVR_RealPlay_V30(int iUserId, ref NetDvrClientinfo lpClientInfo, Realdatacallback fRealDataCallBackV30, IntPtr pUser, uint bBlocked);

		/*********************************************************
		Function:	NET_DVR_RealPlay_V40
		Desc:		ʵʱԤ����չ�ӿڡ�
		Input:	lUserId [in] NET_DVR_Login()��NET_DVR_Login_V30()�ķ���ֵ 
				lpPreviewInfo [in] Ԥ������ 
				fRealDataCallBack_V30 [in] �������ݻص����� 
				pUser [in] �û����� 
		Output:	
		Return:	1��ʾʧ�ܣ�����ֵ��ΪNET_DVR_StopRealPlay�Ⱥ����ľ������
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_RealPlay_V40(int iUserId, ref NetDvrPreviewinfo lpPreviewInfo, Realdatacallback fRealDataCallBackV30, IntPtr pUser);

	   // [DllImport(@"..\bin\HCNetSDK.dll")]
	   // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
		/*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		ֹͣԤ����
		Input:	lRealHandle [in] Ԥ�������NET_DVR_RealPlay����NET_DVR_RealPlay_V30�ķ���ֵ 
		Output:	
		Return:	
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopRealPlay(int iRealHandle);

		/*********************************************************
		Function:	DRAWFUN
		Desc:		(�ص�����)
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
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Setrealdatacallback(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, Setrealdatacallback fRealDataCallBack, uint dwUser);

		/*********************************************************
		Function:	STDDATACALLBACK
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Stddatacallback(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, Stddatacallback fStdDataCallBack, uint dwUser);


		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CapturePicture(int lRealHandle, string sPicFileName);

		//��̬����I֡
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MakeKeyFrame(int lUserId, int lChannel);//������

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MakeKeyFrameSub(int lUserId, int lChannel);//������

		//��̨������ؽӿ�
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

		//�ļ�������ط�
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

		//2007-04-16���Ӳ�ѯ��������ŵ��ļ�����
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
		Desc:		(�ص�����)
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

		//����
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

		//Զ�̸�ʽ��Ӳ��
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FormatDisk(int lUserId, int lDiskNumber);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);

		//����
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

		//�����Խ�
		/*********************************************************
		Function:	VOICEDATACALLBACK
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Voicedatacallback(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom(int lUserId, Voicedatacallback fVoiceDataCallBack, uint dwUser);

		/*********************************************************
		Function:	VOICEDATACALLBACKV30
		Desc:		(�ص�����)
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

		//����ת��
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_MR(int lUserId, Voicedatacallback fVoiceDataCallBack, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserId, uint dwVoiceChan, Voicedatacallbackv30 fVoiceDataCallBack, IntPtr pUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);

		//�����㲥
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientAudioStart();

		/*********************************************************
		Function:	VOICEAUDIOSTART
		Desc:		(�ص�����)
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


		//͸��ͨ������
		/*********************************************************
		Function:	SERIALDATACALLBACK
		Desc:		(�ص�����)
		Input:	
		Output:	
		Return:	
		**********************************************************/
		public delegate void Serialdatacallback(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialStart(int lUserId, int lSerialPort, Serialdatacallback fSerialDataCallBack, uint dwUser);

		//485��Ϊ͸��ͨ��ʱ����Ҫָ��ͨ���ţ���Ϊ��ͬͨ����485�����ÿ��Բ�ͬ(���粨����)
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SerialStop(int lSerialHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SendTo232Port(int lUserId, string pSendBuf, uint dwBufSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SendToSerialPort(int lUserId, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);

		//���� nBitrate = 16000
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_InitG722Decoder(int nBitrate);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);

		//����
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern IntPtr NET_DVR_InitG722Encoder();

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);

		//Զ�̿��Ʊ�����ʾ
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClickKey(int lUserId, int lKeyIndex);

		//Զ�̿����豸���ֶ�¼��
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StartDVRRecord(int lUserId, int lChannel, int lRecordType);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_StopDVRRecord(int lUserId, int lChannel);

		//���뿨
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

		//��ȡ���뿨���кŴ˽ӿ���Ч������GetBoardDetail�ӿڻ��(2005-12-08֧��)
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);

		//��־
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

		//��ֹ2004��8��5��,��113���ӿ�
		//ATM DVR
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFileByCard(int lUserId, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);


		//2005-09-15
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CaptureJPEGPicture(int lUserId, int lChannel, ref NetDvrJpegpara lpJpegPara, string sPicFileName);

		//JPEGץͼ���ڴ�
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserId, int lChannel, ref NetDvrJpegpara lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);

		//2006-02-16
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);

		//2006-08-28 704-640 ��������
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetScaleCFG(int lUserId, uint dwScale);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetScaleCFG(int lUserId, ref uint lpOutScale);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetScaleCFG_V30(int lUserId, ref NetDvrScalecfg pScalecfg);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetScaleCFG_V30(int lUserId, ref NetDvrScalecfg pScalecfg);

		//2006-08-28 ATM���˿�����
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetATMPortCFG(int lUserId, ushort wAtmPort);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetATMPortCFG(int lUserId, ref ushort lpOutAtmPort);

		//2006-11-10 ֧���Կ��������
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

		//�����豸DS-6001D/DS-6001F
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

		//��·������
		//2007-11-30 V211֧�����½ӿ� //11
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

		//2007-12-22 ����֧�ֽӿ� //18
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

		//2009-4-13 ����
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

		public const int NetDvrShowlogo = 1;/*��ʾLOGO*/
		public const int NetDvrHidelogo = 2;/*����LOGO*/

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_LogoSwitch(int lUserId, uint dwDecChan, uint dwLogoSwitch);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserId, ref NetDvrDecoderWorkStatus lpDecoderCfg);

		/*��ʾͨ�������붨��*/
		//�Ϻ����� ����
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RigisterPlayBackDrawFun(int lRealHandle, Drawfun fDrawFun, uint dwUser);


		public const int DispCmdEnlargeWindow = 1;	/*��ʾͨ���Ŵ�ĳ������*/
		public const int DispCmdRenewWindow = 2;	/*��ʾͨ�����ڻ�ԭ*/

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixDiaplayControl(int lUserId, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);

		//end
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);

		//�ָ�Ĭ��ֵ
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RestoreConfig(int lUserId);

		//�������
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SaveConfig(int lUserId);

		//����
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_RebootDVR(int lUserId);

		//�ر�DVR
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ShutDownDVR(int lUserId);

		//��ȡ�豸֧�ֵ�IPCЭ���
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetIPCProtoList(int lUserId, ref NetDvrIpcProtoList lpProtoList);

		//�������� begin
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

		//��ȡUPNP�˿�ӳ��״̬
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetUpnpNatState(int lUserId, ref NetDvrUpnpNatState lpState);

		//��Ƶ��������
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

		//�����ļ�
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

		//������־�ļ�д��ӿ�
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSDKState(ref NetDvrSdkstate pSdkState);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetSDKAbility(ref NetDvrSdkabl pSdkAbl);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetPTZProtocol(int lUserId, ref NetDvrPtzcfg pPtzcfg);

		//ǰ�������
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_LockPanel(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_UnLockPanel(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetRtspConfig(int lUserId, uint dwCommand, ref NetDvrRtspcfg lpInBuffer, uint dwInBufferSize);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetRtspConfig(int lUserId, uint dwCommand, ref NetDvrRtspcfg lpOutBuffer, uint dwOutBufferSize);

		//��Ƶ�ۺ�ƽ̨
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixGetSceneCfg(int lUserId, uint dwSceneNum, ref NetDvrMatrixScenecfg lpSceneCfg);
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_MatrixSetSceneCfg(int lUserId, uint dwSceneNum, ref NetDvrMatrixScenecfg lpSceneCfg);

		//SDK_V222
		//�����豸����
		public const int Ds6001HfB = 60;//��Ϊ������DS6001-HF/B
		public const int Ds6001HfP = 61;//����ʶ��DS6001-HF/P
		public const int Ds6002HfB = 62;//˫�����٣�DS6002-HF/B
		public const int Ds6101HfB = 63;//��Ϊ������DS6101-HF/B
		public const int Ids52Xx = 64;//���ܷ�����IVMS
		public const int Ds9000Ivs = 65;//9000ϵ������DVR
		public const int Ds8004AhlA = 66;//����ATM, DS8004AHL-S/A
		public const int Ds6101HfP = 67;//����ʶ��DS6101-HF/P

		//������ȡ����
		public const int VcaDevAbility = 256;//�豸���ܷ�����������
		public const int VcaChanAbility = 272;//��Ϊ��������
		public const int MatrixdecoderAbility = 512;//��·��������ʾ����������
		//��ȡ/���ô�ӿڲ�����������
		//����ʶ��NET_VCA_PLATE_CFG��
		public const int NetDvrSetPlatecfg = 150;//���ó���ʶ�����
		public const int NetDvrGetPlatecfg = 151;//��ȡ����ʶ�����
		//��Ϊ��Ӧ��NetVcaRulecfg��
		public const int NetDvrSetRulecfg = 152;//������Ϊ��������
		public const int NetDvrGetRulecfg = 153;//��ȡ��Ϊ��������

		//˫������궨������NET_DVR_LF_CFG��
		public const int NetDvrSetLfCfg = 160;//����˫����������ò���
		public const int NetDvrGetLfCfg = 161;//��ȡ˫����������ò���

		//���ܷ�����ȡ�����ýṹ
		public const int NetDvrSetIvmsStreamcfg = 162;//�������ܷ�����ȡ������
		public const int NetDvrGetIvmsStreamcfg = 163;//��ȡ���ܷ�����ȡ������

		//���ܿ��Ʋ����ṹ
		public const int NetDvrSetVcaCtrlcfg = 164;//�������ܿ��Ʋ���
		public const int NetDvrGetVcaCtrlcfg = 165;//��ȡ���ܿ��Ʋ���

		//��������NET_VCA_MASK_REGION_LIST
		public const int NetDvrSetVcaMaskRegion = 166;//���������������
		public const int NetDvrGetVcaMaskRegion = 167;//��ȡ�����������

		//ATM�������� NET_VCA_ENTER_REGION
		public const int NetDvrSetVcaEnterRegion = 168;//���ý����������
		public const int NetDvrGetVcaEnterRegion = 169;//��ȡ�����������

		//�궨������NET_VCA_LINE_SEGMENT_LIST
		public const int NetDvrSetVcaLineSegment = 170;//���ñ궨��
		public const int NetDvrGetVcaLineSegment = 171;//��ȡ�궨��

		// ivms��������NET_IVMS_MASK_REGION_LIST
		public const int NetDvrSetIvmsMaskRegion = 172;//����IVMS�����������
		public const int NetDvrGetIvmsMaskRegion = 173;//��ȡIVMS�����������
		// ivms����������NET_IVMS_ENTER_REGION
		public const int NetDvrSetIvmsEnterRegion = 174;//����IVMS�����������
		public const int NetDvrGetIvmsEnterRegion = 175;//��ȡIVMS�����������

		public const int NetDvrSetIvmsBehaviorcfg = 176;//�������ܷ�������Ϊ�������
		public const int NetDvrGetIvmsBehaviorcfg = 177;//��ȡ���ܷ�������Ϊ�������

		// IVMS �طż���
		public const int NetDvrIvmsSetSearchcfg = 178;//����IVMS�طż�������
		public const int NetDvrIvmsGetSearchcfg = 179;//��ȡIVMS�طż�������        

		//�ṹ�����궨�� 
		public const int VcaMaxPolygonPointNum = 10;//����������֧��10����Ķ����
		public const int MaxRuleNum = 8;//����������
		public const int MaxTargetNum = 30;//���Ŀ�����
		public const int MaxCalibPt = 6;//���궨�����
		public const int MinCalibPt = 4;//��С�궨�����
		public const int MaxTimesegment2 = 2;//���ʱ�����
		public const int MaxLicenseLen = 16;//���ƺ���󳤶�
		public const int MaxPlateNum = 3;//���Ƹ���
		public const int MaxMaskRegionNum = 4;//����ĸ���������
		public const int MaxSegmentNum = 6;//������궨�����������Ŀ
		public const int MinSegmentNum = 3;//������궨��С��������Ŀ        
		/*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ�ܡ�
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetDeviceAbility(int lUserId, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);

		//�����ؼ���
		public enum IvsParamKey
		{
			ObjectDetectSensitive = 1,//Ŀ����������
			BackgroundUpdateRate = 2,//���������ٶ�
			SceneChangeRatio = 3,//�����仯�����Сֵ
			SuppressLamp = 4,//�Ƿ����Ƴ�ͷ��
			MinObjectSize = 5,//�ܼ�������СĿ���С
			ObjectGenerateRate = 6,//Ŀ�������ٶ�
			MissingObjectHold = 7,//Ŀ����ʧ���������ʱ��
			MaxMissingDistance = 8,//Ŀ����ʧ��������پ���
			ObjectMergeSpeed = 9,//���Ŀ�꽻��ʱ��Ŀ����ں��ٶ�
			RepeatedMotionSuppress = 10,//�ظ��˶�����
			IlluminationChange = 11,//��Ӱ�仯���ƿ���
			TrackOutputMode = 12,//�켣���ģʽ��0-���Ŀ������ģ�1-���Ŀ��ĵײ�����
			EnterChangeHold = 13,//�������仯��ֵ
			ResumeDefaultParam = 255,//�ָ�Ĭ�Ϲؼ��ֲ���
		}

		//����/��ȡ�����ؼ���
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetBehaviorParamKey(int lUserId, int lChannel, uint dwParameterKey, int nValue);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetBehaviorParamKey(int lUserId, int lChannel, uint dwParameterKey, ref int pValue);

		//��ȡ/������Ϊ����Ŀ����ӽӿ�
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetVCADrawMode(int lUserId, int lChannel, ref NetVcaDrawMode lpDrawMode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetVCADrawMode(int lUserId, int lChannel, ref NetVcaDrawMode lpDrawMode);

		//�궨�������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfCalibrationParam
		{
			public byte byPointNum;//��Ч�궨�����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxCalibPt, ArraySubType = UnmanagedType.Struct)]
			public NetDvrCbPoint[] struCBPoint;//�궨����
		}

		//LF˫��������ýṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfCfg
		{
			public uint dwSize;//�ṹ����	
			public byte byEnable;//�궨ʹ��
			public byte byFollowChan;// �����ƵĴ�ͨ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
			public NetDvrLfCalibrationParam struCalParam;//�궨����
		}

		//L/F�ֶ����ƽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrLfManualCtrlInfo
		{
			public NetVcaPoint struCtrlPoint;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//L/FĿ����ٽṹ
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
			public uint dwSize;//�ṹ����
			public byte byTrackMode;//����ģʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//��������0
			[StructLayout(LayoutKind.Explicit)]
			public struct UModeParam
			{
				[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
				[FieldOffset(0)]
				public uint[] dwULen;
				[FieldOffset(0)]
				public NetDvrLfManualCtrlInfo struManualCtrl;//�ֶ����ٽṹ
				[FieldOffset(0)]
				public NetDvrLfTrackTargetInfo struTargetTrack;//Ŀ����ٽṹ
			}
		}

		//˫���������ģʽ���ýӿ�
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_SetLFTrackMode(int lUserId, int lChannel, ref NetDvrLfTrackMode lpTrackMode);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_GetLFTrackMode(int lUserId, int lChannel, ref NetDvrLfTrackMode lpTrackMode);

		//ʶ�𳡾�
		public enum VcaRecognizeScene
		{
			VcaLowSpeedScene = 0,//����ͨ���������շ�վ��С���ſڡ�ͣ������
			VcaHighSpeedScene = 1,//����ͨ�����������ڡ����ٹ�·���ƶ�����)
			VcaMobileCameraScene = 2,//�ƶ������Ӧ�ã� 
		}

		//ʶ������־
		public enum VcaRecognizeResult
		{
			VcaRecognizeFailure = 0,//ʶ��ʧ��
			VcaImageRecognizeSuccess,//ͼ��ʶ��ɹ�
			VcaVideoRecognizeSuccessOfBestLicense,//��Ƶʶ����Ž��
			VcaVideoRecognizeSuccessOfNewLicense,//��Ƶʶ���µĳ���
			VcaVideoRecognizeFinishOfCurLicense,//��Ƶʶ���ƽ���
		}

		

		//��Ƶʶ�𴥷�����
		public enum VcaTriggerType
		{
			InterTrigger = 0,// ģ���ڲ�����ʶ��
			ExterTrigger = 1,// �ⲿ�����źŴ�������Ȧ���״�ֶ������źţ�
		}

		public const int MaxChineseCharNum = 64;    // ������������
		//���ƿɶ�̬�޸Ĳ���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlateParam
		{
			public NetVcaRect struSearchRect;//��������(��һ��)
			public NetVcaRect struInvalidateRect;//��Ч���������������ڲ� (��һ��)
			public ushort wMinPlateWidth;//������С���
			public ushort wTriggerDuration;//��������֡��
			public byte byTriggerType;//����ģʽ, VCA_TRIGGER_TYPE
			public byte bySensitivity;//������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//��������0
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
			public byte[] byCharPriority;// �������ȼ�
		}

		/*wMinPlateWidth:�ò���Ĭ������Ϊ80���أ��ò��������ö��ڳ��ƺ������ӳ���ʶ��˵���ĵ� 
		ʶ����Ӱ�죬������ù�����ô��������г���С���ƾͻ�©ʶ����������г��ƿ���ձ�ϴ󣬿��԰Ѹò��������Դ󣬱��ڼ��ٶ���ٳ��ƵĴ����ڱ�������½�������Ϊ80�� �ڸ�������½�������Ϊ120
		wTriggerDuration �� �ⲿ�����źų���֡�������京���ǴӴ����źſ�ʼʶ���֡��������ֵ�ڵ��ٳ�����������Ϊ50��100�����ٳ�����������Ϊ15��25���ƶ�ʶ��ʱ���Ҳ���ⲿ����������Ϊ15��25��������Ը����ֳ������������
		*/
		//����ʶ������ӽṹ
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlateinfo
		{
			public VcaRecognizeScene eRecogniseScene;//ʶ�𳡾�(���ٺ͸���)
			public NetVcaPlateParam struModifyParam;//���ƿɶ�̬�޸Ĳ���
		}

		//����ʶ�����ò���
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlatecfg
		{
			public uint dwSize;
			public byte byPicProType;//����ʱͼƬ����ʽ 0-������ 1-�ϴ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//����������Ϊ0
			public NetDvrJpegpara struPictureParam;//ͼƬ���ṹ
			public NetVcaPlateinfo struPlateInfo;//������Ϣ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxDays * MaxTimesegment2, ArraySubType = UnmanagedType.Struct)]
			public NetDvrSchedtime[] struAlarmTime;//����ʱ��
			public NetDvrHandleexceptionV30 struHandleType;//����ʽ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxChannumV30, ArraySubType = UnmanagedType.I1)]
			public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
		}

		//����ʶ�����ӽṹ
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
		public struct NetVcaPlateInfo
		{
			public VcaRecognizeResult eResultFlag;//ʶ������־ 
			public VcaPlateType ePlateType;//��������
			public VcaPlateColor ePlateColor;//������ɫ
			public NetVcaRect struPlateRect;//����λ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;//����������Ϊ0 
			public uint dwLicenseLen;//���Ƴ���
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxLicenseLen)]
			public string sLicense;//���ƺ��� 
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MaxLicenseLen)]
			public string sBelieve;//����ʶ���ַ������Ŷȣ����⵽����"��A12345", ���Ŷ�Ϊ10,20,30,40,50,60,70�����ʾ"��"����ȷ�Ŀ�����ֻ��10%��"A"�ֵ���ȷ�Ŀ�������20%
		}

		//���Ƽ����
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaPlateResult
		{
			public uint dwSize;//�ṹ����
			public uint dwRelativeTime;//���ʱ��
			public uint dwAbsTime;//����ʱ��
			public byte byPlateNum;//���Ƹ���
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes1;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MaxPlateNum, ArraySubType = UnmanagedType.Struct)]
			public NetVcaPlateInfo[] struPlateInfo;//������Ϣ�ṹ
			public uint dwPicDataLen;//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes2;//����������Ϊ0 ͼƬ�ĸ߿�
			public IntPtr pImage;//ָ��ͼƬ��ָ��
		}

		//�������ܿ�
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_VCA_RestartLib(int lUserId, int lChannel);

		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLineSegment
		{
			public NetVcaPoint struStartPoint;//��ʾ�߶���ʱ����ʾͷ����
			public NetVcaPoint struEndPoint;//��ʾ�߶���ʱ����ʾ�Ų���
			public float fValue;//�߶�ֵ����λ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//�궨������
		[StructLayout(LayoutKind.Sequential)]
		public struct NetVcaLineSegList
		{
			public uint dwSize;//�ṹ����
			public byte bySegNum;//�궨������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;//��������0
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

		//�ʼ�������� 9000_1.1
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_EmailTest(int lUserId);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindFileByEvent(int lUserId, ref NetDvrSearchEventParam lpSearchEventParam);

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextEvent(int lSearchHandle, ref NetDvrSearchEventRet lpSearchEventRet);


		//2009-8-18 ץ�Ļ�
		public const int PlateInfoLen = 1024;
		public const int PlateNumLen = 16;
		public const int FileNameLen = 256;

		//liscense plate result
		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrPlateRet
		{
			public uint dwSize;//�ṹ����
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PlateNumLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byPlateNum;//���ƺ�
			public byte byVehicleType;// ������
			public byte byTrafficLight;//0-�̵ƣ�1-���
			public byte byPlateColor;//������ɫ
			public byte byDriveChan;//����������
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
			public byte[] byTimeInfo;/*ʱ����Ϣ*///plate_172.6.113.64_20090724155526948_197170484 
			//Ŀǰ��17λ����ȷ��ms:20090724155526948
			public byte byCarSpeed;/*��λkm/h*/
			public byte byCarSpeedH;/*cm/s��8λ*/
			public byte byCarSpeedL;/*cm/s��8λ*/
			public byte byRes;
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = PlateInfoLen - 36, ArraySubType = UnmanagedType.I1)]
			public byte[] byInfo;
			public uint dwPicLen;
		}
		/*ע��������� dwPicLen ���ȵ� ͼƬ ��Ϣ*/

		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE(int lUserId, int lChannel, string pPicFileName, ref NetDvrPlateRet pPlateRet, string pPicBuf, uint dwPicBufLen);

		[StructLayout(LayoutKind.Sequential)]
		public struct NetDvrCcdCfg
		{
			public uint dwSize;//�ṹ����
			public byte byBlc;/*���ⲹ��0-off; 1-on*/
			public byte byBlcMode;/*blc����0-�Զ���1-�ϣ�2-�£�3-��4-�ң�5-�У�ע��������blcΪ on ʱ����Ч*/
			public byte byAwb;/*�Զ���ƽ��0-�Զ�1; 1-�Զ�2; 2-�Զ�����*/
			public byte byAgc;/*�Զ�����0-��; 1-��; 2-��; 3-��*/
			public byte byDayNight;/*��ҹת����0 ��ɫ��1�ڰף�2�Զ�*/
			public byte byMirror;/*����0-��;1-����;2-����;3-����*/
			public byte byShutter;/*����0-�Զ�; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
			public byte byIrCutTime;/*IRCUT�л�ʱ�䣬5, 10, 15, 20, 25*/
			public byte byLensType;/*��ͷ����0-���ӹ�Ȧ; 1-�Զ���Ȧ*/
			public byte byEnVideoTrig;/*��Ƶ����ʹ�ܣ�1-֧�֣�0-��֧�֡���Ƶ����ģʽ����Ƶ�����ٶȰ���byShutter�ٶȣ�ץ��ͼƬ�Ŀ����ٶȰ���byCapShutter�ٶȣ�ץ����ɺ���Զ����ڻ���Ƶģʽ*/
			public byte byCapShutter;/*ץ��ʱ�Ŀ����ٶȣ�1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
			public byte byEnRecognise;/*1-֧��ʶ��0-��֧��ʶ��*/
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
			public uint dwWhiteBalanceMode;/*0�ֶ���ƽ��; 1�Զ���ƽ��1����ΧС��; 2 �Զ���ƽ��2����Χ��2200K-15000K��;3�Զ�����3*/
			public uint dwWhiteBalanceModeRGain;/*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� R����*/
			public uint dwWhiteBalanceModeBGain;/*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� B����*/
			public uint dwExposureMode;/*0 �ֶ��ع� 1�Զ��ع�*/
			public uint dwExposureSet;/* 0-USERSET, 1-�Զ�x2��2-�Զ�4��3-�Զ�81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
			public uint dwExposureUserSet;/* �Զ��Զ����ع�ʱ��*/
			public uint dwExposureTarget;/*�ֶ��ع�ʱ�� ��Χ��Manumal��Ч��΢�룩*/
			public uint dwIrisMode;/*0 �Զ���Ȧ 1�ֶ���Ȧ*/
			public uint dwGainLevel;/*���棺0-100*/
			public uint dwBrightnessLevel;/*0-100*/
			public uint dwContrastLevel;/*0-100*/
			public uint dwSharpnessLevel;/*0-100*/
			public uint dwSaturationLevel;/*0-100*/
			public uint dwHueLevel;/*0-100����������*/
			public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
			public uint dwGammaCorrectionLevel;/*0-100*/
			public uint dwWDREnabled;/*��̬��0 dsibale  1 enable*/
			public uint dwWDRLevel1;/*0-F*/
			public uint dwWDRLevel2;/*0-F*/
			public uint dwWDRContrastLevel;/*0-100*/
			public uint dwDayNightFilterType;/*��ҹ�л���0 day,1 night,2 auto */
			public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(����)*/
			//ģʽ1(����)
			public uint dwBeginTime;	/*0-100*/
			public uint dwEndTime;/*0-100*/
			//ģʽ2
			public uint dwDayToNightFilterLevel;//0-7
			public uint dwNightToDayFilterLevel;//0-7
			public uint dwDayNightFilterTime;//(60��)
			public uint dwBacklightMode;/*���ⲹ��:0 USERSET 1 UP��2 DOWN��3 LEFT��4 RIGHT��5MIDDLE*/
			public uint dwPositionX1;//��X����1��
			public uint dwPositionY1;//��Y����1��
			public uint dwPositionX2;//��X����2��
			public uint dwPositionY2;//��Y����2��
			public uint dwBacklightLevel;/*0x0-0xF*/
			public uint dwDigitalNoiseRemoveEnable; /*����ȥ�룺0 dsibale  1 enable*/
			public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
			public uint dwMirror; /* ����0 Left;1 Right,;2 Up;3Down */
			public uint dwDigitalZoom;/*��������:0 dsibale  1 enable*/
			public uint dwDeadPixelDetect;/*������,0 dsibale  1 enable*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
			public uint[] dwRes;
		}

		public const int NetDvrGetCcdparamcfg = 1067;       //IPC��ȡCCD��������
		public const int NetDvrSetCcdparamcfg = 1068;      //IPC����CCD��������

		//ͼ����ǿ��
		//ͼ����ǿȥ����������
		[StructLayout(LayoutKind.Sequential)]
		public struct TagImageregion
		{
			public uint dwSize;//�ܵĽṹ����
			public ushort wImageRegionTopLeftX;/* ͼ����ǿȥ�������x���� */
			public ushort wImageRegionTopLeftY;/* ͼ����ǿȥ�������y���� */
			public ushort wImageRegionWidth;/* ͼ����ǿȥ������Ŀ� */
			public ushort wImageRegionHeight;/*ͼ����ǿȥ������ĸ�*/
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		//ͼ����ǿ��ȥ�뼶���ȶ���ʹ������
		[StructLayout(LayoutKind.Sequential)]
		public struct TagImagesubparam
		{
			public NetDvrSchedtime struImageStatusTime;//ͼ��״̬ʱ���
			public byte byImageEnhancementLevel;//ͼ����ǿ�ļ���0-7��0��ʾ�ر�
			public byte byImageDenoiseLevel;//ͼ��ȥ��ļ���0-7��0��ʾ�ر�
			public byte byImageStableEnable;//ͼ���ȶ���ʹ�ܣ�0��ʾ�رգ�1��ʾ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
			public byte[] byRes;
		}

		public const int NetDvrGetImageregion = 1062;       //ͼ����ǿ��ͼ����ǿȥ�������ȡ
		public const int NetDvrSetImageregion = 1063;       //ͼ����ǿ��ͼ����ǿȥ�������ȡ
		public const int NetDvrGetImageparam = 1064;       // ͼ����ǿ��ͼ�����(ȥ�롢��ǿ�����ȶ���ʹ��)��ȡ
		public const int NetDvrSetImageparam = 1065;       // ͼ����ǿ��ͼ�����(ȥ�롢��ǿ�����ȶ���ʹ��)����

		[StructLayout(LayoutKind.Sequential)]
		public struct TagImageparam
		{
			public uint dwSize;
			//ͼ����ǿʱ��β������ã����տ�ʼ	
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
		Input:	sDvrip [in] �豸IP��ַ 
				wServerPort [in] �豸�˿ں� 
				sUserName [in] ��¼���û��� 
				sPassword [in] �û����� 
		Output:	lpDeviceInfo [out] �豸��Ϣ 
		Return:	-1��ʾʧ�ܣ�����ֵ��ʾ���ص��û�IDֵ
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern int NET_DVR_Login_V30(string sDvrip, int wDvrPort, string sUserName, string sPassword, ref NetDvrDeviceinfoV30 lpDeviceInfo);

		/*********************************************************
		Function:	NET_DVR_Logout_V30
		Desc:		�û�ע���豸��
		Input:	lUserId [in] �û�ID��
		Output:	
		Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ��
		**********************************************************/
		[DllImport(@"..\bin\HCNetSDK.dll")]
		public static extern bool NET_DVR_Logout_V30(int lUserId);











		#region  ȡ��ģ����ؽṹ��ӿ�

		[StructLayout(LayoutKind.Sequential)]
		public struct PlayInfo
		{
			public int iUserId;      //ע���û�ID
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
			public string strDeviceIP;
			public int iDevicePort;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
			public string strDevAdmin;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
			public string strDevPsd;
			public int iChannel;      //����ͨ����(��0��ʼ)
			public int iLinkMode;   //���λ(31)Ϊ0��ʾ��������Ϊ1��ʾ��������0��30λ��ʾ�������ӷ�ʽ: 0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-����Ƶ�ֿ�(TCP)
			public bool bUseMedia;     //�Ƿ�������ý��
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
			public string strMediaIP; //��ý��IP��ַ
			public int iMediaPort;   //��ý��˿ں�
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


		#region VOD�㲥�ſ�

		public const int WmNeterror = 0x0400 + 102;          //�����쳣��Ϣ
		public const int WmStreamend = 0x0400 + 103;		  //�ļ����Ž���

		public const int FileHead = 0;      //�ļ�ͷ
		public const int VideoIFrame = 1;  //��ƵI֡
		public const int VideoBFrame = 2;  //��ƵB֡
		public const int VideoPFrame = 3;  //��ƵP֡
		public const int VideoBpFrame = 4; //��ƵBP֡
		public const int VideoBbpFrame = 5; //��ƵB֡B֡P֡
		public const int AudioPacket = 10;   //��Ƶ��

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
			public IntPtr sessionHandle;                                    //[in]VOD�ͻ��˾��
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
			public string dvrIP;                                            //	[in]DVR�������ַ
			public uint dvrPort;                                            //	[in]DVR�Ķ˿ڵ�ַ
			public uint channelNum;                                         //  [in]DVR��ͨ����
			public Blocktime startTime;                                     //	[in]��ѯ�Ŀ�ʼʱ��
			public Blocktime stopTime;                                      //	[in]��ѯ�Ľ���ʱ��
			public bool bUseIPServer;                                       //  [in]�Ƿ�ʹ��IPServer 
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string SerialNumber;                                     //  [in]�豸�����к�
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
			public IntPtr sessionHandle;                                    //[in]VOD�ͻ��˾��
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
			public string dvrIP;                                            //	[in]DVR�������ַ
			public uint dvrPort;                                            //	[in]DVR�Ķ˿ڵ�ַ
			public uint channelNum;                                         //  [in]DVR��ͨ����
			public Blocktime startTime;                                     //	[in]��ѯ�Ŀ�ʼʱ��
			public Blocktime stopTime;                                      //	[in]��ѯ�Ľ���ʱ��
			public uint uiUser;
			public bool bUseIPServer;                                       //  [in]�Ƿ�ʹ��IPServer 
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string SerialNumber;                                     //  [in]�豸�����к�

			public VodStreamFrameData streamFrameData;
		}


		[StructLayout(LayoutKind.Sequential)]
		public struct Connparam
		{
			public uint uiUser;
			public ErrorCallback errorCB;
		}


		// �쳣�ص�����
		public delegate void ErrorCallback(IntPtr hSession, uint dwUser, int lErrorType);
		//֡���ݻص�����
		public delegate void VodStreamFrameData(IntPtr hStream, uint dwUser, int lFrameType, IntPtr pBuffer, uint dwSize);

		//ģ���ʼ��
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODServerConnect(string strServerIp, uint uiServerPort, ref IntPtr hSession, ref Connparam struConn, IntPtr hWnd);

		//ģ������
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODServerDisconnect(IntPtr hSession);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStreamSearch(IntPtr pSearchParam, ref IntPtr pSecList);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODDeleteSectionList(IntPtr pSecList);

		// ����ID��ʱ��δ�����ȡ�����
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODOpenStream(IntPtr pOpenParam, ref IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODCloseStream(IntPtr hStream);

		//����ID��ʱ��δ���������
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODOpenDownloadStream(ref Vodopenparam struVodParam, ref IntPtr phStream);

		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODCloseDownloadStream(IntPtr hStream);

		// ��ʼ����������������֡
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStartStreamData(IntPtr phStream);
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODPauseStreamData(IntPtr hStream, bool bPause);
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODStopStreamData(IntPtr hStream);

		// ����ʱ�䶨λ
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODSeekStreamData(IntPtr hStream, IntPtr pStartTime);


		// ����ʱ�䶨λ
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODSetStreamSpeed(IntPtr hStream, int iSpeed);

		// ����ʱ�䶨λ
		[DllImport("PdCssVodClient.dll")]
		public static extern bool VODGetStreamCurrentTime(IntPtr hStream, ref Blocktime pCurrentTime);

		#endregion


		#region ֡������


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
		* function��get a empty port number
		* parameters��
		* return�� 0 - 499 : empty port number
		*          -1      : server is full  			
		* comment��
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern int AnalyzeDataGetSafeHandle();


		/******************************************************************************
		* function��open standard stream data for analyzing
		* parameters��lHandle - working port number
		*             pHeader - pointer to file header or info header
		* return��TRUE or FALSE
		* comment��
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataOpenStreamEx(int iHandle, byte[] pFileHead);


		/******************************************************************************
		* function��close analyzing
		* parameters��lHandle - working port number
		* return��
		* comment��
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataClose(int iHandle);


		/******************************************************************************
		* function��input stream data
		* parameters��lHandle		- working port number
		*			  pBuffer		- data pointer
		*			  dwBuffersize	- data size
		* return��TRUE or FALSE
		* comment��
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataInputData(int iHandle, IntPtr pBuffer, uint uiSize); //byte []


		/******************************************************************************
		* function��get analyzed packet
		* parameters��lHandle		- working port number
		*			  pPacketInfo	- returned structure
		* return��-1 : error
		*          0 : succeed
		*		   1 : failed
		*		   2 : file end (only in file mode)				
		* comment��
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern int AnalyzeDataGetPacket(int iHandle, ref PacketInfo pPacketInfo);  //Ҫ��pPacketInfoת����PACKET_INFO�ṹ


		/******************************************************************************
		* function��get remain data from input buffer
		* parameters��lHandle		- working port number
		*			  pBuf	        - pointer to the mem which stored remain data
		*             dwSize        - size of remain data  
		* return�� TRUE or FALSE				
		* comment��
		******************************************************************************/
		[DllImport("AnalyzeData.dll")]
		public static extern bool AnalyzeDataGetTail(int iHandle, ref IntPtr pBuffer, ref uint uiSize);


		[DllImport("AnalyzeData.dll")]
		public static extern uint AnalyzeDataGetLastError(int iHandle);

		#endregion


		#region ¼���

		public const int DatastreamHead = 0;		//����ͷ
		public const int DatastreamBitblock = 1;		//�ֽ�����
		public const int DatastreamKeyframe = 2;		//�ؼ�֡����
		public const int DatastreamNormalframe = 3;		//�ǹؼ�֡����


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

		//�豸��������
		public const int Regiontype = 0;//��������
		public const int Matrixtype = 11;//����ڵ�
		public const int Devicetype = 2;//�����豸
		public const int Channeltype = 3;//����ͨ��
		public const int Usertype = 5;//�����û�

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
			public byte byDevSequence;//��λ��
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;//MAC��ַ
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//���к�
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = LogInfoLen - SerialnoLen - MacaddrLen - 1)]
			public string sInfo;
		}

		//��Ƶ�ۺ�ƽ̨���
		[StructLayout(LayoutKind.Sequential)]
		public struct TagVedioplatlog
		{
			public byte bySearchCondition;//����������0-����λ��������1-�����к����� 2-��MAC��ַ��������
			public byte byDevSequence;//��λ�ţ�0-79����Ӧ��ϵͳ�Ĳ�λ�ţ�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = SerialnoLen, ArraySubType = UnmanagedType.I1)]
			public byte[] sSerialNumber;//���к�
			[MarshalAs(UnmanagedType.ByValArray, SizeConst = MacaddrLen, ArraySubType = UnmanagedType.I1)]
			public byte[] byMacAddr;//MAC��ַ
		}

		[DllImport(@"..\lib\HCNetSDK.dll")]
		public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NetDvrLogMatrix lpLogData);


		[DllImport(@"..\lib\HCNetSDK.dll")]
		public static extern int NET_DVR_FindDVRLog_Matrix(int iUserId, int lSelectMode, uint dwMajorType, uint dwMinorType, ref TagVedioplatlog lpVedioPlatLog, ref NetDvrTime lpStartTime, ref NetDvrTime lpStopTime);
	}
}
