using ESMonApp.Common;

namespace ESMonApp.AsyncSocketProtocolCore
{
    public class DevCtrlCmd : ProtocolCmd
    {
        public DevCtrlCmd()
        {
            CmdType = 0xFC;
        }

        //读取CMP
        public void EncodeCmpReadCmd()
        {
            CmdByte = 0x1F;
        }

        //CMP周期设置
        public void EncodeCmpCycleSetCmd(ushort cycleTime)
        {
            CmdByte = 0x2F;
            ushort bufferIndex = 0;

            Utility.Uint16ToBytes(cycleTime, Data, bufferIndex, false);
            bufferIndex += 2;

            DataLen += bufferIndex;
        }

        //CPM停止
        public void EncodeCmStopCmd()
        {
            CmdByte = 0x3F;
        }

        //BG测试开始
        public void EncodeBgTestStartCmd()
        {
            CmdByte = 0x4F;
        }

        //BG测试停止
        public void EncodeBgTestStopCmd()
        {
            CmdByte = 0x5F;
        }

        //BG测试结果
        public void EncodeBgTestResultCmd()
        {
            CmdByte = 0x6F;
        }

        //SPAN测试开始
        public void EncodeSpanTestStartCmd()
        {
            CmdByte = 0x7F;
        }

        //SPAN测试停止
        public void EncodeSpanTestStopCmd()
        {
            CmdByte = 0x8F;
        }

        //SPAN测试结果
        public void EncodeSpanTestResultCmd()
        {
            CmdByte = 0x9F;
        }

        //开关量 OUT1 输出控制
        public void EncodeSetOut1Cmd(byte state)
        {
            ushort bufferIndex = 0;
            CmdByte = 0xAF;

            Data[bufferIndex] = state;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }

        //开关量 OUT2 输出控制
        public void EncodeSetOut2Cmd(byte state)
        {
            ushort bufferIndex = 0;
            CmdByte = 0xBF;

            Data[bufferIndex] = state;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }

        //主动上传瞬时值-开
        public void EncodeUpInstNoiseOpenCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x1D;

            DataLen += bufferIndex;
        }

        //主动上传瞬时值-关
        public void EncodeUpInstNoiseCloseCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x2D;

            DataLen += bufferIndex;
        }

        //上传瞬时值
        public void EncodeUpInstNoiseCmd()
        {
            CmdByte = 0x3D;
        }

        //主动上传1S值-开
        public void EncodeUpOneSecNoiseOpenCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x4D;

            DataLen += bufferIndex;
        }

        //主动上传1s值-关
        public void EncodeUpOneSecNoiseCloseCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x5D;

            DataLen += bufferIndex;
        }

        //上传1s值
        public void EncodeUpOneSecNoiseCmd()
        {
            CmdByte = 0x6D;
        }

        //设为Z计权
        public void EncodeSetZwCmd()
        {
            CmdByte = 0x7D;
        }

        //设为C计权
        public void EncodeSetCwCmd()
        {
            CmdByte = 0x8D;
        }

        //设为A计权
        public void EncodeSetAwCmd()
        {
            CmdByte = 0x9D;
        }

        //设为F计权
        public void EncodeSetFgCmd()
        {
            CmdByte = 0xAD;
        }

        //设为S计权
        public void EncodeSetSgCmd()
        {
            CmdByte = 0xBD;
        }

        //设为I计权
        public void EncodeSetIgCmd()
        {
            CmdByte = 0xCD;
        }

        //写入新的灵敏度级
        //读出仪器当前的灵敏度级
        //读出仪器的校准结果
        //峰值C声级
        //峰值C声级清零

        //风向写入设备地址
        public void EncodeWindDirWriteDevAddrCmd(byte addr)
        {
            ushort bufferIndex = 0;
            CmdByte = 0x1B;

            Data[bufferIndex] = addr;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }

        //风向读取实时数据
        public void EncodeReadWindDirCmd(byte addr)
        {
            ushort bufferIndex = 0;
            CmdByte = 0x2B;

            Data[bufferIndex] = addr;
            bufferIndex += 1;

            Utility.Uint16ToBytes(0x0000, Data, bufferIndex, false);
            bufferIndex += 2;

            Data[bufferIndex] = 0x01;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }

        //风速写入设备地址
        public void EncodeWindSpeedWriteDevAddrCmd(byte addr)
        {
            ushort bufferIndex = 0;
            CmdByte = 0x1A;

            Data[bufferIndex] = addr;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }

        //风向读取实时数据
        public void EncodeReadWindSpeedCmd(byte addr)
        {
            ushort bufferIndex = 0;
            CmdByte = 0x2A;

            Data[bufferIndex] = addr;
            bufferIndex += 1;

            Utility.Uint16ToBytes(0x0000, Data, bufferIndex, false);
            bufferIndex += 2;

            Data[bufferIndex] = 0x01;
            bufferIndex += 1;

            DataLen += bufferIndex;
        }

        //读取温湿度值
        public void EncodeReadEsDataCmd()
        {
            CmdByte = 0x19;
        }

        //开启自动上传模式
        public bool DecodeSetAutoUploadCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x17;

            /*自动上传暂定1分钟*/
            Utility.Uint16ToBytes(0x003C, Data, bufferIndex, false);

            return true;
        }

        //取消自动上传模式
        public bool DecodeCancelAutoUploadCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x17;

            Utility.Uint16ToBytes(0x0000, Data, bufferIndex, false);

            return true;
        }

        public void EncodeReadAllDataCmd()
        {
            ushort bufferIndex = 0;
            CmdByte = 0x08;

            DataLen += bufferIndex;
        }
    }
}