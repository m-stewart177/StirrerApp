namespace StirrerApp
{
    public class HeidolphStirrer : BaseStirrer
    {
        private const int DefaultRpm = 200;

        private IConstraint _rpmConstraint;
        
        public HeidolphStirrer(string name, IConstraint rpmConstraint, StirrerMode mode = StirrerMode.Standby)
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