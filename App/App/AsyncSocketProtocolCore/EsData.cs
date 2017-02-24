namespace ESMonApp.AsyncSocketProtocolCore
{
    public struct EsData
    {
        public byte PmState;
        public double Pm25;
        public double Pm100;
        public byte CmpState;
        public double Cmp;
        public byte NoiseState;
        public double Noise;
        public byte WindDirState;
        public ushort WindDir;
        public byte WindSpeedState;
        public double WindSpeed;
        public byte EsState;
        public double Temperature;
        public double Humidity;
    };
}