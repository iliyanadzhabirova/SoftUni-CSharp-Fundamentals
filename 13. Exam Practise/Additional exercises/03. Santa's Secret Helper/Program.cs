using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key=int.Parse(Console.ReadLine());
            List<string> goodClidren = new List<string>();
            string input =Console.ReadLine();
            while (input!="end")
            {
                string message = input;
                StringBuilder decodedMessage = new StringBuilder();
                foreach(char ch in message)
                {
                    char newChar = (char)(ch-key);
                    decodedMessage.Append(newChar);
                }
             
                string pattern =@"@(?<names>[A-Za-z]+)[^@\-!:>.]+!(?<behaviour>G|N)!";
                Match match = Regex.Match(decodedMessage.ToString(), pattern);
                string name = match.Groups["names"].Value;
                string behaviour = match.Groups["behaviour"].Value;
                if (behaviour == "G")
                {
                    goodClidren.Add(name);
                }
                input = Console.ReadLine();
            }
          foreach(string child in goodClidren)
            {
                Console.WriteLine(child);
            }
        }
    }
}
