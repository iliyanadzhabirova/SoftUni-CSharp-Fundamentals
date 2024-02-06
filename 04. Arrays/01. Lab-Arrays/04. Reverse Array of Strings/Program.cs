// See https://aka.ms/new-console-template for more information
string[] inputs = Console.ReadLine()
    .Split()
    .ToArray();
for(int i = 0;i < inputs.Length/2; i++)
{
    string firstElement = inputs[i];
    string lastElement = inputs[inputs.Length-1-i];

    inputs[i]=lastElement;
    inputs[inputs.Length - 1 - i] = firstElement;

}
Console.WriteLine(string.Join(" ",inputs));