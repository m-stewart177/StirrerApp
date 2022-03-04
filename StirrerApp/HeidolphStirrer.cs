using System;

namespace StirrerApp
{
    public class HeidolphStirrer : BaseStirrer
    {
        private const int _minRpm = 200;
        private const int _maxRpm = 2000;
        private const int _defaultRpm = _minRpm;

        private int _rpm;

        public override int Rpm
        {
            get => _rpm;
            set
            {
                if (value < _minRpm || value > _maxRpm)
                {
                    throw new ArgumentOutOfRangeException(nameof(Rpm));
                }
                _rpm = value;
                Console.WriteLine($"{{Name}}: Rpm set to {_rpm}");
            }
        }

        public HeidolphStirrer(string name, StirrerMode mode = StirrerMode.Standby)
        {
            Name = name;
            Mode = mode;
            _rpm = _defaultRpm;
        }
    }
}