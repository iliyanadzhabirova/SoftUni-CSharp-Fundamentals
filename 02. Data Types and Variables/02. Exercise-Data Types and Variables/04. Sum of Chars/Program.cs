// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

int number=int.Parse(Console.ReadLine());
int sum = 0;
for(int i=0; i < number; i++)
{
    char letter =char.Parse(Console.ReadLine()) ;
    sum += letter;
}
Console.WriteLine($"The sum equals: {sum}");