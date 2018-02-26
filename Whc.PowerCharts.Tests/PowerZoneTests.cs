using Xunit;

namespace Whc.PowerCharts.Tests
{
    public class PowerZoneTests
    {
        private PowerZoneDefinition TestZone()
        {
            return new PowerZoneDefinition
            {
                HeartRateHighPercent = .5,
                HeartRateLowPercent = .4,
                RpeHigh = 4,
                RpeLow = 3,
                WattsHighPercent = .7,
                WattsLowPercent = .6,
                Zone = 1,
                Description = "Zone 1"
            };
        }

        private Rider TestRider()
        {
            return new Rider
            {
                AgeYears = 50,
                FunctionalThresholdPowerWatts = 300,
                Name = "Dave Kehring",
                RestingHeartRateBpm = 53,
                WeightPounds = 220
            };
        }

        [Fact]
        public void HeartRateHigh()
        {
            var powerZone = new PowerZone(TestRider(), TestZone());
            Assert.Equal(113, powerZone.HeartRateHigh);
        }

        [Fact]
        public void HeartRateLow()
        {
            var powerZone = new PowerZone(TestRider(), TestZone());
            Assert.Equal(101, powerZone.HeartRateLow);
        }

        [Fact]
        public void WattsHigh()
        {
            var powerZone = new PowerZone(TestRider(), TestZone());
            Assert.Equal(210, powerZone.WattsHigh);
        }

        [Fact]
        public void WattsLow()
        {
            var powerZone = new PowerZone(TestRider(), TestZone());
            Assert.Equal(180, powerZone.WattsLow);
        }
    }
}