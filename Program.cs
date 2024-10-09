// Skapa en lista för att lagra fordon
using Carz_Co;

List<Vehicle> vehicles = new List<Vehicle>();

List<Car> carss = new List<Car>();


carss.Add(new Car("scan", "x543"));
// Lägg till några fordon
vehicles.Add(new Car("Volvo", "V60"));
vehicles.Add(new Motorcycle("Harley-Davidson", "Street 750"));
vehicles.Add(new Truck("Scania", "R500"));
vehicles.Add(new Car("Toyota", "Corolla"));

// Skriv ut alla fordon
Console.WriteLine("Alla fordon:");
foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.Brand + vehicle.Model);
}

// Filtrera och skriv ut bara bilar
Console.WriteLine("\nBara bilar:");
var cars = FilterVehicles<Car>(vehicles);
foreach (var car in cars)
{
    Console.WriteLine(car.Brand + car.Model);
}

// Sälj ett fordon
var vehicleToSell = vehicles.Find(v => v.Brand == "Toyota");
if (vehicleToSell != null)
{
    SellVehicle(vehicles, vehicleToSell);
}

// Skriv ut uppdaterad lista
Console.WriteLine("\nUppdaterad lista efter försäljning:");
foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.Brand + vehicle.Model);
}

static List<L> FilterVehicles<L>(List<Vehicle> vehicles) where L : Vehicle
{
    return vehicles.OfType<L>().ToList();
}

static void SellVehicle(List<Vehicle> vehicles, Vehicle vehicle)
{
    Console.WriteLine($"\nSäljer fordon: {vehicle.Brand} {vehicle.Model}");
    vehicles.Remove(vehicle);
}
foreach (var carz in carss)
{
    Console.WriteLine($"{carz.Brand} {carz.Model}");
}