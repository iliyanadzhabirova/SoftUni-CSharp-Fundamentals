// See https://aka.ms/new-console-template for more information
int[] array =Console.ReadLine().Split().Select(int.Parse).ToArray();    
for(int i = 0;i < array.Length; i++)
{
    bool isTop = true;
	for (int j = i+1; j < array.Length; j++)
	{
		if (array[i] <= array[j])
		{
			isTop = false;
			break;
		}
	}
	if (isTop)
	{
		Console.Write($"{array[i]} ");
	}
}