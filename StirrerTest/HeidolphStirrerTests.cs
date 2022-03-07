using System;
using Xunit;

using StirrerApp;

namespace StirrerTest
{
    public class HeidolphStirrerTests
    {
        private const string TestName = "HeidolphTest";
        private readonly RangeConstraint _rangeConstraint = new(200, 2000);
        
        [Fact]
        public void NameShouldBeSetOnCreation()
        {

            var testStirrer = new HeidolphStirrer(TestName, _rangeConstraint);
            Assert.Equal(TestName, testStirrer.Name);
        }

        [Fact]
        public void ModeCanBeSetOnCreation()
        {
            var testStirrer = new HeidolphStirrer(TestName, _rangeConstraint, StirrerMode.Connected);
            Assert.Equal(StirrerMode.Connected, testStirrer.Mode);
        }

        [Fact]
        public void WhenRpmInRangeShouldBeAbleToSetValue()
        {
            var testStirrer = new HeidolphStirrer(TestName, _rangeConstraint)
            {
                Rpm = 1000
            };
            Assert.Equal(1000, testStirrer.Rpm);
        }

        [Fact]
        public void WhenRpmTooLowShouldThrowException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var testStirrer = new HeidolphStirrer(TestName, _rangeConstraint)
                {
                    Rpm = 100
                };
            });
        }

        [Fact]
        public void WhenRpmTooHighShouldThrowException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var testStripper = new HeidolphStirrer(TestName, _rangeConstraint)
                {
                    Rpm = 3000
                };
            });
        }
    }
}