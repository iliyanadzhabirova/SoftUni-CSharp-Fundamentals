string[] words = Console.ReadLine().Split();

foreach (string word in words)
{
    for (int i = 0; i < word.Length; i++)
    {
        Console.Write(word);
    }
}