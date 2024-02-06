using System.Text;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command!= "Reveal")
            {
                string[] commandArgs = command.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];
                if (commandType == "InsertSpace")
                {
                    int index = int.Parse(commandArgs[1]);
                    message=message.Insert(index," ");
                    Console.WriteLine(message);
                }
                else if (commandType == "Reverse")
                {
                    string substring = commandArgs[1];
                    int startIndex = message.IndexOf(substring);//= -1, when there is no substring
                    if (startIndex!=-1)
                    {
                        message = message.Remove(startIndex,substring.Length);
                        message += string.Join("", substring.Reverse());//we use string.join , because the Reverse method returns char array
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (commandType=="ChangeAll")
                {
                    string substring = commandArgs[1];
                    string replacement = commandArgs[2];

                    message=message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}