// See https://aka.ms/new-console-template for more information
int number=int.Parse(Console.ReadLine());
int sum = 0;
while(number > 0)
{
    int digit = number % 10;   
    number = number / 10;
    sum += digit;
}
Console.WriteLine(sum);