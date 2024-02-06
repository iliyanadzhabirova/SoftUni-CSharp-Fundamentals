
class MainClass
{
    static void Main()
    {
        var list = new List<Car>();
        for (int n = int.Parse(Console.ReadLine()); n > 0; --n)
        {
            var data = Console.ReadLine().Split();
            list.Add(new Car(data[0], decimal.Parse(data[1]), decimal.Parse(data[2])));
        }
        while (true)
        {
            string[] data = { Console.ReadLine() };
            if (data[0] == "End") break;
            data = data[0].Split().ToArray();
            list.Find(x => x.Model == data[1]).Move(decimal.Parse(data[2]));
        }
        Console.Write(String.Join("\n", list));
    }
}
class Car
{
    public Car(string model, decimal fuel, decimal fuelPerKm)
    {
        Model = model;
        Fuel = fuel;
        FuelPerKm = fuelPerKm;
        Distance = 0m;
    }
    public string Model { get; set; }
    public decimal Fuel { get; set; }
    public decimal FuelPerKm { get; set; }
    public decimal Distance { get; set; }
    public override string ToString()
    {
        return $"{Model} {Fuel:f2} {Distance}";
    }
    public void Move(decimal km)
    {
        if (FuelPerKm * km <= Fuel)
        {
            Fuel -= FuelPerKm * km;
            Distance += km;
        }
        else Console.WriteLine("Insufficient fuel for the drive");
    }
}