namespace Whc.PowerCharts
{
    public class PowerZoneDefinition
    {
        public int Zone { get; set; }
        public string Description { get; set; }
        public int RpeLow { get; set; }
        public int RpeHigh { get; set; }
        public double? HeartRateLowPercent { get; set; }
        public double? HeartRateHighPercent { get; set; }
        public double WattsLowPercent { get; set; }
        public double WattsHighPercent { get; set; }

        public string RpeText
        {
            get
            {
                if (RpeLow == 0) return "<" + RpeHigh;
                if (RpeHigh == 0) return ">" + RpeLow;
                return RpeLow + "-" + RpeHigh;
            }
        }
    }
}