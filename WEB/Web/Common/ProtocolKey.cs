
using System.Collections.Generic;
namespace Web
{
    public class ProtocolConst
    {        
        public static int InitBufferSize = 1024; //解析命令初始缓存大小        
        public static int ReceiveBufferSize = 1024; //IOCP接收数据缓存大小，设置过小会造成事件响应增多，设置过大会造成内存占用偏多
    }
    
    public enum CommStatus
    {
        DisConnect,
        Connect,
        Busy,
        Free
    }

    public enum ProtocolCmdType
    {
        SysComm = 0xF9, //注册命令
        ModuleCfg = 0xFA,
        ModuleCtrl = 0xFB,
        DevCtrl = 0xFC,
        DevResponse = 0xFE
    }
    
    public enum ProtocolCmdByte
    {
        HeartBeat = 0x1F, //心跳包
        
        AdjustTime = 0x1F, //时间校准

        UploadInstNoise = 0x1D, //读出瞬时值
        UploadOneSecNoise = 0x4D, //读回1秒值
    }
}
