// See https://aka.ms/new-console-template for more information
int[] numbers =Console.ReadLine()
	.Split()
	.Select(int.Parse)
	.ToArray();
int EvenSum = 0;
int OddSum = 0;
for(int i=0; i<numbers.Length; i++)
{
	int cureentNumber = numbers[i];
	if (cureentNumber%2==0)
	{
		EvenSum += cureentNumber;
	}
	else
	{
		OddSum+= cureentNumber;
	}
}
Console.WriteLine(EvenSum-OddSum);