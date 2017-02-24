namespace ESMonApp.AsyncSocketProtocolCore
{
    public class TimeSyncCmd : ProtocolCmd
    {
        public TimeSyncCmd()
        {
            CmdType = 0xFB;
            CmdByte = 0x1F;
        }

        //public void EncodeCmd(RTCTime model)
        //{
        //    UInt16 bufferIndex = 0;

        //    Array.Copy(Utility.UINT16ToBytes(model.Year, false), 0, Data, bufferIndex, 2);
        //    bufferIndex += 2;

        //    Data[bufferIndex] = model.Month;
        //    bufferIndex += 1;

        //    Data[bufferIndex] = model.Day;
        //    bufferIndex += 1;

        //    Data[bufferIndex] = model.Hour;
        //    bufferIndex += 1;

        //    Data[bufferIndex] = model.Min;
        //    bufferIndex += 1;

        //    Data[bufferIndex] = model.Sec;
        //    bufferIndex += 1;

        //    DataLen += bufferIndex;

        //    return;
        //}
    }
}