namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffee = Console.ReadLine().Split().ToList();
            int n=int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0]== "Include")
                {
                    string elementToAdd = command[1];
                    coffee.Add(elementToAdd);
                }
                else if (command[0]=="Remove")
                {
                    string indexToRemove = command[1];
                    int numberToRemove = int.Parse(command[2]);
                    if (indexToRemove=="first")
                    {
                        for (int k = 0; k < numberToRemove; k++)
                        {
                            coffee.RemoveAt(0);
                        }
                    }
                    else if (indexToRemove=="last")
                    {
                        for (int k = 0; k < numberToRemove; k++)
                        {
                            coffee.RemoveAt(coffee.Count-1);
                        }
                    }

                }
                else if (command[0]== "Prefer")
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    if (firstIndex>=0 && secondIndex>=0 && firstIndex<coffee.Count && secondIndex<coffee.Count && firstIndex!=secondIndex)
                    {
                        string firstElement = coffee[firstIndex];
                        string secondElement = coffee[secondIndex];
                        string savingElement= coffee[firstIndex];
                        coffee.RemoveAt(firstIndex);
                        coffee.Insert(firstIndex,secondElement);
                        coffee.RemoveAt(secondIndex);
                        coffee.Insert(secondIndex,firstElement);

                    }
                }
                else if (command[0]== "Reverse")
                {
                    coffee.Reverse();
                }

            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ",coffee));
        }
    }
}