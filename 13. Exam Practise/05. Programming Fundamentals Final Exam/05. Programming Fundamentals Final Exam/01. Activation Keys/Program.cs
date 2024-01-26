using System.ComponentModel.Design;
using System.Text;

StringBuilder activationKey = new StringBuilder(Console.ReadLine());

string command = Console.ReadLine();
while (command!="Generate")
{
    string[] commandArg = command.Split(">>>"/*, StringSplitOptions.RemoveEmptyEntries*/);
    string commandType = commandArg[0];
    if (commandType == "Contains")
    {
        string substring = commandArg[1];
        if (activationKey.ToString().Contains(substring))
        {
            Console.WriteLine($"{activationKey} contains {substring}");
        }
        else
        {
            Console.WriteLine("Substring not found!");
        }
    }
    else if (commandType == "Flip")
    {
      string flipType = commandArg[1];
      int startIndex = int.Parse(commandArg[2]);
      int endIndex = int.Parse(commandArg[3]);//Exclusive

        string substring=activationKey.ToString().Substring(startIndex, endIndex-startIndex);

        if (flipType == "Upper")
        {
            substring = substring.ToUpper();
        }
        else if (flipType == "Lower")
        {
            substring = substring.ToLower();
        }
        activationKey.Remove(startIndex, endIndex - startIndex);
        activationKey.Insert(startIndex, substring);
        Console.WriteLine(activationKey);
    }
    else if (commandType=="Slice")
    {
        int startIndex = int.Parse(commandArg[1]);
        int endIndex = int.Parse(commandArg[2]);

        activationKey.Remove(startIndex, endIndex - startIndex);

        Console.WriteLine(activationKey);
    }




    command = Console.ReadLine();
}
Console.WriteLine($"Your activation key is: {activationKey}");