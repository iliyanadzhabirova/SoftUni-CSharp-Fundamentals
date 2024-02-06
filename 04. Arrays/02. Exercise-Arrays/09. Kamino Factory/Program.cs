// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Metrics;

int dnaLength = int.Parse(Console.ReadLine());

int[] currentLongestSequence = new int[dnaLength];
int currentSequenceLength = 0;
int currentStartingIndex = 0;
int currentSum = 0;
int dnaNumber = 0;

int counter = 0;
while (true)
{
    counter++;  
    string input=Console.ReadLine();
    if (input=="Clone them!")
    {
        break;
    }
    int[] array=input.Split("!",StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    int length = 0;
    foreach (var item in array)
    {
        if (item==1)
        {
            length++;
        }
        else if(item==0 && length>0) 
        {
            break;
        }
    }
    int startingIndex = Array.IndexOf(array, 1);
    int sum = array.Sum();

    if (length>currentSequenceLength||length==currentSequenceLength&&currentStartingIndex>startingIndex
        ||length==currentStartingIndex && currentStartingIndex==startingIndex && sum>currentSum)
    {
        currentLongestSequence = array;
        currentSequenceLength=length;
        currentStartingIndex=startingIndex;
        currentSum= sum;
        dnaNumber= counter; 
    }
}
Console.WriteLine($"Best DNA sample {dnaNumber} with sum: {currentSum}.");
Console.WriteLine(string.Join(" ",currentLongestSequence));

