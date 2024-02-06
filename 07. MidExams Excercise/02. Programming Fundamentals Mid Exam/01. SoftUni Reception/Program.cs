namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee=int.Parse(Console.ReadLine());
            int secondEmployee=int.Parse(Console.ReadLine());
            int thirdEmployee=int.Parse(Console.ReadLine());
            int students=int.Parse(Console.ReadLine());

            double totalStudentsPerHour=firstEmployee+secondEmployee+thirdEmployee;
            double neededHours =Math.Ceiling(students / totalStudentsPerHour);

            for (int i = 1; i <= neededHours; i++)
            {
                if (i%4==0)
                {
                    neededHours=neededHours + 1;
                }
            }
            Console.WriteLine($"Time needed: {neededHours}h.");
        }
    }
}