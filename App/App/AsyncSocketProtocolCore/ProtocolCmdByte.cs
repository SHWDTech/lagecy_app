namespace ESMonApp.AsyncSocketProtocolCore
{
    public enum ProtocolCmdByte
    {
        HeartBeat = 0x1F, //心跳包
        
        AdjustTime = 0x5F, //时间校准

        UploadInstNoise = 0x1D, //读出瞬时值
        
        UploadOneSecNoise = 0x6D, //读回1秒值
        
        UploadAllEsParams = 0x08, //读取全部数据

        AutoUploadAllEsParams = 0x27, //读取全部数据

        GetGpsInfo = 0x2F   //读取设备GPS信息
    }
}