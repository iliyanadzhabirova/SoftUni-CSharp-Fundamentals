Dictionary<string,int>words= new Dictionary<string,int>();
string[] input = Console.ReadLine().Split();
foreach (string word in input)
{
	string wordToLowerCase=word.ToLower();
	if (!words.ContainsKey(wordToLowerCase))
	{
		words[wordToLowerCase] = 0;
	}
	words[wordToLowerCase]++;
}
foreach (var wordToLowerCase in words)
{
	if (wordToLowerCase.Value%2!=0)
	{
        Console.Write($"{wordToLowerCase.Key + " "}");
    }
}

