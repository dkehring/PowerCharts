using Xunit;

namespace Whc.PowerCharts.Tests
{
    public class UtilitiesTests
    {
        [Fact]
        public void AgePredicatedMaxHeartRate()
        {
            var max = Utilities.AgePredictedMaxHeartRate(50);
            Assert.Equal(173, max);
        }

        [Fact]
        public void CaluculateHeartRate_ReturnsNull_ForNullTargetPercent()
        {
            var hr = Utilities.CalculateHeartRate(50, null, 60);
            Assert.False(hr.HasValue);
        }

        [Fact]
        public void CaluculateHeartRate()
        {
            var hr = Utilities.CalculateHeartRate(50, .6, 60);
            Assert.Equal(127.8, hr);
        }
    }
}
