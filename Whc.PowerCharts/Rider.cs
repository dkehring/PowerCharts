using System;

namespace Whc.PowerCharts
{
    public class Rider
    {
        public string Name { get; set; }
        public int AgeYears { get; set; }
        public double WeightPounds { get; set; }
        public double WeightKgs => Math.Round(WeightPounds / 2.2, 2);
        public int RestingHeartRateBpm { get; set; }
        public int FunctionalThresholdPowerWatts { get; set; }
        public double WattsPerKilogram
        {
            get
            {
                
                return (WeightKgs == 0) ? 0 : Math.Round(FunctionalThresholdPowerWatts / WeightKgs, 4);
            }
        }
    }
}
