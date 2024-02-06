using System.Text.RegularExpressions;

namespace _02._Destination_Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> validDestinations = new List<string>();
           string destinationa=Console.ReadLine();
            string pattern = @"(=|/)([A-Z][A-Za-z]{2,})\1";
            MatchCollection matches=Regex.Matches(destinationa, pattern);
            int points = 0;
            foreach (Match match in matches)
            {
                string validDestination = match.Groups[2].Value;
                points += validDestination.Length;
                validDestinations.Add(validDestination);
            }
            Console.WriteLine($"Destinations: {string.Join(", ",validDestinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}