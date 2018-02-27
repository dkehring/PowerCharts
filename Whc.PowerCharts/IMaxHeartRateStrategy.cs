namespace Whc.PowerCharts
{
    public interface IMaxHeartRateStrategy
    {
        double? Calculate(Rider rider);
    }
}
