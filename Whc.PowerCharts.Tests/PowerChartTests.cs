using Xunit;

namespace Whc.PowerCharts.Tests
{
    public class PowerChartTests
    {
        [Fact]
        public void Test()
        {
            var rider = new Rider
            {
                AgeYears = 50,
                FunctionalThresholdPowerWatts = 300,
                Name = "Dave Kehring",
                RestingHeartRateBpm = 53,
                WeightPounds = 220
            };

            var zones = new AndyCogganZones();
            var chart = new PowerChart(rider, zones);
            Assert.Equal(zones.Count, chart.Zones.Count);
        }
    }
}