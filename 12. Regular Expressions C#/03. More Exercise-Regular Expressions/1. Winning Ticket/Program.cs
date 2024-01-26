using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] tickets = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string pattern = @"(\@{6,}|\#{6,}|\${6,}|\^{6,})";
        Regex regex = new Regex(pattern);

        foreach (string ticket in tickets)
        {
            if (ticket.Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            Match leftMatch = regex.Match(ticket.Substring(0, 10));
            Match rightMatch = regex.Match(ticket.Substring(10));

            if (!leftMatch.Success || !rightMatch.Success)
            {
                Console.WriteLine("ticket \"" + ticket + "\" - no match");
                continue;
            }

            int matchLength = Math.Min(leftMatch.Value.Length, rightMatch.Value.Length);
            char matchSymbol = leftMatch.Value[0];

            if (matchLength == 10)
            {
                Console.WriteLine("ticket \"" + ticket + "\" - 10" + matchSymbol + " Jackpot!");
            }
            else
            {
                Console.WriteLine("ticket \"" + ticket + "\" - " + matchLength + matchSymbol);
            }
        }
    }
}