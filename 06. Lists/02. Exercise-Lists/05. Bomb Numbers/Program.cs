// See https://aka.ms/new-console-template for more information
/*
1 2 2 4 2 2 2 9-list
4 2-bomb and power

12-sum of the left numbers
 */
List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
int[] bomb = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
int bombNumber = bomb[0];
int power = bomb[1];

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == bombNumber)
    {
        int left = i - power;
        int right = i + power;
        if (left < 0)
        {
            left = 0;
        }
        if (right >= numbers.Count)
        {
            right = numbers.Count - 1;
        }
        int count = right - left + 1;
        numbers.RemoveRange(left, count);
        i = left - 1;
    }
}

int sum = numbers.Sum();
Console.WriteLine(sum);