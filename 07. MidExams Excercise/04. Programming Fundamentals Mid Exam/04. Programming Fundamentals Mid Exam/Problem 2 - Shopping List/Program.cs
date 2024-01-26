using System.Security.Cryptography;

namespace Problem_2___Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string>groceries=Console.ReadLine().Split("!").ToList();
            string input=Console.ReadLine();
            
            while (input!="Go Shopping!")
            {
                string[] command = input.Split();

                if (command[0]=="Urgent")
                {
                    string urgentItem = command[1];
                    if (!groceries.Contains(command[1]))
                    {
                        groceries.Insert(0, urgentItem);
                    }
                }
                else if (command[0]== "Unnecessary")
                {
                   string unnecessaryItem = command[1];
                    if (groceries.Contains(command[1]))
                    {
                        groceries.Remove(unnecessaryItem);
                    }
                }
                else if (command[0]=="Correct")
                {

                    string oldItem = command[1];
                    string newItem = command[2];
                    if (groceries.Contains(oldItem))
                    {
                        int indexOfOldItem=groceries.IndexOf(oldItem);
                        groceries.Insert(indexOfOldItem, newItem);
                        groceries.Remove(oldItem);
                    }

                }
                else if (command[0]=="Rearrange")
                {
                    string rearrangeItem = command[1];
                    
                    if (groceries.Contains(rearrangeItem))
                    {
                        int indexOfRearrandedItem=groceries.IndexOf(rearrangeItem);
                        groceries.RemoveAt(indexOfRearrandedItem);
                        groceries.Add(rearrangeItem);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}