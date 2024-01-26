// See https://aka.ms/new-console-template for more information
int capacity = 255;
int number=int.Parse(Console.ReadLine());
int totalLiters = 0;
for (int i = 0; i < number; i++)
{
    int sipOfWater=int.Parse(Console.ReadLine());
    
    totalLiters += sipOfWater;
    if (totalLiters>capacity)
    {
        Console.WriteLine("Insufficient capacity!");
        totalLiters -= sipOfWater;
    }
}
Console.WriteLine(totalLiters);