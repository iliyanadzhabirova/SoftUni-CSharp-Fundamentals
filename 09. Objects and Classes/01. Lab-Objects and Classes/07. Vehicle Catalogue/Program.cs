Catalog catalog = new Catalog();


string commandInfo=Console.ReadLine();
while (commandInfo != "end")
{
    string[] vehicleInfo = commandInfo.Split("/");

    string type = vehicleInfo[0];
    string make = vehicleInfo[1];
    string model = vehicleInfo[2];
    int value = int.Parse(vehicleInfo[3]);//hp || weight

    if (type=="Car")
    {
        Car car = new Car();
        car.Brand = make;
        car.Model = model;
        car.HorsePower = value;

        catalog.Cars.Add(car);
    }
    else
    {
        Truck truck = new Truck();
        truck.Brand = make;
        truck.Model = model;
        truck.Weight = value;

        catalog.Trucks.Add(truck);
    }

    commandInfo = Console.ReadLine();
}
Console.WriteLine("Cars:");
foreach (var car in catalog.Cars.OrderBy(x=>x.Brand))
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
}
Console.WriteLine("Trucks:");
foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}


class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}
class Catalog
{
    public Catalog() 
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }
}