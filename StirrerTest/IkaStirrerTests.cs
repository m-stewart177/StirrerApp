using System;
using Xunit;

using StirrerApp;

namespace StirrerTest
{
    public class IkaStirrerTests
    {
        private const string TestName = "IkaStirrerTest";
        private readonly RangeConstraint _rangeConstraint = new(300, 1500);

        [Fact]
        public void NameShouldBeSetOnCreation()
        {

            var testStirrer = new IkaStirrer(TestName, _rangeConstraint);
            Assert.Equal(TestName, testStirrer.Name);
        }

        [Fact]
        public void ModeCanBeSetOnCreation()
        {
            var testStirrer = new IkaStirrer(TestName, _rangeConstraint, StirrerMode.Connected);
            Assert.Equal(StirrerMode.Connected, testStirrer.Mode);
        }
        
        [Fact]
        public void WhenRpmInRangeShouldBeAbleToSetValue()
        {
            var testStirrer = new IkaStirrer(TestName, _rangeConstraint)
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
                var testStirrer = new IkaStirrer(TestName, _rangeConstraint)
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
                var testStripper = new IkaStirrer(TestName, _rangeConstraint)
                {
                    Rpm = 3000
                };
            });
        }

        
    }
}