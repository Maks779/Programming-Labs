using System.Reflection;

namespace ReflectionTutorial;

public class FileCarStore
{
    // Task 5: StoreCars properly saves _fuelLevel and _odometer using reflection
    public void StoreCars(string path, IEnumerable<Car> cars)
    {
        File.Delete(path);

        var carType = typeof(Car);
        var fuelField = carType.GetField("_fuelLevel", BindingFlags.NonPublic | BindingFlags.Instance);
        var odometerField = carType.GetField("_odometer", BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var car in cars)
        {
            var fuelLevel = fuelField.GetValue(car);
            var odometer = odometerField.GetValue(car);

            File.AppendAllLines(path,
                [$"{car.Brand};{car.Model};{car.TankCapacity};{car.FuelConsumption};{fuelLevel};{odometer}"]);
        }
    }

    // Task 4: RestoreCars properly retrieves _fuelLevel and _odometer using reflection
    // Task 6: CarsMade is reset each time RestoreCars is invoked
    public IList<Car> RestoreCars(string path)
    {
        var result = new List<Car>();
        var fileLines = File.ReadAllLines(path);

        // Task 6: Reset CarsMade using reflection
        var carsMadeProperty = typeof(Car).GetProperty("CarsMade", BindingFlags.Public | BindingFlags.Static);
        carsMadeProperty.SetValue(null, 0);

        var carType = typeof(Car);
        var fuelField = carType.GetField("_fuelLevel", BindingFlags.NonPublic | BindingFlags.Instance);
        var odometerField = carType.GetField("_odometer", BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var line in fileLines)
        {
            var carRawData = line.Split(';');

            var car = new Car(carRawData[0], carRawData[1], int.Parse(carRawData[2]), double.Parse(carRawData[3]));

            // Task 4: Restore private fields using reflection
            fuelField.SetValue(car, double.Parse(carRawData[4]));
            odometerField.SetValue(car, double.Parse(carRawData[5]));

            result.Add(car);
        }

        return result;
    }
}
