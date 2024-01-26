int number = int.Parse(Console.ReadLine());
int openingCount = 0;
int closingCount = 0;

for (int i = 0; i < number; i++)
{
    string input = Console.ReadLine();

    if (input == "(")
    {
        openingCount++;
    }
    if (input == ")")
    {
        closingCount++;
    }
    if (closingCount > openingCount)
    {
        Console.WriteLine("UNBALANCED");
        return;
    }
}
if (openingCount == closingCount)
{
    Console.WriteLine("BALANCED");
}
else
{
    Console.WriteLine("UNBALANCED");
}