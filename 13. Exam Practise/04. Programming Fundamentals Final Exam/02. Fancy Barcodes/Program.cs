using System.Text;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string barCode= Console.ReadLine();

                string pattern = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(barCode);
                if (match.Success ) 
                {
                    StringBuilder group = new StringBuilder();
                    foreach (char ch in barCode)
                    {
                        if (char.IsDigit(ch))
                        {
                            int digit = (int)ch - 48;
                            group.Append(digit);
                        }
                                          
                    }
                    if (string.IsNullOrEmpty(group.ToString()))
                    {
                        group.Append("00");
                    }
                    Console.WriteLine($"Product group: {group}");

                }
                else    
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}