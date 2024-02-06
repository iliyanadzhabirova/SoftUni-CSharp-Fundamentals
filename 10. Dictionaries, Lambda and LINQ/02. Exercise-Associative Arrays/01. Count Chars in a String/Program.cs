Dictionary<char,int>letterCounter = new Dictionary<char,int>();

string input=Console.ReadLine();

foreach (char currentChar in input)
{
	if (currentChar==' ')
	{
		continue;
	}
	if (!letterCounter.ContainsKey(currentChar))
	{
		letterCounter.Add(currentChar, 0);
	}
	letterCounter[currentChar]++;

}
foreach (var letter in letterCounter)
{
	
        Console.WriteLine($"{letter.Key} -> {letter.Value}");
    
}