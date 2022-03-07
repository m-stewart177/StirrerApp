using System;

namespace StirrerApp
{
    public abstract class BaseStirrer
    {
        private int _rpm;

        protected abstract bool CheckRpm(int value);
        public string Name { get; protected init; }

        public int Rpm
        {
            get => _rpm;
            set
            {
                if (!CheckRpm(value))
                {
                    throw new ArgumentOutOfRangeException(nameof(Rpm));
                }
                _rpm = value;
                Console.WriteLine($"{Name}: RPM changed to {value}");
            }
        }

        public StirrerMode Mode { get; set; }
    }
}