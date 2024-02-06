string input = Console.ReadLine();

List<string> letters = new List<string>();
List<string> numbers = new List<string>();
List<string> symbols = new List<string>();

for (int i = 0; i < input.Length; i++)
{
    if ((input[i] >=65 && input[i]<=90)||(input[i]>=97 && input[i]<=122))
    {
        letters.Add(input[i].ToString());
    }
    else if (input[i]>=48 && input[i] <= 57)
    {
        numbers.Add(input[i].ToString());
    }
    else
    {
        symbols.Add(input[i].ToString());   
    }
}
Console.WriteLine(string.Join("",numbers));
Console.WriteLine(string.Join("",letters));
Console.WriteLine(string.Join("",symbols));