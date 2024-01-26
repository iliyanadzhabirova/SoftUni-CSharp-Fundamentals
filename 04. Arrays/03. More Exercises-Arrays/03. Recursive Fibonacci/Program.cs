// See https://aka.ms/new-console-template for more information
int numberPosition=int.Parse(Console.ReadLine());
int []fibonacciArray=new int[numberPosition];

fibonacciArray[0] = 1;
fibonacciArray[1] = 1;

if (numberPosition > 2)
{

    for (int i = 2; i < fibonacciArray.Length; i++)
    {
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
    }
}
Console.WriteLine(fibonacciArray[numberPosition - 1]);