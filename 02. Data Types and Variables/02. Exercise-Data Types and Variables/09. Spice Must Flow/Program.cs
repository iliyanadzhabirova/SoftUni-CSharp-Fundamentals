// See https://aka.ms/new-console-template for more information
int source=int.Parse(Console.ReadLine());
int amountOfSpice = 0;
int days = 0;

while (source >= 100)
{
   int leftSource=source - 26;
    amountOfSpice += leftSource;
    days++;
    source -= 10;
}
if (days>0)
{
    amountOfSpice -= 26;
}

Console.WriteLine(days);
Console.WriteLine(amountOfSpice);