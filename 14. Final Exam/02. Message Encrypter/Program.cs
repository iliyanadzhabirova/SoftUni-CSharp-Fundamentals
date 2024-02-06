using System.Text.RegularExpressions;

int n=int.Parse(Console.ReadLine());

for (int i=0; i<n; i++)
{
    string message=Console.ReadLine();

    string pattern = @"(@|\*)(?<tag>[A-Z][a-z]{2,})\1: (\[[A-Za-z]\]\|)(\[[A-Za-z]\]\|)(\[[A-Za-z]\]\|)$";
    Match match = Regex.Match(message, pattern);

    if (match.Success)
    {
        string tag = match.Groups["tag"].Value;
        string letterOne =match.Groups[2].Value;
        char first = ' ';

        for (int k = 0; k < letterOne.Length; k++)
        {
           if (k == 1)
            {
                first = (letterOne[k]);
                
            }
        }
        int firstN = (int)(first);
        string letterTwo= match.Groups[3].Value;
        char second = ' ';
        for (int m = 0; m < letterTwo.Length; m++)
        {
            if (m == 1)
            {
                second = letterTwo[m];
            }
        }
        int secondN = (int)(second);
        string letterThree = match.Groups[4].Value;
        char third = ' ';
        for (int p = 0; p < letterThree.Length; p++)
        {
            if (p == 1)
            {
                third = letterThree[p];
            }
        }
        int thirdN = (int)(third);

        Console.WriteLine($"{tag}: {firstN} {secondN} {thirdN}");
    }
    else
    {
        Console.WriteLine("Valid message not found!");
    }
}