public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine()
                .Split(' ', 6)
                .ToArray();
            var engine = new Engine();
            var cargo = new Cargo();
            var tires = new List<Tire>();
            string model = input[0];
            engine.Speed = int.Parse(input[1]);
            engine.Power = int.Parse(input[2]);
            cargo.Weight = int.Parse(input[3]);
            cargo.Type = input[4];
            var splitTires = input[5].Split(' ').ToArray();

            for (int j = 0; j < splitTires.Length; j += 2)
            {
                var tire = new Tire();
                tire.Pressure = double.Parse(splitTires[j]);
                tire.Age = int.Parse(splitTires[j + 1]);
                tires.Add(tire);
            }
            var car = new Car(model, engine, cargo, tires.ToArray());
            cars.Add(car);
        }

        string command = Console.ReadLine();

        switch (command)
        {
            case "fragile":
                DisplayFragile(cars);
                break;
            case "flamable":
                DisplayFlamable(cars);
                break;
        }
    }

    static void DisplayFragile(List<Car> cars)
    {
        foreach (var car in cars)
        {
            string model = string.Empty;
            foreach (var tire in car.Tires)
            {

                if (tire.Pressure < 1 && car.Model != model)
                {
                    model = car.Model;
                    Console.WriteLine($"{car.Model}");
                }
            }

        }
    }

    static void DisplayFlamable(List<Car> cars)
    {
        foreach (var car in cars)
        {
            if (car.Engine.Power > 250)
                Console.WriteLine($"{car.Model}");
        }
    }
}

public class Car
{
    private Tire[] tires;
    public string Model { get; set; }

    public Engine Engine { get; set; }

    public Cargo Cargo { get; set; }

    public Tire[] Tires
    {
        get => tires;
        set
        {
            if (value.Length == 4)
            {
                tires = value;
            }
        }
    }

    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        this.Model = model;
        this.Engine = engine;
        this.Cargo = cargo;
        this.Tires = tires;
    }
}

public class Cargo
{
    public string Type { get; set; }

    public int Weight { get; set; }
}

public class Engine
{
    public int Speed { get; set; }

    public int Power { get; set; }
}

public class Tire
{
    public double Pressure { get; set; }

    public int Age { get; set; }
}