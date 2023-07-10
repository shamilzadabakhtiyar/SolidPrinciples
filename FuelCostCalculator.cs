public class FuelCostCalculator
{
    public double Calculate(BaseCar car)
    {
        return car.TripKM * car.GetCostPerKM();
    }
}