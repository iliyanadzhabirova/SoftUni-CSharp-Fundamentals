namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();

            string input=Console.ReadLine();
            while(input!= "Travel")
            {
                string[]commandArgs=input.Split(":",StringSplitOptions.RemoveEmptyEntries);
                string command = commandArgs[0];
                if (command== "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string element = commandArgs[2];
                    if (index>=0 && index<destinations.Length)
                    {
                        destinations=destinations.Insert(index,element);
                    }
                    Console.WriteLine(destinations);
                }
                else if (command== "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);
                    if (startIndex>=0&&startIndex<destinations.Length&&endIndex>=0&&endIndex<destinations.Length)
                    {
                        destinations=destinations.Remove(startIndex, endIndex - startIndex+1);
                    }
                    
                    Console.WriteLine(destinations);
                }
                else if (command== "Switch")
                {
                    string oldString = commandArgs[1];
                    string newString = commandArgs[2];
                    if (destinations.Contains(oldString))
                    {
                        destinations=destinations.Replace(oldString,newString);
                    }
                    Console.WriteLine(destinations);
                }

                input=Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}