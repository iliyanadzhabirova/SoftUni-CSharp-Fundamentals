// See https://aka.ms/new-console-template for more information

//"Type: {typeOfVehicle}
//Model: { modelOfVehicle}
//Color: { colorOfVehicle}
//Horsepower: { horsepowerOfVehicle}
//"
using System.Runtime.CompilerServices;

List<Vehicle> vehicles=new List<Vehicle>();


while (true)
{
    string line = Console.ReadLine();
    if (line == "End")
    {
        break;
    }
    string[] vehiclePart = line.Split();
    string type= vehiclePart[0];
    string model= vehiclePart[1];
    string color= vehiclePart[2];
    int horsePower = int.Parse(vehiclePart[3]);

    Vehicle vehicle = new Vehicle
    {
        Type = type,
        Model = model,
        Color = color,
        Horsepower = horsePower
    };
    vehicles.Add(vehicle);

}
while (true)
{
 string line=Console.ReadLine();
    if (line == "Close the Catalogue")
    { 
        break;
    }
    Vehicle vehicle = GetVehicleByModel(vehicles, line);  
    if (vehicle == null)
    {
        continue;
    }
    if (vehicle.Type=="car")
    {
        Console.WriteLine($"Type: Car");
    }
    else
    {
        Console.WriteLine($"Type: Truck");
    }
   
    Console.WriteLine($"Model: {vehicle.Model}");
    Console.WriteLine($"Color: {vehicle.Color}");
    Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
    
}
double carsHpAverage = CalculateAverageHp(vehicles, "car");
double trucksHpAverage = CalculateAverageHp(vehicles, "truck");
Console.WriteLine($"Cars have average horsepower of: {carsHpAverage:f2}.");
Console.WriteLine($"Trucks have average horsepower of: {trucksHpAverage:f2}.");
static double CalculateAverageHp(List<Vehicle> vehicles, string type)
{

    int typeCount= 0;
    int typeHorsePowerTotal = 0;
    foreach (var vehicle in vehicles)
    {
        if (vehicle.Type == type)
        {
            typeCount++;
            typeHorsePowerTotal += vehicle.Horsepower;
        }
       
    }
    if (typeCount==0)
    {
        return 0;
    }
    return (double)typeHorsePowerTotal / typeCount;
}

static  Vehicle  GetVehicleByModel(List<Vehicle> vehicles, string model)
{
    foreach (var vehicle in vehicles)
    {
        if (vehicle.Model == model)
        {
            return vehicle;
        }
    }
    return null;
}
public class Vehicle
{
    public string Type { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
}