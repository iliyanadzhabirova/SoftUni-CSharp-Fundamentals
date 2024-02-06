// See https://aka.ms/new-console-template for more information
int[]array=Console.ReadLine().Split().Select(int.Parse).ToArray();
int rotationNumber=int.Parse(Console.ReadLine());
for (int j = 0; j < rotationNumber; j++)
{
    int firstElement = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i] = array[i + 1];
    }
    array[array.Length - 1] = firstElement;
}
Console.WriteLine(String.Join(" ", array));