string message = Console.ReadLine();
string input = Console.ReadLine();
while (input!= "Decode")
{
    string[] instructions = input.Split('|', StringSplitOptions.RemoveEmptyEntries);
    string command = instructions[0];

    if (command == "Move")
    {
        int length = int.Parse(instructions[1]);

        string element = message.Substring(0, length);
        message = message.Remove(0, length);
        message = message.Insert(message.Length, element);
    }
    else if (command == "Insert")
    {
        int index = int.Parse(instructions[1]);
        string value = instructions[2];
        message=message.Insert(index,value);
    }
    else if(command== "ChangeAll")
    {
        string substring = instructions[1];
        string replacement = instructions[2];
        message=message.Replace(substring, replacement);
    }


    input=Console.ReadLine();
}
Console.WriteLine($"The decrypted message is: {message}");