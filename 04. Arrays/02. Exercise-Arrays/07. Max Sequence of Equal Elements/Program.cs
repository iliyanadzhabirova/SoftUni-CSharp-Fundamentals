// See https://aka.ms/new-console-template for more information
int[] array=Console.ReadLine().Split().Select(int.Parse).ToArray();

int longestSequenceStartIndex = 0;
int longestSequenceLength = 0;
for (int i = 1;i < array.Length; i++)
{
    int currentSequenceStartIndex = i-1;
    int currentSequenceLength = 1;
    while (i < array.Length && array[i] == array[i-1])
    {
        currentSequenceLength++;
        i++;
    }
    if (currentSequenceLength > longestSequenceLength)
    {
        longestSequenceLength = currentSequenceLength;
        longestSequenceStartIndex = currentSequenceStartIndex;  
    }
}
for (int i = longestSequenceStartIndex;i < longestSequenceStartIndex+longestSequenceLength; i++)
{
    Console.Write(array[i]+" ");
}
