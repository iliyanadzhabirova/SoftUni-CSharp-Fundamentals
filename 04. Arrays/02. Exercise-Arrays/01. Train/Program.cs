// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());

int[]wagons=new int[n];
int sumOfPeople = 0;
for (int i = 0;i < wagons.Length; i++)
{
    int people=int.Parse(Console.ReadLine());
    wagons[i] = people;
    sumOfPeople += people;
}
Console.WriteLine(String.Join(" ",wagons));
Console.Write(sumOfPeople);