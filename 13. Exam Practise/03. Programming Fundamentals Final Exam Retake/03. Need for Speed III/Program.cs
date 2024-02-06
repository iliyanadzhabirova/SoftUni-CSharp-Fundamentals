using System.ComponentModel.Design;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        { Dictionary<string,int> carAndMileage=new Dictionary<string, int>();
            Dictionary<string,int>carAndFuel=new Dictionary<string,int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] carInfo=Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
                string car = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);
                if (!carAndMileage.ContainsKey(car))
                {
                    carAndMileage[car] = mileage;
                    carAndFuel[car] = fuel;
                }
            }
            string input=Console.ReadLine();
            while (input!="Stop")
            {
                string[] commandArgs = input.Split(" : ");
                string car = commandArgs[1];
                string command = commandArgs[0];

                if (command== "Drive")
                {
                    int distance = int.Parse(commandArgs[2]);
                    int fuel = int.Parse(commandArgs[3]);
                    if (carAndFuel[car] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");

                    }
                    else
                    {
                        carAndFuel[car]-=fuel;
                        carAndMileage[car] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }

                    if (carAndMileage[car] >= 100000)
                    {
                        carAndFuel.Remove(car);
                        carAndMileage.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                   
                }
                else if (command== "Refuel")
                {
                    int fuel = int.Parse(commandArgs[2]);
                    if (carAndFuel[car]+fuel>75)
                    {
                        fuel = 75 - carAndFuel[car];               
                    }
                    carAndFuel[car] += fuel;
                    Console.WriteLine($"{car} refueled with {fuel} liters");
                }
                else if(command== "Revert")
                {
                    int kilometers = int.Parse(commandArgs[2]);
                    carAndMileage[car]-=kilometers;
                    if (carAndMileage[car] >= 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");

                    }
                    else
                    {
                        carAndMileage[car] = 10000;
                    }

                        
                }
                input=Console.ReadLine();
            }
            foreach (var kvp in carAndMileage)
            {
                Console.WriteLine($"{kvp.Key} -> Mileage: {kvp.Value} kms, Fuel in the tank: {carAndFuel[kvp.Key]} lt.");
            }
        }
    }
}