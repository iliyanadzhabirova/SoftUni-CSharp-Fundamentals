using System.Data;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<string> items=Console.ReadLine().Split((", "),StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command!= "Craft!")
            {
                string[]action=command.Split((" - "),StringSplitOptions.RemoveEmptyEntries);
                if (action[0]== "Collect")
                {
                    string item = action[1];
                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }

                }
                else if (action[0]== "Drop")
                {
                    string item = action[1];
                    if (items.Contains(item))
                    {
                        items.Remove(item);
                    }
                }
                else if (action[0]== "Combine Items")
                {
                    string elements = action[1];
                    string[] elementsArr = elements.Split(":");
                    string oldElement = elementsArr[0];
                    string newElement = elementsArr[1];
                    if (items.Contains(oldElement))
                    {
                        int index = items.IndexOf(oldElement);
                       
                        items.Insert(index+1, newElement);
                    }
                }
                else if (action[0]== "Renew")
                {
                    string itemToRenew = action[1];
                    if (items.Contains(itemToRenew))
                    {
                        int indexToRemove=items.IndexOf(itemToRenew);
                        items.RemoveAt(indexToRemove);
                        items.Add(itemToRenew);
                    }
                }




                command= Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}