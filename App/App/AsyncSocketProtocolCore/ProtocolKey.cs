
namespace ESMonApp
{
    public class ProtocolConst
    {        
        public static int InitBufferSize = 256; //解析命令初始缓存大小        
        public static int ReceiveBufferSize = 256; //IOCP接收数据缓存大小，设置过小会造成事件响应增多，设置过大会造成内存占用偏多
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
        SysComm = 0xF9, //注册命令,也就是心跳包命令
        ModuleCfg = 0xFA,
        ModuleCtrl = 0xFB,
        DevCtrl = 0xFC,
        DevResponse = 0xFD
    }
    
    public enum ProtocolCmdByte
    {
        HeartBeat = 0x1F, //心跳包
        
        AdjustTime = 0x1F, //时间校准

        UploadInstNoise = 0x1D, //读出瞬时值
        
        UploadOneSecNoise = 0x6D, //读回1秒值
        
        UploadAllESParams = 0x08, //读取全部数据

        AutoUploadAllESParams = 0x27, //读取全部数据

        GetGpsInfo = 0x2F   //读取设备GPS信息
    }
}
