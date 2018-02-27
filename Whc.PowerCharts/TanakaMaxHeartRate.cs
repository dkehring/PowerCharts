namespace Whc.PowerCharts
{
    /// <summary>
    /// Calculate age-predicted maximal heart rate base on the Tanaka forumla.
    /// https://www.ncbi.nlm.nih.gov/pubmed/11153730
    /// </summary>
    public class TanakaMaxHeartRate : IMaxHeartRateStrategy
    {
        public double? Calculate(Rider rider)
        {
            return 208 - (.7 * rider.AgeYears);
        }
    }
}
