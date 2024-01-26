using System.Text;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input=Console.ReadLine();
            while (input!="Done") 
            {
                string[] commandArg=input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArg[0];
                
                if (commandType == "TakeOdd")
                {
                    StringBuilder oddChars= new StringBuilder();
                    
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        oddChars.Append(password[i]);
                    }
                    password = oddChars.ToString();
                    Console.WriteLine(password);
                }
                else if (commandType == "Cut")
                {
                    int index = int.Parse(commandArg[1]);
                    int length = int.Parse(commandArg[2]);
                    password=password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if(commandType == "Substitute")
                {
                    string substring = commandArg[1];
                    string substitute = commandArg[2];
                    if (password.Contains(substring))
                    {
                        password=password.Replace(substring,substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }

                }

            input = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}