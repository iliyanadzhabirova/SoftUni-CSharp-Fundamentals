// See https://aka.ms/new-console-template for more information
int key=int.Parse(Console.ReadLine());
int numberOfLines=int.Parse(Console.ReadLine());
char newSymbol = ' ';
string result = " ";
for (int i = 1; i <= numberOfLines; i++)
{
    char symbol = char.Parse(Console.ReadLine());
    newSymbol = (char)(symbol + key);
    result += newSymbol;
}
Console.WriteLine(result);
