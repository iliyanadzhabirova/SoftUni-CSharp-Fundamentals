// See https://aka.ms/new-console-template for more information
int number=int.Parse(Console.ReadLine());
double maxValue = 0;
string bestModel = "";
for (int i = 0; i < number; i++)
{
    string model = Console.ReadLine();
    double radius=double.Parse(Console.ReadLine());
    int height=int.Parse(Console.ReadLine());
    double volume = Math.PI * Math.Pow(radius, 2) * height;
    if (volume>maxValue)
    {
        maxValue = volume;
        bestModel = model;
    }

}
Console.WriteLine(bestModel);