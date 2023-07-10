void CalculateTripCost()
{
    var calculator = new FuelCostCalculator();
    var cost = calculator.Calculate(new MercedesBenz);
    System.Console.WriteLine($"Total cost for this car is {cost} $");
}
