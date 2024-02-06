List<string> strings = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries)
           .ToList();

string currentOutput = Console.ReadLine();

while (currentOutput != "3:1")
{
    List<string> currentCommand = currentOutput
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    if (currentCommand[0] == "merge")
    {
        int startIndex = int.Parse(currentCommand[1]);
        int endIndex = int.Parse(currentCommand[2]);

        if (startIndex < 0)
        {
            startIndex = 0;
        }
        if (endIndex > strings.Count - 1)
        {
            endIndex = strings.Count - 1;
        }

        MerageStrings(strings, startIndex, endIndex);
    }
    else if (currentCommand[0] == "divide")
    {
        DivideStrings(strings, currentCommand);
    }

    currentOutput = Console.ReadLine();
}

Console.WriteLine(string.Join(' ', strings));
        
 
         static void DivideStrings(List<string> strings, List<string> currentCommand)
{
    int index = int.Parse(currentCommand[1]);
    int partition = int.Parse(currentCommand[2]);

    string currentString = strings[index];
    int lengthOfSubstrings = currentString.Length;

    strings[index] = string.Empty;

    if (lengthOfSubstrings % partition == 0)
    {
        lengthOfSubstrings /= partition;

        for (int currentSymbol = 0; currentSymbol < currentString.Length; currentSymbol++)
        {
            if (currentSymbol != 0 && currentSymbol % lengthOfSubstrings == 0)
            {
                index++;
                strings.Insert(index, string.Empty);
            }

            strings[index] += currentString[currentSymbol];
        }
    }
    else
    {
        lengthOfSubstrings = lengthOfSubstrings / partition <= 0 ? 1 : lengthOfSubstrings / partition;

        int countOfSubstrings = partition;

        for (int currentSymbol = 0; currentSymbol < currentString.Length; currentSymbol++)
        {
            if (currentSymbol != 0 && currentSymbol % lengthOfSubstrings == 0 && countOfSubstrings > 1)
            {
                index++;
                strings.Insert(index, string.Empty);
                countOfSubstrings--;
            }

            strings[index] += currentString[currentSymbol]; 
        } 
    }
}
 static void MerageStrings(List<string> strings, int startIndex, int endIndex)
{
    for (int j = startIndex + 1; j <= endIndex; j++)
    {
        strings[startIndex] += strings[startIndex + 1];
        strings.RemoveAt(startIndex + 1);
    }
}