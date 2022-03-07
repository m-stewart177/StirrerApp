namespace StirrerApp
{
    public class IkaStirrer : BaseStirrer
    {
        private const int MinRpm = 300;
        private const int MaxRpm = 1500;
        private const int DefaultRpm = MinRpm;
        
        public IkaStirrer(string name, StirrerMode mode = StirrerMode.Standby)
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