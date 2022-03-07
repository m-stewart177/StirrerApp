namespace StirrerApp
{
    public class RangeConstraint : IConstraint, IRange
    {
        public RangeConstraint(int min, int max)
        {
            Min = min;
            Max = max;
        }

        public bool CheckValue(int value)
        {
            return value >= Min && value <= Max;
        }

        public int Min { get; init; }
        public int Max { get; init; }
    }
}