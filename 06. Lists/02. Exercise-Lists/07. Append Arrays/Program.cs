// See https://aka.ms/new-console-template for more information

string input = Console.ReadLine();
string[] arrayStrings = input.Split('|');
List<List<int>> arrays = new List<List<int>>(arrayStrings.Length);

// Parse each array string into a list of integers
for (int i = 0; i < arrayStrings.Length; i++)
{
    string[] values = arrayStrings[i].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    List<int> list = new List<int>(values.Length);
    for (int j = 0; j < values.Length; j++)
    {
        list.Add(int.Parse(values[j]));
    }
    arrays.Add(list);
}

// Append the lists in reverse order
List<int> result = new List<int>();
for (int i = arrays.Count - 1; i >= 0; i--)
{
    result.AddRange(arrays[i]);
}

// Print the resulting list
Console.WriteLine(string.Join(" ", result));
