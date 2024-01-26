using System.Text.RegularExpressions;

string phoneNumbers=Console.ReadLine();

Regex regex=new Regex(@"\+359( ||-)2\1\d{3}\1\d{4}\b");

MatchCollection matches=regex.Matches(phoneNumbers);

Console.WriteLine(string.Join(", ", matches));