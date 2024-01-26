string[] bannedwords = Console.ReadLine().Split(", ");
string text =Console.ReadLine();

foreach (string bannedword in bannedwords)
{
    text = text = text.Replace(bannedword,new string('*', bannedword.Length));
}
Console.WriteLine(text);

