// See https://aka.ms/new-console-template for more information
int power=int.Parse(Console.ReadLine());
int distance=int.Parse(Console.ReadLine());    
int exhaustionFactor=int.Parse(Console.ReadLine());
int targets = 0;
int poke = power;
while (poke >= distance)
{
   poke-=distance;
    targets++;
    if (poke ==(double)power*0.50 && exhaustionFactor!=0)
    {
            poke /= exhaustionFactor;
        
        
    }
}
Console.WriteLine(poke);
Console.WriteLine(targets);