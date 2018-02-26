namespace Whc.PowerCharts
{
    public class PowerZone
    {
        public PowerZoneDefinition Definition { get; set; }
        public double WattsLow { get; set; }
        public double WattsHigh { get; set; }
        public double? HeartRateLow { get; set; }
        public double? HeartRateHigh { get; set; }

        public PowerZone(Rider rider, PowerZoneDefinition zoneDefinition)
        {
            Definition = zoneDefinition;
            WattsLow = Definition.WattsLowPercent * rider.FunctionalThresholdPowerWatts;
            WattsHigh = Definition.WattsHighPercent * rider.FunctionalThresholdPowerWatts;
            HeartRateLow = Utilities.CalculateHeartRate(rider.AgeYears, Definition.HeartRateLowPercent, rider.RestingHeartRateBpm);
            HeartRateHigh = Utilities.CalculateHeartRate(rider.AgeYears, Definition.HeartRateHighPercent, rider.RestingHeartRateBpm);
        }
    }
}