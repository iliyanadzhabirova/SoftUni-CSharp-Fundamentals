// See https://aka.ms/new-console-template for more information
int n=int.Parse(Console.ReadLine());
int[]firstArray= new int[n];
int[] secondArray= new int[n];
for (int i=0; i < n; i++)
{
    int[] currentNumber=Console.ReadLine().Split().Select(int.Parse).ToArray();
	if (i%2==0)
	{
		firstArray[i] = currentNumber[0];
		secondArray[i] = currentNumber[1];
	}
	else
	{
		firstArray[i] = currentNumber[1];
		secondArray[i] = currentNumber[0];
	}
}
Console.WriteLine(String.Join(" ",firstArray));
Console.WriteLine(String.Join(" ", secondArray));

