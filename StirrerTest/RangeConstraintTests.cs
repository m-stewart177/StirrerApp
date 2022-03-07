using Xunit;

using StirrerApp;

namespace StirrerTest
{
    public class RangeConstraintTests
    {
        [Fact]
        public void CheckShouldPassForValueInRange()
        {
            var rangeConstraint = new RangeConstraint(100, 5000);

            var result = rangeConstraint.CheckValue(2500);
            
            Assert.True(result);
        }

        [Fact]
        public void CheckShouldFailForValueLessThanMinimum()
        {
            var rangeConstraint = new RangeConstraint(100, 5000);

            var result = rangeConstraint.CheckValue(50);
            
            Assert.False(result);
        }

        [Fact]
        public void CheckShouldFailForValueMoreThanMaximum()
        {
            var rangeConstraint = new RangeConstraint(100, 5000);

            var result = rangeConstraint.CheckValue(7500);
            
            Assert.False(result);
        }
        
    }
}