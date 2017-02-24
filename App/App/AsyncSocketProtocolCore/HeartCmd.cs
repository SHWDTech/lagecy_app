namespace ESMonApp.AsyncSocketProtocolCore
{
    public class HeartCmd : ProtocolCmd
    {
        public HeartCmd()
        {
            CmdType = 0xF9;
            CmdByte = 0x1F;
        }
    }
}