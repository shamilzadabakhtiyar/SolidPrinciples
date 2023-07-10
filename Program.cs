void CalculateTripCost()
{
    var calculator = new FuelCostCalculator();
    var cost = calculator.Calculate(new MercedesBenz);
    System.Console.WriteLine($"Total cost for this car is {cost} $");
}

void RunCars()
{
    try
    {
        var mercedes = new MercedesBenz();
        mercedes.Go();
        mercedes.Stop();
        mercedes.SendTripInfoEmailToDriver(new DriverInfo());

    }
    catch (EngineStartException ex)
    {
        // new TripInfoLogger().LogGermany(ex.Message);
        new TripInfoLogger(new GermanyLogger()).Log(ex.Message);
    }
    catch (AirPressureException ex)
    {
        // new TripInfoLogger().LogToLocalStorage(ex.Message);
        new TripInfoLogger(new LocalStorageLogger()).Log(ex.Message);
    }
}