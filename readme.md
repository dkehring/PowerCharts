# PowerCharts
A library for calculating power training zones based on Dr. Andy Coggan's power zones.

To use:

First, create rider information critical to the calculation of the power and heart rate zones. You'll also need the definition of the power zones. A class that represents the Coggan zones is provided, but you can create your own. Then pass those into the PowerChart class' constructor and you'll get back the power zones with min/max Watts, min/max HR and RPE.

    var rider = new Rider
    {
        AgeYears = 32,
        FunctionalThresholdPowerWatts = 350,
        Name = "Chris Froome",
        RestingHeartRateBpm = 40,
        WeightPounds = 170
    };

    var zones = new AndyCogganZones();
    var chart = new PowerChart(rider, zones);

There's an alternate constructor for the PowerChart class that let's you pass in the max HR calculation strategy.

    var chart = new PowerChart(rider, new TanakaMaxHeartRate(), zones);

You can create your own max HR strategy by creating a class that implements the `IMaxHeartRateStrategy` interface.

### License
[MIT License](license.txt)