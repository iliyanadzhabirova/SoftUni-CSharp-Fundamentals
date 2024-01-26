// See https://aka.ms/new-console-template for more information
int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i++)
{
    bool primeOrNot = true;
    for (int k = 2; k < i; k++)
    {
        if (i % k == 0)
        {
            primeOrNot = false;
            break;
        }
    }
    if (primeOrNot==true)
    {
        Console.WriteLine($"{i} -> true");
    }
    else
    {
        Console.WriteLine($"{i} -> false");
    }

}
