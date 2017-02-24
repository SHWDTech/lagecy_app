using System;
using System.Text;
using ESMonApp.Common;

namespace ESMonApp.AsyncSocketCore
{
    public class DynamicBufferManager
    {
        public byte[] Buffer { get; set; } //存放内存的数组
        public int DataCount { get; set; } //写入数据大小

        public DynamicBufferManager(int bufferSize)
        {
            DataCount = 0;
            Buffer = new byte[bufferSize];
        }

        public int GetDataCount() //获得当前写入的字节数
        {
            return DataCount;
        }

        public int GetReserveCount() //获得剩余的字节数
        {
            return Buffer.Length - DataCount;
        }

        public void Clear(int count) //清理指定大小的数据
        {
            if (count >= DataCount) //如果需要清理的数据大于现有数据大小，则全部清理
            {
                DataCount = 0;
            }
            else
            {
                for (var i = 0; i < DataCount - count; i++) //否则后面的数据往前移
                {
                    Buffer[i] = Buffer[count + i];
                }
                DataCount = DataCount - count;
            }
        }

        public void WriteBuffer(byte[] buffer, int offset, int count)
        {
            if (GetReserveCount() >= count) //缓冲区空间够，不需要申请
            {
                Array.Copy(buffer, offset, Buffer, DataCount, count);
                DataCount = DataCount + count;
            }
            else //缓冲区空间不够，需要申请更大的内存，并进行移位
            {
                var totalSize = Buffer.Length + count - GetReserveCount(); //总大小-空余大小
                var tmpBuffer = new byte[totalSize];
                Array.Copy(Buffer, 0, tmpBuffer, 0, DataCount); //复制以前的数据
                Array.Copy(buffer, offset, tmpBuffer, DataCount, count); //复制新写入的数据
                DataCount = DataCount + count;
                Buffer = tmpBuffer; //替换
            }
        }

        public void WriteBuffer(byte[] buffer)
        {
            WriteBuffer(buffer, 0, buffer.Length);
        }

        public void WriteByte(byte value)
        {
            var temBuffer = new byte[1];
            temBuffer[0] = value;
            WriteBuffer(temBuffer);
        }

        public void WriteShort(short value, bool isLittleEndian)
        {
            //if (isLittleEndian)
            //{
            //    value = System.Net.IPAddress.HostToNetworkOrder(value); //NET是小头结构，网络字节是大头结构，需要客户端和服务器约定好
            //}
            //byte[] tmpBuffer = BitConverter.GetBytes(value);

            var tmpBuffer = Utility.Int16ToBytes(value, isLittleEndian);
            WriteBuffer(tmpBuffer);
        }

        public void WriteInt(int value, bool isLittleEndian)
        {
            //if (isLittleEndian)
            //{
            //    value = System.Net.IPAddress.HostToNetworkOrder(value); //NET是小头结构，网络字节是大头结构，需要客户端和服务器约定好
            //}            
            //byte[] tmpBuffer = BitConverter.GetBytes(value);

            var tmpBuffer = Utility.Int32ToBytes(value, isLittleEndian);
            WriteBuffer(tmpBuffer);
        }

        public void WriteLong(long value, bool isLittleEndian)
        {
            //if (isLittleEndian)
            //{
            //    value = System.Net.IPAddress.HostToNetworkOrder(value); //NET是小头结构，网络字节是大头结构，需要客户端和服务器约定好
            //}
            //byte[] tmpBuffer = BitConverter.GetBytes(value);

            var tmpBuffer = Utility.Int64ToBytes(value, isLittleEndian);
            WriteBuffer(tmpBuffer);
        }

        public void WriteUShort(ushort value, bool isLittleEndian)
        {
            //if (isLittleEndian)
            //{
            //    value = Convert.ToUInt16(System.Net.IPAddress.HostToNetworkOrder((short)value)); //NET是小头结构，网络字节是大头结构，需要客户端和服务器约定好
            //}
            //byte[] tmpBuffer = BitConverter.GetBytes(value);

            var tmpBuffer = Utility.Uint16ToBytes(value, isLittleEndian);
            WriteBuffer(tmpBuffer);
        }

        public void WriteUInt(uint value, bool isLittleEndian)
        {
            //if (isLittleEndian)
            //{
            //    value = Convert.ToUInt32(System.Net.IPAddress.HostToNetworkOrder((int)value)); //NET是小头结构，网络字节是大头结构，需要客户端和服务器约定好
            //}
            //byte[] tmpBuffer = BitConverter.GetBytes(value);

            var tmpBuffer = Utility.Uint32ToBytes(value, isLittleEndian);
            WriteBuffer(tmpBuffer);
        }

        public void WriteULong(ulong value, bool isLittleEndian)
        {
            //if (isLittleEndian)
            //{
            //    value = Convert.ToUInt64(System.Net.IPAddress.HostToNetworkOrder((long)value)); //NET是小头结构，网络字节是大头结构，需要客户端和服务器约定好
            //}

            //byte[] tmpBuffer = BitConverter.GetBytes(value);

            var tmpBuffer = Utility.Uint64ToBytes(value, isLittleEndian);
            WriteBuffer(tmpBuffer);
        }

        public void WriteString(string value) //文本全部转成UTF8，UTF8兼容性好
        {
            var tmpBuffer = Encoding.UTF8.GetBytes(value);
            WriteBuffer(tmpBuffer);
        }
    }
}
