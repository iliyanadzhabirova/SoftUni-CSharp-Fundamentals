string[] key = Console.ReadLine().Split(' ');
int[] keySequence = new int[key.Length];
for (int i = 0; i < key.Length; i++)
{
    keySequence[i] = int.Parse(key[i]);
}

string input;
while ((input = Console.ReadLine()) != "find")
{
    string decrypted = "";
    for (int i = 0; i < input.Length; i++)
    {
        int keyIndex = i % keySequence.Length;
        int decryptedChar = (int)input[i] - keySequence[keyIndex];
        decrypted += (char)decryptedChar;
    }

    int typeStart = decrypted.IndexOf('&') + 1;
    int typeEnd = decrypted.IndexOf('&', typeStart);
    string type = decrypted.Substring(typeStart, typeEnd - typeStart);

    int coordStart = decrypted.IndexOf('<') + 1;
    int coordEnd = decrypted.IndexOf('>', coordStart);
    string coordinates = decrypted.Substring(coordStart, coordEnd - coordStart);

    Console.WriteLine($"Found {type} at {coordinates}");
}