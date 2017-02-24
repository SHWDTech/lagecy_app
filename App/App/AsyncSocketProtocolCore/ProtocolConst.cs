
namespace ESMonApp.AsyncSocketProtocolCore
{
    public class ProtocolConst
    {        
        public static int InitBufferSize = 256; //解析命令初始缓存大小        
        public static int ReceiveBufferSize = 256; //IOCP接收数据缓存大小，设置过小会造成事件响应增多，设置过大会造成内存占用偏多
    }
}
