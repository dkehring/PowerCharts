using System.Collections.Generic;

namespace Whc.PowerCharts
{
    public class AndyCogganZones : List<PowerZoneDefinition>
    {
        public AndyCogganZones()
        {
            Add(new PowerZoneDefinition
            {
                Zone = 1,
                Description = "Active Recovery",
                WattsLowPercent = 0,
                WattsHighPercent = .55,
                HeartRateLowPercent = 0,
                HeartRateHighPercent = .68,
                RpeLow = 0,
                RpeHigh = 2
            });
            Add(new PowerZoneDefinition
            {
                Zone = 2,
                Description = "Endurance",
                WattsLowPercent = .56,
                WattsHighPercent = .75,
                HeartRateLowPercent = .69,
                HeartRateHighPercent = .83,
                RpeLow = 2,
                RpeHigh = 3
            });
            Add(new PowerZoneDefinition
            {
                Zone = 3,
                Description = "Tempo",
                WattsLowPercent = .76,
                WattsHighPercent = .90,
                HeartRateLowPercent = .84,
                HeartRateHighPercent = .94,
                RpeLow = 3,
                RpeHigh = 4
            });
            Add(new PowerZoneDefinition
            {
                Zone = 4,
                Description = "Lactate Threshold",
                WattsLowPercent = .91,
                WattsHighPercent = 1.05,
                HeartRateLowPercent = .95,
                HeartRateHighPercent = 1.05,
                RpeLow = 4,
                RpeHigh = 5
            });
            Add(new PowerZoneDefinition
            {
                Zone = 5,
                Description = "VO2 Max",
                WattsLowPercent = 1.06,
                WattsHighPercent = 1.20,
                HeartRateLowPercent = 1.06,
                RpeLow = 6,
                RpeHigh = 7
            });
            Add(new PowerZoneDefinition
            {
                Zone = 6,
                Description = "Anaerobic Capacity",
                WattsLowPercent = 1.21,
                WattsHighPercent = 1.5,
                RpeLow = 7,
                RpeHigh = 0
            });
        }
    }
}
