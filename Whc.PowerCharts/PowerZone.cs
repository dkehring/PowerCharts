namespace Whc.PowerCharts
{
    public class PowerZone
    {
        public PowerZoneDefinition Definition { get; set; }
        public double WattsLow { get; set; }
        public double WattsMiddle => (WattsLow + WattsHigh) / 2.0;
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

        public PowerZone(Rider rider, 
            IMaxHeartRateStrategy maxHrStrategy, 
            PowerZoneDefinition zoneDefinition)
        {
            Definition = zoneDefinition;
            WattsLow = Definition.WattsLowPercent * rider.FunctionalThresholdPowerWatts;
            WattsHigh = Definition.WattsHighPercent * rider.FunctionalThresholdPowerWatts;
            HeartRateLow = Utilities.CalculateHeartRate(maxHrStrategy, rider, Definition.HeartRateLowPercent);
            HeartRateHigh = Utilities.CalculateHeartRate(maxHrStrategy, rider, Definition.HeartRateHighPercent);
        }
    }
}