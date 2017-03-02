using System;
using ESMonApp.Common;
using ESMonitor.Model;

namespace ESMonApp.AsyncSocketProtocolCore
{
    public class ProtocolCmd
    {
        public ProtocolCmd()
        {
            NodeId = 0;
            CmdType = 0;
            CmdByte = 0;
            SrcAddr = 0;
            DstAddr = 0;
            DataLen = 0;
        }

        #region Model

        /// <summary>
        /// 节点Id
        /// </summary>
        public uint NodeId { set; get; }

        /// <summary>
        /// 命令码
        /// </summary>
        public byte CmdType { set; get; }

        /// <summary>
        /// 命令码
        /// </summary>
        public byte CmdByte { set; get; }

        /// <summary>
        /// 密码
        /// </summary>
        public byte[] Pwd { set; get; } = new byte[8];

        /// <summary>
        /// 描述
        /// </summary>
        public byte[] Description { set; get; } = new byte[12];

        /// <summary>
        /// 源地址
        /// </summary>
        public byte SrcAddr { set; get; }

        /// <summary>
        /// 目标地址
        /// </summary>
        public byte DstAddr { set; get; }

        /// <summary>
        /// 发送数据
        /// </summary>
        public byte[] Data { set; get; } = new byte[512];

        /// <summary>
        /// 发送数据长度
        /// </summary>
        public ushort DataLen { set; get; }

        public ushort PacketLen 
            => (ushort)(DataLen + 34);

        #endregion

        #region 命令
        public void EncodeFrame(ref byte[] buffer, ref int bufferLen)
        {
            if (bufferLen < 0) throw new ArgumentOutOfRangeException(nameof(bufferLen));

            ushort bufferIndex = 0;

            buffer[bufferIndex] = 0xAA;
            bufferIndex += 1;

            buffer[bufferIndex] = CmdType;
            bufferIndex += 1;

            buffer[bufferIndex] = CmdByte;
            bufferIndex += 1;

            Array.Copy(Pwd, 0, buffer, bufferIndex, 8);
            bufferIndex += 8;

            Utility.Uint32ToBytes(NodeId, buffer, bufferIndex, false);
            bufferIndex += 4;

            Array.Copy(Description, 0, buffer, bufferIndex, 12);
            bufferIndex += 12;

            SrcAddr = 0x00;

            buffer[bufferIndex] = SrcAddr;
            bufferIndex += 1;

            DstAddr = 0x01;
            buffer[bufferIndex] = DstAddr;
            bufferIndex += 1;

            Utility.Uint16ToBytes(DataLen, buffer, bufferIndex, false);
            bufferIndex += 2;

            Array.Copy(Data, 0, buffer, bufferIndex, DataLen);
            bufferIndex += DataLen;

            //CRC 
            var crc = Crc.GetUsmbcrc16(buffer, bufferIndex);

            Utility.Uint16ToBytes(crc, buffer, bufferIndex, false);
            //Array.Copy(buffer, bufferIndex, Utility.UINT16ToBytes(crc, false), 0, 2);
            bufferIndex += 2;

            buffer[bufferIndex] = 0xDD;
            bufferIndex += 1;

            bufferLen = bufferIndex;
        }

        public bool DecodeFrame(byte[] buffer, int bufferLen)
        {
            ushort bufferIndex = 0;

            if (buffer[bufferIndex] != 0xAA)
            {
                return false;
            }
            bufferIndex += 1;

            CmdType = buffer[bufferIndex];
            bufferIndex += 1;

            CmdByte = buffer[bufferIndex];
            bufferIndex += 1;

            Array.Copy(buffer, bufferIndex, Pwd, 0, 8);
            bufferIndex += 8;

            NodeId = Utility.BytesToUint32(buffer, bufferIndex, false);
            bufferIndex += 4;

            Array.Copy(buffer, bufferIndex, Description, 0, 12);
            bufferIndex += 12;

            SrcAddr = buffer[bufferIndex];
            bufferIndex += 1;

            DstAddr = buffer[bufferIndex];
            bufferIndex += 1;

            DataLen = Utility.BytesToUint16(buffer, bufferIndex, false);
            bufferIndex += 2;

            Array.Copy(buffer, bufferIndex, Data, 0, DataLen);
            bufferIndex += DataLen;

            var crc1 = Crc.GetUsmbcrc16(buffer, bufferIndex);

            var crc2 = Utility.BytesToUint16(buffer, bufferIndex, false);
            bufferIndex += 2;

            if (crc1 != crc2)
            {
                return false;
            }

            if (buffer[bufferIndex] != 0xDD)
            {
                return false;
            }

            bufferIndex += 1;

            if (bufferLen != bufferIndex)
            {
                return false;
            }

            return true;
        }

        public virtual void EncodeCmd()
        {
        }

        public void DecodeCmd()
        {
        }

        public void GetTaskModel(int devId, ref Tasks model)
        {
            model.CmdType = CmdType;
            model.CmdByte = CmdByte;
            model.DevId = devId;

            model.Status = 0;
            model.Length = PacketLen;
            var buffer = new byte[PacketLen];
            var bufferLen = 0;

            EncodeFrame(ref buffer, ref bufferLen);
            model.Data = buffer;

            model.SendTime = DateTime.Now;
        }
        #endregion
    }

    #region 心跳命令

    #endregion


    #region 时间校准

    #endregion

    #region 设备控制命令

    #endregion

    #region 仪器上报&应答信息

    #endregion


}
