// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];
for (int i = 0; i < numbers.Length; i++)
{
    int input = int.Parse(Console.ReadLine());
    numbers[i] = input;
}
for (int i = numbers.Length - 1; i >= 0; i--)
{
    Console.Write(numbers[i] + " ");
}
