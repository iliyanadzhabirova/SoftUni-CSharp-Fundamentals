string text = Console.ReadLine();

char[] encryptedText = new char[text.Length];

for (int i = 0; i < text.Length; i++)
{
    encryptedText[i] = (char)(text[i]+3);
}
Console.WriteLine(string.Join("",encryptedText));
