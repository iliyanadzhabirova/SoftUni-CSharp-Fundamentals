string line = Console.ReadLine();
while (line!="end")
{

char [] reversedWord=line.Reverse().ToArray();


    Console.WriteLine($"{line} = {string.Join("",reversedWord)}");
    line = Console.ReadLine();
}
