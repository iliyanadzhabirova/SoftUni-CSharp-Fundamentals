using System.Text;
using System.Text.RegularExpressions;

List<string> attackedPlanets = new List<string>();
List<string> destroyedPlanets = new List<string>();
int n=int.Parse(Console.ReadLine());
string pattern =@"\@(?<planetName>[A-Za-z]+)[^\@\-\!\:\>]*?\:\d+[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>\d+";
Regex regex = new Regex(pattern);   
 for (int i=0; i<n; i++)
{
    string encryptedMessage=Console.ReadLine();
    string decryptedMessage=DecryptMessage(encryptedMessage);
    Match match=regex.Match(decryptedMessage);
    if (match.Success)
    {
        string planetName = match.Groups["planetName"].Value;
        string attackType = match.Groups["attackType"].Value;
        if (attackType == "A")
        {
            attackedPlanets.Add(planetName);
        }
        else if (attackType == "D") 
        { 
            destroyedPlanets.Add(planetName);
        }
    }
}
PrintPlanets(attackedPlanets, "Attacked");
PrintPlanets(destroyedPlanets, "Destroyed");
static string DecryptMessage(string encryptedMessage) 
{ 

    StringBuilder decryptedMessage = new StringBuilder();   
    int decryptionStep = GetDecryptionStep(encryptedMessage);

    foreach (char oldCh in encryptedMessage)
    {
        decryptedMessage.Append((char)(oldCh-decryptionStep));
    }
   return decryptedMessage.ToString();
}
static int GetDecryptionStep(string encryptedMessage)
{
    int decryptionStep = 0;

    foreach (char ch in encryptedMessage.ToLower())
    {
        if (ch =='s'||ch=='t'||ch=='a'||ch=='r')
        {
            decryptionStep++;
        }
    }
    return decryptionStep;
}

static void PrintPlanets(List<string>planets,string attackType)
{
    Console.WriteLine($"{attackType} planets: {planets.Count}");
    foreach (string planetName in planets.OrderBy(p=>p))
    {
        Console.WriteLine($"-> {planetName}");
    }
}