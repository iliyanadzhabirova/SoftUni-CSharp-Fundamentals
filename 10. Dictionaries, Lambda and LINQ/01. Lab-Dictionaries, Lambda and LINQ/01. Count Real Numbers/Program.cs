SortedDictionary<double,int>counts= new SortedDictionary<double,int>();
double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

foreach (var number in numbers)
{
    if (!counts.ContainsKey(number))
    {
        counts[number] = 0;
    }
    counts[number]++;
}

foreach (var number in counts)
{
    Console.WriteLine($"{number.Key} -> {number.Value}");
}

