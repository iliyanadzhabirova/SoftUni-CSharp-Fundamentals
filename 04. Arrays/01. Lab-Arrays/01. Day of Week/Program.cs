// See https://aka.ms/new-console-template for more information

string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int intDaysOfWeek = int.Parse(Console.ReadLine());
if (intDaysOfWeek >= 1 && intDaysOfWeek <= 7)
{
    Console.WriteLine(daysOfWeek[intDaysOfWeek-1]);
}
else
{
    Console.WriteLine("Invalid day!");
}