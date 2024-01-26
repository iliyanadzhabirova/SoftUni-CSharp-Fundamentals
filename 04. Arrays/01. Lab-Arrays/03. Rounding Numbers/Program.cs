// See https://aka.ms/new-console-template for more information
double[] inputNumbers = Console.ReadLine()
    .Split()
    .Select(double.Parse)
    .ToArray(); 

for (int i = 0;i < inputNumbers.Length; i++)
{
	if (inputNumbers[i] ==-0)
	{
        Console.WriteLine($"{inputNumbers[i]} => 0");
    }
	else
	{
        Console.WriteLine($"{Convert.ToDecimal(inputNumbers[i])} => {Convert.ToDecimal(Math.Round(inputNumbers[i], MidpointRounding.AwayFromZero))}");
    }
    
}
