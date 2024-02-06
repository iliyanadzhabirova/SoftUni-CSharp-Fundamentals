using System.Text.RegularExpressions;

//string listOfNames = Console.ReadLine();

//string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

//Regex regex = new Regex(pattern);

//MatchCollection matches = regex.Matches(listOfNames);

//Console.WriteLine(string.Join(" ",matches));

using System.Text.RegularExpressions;

string listOfNames = Console.ReadLine();

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

MatchCollection matches = Regex.Matches(listOfNames,pattern);

Console.WriteLine(string.Join(" ", matches));