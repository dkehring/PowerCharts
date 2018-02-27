using System;

namespace Whc.PowerCharts
{
    public class Rider
    {
        public string Name { get; set; }
        public int AgeYears { get; set; }

        public double WeightPounds
        {
            get { return Math.Round(WeightKgs * 2.2); }
            set { WeightKgs = Math.Round(value / 2.2); }
        }

        public double WeightKgs { get; set; }

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
