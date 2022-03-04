using System;
using Xunit;

using StirrerApp;

namespace StirrerTest
{
    public class IkaStirrerTests
    {
        private const string testName = "IkaStirrerTest";
        [Fact]
        public void NameShouldBeSetOnCreation()
        {

            var testStirrer = new IkaStirrer(testName);
            Assert.Equal(testName, testStirrer.Name);
        }

        [Fact]
        public void ModeCanBeSetOnCreation()
        {
            var testStirrer = new IkaStirrer(testName, StirrerMode.Connected);
            Assert.Equal(StirrerMode.Connected, testStirrer.Mode);
        }
        
        [Fact]
        public void WhenRpmInRangeShouldBeAbleToSetValue()
        {
            var testStirrer = new IkaStirrer(testName);
            testStirrer.Rpm = 1000;
            Assert.Equal(1000, testStirrer.Rpm);
        }

        [Fact]
        public void WhenRpmTooLowShouldThrowException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var testStirrer = new IkaStirrer(testName);
                testStirrer.Rpm = 100;
            });
        }

        [Fact]
        public void WhenRpmTooHighShouldThrowException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var testStripper = new IkaStirrer(testName);
                testStripper.Rpm = 3000;
            });
        }

        
    }
}