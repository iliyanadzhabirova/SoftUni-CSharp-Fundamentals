int number = int.Parse(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    string twoNumbers = Console.ReadLine();
    char delimiter = ' ';
    string[] splitNumbers = twoNumbers.Split(delimiter);

    long leftNum = long.Parse(splitNumbers[0]);
    long rightNum = long.Parse(splitNumbers[1]);

    long biggerNumber = rightNum;
    if (leftNum > rightNum)
    {
        biggerNumber = leftNum;
    }

    long sumOfDigits = 0;
    while (biggerNumber != 0)
    {
        sumOfDigits += biggerNumber % 10;
        biggerNumber /= 10;
    }
    Console.WriteLine(Math.Abs(sumOfDigits));
}