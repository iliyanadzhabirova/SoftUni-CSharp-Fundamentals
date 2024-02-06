string [] sequence = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);


double sum = 0;

foreach (string s in sequence)
{
    double result = 0;

    char firstChar = s.First();
    char lastChar = s.Last();

    double firstOperand = double.Parse(s.Substring(1, s.Length - 2));
    double secondOperand = GetLetterPositionInTheAlphabet(firstChar);
    double thirdOperand=GetLetterPositionInTheAlphabet(lastChar);

    if (char.IsUpper(firstChar))
    {
        result = firstOperand / secondOperand;  
    }
    else
    {
        result = firstOperand * secondOperand;
    }

    if (char.IsUpper(lastChar))
    {
        result -= thirdOperand;
    }
    else
    {
        result += thirdOperand  ;
    }
    sum += result;
}

Console.WriteLine( $"{sum:f2}");
static int GetLetterPositionInTheAlphabet(char c)
{
    return c.ToString().ToLower().First()-96;
}