// See https://aka.ms/new-console-template for more information
List<int>wagons=Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity=int.Parse(Console.ReadLine());
//•	Add
//{ passengers} – add a wagon to the end of the train with the given number of passengers.
//•	{passengers} – find a single wagon to fit all the incoming passengers (starting from the first wagon).
string input=Console.ReadLine();
while (input!="end")
{
    string[]command=input.Split() ;
    if (command.Contains("Add"))
    {
        int passengers = int.Parse(command[1]);
        wagons.Add(passengers);
    }
    else
    {
        int passengers = int.Parse(command[0]);
        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i]+passengers<=maxCapacity)
            {
                wagons[i] += passengers;
                break;
            }
        }
    }
    input=Console.ReadLine();
}
Console.WriteLine(string.Join(" ",wagons));
