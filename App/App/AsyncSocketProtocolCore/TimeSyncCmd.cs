using System;

namespace ESMonApp.AsyncSocketProtocolCore
{
    public class TimeSyncCmd : ProtocolCmd
    {
        public TimeSyncCmd()
        {
            CmdType = (byte)ProtocolCmdType.ModuleCfg;
            CmdByte = (byte)ProtocolCmdByte.AdjustTime;
        }

        public void EncodeCmd(DateTime date)
        {
            ushort bufferIndex = 0;

            Data[bufferIndex] = (byte)(date.Year - 2000);
            bufferIndex += 1;

            Data[bufferIndex] = (byte)date.Month;
            bufferIndex += 1;

            Data[bufferIndex] = (byte)date.Day;
            bufferIndex += 1;

            Data[bufferIndex] = (byte)date.Hour;
            bufferIndex += 1;

            Data[bufferIndex] = (byte)date.Minute;
            bufferIndex += 1;

            Data[bufferIndex] = (byte)date.Second;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }
    }
}