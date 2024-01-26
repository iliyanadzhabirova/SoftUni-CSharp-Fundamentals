string word = string.Empty;
string input=Console.ReadLine();
while (input!="End")
{
    string[] commandArgs = input.Split();
    string command = commandArgs[0];
    if (command== "Add")
    {
        string substring = commandArgs[1];

        if (word.Length > 0)
        {
            int lastIndex = word.Length - 1;
            word = word.Insert(lastIndex + 1, substring);
        }
        else if (word.Length == 0)
        {
            word = word.Insert(word.Length, substring);
        }


    }
    else if (command=="Upgrade")
    {
        char oldChar = char.Parse(commandArgs[1]);
        char newChar =(char)(oldChar + 1);
        if(word.Contains(oldChar))
        {
            word = word.Replace(oldChar, newChar);
        }
    }
    else if (command=="Print")
    {
        Console.WriteLine(word);
    }
    else if (command=="Index")
    {
        List<int>matches= new List<int>();
        char charToFind = char.Parse(commandArgs[1]);
        for (int i = 0; i < word.Length; i++)
        {
            if (charToFind == word[i])
            {
                matches.Add(i);
            }
        }
        if (matches.Count==0)
        {
            Console.WriteLine("None");
        }
        else
        {
            Console.WriteLine(string.Join(" ", matches));
        }
    }
    else if (command== "Remove")
    {
        string substring = commandArgs[1];
       
        if (word.Contains(substring)) 
        {
            word= word.Replace(substring,"");
        }
       
    }
        
    input = Console.ReadLine();
}