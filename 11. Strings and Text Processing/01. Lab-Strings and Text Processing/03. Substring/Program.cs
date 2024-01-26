string wordToRemove=Console.ReadLine();
string word=Console.ReadLine();

while (true)
{
    if (word.Contains(wordToRemove))
    {
       int index=word.IndexOf(wordToRemove);
        word=word.Remove(index,wordToRemove.Length);
    }
    else
    {
        break;
    }
}
Console.WriteLine(word);