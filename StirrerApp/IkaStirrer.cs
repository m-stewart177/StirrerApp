using System;

namespace StirrerApp
{
    public class IkaStirrer : BaseStirrer
    {
        private int _rpm;
        private const int _minRpm = 300;
        private const int _maxRpm = 1500;
        private const int _defaultRpm = _minRpm;

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

        public IkaStirrer(string name, StirrerMode mode = StirrerMode.Standby)
        {
            Name = name;
            Mode = mode;
        }
    }
}