using System;

namespace StirrerApp
{
    public class HeidolphStirrer : BaseStirrer
    {
        private const int MinRpm = 200;
        private const int MaxRpm = 2000;
        private const int DefaultRpm = MinRpm;
        
        public HeidolphStirrer(string name, StirrerMode mode = StirrerMode.Standby)
        {
            Name = name;
            Mode = mode;
            Rpm = DefaultRpm;
        }

        protected override bool CheckRpm(int value)
        {
            return value is >= MinRpm and <= MaxRpm;
        }
    }
}