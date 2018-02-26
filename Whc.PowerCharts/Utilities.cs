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
    }
}