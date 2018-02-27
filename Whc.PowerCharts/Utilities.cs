namespace Whc.PowerCharts
{
    public static class Utilities
    {
        public static double AgePredictedMaxHeartRate(int age)
        {
            return (208 - (0.7 * age));
        }

        public static double? CalculateHeartRate(int age, double? targetPercent, int restingHeartRate)
        {
            if (targetPercent.HasValue == false) return new double?();
            return ((AgePredictedMaxHeartRate(age) - restingHeartRate) * targetPercent) + restingHeartRate;
        }

        public static double? CalculateHeartRate(IMaxHeartRateStrategy maxHrStrategy, 
            Rider rider,
            double? targetPercent)
        {
            if (targetPercent.HasValue == false) return new double?();
            return ((maxHrStrategy.Calculate(rider) - rider.RestingHeartRateBpm) * targetPercent) + rider.RestingHeartRateBpm;
        }
    }
}