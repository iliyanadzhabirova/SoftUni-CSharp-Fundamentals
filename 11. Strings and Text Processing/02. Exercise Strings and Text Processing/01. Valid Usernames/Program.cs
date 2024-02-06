string input = Console.ReadLine();
string[] names = input.Split(", ");

foreach (string name in names)
{
	if (usernameIsValid(name))
	{
		Console.WriteLine(name);
	}
}

bool usernameIsValid(string name)
{
    if (name.Length<3 || name.Length>16)
	{
		return false;
	}

	foreach (var character in name)
	{
		if (character!='_'&&character!='-'&& 
			((character<'a'||character>'z')&& 
			(character < 'A' || character > 'Z')&&
			(character<'0'||character>'9')))
		{
			return false;
		}
	}
	return true;	
}