using Xunit;

namespace Whc.PowerCharts.Tests
{
    public class TanakaMaxHeartRateTests
    {
        [Fact]
        public void Test()
        {
            var rider = new Rider
            {
                AgeYears = 50,
            };
            var strategy = new TanakaMaxHeartRate();
            Assert.Equal(173, strategy.Calculate(rider));
        }
    }
}
