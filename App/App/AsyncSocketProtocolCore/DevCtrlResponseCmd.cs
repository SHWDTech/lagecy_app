using ESMonApp.Common;

namespace ESMonApp.AsyncSocketProtocolCore
{
    public class DevCtrlResponseCmd : ProtocolCmd
    {
        public DevCtrlResponseCmd()
        {
            CmdType = 0xFD;
        }

        public bool DecodeCmpReadCmd(ref double cmp)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x1F)
            {
                return false;
            }

            if (DataLen != 2)
            {
                return false;
            }

            cmp = Utility.BytesToUint16(Data, bufferIndex, false) / 1000.0;

            return true;
        }

        public bool DecodeCmpCycleSetCmd(ref ushort cycleTime)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x2F)
            {
                return false;
            }

            if (DataLen != 2)
            {
                return false;
            }

            cycleTime = Utility.BytesToUint16(Data, bufferIndex, false);

            return true;
        }

        //CPM停止
        public bool DecodeCmStopCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x3F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //BG测试开始
        public bool DecodeBgTestStartCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x4F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //BG测试停止
        public bool DecodeBgTestStopCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x5F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //BG测试结果
        public bool DecodeBgTestResultCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x6F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //SPAN测试开始
        public bool DecodeSpanTestStartCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x7F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //SPAN测试停止
        public bool DecodeSpanTestStopCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x8F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //SPAN测试结果
        public bool DecodeSpanTestResultCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x9F)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //开关量 OUT1 输出控制
        public bool DecodeSetOut1Cmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0xAF)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //开关量 OUT2 输出控制
        public bool DecodeSetOut2Cmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0xBF)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //主动上传瞬时值-开
        public bool DecodeUpInstNoiseOpenCmd(ref double noise)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x1D)
            {
                return false;
            }

            if (DataLen != 2)
            {
                return false;
            }

            noise = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;

            return true;
        }

        //主动上传瞬时值-关
        public bool DecodeUpInstNoiseCloseCmd()
        {
            if (CmdByte != 0x2D)
            {
                return false;
            }

            return DataLen == 0;
        }

        //上传瞬时值
        public bool DecodeUpInstNoiseCmd(ref double noise)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x3D)
            {
                return false;
            }

            if (DataLen != 2)
            {
                return false;
            }

            noise = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;

            return true;
        }

        //主动上传1S值-开
        public bool DecodeUpOneSecNoiseOpenCmd(ref double noise)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x4D)
            {
                return false;
            }

            if (DataLen != 2)
            {
                return false;
            }

            noise = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;

            return true;
        }

        //主动上传1s值-关
        public bool DecodeUpOneSecNoiseCloseCmd()
        {
            if (CmdByte != 0x5D)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //上传1s值
        public bool DecodeUpOneSecNoiseCmd(ref double noise)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x6D)
            {
                return false;
            }

            if (DataLen != 2)
            {
                return false;
            }

            noise = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;

            return true;
        }

        //设为Z计权
        public bool DecodeSetZwCmd()
        {
            if (CmdByte != 0x7D)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //设为C计权
        public bool DecodeSetCwCmd()
        {
            if (CmdByte != 0x8D)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //设为A计权
        public bool DecodeSetAwCmd()
        {
            if (CmdByte != 0x9D)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //设为F计权
        public bool DecodeSetFgCmd()
        {
            if (CmdByte != 0xAD)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //设为S计权
        public bool DecodeSetSgCmd()
        {
            if (CmdByte != 0xBD)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //设为I计权
        public bool DecodeSetIgCmd()
        {
            if (CmdByte != 0xCD)
            {
                return false;
            }

            if (DataLen != 0)
            {
                return false;
            }

            return true;
        }

        //写入新的灵敏度级
        //读出仪器当前的灵敏度级
        //读出仪器的校准结果
        //峰值C声级
        //峰值C声级清零

        //风向写入设备地址
        public bool DecodeWindDirWriteDevAddrCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x1B)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //风向读取实时数据
        public bool DecodeReadWindDirCmd(ref byte addr, ref ushort windDir)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x2B)
            {
                return false;
            }

            if (DataLen != 3)
            {
                return false;
            }

            addr = Data[bufferIndex];
            bufferIndex += 1;

            windDir = Utility.BytesToUint16(Data, bufferIndex, false);

            return true;
        }

        //风速写入设备地址
        public bool DecodeWindSpeedWriteDevAddrCmd(ref byte state)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x1A)
            {
                return false;
            }

            if (DataLen != 1)
            {
                return false;
            }

            state = Data[bufferIndex];

            return true;
        }

        //风向读取实时数据
        public bool DecodeReadWindSpeedCmd(ref byte addr, ref double windSpeed)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x2A)
            {
                return false;
            }

            if (DataLen != 3)
            {
                return false;
            }

            addr = Data[bufferIndex];
            bufferIndex += 1;

            windSpeed = Utility.BytesToUint16(Data, bufferIndex, false) / 10.0;

            return true;
        }

        //读取温湿度值
        public bool DecodeReadEsDataCmd(ref double temperature, ref double humidity)
        {
            var bufferIndex = 0;

            if (CmdByte != 0x19)
            {
                return false;
            }

            if (DataLen != 4)
            {
                return false;
            }

            temperature = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;
            bufferIndex += 2;

            humidity = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;

            return true;
        }

        public bool DecodeReadAllDataCmd(ref EsData model)
        {
            var bufferIndex = 0;

            CmdByte = 0x27;

            if (DataLen != 26)
            {
                return false;
            }

            var flag = Utility.BytesToUint16(Data, bufferIndex, false);
            bufferIndex += 2;

            model.PmState = (byte)((flag >> 5) & 0x01);
            model.CmpState = (byte)((flag >> 4) & 0x01);
            model.NoiseState = (byte)((flag >> 3) & 0x01);
            model.WindDirState = (byte)((flag >> 2) & 0x01);
            model.WindSpeedState = (byte)((flag >> 1) & 0x01);
            model.EsState = (byte)(flag & 0x01);

            model.Pm25 = Utility.BytesToInt32(Data, bufferIndex, false);
            bufferIndex += 4;

            model.Pm100 = Utility.BytesToInt32(Data, bufferIndex, false);
            bufferIndex += 4;

            model.Cmp = Utility.BytesToInt32(Data, bufferIndex, false);
            bufferIndex += 4;

            model.Noise = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;
            bufferIndex += 2;

            //addr
            bufferIndex += 1;

            model.WindDir = Utility.BytesToUint16(Data, bufferIndex, false);
            bufferIndex += 2;

            //addr
            bufferIndex += 1;

            model.WindSpeed = Utility.BytesToUint16(Data, bufferIndex, false) / 10.0;
            bufferIndex += 2;

            model.Temperature = (sbyte)Data[bufferIndex] + (sbyte)Data[bufferIndex + 1] / 10.0;
            bufferIndex += 2;

            model.Humidity = Data[bufferIndex] + Data[bufferIndex + 1] / 100.0;

            return true;
        }

        //自动上传模式配置响应
        public bool DecodeSetAutoUploadEsParamsCmd(ref ushort cycleTime)
        {
            var bufferIndex = 0;

            CmdByte = 0x17;

            if (DataLen != 2)
            {
                return false;
            }

            cycleTime = Utility.BytesToUint16(Data, bufferIndex, false);

            return true;
        }

        //自动上报数据
        public bool DecodeAutoUploadEsParamsCmd(ref EsData model)
        {
            var bufferIndex = 0;

            CmdByte = 0x27;

            if (DataLen != 30)
            {
                return false;
            }

            var flag = Utility.BytesToUint16(Data, bufferIndex, false);
            bufferIndex += 2;

            model.PmState = (byte)((flag >> 14) & 0x01);
            model.CmpState = (byte)((flag >> 13) & 0x01);
            model.NoiseState = (byte)((flag >> 12) & 0x01);
            model.WindDirState = (byte)((flag >> 11) & 0x01);
            model.WindSpeedState = (byte)((flag >> 10) & 0x01);
            model.EsState = (byte)((flag >> 9) & 0x01);

            model.Pm25 = Utility.BytesToInt32(Data, bufferIndex, false);
            bufferIndex += 4;

            model.Pm100 = Utility.BytesToInt32(Data, bufferIndex, false);
            bufferIndex += 4;

            model.Cmp = Utility.BytesToInt32(Data, bufferIndex, false);
            bufferIndex += 4;

            model.Noise = Data[bufferIndex] + Data[bufferIndex + 1] / 10.0;
            bufferIndex += 2;

            //addr
            bufferIndex += 1;

            model.WindDir = (ushort)(Utility.BytesToUint16(Data, bufferIndex, false) / 10);
            bufferIndex += 2;

            //addr
            bufferIndex += 1;

            model.WindSpeed = Utility.BytesToUint16(Data, bufferIndex, false) / 10.0;
            bufferIndex += 2;

            model.Temperature = (sbyte)Data[bufferIndex] + (sbyte)Data[bufferIndex + 1] / 100.0;
            bufferIndex += 2;

            model.Humidity = Data[bufferIndex] + Data[bufferIndex + 1] / 100.0;

            return true;
        }
    }
}