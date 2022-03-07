namespace StirrerApp
{
    public class IkaStirrer : BaseStirrer
    {
        private const int MinRpm = 300;
        private const int MaxRpm = 1500;
        private const int DefaultRpm = 300;

        private IConstraint _rpmConstraint;
        
        public IkaStirrer(string name, IConstraint rpmConstraint, StirrerMode mode = StirrerMode.Standby)
        {
            _rpmConstraint = rpmConstraint;
            Name = name;
            Mode = mode;

            var rpmRange = rpmConstraint as IRange;
            Rpm = rpmRange?.Min ?? DefaultRpm;
        }

        protected override bool CheckRpm(int value)
        {
            return _rpmConstraint.CheckValue(value);
        }
    }
}