using System.Collections.Generic;
using System.Linq;

namespace Whc.PowerCharts
{
    public class PowerChart
    {
        public Rider Rider { get; set; }
        public IList<PowerZone> Zones { get; private set; }

        public PowerChart(Rider rider, IEnumerable<PowerZoneDefinition> zoneDefinitions)
        {
            Rider = rider;
            Zones = new List<PowerZone>();
            foreach (var powerZoneDef in zoneDefinitions.OrderBy(x => x.Zone))
            {
                Zones.Add(new PowerZone(rider, powerZoneDef));
            }
        }

        public PowerChart(Rider rider, 
            IMaxHeartRateStrategy maxHrStrategy,
            IEnumerable<PowerZoneDefinition> zoneDefinitions)
        {
            Rider = rider;
            Zones = new List<PowerZone>();
            foreach (var powerZoneDef in zoneDefinitions.OrderBy(x => x.Zone))
            {
                Zones.Add(new PowerZone(rider, maxHrStrategy, powerZoneDef));
            }
        }

    }
}
