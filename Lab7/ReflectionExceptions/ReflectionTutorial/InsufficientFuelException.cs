namespace ReflectionTutorial;

public class InsufficientFuelException : Exception
{
    public double DistanceRequested { get; }
    public double FuelAvailable { get; }
    public double MaxDistance { get; }

    public InsufficientFuelException(double distanceRequested, double fuelAvailable, double maxDistance)
        : base($"Cannot drive {distanceRequested} km. Fuel available: {fuelAvailable:F1} L, max possible distance: {maxDistance:F1} km.")
    {
        DistanceRequested = distanceRequested;
        FuelAvailable = fuelAvailable;
        MaxDistance = maxDistance;
    }
}
