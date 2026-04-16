using ReflectionTutorial;

var car1 = new Car("Ford", "Mondeo", 60, 6.5);
car1.AddFuel(40);
car1.Drive(200);

var car2 = new Car("Toyota", "Corolla", 50, 5.0);
car2.AddFuel(50);
car2.Drive(350);

Console.WriteLine("Original cars");
Console.WriteLine($"Car 1: {car1.Brand} {car1.Model}, Fuel: {car1.FuelLevel}, Odometer: {car1.Odometer}");
Console.WriteLine($"Car 2: {car2.Brand} {car2.Model}, Fuel: {car2.FuelLevel}, Odometer: {car2.Odometer}");
Console.WriteLine($"Cars Made: {Car.CarsMade}");

var store = new FileCarStore();
store.StoreCars("cars.txt", [car1, car2]);
Console.WriteLine("\nFile saved. Content:");
Console.WriteLine(File.ReadAllText("cars.txt"));

Console.WriteLine("Restored cars");
var restoredCars = store.RestoreCars("cars.txt");
foreach (var car in restoredCars)
{
    Console.WriteLine($"{car.Brand} {car.Model}, Fuel: {car.FuelLevel}, Odometer: {car.Odometer}");
}
Console.WriteLine($"Cars Made after restore: {Car.CarsMade}");

Console.WriteLine("\nTask 7: InsufficientFuelException");
var car3 = new Car("BMW", "X5", 70, 10.0);
car3.AddFuel(5);

try
{
    Console.WriteLine("Trying to drive 100 km with only 5 liters...");
    car3.Drive(100);
}
catch (InsufficientFuelException ex)
{
    Console.WriteLine($"Exception caught: {ex.Message}");
    Console.WriteLine($"  Distance requested: {ex.DistanceRequested} km");
    Console.WriteLine($"  Fuel available: {ex.FuelAvailable} L");
    Console.WriteLine($"  Max possible distance: {ex.MaxDistance} km");
}
