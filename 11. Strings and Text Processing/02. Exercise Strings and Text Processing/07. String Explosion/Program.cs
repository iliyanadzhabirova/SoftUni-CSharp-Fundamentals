using System.Text;

string input = Console.ReadLine();
StringBuilder output = new StringBuilder();
int explosiondtrength = 0;


for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '>')
    {
        explosiondtrength += int.Parse(input[i + 1].ToString());
        output.Append(input[i]);
    }
    else if (explosiondtrength > 0)
    {
        explosiondtrength--;
    }
    else
    {
        output.Append(input[i]);
    }
}
Console.WriteLine(output.ToString());