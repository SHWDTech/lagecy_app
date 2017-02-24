using System;
using System.IO;
using ESMonApp.Common;

namespace ESMonApp.AsyncSocketPublic
{
    class BasicFunc
    {
        public static int MinPacketLength = 34; //单个数据包最小长度是34bytes

        public static bool IsFileInUse(string fileName)
        {
            bool inUse;
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                inUse = false;
            }
            catch
            {
                inUse = true;
            }
            finally
            {
                fs?.Close();
            }
            return inUse;
        }

        public static bool CheckPacket(byte[] buffer, ref int packetLength)
        {
            if (packetLength < 0) throw new ArgumentOutOfRangeException(nameof(packetLength));
            var flag = false;
            var bufferIndex = 0;

            if (buffer[bufferIndex] == 0xAA)
            {
                bufferIndex += 29;

                int dataLen = Utility.BytesToUint16(buffer, bufferIndex, false);
                bufferIndex += 2 + dataLen + 2; //长度2bytes；数据部分的长度dataLength bytes；校验码2bytes

                if (buffer[bufferIndex] == 0xDD)
                {
                    flag = true;
                }

                bufferIndex++;
            }

            packetLength = bufferIndex;

            return flag;
        }

        
    }
}
