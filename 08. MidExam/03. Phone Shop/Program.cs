namespace _03._Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<string> telephones=Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToList();
            string input=Console.ReadLine();
            while (input!="End")
            {
                string[] command = input.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                if (command[0]=="Add")
                {
                    string elementToAdd = command[1];
                    if (!telephones.Contains(elementToAdd))
                    {
                        telephones.Add(elementToAdd);
                    }
                }
                else if (command[0]== "Remove")
                {
                    string elementToRemove = command[1];
                    if (telephones.Contains(elementToRemove))
                    {
                        telephones.Remove(elementToRemove);
                    }
                }
                else if (command[0]== "Bonus phone")
                {
                    string bonusElemnt = command[1];
                    string[] bonus = bonusElemnt.Split(":",StringSplitOptions.RemoveEmptyEntries);
                    string oldPhone = bonus[0];
                    string newPhone = bonus[1];
                    if (telephones.Contains(oldPhone)&&!telephones.Contains(newPhone))
                    {
                        int indexOld = telephones.IndexOf(oldPhone);
                        if (indexOld+1<=telephones.Count)
                        {
                            telephones.Insert(indexOld + 1, newPhone);
                        }
                        
                    }

                }
                else if (command[0]== "Last")
                {
                    string lastElement= command[1];
                    int indexOfTheLastElement=telephones.IndexOf(lastElement);
                    if (indexOfTheLastElement>=0&&indexOfTheLastElement<telephones.Count)
                    {
                        telephones.RemoveAt(indexOfTheLastElement);
                        telephones.Add(lastElement);
                    }
                   
                }



                input= Console.ReadLine();
            }
            Console.WriteLine(string.Join (", ",telephones));
        }
    }
}