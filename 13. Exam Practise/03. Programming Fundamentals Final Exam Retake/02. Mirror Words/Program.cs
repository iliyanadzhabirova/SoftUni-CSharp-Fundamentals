using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> validPairs = new List<string>();
            string input=Console.ReadLine();
            string pattern = @"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            MatchCollection matches =Regex.Matches(input, pattern);

            if (matches.Count==0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value;
                string secondWord = match.Groups[3].Value;
                string reversedWord = new string(secondWord.Reverse().ToArray());

                if (firstWord==reversedWord)
                {
                    validPairs.Add($"{firstWord} <=> {secondWord}");
                }
            }
            if (validPairs.Count==0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ",validPairs));
            }
        }
    }
}