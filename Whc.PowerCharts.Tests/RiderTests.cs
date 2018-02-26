using Xunit;

namespace Whc.PowerCharts.Tests
{
    public class RiderTests
    {
        [Fact]
        public void WeightKgConversion()
        {
            var rider = new Rider { WeightPounds = 220 };
            Assert.Equal(100.0, rider.WeightKgs);
        }

        [Fact]
        public void WattsPerKg_Zero_IfNoWeight()
        {
            var rider = new Rider { WeightPounds = 0 };
            Assert.Equal(0, rider.WattsPerKilogram);
        }

        [Fact]
        public void WattsPerKg()
        {
            var rider = new Rider { WeightPounds = 220, FunctionalThresholdPowerWatts = 300 };
            Assert.Equal(3.0, rider.WattsPerKilogram);
        }
    }
}